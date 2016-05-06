Public Class HomeForm
    ' Simple Visual Basic Program
    '        Gordon Doskas
    '           POS/408
    '          May 9, 2016
    '        Dr. Bill Spees

    ' This GUI program has a button that creates a new window with the word
    ' Hello. The word moves diagonally, and when it hits the edge of the
    ' screen, it reverses vertical or horizontal direction and changes to a
    ' random color.

    Private Sub HomeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frmGreeting As New GreetingForm

        Me.Hide()
        frmGreeting.ShowDialog()
        Me.Close()
    End Sub
End Class
