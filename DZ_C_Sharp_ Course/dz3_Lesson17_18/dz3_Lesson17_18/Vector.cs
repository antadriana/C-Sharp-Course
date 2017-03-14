using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz3_Lesson17_18
{
    class Vector
    {
        private double x;
        private double y;
        private double magn;

        public double X
        {
            get { return x; }
            set { x = value;
                CalcMagnitude();
            }
        }
        public double Y
        {
            get { return y; }
            set { y= value;
                CalcMagnitude();
            }
        }
       
        public double CalcMagnitude()
        {
            magn = Math.Sqrt(x * x + y * y);
            return magn;
        }
        public Vector() { }
        public Vector(double x, double y)
        {
            this.x = x;
            this.y = y;
            CalcMagnitude();
        }
        public override string ToString()
        {
            return " \n" + " X= " + x + " Y= " + y + " Magnitude: " + CalcMagnitude();
        }
    }
}
