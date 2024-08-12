using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double baseRet, alturaRet, areaRet;

            Console.WriteLine("Digite o valor da base do retângulo: ");
            baseRet = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da altura do retângulo: ");
            alturaRet = double.Parse(Console.ReadLine());

            areaRet = baseRet * alturaRet;

            if (areaRet > 100)
            {
                Console.WriteLine("Terreno grande pois o valor da área é: " + areaRet);
            }
            else
            {
                Console.WriteLine("Terreno pequeno pois o valor da área é: " + areaRet);
            }
            Console.ReadKey();
        }
    }
}
