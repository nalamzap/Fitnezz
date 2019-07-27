Public Class CustomWS
	Dim x, t, c, n, time As Integer

	Private Sub CustomWS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		c = 0

		For x = 1 To 14
			If GetSetting("kworkout", "CustomWS", x.ToString, "0") <> "0" Then
				CBSet(Integer.Parse(GetSetting("kworkout", "CustomWS", x.ToString)))
			End If
		Next
		time = Integer.Parse(GetSetting("kworkout", "CustomWS", "time", "270"))
		TBar.Value = time / 270
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		MySub()
	End Sub

	Private Sub CBSet(i As Integer)
		For Each control In Me.Panel1.Controls
			If DirectCast(control, CheckBox).TabIndex = i Then
				DirectCast(control, CheckBox).Checked = True
			End If
		Next
	End Sub

	Private Sub UCB_disable()
		For Each control In Me.Panel1.Controls
			If DirectCast(control, CheckBox).Checked = False Then DirectCast(control, CheckBox).Enabled = False
		Next
	End Sub

	Private Sub CheckChanged(sender As Object, e As EventArgs) Handles CheckBox9.CheckedChanged, CheckBox8.CheckedChanged, CheckBox7.CheckedChanged, CheckBox60.CheckedChanged, CheckBox6.CheckedChanged, CheckBox59.CheckedChanged, CheckBox58.CheckedChanged, CheckBox57.CheckedChanged, CheckBox56.CheckedChanged, CheckBox55.CheckedChanged, CheckBox54.CheckedChanged, CheckBox53.CheckedChanged, CheckBox52.CheckedChanged, CheckBox51.CheckedChanged, CheckBox50.CheckedChanged, CheckBox5.CheckedChanged, CheckBox49.CheckedChanged, CheckBox48.CheckedChanged, CheckBox47.CheckedChanged, CheckBox46.CheckedChanged, CheckBox45.CheckedChanged, CheckBox44.CheckedChanged, CheckBox43.CheckedChanged, CheckBox42.CheckedChanged, CheckBox41.CheckedChanged, CheckBox40.CheckedChanged, CheckBox4.CheckedChanged, CheckBox39.CheckedChanged, CheckBox38.CheckedChanged, CheckBox37.CheckedChanged, CheckBox36.CheckedChanged, CheckBox35.CheckedChanged, CheckBox34.CheckedChanged, CheckBox33.CheckedChanged, CheckBox31.CheckedChanged, CheckBox30.CheckedChanged, CheckBox3.CheckedChanged, CheckBox29.CheckedChanged, CheckBox28.CheckedChanged, CheckBox27.CheckedChanged, CheckBox26.CheckedChanged, CheckBox25.CheckedChanged, CheckBox24.CheckedChanged, CheckBox23.CheckedChanged, CheckBox22.CheckedChanged, CheckBox21.CheckedChanged, CheckBox20.CheckedChanged, CheckBox2.CheckedChanged, CheckBox19.CheckedChanged, CheckBox18.CheckedChanged, CheckBox17.CheckedChanged, CheckBox16.CheckedChanged, CheckBox15.CheckedChanged, CheckBox14.CheckedChanged, CheckBox13.CheckedChanged, CheckBox12.CheckedChanged, CheckBox11.CheckedChanged, CheckBox10.CheckedChanged, CheckBox1.CheckedChanged
		If DirectCast(sender, CheckBox).Checked = True Then
			c = c + 1
			If c = 14 Then UCB_disable()
		Else
			c = c - 1
			If c = 13 Then UCB_enable()
			If c = 0 Then
				If MsgBox("Atleast one exercise must be there, or you can reset the state of custom workout and continue with other options", MsgBoxStyle.YesNo, "Information") = MsgBoxResult.Yes Then
					MySub()
					SaveSetting("KWorkout", "CustomWS", "cws", "0")
					Workout.Show()
					Close()
				Else
					DirectCast(sender, CheckBox).Checked = True
				End If

			End If
		End If
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		If MsgBox("Are you sure you want to reset custom workout and go to the main window?", MsgBoxStyle.YesNo, "Prompt...") = MsgBoxResult.Yes Then
			For x = 1 To 14
				SaveSetting("kworkout", "CustomWS", x.ToString, "0")
			Next
			SaveSetting("KWorkout", "CustomWS", "cws", "0")
			SaveSetting("kworkout", "CustomWS", "time", "270")
			Workout.Show()
			Close()
		End If
	End Sub


	Private Sub MySub()
		For x = 1 To 14
			SaveSetting("kworkout", "CustomWS", x.ToString, "0")
		Next
		x = 1
		For Each control In Me.Panel1.Controls
			If DirectCast(control, CheckBox).Checked = True Then
				SaveSetting("kworkout", "CustomWS", x.ToString, DirectCast(control, CheckBox).TabIndex.ToString)
				x = x + 1
			End If
		Next
		SaveSetting("KWorkout", "CustomWS", "cws", "1")
		SaveSetting("kworkout", "CustomWS", "time", time.ToString)
	End Sub

	Private Sub UCB_enable()
		For Each control In Me.Panel1.Controls
			If DirectCast(control, CheckBox).Enabled = False Then DirectCast(control, CheckBox).Enabled = True
		Next
	End Sub

	Private Sub CustomWS_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
		Workout.Enabled = True
	End Sub

	Private Sub TBar_ValueChanged(sender As Object, e As EventArgs) Handles TBar.ValueChanged
		time = TBar.Value * 270
	End Sub
End Class