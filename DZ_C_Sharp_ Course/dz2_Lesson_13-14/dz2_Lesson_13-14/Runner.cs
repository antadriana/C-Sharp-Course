using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz2_Lesson_14_15
{
    class Runner
    {
        private string name;
        private float time;

        public string Name
        {
            get { return name; }
            //set{ name = value;}
        }

        public float Time
        {
            get { return time; }
            //  set { time = value; }
        }
        public Runner()
        {
            FillInfo();
        }
        public Runner(string name, float time)
        {
            this.name = name;
            this.time = time;
        }
        public void FillInfo()
        {

            name = Console.ReadLine();
            time = float.Parse(Console.ReadLine());
        }
        public void TheFastestRunner(Runner[] runner)
        {
            float temp = 0.0f;
            int count = 0;
            for (int i = 0; i < runner.Length; i++)
            {
                if (temp > runner[i].time) runner[i].time = temp;
                else temp = runner[i].time;
                count = i;

            }
            Console.WriteLine("\nThe Longest time on a distance is:" + temp + "\n" + "The runner with longest time is");
            runner[count].PrintInfo();
        }
        public void PrintInfo()
        {
            Console.WriteLine("Name: {0}\nTime of being on a distance is: {1}", name, time);
        }





    }
}
