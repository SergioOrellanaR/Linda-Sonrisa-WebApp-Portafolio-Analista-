using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PortafolioNet.Business;
namespace PortafolioNet.View
{
    public partial class PreguntaSecreta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["recover"]!= null)
            {
                User user = (User)Session["recover"];
                SecretQuestion question = new SecretQuestion() { Id = user.IdSecretQuestion };
                if (question.Read())
                {
                    lblQuestion.Text = question.Question;
                }                
            }
        }

        protected void btnConfirmar_Click(object sender, EventArgs e)
        {
            User user = (User)Session["recover"];
            if (user.AnswerSecretQuestion.Equals(txtRespuestaSecreta.Text))
            {
                Response.Redirect("RestablecerContraseña.aspx");
            }
            else
            {
                Session["recover"] = null;
                Response.Redirect("InserteUsuario.aspx");
            }
        }
    }
}