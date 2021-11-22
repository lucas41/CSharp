using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10___Enum
{
    internal class Program
    {
        // Enum em portugues significa enumeração 
        // comstroi um novo tipo de dado 

        // no exemplo queremos criar um tipo de dados COR 
        // assim que um enum for criado e necessario colocar todas as opções que ele pode receber da seguinte forma

        enum cor {vermelho, azul, verde, Amarelo};
        static void Main(string[] args)
        {

            cor corfavorita = cor.vermelho;
            cor corfavorita2 = cor.azul;

            Console.WriteLine(corfavorita);
            Console.WriteLine(corfavorita2);

            Console.ReadLine(); 

        }
    }
}
