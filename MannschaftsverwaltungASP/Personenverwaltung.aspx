<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Personenverwaltung.aspx.cs" Inherits="MannschaftsverwaltungASP.Personenverwaltung" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:DropDownList ID="SportArt" runat="server">
        <asp:ListItem Selected="True" Text="Fussbal" Value="fussball"></asp:ListItem>
        <asp:ListItem Text="Tennis" Value="tennis"></asp:ListItem>
        <asp:ListItem Text="Handball" Value="handball"></asp:ListItem>
    </asp:DropDownList>
</asp:Content>
