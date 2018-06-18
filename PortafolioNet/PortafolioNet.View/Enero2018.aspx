<%@ Page Title="" Language="C#" MasterPageFile="~/Logeado.Master" AutoEventWireup="true" CodeBehind="Enero2018.aspx.cs" Inherits="PortafolioNet.View.Enero2018" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="jumbotron">
        <div class="container">  
          <h1>Toma de Hora</h1>
        </div>
    </div>

    <section class="section">
      <div class="container">
          <div class="col-md-10 mb-2 element-animate">
                <div class="row">
                    <div class="col-md-4 form-group">                  
                    </div>
                    <div class="col-md-1 form-group">
                        <a class="btn btn-secondary" href="Agosto.aspx" role="button"><</a>
                    </div>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <div class="col-md-3 form-group">
                        <h2> Enero 2018 </h2>                   
                    </div>
                    <div class="col-md-2 form-group">
                        <a class="btn btn-secondary" href="Junio.aspx" role="button">></a>
                    </div>
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
            <td><asp:Button ID="Button1" runat="server" Text="1" class="btn btn-danger btn-lg btn-block" Enabled="false" OnClick="Button_Click"/></td>
            <td><asp:Button ID="Button2" runat="server" Text="2" class="btn btn-primary btn-lg btn-block" Enabled="false" OnClick="Button_Click"/></td>
            <td><asp:Button ID="Button3" runat="server" Text="3" class="btn btn-primary btn-lg btn-block" Enabled="false" OnClick="Button_Click"/></td>
            <td><asp:Button ID="Button4" runat="server" Text="4" class="btn btn-primary btn-lg btn-block" Enabled="false" OnClick="Button_Click"/></td>
            <td><asp:Button ID="Button5" runat="server" Text="5" class="btn btn-primary btn-lg btn-block" Enabled="false" OnClick="Button_Click"/></td>
            <td><asp:Button ID="Button6" runat="server" Text="6" class="btn btn-primary btn-lg btn-block" Enabled="false" OnClick="Button_Click"/></td>
            <td><asp:Button ID="Button7" runat="server" Text="7" class="btn btn-primary btn-lg btn-block disabled" Enabled="false" OnClick="Button_Click"/></td>
          </tr>
          <tr>
            <td><asp:Button ID="Button8" runat="server" Text="8" class="btn btn-primary btn-lg btn-block" Enabled="false" OnClick="Button_Click"/></td>
            <td><asp:Button ID="Button9" runat="server" Text="9" class="btn btn-primary btn-lg btn-block" Enabled="false" OnClick="Button_Click"/></td>
            <td><asp:Button ID="Button10" runat="server" Text="10" class="btn btn-primary btn-lg btn-block" Enabled="false" OnClick="Button_Click"/></td>
            <td><asp:Button ID="Button11" runat="server" Text="11" class="btn btn-primary btn-lg btn-block" Enabled="false" OnClick="Button_Click"/></td>
            <td><asp:Button ID="Button12" runat="server" Text="12" class="btn btn-primary btn-lg btn-block" Enabled="false" OnClick="Button_Click"/></td>
            <td><asp:Button ID="Button13" runat="server" Text="13" class="btn btn-primary btn-lg btn-block" Enabled="false" OnClick="Button_Click"/></td>
            <td><asp:Button ID="Button14" runat="server" Text="14" class="btn btn-primary btn-lg btn-block disabled" Enabled="false" OnClick="Button_Click"/></td>
          </tr>
          <tr>
            <td><asp:Button ID="Button15" runat="server" Text="15" class="btn btn-primary btn-lg btn-block" Enabled="false" OnClick="Button_Click"/></td>
            <td><asp:Button ID="Button16" runat="server" Text="16" class="btn btn-primary btn-lg btn-block" Enabled="false" OnClick="Button_Click"/></td>
            <td><asp:Button ID="Button17" runat="server" Text="17" class="btn btn-primary btn-lg btn-block" Enabled="false" OnClick="Button_Click"/></td>
            <td><asp:Button ID="Button18" runat="server" Text="18" class="btn btn-primary btn-lg btn-block" Enabled="false" OnClick="Button_Click"/></td>
            <td><asp:Button ID="Button19" runat="server" Text="19" class="btn btn-primary btn-lg btn-block" Enabled="false" OnClick="Button_Click"/></td>
            <td><asp:Button ID="Button20" runat="server" Text="20" class="btn btn-primary btn-lg btn-block" Enabled="false" OnClick="Button_Click"/></td>
            <td><asp:Button ID="Button21" runat="server" Text="21" class="btn btn-primary btn-lg btn-block disabled" Enabled="false" OnClick="Button_Click"/></td>
          </tr>
          <tr>
            <td><asp:Button ID="Button22" runat="server" Text="22" class="btn btn-primary btn-lg btn-block" Enabled="false" OnClick="Button_Click"/></td>
            <td><asp:Button ID="Button23" runat="server" Text="23" class="btn btn-primary btn-lg btn-block" Enabled="false" OnClick="Button_Click"/></td>
            <td><asp:Button ID="Button24" runat="server" Text="24" class="btn btn-primary btn-lg btn-block" Enabled="false" OnClick="Button_Click"/></td>
            <td><asp:Button ID="Button25" runat="server" Text="25" class="btn btn-primary btn-lg btn-block" Enabled="false" OnClick="Button_Click"/></td>
            <td><asp:Button ID="Button26" runat="server" Text="26" class="btn btn-primary btn-lg btn-block" Enabled="false" OnClick="Button_Click"/></td>
            <td><asp:Button ID="Button27" runat="server" Text="27" class="btn btn-primary btn-lg btn-block" Enabled="false" OnClick="Button_Click"/></td>
            <td><asp:Button ID="Button28" runat="server" Text="28" class="btn btn-primary btn-lg btn-block disabled" Enabled="false" OnClick="Button_Click"/></td>
          </tr>
          <tr>
            <td><asp:Button ID="Button29" runat="server" Text="29" class="btn btn-primary btn-lg btn-block" Enabled="false" OnClick="Button_Click"/></td>
            <td><asp:Button ID="Button30" runat="server" Text="30" class="btn btn-primary btn-lg btn-block" Enabled="false" OnClick="Button_Click"/></td>
            <td><asp:Button ID="Button31" runat="server" Text="31" class="btn btn-primary btn-lg btn-block" Enabled="false" OnClick="Button_Click"/></td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
          </tr>
        </tbody>
      </table>
          </div> 
       </div>    
    </section>
</asp:Content>
