using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_House
{
    class House:LivingArea
    { string type;
        public House(float area, float externallArea, float pricePerMeter,string type):base (area, externallArea,pricePerMeter)
        {
            this.Type = type;
            base.PrintInfo();
        }

        public string Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
                Print();
            }

        }
        public void Print()
        {
            Console.WriteLine("Type: {0}", type);
        }
    }
}
