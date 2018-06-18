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
                        Response.Redirect("indexLogin.aspx");
                    }
                }
                else
                {
                    Response.Redirect("Index.aspx");
                }

            }
        }

        private int rutWithoutDV()
        {
            string rut = txtRut.Text.Replace("-", "").Replace(".", "").Replace(",", "");
            string rutWithoutDV = rut.Substring(0, rut.Length - 1);
            return int.Parse(rutWithoutDV);
        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            Client client = new Client() { Rut = rutWithoutDV() };
            args.IsValid = !client.RutAlreadyExist();
        }

        protected void CustomValidator2_ServerValidate(object source, ServerValidateEventArgs args)
        {
            User user = new User() { Username = txtUsername.Text };
            args.IsValid = !user.UsernameAlreadyExist();
        }

        protected void CustomValidator3_ServerValidate(object source, ServerValidateEventArgs args)
        {
            Client client = new Client() { Email = txtEmail.Text };
            args.IsValid = !client.MailAlreadyExist();
        }

        public bool isValidRut(string rut)
        {
            bool validacion = false;
            try
            {
                rut = rut.ToUpper();
                rut = rut.Replace(".", "");
                rut = rut.Replace("-", "");
                rut = rut.Replace(",", "");
                int rutAux = int.Parse(rut.Substring(0, rut.Length - 1));

                char dv = char.Parse(rut.Substring(rut.Length - 1, 1));

                int m = 0, s = 1;
                for (; rutAux != 0; rutAux /= 10)
                {
                    s = (s + rutAux % 10 * (9 - m++ % 6)) % 11;
                }
                if (dv == (char)(s != 0 ? s + 47 : 75))
                {
                    validacion = true;
                }
            }
            catch (Exception)
            {
            }
            return validacion;
        }

        protected void CustomValidator4_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = isValidRut(txtRut.Text);
        }
    }
}