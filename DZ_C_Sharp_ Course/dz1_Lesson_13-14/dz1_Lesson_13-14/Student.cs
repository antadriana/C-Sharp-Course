using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz1_Lesson_13_14
{
    class Student
    {
        private string pib;
       // private int n;
        private int[] marks;
        private float averageMark;
        private string address;

        public string Pib
        {
            get {return pib; }
            set {pib = value; }   
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public float AverageMark
        {
            get { return averageMark; }
        }

        public int[] Marks
        {
            get {return marks; }
         }

        public Student(string pib, string address, int[] marks)
        {
            this.pib = pib;
            this.address = address;

            this.marks = marks;
                CalcAvg();

        }
           public void CalcAvg()
        {
            float temp = 0f;
            float counter = 0f;
            for (int i=0; i<marks.Length; i++)
            {
                temp += marks[i];
                counter++;
            }
            averageMark = temp / counter;
            
        }
        public void PrintInfo()
        {
            Console.WriteLine("PIB:  {0}\nAddress: {1}", pib, address);
            Console.Write("Marks: ");
            foreach(int k in marks)
            {
                Console.Write( k + " ");
            }
            Console.WriteLine("\nAverage Mark: {0}", averageMark);
        }
            
        
    }
}
