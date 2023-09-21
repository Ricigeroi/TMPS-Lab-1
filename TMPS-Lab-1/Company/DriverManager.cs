using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMPS_Lab_1.Cars;
using TMPS_Lab_1.People;

namespace TMPS_Lab_1.Company
{
    internal class DriverManager
    {

        public List<Driver> drivers = new List<Driver>();


        public void AddDriver(string name, string surname, int age)
        {
            drivers.Add(new Driver(name, surname, age, age - 21));
        }

        public Driver FindDriverByIdCar(int idOrder)
        {
            return drivers.FirstOrDefault(driver => driver.GetIdCar() == idOrder);
        }

        public void DisplayDrivers()
        {
            foreach (Driver driver in drivers)
            {
                driver.Describe();
            }
        }
    }
}
