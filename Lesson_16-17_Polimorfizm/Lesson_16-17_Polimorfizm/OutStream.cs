using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_16_17_Polimorfizm
{
    class OutStream
    {
        public OutStream() { }
        public virtual void Write(string line = "")
        {
            Console.WriteLine("Error!You cant write to OutStream");
        }
        public void WriteLine(string line = "")
        {
            Write();

        }

        public bool TryWrite(string line = "")
        {
            Write();
            return false;
        }
        public abstract void Connect()
        {

        }
        public abstract void Close()
        {

        }
    }
}
