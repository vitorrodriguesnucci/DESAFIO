using System;
using System.Collections.Generic;

namespace ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Utilizando o conceito de SORT elabore uma aplicação que faça o cadastro de
            ///fornecedores.Os fornecedores devem possuir o mínimo de 10 propriedades.O
            ///usuário poderá cadastrar a quantidade de fornecedores que julgar necessário.
            ///Ao final apresente os dados ordenados por ordem alfabética do nome do
            ///fornecedor. (1, 0 pto)

            List<Fornecedor> lstFornecedor = new List<Fornecedor>();
            int escolha = 0;
            do
            {
                do
                {
                    Console.WriteLine("1 - Cadastrar");
                    Console.WriteLine("2 - Sair");
                    Console.Write("O que deseja fazer? ");
                    escolha = Convert.ToInt32(Console.ReadLine());
                } while (escolha != 1 && escolha != 2);
                if (escolha == 1)
                {
                    Incluir();
                }
                else
                {
                    Sair();
                }
            } while (escolha != 2);
            void Incluir()
            {
                var forn = new Fornecedor();

                Console.Write("Código do fornecedor: ");
                forn.Codigo = Convert.ToInt32(Console.ReadLine());

                Console.Write("Nome do fornedor: ");
                forn.Nome = Console.ReadLine();

                Console.Write("Telefone: ");
                forn.Telefone = Console.ReadLine();

                Console.Write("CNPJ: ");
                forn.Cnpj = Console.ReadLine();

                Console.Write("Endereço: ");
                forn.Endereco = Console.ReadLine();

                Console.Write("Bairro: ");
                forn.Bairro = Console.ReadLine();

                Console.Write("Cidade: ");
                forn.Cidade = Console.ReadLine();

                Console.Write("Cep: ");
                forn.Cep = Console.ReadLine();

                Console.Write("Estado: ");
                forn.Estado = Console.ReadLine();

                Console.Write("E-mail: ");
                forn.Email = Console.ReadLine();

                lstFornecedor.Add(forn);
                Console.Clear();
                Console.WriteLine("Fornecedor cadastrado com sucesso");
            }

            void Sair()
            {
                Console.WriteLine("Fim da execução");
                Console.WriteLine("Lista ordenada pelo nome do fornecedor");
                Console.WriteLine("");
                lstFornecedor.Sort();
                foreach (var item in lstFornecedor)
                {
                    Console.WriteLine("Código:   " + item.Codigo);
                    Console.WriteLine("Nome:     " + item.Nome);
                    Console.WriteLine("Telefone: " + item.Telefone);                 
                    Console.WriteLine("CNPJ:     " + item.Cnpj);                    
                    Console.WriteLine("Endereço: " + item.Endereco);                  
                    Console.WriteLine("Bairro:   " + item.Bairro);                  
                    Console.WriteLine("Cidade:   " + item.Cidade);                   
                    Console.WriteLine("Cep:      " + item.Cep);                   
                    Console.WriteLine("Estado:   " + item.Estado);                    
                    Console.WriteLine("E-mail:   " + item.Email);
                    Console.WriteLine("");
                }
            }
        }
    }
}
