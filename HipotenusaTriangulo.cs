using System;

namespace TrianguloRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            float Cateto1;
            float Cateto2;
            double Hipotenusa;
            
            Console.WriteLine("Insira o primeiro cateto do triângulo:");
            Cateto1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Insira o segundo cateto do triângulo:");
            Cateto2 = float.Parse(Console.ReadLine());
            Hipotenusa = Math.Pow(Cateto1, 2) + Math.Pow(Cateto2, 2);
            Hipotenusa = Math.Sqrt(Hipotenusa);
            Console.WriteLine("A hipotenusa é: " + Hipotenusa);
        }
    }
}
