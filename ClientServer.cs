using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplicationDemo3
{
    class ClientServer
    {
        IList<Client> client_server = new List<Client>();

        #region method 1
        public void AddToServer(Client client)
        {
            client_server.Add(client);
        }
        #endregion
        #region  method 2
        public void Display()
        {
            foreach (Client l in client_server)
                Console.WriteLine(l.Phone_Number + " " + l.Name);
        }
        #endregion
        #region method 3
        public void RemoveFromServer(Client client)
        {
            client_server.Remove(client);
        }
        #endregion
        #region method 4
        public void Duplicate(Client client)
        {
            
        }
        #endregion
        public void AddtoServer(Client cl)
        {
            client_server.Add(cl);
        }

    }
}
