Public Class Customers2
    Private Sub Customers2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Cinema_2DataSet.tblCustomers' table. You can move, or remove it, as needed.
        Me.TblCustomersTableAdapter1.Fill(Me.Cinema_2DataSet.tblCustomers)

    End Sub
End Class