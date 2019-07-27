<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Workout
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Workout))
		Me.GoBack = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.CMS = New System.Windows.Forms.ContextMenuStrip(Me.components)
		Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
		Me.Button6 = New System.Windows.Forms.Button()
		Me.Button7 = New System.Windows.Forms.Button()
		Me.Button5 = New System.Windows.Forms.Button()
		Me.Button4 = New System.Windows.Forms.Button()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Button3 = New System.Windows.Forms.Button()
		Me.CMS.SuspendLayout()
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
		Me.GoBack.TabIndex = 7
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
		Me.Label1.TabIndex = 9
		Me.Label1.Text = resources.GetString("Label1.Text")
		Me.ToolTip1.SetToolTip(Me.Label1, "Drag to Move Window")
		'
		'CMS
		'
		Me.CMS.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.CMS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem})
		Me.CMS.Name = "CMS"
		Me.CMS.ShowImageMargin = False
		Me.CMS.ShowItemToolTips = False
		Me.CMS.Size = New System.Drawing.Size(147, 29)
		'
		'SettingsToolStripMenuItem
		'
		Me.SettingsToolStripMenuItem.AutoSize = False
		Me.SettingsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.SettingsToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
		Me.SettingsToolStripMenuItem.Font = New System.Drawing.Font("Lucida Calligraphy", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.SettingsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight
		Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
		Me.SettingsToolStripMenuItem.ShowShortcutKeys = False
		Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(150, 25)
		Me.SettingsToolStripMenuItem.Text = "     Settings"
		'
		'ToolTip1
		'
		Me.ToolTip1.BackColor = System.Drawing.Color.MidnightBlue
		Me.ToolTip1.ForeColor = System.Drawing.Color.CornflowerBlue
		Me.ToolTip1.IsBalloon = True
		Me.ToolTip1.ToolTipTitle = "Info"
		'
		'Button6
		'
		Me.Button6.BackgroundImage = CType(resources.GetObject("Button6.BackgroundImage"), System.Drawing.Image)
		Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Button6.ContextMenuStrip = Me.CMS
		Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
		Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.Silver
		Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
		Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
		Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button6.Font = New System.Drawing.Font("Modern No. 20", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button6.ForeColor = System.Drawing.Color.Black
		Me.Button6.Location = New System.Drawing.Point(330, 262)
		Me.Button6.Margin = New System.Windows.Forms.Padding(29)
		Me.Button6.Name = "Button6"
		Me.Button6.Size = New System.Drawing.Size(183, 183)
		Me.Button6.TabIndex = 5
		Me.Button6.Text = "Custom workout"
		Me.Button6.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.ToolTip1.SetToolTip(Me.Button6, "Right Click for menu")
		Me.Button6.UseVisualStyleBackColor = True
		'
		'Button7
		'
		Me.Button7.BackgroundImage = CType(resources.GetObject("Button7.BackgroundImage"), System.Drawing.Image)
		Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Button7.Cursor = System.Windows.Forms.Cursors.Hand
		Me.Button7.FlatAppearance.BorderColor = System.Drawing.Color.Silver
		Me.Button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
		Me.Button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
		Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button7.Font = New System.Drawing.Font("Modern No. 20", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button7.ForeColor = System.Drawing.Color.Black
		Me.Button7.Location = New System.Drawing.Point(542, 262)
		Me.Button7.Margin = New System.Windows.Forms.Padding(0)
		Me.Button7.Name = "Button7"
		Me.Button7.Size = New System.Drawing.Size(183, 183)
		Me.Button7.TabIndex = 6
		Me.Button7.Text = "Sleepy time stretch"
		Me.Button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Button7.UseVisualStyleBackColor = True
		'
		'Button5
		'
		Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
		Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
		Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.Silver
		Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
		Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
		Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button5.Font = New System.Drawing.Font("Modern No. 20", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button5.ForeColor = System.Drawing.Color.White
		Me.Button5.Location = New System.Drawing.Point(118, 262)
		Me.Button5.Margin = New System.Windows.Forms.Padding(0)
		Me.Button5.Name = "Button5"
		Me.Button5.Size = New System.Drawing.Size(183, 183)
		Me.Button5.TabIndex = 4
		Me.Button5.Text = "Classic   " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "workout   " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " "
		Me.Button5.TextAlign = System.Drawing.ContentAlignment.BottomRight
		Me.Button5.UseVisualStyleBackColor = True
		'
		'Button4
		'
		Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
		Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
		Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.Silver
		Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
		Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
		Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button4.Font = New System.Drawing.Font("Modern No. 20", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button4.ForeColor = System.Drawing.Color.Black
		Me.Button4.Location = New System.Drawing.Point(644, 52)
		Me.Button4.Margin = New System.Windows.Forms.Padding(0)
		Me.Button4.Name = "Button4"
		Me.Button4.Size = New System.Drawing.Size(183, 183)
		Me.Button4.TabIndex = 3
		Me.Button4.Text = "            w" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "            o" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   L       r" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    e       k" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    g       o" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "       " &
	"      u" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "             t"
		Me.Button4.UseVisualStyleBackColor = True
		'
		'Button2
		'
		Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
		Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
		Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Silver
		Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
		Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
		Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button2.Font = New System.Drawing.Font("Modern No. 20", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button2.ForeColor = System.Drawing.Color.Black
		Me.Button2.Location = New System.Drawing.Point(226, 52)
		Me.Button2.Margin = New System.Windows.Forms.Padding(0)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(183, 183)
		Me.Button2.TabIndex = 1
		Me.Button2.Text = "Butt" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "workout"
		Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Button2.UseVisualStyleBackColor = True
		'
		'Button1
		'
		Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
		Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
		Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Silver
		Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
		Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
		Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button1.Font = New System.Drawing.Font("Modern No. 20", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button1.ForeColor = System.Drawing.Color.White
		Me.Button1.Location = New System.Drawing.Point(16, 52)
		Me.Button1.Margin = New System.Windows.Forms.Padding(29)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(183, 183)
		Me.Button1.TabIndex = 0
		Me.Button1.Text = "Abs" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "workout"
		Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.Button1.UseVisualStyleBackColor = True
		'
		'Button3
		'
		Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
		Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
		Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Silver
		Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
		Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
		Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button3.Font = New System.Drawing.Font("Modern No. 20", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button3.ForeColor = System.Drawing.Color.White
		Me.Button3.Location = New System.Drawing.Point(434, 52)
		Me.Button3.Margin = New System.Windows.Forms.Padding(29)
		Me.Button3.Name = "Button3"
		Me.Button3.Size = New System.Drawing.Size(183, 183)
		Me.Button3.TabIndex = 2
		Me.Button3.Text = "Arm workout"
		Me.Button3.UseVisualStyleBackColor = True
		'
		'Workout
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.Silver
		Me.ClientSize = New System.Drawing.Size(843, 470)
		Me.Controls.Add(Me.Button6)
		Me.Controls.Add(Me.GoBack)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.Button7)
		Me.Controls.Add(Me.Button5)
		Me.Controls.Add(Me.Button4)
		Me.Controls.Add(Me.Button2)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.Button3)
		Me.ForeColor = System.Drawing.Color.Black
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "Workout"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.CMS.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Button1 As Button
	Friend WithEvents Button2 As Button
	Friend WithEvents Button3 As Button
	Friend WithEvents Button4 As Button
	Friend WithEvents Button5 As Button
	Friend WithEvents Button6 As Button
	Friend WithEvents Button7 As Button
	Friend WithEvents GoBack As Button
	Friend WithEvents Label1 As Label
	Friend WithEvents CMS As ContextMenuStrip
	Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ToolTip1 As ToolTip
End Class
