using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07___ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
     
            ContaCorrente conta = new ContaCorrente(867, 8423743);

            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
            
            Console.WriteLine(conta.Agencia);
            Console.Write(conta.Numero);

            ContaCorrente ContadaGabriela = new ContaCorrente(867, 327842784);

            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
            Console.ReadLine();
        }
    }
}
