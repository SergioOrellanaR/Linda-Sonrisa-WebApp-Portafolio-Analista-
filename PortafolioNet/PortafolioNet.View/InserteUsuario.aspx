<%@ Page Title="" Language="C#" MasterPageFile="~/Normal.Master" AutoEventWireup="true" CodeBehind="InserteUsuario.aspx.cs" Inherits="PortafolioNet.View.InserteUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="jumbotron">
        <div class="container">  
          <h1>Recuperar Contraseña</h1>
        </div>
    </div>

    <section class="section">
      <div class="container">
          <div class="col-md-8 mb-5 element-animate">
              <div class="row">
                <div class="col-md-8 form-group">
                  <label for="usuario">Inserte Usuario:</label>
                <asp:TextBox class="form-control" ID="txtUsuario" type="text" runat="server" placeholder="Ingrese su usuario"></asp:TextBox>
                <br />
                  <asp:Label ID="lblMessage" runat="server" Text="" ForeColor="Red"></asp:Label>
                </div>
              </div>
                <div class="row">
                    <div class="col-md-3 form-group">
                        <asp:Button ID="BtnContinuar" runat="server" Text="Continuar" class="btn btn-primary btn-lg btn-block" OnClick="BtnContinuar_Click"   />
                    </div>
                    <div class="col-md-3 form-group">
                        <asp:Button ID="btnVolver" runat="server" Text="Volver" class="btn btn-primary btn-lg btn-block" OnClick="btnVolver_Click"   />
                    </div>
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
