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
    public partial class CalendarMonths : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            { 
                if (Session["ScheduleHour"] != null)
            {
                DateTime dateLoader;
                if (Session["DateLoader"]!=null)
                {
                    dateLoader = (DateTime)Session["DateLoader"];
                }
                else
                {
                    dateLoader = DateTime.Now;
                    Session["DateLoader"] = dateLoader;
                }
                loadDaysOfMonth(dateLoader);
                string monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(dateLoader.Month);
                monthName = char.ToUpper(monthName[0]) + monthName.Substring(1);
                lblMonth.Text = monthName;
                lblYear.Text = dateLoader.Year.ToString();

                ScheduleHourController scheduleHourController = (ScheduleHourController)Session["ScheduleHour"];
                string functionaryName = scheduleHourController.FunctionaryName;
                lblService.Text = scheduleHourController.ServiceName;
                Label2.Text = functionaryName;
                Image2.ImageUrl = "~/images/"+ functionaryName+".jpg";
                scheduleHourController.Month = dateLoader.Month;
                scheduleHourController.Year = dateLoader.Year;
                LoadAvailableDays (scheduleHourController.getFunctionaryAvailableDays(), scheduleHourController);
                saveScheduleHour(scheduleHourController);
            }
            else
            {
                Response.Redirect("indexLogin.aspx");
            }
            }
        }

        protected void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int buttonDay = int.Parse(button.ID.Replace("Button", ""));
            ScheduleHourController scheduleHourController = (ScheduleHourController)Session["ScheduleHour"];
            scheduleHourController.Day = buttonDay;
            saveScheduleHour(scheduleHourController);
            Session["DateLoader"] = null;
            Response.Redirect("ElegirHora.aspx");
        }

        private void LoadAvailableDays(List<int> availableDays, ScheduleHourController schedule)
        {
            ContentPlaceHolder contentPlaceHolder = (ContentPlaceHolder)Master.FindControl("ContentPlaceHolder1");
            foreach (int day in availableDays)
            {
                foreach (var button in contentPlaceHolder.Controls.OfType<Button>())
                {
                    if (button.ID.Substring(0, 6).Equals("Button"))
                    {
                        int buttonDay = int.Parse(button.ID.Replace("Button", ""));
                        if (buttonDay == day)
                        {
                            DateTime AvailablityDay = new DateTime(schedule.Year , schedule.Month, day);
                            if (schedule.DayHaveAvailableHours(AvailablityDay))
                            {
                                button.Enabled = true;
                                button.CssClass = "btn btn-primary btn-lg btn-block";
                            }
                        }
                        else
                        {
                            //button.CssClass = "btn btn-secondary btn - lg btn - block";
                        }
                    }
                }
            }
        }

        private void saveScheduleHour (ScheduleHourController scheduleHourController)
        {
            Session["ScheduleHour"] = scheduleHourController;
        }

        private void loadDaysOfMonth (DateTime dateLoader)
        {
            DateTime dateForMonthInfo = new DateTime(dateLoader.Year, dateLoader.Month, 1);
            int firstDayOfMonthDay = (int)dateForMonthInfo.DayOfWeek == 0 ? 7 : (int)dateForMonthInfo.DayOfWeek;
            int lastDayOfMonth = dateForMonthInfo.AddMonths(1).AddDays(-1).Day;
            SetButtonsByMonth(firstDayOfMonthDay, lastDayOfMonth);
        }

        private void SetButtonsByMonth (int firstDayOfMonth, int lastDayOfMonth)
        {
            switch (firstDayOfMonth)
            {
                case 1:
                    Button1.ID = "Button1";
                    EnableAndDisableByDays(0, lastDayOfMonth);
                    break;
                case 2:
                    Button1.ID = "NotButton1";
                    Button2.ID = "Button1";
                    Button1.Text = "01";
                    EnableAndDisableByDays(1, lastDayOfMonth);
                    break;
                case 3:
                    Button1.ID = "NotButton1";
                    Button2.ID = "NotButton2";
                    Button3.ID = "Button1";
                    Button1.Text = "01";
                    EnableAndDisableByDays(2, lastDayOfMonth);
                    break;
                case 4:
                    Button1.ID = "NotButton1";
                    Button2.ID = "NotButton2";
                    Button3.ID = "NotButton3";
                    Button4.ID = "Button1";
                    Button1.Text = "01";
                    EnableAndDisableByDays(3, lastDayOfMonth);
                    break;
                case 5:
                    Button1.ID = "NotButton1";
                    Button2.ID = "NotButton2";
                    Button3.ID = "NotButton3";
                    Button4.ID = "NotButton4";
                    Button5.ID = "Button1";
                    Button1.Text = "01";
                    EnableAndDisableByDays(4, lastDayOfMonth);
                    break;
                case 6:
                    Button1.ID = "NotButton1";
                    Button2.ID = "NotButton2";
                    Button3.ID = "NotButton3";
                    Button4.ID = "NotButton4";
                    Button5.ID = "NotButton5";
                    Button6.ID = "Button1";
                    Button1.Text = "01";
                    EnableAndDisableByDays(5, lastDayOfMonth);
                    break;
                case 7:
                    Button1.ID = "NotButton1";
                    Button2.ID = "NotButton2";
                    Button3.ID = "NotButton3";
                    Button4.ID = "NotButton4";
                    Button5.ID = "NotButton5";
                    Button6.ID = "NotButton6";
                    Button7.ID = "Button1";
                    Button1.Text = "01";
                    EnableAndDisableByDays(6, lastDayOfMonth);
                    break;
            }
            Button1.Text = "01";
        }

        private void EnableAndDisableByDays (int daysLess, int lastDayOfMonth)
        {
            ContentPlaceHolder contentPlaceHolder = (ContentPlaceHolder)Master.FindControl("ContentPlaceHolder1");
            foreach (var button in contentPlaceHolder.Controls.OfType<Button>())
            {
                if (button.ID.Substring(0, 6).Equals("Button"))
                {
                    int buttonDay = int.Parse(button.ID.Replace("Button", "")) - daysLess;
                    if (buttonDay <= lastDayOfMonth)
                    {
                        if (buttonDay<=0)
                        {
                            button.Text = "01";
                        }
                        else
                        {
                            button.ID = "Button" + buttonDay;
                            button.Text = buttonDay.ToString("00");
                        }
                    }
                    else
                    {
                        if (buttonDay > lastDayOfMonth)
                        {
                            button.Visible = false;
                        }
                    }
                }
                else
                {
                    if (button.ID != "btnAdvance" && button.ID != "btnBack")
                    {
                        button.Visible = false;
                    }
                }
            }
        }

        protected void btnAdvance_Click(object sender, EventArgs e)
        {
            DateTime date = (DateTime)Session["DateLoader"];
            Session["DateLoader"] = date.AddMonths(1);
            Response.Redirect("CalendarMonths.aspx");
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            DateTime date = (DateTime)Session["DateLoader"];
            Session["DateLoader"] = date.AddMonths(-1);
            Response.Redirect("CalendarMonths.aspx");
        }
    }
}