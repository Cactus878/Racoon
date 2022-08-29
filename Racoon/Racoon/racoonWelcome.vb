Public Class welcomePage
    Dim taskName As String
    Dim taskText As String
    Dim currentItem As Integer = 0

    Private Sub racoonWelcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "User:" + " " + username
        TaskList.GridLines = True
    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        TaskList.Items.Clear()
    End Sub

    Private Sub UpdateTask_Click(sender As Object, e As EventArgs) Handles UpdateTask.Click
        TaskList.Items.Add(NameText.Text)
        TaskList.Items(currentItem).SubItems.Add(taskName)
        TaskList.Items(currentItem).SubItems.Add(ComboBox1.Text)
        TaskList.Items(currentItem).SubItems.Add(TaskTextBox.Text)
        TaskList.Items(currentItem).SubItems.Add(DateTimePicker.Text)
        currentItem += 1
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        taskName = TextBox1.Text
    End Sub

    Private Sub AddText_Click(sender As Object, e As EventArgs) Handles AddText.Click
        taskText = InputBox("Enter Task Description")
        TaskTextBox.Text = taskText
    End Sub

    Private Sub ExitRacoon_Click(sender As Object, e As EventArgs) Handles ExitRacoon.Click
        Dim didExit As DialogResult
        didExit = MessageBox.Show("Confirm if you want to exit", "System Down", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If didExit = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub videoCall_Click(sender As Object, e As EventArgs) Handles videoCall.Click
        RaccoonCall.Visible = True
    End Sub
End Class