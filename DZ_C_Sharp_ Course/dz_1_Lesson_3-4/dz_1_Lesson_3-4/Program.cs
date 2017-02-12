using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_1_Lesson_3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter three marks: ");
            float firstMark, secondMark, thirdMark;
            firstMark = float.Parse(Console.ReadLine());
            secondMark = float.Parse(Console.ReadLine());
            thirdMark = float.Parse(Console.ReadLine());

            Console.WriteLine("The first mark is: "+firstMark);
            Console.WriteLine("The second mark is: "+secondMark);
            Console.WriteLine("The thirs mark is: " +thirdMark);
            Console.WriteLine("The average value is: "+ ((firstMark+secondMark+thirdMark)/3));
        }
    }
}
