using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PortafolioNet.Business;

namespace PortafolioNet.View
{
    public partial class ElegirHora : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ScheduleHour"] != null)
            {
                ScheduleHourController scheduleHourController = (ScheduleHourController)Session["ScheduleHour"];
                setUnavailableHours(scheduleHourController.getUnavailableHours());
            }
            else
            {
                Response.Redirect("indexLogin.aspx");
            }
        }

        protected void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string buttonStartTime = button.ID.Replace("Button", "").Substring(0, 4);
            ScheduleHourController scheduleHourController = (ScheduleHourController)Session["ScheduleHour"];
            Client client = (Client)Session["ses"];
            DateTime startHour = new DateTime
                (
                    scheduleHourController.Year,
                    scheduleHourController.Month,
                    scheduleHourController.Day,
                    int.Parse(buttonStartTime.Substring(0, 2)),
                    int.Parse(buttonStartTime.Substring(2)),
                    0
                );

            Hour hour = new Hour()
            {
                RutClient = client.Rut,
                DateHour = startHour,
                RutFunctionary = scheduleHourController.FunctionaryRut
            };
            if (hour.Create())
            {
                scheduleHourController.TakenHour = startHour;
                Session["ScheduleHour"] = scheduleHourController;
                Response.Redirect("HoraRegistrada.aspx");
            }
            else
            {
                Response.Redirect("Index.aspx");
            }
        }

        private void setUnavailableHours (List<DateTime> unavailableHours)
        {
            ContentPlaceHolder contentPlaceHolder = (ContentPlaceHolder)Master.FindControl("ContentPlaceHolder1");
            foreach (DateTime element in unavailableHours)
            {
                string startTime = element.Hour.ToString("00") + element.Minute.ToString("00");
                foreach (var button in contentPlaceHolder.Controls.OfType<Button>())
                {
                    if (button.ID != "btnVolver")
                    {
                        string buttonStartTime = button.ID.Replace("Button", "").Substring(0,4);
                        if (buttonStartTime.Equals(startTime))
                        {
                            button.Enabled = false;
                            button.CssClass = "btn btn-danger btn-lg btn-block";
                            button.Text = "No disponible";
                        }
                    }
                }
            }
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("CalendarMonths.aspx");
        }
    }
}