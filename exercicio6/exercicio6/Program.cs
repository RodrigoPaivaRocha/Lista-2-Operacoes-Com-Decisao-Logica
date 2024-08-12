using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double altura, peso, relacao;

            Console.WriteLine("Digite sua altura: ");
            altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite seu peso: ");
            peso = double.Parse(Console.ReadLine());

            relacao = peso / (altura * altura);

            if (relacao < 20)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else if (relacao >= 20 && relacao < 25)
            {
                Console.WriteLine("Peso ideal");
            }
            else
            {
                Console.WriteLine("Acima do peso");
            }  
            
            Console.ReadKey();
        }
    }
}
