using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortafolioNet.Business
{
    class Client
    {
        public int RutClient { get; set; }
        public int IsVulnerable { get; set; }

        public Client(int rutClient, int isVulnerable)
        {
            RutClient = rutClient;
            IsVulnerable = isVulnerable;
        }

        public Client()
        {
        }

        public bool Create()
        {
            try
            {
                Data.CLIENTE client = new Data.CLIENTE();
                client.RUT = RutClient;
                client.VULNERABLE = IsVulnerable;
                Connection.LindaSonrisaDB.CLIENTE.Add(client);
                Connection.LindaSonrisaDB.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update()
        {
            try
            {
                Data.CLIENTE hour = Connection.LindaSonrisaDB.CLIENTE.First(re => re.RUT == RutClient);
                hour.RUT = RutClient;
                hour.VULNERABLE = IsVulnerable;
                Connection.LindaSonrisaDB.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
