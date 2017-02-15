using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz2_Lesson_5_6_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the word, please");
            string test = Console.ReadLine();
            Console.WriteLine("Your word is: ");
            for (int i = 0; i < test.Length; i++)
            {
                Console.Write(test[i]);

            }
            Console.WriteLine();
            for (int i = 0; i < test.Length / 2; i++)
            {

                if (test[i] != test[test.Length - i - 1])
                {
                    Console.WriteLine("It is not a palindrom");

                }
                else Console.WriteLine("It is a palindrom");
                break;
            }

        }
    }
}

