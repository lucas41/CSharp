using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CriandoVariaveisPontoFlutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 3 criando variasives Ponto Flutuante");

            double salario;
            double idade;

            salario = 1777.77;

            idade = 15.0 / 2.0;

            // Mesmo variaveis declaradas como Double ( no caso Idade) caso não coloquemos o .0 o resultado será um valor inteiro diferente do esperado //

            Console.WriteLine("seu sálario é de : " + salario + " R$");
            Console.WriteLine(idade);


            Console.WriteLine("Fim da execução do programa aperte enter para sair");
            Console.ReadLine();
        }
    }
}
