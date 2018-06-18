using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PortafolioNet.Business;

namespace PortafolioNet.View
{
    public partial class CrearUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }

        protected void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                User user = new User()
                {
                    Username = txtUsername.Text,
                    Password = txtPassword.Text,
                    IdSecretQuestion = int.Parse(ddlSecretQuestion.SelectedValue),
                    AnswerSecretQuestion = txtRespuestaSecreta.Text
                };

                string rut = txtRut.Text.Replace("-","").Replace(".","").Replace(",","");
                string rutWithoutDV = rut.Substring(0, rut.Length - 1);
                string dv = rut.Substring(rut.Length - 1);
                string[] names = txtName.Text.Split(' ');
                if (user.Create())
                {
                    user.Read();
                    Client client = new Client()
                    {
                        Rut = int.Parse(rutWithoutDV),
                        Dv = dv,
                        Address = txtAddress.Text,
                        Email = txtEmail.Text,
                        FirstName = names[0],
                        SecondName = names.Length > 1 ? names[1] : "",
                        FirstLastName = txtFirstLastName.Text,
                        SecondLastName = txtSecondLastName.Text,
                        Phone = int.Parse(txtPhone.Text),
                        Vulnerable = 0,
                        Gender = ddlGender.SelectedValue,
                        IdCommune = int.Parse(ddlCommune.SelectedValue),
                        User = user,
                        BirthDate = DateTime.Parse(txtFechaNacimiento.Text)
                    };
                    if (client.Create())
                    {
                        Session["ses"] = client;
                        Response.Redirect("index.aspx");
                    }
                }
                else
                {
                    Response.Redirect("Junio.aspx");
                }

            }
        }
    }
}