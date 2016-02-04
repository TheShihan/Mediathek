<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMasterMenuMediaSearch.master" AutoEventWireup="true" CodeBehind="MediaSearchVideos.aspx.cs" Inherits="Mediathek_Webfrontend.MediaSearchVideos" %>


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
                            <asp:BoundField DataField="Director" HeaderText="Regisseur" 
                                SortExpression="Director" />
                            <asp:CommandField ButtonType="Image" HeaderText="Details" 
                                SelectImageUrl="~/Images/Icons/page.png" SelectText="Anzeigen" 
                                ShowHeader="True" ShowSelectButton="True" >
                            <ItemStyle CssClass="centerControl" />
                            </asp:CommandField>
                        </Columns>
</asp:GridView>
<asp:ObjectDataSource ID="ObjectDataSourceMedia" runat="server" 
    SelectMethod="GetMediaVideoByCatId" TypeName="BusinessLogic.BusinessLogicHandler">
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


