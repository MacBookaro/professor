<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="_Default" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link type="text/css" rel="Stylesheet" href="../../_Resources/Css/Site.css" />
    <link rel="shortcut icon" href="../../_Resources/Images/icono.ico" />
    <title><asp:Literal ID="ltrTittle" runat="server" Text="<%$ Resources: Tags, tagTittlePage%>" /></title>
</head>
<body>
    <form id="formRecruitment" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
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
                            <br/>
                            <asp:Literal ID="Literal5" runat="server" Text="<%$ Resources: Tags, tagInicioSesion%>" />
                        </td>
                    </tr>
                </table> <%-- Fin subTabla Logo Encabezado --%>
            </td> <%-- Fin TD Logo Encabezado --%>
        </tr> <%-- Fin TR Logo Encabezado --%>
        <tr>
            <td style="padding-top: 1px;">
                <table cellspacing="0" cellpadding="0" border="0" width="100%" >
                    <tr>
                        <td style="padding-top: 2px">
                            <table cellspacing="0" cellpadding="0" border="0" width="100%">
                                <tr>
                                    <td align="right" width="50" valign="top">
                                        <img src="../../_Resources/Images/www.cvudes.edu.co.gif" alt="" />&nbsp;
                                    </td>
                                    <td width="10">
                                    </td>
                                    <td valign="top">
                                        <br/>
                                        <span class="ContentTitle"><asp:Literal ID="ltrtittle2" runat="server" Text="<%$ Resources: Tags, tagTittlePage%>" /></span>
                                        <br/>
                                        <div style="margin-bottom:10px;">
                                            <asp:Literal ID="ltrDescription" runat="server" Text="<%$ Resources: Tags, tagDescription%>" />
                                        </div>
                                        <br/>
                                        <table cellspacing="0" cellpadding="0" border="0" width="100%">
                                            <tr>
                                                <td valign="top" style="border-bottom: #c0c0c0 1px solid; border-top: #c0c0c0 1px solid; padding-left: 4px; 
                                                    padding-right: 4px; border-left-width: 1px; border-left-color: #c0c0c0;">
                                                    <p>
                                                        <span class="SegmentSubTitle"><asp:Literal ID="Literal1" runat="server" Text="<%$ Resources: Tags, tagTittleSeccion1%>" /></span>
                                                        <br/>&nbsp;&nbsp;<br/>
                                                        <asp:Literal ID="Literal2" runat="server" Text="<%$ Resources: Tags, tagDescriptionSeccion1%>" />
                                                        <br/><br/>
                                                    </p>
                                                </td> <%-- Fin TD Descripción Información Personal --%> 
                                                <td width="580" valign="top" style="border-bottom: #c0c0c0 1px solid; padding-right: 4px; border-top: #c0c0c0 1px solid;
                                                    padding-left: 4px; padding-bottom: 4px; padding-top: 4px; background-color: #f2f2f2;">
                                                    <table cellspacing="0" cellpadding="2" border="0" style="width: 100%;">
                                                        <tr> <%-- Inicio TR Tag/Validador Nombres --%>
                                                            <td width="25%"> <%-- Inicio TD Tag/Validador Primer Nombre --%>
                                                                <asp:Label ID="tagFirstName" runat="server" Text="<%$ Resources: Tags, tagFirstName %>"></asp:Label>
                                                                <asp:RequiredFieldValidator ID="rfvFirstName" runat="server" 
                                                                    ControlToValidate="txtFirstName" 
                                                                    ErrorMessage="<%$ Resources: Validators, rfvFirstName %>" 
                                                                    SetFocusOnError="True" ForeColor="Red" >*
                                                                </asp:RequiredFieldValidator>
                                                            </td> <%-- Fin TD Tag/Validador Primer Nombre --%>
                                                            <td width="25%"> <%-- Inicio TD Tag/Validador Segundo Nombre --%>
                                                                <asp:Label ID="tagSecondName" runat="server" Text="<%$ Resources: Tags, tagMiddleName %>"></asp:Label>
                                                            </td> <%-- Fin TD Tag/Validador Segundo Nombre --%>
                                                            <td width="25%"> <%-- Inicio TD Tag/Validador Primer Apellido --%>
                                                                <asp:Label ID="tagFirstSurname" runat="server" Text="<%$ Resources: Tags, tagFirstSurname %>"></asp:Label>
                                                                <asp:RequiredFieldValidator ID="rfvFirstSurname" runat="server" 
                                                                    ControlToValidate="txtFirstSurname" 
                                                                    ErrorMessage="<%$ Resources: Validators, rfvFirstSurname %>" 
                                                                    SetFocusOnError="True" ForeColor="Red" >*
                                                                </asp:RequiredFieldValidator>
                                                            </td> <%-- Fin TD Tag/Validador Primer Apellido --%>
                                                            <td width="25%"> <%-- Inicio TD Tag/Validador Segundo Apellido --%>
                                                                <asp:Label ID="tagMiddleSurname" runat="server" Text="<%$ Resources: Tags, tagMiddleSurname %>"></asp:Label>
                                                            </td> <%-- Fin TD Tag/Validador Segundo Apellido --%>
                                                        </tr> <%-- Fin TR Tag/Validador Nombres --%>
                                                        <tr> <%-- Inicio TR TextBox Nombres --%>
                                                            <td  width="25%">
                                                                <asp:TextBox ID="txtFirstName" runat="server" Height="16px" Width="135px"></asp:TextBox>
                                                            </td> <%-- Fin TD TextBox Primer Nombre --%>
                                                            <td  width="25%">
                                                                <asp:TextBox ID="txtMiddleName" runat="server" Height="16px" Width="135px"></asp:TextBox>
                                                            </td> <%-- Fin TD TextBox Segundo Nombre --%>
                                                            <td  width="25%">
                                                                <asp:TextBox ID="txtFirstSurname" runat="server" Height="16" Width="135px"></asp:TextBox>
                                                            </td> <%-- Fin TD TextBox Primer Apellido --%>
                                                            <td width="25%">
                                                                <asp:TextBox ID="txtMiddleSurname" runat="server" Height="16" Width="135px"></asp:TextBox>
                                                            </td> <%-- Fin TD TextBox Segundo Apellido --%>
                                                        </tr> <%-- Fin TR TextBox Nombres --%>
                                                        <tr>
                                                            <td colspan="2">
                                                                <asp:Label ID="tagGender" runat="server" Text="<%$ Resources: Tags, tagGender %>"></asp:Label>
                                                                <asp:RequiredFieldValidator ID="rfvGender" runat="server" 
                                                                    ControlToValidate="dropGender" 
                                                                    InitialValue ="Seleccione..."
                                                                    ErrorMessage="<%$ Resources: Validators, rfvGender %>" 
                                                                    SetFocusOnError="True" ForeColor="Red" >*
                                                                </asp:RequiredFieldValidator>
                                                            </td> <%-- Fin TD Tag/Validador Género --%>
                                                            <td colspan="2">
                                                                <asp:Label ID="tagMaritalStatusType" runat="server" Text="<%$ Resources: Tags, tagMaritalStatusType %>"></asp:Label>       
                                                                <asp:RequiredFieldValidator ID="rfvMaritalStatusType" runat="server" 
                                                                    ControlToValidate="dropMaritalStatusType" 
                                                                    InitialValue ="Seleccione..."
                                                                    ErrorMessage="<%$ Resources: Validators, rfvMaritalStatusType %>" 
                                                                    SetFocusOnError="True" ForeColor="Red" >*
                                                                </asp:RequiredFieldValidator>
                                                            </td> <%-- Fin TD Tag/Validador Estado Civíl --%>
                                                        </tr> <%-- Fin TR Tag/Validador Género-Estado Civíl --%>
                                                        <tr>
                                                            <td colspan="2">
                                                                <telerik:RadComboBox ID="dropGender" Runat="server" Width="280" AutoPostBack="False" CausesValidation="False"></telerik:RadComboBox>
                                                            </td> <%-- Fin TD TextBox Género --%>
                                                            <td colspan="2">
                                                                <telerik:RadComboBox ID="dropMaritalStatusType" Width="280" runat="server" AutoPostBack="False" CausesValidation="False"></telerik:RadComboBox>    
                                                            </td> <%-- Fin TD TextBox Estado Civíl --%>
                                                        </tr> <%-- Fin TR TextBox Género-Estado Civíl --%>
                                                        <tr>
                                                            <td  width="25%">
                                                                <asp:Label ID="tagBirthDate" runat="server" Text="<%$ Resources: Tags, tagBirthDate %>"></asp:Label>       
                                                                <asp:RequiredFieldValidator ID="rfvBirthDate" runat="server" 
                                                                    ControlToValidate="txtBirthDate" 
                                                                    ErrorMessage="<%$ Resources: Validators, rfvBirthDate %>" 
                                                                    SetFocusOnError="True" ForeColor="Red" >*
                                                                </asp:RequiredFieldValidator>
                                                            </td> <%-- Fin TD Tag/Validador Fecha Nacimiento --%>
                                                            <td  width="25%">
                                                                <asp:Label ID="tagPlaceBirthCountry" runat="server" Text="<%$ Resources: Tags, tagPlaceBirthCountry %>"></asp:Label>
                                                                <asp:RequiredFieldValidator ID="rfvPlaceBirthCountry" runat="server" 
                                                                    ControlToValidate="dropPlaceBirthCountry" 
                                                                    InitialValue ="Seleccione..."
                                                                    ErrorMessage="<%$ Resources: Validators, rfvPlaceBirthCountry %>" 
                                                                    SetFocusOnError="True" ForeColor="Red" >*
                                                                </asp:RequiredFieldValidator>
                                                            </td> <%-- Fin TD Tag/Validador País Nacimiento --%>
                                                            <td  width="25%">
                                                                <asp:Label ID="tagPlaceBirthRegion" runat="server" Text="<%$ Resources: Tags, tagPlaceBirthRegion %>"></asp:Label>
                                                                <asp:RequiredFieldValidator ID="rfvPlaceBirthRegion" runat="server" 
                                                                    ControlToValidate="dropPlaceBirthRegion" 
                                                                    InitialValue ="Seleccione..."
                                                                    ErrorMessage="<%$ Resources: Validators, rfvPlaceBirthRegion %>" 
                                                                    SetFocusOnError="True" ForeColor="Red" >*
                                                                </asp:RequiredFieldValidator>
                                                            </td> <%-- Fin TD Tag/Validador Departamento Nacimiento --%>
                                                            <td width="25%">
                                                                <asp:Label ID="tagBirthCity" runat="server" Text="<%$ Resources: Tags, tagPlaceBirth %>"></asp:Label>       
                                                                <asp:RequiredFieldValidator ID="rfvPlaceBirth" runat="server" 
                                                                    ControlToValidate="dropPlaceBirth" 
                                                                    InitialValue ="Seleccione..."
                                                                    ErrorMessage="<%$ Resources: Validators, rfvPlaceBirth %>" 
                                                                    SetFocusOnError="True" ForeColor="Red" >*
                                                                </asp:RequiredFieldValidator>
                                                            </td> <%-- Fin TD Tag/Validador Ciudad Nacimiento --%>
                                                        </tr> <%-- Fin TR Tag/Validador Información Nacimiento --%>
                                                        <tr>
                                                            <td width="25%">
                                                                <telerik:RadDatePicker ID="txtBirthDate" runat="server" MinDate="01/01/1900" Width="135px">
                                                                </telerik:RadDatePicker>
                                                            </td> <%-- Fin TD TextBox Fecha Nacimiento --%>
                                                            <td width="25%">
                                                                <telerik:RadComboBox ID="dropPlaceBirthCountry" runat="server" AutoPostBack="True" CausesValidation="False" Width="135px">
                                                                </telerik:RadComboBox>       
                                                            </td> <%-- Fin TD TextBox País Nacimiento --%>
                                                            <td  width="25%">
                                                                <telerik:RadComboBox ID="dropPlaceBirthRegion" runat="server" AutoPostBack="True" CausesValidation="False" Width="135px">
                                                                </telerik:RadComboBox>       
                                                            </td> <%-- Fin TD TextBox Departamento Nacimiento --%>
                                                            <td width="25%">
                                                                <telerik:RadComboBox ID="dropPlaceBirth" runat="server" AutoPostBack="False" CausesValidation="False" Width="135px">
                                                                </telerik:RadComboBox>
                                                            </td><%-- Fin TD TextBox Ciudad Nacimiento --%>
                                                        </tr> <%-- Fin TR TextBox Información Nacimiento --%>
                                                        <tr>
                                                            <td colspan="2">
                                                                <asp:Label ID="tagIdentificationDocumentType" runat="server" Text="<%$ Resources: Tags, tagIdentificationDocumentType %>"></asp:Label>
                                                                <asp:RequiredFieldValidator ID="rfvIdentificationDocumentType" runat="server" 
                                                                    ControlToValidate="dropIdentificationDocumentType" 
                                                                    InitialValue ="Seleccione..."
                                                                    ErrorMessage="<%$ Resources: Validators, rfvIdentificationDocumentType %>" 
                                                                    SetFocusOnError="True" ForeColor="Red" >*
                                                                </asp:RequiredFieldValidator>
                                                            </td> <%-- Fin TD Tag/Validador Tipo Documento Identidad --%>
                                                            <td colspan="2">
                                                                <asp:Label ID="tagIdentification" runat="server" Text="<%$ Resources: Tags, tagIdentification %>"></asp:Label>
                                                                <asp:RequiredFieldValidator ID="rfvIdentification" runat="server" 
                                                                    ControlToValidate="txtIdentification" 
                                                                    ErrorMessage="<%$ Resources: Validators, rfvIdentification %>" 
                                                                    SetFocusOnError="True" ForeColor="Red" >*
                                                                </asp:RequiredFieldValidator>
                                                            </td> <%-- Fin TD Tag/Validador Número Documento Identidad --%>
                                                        </tr> <%-- Fin TR Tag/Validador Documento Identidad --%>
                                                        <tr>
                                                            <td colspan="2">
                                                                <telerik:RadComboBox ID="dropIdentificationDocumentType" runat="server" Width="280px" AutoPostBack="False" CausesValidation="False">
                                                                </telerik:RadComboBox>
                                                            </td> <%-- Fin TD TextBox Tipo Documento Identidad --%>
                                                            <td colspan="2">
                                                                <asp:TextBox ID="txtIdentification" runat="server" Width="280px" Height="16px"></asp:TextBox>    
                                                            </td> <%-- Fin TD TextBox Número Documento Identidad --%>
                                                        </tr> <%-- Fin TR TextBox Documento Identidad --%>
                                                        <tr>
                                                            <td  width="25%">
                                                                <asp:Label ID="tagExpeditionDate" runat="server" Text="<%$ Resources: Tags, tagExpeditionDate %>"></asp:Label>       
                                                                <asp:RequiredFieldValidator ID="rfvExpeditionDate" runat="server" 
                                                                    ControlToValidate="txtExpeditionDate" 
                                                                    ErrorMessage="<%$ Resources: Validators, rfvExpeditionDate %>" 
                                                                    SetFocusOnError="True" ForeColor="Red" >*
                                                                </asp:RequiredFieldValidator>
                                                            </td> <%-- Fin TD Tag/Validador Fecha Expedición Documento Identidad --%>
                                                            <td  width="25%">
                                                                <asp:Label ID="tagIdentificationIssuedLocationCountry" runat="server" Text="<%$ Resources: Tags, tagIdentificationIssuedLocationCountry %>"></asp:Label>
                                                                <asp:RequiredFieldValidator ID="rfvIdentificationIssuedLocationCountry" runat="server" 
                                                                    ControlToValidate="dropIdentificationIssuedLocationCountry" 
                                                                    InitialValue ="Seleccione..."
                                                                    ErrorMessage="<%$ Resources: Validators, rfvIdentificationIssuedLocationCountry %>" 
                                                                    SetFocusOnError="True" ForeColor="Red" >*
                                                                </asp:RequiredFieldValidator>
                                                            </td> <%-- Fin TD Tag/Validador País Expedición Documento Identidad --%>
                                                            <td  width="25%">
                                                                <asp:Label ID="tagIdentificationIssuedLocationRegion" runat="server" Text="<%$ Resources: Tags, tagIdentificationIssuedLocationRegion %>"></asp:Label>
                                                                <asp:RequiredFieldValidator ID="rfvIdentificationIssuedLocationRegion" runat="server" 
                                                                    ControlToValidate="dropIdentificationIssuedLocationRegion" 
                                                                    InitialValue ="Seleccione..."
                                                                    ErrorMessage="<%$ Resources: Validators, rfvIdentificationIssuedLocationRegion %>" 
                                                                    SetFocusOnError="True" ForeColor="Red" >*
                                                                </asp:RequiredFieldValidator>
                                                            </td> <%-- Fin TD Tag/Validador Departamento Expedición Documento Identidad --%>
                                                            <td  width="25%">
                                                                <asp:Label ID="tagIdentificationIssuedLocation" runat="server" Text="<%$ Resources: Tags, tagIdentificationIssuedLocation %>"></asp:Label>       
                                                                <asp:RequiredFieldValidator ID="rfvIdentificationIssuedLocation" runat="server" 
                                                                    ControlToValidate="dropIdentificationIssuedLocation" 
                                                                    InitialValue ="Seleccione..."
                                                                    ErrorMessage="<%$ Resources: Validators, rfvIdentificationIssuedLocation %>" 
                                                                    SetFocusOnError="True" ForeColor="Red" >*
                                                                </asp:RequiredFieldValidator>
                                                            </td> <%-- Fin TD Tag/Validador Ciudad Expedición Documento Identidad --%>
                                                        </tr> <%-- Fin TR Tag/Validador Información Documento --%>
                                                        <tr>
                                                            <td  width="25%">
                                                                <telerik:RadDatePicker ID="txtExpeditionDate" runat="server" MinDate="01/01/1900" Width="135px">
                                                                </telerik:RadDatePicker>
                                                            </td> <%-- Fin TD TextBox Fecha Expedición Documento Identidad --%>
                                                            <td  width="25%">
                                                                <telerik:RadComboBox ID="dropIdentificationIssuedLocationCountry" runat="server" AutoPostBack="True" CausesValidation="False" Width="135px"></telerik:RadComboBox>       
                                                            </td> <%-- Fin TD TextBox País Expedición Documento Identidad --%>
                                                            <td  width="25%">
                                                                <telerik:RadComboBox ID="dropIdentificationIssuedLocationRegion" runat="server" AutoPostBack="True" CausesValidation="False" Width="135px"></telerik:RadComboBox>       
                                                            </td> <%-- Fin TD TextBox Departamento Expedición Documento Identidad --%>
                                                            <td  width="25%">
                                                                <telerik:RadComboBox ID="dropIdentificationIssuedLocation" runat="server" AutoPostBack="False" CausesValidation="False" Width="135px"></telerik:RadComboBox>
                                                            </td> <%-- Fin TD TextBox Ciudad Expedición Documento Identidad --%>
                                                        </tr> <%-- Fin TR TextBox Información Documento --%>
                                                    </table> <%-- Tabla Campos Información Personal --%>
                                                </td> <%-- Fin TD Campos Información Personal --%>
                                            </tr> <%-- Fin TR Sección Información Personal --%>
                                            <tr>
                                                <td valign="top" style="border-bottom: #c0c0c0 1px solid; padding-left: 4px; padding-right: 4px; border-left-width: 1px; border-left-color: #c0c0c0;">
                                                    <p>
                                                        <span class="SegmentSubTitle"><asp:Literal ID="Literal3" runat="server" Text="<%$ Resources: Tags, tagTittleSeccion2%>" /></span>
                                                        <br/>&nbsp;&nbsp;<br/>
                                                        <asp:Literal ID="Literal4" runat="server" Text="<%$ Resources: Tags, tagDescriptionSeccion2%>" />
                                                        <br/><br/>
                                                    </p>
                                                </td> <%-- Fin TD que contiene la Descripción de la Información de Contacto --%>
                                                <td width="580" valign="top" style="border-bottom: #c0c0c0 1px solid; padding-right: 4px; padding-left: 4px; padding-bottom: 4px; padding-top: 4px; background-color: #f2f2f2;">
                                                    <table cellspacing="0" cellpadding="2" border="0" style="width: 100%;">
                                                    <tr>
                                                        <td >
                                                            <asp:Label ID="tagProfession" runat="server" Text="<%$ Resources: Tags, tagProfession %>"></asp:Label>       
                                                            <asp:RequiredFieldValidator ID="rfvProfession" runat="server" 
                                                                ControlToValidate="txtProfession" 
                                                                ErrorMessage="<%$ Resources: Validators, rfvProfession %>" 
                                                                SetFocusOnError="True" ForeColor="Red" >*
                                                            </asp:RequiredFieldValidator>
                                                        </td>
                                                        <td >
                                                            <asp:Label ID="tagOccupation" runat="server" Text="<%$ Resources: Tags, tagOccupation %>"></asp:Label>
                                                            <asp:RequiredFieldValidator ID="rfvOccupation" runat="server" 
                                                                ControlToValidate="txtOccupation" 
                                                                ErrorMessage="<%$ Resources: Validators, rfvOccupation %>" 
                                                                SetFocusOnError="True" ForeColor="Red" >*
                                                            </asp:RequiredFieldValidator>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <asp:TextBox ID="txtProfession" runat="server" Width="280px" Height="16px"></asp:TextBox>
                                                        </td>
                                                        <td >
                                                            <asp:TextBox ID="txtOccupation" runat="server" Width="280px" Height="16px"></asp:TextBox>    
                                                        </td>
                                                    </tr>
                                                    <tr >
                                                        <td colspan="2">
                                                            <asp:Label ID="tagResidenceAddress" runat="server" Text="<%$ Resources: Tags, tagResidenceAddress %>"></asp:Label>       
                                                            <asp:RequiredFieldValidator ID="rfvResidenceAddress" runat="server" 
                                                                ControlToValidate="txtResidenceAddress" 
                                                                ErrorMessage="<%$ Resources: Validators, rfvResidenceAddress %>" 
                                                                SetFocusOnError="True" ForeColor="Red" >*
                                                            </asp:RequiredFieldValidator>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="2">
                                                            <asp:TextBox ID="txtResidenceAddress" runat="server" Width="570px" Height="16px"></asp:TextBox>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                            <td colspan="2">
                                                            <div style="display:inline-block;width:185px;">
                                                                <asp:Label ID="tagResidencePlaceCountry" runat="server" Text="<%$ Resources: Tags, tagResidencePlaceCountry %>"></asp:Label>
                                                                <asp:RequiredFieldValidator ID="rfvResidencePlaceCountry" runat="server" 
                                                                    ControlToValidate="dropResidencePlaceCountry" 
                                                                    InitialValue ="Seleccione..."
                                                                    ErrorMessage="<%$ Resources: Validators, rfvResidencePlaceCountry %>" 
                                                                    SetFocusOnError="True" ForeColor="Red" >*
                                                                </asp:RequiredFieldValidator>
                                                            </div>
                                                            <div style="display:inline-block;width:185px;">
                                                                <asp:Label ID="tagResidencePlaceRegion" runat="server" Text="<%$ Resources: Tags, tagResidencePlaceRegion %>"></asp:Label>
                                                                <asp:RequiredFieldValidator ID="rfvResidencePlaceRegion" runat="server" 
                                                                    ControlToValidate="dropResidencePlaceRegion" 
                                                                    InitialValue ="Seleccione..."
                                                                    ErrorMessage="<%$ Resources: Validators, rfvResidencePlaceRegion %>" 
                                                                    SetFocusOnError="True" ForeColor="Red" >*
                                                                </asp:RequiredFieldValidator>
                                                            </div>
                                                            <div style="display:inline-block;width:185px;">
                                                                <asp:Label ID="tagResidencePlace" runat="server" Text="<%$ Resources: Tags, tagResidencePlace %>"></asp:Label>       
                                                                <asp:RequiredFieldValidator ID="rfvResidencePlace" runat="server" 
                                                                    ControlToValidate="dropResidencePlace" 
                                                                    InitialValue ="Seleccione..."
                                                                    ErrorMessage="<%$ Resources: Validators, rfvResidencePlace %>" 
                                                                    SetFocusOnError="True" ForeColor="Red" >*
                                                                </asp:RequiredFieldValidator>
                                                            </div>
                                                            </td>
                                                     </tr>
                                                    <tr>
                                                        <td colspan="2">
                                                        <div style="display:inline-block;width:185px;">
                                                            <telerik:RadComboBox ID="dropResidencePlaceCountry" runat="server" AutoPostBack="True" CausesValidation="False" Width="175px"></telerik:RadComboBox>       
                                                        </div>
                                                        <div style="display:inline-block;width:185px;">
                                                            <telerik:RadComboBox ID="dropResidencePlaceRegion" runat="server" AutoPostBack="True" CausesValidation="False" Width="175px" style="margin-left: 0px"></telerik:RadComboBox>       
                                                        </div>
                                                        <div style="display:inline-block;width:185px;">
                                                            <telerik:RadComboBox ID="dropResidencePlace" runat="server" AutoPostBack="False" CausesValidation="False" Width="175px"></telerik:RadComboBox>
                                                        </div>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td >
                                                            <asp:Label ID="tagPhoneNumber" runat="server" Text="<%$ Resources: Tags, tagPhoneNumber %>"></asp:Label>       
                                                            <asp:RequiredFieldValidator ID="rfvPhoneNumber" runat="server" 
                                                                ControlToValidate="txtPhoneNumber" 
                                                                ErrorMessage="<%$ Resources: Validators, rfvPhoneNumber %>" 
                                                                SetFocusOnError="True" ForeColor="Red" >*
                                                            </asp:RequiredFieldValidator>
                                                            <asp:RegularExpressionValidator ID="revPhoneNumber" runat="server" 
                                                                ErrorMessage="<%$ Resources: Validators, revPhoneNumber %>" 
                                                                ValidationExpression="\d+" 
                                                                ControlToValidate="txtPhoneNumber" Display="Dynamic" ForeColor="Red">*
                                                            </asp:RegularExpressionValidator>                                                        </td>
                                                        <td >
                                                            <asp:Label ID="tagAreaPhoneNumber" runat="server" Text="<%$ Resources: Tags, tagAreaPhoneNumber %>"></asp:Label>
                                                            <asp:RequiredFieldValidator ID="rfvAreaPhoneNumber" runat="server" 
                                                                ControlToValidate="txtAreaPhoneNumber" 
                                                                ErrorMessage="<%$ Resources: Validators, rfvAreaPhoneNumber %>" 
                                                                SetFocusOnError="True" ForeColor="Red" >*
                                                            </asp:RequiredFieldValidator>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <asp:TextBox ID="txtPhoneNumber" runat="server" Width="280px" Height="16px"></asp:TextBox>
                                                        </td>
                                                        <td >
                                                            <asp:TextBox ID="txtAreaPhoneNumber" runat="server" Width="280px" Height="16px"></asp:TextBox>    
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td >
                                                            <asp:Label ID="tagCellPhoneNumber" runat="server" Text="<%$ Resources: Tags, tagCellPhoneNumber %>"></asp:Label>       
                                                            <asp:RequiredFieldValidator ID="rfvCellPhoneNumber" runat="server" 
                                                                ControlToValidate="txtCellPhoneNumber" 
                                                                ErrorMessage="<%$ Resources: Validators, rfvCellPhoneNumber %>" 
                                                                SetFocusOnError="True" ForeColor="Red" >*
                                                            </asp:RequiredFieldValidator>
                                                        </td>
                                                        <td >
                                                            <asp:Label ID="tagCellPhoneNumberAlternative" runat="server" Text="<%$ Resources: Tags, tagCellPhoneNumberAlternative %>"></asp:Label>
<%--                                                            <asp:RequiredFieldValidator ID="rfvCellPhoneNumberAlternative" runat="server" 
                                                                ControlToValidate="txtCellPhoneNumberAlternative" 
                                                                ErrorMessage="<%$ Resources: Validators, rfvCellPhoneNumberAlternative %>" 
                                                                SetFocusOnError="True" ForeColor="Red" >*
                                                            </asp:RequiredFieldValidator>--%>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <asp:TextBox ID="txtCellPhoneNumber" runat="server" Width="280px" Height="16px"></asp:TextBox>
                                                        </td>
                                                        <td >
                                                            <asp:TextBox ID="txtCellPhoneNumberAlternative" runat="server" Width="280px" Height="16px"></asp:TextBox>    
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td >
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
                                                        <td >
                                                            <asp:Label ID="tagEmail2" runat="server" Text="<%$ Resources: Tags, tagEmail2 %>"></asp:Label>
                                                             <asp:RegularExpressionValidator ID="revEmail2" runat="server" 
                                                                ErrorMessage="<%$ Resources: Validators, rfvEmail2 %>" 
                                                                ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                                                                ControlToValidate="txtEmail" Display="Dynamic" ForeColor="Red">*
                                                            </asp:RegularExpressionValidator>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td >
                                                            <asp:TextBox ID="txtEmail" runat="server" Width="280px" Height="16px"></asp:TextBox>    
                                                        </td>
                                                        <td >
                                                            <asp:TextBox ID="txtEmail2" runat="server" Width="280px" Height="16px"></asp:TextBox>    
                                                        </td>
                                                    </tr>
                                                    <tr >
                                                        <td colspan="2">
                                                            <asp:Label ID="tagWbeSite" runat="server" Text="<%$ Resources: Tags, tagWebSite %>"></asp:Label>       
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="2">
                                                            <asp:TextBox ID="txtWebSite" runat="server" Width="570px" Height="16px"></asp:TextBox>
                                                        </td>
                                                    </tr>
                                                    <tr >
                                                        <td colspan="2">
                                                            <br /><asp:Literal ID="Literal10" runat="server" Text="<%$ Resources: Tags, tagConditions%>" />
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="2" align="right">
                                                            <asp:Button ID="btnOk" Text="<%$ Resources: Buttons, btnSave %>" runat="server" Width="120" CausesValidation="True" />
                                                            <asp:Button ID="btnCancel" Text="<%$ Resources: Buttons, btnCancel %>" runat="server" Width="120" CausesValidation="False" />
                                                        </td>
                                                    </tr>
                                                    </table> <%-- Fin Tabla Información de Contacto --%>
                                                </td> <%-- Fin TD que contiene la Tabla Información de Contacto --%>
                                            </tr> <%-- Fin TR que contiene la Información de Contacto --%>
                                        </table>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </td>
        </tr> <%-- Fin TR Cuerpo Página --%>
        <tr>
            <td height="10" style="padding-top: 10px">
                <table cellspacing="0" cellpadding="0" border="0" style="width: 100%">
                    <tr>
                        <td align="right" width="111" style="border-right: solid 1px #999999; padding-right: 5px;">
                        <a target="_blank" href="http://www.udes.edu.co" id="ctl00_uxPageFooter_lnkUDES"><img style="border-width:0px;" alt="" src="/_Resources/Images/LogoUDES.jpg" /></a>
                        </td> <%-- Fin TD Logo Pie de Página --%>
                        <td class="PageFooter" style="padding-left: 5px; font-family: Arial; font-size: 10px;">
                            Mapa del Sitio | <a target="_blank" href="http://www.cvudes.edu.co/Privacidad.aspx">Política de Privacidad
                            y Seguridad</a> | <a target="_blank" href="http://www.cvudes.edu.co/Contactenos.aspx">Contáctenos</a> | <a target="_blank" href="http://www.cvudes.edu.co/Accesibilidad.aspx">
                            Accesibilidad</a><br />
                            El uso de este Sitio Web implica estar de acuerdo con los <a target="_blank" href="http://www.cvudes.edu.co//Terminos.aspx">Términos
                            y Condiciones de Uso</a>.<br />
                            &copy; 2012 Campus Virtual UDES. Todos los derechos reservados.
                        </td> <%-- Fin TD Información Pie de Página --%>
                    </tr> <%-- Fin TR Pie de Página --%>
                </table> <%-- Fin Tabla Pie de Página --%>
            </td> <%-- Fin TD Pie de Página --%>
        </tr> <%-- Fin TR Píe de Página --%>
    </table> <%-- Fin Tabla principal --%>
    <%--<asp:Panel ID="pnlAjax" runat="server">
            <uc:ActionMessage ID="ActionMessage1" runat="server" />
        </asp:Panel> --%>
    </div> <%-- Fin Div Principal --%>
    <asp:ValidationSummary ID="vsmform" runat="server" ShowMessageBox="True" ShowSummary="False" Width="100%" />
    <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server" EnablePageHeadUpdate="False" RequestQueueSize="1" UpdatePanelsRenderMode="Inline" ></telerik:RadAjaxManager>
    <telerik:RadAjaxManagerProxy ID="RadAjaxManagerProxy1" runat="server">
        <AjaxSettings>
            <telerik:AjaxSetting AjaxControlID="dropPlaceBirthCountry"><UpdatedControls><telerik:AjaxUpdatedControl ControlID="dropPlaceBirthRegion" /></UpdatedControls></telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="dropPlaceBirthRegion"><UpdatedControls><telerik:AjaxUpdatedControl ControlID="dropPlaceBirth" /></UpdatedControls></telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="dropIdentificationIssuedLocationCountry"><UpdatedControls><telerik:AjaxUpdatedControl ControlID="dropIdentificationIssuedLocationRegion" /></UpdatedControls></telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="dropIdentificationIssuedLocationRegion"><UpdatedControls><telerik:AjaxUpdatedControl ControlID="dropIdentificationIssuedLocation" /></UpdatedControls></telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="dropResidencePlaceCountry"><UpdatedControls><telerik:AjaxUpdatedControl ControlID="dropResidencePlaceRegion" /></UpdatedControls></telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="dropResidencePlaceRegion"><UpdatedControls><telerik:AjaxUpdatedControl ControlID="dropResidencePlace" /></UpdatedControls></telerik:AjaxSetting>
        </AjaxSettings>
    </telerik:RadAjaxManagerProxy>
    </form>
</body>
</html>
