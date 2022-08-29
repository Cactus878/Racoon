Imports AForge
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports System.IO
Public Class RaccoonCall
    Dim Camera As VideoCaptureDevice
    Dim bitmap As Bitmap
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cameras As VideoCaptureDeviceForm = New VideoCaptureDeviceForm
        If cameras.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Camera = cameras.VideoDevice
            AddHandler Camera.NewFrame, New NewFrameEventHandler(AddressOf Capture)
            Camera.Start()
        End If
    End Sub

    Private Sub Capture(sender As Object, eventArgs As NewFrameEventArgs)
        bitmap = DirectCast(eventArgs.Frame.Clone(), Bitmap)
        PictureBox1.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PictureBox2.Image = PictureBox1.Image
    End Sub
End Class