using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7_incapsulation
{
    class Vector
 { 
        //private float _x;
     // public float x { get; set; }
        private float x;
        private float y;
        private float magn;


        public float X //property
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
                CalcMagnitude();
            }
        }

        public float Y//property
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
                CalcMagnitude();
            }
        }
      //   public float Magn { get; set; }//skorochena forma

        public float Magn
        {
            get
            {
              return  magn;
            }
        }

        public Vector(float x, float y)
        {
           // SetX(x);
           // SetY(y);
            this.x = x;
            this.y = y;
            CalcMagnitude();
        }


        public void PrintInfo()
        {
            Console.WriteLine("X: {0}\nY: {1}\nMagnitude: {2}", x, y, magn);
        }

       // public Vector() { };
        private void CalcMagnitude()
        {
            magn = (float)Math.Sqrt(x * x + y * y);
        }
        public void SetX(float x)
        {
            this.x = x;
            CalcMagnitude();
        }
        public float GetX()
        {
            return x;
        }
        public void SetY(float y)
        {
            this.y = y;
            CalcMagnitude();
        }
        public float GetY()
        {
            return y;
        }
        public float GetMagn()
        {
            return magn;
        }
        
    }
}
