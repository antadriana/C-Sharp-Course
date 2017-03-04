using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_House
{
    class LivingArea
    {
        private float area;
        float price;
        float pricePerMeter;
        float externallArea;


        public float Area
        {
            get
            {
                return area;
            }

            set
            {
                area = value;
                CalcArea();
            }
        }
        public float Price
        {
            get { return price; }
        }

        public float PricePerMeter
        {
            get
            {
                return pricePerMeter;
            }

            set
            {
                pricePerMeter = value;
            }
        }

        public float ExternallArea
        {
            get
            {
                return externallArea;
            }

            set
            {
                externallArea = value;
            }
        }

        public LivingArea(float area, float externallArea, float pricePerMeter)
        {
            this.area = area;
            this.externallArea = externallArea;
            this.pricePerMeter=pricePerMeter;
            CalcPrice();
        }
        public void CalcArea()
        {
            area = area + ExternallArea;
        }
        public void CalcPrice()
        {
            price = PricePerMeter * area;
        }
        public void PrintInfo()
        {
            Console.WriteLine("Area: {0}\nExtArea: {1}\nPricePerMeter: {2}\nPrice: {3}", area, externallArea, pricePerMeter, price);
        }
    }
}
