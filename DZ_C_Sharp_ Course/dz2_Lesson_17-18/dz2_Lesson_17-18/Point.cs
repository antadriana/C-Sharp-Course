using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz2_Lesson_17_18
{
    class Point
    {
        private int x;
        private int y;

        public int X
        { get {return x; }}
          

        public int Y
        { get{ return y;} }
           
            
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
       
             
               public void Print()
        {
            Console.WriteLine("Point : x={0}, y={1}", x, y);
        }
            
    }
}
