using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PortafolioNet.Business;

namespace PortafolioNet.View
{
    public partial class InserteUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnContinuar_Click(object sender, EventArgs e)
        {
            User user = new User() { Username = txtUsuario.Text };
            if (user.Read())
            {
                Session["recover"] = user;
                Response.Redirect("PreguntaSecreta.aspx");
            }
            else
            {
                lblMessage.Text = "Verifique que el usuario ingresado sea correcto";
            }
        }
    }
}