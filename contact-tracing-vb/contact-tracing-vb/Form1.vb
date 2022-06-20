Public Class Form1
    Private Sub addbtn_Click(sender As Object, e As EventArgs) Handles addbtn.Click
        lb1.Items.Add(tb1.Text)


    End Sub

    Private Sub savebtn_Click(sender As Object, e As EventArgs) Handles savebtn.Click

        Dim file As System.IO.StreamWriter
        Dim x As Integer
        file = New IO.StreamWriter("C:\Users\Lim\OneDrive\Desktop\vbassignment\" & FullName.Text & ".txt")
        For x = 0 To lb1.Items.Count - 1
            file.WriteLine(lb1.Items.Item(x))
        Next

        file.Close()

    End Sub

    Private Sub clearbtn_Click(sender As Object, e As EventArgs) Handles clearbtn.Click


        lb1.Items.Clear()

    End Sub
End Class
