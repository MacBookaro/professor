<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Notification.aspx.vb" Inherits="CVUDES_Professor.Notification" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <link type="text/css" rel="Stylesheet" href="../../_Resources/Css/Site.css" />
    <link rel="shortcut icon" href="../../_Resources/Images/icono.ico" />
    <title><asp:Literal ID="ltrTittleNotification" runat="server" Text="<%$ Resources: Tags, tagTittleNotification%>" /></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table align="center" cellspacing="0" cellpadding="0" border="0" width="890">
        <tr>
            <td height="38" valign="top" style="border-bottom: solid 1px #D9D9D9;">
                <table cellspacing="0" cellpadding="0" border="0" width="100%">
                    <tr>
                        <td width="50%">
                            <a href="#">
                                <img border="0" alt="Campus Virtual UDES" src="../../_Resources/Images/Logo.gif" />
                            </a>
                         </td>
                        <td align="right" width="50%" valign="bottom" style="padding-bottom: 5px;">
                            <asp:Label ID="lblDate" runat="server" Text="lblDate" Font-Bold="True" ForeColor="Black"></asp:Label>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td style="padding-top: 1px;">
                <table cellspacing="0" cellpadding="0" border="0" width="100%">
                    <tr>
                        <td style="padding-top: 2px">
                            <table cellspacing="0" cellpadding="0" border="0" width="100%">
                                <tr>
                                    <td align="right" width="50" valign="top">
                                        <img src="../../_Resources/Images/www.cvudes.edu.co.gif" alt="CVUDES" />&nbsp;
                                    </td>
                                    <td width="10">
                                    </td>
                                    <td valign="top">
                                        <br />
                                        <span class="ContentTitle"><asp:Literal ID="ltrtittle2" runat="server" Text="<%$ Resources: Tags, tagTittleNotification%>" /></span>
                                        <br />
                                        <div style="margin-bottom:10px;">
                                            <asp:Literal ID="ltrDescription" runat="server" Text="<%$ Resources: Tags, tagNotification%>" />
                                        </div>
                                        <br />
                                        <table>
                                            <tr>
                                                <td>&nbsp</td>
                                                <td>
                                                    <asp:Button ID="btnSignIn" Text="<%$ Resources: Buttons, btnSignIn %>" runat="server" Width="100" />
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
               </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
