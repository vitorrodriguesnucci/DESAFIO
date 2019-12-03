using System;

namespace ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Em um array bidimensional de 10 linhas por 10 colunas do tipo inteiro, solicite ao
            ///usuário que preencha este array.Ao final apresente: (1, 0 pto)
            ///a.Média Geral
            ///b.Maior Número
            ///c.Menor Número
            int[,] numero = new int[10, 10];
            int media = 0, maior = 0, menor = 0;
            for (int l = 0; l < 10; l++)
            {
                for (int c = 0; c < 10; c++)
                {
                    Console.Write("Digite um número: ");
                    numero[l, c] = Convert.ToInt32(Console.ReadLine());
                    media += numero[l, c];
                    if (l == 0 && c == 0)
                    {
                        maior = numero[l, c];
                        menor = numero[l, c];
                    }
                    else
                    {
                        if (numero[l, c] > maior)
                        {
                            maior = numero[l, c];
                        }
                        else
                        {
                            if (numero[l, c] < menor)
                            {
                                menor = numero[l, c];
                            }
                        }
                    }
                }

            }
            Console.WriteLine("Média dos números: " + media / 100);
            Console.WriteLine("Menor número: " + menor);
            Console.WriteLine("Maior número: " + maior);
        }
    }
}
