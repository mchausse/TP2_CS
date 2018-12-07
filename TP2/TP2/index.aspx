<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="TP2.index" MasterPageFile="~/MasterTP2.Master" %>

<asp:Content Id="Inscription" ContentPlaceHolderId="ContentPlaceHolder1" runat="server">
    <asp:Label ID="LblCourriel" runat="server" Text="Courriel :"></asp:Label>
    <asp:TextBox ID="TxtbxCourriel" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TxtbxCourriel" ErrorMessage="Le courriel est obligatoire pour se connecter" ForeColor="Red" ValidationGroup="connexion"></asp:RequiredFieldValidator>
    <br />
    <asp:Label ID="LblMotDePasse" runat="server" Text="Mot de passe :"></asp:Label>
    <asp:TextBox ID="TxtbxMotDePasse" runat="server" TextMode="Password"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TxtbxMotDePasse" ErrorMessage="Le mot de passe est obligatoire pour se connecter" ForeColor="Red" ValidationGroup="connexion"></asp:RequiredFieldValidator>
    <br />
    <asp:Button ID="BtnInscription" runat="server" Text="Inscription" OnClick="BtnInscription_Click" />
    <asp:Button ID="BtnConnexion" runat="server" Text="Connexion" OnClick="BtnConnexion_Click" ValidationGroup="connexion"/>
</asp:Content>