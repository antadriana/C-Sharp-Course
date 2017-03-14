using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Motherboard
    {
        string type;


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

        public Motherboard(string type)
        {
            this.type = type;
        }
    }
}
