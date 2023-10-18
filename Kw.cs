using System;

namespace Killowatt
{
    class Program
    {
        static void Main(string[] args)
        {
            double SalarioM, Kilowatt, ValorKw, Vt;
            Console.WriteLine("Escreva o valor do salário mínimo: ");
            SalarioM = double.Parse(Console.ReadLine());
            Console.WriteLine("Escreva a quantidade do kilowatt gasto: ");
            Kilowatt = double.Parse(Console.ReadLine());
            ValorKw = 0.001 * SalarioM;
            Vt = ValorKw * Kilowatt;   
            Console.WriteLine("O valor de cada Kw é R$" + ValorKw + ", e o valor total é de R$" + Vt);  
        }
    }
}
