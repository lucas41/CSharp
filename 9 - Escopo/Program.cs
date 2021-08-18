using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9___Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("executando projeto 9 - Escopo");

            int idadejoao = 19;
            int qtdpessoa = 1;

            bool acompanhado = qtdpessoa >= 2;
            string mensagemAdicional;

            // bool = variavel booleana aceita apenas true or false // 

            if (acompanhado == true)
            {
                mensagemAdicional = "joão está acompanhado";
            }
            else
            {
                mensagemAdicional = "joão não está acompanhado";
            }

            if (idadejoao >= 18 || acompanhado == true)
            {
                Console.WriteLine("joão Pode entrar");
                Console.WriteLine(mensagemAdicional);
            }
            else
            {
                Console.WriteLine("João não pode entrar");
                Console.WriteLine(mensagemAdicional);
            }

            // || = ou //
            // && = E //

            Console.ReadLine();
        }
    }
}
