using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06___OperadoLogico
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("digite sua idade");
            //int.parse significa converter o dado digitado em int
            // int é o tipo da variavel e parse significa converter

            int idade = int.Parse(Console.ReadLine());


            // os condicionas são maneiras de fazer mais de uma condição dentro de um if
            // && significa E a condição apenas será cumprida se ambos requisitos forem sanados
            // || significa OU a condição sera cumprida em qualquer um dos casos for verdadeiro

            if (idade < 12 && idade >= 0)
            {
                Console.WriteLine("você é uma criança");
            }
            else if(idade >= 12 && idade <= 18)
            {
                Console.WriteLine("você é um adolescente");
            }
            else if( idade > 18 && idade <= 60)
            {
                Console.WriteLine("você é um adulto");
            }
            else if(idade > 60)
            {
                Console.WriteLine("você é um idoso");
            }

            Console.ReadLine();
        }
    }
}
