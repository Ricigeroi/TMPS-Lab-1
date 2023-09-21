using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMPS_Lab_1
{
    internal class Car
    {
        protected int id_car;
        protected string model;
        protected int year;
        protected IEngine engine;
        protected int id_order;
        
        public Car (int id_car, string model, int year, Engine engine, int id_order = 0)
        {
            this.id_car = id_car;
            this.model = model;
            this.year = year;
            this.engine = engine;
            this.id_order = id_order;

            
        }

        public void Run()
        {
            this.engine.Start();
        }
        public void Describe()
        {
            Console.WriteLine("Car " + id_car + " " + model + " " + year);
        }
    }
}
