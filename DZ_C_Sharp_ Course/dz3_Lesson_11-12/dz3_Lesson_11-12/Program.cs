using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz3_Lesson_11_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.PrintInfo();
            person1.PersonIsAlive();


            Person person2 = new Person("mary");
            person2.PrintInfo();

            Person person3 = new Person("kate", "alley", 34.5f, 35);
            person3.PrintInfo();

            Person person4 = new Person(35);
            person4.PrintInfo();
            person4.PersonIsAlive();

            Person person5 = new Person(person3);
            person3.PrintInfo();

        }
    }
}
