<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClosingDialog
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Yes_Button = New Button()
        Label1 = New Label()
        No_Button = New Button()
        Cancel_Button = New Button()
        SuspendLayout()
        ' 
        ' Yes_Button
        ' 
        Yes_Button.Anchor = AnchorStyles.None
        Yes_Button.Location = New Point(13, 84)
        Yes_Button.Margin = New Padding(4, 5, 4, 5)
        Yes_Button.Name = "Yes_Button"
        Yes_Button.Size = New Size(89, 35)
        Yes_Button.TabIndex = 0
        Yes_Button.Text = "Yes (&S)"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(322, 20)
        Label1.TabIndex = 1
        Label1.Text = "Would like to close the window with save data?"
        ' 
        ' No_Button
        ' 
        No_Button.Anchor = AnchorStyles.None
        No_Button.Location = New Point(110, 84)
        No_Button.Margin = New Padding(4, 5, 4, 5)
        No_Button.Name = "No_Button"
        No_Button.Size = New Size(89, 35)
        No_Button.TabIndex = 2
        No_Button.Text = "No (&N)"
        ' 
        ' Cancel_Button
        ' 
        Cancel_Button.Anchor = AnchorStyles.None
        Cancel_Button.Location = New Point(240, 84)
        Cancel_Button.Margin = New Padding(4, 5, 4, 5)
        Cancel_Button.Name = "Cancel_Button"
        Cancel_Button.Size = New Size(89, 35)
        Cancel_Button.TabIndex = 1
        Cancel_Button.Text = "Cancel"
        ' 
        ' ClosingDialog
        ' 
        AcceptButton = Yes_Button
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = Cancel_Button
        ClientSize = New Size(342, 133)
        Controls.Add(Cancel_Button)
        Controls.Add(No_Button)
        Controls.Add(Yes_Button)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(4, 5, 4, 5)
        MaximizeBox = False
        MinimizeBox = False
        Name = "ClosingDialog"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "ClosingDialog"
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents Yes_Button As System.Windows.Forms.Button
    Friend WithEvents Label1 As Label
    Friend WithEvents No_Button As Button
    Friend WithEvents Cancel_Button As Button

End Class
