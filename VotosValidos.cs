using System;

namespace Eleitores
{
    class Program
    {
        static void Main(string[] args)
        {
            int Eleitores, brancos, nulos, validos;
            Console.WriteLine("Insira a quantidade de eleitores no município: ");
            Eleitores = (int.Parse(Console.ReadLine()));
            Console.WriteLine("Quantos votaram branco: ");
            brancos = (int.Parse(Console.ReadLine()));
            Console.WriteLine("Quantos votaram nulo: ");
            nulos = (int.Parse(Console.ReadLine()));
            Console.WriteLine("Quantos votos são válidos: ");
            validos = (int.Parse(Console.ReadLine()));
            validos = (validos * 100) / Eleitores;
            brancos = (brancos * 100) / validos;
            nulos = (nulos * validos) / validos;
            Console.WriteLine("O percentual de votos brancos é de " + brancos + ", de votos nulo é de " + nulos + ", e de votos válidos é de " + validos);
        }
    }
}
