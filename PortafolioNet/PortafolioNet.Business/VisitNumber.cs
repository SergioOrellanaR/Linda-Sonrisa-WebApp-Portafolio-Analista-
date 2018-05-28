using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortafolioNet.Business
{
    class VisitNumber
    {
        public int Quantity { get; set; }

        public VisitNumber()
        {

        }

        public VisitNumber(int quantity)
        {
            Quantity = quantity;
        }

        public void addVisit ()
        {
            try
            {
                Data.VISITAS_WEB data= Connection.LindaSonrisaDB.VISITAS_WEB.First();
                data.CANTIDAD = Connection.LindaSonrisaDB.VISITAS_WEB.Max(quantity => quantity.CANTIDAD)+1;
                Connection.LindaSonrisaDB.SaveChanges();
            }
            catch (Exception e)
            {
                String val = e.Message;
            }
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

    }
}
