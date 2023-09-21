using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMPS_Lab_1.Cars
{
    internal class Car : ICar
    {
        protected int id_car;
        protected string model;
        protected int year;
        protected IEngine engine;
        protected ITank tank;
        protected int id_order;

        public Car(int id_car, string model, int year, Engine engine, int id_order = 0)
        {
            this.id_car = id_car;
            this.model = model;
            this.year = year;
            this.engine = engine;
            tank = new Tank(engine.GetTypeOfEngine(), 40, 40);
            this.id_order = id_order;


        }

        public void Run()
        {
            engine.Start();
            tank.GetLevel();
            Console.WriteLine();
        }
        public void Describe()
        {
            Console.WriteLine("Car " + id_car + " " + model + " " + year);
        }

        public int GetIdOrder()
        {
            return id_order;
        }
    }
}
