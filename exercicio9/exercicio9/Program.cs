using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Entrada dos dados
            Console.Write("Digite o peso (em kg): ");
            double peso = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a altura (em metros): ");
            double altura = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o sexo (M para masculino, F para feminino): ");
            char sexo = Char.ToUpper(Console.ReadLine()[0]);

            // Cálculo da relação peso/altura² (IMC)
            double R = peso / (altura * altura);

            // Exibir a mensagem correspondente
            if (sexo == 'F')
            {
                if (R < 19)
                    Console.WriteLine("Abaixo do peso");
                else if (R >= 19 && R < 24)
                    Console.WriteLine("Peso ideal");
                else
                    Console.WriteLine("Acima do peso");
            }
            else if (sexo == 'M')
            {
                if (R < 20)
                    Console.WriteLine("Abaixo do peso");
                else if (R >= 20 && R < 25)
                    Console.WriteLine("Peso ideal");
                else
                    Console.WriteLine("Acima do peso");
            }
            else
            {
                Console.WriteLine("Sexo inválido.");
            }
            Console.ReadKey();
        }
    }
}
