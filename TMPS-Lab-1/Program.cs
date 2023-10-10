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
        public static void Main()
        {
            // Company
            // Using singleton method
            TaxiCompany company = TaxiCompany.GetInstance();

            // Drivers
            company.driverManager.AddDriver("Domenic", "Torreto", 34);
            company.driverManager.AddDriver("Ivan", "Ivanov", 32);

            // Clients
            company.clientManager.AddClient("Andrei", "Bardier", 20, 10000);

            // Engines
            // Prototype pattern
            Engine toyota_hybrid_engine = new("petrol-hybrid fuel", 140);
            Engine prius_engine = toyota_hybrid_engine.Copy();
            Engine auris_engine = toyota_hybrid_engine.Copy();
            
            // Engine zoe_engine = new("electricity", 250);
            // Engine dacia_engine = new("diesel fuel", 90);

            // Cars
            company.carManager.AddCar("Toyota Prius", 2012, prius_engine, "premium", false);
            company.carManager.AddCar("toyota Auris", 2010, auris_engine, "simple", true);
            
            // company.carManager.AddCar("Renault Zoe", 2018, zoe_engine);
            // scompany.carManager.AddCar("Dacia Logan", 2007, dacia_engine);


            foreach(Client client in company.clientManager.GetClients())
            {
                client.MakeOrder();
            }

            Console.WriteLine();
            Console.WriteLine("=======================");
            Console.WriteLine("Orders:");
            foreach(Order order in company.GetOrders())
            {
                order.Describe();
            }

            Console.WriteLine();
            Console.WriteLine("=======================");
            Console.WriteLine("Cars:");
            foreach (var car in company.carManager.GetCars())
            {
                car.Describe();
            }


            Console.WriteLine();
            Console.WriteLine("=======================");
            Console.WriteLine("Drivers:");
            foreach (Driver driver in company.driverManager.GetDrivers())
            {
                driver.GetInfo();
            }


        }
    }
}
