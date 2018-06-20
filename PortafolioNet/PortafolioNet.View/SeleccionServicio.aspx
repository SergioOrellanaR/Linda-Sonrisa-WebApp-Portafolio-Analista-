<%@ Page Title="" Language="C#" MasterPageFile="~/Logeado.Master" AutoEventWireup="true" CodeBehind="SeleccionServicio.aspx.cs" Inherits="PortafolioNet.View.SeleccionServicio" EnableViewState="true"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="jumbotron">
        <div class="container">  
          <h1>Seleccion de Servicio</h1>
        </div>
    </div>

    <section class="section">
      <div class="container">
          <div class="col-md-10 mb-5 element-animate">
              <div class="row">
                <div class="col-md-8 form-group">
                  <label for="servicio" class="col-lg-10 control-label">Seleccione Servicio: </label>
                    <div class="col-lg-10">
                        <asp:DropDownList class="form-control" ID="ddlService" runat="server">
                        </asp:DropDownList>
                    </div>
                </div>
                </div>
                <div class="row">
                    <div class="col-md-2 form-group">
                        <asp:Button ID="btnContinuar" runat="server" Text="Continuar" class="btn btn-primary btn-lg btn-block" OnClick="btnContinuar_Click"   />
                    </div>
                    <div class="col-md-2 form-group">
                        <asp:Button ID="btnVolver" runat="server" Text="Volver" class="btn btn-primary btn-lg btn-block" OnClick="btnVolver_Click"   />
                    </div>
                </div>
              </div>              
          </div>
    </section>
</asp:Content>
