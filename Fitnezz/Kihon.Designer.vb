﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Kihon
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Kihon))
		Me.Label1 = New System.Windows.Forms.Label()
		Me.GoBack = New System.Windows.Forms.Button()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.KataV1 = New WindowsControlLibrary1.KataV()
		Me.Kata1 = New WindowsControlLibrary1.kata()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.Label1.Cursor = System.Windows.Forms.Cursors.NoMove2D
		Me.Label1.Location = New System.Drawing.Point(0, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(811, 26)
		Me.Label1.TabIndex = 11
		Me.Label1.Text = resources.GetString("Label1.Text")
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
		Me.GoBack.TabIndex = 12
		Me.GoBack.Text = "<"
		Me.GoBack.UseVisualStyleBackColor = False
		'
		'Button1
		'
		Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
		Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button1.Font = New System.Drawing.Font("MT Extra", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
		Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
		Me.Button1.Location = New System.Drawing.Point(378, 26)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(44, 44)
		Me.Button1.TabIndex = 15
		Me.Button1.Text = "0"
		Me.Button1.UseVisualStyleBackColor = False
		Me.Button1.Visible = False
		'
		'KataV1
		'
		Me.KataV1.BackColor = System.Drawing.Color.Silver
		Me.KataV1.Location = New System.Drawing.Point(0, 69)
		Me.KataV1.MaximumSize = New System.Drawing.Size(800, 400)
		Me.KataV1.Name = "KataV1"
		Me.KataV1.Size = New System.Drawing.Size(800, 400)
		Me.KataV1.TabIndex = 14
		Me.KataV1.Visible = False
		'
		'Kata1
		'
		Me.Kata1.BackColor = System.Drawing.Color.Silver
		Me.Kata1.BackgroundImage = CType(resources.GetObject("Kata1.BackgroundImage"), System.Drawing.Image)
		Me.Kata1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Kata1.Location = New System.Drawing.Point(1, 53)
		Me.Kata1.MaximumSize = New System.Drawing.Size(800, 400)
		Me.Kata1.Name = "Kata1"
		Me.Kata1.Size = New System.Drawing.Size(800, 400)
		Me.Kata1.TabIndex = 13
		'
		'Kihon
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.Silver
		Me.ClientSize = New System.Drawing.Size(800, 470)
		Me.ControlBox = False
		Me.Controls.Add(Me.GoBack)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.Kata1)
		Me.Controls.Add(Me.KataV1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "Kihon"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Fitnezz"
		Me.TransparencyKey = System.Drawing.Color.Red
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents Label1 As Label
	Friend WithEvents GoBack As Button
	Friend WithEvents Kata1 As WindowsControlLibrary1.kata
	Friend WithEvents KataV1 As WindowsControlLibrary1.KataV
	Friend WithEvents Button1 As Button
End Class