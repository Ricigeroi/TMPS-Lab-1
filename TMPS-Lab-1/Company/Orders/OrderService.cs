using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMPS_Lab_1.Cars;

namespace TMPS_Lab_1.Company
{
    internal class OrderService
    {
        public static void MakeOrder()
        {
            Car car = TaxiCompany.GetInstance().carManager.FindCarByIdOrder(0);
            if (car != null)
            {
                Console.WriteLine("Found a car:");
                car.Describe();
                car.Run();
            }
            
        }
    }
}
