using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortafolioNet.Business
{
    public class SecretQuestion
    {
        public int Id { get; set; }
        public string Question { get; set; }

        public bool Create()
        {
            try
            {
                Data.PREGUNTA_SECRETA question = Connection.LindaSonrisaDB.PREGUNTA_SECRETA.First(dbquestion => dbquestion.ID == Id);
                question.ID = LastId() + 1;
                question.TXT_PREGUNTA = Question;
                Connection.LindaSonrisaDB.PREGUNTA_SECRETA.Add(question);
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
                Data.PREGUNTA_SECRETA question = Connection.LindaSonrisaDB.PREGUNTA_SECRETA.First(dbquestion => dbquestion.ID == Id);
                Id = (int)question.ID;
                Question = question.TXT_PREGUNTA;
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
                return (int)Connection.LindaSonrisaDB.PREGUNTA_SECRETA.Max(re => re.ID);
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
