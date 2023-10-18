using System;

namespace TrocaVariavel
{
    class Program
    {
        static void Main(string[] args)
        {
            int DiasT, ValorF;
            Console.WriteLine("Quantos dias foram trabalhados: ");
            DiasT = (int.Parse(Console.ReadLine()));
            ValorF = (DiasT * 30);
            ValorF = (ValorF * 92) / 100;
            Console.WriteLine("O valor a ser recebido é R$" + ValorF);
        }
    }
}
