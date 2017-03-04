using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz2_Lesson_11_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Product[] product = new Product[6];
            product[0]= new Product("book", "for children", 50);
            product[1] = new Product("magazine", "for children");
            product[2] = new Product("paper", "for children", 1.5f);
            product[3] = new Product("book", "16+", 72);
            product[4] = new Product("phone", "for children");
            product[5] = new Product("computer", "16+");
            for (int i=0; i<6; i++)
            {
               if(product[i]._category=="for children")
                {
                    product[i].PrintInfo();
                }
            }
        }
    }
}
