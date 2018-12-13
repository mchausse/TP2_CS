<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AjoutEquipe.aspx.cs" Inherits="TP2.AjoutEquipe" MasterPageFile="~/MasterTP2.Master"%>

<asp:Content Id="sdf" ContentPlaceHolderId="ContentPlaceHolder1" runat="server">
            <asp:Label ID="lblNom" runat="server" Text="Nom :"></asp:Label>
            <asp:TextBox ID="txtNom" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="reqValidNom" runat="server" ControlToValidate="txtNom" ErrorMessage="Nom requis"></asp:RequiredFieldValidator>
            <br/>
            <asp:Label ID="lblDescription" runat="server" Text="Description :"></asp:Label>
            <asp:TextBox ID="txtDesc" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="reqValidDesc" runat="server" ControlToValidate="txtDesc" ErrorMessage="Description requise"></asp:RequiredFieldValidator>
            <br/>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Ajouter" />
</asp:Content>
