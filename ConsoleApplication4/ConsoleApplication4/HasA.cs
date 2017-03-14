using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class HasA:MainClass
    {
        private int a;
        public HasA (int a, IsA i) : base(i)
        {
            this.a = a;
        }
    }
}
