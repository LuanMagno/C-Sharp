using System;

namespace RestauranteGorjetaePagamento
{
    class Program
    {
        static void Main(string[] args)
        {
            double ValorGasto, Gorjeta,ValorF;
            Console.WriteLine("Insira o valor gasto com as despesas do restaurante: ");
            ValorGasto = (double.Parse(Console.ReadLine()));
            Console.WriteLine("Insira o percentual da gorjeta: ");
            Gorjeta = (double.Parse(Console.ReadLine()));
            Gorjeta = (Gorjeta * ValorGasto) / 100;
            ValorF = ValorGasto + Gorjeta;
            Console.WriteLine("O valor da gorjeta será de " + Gorjeta + ", e o valor final será de " + ValorF);
        }
    }
}
