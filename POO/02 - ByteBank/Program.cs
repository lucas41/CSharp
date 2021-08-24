using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02___ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();


            // Caso não tenha sido atribuido valor a variavel será demonstrada zerada \\

            Console.WriteLine(conta.saldo);

            conta.titular = "lucas";
            conta.saldo = 120;

            // Agora com a declaração feita o valor se iniciar com o valor esperado \\
            Console.WriteLine(conta.saldo);

            Console.ReadLine();
        }
    }
}
