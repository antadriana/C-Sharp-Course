using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer c1=new Computer("Lenovo", "AMD 123345",8196);
           // c1.model = "Lenovo";
            //c1.proc = "AMD 123345";
           // c1.ram = 8196;
           // Console.WriteLine("{0} {1} {2}", c1.model, c1.proc, c1.ram);
            Computer my = new Computer("Asusu","i7- 123345", 45678);
          ////  my.model = "Asusu";
           // my.proc = "i7- 123345";
           // my.ram = 45678;
           //             Console.WriteLine("{0} {1} {2}", my.model, my.proc, my.ram);
            c1.PrintInfo();
            my.PrintInfo();

            //Random rand = new Random();
           // Random.
        }
    }
}
