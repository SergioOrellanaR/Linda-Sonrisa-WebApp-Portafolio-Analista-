using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PortafolioNet.Business;

namespace PortafolioNet.View
{
    public partial class SeleccionServicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadService();
            }
        }

        protected void btnContinuar_Click(object sender, EventArgs e)
        {
            Service service = new Service() { Id = getServiceIdByName() };
            if (service.Read())
            {
                ScheduleHourController schec = new ScheduleHourController()
                {
                    FunctionaryRut = service.RutFunctionary,
                    ServiceName = service.Description
                };
                schec.FunctionaryNameByRut(schec.FunctionaryRut);
                Session["ScheduleHour"] = schec;
                Response.Redirect("CalendarMonths.aspx");
            }
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("indexLogin.aspx");
        }

        private void LoadService()
        {
            List<string> list = new List<string>();
            foreach (Service service in ComboBoxDataLoader.ServicesList())
            {
                list.Add(service.Description);
            }
            ddlService.DataSource = list;
            ddlService.DataBind();
        }

        private int getServiceIdByName()
        {
            Service service = new Service()
            {
                Description = ddlService.SelectedValue
            };
            return service.getIdByName();
        }
    }
}