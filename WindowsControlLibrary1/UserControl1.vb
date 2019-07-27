Public Class kata
	Public n, x As Integer
	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		x = 1
		ForeColor = Color.FromArgb(n, n, n)
		n = (n + 1) Mod 2
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		x = 2
		ForeColor = Color.FromArgb(n, n, n)
		n = (n + 1) Mod 2
	End Sub

	Private Sub Kata_Load(sender As Object, e As EventArgs) Handles Me.Load
		n = 1
		x = 0
	End Sub

	Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
		x = 3
		ForeColor = Color.FromArgb(n, n, n)
		n = (n + 1) Mod 2
	End Sub
End Class