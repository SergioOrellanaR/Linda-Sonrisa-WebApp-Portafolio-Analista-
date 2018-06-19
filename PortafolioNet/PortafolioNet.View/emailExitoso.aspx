<%@ Page Title="" Language="C#" MasterPageFile="~/Logeado.Master" AutoEventWireup="true" CodeBehind="emailExitoso.aspx.cs" Inherits="PortafolioNet.View.emailExitoso" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="Estilos/css/style.css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <a href="indexLogin.aspx" class="cta-link element-animate" data-animate-effect="fadeIn" data-target="#modalAppointment">
      <label for="servicio" class="col-lg-10 control-label"><span class="sub-heading">El email se ha enviado exitosamente, este sera recibido por el/la recepcionista quien le informará por email ingresado por usted si se validó su situación socio economica.</span></label> 
        <label for="servicio" class="col-lg-10 control-label"><span class="sub-heading">El tiempo estimado para este proceso es de aproximadamente una semana.</span></label>   
    </a>

    <script src="Estilos/js/jquery-3.2.1.min.js"></script>
    <script src="Estilos/js/popper.min.js"></script>
    <script src="Estilos/js/bootstrap.min.js"></script>
    <script src="Estilos/js/owl.carousel.min.js"></script>
    <script src="Estilos/js/bootstrap-datepicker.js"></script>
    <script src="Estilos/js/jquery.timepicker.min.js"></script>
    <script src="Estilos/js/jquery.waypoints.min.js"></script>
    <script src="Estilos/js/main.js"></script>
</asp:Content>