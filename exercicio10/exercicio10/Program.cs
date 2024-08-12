using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Entrada das notas
            Console.Write("Digite a nota da P1: ");
            double P1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a nota da P2: ");
            double P2 = Convert.ToDouble(Console.ReadLine());

            // Cálculo da média
            double media = (P1 + 2 * P2) / 3;

            // Exibição da situação final do aluno
            if (media >= 5)
            {
                Console.WriteLine($"Média: {media:F2}");
                Console.WriteLine("Situação: Aprovado");
            }
            else
            {
                Console.WriteLine($"Média: {media:F2}");
                Console.WriteLine("Situação: Reprovado");
            }
            Console.ReadKey();
        }
    }
}
