using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
                /*
                int num = int.Parse(Console.ReadLine());
             if (num%100==0) {
                    Console.WriteLine("dil na 100");
                }
             else if (num%36==0) { Console.WriteLine("dil na 36"); }
             else if (num % 9 == 0) { Console.WriteLine("dil na 9"); }
                switch (num%2)
                {
                    case 0:
                        Console.WriteLine("Parne");
                        break;
                    case 1:
                        Console.WriteLine("Neparne");
                        break;

                }*/
                Console.WriteLine("Enter your drink");
                string drink = Console.ReadLine().ToLower().Trim();
                //  coffee = coffee.ToLower();
                //  coffee = coffee.Trim();
                switch (drink)
                {
                    case "latte":
                    case "late"
    :
                        Console.WriteLine("Here is your Latte; $20");
                        break;
                    case "americano":
                    case "ameriano":
                    case "amerikano":
                        Console.WriteLine("Here is your Americano; $15");
                        break;
                    case "espresso":
                    case "expresso":
                    case "eckspreso":
                    case "espreso":
                        Console.WriteLine("Here is your Espresso; $12");
                        break;
                    default:
                        string newDrink = drink.Contains("tea") ? "tea" : drink;
                        if (newDrink == "tea")
                        {
                            Console.WriteLine("Here is your tea");

                        }
                        else Console.WriteLine("Wrong name");
                        // Console.WriteLine("Wrong coffee name!Try again...");
                        break;
                }
            }
        }
    }

    

