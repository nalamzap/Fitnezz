Public Class Kihon

	Dim MoDn As Boolean
	Dim x, y, fNum, n As Integer
	Dim kt As New List(Of String)
	'Moving the form#############################################################
	Private Sub Mm(sender As Object, e As MouseEventArgs) Handles Label1.MouseMove
		If MoDn = True Then
			If x = 0 And y = 0 Then
				x = Cursor.Position.X
				y = Cursor.Position.Y
			Else
				DesktopLocation = New Point(DesktopLocation.X - (x - Cursor.Position.X), DesktopLocation.Y - (y - Cursor.Position.Y))
				x = Cursor.Position.X
				y = Cursor.Position.Y
			End If
		End If
	End Sub

	Private Sub Md(sender As Object, e As MouseEventArgs) Handles Label1.MouseDown
		MoDn = True
	End Sub

	Private Sub Mu(sender As Object, e As MouseEventArgs) Handles Label1.MouseUp
		MoDn = False
		x = 0
		y = 0
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		KataV1.AxWindowsMediaPlayer1.Ctlcontrols.stop()
		KataV1.Visible = False
		Kata1.Visible = True
		GoBack.Visible = True
		Button1.Visible = False
	End Sub

	'Moving the form#############################################################
	Private Sub GoBack_Click(sender As Object, e As EventArgs) Handles GoBack.Click
		Karate.Show()
		My.Computer.FileSystem.CurrentDirectory = My.Computer.FileSystem.GetParentPath(My.Computer.FileSystem.CurrentDirectory)
		Close()

	End Sub

	Private Sub Kata_Load(sender As Object, e As EventArgs) Handles Me.Load
		n = 0
		x = 0
		y = 0
		Kata1.Label1.Text = "KATA TAIKYOKU SONO ICHI"
		My.Computer.FileSystem.CurrentDirectory = My.Computer.FileSystem.CurrentDirectory + "\kata"
		For Each file In My.Computer.FileSystem.GetFiles(My.Computer.FileSystem.CurrentDirectory)
			kt.Add(file)
		Next
		fNum = kt.Count
		Kata1.Button2.Visible = False
		If fNum > 0 Then
			Kata1.Label1.Text = kt(n).Substring(kt(n).LastIndexOf(Char.Parse("\")) + 3, kt(n).LastIndexOf(Char.Parse(".")) - kt(n).LastIndexOf(Char.Parse("\")) - 3)
			If Not (fNum > 1) Then
				Kata1.Button1.Visible = False
			End If
		End If
	End Sub

	Private Sub Kata1_ForeColorChanged(sender As Object, e As EventArgs) Handles Kata1.ForeColorChanged
		If Kata1.x = 1 Then
			n += 1
			Kata1.Label1.Text = kt(n).Substring(kt(n).LastIndexOf(Char.Parse("\")) + 3, kt(n).LastIndexOf(Char.Parse(".")) - kt(n).LastIndexOf(Char.Parse("\")) - 3)
			Kata1.Button2.Visible = True
			If n = fNum - 1 Then
				Kata1.Button1.Visible = False
			End If
		ElseIf Kata1.x = 2 Then
			n -= 1
			Kata1.Label1.Text = kt(n).Substring(kt(n).LastIndexOf(Char.Parse("\")) + 3, kt(n).LastIndexOf(Char.Parse(".")) - kt(n).LastIndexOf(Char.Parse("\")) - 3)
			Kata1.Button1.Visible = True
			If n = 0 Then
				Kata1.Button2.Visible = False
			End If
		ElseIf Kata1.x = 3 Then
			Kata1.Visible = False
			KataV1.Visible = True
			KataV1.AxWindowsMediaPlayer1.URL = kt(n)
			GoBack.Visible = False
			Button1.Visible = True

		End If
	End Sub
End Class