using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicita três valores ao usuário
            Console.WriteLine("Digite o valor de A:");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de B:");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de C:");
            double c = double.Parse(Console.ReadLine());

            // Verifica se os valores fornecidos podem formar um triângulo retângulo
            if (EhTrianguloRetangulo(a, b, c))
            {
                Console.WriteLine("Os valores formam um triângulo retângulo.");
            }
            else
            {
                Console.WriteLine("Os valores não formam um triângulo retângulo.");
            }
        }

        static bool EhTrianguloRetangulo(double x, double y, double z)
        {
            // Ordena os lados de forma que o maior valor seja considerado como a hipotenusa
            double[] lados = { x, y, z };
            Array.Sort(lados);

            double cateto1 = lados[0];
            double cateto2 = lados[1];
            double hipotenusa = lados[2];

            // Verifica a condição do teorema de Pitágoras
            return Math.Abs((cateto1 * cateto1) + (cateto2 * cateto2) - (hipotenusa * hipotenusa)) < 1e-10;
        }
    }
}
