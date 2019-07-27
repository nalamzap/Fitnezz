Imports System.ComponentModel

Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        FitnezzMainScreen.Show()
        Close()
    End Sub
End Class
