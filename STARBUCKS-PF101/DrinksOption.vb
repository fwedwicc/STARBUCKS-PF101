Imports System.Web.UI.WebControls

Public Class DrinksOption
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim oleatosForm As New OleatoOptions()
        oleatosForm.TopLevel = False
        oleatosForm.FormBorderStyle = FormBorderStyle.None
        oleatosForm.Dock = DockStyle.Fill
        MainForm.SideOptions.Controls.Add(oleatosForm)
        oleatosForm.BringToFront()
        oleatosForm.Show()
    End Sub

    Private Sub Guna2Button1_Click_1(sender As Object, e As EventArgs) Handles HotCoffeesBtn.Click
        Dim hotCoffeesForm As New HotCoffeesOptions()
        hotCoffeesForm.TopLevel = False
        hotCoffeesForm.FormBorderStyle = FormBorderStyle.None
        hotCoffeesForm.Dock = DockStyle.Fill
        MainForm.SideOptions.Controls.Add(hotCoffeesForm)
        hotCoffeesForm.BringToFront()
        hotCoffeesForm.Show()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim hotTeasForm As New HotTeasOptions()
        hotTeasForm.TopLevel = False
        hotTeasForm.FormBorderStyle = FormBorderStyle.None
        hotTeasForm.Dock = DockStyle.Fill
        MainForm.SideOptions.Controls.Add(hotTeasForm)
        hotTeasForm.BringToFront()
        hotTeasForm.Show()
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Dim hotDrinksForm As New HotDrinksOptions()
        hotDrinksForm.TopLevel = False
        hotDrinksForm.FormBorderStyle = FormBorderStyle.None
        hotDrinksForm.Dock = DockStyle.Fill
        MainForm.SideOptions.Controls.Add(hotDrinksForm)
        hotDrinksForm.BringToFront()
        hotDrinksForm.Show()
    End Sub
End Class




