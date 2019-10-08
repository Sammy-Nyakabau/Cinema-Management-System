Public Class Menu_Visitor
    Private Sub linklogout_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linklogout.LinkClicked

        MessageBox.Show("Are you sure you want to leave the system?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If DialogResult.Yes Then
            Me.Close()
            LoginInfo.txtPassword.Clear()
            LoginInfo.txtUsername.Clear()
            LoginInfo.Show()
        End If

    End Sub
    Private Sub Menu_Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        lblDate.Text = Date.Today
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = TimeOfDay
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Trailer_1.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Trailer_2.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Trailer_3.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Trailer_4.Show()
    End Sub
End Class