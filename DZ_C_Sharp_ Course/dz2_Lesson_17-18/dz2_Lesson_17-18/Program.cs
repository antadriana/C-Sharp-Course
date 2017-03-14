using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz2_Lesson_17_18
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(-2, 3);
            Point p2 = new Point(2, 4);
            Point p3 = new Point(4, 0);
            Point p4 = new Point(-4, 0);

            Point k1 = new Point(-3, 2);
            Point k2 = new Point(5, 5);
            Point k3 = new Point(2, -3);
            Point k4 = new Point(-1, 4);

            Point  i1= new Point(-2, 3);
            Point i2 = new Point(2, 1);
            Point i3 = new Point(0, 3);
            Point i4 = new Point(-2, -3);

            Point a1 = new Point(-2, 3);
            Point a2 = new Point(-2, 3);
            Point a3 = new Point(-2, 3);
            Point a4 = new Point(-2, 3);


           //Trapeze t1 = new Trapeze(p1, p2, p3, p4);
            //t1.Perimeter();
            //t1.Area();
            //t1.IsTrapezeWithEqualSides();
           // t1.ToString();


            Trapeze[] arr = new Trapeze[3];
            arr[0] = new Trapeze(k1, k2, k3, k4);
            //arr[0].ToString();
            arr[1] = new Trapeze(i1, i2, i3, i4);
            arr[2] = new Trapeze(p1, p2, p3, p4);

            for(int i=0;i<arr.Length; i++)
            {
                arr[i].ToString();
            }
            double ave = 0;
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                ave += arr[i].Area();
                count++;
            }
            ave = ave / count;
            Console.WriteLine("\n\naverage area:{0} ",ave);

            Console.WriteLine("\nTrapezes with Area more than average area: ");
            int c = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Area() >= ave)
                {
                    arr[i].ToString();c++;
                }
            }
            Console.WriteLine("\nthere are {0} trapezes with area bigger than average", c);
        }
    }
}
