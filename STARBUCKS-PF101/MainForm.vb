Imports Guna.UI2.WinForms

Public Class MainForm



    Public Property HotCoffeesBtn As Object

    Private Sub Guna2Button1_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2Button4.CheckedChanged, Guna2Button3.CheckedChanged, Guna2Button2.CheckedChanged, Guna2Button.CheckedChanged

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        ImageSlide.Location = New Point(69, 240)
        ImageSlide.SendToBack()
        Dim foods As New FoodsOption()
        foods.TopLevel = False
        foods.Dock = DockStyle.Fill
        OptionPanel.Controls.Add(foods)
        foods.BringToFront()
        foods.Show()

        Dim hotBreakfastForm As New HotBreakfastOptions()
        hotBreakfastForm.TopLevel = False
        hotBreakfastForm.FormBorderStyle = FormBorderStyle.None
        hotBreakfastForm.Dock = DockStyle.Fill
        Me.SideOptions.Controls.Add(hotBreakfastForm)
        hotBreakfastForm.BringToFront()
        hotBreakfastForm.Show()

        Label1.Text = "Foods"
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        ImageSlide.Location = New Point(69, 330)
        ImageSlide.SendToBack()

        Label1.Text = "At Home"
    End Sub

    Private Sub Guna2Button_Click(sender As Object, e As EventArgs) Handles Guna2Button.Click
        ImageSlide.Location = New Point(69, 145)
        ImageSlide.SendToBack()
        Dim drinks As New DrinksOption()
        drinks.TopLevel = False
        drinks.Dock = DockStyle.Fill
        OptionPanel.Controls.Add(drinks)
        drinks.BringToFront()
        drinks.Show()

        Dim oleatosForm As New OleatoOptions()
        oleatosForm.TopLevel = False
        oleatosForm.FormBorderStyle = FormBorderStyle.None
        oleatosForm.Dock = DockStyle.Fill
        Me.SideOptions.Controls.Add(oleatosForm)
        oleatosForm.BringToFront()
        oleatosForm.Show()

        Dim oleato As New OleatoPanel()
        oleato.TopLevel = False
        oleato.FormBorderStyle = FormBorderStyle.None
        oleato.Dock = DockStyle.Fill
        Me.ContentPanel.Controls.Add(oleato)
        oleato.BringToFront()
        oleato.Show()

        Label1.Text = "Drinks"
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        ImageSlide.Location = New Point(69, 423)
        ImageSlide.SendToBack()

        Label1.Text = "Merch"
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(65, 30)
        Me.StartPosition = FormStartPosition.CenterScreen
        ' Set the AutoSize property to False.
        Me.AutoSize = False
        ' Set the MinimumSize property to the assigned width and height.
        Me.MinimumSize = New Size(1400, 757)
        ' Set the MaximumSize property to the assigned width and height.
        Me.MaximumSize = New Size(1400, 757)
        ' Set the AutoScaleMode property to Font.
        Me.AutoScaleMode = AutoScaleMode.Font
    End Sub

    Private Sub OptionPanel_Paint(sender As Object, e As PaintEventArgs) Handles OptionPanel.Paint
        Dim drinks As New DrinksOption()
        drinks.TopLevel = False
        drinks.Dock = DockStyle.Fill
        OptionPanel.Controls.Add(drinks)
        drinks.BringToFront()
        drinks.Show()
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click

    End Sub

    Private Sub SideOptions_Paint(sender As Object, e As PaintEventArgs) Handles SideOptions.Paint
        Dim oleatosForm As New OleatoOptions()
        oleatosForm.TopLevel = False
        oleatosForm.FormBorderStyle = FormBorderStyle.None
        oleatosForm.Dock = DockStyle.Fill
        Me.SideOptions.Controls.Add(oleatosForm)
        oleatosForm.BringToFront()
        oleatosForm.Show()
    End Sub

    Friend Shared Function Instance() As Object
        Throw New NotImplementedException()
    End Function

    Private Sub ContentPanel_Paint(sender As Object, e As PaintEventArgs) Handles ContentPanel.Paint
        Dim oleato As New OleatoPanel()
        oleato.TopLevel = False
        oleato.FormBorderStyle = FormBorderStyle.None
        oleato.Dock = DockStyle.Fill
        Me.ContentPanel.Controls.Add(oleato)
        oleato.BringToFront()
        oleato.Show()
    End Sub
End Class
