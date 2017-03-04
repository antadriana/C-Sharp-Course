using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_14_15
{
    class Car
    {
        private string model;
        private int numOfWheels;

        public Car(string m="none", int num = 4)
        {
            model = m;
            numOfWheels = num;
        }
        public void PrintInfo()
        {
            Console.WriteLine("car model: {0}\nnum of wheels: {1}", model, numOfWheels);
        }
    }
}
