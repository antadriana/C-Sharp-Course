using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_methods
{
    class Program
    {
        static void PrintInfo()
        {
            Console.WriteLine("Hello");
            Console.WriteLine("My name is Sasha");
            Console.WriteLine("Im a boy");
            Console.WriteLine("I have a car");
        }

        static void PrintNum(float num)
        {
            Console.WriteLine("Num = " + num);
        }

        static void PrintNum(int num)
        {
            // /dkdsaljkdsal
            // dsapsal;da;l
            //d pas;dsa;lsad
            // .....
            Console.WriteLine("Num = " + num);
        }

        static void PrintNumOrNot(int num = 0, bool val = true)
        {
            if (val)
            {
                PrintNum(num);
            }
        }

        static int Sum(params int[] nums)
        {
            int sum = 0;
            foreach (int el in nums)
            {
                sum += el;
            }
            return sum;
        }




        static float Sum(float a, float b)
        {
            return a + b;
        }

        static int[,] CalcMatrix(int num)
        {
            int[,] ar = new int[num, num];

            Random r = new Random();

            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    ar[i, j] = r.Next(10) * num;
                }
            }

            return ar;
        }

        static void PrintMatrix(int[,] ar, int num)
        {
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    Console.Write("{0}\t", ar[i, j]);
                }
                Console.WriteLine();
            }
        }

        static int Add5(ref int n)
        {
            n = n + 5;
            return n;
        }

        static void Swap(ref int a, ref int b)
        {

            int temp = a;
            a = b;
            b = temp;
        }

        static void CalcSumAndProduct(int a, int b, out int sum, out int product)
        {
            sum = a + b;
            product = a * b;
        }



        static void Main(string[] args)
        {

            PrintNumOrNot();
            //  PrintNum(Sum( 3, 5, 9, 12, 120 ));   

            //int sum, product;

            //CalcSumAndProduct(5, 5, out sum, out product);

            //PrintNum(sum);
            //PrintNum(product);

            //int a = 0;
            //int b = 5;
            //PrintNum(a);
            //PrintNum(b);

            //Swap(ref a, ref b);

            //PrintNum(a);
            //PrintNum(b);
            //int k = 0;
            //PrintNum(k);
            //int res = Add5(ref k);
            //PrintNum(k);
            //PrintNum(res);
            //Sum(300, 5);
            //PrintNum(Sum(120, 20));

            //int i = 0;
            //int sum = 0;
            //int n = 1;
            //int[] ar = new int[10];
            //while (n != 0)
            //{
            //    n = int.Parse(Console.ReadLine());
            //    ar[i] = n;
            //    i++;
            //    sum += n;
            //}

            //Console.WriteLine(sum);
            //for (int j = 0; j <= sum; j++)
            //{
            //    if (j % 10 == 0)
            //        Console.WriteLine(j);
            //}
            //Console.WriteLine(8 % 3);

            //int n = int.Parse(Console.ReadLine());

            //int[,] array = CalcMatrix(n);
            //PrintMatrix(array, n);
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        array[i, j] += 5;
            //    }
            //}
            //// dajdkasl
            //// ....
            //// ....
            //PrintMatrix(array, n);
        }
    }
}