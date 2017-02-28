using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5_Methods
{
    class Program
    {static int Fibo(int n)
        {if (n < 1) return 0;
            if (n == 1 || n == 2) return 1;
            return Fibo(n - 1) + Fibo(n - 2);

        }
        static int[] Calc1(int n)
        {
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = i;
               // return arr[i];
            }
            return arr; }
        static void Print(int[] arr)
        {
           for (int i =0; i<arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
      /*  static string DoAll(out bool b, string find, float f=0.0f, string[] lines ref int a,)
        {
            b = false;
            foreach (string l in lines)
            {
                if (l == find)
                {

                    b = true;
                    break;
                }
            }
            if (a > 150)
            {
                a = (int)f;
                return "A is bigger than 150";
            }
            return "A is smaller";
           // return "";
        }*/
        static void Main(string[] args)
        {Console.WriteLine()
            //int n = 6;
         // int []arr1=  Calc1(n);
           // Print(Calc1(n));
            

        }
    }
}
