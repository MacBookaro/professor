Imports System.Configuration
Imports System.Text
Imports System.ComponentModel

Module UrlsModule

    Public Function GetURLToRedirect(ByVal PId As String, ByVal PParams As String, ByVal POwnerId As String, ByVal CookieValue As String) As String
        Dim strResult As String = String.Empty
        If PId <> String.Empty And PParams <> String.Empty Then
            Select Case PId
                Case "AdministrationUsersView"
                    strResult = "/ControlPanel/Administration/Users/View.aspx" & PParams
                    '///////////////////////////////////////////////////////////////////////////////////////////////////////
                Case Else
                    strResult = GetURLToRedirect(String.Empty, String.Empty, POwnerId, CookieValue)
            End Select
        Else
            If PId <> String.Empty Then
                Select Case PId
                    Case "Home"
                        strResult = "/ControlPanel/Default.aspx"
                    Case Else
                        strResult = GetURLToRedirect(String.Empty, String.Empty, POwnerId, CookieValue)
                End Select
            Else
                Select Case POwnerId
                    Case "AdministrationUsersDefault"
                        strResult = "/ControlPanel/Administration/Users/Default.aspx" & CookieValue
                        '///////////////////////////////////////////////////////////////////////////////////////////////////////
                    Case Else
                        strResult = "/ControlPanel/Default.aspx"
                End Select
            End If
        End If
        Return strResult
    End Function

End Module
