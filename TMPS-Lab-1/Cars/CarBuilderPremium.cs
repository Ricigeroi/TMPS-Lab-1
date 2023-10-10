using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TMPS_Lab_1.Company;
using TMPS_Lab_1.People;

namespace TMPS_Lab_1.Cars
{
    internal class CarBuilderPremium : IBuilder
    {

        Car car;

        public CarBuilderPremium(Car car)
        {
            this.car = car;
        }
        public void AddABS()
        {
            this.car.AddPart("ABS system");
        }
        public void AddInterior()
        {
            this.car.AddPart("Leather Interior");
        }
        
        public void AddClimate()
        {
            this.car.AddPart("Automatic Conditioner");
        }
        
        public void AddMultimedia()
        {
            this.car.AddPart("GPS multimedia");
        }

        public Car GetCar()
        {
            return this.car;
        }

    }
}
