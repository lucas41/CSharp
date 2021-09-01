using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06___ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            Cliente cliente = new Cliente();
            cliente.Nome = "lucas";
            cliente.Profissao = "dev";
            cliente.CPF = "432.343.455-39";

            ContaCorrente conta = new ContaCorrente();


            conta.Saldo = -10;
            conta.Titular = cliente;

            Console.WriteLine(conta.Titular.Nome);
            Console.WriteLine(conta.Saldo);

            Console.ReadLine();

        }
    }
}
