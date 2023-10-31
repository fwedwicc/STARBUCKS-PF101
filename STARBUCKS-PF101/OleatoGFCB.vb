Public Class OleatoGFCB
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub OleatoGFCB_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Guna2Button7_Click(sender As Object, e As EventArgs) Handles Guna2Button7.Click
        ' Get the selected item from the add-ons ComboBox

        Dim defaultPrice As Integer = 120
        Dim addOnPrices As New Dictionary(Of String, Integer) From {
            {"No Syrup", 0},
            {"Apple Brown Sugar", 50},
            {"Brown Sugar Syrup", 70},
            {"Caramel Syrup", 90}
        }

        Dim selectedAddOn As String = ComboBox1.SelectedItem.ToString()

        ' Calculate the total price based on the default price and selected add-on price
        Dim total As Integer = defaultPrice + addOnPrices(selectedAddOn)

        ' Display the total price in the totalLabel
        MainForm.Label5.Text = total.ToString() & ".00 PHP"

        ' Add the selected item with its price to the cart (if needed)
        'cartComboBox.Items.Add(selectedAddOn & " - $" & addOnPrices(selectedAddOn))






    End Sub
End Class