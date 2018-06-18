<%@ Page Title="" Language="C#" MasterPageFile="~/Normal.Master" AutoEventWireup="true" CodeBehind="CrearUsuario.aspx.cs" Inherits="PortafolioNet.View.CrearUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="jumbotron">
        <div class="container">  
          <h1>Crear Usuario</h1>
        </div>
    </div>

    <section class="section">
      <div class="container">
          <div class="col-md-10 mb-5 element-animate">
              <div class="row">
                <div class="col-md-8 form-group">
                  <label for="Rut">Rut (Con dígito verificador):</label>
                    <asp:TextBox class="form-control" ID="txtRut" type="text" runat="server" placeholder="Rut"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Campo requerido" ControlToValidate="txtRut" ForeColor="Red"></asp:RequiredFieldValidator><br />
                    <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="El rut ya existe" ForeColor="Red" ControlToValidate="txtRut" OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator><br />
                    <asp:CustomValidator ID="CustomValidator4" runat="server" ErrorMessage="Ingrese un rut válido" ForeColor="Red" ControlToValidate="txtRut" OnServerValidate="CustomValidator4_ServerValidate"></asp:CustomValidator>
                </div>
              </div>

              <div class="row">
                <div class="col-md-8 form-group">
                  <label for="Snombre">Nombre:</label>
                    <asp:TextBox class="form-control" ID="txtName" type="text" runat="server" placeholder="Nombre"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Campo requerido" ControlToValidate="txtName" ForeColor="Red"></asp:RequiredFieldValidator>
                </div>
              </div>

              <div class="row">
                <div class="col-md-8 form-group">
                  <label for="PApellido">Primer apellido:</label>
                    <asp:TextBox class="form-control" ID="txtFirstLastName" type="text" runat="server" placeholder="Primer Apellido"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Campo requerido" ControlToValidate="txtFirstLastName" ForeColor="Red"></asp:RequiredFieldValidator>
                </div>
              </div>

              <div class="row">
                <div class="col-md-8 form-group">
                  <label for="SApellido">Segundo apellido:</label>
                    <asp:TextBox class="form-control" ID="txtSecondLastName" type="text" runat="server" placeholder="Segundo apellido"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Campo requerido" ControlToValidate="txtSecondLastName" ForeColor="Red"></asp:RequiredFieldValidator>
                </div>
              </div>

              <div class="row">
                <div class="col-md-8 form-group">
                  <label for="Username">Elija un nombre de usuario para iniciar sesión en nuestro portal:</label>
                    <asp:TextBox class="form-control" ID="txtUsername" type="text" runat="server" placeholder="Nombre de usuario"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Campo requerido" ControlToValidate="txtUsername" ForeColor="Red"></asp:RequiredFieldValidator>
                    <br /><asp:CustomValidator ID="CustomValidator2" runat="server" ErrorMessage="El usuario ya existe" ForeColor="Red" ControlToValidate="txtUsername" OnServerValidate="CustomValidator2_ServerValidate"></asp:CustomValidator>
                </div>
              </div>

              <div class="row">
                <div class="col-md-8 form-group">
                  <label for="Password">Contraseña:</label>
                    <asp:TextBox class="form-control" ID="txtPassword" type="password" runat="server" placeholder="Contraseña"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Campo requerido" ControlToValidate="txtPassword" ForeColor="Red"></asp:RequiredFieldValidator>
                </div>
              </div>

              <div class="row">
                <div class="col-md-8 form-group">
                  <label for="PasswordConfirm">Confirmar contraseña:</label>
                    <asp:TextBox class="form-control" ID="txtPasswordConfirm" type="password" runat="server" placeholder="Confirmar contraseña"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="Campo requerido" ControlToValidate="txtPasswordConfirm" ForeColor="Red"></asp:RequiredFieldValidator><br />
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Las contraseñas deben coincidir" ForeColor="Red" ControlToCompare="txtPassword" ControlToValidate="txtPasswordConfirm"></asp:CompareValidator>
                </div>
              </div>

              <div class="row">
                <div class="col-md-8 form-group">
                  <label for="Pnombre">Direccion:</label>
                    <asp:TextBox class="form-control" ID="txtAddress" type="text" runat="server" placeholder="Direccion"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ErrorMessage="Campo requerido" ControlToValidate="txtAddress" ForeColor="Red"></asp:RequiredFieldValidator>
                </div>
              </div>

              <div class="row">
                <div class="col-md-8 form-group">
                  <label for="Comuna" class="col-lg-10 control-label">Comuna: </label>
                    <div class="col-lg-16">
                        <asp:DropDownList class="form-control" ID="ddlCommune" runat="server">
                             <asp:ListItem Value="0">Alhue</asp:ListItem>
                             <asp:ListItem Value="1">Buin</asp:ListItem>
                             <asp:ListItem Value="2">Calera De Tango</asp:ListItem>
                             <asp:ListItem Value="3">Cerrillos</asp:ListItem>
                             <asp:ListItem Value="25">Maipú</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>
                </div>

              <div class="row">
                <div class="col-md-8 form-group">
                  <label for="Género" class="col-lg-10 control-label">Género: </label>
                    <div class="col-lg-16">
                        <asp:DropDownList class="form-control" ID="ddlGender" runat="server">
                             <asp:ListItem Value="M">Masculino</asp:ListItem>
                             <asp:ListItem Value="F">Femenino</asp:ListItem>
                             <asp:ListItem Value="X">No Binario</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>
                </div>

              <div class="row">
                <div class="col-md-8 form-group">
                  <label for="Pnombre">Teléfono:</label>
                    <asp:TextBox class="form-control" ID="txtPhone" type="number" runat="server" placeholder="Teléfono" MaxLength="9"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ErrorMessage="Campo requerido" ControlToValidate="txtPhone" ForeColor="Red"></asp:RequiredFieldValidator>
                </div>
              </div>

              <div class="row">
                <div class="col-md-8 form-group">
                  <label for="email">Email:</label>
                <asp:TextBox class="form-control" ID="txtEmail" type="email" runat="server" placeholder="Ejemplo asd@gmail.com"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ErrorMessage="Campo requerido" ControlToValidate="txtEmail" ForeColor="Red"></asp:RequiredFieldValidator>
                    <br /><asp:CustomValidator ID="CustomValidator3" runat="server" ErrorMessage="El email ingresado ya se encuentra registrado" ForeColor="Red" ControlToValidate="txtEmail" OnServerValidate="CustomValidator3_ServerValidate"></asp:CustomValidator>
                </div>
              </div>
              <div class="row">
                <div class="col-md-8 form-group">
                  <label for="fechanacimiento">Fecha de Nacimiento:</label>
                <asp:TextBox class="form-control" ID="txtFechaNacimiento" type="date" runat="server" placeholder="Ingresa tu fecha de nacimiento"></asp:TextBox>          
                <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ErrorMessage="Campo requerido" ControlToValidate="txtFechaNacimiento" ForeColor="Red"></asp:RequiredFieldValidator>
                </div>
              </div>
              <div class="row">
                <div class="col-md-8 form-group">
                  <label for="preguntasecreta" class="col-lg-10 control-label">Pregunta Secreta: </label>
                    <div class="col-lg-16">
                        <asp:DropDownList class="form-control" ID="ddlSecretQuestion" runat="server">
                             <asp:ListItem Value="0">¿Cual es el nombre de tu primera mascota?</asp:ListItem>
                             <asp:ListItem Value="1">¿Cuál fue el primer colegio donde estudiaste?</asp:ListItem>
                             <asp:ListItem Value="2">Nombre de la primera empresa donde trabajaste.</asp:ListItem>
                             <asp:ListItem Value="3">¿En qué lugar nació tu madre?</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>
                </div>

              <div class="row">
                <div class="col-md-8 form-group">
                  <label for="respuestasecreta">Respuesta Secreta:</label>
                <asp:TextBox class="form-control" ID="txtRespuestaSecreta" type="text" runat="server" placeholder="Ingrese su respuesta secreta"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ErrorMessage="Campo requerido" ControlToValidate="txtRespuestaSecreta" ForeColor="Red"></asp:RequiredFieldValidator>
                </div>
              </div>
                <div class="row">
                    <div class="col-md-3 form-group">
                        <asp:Button ID="btnConfirmar" runat="server" Text="Confirmar" class="btn btn-primary btn-lg btn-block" OnClick="btnConfirmar_Click"   />
                    </div>
                    <div class="col-md-3 form-group">
                        <asp:Button ID="btnVolver" runat="server" Text="Volver" class="btn btn-primary btn-lg btn-block" OnClick="btnVolver_Click"   />
                    </div>
                </div>
              </div>              
          </div>
    </section>

    <script src="Estilos/js/jquery-3.2.1.min.js"></script>
    <script src="Estilos/js/popper.min.js"></script>
    <script src="Estilos/js/bootstrap.min.js"></script>
    <script src="Estilos/js/owl.carousel.min.js"></script>
    <script src="Estilos/js/bootstrap-datepicker.js"></script>
    <script src="Estilos/js/jquery.timepicker.min.js"></script>
    <script src="Estilos/js/jquery.waypoints.min.js"></script>
    <script src="Estilos/js/main.js"></script>
</asp:Content>
