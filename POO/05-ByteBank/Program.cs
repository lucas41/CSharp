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
           // Cliente gabriela = new Cliente();

            //gabriela.nome = "Gabriela";
            //gabriela.profissao = "Dev c#";
            //gabriela.cpf = "456.543.243-20";

            ContaCorrente conta = new ContaCorrente();

            //conta.titular = gabriela;
            //conta.titular = new Cliente();
            //conta.titular.cpf = "432.543.432 - 30";

            // caso a referencia não aponte para lugar nenhum havera um erro de exceção

            conta.saldo = 500;
            conta.numeroAgencia = 563;
            conta.numeroAgencia = 234;

            //Console.WriteLine(gabriela.nome);
            Console.WriteLine(conta.titular.cpf);
            Console.ReadLine();
        }
    }
}
