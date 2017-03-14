using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz1_Lesson_19_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckForEvenNumberOf1("fh1g   1 u 1jhjk1 j1hh1njk1jk11kj11;"));
        }
            public static bool CheckForEvenNumberOf1(string line)
        {
            Stack<char> temp = new Stack<char>();
            for(int i=0;i<line.Length; i++)
            {
                if (line[i] =='1')
                {
                    temp.Push(line[i]);
                }
            }
            if (temp.Count() % 2 == 0) { return true; }
            
            return false;
        }
        }
    }
