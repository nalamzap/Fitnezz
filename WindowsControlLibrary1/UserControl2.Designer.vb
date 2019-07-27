<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class KataV
	Inherits System.Windows.Forms.UserControl

	'UserControl overrides dispose to clean up the component list.
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KataV))
		Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.Button3 = New System.Windows.Forms.Button()
		CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'AxWindowsMediaPlayer1
		'
		Me.AxWindowsMediaPlayer1.Enabled = True
		Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(138, -1)
		Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
		Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
		Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(525, 397)
		Me.AxWindowsMediaPlayer1.TabIndex = 0
		'
		'Button2
		'
		Me.Button2.BackgroundImage = Global.WindowsControlLibrary1.My.Resources.Resources.wind
		Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Silver
		Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
		Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
		Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button2.Font = New System.Drawing.Font("Lucida Calligraphy", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button2.Location = New System.Drawing.Point(582, -1)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(350, 397)
		Me.Button2.TabIndex = 4
		Me.Button2.Text = "+10 secs           " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
		Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Button2.UseVisualStyleBackColor = True
		'
		'Button3
		'
		Me.Button3.BackgroundImage = Global.WindowsControlLibrary1.My.Resources.Resources.rewind
		Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Silver
		Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
		Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
		Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button3.Font = New System.Drawing.Font("Lucida Calligraphy", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button3.Location = New System.Drawing.Point(-77, 0)
		Me.Button3.Name = "Button3"
		Me.Button3.Size = New System.Drawing.Size(350, 397)
		Me.Button3.TabIndex = 5
		Me.Button3.Text = "-10 secs           " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " "
		Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Button3.UseVisualStyleBackColor = True
		'
		'KataV
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.Silver
		Me.Controls.Add(Me.AxWindowsMediaPlayer1)
		Me.Controls.Add(Me.Button3)
		Me.Controls.Add(Me.Button2)
		Me.MaximumSize = New System.Drawing.Size(800, 400)
		Me.Name = "KataV"
		Me.Size = New System.Drawing.Size(800, 396)
		CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Public WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
	Friend WithEvents Button2 As Button
	Friend WithEvents Button3 As Button
End Class
