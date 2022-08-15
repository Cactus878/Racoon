Public Class racoonWelcome
    Dim taskName As String
    Dim taskText As String

    Private Sub racoonWelcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "User:" + " " + username
        TaskList.View = View.Details
        TaskList.GridLines = True
        TaskList.FullRowSelect = True
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        TaskList.Items.Clear()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub UpdateTask_Click(sender As Object, e As EventArgs) Handles UpdateTask.Click
        TaskList.Items.Add(taskName + " | State: " + ComboBox1.Text)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        taskName = TextBox1.Text
    End Sub

    Private Sub TaskTextBox_TextChanged(sender As Object, e As EventArgs) Handles TaskTextBox.TextChanged

    End Sub

    Private Sub AddText_Click(sender As Object, e As EventArgs) Handles AddText.Click
        taskText = InputBox("Enter Task Description")
        TaskTextBox.Text = taskText
    End Sub

    Private Sub TaskList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TaskList.SelectedIndexChanged

    End Sub
End Class