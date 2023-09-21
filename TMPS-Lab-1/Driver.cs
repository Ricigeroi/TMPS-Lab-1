﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMPS_Lab_1
{
    internal class Driver : Person
    {
        private int exp;

        public Driver(string name, string surname, int age, int exp) : base(name, surname, age)
        {
            this.exp = exp;
        }

        public void Drive()
        {
            Console.WriteLine("Driver " + name + " " + surname + " drives!");
        }
    }
}
