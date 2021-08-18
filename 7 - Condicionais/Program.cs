using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7___Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("executando projeto 7 - Condicionais");

            int idadejoao = 14;
            int qtdpessoa = 1;

            if (idadejoao >= 18)
            {
                Console.WriteLine("joão é maior de 18 anos");
            }
            else
            {
                if (qtdpessoa >= 2)
                {
                    Console.WriteLine("João não possui + de 18 anos porem está acompanhado");
                }
                else
                {
                    Console.WriteLine("João é de menor");
                }

            }

            Console.ReadLine();
        }
    }
}
