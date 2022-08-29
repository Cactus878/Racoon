<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class welcomePage
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.NameText = New System.Windows.Forms.TextBox()
        Me.AddText = New System.Windows.Forms.Button()
        Me.UpdateTask = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TaskTextBox = New System.Windows.Forms.RichTextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Clear = New System.Windows.Forms.Button()
        Me.ExitRacoon = New System.Windows.Forms.Button()
        Me.TaskList = New System.Windows.Forms.ListView()
        Me.Name = New System.Windows.Forms.ColumnHeader()
        Me.Task_Name = New System.Windows.Forms.ColumnHeader()
        Me.Progress = New System.Windows.Forms.ColumnHeader()
        Me.Task_Information = New System.Windows.Forms.ColumnHeader()
        Me.Date_From_Task_Start = New System.Windows.Forms.ColumnHeader()
        Me.videoCall = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.NameText)
        Me.GroupBox1.Controls.Add(Me.AddText)
        Me.GroupBox1.Controls.Add(Me.UpdateTask)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.TaskTextBox)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 58)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(772, 81)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'NameText
        '
        Me.NameText.Location = New System.Drawing.Point(7, 33)
        Me.NameText.Name = "NameText"
        Me.NameText.Size = New System.Drawing.Size(100, 23)
        Me.NameText.TabIndex = 8
        '
        'AddText
        '
        Me.AddText.Location = New System.Drawing.Point(514, 18)
        Me.AddText.Name = "AddText"
        Me.AddText.Size = New System.Drawing.Size(75, 23)
        Me.AddText.TabIndex = 7
        Me.AddText.Text = "AddText"
        Me.AddText.UseVisualStyleBackColor = True
        '
        'UpdateTask
        '
        Me.UpdateTask.Location = New System.Drawing.Point(675, 48)
        Me.UpdateTask.Name = "UpdateTask"
        Me.UpdateTask.Size = New System.Drawing.Size(91, 23)
        Me.UpdateTask.TabIndex = 6
        Me.UpdateTask.Text = "UpdateTask"
        Me.UpdateTask.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(113, 16)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(121, 23)
        Me.TextBox1.TabIndex = 5
        '
        'TaskTextBox
        '
        Me.TaskTextBox.Location = New System.Drawing.Point(266, 19)
        Me.TaskTextBox.Name = "TaskTextBox"
        Me.TaskTextBox.Size = New System.Drawing.Size(242, 49)
        Me.TaskTextBox.TabIndex = 3
        Me.TaskTextBox.Text = ""
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"In Progress", "Assistance Needed", "Completed"})
        Me.ComboBox1.Location = New System.Drawing.Point(113, 45)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 23)
        Me.ComboBox1.TabIndex = 2
        '
        'DateTimePicker
        '
        Me.DateTimePicker.Location = New System.Drawing.Point(616, 19)
        Me.DateTimePicker.Name = "DateTimePicker"
        Me.DateTimePicker.Size = New System.Drawing.Size(150, 23)
        Me.DateTimePicker.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Employee Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(125, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Progress"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(278, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Task"
        '
        'Clear
        '
        Me.Clear.Location = New System.Drawing.Point(709, 411)
        Me.Clear.Name = "Clear"
        Me.Clear.Size = New System.Drawing.Size(75, 23)
        Me.Clear.TabIndex = 7
        Me.Clear.Text = "Clear"
        Me.Clear.UseVisualStyleBackColor = True
        '
        'ExitRacoon
        '
        Me.ExitRacoon.Location = New System.Drawing.Point(628, 411)
        Me.ExitRacoon.Name = "ExitRacoon"
        Me.ExitRacoon.Size = New System.Drawing.Size(75, 23)
        Me.ExitRacoon.TabIndex = 10
        Me.ExitRacoon.Text = "Exit"
        Me.ExitRacoon.UseVisualStyleBackColor = True
        '
        'TaskList
        '
        Me.TaskList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Name, Me.Task_Name, Me.Progress, Me.Task_Information, Me.Date_From_Task_Start})
        Me.TaskList.HideSelection = False
        Me.TaskList.Location = New System.Drawing.Point(219, 145)
        Me.TaskList.Name = "TaskList"
        Me.TaskList.Size = New System.Drawing.Size(565, 260)
        Me.TaskList.TabIndex = 11
        Me.TaskList.UseCompatibleStateImageBehavior = False
        Me.TaskList.View = System.Windows.Forms.View.Details
        '
        'Name
        '
        Me.Name.Text = "Name"
        Me.Name.Width = 80
        '
        'Task_Name
        '
        Me.Task_Name.Text = "Task_Name"
        Me.Task_Name.Width = 100
        '
        'Progress
        '
        Me.Progress.Text = "Progress"
        Me.Progress.Width = 100
        '
        'Task_Information
        '
        Me.Task_Information.Text = "Task_Information"
        Me.Task_Information.Width = 180
        '
        'Date_From_Task_Start
        '
        Me.Date_From_Task_Start.Text = "Date_From_Task_Start"
        Me.Date_From_Task_Start.Width = 180
        '
        'videoCall
        '
        Me.videoCall.Location = New System.Drawing.Point(12, 146)
        Me.videoCall.Name = "videoCall"
        Me.videoCall.Size = New System.Drawing.Size(201, 38)
        Me.videoCall.TabIndex = 12
        Me.videoCall.Text = "Create Video Call"
        Me.videoCall.UseVisualStyleBackColor = True
        '
        'welcomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.videoCall)
        Me.Controls.Add(Me.TaskList)
        Me.Controls.Add(Me.ExitRacoon)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Clear)
        Me.Controls.Add(Me.Label1)
        'Me.Name = "welcomePage"
        Me.Text = "welcome"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TaskTextBox As RichTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Clear As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents UpdateTask As Button
    Friend WithEvents AddText As Button
    Friend WithEvents NameText As TextBox
    Friend WithEvents DateTimePicker As DateTimePicker
    Friend WithEvents ExitRacoon As Button
    Friend WithEvents TaskList As ListView
    Friend WithEvents Name As ColumnHeader
    Friend WithEvents Task_Name As ColumnHeader
    Friend WithEvents Progress As ColumnHeader
    Friend WithEvents Task_Information As ColumnHeader
    Friend WithEvents Date_From_Task_Start As ColumnHeader
    Friend WithEvents videoCall As Button
End Class
