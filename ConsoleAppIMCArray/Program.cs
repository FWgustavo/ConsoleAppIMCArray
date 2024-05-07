using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppIMCArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nome = new string[5];
            double[] altura = new double[5];
            double[] peso = new double[5];
            double[] imc = new double[5];
            double cont = 0;

            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine("Insira o nome: ");
                nome[i] = Console.ReadLine();

                Console.WriteLine("Insira a altura: ");
                altura[i] = double.Parse(Console.ReadLine());

                Console.WriteLine("Insira o peso em kg: ");
                peso[i] = double.Parse(Console.ReadLine());

                imc[i] = peso[i] / (altura[i] * altura[i]);
                Console.Clear();
            }
            Console.Clear();
            for (int j = 0; j <= 4; j++)
            {
                Console.WriteLine("Nome: "+nome[j]);
                Console.WriteLine("Altura: " + altura[j]);
                Console.WriteLine("Peso: " + peso[j]);

                if (imc[j] <= 16.9)
                {
                    Console.WriteLine("Você está muito abaixo do peso " + imc[j]);
                }
                else if (imc[j] <= 18.4)
                {
                    Console.WriteLine("Você está abaixo do peso " + imc[j]);
                }
                else if (imc[j] <= 24.9)
                {
                    Console.WriteLine("Seu peso está normal " + imc[j]);
                }
                else if (imc[j] <= 29.9)
                {
                    Console.WriteLine("Você está acima do peso " + imc[j]);
                    cont++;
                }
                else if (imc[j] <= 34.9)
                {
                    Console.WriteLine("Obesidade Grau 1 " + imc[j]);
                    cont++;
                }
                else if (imc[j] <= 40)
                {
                    Console.WriteLine("Obesidade Grau 2 " + imc[j]);
                    cont++;
                }
                else if (imc[j] > 40)
                {
                    Console.WriteLine("Obesidade Grau 3 " + imc[j]);
                    cont++;
                }
            }
            Console.WriteLine("" + cont * 20 + " % pessoas estão acima do peso ideal");
            Console.ReadKey();
        }
    }
}
