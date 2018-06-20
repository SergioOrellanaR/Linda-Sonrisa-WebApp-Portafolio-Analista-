using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PortafolioNet.Business;

namespace PortafolioNet.View
{
    public partial class Estadisticas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Statistics stats = new Statistics();
            lblAverageClientAge.Text = stats.AverageClientAge;
            lblClientRegisteredQuantity.Text = stats.ClientRegisteredQuantity;
            lblClientWithMoreHours.Text = stats.ClientWithMoreHours;
            lblDentistWithLessHours.Text = stats.DentistWithLessHours;
            lblDentistWithMoreHours.Text = stats.DentistWithMoreHours;
            lblLessSolicitedService.Text = stats.LessSolicitedService;
            lblMostClientCommune.Text = stats.MostClientCommune;
            lblMostOlderClient.Text = stats.MostOlderClient;
            lblMostSolicitedDay.Text = stats.MostSolicitedDay;
            lblMostSolicitedService.Text = stats.MostSolicitedService;
            lblMostYoungerClient.Text = stats.MostYoungerClient;
        }
    }
}