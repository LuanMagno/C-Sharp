using System;

namespace IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            double PerimetroC;
            double AreaC;
            double RaioC;


            Console.WriteLine("Digite o raio do círculo: ");
            RaioC = double.Parse(Console.ReadLine());
            AreaC = Math.PI * Math.Pow(RaioC, 2);
            PerimetroC = 2 * Math.PI * RaioC;
            Console.WriteLine("A área do círculo é : " + AreaC);
            Console.WriteLine("O perímetro do círculo é :" + PerimetroC);
        }
    }
}
