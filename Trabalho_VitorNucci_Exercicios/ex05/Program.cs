using System;
using System.Collections.Generic;

namespace ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Utilizando o conceito de fila, desenvolva uma aplicação que coloque os
            ///elementos em fila e os retire da fila conforme necessário. (0, 5 pto)
            Stack<String> stack = new Stack<String>();
            int escolha = 0;
            string valor;
            do
            {
                do
                {

                    Console.WriteLine("1 - Incluir");
                    Console.WriteLine("2 - Excluir");
                    Console.WriteLine("0 - Sair");
                    Console.Write("O que deseja fazer? ");
                    escolha = Convert.ToInt32(Console.ReadLine());
                } while (escolha < 0 && escolha > 2);

                if (escolha == 1)
                {
                    Inluir();
                }
                else if (escolha == 2)
                {
                    Excluir();
                }
                else
                {
                    Console.WriteLine("Fim de execução");
                }
            } while (escolha != 0);


            void Inluir()
            {
                Console.Write("Informe um valor: ");
                valor = Console.ReadLine();
                stack.Push(valor);
                Console.Clear();
                Console.WriteLine("Valor cadastrado com sucesso");
                Print();
            }
            void Excluir()
            {
                if (stack.Count > 0)
                {
                    stack.Pop();
                    Console.WriteLine("Valor removido com sucesso");
                    Print();
                }
                else
                {
                    Console.WriteLine("A lista não possui nenhum valor para ser removido");
                }

            }
            void Print()
            {
                Console.WriteLine("Fila");
                Console.WriteLine("");
                foreach (var item in stack)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("");
            }
        }
    }
}
