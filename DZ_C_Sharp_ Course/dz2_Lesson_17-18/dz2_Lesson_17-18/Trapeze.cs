using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz2_Lesson_17_18
{
    class Trapeze : Shape
    {
        private Point coordA;
        private Point coordB;
        private Point coordC;
        private Point coordD;


        public Trapeze(Point coordA, Point coordB, Point coordC, Point coordD)
        {
            this.coordA = coordA;
            this.coordB = coordB;
            this.coordC = coordC;
            this.coordD = coordD;
            //SideLength();
        }
        public double [] SideLength()
        {
            double[] sideLengh = new double[4];
            sideLengh[0] = Math.Sqrt(Math.Pow((coordB.X - coordA.X), 2) + Math.Pow((coordB.Y - coordA.Y), 2));
            sideLengh[1] = Math.Sqrt(Math.Pow((coordA.X - coordD.X), 2) + Math.Pow((coordA.Y - coordD.Y), 2));
            sideLengh[2] = Math.Sqrt(Math.Pow((coordD.X - coordC.X), 2) + Math.Pow((coordD.Y - coordC.Y), 2));
            sideLengh[3] = Math.Sqrt(Math.Pow((coordB.X - coordC.X), 2) + Math.Pow((coordB.Y - coordC.Y), 2));
           
           /* for (int i=0; i<4; i++)
            { 
                Console.WriteLine(sideLengh[i] + " ");
            }
           */
                return sideLengh;
            
        }
        public double Perimeter()
        {
            double perimeter = 0;
            double[] sideLengh = new double[4];
            sideLengh[0] = Math.Sqrt(Math.Pow((coordB.X - coordA.X), 2) + Math.Pow((coordB.Y - coordA.Y), 2));
            sideLengh[1] = Math.Sqrt(Math.Pow((coordA.X - coordD.X), 2) + Math.Pow((coordA.Y - coordD.Y), 2));
            sideLengh[2] = Math.Sqrt(Math.Pow((coordC.X - coordD.X), 2) + Math.Pow((coordC.Y - coordD.Y), 2));
            sideLengh[3] = Math.Sqrt(Math.Pow((coordB.X - coordC.X), 2) + Math.Pow((coordB.Y - coordC.Y), 2));
            Console.WriteLine("\nSideLength:");
            for (int i = 0; i < 4; i++)
            {Console.Write(sideLengh[i] + " "); }
            
           
            for (int i = 0; i < 4; i++)
            {
                perimeter += sideLengh[i];
            }

            // Console.WriteLine("Perimeter: "+ perimeter);
            return perimeter;
        }
        public double Area()
        {
            double area = 0;
            double[] sideLengh = new double[4];
            sideLengh[0] = Math.Sqrt(Math.Pow((coordB.X - coordA.X), 2) + Math.Pow((coordB.Y - coordA.Y), 2));
            sideLengh[1] = Math.Sqrt(Math.Pow((coordA.X - coordD.X), 2) + Math.Pow((coordA.Y - coordD.Y), 2));
            sideLengh[2] = Math.Sqrt(Math.Pow((coordC.X - coordD.X), 2) + Math.Pow((coordC.Y - coordD.Y), 2));
            sideLengh[3] = Math.Sqrt(Math.Pow((coordB.X - coordC.X), 2) + Math.Pow((coordB.Y - coordC.Y), 2));


            area = Math.Abs((0.25 * (sideLengh[2] + sideLengh[0]) / (sideLengh[2] - sideLengh[0]))* Math.Sqrt(Math.Abs((-sideLengh[0] + sideLengh[2] + sideLengh[1] + sideLengh[3]) * (sideLengh[0] - sideLengh[2] + sideLengh[1] + sideLengh[3]) * (sideLengh[0] - sideLengh[2] + sideLengh[1] - sideLengh[3]) * (sideLengh[0] - sideLengh[2] - sideLengh[1] + sideLengh[3]))));


            // Console.WriteLine("Area: " + area);

            return area;
        }
        public bool IsTrapezeWithEqualSides()
        {
            double[] diagLength = new double[2];
            diagLength[0] = Math.Sqrt(Math.Pow((coordA.X - coordC.X), 2) + Math.Pow((coordA.Y - coordC.Y), 2));
            diagLength[1] = Math.Sqrt(Math.Pow((coordB.X - coordD.X), 2) + Math.Pow((coordB.Y - coordD.Y), 2));
            if (diagLength[0] == diagLength[1])
            {return true;}
             return false;}
        
        public override void ToString()
        {
      Console.WriteLine(  " \nArea: " + Area() + " \nPerimeter: " + Perimeter() + " \nIt is trapeze with euqual sides: " + IsTrapezeWithEqualSides());
       
        }
    }
}
