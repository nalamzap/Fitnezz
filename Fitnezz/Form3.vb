Public Class WEx
	Dim x, y, xw, yw, n, i, time As Integer
	Dim SAPI As Object
	Dim Exs(14), s As String
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
	Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.PerformStep()
        Check()
    End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Size = New Point(843, 470)
		Location = New Point(Location.X - 251, Location.Y)
		Button2.Enabled = True
		Button2.Visible = True
		ProgressBar1.Visible = True
		Button4.Visible = False
		ProgressBar1.Enabled = True
		Timer1.Start()
		Button1.Enabled = False
	End Sub

	Private Sub Check()
		If x = 1 Then
			If ProgressBar1.Value = 2 Then
				wmp.URL = "eData/" & Exs(y) & ".mp4"
				wmp.settings.playCount = 9
				SAPI.speak("Start with ," & Exs(y))
			ElseIf ProgressBar1.Value = 135 Then
				x = 2
				ProgressBar1.Maximum = time

				ProgressBar1.Value = 0
			End If

		ElseIf x Mod 2 = 1 Then
			If ProgressBar1.Value = 2 Then
				wmp.URL = "eData/" & Exs(y) & ".mp4"
				wmp.settings.playCount = 9
				SAPI.speak("Take a rest, to next ," & Exs(y))
			ElseIf ProgressBar1.Value = 135 Then
				x += 1
				ProgressBar1.Maximum = time
				ProgressBar1.Value = 0
			End If
		Else
			If ProgressBar1.Value = 2 Then
				SAPI.speak("Do the exercise ," & Exs(y))
			ElseIf ProgressBar1.Value = time Then
				x += 1
				y += 1
				ProgressBar1.Maximum = 135
				ProgressBar1.Value = 0
			End If
		End If
		If y = n Then
			Timer1.Stop()
			wmp.Ctlcontrols.stop()
			SAPI.speak("Well done! You have done the exercises!")
			Workout.Show()
			Close()
		End If
	End Sub

	Private Sub WEx_Load(sender As Object, e As EventArgs) Handles Me.Load
		time = 270
		Exs(0) = ""
		Exs(1) = ""
		Exs(2) = ""
		Exs(3) = ""
		Exs(4) = ""
		Exs(5) = ""
		Exs(6) = ""
		Exs(7) = ""
		Exs(8) = ""
		Exs(9) = ""
		Exs(10) = ""
		Exs(11) = ""
		Exs(12) = ""
		Exs(13) = ""
		i = 3
		If Me.Tag = 1 Then
			n = 14
			Exs(0) = "JUMPING SQUATS"
			Exs(1) = "REVERSE CRUNCHES"
			Exs(2) = "STRAIGHT-ARM PLANK"
			Exs(3) = "RUSSIAN TWIST"
			Exs(4) = "BIRD DOG"
			Exs(5) = "BURPEES"
			Exs(6) = "LONG ARM CRUNCHES"
			Exs(7) = "ONE LEG BRIDGE"
			Exs(8) = "ONE LEG PUSH-UPS"
			Exs(9) = "PLANK"
			Exs(10) = "CROSS ARM CRUNCHES"
			Exs(11) = "MOUNTAIN CLIMBER"
			Exs(12) = "BRIDGE"
			Exs(13) = "BICYCLE CRUNCHES"
		ElseIf Me.Tag = 2 Then
			n = 12
			Exs(0) = "SQUATS"
			Exs(1) = "FROGGY GLUTE LIFTS"
			Exs(2) = "LUNGES"
			Exs(3) = "BUTT BRIDGE"
			Exs(4) = "DONKEY KICKS LEFT"
			Exs(5) = "SPLIT SQUAT RIGHT"
			Exs(6) = "FIRE HYDRANT LEFT"
			Exs(7) = "FIRE HYDRANT RIGHT"
			Exs(8) = "PLIE SQUATS"
			Exs(9) = "DONKEY KICKS RIGHT"
			Exs(10) = "SUMO SQUAT CALF RAISES"
			Exs(11) = "SPLIT SQUAT LEFT"
			Exs(12) = ""
			Exs(13) = ""
		ElseIf Me.Tag = 3 Then
			n = 14
			Exs(0) = "SIDE ARM RAISE"
			Exs(1) = "PUSH-UPS"
			Exs(2) = "TRICEP DIPS"
			Exs(3) = "DIAMOND PUSH-UPS"
			Exs(4) = "PUNCHES"
			Exs(5) = "UP AND DOWN PLANK"
			Exs(6) = "SHOULDER STRETCH"
			Exs(7) = "ARM CIRCLES"
			Exs(8) = "REVERSE PUSH-UPS"
			Exs(9) = "PUNCHES"
			Exs(10) = "ONE LEG PUSH-UPS"
			Exs(11) = "PLANK TAPS"
			Exs(12) = "TRICEP STRETCH LEFT"
			Exs(13) = "TRICEP STRETCH RIGHT"
		ElseIf Me.Tag = 4 Then
			n = 13
			Exs(0) = "CALF RAISES"
			Exs(1) = "CURTSY LUNGES"
			Exs(2) = "SINGLE LEFT LEG CALF RAISES"
			Exs(3) = "SIDE LUNGES"
			Exs(4) = "LEFT LUNGE KNEE HOPS"
			Exs(5) = "SINGLE RIGHT LEG CALF RAISES"
			Exs(6) = "BOTTOM LEG LIFT LEFT"
			Exs(7) = "BOTTOM LEG LIFT RIGHT"
			Exs(8) = "RIGHT LUNGE KNEE HOPS"
			Exs(9) = "SIDE LEG CIRCLES LEFT"
			Exs(10) = "SIDE LEG CIRCLES RIGHT"
			Exs(11) = "LEFT LUNGE WITH FRONT KICK"
			Exs(12) = "RIGHT LUNGE WITH FRONT KICK"
			Exs(13) = ""
		ElseIf Me.Tag = 5 Then
			n = 13
			Exs(0) = "JUMPING JACKS"
			Exs(1) = "WALL SIT"
			Exs(2) = "PUSH-UPS"
			Exs(3) = "ABDOMINAL CRUNCHES"
			Exs(4) = "STEP-UP ONTO CHAIR"
			Exs(5) = "SQUATS"
			Exs(6) = "TRICEPS DIPS"
			Exs(7) = "PLANK"
			Exs(8) = "HIGH STEPPING"
			Exs(9) = "LUNGES"
			Exs(10) = "PUSH-UP AND ROTATION"
			Exs(11) = "SIDE PLANK RIGHT"
			Exs(12) = "SIDE PLANK LEFT"
			Exs(13) = ""
		ElseIf Me.Tag = 6 Then
			n = 0
			For x = 1 To 14
				If GetSetting("kworkout", "CustomWS", x.ToString, "0") <> "0" Then
					For Each control In CustomWS.Panel1.Controls
						If DirectCast(control, CheckBox).TabIndex = Integer.Parse(GetSetting("kworkout", "CustomWS", x.ToString, "0")) Then
							Exs(n) = DirectCast(control, CheckBox).Text
						End If
					Next
					n += 1
				End If
			Next
			time = Integer.Parse(GetSetting("kworkout", "CustomWS", "time", "270"))
			x = time / 270
			If x = 1 Then
				s = "30 s"
			ElseIf x = 2 Then
				s = "1 m"
			ElseIf x = 3 Then
				s = "1 m 30 s"
			ElseIf x = 4 Then
				s = "2 m"
			ElseIf x = 5 Then
				s = "2 m 30 s"
			ElseIf x = 6 Then
				s = "3 m"
			ElseIf x = 7 Then
				s = "3 m 30 s"
			End If
			Label3.Text = s
			Label5.Text = s
			Label9.Text = s
			Label7.Text = s
			Label13.Text = s
			Label11.Text = s
			Label25.Text = s
			Label23.Text = s
			Label21.Text = s
			Label19.Text = s
			Label17.Text = s
			Label15.Text = s
			Label27.Text = s
			Label29.Text = s

		ElseIf Me.Tag = 7 Then
			n = 11
			Exs(0) = "KNEELING LUNGE STRETCH LEFT"
			Exs(1) = "KNEELING LUNGE STRETCH RIGHT"
			Exs(2) = "CALF STRETCH LEFT"
			Exs(3) = "CALF STRETCH RIGHT"
			Exs(4) = "TRICEPS STRETCH LEFT"
			Exs(5) = "TRICEPS STRETCH RIGHT"
			Exs(6) = "CAT COW POSE"
			Exs(7) = "COBRA STRETCH"
			Exs(8) = "CHILD'S POSE"
			Exs(9) = "SPINE LUMBAR TWIST STRETCH LEFT"
			Exs(10) = "SPINE LUMBAR TWIST STRETCH RIGHT"
			Exs(11) = ""
			Exs(12) = ""
			Exs(13) = ""
		End If

		x = 1
		y = 0
		SAPI = CreateObject("SAPI.spvoice")
		SAPI.Rate = -2
		Label4.Text = Exs(0)
		If Label4.Text.Length = 0 Then Label3.Text = ""
		Label6.Text = Exs(1)
		If Label6.Text.Length = 0 Then Label5.Text = ""
		Label10.Text = Exs(2)
		If Label10.Text.Length = 0 Then Label9.Text = ""
		Label8.Text = Exs(3)
		If Label8.Text.Length = 0 Then Label7.Text = ""
		Label14.Text = Exs(4)
		If Label14.Text.Length = 0 Then Label13.Text = ""
		Label12.Text = Exs(5)
		If Label12.Text.Length = 0 Then Label11.Text = ""
		Label26.Text = Exs(6)
		If Label26.Text.Length = 0 Then Label25.Text = ""
		Label24.Text = Exs(7)
		If Label24.Text.Length = 0 Then Label23.Text = ""
		Label22.Text = Exs(8)
		If Label22.Text.Length = 0 Then Label21.Text = ""
		Label20.Text = Exs(9)
		If Label20.Text.Length = 0 Then Label19.Text = ""
		Label18.Text = Exs(10)
		If Label18.Text.Length = 0 Then Label17.Text = ""
		Label16.Text = Exs(11)
		If Label16.Text.Length = 0 Then Label15.Text = ""
		Label28.Text = Exs(12)
		If Label28.Text.Length = 0 Then Label27.Text = ""
		Label30.Text = Exs(13)
		If Label30.Text.Length = 0 Then Label29.Text = ""

	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		If Button2.Text = ";" Then
			Button4.Visible = True
			Timer1.Stop()
			wmp.Ctlcontrols.pause()
			Button2.Text = "4"
		Else
			Button4.Visible = False
			Timer1.Start()
			wmp.Ctlcontrols.play()
			Button2.Text = ";"
		End If

	End Sub

	Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
		Workout.Show()
		Close()
	End Sub

	Private Sub MEnt(sender As Object, e As EventArgs) Handles Button4.MouseEnter
		Button4.ForeColor = Color.White
	End Sub

	Private Sub MLea(sender As Object, e As EventArgs) Handles Button4.MouseLeave
		Button4.ForeColor = Color.Silver
	End Sub
End Class