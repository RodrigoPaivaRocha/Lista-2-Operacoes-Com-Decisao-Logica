using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, maior = 0;

            Console.WriteLine("Digite o primeiro número: ");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro número: ");
            n3 = double.Parse(Console.ReadLine());

            if (n1 > n2)
            {
                maior = n1;
            }
            else
            {
                maior = n2;
            }
            if (n3 > maior)
            {
                maior = n3;
            }
            Console.WriteLine("O(s) maior(es) número(s) é(são): " + maior);

            Console.ReadKey();
        }
    }
}
