using System;

namespace FparaC
{
    class Program
    {
        static void Main(string[] args)
        {
            double TempF;
            double TempC;
            Console.WriteLine("Digite a temperatura em F°: ");
            TempF = double.Parse(Console.ReadLine());
            TempC = 5.0 * ((TempF - 32.0) / 9.0);
            Console.WriteLine("A temperatura em C° é: " + TempC);
        }
    }
}
