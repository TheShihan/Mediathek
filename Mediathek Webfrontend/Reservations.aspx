<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMasterMenu.master" AutoEventWireup="true" CodeBehind="Reservations.aspx.cs" Inherits="Mediathek_Webfrontend.Reservations" culture="auto" meta:resourcekey="PageResource1" uiculture="auto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder" runat="server">

<div class="innerContent" style="text-align: center;">
    <br />
    <asp:HiddenField ID="HiddenFieldUserId" runat="server" />
    <h3>
        <asp:Label ID="LblOpenReservations" runat="server" Text="Offene Reservationen"></asp:Label>
    </h3>
    <asp:GridView ID="GridViewOpenReservations" runat="server" 
        AutoGenerateColumns="False" DataSourceID="ObjectDataSourceOpenReservations" 
        onrowdeleted="GridViewOpenReservations_RowDeleted" 
        DataKeyNames="ReservationId" 
        onselectedindexchanged="GridViewOpenReservations_SelectedIndexChanged">
        <Columns>
            <asp:BoundField DataField="ReservationId" HeaderText="ID" 
                SortExpression="ReservationId" >
            <ItemStyle CssClass="centerControl" />
            </asp:BoundField>
            <asp:BoundField DataField="CreationDate" HeaderText="Erstell-Datum" 
                SortExpression="CreationDate" DataFormatString="{0:d}" 
                HtmlEncode="False" >
            <ItemStyle CssClass="centerControl" />
            </asp:BoundField>
            <asp:BoundField DataField="Duration" HeaderText="Wartedauer (T)">
            <ItemStyle CssClass="centerControl" />
            </asp:BoundField>
            <asp:CommandField ButtonType="Image" HeaderText="Medium" 
                SelectImageUrl="~/Images/Icons/page.png" SelectText="Medium anzeigen" 
                ShowHeader="True" ShowSelectButton="True">
            <ItemStyle CssClass="centerControl" />
            </asp:CommandField>
            <asp:CommandField ButtonType="Image" DeleteImageUrl="~/Images/Icons/cross.png" 
                DeleteText="Reservation abbrechen" HeaderText="Löschen" ShowDeleteButton="True" 
                ShowHeader="True">
            <ItemStyle CssClass="centerControl" />
            </asp:CommandField>
        </Columns>
    </asp:GridView>
    <asp:ObjectDataSource ID="ObjectDataSourceOpenReservations" runat="server" 
        SelectMethod="GetOpenReservations" 
        TypeName="BusinessLogic.BusinessLogicHandler" 
        DeleteMethod="DeleteReservation">
        <DeleteParameters>
            <asp:ControlParameter ControlID="GridViewOpenReservations" Name="reservationId" 
                PropertyName="SelectedValue" />
        </DeleteParameters>
        <SelectParameters>
            <asp:ControlParameter ControlID="HiddenFieldUserId" DefaultValue="0" 
                Name="userId" PropertyName="Value" Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>
    <br />
</div>

<br />

<div class="innerContent" style="text-align: center;">
    <br />
    <h3>
    <asp:Label ID="LblOldReservations" runat="server" Text="Abgeschlossene Reservationen" 
        meta:resourcekey="Label2Resource1"></asp:Label>
    </h3>
    <asp:GridView ID="GridViewClosedReservations" runat="server" AutoGenerateColumns="False" 
        DataSourceID="ObjectDataSourceClosedReservations" 
        onselectedindexchanged="GridViewClosedReservations_SelectedIndexChanged">
        <Columns>
            <asp:BoundField DataField="ReservationId" HeaderText="ID" 
                SortExpression="ReservationId" >
            <ItemStyle CssClass="centerControl" />
            </asp:BoundField>
            <asp:BoundField DataField="CreationDate" DataFormatString="{0:d}" 
                HeaderText="Erstell-Datum" HtmlEncode="False" 
                SortExpression="CreationDate" >
            <ItemStyle CssClass="centerControl" />
            </asp:BoundField>
            <asp:BoundField DataField="EndDate" DataFormatString="{0:d}" 
                HeaderText="Ausleih-Datum" HtmlEncode="False" SortExpression="EndDate" >
            <ItemStyle CssClass="centerControl" />
            </asp:BoundField>
            <asp:BoundField DataField="Duration" HeaderText="Wartedauer (T)">
            <ItemStyle CssClass="centerControl" />
            </asp:BoundField>
            <asp:CommandField ButtonType="Image" HeaderText="Medium" 
                NewText="Medium anzeigen" SelectImageUrl="~/Images/Icons/page.png" 
                ShowHeader="True" ShowSelectButton="True">
            <ItemStyle CssClass="centerControl" />
            </asp:CommandField>
        </Columns>
    </asp:GridView>
    <asp:ObjectDataSource ID="ObjectDataSourceClosedReservations" runat="server" 
        SelectMethod="GetClosedReservations" 
        TypeName="BusinessLogic.BusinessLogicHandler">
        <SelectParameters>
            <asp:ControlParameter ControlID="HiddenFieldUserId" DefaultValue="0" 
                Name="userId" PropertyName="Value" Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>
    <br />
</div>

</asp:Content>
