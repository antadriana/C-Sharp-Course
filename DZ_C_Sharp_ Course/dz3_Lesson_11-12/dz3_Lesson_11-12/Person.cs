using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz3_Lesson_11_12
{
    class Person
    {
        private string name;
        private string surname;
        private float height;
        private int age;
        //private string isAlive;
        private bool isAlive;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Surname
        {
            get
            {
                return surname;
            }

            set
            {
                surname = value;
            }
        }

        public float Height
        {
            get
            {
                return height;
            }

            set
            {
                height = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }
        public Person(string name, string surname, float height, int age)
        {
            this.name = name;
            this.surname = surname;
            this.height = height;
            this.age = age;
        }
        public Person() : this("None", "None", 0, 0) { }
        public Person(string name) : this(name, "Unknown", 0, 0) { }
        public Person(int age) : this("Unknown", "Unknown", 0, age) { }
        public Person(Person obj) : this(obj.name, obj.surname, obj.height, obj.age) { }

        public void PersonIsAlive()
        {
            if (age > 0) { isAlive = true;
            Console.WriteLine("Alive person"); }
            else Console.WriteLine("Person doesn't exist");
            }
        
        public void PrintInfo()
        {
            Console.WriteLine("\nname: {0}\nsurname: {1}\nheight: {2}\nage: {3}", name, surname, height, age);
        }
    }
}
