<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AjoutEquipe.aspx.cs" Inherits="TP2.AjoutEquipe" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblNom" runat="server" Text="Nom :"></asp:Label>
            <asp:TextBox ID="txtNom" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="reqValidNom" runat="server" ControlToValidate="txtNom" ErrorMessage="Nom requis"></asp:RequiredFieldValidator>
            <br/>
            <asp:Label ID="lblDescription" runat="server" Text="Description :"></asp:Label>
            <asp:TextBox ID="txtDesc" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="reqValidDesc" runat="server" ControlToValidate="txtDesc" ErrorMessage="Description requise"></asp:RequiredFieldValidator>
            <br/>
        </div>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Ajouter" />
    </form>
</body>
</html>
