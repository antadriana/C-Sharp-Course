using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Vector : IPrintable, ICloneable, IComparable<Vector>
    {
        private float _x;
        private float _y;
        private float _magn;

        public float X
        {
            get
            { return _x; }
            set
            {
                _x = value;
                CalcMagnitude();
            }
        }
        public float Y
        {
            get
            { return _y; }
            set
            {
                _y = value;
                CalcMagnitude();
            }
        }
        public float magnitude
        {
            get { return _magn; }
        }
        public Vector(float pX = 0, float pY = 0)
        {
            X = pX;
            Y = pY;
        }

        public void CalcMagnitude()
        {
            _magn = (float)Math.Sqrt(X * X + Y * Y);
        }

        public void Print()
        {
            Console.WriteLine("X={0}; Y={1}; Magnitude={2} ", X, Y, magnitude);
        }
        /*  public Vector TryClone()
          {
              return new Vector(X, Y);
          }*/
        public object Clone()
        {
            return new Vector(X, Y);
            //return Memberwiseclone
        }
        public int CompareTo(Vector v)
        {
            if (v == null) return 1;
       
           return magnitude.CompareTo(v.magnitude);
            
        }


    }
}
