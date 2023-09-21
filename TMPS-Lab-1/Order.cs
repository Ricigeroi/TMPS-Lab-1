using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMPS_Lab_1.People;
using TMPS_Lab_1.Cars;

namespace TMPS_Lab_1
{
    internal class Order
    {
        public int Id { get; set; }
        private int distance;
        private ICar car;
        private IDriver driver;
        private IClient client;

        public Order(int id, int distance, Car car, Driver driver, Client client)
        {
            this.Id = id;
            this.distance = distance;
            this.car = car;
            this.driver = driver;
            this.client = client;
        }

        public void Describe()
        {
            Console.WriteLine("Order " + Id + ". Distance: " + distance);
        }
    }
}
