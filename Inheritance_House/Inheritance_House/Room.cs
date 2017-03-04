using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_House
{
    class Room:House
    {
        //string type;
        int numOfBeds;
        public Room(float area float pricePerMeter, string type, int numOfBeds):base (area, externallArea,pricePerMeter)
        public int NumOfBeds
        {
            get
            {
                return numOfBeds;
            }

            set
            {
                numOfBeds = value;
            }
        }
    }
}
