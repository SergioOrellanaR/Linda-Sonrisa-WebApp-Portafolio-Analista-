using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortafolioNet.Business
{
    public class Service
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int RutFunctionary { get; set; }

        public Service()
        {

        }

        public bool Read()
        {
            try
            {
                Data.SERVICIO service = Connection.LindaSonrisaDB.SERVICIO.First(servicio => servicio.ID == Id);
                Id = (int)service.ID;
                Description = service.DESCRIPCION;
                Price = (int)service.PRECIO;
                RutFunctionary = (int)service.RUT_FUNCIONARIO;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
