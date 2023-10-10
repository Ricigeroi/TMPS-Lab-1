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
        private Director director = new Director();
        private CarBuilderSimple simple_builder = new CarBuilderSimple();
        private CarBuilderPremium premium_builder = new CarBuilderPremium();

        public void AddCar(string model, int year, Engine engine, string version, bool abs_system)
        {

            Car car = new Car(cars.Count + 1, model, year, engine);
            if (version == "premium")
            {
                director.Builder = premium_builder;
            }
            if (version == "simple")
            {
                director.Builder = simple_builder;
            }
            if (abs_system)
            {
                cars.Add(director.BuildCarWithABS(car));
            }
            else
            {
                cars.Add(director.BuildCarWithoutABS(car));
            }
            
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
