using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMPS_Lab_1.People
{
    internal class Driver : Person, IDriver
    {
        private int exp;
        private int id_car;


        public Driver(string name, string surname, int age, int exp, int id_car = 0) : base(name, surname, age)
        {
            this.exp = exp;
            this.id_car = id_car;
        }


        public void Drive()
        {
            Console.WriteLine("Driver " + name + " " + surname + " drives!");
        }


        public void GetInfo()
        {
            Console.WriteLine(name + " " + surname + " | Id car: " + id_car);
        }
        public override string Describe()
        {
            return "Driver: " + name + " " + surname;
        }


        public int GetIdCar()
        {
            return id_car;
        }
        public void SetIdCar(int id_car)
        {
            this.id_car = id_car;
        }
    }
}
