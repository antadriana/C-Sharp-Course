using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6_OOP
{
    class Computer
    {
        public string model;
        public string proc;
        public int ram;
        public bool isOn;

        public Computer() { }
       /* public Computer()
        {
            model = "Unknown";
            proc = "Unknown";
            ram = 0;
        }*/
        public Computer(string p_model, string p_proc, int p_ram)
        {
            model = p_model;
            proc = p_proc;
            ram = p_ram;
            
        }
        public void PrintInfo()
        {
            Console.WriteLine("Model: {0}\nProc: {1}\nRAM: {2}", model, proc, ram);
        }
        public void TurnOn()
        {
            isOn = true;
        }
        public void TurnOf()
        {
            isOn = false;
        }
    }
}
