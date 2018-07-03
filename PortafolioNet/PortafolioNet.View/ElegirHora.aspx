<%@ Page Title="" Language="C#" MasterPageFile="~/Logeado.Master" AutoEventWireup="true" CodeBehind="ElegirHora.aspx.cs" Inherits="PortafolioNet.View.ElegirHora" EnableEventValidation="true" %>
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
                        <td><asp:Button ID="Button08300900" runat="server" Text="Solicitar" CssClass="btn btn-primary btn-lg btn-block" OnClick="Button_Click"/></td>
                      </tr>
                      <tr>
                        <td>9:00 - 9:30</td>
                        <td><asp:Button ID="Button09000930" runat="server" Text="Solicitar" CssClass="btn btn-primary btn-lg btn-block" OnClick="Button_Click"/></td>
                      </tr>
                      <tr>
                        <td>9:30 - 10:00</td>
                        <td><asp:Button ID="Button09301000" runat="server" Text="Solicitar" CssClass="btn btn-primary btn-lg btn-block" OnClick="Button_Click"/></td>
                      </tr>
                      <tr>
                        <td>10:00 - 10:30</td>
                        <td><asp:Button ID="Button10001030" runat="server" Text="Solicitar" CssClass="btn btn-primary btn-lg btn-block" OnClick="Button_Click"/></td>
                      </tr>
                      <tr>
                        <td>10:30 - 11:00</td>
                        <td><asp:Button ID="Button10301100" runat="server" Text="Solicitar" CssClass="btn btn-primary btn-lg btn-block" OnClick="Button_Click"/></td>
                      </tr>
                      <tr>
                        <td>11:00 - 11:30</td>
                        <td><asp:Button ID="Button11001130" runat="server" Text="Solicitar" CssClass="btn btn-primary btn-lg btn-block" OnClick="Button_Click"/></td>
                      </tr>
                      <tr>
                        <td>11:30 - 12:00</td>
                        <td><asp:Button ID="Button11301200" runat="server" Text="Solicitar" CssClass="btn btn-primary btn-lg btn-block" OnClick="Button_Click"/></td>
                      </tr>
                      <tr>
                        <td>12:00 - 12:30</td>
                        <td><asp:Button ID="Button12001230" runat="server" Text="Solicitar" CssClass="btn btn-primary btn-lg btn-block" OnClick="Button_Click"/></td>
                      </tr>
                      <tr>
                        <td>12:30 - 13:00</td>
                        <td><asp:Button ID="Button12301300" runat="server" Text="Solicitar" CssClass="btn btn-primary btn-lg btn-block" OnClick="Button_Click"/></td>
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
                        <td><asp:Button ID="Button14001430" runat="server" Text="Solicitar" CssClass="btn btn-primary btn-lg btn-block" OnClick="Button_Click"/></td>
                      </tr>
                      <tr>
                        <td>14:30 - 15:00</td>
                        <td><asp:Button ID="Button14301500" runat="server" Text="Solicitar" CssClass="btn btn-primary btn-lg btn-block" OnClick="Button_Click"/></td>
                      </tr>
                      <tr>
                        <td>15:00 - 15:30</td>
                        <td><asp:Button ID="Button15001530" runat="server" Text="Solicitar" CssClass="btn btn-primary btn-lg btn-block" OnClick="Button_Click"/></td>
                      </tr>
                      <tr>
                        <td>15:30 - 16:00</td>
                        <td><asp:Button ID="Button15301600" runat="server" Text="Solicitar" CssClass="btn btn-primary btn-lg btn-block" OnClick="Button_Click"/></td>
                      </tr>
                      <tr>
                        <td>16:00 - 16:30</td>
                        <td><asp:Button ID="Button16001630" runat="server" Text="Solicitar" CssClass="btn btn-primary btn-lg btn-block" OnClick="Button_Click"/></td>
                      </tr>
                      <tr>
                        <td>16:30 - 17:00</td>
                        <td><asp:Button ID="Button16301700" runat="server" Text="Solicitar" CssClass="btn btn-primary btn-lg btn-block" OnClick="Button_Click"/></td>
                      </tr>
                      <tr>
                        <td>17:00 - 17:30</td>
                        <td><asp:Button ID="Button17001730" runat="server" Text="Solicitar" CssClass="btn btn-primary btn-lg btn-block" OnClick="Button_Click"/></td>
                      </tr>
                      <tr>
                        <td>17:30 - 18:00</td>
                        <td><asp:Button ID="Button17301800" runat="server" Text="Solicitar" CssClass="btn btn-primary btn-lg btn-block" OnClick="Button_Click"/></td>
                      </tr>
                    </tbody>
                  </table>     
                    <div class="col-md-12 form-group">
                        <asp:Button ID="btnVolver" runat="server" Text="Volver" CssClass="btn btn-primary btn-lg btn-block" OnClick="btnVolver_Click"   />
                    </div>                               
                    </div>
                </div>
              </div>              
          </div>
    </section>
</asp:Content>
