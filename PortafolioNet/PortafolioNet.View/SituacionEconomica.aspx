<%@ Page Title="" Language="C#" MasterPageFile="~/Logeado.Master" AutoEventWireup="true" CodeBehind="SituacionEconomica.aspx.cs" Inherits="PortafolioNet.View.SituacionEconomica" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="jumbotron">
        <div class="container">  
          <h1>Situacion Socio Economica</h1>
        </div>
    </div>

    <section class="section">
      <div class="container">
        <div class="alert alert-success" role="alert">
          <h4 class="alert-heading">Información importante acerca del archivo adjunto</h4>
          <p>El archivo adjunto de su situacion socio economica debe ser comprimido (7z, rar o zip) y menor a 25 MB</p>
          <p class="mb-0">El archivo adjunto de la situacion socio economica es obligatorio</p>
            <hr>
          <h4 class="alert-heading">Documentos solicitados</h4>
          <p class="mb-0">-Cartola hogar actualizada del Registro Social de Hogares (visita su <a href="http://www.registrosocial.gob.cl/" class="alert-link">sitio web</a>)</p>
           </br>
            <p class="mb-0">-Fotocopia Cédula de Identidad por ambos lados de TODOS los integrantes del grupo familiar, incluido el postulante. Si un integrante del grupo familiar NO cuenta con el documento se solicitará el Certificado de Nacimiento o Fotocopia de la Libreta de Familia.</p>
            </br>
            <p class="mb-0">-En caso que algún integrante de tu grupo familiar presente algún diagnóstico de discapacidad, debes presentar un certificado emitido por COMPIN o una credencial de discapacidad emitida por SENADIS o un certificado emitido por el Registro Civil</p>
            </br>
            <p class="mb-0">-Liquidaciones de remuneraciones desde enero a diciembre de 2018, para TODOS los integrantes del grupo familiar que perciban ingresos vía contrato</p>
             </br>
            <p class="mb-0">-Certificado de Cotizaciones de AFP de los últimos doce meses con el RUT DEL EMPLEADOR y finiquitos.</p>                   
        </div>
      </div>
    </section>          

    <section class="section">
      <div class="container">
        <div class="row">
          <div class="col-md-8 mb-5 element-animate">
              <div class="row">
                <div class="col-md-8 form-group">
                  <label for="fadjuntar">Adjuntar:</label>
                    <asp:FileUpload ID="AtUploader" runat="server" class=" form-control-lg" />
                    <asp:CustomValidator ID="fileValidator" runat="server" ErrorMessage="" OnServerValidate="fileValidator_ServerValidate" ControlToValidate="AtUploader"></asp:CustomValidator>                
                </div>
              </div>
              <div class="row">
                <div class="col-md-12 form-group">
                  <label for="message">Escriba un Mensaje</label>
                  <asp:TextBox ID="txtMessage" runat="server" TextMode="MultiLine" cols="30" rows="8" class="form-control form-control-lg" ></asp:TextBox><br />
                </div>
              </div>
              <div class="row">
                <div class="col-md-6 form-group">
                    <asp:Button ID="btnSend" runat="server" Text="Enviar" class="btn btn-primary btn-lg btn-block"  OnClick="submit_Click"  />
                </div>
                <div class="col-md-6 form-group">
                    <asp:Button ID="btnVolver" runat="server" Text="Volver" class="btn btn-primary btn-lg btn-block submitBnt"   />
                </div>
              </div>
              <asp:Label ID="lblErrorText" runat="server" Text=""></asp:Label>
          </div>
        </div>
      </div>
    </section>

        <script src="Estilos/js/jquery-3.2.1.min.js"></script>
    <script src="Estilos/js/popper.min.js"></script>
    <script src="Estilos/js/bootstrap.min.js"></script>
    <script src="Estilos/js/owl.carousel.min.js"></script>
    <script src="Estilos/js/bootstrap-datepicker.js"></script>
    <script src="Estilos/js/jquery.timepicker.min.js"></script>
    <script src="Estilos/js/jquery.waypoints.min.js"></script>
    <script src="Estilos/js/main.js"></script>
</asp:Content>
