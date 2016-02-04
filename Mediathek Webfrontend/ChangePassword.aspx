<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMasterMenu.master" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="Mediathek_Webfrontend.ChangePassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <div style="width: 700px; margin-left: auto; margin-right: auto;">
        <asp:Label ID="LblMessages" runat="server" CssClass="error" 
        Text="Text" Visible="False"></asp:Label>
        <br />
        <br />
	    <div class="label">
		    Altes Kennwort:
	    </div>
	    <asp:TextBox ID="TxtPasswordOld" runat="server" MaxLength="10" Width="150px" TextMode="Password"></asp:TextBox>
	    <asp:RequiredFieldValidator ID="RequiredFieldValidatorOldPwd" runat="server" 
            ErrorMessage="Bitte Ihr aktuelles Kennwort eingeben." 
            ControlToValidate="TxtPasswordOld" Display="None"></asp:RequiredFieldValidator>
	    <br />
	    <br />
	    <div class="label">
		    Neues Kennwort:

	    </div>
        <asp:TextBox ID="TxtPassword" runat="server" MaxLength="50" Width="150px" 
            TextMode="Password"></asp:TextBox>
	    <asp:RequiredFieldValidator ID="RequiredFieldValidatorNewPwd" runat="server" 
                ErrorMessage="Bitte das neue Kennwort eingeben." 
            ControlToValidate="TxtPassword" Display="None"></asp:RequiredFieldValidator>
	    <br />
	    <br />
	    <div class="label">
		    Neues Passwort (Wiederhl.):
	    </div>

	    <asp:TextBox ID="TxtPasswordCheck" runat="server" MaxLength="50" Width="150px" 
            TextMode="Password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorNewPwdCheck" runat="server" 
            ErrorMessage="Bitte die Wiederholung des neuen Kennwortes eingeben." 
            ControlToValidate="TxtPasswordCheck" Display="None"></asp:RequiredFieldValidator>
	    <br />
	    <br />
	    <div class="label">
		    &nbsp;
	    </div>
        <asp:Button ID="ButOk" runat="server" Text="OK" onclick="ButOk_Click" />
        &nbsp;
        <br />
        <br />
        <asp:CompareValidator ID="CompareValidatorNewPwds" runat="server" 
            ErrorMessage="Die neuen Kennwörter stimmen nicht überein" 
            ControlToCompare="TxtPasswordCheck" ControlToValidate="TxtPassword" 
            Display="None"></asp:CompareValidator>
        <asp:ValidationSummary ID="ValidationSummary" runat="server" />
    </div>
</asp:Content>
