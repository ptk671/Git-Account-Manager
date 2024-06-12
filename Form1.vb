' メモ
' ノート機能を追加する
' メニューの実装
' GitHubのアカウントを追加する
' ListBoxの選択を変更したときにボタンの有効無効を切り替える
' ListBoxをダブルクリックしたときに編集ダイアログを開く

' License: MIT License

Imports System.IO
Imports System.Text.Encodings.Web
Imports System.Text.Json
Imports System.Text.Unicode

Public Class Form1
    Public userInfos As New Dictionary(Of String, UserInfo)

    Public isChanged As Boolean = False

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

        appendingAccountDialog1.UserNameTextBox.Enabled = False

        appendingAccountDialog1.ShowDialog()
    End Sub

    Private Sub RemoveBtn_Click(sender As Object, e As EventArgs) Handles RemoveBtn.Click
        If (UserList.SelectedItems.Count > 0) Then
            removeUserInfo(UserList.SelectedItem)
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
                Dim dialogResult = MessageBox.Show("Switched user to " + UserList.SelectedItem, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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



    Public Sub saveToFile()
        Dim sw As New IO.StreamWriter("config.json")
        Dim dict = New Dictionary(Of String, Dictionary(Of String, Object))
        For Each userInfo In userInfos
            dict.Add(userInfo.Key, New Dictionary(Of String, Object) From {
                {"name", userInfo.Value.name},
                {"email", userInfo.Value.email}
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
                addUserInfo(New UserInfo(userInfo.Value("name").ToString(), userInfo.Value("email").ToString()))
            End If
        Next
    End Sub

    Private Sub AboutGitAccountManagerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutGitAccountManagerToolStripMenuItem.Click
        Dim dialogResult = MessageBox.Show("Git Account Manager" +
                                           vbCrLf + "Version 1.0.0" +
                                           vbCrLf + "©2024 ぴたQ",
                                           "About Git Account Manager",
                                           MessageBoxButtons.OK,
                                           MessageBoxIcon.Information)
    End Sub
End Class
