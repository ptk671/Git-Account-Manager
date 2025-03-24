Public Class AppendingAccountDialog



    Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles OK_Button.Click
        Dim userInfo As New UserInfo(UserNameTextBox.Text, MailaddressTextBox.Text, ColorBox.Text)

        Form1.addUserInfo(userInfo)

        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles ColorBox.TextChanged

        Panel1.BackColor = ColorTranslator.FromHtml(ColorBox.Text)

    End Sub

    Private Sub AppendingAccountDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (ColorBox.Text Is "") Then

            ColorBox.Text = "#FFFFFF"

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ColorDialog1.ShowDialog()
        ColorBox.Text = ColorTranslator.ToHtml(ColorDialog1.Color)


    End Sub
End Class
