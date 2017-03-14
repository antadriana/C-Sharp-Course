using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz1_Lesson_13_14
{
    class Program
    {
        static void Main(string[] args)
        { Console.WriteLine("Enter The number of marks");
          int n=int.Parse(Console.ReadLine());
         int[] marks = new int[n];
         for(int i = 0; i < n; i++)
           {
           marks[i] = int.Parse(Console.ReadLine());
         }

   Student person1 = new Student("Andrew", "Lviv",marks );
            person1.PrintInfo();

            Console.WriteLine("\nEnter The number of marks ");
            int m = int.Parse(Console.ReadLine());
            int[] marks2 = new int[m];
            for (int i = 0; i < m; i++)
            {
                marks2[i] = int.Parse(Console.ReadLine());
            }

            Student person2 = new Student("Katy", "Lviv", marks2);
            int[] tmp = person2.Marks;
            tmp[0] = 412;
            person2.PrintInfo();
        }
    }
}
