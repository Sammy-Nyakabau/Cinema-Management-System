Public Class AddCustomer2


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim stSQLInsert As String
        Dim stConString As String = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " & Application.StartupPath & "\Cinema 2.accdb"

        Dim conCustomers As OleDb.OleDbConnection
        conCustomers = New OleDb.OleDbConnection
        conCustomers.ConnectionString = stConString
        conCustomers.Open()

        Dim cmdAddCustomers As OleDb.OleDbCommand = New OleDb.OleDbCommand

        cmdAddCustomers.Connection = conCustomers

        stSQLInsert = "INSERT INTO tblCustomers (CustomerID, FirstName, LastName) VALUES ('" & txtCustomerID.Text & "','" & txtFirstName.Text & "','" & txtLastName.Text & "' )"
        cmdAddCustomers.CommandText = stSQLInsert
        cmdAddCustomers.ExecuteNonQuery()
        txtCustomerID.Clear()
        txtFirstName.Clear()
        txtLastName.Clear()

        conCustomers.Close()
    End Sub
End Class