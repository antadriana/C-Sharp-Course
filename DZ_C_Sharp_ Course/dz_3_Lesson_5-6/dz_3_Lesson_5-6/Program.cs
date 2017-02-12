using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_3_Lesson_5_6
{
    class Program
    {
        static void Main(string[] args)
        {
            float price;
            string time;
            float distance;
            float call = 30f;
            Console.WriteLine("Please, enter the day/night:");
            time = Console.ReadLine();
            Console.WriteLine("Please, enter the distance:");
            distance = float.Parse(Console.ReadLine());
            Console.WriteLine("Your time of a day is - " + time + ", your distance is " + distance + "km" + " and the price of a call is $30 during day (and $15at nights)");
            if (distance <= 10)
            {
                price = call + (5 * distance);
            }
            else if ((distance <= 20) && (distance > 10))
            {
                price = call + (4 * distance);
            }

            else { price = call + (3 * distance); }

            switch (time)
            {
                case "1":
                case "day":
                    price += 0;
                    break;
                case "2":
                case "night":
                    price = price / 2;
                    goto case "1";
            }

            Console.WriteLine("Your total price is :" + price);
        }
    }
}

