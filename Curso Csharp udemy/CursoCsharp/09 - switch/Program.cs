using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09___switch
{
    internal class Program
    {
        static void Main(string[] args)
        {

            String cor = "verde";

            // switch apenas faz operação de igualdade
            switch (cor)
            {
                case "azul":
                    Console.WriteLine("sua cor favorita e azul");
                    break;
                case "vermelho":
                    Console.WriteLine("sua cor favorita e vermelho");
                    break;

                default:
                    Console.WriteLine("problema ao executar!");
                    break ;
            }

            Console.ReadLine();
        }
    }
}
