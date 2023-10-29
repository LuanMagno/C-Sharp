using System;

namespace DivisivelPor3e6
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb;
            Console.WriteLine("Digite um número: ");
            numb = int.Parse(Console.ReadLine());
            if(numb%3 == 0 & numb%6==0) {
                Console.WriteLine(numb + " é divisível por 3 e por 6");  
            }
            else
            {
                Console.WriteLine("Não é divisível por 3 e por 6 simultaneamente");
            }
        }
    }
}
