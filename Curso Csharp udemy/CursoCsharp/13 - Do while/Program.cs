using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13___Do_while
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // do while faça enquanto condição ao final 

            int contador = 4;
            // mesma a condiçãi sendo falta sera executado uma vez 

            do
            {
                Console.WriteLine("contador na posição " + contador);
                contador++;
            } while (contador < 3);

            Console.ReadLine();
        }
    }
}
