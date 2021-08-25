using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contabruno = new ContaCorrente();

            contabruno.titular = "bruno";

            Console.WriteLine(contabruno.saldo);
            bool resultadoSaque = contabruno.Sacar(50);
            if (resultadoSaque == true)
            {
                Console.WriteLine("Saque efetuado com sucesso");
            } else
            {
                Console.WriteLine("Falha ao efetuar saque");
            }

            Console.WriteLine(resultadoSaque);
            Console.WriteLine(contabruno.saldo);

            contabruno.Depositar(500);
            Console.WriteLine(contabruno.saldo);


            ContaCorrente contagabriela = new ContaCorrente();

            contagabriela.titular = "gabi";

            Console.WriteLine("Saldo do Bruno: " + contabruno.saldo);
            Console.WriteLine("Saldo do Gabriela: " + contagabriela.saldo);

           bool resultado = contabruno.transferir(200, contagabriela);

            if (resultado == true)
            {
                Console.WriteLine("transferencia efetuado com sucesso");

            } else
            {
                Console.WriteLine("Falha na transferencia");
            }

            Console.WriteLine("Saldo do Bruno: " + contabruno.saldo);
            Console.WriteLine("Saldo do Gabriela: " + contagabriela.saldo);
            Console.ReadLine();
        }
    }
}
