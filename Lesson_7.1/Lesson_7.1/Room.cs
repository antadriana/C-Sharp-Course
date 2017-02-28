using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7._1
{
    class Room
    {
       // private float area;
        private float mArea;

        public float area
        {
            get { return mArea; }
           // set { area = value; }
        }

        public Room(float area)
        {
            mArea = area;
        }
    }
}
