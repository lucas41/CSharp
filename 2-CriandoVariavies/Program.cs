using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_CriandoVariavies
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("executando o segundo projeto lidando com variaveis \n");

            int idade;
            int idade2;
            int idadeF;

            idade = 32 + 12;
            idade2 = 10;
            idadeF = idade + idade2;

       
            Console.WriteLine(idadeF + "\n");

            Console.WriteLine("Fim da execução tecle enter para encerrar");
            Console.ReadLine();
        }
    }
}
