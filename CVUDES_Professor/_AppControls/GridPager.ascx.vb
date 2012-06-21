Partial Public Class GridPager
	Inherits System.Web.UI.UserControl

	Const LnkFirstImageOn As String = "Pager_First.gif"
	Const LnkFirstImageOff As String = "Pager_First_Off.gif"

	Const LnkPreviousImageOn As String = "Pager_Previous.gif"
	Const LnkPreviousImageOff As String = "Pager_Previous_Off.gif"

	Const LnkNextImageOn As String = "Pager_Next.gif"
	Const LnkNextImageOff As String = "Pager_Next_Off.gif"

	Const LnkLastImageOn As String = "Pager_Last.gif"
	Const LnkLastImageOff As String = "Pager_Last_Off.gif"

	Public Sub ConfigurePaginationTable(ByVal PageIndex As Integer, ByVal Pagination As Integer, _
			ByVal DBRecords As Integer, ByVal DSRecords As Integer)

		Dim intPageLinks As Integer = 10
        Dim intPages As Integer = Math.Ceiling(DBRecords / Pagination)
		Dim intBeginLink As Integer = 0
		Dim intEndLink As Integer = 0
		Dim strURL As String = Request.CurrentExecutionFilePath.ToString & GetURLParamsString()

		Me.Visible = True

		If intPages > intPageLinks Then
			intBeginLink = PageIndex - (intPageLinks / 2)
			If intBeginLink < 1 Then intBeginLink = 1
			intEndLink = intBeginLink + intPageLinks
			If intEndLink > intPages Then
				intBeginLink = intBeginLink - (intEndLink - intPages)
				intEndLink = intPages
			End If
		Else
			intBeginLink = 1
			intEndLink = intPages
		End If

		If DBRecords > 0 Then
			Me.lblPageRecords.Text = String.Format(Me.lblPageRecords.Text, ((PageIndex * Pagination) - Pagination + 1).ToString, ((PageIndex * Pagination) - Pagination + DSRecords).ToString, DBRecords.ToString)

			Me.phPagination.Controls.Add(New LiteralControl(GetGlobalResourceObject("AppConfig", "PagerLinkPages")))
			Dim objLnk As New Object
			For i As Integer = intBeginLink To intEndLink
				If i = PageIndex Then
					objLnk = New Label
					objLnk.ID = "lnkPage" & i.ToString
					objLnk.Text = i.ToString
					objLnk.CssClass = "LinkDisabled"
					objLnk.Enabled = False
				Else
					objLnk = New HyperLink
					objLnk.ID = "lnkPage" & i.ToString
					objLnk.Text = i.ToString
					objLnk.NavigateUrl = strURL.Replace("@@@@", i.ToString)
				End If

				Me.phPagination.Controls.Add(objLnk)
				Me.phPagination.Controls.Add(New LiteralControl("&nbsp"))
			Next
		Else
			Me.lblPageRecords.Text = String.Format(Me.lblPageRecords.Text, "0", "0", "0")
			Me.phPagination.Controls.Add(New LiteralControl(GetGlobalResourceObject("AppConfig", "PagerLinkPages") & "-"))
		End If

		If PageIndex > 1 And PageIndex < intPages Then 'Si esta dentro del rango de las paginas
			ConfigurePaginationLinks(True, True, True, True, strURL, PageIndex, intPages)
		Else
			If PageIndex = 1 And PageIndex < intPages Then 'Es BOF
				ConfigurePaginationLinks(False, False, True, True, strURL, PageIndex, intPages)
			Else
				If PageIndex > 1 And PageIndex = intPages Then 'Es EOF
					ConfigurePaginationLinks(True, True, False, False, strURL, PageIndex, intPages)
				Else 'No requiere paginacion
					ConfigurePaginationLinks(False, False, False, False, strURL, PageIndex, intPages)
				End If
			End If
		End If
	End Sub

	Private Sub ConfigurePaginationLinks(ByVal IsFirstActive As Boolean, ByVal IsPreviousActive As Boolean, _
		ByVal IsNextActive As Boolean, ByVal IsLastActive As Boolean, ByVal URLParam As String, _
		ByVal PageIndex As Integer, ByVal LastPage As Integer)
		ConfigureLnkFirst(IsFirstActive, URLParam, 1)
		ConfigureLnkPrevious(IsPreviousActive, URLParam, PageIndex)
		ConfigureLnkNext(IsNextActive, URLParam, PageIndex)
		ConfigureLnkLast(IsLastActive, URLParam, LastPage)
	End Sub

	Private Sub ConfigureLnkFirst(ByVal State As Boolean, ByVal URLParam As String, ByVal FirstPage As Integer)
		Dim strURL As String = String.Empty
		Dim strImage As String = String.Empty
		Select Case State
			Case True
				strURL = URLParam.Replace("@@@@", FirstPage.ToString)
				strImage = LnkFirstImageOn
			Case False
				strURL = "javascript:;"
				strImage = LnkFirstImageOff
		End Select
		Me.lnkFirst.Enabled = State
		Me.lnkFirst.Text = "<img src=/_Resources/Icons/" & strImage & " alt='" & Me.lnkFirst.Text & "'>"
		Me.lnkFirst.NavigateUrl = strURL
	End Sub

	Private Sub ConfigureLnkPrevious(ByVal State As Boolean, ByVal URLParam As String, ByVal PageIndex As Integer)
		Dim strURL As String = String.Empty
		Dim strImage As String = String.Empty
		Select Case State
			Case True
				strURL = URLParam.Replace("@@@@", (PageIndex - 1).ToString)
				strImage = LnkPreviousImageOn
			Case False
				strURL = "javascript:;"
				strImage = LnkPreviousImageOff
		End Select
		Me.lnkPrevious.Enabled = State
		Me.lnkPrevious.Text = "<img src=/_Resources/Icons/" & strImage & " alt='" & Me.lnkPrevious.Text & "'>"
		Me.lnkPrevious.NavigateUrl = strURL
	End Sub

	Private Sub ConfigureLnkNext(ByVal State As Boolean, ByVal URLParam As String, ByVal PageIndex As Integer)
		Dim strURL As String = String.Empty
		Dim strImage As String = String.Empty
		Select Case State
			Case True
				strURL = URLParam.Replace("@@@@", (PageIndex + 1).ToString)
				strImage = LnkNextImageOn
			Case False
				strURL = "javascript:;"
				strImage = LnkNextImageOff
		End Select
		Me.lnkNext.Enabled = State
		Me.lnkNext.Text = "<img src=/_Resources/Icons/" & strImage & " alt='" & Me.lnkNext.Text & "'>"
		Me.lnkNext.NavigateUrl = strURL
	End Sub

	Private Sub ConfigureLnkLast(ByVal State As Boolean, ByVal URLParam As String, ByVal LastPage As Integer)
		Dim strURL As String = String.Empty
		Dim strImage As String = String.Empty
		Select Case State
			Case True
				strURL = URLParam.Replace("@@@@", LastPage.ToString)
				strImage = LnkLastImageOn
			Case False
				strURL = "javascript:;"
				strImage = LnkLastImageOff
		End Select
		Me.lnkLast.Enabled = State
		Me.lnkLast.Text = "<img src=/_Resources/Icons/" & strImage & " alt='" & Me.lnkLast.Text & "'>"
		Me.lnkLast.NavigateUrl = strURL
	End Sub

	Protected Function GetURLParamsString() As String
		Dim strURL As String = Request.Url.Query
		Dim intIndex As Integer = 0

		If Request.QueryString("Page") <> String.Empty Then
			strURL = strURL.Replace("Page=" & Request.QueryString("Page"), "Page=@@@@")
		Else
			If strURL.Contains("Page=") Then
				strURL = strURL.Replace("Page=", "Page=@@@@")
			Else
				If strURL <> String.Empty Then
					strURL = strURL & "&Page=@@@@"
				Else
					strURL = "?Page=@@@@"
				End If
			End If
		End If

		Return strURL
	End Function
End Class