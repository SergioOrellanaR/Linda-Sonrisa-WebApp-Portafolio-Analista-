<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginClose.aspx.cs" Inherits="PortafolioNet.View.LoginTest" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
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
    <section class="banner" role="banner">
  <header id="header">
    <div class="header-content clearfix"> <a class="logo" href="Index.aspx">LINDA SONRISA</a>
      <nav class="navigation" role="navigation">
      </nav>
      <a href="#" class="nav-toggle">Menu<span></span></a> </div>
      <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
  </header>
  <!-- banner text -->
  <div class="container">
    <div class="col-md-10 col-md-offset-1">
      <div class="banner-text text-center">
        <h1>Gracias por visitarnos, vuelva pronto: <asp:Label ID="lblName" runat="server" Text=""></asp:Label></h1>
        <p>Lorem ipsum dolor sit ametcursus magna vel scelerisque Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent commodo cursus magna vel scelerisque nisl consectetur et.nisl consectetur et.</p>
            <form id="form1" runat="server">
        <div>
            <br />
            <asp:Button ID="btnBack" runat="server" Text="Volver" OnClick="btnBack_Click" class="btn btn-large"/>
        </div>
    </form>

      </div>
      <!-- banner text --> 
    </div>
  </div>
</section>
</body>
</html>
