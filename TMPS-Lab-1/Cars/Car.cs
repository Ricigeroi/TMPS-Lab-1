using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMPS_Lab_1.Company;
using TMPS_Lab_1.People;

namespace TMPS_Lab_1.Cars
{
    internal class Car : ICar
    {
        protected TaxiCompany company = TaxiCompany.GetInstance();
        protected int id_car;
        protected string model;
        protected int year;
        protected IEngine engine;
        protected ITank tank;
        protected IDriver driver;
        protected int id_order;
        protected List<object> parts = new List<object>();

        
        public Car(int id_car, string model, int year, Engine engine, int id_order = 0)
        {
            this.id_car = id_car;
            this.model = model;
            this.year = year;
            this.engine = engine;
            this.tank = new Tank(engine.GetTypeOfEngine(), 40, 40);
            this.driver = company.driverManager.FindDriverByIdCar(0);
            this.id_order = id_order;
        }
        
        public void AddPart(object part)
        {
            parts.Add(part);
        }

        public void ListParts()
        {
            foreach (object part in parts)
            {
                Console.WriteLine(part);
                Console.Write(part.GetType());
            }
        }

        public void Run()
        {
            engine.Start();
            tank.GetLevel();
            Console.WriteLine();
        }
        public void Describe()
        {
            Console.WriteLine();
            Console.WriteLine("Car " + id_car + " " + model + " " + year + " | " + driver.Describe());
            
            foreach(object part in parts)
            {
                Console.WriteLine(part);
            }
            Console.WriteLine();
        }

        public int GetIdOrder()
        {
            return id_order;
        }
    }
}
