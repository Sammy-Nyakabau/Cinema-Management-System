Public Class Customers4
    Private Sub Customers4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Cinema_4DataSet2.tblCustomers' table. You can move, or remove it, as needed.
        Me.TblCustomersTableAdapter1.Fill(Me.Cinema_4DataSet2.tblCustomers)

    End Sub
End Class