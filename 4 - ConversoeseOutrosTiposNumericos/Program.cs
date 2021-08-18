using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4___ConversoeseOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("executando o Projeto 4");

            double salario;
            salario = 1200.50;

            int salariointeiro;
            salariointeiro = (int)salario;

            Console.WriteLine(salario);
            Console.WriteLine(salariointeiro);


            int idade;
            idade = 26;

            long idademundo;
            idademundo = 1300000000000000000;

            // Variaveis de tipo int possuem um limite de numeros armazenaveis de até 2^31 (32 bits) para valores maiores usar o long //

            short qtdProdutos;
            qtdProdutos = 150;

            // Short é ultilizado para numeros de 16 bits seu valor maximo é um pouco mais que 16000 //


            float altura = 1.80f;

            // Como é pouco usual ultilizar float o C# espera que seja um double. Para forçar a ultilização necessario colocar o sufixo F //

            Console.WriteLine(idade);
            Console.WriteLine(idademundo);
            Console.WriteLine(qtdProdutos);
            Console.WriteLine(altura);

            Console.ReadLine();
        }
    }
}
