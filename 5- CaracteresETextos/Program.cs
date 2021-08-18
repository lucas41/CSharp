using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5__CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 5 - Caracteres e textos");

            // Tabela ASC é completamente funcional em c# sendo possivel fazer manipulação com operações aritimeticas //

            char primeiraletra = (char)65;
            primeiraletra = (char)(primeiraletra + 1);

            Console.WriteLine(primeiraletra);


            // STRING ultilizado para receber texto
            string titulo = "Primeiro texto digitado em uma String " + 2020;

            Console.WriteLine(titulo);

            string cursosProgramacao = "- .NET\n" +
                                       "- Java\n" +
                                       "- Javascript";

            Console.WriteLine(cursosProgramacao);


            Console.ReadLine();
        }
    }
}
