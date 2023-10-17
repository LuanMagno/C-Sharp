using System;

namespace IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            double TempC;
            double TempF;


            Console.WriteLine("Digite a temperatura em C°: ");
            TempC = double.Parse(Console.ReadLine());
            TempF = TempC * (9.0/5) + 32;
            Console.WriteLine("A temperatura em Fahreheit é : " + TempF);
        }
    }
}
