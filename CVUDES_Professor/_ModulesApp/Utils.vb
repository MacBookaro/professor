Imports System.Configuration
Imports System.Text
Imports System.ComponentModel
Imports System.Web.HttpContext
Imports Telerik.Web.UI
Imports System.Net.Mail

Module UtilsModule

    Public Function Truncate(ByVal Length As Integer, ByVal Value As String) As String
        If Value.Length > Length Then
            Return Value.Substring(0, Length) & "..."
        Else
            Return Value
        End If
    End Function

    Public Function ToGuid(ByVal Value As String) As Guid
        Return TypeDescriptor.GetConverter(GetType(Guid)).ConvertFrom(Value)
    End Function

    Public Function GetIndexByValue(ByVal Drop As RadComboBox, ByVal Value As String) As Integer
        Return Drop.Items.IndexOf(Drop.Items.FindItemByValue(Value))
    End Function

    Public Function GetIndexByValue(ByVal Drop As RadComboBox, ByVal Value As String, ByVal Text As String) As Integer
        Dim intIndex As Integer = -1
        intIndex = Drop.Items.IndexOf(Drop.Items.FindItemByValue(Value))
        If Not intIndex >= 0 Then
            Drop.Items.Insert(0, New RadComboBoxItem(Text, Value))
            intIndex = 0
        End If
        Return intIndex
    End Function

    Public Function GetIndexByBool(ByVal Drop As RadComboBox, ByVal Value As Boolean) As Integer
        If Value Then
            Return Drop.Items.IndexOf(Drop.Items.FindItemByValue("1"))
        Else
            Return Drop.Items.IndexOf(Drop.Items.FindItemByValue("0"))
        End If
    End Function

    Public Function GetIndexByText(ByVal Drop As RadComboBox, ByVal Value As String) As Integer
        Return Drop.Items.IndexOf(Drop.Items.FindItemByText(Value))
    End Function

    Public Function GetCheckedListItems(ByVal objCheckList As CheckBoxList) As String
        Dim itemList As String = String.Empty
        For Each item As ListItem In objCheckList.Items
            If item.Selected = True Then itemList = itemList + item.Value + ","
        Next
        If itemList <> String.Empty Then itemList = itemList.Remove(Len(itemList) - 1, 1)
        Return itemList
    End Function

    Public Sub SetCheckedListItems(ByVal objCheckList As CheckBoxList, ByVal LockedIds As String, ByVal SelectedIds As String)
        For Each item As ListItem In objCheckList.Items
            If LockedIds.IndexOf(item.Value) >= 0 Then item.Enabled = False
            If SelectedIds.IndexOf(item.Value) >= 0 Then item.Selected = True
        Next
    End Sub

    Public Sub SetRowAttributes(ByVal Row As System.Web.UI.WebControls.GridViewRow)
        Row.Attributes.Add("onmousemove", "this.style.backgroundColor='#FFFFC2'")
        Row.Attributes.Add("onmouseout", "this.style.backgroundColor='#FFFFFF'")
    End Sub

    Public Function GetFilterNumericValue(ByVal Param As String, ByVal MaxValue As Integer, ByVal DefaultValue As Integer) As Integer
        Dim intResult As Integer = 0
        If Param <> String.Empty Then
            If IsNumeric(Param) Then
                Select Case CInt(Param)
                    Case Is >= 0
                        intResult = CInt(Param)
                    Case Else
                        intResult = DefaultValue
                End Select
            End If
            If MaxValue > 0 Then
                If intResult > MaxValue Then intResult = DefaultValue
            End If
        Else
            intResult = DefaultValue
        End If
        Return intResult
    End Function

    Public Function GetFilterGUIDValue(ByVal Param As String, ByVal DefaultValue As String) As String
        Dim strResult As String = "0"
        If Param <> String.Empty Then
            strResult = Param
        Else
            strResult = DefaultValue
        End If
        Return strResult
    End Function

    Public Function GetFilterBooleanValue(ByVal Param As String, ByVal DefaultValue As Integer) As Integer
        Dim intResult As Integer = 0
        If Param <> String.Empty Then
            If Param = "1" Then
                intResult = 1
            Else
                intResult = 0
            End If
        Else
            intResult = DefaultValue
        End If
        Return intResult
    End Function

    Public Function GetFilterCharValue(ByVal Param As String, ByVal DefaultValue As String) As String
        Dim strResult As String = "0"
        If Param <> String.Empty Then
            Dim arrParams() As String = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"}
            If Array.BinarySearch(arrParams, Param) >= 0 Then
                strResult = Param
            Else
                If Param = "1" Then
                    strResult = "1"
                Else
                    strResult = "0"
                End If
            End If
        Else
            strResult = DefaultValue
        End If
        Return strResult
    End Function

    Public Function GetFilterCharWhereValue(ByVal Param As String, ByVal DefaultValue As String) As String
        Dim strResult As String = "0"

        strResult = GetFilterCharValue(Param, DefaultValue)
        If Param = "1" Then
            strResult = "[^A-Z]"
        End If
        Return strResult
    End Function

    Public Function FormatTraceInfo(ByVal Type As Integer, ByVal Description As String) As String
        Dim strResult As String = String.Empty
        Select Case Type
            Case 1
                strResult = FormatTraceInfo_Insert(Description)
            Case 2
                strResult = FormatTraceInfo_Update(Description)
            Case 3
                strResult = FormatTraceInfo_Delete(Description)
            Case Else
                strResult = Description
        End Select

        Return strResult
    End Function

    Private Function FormatTraceInfo_Insert(ByVal Description As String) As String
        Dim strResult As String = String.Empty
        Dim strRecords() As String = Description.Split(vbNewLine)
        Dim intRecords As Integer = 0
        Dim strParams() As String

        If strRecords.Length = 1 Then intRecords = 1 Else intRecords = strRecords.Length - 1
        strResult = strResult & "<table cellspacing=""0"" cellpadding=""0"" width=""100%"" border=""0"" class=""TableTraceInsert"">"
        strResult = strResult & "<tr><th>" & GetGlobalResourceObject("Tags", "tagField") & "</th><th>" & GetGlobalResourceObject("Tags", "tagFieldValue") & "</th></tr>"
        If strRecords.Length > 0 Then
            For i As Integer = 0 To intRecords - 1
                strRecords(i) = strRecords(i).Replace("<!:>", vbNewLine)
                strParams = strRecords(i).Split(vbNewLine)
                Select Case strParams.Length
                    Case 0
                        strResult = strResult & "<tr><td class=""Field"">" & "&nbsp;" & "</td><td class=""FieldValue"">" & strRecords(i) & "</td></tr>"
                    Case 1
                        strResult = strResult & "<tr><td class=""Field"">" & "&nbsp;" & "</td><td class=""FieldValue"">" & strParams(0) & "</td></tr>"
                    Case 2
                        strResult = strResult & "<tr><td class=""Field"">" & strParams(0) & ":</td><td class=""FieldValue"">" & strParams(1) & "</td></tr>"
                End Select
            Next
        Else
            strResult = strResult & "<tr><td>" & Description & "</td></tr>"
        End If
        strResult = strResult & "</table>"
        Return strResult
    End Function

    Private Function FormatTraceInfo_Update(ByVal Description As String) As String
        Dim strResult As String = String.Empty
        Dim strRecords() As String = Description.Split(vbNewLine)
        Dim intRecords As Integer = 0
        Dim strParams() As String

        If strRecords.Length = 1 Then intRecords = 1 Else intRecords = strRecords.Length - 1
        strResult = strResult & "<table cellspacing=""0"" cellpadding=""0"" width=""100%"" border=""0"" class=""TableTraceUpdate"">"
        strResult = strResult & "<tr><th>" & GetGlobalResourceObject("Tags", "tagField") & "</th><th>" & GetGlobalResourceObject("Tags", "tagFieldOldValue") & "</th><th>" & GetGlobalResourceObject("Tags", "tagFieldNewValue") & "</th></tr>"
        If strRecords.Length > 0 Then
            For i As Integer = 0 To intRecords - 1
                strRecords(i) = strRecords(i).Replace("<!:>", vbNewLine)
                strRecords(i) = strRecords(i).Replace("<!->", vbNewLine)
                strParams = strRecords(i).Split(vbNewLine)
                Select Case strParams.Length
                    Case 0
                        strResult = strResult & "<tr><td class=""Field"">" & "&nbsp;" & "</td><td class=""FieldValue"">" & strRecords(i) & "</td><td class=""FieldValue"">" & "&nbsp;" & "</td></tr>"
                    Case 1
                        strResult = strResult & "<tr><td class=""Field"">" & "&nbsp;" & "</td><td class=""FieldValue"">" & strParams(0) & "</td><td class=""FieldValue"">" & "&nbsp;" & "</td></tr>"
                    Case 2
                        strResult = strResult & "<tr><td class=""Field"">" & strParams(0) & ":</td><td class=""FieldValue"">" & strParams(1) & "</td><td class=""FieldValue"">" & "&nbsp;" & "</td></tr>"
                    Case 3
                        strResult = strResult & "<tr><td class=""Field"">" & strParams(0) & ":</td><td class=""FieldValue"">" & strParams(1) & "</td><td class=""FieldValue"">" & strParams(2) & "</td></tr>"
                End Select
            Next
        Else
            strResult = strResult & "<tr><td>" & Description & "</td></tr>"
        End If
        strResult = strResult & "</table>"
        Return strResult
    End Function

    Private Function FormatTraceInfo_Delete(ByVal Description As String) As String
        Dim strResult As String = String.Empty
        strResult = strResult & "<table cellspacing=""0"" cellpadding=""0"" width=""100%"" border=""0"" class=""TableTraceDelete"">"
        strResult = strResult & "<tr><td>"
        strResult = strResult & Description
        strResult = strResult & "</td></tr></table>"
        Return strResult
    End Function

    Public Function GetMasterPageScript() As String
        Dim strResult As String = String.Empty
        strResult = strResult & "<div id=""divLoading"" style=""display: none;"">"
        strResult = strResult & "<div><b>" & GetGlobalResourceObject("AppResources", "LoadingPageTitle") & "</b><br />"
        strResult = strResult & GetGlobalResourceObject("AppResources", "LoadingPageSubtitle") & "<br />"
        strResult = strResult & "<img alt="""" src=""/_Resources/Images/Busy.gif"" style=""margin-top: 4px;"" /></div></div>"
        strResult = strResult & "<div id=""divProcessing"" style=""display: none;"">"
        strResult = strResult & "<div style=""margin-top: 5px;""><b>"
        strResult = strResult & GetGlobalResourceObject("AppResources", "ProcessingPageSubtitle") & "</b></div></div>"
        Return strResult
    End Function

    'Public Function GetPopupMessages(ByVal AppCode As String, ByVal UserId As Guid) As String
    'Dim strResult As String = String.Empty
    'Dim i As Integer
    'Dim intPosX As Integer = 100
    'Dim intposY As Integer = 100
    'Dim dstTemp As DataSet
    'Dim dvTemp As DataView

    'dstTemp = UserSession.UserSessions.ReadAppMessages(AppCode)
    'If dstTemp.Tables(0).Rows.Count > 0 Then
    '    dvTemp = New DataView(dstTemp.Tables(0))
    '    For i = 0 To dvTemp.Count - 1
    '        strResult = strResult & "<script>"
    '        strResult = strResult & "window.open('/ControlPanel/Public/Messages/AppMessage.aspx?MessageId="
    '        strResult = strResult & dvTemp(i)("ApplicationMessageId").ToString()
    '        strResult = strResult & " ' , '', 'menubar=0,toolbar=0,resizable=0,scrollbars=0"
    '        strResult = strResult & ",left="
    '        strResult = strResult & intPosX.ToString
    '        strResult = strResult & ",top="
    '        strResult = strResult & intposY.ToString
    '        strResult = strResult & ",width="
    '        strResult = strResult & dvTemp(i)("WidthValue").ToString()
    '        strResult = strResult & ",height="
    '        strResult = strResult & dvTemp(i)("HeightValue").ToString()
    '        strResult = strResult & "');"
    '        strResult = strResult & "</script>"
    '        intPosX = intPosX + 80
    '        intposY = intposY + 60
    '    Next
    'End If

    'dstTemp = UserSession.UserSessions.ReadUserMessages(UserId)
    'If dstTemp.Tables(0).Rows.Count > 0 Then
    '    dvTemp = New DataView(dstTemp.Tables(0))
    '    For i = 0 To dvTemp.Count - 1
    '        strResult = strResult & "<script>"
    '        strResult = strResult & "window.open('/ControlPanel/Public/Messages/UserMessage.aspx?MessageId="
    '        strResult = strResult & dvTemp(i)("UserMessageId").ToString()
    '        strResult = strResult & " ' , '', 'menubar=0,toolbar=0,resizable=0,scrollbars=0"
    '        strResult = strResult & ",left="
    '        strResult = strResult & intPosX.ToString
    '        strResult = strResult & ",top="
    '        strResult = strResult & intposY.ToString
    '        strResult = strResult & ",width="
    '        strResult = strResult & dvTemp(i)("WidthValue").ToString()
    '        strResult = strResult & ",height="
    '        strResult = strResult & dvTemp(i)("HeightValue").ToString()
    '        strResult = strResult & "');"
    '        strResult = strResult & "</script>"
    '        intPosX = intPosX + 80
    '        intposY = intposY + 60
    '    Next
    'End If

    'Return strResult
    'End Function

    Public Function GetRandomCode() As String
        Return Date.Now.Year.ToString.Substring(2, 2) & Date.Now.Month.ToString.PadLeft(2, "0") & Date.Now.Day.ToString.PadLeft(2, "0") & GetRandomNumber(999999).ToString.PadLeft(6, "0")
    End Function

    Public Function GetRandomNumber(ByVal MaxNumber As Integer, Optional ByVal MinNumber As Integer = 0) As Integer
        Dim r As New Random(System.DateTime.Now.Millisecond)
        If MinNumber > MaxNumber Then
            Dim t As Integer = MinNumber
            MinNumber = MaxNumber
            MaxNumber = t
        End If
        Return r.Next(MinNumber, MaxNumber)
    End Function

End Module
