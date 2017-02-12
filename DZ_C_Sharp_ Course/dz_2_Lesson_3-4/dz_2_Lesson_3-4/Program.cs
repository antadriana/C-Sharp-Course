using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_2_Lesson_3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter the radius:");
            float radius = float.Parse(Console.ReadLine());
            Console.WriteLine("The radius you've entered is: " + radius);
            float lengths = radius * 2* 3.14f;
            Console.WriteLine("The lenghs of a circle is " + lengths);
            

        }
    }
}
