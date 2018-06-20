using PortafolioNet.Business;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PortafolioNet.View
{
    public partial class SituacionEconomica : System.Web.UI.Page
    {
        public const int MAX_MB = 25165824;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void submit_Click(object sender, EventArgs e)
        {
            lblErrorText.Text = "";
            if (Page.IsValid && AtUploader.HasFile)
            {
                Client client = (Client)Session["ses"];
                //creamos nuestra lista de archivos a enviar
                List<string> lstArchivos = new List<string>();
                Attachment at = new Attachment(AtUploader.PostedFile.InputStream, AtUploader.FileName);
                String title = "Situación socioeconómica de: " + client.FirstName + " " + client.FirstLastName + " (" + client.Rut + ")";
                //creamos nuestro objeto de la clase que hicimos
                MailSender oMail = new MailSender("lindasonrisawebpage@gmail.com", "odontologicalindasonrisa@gmail.com", txtMessage.Text
                                    ,title, at);
                //y enviamos
                if (oMail.enviaMail())
                {
                    Response.Redirect("emailExitoso.aspx");
                }
                else
                {
                    lblErrorText.Text = "Error durante el envío de Email";
                }
            }
            else
            {
                if (!AtUploader.HasFile)
                {
                    lblErrorText.Text = "Adjunte archivo por favor";
                }
            }
        }

        private Boolean isValidFileFormat(String fileExtension)
        {
            String value = fileExtension.ToLower();
            return value.Equals(".rar") || value.Equals(".zip") || value.Equals(".7z");
        }

        private Boolean isValidFileLength(int fileLength)
        {
            return fileLength < MAX_MB;
        }

        protected void fileValidator_ServerValidate(object source, ServerValidateEventArgs args)
        {
            string fileExtension = Path.GetExtension(AtUploader.PostedFile.FileName);
            int fileLength = AtUploader.PostedFile.ContentLength;
            Boolean isFileValid = false;
            if (isValidFileFormat(fileExtension))
            {
                if (isValidFileLength(fileLength))
                {
                    isFileValid = true;
                }
                else
                {
                    fileValidator.ErrorMessage = "El tamaño del archivo debe ser menor a 25 MB";
                }
            }
            else
            {
                fileValidator.ErrorMessage = "El archivo debe estar en formato .zip, .rar o .7z";
            }
            args.IsValid = isFileValid;
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("indexLogin.aspx");
        }
    }
}