using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMPS_Lab_1.Cars;
using TMPS_Lab_1.People;

namespace TMPS_Lab_1
{
    internal class Program
    {
        public static int Main()
        {
            // Company
            TaxiCompany company = new TaxiCompany();

            // Drivers
            company.AddDriver("Domenic", "Torreto", 34);

            // Clients
            company.AddClient("Andrei", "Bardier", 20, 10000);

            // Engines
            Engine prius_engine = new("petrol-hybrid", 140);
            Engine zoe_engine = new("electric", 250);
            Engine dacia_engine = new("diesel", 90);

            // Cars
            company.AddCar("Toyota Prius", 2012, prius_engine);
            company.AddCar("Renault Zoe", 2018, zoe_engine);
            company.AddCar("Dacia Logan", 2007, dacia_engine);

            




            foreach (Car car in company.GetCars())
            {
                car.Run();

            }

            foreach(Client client in company.GetClients())
            {
                client.MakeOrder(company);
            }
            
            foreach(Order order in company.GetOrders())
            {
                order.Describe();
            }

            return 0;
        }
    }
}
