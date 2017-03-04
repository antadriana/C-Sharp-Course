using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_House
{
    class Villa:LivingArea
    {
        string type;

        public Villa(float area, float externallArea, float pricePerMeter, string type):base (area, externallArea,pricePerMeter)
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
            }
        }
    }
}
