Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            Me.Hide()
            FrmLogin.ShowDialog()
        End If
        LblCarga.Text = ProgressBar1.Value & (" %")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 100
        Timer1.Start()
        LblCarga.Text = "0 %"
    End Sub
End Class
