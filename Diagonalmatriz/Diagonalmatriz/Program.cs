using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagonalmatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero inteiro");

            int n = int.Parse(Console.ReadLine());

            int [,]  mat;
            int cont = 0; 

            mat = new int[n, n];

            Console.WriteLine("Sua matriz e " + n + "x " + n);
            Console.WriteLine("Digite as linhas da matriz separada por espaço cada elemento da linha"); 
            
            for(int i =0; i< n; i++)
            {
                string[] linha = Console.ReadLine().Split(' '); 
                for(int j = 0; j < n; j++)
                {
               
                    mat[i, j] = int.Parse(linha[j]);
                }
            }
            Console.WriteLine("DIAGONAL PRINCIPAL");

            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    if( i == j)
                    {
                        Console.Write(mat[j, i] + " " );
                    }

                }
            }

            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    if (mat[j,i] <0)
                    {
                        cont++;
                    }
                }
            }
            Console.ReadLine();

            Console.WriteLine( "Quantidade de negativos " + cont);

            Console.ReadLine();
        }
    }
}
