Public Class Karate
	Dim MoDn As Boolean
	Dim x, y As Integer
	Private Sub GoBack_Click(sender As Object, e As EventArgs) Handles GoBack.Click
		FitnezzMainScreen.Show()
		Close()
	End Sub

	Private Sub Kata_Load(sender As Object, e As EventArgs) Handles Me.Load
		x = 0
		y = 0

	End Sub
	'Moving the form#############################################################
	Private Sub Mm(sender As Object, e As MouseEventArgs) Handles Label1.MouseMove
		If MoDn Then
			If x = 0 And y = 0 Then
				x = Cursor.Position.X
				y = Cursor.Position.Y
			Else
				Me.DesktopLocation = New Point(Me.DesktopLocation.X - (x - Cursor.Position.X), Me.DesktopLocation.Y - (y - Cursor.Position.Y))
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
	'Moving the form#############################################################

	'Change the button color on mouse movements#####################################
	Private Sub Button_MouseEnter(sender As Object, e As EventArgs) Handles Button2.MouseEnter, Button1.MouseEnter
		DirectCast(sender, Button).BackColor = Color.FromArgb(70, 70, 70)
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		Kata.Show()
		Close()
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Kihon.Show()
		Close()
	End Sub

	Private Sub Button_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave, Button1.MouseLeave
		DirectCast(sender, Button).BackColor = Color.FromArgb(50, 50, 50)
	End Sub
	'Change the button color on mouse movements#####################################
End Class