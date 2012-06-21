<%@ Page Title="Inicio de Sesión" Language="vb" AutoEventWireup="false" MasterPageFile="~/_MasterPages/Form.Master" CodeBehind="SignIn.aspx.vb" Inherits="CVUDES_Professor.SignInPage" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="phMainBody" runat="server">
    <asp:Panel ID="pnlForm" runat="server" DefaultButton="btnSignIn">
        <div style="height: 29px; text-align: center; display: block; padding-right: 2%; padding-left: 2%; border: 0px solid white; margin-left: 10px; margin-right: 10px;">
            <asp:Panel runat="server" Visible="false" ID="TableMessage" CssClass="MessageContainer3" Style="height: 18px; width: auto; vertical-align: middle; padding-top: 4px;">
                <img alt="" src="/_Resources/Icons/Warning_Red.gif" style="width: 16px; height: 16px; vertical-align: top; margin-right: 4px;" />
                <asp:Label ID="lblValidateError" runat="server" Text="<%$ Resources: Messages, SignInErrorValidating %>"></asp:Label>
            </asp:Panel>
        </div>
        <table width="100%" border="0" cellpadding="0" cellspacing="1">
            <tr>
                <td style="text-align: right; width: 30%;">
                    <asp:RequiredFieldValidator ControlToValidate="txtUserName" Text="*" runat="Server" ID="rfvUserName" ErrorMessage="<%$ Resources: Validators, rfvUserName %>" SetFocusOnError="True" ForeColor="Red" />
                    <asp:Label ID="tagUserName" runat="server" Text="<%$ Resources: Tags, tagUserName %>"></asp:Label>
                    &nbsp;
                </td>
                <td>
                    <telerik:RadTextBox ID="txtUserName" runat="server" Width="230" />
                </td>
            </tr>
            <tr>
                <td style="text-align: right;">
                    <asp:RequiredFieldValidator ControlToValidate="txtPassword" Text="*" runat="Server" ID="rfvPassword" ErrorMessage="<%$ Resources: Validators, rfvPassword %>" SetFocusOnError="True" ForeColor="Red" />
                    <asp:Label ID="tagUserPassword" runat="server" Text="<%$ Resources: Tags, tagUserPassword %>"></asp:Label>
                    &nbsp;
                </td>
                <td>
                    <telerik:RadTextBox ID="txtPassword" runat="server" TextMode="Password" Width="230" />
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td style="padding-top: 4px" align="center">
                    <asp:Button ID="btnSignIn" Text="<%$ Resources: Buttons, btnSignIn %>" runat="server" Width="100" />
                    <asp:Button ID="btnCancel" Text="<%$ Resources: Buttons, btnCancel %>" runat="server" Width="100" CausesValidation="False" />
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td style="padding-top: 5px" align="center">
                    <asp:HyperLink ID="lnkPasswordReset" runat="server" NavigateUrl="javascript:;" Text="<%$ Resources: Links, lnkPasswordReset %>"></asp:HyperLink><br />
                    <asp:HyperLink ID="lnkRegister" runat="server" NavigateUrl="javascript:;" Text="<%$ Resources: Links, lnkRegistreceAqui %>"></asp:HyperLink>
                </td>
            </tr>
        </table>
    </asp:Panel>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="True" ShowSummary="False" Width="100%" />
    <telerik:RadAjaxManagerProxy ID="RadAjaxManagerProxy1" runat="server">
        <AjaxSettings>
            <telerik:AjaxSetting AjaxControlID="btnSignIn">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="TableMessage" />
                    <telerik:AjaxUpdatedControl ControlID="txtUsername" />
                    <telerik:AjaxUpdatedControl ControlID="txtPassword" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="btnCancel">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="btnCancel" />
                </UpdatedControls>
            </telerik:AjaxSetting>
        </AjaxSettings>
    </telerik:RadAjaxManagerProxy>
    <telerik:RadAjaxPanel ID="xpnlScript" runat="server" EnablePageHeadUpdate="False"></telerik:RadAjaxPanel>

    <div style="padding-top: 15px; height: 15px; text-align: center;">
        <asp:Label ID="lblTitle" runat="server" Text="<%$ Resources: AppResources, ApplicationTitle %>"></asp:Label>
    </div>
    <div style="height: 29px; text-align: center; display: block; padding-right: 2%; padding-left: 2%; border: 0px solid white; margin-left: 10px; margin-right: 10px;">
    </div>
</asp:Content>
