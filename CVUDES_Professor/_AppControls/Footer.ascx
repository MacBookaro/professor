<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="Footer.ascx.vb" Inherits="CVUDES_Professor.Footer" %>
<div class="FooterBar">
</div>
<span>
    <asp:Label ID="lblFooterText" runat="server" Text="<%$ Resources:AppResources, FooterText %>"></asp:Label>
    <asp:HyperLink ID="lnkFooter" runat="server" NavigateUrl="javascript:;" Text="<%$ Resources:AppResources, FooterLink %>"></asp:HyperLink>&nbsp;&nbsp;
    <asp:Label ID="lblCount" runat="server" Text="0" ForeColor="White"></asp:Label>&nbsp;&nbsp;
    <asp:Label ID="lblCulture" runat="server" Text="0" ForeColor="White"></asp:Label>
</span>

