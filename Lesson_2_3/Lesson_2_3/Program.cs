using System;


namespace Lesson_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* float km = 15.9f;
             string val = Console.ReadLine();
             Console.WriteLine(val+" Line Readed");*/
            Console.WriteLine("Please, enter number of km");
            float km = float.Parse(Console.ReadLine());
            float m = km * 1000;
            Console.WriteLine("\a");
            Console.WriteLine("{2} km= {1} m", km, m, 15, "hello");
            Console.WriteLine($"{km} km={m} m");
                Console.WriteLine(km+"km= "+m+"m");
            Console.WriteLine("enter Pin:****\b\b\b\b");
            int pin = int.Parse(Console.ReadLine());

        }
    }
}
