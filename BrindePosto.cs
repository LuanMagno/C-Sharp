using System;

namespace PostoGasolina
{
    class Program
    {
        static void Main(string[] args)
        {
            double litros;
            string brinde;
            Console.WriteLine("Quantos litros foram colocados: ");
            litros = double.Parse(Console.ReadLine());
            brinde = (litros < 10) ? "chaveiro" : "ducha";
            Console.WriteLine("Seu brinde é: " + brinde);
        }
    }
}