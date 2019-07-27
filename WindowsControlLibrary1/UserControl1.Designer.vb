<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class kata
	Inherits System.Windows.Forms.UserControl

	'UserControl1 overrides dispose to clean up the component list.
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
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Button3 = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'Button1
		'
		Me.Button1.BackColor = System.Drawing.Color.Transparent
		Me.Button1.BackgroundImage = Global.WindowsControlLibrary1.My.Resources.Resources.rt
		Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
		Me.Button1.Dock = System.Windows.Forms.DockStyle.Right
		Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Silver
		Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
		Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
		Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button1.Location = New System.Drawing.Point(706, 0)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(94, 400)
		Me.Button1.TabIndex = 0
		Me.Button1.UseVisualStyleBackColor = False
		'
		'Button2
		'
		Me.Button2.BackColor = System.Drawing.Color.Transparent
		Me.Button2.BackgroundImage = Global.WindowsControlLibrary1.My.Resources.Resources.lt
		Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
		Me.Button2.Dock = System.Windows.Forms.DockStyle.Left
		Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Silver
		Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
		Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
		Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button2.Location = New System.Drawing.Point(0, 0)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(94, 400)
		Me.Button2.TabIndex = 1
		Me.Button2.UseVisualStyleBackColor = False
		'
		'Label1
		'
		Me.Label1.BackColor = System.Drawing.Color.Transparent
		Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.Label1.Location = New System.Drawing.Point(94, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(612, 400)
		Me.Label1.TabIndex = 2
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Button3
		'
		Me.Button3.BackColor = System.Drawing.Color.Transparent
		Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
		Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Silver
		Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
		Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
		Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button3.Font = New System.Drawing.Font("Lucida Calligraphy", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button3.Location = New System.Drawing.Point(339, 294)
		Me.Button3.Name = "Button3"
		Me.Button3.Size = New System.Drawing.Size(126, 78)
		Me.Button3.TabIndex = 4
		Me.Button3.Text = "Watch"
		Me.Button3.UseVisualStyleBackColor = False
		'
		'kata
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.Silver
		Me.BackgroundImage = Global.WindowsControlLibrary1.My.Resources.Resources._15
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Controls.Add(Me.Button3)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.Button2)
		Me.Controls.Add(Me.Button1)
		Me.DoubleBuffered = True
		Me.MaximumSize = New System.Drawing.Size(800, 400)
		Me.Name = "kata"
		Me.Size = New System.Drawing.Size(800, 400)
		Me.ResumeLayout(False)

	End Sub

	Public WithEvents Button1 As Button
	Public WithEvents Button2 As Button
	Public WithEvents Label1 As Label
	Public WithEvents Button3 As Button
End Class
