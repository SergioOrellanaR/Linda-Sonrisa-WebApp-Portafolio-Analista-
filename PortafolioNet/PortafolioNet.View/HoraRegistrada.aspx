<%@ Page Title="" Language="C#" MasterPageFile="~/Logeado.Master" AutoEventWireup="true" CodeBehind="HoraRegistrada.aspx.cs" Inherits="PortafolioNet.View.HoraRegistrada" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Estilos/css/style.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <a href="indexLogin.aspx" class="cta-link element-animate" data-animate-effect="fadeIn" data-target="#modalAppointment">
        <label for="servicio" class="col-lg-10 control-label"><span class="sub-heading">Estimado/a
            <asp:Label ID="lblClientName" runat="server" Text="Label"></asp:Label> su cita para el servicio de 
            <asp:Label ID="lblService" runat="server" Text="Label"></asp:Label> ha sido agendada para el día
            <asp:Label ID="lblFechaCita" runat="server" Text="Label"></asp:Label> con el odontólogo
            <asp:Label ID="lblOdontologo" runat="server" Text="Label"></asp:Label>
            </span></label>
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
