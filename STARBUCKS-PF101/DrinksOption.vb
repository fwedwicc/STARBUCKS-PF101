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

        Dim oleato As New OleatoPanel()
        oleato.TopLevel = False
        oleato.FormBorderStyle = FormBorderStyle.None
        oleato.Dock = DockStyle.Fill
        MainForm.ContentPanel.Controls.Add(oleato)
        oleato.BringToFront()
        oleato.Show()
    End Sub

    Private Sub Guna2Button1_Click_1(sender As Object, e As EventArgs) Handles HotCoffeesBtn.Click
        Dim hotCoffeesForm As New HotCoffeesOptions()
        hotCoffeesForm.TopLevel = False
        hotCoffeesForm.FormBorderStyle = FormBorderStyle.None
        hotCoffeesForm.Dock = DockStyle.Fill
        MainForm.SideOptions.Controls.Add(hotCoffeesForm)
        hotCoffeesForm.BringToFront()
        hotCoffeesForm.Show()

        Dim americanos As New AmericanosPanel()
        americanos.TopLevel = False
        americanos.FormBorderStyle = FormBorderStyle.None
        americanos.Dock = DockStyle.Fill
        MainForm.ContentPanel.Controls.Add(americanos)
        americanos.BringToFront()
        americanos.Show()
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

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Dim frappuccinoForm As New FrappuccinoOptions()
        frappuccinoForm.TopLevel = False
        frappuccinoForm.FormBorderStyle = FormBorderStyle.None
        frappuccinoForm.Dock = DockStyle.Fill
        MainForm.SideOptions.Controls.Add(frappuccinoForm)
        frappuccinoForm.BringToFront()
        frappuccinoForm.Show()
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        Dim coldCoffeesForm As New ColdCoffeesOptions()
        coldCoffeesForm.TopLevel = False
        coldCoffeesForm.FormBorderStyle = FormBorderStyle.None
        coldCoffeesForm.Dock = DockStyle.Fill
        MainForm.SideOptions.Controls.Add(coldCoffeesForm)
        coldCoffeesForm.BringToFront()
        coldCoffeesForm.Show()
    End Sub

    Private Sub Guna2Button7_Click(sender As Object, e As EventArgs) Handles Guna2Button7.Click
        Dim icedTeasForm As New IcedTeasOptions()
        icedTeasForm.TopLevel = False
        icedTeasForm.FormBorderStyle = FormBorderStyle.None
        icedTeasForm.Dock = DockStyle.Fill
        MainForm.SideOptions.Controls.Add(icedTeasForm)
        icedTeasForm.BringToFront()
        icedTeasForm.Show()
    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        Dim coldDrinksForm As New ColdDrinksOptions()
        coldDrinksForm.TopLevel = False
        coldDrinksForm.FormBorderStyle = FormBorderStyle.None
        coldDrinksForm.Dock = DockStyle.Fill
        MainForm.SideOptions.Controls.Add(coldDrinksForm)
        coldDrinksForm.BringToFront()
        coldDrinksForm.Show()
    End Sub
End Class




