using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___capturando_dados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("escreva seu nome");


            // para capturar um dado do usuario colocamos a variavel a frente depois = e executamos um Readline

            String nome = Console.ReadLine();


            Console.WriteLine("Seu nome é " + nome);

            Console.ReadLine();
        }
    }
}
