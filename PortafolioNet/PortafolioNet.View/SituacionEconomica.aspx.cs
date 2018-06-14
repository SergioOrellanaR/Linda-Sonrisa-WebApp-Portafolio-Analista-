using System;
using System.Collections.Generic;
using System.Linq;
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
                User usr = (User)Session["ses"];
                //creamos nuestra lista de archivos a enviar
                List<string> lstArchivos = new List<string>();
                Attachment at = new Attachment(AtUploader.PostedFile.InputStream, AtUploader.FileName);

                //creamos nuestro objeto de la clase que hicimos
                MailSender oMail = new MailSender("lindasonrisawebpage@gmail.com", "odontologicalindasonrisa@gmail.com", txtMessage.Text
                                    , "Situación socioeconómica de: " + usr.Username, at);
                //y enviamos
                if (oMail.enviaMail())
                {
                    lblErrorText.Text = "Email enviado con éxito";
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
    }
}