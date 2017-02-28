using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz1_Lesson_9_10
{
    class Program
    { static int FindInArray(ref int []array, ref int a)
            
        {for (int i=0; i<array.Length; i++)
            {
                if (array[i] == a)
                {
                    return i;
                }
               
            }
             return -1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter the length of array: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter the array: ");
            int[] array = new int[n];
            for(int i=0; i<n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(array[i]+" ");
            }
            Console.WriteLine("Please, enter number: ");
            int a = int.Parse(Console.ReadLine());
            int result = FindInArray(ref array, ref a);
            Console.WriteLine("The index of a number in array is: ");
            Console.WriteLine(result);

        }
    }
}
