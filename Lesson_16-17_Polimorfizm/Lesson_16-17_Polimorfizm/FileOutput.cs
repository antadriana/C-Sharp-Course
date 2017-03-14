using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_16_17_Polimorfizm
{
    class FileOutput:OutStream
    {
        public override void Write(string line = "")
        {
            Console.WriteLine("File1 t1.txt START:\n" + line + "End");
        }

        public new void WriteLine(string line = "")
        {
            Console.WriteLine("File1 t1.txt START:\n" + line + "End");
        }
        public new bool TryWrite(string line = "")
        {
            Console.WriteLine("File1 t1.txt START:\n" + line + "End");
                return true;
        }

        public override void Connect()
        {
            Console.WriteLine("File Opened");
        }
        
        public override void Close()
        {
            Console.WriteLine("File Closed");
        }
    }
}
