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

        public Statistics()
        {
            if (dentistWithMoreHours() != null)
            {
                DentistWithMoreHours = "El dentista con más horas registradas es: "+ dentistWithMoreHours();
            }
            else
            {
                DentistWithMoreHours = "";
            }

            if (mostSolicitedService() != null)
            {
                MostSolicitedService = "El servicio más solicitado es: "+ mostSolicitedService();
            }
            else
            {
                MostSolicitedService = "";
            }

            if (clientWithMoreHours() != null)
            {
                ClientWithMoreHours = "El cliente con más horas registradas es: " + clientWithMoreHours();
            }
            else
            {
                ClientWithMoreHours = "";
            }

            if (mostSolicitedDay() != null)
            {
                MostSolicitedDay = "El día con más horas registradas es: " + mostSolicitedDay();
            }
            else
            {
                MostSolicitedDay = "";
            }

            if (lessSolicitedService() != null)
            {
                LessSolicitedService = "El servicio menos solicitado es: " + lessSolicitedService();
            }
            else
            {
                LessSolicitedService = "";
            }

            if (dentistWithLessHours() != null)
            {
                DentistWithLessHours = "El dentista con menos horas registradas es: " + dentistWithLessHours();
            }
            else
            {
                DentistWithLessHours = "";
            }

            if (mostClientCommune() != null)
            {
                MostClientCommune = "La comuna con más clientes registrados es: " + mostClientCommune();
            }
            else
            {
                MostClientCommune = "";
            }

            if (clientRegisteredQuantity() != 0)
            {
                ClientRegisteredQuantity = "La cantidad de clientes registrados es: " + clientRegisteredQuantity();
            }
            else
            {
                ClientRegisteredQuantity = "";
            }

            if (averageClientAge() != 0)
            {
                AverageClientAge = "El promedio de edad de los clientes es: " + averageClientAge();
            }
            else
            {
                AverageClientAge = "";
            }

            if (mostOlderClient() != null)
            {
                MostOlderClient = "El cliente de mayor edad es: " + mostOlderClient();
            }
            else
            {
                MostOlderClient = "";
            }

            if (mostYoungerClient() != null)
            {
                MostYoungerClient = "El cliente de menor edad es: " + mostYoungerClient();
            }
            else
            {
                MostYoungerClient = "";
            }
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
                string maxServiceName = "";
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
                int maxSolicitedDay = 0;
                DateTime date = DateTime.Now;
                string maxDay = "";
                List<Data.HORA> list = Connection.LindaSonrisaDB.HORA.ToList();
                foreach (Data.HORA hour in list)
                {
                    DateTime temporalDate = hour.FECHA_HORA.Date;
                    int temporalNumber = Connection.LindaSonrisaDB.HORA.Count(result => result.FECHA_HORA.Date == temporalDate);
                    if (temporalNumber > maxSolicitedDay)
                    {
                        maxSolicitedDay = temporalNumber;
                        maxDay = temporalDate.ToString("dd/mm/yyyy");
                    }
                }
                return maxDay;
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
                    int temporalNumber = Connection.LindaSonrisaDB.HORA.Count(result => result.RUT_FUNCIONARIO == dentist.RUT);
                    if (temporalNumber < lessNumberOfHours)
                    {
                        lessNumberOfHours = temporalNumber;
                        lessFunctionaryName = dentist.P_NOMBRE + " " + dentist.P_APELLIDO;
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
                DateTime minDate = Connection.LindaSonrisaDB.CLIENTE.Min().FECHA_NAC;
                Data.CLIENTE client = Connection.LindaSonrisaDB.CLIENTE.First(result => result.FECHA_NAC == minDate);
                string mostOlderClientName = client.P_NOMBRE + " " + client.P_APELLIDO + " con " + (DateTime.Now.Year - minDate.Year) + " años.";
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
                DateTime maxDate = Connection.LindaSonrisaDB.CLIENTE.Max().FECHA_NAC;
                Data.CLIENTE client = Connection.LindaSonrisaDB.CLIENTE.First(result => result.FECHA_NAC == maxDate);
                string mostOlderClientName = client.P_NOMBRE + " " + client.P_APELLIDO + " con " + (DateTime.Now.Year - maxDate.Year) + " años.";
                return mostOlderClientName;
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
                    agesList.Add(DateTime.Now.Year - client.FECHA_NAC.Year);
                }
                return agesList;
            }
            catch
            {
                return agesList;
            }
        }
    }
}
