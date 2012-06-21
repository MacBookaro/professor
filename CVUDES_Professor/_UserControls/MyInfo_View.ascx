<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="MyInfo_View.ascx.vb" Inherits="CVUDES_Professor.MyInfoViewUserControl" %>
<table width="100%" border="0" cellspacing="0" cellpadding="0">
    <tr>
        <td style="width: 120px; vertical-align: top; text-align: center;">
            <img alt="" src="/_Resources/Images/User.png" />
        </td>
        <td style="vertical-align: top; padding-left: 0px;">
            <table width="100%" border="0" cellspacing="0" cellpadding="0">
                <tr>
                    <td>
                        <asp:Label ID="lblUserCompleteName" runat="server" Text="Nombre Completo del Usuario" CssClass="MyInfoTitle"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <table width="100%" border="0" cellspacing="0" cellpadding="0">
                            <tr>
                                <td style="width: 450px; vertical-align: top;">
                                    <asp:Label ID="tagUserInformation" runat="server" Text="<%$ Resources: Tags, tagUserInformation %>" Font-Bold="true"></asp:Label>
                                    <br />
                                    <asp:Label ID="tagEmail" runat="server" Text="<%$ Resources: Tags, tagEmail %>"></asp:Label>
                                    <asp:Label ID="lblEmail" runat="server" Text="email@cvudes.edu.co" Font-Bold="true" ForeColor="#999999"></asp:Label>
                                    <br />
                                    <asp:Label ID="tagUserName" runat="server" Text="<%$ Resources: Tags, tagUserName %>"></asp:Label>
                                    <asp:Label ID="lblUserName" runat="server" Text="user.name" Font-Bold="true" ForeColor="#999999"></asp:Label>
                                    <br />
<%--                                    <asp:Label ID="tagCurrentSession" runat="server" Text="<%$ Resources: Tags, tagCurrentSession %>"></asp:Label>
                                    <asp:Label ID="lblCurrentSession" runat="server" Text="sesión actual" Font-Bold="false" ForeColor="#999999"></asp:Label>
                                    <br />
                                    <asp:Label ID="tagLastSession" runat="server" Text="<%$ Resources: Tags, tagLastSession %>"></asp:Label>
                                    <asp:Label ID="lblLastSession" runat="server" Text="última sesión" Font-Bold="false" ForeColor="#999999"></asp:Label>
                                    <br />
                                    <asp:HyperLink ID="lnkEditMyInformation" runat="server" NavigateUrl="javascript:;" Text="<%$ Resources: Links, lnkEditMyInformation2 %>"></asp:HyperLink>&nbsp;
                                    <asp:HyperLink ID="lnkViewMySessionsLog" runat="server" NavigateUrl="javascript:;" Text="<%$ Resources: Links, lnkViewMySessionsLog %>"></asp:HyperLink>--%>
                                </td>
                                <td style="width: 450px; vertical-align: top;">
                                   <%-- <asp:Label ID="tagPasswordReseInformation" runat="server" Text="<%$ Resources: Tags, tagPasswordResetInformation %>" Font-Bold="true"></asp:Label>
                                    <br />
                                    <asp:Label ID="tagPassword" runat="server" Text="<%$ Resources: Tags, tagPassword %>"></asp:Label>
                                    <asp:Label ID="lblPassword" runat="server" Text="********" Font-Bold="false" ForeColor="#999999"></asp:Label>&nbsp;
                                    <asp:HyperLink ID="lnkChangeMyPassword" runat="server" NavigateUrl="javascript:;" Text="<%$ Resources: Links, lnkChangeMyPassword2 %>"></asp:HyperLink>
                                    <br />
                                    <asp:Label ID="tagSecretQuestion" runat="server" Text="<%$ Resources: Tags, tagSecretQuestion %>"></asp:Label>
                                    <asp:Label ID="lblSecretQuestion" runat="server" Text="Secret Question" Font-Bold="false" ForeColor="#999999"></asp:Label>
                                    <br />
                                    <asp:Label ID="tagExternalEmail" runat="server" Text="<%$ Resources: Tags, tagExternalEmail %>"></asp:Label>
                                    <asp:Label ID="lblExternalEmail" runat="server" Text="External Email" Font-Bold="false" ForeColor="#999999"></asp:Label>--%>
                                </td>
                                <td>
                                    &nbsp;
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
</table>
