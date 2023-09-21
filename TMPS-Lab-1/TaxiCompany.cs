using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMPS_Lab_1
{
    internal class TaxiCompany
    {
        public List<Car> cars = new List<Car>();
        public List<Driver> drivers = new List<Driver>();
        public List<Client> clients = new List<Client>();
        public List<Order> orders = new List<Order>();

        public List<Car> GetCars()
        {
            return cars;
        }
        public List<Order> GetOrders()
        {
            return orders;
        }
        public List<Client> GetClients()
        {
            return clients;
        }

        public void AddCar(string model, int year, Engine engine)
        {
            cars.Add(new Car(cars.Count + 1, model, year, engine));
        }

        public void AddDriver(string name, string surname, int age)
        {
            drivers.Add(new Driver(name, surname, age, age - 21));
        }
        public void AddClient(string name, string surname, int age, int money)
        {
            clients.Add(new Client(name, surname, age, money));
        }

        public void AddOrder(int distance)
        {
            orders.Add(new Order(orders.Count + 1, distance));
        }

        public void DisplayCars()
        {
            foreach (Car car in cars)
            {
                car.Describe();
            }
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
