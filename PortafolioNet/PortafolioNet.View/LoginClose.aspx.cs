
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
                User usr = (User)Session["ses"];
                lblName.Text = usr.Username;
            }
            
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Session["ses"] = null;
            Response.Redirect("Index.aspx");
        }
    }
}