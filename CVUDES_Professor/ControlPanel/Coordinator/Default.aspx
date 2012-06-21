<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/_MasterPages/Default.Master" CodeBehind="Default.aspx.vb" Inherits="CVUDES_Professor.CoodinatorDefaultpage" %>
<%@ Register src="../../_UserControls/MyInfo_View.ascx" tagname="MyInfo_View" tagprefix="uc1" %>


<asp:Content ID="Content1" ContentPlaceHolderID="phMainBody" runat="server">
    <div>
        <asp:Label CssClass="PageTitle" runat="server" ID="lblPageTitle" Text="<%$ Resources: AppResources, HomeTitle %>"></asp:Label>
        <asp:Label CssClass="PageSubTitle" runat="server" ID="lblPageSubTitle" Text="<%$ Resources: AppResources, HomeTitle2 %>"></asp:Label>
    </div>
    <div class="MainContainer" style="float: none; margin-top: 0px; margin-bottom: 3px; height: 105px; width: auto;">
        <uc1:MyInfo_View ID="MyInfo_View1" runat="server" />
    </div>
    <table cellpadding="0" cellspacing="0" border="0" style="height: 295px;">
        <tr>
            <td id="MainCommonOptions" class="MainContainer" style="width: 440px;">
                <asp:Label ID="Label1" runat="server" Text="<%$ Resources: Tags, tagAdministratorOptions %>" CssClass="MainMenuTitle"></asp:Label>
                <div style="float: left; width: 48%;">
                    <div class="MainMenuSubTitle">
                        <asp:Label ID="Label2" runat="server" Text="<%$ Resources: Tags, tagViewInformation %>"></asp:Label></div>
                    <ul class="MainMenu">
                        <li>
                            <asp:HyperLink ID="lnkProfessor" runat="server" NavigateUrl="javascript:;" Text="<%$ Resources: Links, lnkAppProfessor %>" />
                        </li>
                    </ul>
                    <div class="MainMenuSubTitle">
                        <asp:Label ID="Label3" runat="server" Text="<%$ Resources: Tags, tagViewInformation %>"></asp:Label>
                    </div>
                    <ul class="MainMenu">
                        <li>
                            <asp:HyperLink ID="lnkLoadingProfessor" runat="server" NavigateUrl="javascript:;" Text="<%$ Resources: Links, lnkAppLoadingProfessor %>" />
                        </li>
                        <li>
                            <asp:HyperLink ID="lnkLoadingInfoAdmin" runat="server" NavigateUrl="javascript:;" Text="<%$ Resources: Links, lnkAppLoadingInfoAdmin %>" />
                        </li>
                    </ul>
                </div>
                <div style="float: left; width: 10px;">
                </div>
                <div style="float: left; width: 48%;">
                    <div class="MainMenuSubTitle">
                        <asp:Label ID="tagReports" runat="server" Text="<%$ Resources: Tags, tagReports %>"></asp:Label>
                    </div>
                    <ul class="MainMenu">
                        <li>
                            <asp:HyperLink ID="lnkReports" runat="server" NavigateUrl="javascript:;" Text="<%$ Resources: Links, lnkAppReports %>" />
                        </li>
                        <li>
                            &nbsp;
                        </li>
                    </ul>
                </div>
            </td>
            <td class="MainContainerSpacer">
                &nbsp;
            </td>
            <td id="MainAdmin" class="MainContainer" style="width: 230px;">
                <asp:Label ID="tagCommonOptions2" runat="server" Text="<%$ Resources: Tags, tagCommonOptions %>" CssClass="MainMenuTitle"></asp:Label>
            </td>
            <td class="MainContainerSpacer">
                &nbsp;
            </td>
            <td id="MainHelp" class="MainContainer" style="width: 230px;">
                <asp:Label ID="tagHelp" runat="server" Text="<%$ Resources: Tags, tagHelp %>" CssClass="MainMenuTitle"></asp:Label>
            </td>
        </tr>
    </table>
    <asp:Literal ID="Literal1" runat="server"></asp:Literal>
</asp:Content>
