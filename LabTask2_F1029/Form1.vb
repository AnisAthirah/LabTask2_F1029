Public Class Form1
    Private Sub RegistrationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrationToolStripMenuItem.Click
        Form2.Show()
        Me.Hide()
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("This program is design by Nur Anis Athirah Binti Mohamad Hadi, 10DDT20F1029, JTMK", MsgBoxStyle.Information, "About Menu Strip")
    End Sub
End Class
