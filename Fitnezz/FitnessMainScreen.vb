
Public Class KW
	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Workout.Show()
		Close()
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		Kata.Show()
		Close()
	End Sub

	Private Sub Button_glow(sender As Object, e As EventArgs) Handles Button2.MouseEnter, Button1.MouseEnter
		DirectCast(sender, Button).Font = New Font("Monotype Corsiva", 28, FontStyle.Italic)
		DirectCast(sender, Button).ForeColor = Color.White
	End Sub

	Private Sub Button_dim(sender As Object, e As EventArgs) Handles Button2.MouseLeave, Button1.MouseLeave
		DirectCast(sender, Button).Font = New Font("Modern No. 20", 28, FontStyle.Italic)
		DirectCast(sender, Button).ForeColor = Color.Gainsboro
	End Sub

	Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
		Close()
	End Sub

	Private Sub MEnt(sender As Object, e As EventArgs) Handles Button4.MouseEnter
		Button4.ForeColor = Color.White
	End Sub

	Private Sub MLea(sender As Object, e As EventArgs) Handles Button4.MouseLeave
		Button4.ForeColor = Color.Silver
	End Sub

	Dim xw, yw As Short
	Dim MoDn As Boolean

	'Moving the form#############################################################
	Private Sub Mm(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
		If MoDn = True Then
			If xw = 0 And yw = 0 Then
				xw = Cursor.Position.X
				yw = Cursor.Position.Y
			Else
				DesktopLocation = New Point(DesktopLocation.X - (xw - Cursor.Position.X), DesktopLocation.Y - (yw - Cursor.Position.Y))
				xw = Cursor.Position.X
				yw = Cursor.Position.Y
			End If
		End If
	End Sub

	Private Sub Md(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
		MoDn = True
	End Sub

	Private Sub Mu(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
		MoDn = False
		xw = 0
		yw = 0
	End Sub
	'Moving the form#############################################################
End Class