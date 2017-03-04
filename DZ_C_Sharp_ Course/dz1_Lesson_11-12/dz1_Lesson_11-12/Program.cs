using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz1_Lesson_11_12
{
    class Program
    {
        static void Main(string[] args)
        {
            House h1 = new House(3, 5000, 30);
            h1.PrintInfo();
            h1.CalcPricePerMeter();
            House h2 = new House(6, 1000000, 24);
            h2.PrintInfo();
            h2.CalcPricePerMeter();
        }
    }
}
