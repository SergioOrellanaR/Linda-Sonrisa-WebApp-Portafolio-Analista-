using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortafolioNet.Business
{
    class Day
    {
        public DateTime DayDate { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int FunctionaryRut { get; set; }

        public Day(DateTime dayDate, DateTime startTime, DateTime endTime, int functionaryRut)
        {
            DayDate = dayDate;
            StartTime = startTime;
            EndTime = endTime;
            FunctionaryRut = functionaryRut;
        }

        public Day()
        {

        }

        public bool Read()
        {
            try
            {
                Data.DIA day = Connection.LindaSonrisaDB.DIA.First(re => re.DIA1 == DayDate);
                DayDate = day.DIA1;
                StartTime = day.HORA_INICIO;
                EndTime = day.HORA_TERMINO;
                FunctionaryRut = (int)day.RUT_FUNCIONARIO;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
