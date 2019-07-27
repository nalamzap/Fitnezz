<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class KW
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KW))
		Me.Button2 = New System.Windows.Forms.Button()
		Me.Button3 = New System.Windows.Forms.Button()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Button4 = New System.Windows.Forms.Button()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
		Me.SuspendLayout()
		'
		'Button2
		'
		Me.Button2.BackColor = System.Drawing.Color.Transparent
		Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
		Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Black
		Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
		Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
		Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button2.Font = New System.Drawing.Font("Modern No. 20", 27.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button2.ForeColor = System.Drawing.Color.Gainsboro
		Me.Button2.Location = New System.Drawing.Point(34, 118)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(330, 220)
		Me.Button2.TabIndex = 1
		Me.Button2.Text = "Kata"
		Me.Button2.UseMnemonic = False
		Me.Button2.UseVisualStyleBackColor = False
		'
		'Button3
		'
		Me.Button3.BackColor = System.Drawing.Color.Transparent
		Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
		Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
		Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
		Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
		Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
		Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.Button3.Location = New System.Drawing.Point(762, 426)
		Me.Button3.Name = "Button3"
		Me.Button3.Size = New System.Drawing.Size(55, 43)
		Me.Button3.TabIndex = 2
		Me.ToolTip1.SetToolTip(Me.Button3, "Application Settings")
		Me.Button3.UseVisualStyleBackColor = False
		'
		'Button1
		'
		Me.Button1.BackColor = System.Drawing.Color.Transparent
		Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
		Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Black
		Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
		Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
		Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button1.Font = New System.Drawing.Font("Modern No. 20", 27.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button1.ForeColor = System.Drawing.Color.Gainsboro
		Me.Button1.Location = New System.Drawing.Point(459, 118)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(330, 220)
		Me.Button1.TabIndex = 0
		Me.Button1.Text = "Workout"
		Me.Button1.UseVisualStyleBackColor = False
		'
		'Button4
		'
		Me.Button4.BackColor = System.Drawing.Color.DarkSlateBlue
		Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue
		Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue
		Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue
		Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button4.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button4.ForeColor = System.Drawing.Color.Silver
		Me.Button4.Location = New System.Drawing.Point(15, 12)
		Me.Button4.Name = "Button4"
		Me.Button4.Size = New System.Drawing.Size(30, 27)
		Me.Button4.TabIndex = 16
		Me.Button4.Text = "X"
		Me.ToolTip1.SetToolTip(Me.Button4, "Closes Application")
		Me.Button4.UseVisualStyleBackColor = False
		'
		'ToolTip1
		'
		Me.ToolTip1.BackColor = System.Drawing.Color.MidnightBlue
		Me.ToolTip1.ForeColor = System.Drawing.Color.CornflowerBlue
		Me.ToolTip1.IsBalloon = True
		Me.ToolTip1.ToolTipTitle = "Info"
		'
		'KW
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.ClientSize = New System.Drawing.Size(820, 470)
		Me.ControlBox = False
		Me.Controls.Add(Me.Button4)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.Button3)
		Me.Controls.Add(Me.Button2)
		Me.ForeColor = System.Drawing.SystemColors.ControlText
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "KW"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Fitnezz"
		Me.TransparencyKey = System.Drawing.Color.Black
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
	Friend WithEvents Button4 As Button
	Friend WithEvents ToolTip1 As ToolTip
End Class
