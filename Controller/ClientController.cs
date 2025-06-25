using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedicineLocator.Model;

namespace MedicineLocator.Controller
{
    public class ClientController
    {
        Clients clients = new Clients();
        public void AddClient(Client client)
        {
            clients.AddClient(client);
        }
        public void UpdateClient(Client client)
        {
            clients.UpdateClient(client);
        }
        public void RemoveClient(string clientId)
        {
            clients.RemoveClient(clientId);
        }
        public Client SearchClient(string clientId)
        {
            Client c = clients.SearchClient(clientId);
            return c;
        }
        public List<Client> GetAllCLient()
        {
            List<Client> c = clients.GetAllClient();
            return c;
        }
        

        public List<Client> GetClients(string adminId)
        {
            List<Client> c = clients.GetClient(adminId);
            return c;
        }
    }
}
