<%@ Page Title="Creación de Usuario" Language="vb" AutoEventWireup="false" MasterPageFile="~/_MasterPages/DefaultPublic.Master" CodeBehind="PreRegister.aspx.vb" Inherits="CVUDES_Professor.PreRegister" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="phMainBody" runat="server">
    <div>
        <asp:Label CssClass="PageTitle" runat="server" ID="lblPageTitle" Text="<%$ Resources: Titles, RegisterTitle %>"></asp:Label>
        <asp:Label CssClass="PageSubTitle" runat="server" ID="lblPageSubTitle" Text="<%$ Resources: Titles, RegisterTitleCreate %>"></asp:Label>
        <br/><br/>
    </div>

    <div>
        <table border="0" cellspacing="0" cellpadding="0" class="FormLayout" width="100%">
            <tr>
                <th>
                    <asp:Label runat="server" ID="lbl1" Text="<%$ Resources: Tags, tagTittleSeccion1 %>" CssClass="SectionTitle"></asp:Label>
                    <br /><br />
                    <asp:Label runat="server" ID="lbl11" Text="<%$ Resources: Tags, tagDescriptionPreRegister %>"></asp:Label>
                </th>
                <td valign="top" style="border-bottom: #c0c0c0 1px solid; padding-right: 4px; border-top: #c0c0c0 1px solid;
                    padding-left: 4px; padding-bottom: 4px; padding-top: 4px; background-color: #f2f2f2; " >
                 <table cellspacing="0" cellpadding="2" border="0" width="95%">
                    <tr >
                        <td>
                            <asp:Panel ID="pnlCheckUserName" runat="server" 
                                Style="padding-left: 0px; padding-right: 6px;" Width="576px">
                            <div id="divUserNameRequired" runat="server" class="MessageContainer1" 
                                    style="height: 16px; margin-bottom: 2px; ">
                                <table cellpadding="0" cellspacing="0" border="0">
                                    <tr>
                                        <td style="width: 22px;">
                                            <img alt="" src="/_Resources/Icons/Warning_Red.gif" /></td>
                                        <td>
                                            <asp:Label ID="lblUserNameRequired" runat="server" Text="<%$ Resources: Messages, UserNameRequired %>" Font-Bold="true" ForeColor="red"></asp:Label>
                                        </td>
                                    </tr>
                                </table>
                            </div>
                            <div id="divUserNameNotAvailable" runat="server" class="MessageContainer1" 
                                    style="height: 16px; margin-bottom: 2px;">
                                <table cellpadding="0" cellspacing="0" border="0">
                                    <tr>
                                        <td style="width: 22px;">
                                            <img alt="" src="/_Resources/Icons/Warning_Red.gif" /></td>
                                        <td>
                                            <asp:Label ID="lblUserNameNotAvailable" runat="server" Text="<%$ Resources: Messages, UserNameNotAvailable %>" Font-Bold="true" ForeColor="red"></asp:Label>
                                            <asp:HyperLink ID="lnkViewUser" runat="server" NavigateUrl="javascript:;" Text="<%$ Resources: Messages, ClickHereToView %>" Target="_blank"></asp:HyperLink>
                                        </td>
                                    </tr>
                                </table>
                            </div>
                            <div id="divUserNameAvailable" runat="server" class="MessageContainer2" 
                                    style="height: 16px; margin-bottom: 2px; " >
                                <table cellpadding="0" cellspacing="0" border="0">
                                    <tr>
                                        <td style="width: 22px;">
                                            <img alt="" src="/_Resources/Icons/Ok_Green.gif" /></td>
                                        <td>
                                            <asp:Label ID="Label7" runat="server" Text="<%$ Resources: Messages, UserNameAvailable %>" Font-Bold="true" ForeColor="Black"></asp:Label>
                                        </td>
                                    </tr>
                                </table>
                            </div>
                            </asp:Panel>
                        </td>
                    </tr>
                    <tr> <%-- Inicio TR Tag/Validador Nombres --%>
                        <td style="height: 20px" > <%-- Inicio TD Tag/Validador Primer Nombre --%>
                            <asp:Label ID="tagNickUserName" runat="server" Text="<%$ Resources: Tags, tagNickUserName %>"></asp:Label>
                            <asp:RequiredFieldValidator ID="rfvNickUserName" runat="server" 
                                ControlToValidate="txtUserName" 
                                ErrorMessage="<%$ Resources: Validators, rfvFirstName %>" 
                                SetFocusOnError="True" ForeColor="Red" >*
                            </asp:RequiredFieldValidator>
                        </td> <%-- Fin TD Tag/Validador Primer Nombre --%>
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="txtUserName" runat="server" Height="16px" Width="280px"></asp:TextBox>
                            <asp:Button ID="btnCheckUserName" runat="server" Text="<%$ Resources: Buttons, btnVerifyUserName %>" Width="120" CausesValidation="false" />
                        </td> <%-- Fin TD TextBox Primer Nombre --%>
                    </tr> <%-- Fin TR TextBox Nombres --%>
                    <tr>
                        <td style="height: 20px" >
                            <asp:Label ID="tagIdentificationDocumentType" runat="server" Text="<%$ Resources: Tags, tagIdentificationDocumentType %>"></asp:Label>
                            <asp:RequiredFieldValidator ID="rfvIdentificationDocumentType" runat="server" 
                                ControlToValidate="dropIdentificationDocumentType" 
                                InitialValue ="Seleccione..."
                                ErrorMessage="<%$ Resources: Validators, rfvIdentificationDocumentType %>" 
                                SetFocusOnError="True" ForeColor="Red" >*
                            </asp:RequiredFieldValidator>
                        </td> <%-- Fin TD Tag/Validador Tipo Documento Identidad --%>
                    </tr>
                    <tr>
                        <td>
                            <telerik:RadComboBox ID="dropIdentificationDocumentType" runat="server" Width="285px" AutoPostBack="False" CausesValidation="False"></telerik:RadComboBox>
                        </td> <%-- Fin TD TextBox Tipo Documento Identidad --%>
                    </tr> <%-- Fin TR Tag/Validador Documento Identidad --%>
                    <tr>
                        <td style="height: 20px" >
                            <asp:Label ID="Label2" runat="server" Text="<%$ Resources: Tags, tagIdentification %>"></asp:Label>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                ControlToValidate="txtIdentification" 
                                ErrorMessage="<%$ Resources: Validators, rfvIdentification %>" 
                                SetFocusOnError="True" ForeColor="Red" >*
                            </asp:RequiredFieldValidator>
                        </td> <%-- Fin TD Tag/Validador Número Documento Identidad --%>
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="txtIdentification" runat="server" Width="280px" Height="16px"></asp:TextBox>    
                        </td> <%-- Fin TD TextBox Número Documento Identidad --%>
                    </tr> <%-- Fin TR Tag/Validador Documento Identidad --%>
                    <tr>
                        <td style="height: 20px" >
                            <asp:Label ID="tagEmail" runat="server" Text="<%$ Resources: Tags, tagEmail %>"></asp:Label>
                            <asp:RequiredFieldValidator ID="rfvEmail" runat="server" 
                                ControlToValidate="txtEmail" 
                                ErrorMessage="<%$ Resources: Validators, rfvEmail %>" 
                                SetFocusOnError="True" ForeColor="Red" >*
                            </asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="revEmail" runat="server" 
                                ErrorMessage="<%$ Resources: Validators, rfvEmail %>" 
                                ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                                ControlToValidate="txtEmail" Display="Dynamic" ForeColor="Red">*
                            </asp:RegularExpressionValidator>
                        </td>
                    </tr>
                    <tr>
                        <td >
                            <asp:TextBox ID="txtEmail" runat="server" Width="280px" Height="16px"></asp:TextBox>    
                        </td>
                    </tr>
                    <tr>
                        <td style="height: 20px" >
                            <asp:Label ID="tagEmail2" runat="server" Text="<%$ Resources: Tags, tagEmail2 %>"></asp:Label>
                                <asp:RegularExpressionValidator ID="revEmail2" runat="server" 
                                ErrorMessage="<%$ Resources: Validators, rfvEmail2 %>" 
                                ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                                ControlToValidate="txtEmail" Display="Dynamic" ForeColor="Red">*
                            </asp:RegularExpressionValidator>
                        </td>
                    </tr>
                    <tr>
                        <td style="height: 20px" >
                            <asp:TextBox ID="txtEmail2" runat="server" Width="280px" Height="16px"></asp:TextBox> 
                        </td>
                    </tr>
                    <tr>
                        <td style="height: 20px" >
                            <asp:Label ID="tagPassword" runat="server" Text="<%$ Resources: Tags, tagPassword %>"></asp:Label>
                            <asp:RequiredFieldValidator ID="rfvPassword" runat="server" 
                                ControlToValidate="txtPassword" 
                                ErrorMessage="<%$ Resources: Validators, rfvPassword %>" 
                                SetFocusOnError="True" ForeColor="Red" >*
                            </asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td >
                            <asp:TextBox ID="txtPassword" runat="server" Width="280px" Height="16px" TextMode="Password"></asp:TextBox>    
                        </td>
                    </tr>
                    <tr>
                        <td style="height: 20px" >
                            <asp:Label ID="tagPassword2" runat="server" Text="<%$ Resources: Tags, tagPassword2 %>"></asp:Label>
                            <asp:RequiredFieldValidator ID="rfvPassword2" runat="server" 
                                ControlToValidate="txtPassword" 
                                ErrorMessage="<%$ Resources: Validators, rfvPassword %>" 
                                SetFocusOnError="True" ForeColor="Red" >*
                            </asp:RequiredFieldValidator>
                            <asp:CompareValidator ID="cpvPassword" runat="server" 
                                ControlToCompare="txtPassword" ControlToValidate="txtPassword2" 
                                ErrorMessage="<%$ Resources: Validators, cpvPassword %>"
                                SetFocusOnError="True" ForeColor="Red" >*
                            </asp:CompareValidator>
                        </td>
                    </tr>
                    <tr>
                        <td >
                            <asp:TextBox ID="txtPassword2" runat="server" Width="280px" Height="16px" TextMode="Password"></asp:TextBox>    
                        </td>
                    </tr>
                </table> <%-- Tabla Campos Información Personal --%>
                </td> <%-- Fin TD Campos Información Personal --%>
            </tr> <%-- Fin TR Sección Información Personal --%>
        </table>
        <div class="FormLayoutButtons">
            <asp:Button ID="btnRegister" Text="<%$ Resources: Buttons, btnRegister %>" runat="server" Width="100" />&nbsp; &nbsp; &nbsp;
            <asp:Button ID="btnCancel" Text="<%$ Resources: Buttons, btnCancel %>" runat="server" Width="100" CausesValidation="False" />
        </div>
    </div>
        <asp:ValidationSummary ID="vsmform" runat="server" ShowMessageBox="True" ShowSummary="False" Width="100%" />
</asp:Content>
