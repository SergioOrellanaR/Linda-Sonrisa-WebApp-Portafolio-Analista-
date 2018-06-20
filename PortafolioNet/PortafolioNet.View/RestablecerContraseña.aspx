<%@ Page Title="" Language="C#" MasterPageFile="~/Normal.Master" AutoEventWireup="true" CodeBehind="RestablecerContraseña.aspx.cs" Inherits="PortafolioNet.View.RestablecerContraseña" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="jumbotron">
        <div class="container">  
          <h1>Restablecer Contraseña</h1>
        </div>
    </div>

    <section class="section">
      <div class="container">
          <div class="col-md-8 mb-5 element-animate">
              <div class="row">
                <div class="col-md-10 form-group">
                  <label for="contraseña">Nueva contraseña: </label>
                    <asp:TextBox class="form-control" ID="txtNuevaContraseña" type="password" runat="server" placeholder="Nueva Contraseña" MaxLength="30"></asp:TextBox>   
                </div>
              </div>
              <br />
              <div class="row">
                <div class="col-md-10 form-group">
                  <label for="respuesta2">Confirmar nueva contraseña: </label>
                <asp:TextBox class="form-control" ID="txtConfirmarContraseña" type="password" runat="server" placeholder="Confirmar nueva contraseña" MaxLength="30"></asp:TextBox>
                    <br />
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Las contraseñas deben coincidir" ForeColor="Red" ControlToCompare="txtNuevaContraseña" ControlToValidate="txtConfirmarContraseña"></asp:CompareValidator>
                </div>
              </div>

          </div>
                <div class="row">
                    <div class="col-md-2 form-group">
                        <asp:Button ID="btnConfirmar" runat="server" Text="Confirmar" class="btn btn-primary btn-lg btn-block" OnClick="btnConfirmar_Click"   />
                    </div>
                    <div class="col-md-2 form-group">
                        <asp:Button ID="btnVolver" runat="server" Text="Volver" class="btn btn-primary btn-lg btn-block" OnClick="btnVolver_Click"   />
                    </div>
                </div>
      </div>
    </section>

 <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script> 
<script src="js/bootstrap.min.js"></script> 
<script src="js/jquery.flexslider-min.js"></script> 
<script src="js/jquery.fancybox.pack.js"></script> 
<script src="js/retina.min.js"></script> 
<script src="js/modernizr.js"></script> 
<script src="js/main.js"></script> 
<script type="text/javascript" src="js/jquery.contact.js"></script>
</asp:Content>
