using System;


namespace Lesson_2_3_1
{
    class Program
    {
        static void Main(string[] args)
        {   
            string product1, product2, product3;
            float price1, price2, price3;
            string name1;
            Console.WriteLine("Please, enter the products: ");
            product1 = Console.ReadLine();
            product2 = Console.ReadLine();
            product3 = Console.ReadLine();

            Console.WriteLine("Please, enter the prices: ");
            price1 = float.Parse(Console.ReadLine());
            price2 = float.Parse(Console.ReadLine());
            price3 = float.Parse(Console.ReadLine());

            Console.WriteLine("Please, enter the waiter: ");
            name1 = Console.ReadLine();
            Console.WriteLine("Bill:" + " " + name1 + "\n" +" "+product1 + " $" + price1);
            Console.WriteLine( " "+product2 + " $" + price2);
            Console.WriteLine( " " + product3 + " $" + price3);
            Console.WriteLine("____________________________");
            Console.WriteLine("sum:" + " $" + (price1 + price2 + price3));
        }
    }
}
