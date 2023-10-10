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

        private List<Driver> drivers = new List<Driver>();


        public void AddDriver(string name, string surname, int age)
        {
            drivers.Add(new Driver(name, surname, age, age - 21));
        }

        public Driver FindDriverByIdCar(int idOrder, int id_car = 0)
        {
            if (idOrder == 0)
            {
                var driver = drivers.FirstOrDefault(driver => driver.GetIdCar() == idOrder);
                driver.SetIdCar(id_car);
                return driver;
            }
            else
            {
                return drivers.FirstOrDefault(driver => driver.GetIdCar() == idOrder);
            }
            
        }

        public List<Driver> GetDrivers()
        {
            return drivers;
        }

    }
}
