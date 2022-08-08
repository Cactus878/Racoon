Public Class racoonWelcome
    Dim taskName As String
    Dim arrListing(2) As String
    Dim intIndex As Integer = 0

    Private Sub racoonWelcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "User:" + " " + username
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub UpdateTask_Click(sender As Object, e As EventArgs) Handles UpdateTask.Click
        ListBox1.Items.Add(taskName + " | State: " + ComboBox1.Text)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        taskName = TextBox1.Text
    End Sub
End Class