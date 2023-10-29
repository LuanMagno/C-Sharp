using System;

namespace CalculadoraSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            int operacao;
            double num1, num2, result;
            Console.WriteLine("1-Soma");
            Console.WriteLine("2-Subtração");
            Console.WriteLine("3-Multiplicação");
            Console.WriteLine("4-Divisão");
            operacao = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o primeiro número: ");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            num2 = double.Parse(Console.ReadLine());
            switch (operacao)
            {
                case 1: result = num1 + num2;
                    Console.WriteLine(result);
                    break;
                case 2: result = num1 - num2;
                    Console.WriteLine(result);
                    break;
                case 3: result = num1 * num2;
                    Console.WriteLine(result);
                    break;
                case 4:
                    if (num2 == 0){
                        Console.WriteLine("Error!");
                    }
                    else
                    {
                        result = num1 / num2;
                        Console.WriteLine(result);
                    }
                    break;
                default: Console.WriteLine("Insira uma operação válida!");
                    break;
            }

        }
    }
}
