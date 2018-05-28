using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortafolioNet.Business
{
    class Hour
    {
        

        public int Id { get; set; }
        public DateTime DateHour { get; set; }
        public int RutFunctionary { get; set; }
        public int RutClient { get; set; }

        public Hour(int id, DateTime dateHour, int rutFunctionary, int rutClient)
        {
            Id = id;
            DateHour = dateHour;
            RutFunctionary = rutFunctionary;
            RutClient = rutClient;
        }

        public Hour()
        {

        }

        public bool Create()
        {
            try
            {
                Data.HORA hour = new Data.HORA();
                hour.ID = LastId() + 1;
                hour.FECHA_HORA = DateHour;
                hour.RUT_FUNCIONARIO = RutFunctionary;
                hour.RUT_CLIENTE = RutClient;
                Connection.LindaSonrisaDB.HORA.Add(hour);
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
                Data.HORA hour = Connection.LindaSonrisaDB.HORA.First(re => re.FECHA_HORA == DateHour);
                hour.FECHA_HORA = DateHour;
                hour.RUT_FUNCIONARIO = RutFunctionary;
                hour.RUT_CLIENTE = RutClient;
                Connection.LindaSonrisaDB.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete()
        {
            try
            {
                Data.HORA hour = Connection.LindaSonrisaDB.HORA.First(re => re.FECHA_HORA == DateHour);
                Connection.LindaSonrisaDB.HORA.Remove(hour);
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
                Data.HORA hour = Connection.LindaSonrisaDB.HORA.First(re => re.FECHA_HORA == DateHour);
                DateHour = hour.FECHA_HORA;
                Id = (int)hour.ID;
                RutFunctionary = (int)hour.RUT_FUNCIONARIO;
                RutClient = (int)hour.RUT_CLIENTE;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public int LastId() //Obtiene el ultimo ID
        {
            try
            {
                return (int)Connection.LindaSonrisaDB.HORA.Max(re => re.ID);
            }
            catch (Exception)
            {
                return 0;
            }
        }

    }
}
