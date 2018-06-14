<%@ Page Title="" Language="C#" MasterPageFile="~/Logeado.Master" AutoEventWireup="true" CodeBehind="ElegirHora.aspx.cs" Inherits="PortafolioNet.View.ElegirHora" %>
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
                       <table class="table table-bordered">
                    <thead>
                      <tr>
                        <th>Hora</th>
                      </tr>
                    </thead>
                    <tbody>
                      <tr>
                        <td>8:30 - 9:00</td>
                        <td><asp:Button ID="Button1" runat="server" Text="Solicitar" class="btn btn-primary btn-lg btn-block"/></td>
                      </tr>
                      <tr>
                        <td>9:00 - 9:30</td>
                        <td><asp:Button ID="Button2" runat="server" Text="Solicitar" class="btn btn-primary btn-lg btn-block"/></td>
                      </tr>
                      <tr>
                        <td>9:30 - 10:00</td>
                        <td><asp:Button ID="Button6" runat="server" Text="Solicitar" class="btn btn-primary btn-lg btn-block"/></td>
                      </tr>
                      <tr>
                        <td>10:00 - 10:30</td>
                        <td><asp:Button ID="Button3" runat="server" Text="Solicitar" class="btn btn-primary btn-lg btn-block"/></td>
                      </tr>
                      <tr>
                        <td>10:30 - 11:00</td>
                        <td><asp:Button ID="Button4" runat="server" Text="Solicitar" class="btn btn-primary btn-lg btn-block"/></td>
                      </tr>
                      <tr>
                        <td>11:00 - 11:30</td>
                        <td><asp:Button ID="Button5" runat="server" Text="Solicitar" class="btn btn-primary btn-lg btn-block"/></td>
                      </tr>
                      <tr>
                        <td>11:30 - 12:00</td>
                        <td><asp:Button ID="Button7" runat="server" Text="Solicitar" class="btn btn-primary btn-lg btn-block"/></td>
                      </tr>
                      <tr>
                        <td>12:00 - 12:30</td>
                        <td><asp:Button ID="Button8" runat="server" Text="Solicitar" class="btn btn-primary btn-lg btn-block"/></td>
                      </tr>
                      <tr>
                        <td>12:30 - 13:00</td>
                        <td><asp:Button ID="Button20" runat="server" Text="Solicitar" class="btn btn-primary btn-lg btn-block"/></td>
                      </tr>
                    </tbody>
                  </table>                 
                    </div>

                    <div class="col-md-4 form-group">
                       <table class="table table-bordered">
                    <thead>
                      <tr>
                        <th>Hora</th>
                      </tr>
                    </thead>
                    <tbody>
                      <tr>
                        <td>14:00 - 14:30</td>
                        <td><asp:Button ID="Button21" runat="server" Text="Solicitar" class="btn btn-primary btn-lg btn-block"/></td>
                      </tr>
                      <tr>
                        <td>14:30 - 15:00</td>
                        <td><asp:Button ID="Button22" runat="server" Text="Solicitar" class="btn btn-primary btn-lg btn-block"/></td>
                      </tr>
                      <tr>
                        <td>15:00 - 15:30</td>
                        <td><asp:Button ID="Button9" runat="server" Text="Solicitar" class="btn btn-primary btn-lg btn-block"/></td>
                      </tr>
                      <tr>
                        <td>15:30 - 16:00</td>
                        <td><asp:Button ID="Button10" runat="server" Text="Solicitar" class="btn btn-primary btn-lg btn-block"/></td>
                      </tr>
                      <tr>
                        <td>16:00 - 16:30</td>
                        <td><asp:Button ID="Button11" runat="server" Text="Solicitar" class="btn btn-primary btn-lg btn-block"/></td>
                      </tr>
                      <tr>
                        <td>16:30 - 17:00</td>
                        <td><asp:Button ID="Button12" runat="server" Text="Solicitar" class="btn btn-primary btn-lg btn-block"/></td>
                      </tr>
                      <tr>
                        <td>17:00 - 17:30</td>
                        <td><asp:Button ID="Button13" runat="server" Text="Solicitar" class="btn btn-primary btn-lg btn-block"/></td>
                      </tr>
                      <tr>
                        <td>17:30 - 18:00</td>
                        <td><asp:Button ID="Button14" runat="server" Text="Solicitar" class="btn btn-primary btn-lg btn-block"/></td>
                      </tr>
                    </tbody>
                  </table>     
                    <div class="col-md-12 form-group">
                        <asp:Button ID="btnVolver" runat="server" Text="Volver" class="btn btn-primary btn-lg btn-block"   />
                    </div>                               
                    </div>
                </div>
              </div>              
          </div>
    </section>
</asp:Content>
