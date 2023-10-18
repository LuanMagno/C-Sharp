using System;

namespace EnergiaGasta
{
    class Program
    {
        static void Main(string[] args)
        {
            int ValorInt,Centena,Dezena,Unidade;
            Console.WriteLine("Insira um valor inteiro de 3 dígitos");
            ValorInt = (int.Parse(Console.ReadLine()));
            Unidade = ValorInt % 10;
            Dezena = ((ValorInt % 100)-Unidade)/10;
            Centena = ((ValorInt % 1000) - Unidade - Dezena)/100;
            Console.WriteLine(Unidade+Dezena+Centena);
        }
    }
}
