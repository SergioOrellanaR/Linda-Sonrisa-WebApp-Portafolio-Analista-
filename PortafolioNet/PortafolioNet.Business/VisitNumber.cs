using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortafolioNet.Business
{
    public class VisitNumber
    {
        public int Id { get; set; }
        public int Quantity { get; set; }

        public VisitNumber()
        {
        }

        public bool Create()
        {
            try
            {
                Data.VISITAS_WEB visit = new Data.VISITAS_WEB();
                visit.ID = Id;
                visit.CANTIDAD = Quantity;
                Connection.LindaSonrisaDB.VISITAS_WEB.Add(visit);
                Connection.LindaSonrisaDB.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Read()
        {
            try
            {
                Data.VISITAS_WEB data = Connection.LindaSonrisaDB.VISITAS_WEB.First(re => re.ID == Id);
                Id = (int)data.ID;
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
