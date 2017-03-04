using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz2_Lesson_11_12
{
    class Product
    {
        private string name;
        private string category;
        private float price;

        public string _name {
            get { return name; }
            set { name = value; }
        }
        public string _category
        {
            get { return category; }
            set { category = value; }
        }
        public float _price
        {
            get { return price; }
            set { price = value; }
        }

       // public Product() { }
        public Product(string name="none", string category="none", float price = 0)
        {
            this.name = name;
            this.category = category;
            this.price = price;
        }
       
        public void PrintInfo()
        {
            Console.WriteLine("Name: {0}\nCategory: {1}\nPrice: {2}", name, category, price);
        }
    }
}
