<%@ Page Language="vb" AutoEventWireup="false" Codebehind="ErrorMessage.aspx.vb" Inherits="CVUDES.CVAdmin.PublicErrorMessagePage" MasterPageFile="~/_MasterPages/DefaultPublic.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="phMainBody" runat="Server">
    <div>
        <asp:Label CssClass="PageTitle" runat="server" ID="lblPageTitle" Text="<%$ Resources: Titles, ApplicationErrorTitle %>"></asp:Label>
        <asp:Label CssClass="PageSubTitle" runat="server" ID="lblPageSubTitle" Text="<%$ Resources: Titles, ApplicationErrorTitle2 %>"></asp:Label>
    </div>
    <table width="100%" border="0" cellpadding="0" cellspacing="0">
        <tr>
            <td style="width: 190px; border: 1px solid #C8C8C8; vertical-align: top; text-align: center; padding-top: 20px; padding-bottom: 20px;">
                <asp:Image ID="Image1" runat="server" ImageUrl="/_Resources/Images/Alert_Error_Red.png" />
            </td>
            <td style="width: 2px;">
            </td>
            <td style="padding: 10px; border: 1px solid #C8C8C8; vertical-align: top;">
                <br />
                <br />
                <asp:Label ID="lblErrorMessage" runat="server" Text="" Font-Bold="true" ForeColor="red" Font-Size="10"></asp:Label>
                <br />
                <br />
                <br />
                <asp:Label ID="lblErrorDescription" runat="server" Text=""></asp:Label>
            </td>
        </tr>
    </table>
    <div class="FormLayoutButtons">
        <asp:Button ID="btnOk" Text="<%$ Resources: Buttons, btnContinue %>" runat="server" Width="120" CausesValidation="true"  />
    </div>
</asp:Content>
