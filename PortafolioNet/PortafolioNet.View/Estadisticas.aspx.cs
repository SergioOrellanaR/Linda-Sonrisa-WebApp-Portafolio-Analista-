using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PortafolioNet.Business;
using System.Data;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace PortafolioNet.View
{
    public partial class Estadisticas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ses"] != null)
            {
                Client client = (Client)Session["ses"];
                if (client.User.Username.Equals("Estadisticas"))
                {
                    Statistics stats = new Statistics();
                    lblAverageClientAge.Text = stats.AverageClientAge;
                    lblClientRegisteredQuantity.Text = stats.ClientRegisteredQuantity;
                    lblClientWithMoreHours.Text = stats.ClientWithMoreHours;
                    lblDentistWithLessHours.Text = stats.DentistWithLessHours;
                    lblDentistWithMoreHours.Text = stats.DentistWithMoreHours;
                    lblLessSolicitedService.Text = stats.LessSolicitedService;
                    lblMostClientCommune.Text = stats.MostClientCommune;
                    lblMostOlderClient.Text = stats.MostOlderClient;
                    lblMostSolicitedDay.Text = stats.MostSolicitedDay;
                    lblMostSolicitedService.Text = stats.MostSolicitedService;
                    lblMostYoungerClient.Text = stats.MostYoungerClient;
                    lblVisitNumber.Text = stats.VisitNumber;
                }
                else
                {
                    Response.Redirect("Index.aspx");
                }
            }
            else
            {
                Response.Redirect("Index.aspx");
            }
        }

        protected void btnClose_Click(object sender, EventArgs e)
        {
            Session["ses"] = null;
            Response.Redirect("Index.aspx");
        }

        protected void btnGeneratePDF_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtbl = makeDatatable();
                ExportDataTableToPdf(dtbl, "C:\\Users\\orell\\Desktop\\Actividades 1er Semestre 2018\\Portafolio\\Portafolio web\\PortafolioNet\\PortafolioNet.View\\Reportes\\Reporte.pdf", "Reporte");
                HttpResponse res = HttpContext.Current.Response;
                res.Clear();
                res.AppendHeader("content-disposition", "attachment; filename=Reportes.pdf");
                res.ContentType = "application/octet-stream";
                res.WriteFile("C:\\Users\\orell\\Desktop\\Actividades 1er Semestre 2018\\Portafolio\\Portafolio web\\PortafolioNet\\PortafolioNet.View\\Reportes\\Reporte.pdf");
                res.Flush();
                res.End();
            }
            catch (Exception)
            {
                string val = "";
            }
        }

        private void ExportDataTableToPdf(DataTable dtbl, String pdfPath, string header)
        {

            try
            {
                FileStream fs = new FileStream(pdfPath, FileMode.Create, FileAccess.Write, FileShare.None);
                Document document = new Document();
                document.SetPageSize(PageSize.A4);
                PdfWriter writer = PdfWriter.GetInstance(document, fs);
                document.Open();

                //Report Header
                BaseFont bfntHead = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                Font fntHead = new Font(bfntHead, 16, 1, iTextSharp.text.BaseColor.GRAY);
                Paragraph prgHeading = new Paragraph();
                prgHeading.Alignment = Element.ALIGN_CENTER;
                prgHeading.Add(new Chunk(header.ToUpper(), fntHead));
                document.Add(prgHeading);

                //Author
                Paragraph prgAuthor = new Paragraph();
                BaseFont btnAuthor = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                Font fntAuthor = new Font(btnAuthor, 8, 2, BaseColor.GRAY);
                prgAuthor.Alignment = Element.ALIGN_LEFT;
                prgAuthor.Add(new Chunk("Fecha de reporte: " + DateTime.Now.ToShortDateString(), fntAuthor));
                document.Add(prgAuthor);

                //Img
                iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(@"C:\Users\orell\Desktop\Actividades 1er Semestre 2018\Portafolio\Portafolio web\PortafolioNet\PortafolioNet.View\images\Logo.png");
                logo.ScaleAbsoluteHeight(50);
                logo.ScaleAbsoluteWidth(180);
                logo.Alignment = Element.ALIGN_RIGHT;
                document.Add(logo);

                //Separador de Linea.
                Paragraph p = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_LEFT, 0.0F)));
                document.Add(p);

                document.Add(new Chunk("\n", fntHead));

                //EScribir la tabla:
                PdfPTable table = new PdfPTable(dtbl.Columns.Count);
                //Header de tabla.
                BaseFont btnColumnHeader = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                Font fntColumnHeader = new Font(btnColumnHeader, 10, 1, BaseColor.WHITE);
                for (int i = 0; i < dtbl.Columns.Count; i++)
                {
                    PdfPCell cell = new PdfPCell();
                    cell.BackgroundColor = BaseColor.GRAY;
                    cell.AddElement(new Chunk(dtbl.Columns[i].ColumnName.ToUpper(), fntColumnHeader));
                    table.AddCell(cell);
                }
                //Datos de table.
                for (int i = 0; i < dtbl.Rows.Count; i++)
                {
                    for (int j = 0; j < dtbl.Columns.Count; j++)
                    {
                        table.AddCell(dtbl.Rows[i][j].ToString());
                    }
                }
                document.Add(table);
                document.Close();
                writer.Close();
                fs.Close();
            }
            catch (Exception e)
            {
                string val = e.Message;
            }
        }

        DataTable makeDatatable()
        {
            Statistics stats = new Statistics();
            DataTable table = new DataTable();
            table.Columns.Add("Bienvenido a estadísticas de clínica odontológica Linda sonrisa.");

            table.Rows.Add(stats.AverageClientAge);
            table.Rows.Add(stats.ClientRegisteredQuantity);
            table.Rows.Add(stats.ClientWithMoreHours);
            table.Rows.Add(stats.DentistWithLessHours);
            table.Rows.Add(stats.DentistWithMoreHours);
            table.Rows.Add(stats.LessSolicitedService);
            table.Rows.Add(stats.MostClientCommune);
            table.Rows.Add(stats.MostOlderClient);
            table.Rows.Add(stats.MostSolicitedDay);
            table.Rows.Add(stats.MostSolicitedService);
            table.Rows.Add(stats.MostYoungerClient);
            table.Rows.Add(stats.VisitNumber);

            return table;
        }
    }
}