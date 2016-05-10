Public Class GreetingForm
    Public Const HPADDING As Integer = 16
    Public Const VPADDING As Integer = 40

    Public Property vDir As Integer
    Public Property hDir As Integer

    Private Sub GreetingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        vDir = 1
        hDir = 1
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Move the label diagonally
        Label1.Left += hDir
        Label1.Top += vDir

        'Change label direction and color when it hits an edge of the screen
        If Label1.Top < 0 Then
            vDir = 1
            ChangeColor()
        End If
        If Label1.Top + Label1.Height > Label1.Parent.Height - VPADDING Then
            vDir = -1
            ChangeColor()
        End If
        If Label1.Left < 0 Then
            hDir = 1
            ChangeColor()
        End If
        If Label1.Left + Label1.Width > Label1.Parent.Width - HPADDING Then
            hDir = -1
            ChangeColor()
        End If
    End Sub

    Private Sub ChangeColor()
        Dim rand As New Random
        Dim newColor As Color = Color.FromArgb(255, rand.Next(256), rand.Next(256), rand.Next(256))
        Label1.ForeColor = newColor
    End Sub
End Class