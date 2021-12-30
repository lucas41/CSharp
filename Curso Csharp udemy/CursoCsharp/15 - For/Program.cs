using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15___For
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // For significa PARA

            string[] nomes = { "lucas", "joão", "evely", "victor" };


            for (int contador = 0; contador < nomes.Length; contador++) // todo o bloco de comando fica de forma enxuta 
                // se lé variavel contador recebe o valor zero enquanto o valor for menor que 10 execute e ao fim adicione + 1 a contador
            {
                Console.WriteLine("contador na posição " + contador);
            }

            for (int contador = 0; contador < 10; contador++) { 
                Console.WriteLine(nomes[contador]);
            }

                Console.ReadLine();
        }
    }
}
