
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PortafolioNet.Business;

namespace PortafolioNet.View
{
    public partial class LoginTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ses"] != null)
            {
                Client client = (Client)Session["ses"];
                lblName.Text = client.FirstName + " " + client.FirstLastName;
                Session["ses"] = null;
            }
            else
            {
                Response.Redirect("Index.aspx");
            }
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }
    }
}