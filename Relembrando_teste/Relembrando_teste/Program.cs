using System;

namespace Relembrando_teste
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, idade, cidade;
            Console.WriteLine("Oi pessoa! Hoje estamos aqui pra pegar alguns dados seus, beleza? \n");
            Console.WriteLine("Me diz aí, como você chama? ");
            nome = Console.ReadLine();
            Console.WriteLine("\nE quantos anos você tem? ");
            idade = Console.ReadLine();
            Console.WriteLine("\nTá acabando já, só preciso saber agora onde você mora?");
            cidade = Console.ReadLine();
            Console.WriteLine("\nConfere aí pra mim meu parceiro... \nNome: " + nome + "\nIdade: " + idade + "\nCidade: " + cidade);
            Console.ReadLine();
            Console.WriteLine("\nÉ só isso mesmo, se tiver tudo certinho a gente finaliza por aqui. Até mais!");
            Console.ReadLine();
        }
    }
}
