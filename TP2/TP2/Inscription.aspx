<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inscription.aspx.cs" Inherits="TP2.Inscription" MasterPageFile="~/MasterTP2.Master" %>


<asp:Content Id="Inscription" ContentPlaceHolderId="ContentPlaceHolder1" runat="server">

    <asp:Label ID="LblTitre" runat="server" Text="Inscription"></asp:Label><br />
    <asp:Label ID="LblNom" runat="server" Text="Nom :"></asp:Label>
    <asp:TextBox ID="TxtbxNom" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="LblCourriel" runat="server" Text="Courriel :"></asp:Label>
    <asp:TextBox ID="TxtbxCourriel" runat="server"></asp:TextBox><br />
    <asp:Label ID="LblMotDePasse" runat="server" Text="Mot de passe : "></asp:Label>
    <asp:TextBox ID="TxtbxMotDePasse" runat="server" TextMode="Password"></asp:TextBox>
    <br />
    <asp:Button ID="BtnCreeProgrammeur" runat="server" Text="Cree" OnClick="BtnCreeProgrammeur_Click" />
    <br />

</asp:Content>

