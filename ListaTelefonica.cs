using System;

namespace ListaTelefonica
{
    class Program
    {
        static void Main(string[] args)
        {
            const int  Arthur = 3221 - 0021;
            const int Bernado = 3211 - 3433;
            const int Caio = 3311 - 4567;
            const int Luiz = 9905 - 0098;
            string Nome;
            Console.WriteLine("Insira o nome a ser consultado: ");
            Nome = Console.ReadLine();
            switch (Nome)
            {
                case "Arthur":
                    Console.WriteLine(Nome + ": " + Arthur);
                    break;
                case "Bernado":
                    Console.WriteLine(Nome + ": " + Bernado);
                    break;
                case "Caio":
                    Console.WriteLine(Nome + ": " + Caio);
                    break;
                case "Luiz":
                    Console.WriteLine(Nome + ": " + Luiz);
                    break;
                default:
                    Console.WriteLine("Digite um nome válido!");
                    break;
            }
        }
    }
}
