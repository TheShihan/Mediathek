<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Mediathek_Webfrontend.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderMenu" runat="server">
    <!-- Menu not used here -->
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    <div style="width: 700px; margin-left: auto; margin-right: auto;">
        <asp:Label ID="LblLoginError" runat="server" CssClass="error" 
            Text="Die Login-Daten sind ungültig." Visible="False"></asp:Label>
        <br />
        <br />
	    <div class="label">
		    Kunden-Nr.:
	    </div>
	    <asp:TextBox ID="TxtUsername" runat="server" MaxLength="10" Width="150px" 
            ontextchanged="TxtLoginField_TextChanged"></asp:TextBox>
	    <asp:RequiredFieldValidator ID="RequiredFieldValidatorUsername" runat="server" 
            ControlToValidate="TxtUsername" 
            ErrorMessage="Bitte geben Sie Ihre Kunden-Nr. ein" Display="Dynamic"></asp:RequiredFieldValidator>
        <asp:CompareValidator
                ID="CompareValidatorUserId" runat="server" 
            ErrorMessage="Nur Zahlen erlaubt" ControlToValidate="TxtUsername" 
            Display="Dynamic" Operator="DataTypeCheck" Type="Integer"></asp:CompareValidator>
	    <br />
	    <br />
	    <div class="label">
		    Passwort:
	    </div>
	    <asp:TextBox ID="TxtPassword" runat="server" MaxLength="50" Width="150px" 
            TextMode="Password" ontextchanged="TxtLoginField_TextChanged"></asp:TextBox>
	    <asp:RequiredFieldValidator ID="RequiredFieldValidatorPassword" runat="server" 
            ControlToValidate="TxtPassword" 
            ErrorMessage="Bitte geben Sie Ihr Kennwort ein" Display="Dynamic"></asp:RequiredFieldValidator>
	    <br />
	    <br />
	    <div class="label">
		    &nbsp;
	    </div>
        <asp:Button ID="ButOk" runat="server" Text="OK" onclick="ButOk_Click" />
        &nbsp;
        <asp:Button ID="ButReset" runat="server" Text="Zurücksetzen" 
            onclick="ButReset_Click" CausesValidation="False" />
        <br />
        <br />
    </div>
</asp:Content>

