<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMasterMenu.master" AutoEventWireup="true" CodeBehind="Lendings.aspx.cs" Inherits="Mediathek_Webfrontend.Lendings" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder" runat="server">

<div class="innerContent" style="text-align: center;">
    <br />
    <asp:HiddenField ID="HiddenFieldUserId" runat="server" />
    <h3>
        <asp:Label ID="LblLendings" runat="server" Text="Bisherige Aufträge"></asp:Label>
    </h3>
    <asp:GridView ID="GridViewLendings" runat="server" AllowPaging="True" 
        AutoGenerateColumns="False" CssClass="GridView" 
        DataSourceID="ObjectDataSourceLendings" 
        onselectedindexchanged="GridViewLendings_SelectedIndexChanged">
        <Columns>
            <asp:BoundField DataField="MediaId" HeaderText="Media ID" 
                SortExpression="MediaId">
            <ControlStyle CssClass="hide" />
            <FooterStyle CssClass="hide" />
            <HeaderStyle CssClass="hide" />
            <ItemStyle CssClass="hide" />
            </asp:BoundField>
            <asp:BoundField DataField="CheckOutDate" DataFormatString="{0:d}" 
                HeaderText="Ausleih-Datum" HtmlEncode="False" SortExpression="CheckOutDate">
            <ItemStyle CssClass="centerControl" />
            </asp:BoundField>
            <asp:BoundField DataField="CheckInDate" DataFormatString="{0:d}" 
                HeaderText="Rückgabe-Datum" HtmlEncode="False" SortExpression="CheckInDate">
            <ItemStyle CssClass="centerControl" />
            </asp:BoundField>
            <asp:BoundField DataField="Duration" HeaderText="Ausleih-Dauer (T)" 
                SortExpression="Duration">
            <ItemStyle CssClass="centerControl" />
            </asp:BoundField>
            <asp:CommandField ButtonType="Image" HeaderText="Medium" 
                SelectImageUrl="~/Images/Icons/page.png" SelectText="Medium anzeigen" 
                ShowHeader="True" ShowSelectButton="True">
            <ItemStyle CssClass="centerControl" />
            </asp:CommandField>
        </Columns>
    </asp:GridView>
    <asp:ObjectDataSource ID="ObjectDataSourceLendings" runat="server" 
        SelectMethod="GetLendingsForUser" TypeName="BusinessLogic.BusinessLogicHandler">
        <SelectParameters>
            <asp:ControlParameter ControlID="HiddenFieldUserId" DefaultValue="0" 
                Name="userId" PropertyName="Value" Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>
    <br />
</div>

</asp:Content>
