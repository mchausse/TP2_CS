<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProfilEquipe.aspx.cs" Inherits="TP2.ProfilEquipe" MasterPageFile="~/MasterTP2.Master" %>

<asp:Content Id="pro" ContentPlaceHolderId="ContentPlaceHolder1" runat="server">
    <asp:Label ID="titreEquipe" runat="server" Text="Label"></asp:Label><br />
    
    <asp:Label ID="description" runat="server" Text="Description:"></asp:Label>
    
    
    
    <asp:BulletedList ID="ListProgrammeur" runat="server">
        
    </asp:BulletedList><br />
    <asp:Button ID="bn_quitter" runat="server" Height="26px" Text="Retour" OnClick="bn_quitter_Click" />
    <br /><br />
    <asp:Button ID="quitterEquipe" runat="server" Text="Quitter l'équipe" OnClick="quitterEquipe_Click" />
</asp:Content>