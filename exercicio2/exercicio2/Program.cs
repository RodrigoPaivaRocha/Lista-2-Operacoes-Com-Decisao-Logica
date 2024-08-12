using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, n2;

            Console.WriteLine("Digite um número: ");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número: ");
            n2 = double.Parse(Console.ReadLine());

            if (n1 == n2)
            {
                Console.WriteLine("Os números são idênticos");
            }
            else if (n1 > n2)
            {
                Console.WriteLine("O primeiro número é maior que o segundo");
            }
            else
            {
                Console.WriteLine("O segundo número é maior que o primeiro");
            }
            Console.ReadKey();
        }
    }
}
