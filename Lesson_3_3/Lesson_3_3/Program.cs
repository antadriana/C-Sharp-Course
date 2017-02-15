using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a,b,c");
            // float num = float.Parse(Console.ReadLine());
            /* float y=0;
              if (num > 150)
              {
                 y=num * num + 127 / 5.5f;

              }
              if (num == 0) {y=1996; }
              if (num < -170) {y= num / 100 + 127 * 3.14f; }

              Console.WriteLine(y);*/
            /*    if (num > 1000)
                {
                    num = num - num * 0.15f;
                    Console.WriteLine("Discount: -15%. Sum: " + num);
                }
                else
                {
                    float add;
                    add = 1000 - num;
                    Console.WriteLine("No discount. Add "+add);
                }*/
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if ((a + b > c) && (a + c > b) && (c + b > a))
            {
                Console.WriteLine("Triangle exists");
            }
            else Console.WriteLine("Doesnt exist");
        }
    }
}