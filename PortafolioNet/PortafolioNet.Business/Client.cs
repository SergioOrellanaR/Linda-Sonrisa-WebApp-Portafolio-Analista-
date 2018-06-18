using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortafolioNet.Business
{
    public class Client
    {
        public int Rut { get; set; }
        public String Dv { get; set; }
        public String FirstName { get; set; }
        public String SecondName { get; set; }
        public String FirstLastName { get; set; }
        public String SecondLastName { get; set; }
        public DateTime BirthDate { get; set; }
        public String Gender { get; set; }
        public String Address { get; set; }
        public int Phone { get; set; }
        public String Email { get; set; }
        public int IdCommune { get; set; }
        public User User { get; set; }
        public int Vulnerable { get; set; }


        public Client()
        {

        }

        public Client(int rut, string dv, string firstName, string secondName, string firstLastName, string secondLastName, DateTime birthDate, string gender, string address, int phone, string email, int idCommune, User user, int vulnerable)
        {
            Rut = rut;
            Dv = dv;
            FirstName = firstName;
            SecondName = secondName;
            FirstLastName = firstLastName;
            SecondLastName = secondLastName;
            BirthDate = birthDate;
            Gender = gender;
            Address = address;
            Phone = phone;
            Email = email;
            IdCommune = idCommune;
            User = user;
            Vulnerable = vulnerable;
        }

        public Client(int rut, string dv, string firstName, DateTime birthDate, string gender, string email, User user)
        {
            Rut = rut;
            Dv = dv;
            FirstName = firstName;
            SecondName = "";
            FirstLastName = "";
            SecondLastName = "";
            BirthDate = birthDate;
            Gender = gender;
            Address = "";
            Phone = 0;
            Email = email;
            IdCommune = 0;
            User = user;
            Vulnerable = 0;
        }

        public bool Create()
        {
            try
            {
                Data.CLIENTE client = new Data.CLIENTE();
                client.RUT = Rut;
                client.DV = Dv;
                client.P_NOMBRE = FirstName;
                client.S_NOMBRE = SecondName;
                client.P_APELLIDO = FirstLastName;
                client.S_APELLIDO = SecondLastName;
                client.FECHA_NAC = BirthDate;
                client.SEXO = Gender;
                client.DIRECCION = Address;
                client.TELEFONO = Phone;
                client.EMAIL = Email;
                client.ID_COMUNA = IdCommune;
                client.ID_USUARIO = User.Id;
                client.VULNERABLE = 0;
                Connection.LindaSonrisaDB.CLIENTE.Add(client);
                Connection.LindaSonrisaDB.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                string val = e.Message;
                return false;
            }
        }

        public bool Read()
        {
            try
            {
                Data.USUARIO usr = Connection.LindaSonrisaDB.USUARIO.First(re => re.NOMBRE == User.Username);
                Data.CLIENTE client = Connection.LindaSonrisaDB.CLIENTE.First(re => re.ID_USUARIO == usr.ID);
                User user = new User() { Id = (int)client.ID_USUARIO };
                user.Read();
                Rut = (int) client.RUT;
                Dv = client.DV;
                FirstName = client.P_NOMBRE;
                SecondName = client.S_NOMBRE;
                FirstLastName = client.P_APELLIDO;
                SecondLastName = client.S_APELLIDO;
                BirthDate = client.FECHA_NAC;
                Gender = client.SEXO;
                Address = client.DIRECCION;
                Phone = (int)client.TELEFONO;
                Email = client.EMAIL;
                IdCommune = (int)client.ID_COMUNA;
                User = user;
                Vulnerable = (int)client.VULNERABLE;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool MailAlreadyExist()
        {
            try
            {
                Data.CLIENTE client = Connection.LindaSonrisaDB.CLIENTE.First(re => re.EMAIL == Email);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool RutAlreadyExist()
        {
            try
            {
                Data.CLIENTE client = Connection.LindaSonrisaDB.CLIENTE.First(re => re.RUT == Rut);
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
