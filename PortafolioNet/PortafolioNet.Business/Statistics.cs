using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortafolioNet.Business
{
    public class Statistics
    {
        public string DentistWithMoreHours { get; set; }
        public string MostSolicitedService { get; set; }
        public string ClientWithMoreHours { get; set; }
        public string MostSolicitedDay { get; set; }
        public string LessSolicitedService { get; set; }
        public string DentistWithLessHours { get; set; }
        public string MostClientCommune { get; set; }
        public string ClientRegisteredQuantity { get; set; }
        public string AverageClientAge { get; set; }
        public string MostOlderClient { get; set; }
        public string MostYoungerClient { get; set; }
        public string VisitNumber { get; set; }

        public Statistics()
        {
            if (dentistWithMoreHours() != null)
            {
                DentistWithMoreHours = "El dentista con más horas registradas es: "+ dentistWithMoreHours();
            }
            else
            {
                DentistWithMoreHours = "No existe información disponible para conocer el dentista con más horas registradas.";
            }

            if (mostSolicitedService() != null)
            {
                MostSolicitedService = "El servicio más solicitado es: "+ mostSolicitedService();
            }
            else
            {
                MostSolicitedService = "No existe información disponible para conocer el servicio más solicitado.";
            }

            if (clientWithMoreHours() != null)
            {
                ClientWithMoreHours = "El cliente con más horas registradas es: " + clientWithMoreHours();
            }
            else
            {
                ClientWithMoreHours = "No existe información disponible para conocer el cliente con más horas.";
            }

            if (mostSolicitedDay() != null)
            {
                MostSolicitedDay = "El día con más horas registradas es: " + mostSolicitedDay();
            }
            else
            {
                MostSolicitedDay = "No existe información disponible para conocer el día con más solicitudes.";
            }

            if (lessSolicitedService() != null)
            {
                LessSolicitedService = "El servicio menos solicitado es: " + lessSolicitedService();
            }
            else
            {
                LessSolicitedService = "No existe información disponible para conocer el servicio menos solicitado.";
            }

            if (dentistWithLessHours() != null)
            {
                DentistWithLessHours = "El dentista con menos horas registradas es: " + dentistWithLessHours();
            }
            else
            {
                DentistWithLessHours = "No existe información disponible para conocer el dentista con menos horas.";
            }

            if (mostClientCommune() != null)
            {
                MostClientCommune = "La comuna con más clientes registrados es: " + mostClientCommune();
            }
            else
            {
                MostClientCommune = "No existe información disponible para conocer la comuna con más clientes.";
            }

            if (clientRegisteredQuantity() != 0)
            {
                ClientRegisteredQuantity = "La cantidad de clientes registrados es: " + clientRegisteredQuantity();
            }
            else
            {
                ClientRegisteredQuantity = "No existe información disponible para conocer la cantidad de clientes registrados.";
            }

            if (averageClientAge() != 0)
            {
                AverageClientAge = "El promedio de edad de los clientes es: " + averageClientAge();
            }
            else
            {
                AverageClientAge = "No existe información disponible para conocer el promedio de edad de los clientes.";
            }

            if (mostOlderClient() != null)
            {
                MostOlderClient = "El cliente de mayor edad es: " + mostOlderClient();
            }
            else
            {
                MostOlderClient = "No existe información disponible para conocer el cliente de mayor edad.";
            }

            if (mostYoungerClient() != null)
            {
                MostYoungerClient = "El cliente de menor edad es: " + mostYoungerClient();
            }
            else
            {
                MostYoungerClient = "No existe información disponible para conocer el cliente más joven.";
            }

            VisitNumber = "La cantidad total de visitas que registra la página es de: " + visitNumber();
        }

        public string dentistWithMoreHours()
        {
            try
            {
                int maxNumberOfHours = 0;
                string maxFunctionaryName = "";
                List<Data.FUNCIONARIO> func = Connection.LindaSonrisaDB.FUNCIONARIO.ToList();
                foreach (Data.FUNCIONARIO dentist in func)
                {
                    int temporalNumber = Connection.LindaSonrisaDB.HORA.Count(result => result.RUT_FUNCIONARIO == dentist.RUT);
                    if (temporalNumber > maxNumberOfHours)
                    {
                        maxNumberOfHours = temporalNumber;
                        maxFunctionaryName = dentist.P_NOMBRE + " " + dentist.P_APELLIDO;
                    }
                }
                return maxFunctionaryName;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public string mostSolicitedService()
        {
            try
            {
                int maxNumberOfService = 0;
                string maxServiceName = null;
                List<Data.SERVICIO> list = Connection.LindaSonrisaDB.SERVICIO.ToList();
                foreach (Data.SERVICIO service in list)
                {
                    int temporalNumber = Connection.LindaSonrisaDB.DETALLE_BOLETA_CLI.Count(result => result.ID_SERVICIO == service.ID);
                    if (temporalNumber > maxNumberOfService)
                    {
                        maxNumberOfService = temporalNumber;
                        maxServiceName = service.DESCRIPCION;
                    }
                }
                return maxServiceName;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public string clientWithMoreHours()
        {
            try
            {
                int maxNumberOfHours = 0;
                string maxClientName = "";
                List<Data.CLIENTE> list = Connection.LindaSonrisaDB.CLIENTE.ToList();
                foreach (Data.CLIENTE client in list)
                {
                    int temporalNumber = Connection.LindaSonrisaDB.HORA.Count(result => result.RUT_CLIENTE == client.RUT);
                    if ( temporalNumber > maxNumberOfHours)
                    {
                        maxNumberOfHours = temporalNumber;
                        maxClientName = client.P_NOMBRE + " " + client.P_APELLIDO;
                    }
                }
                return maxClientName;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public string mostSolicitedDay()
        {
            try
            {
                List<Data.HORA> hourList = Connection.LindaSonrisaDB.HORA.ToList();
                List<DateTime> list = new List<DateTime>();
                foreach (Data.HORA hour in hourList)
                {
                    list.Add(hour.FECHA_HORA.Date);
                }

                int maxNumber = 0;
                DateTime maxDate = DateTime.Now;

                foreach (DateTime date in list)
                {
                    int temporalNumber = list.Count(result => result == date);
                    if (temporalNumber > maxNumber)
                    {
                        maxDate = date;
                        maxNumber = temporalNumber;
                    }
                }
                return maxDate.ToShortDateString();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public string lessSolicitedService()
        {
            try
            {
                int lessSolicitedService = 1000000;
                string lessServiceName = "";
                List<Data.SERVICIO> list = Connection.LindaSonrisaDB.SERVICIO.ToList();
                foreach (Data.SERVICIO service in list)
                {
                    int temporalNumber = Connection.LindaSonrisaDB.DETALLE_BOLETA_CLI.Count(result => result.ID_SERVICIO == service.ID);
                    if (temporalNumber < lessSolicitedService)
                    {
                        lessSolicitedService = temporalNumber;
                        lessServiceName = service.DESCRIPCION;
                    }
                }
                return lessServiceName;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public string dentistWithLessHours()
        {
            try
            {
                int lessNumberOfHours = 999999;
                string lessFunctionaryName = "";
                List<Data.FUNCIONARIO> func = Connection.LindaSonrisaDB.FUNCIONARIO.ToList();
                foreach (Data.FUNCIONARIO dentist in func)
                {
                    if (dentist.ID_TIPO == 1)
                    {
                        int temporalNumber = Connection.LindaSonrisaDB.HORA.Count(result => result.RUT_FUNCIONARIO == dentist.RUT);
                        if (temporalNumber < lessNumberOfHours)
                        {
                            lessNumberOfHours = temporalNumber;
                            lessFunctionaryName = dentist.P_NOMBRE + " " + dentist.P_APELLIDO;
                        }
                    }
                }
                return lessFunctionaryName;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public string mostClientCommune()
        {
            try
            {
                int maxCommuneClient = 0;
                string maxCommuneName = "";
                List<Data.COMUNA> list = Connection.LindaSonrisaDB.COMUNA.ToList();
                foreach (Data.COMUNA commune in list)
                {
                    int temporalNumber = Connection.LindaSonrisaDB.CLIENTE.Count(result => result.ID_COMUNA == commune.ID);
                    if (temporalNumber > maxCommuneClient)
                    {
                        maxCommuneClient = temporalNumber;
                        maxCommuneName = commune.NOMBRE;
                    }
                }
                return maxCommuneName;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public int clientRegisteredQuantity()
        {
            try
            {
                return Connection.LindaSonrisaDB.CLIENTE.Count();
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public double averageClientAge()
        {
            try
            {
                return agesList().Average();
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public string mostOlderClient()
        {
            try
            {
                Data.CLIENTE client = Connection.LindaSonrisaDB.CLIENTE.OrderBy(cv => cv.FECHA_NAC).First();
                string mostOlderClientName = client.P_NOMBRE + " " + client.P_APELLIDO + " con " + calculatedYears(client.FECHA_NAC) + " años.";
                return mostOlderClientName;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public string mostYoungerClient()
        {
            try
            {
                Data.CLIENTE client = Connection.LindaSonrisaDB.CLIENTE.OrderByDescending(cv => cv.FECHA_NAC).First();
                string mostYoungerClientName = client.P_NOMBRE + " " + client.P_APELLIDO + " con " + calculatedYears(client.FECHA_NAC) + " años.";
                return mostYoungerClientName;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        private List<int> agesList()
        {
            List<int> agesList = new List<int>();
            try
            {
                List<Data.CLIENTE> clientList = Connection.LindaSonrisaDB.CLIENTE.ToList();
                foreach (Data.CLIENTE client in clientList)
                {
                    agesList.Add(calculatedYears(client.FECHA_NAC));
                }
                return agesList;
            }
            catch
            {
                return agesList;
            }
        }

        private int visitNumber()
        {
            try
            {
                Data.VISITAS_WEB visits = Connection.LindaSonrisaDB.VISITAS_WEB.First(result => result.ID == 0);
                return (int)visits.CANTIDAD;
            }
            catch
            {
                return 0;
            }
        }

        private int calculatedYears(DateTime birthDate)
        {
            int days = (DateTime.Today - birthDate).Days;
            decimal years = days / 365.25m;
            return (int)years;
        }
    }
}
