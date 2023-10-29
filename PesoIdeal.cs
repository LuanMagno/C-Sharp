using System;

namespace PesoIdeal
{
    class Program
    {
        static void Main(string[] args)
        {
            char sexo;
            double altura, peso;
            Console.WriteLine("Insira sua altura: ");
            altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira seu sexo biológico(M/F): ");
            sexo = char.Parse(Console.ReadLine());
            peso = (sexo == 'M') ? (72.7 * altura) - 58 :(62.1 * altura) - 44.7;
            Console.WriteLine($"Seu peso ideal é {peso}");
        }
    }
}