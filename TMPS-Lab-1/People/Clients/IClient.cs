using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMPS_Lab_1.Company;

namespace TMPS_Lab_1.People
{
    internal interface IClient
    {
        public void MakeOrder(TaxiCompany company);
    }
}
