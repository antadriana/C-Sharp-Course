using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Display
    {
        int diag;

        public int Diag
        {
            get
            {
                return diag;
            }

            set
            {
                diag = value;
            }
        }
        public Display(int diag)
        {
            this.diag = diag;
        }
    }
}
