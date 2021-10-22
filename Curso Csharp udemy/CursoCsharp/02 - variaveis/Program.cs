using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02___variaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // existe no c# diversos tipos de variaveis 

            // int -> inteiro -> armazena dados de numero inteiros exemplo = 1, -54, 5
            // float -> flutuante -> armazena numero porem com decimais = 1.5, 56.4, -4.2
            // double / decimal tambem servem para numeros flutuantes
            // Bool 0> armazena valor booleanos = true or false
            // String -> Armazena texto 
            // Char -> selecionado por '' ultilizado para caracter

            int idade = 21; // declaramos o tipo em seguida o nome da variavel e por fim seu valor
            float altura = 1.75f;
            String nome = "lucas Delfini";
            bool emaior = true;

            Console.WriteLine("meu nome é " + nome + "\n" +
                "Minha altura é de " + altura + "\n" +
                "Minha idade é de " + idade + " Anos \n" +
                "Portabto eu sou de maior? ");

            //imprindo os dados das variaveis


            // if para verificar as propriedade da variavel emaior se for verdadeiro ira imprimir a primeira mensagem caso seja falso a segunda
            if (emaior == true)
            {
                Console.WriteLine("Sim sou de maior");
            }
            else
            {
                Console.WriteLine("Não é de menor");
            }

            Console.ReadLine();


            // é possivel declaram variaveis sem o tipo dela com a sintaxe a baixo 

            var cor_favorita = "roxo";
            //o uso da palavra var faz com que o c# detecte o tipo da variavel para o programado de acordo com os parametros passados

            // porem não é recomendado é sempre mais pratico colocar o tipo da variavel ao declarar a mesma

            // podemos declaram uma variavel dinamica da seguinte forma

            dynamic outra_cor = "Vermelho";

            // desta forma conseguimos mudar o tipo da variavel de um String para um int por exemplo 

            outra_cor = 132;

            // apenas variaveis dinamicas podem fazer isso 
        }
    }
}
