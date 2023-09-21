using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMPS_Lab_1.Cars;
using TMPS_Lab_1.Company;
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
            company.driverManager.AddDriver("Domenic", "Torreto", 34);

            // Clients
            company.clientManager.AddClient("Andrei", "Bardier", 20, 10000);

            // Engines
            Engine prius_engine = new("petrol-hybrid fuel", 140);
            Engine zoe_engine = new("electricity", 250);
            Engine dacia_engine = new("diesel fuel", 90);

            // Cars
            company.carManager.AddCar("Toyota Prius", 2012, prius_engine);
            // company.carManager.AddCar("Renault Zoe", 2018, zoe_engine);
            // scompany.carManager.AddCar("Dacia Logan", 2007, dacia_engine);

            

            foreach(Client client in company.clientManager.GetClients())
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
