using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Entrada da nota P1
            Console.Write("Digite a nota da P1: ");
            double P1 = Convert.ToDouble(Console.ReadLine());

            // Cálculo da nota necessária em P2 para ser aprovado
            double P2 = (15 - P1) / 2;

            // Exibição do resultado
            if (P2 > 10)
            {
                Console.WriteLine("Com a nota da P1, não é possível atingir a média de aprovação.");
            }
            else
            {
                Console.WriteLine($"Para ser aprovado, você precisa tirar {P2:F2} na P2.");
            }
            Console.ReadKey();
        }
    }
}
