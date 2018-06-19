using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PortafolioNet.Business;
using System.Globalization;

namespace PortafolioNet.View
{
    public partial class HoraRegistrada : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ScheduleHour"] != null)
            {
                ScheduleHourController scheduleHourController = (ScheduleHourController)Session["ScheduleHour"];
                Client client = (Client)Session["ses"];
                lblClientName.Text = client.FirstName + " " + client.FirstLastName;
                lblOdontologo.Text = scheduleHourController.FunctionaryName;
                lblService.Text = scheduleHourController.ServiceName;
                lblFechaCita.Text = CultureInfo.CurrentCulture.DateTimeFormat.GetDayName(scheduleHourController.TakenHour.DayOfWeek) + " " + scheduleHourController.TakenHour.ToString("dd/MM") + " a las "+ scheduleHourController.TakenHour.ToString("HH:mm");
                Session["ScheduleHour"] = null;
            }
            else
            {
                Response.Redirect("Index.aspx");
            }
        }
    }
}