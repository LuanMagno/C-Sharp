using System;

namespace ImprimirNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Digite um número entre 0 e 4: ");
            numero = int.Parse(Console.ReadLine());
            if (numero == 0)
            {
                Console.WriteLine("Zero");
            }
            else if (numero == 1)
            {
                Console.WriteLine("Um");
            }
            else if (numero == 2)
            {
                Console.WriteLine("Dois");
            }
            else if (numero == 3)
            {
                Console.WriteLine("Três");
            }
            else if (numero == 4)
            {
                Console.WriteLine("Quatro");
            }
            else
                Console.WriteLine("Insira um valor válido");
            Console.ReadLine();
        }
    }
}
