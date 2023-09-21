using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMPS_Lab_1
{
    internal class Person
    {
        protected string name;
        protected string surname;
        protected int age;

        public Person(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }

        public void Describe()
        {
            Console.WriteLine("Person " + name + " " + surname + " " + age + " years old");

        }
    }
}
