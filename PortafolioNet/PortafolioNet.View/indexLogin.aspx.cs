using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PortafolioNet.Business;

namespace PortafolioNet.View
{
    public partial class indexLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ses"] != null)
            {
                Client client = (Client)Session["ses"];
                lblUsernameWelcome.Text = client.FirstName + " " + client.FirstLastName;
            }
            else
            {
                Response.Redirect("Index.aspx");
            }
        }
    }
}