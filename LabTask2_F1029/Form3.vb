Public Class Form3
    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        Dim no1 As Integer = txtNo1.Text
        Dim no2 As Integer = txtNo2.Text
        Dim add As Integer
        no1 = txtNo1.Text
        no2 = txtNo2.Text
        add = no1 + no2
        txtResult.Text = add
    End Sub
    Private Sub SubBtn_Click(sender As Object, e As EventArgs) Handles SubBtn.Click
        Dim no1 As Integer = txtNo1.Text
        Dim no2 As Integer = txtNo2.Text
        Dim minus As Integer
        no1 = txtNo1.Text
        no2 = txtNo2.Text
        minus = no1 - no2
        txtResult.Text = minus
    End Sub
    Private Sub MulBtn_Click(sender As Object, e As EventArgs) Handles MulBtn.Click
        Dim no1 As Integer = txtNo1.Text
        Dim no2 As Integer = txtNo2.Text
        Dim mul As Integer
        no1 = txtNo1.Text
        no2 = txtNo2.Text
        mul = no1 * no2
        txtResult.Text = mul
    End Sub
    Private Sub DivBtn_Click(sender As Object, e As EventArgs) Handles DivBtn.Click
        Dim no1 As Integer = txtNo1.Text
        Dim no2 As Integer = txtNo2.Text
        Dim div As Integer
        no1 = txtNo1.Text
        no2 = txtNo2.Text
        div = no1 / no2
        txtResult.Text = div
    End Sub
    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub
End Class