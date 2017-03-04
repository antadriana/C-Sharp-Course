using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_14_15
{
    class Person
    {
        private string fullName;
        public readonly long id;
        private int age;
         string nationality;

        public string FullName
        {
            get {return fullName;}
           
             set {fullName = value; }

         }

        public string Nationality
        {
            get
            {
                return nationality;
            }

            set
            {
                switch (value.ToLower())
                {
                    case "ua":
                    case "uk":
                    case "ukraine":
                        nationality = "ua";
                        break;
                    default:
                        nationality = "unknown";
                        break;

                }
            }
        }
            public void IncAge()
        {
            age++;
        }
        
    
                public Person(long id, string name="none", int age=0, string nat = "none")
    {
            Console.WriteLine("Called from Person const");
        this.id = id;
        fullName = name;
        this.age = age;
        Nationality = nat;
    }
        public void PrintInfo()
        {
            Console.WriteLine("Person id: {0}, FullName: {1}\nAge: {2}\nNat:: {3}/n", id, fullName, age, nationality);        
           
        
    }
}}
