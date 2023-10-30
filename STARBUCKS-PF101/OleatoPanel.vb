Public Class OleatoPanel
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub OleatoPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim gfcbOrder As New OleatoGFCB()
        gfcbOrder.TopLevel = False
        gfcbOrder.FormBorderStyle = FormBorderStyle.None
        gfcbOrder.Dock = DockStyle.Fill
        MainForm.ContentPanel.Controls.Add(gfcbOrder)
        gfcbOrder.BringToFront()
        gfcbOrder.Show()
    End Sub
End Class