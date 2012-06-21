<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/_MasterPages/Default.Master" CodeBehind="Default.aspx.vb" Inherits="CVUDES_Professor._Default2" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="phMainBody" runat="server">
    <div class="TabStripContainer">
    <div>
        <asp:Label CssClass="PageTitle" runat="server" ID="lblPageTitle" Text="<%$ Resources: Titles2, ProfessorTitle %>"></asp:Label>
        <asp:Label CssClass="PageSubTitle" runat="server" ID="lblPageSubTitle" Text="<%$ Resources: Titles2, ProfessorTitle2 %>"></asp:Label>
    </div>
    <div class="ToolBar">
        <ul>
            <li>
                <asp:HyperLink ID="lnkHome" runat="server" Text="<%$ Resources: Links, lnkHome %>" NavigateUrl="javascript:;"></asp:HyperLink>
            </li>
            <li class="Separator">
                <img alt="" src="/_Resources/Images/Separator.gif" />
            </li>
            <li>
                <asp:HyperLink ID="lnkCreate" runat="server" Text="<%$ Resources: Links2, lnkProfessorCreate %>" NavigateUrl="javascript:;"></asp:HyperLink>
            </li>
            <li class="Separator">
                <img alt="" src="/_Resources/Images/Separator.gif" />
            </li>
            <li>
                <asp:HyperLink ID="lnkSearch" runat="server" Text="<%$ Resources: Links2, lnkProfessorSearch %>" NavigateUrl="javascript:;" />
            </li>
            <li class="Separator">
                <img alt="" src="/_Resources/Images/Separator.gif" />
            </li>
            <li>
                <eb:ExpandingLinkButton ID="lbtnFilter" runat="server" ControlToToggle="FilterOptions" ExpandedText="<%$ Resources: Buttons, lbtnFilter_ExpandedText %>" ContractedText="<%$ Resources: Buttons, lbtnFilter_ContractedText %>" TextAlt1="<%$ Resources: Buttons, lbtnFilter_TextAlt1 %>" TextAlt2="<%$ Resources: Buttons, lbtnFilter_TextAlt2 %>" Expanded="False"></eb:ExpandingLinkButton>
            </li>
        </ul>
    </div>
    <div class="BoxUnderline">
        <div class="FilterDescription" style="height: 15px; display: block;">
            <div style="display: inline; float: left; width: auto; margin-right: 4px;">
                <asp:Label ID="Label1" runat="server" Text="<%$ Resources: Tags, tagFilterSelected %>" Font-Bold="true"></asp:Label>
            </div>
            <div style="display: inline; float: left; width: 830px;">
                <telerik:RadRotator ID="radFilterOptions" runat="server" ScrollDirection="Up" FrameDuration="2000" Width="800" Height="15" ItemWidth="800" ItemHeight="15" ScrollDuration="1000">
                </telerik:RadRotator>
            </div>
        </div>
    </div>
    <asp:Panel ID="FilterOptions" runat="server" Width="100%">
        <div id="TabStrip" class="TabStripHeader">
            <%--<uc:GridTabStrip ID="GridTabStrip1" runat="server" />--%>
        </div>
        <div class="TabStripContainerIE6">
        </div>


    </asp:Panel>
</div>
</asp:Content>
