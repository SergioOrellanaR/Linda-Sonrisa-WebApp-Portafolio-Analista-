<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="indexLogin.aspx.cs" Inherits="PortafolioNet.View.indexLogin" %>

<!DOCTYPE html>

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
    <style>
       #map {
        height: 400px;
        width: 100%;
       }
    </style>
</head>

<body>
    <form id="form1" runat="server">
<!-- header section -->
<section class="banner" role="banner">
  <header id="header">
    <div class="header-content clearfix"> <a class="logo" href="indexLogin.aspx"><img src="images/Logo.png" width="300" height="80"/></a>
      <nav class="navigation" role="navigation">
        <ul class="primary-nav">
          <li><a href="#intro">Nosotros</a></li>
          <li><a href="#services">Servicios</a></li>
          <li><a href="SeleccionServicio.aspx">Tomar Hora</a></li>
          <li class="nav-item"><a class="nav-link" href="#contact">Contacto</a></li>
          <li><a href="SituacionEconomica.aspx">Situacion Socio Economica</a></li>
          <li><a href="LoginClose.aspx">Cerrar Sesion</a></li>
        </ul>
      </nav>
      <a href="#" class="nav-toggle">Menu<span></span></a> </div>
      <asp:Label ID="lblWelcome" runat="server" Text=""></asp:Label>
  </header>
  <!-- banner text -->
  <div class="container">
    <div class="col-md-10 col-md-offset-1">
      <div class="banner-text text-center">
        <h1> <asp:Label ID="lblCredenciales" runat="server" Text=""></asp:Label>  </h1>
          <br />
          <br />
        <h1>Bienvenido <asp:Label ID="lblUsernameWelcome" runat="server" Text=""></asp:Label></h1>
        <p>Somos una institución de salud que entrega a sus pacientes la confianza y el profesionalismo de su personal en la resolución de los problemas bucales con la calidad, eficiencia y eficacia que ellos merecen.</p>
      <!-- banner text --> 
    </div>
  </div>
</section>
<!-- header section --> 
<!-- intro section -->
<section id="intro" class="section intro">
  <div class="container">
    <div class="col-md-8 col-md-offset-2 text-center">
      <h3>Tenemos lo que tu necesitas!</h3>
      <p>Como profesionales de la salud, nuestro objetivo siempre ha sido mejorar la calidad de vida de nuestros pacientes, y no existe un mejor premio para nosotros que un paciente satisfecho y feliz de haber recibido nuestra ayuda profesional y humana</p>
    </div>
  </div>
</section>
<!-- intro section --> 
<!-- services section -->
<section id="services" class="works section no-padding">
  <div class="container-fluid">
    <div class="row no-gutter">
      <div class="col-lg-3 col-md-6 col-sm-6 work"> <a href="images/work-1.jpg" class="work-box"> <img src="images/work-1.jpg" alt="">
        <div class="overlay">
          <div class="overlay-caption">
            <h5>Ortodoncia</h5>
            <p>Ortodoncia es la especialidad dedicada al estudio, prevención, diagnóstico y tratamiento de anomalías de forma, posición y función entre huesos y dientes.</p>
          </div>
        </div>
        <!-- overlay --> 
        </a> </div>
      <div class="col-lg-3 col-md-6 col-sm-6 work"> <a href="images/work-2.jpg" class="work-box"> <img src="images/work-2.jpg" alt="">
        <div class="overlay">
          <div class="overlay-caption">
            <h5>Estética Dental</h5>
            <p>Ofrecemos múltiples tecnologías utilizadas para lograr la estética dental deseada por nuestros pacientes ( Blanqueamiento, carillas de porcelana, etc ).</p>
          </div>
        </div>
        <!-- overlay --> 
        </a> </div>
      <div class="col-lg-3 col-md-6 col-sm-6 work"> <a href="images/work-3.jpg" class="work-box"> <img src="images/work-3.jpg" alt="">
        <div class="overlay">
          <div class="overlay-caption">
            <h5>Limpieza Dental</h5>
            <p>La limpieza dental corresponde a un procedimiento común, donde se realiza higienización de la parte visible del diente.</p>
          </div>
        </div>
        <!-- overlay --> 
        </a> </div>
      <div class="col-lg-3 col-md-6 col-sm-6 work"> <a href="images/work-4.jpg" class="work-box"> <img src="images/work-4.jpg" alt="">
        <div class="overlay">
          <div class="overlay-caption">
            <h5>Sedación Conciente</h5>
            <p>Para mayor tranquilidad del paciente, se utilizan medicamentos que producen diferentes grados de adormecimiento y tranquilidad, permitiendo que el tratamiento odontológico se pueda realizar sin malestar, tensión o trauma psicológico.</p>
          </div>
        </div>
        <!-- overlay --> 
        </a> </div>
      <div class="col-lg-3 col-md-6 col-sm-6 work"> <a href="images/work-5.jpg" class="work-box"> <img src="images/work-5.jpg" alt="">
        <div class="overlay">
          <div class="overlay-caption">
            <h5>Estética Dental</h5>
            <p>Ofrecemos múltiples tecnologías utilizadas para lograr la estética dental deseada por nuestros pacientes ( Blanqueamiento, carillas de porcelana, etc ).</p>
          </div>
        </div>
        <!-- overlay --> 
        </a> </div>
      <div class="col-lg-3 col-md-6 col-sm-6 work"> <a href="images/work-6.jpg" class="work-box"> <img src="images/work-6.jpg" alt="">
        <div class="overlay">
          <div class="overlay-caption">
            <h5>Odontopediatría</h5>
            <p>La Odontopediatría es la especialidad odontólogica que se dedica a la atención de Niños. Las técnicas preventivas ayudarán a que el niño crezca sin caries.</p>
          </div>
        </div>
        <!-- overlay --> 
        </a> </div>
      <div class="col-lg-3 col-md-6 col-sm-6 work"> <a href="images/work-7.jpg" class="work-box"> <img src="images/work-7.jpg" alt="">
        <div class="overlay">
          <div class="overlay-caption">
            <h5>Radiografías</h5>
            <p>Contamos con los equipos necesarios para tomar radiografías dentales, que son indispensables para complementar el diagnóstico de nuestros pacientes.</p>
          </div>
        </div>
        <!-- overlay --> 
        </a> </div>
      <div class="col-lg-3 col-md-6 col-sm-6 work"> <a href="images/work-8.jpg" class="work-box"> <img src="images/work-8.jpg" alt="">
        <div class="overlay">
          <div class="overlay-caption">
            <h5>Rehabilitación Oral</h5>
            <p>La Rehabilitación Oral es la especialidad encargada de devolver la estética y función oral cuando se han perdido las piezas dentales.</p>
          </div>
        </div>
        <!-- overlay --> 
        </a> </div>
    </div>
  </div>
</section>
<!-- service section --> 
<!-- our team section -->
<section id="teams" class="section teams">
  <div class="container">
    <div class="row">
     <div class="col-md-3 col-sm-6">
      </div>
      <div class="col-md-3 col-sm-6">
        <div class="person"> <img src="images/Luis Jara.jpg" alt="" class="img-responsive">
          <div class="person-content">
            <h4>Luis Jara</h4>
            <h5 class="role">Odontologo</h5>
            <p>Profesional titulado de Odontologia de la Pontifice Universidad Catolica de Chile</p>
          </div>
          <ul class="social-icons clearfix">
            <li><a href="#" class=""><span class="fa fa-facebook"></span></a></li>
            <li><a href="#" class=""><span class="fa fa-twitter"></span></a></li>
            <li><a href="#" class=""><span class="fa fa-linkedin"></span></a></li>
            <li><a href="#" class=""><span class="fa fa-google-plus"></span></a></li>
            <li><a href="#" class=""><span class="fa fa-dribbble"></span></a></li>
          </ul>
        </div>
      </div>
      <div class="col-md-3 col-sm-6">
        <div class="person"> <img src="images/Marco Medina.jpg" alt="" class="img-responsive">
          <div class="person-content">
            <h4>Marco Medina</h4>
            <h5 class="role">Odontologo</h5>
            <p>Profesional titulado de Odontologia de la Pontifice Universidad Catolica de Chile</p>
          </div>
          <ul class="social-icons clearfix">
            <li><a href="#" class=""><span class="fa fa-facebook"></span></a></li>
            <li><a href="#" class=""><span class="fa fa-twitter"></span></a></li>
            <li><a href="#" class=""><span class="fa fa-linkedin"></span></a></li>
            <li><a href="#" class=""><span class="fa fa-google-plus"></span></a></li>
            <li><a href="#" class=""><span class="fa fa-dribbble"></span></a></li>
          </ul>
        </div>
      </div>
    </div>
  </div>
</section>
<!-- our team section --> 
<!-- Testimonials section -->
<section id="testimonials" class="section testimonials no-padding">
  <div class="container-fluid">
    <div class="row no-gutter">
      <div class="flexslider">
        <ul class="slides">
          <li>
            <div class="col-md-12">
              <blockquote>
                <h1>"Excelente iniciativa para aquellas personas que no tenemos los recursos necesarios para tener una buena atención y salud bucal" </h1>
                <p>Brayan Méndez Fuenzalida - Santiago, Chile</p>
              </blockquote>
            </div>
          </li>
          <li>
            <div class="col-md-12">
              <blockquote>
                <h1>"No dudaría ni un segundo en recomendar a la clínica Ortodoncia Linda Sonrisa a cualquiera que necesite frenillos.
                    Sus predicciones sobre mi evolución fueron completamente acertadas y son extremadamente profesionales y acogedores. " </h1>
                <p>Sergio Orellana Rey - Maipú, Chile</p>
              </blockquote>
            </div>
          </li>
          <li>
            <div class="col-md-12">
              <blockquote>
                <h1>"El corazón debe estar puesto en nuestros actos por mas pequeños que estos sean, ellos ponen sus corazones al servicio humano de sus pacientes" </h1>
                <p>Marco Medina Valdivieso - Estacion Central, Chile</p>
              </blockquote>
            </div>
          </li>
          <li>
            <div class="col-md-12">
              <blockquote>
                <h1>"Muy buena odontologica, me atendieron de muy buena manera y sin discriminarme por ser haitiana" </h1>
                <p>Kristy Gabbor - Quilicura, Chile</p>
              </blockquote>
            </div>
          </li>
        </ul>
      </div>
    </div>
  </div>
</section>
<!-- Testimonials section --> 
<!-- contact section -->
<section id="contact" class="section" runat="server">
  <div class="container">
    <div class="row">
      <div class="col-md-8 col-md-offset-2 conForm">
        <h5>Envianos tus comentarios</h5>
        <p>Envianos tus comentarios, estos seran recibidos y considerados de buena manera para asi poder crecer juntos.</p>
                <div id="message"></div>
          <asp:TextBox ID="txtName" runat="server" class="col-xs-12 col-sm-12 col-md-12 col-lg-12" placeholder="Tu nombre..." maxlength="30"></asp:TextBox>
          <asp:TextBox ID="txtEmail" runat="server" class=" col-xs-12 col-sm-12 col-md-12 col-lg-12 noMarr" placeholder="Email..." maxlength="30"></asp:TextBox>
          <asp:TextBox ID="txtMessage" runat="server" TextMode="MultiLine" cols="30" rows="8" class="form-control form-control-lg" MaxLength="255" placeholder="Ingrese su comentario aquí..."></asp:TextBox>
            <asp:Button ID="BtnIngresar" runat="server" Text="Enviar" class="submitBnt" OnClick="BtnIngresar_Click"  />
          <div id="simple-msg"></div>
      </div>
    </div>
  </div>
</section>
<!-- contact section --> 
<section class="section">
  <div class="container-fluid">
      <div id="map"></div>
    <script>
      function initMap() {
          var uluru = { lat: -33.511107, lng:-70.752497};
        var map = new google.maps.Map(document.getElementById('map'), {
          zoom: 15,
          center: uluru
        });
        var marker = new google.maps.Marker({
          position: uluru,
          map: map
        });
      }
    </script>
    <script async defer
    src="https://maps.googleapis.com/maps/api/js?key=AIzaSyAlFEYoggiDC7PX31zg0_OuitgAaTT3c2s&callback=initMap">
    </script>
  </div>
</section>
<!-- Footer section -->
<footer class="footer">
  <div class="footer-top section">
    <div class="container">
      <div class="row">
        <div class="footer-col col-md-6">
          <h5>Ubicación de nuestra Clinica</h5>
          <p>Esquina Blanca #501, Maipú, Region Metropolitana.<br>
            23168407 / 995285476<br>
            lindasonrisawebpage@gmail.cl</p>
          <p>Copyright © Inc. All Rights Reserved.</a></p>
        </div>
        <div class="footer-col col-md-3">
          <h5>Servicios memeros</h5>
          <p>
          <ul>
            <li><a href="#">Odontopediatría</a></li>
            <li><a href="#">Radiografias</a></li>
            <li><a href="#">Rehabilitación Oral</a></li>
            <li><a href="#">Estética Dental</a></li>
            <li><a href="#">Limpieza Dental</a></li>
            <li>Usted es la visita número: <asp:Label ID="lblVisitCounter" runat="server" Text=""></asp:Label></li>
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
