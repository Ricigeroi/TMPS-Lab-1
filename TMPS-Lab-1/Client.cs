using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMPS_Lab_1
{
    internal class Client : Person
    {
        private int money;
        
        public Client(string name, string surname, int age, int money) : base(name, surname, age)
        {
            this.name = base.name;
            this.surname = base.surname;
            this.age = base.age;
            this.money = money;
        }

        public void MakeOrder(TaxiCompany company)
        {
            Console.WriteLine("Client " + name + " " + surname + " have just made an order!");
            company.AddOrder(10);
        }
    }
}
