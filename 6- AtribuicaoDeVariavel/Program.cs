using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6__AtribuicaoDeVariavel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("executando a aula 6 Atribuição de Variavel");

            int idade = 32;

            int idadegustavo = idade;

            idade = 20;

            Console.WriteLine(idade);
            Console.WriteLine(idadegustavo);

            Console.ReadLine();

        }
    }
}
