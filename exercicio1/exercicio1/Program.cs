using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio1
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

            if (n1 > n2)
            {
                Console.WriteLine("O número " + n1 + " é maior");
            }
            else
            {
                Console.WriteLine("O número " + n2 + " é maior");
            }
            Console.ReadKey();
        }
    }
}
