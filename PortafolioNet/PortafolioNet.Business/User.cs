using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PortafolioNet.Data;

namespace PortafolioNet.Business
{
    public class User
    {
        public int Id { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }
        public int IdSecretQuestion { get; set; }
        public String AnswerSecretQuestion { get; set; }

        public User()
        {

        }

        public User(int id, string username, string password, int idSecretQuestion, String answerSecretQuestion)
        {
            Id = id;
            Username = username;
            Password = password;
            IdSecretQuestion = idSecretQuestion;
            AnswerSecretQuestion = answerSecretQuestion;
        }

        public bool Create()
        {
            try
            {
                Data.USUARIO account = new Data.USUARIO();
                account.ID = SequencerController.GetNextVal("SEQ_ID_USUARIO");
                account.NOMBRE = Username;
                account.CLAVE = Password;
                account.ID_PREGUNTA = IdSecretQuestion;
                account.RESP_PREGUNTA = AnswerSecretQuestion;
                Connection.LindaSonrisaDB.USUARIO.Add(account);
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
                Data.USUARIO account = Connection.LindaSonrisaDB.USUARIO.First(user => user.NOMBRE == Username);
                Id = (int) account.ID;
                Username = account.NOMBRE;
                Password = account.CLAVE;
                IdSecretQuestion = (int) account.ID_PREGUNTA;
                AnswerSecretQuestion = account.RESP_PREGUNTA;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Authenticate()
        {
            try
            {
                Data.USUARIO account = Connection.LindaSonrisaDB.USUARIO.First(user => user.NOMBRE == Username && user.CLAVE == Password);
                Username = account.NOMBRE;
                Password = account.CLAVE;
                return true;
            }
            catch (Exception e)
            {
                String val = e.Message;
                return false;
            }
        }

        public bool updatePassword()
        {
            try
            {
                Data.USUARIO user = Connection.LindaSonrisaDB.USUARIO.First(re => re.ID == Id);
                user.CLAVE = Password;
                Connection.LindaSonrisaDB.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UsernameAlreadyExist()
        {
            try
            {
                Data.USUARIO user = Connection.LindaSonrisaDB.USUARIO.First(re => re.NOMBRE == Username);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
