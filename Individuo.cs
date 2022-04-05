public class Individuo
{
    public string Nome { get; set; }
    public float Altura { get; set; }
    public float Peso { get; set; }
    public float Imc { get => Peso / (Altura * Altura); }
    
    
}