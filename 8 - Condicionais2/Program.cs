using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8___Condicionais2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("executando projeto 8 - Condicionais2");

            int idadejoao = 14;
            int qtdpessoa = 3;

            bool acompanhado = qtdpessoa >= 2;

            // bool = variavel booleana aceita apenas true or false // 

            if (idadejoao >= 18 || acompanhado == true)
            {
                Console.WriteLine("joão Pode entrar");
            }
            else
            {
                Console.WriteLine("João não pode entrar");
            }

            // || = ou //
            // && = E //

            Console.ReadLine();
        }
    }
}
