using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente gabriela = new Cliente();

            gabriela.nome = "Gabriela";
            gabriela.profissao = "Dev c#";
            gabriela.cpf = "456.543.243-20";

            ContaCorrente conta = new ContaCorrente();

            conta.titular = gabriela;
            conta.saldo = 500;
            conta.numeroAgencia = 563;
            conta.numeroAgencia = 234;

            Console.WriteLine(gabriela.nome);
            Console.WriteLine(conta.titular.nome);
            Console.ReadLine();
        }
    }
}
