using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortafolioNet.Business
{
    public class ComboBoxDataLoader
    {
        public static List<Service> ServicesList ()
        {
            List<Service> list = new List<Service>();
            foreach (Data.SERVICIO service in Connection.LindaSonrisaDB.SERVICIO.ToList())
            {
                list.Add(new Service()
                {
                    Id = (int)service.ID,
                    Description = service.DESCRIPCION,
                    Price = (int)service.PRECIO,
                    RutFunctionary = (int)service.RUT_FUNCIONARIO
                });
            }
            return list;
        }

        public static List<Commune> CommuneList()
        {
            List<Commune> list = new List<Commune>();
            foreach (Data.COMUNA commune in Connection.LindaSonrisaDB.COMUNA.ToList())
            {
                list.Add(new Commune()
                {
                    Id = (int)commune.ID,
                    Name = commune.NOMBRE
                });
            }
            return list;
        }

        public static List<SecretQuestion> secretQuestionList()
        {
            List<SecretQuestion> list = new List<SecretQuestion>();
            foreach (Data.PREGUNTA_SECRETA question in Connection.LindaSonrisaDB.PREGUNTA_SECRETA.ToList())
            {
                list.Add(new SecretQuestion()
                {
                    Id = (int)question.ID,
                    Question = question.TXT_PREGUNTA
                });
            }
            return list;
        }
    }
}
