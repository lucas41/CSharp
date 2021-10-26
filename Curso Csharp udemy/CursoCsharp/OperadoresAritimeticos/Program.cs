using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadoresAritimeticos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // declarando desta forma o c# ira automaticamente efetuar a conta e ira imprimir 40 como resultado
            int numQualquer = 20 + 20;

            int n1 = 30;
            int n2 = 30;

            // a variavel soma ira somar os valores da variavel n1 e n2 resultando em 60 isso vale para qualquer operação aritimetica (+  -  * /)

            int soma = n1 + n2;

            Console.WriteLine(soma);

            Console.ReadLine();

        }
    }
}
