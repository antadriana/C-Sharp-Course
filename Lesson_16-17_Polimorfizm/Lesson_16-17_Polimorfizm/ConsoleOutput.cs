using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_16_17_Polimorfizm
{
    class ConsoleOutput:OutStream
    {public override void Write(string line = "")
        {
            Console.Write(line);
        }
        public new void WriteLine(string line = "")
        {
            Write(line);

        }
        public new bool TryWrite(string line = "")
        {
            Write(line);
            return false;
        }
        public override void Connect()
        {
            Console.WriteLine("Console Created");
        }

        public override void Close()
        {
            Console.WriteLine("Console Closed");
        }

    }
}
