using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMPS_Lab_1
{
    internal class Order
    {
        public int Id { get; set; }
        private int distance;

        public Order(int id, int distance)
        {
            this.Id = id;
            this.distance = distance;
        }

        public void Describe()
        {
            Console.WriteLine("Order " + Id + ". Distance: " + distance);
        }
    }
}
