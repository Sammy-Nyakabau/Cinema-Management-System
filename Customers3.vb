Public Class Customers3
    Private Sub Customers3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Cinema_3DataSet.tblCustomers' table. You can move, or remove it, as needed.
        Me.TblCustomersTableAdapter.Fill(Me.Cinema_3DataSet.tblCustomers)

    End Sub
End Class