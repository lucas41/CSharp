using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13___For_encadeado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 13");

            for (int contlinha = 0; contlinha < 10; contlinha++)
            {
                for (int contcoluna = 0; contcoluna < 10; contcoluna++)
                {
                    Console.Write("*");
                    if (contcoluna >= contlinha)
                    {
                        break;
                    }
                }
                Console.WriteLine();
            }
            


            Console.ReadLine();
        }
    }
}
