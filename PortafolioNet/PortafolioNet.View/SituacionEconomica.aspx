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
<section class="banner" role="banner">
  <header id="header">
    <div class="header-content clearfix"> <a class="logo" href="Index.aspx">LINDA SONRISA</a>
      <nav class="navigation" role="navigation">
        <ul class="primary-nav">
          <li><a href="Index.aspx">Nosotros</a></li>
          <li><a href="Index.aspx">Servicios</a></li>
          <li><a href="Index.aspx">Nuestro equipo</a></li>
          <li><a href="#contact">Situacion Economica</a></li>
          <li><a href="Index.aspx">Contacto</a></li>
          <li><a href="Index.aspx">Login</a></li>
        </ul>
      </nav>
      <a href="#" class="nav-toggle">Menu<span></span></a> </div>
  </header>
      <!-- banner text -->
      <div class="container">
    <div class="col-md-10 col-md-offset-1">
      <div class="banner-text text-center">
        <h1> <asp:Label ID="lblCredenciales" runat="server" Text=""></asp:Label>  </h1>
          <br />
          <br />
        <h1>Regulariza tu situacion Socio Economica<asp:Label ID="lblUsernameWelcome" runat="server" Text=""></asp:Label></h1>
        <p>Lorem ipsum dolor sit ametcursus magna vel scelerisque Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent commodo cursus magna vel scelerisque nisl consectetur et.nisl consectetur et.</p>
        <a href="#contact" class="btn btn-large">Regularizar</a> </div>
      <!-- banner text --> 
    </div>
  </div>
    </section>

    <!-- contact section -->
<section id="contact" class="section">
  <div class="container">
    <div class="row">
      <div class="col-md-8 col-md-offset-2 conForm">
        <h5>Situacion Socio Economica</h5>
        <div id="message"></div>    
          <div class="form-group">     
              <label>Adjuntar: </label>&nbsp; &nbsp;
              <asp:FileUpload ID="AtUploader" runat="server" /><br />
              <br />
          </div>
          <asp:TextBox ID="txtMessage" runat="server" TextMode="MultiLine" MaxLength="500" Width="600px"></asp:TextBox><br />
          <asp:Button ID="btnSend" runat="server" Text="Enviar" class="submitBnt" OnClick="submit_Click"   />
          <input type="submit" id="volver" name="volver" class="volverBnt" value="Volver">
          <br />
          <asp:CustomValidator ID="fileValidator" runat="server" ErrorMessage="" OnServerValidate="fileValidator_ServerValidate" ControlToValidate="AtUploader"></asp:CustomValidator>
          <br />
          <asp:Label ID="lblErrorText" runat="server" Text=""></asp:Label>
          <div id="simple-msg"></div>
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