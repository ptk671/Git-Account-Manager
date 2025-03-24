<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AppendingAccountDialog
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
        TableLayoutPanel1 = New TableLayoutPanel()
        OK_Button = New Button()
        Cancel_Button = New Button()
        UserNameTextBox = New TextBox()
        MailaddressTextBox = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        ColorBox = New TextBox()
        ColorDialog1 = New ColorDialog()
        Button1 = New Button()
        Panel1 = New Panel()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(OK_Button, 0, 0)
        TableLayoutPanel1.Controls.Add(Cancel_Button, 1, 0)
        TableLayoutPanel1.Location = New Point(202, 98)
        TableLayoutPanel1.Margin = New Padding(4)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(171, 34)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' OK_Button
        ' 
        OK_Button.Anchor = AnchorStyles.None
        OK_Button.Location = New Point(4, 4)
        OK_Button.Margin = New Padding(4)
        OK_Button.Name = "OK_Button"
        OK_Button.Size = New Size(77, 26)
        OK_Button.TabIndex = 0
        OK_Button.Text = "Add"
        ' 
        ' Cancel_Button
        ' 
        Cancel_Button.Anchor = AnchorStyles.None
        Cancel_Button.Location = New Point(89, 4)
        Cancel_Button.Margin = New Padding(4)
        Cancel_Button.Name = "Cancel_Button"
        Cancel_Button.Size = New Size(78, 26)
        Cancel_Button.TabIndex = 1
        Cancel_Button.Text = "Cancel"
        ' 
        ' UserNameTextBox
        ' 
        UserNameTextBox.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        UserNameTextBox.Location = New Point(10, 24)
        UserNameTextBox.Margin = New Padding(3, 2, 3, 2)
        UserNameTextBox.Name = "UserNameTextBox"
        UserNameTextBox.Size = New Size(366, 23)
        UserNameTextBox.TabIndex = 1
        ' 
        ' MailaddressTextBox
        ' 
        MailaddressTextBox.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        MailaddressTextBox.Location = New Point(10, 65)
        MailaddressTextBox.Margin = New Padding(3, 2, 3, 2)
        MailaddressTextBox.Name = "MailaddressTextBox"
        MailaddressTextBox.Size = New Size(366, 23)
        MailaddressTextBox.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(10, 7)
        Label1.Name = "Label1"
        Label1.Size = New Size(62, 15)
        Label1.TabIndex = 3
        Label1.Text = "User name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(10, 47)
        Label2.Name = "Label2"
        Label2.Size = New Size(75, 15)
        Label2.TabIndex = 4
        Label2.Text = "Mail Address"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(82, 98)
        Label3.Name = "Label3"
        Label3.Size = New Size(35, 15)
        Label3.TabIndex = 5
        Label3.Text = "Color"
        ' 
        ' ColorBox
        ' 
        ColorBox.Location = New Point(72, 116)
        ColorBox.Name = "ColorBox"
        ColorBox.Size = New Size(100, 23)
        ColorBox.TabIndex = 6
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(10, 116)
        Button1.Name = "Button1"
        Button1.Size = New Size(52, 23)
        Button1.TabIndex = 7
        Button1.Text = "Select"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Location = New Point(12, 93)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(36, 20)
        Panel1.TabIndex = 8
        ' 
        ' AppendingAccountDialog
        ' 
        AcceptButton = OK_Button
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = Cancel_Button
        ClientSize = New Size(387, 145)
        Controls.Add(Panel1)
        Controls.Add(Button1)
        Controls.Add(ColorBox)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(MailaddressTextBox)
        Controls.Add(UserNameTextBox)
        Controls.Add(TableLayoutPanel1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(4)
        MaximizeBox = False
        MinimizeBox = False
        Name = "AppendingAccountDialog"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "Appending Account"
        TableLayoutPanel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents UserNameTextBox As TextBox
    Friend WithEvents MailaddressTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ColorBox As TextBox
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel

End Class
