using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz1_Lesson_7_8_mtrx
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int sum=0;
            int sum1 = 0;
            Console.WriteLine("Enter strings and rows");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("The quantity of strings : " + n + "\n" + "The quantity of rows : " + n);
            int[,] matrix = new int[n,n];
            Console.WriteLine("Enter the matrix");
            for (int i=0; i<n; i++)
            { for (int j=0; j<n; j++)
                { matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Your matrix is:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++) {
                    Console.Write(matrix[i, j] + " ");
                } Console.WriteLine();
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {  if (i == j)
                    {
                        sum += matrix[i, i];
                    }
                }
            }
            Console.WriteLine("The sum of main diag is: " + sum);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                   if (j==n-i-1)
                    {
                        sum1 += matrix[i, j];
                    }
                }
            }
            Console.WriteLine("The sum of main additional is: " + sum1);
        }
    }
}
