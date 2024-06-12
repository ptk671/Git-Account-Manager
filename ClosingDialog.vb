Public Class ClosingDialog

    Public formClosingEventArgs As FormClosingEventArgs

    Public Sub New(e As FormClosingEventArgs)
        InitializeComponent()
        formClosingEventArgs = e
        e.Cancel = True
    End Sub

    Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub

    Private Sub Yes_Button_Click(sender As Object, e As EventArgs) Handles Yes_Button.Click
        formClosingEventArgs.Cancel = False
        DialogResult = DialogResult.OK
        Form1.saveToFile()
        Close()
    End Sub

    Private Sub No_Button_Click(sender As Object, e As EventArgs) Handles No_Button.Click
        formClosingEventArgs.Cancel = False
        DialogResult = DialogResult.OK
        Close()
    End Sub
End Class
