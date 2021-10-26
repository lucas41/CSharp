using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06___condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // um if significa o mesmo no portugues que o SE portanto se a condição contida dentro dos parenteses for uma verdade o bloco de codigo sera executado caso não o proximo bloco else ira ser executado

            int n1 = 39;
            int n2 = 40;

            if (n2 > n1) // a condição pergunta se o valor da variavel n2 e maior que n1 no caso isso é uma verdade pois 20 > 10 então sera executado esse bloco
            {
                Console.WriteLine("A condição é verdadeira"); // como a condição é verdadeira sera impresso essa mensagem
            }
            else
            {
                Console.WriteLine("A condição era falsa"); // caso fosse falsa seria impressa essa mensagem você pode fazer um teste alterando o valor das variaveis 
            }



            // existe tambem a estrutura else if ela entra entre um if e um else para averiguar mais de uma condição 

            if(n1 < 20)
            {
                Console.WriteLine("o n1 é menor que 20"); // o valor de n1 e 39 portanto essa mensagem sera ignorada

            } else if(n1 < 40)
            {
                Console.WriteLine("o valor de n1 é menor que 40"); // 39 e menor que 40 portanto sera impresso essa mensagem

            } else
            {
                Console.WriteLine("o valor é superior a 40"); // por fim essa mensagem tambem sera ignorada pois 39 < 40
            }

            Console.ReadLine();
        }
    }
}
