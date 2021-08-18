using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10___CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 10 - Calcula Poupança");

            double valinvestido = 1000.00;

            int cont = 0;
            while (cont <= 12)
            {
                valinvestido = valinvestido + valinvestido * 0.0036;
                Console.WriteLine("Apos " + cont + " meses Mês o Rendimento será de R$" + valinvestido) ;
                cont++;
            }

            // 0.36% = 0.0036

            valinvestido = valinvestido + valinvestido * 0.0036;

            Console.WriteLine("Apos um Mês o Rendimento será de R$" + valinvestido);

            valinvestido = valinvestido + valinvestido * 0.0036;

            Console.WriteLine("Apos dois Mês o Rendimento será de R$" + valinvestido);

         

          

            Console.ReadLine();
        }
    }
}
