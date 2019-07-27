Public Class Workout
    Dim MoDn As Boolean
	Dim x, y As Integer
	'Workout options#############################################################
	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		WEx.Tag = 1
		WEx.Show()
		Close()
	End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		WEx.Tag = 2
		WEx.Show()
		Close()
	End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
		WEx.Tag = 3
		WEx.Show()
		Close()
	End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        WEx.Tag = 4
        WEx.Show()
        Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        WEx.Tag = 5
        WEx.Show()
        Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
		If GetSetting("KWorkout", "CustomWS", "cws", "0") = "0" Then
			'If the custom exercises are not initialised it opens the settings of custom workout
			CustomWS.Show()
			Me.Enabled = False

		Else
			WEx.Tag = 6
			WEx.Show()
			Close()
		End If
	End Sub

	Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
		WEx.Tag = 7
		WEx.Show()
		Close()
	End Sub
	'Workout options#############################################################
	'Moving the form#############################################################
	Private Sub Md(sender As Object, e As MouseEventArgs) Handles Label1.MouseDown
        MoDn = True
    End Sub

    Private Sub Mu(sender As Object, e As MouseEventArgs) Handles Label1.MouseUp
        MoDn = False
        x = 0
        y = 0
    End Sub

    Private Sub Mm(sender As Object, e As MouseEventArgs) Handles Label1.MouseMove
        If MoDn = True Then
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
	'Moving the form#############################################################
	Private Sub GoBack_Click(sender As Object, e As EventArgs) Handles GoBack.Click
		FitnezzMainScreen.Show()
		Close()
	End Sub

	Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
		CustomWS.Show()
		Me.Enabled = False
	End Sub

	Private Sub Workout_Load(sender As Object, e As EventArgs) Handles Me.Load
		x = 0
		y = 0
	End Sub
End Class