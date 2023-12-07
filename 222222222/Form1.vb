Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Single
        Dim b As Single
        Dim c As Single
        a = CSng(coff_a.Text)
        b = CSng(coff_b.Text)
        c = CSng(coff_c.Text)
        Dim delta As Single
        delta = (b * b) - 4 * (a * c)
        lbl_delta.Text = delta.ToString
        If delta < 0 Then
            MsgBox("nb solution = 0")
            lbl_result1.Text = "pas de solution"
            lbl_result3x1.Text = " "
            lbl_result3x2.Text = " "
            lbl_result2.Text = " "
        Else
            If delta = 0 Then
                Dim x12 As Single
                x12 = (-b) / (2 * a)
                MsgBox("nb solution = 1")
                lbl_result2.Text = x12.ToString
                lbl_result3x1.Text = " "
                lbl_result3x2.Text = " "
            Else
                Dim x1 As Single
                Dim x2 As Single
                x1 = (-b) / (2 * a)
                x2 = b / (2 * a)
                MsgBox("nb solution = 2")
                lbl_result3x1.Text = x1.ToString
                lbl_result3x2.Text = x2.ToString
                lbl_result1.Text = " "
                lbl_result2.Text = " "



            End If
        End If
    End Sub

    Private Sub lbl_delta_Click(sender As Object, e As EventArgs) Handles lbl_delta.Click

    End Sub
End Class
