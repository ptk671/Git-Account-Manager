Public Class UserInfo
    Public name As String
    Public email As String

    Public Sub New(name As String, email As String)
        Me.name = name
        Me.email = email
    End Sub

    Public Function getName() As String
        Return name
    End Function

    Public Function getEmail() As String
        Return email
    End Function

End Class
