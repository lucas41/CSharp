using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12___CalculaInvestimentoLongoPrazo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executanto o projeto 12");

            double valinvestido = 1000.00;
            double fatorrendimento = 1.0036;

            for (int contano = 1; contano <=5; contano++)
            {
                for (int contmes = 1; contmes <= 12; contmes++)
                {
                    valinvestido *= fatorrendimento;
                }

                fatorrendimento += 0.0010;
            }
         
          Console.WriteLine("Ao termino do investimento você tera R$: " + valinvestido);

            Console.ReadLine();
        }
    }
}
