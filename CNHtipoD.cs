using System;

namespace CNHtipoD
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, tempocarteira;
            char tipoCNH;
            Console.WriteLine("Insira sua idade: ");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira sua carteira(B ou C): ");
            tipoCNH = char.Parse(Console.ReadLine());
            Console.WriteLine("A quantos anos você tem a carteira: ");
            tempocarteira = int.Parse(Console.ReadLine());
            if(idade>=21 & (tipoCNH == 'B' & tempocarteira>=2 || tipoCNH =='C' & tempocarteira>=1)) {
                Console.WriteLine("Você está apto a tirar carteira do tipo D");
            }
            else if(idade < 21 & (tipoCNH == 'B' & tempocarteira >= 2 || tipoCNH == 'C' & tempocarteira >= 1))
            {
                Console.WriteLine("Você possui o tempo de carteira necessário mas não possui a idade");
            }
            else if(idade >= 21 & (tipoCNH == 'B' & tempocarteira < 2 || tipoCNH == 'C' & tempocarteira < 1))
            {
                Console.WriteLine("Você possui a idade necessária mas não atende ao tempo de carteira necessário");
            }
            else
            {
                Console.WriteLine("Você não atende a nenhum dos requisitos");
            }
            Console.ReadLine();


        }
    }
}
