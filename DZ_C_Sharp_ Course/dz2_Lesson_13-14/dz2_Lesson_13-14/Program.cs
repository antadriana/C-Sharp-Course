using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz2_Lesson_14_15
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the number of runners, please");
            int n = int.Parse(Console.ReadLine());
            Runner[] runner = new Runner[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Please enter the name  and a time on a distance of {0} runner:", i + 1);
                runner[i] = new Runner();
            }
            for (int i = 0; i < n; i++)
            {
                runner[i].PrintInfo();
            }
            for (int i = 0; i < n; i++)
            {
                runner[i].TheFastestRunner(runner);
                break;
            }


        }
    }
}
