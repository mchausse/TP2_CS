<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inscription.aspx.cs" Inherits="TP2.Inscription" MasterPageFile="~/MasterTP2.Master" %>


<asp:Content Id="Inscription" ContentPlaceHolderId="ContentPlaceHolder1" runat="server">

    <asp:Label ID="LblTitre" runat="server" Text="Inscription"></asp:Label><br />
    <asp:Label ID="LblNom" runat="server" Text="Nom :"></asp:Label>
    <asp:TextBox ID="TxtbxNom" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TxtbxCourriel" ErrorMessage="Le nom du programmeur est obligatoire" ForeColor="#F00000" ValidationGroup="inscription" ></asp:RequiredFieldValidator>
    <br />
    <asp:Label ID="LblCourriel" runat="server" Text="Courriel :"></asp:Label>
    <asp:TextBox ID="TxtbxCourriel" runat="server" ValidationGroup="inscription"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TxtbxCourriel" ErrorMessage="Le courriel est obligatoire" ForeColor="Red" ValidationGroup="inscription"></asp:RequiredFieldValidator>
    <br />
    <asp:Label ID="LblMotDePasse" runat="server" Text="Mot de passe : "></asp:Label>
    <asp:TextBox ID="TxtbxMotDePasse" runat="server" TextMode="Password" ValidationGroup="inscription"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TxtbxMotDePasse" ErrorMessage="Le mot de passe est obligatoire" ForeColor="Red" ValidationGroup="inscription"></asp:RequiredFieldValidator>
    <br />
    <asp:Label ID="LblMotDePasse2" runat="server" Text="Mot de passe :"></asp:Label>
    <asp:TextBox ID="TxtbxMotDePasse2" runat="server" ValidationGroup="inscription"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TxtbxMotDePasse2" ErrorMessage="La validation du mot de passe est obligatoire" ForeColor="Red" ValidationGroup="inscription"></asp:RequiredFieldValidator>
    <asp:CompareValidator ID="CompareValidator1" runat="server" 
        ControlToCompare="TxtbxMotDePasse2" ControlToValidate="TxtbxMotDePasse" 
        Display="Dynamic" ErrorMessage="Les mots de passe doivent etre identiques" ForeColor="Red" EnableClientScript="False" ValidationGroup="inscription" ></asp:CompareValidator>
    <br />
    <asp:Button ID="BtnCreeProgrammeur" runat="server" Text="Cree" OnClick="BtnCreeProgrammeur_Click" ValidationGroup="inscription"  />
    <br />

</asp:Content>

