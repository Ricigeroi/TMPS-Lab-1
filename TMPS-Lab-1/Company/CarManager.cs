using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMPS_Lab_1.Cars;

namespace TMPS_Lab_1.Company
{
    internal class CarManager
    {
        private List<Car> cars = new List<Car>();
        private TaxiCompany company;

        public CarManager(TaxiCompany company)
        {
            this.company = company;
        }

        public void AddCar(string model, int year, Engine engine)
        {
            cars.Add(new Car(company, cars.Count + 1, model, year, engine));
        }

        // Search for a car by id_order
        public Car FindCarByIdOrder(int idOrder)
        {
            return cars.FirstOrDefault(car => car.GetIdOrder() == idOrder);
        }

        public List<Car> GetCars()
        {
            return cars;
        }


        public void DisplayCars()
        {
            foreach (Car car in cars)
            {
                car.Describe();
            }
        }
    }
}
