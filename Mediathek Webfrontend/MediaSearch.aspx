<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMasterMenu.master" AutoEventWireup="true" CodeBehind="MediaSearch.aspx.cs" Inherits="Mediathek_Webfrontend.MediaSearch" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder" runat="server">

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
        <asp:GridView ID="GridViewMedia" runat="server" CssClass="GridView" 
            AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" 
            DataSourceID="ObjectDataSourceMedia" 
            onselectedindexchanged="GridViewMedia_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="MediaId" HeaderText="ID" SortExpression="MediaId" />
                <asp:BoundField DataField="Title" HeaderText="Titel" SortExpression="Title" />
                <asp:TemplateField HeaderText="Description" SortExpression="Description">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server"
                            Text='<%# Eval("Description").ToString().Length>20 ? (Eval("Description") as string).Substring(0,20) + "..." : Eval("Description")  %>'>
                        </asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("Description") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:CommandField ButtonType="Image" HeaderText="Details" 
                    SelectImageUrl="~/Images/Icons/page.png" SelectText="Anzeigen" 
                    ShowHeader="True" ShowSelectButton="True" >
                <ItemStyle CssClass="centerControl" />
                </asp:CommandField>
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSourceMedia" runat="server" 
            SelectMethod="SearchMedia" TypeName="BusinessLogic.BusinessLogicHandler">
            <SelectParameters>
                <asp:ControlParameter ControlID="TxtTitle" Name="title" PropertyName="Text" 
                    Type="String" />
                <asp:ControlParameter ControlID="TxtDesc" Name="description" 
                    PropertyName="Text" Type="String" />
            </SelectParameters>
        </asp:ObjectDataSource>
        <asp:Label ID="LblNoData" runat="server" Text="Es wurden keine Daten gefunden" 
            CssClass="error" Visible="False"></asp:Label>
    </div>

</asp:Content>
