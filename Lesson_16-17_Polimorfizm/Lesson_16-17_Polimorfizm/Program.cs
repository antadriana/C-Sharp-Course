using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_16_17_Polimorfizm
{
    class Program
    {
        static void Main(string[] args)
        {
            OutStream os = new OutStream();
            //os.Write("Hello outstream");


            ConsoleOutput co = new ConsoleOutput();
            co.Write("Hello console output");
            co.WriteLine("Hello console output");


            FileOutput fo = new FileOutput();
            fo.WriteLine("Hello, file:");

            OutStream os1 = co;
            os1.Write("Hello,console to out");


            Console.WriteLine("Please enter your line");
            string l = Console.ReadLine();
            Console.WriteLine("Please enter type of output:\n1 - Console\n2 - File");
            int action = int.Parse(Console.ReadLine());
            OutStream result = null;
            switch (action)
            {
                case 1:
                    ConsoleOutput tmpConsole = new ConsoleOutput();
                    result = tmpConsole;
                    break;
                case 2:
                    result = new FileOutput();
                    
                    break;
                default:
                    Console.Write("eRRor!");
                    break;

            }
            if (result == null) { }
            else
            {
                result.Connect();
                result.Write(l);
                result.Close();
            }


        }


    }
}
