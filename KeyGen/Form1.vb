Public Class Form1

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
    Dim PreviousKey As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Key As Integer
Start:  Key = Int(Rnd() * 3) 'Multiply by the number of cases, In this case it is 3.
        If (PreviousKey = Key) Then
            GoTo Start
        End If
        Select Case Key
            Case 0
                TextBox1.Text = "your key" 'Provide Key for each case.
            Case 1
                TextBox1.Text = "your other key"
            Case 2
                TextBox1.Text = "your other other key"
        End Select
        PreviousKey = Key
    End Sub
End Class
