<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Estadisticas.aspx.cs" Inherits="PortafolioNet.View.Estadisticas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblDentistWithMoreHours" runat="server" Text=""></asp:Label> <br />
            <asp:Label ID="lblMostSolicitedService" runat="server" Text=""></asp:Label> <br />
            <asp:Label ID="lblClientWithMoreHours" runat="server" Text=""></asp:Label> <br />
            <asp:Label ID="lblMostSolicitedDay" runat="server" Text=""></asp:Label> <br />
            <asp:Label ID="lblLessSolicitedService" runat="server" Text=""></asp:Label> <br />
            <asp:Label ID="lblDentistWithLessHours" runat="server" Text=""></asp:Label> <br />
            <asp:Label ID="lblMostClientCommune" runat="server" Text=""></asp:Label> <br />
            <asp:Label ID="lblClientRegisteredQuantity" runat="server" Text=""></asp:Label> <br />
            <asp:Label ID="lblAverageClientAge" runat="server" Text=""></asp:Label> <br />
            <asp:Label ID="lblMostOlderClient" runat="server" Text=""></asp:Label> <br />
            <asp:Label ID="lblMostYoungerClient" runat="server" Text=""></asp:Label> <br />
            <asp:Button ID="btnGeneratePDF" runat="server" Text="Generar PDF" />
            <asp:Button ID="btnClose" runat="server" Text="Volver" />
        </div>
    </form>
</body>
</html>
