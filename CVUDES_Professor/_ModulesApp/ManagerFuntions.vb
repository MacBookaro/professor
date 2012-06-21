Imports System.Security.Cryptography
Imports System.Net.Mail

Module ManagerFuntions
    Public Function generateMD5(ByVal sCadena As String) As String

        ' Create a new instance of the MD5 object.
        Dim md5Hasher As MD5 = MD5.Create()
        ' Convert the input string to a byte array and compute the hash.
        Dim data As Byte() = md5Hasher.ComputeHash(Encoding.Default.GetBytes(sCadena))
        ' Create a new Stringbuilder to collect the bytes
        ' and create a string.
        Dim sBuilder As New StringBuilder()
        ' Loop through each byte of the hashed data 
        ' and format each one as a hexadecimal string.
        Dim i As Integer
        For i = 0 To data.Length - 1
            sBuilder.Append(data(i).ToString("x2"))
        Next i
        ' Return the hexadecimal string.
        Return sBuilder.ToString()

    End Function

    Public Function GetJsonObs(ByVal dt As DataTable) As String

        Dim serializer As System.Web.Script.Serialization.JavaScriptSerializer = New System.Web.Script.Serialization.JavaScriptSerializer()
        Dim rows As New List(Of Dictionary(Of String, Object))
        Dim row As Dictionary(Of String, Object)

        For Each dr As DataRow In dt.Rows
            row = New Dictionary(Of String, Object)
            For Each col As DataColumn In dt.Columns
                row.Add(col.ColumnName, dr(col).ToString)
            Next
            rows.Add(row)
        Next
        'Return "{""data"":" & serializer.Serialize(rows) & "}"
        Return serializer.Serialize(rows)
    End Function

End Module
