<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SituacionEconomica.aspx.cs" Inherits="PortafolioNet.View.SituacionEconomica" %>

<!doctype html>

<html class="no-js" lang="">

<head>
<meta charset="utf-8">
<meta name="description" content="">
<meta name="viewport" content="width=device-width, initial-scale=1">
<title>Odontologica Linda Sonrisa</title>
<link rel="stylesheet" href="css/bootstrap.min.css">
<link rel="stylesheet" href="css/flexslider.css">
<link rel="stylesheet" href="css/jquery.fancybox.css">
<link rel="stylesheet" href="css/main.css">
<link rel="stylesheet" href="css/responsive.css">
<link rel="stylesheet" href="css/font-icon.css">
<link rel="stylesheet" href="css/animate.min.css">
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/4.4.0/css/font-awesome.min.css">
</head>

<body>
        <form id="form1" runat="server">
<!-- header section -->


    <!-- contact section -->
    <div class="jumbotron">
        <div class="container">  
          <h1>Crear Usuario</h1>
        </div>
    </div>
<section id="contact" class="section">
  <div class="container">
    <div class="form-group">
        <label for="email" class="col-lg-2 control-label">Nombre:</label>
        <div class="col-lg-5">
                <asp:TextBox class="form-control" ID="txtNombre" type="text" runat="server" placeholder="Nombre"></asp:TextBox>
        </div>
    </div>
      <br /><br />
    <div class="form-group">
        <label for="email" class="col-lg-2 control-label">Apellido:</label>
        <div class="col-lg-5">
                <asp:TextBox class="form-control" ID="txtApellido" type="text" runat="server" placeholder="Apellido"></asp:TextBox>
        </div>
    </div>
       <br /><br />
    <div class="form-group">
        <label for="email" class="col-lg-2 control-label">Email:</label>
        <div class="col-lg-5">
                <asp:TextBox class="form-control" ID="txtEmail" type="email" runat="server" placeholder="Ejemplo asd@gmail.com"></asp:TextBox>
        </div>
    </div>
        <br /><br />

    <div class="form-group">
        <label for="email" class="col-lg-2 control-label">Fecha Nacimiento:</label>
        <div class="col-lg-5">
                <asp:TextBox class="form-control" ID="txtFechaNacimiento" type="date" runat="server" placeholder="Ingresa tu fecha de nacimiento"></asp:TextBox>            
        </div>
    </div>
      <br /><br />
    <div class="form-group">
        <label for="motivo" class="col-lg-2 control-label">Pregunta Secreta: </label>
        <div class="col-lg-5">
            <asp:DropDownList class="form-control" ID="ddlCampus" runat="server">
                 <asp:ListItem Value="">¿Cual es el nombre de tu primera mascota?</asp:ListItem>
                 <asp:ListItem Value=""> </asp:ListItem>
                 <asp:ListItem Value=""></asp:ListItem>
                 <asp:ListItem Value=""></asp:ListItem>
            </asp:DropDownList>
        </div>
    </div>   
      <br /><br />
    <div class="form-group">
        <label for="email" class="col-lg-2 control-label">Respuesta Secreta: </label>
        <div class="col-lg-5">
                <asp:TextBox class="form-control" ID="txtRespuestaSecreta" type="text" runat="server" placeholder="Ingrese su respuesta secreta"></asp:TextBox>
        </div>
    </div>
        <br /><br />
    <div class="form-group">
        <div class="col-lg-offset-2 col-lg-10">      
            <asp:Button ID="btnConfirmar" runat="server" Text="Confirmar" class="btn btn-default" />
            <asp:Button ID="btnVolver" runat="server" Text="Volver" class="btn btn-default" />
        </div>
    </div>    
  </div>
</section>
<!-- contact section --> 
<!-- Footer section -->
<footer class="footer">
  <div class="footer-top section">
    <div class="container">
      <div class="row">
        <div class="footer-col col-md-6">
          <h5>Our Office Location</h5>
          <p>Los memitos, Santiago, Chile.<br>
            1800 1234 56789 / 98532100987<br>
            support@meme.com</p>
          <p>Copyright © Inc. All Rights Reserved.</a></p>
        </div>
        <div class="footer-col col-md-3">
          <h5>Servicios memeros</h5>
          <p>
          <ul>
            <li><a href="#">DMeme1</a></li>
            <li><a href="#">DMeme1</a></li>
            <li><a href="#">DMeme1</a></li>
            <li><a href="#">DMeme1 Media</a></li>
            <li><a href="#">DMeme1</a></li>
          </ul>
          </p>
        </div>
        <div class="footer-col col-md-3">
          <h5>Redes sociales</h5>
          <ul class="footer-share">
            <li><a href="#"><i class="fa fa-facebook"></i></a></li>
            <li><a href="#"><i class="fa fa-twitter"></i></a></li>
            <li><a href="#"><i class="fa fa-linkedin"></i></a></li>
            <li><a href="#"><i class="fa fa-google-plus"></i></a></li>
          </ul>
        </div>
      </div>
    </div>
  </div>
  <!-- footer top --> 
  
</footer>

<!-- Footer section --> 
<!-- JS FILES --> 
<script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script> 
<script src="js/bootstrap.min.js"></script> 
<script src="js/jquery.flexslider-min.js"></script> 
<script src="js/jquery.fancybox.pack.js"></script> 
<script src="js/retina.min.js"></script> 
<script src="js/modernizr.js"></script> 
<script src="js/main.js"></script> 
<script type="text/javascript" src="js/jquery.contact.js"></script>
            </form>
</body>
</html>