using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03___ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contalucas = new ContaCorrente();

            contalucas.titular = "lucas";
            contalucas.numeroAgencia = 863;
            contalucas.numeroConta = 75432;

            ContaCorrente contagabriela = new ContaCorrente();

            contagabriela.titular = "Gabi";
            contagabriela.numeroAgencia = 423;
            contagabriela.numeroConta = 754432;

            Console.ReadLine();
        }
    }
}
