<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Equipes.aspx.cs" Inherits="TP2.Equipes" MasterPageFile="~/MasterTP2.Master"%>

<asp:Content Id="Equipes" ContentPlaceHolderId="ContentPlaceHolder1" runat="server">
    <asp:Label ID="LblProgrammeur" runat="server" Text="<nom du programmeur>"></asp:Label><br />
    <asp:Label ID="LblMembre" runat="server" Text=""></asp:Label>
    <asp:Button ID="Voir_equipe" runat="server" OnClick="Voir_equipe_Click" style="margin-top: 11px" Text="Voir Équipe" />
    <br /><br />
    <asp:Label ID="Label3" runat="server" Text="Liste des équipes :"></asp:Label><br />
    <asp:Button ID="btnSearch" runat="server" Text="Rechercher" OnClick="btnSearch_Click" />
    <asp:TextBox ID="txtSearch" runat="server"></asp:TextBox>
    <asp:BulletedList ID="ListEquipes" runat="server">
    </asp:BulletedList>
    <asp:Label ID="LblRejoindreEquipe" runat="server" Text="Rejoindre une équipe : "></asp:Label>
    <asp:TextBox ID="TxtbxEquipe" runat="server"></asp:TextBox>
    <asp:Button ID="BtnRejoindreEquipe" runat="server" Text="Rejoindre!" OnClick="BtnRejoindreEquipe_Click" /><br />
    <asp:Label ID="LblErreurEquipe" runat="server" ForeColor="Red"></asp:Label><br /> 
    <asp:Button ID="btnAjout" runat="server" Text="Ajouter une équipe" OnClick="btnAjout_Click" /><br />
</asp:Content>
