using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortafolioNet.Business
{
    public class Commune
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Commune()
        {

        }

        public int getIdByName ()
        {
            try
            {
                Data.COMUNA commune = Connection.LindaSonrisaDB.COMUNA.First(re => re.NOMBRE == Name);
                return (int) commune.ID;
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
