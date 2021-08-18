using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11___CalculaPoupanca2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 11");

            int cont = 1;
            double valinvestido = 1000.00;

            for (cont = 1; cont <=12; cont++)
            {
                valinvestido = valinvestido + valinvestido * 0.0036;
                Console.WriteLine("Apos " + cont + " meses Mês o Rendimento será de R$" + valinvestido);
            }


            Console.ReadLine();
        }
    }
}
