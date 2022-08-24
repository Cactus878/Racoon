Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub UsernameTextBox_TextChanged(sender As Object, e As EventArgs) Handles UsernameTextBox.TextChanged

    End Sub

    Private Sub PasswordTextBox_TextChanged(sender As Object, e As EventArgs) Handles PasswordTextBox.TextChanged

    End Sub

    Private Sub Logon_Click(sender As Object, e As EventArgs) Handles Logon.Click
        username = UsernameTextBox.Text
        If UsernameTextBox.Text = "Boss" Then
            If PasswordTextBox.Text = "RacoonIsCool" Then
                welcomePage.Visible = True
            Else
                MsgBox("Error, wrong username or password", vbCritical, "Login")
            End If
        ElseIf UsernameTextBox.Text = "RacoonEmployee" Then
            PasswordTextBox.Text = "ILoveRacoons"
            welcomePage.Visible = True
        Else
            MsgBox("Error, wrong username or password", vbCritical, "Login")
        End If
        PasswordTextBox.Text = ""
        UsernameTextBox.Text = ""
    End Sub

    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles Reset.Click
        PasswordTextBox.Text = ""
        UsernameTextBox.Text = ""
        UsernameTextBox.Focus()
    End Sub
End Class
