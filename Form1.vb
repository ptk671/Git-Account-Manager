' メモ
' ノート機能を追加する
' メニューの実装
' GitHubのアカウントを追加する
' ListBoxの選択を変更したときにボタンの有効無効を切り替える
' ListBoxをダブルクリックしたときに編集ダイアログを開く

' License: MIT License

Imports System.Configuration
Imports System.IO
Imports System.Text
Imports System.Text.Encodings.Web
Imports System.Text.Json
Imports System.Text.Json.Nodes
Imports System.Text.Unicode
Imports Corale.Colore
Imports Corale.Colore.Core

Public Class Form1
    Public userInfos As New Dictionary(Of String, UserInfo)

    Public isChanged As Boolean = False

    Public accountConfigFile As String = "Config.json"

    Public Sub loadSettings()
        ChromaCheack.Checked = My.Settings.DeviceLighting
    End Sub

    Public Sub initRGB()
        Try
            Chroma.Instance.Initialize()

        Catch ex As Exception

        End Try
    End Sub

    Public Sub uninitRGB()
        Try
            Chroma.Instance.Uninitialize()

        Catch ex As Exception

        End Try
    End Sub


    Public Sub settingStaticRGBColor(drawingColor As Drawing.Color)
        If (ChromaCheack.Checked = True) Then
            Dim tempColor As Drawing.Color
            Try
                Chroma.Instance.SetAll(New Color(drawingColor.R, drawingColor.G, drawingColor.B))
            Catch ex As Exception

            End Try

        End If
    End Sub

    Public Sub settingStaticRGBColor(r As Integer, g As Integer, b As Integer)
        settingStaticRGBColor(r, g, b)
    End Sub

    Public Sub settingStaticRGBColor(hexColor As String)
        settingStaticRGBColor(ColorTranslator.FromHtml(hexColor))
    End Sub


    Public Sub initColor()
        settingStaticRGBColor(Drawing.Color.Black)
    End Sub

    Public Sub addUserInfo(userInfo As UserInfo)
        If (userInfos.ContainsKey(userInfo.getName())) Then
            removeUserInfo(userInfo.getName())
        End If
        userInfos.Add(userInfo.getName(), userInfo)
        UserList.Items.Add(userInfo.name)

        If (userInfos.Count > 0) Then
            SwitchBtn.Enabled = True
            RemoveBtn.Enabled = True
            EditBtn.Enabled = True
        Else
            SwitchBtn.Enabled = False
            RemoveBtn.Enabled = False
            EditBtn.Enabled = False
        End If

        isChanged = True
    End Sub

    Public Sub removeUserInfo(userInfo As UserInfo)
        removeUserInfo(userInfo.name)
    End Sub

    Public Sub removeUserInfo(userName As String)
        If (userInfos.ContainsKey(userName)) Then
            userInfos.Remove(userName)
            UserList.Items.Remove(userName)

            If (userInfos.Count > 0) Then
                SwitchBtn.Enabled = True
                RemoveBtn.Enabled = True
                EditBtn.Enabled = True
            Else
                SwitchBtn.Enabled = False
                RemoveBtn.Enabled = False
                EditBtn.Enabled = False
            End If
        End If

        isChanged = True
    End Sub

    Public Function getUserInfo(userName As String) As UserInfo
        Return userInfos.Item(userName)
    End Function

    Public Function switchUser(userName As String) As Boolean
        Dim userInfo = getUserInfo(userName)

        If (userInfo Is Nothing) Then
            Return False
        End If

        Dim processStartInfo = New ProcessStartInfo With {
            .FileName = "cmd",
            .Arguments = "/c git config --global user.name '" + userInfo.name + "' & git config --global user.email '" + userInfo.email + "'",
            .CreateNoWindow = True,
            .UseShellExecute = False,
            .RedirectStandardOutput = True,
            .RedirectStandardError = True
        }

        Dim process_ = Process.Start(processStartInfo)
        Dim output = process_.StandardOutput.ReadToEnd()
        process_.WaitForExit()
        process_.Close()

        Return True
    End Function

    ' めんどくせえので変えてないけどそのうち変える
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        Dim appendingAccountDialog1 = New AppendingAccountDialog()
        appendingAccountDialog1.ShowDialog()
    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        openEditDialog()
    End Sub




    Public Sub openEditDialog()
        If (UserList.SelectedItems.Count <= 0) Then
            Return
        End If

        Dim appendingAccountDialog1 = New AppendingAccountDialog()

        appendingAccountDialog1.Text = "Edit Account"

        appendingAccountDialog1.OK_Button.Text = "Change"
        appendingAccountDialog1.UserNameTextBox.Text = userInfos(UserList.SelectedItem).name
        appendingAccountDialog1.MailaddressTextBox.Text = userInfos(UserList.SelectedItem).email
        appendingAccountDialog1.ColorBox.Text = userInfos(UserList.SelectedItem).color
        appendingAccountDialog1.UserNameTextBox.Enabled = False

        appendingAccountDialog1.ShowDialog()
    End Sub

    Private Sub RemoveBtn_Click(sender As Object, e As EventArgs) Handles RemoveBtn.Click
        If (UserList.SelectedItems.Count > 0) Then
            removeUserInfo(UserList.SelectedItem)
            Panel1.BackColor = Nothing
            initColor()
        End If
    End Sub

    Private Sub UserList_KeyDown(sender As Object, e As KeyEventArgs) Handles UserList.KeyDown
        If (UserList.SelectedItems.Count > 0) Then
            If (e.KeyCode.Equals(Keys.Delete)) Then
                removeUserInfo(UserList.SelectedItem)
            End If
        End If
    End Sub

    Private Sub SwitchBtn_Click(sender As Object, e As EventArgs) Handles SwitchBtn.Click
        If (UserList.SelectedItems.Count > 0) Then
            Dim b = switchUser(UserList.SelectedItem)
            If (b) Then
                Dim DialogResult = MessageBox.Show("Switched user to " + UserList.SelectedItem, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadSettings()

        If (ChromaCheack.Checked) Then

            initRGB()

        End If
        RemoveBtn.Enabled = False
        SwitchBtn.Enabled = False
        EditBtn.Enabled = False

        If (File.Exists("config.json")) Then
            loadFromFile()
        End If

        isChanged = False
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If (isChanged) Then
            Dim closingDialog = New ClosingDialog(e)
            closingDialog.ShowDialog()
        End If
    End Sub



    Public Sub saveToFile(config As String)
        Dim sw As New IO.StreamWriter(config)
        Dim dict = New Dictionary(Of String, Dictionary(Of String, Object))
        For Each userInfo In userInfos
            dict.Add(userInfo.Key, New Dictionary(Of String, Object) From {
                {"name", userInfo.Value.name},
                {"email", userInfo.Value.email},
                 {"color", userInfo.Value.color}
                     })
        Next

        Dim json = JsonSerializer.Serialize(dict, New JsonSerializerOptions With {
        .WriteIndented = True,
        .Encoder = JavaScriptEncoder.Create(UnicodeRanges.All)
    })
        sw.Write(json)
        sw.Close()
    End Sub

    Public Sub loadFromFile()
        Dim sr As New IO.StreamReader("config.json")
        Dim json = sr.ReadToEnd()
        sr.Close()
        Dim dict = JsonSerializer.Deserialize(Of Dictionary(Of String, Dictionary(Of String, Object)))(json)
        For Each userInfo In dict
            If userInfo.Value.ContainsKey("name") And userInfo.Value.ContainsKey("email") Then
                addUserInfo(New UserInfo(userInfo.Value("name").ToString(), userInfo.Value("email").ToString(), userInfo.Value("color").ToString))
            End If
        Next
    End Sub

    Private Sub AboutGitAccountManagerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutGitAccountManagerToolStripMenuItem.Click
        Dim dialogResult = MessageBox.Show("Git Account Manager" +
                                           vbCrLf + "Version 1.0.0" +
                                           vbCrLf + "©2025 ぴたQ、Ptki",
                                           "About Git Account Manager",
                                           MessageBoxButtons.OK,
                                           MessageBoxIcon.Information)
    End Sub

    Private Sub 設定を保存するToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 設定を保存するToolStripMenuItem.Click

    End Sub

    Private Function UserList_SelectedIndexChangedAsync(sender As Object, e As EventArgs) As Task Handles UserList.SelectedIndexChanged
        Try
            Panel1.BackColor = ColorTranslator.FromHtml(userInfos(UserList.SelectedItem).color)
            settingStaticRGBColor(Panel1.BackColor)


        Catch ex As Exception

        End Try

    End Function

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub ChromaCheack_CheckedChanged(sender As Object, e As EventArgs) Handles ChromaCheack.CheckedChanged
        If (ChromaCheack.Checked = True) Then

            initRGB()
        Else

            uninitRGB()

        End If
        My.Settings.DeviceLighting = ChromaCheack.Checked
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        initColor()
        Task.Delay(0.6)
        settingStaticRGBColor(Panel1.BackColor)
    End Sub

    Private Sub ファイルを読み込むToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ファイルを読み込むToolStripMenuItem.Click

    End Sub

    Private Sub ファイルとして保存ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ファイルとして保存ToolStripMenuItem.Click

    End Sub

    Private Sub バックアップToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles バックアップToolStripMenuItem.Click

    End Sub
End Class
