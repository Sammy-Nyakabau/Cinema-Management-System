Public Class ReservedSeats2
    Private Sub ReservedSeats2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Cinema_2DataSet1.tblBookings' table. You can move, or remove it, as needed.
        Me.TblBookingsTableAdapter1.Fill(Me.Cinema_2DataSet1.tblBookings)

    End Sub
End Class