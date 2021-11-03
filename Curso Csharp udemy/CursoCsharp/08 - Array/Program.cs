using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08___Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Um array serve para armazenamento de diversos valores 


            // CRIANDO UM NOVO ARRAY
            string[] produtos = new string[5] { 
                "Sea of theaves", // indice 0 
                "FIFA 2022", // indice 1
                "HALF - LIFE 3", // indice 2
                "PORTAL 3", // indice 3
                "LEAGUE OF LEGENDS" // indice 4
            };

            Console.WriteLine(produtos[0]); // ira imprimir Sea of theaves pois e o indice 0 do array produtos 

            // podemos usar um for para percorrer todo o array e mostralo 
            for (int i = 0; i < produtos.Length; i++)
            {
                Console.WriteLine(produtos[i]);
            }

            // tambem podemos usar um for para colocar valor em um array

            string[] produtos2 = new string[5]; // declarando um novo array

            for (int i = 0; i < produtos2.Length; i++) // solicitando os dados que irão prencher esse arry sendo passados pelo user
            {
                produtos[i] = Console.ReadLine();
            }


            for (int i = 0; i < produtos2.Length; i++) // imprimindo array passado pelo usuario
            {
                Console.WriteLine(produtos[i]);
            }



            Console.ReadLine();
        }
    }
}
