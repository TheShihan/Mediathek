<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMasterMenuMediaSearch.master" AutoEventWireup="true" CodeBehind="MediaSearchBooks.aspx.cs" Inherits="Mediathek_Webfrontend.MediaSearchBooks" %>

<asp:Content ID="Content2" runat="server" 
    contentplaceholderid="ContentPlaceHolderDgv">
                    
                    <asp:GridView ID="GridViewMedia" runat="server" 
    AllowPaging="True" AutoGenerateColumns="False" 
    DataSourceID="ObjectDataSourceMedia" CssClass="GridView" 
                        onselectedindexchanged="GridViewMedia_SelectedIndexChanged">
                        <Columns>
                            <asp:BoundField DataField="MediaId" HeaderText="ID" 
                                SortExpression="MediaId" />
                            <asp:BoundField DataField="Title" HeaderText="Titel" SortExpression="Title" />
                            <asp:BoundField DataField="Author" HeaderText="Autor" 
                                SortExpression="Author" />
                            <asp:BoundField DataField="Publisher" HeaderText="Verlag" 
                                SortExpression="Publisher" />
                            <asp:BoundField DataField="CreationDate" HeaderText="CreationDate" 
                                SortExpression="CreationDate" Visible="False" />
                            <asp:BoundField DataField="Tag" HeaderText="Tag" SortExpression="Tag" 
                                Visible="False" />
                            <asp:BoundField DataField="Description" HeaderText="Description" 
                                SortExpression="Description" Visible="False" />
                            <asp:CommandField ButtonType="Image" HeaderText="Details" 
                                SelectImageUrl="~/Images/Icons/page.png" SelectText="Anzeigen" 
                                ShowHeader="True" ShowSelectButton="True" >
                            <ItemStyle CssClass="centerControl" />
                            </asp:CommandField>
                        </Columns>
</asp:GridView>
<asp:ObjectDataSource ID="ObjectDataSourceMedia" runat="server" 
    SelectMethod="GetMediaBooksByCatId" TypeName="BusinessLogic.BusinessLogicHandler">
    <SelectParameters>
        <asp:ControlParameter ControlID="ContentPlaceHolderTreeView$TreeViewCategories" DefaultValue="0" 
            Name="categoryId" PropertyName="SelectedValue" Type="Int32" />
    </SelectParameters>
</asp:ObjectDataSource>




</asp:Content>

<asp:Content ID="Content3" runat="server" 
    contentplaceholderid="ContentPlaceHolderTreeView">
    <asp:TreeView ID="TreeViewCategories" runat="server" style="text-align: center" 
                        NodeWrap="True" Width="204px">
    </asp:TreeView>
</asp:Content>


