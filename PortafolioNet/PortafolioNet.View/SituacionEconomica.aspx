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
