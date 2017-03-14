using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    abstract class Computer
    {
       Motherboard motherboard;
        Display display;
        private string model;
        protected int price;

        public int Price
        {
            get
            {
                return price;
              }
            set { price = value; }
            
        }

        protected string Model
        {
            get
            {
                return model;
            }

            set
            {
                model = value;
            }
        }

        public Computer(string model, int price, Motherboard motherboard, Display display)
        {
            this.model = model;
            this.price = price;
            this.motherboard = motherboard;
            this.display = display;
        }
        public virtual void TurnON()
        {
            Console.WriteLine("Computer is turned on");
        }
        public virtual void TurnOf()
        {
            Console.WriteLine("Computer is turned of");
        }

        public override string ToString()
        {
            return "Model: " + model + "Price: " + price + "Display: " + display + "Motherload type "+ motherboard;
        }
    }
}
