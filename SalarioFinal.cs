using System;

namespace SalarioBase
{
    class Program
    {
        static void Main(string[] args)
        {
            double Salario,SalarioG,SalarioI;
            Console.WriteLine("Insira o salário base: ");
            Salario = double.Parse(Console.ReadLine());
            SalarioG = Salario * 1.05;
            SalarioI = Salario * 0.07;
            Salario = SalarioG - SalarioI;
            Console.WriteLine("O salário final será de R$" + Salario);
            Console.WriteLine();
        }
    }
}
