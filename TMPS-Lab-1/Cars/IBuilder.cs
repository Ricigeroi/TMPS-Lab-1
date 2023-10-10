using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMPS_Lab_1.People;

namespace TMPS_Lab_1.Cars
{
    internal interface IBuilder
    {
        void Reset(Car car);
        void AddABS();
        void AddClimate();
        void AddInterior();
        void AddMultimedia();
        Car GetCar();
        
    }
}
