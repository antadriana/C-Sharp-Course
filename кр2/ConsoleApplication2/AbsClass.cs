using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    abstract class AbsClass
    {
        protected string line;

        public string Line
        {
            get
            {
                return line;
            }

            set
            {
                line = value;
            }
        }
        public AbsClass(string line)
        {
            this.line = line;
        }
        public abstract string Rotate();
    }
}
