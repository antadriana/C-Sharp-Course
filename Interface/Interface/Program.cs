using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector v1=new Vector(10, 15);
            v1.Print();


            //  IPrintable toPrint = v1; //переводимо вектор  в Iprintable
            //toPrint.Print();

            // Vector v2 = new Vector(v1.X, v1.Y); //copy v1
            /*Vector v2 = v1.TryClone();
            v2.X = 100;
            v1.Print();
            v2.Print();
            */
            Vector v2 = v1.Clone() as Vector;
            v2.X = 100;
            v1.Print();
            v2.Print();

            List<Vector> vecs = new List<Vector>(new Vector[]
            {
                new Vector(0,0),
            new Vector(3, 3),
            new Vector(0,1),
            new Vector (100,100),
            new Vector(10,10),
            new Vector(3,3) });
           vecs.Sort();

            foreach(Vector v in vecs)
            {
                v.Print();
            }
        }
    }
}
