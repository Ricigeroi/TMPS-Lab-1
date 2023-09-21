using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMPS_Lab_1.Cars;

namespace TMPS_Lab_1
{
    internal class CarManager
    {
        private List<Car> cars = new List<Car>();

        public void AddCar(string model, int year, Engine engine)
        {
            cars.Add(new Car(cars.Count + 1, model, year, engine));
        }

        // Search for a car by id_order
        public Car FindCarByIdOrder(int idOrder)
        {
            // Use LINQ to find the car with the matching id_order
            return cars.FirstOrDefault(car => car.GetIdOrder() == idOrder);
        }
    }
}
