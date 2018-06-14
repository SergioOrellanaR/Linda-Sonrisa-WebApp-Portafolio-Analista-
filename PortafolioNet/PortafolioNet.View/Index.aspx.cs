using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PortafolioNet.Business;

namespace PortafolioNet.View
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //UpdateVisitNumber();
                if (Session["ses"] != null)
                {
                    lblLogin.Text = "";
                    lblCredenciales.Text = "";
                    txUser.Visible = false;
                    txPass.Visible = false;
                    lblCerrarSesion.Visible = true;
                    lblSituacionEconomica.Visible = true;
                    User user = (User)Session["ses"];
                    lblUsernameWelcome.Text = user.Username;
                    lblEnterAsUser.Text = "Aquí podrás encontrar todo lo que necesitas "+ user.Username;
                    lblErrorMessage.Text = "";
                    submit.Visible = false;
                }
            }
            
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            User user = new User()
            {
                Username = txUser.Text,
                Password = txPass.Text
            };

            if (user.Authenticate() == true)
            {
                Session["ses"] = user;
                Response.Redirect("Index.aspx");
            }
            else
            {
                lblErrorMessage.Text = "Ingrese credenciales válidas";
                contact.Focus();
            }
        }

        protected void ValidateUser_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = args.Value.Length > 5 && args.Value.Length < 19;
        }

        protected void ValidatePassword_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = args.Value.Length > 5 && args.Value.Length < 19;
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("CrearUsuario.aspx");
        }

        //public void UpdateVisitNumber()
        //{
        //    VisitNumber vn = new VisitNumber();
        //    vn.Quantity += 1;
        //    vn.Update();
        //    lblVisitNumber.Text = vn.Quantity.ToString();
        //}
    }
}