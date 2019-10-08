Public Class Menu_Admin
    Private Sub linklogout_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linklogout.LinkClicked

        MessageBox.Show("Are you sure you want to leave the system?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If DialogResult.Yes Then
            Me.Close()
            LoginInfo.txtPassword.Clear()
            LoginInfo.txtUsername.Clear()
            LoginInfo.Show()
        End If

    End Sub

    Private Sub btnCinema1_Click(sender As Object, e As EventArgs) Handles btnCinema1.Click
        Cinema1.Show()
    End Sub

    Private Sub btnCinema2_Click(sender As Object, e As EventArgs) Handles btnCinema2.Click
        Cinema2.Show()
    End Sub

    Private Sub btnCinema3_Click(sender As Object, e As EventArgs) Handles btnCinema3.Click
        Cinema3.Show()
    End Sub

    Private Sub btnCinema4_Click(sender As Object, e As EventArgs) Handles btnCinema4.Click
        Cinema4.Show()
    End Sub

    Private Sub Menu_Admin_Load(sender As Object, e As EventArgs) Handles Me.Load
        Timer1.Start()
        lblDate.Text = Date.Today
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = TimeOfDay
    End Sub
End Class