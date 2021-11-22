using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12___while
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // while = enquanto 


            /*while ( 1 < 2) // enquanto x for verdade execute o bloco de codigo
            {
                Console.WriteLine("loop infinito hehe");
                Console.WriteLine("Desta forma o computador sempre ira executar esse codigo infinitamente pos a condição sempre e verdadeira");
            }
            */


            // forma correta de ser feito 


            int contador = 1;

            while (contador <= 10)
            {
                Console.WriteLine(" executando na posição " + contador);
                contador++;
            }

            Console.ReadLine();
        }
    }
}
