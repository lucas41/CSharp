using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01__ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contalucas = new ContaCorrente();

            contalucas.titular = "lucas";
            contalucas.numeroConta = 123;
            contalucas.numeroAgencia = 456;
            contalucas.saldo = 1000;


            Console.WriteLine(contalucas.titular);
            Console.WriteLine("Agencia : "+contalucas.numeroAgencia);
            Console.WriteLine("Conta : "+contalucas.numeroConta);
            Console.WriteLine("Saldo atual de : " +contalucas.saldo + " R$");

            Console.ReadLine();
        }
    }
}
