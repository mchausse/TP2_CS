<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="TP2.index" MasterPageFile="~/MasterTP2.Master" %>

<asp:Content Id="Inscription" ContentPlaceHolderId="ContentPlaceHolder1" runat="server">
    <asp:Label ID="LblCourriel" runat="server" Text="Courriel :"></asp:Label>
    <asp:TextBox ID="TxtbxCourriel" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="LblMotDePasse" runat="server" Text="Mot de passe :"></asp:Label>
    <asp:TextBox ID="TxtbxMotDePasse" runat="server" TextMode="Password"></asp:TextBox>
    <br />
    <asp:Button ID="BtnInscription" runat="server" Text="Inscription" OnClick="BtnInscription_Click" />
    <asp:Button ID="BtnConnexion" runat="server" Text="Connexion" OnClick="BtnConnexion_Click"/>
</asp:Content>