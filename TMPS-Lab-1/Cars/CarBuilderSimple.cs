using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMPS_Lab_1.Cars
{
    internal class CarBuilderSimple : IBuilder
    {
        Car car;

        public void Reset(Car car)
        {
            this.car = car;
        }

        public void AddABS()
        {
            this.car.AddPart("ABS system");
        }
        public void AddInterior()
        {
            this.car.AddPart("Textil Interior");
        }

        public void AddClimate()
        {
            this.car.AddPart("Manual conditioner and heater");
        }

        public void AddMultimedia()
        {
            this.car.AddPart("CD player");
        }

        public Car GetCar()
        {
            return this.car;
        }
    }
}
