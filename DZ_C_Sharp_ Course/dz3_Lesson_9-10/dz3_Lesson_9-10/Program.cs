using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz3_Lesson_9_10
{
    class Program
    { static void Matrix(int n, int m,int[,] matr)
        { int fill=0;
            for (int i=0; i<n; i++)
            {
                for (int j=0; j<m; j++)
                {
                    matr[i, j] = fill;
                    fill++;
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matr[i, j]+" ");
                }
                Console.WriteLine();
            }

        }
        static void Main(string[] args)
        {
            int n = 3;
            int m = 4;
            int[,] matr= new int [n, m];
            Matrix(n, m, matr);
        }
    }
}
