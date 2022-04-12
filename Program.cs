
Console.WriteLine("Qual o seu nome?");
string nome = Console.ReadLine();

Console.WriteLine("Qual a sua altura em metros? Ex.: 1,65");
double altura = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Qual o seu peso em kg? Ex.: 70,3");
double peso = Convert.ToDouble(Console.ReadLine());

Individuo i1 = new Individuo(nome, altura, peso);

Console.WriteLine("{0}, sua altura é {1}m e seu peso, {2}kg.", nome, altura, peso);
Console.WriteLine("Então, seu IMC é {0}", i1.Imc);



Console.WriteLine("Você está " + i1.FaixaPeso());
Console.WriteLine("Você " + i1.Situacao());
