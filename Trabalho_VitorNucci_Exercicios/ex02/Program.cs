using System;
using System.Collections.Generic;

namespace ex02
{
    class Program
    {

        

        static void Main(string[] args)
        {
            ///Utilizando um List & lt; T & gt; em uma classe de Produtos com pelo menos 10
            ///propriedades, elabore uma aplicação que contenha um menu com três opções,
            ///sendo elas, INCLUIR, CONSULTAR e SAIR.O usuário poderá incluir quantos
            ///produtos julgar necessário. A Consulta poderá ser feita utilizando 5 opções de
            ///propriedade(Ex: Código, Nome, Fornecedor, etc).A opção Sair, além de
            ///encerrar a aplicação deve apresentar a quantidade de produtos cadastrados.
          List<Produtos> lstProd = new List<Produtos>();
            int escolha = 0, buscaInt;
            string buscaStr;
            bool encontrou;
            do
            {
                do
                {
                    
                    Console.WriteLine("1 - Incluir");
                    Console.WriteLine("2 - Consultar");
                    Console.WriteLine("0 - Sair");
                    Console.Write("O que deseja fazer? ");
                    escolha = Convert.ToInt32(Console.ReadLine());
                } while (escolha != 0 && escolha != 1 && escolha != 2);
                if (escolha == 1)
                {
                    Incluir();
                }
                else if (escolha == 2)
                {
                    Consultar();
                }
                else
                {
                    Console.WriteLine("Todal de produtos cadastrados: "+ lstProd.Count);
                    Console.WriteLine("Fim da execução");
                }
            } while (escolha != 2);

            void Incluir()
            {
                var prod = new Produtos();
  
                Console.Write("Código do produto: ");
                prod.Codigo = Convert.ToInt32(Console.ReadLine());

                Console.Write("Nome do produto: ");
                prod.Nome = Console.ReadLine();

                Console.Write("Fabricante do produto: ");
                prod.Fabricante = Console.ReadLine();

                Console.Write("Fornecedor do produto: ");
                prod.Fornecedor = Console.ReadLine();

                Console.Write("Marca do produto: ");
                prod.Marca = Console.ReadLine();

                Console.Write("Peso do produto[kg]: ");
                prod.Peso = (float)Convert.ToDouble(Console.ReadLine());

                Console.Write("Preço do produto[R$]: ");
                prod.Preço = (float)Convert.ToDouble(Console.ReadLine());

                Console.Write("Quantidade de unidades: ");
                prod.QtdeUni = Convert.ToInt32(Console.ReadLine());

                Console.Write("Tipo de produto: ");
                prod.Tipo = Console.ReadLine();

                Console.Write("Descrição do produto: ");
                prod.Descricao = Console.ReadLine();

                lstProd.Add(prod);
                Console.Clear();
                Console.WriteLine("Produto cadastrado com sucesso");
            }
            void Consultar()
            {
                do
                {
                    Console.WriteLine("1 - Codigo");
                    Console.WriteLine("2 - Nome");
                    Console.WriteLine("3 - Fabricante");
                    Console.WriteLine("4 - Fornecedor");
                    Console.WriteLine("5 - Marca");
                    Console.Write("Deseja consular por?");
                    escolha = Convert.ToInt32(Console.ReadLine());
                } while (escolha < 0 && escolha > 5);
                
                if (escolha == 1)
                {
                    encontrou = false;
                    Console.WriteLine("Digite o codigo que deseja consultar: ");
                    buscaInt = Convert.ToInt32(Console.ReadLine());
                    foreach (var item in lstProd)
                    {
                        if (buscaInt == item.Codigo)
                        {
                            encontrou = true;
                            Console.WriteLine("Código:      " + item.Codigo);
                            Console.WriteLine("Nome:        " + item.Nome);
                            Console.WriteLine("Fabricante:  " + item.Fabricante);
                            Console.WriteLine("Fornecedor:  " + item.Fornecedor);
                            Console.WriteLine("Marca:       " + item.Marca);
                            Console.WriteLine("Peso[kg]:    " + item.Peso);
                            Console.WriteLine("Preço[R$]:   " + item.Preço);
                            Console.WriteLine("Qtde de Uni: " + item.QtdeUni);
                            Console.WriteLine("Tipo:        " + item.Tipo);
                            Console.WriteLine("Descrição:   " + item.Descricao);
                        }
                    }
                    if (encontrou == false)
                    {
                        Console.WriteLine("Produto não encontrado");
                    }
                }
                else if (escolha == 2)
                {
                    encontrou = false;
                    Console.WriteLine("Digite o nome que deseja consultar");
                    buscaStr = Console.ReadLine();
                    foreach (var item in lstProd)
                    {
                        if (buscaStr == item.Nome)
                        {
                            encontrou = true;
                            Console.WriteLine("Código:      " + item.Codigo);
                            Console.WriteLine("Nome:        " + item.Nome);
                            Console.WriteLine("Fabricante:  " + item.Fabricante);
                            Console.WriteLine("Fornecedor:  " + item.Fornecedor);
                            Console.WriteLine("Marca:       " + item.Marca);
                            Console.WriteLine("Peso[kg]:    " + item.Peso);
                            Console.WriteLine("Preço[R$]:   " + item.Preço);
                            Console.WriteLine("Qtde de Uni: " + item.QtdeUni);
                            Console.WriteLine("Tipo:        " + item.Tipo);
                            Console.WriteLine("Descrição:   " + item.Descricao);
                        }
                    }
                    if (encontrou == false)
                    {
                        Console.WriteLine("Produto não encontrado");
                    }
                }
                else if (escolha == 3)
                {
                    encontrou = false;
                    Console.WriteLine("Digite o Fabricante que deseja consultar");
                    buscaStr = Console.ReadLine();
                    foreach (var item in lstProd)
                    {
                        if (buscaStr == item.Fabricante)
                        {
                            encontrou = true;
                            Console.WriteLine("Código:      " + item.Codigo);
                            Console.WriteLine("Nome:        " + item.Nome);
                            Console.WriteLine("Fabricante:  " + item.Fabricante);
                            Console.WriteLine("Fornecedor:  " + item.Fornecedor);
                            Console.WriteLine("Marca:       " + item.Marca);
                            Console.WriteLine("Peso[kg]:    " + item.Peso);
                            Console.WriteLine("Preço[R$]:   " + item.Preço);
                            Console.WriteLine("Qtde de Uni: " + item.QtdeUni);
                            Console.WriteLine("Tipo:        " + item.Tipo);
                            Console.WriteLine("Descrição:   " + item.Descricao);
                        }
                    }
                    if (encontrou == false)
                    {
                        Console.WriteLine("Produto não encontrado");
                    }
                }
                else if (escolha == 4)
                {
                    encontrou = false;
                    Console.WriteLine("Digite o fornecedor que deseja consultar");
                    buscaStr = Console.ReadLine();
                    foreach (var item in lstProd)
                    {
                        if (buscaStr == item.Fornecedor)
                        {
                            encontrou = true;
                            Console.WriteLine("Código:      " + item.Codigo);
                            Console.WriteLine("Nome:        " + item.Nome);
                            Console.WriteLine("Fabricante:  " + item.Fabricante);
                            Console.WriteLine("Fornecedor:  " + item.Fornecedor);
                            Console.WriteLine("Marca:       " + item.Marca);
                            Console.WriteLine("Peso[kg]:    " + item.Peso);
                            Console.WriteLine("Preço[R$]:   " + item.Preço);
                            Console.WriteLine("Qtde de Uni: " + item.QtdeUni);
                            Console.WriteLine("Tipo:        " + item.Tipo);
                            Console.WriteLine("Descrição:   " + item.Descricao);
                        }
                    }
                    if (encontrou == false)
                    {
                        Console.WriteLine("Produto não encontrado");
                    }
                }
                else if (escolha == 5)
                {
                    encontrou = false;
                    Console.WriteLine("Digite a marca que deseja consultar");
                    buscaStr = Console.ReadLine();
                    foreach (var item in lstProd)
                    {
                        if (buscaStr == item.Marca)
                        {
                            encontrou = true;
                            Console.WriteLine("Código:      " + item.Codigo);
                            Console.WriteLine("Nome:        " + item.Nome);
                            Console.WriteLine("Fabricante:  " + item.Fabricante);
                            Console.WriteLine("Fornecedor:  " + item.Fornecedor);
                            Console.WriteLine("Marca:       " + item.Marca);
                            Console.WriteLine("Peso[kg]:    " + item.Peso);
                            Console.WriteLine("Preço[R$]:   " + item.Preço);
                            Console.WriteLine("Qtde de Uni: " + item.QtdeUni);
                            Console.WriteLine("Tipo:        " + item.Tipo);
                            Console.WriteLine("Descrição:   " + item.Descricao);
                        }
                    }
                    if (encontrou == false)
                    {
                        Console.WriteLine("Produto não encontrado");
                    }
                }

                Console.WriteLine("Pressione enter para continuar");
                Console.ReadLine();
                Console.Clear();
            }
        }
       

    }
}
