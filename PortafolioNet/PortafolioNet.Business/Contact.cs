using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortafolioNet.Business
{
    class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Cellphone { get; set; }
        public string Message { get; set; }

        public Contact(int id, string name, string email, string cellphone, string message)
        {
            Id = id;
            Name = name;
            Email = email;
            Cellphone = cellphone;
            Message = message;
        }

        public Contact()
        {

        }

        public bool Create()
        {
            try
            {
                Data.CONTACTO contact = new Data.CONTACTO();
                contact.NOMBRE = Name;
                contact.CORREO = Email;
                contact.TELEFONO = Cellphone;
                contact.MENSAJE = Message;
                Connection.LindaSonrisaDB.CONTACTO.Add(contact);
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
