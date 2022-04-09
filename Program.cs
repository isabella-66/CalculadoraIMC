using System;

namespace CalculadoraIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o seu nome?");
            string Nome = Console.ReadLine();

            Console.WriteLine("Qual a sua altura em metros? Ex.: 1,65");
            double Altura = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Qual o seu peso em kg? Ex.: 70,3");
            double Peso = Convert.ToSingle(Console.ReadLine());

            double Imc = Math.Round(Peso / (Altura * Altura), 2);

            Console.WriteLine("{0}, sua altura é {1}m e seu peso, {2}kg.", Nome, Altura, Peso);
            Console.WriteLine("Então, seu IMC é {0}", Imc);

            Individuo i1 = new Individuo(Nome, Altura, Peso);

            Console.WriteLine("Você está " + i1.FaixaPeso());
            Console.WriteLine("Você " + i1.Situacao());
        }
    }
}
