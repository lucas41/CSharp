using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14___Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // foreach serve para passar um array 
            // foreach = array 

            string[] nomes = { "lucas", "joão", "josé", "victor" };


          foreach(string nome in nomes) // imprime todos os nome ( variavel de loop) dentro do array nomes
                // existe uma convenção que arays sempre devem terminar no plural assim fica mais facil o entendimento cada nome entre nomes
            {
                Console.WriteLine(nome);
            }
          Console.ReadLine ();

        }
    }
}
