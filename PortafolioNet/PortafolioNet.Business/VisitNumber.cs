using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortafolioNet.Business
{
    public class VisitNumber
    {
        public int Quantity { get; set; }

        public VisitNumber()
        {
            Quantity = (int) Connection.LindaSonrisaDB.VISITAS_WEB.First().CANTIDAD;
        }

        public VisitNumber(int quantity)
        {
            Quantity = quantity;
        }

        public bool Read()
        {
            try
            {
                Data.VISITAS_WEB data = Connection.LindaSonrisaDB.VISITAS_WEB.First();
                Quantity = (int) data.CANTIDAD;
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
                Data.VISITAS_WEB data = Connection.LindaSonrisaDB.VISITAS_WEB.First();
                data.CANTIDAD = Quantity;
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
