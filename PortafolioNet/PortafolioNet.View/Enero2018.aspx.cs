using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PortafolioNet.Business;

namespace PortafolioNet.View
{
    public partial class Enero2018 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ScheduleHour"] != null)
            {
                ScheduleHourController scheduleHourController = (ScheduleHourController)Session["ScheduleHour"];
                scheduleHourController.Month = 1;
                scheduleHourController.Year = 2018;
                LoadAvailableDays (scheduleHourController.getFunctionaryAvailableDays());
                saveScheduleHour(scheduleHourController);
            }
        }

        protected void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int buttonDay = int.Parse(button.ID.Replace("Button", ""));
            ScheduleHourController scheduleHourController = (ScheduleHourController)Session["ScheduleHour"];
            scheduleHourController.Day = buttonDay;
            saveScheduleHour(scheduleHourController);
            Response.Redirect("ElegirHora.aspx");
        }

        private void LoadAvailableDays(List<int> availableDays)
        {
            ContentPlaceHolder contentPlaceHolder = (ContentPlaceHolder)Master.FindControl("ContentPlaceHolder1");
            foreach (int day in availableDays)
            {
                foreach (var button in contentPlaceHolder.Controls.OfType<Button>())
                {
                    int buttonDay = int.Parse(button.ID.Replace("Button",""));
                    if (buttonDay == day)
                    {
                        button.Enabled = true;
                    }
                }
            }
        }

        private void saveScheduleHour (ScheduleHourController scheduleHourController)
        {
            Session["ScheduleHour"] = scheduleHourController;
        }
    }
}