<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Estadisticas.aspx.cs" Inherits="PortafolioNet.View.Estadisticas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Odontologica Linda Sonrisa</title>

    <link href="https://fonts.googleapis.com/css?family=Open+Sans:300, 400, 700" rel="stylesheet"/>

    <link rel="stylesheet" href="Estilos/css/bootstrap.css"/>
    <link rel="stylesheet" href="Estilos/css/animate.css"/>
    <link rel="stylesheet" href="Estilos/css/owl.carousel.min.css"/>
    <link rel="stylesheet" href="Estilos/css/bootstrap-datepicker.css"/>
    <link rel="stylesheet" href="Estilos/css/jquery.timepicker.css"/>

    <link rel="stylesheet" href="Estilos/fonts/ionicons/css/ionicons.min.css"/>
    <link rel="stylesheet" href="Estilos/fonts/fontawesome/css/font-awesome.min.css"/>
    <link rel="stylesheet" href="Estilos/fonts/flaticon/font/flaticon.css"/>


    <!-- Theme Style -->
    <link rel="stylesheet" href="css/style.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <div>
    <div class="jumbotron">
        <div class="container">  
                <div class="row">
                    <div class="col-md-8 form-group">
                        <h1>Reporte estadistico</h1>
                    </div>&nbsp;&nbsp;
                    <div class="col-md-3 form-group">   
                        <img  src="images/Logo.png" width="400" height="80"/>
                    </div>
                </div>
        </div>
    </div>
    <section class="section">
      <div class="container">
        <div class="alert alert-info" role="alert">
          <h4 class="alert-heading">Reporte de las estadisticas registradas en Odontologica Linda Sonrisa</h4>
            <hr>
            <p class="mb-0"><asp:Label ID="lblDentistWithMoreHours" runat="server" Text=""></asp:Label></p>
           </br>
            <p class="mb-0"><asp:Label ID="lblMostSolicitedService" runat="server" Text=""></asp:Label></p>
            </br>
            <p class="mb-0"><asp:Label ID="lblClientWithMoreHours" runat="server" Text=""></asp:Label></p>
            </br>
            <p class="mb-0"><asp:Label ID="lblMostSolicitedDay" runat="server" Text=""></asp:Label></p>
             </br>
            <p class="mb-0"><asp:Label ID="lblLessSolicitedService" runat="server" Text=""></asp:Label></p>  
             </br>
            <p class="mb-0"><asp:Label ID="lblDentistWithLessHours" runat="server" Text=""></asp:Label></p>   
             </br>
            <p class="mb-0"><asp:Label ID="lblMostClientCommune" runat="server" Text=""></asp:Label></p>   
             </br>
            <p class="mb-0"><asp:Label ID="lblClientRegisteredQuantity" runat="server" Text=""></asp:Label></p>   
             </br>
            <p class="mb-0"><asp:Label ID="lblAverageClientAge" runat="server" Text=""></asp:Label></p>     
             </br>
            <p class="mb-0"><asp:Label ID="lblMostOlderClient" runat="server" Text=""></asp:Label></p>  
             </br>
            <p class="mb-0"><asp:Label ID="lblMostYoungerClient" runat="server" Text=""></asp:Label></p> 
            </br>
            <p class="mb-0"><asp:Label ID="lblVisitNumber" runat="server" Text=""></asp:Label></p>
        </div>
      </div>
    </section> 

    <section class="section">
      <div class="container">
            <div class="col-md-8 mb-2 element-animate">
                <div class="row">
                    <div class="col-md-3 form-group">
                        <asp:Button ID="btnGeneratePDF" runat="server" Text="Generar PDF" CssClass="btn btn-primary btn-lg btn-block" OnClick="btnGeneratePDF_Click" />
                    </div>&nbsp;&nbsp;
                    <div class="col-md-3 form-group">   
                        <asp:Button ID="btnClose" runat="server" Text="Volver" CssClass="btn btn-primary btn-lg btn-block" OnClick="btnClose_Click"  />
                    </div>
                </div>
              </div>              
          </div>
    </section>
        </div>

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
