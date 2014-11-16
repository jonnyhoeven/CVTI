Public Class LoadingForm

    Private Sub LoadingForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            progtimer.Start()
            Me.ProgressBar1.Value = 0
            Timer1.Start()
        Catch ex As Exception

        End Try
    End Sub

    'update loading screen
    Private Sub progtimer_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles progtimer.Tick
        Try
            Me.ProgressBar1.Increment(1)
        Catch ex As Exception

        End Try
    End Sub

    'stop
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            Timer1.Stop()
            progtimer.Stop()
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

End Class