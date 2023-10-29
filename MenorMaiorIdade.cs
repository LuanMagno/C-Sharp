using System;

namespace MenorIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade1, idade2, idade3,menorId,maiorId;
            Console.WriteLine("Insira a primeira idade: ");
            idade1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira a segunda idade: ");
            idade2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira a terceira idade: ");
            idade3 = int.Parse(Console.ReadLine());
            if (idade1 >= idade2 & idade1 >= idade3)
            {
                maiorId = idade1;
            }
            else if (idade2 >= idade1 & idade2 >= idade3){
                maiorId = idade2;
            }
            else
            {
                maiorId = idade3;

            }
            if (idade1 <= idade2 & idade1 <= idade3)
            {
                menorId= idade1;
            }
            else if (idade2 <= idade1 & idade2 <= idade3)
            {
                menorId = idade2;
            }
            else
            {
                menorId = idade3;

            }
            Console.WriteLine("A maior idade é:" + maiorId + "\nA menor idade é:" + menorId);

        }
    }
}
