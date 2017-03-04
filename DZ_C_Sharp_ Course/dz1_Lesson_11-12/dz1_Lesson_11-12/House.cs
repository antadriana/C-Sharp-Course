using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz1_Lesson_11_12
{
    class House
    {
        private int numOfRooms;
        private float price;
        private float area;
       // private float pricePerMeter;


        public House() { }
        public House(int numOfRooms, float price, float area)
        {
            this.numOfRooms = numOfRooms;
            this.price = price;
            this.area = area;
            //CalcPricePerMeter()

        }
       

        public int _numOfrooms
        {
            get
            {
                return numOfRooms;
            }
            set
            {
                numOfRooms = value;
            }
        }
        public float _price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
              //  CalcPricePerMeter();
            }
        }
        public float _area
        {
            get
            {
                return area;
            }
            set
            {
                area = value;
              //  CalcPricePerMeter();
            }
        }
      /*  public float _pricePerMeter
        {
            get { return pricePerMeter;}
        }*/
  public void CalcPricePerMeter()
        {
        float pricePerMeter = price / area;
            Console.WriteLine("Price per meter is : " + pricePerMeter+"\n");

        }
        public void PrintInfo()
        {
            Console.WriteLine("Number of rooms is: {0}\nPrice: {1}\nArea: {2}", numOfRooms, price,area);
        }
    }
}
