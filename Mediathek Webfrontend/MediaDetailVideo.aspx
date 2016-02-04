<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMasterMenu.master" AutoEventWireup="true" CodeBehind="MediaDetailVideo.aspx.cs" Inherits="Mediathek_Webfrontend.MediaDetailVideo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder" runat="server">

    <div>
        <asp:Label ID="LblError" runat="server" CssClass="error"></asp:Label>
        
        <table cellpadding="0" cellspacing="0" style="width: 100%">
            <tr>
                <td style="width: 160px; max-width: 160px;">
                    <b>Titel:</b></td>
                <td style="width: 10px; max-width: 10px;">
                    &nbsp;</td>
                <td style="width: 200px; max-width: 200px;">
                    <asp:Label ID="LblTitle" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="width: 160px;">
                    <b>Beschreibung:</b></td>
                <td style="width: 10px;">
                    </td>
                <td style="width: 200px;">
                    </td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:Label ID="LblDesc" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="width: 160px">
                    <b>Regisseur:</b></td>
                <td style="width: 10px">
                    &nbsp;</td>
                <td style="width: 200px">
                    <asp:Label ID="LblDirector" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="width: 160px">
                    <b>Schauspieler:</b></td>
                <td style="width: 10px">
                    &nbsp;</td>
                <td style="width: 200px">
                    <asp:Label ID="LblActors" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="width: 160px">
                    <b>Laufzeit:</b></td>
                <td style="width: 10px">
                    &nbsp;</td>
                <td style="width: 200px">
                    <asp:Label ID="LblRunTime" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="width: 160px">
                    <b>Kategorie:</b></td>
                <td style="width: 10px">
                    &nbsp;</td>
                <td style="width: 200px">
                    <asp:Label ID="LblCat" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="width: 160px">
                    <b>Kennzeichnung:</b></td>
                <td style="width: 10px">
                    &nbsp;</td>
                <td style="width: 200px">
                    <asp:Label ID="LblTag" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="width: 160px">
                    <b>Aufgenommen seit:</b></td>
                <td style="width: 10px">
                    &nbsp;</td>
                <td style="width: 200px">
                    <asp:Label ID="LblCreationDate" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="width: 160px">
                    <b>Status:</b></td>
                <td style="width: 10px">
                    &nbsp;</td>
                <td style="width: 200px">
                    <asp:Label ID="LblState" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
        <p class="center">
            <asp:Image ID="ImgMedia" runat="server" CssClass="center" />
        </p>
    </div>
    <div style="text-align: center;">
    <asp:Button ID="ButReservation" runat="server" Text="Reservieren" 
        CssClass="center" onclick="ButReservation_Click" />
    <asp:Label ID="LblAlreadyRes" runat="server" 
        Text="(Medium ist reserviert)" Visible="False" style="font-weight: 700"></asp:Label>
    </div>
    
</asp:Content>

