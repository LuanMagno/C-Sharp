using System;

namespace IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            float TempC;
            float TempF;
            
            
            Console.WriteLine("Digite a temperatura em C°: ");
            TempC = float.Parse(Console.ReadLine());
            TempF = TempC * 1.8 + 32;
            Console.WriteLine("A temperatura em Fahreheit é : " + TempF);
        }
    }
}
