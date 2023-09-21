using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMPS_Lab_1.Cars
{
    internal class Tank : ITank
    {
        protected string type;
        protected int capacity;
        protected int level;

        public Tank(string type, int capacity, int level)
        {
            this.type = type;
            this.capacity = capacity;
            this.level = level;
        }

        public void GetLevel()
        {
            Console.WriteLine(type + " level: " + level + "/" + capacity);
        }
    }
}
