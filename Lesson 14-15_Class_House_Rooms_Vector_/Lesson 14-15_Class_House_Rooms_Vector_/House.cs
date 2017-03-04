using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_14_15_Class_House_Rooms_Vector_
{
    class House
    {
        private static float pricePerMeter = 200; 
 
 
         private float mPrice = 0; 
         public float price 
         { 
             get { return mPrice; } 
         } 
 
         private float mArea = 0; 
         private float area
         { 
             get { return mArea; } 
             set { mArea = value; mPrice = pricePerMeter* mArea; } 
         } 
 
 
         private Room[] rooms = new Room[10]; 
         private int roomCount = 0; 
 
 
         public House()
         { 
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
 
         public void Print()
         { 
             Console.WriteLine("Area: {0}\nPrice: ${1}", area, price); 
 
 
             for (int i = 0; i<roomCount; i++) 
             { 
                 Console.WriteLine("Room #{0} with area {1}m2", i + 1, rooms[i].area); 
             } 
        } 

    }
}
