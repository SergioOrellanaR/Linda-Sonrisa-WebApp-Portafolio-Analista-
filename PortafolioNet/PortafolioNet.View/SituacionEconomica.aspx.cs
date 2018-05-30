using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PortafolioNet.Business;
using System.Net.Mail;
using System.IO;

namespace PortafolioNet.View
{
    public partial class SituacionEconomica : System.Web.UI.Page
    {
        public const int MAX_MB = 25165824;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["ses"] == null)
                {
                    Response.Redirect("Index.aspx");
                }
            }
        }

        protected void submit_Click(object sender, EventArgs e)
        {
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

                }
                else
                {
                    lblMensajePrueba.Text = "Error durante el envío de Email";
                }
            }
            else
            {
                lblMensajePrueba.Text = "Adjunte archivo por favor";
            }
        }

        private Boolean isValidFileFormat(String fileExtension)
        {
            String value = fileExtension.ToLower();
            return value.Equals(".rar") || value.Equals(".zip") || value.Equals(".7z");
        }

        private Boolean isValidFileLength (int fileLength)
        {
            return fileLength < MAX_MB;
        }

        protected void fileValidator_ServerValidate(object source, ServerValidateEventArgs args)
        {
            string fileExtension = Path.GetExtension(AtUploader.PostedFile.FileName);
            int fileLength = AtUploader.PostedFile.ContentLength;
            Boolean isFileValid = false ;
            if (AtUploader.HasFile)
            { 
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
            }
            else
            {
                fileValidator.ErrorMessage = "Por favor, adjunte un archivo para acreditar su situación";
            }
            args.IsValid = isFileValid;
        }
    }
}