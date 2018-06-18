using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortafolioNet.Business
{
    public class ScheduleHourController
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public int FunctionaryRut { get; set; }

        public ScheduleHourController()
        {

        }

        public List<int> getFunctionaryAvailableDays()
        {
            List<int> availableDays = new List<int>();
            DateTime startDayOfMonth = new DateTime(Year, Month, 1);
            DateTime endDayOfMonth = new DateTime(Year,Month, DateTime.DaysInMonth(Year, Month));
            foreach (Data.DIA element in Connection.LindaSonrisaDB.DIA)
            {
                if (element.DIA1 > startDayOfMonth && element.DIA1 < endDayOfMonth && element.RUT_FUNCIONARIO == FunctionaryRut)
                {
                    DateTime day = element.DIA1;
                    availableDays.Add(day.Day);
                }
            }
            return availableDays;
        }

        public List<DateTime> getUnavailableHours ()
        {
            List<DateTime> unavailableHours = new List<DateTime>();
            foreach (Data.HORA element in Connection.LindaSonrisaDB.HORA)
            {
                if (element.FECHA_HORA.Day == Day && element.FECHA_HORA.Month == Month && element.FECHA_HORA.Year == Year && element.RUT_FUNCIONARIO == FunctionaryRut)
                {
                    unavailableHours.Add(element.FECHA_HORA);
                }
            }
            return unavailableHours;
        }


    }
}
