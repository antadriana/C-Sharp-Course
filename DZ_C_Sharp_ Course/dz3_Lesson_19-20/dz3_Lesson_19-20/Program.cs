using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz3_Lesson_19_20
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3,0, 3, 2, 1 };
            Console.WriteLine(IsSymetric(arr));
        }

        public static bool IsSymetric(int [] arr)
        {
            Stack<int> tmp = new Stack<int>();
           
            int count2 = arr.Length-1;
        
            for (int i = 0; i < arr.Length/2; i++)
                
            {
                if ((arr[i] == arr[count2 - i] )&&(arr[arr.Length/2]==0) )
                {
                    tmp.Push(arr[i]);
                }
                else return false;
            }           
           
            return true;
        }
    }
}
