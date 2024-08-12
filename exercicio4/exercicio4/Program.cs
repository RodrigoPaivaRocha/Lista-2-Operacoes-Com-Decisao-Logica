using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double baseRet, alturaRet, areaRet;

            Console.WriteLine("Digite a base do retângulo: ");
            baseRet = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a base do retângulo: ");
            alturaRet = double.Parse(Console.ReadLine());

            areaRet = baseRet * alturaRet;

            if (areaRet > 100)
            {
                Console.WriteLine("Terreno grande");
            }
            else
            {
                Console.WriteLine("O valor da área é: " + areaRet);
            }
            Console.ReadKey();
        }
    }
}
