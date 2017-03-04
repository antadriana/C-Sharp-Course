using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_14_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee(4252, "gsdyh", 34,"sdkh", 56);
            e1.IncAge();
            e1.PrintInfo();
            e1.companyCar = new Car("audi", 4);

            e1.companyCar.PrintInfo();
           
        }
    }
}
