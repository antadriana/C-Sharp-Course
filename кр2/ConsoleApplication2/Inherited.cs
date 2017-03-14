using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Inherited:AbsClass
    {
        public Inherited(string line):base (line){}

        public  string [] Split()
        {
            // string[] temp = new string[20];
            string[] tmp = line.Split(' ');
            
            return tmp;
        }
        public override string Rotate()
        { 
            string[] tmp = line.Split(' ');
            string[] newArr = new string[tmp.Length];
            Stack<string> stack = new Stack<string>();
            for (int i=0; i<tmp.Length; i++)
            {
                stack.Push(tmp[i]);
            }
            for (int i=0;i<tmp.Length; i++)
            {
                newArr[i] = stack.Pop();
            }
            /*for (int i = 0; i < tmp.Length; i++)
            {
                Console.WriteLine(newArr[i]);
            }*/
            string line2 = " ";
            for (int i = 0; i < tmp.Length; i++)
            {
                line2 +=( newArr[i]+" ");
            }
            Console.WriteLine(line2);
            return line2;
        }
        

    }
}
