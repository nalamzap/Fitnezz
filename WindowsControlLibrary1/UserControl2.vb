Imports AxWMPLib
Public Class KataV
	Public b As Boolean
	Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
		AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = AxWindowsMediaPlayer1.Ctlcontrols.currentPosition - 10
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = AxWindowsMediaPlayer1.Ctlcontrols.currentPosition + 10
	End Sub

	Private Sub KataV_Load(sender As Object, e As EventArgs) Handles Me.Load
		b = True
	End Sub

	Private Sub AxWindowsMediaPlayer1_PlayStateChange(sender As Object, e As _WMPOCXEvents_PlayStateChangeEvent) Handles AxWindowsMediaPlayer1.PlayStateChange

		If AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsStopped And b Then
			If MsgBox("Want to watch again?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
				AxWindowsMediaPlayer1.Ctlcontrols.play()
			Else
				ParentForm.TabIndex = (Parent.TabIndex + 1) Mod 2
			End If
		Else
			b = True
		End If
	End Sub
End Class
