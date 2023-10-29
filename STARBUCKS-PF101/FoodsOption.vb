Public Class FoodsOption
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim hotBreakfastForm As New HotBreakfastOptions()
        hotBreakfastForm.TopLevel = False
        hotBreakfastForm.FormBorderStyle = FormBorderStyle.None
        hotBreakfastForm.Dock = DockStyle.Fill
        MainForm.SideOptions.Controls.Add(hotBreakfastForm)
        hotBreakfastForm.BringToFront()
        hotBreakfastForm.Show()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim outmealAndYogurtForm As New OutmealandYogurtOptions()
        outmealAndYogurtForm.TopLevel = False
        outmealAndYogurtForm.FormBorderStyle = FormBorderStyle.None
        outmealAndYogurtForm.Dock = DockStyle.Fill
        MainForm.SideOptions.Controls.Add(outmealAndYogurtForm)
        outmealAndYogurtForm.BringToFront()
        outmealAndYogurtForm.Show()
    End Sub
End Class