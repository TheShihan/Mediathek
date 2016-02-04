<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="Logout.aspx.cs" Inherits="Mediathek_Webfrontend.Logout" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderMenu" runat="server">
    <!-- no Menu used -->
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    <p style="text-align: center">
        Sie wurden erfolgreich abgemeldet.</p>
<p style="text-align: center">
        &nbsp;<asp:HyperLink ID="HyperLinkLogonPage" runat="server" 
            NavigateUrl="~/Default.aspx">Erneut anmelden</asp:HyperLink>
    </p>
</asp:Content>
