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
            UpdateVisitNumber();
            if (Session["ses"] != null)
            {
                Client client = (Client)Session["ses"];
                client.User.ReadById();
                if (client.User.Username.Equals("Estadisticas"))
                {
                    Response.Redirect("Estadisticas.aspx");
                }
                else
                {
                    lblUsernameWelcome.Text = client.FirstName + " " + client.FirstLastName;
                }
            }
            else
            {
                Response.Redirect("Index.aspx");
            }
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
            VisitNumber vn = new VisitNumber() { Id = 0 };
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