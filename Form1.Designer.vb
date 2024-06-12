<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        AddBtn = New Button()
        UserList = New ListBox()
        SwitchBtn = New Button()
        RemoveBtn = New Button()
        EditBtn = New Button()
        MenuStrip1 = New MenuStrip()
        あToolStripMenuItem = New ToolStripMenuItem()
        設定を保存するToolStripMenuItem = New ToolStripMenuItem()
        バックアップToolStripMenuItem = New ToolStripMenuItem()
        ファイルとして保存ToolStripMenuItem = New ToolStripMenuItem()
        ファイルを読み込むToolStripMenuItem = New ToolStripMenuItem()
        ヘルプHToolStripMenuItem = New ToolStripMenuItem()
        AboutGitAccountManagerToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' AddBtn
        ' 
        AddBtn.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        AddBtn.Location = New Point(12, 272)
        AddBtn.Name = "AddBtn"
        AddBtn.Size = New Size(94, 29)
        AddBtn.TabIndex = 0
        AddBtn.Text = "Add (&A)"
        AddBtn.UseVisualStyleBackColor = True
        ' 
        ' UserList
        ' 
        UserList.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        UserList.FormattingEnabled = True
        UserList.Location = New Point(12, 32)
        UserList.Name = "UserList"
        UserList.Size = New Size(598, 224)
        UserList.TabIndex = 1
        ' 
        ' SwitchBtn
        ' 
        SwitchBtn.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        SwitchBtn.Location = New Point(516, 272)
        SwitchBtn.Name = "SwitchBtn"
        SwitchBtn.Size = New Size(94, 29)
        SwitchBtn.TabIndex = 2
        SwitchBtn.Text = "Switch (&S)"
        SwitchBtn.UseVisualStyleBackColor = True
        ' 
        ' RemoveBtn
        ' 
        RemoveBtn.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        RemoveBtn.Location = New Point(112, 272)
        RemoveBtn.Name = "RemoveBtn"
        RemoveBtn.Size = New Size(94, 29)
        RemoveBtn.TabIndex = 3
        RemoveBtn.Text = "Remove (&R)"
        RemoveBtn.UseVisualStyleBackColor = True
        ' 
        ' EditBtn
        ' 
        EditBtn.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        EditBtn.Location = New Point(212, 272)
        EditBtn.Name = "EditBtn"
        EditBtn.Size = New Size(94, 29)
        EditBtn.TabIndex = 4
        EditBtn.Text = "Edit (&E)"
        EditBtn.UseVisualStyleBackColor = True
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {あToolStripMenuItem, ヘルプHToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(622, 28)
        MenuStrip1.TabIndex = 5
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' あToolStripMenuItem
        ' 
        あToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {設定を保存するToolStripMenuItem, バックアップToolStripMenuItem})
        あToolStripMenuItem.Name = "あToolStripMenuItem"
        あToolStripMenuItem.Size = New Size(67, 24)
        あToolStripMenuItem.Text = "File (&F)"
        ' 
        ' 設定を保存するToolStripMenuItem
        ' 
        設定を保存するToolStripMenuItem.Name = "設定を保存するToolStripMenuItem"
        設定を保存するToolStripMenuItem.Size = New Size(224, 26)
        設定を保存するToolStripMenuItem.Text = "Save a config"
        ' 
        ' バックアップToolStripMenuItem
        ' 
        バックアップToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ファイルとして保存ToolStripMenuItem, ファイルを読み込むToolStripMenuItem})
        バックアップToolStripMenuItem.Name = "バックアップToolStripMenuItem"
        バックアップToolStripMenuItem.Size = New Size(224, 26)
        バックアップToolStripMenuItem.Text = "Backup (&B)"
        ' 
        ' ファイルとして保存ToolStripMenuItem
        ' 
        ファイルとして保存ToolStripMenuItem.Name = "ファイルとして保存ToolStripMenuItem"
        ファイルとして保存ToolStripMenuItem.Size = New Size(224, 26)
        ファイルとして保存ToolStripMenuItem.Text = "Save as file"
        ' 
        ' ファイルを読み込むToolStripMenuItem
        ' 
        ファイルを読み込むToolStripMenuItem.Name = "ファイルを読み込むToolStripMenuItem"
        ファイルを読み込むToolStripMenuItem.Size = New Size(224, 26)
        ファイルを読み込むToolStripMenuItem.Text = "Load file"
        ' 
        ' ヘルプHToolStripMenuItem
        ' 
        ヘルプHToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AboutGitAccountManagerToolStripMenuItem})
        ヘルプHToolStripMenuItem.Name = "ヘルプHToolStripMenuItem"
        ヘルプHToolStripMenuItem.Size = New Size(80, 24)
        ヘルプHToolStripMenuItem.Text = "Help (&H)"
        ' 
        ' AboutGitAccountManagerToolStripMenuItem
        ' 
        AboutGitAccountManagerToolStripMenuItem.Name = "AboutGitAccountManagerToolStripMenuItem"
        AboutGitAccountManagerToolStripMenuItem.Size = New Size(277, 26)
        AboutGitAccountManagerToolStripMenuItem.Text = "About Git Account Manager"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(622, 313)
        Controls.Add(EditBtn)
        Controls.Add(RemoveBtn)
        Controls.Add(SwitchBtn)
        Controls.Add(UserList)
        Controls.Add(AddBtn)
        Controls.Add(MenuStrip1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Git Account Manager"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents AddBtn As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents SwitchBtn As Button
    Friend WithEvents RemoveBtn As Button
    Public WithEvents UserList As ListBox
    Friend WithEvents EditBtn As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents あToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 設定を保存するToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents バックアップToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ファイルとして保存ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ヘルプHToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ファイルを読み込むToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutGitAccountManagerToolStripMenuItem As ToolStripMenuItem

End Class
