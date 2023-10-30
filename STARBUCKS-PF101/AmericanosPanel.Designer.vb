<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AmericanosPanel
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AmericanosPanel))
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.BorderColor = System.Drawing.Color.Empty
        Me.Guna2Button1.BorderRadius = 10
        Me.Guna2Button1.BorderThickness = 2
        Me.Guna2Button1.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.Guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Button1.CustomImages.ImageOffset = New System.Drawing.Point(-10, 47)
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Guna2Button1.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.Guna2Button1.Image = CType(resources.GetObject("Guna2Button1.Image"), System.Drawing.Image)
        Me.Guna2Button1.ImageOffset = New System.Drawing.Point(0, 20)
        Me.Guna2Button1.ImageSize = New System.Drawing.Size(100, 95)
        Me.Guna2Button1.Location = New System.Drawing.Point(3, 4)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.PressedColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.Guna2Button1.Size = New System.Drawing.Size(185, 241)
        Me.Guna2Button1.TabIndex = 3
        Me.Guna2Button1.Text = "Starbucks Caffe Americano"
        Me.Guna2Button1.TextOffset = New System.Drawing.Point(0, 20)
        '
        'AmericanosPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(987, 500)
        Me.Controls.Add(Me.Guna2Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AmericanosPanel"
        Me.Text = "AmericanosPanel"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
End Class
