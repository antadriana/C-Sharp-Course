using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz3_Lesson_7_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter strings and rows");
           int n = int.Parse(Console.ReadLine());
            Console.WriteLine("The quantity of strings : " + n + "\n" + "The quantity of rows : " + n);
            int[,] matrix = new int[n, n];
            int[,] matrix2 = new int[n, n];
            Console.WriteLine("Enter the matrix");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Enter the matrix 2");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix2[i, j] = int.Parse(Console.ReadLine());
                }
            }
            float one_percent = 100f/ (n * n);
            float percent=0f;

            for (int i = 0; i < n; i++)
            { for (int j = 0; j < n; j++) {
                    if (matrix[i, j] == matrix2[i, j])
                    {
                        percent +=one_percent;
                    }
            }
            }

            //Console.WriteLine(100f / 9);
            Console.WriteLine(one_percent+" Similarity is "+percent + "%");

        }
    }
}
