using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz3_Lesson17_18
{
    class Program
    {
        static void Main(string[] args)
        { Vector v1 = new Vector(2, 3);
            // Console.WriteLine(v1);
            int n = 10;
            Vector[] arr = new Vector[n];
            for (int i=0;i<n; i++)
            {
                 arr[i] = new Vector();
            }
            
            for (int i=0; i<n; i++)
            {
                Console.WriteLine("Enter the coordinates of {0} vector: ", i+1);
                arr[i].X = float.Parse(Console.ReadLine());
                arr[i].Y = float.Parse(Console.ReadLine());

            }
            Console.WriteLine("\nInformation about all your vectors");
            for (int i=0;i<n; i++)
            {
                Console.WriteLine("Vector {0}: ", i);
                Console.WriteLine(arr[i]);
            }

            Console.WriteLine(" \nVectors with magnitude more than 5:");

            for (int i = 0; i < n; i++)
            {
                if (arr[i].CalcMagnitude() > 5) { Console.WriteLine(arr[i]); }
            }

        }
    }
}
