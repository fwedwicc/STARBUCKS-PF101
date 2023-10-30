Public Class OleatoOptions
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim oleato As New OleatoPanel()
        oleato.TopLevel = False
        oleato.FormBorderStyle = FormBorderStyle.None
        oleato.Dock = DockStyle.Fill
        MainForm.ContentPanel.Controls.Add(oleato)
        oleato.BringToFront()
        oleato.Show()
    End Sub
End Class