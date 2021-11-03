using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcao
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ExibirMsg(); // chamando a função dentro do metodo main para ser exibida no programa

            GerarPreco(10);

            int soma1 = soma(1, 2, 3);
            
            int soma2 = soma(10, 20, 30);

            Console.WriteLine(soma1);
            Console.WriteLine(soma2);

            Console.ReadLine();

        }

        // uma função serve para armazenar um codigo que se repete diversas vezes ao longo do programa dessa forma ao inves de termos que escrever todo o codigo novamente apenas chamamos a função 
        static void ExibirMsg() // declarando a função desta forma sendo void o tipo de retorno dela
        {
            Console.WriteLine("Essa é minha primeira função");
            Console.WriteLine("Vamos ver se funciona");
        }

        static void GerarPreco(int preco) // dentro dos () uma função pode receber um parametro 
        {
            // função ABS faz o valor de modulo ultilizada como Math.ABS
            Console.WriteLine(preco);
        }

        static int soma(int a, int b, int c)
            // void e uma funçao que não possui retorno caso possua é necessario colocar o tipo de resultado esperado assim como uma variavel no caso int
        {
            int resultfinal = a + b + c;

            return resultfinal; // retorna o valor da variavel resultfinal atraves da palavra resservada resultfinal
        }
    }
}
