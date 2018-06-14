<%@ Page Title="" Language="C#" MasterPageFile="~/Normal.Master" AutoEventWireup="true" CodeBehind="CrearUsuario.aspx.cs" Inherits="PortafolioNet.View.CrearUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="jumbotron">
        <div class="container">  
          <h1>Crear Usuario</h1>
        </div>
    </div>

    <section class="section">
      <div class="container">
          <div class="col-md-10 mb-5 element-animate">
              <div class="row">
                <div class="col-md-8 form-group">
                  <label for="nombre">Nombre:</label>
                    <asp:TextBox class="form-control" ID="txtNombre" type="text" runat="server" placeholder="Nombre"></asp:TextBox>
                </div>
              </div>
              <div class="row">
                <div class="col-md-8 form-group">
                  <label for="apellido">Apellido:</label>
                    <asp:TextBox class="form-control" ID="txtApellido" type="text" runat="server" placeholder="Apellido"></asp:TextBox>
                </div>
              </div>

              <div class="row">
                <div class="col-md-8 form-group">
                  <label for="email">Email:</label>
                <asp:TextBox class="form-control" ID="txtEmail" type="email" runat="server" placeholder="Ejemplo asd@gmail.com"></asp:TextBox>
                </div>
              </div>
              <div class="row">
                <div class="col-md-8 form-group">
                  <label for="fechanacimiento">Fecha de Nacimiento:</label>
                <asp:TextBox class="form-control" ID="txtFechaNacimiento" type="date" runat="server" placeholder="Ingresa tu fecha de nacimiento"></asp:TextBox>            
                </div>
              </div>
              <div class="row">
                <div class="col-md-8 form-group">
                  <label for="preguntasecreta" class="col-lg-10 control-label">Pregunta Secreta: </label>
                    <div class="col-lg-16">
                        <asp:DropDownList class="form-control" ID="ddlCampus" runat="server">
                             <asp:ListItem Value="">¿Cual es el nombre de tu primera mascota?</asp:ListItem>
                             <asp:ListItem Value=""> </asp:ListItem>
                             <asp:ListItem Value=""></asp:ListItem>
                             <asp:ListItem Value=""></asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>
                </div>

              <div class="row">
                <div class="col-md-8 form-group">
                  <label for="respuestasecreta">Respuesta Secreta:</label>
                <asp:TextBox class="form-control" ID="txtRespuestaSecreta" type="text" runat="server" placeholder="Ingrese su respuesta secreta"></asp:TextBox>
                </div>
              </div>
                <div class="row">
                    <div class="col-md-3 form-group">
                        <asp:Button ID="btnConfirmar" runat="server" Text="Confirmar" class="btn btn-primary btn-lg btn-block"   />
                    </div>
                    <div class="col-md-3 form-group">
                        <asp:Button ID="btnVolver" runat="server" Text="Volver" class="btn btn-primary btn-lg btn-block"   />
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
