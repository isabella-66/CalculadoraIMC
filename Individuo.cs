public class Individuo
{
    public string Nome { get; set; }
    public double Altura { get; set; }
    public double Peso { get; set; }
    public double Imc { get => Peso / (Altura * Altura); }

    public Individuo (string nome, double altura, double _peso)
    {
        Nome = nome;
        Altura = altura;
        Peso = _peso;
    }
    
    public string FaixaPeso() 
    {
        if (Imc < 17.00)
        {
            return "muito abaixo do peso.";
        } 
        else if (Imc >= 17.00 && Imc < 18.50)
        {
            return "abaixo do peso.";
        }
        else if (Imc >= 18.50 && Imc < 25.00)
        {
            return "peso normal.";
        }
        else if (Imc >= 25.00 && Imc < 30.00)
        {
            return "acima do peso.";
        }
        else if (Imc >= 30.00 && Imc < 35.00)
        {
            return "Obesidade I.";
        }
        else if (Imc >= 35.00 && Imc < 40.00)
        {
            return "Obesidade II (severa).";
        }
        else 
        {
            return "Obesidade III (mórbida).";
        }
    }

    public string Situacao()
    {
        double aux = 0.00;
        double peso = 0.00;

        if (Imc < 18.5) 
        {
            peso = 18.5 * Altura * Altura;
            aux = peso - Peso;
            return $"precisa ganhar {aux}kg";
        }
        else if (Imc > 24.99)
        {
            peso = 24.99 * Altura * Altura;
            aux = Peso - peso;
            return $"precisa perder {aux}kg";
        }
    }
}