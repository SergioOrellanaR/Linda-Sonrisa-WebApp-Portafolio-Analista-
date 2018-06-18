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
                UpdateVisitNumber();
                if (Session["ses"] != null)
                {
                    Response.Redirect("IndexLogin.aspx");
                }
            }
            
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            Client client = new Client()
            {
                User = new Business.User()
                {
                    Username = txUser.Text,
                    Password = txPass.Text
                }
            };

            if (client.User.Authenticate() == true)
            {
                client.Read();
                Session["ses"] = client;
                Response.Redirect("indexLogin.aspx");
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

        protected void BtnIngresar_Click(object sender, EventArgs e)
        {
            Contact contact = new Contact()
            {
                Cellphone = "0",
                Name = txtName.Text,
                Email = txtEmail.Text,
                Message = txtMessage.Text
            };
            contact.Create();
        }

        public void UpdateVisitNumber()
        {
            VisitNumber vn = new VisitNumber() { Id = 0};
            vn.Read();
            vn.Quantity++;
            if (!vn.Update())
            {
                vn.Id = 0;
                vn.Quantity = 0;
                vn.Create();
            }
            lblVisitCounter.Text = vn.Quantity.ToString();
        }
    }
}