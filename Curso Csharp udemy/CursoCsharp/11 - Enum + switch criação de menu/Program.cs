using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11___Enum___switch_criação_de_menu
{
    internal class Program
    {
        enum Opcao {Criar = 1, Deletar, Editar, Listar, Atualizar}
        static void Main(string[] args)
        {
            Console.WriteLine("selecione uma das opções abaixo\n");
            Console.WriteLine(" 1 - criar\n 2 - deletar\n 3 - editar\n 4 - Listar\n 5 - Atualizar");

            int index = int.Parse(Console.ReadLine());

            Opcao opcaoselecionada = (Opcao)index;

            switch(opcaoselecionada)
            {
                case Opcao.Criar:
                    Console.WriteLine("você está efetuando a criação");
                    break;
                case Opcao.Deletar:
                    break;
                case Opcao.Editar:
                    break;
                case Opcao.Listar:
                    break;
                case Opcao.Atualizar:
                    break;
                default:
                    Console.WriteLine("opção não encontrada");
                    break;
            }

            Console.ReadLine();
        }
    }
}
