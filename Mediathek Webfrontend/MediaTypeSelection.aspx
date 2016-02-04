<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMasterMenu.master" AutoEventWireup="true" CodeBehind="MediaTypeSelection.aspx.cs" Inherits="Mediathek_Webfrontend.MediaTypeSelection" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <asp:ObjectDataSource ID="ObjectDataSourceMediaTypes" runat="server" 
        SelectMethod="GetMediaTypes" TypeName="BusinessLogic.BusinessLogicHandler">
    </asp:ObjectDataSource>
    
    <div style="text-align: center;">
        <br />
        <div class="innerContent" style="margin-left: auto; margin-right: auto; width: 500px; text-align: center;">
            <br />
            <b>Suche</b>
            <br />
            <br />
            <div class="label" style="padding-left: 100px; width: 120px;">
            <asp:Label ID="LblTitle" runat="server" Text="Titel:"></asp:Label>
            </div>
            <asp:TextBox ID="TxtTitle" runat="server" MaxLength="50" style="width: 200px;"></asp:TextBox>
            <br />
            <br />
            <div class="label" style="padding-left: 100px; width: 120px;">
            <asp:Label ID="LblDescription" runat="server" Text="Beschreibung:"></asp:Label>
            </div>
            <asp:TextBox ID="TxtDesc" runat="server" MaxLength="50" style="width: 200px;"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="ButSearch" runat="server" Text="Suchen" 
                onclick="ButSearch_Click" />
            <br />
            <br />
        </div>
        <br />
        <div class="innerContent"  style="margin-left: auto; margin-right: auto; width: 500px; text-align: center;">
            <br />
            <b>Suche (nach Kategorien)</b>
            <br />
            <br />
            <asp:DropDownList ID="DropDownListMediaType" runat="server" AutoPostBack="False" 
                DataSourceID="ObjectDataSourceMediaTypes" DataTextField="TypeName" 
                DataValueField="MediaTypeId" 
                AppendDataBoundItems="True">
                <asp:ListItem Selected="True" Value="-1">-</asp:ListItem>
            </asp:DropDownList>
            &nbsp;
            <asp:Button ID="ButTypeSelOk" runat="server" Text="OK" 
                onclick="ButTypeSelOk_Click" />
            <br />
            <br />
        </div>
        <br />
    </div>
</asp:Content>
