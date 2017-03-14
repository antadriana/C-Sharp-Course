using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of matrix, please");
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());


            int[,] matr = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matr[i, j] = int.Parse(Console.ReadLine());
                }
            }


            Console.WriteLine("Your matrix is:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matr[i, j] + " ");
                }
                Console.WriteLine();
            }int k = 0;
            for (int i = 0; i < n; i++)
            {
                matr[i, k] = 0;
            }

        }
    }
}