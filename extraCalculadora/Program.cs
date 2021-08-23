using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extraCalculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao Programa Calculadora Virtual em C#");
            int repetprog = 1;
            while (repetprog != 0) { 
            Console.WriteLine("Vamos pegar o primeiro valor por favor digite-o");
            double n1;
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Vamos pegar agora o segundo valor por favor digite-o");
            double n2;
            n2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Qual operação você gostaria de realizar?");
            int repet = 1;

                while (repet != 0)
                {
                    Console.WriteLine("Lista de codigos de operação \n" +
                    "1 - Adição\n" +
                    "2 - Subtração\n" +
                    "3 - Divisão\n" +
                    "4 - Multiplicação");


                    int escolha;
                    escolha = Convert.ToInt32(Console.ReadLine());

                    if (escolha == 1)
                    {
                        double soma = n1 + n2;
                        Console.WriteLine("O valora da soma dos numeros digitados é de " + soma);
                        Console.WriteLine("Caso deseje fazer outra operação com esses numero digite 1 caso queira encerrar digite 0");
                        repet = Convert.ToInt32(Console.ReadLine());
                    }
                    else if (escolha == 2)
                    {
                        double sub = n1 - n2;
                        Console.WriteLine("O valora da subtração dos numeros digitados é de " + sub);
                        Console.WriteLine("Caso deseje fazer outra operação com esses numero digite 1 caso queira encerrar digite 0");
                        repet = Convert.ToInt32(Console.ReadLine());
                    }
                    else if (escolha == 3)
                    {
                        double divi = n1 / n2;
                        Console.WriteLine("O valora da divisão dos numeros digitados é de " + divi);
                        Console.WriteLine("Caso deseje fazer outra operação com esses numero digite 1 caso queira encerrar digite 0");
                        repet = Convert.ToInt32(Console.ReadLine());
                    }
                    else if (escolha == 4)
                    {
                        double multi = n1 * n2;
                        Console.WriteLine("O valora da Multiplicação dos numeros digitados é de " + multi);
                        Console.WriteLine("Caso deseje fazer outra operação com esses numero digite 1 caso queira encerrar digite 0");
                        repet = Convert.ToInt32(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("Numero invalido Favor digitar um numeral valido ou encerrar!");
                        Console.WriteLine("Caso deseje selecionar uma operação valida digite 1 caso queira encerrar digite 0");
                        repet = Convert.ToInt32(Console.ReadLine());
                    }

                    
             
                }
                Console.WriteLine("Fim da execução do programa com esses numeros");
                Console.WriteLine("Caso deseje fazer novas operações digite 1 para encerrar 0");
                repetprog = Convert.ToInt32(Console.ReadLine());
            }
           
        }
    }
}
