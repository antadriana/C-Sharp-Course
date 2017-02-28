using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7._1
{
    class House
    {   private static  float pricePerMeter=220;
        // private int numOfRooms;
        // private Room[] rooms;
        private Room[] rooms = new Room[10];
        private float mArea=0;
        private int numOfBathrooms;
        private float mPrice=0;
        private int roomCount = 0;

       /* public int _numOfRooms
        {
            get { return numOfRooms;}
            set { numOfRooms = value; }
        }*/
        private float area
        {
            get { return mArea; }
            set { mArea = value;
                CalcPrice();
            }
        }
        public int _numOfBathrooms
        {
            get { return numOfBathrooms; }
            set { numOfBathrooms = value; }
        }

        public float _price
        {
            get { return mPrice;  }
            
        }
        public House (float area)
        {
            this.area = area;

        }
        public void AddRoom(Room room)
        {
            rooms[roomCount] = room;
            roomCount++;
            area += room.area;
        }
        public void AddRoom(float area)
        {
            rooms[roomCount] = new Room(area);
            roomCount++;
            this.area += area;
        }
        public House(/*int numOfRooms, */float area, int numOfBathrooms)
        {
           
            //this.numOfRooms = numOfRooms;
            this.area = area;
            this.numOfBathrooms =numOfBathrooms;
            CalcPrice();
        }

        public void CalcPrice()
        {
            mPrice = pricePerMeter * area;
        }
        public void AddRoom(Room[] _room, int n)
        {
            Room[] room = new Room[n];
        }
        public void printInfo()
        {
            Console.WriteLine("The numb of rooms is: {0}\nThe area is: {1}\nNumber of bathrooms is: {2}\nPrice is: {3}",/* numOfRooms,*/ area, numOfBathrooms, mPrice);
        }
        public void print()
        { Console.WriteLine("Area: {0}\nPrice: ${1}", area, mPrice);
            for (int i = 0; i < roomCount; i++) { Console.WriteLine("Room: {0}\n }
        }
}
