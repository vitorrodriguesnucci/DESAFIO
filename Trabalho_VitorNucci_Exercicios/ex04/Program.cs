using System;
using System.Collections.Generic;

namespace ex04
{
    class Program
    {   
        static void Main(string[] args)
        {
            ///Utilizando o conceito de pilha, desenvolva uma aplicação que faça o
            ///empilhamento e o desempilhamento de dados. (0, 5 pto)
            Queue<String> queue = new Queue<string>();
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
                } while (escolha<0 && escolha > 2);

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
                queue.Enqueue(valor);
                Console.Clear();
                Console.WriteLine("Valor cadastrado com sucesso");
                Print();
            }
            void Excluir()
            {
                if (queue.Count > 0)
                {
                    queue.Dequeue();
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
                Console.WriteLine("Pilha");
                Console.WriteLine("");
                foreach (var item in queue)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("");
            }
        }
    }
}
