using System;

namespace PESSOA_MAIS_VELHA_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PESSOA p1 = new PESSOA();
            PESSOA p2 = new PESSOA();

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Nome: ");
            p2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p2.Idade = int.Parse(Console.ReadLine());

            if (p1.Idade > p2.Idade)
            {
                Console.WriteLine($"Pessoa mais velha é {p1.Nome}");
            }
            else
            {
                Console.WriteLine($"Pessoa mais velha é {p2.Nome}");
            }

        }
    }
}
