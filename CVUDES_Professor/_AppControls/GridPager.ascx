<%@ Control Language="vb" AutoEventWireup="false" Codebehind="GridPager.ascx.vb" Inherits="CVUDES.CVAdmin.GridPager" %>
<div class="ToolBarPager">
    <div style="float: left;">
        <asp:Label ID="lblPageRecords" runat="server" Text="<%$ Resources: AppConfig, PagerLabelRecords %>" Style="padding-top: 4px; padding-left: 4px; display: block; float: left;"></asp:Label>
    </div>
    <div style="float: right; width: 50%;">
        <ul style="float: right;">
            <li class="Separator">
                <img alt="" src="/_Resources/Images/Separator.gif" />
            </li>
            <li>
                <asp:HyperLink ID="lnkFirst" runat="server" Text="<%$ Resources: AppConfig, PagerLinkFirst %>" NavigateUrl="javascript:;"></asp:HyperLink>
            </li>
            <li>
                <asp:HyperLink ID="lnkPrevious" runat="server" Text="<%$ Resources: AppConfig, PagerLinkPrior %>" NavigateUrl="javascript:;"></asp:HyperLink>
            </li>
            <li>
                <asp:HyperLink ID="lnkNext" runat="server" Text="<%$ Resources: AppConfig, PagerLinkNext %>" NavigateUrl="javascript:;"></asp:HyperLink>
            </li>
            <li>
                <asp:HyperLink ID="lnkLast" runat="server" Text="<%$ Resources: AppConfig, PagerLinkLast %>" NavigateUrl="javascript:;"></asp:HyperLink>
            </li>
        </ul>
        <div style="float: right; padding-top: 4px; padding-right: 4px;">
            <asp:PlaceHolder ID="phPagination" runat="server"></asp:PlaceHolder>
        </div>
    </div>
</div>
