using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz2_Lesson_9_10
{
    class Program
    { static string Method2(string str, params int[] n)
        { int sum = 0;
            for (int i=0; i<n.Length; i++)
            {
                sum += n[i];
            }
            if (sum >= 20)
            {
                return str;
            }
            return "Sorry but the sum is:" + sum;
        }
        static void Main(string[] args)
        {
            string str = "The sum is >=20";
            Console.WriteLine(Method2(str, 5, 6, 4));
            Console.WriteLine(Method2(str, 5, 6, 4,40));
        }
    }
}
