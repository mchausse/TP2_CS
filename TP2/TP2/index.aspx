<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="TP2.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Gestion d'équipe | Bienvenue"></asp:Label>
        </div>
        <asp:Label ID="lblCourriel" runat="server" Text="Courriel :"></asp:Label>
        <asp:LoginName ID="courriel" runat="server" />
    </form>
</body>
</html>
