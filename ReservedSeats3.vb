Public Class ReservedSeats3
    Private Sub ReservedSeats3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Cinema_3DataSet1.tblBookings' table. You can move, or remove it, as needed.
        Me.TblBookingsTableAdapter.Fill(Me.Cinema_3DataSet1.tblBookings)

    End Sub
End Class