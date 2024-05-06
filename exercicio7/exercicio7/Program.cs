using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;

            Console.WriteLine("Digite o valor do lado 1: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do lado 2: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do lado 3: ");
            c = int.Parse(Console.ReadLine());

            if (a + b > c && a + c > b && b + c > a)
                if (a == b && a == c)
                    Console.WriteLine("Equilátero");
                else
                    if (a == b || a == c || b == c)
                    Console.WriteLine("Isósceles");
                else
                    Console.WriteLine("Escaleno");
            else
                Console.WriteLine("Não forma triângulo");

            Console.ReadKey();
        }
    }
}
