using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMPS_Lab_1.Cars
{
    internal interface IEngine
    {
        public void Start();
        public string GetTypeOfEngine();
    }
}
