using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_14_15
{
    class Employee:Person
    {
        public const float minsalary = 1300;
        public string Company { get; set; }
        private float salary;
        public Car companyCar;
        public float Salary

        {
            get { return salary; }
            set
            {
                if (value < minsalary)
                {
                    salary = minsalary;
                    Console.WriteLine("Warning!");
                }
                else salary = value;
            }
        }
        public Employee(long id, string name = "none", int age = 0, string company = "EPAM", float salary=1000):base(id,name, age)
        {
            Console.WriteLine("Called from Employee Constructor");
            Company = company;
            Salary = salary;
            base.PrintInfo();
            
        }
    }
}
