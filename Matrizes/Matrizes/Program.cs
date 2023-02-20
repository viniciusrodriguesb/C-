using System;

namespace Matrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //Declarando uma Matriz
            int[,] mat = new int[n, n];

            for (int i =0; i < n; i++)
            {
                //Utilização do Split para pegar somente os numeros digitados pelo usuário, retirandos os espaços.
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++) {
                //Transformando o dado do Split que é String, para Inteiro, e inserindo na matriz
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            //Pegando a diagonal principal da matriz:
            Console.WriteLine("Main Diagonal: ");
            for (int i = 0; i < n; i++)
            {
                //A diagonal principal tem mesmo numero de colunas e linhas então para imprimir é:
                Console.WriteLine(mat[i,i] + " ");
            }
            Console.WriteLine();

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; i++)
                {
                    //Verificação: se os numeros da matriz forem menores que zero, fazer contagem
                    if (mat[i,j] < 0)
                    {
                        count++;    
                    }
                }
            }
            Console.WriteLine("Negative numbers: " + count);
        }
    }
}