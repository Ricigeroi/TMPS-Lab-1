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
        private TaxiCompany company;


        public OrderService(TaxiCompany company)
        {
            this.company = company;
        }


        public void MakeOrder()
        {
            Car car = company.carManager.FindCarByIdOrder(0);
            Console.WriteLine("Found a car:");
            car.Describe();
            car.Run();
        }
    }
}
