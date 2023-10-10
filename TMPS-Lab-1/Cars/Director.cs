using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMPS_Lab_1.Cars
{
    internal class Director
    {
        private IBuilder _builder;
        public IBuilder Builder
        {
            set { _builder = value; }
        }


        public Car BuildCarWithABS (Car car)
        {
            this._builder.Reset(car);
            this._builder.AddABS();
            this._builder.AddClimate();
            this._builder.AddInterior();
            this._builder.AddMultimedia();
            return this._builder.GetCar();
        }
        public Car BuildCarWithoutABS(Car car)
        {
            this._builder.Reset(car);
            this._builder.AddClimate();
            this._builder.AddInterior();
            this._builder.AddMultimedia();
            return this._builder.GetCar();
        }


    }
}
