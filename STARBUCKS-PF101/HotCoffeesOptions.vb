Imports Guna.UI2.WinForms

Public Class HotCoffeesOptions
    Friend Sub ShowInPanel(sideOptions As Guna2Panel)
        Throw New NotImplementedException()
    End Sub

    Private Sub HotCoffeesOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim americanos As New AmericanosPanel()
        americanos.TopLevel = False
        americanos.FormBorderStyle = FormBorderStyle.None
        americanos.Dock = DockStyle.Fill
        MainForm.ContentPanel.Controls.Add(americanos)
        americanos.BringToFront()
        americanos.Show()
    End Sub
End Class