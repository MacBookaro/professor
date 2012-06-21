<%@ Page Language="vb" AutoEventWireup="false" Codebehind="SignOut.aspx.vb" Inherits="CVUDES_Professor.SignOutPage" MasterPageFile="~/_MasterPages/Form.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="phMainBody" runat="Server">
    <div style="padding-top: 20px; text-align: center;">
        <br />
        <br />
        <br />
        <asp:Label ID="tagMessage" runat="server" Text="<%$ Resources: Messages, SignOutConfirm %>" Font-Bold="true"></asp:Label><br />
        <asp:HyperLink ID="lnkSignIn" runat="server" NavigateUrl="javascript:;" Text="<%$ Resources: Links, lnkSignIn %>"></asp:HyperLink>
    </div>
</asp:Content>
