<%@ Control Language="vb" AutoEventWireup="false" Codebehind="Header.ascx.vb" Inherits="CVUDES_Professor.Header" %>

<table width="100%" border="0" cellspacing="0" cellpadding="0">
    <tr>
        <td>
            <table width="100%" border="0" cellspacing="0" cellpadding="0">
                <tr>
                    <td style="width: 100px;">
                        <asp:Image ID="imgAppLogo" runat="server" ImageUrl="<%$ Resources:AppResources, AppLogo %>" />
                    </td>
                    <td style="text-align: right; padding-right: 10px; padding-bottom: 4px; vertical-align: bottom;">
                        <asp:Label ID="tagUser" runat="server" Text="<%$ Resources: Tags, tagUser %>"></asp:Label>
                        <asp:Label ID="lblUserName" runat="server" Text="Nombre del Usuario" Font-Bold="true"></asp:Label>&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="lblSep1" runat="server" Text="&nbsp;|&nbsp;"></asp:Label>
                        <asp:HyperLink ID="lnkSignOut" runat="server" NavigateUrl="javascript:;" Text="<%$ Resources: Links, lnkSignOut %>"></asp:HyperLink>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td>
            <table width="100%" border="0" cellpadding="0" cellspacing="0">
                <tr>
                    <td class="HeaderMenuLeftCorner">
                        &nbsp;
                    </td>
                    <td align="left" class="HeaderMenuMiddle">
                        <table width="100%" border="0" cellpadding="0" cellspacing="0">
                            <tr>
                                <td id="TabAdministrator" runat="server" class="HeaderMenu" visible="true">
                                    <asp:HyperLink ID="lnkAdministrator" Text="<%$ Resources: AppResources, HeaderTabAdministrator %>" runat="server" NavigateUrl="javascript:;" />
                                </td>
                                <td id="TabCoordinator" runat="server" class="HeaderMenu" visible="true">
                                    <asp:HyperLink ID="lnkCoordinator" Text="<%$ Resources: AppResources, HeaderTabCoordinator %>" runat="server" NavigateUrl="javascript:;" />
                                </td>
                                <td id="TabProfessor" runat="server" class="HeaderMenu" visible="true">
                                    <asp:HyperLink ID="lnkProfessor" Text="<%$ Resources: AppResources, HeaderTabProfesor %>" runat="server" NavigateUrl="javascript:;" />
                                </td>
                                <td id="TabCandidate" runat="server" class="HeaderMenu" visible="true">
                                    <asp:HyperLink ID="lnkCandidate" Text="<%$ Resources: AppResources, HeaderTabCandidate %>" runat="server" NavigateUrl="javascript:;" />
                                </td>
                                <td>
                                    &nbsp;
                                </td>
                            </tr>
                        </table>
                    </td>
                    <td class="HeaderMenuRightCorner">
                        &nbsp;
                    </td>
                </tr>
            </table>
        </td>
    </tr>
</table>
<div class="HeaderBar">
</div>

