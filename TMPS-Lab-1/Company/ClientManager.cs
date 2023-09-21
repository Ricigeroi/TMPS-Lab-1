using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMPS_Lab_1.People;

namespace TMPS_Lab_1.Company
{
    internal class ClientManager
    {
        public List<Client> clients = new List<Client>();
        public List<Client> GetClients()
        {
            return clients;
        }

        public void AddClient(string name, string surname, int age, int money)
        {
            clients.Add(new Client(name, surname, age, money));
        }
    }
}
