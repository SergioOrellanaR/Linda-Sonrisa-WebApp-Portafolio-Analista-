<%@ Page Title="" Language="C#" MasterPageFile="~/Logeado.Master" AutoEventWireup="true" CodeBehind="CalendarMonths.aspx.cs" Inherits="PortafolioNet.View.CalendarMonths" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Estilos/css/bootstrap.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="jumbotron">
        <div class="container">  
            <div class="media">
              <div class="media-body">
                <h1 class="mt-0 mb-1">El servicio <asp:Label ID="lblService" runat="server" Text=""></asp:Label> es brindado por: <asp:Label ID="Label2" runat="server" Text=""></asp:Label> </h1>
              </div>
                <asp:Image ID="Image2" runat="server" ImageUrl="~/images/team-3.jpg" Width ="150px" Height="150px"/>
            </div>
        </div>
    </div>


   <section class="section">
      <div class="container">
          <div class="col-md-10 mb-2 element-animate">
                <div class="row">
                    <div class="col-md-4 form-group">                  
                    </div>
                    <div class="col-md-1 form-group">
                        <asp:Button ID="btnBack" runat="server" Text="<" class="btn btn-secondary" OnClick="btnBack_Click" />
                    </div>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <div class="col-md-2 form-group">   
                        <h2><asp:Label ID="lblMonth" runat="server" Text=""></asp:Label></h2>                 
                    </div>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <div class="col-md-2 form-group">
                        <h2><asp:Label ID="lblYear" runat="server" Text=""></asp:Label> </h2>                   
                    </div>
                    <div class="col-md-2 form-group">
                        <asp:Button ID="btnAdvance" runat="server" Text=">" class="btn btn-secondary" OnClick="btnAdvance_Click" />                    </div>
                </div>
              </div>              
          </div>
    </section>

    <section class="section">
      <div class="container">
         <div class="row">                 
      <table class="table table-bordered">
        <thead>
          <tr>
            <th>Lunes</th>
            <th>Martes</th>
            <th>Miercoles</th>
            <th>Jueves</th>
            <th>Viernes</th>
            <th>Sabado</th>
            <th>Domingo</th>
          </tr>
        </thead>
        <tbody>
          <tr>
            <td><asp:Button ID="Button1" runat="server" Text="1" CssClass="btn btn-danger btn-lg btn-block" Enabled="false" OnClick="Button_Click"/></td>
            <td><asp:Button ID="Button2" runat="server" Text="2" CssClass="btn btn-danger btn-lg btn-block" Enabled="false" OnClick="Button_Click"/></td>
            <td><asp:Button ID="Button3" runat="server" Text="3" CssClass="btn btn-danger btn-lg btn-block" Enabled="false" OnClick="Button_Click"/></td>
            <td><asp:Button ID="Button4" runat="server" Text="4" CssClass="btn btn-danger btn-lg btn-block" Enabled="false" OnClick="Button_Click"/></td>
            <td><asp:Button ID="Button5" runat="server" Text="5" CssClass="btn btn-danger btn-lg btn-block" Enabled="false" OnClick="Button_Click"/></td>
            <td><asp:Button ID="Button6" runat="server" Text="6" CssClass="btn btn-danger btn-lg btn-block" Enabled="false" OnClick="Button_Click"/></td>
            <td><asp:Button ID="Button7" runat="server" Text="7" CssClass="btn btn-danger btn-lg btn-block" Enabled="false" OnClick="Button_Click"/></td>
          </tr>
          <tr>
            <td><asp:Button ID="Button8" runat="server" Text="8"   CssClass="btn btn-danger btn-lg btn-block" Enabled="false" OnClick="Button_Click"/></td>
            <td><asp:Button ID="Button9" runat="server" Text="9"   CssClass="btn btn-danger btn-lg btn-block" Enabled="false" OnClick="Button_Click"/></td>
            <td><asp:Button ID="Button10" runat="server" Text="10" CssClass="btn btn-danger btn-lg btn-block" Enabled="false" OnClick="Button_Click"/></td>
            <td><asp:Button ID="Button11" runat="server" Text="11" CssClass="btn btn-danger btn-lg btn-block" Enabled="false" OnClick="Button_Click"/></td>
            <td><asp:Button ID="Button12" runat="server" Text="12" CssClass="btn btn-danger btn-lg btn-block" Enabled="false" OnClick="Button_Click"/></td>
            <td><asp:Button ID="Button13" runat="server" Text="13" CssClass="btn btn-danger btn-lg btn-block" Enabled="false" OnClick="Button_Click"/></td>
            <td><asp:Button ID="Button14" runat="server" Text="14" CssClass="btn btn-danger btn-lg btn-block" Enabled="false" OnClick="Button_Click"/></td>
          </tr>
          <tr>
            <td><asp:Button ID="Button15" runat="server" Text="15" CssClass="btn btn-danger btn-lg btn-block" Enabled="false" OnClick="Button_Click"/></td>
            <td><asp:Button ID="Button16" runat="server" Text="16" CssClass="btn btn-danger btn-lg btn-block" Enabled="false" OnClick="Button_Click"/></td>
            <td><asp:Button ID="Button17" runat="server" Text="17" CssClass="btn btn-danger btn-lg btn-block" Enabled="false" OnClick="Button_Click"/></td>
            <td><asp:Button ID="Button18" runat="server" Text="18" CssClass="btn btn-danger btn-lg btn-block" Enabled="false" OnClick="Button_Click"/></td>
            <td><asp:Button ID="Button19" runat="server" Text="19" CssClass="btn btn-danger btn-lg btn-block" Enabled="false" OnClick="Button_Click"/></td>
            <td><asp:Button ID="Button20" runat="server" Text="20" CssClass="btn btn-danger btn-lg btn-block" Enabled="false" OnClick="Button_Click"/></td>
            <td><asp:Button ID="Button21" runat="server" Text="21" CssClass="btn btn-danger btn-lg btn-block" Enabled="false" OnClick="Button_Click"/></td>
          </tr>
          <tr>
            <td><asp:Button ID="Button22" runat="server" Text="22" CssClass="btn btn-danger btn-lg btn-block" Enabled="false" OnClick="Button_Click"/></td>
            <td><asp:Button ID="Button23" runat="server" Text="23" CssClass="btn btn-danger btn-lg btn-block" Enabled="false" OnClick="Button_Click"/></td>
            <td><asp:Button ID="Button24" runat="server" Text="24" CssClass="btn btn-danger btn-lg btn-block" Enabled="false" OnClick="Button_Click"/></td>
            <td><asp:Button ID="Button25" runat="server" Text="25" CssClass="btn btn-danger btn-lg btn-block" Enabled="false" OnClick="Button_Click"/></td>
            <td><asp:Button ID="Button26" runat="server" Text="26" CssClass="btn btn-danger btn-lg btn-block" Enabled="false" OnClick="Button_Click"/></td>
            <td><asp:Button ID="Button27" runat="server" Text="27" CssClass="btn btn-danger btn-lg btn-block" Enabled="false" OnClick="Button_Click"/></td>
            <td><asp:Button ID="Button28" runat="server" Text="28" CssClass="btn btn-danger btn-lg btn-block" Enabled="false" OnClick="Button_Click"/></td>
          </tr>
          <tr>
            <td><asp:Button ID="Button29" runat="server" Text="29" CssClass="btn btn-danger btn-lg btn-block" Enabled="false" OnClick="Button_Click"/></td>
            <td><asp:Button ID="Button30" runat="server" Text="30" CssClass="btn btn-danger btn-lg btn-block" Enabled="false" OnClick="Button_Click"/></td>
            <td><asp:Button ID="Button31" runat="server" Text="31" CssClass="btn btn-danger btn-lg btn-block" Enabled="false" OnClick="Button_Click"/></td>
            <td><asp:Button ID="Button32" runat="server" Text="31" CssClass="btn btn-danger btn-lg btn-block" Enabled="false" OnClick="Button_Click"/></td>
            <td><asp:Button ID="Button33" runat="server" Text="31" CssClass="btn btn-danger btn-lg btn-block" Enabled="false" OnClick="Button_Click"/></td>
            <td><asp:Button ID="Button34" runat="server" Text="31" CssClass="btn btn-danger btn-lg btn-block" Enabled="false" OnClick="Button_Click"/></td>
            <td><asp:Button ID="Button35" runat="server" Text="31" CssClass="btn btn-danger btn-lg btn-block" Enabled="false" OnClick="Button_Click"/></td>
          </tr>
          <tr>
            <td><asp:Button ID="Button36" runat="server" Text="31" CssClass="btn btn-danger btn-lg btn-block" Enabled="false" OnClick="Button_Click"/></td>
            <td><asp:Button ID="Button37" runat="server" Text="31" CssClass="btn btn-danger btn-lg btn-block" Enabled="false" OnClick="Button_Click"/></td>
          </tr>
        </tbody>
      </table>
          </div> 
       </div>    
    </section>
</asp:Content>
