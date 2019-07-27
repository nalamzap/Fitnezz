<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Karate
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Karate))
		Me.GoBack = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'GoBack
		'
		Me.GoBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.GoBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.GoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.GoBack.Font = New System.Drawing.Font("Microsoft YaHei", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.GoBack.ForeColor = System.Drawing.Color.Silver
		Me.GoBack.Location = New System.Drawing.Point(-1, -4)
		Me.GoBack.Name = "GoBack"
		Me.GoBack.Size = New System.Drawing.Size(120, 51)
		Me.GoBack.TabIndex = 1
		Me.GoBack.Text = "<"
		Me.ToolTip1.SetToolTip(Me.GoBack, "Back to main window")
		Me.GoBack.UseVisualStyleBackColor = False
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.Label1.Cursor = System.Windows.Forms.Cursors.NoMove2D
		Me.Label1.Location = New System.Drawing.Point(118, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(733, 26)
		Me.Label1.TabIndex = 10
		Me.Label1.Text = resources.GetString("Label1.Text")
		Me.ToolTip1.SetToolTip(Me.Label1, "Drag to Move Window")
		'
		'ToolTip1
		'
		Me.ToolTip1.BackColor = System.Drawing.Color.MidnightBlue
		Me.ToolTip1.ForeColor = System.Drawing.Color.CornflowerBlue
		Me.ToolTip1.IsBalloon = True
		Me.ToolTip1.ToolTipTitle = "Info"
		'
		'Button1
		'
		Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
		Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button1.Font = New System.Drawing.Font("Monotype Corsiva", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button1.ForeColor = System.Drawing.Color.Silver
		Me.Button1.Location = New System.Drawing.Point(120, 172)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(254, 180)
		Me.Button1.TabIndex = 12
		Me.Button1.Text = "KIHON"
		Me.Button1.UseVisualStyleBackColor = False
		'
		'Button2
		'
		Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
		Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button2.Font = New System.Drawing.Font("Monotype Corsiva", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button2.ForeColor = System.Drawing.Color.Silver
		Me.Button2.Location = New System.Drawing.Point(420, 172)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(254, 180)
		Me.Button2.TabIndex = 13
		Me.Button2.Text = "KATA"
		Me.Button2.UseVisualStyleBackColor = False
		'
		'Karate
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.Silver
		Me.ClientSize = New System.Drawing.Size(800, 470)
		Me.ControlBox = False
		Me.Controls.Add(Me.Button2)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.GoBack)
		Me.Controls.Add(Me.Label1)
		Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "Karate"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Fitnezz"
		Me.TransparencyKey = System.Drawing.Color.Maroon
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents GoBack As Button
	Friend WithEvents Label1 As Label
	Friend WithEvents ToolTip1 As ToolTip
	Friend WithEvents Button1 As Button
	Friend WithEvents Button2 As Button
End Class
