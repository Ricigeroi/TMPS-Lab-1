using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMPS_Lab_1.Cars;
using TMPS_Lab_1.People;

namespace TMPS_Lab_1.Company
{
    internal class OrderService
    {
        public List<Order> orders = new List<Order>();
        public static void MakeOrder(Client client)
        {
            var company = TaxiCompany.GetInstance();
            
            Car car = TaxiCompany.GetInstance().carManager.FindCarByIdOrder(0);
            if (car != null)
            {
                Console.WriteLine("Found a car:");
                car.Describe();
                car.Run();
                company.AddOrder(new Random().Next(4, 20), car, car.GetDriver(), client);
                car.GetDriver().SetIdCar(car.GetIDCar());
            }
            
        }
    }
}
