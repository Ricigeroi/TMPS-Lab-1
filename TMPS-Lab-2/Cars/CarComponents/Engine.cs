using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMPS_Lab_1.Cars
{
    internal class Engine : IEngine
    {
        private string type;
        private int power;

        public Engine(string type, int power)
        {
            this.type = type;
            this.power = power;
        }

        public void Start()
        {
            Console.WriteLine(power + "HP " + type + " engine has started!");
        }

        // Prototype pattern
        public Engine Copy()
        {
            return (Engine) this.MemberwiseClone();
        }

        public string GetTypeOfEngine()
        {
            return type;
        }
    }
}
