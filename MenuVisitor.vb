Public Class MenuVisitor
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MovieSynopsis1.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        MoviesSynopsis2.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MovieSynopsis3.Show()
    End Sub

    Private Sub MenuVisitor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("Most features are disabled in this limited view. Kindly register to access and enjoy the whole system", "Please Note", MessageBoxButtons.OK, MessageBoxIcon.Information)
        lblDate.Text = Date.Today
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = TimeOfDay
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        MovieSynopsis4.Show()
    End Sub
End Class