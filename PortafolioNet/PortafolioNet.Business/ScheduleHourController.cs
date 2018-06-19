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
        public string FunctionaryName { get; set; }
        public string ServiceName { get; set; }
        public DateTime TakenHour { get; set; }


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

        public bool DayHaveAvailableHours(DateTime time)
        {
            List<DateTime> unavailableHours = new List<DateTime>();
            foreach (Data.HORA element in Connection.LindaSonrisaDB.HORA)
            {
                if (element.FECHA_HORA.Day == time.Day && element.FECHA_HORA.Month == time.Month && element.FECHA_HORA.Year == time.Year && element.RUT_FUNCIONARIO == FunctionaryRut)
                {
                    unavailableHours.Add(element.FECHA_HORA);
                }
            }
            return unavailableHours.Count < 17;
        }

        public bool FunctionaryNameByRut (int rut)
        {
            try
            {
                Data.FUNCIONARIO func = Connection.LindaSonrisaDB.FUNCIONARIO.First(fun => fun.RUT == rut);
                FunctionaryName = func.P_NOMBRE + " " + func.P_APELLIDO;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool ServiceNameById (int Id)
        {
            try
            {
                Data.SERVICIO service = Connection.LindaSonrisaDB.SERVICIO.First(serv => serv.ID == Id);
                ServiceName = service.DESCRIPCION;
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
