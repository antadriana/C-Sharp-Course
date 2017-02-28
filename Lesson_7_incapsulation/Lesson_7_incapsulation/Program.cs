using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7_incapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector v1 = new Vector(3, 4);
            //v1.SetX(150);
            v1.X = 150;
            Console.WriteLine(v1.X);
            v1.PrintInfo();

            Vector v2 = new Vector() { X = 150, Y = 35 };

        }
    }
}
