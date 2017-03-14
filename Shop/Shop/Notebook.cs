using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Notebook:Computer
    {
        private int weight;

        protected int Weight
        {
            get
            {
                return weight;
            }

            set
            {
                weight = value;
            }
        }
        public Notebook(string model, int price,int weight, Display display, Motherboard motherboard): base(model, price, motherboard, display)
        {
            this.weight = weight;
        }

        public override void TurnON()
        {
            Console.WriteLine("Notebook is turned on");
        }
        public override void TurnOf()
        {
            Console.WriteLine("Notebook is turned of");
        }
    }
}
