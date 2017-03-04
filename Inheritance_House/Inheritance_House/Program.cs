using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_House
{
    class Program
    {
        static void Main(string[] args)
        {
            LivingArea l1 = new LivingArea(56, 78, 78);
            l1.PrintInfo();
            House h1 = new House(34, 45, 43, "Two-storey");
            h1.PrintInfo();
        }
    }
}
