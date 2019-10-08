Public Class Customers1
    Dim fname As String
    Private Sub Customers1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Cinema_1DataSet.tblCustomers' table. You can move, or remove it, as needed.
        Me.TblCustomersTableAdapter.Fill(Me.Cinema_1DataSet.tblCustomers)

    End Sub


End Class