Public Class ReservedSeats4
    Private Sub ReservedSeats4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Cinema_4DataSet3.tblBookings' table. You can move, or remove it, as needed.
        Me.TblBookingsTableAdapter.Fill(Me.Cinema_4DataSet3.tblBookings)


    End Sub
End Class