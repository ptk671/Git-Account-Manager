Public Class UserInfo
    Public name As String
    Public email As String
    Public color As String
    Public Sub New(name As String, email As String, color As String)
        Me.name = name
        Me.email = email
        Me.color = color
    End Sub


    Public Function getColor() As String
        Return color
    End Function
    Public Function getName() As String
        Return name
    End Function

    Public Function getEmail() As String
        Return email
    End Function

End Class
