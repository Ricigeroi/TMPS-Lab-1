using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMPS_Lab_1.Cars;
using TMPS_Lab_1.People;

namespace TMPS_Lab_1.Company
{
    internal class TaxiCompany
    {
        public List<Order> orders = new List<Order>();
        public CarManager carManager;
        public DriverManager driverManager;
        public ClientManager clientManager;

        public TaxiCompany()
        {
            this.carManager = new CarManager(this);
            this.driverManager = new DriverManager();
            this.clientManager = new ClientManager();

        }
        

        

        public List<Order> GetOrders()
        {
            return orders;
        }


        public void AddOrder(int distance, Car car, Driver driver, Client client)
        {
            orders.Add(new Order(orders.Count + 1, distance, car, driver, client));
        }
    }
}
