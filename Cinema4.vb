Public Class Cinema4
    ' global variables to store program identifiers
    Dim availableIcon As New System.Drawing.Bitmap(My.Resources.available)
    Dim provisionalIcon As New System.Drawing.Bitmap(My.Resources.provisional)
    Dim bookedIcon As New System.Drawing.Bitmap(My.Resources.booked)
    Dim bookedSeats, availableSeats, provisionalSeats As Integer
    Public totalCost, totalPayment, change, seats As Integer
    Public customerID As String
    Public firstName As String
    Const COST = 5 'the cost of one seat

    ' this method saves and commits to the database the selected seats
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim c As Control
        Dim bSelected As Boolean

        For Each c In Me.Controls 'this loop iterates until it reaches a selected seat
            If TypeOf (c) Is PictureBox Then
                If CType(c, PictureBox).Image Is provisionalIcon Then
                    bSelected = True
                    Exit For
                End If
            End If
        Next

        If bSelected = False Then
            MessageBox.Show("Please select at least one seat to book", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim stSQLInsert As String
        Dim stConString As String = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " & Application.StartupPath & "\Cinema 4.accdb"

        Dim conBookings As OleDb.OleDbConnection
        conBookings = New OleDb.OleDbConnection
        conBookings.ConnectionString = stConString
        conBookings.Open()

        Dim cmdMakeBookings As OleDb.OleDbCommand = New OleDb.OleDbCommand

        cmdMakeBookings.Connection = conBookings


        Dim iSeatNum As Integer
        For Each c In Me.Controls
            If TypeOf (c) Is PictureBox Then
                If CType(c, PictureBox).Image Is provisionalIcon Then

                    iSeatNum = Mid(CType(c, PictureBox).Name, 11)
                    stSQLInsert = "INSERT INTO tblBookings (Customer, Seat) VALUES ('" & txtID.Text & "'," & iSeatNum & " )" 'inserting selected seat number into table
                    cmdMakeBookings.CommandText = stSQLInsert
                    cmdMakeBookings.ExecuteNonQuery()
                End If
            End If
        Next
        customerID = txtID.Text
        firstName = txtFirstName.Text
        conBookings.Close()

        Call updateBookings()
        MessageBox.Show("The Booking Was Successfull!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Receipt4.Show()
    End Sub
    '  calculating change 
    Private Sub btnCalculateChange_Click(sender As Object, e As EventArgs) Handles btnCalculateChange.Click
        totalPayment = txtTotalPayment.Text
        If totalPayment >= totalCost Then
            change = totalPayment - totalCost
            txtChange.Text = ("$") & (change).ToString
        Else
            MessageBox.Show("Please make enough payment to proceed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtTotalPayment.Clear()
            Exit Sub
        End If
    End Sub
    '  this method loads the form with the number of seats available, booked by communicating with the database
    Private Sub Cinema4_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim c As Control

        For Each c In Me.Controls
            If TypeOf (c) Is PictureBox Then
                If c.Name = "NameBox" Or c.Name = "Background" Then
                    Continue For
                End If
                CType(c, PictureBox).Image = availableIcon
                AddHandler c.Click, AddressOf PictureBox10_Click
            End If
        Next
        availableSeats = 160
        bookedSeats = 0
        provisionalSeats = 0

        Call updateBookings()
    End Sub
    'viewing reservations
    Private Sub btnViewReservations_Click(sender As Object, e As EventArgs) Handles btnViewReservations.Click
        ReservedSeats4.Show()
    End Sub
    'viewing existing customers
    Private Sub btnExisting_Click(sender As Object, e As EventArgs) Handles btnExisting.Click
        Customers4.Show()
    End Sub
    'adding a new customer
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        AddCustomer4.Show()
    End Sub

    Sub updateBookings() ' this methods loads the application with data from the database
        availableSeats = 160 - bookedSeats 'getting the number of available seats
        provisionalSeats = 0
        Dim strSQL As String = "SELECT * FROM tblBookings"

        Dim stConString As String = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " & Application.StartupPath & "\Cinema 4.accdb"
        Dim conBookings As OleDb.OleDbConnection
        conBookings = New OleDb.OleDbConnection
        conBookings.ConnectionString = stConString
        conBookings.Open()

        Dim cmdSelectBookings As OleDb.OleDbCommand = New OleDb.OleDbCommand
        cmdSelectBookings.CommandText = strSQL
        cmdSelectBookings.Connection = conBookings

        Dim dsBookings As New DataSet
        Dim daBookings As New OleDb.OleDbDataAdapter(cmdSelectBookings)
        daBookings.Fill(dsBookings, "Bookings")
        conBookings.Close()

        Dim t1 As DataTable = dsBookings.Tables("Bookings")
        Dim row As DataRow

        For Each row In t1.Rows 'this loop gets all the booked seats and updates the interface

            CType(Controls("PictureBox" & row(2)), PictureBox).Image = bookedIcon
            bookedSeats += 1
            availableSeats -= 1
        Next

        txtBooked.Text = bookedSeats
        txtAvailable.Text = availableSeats
        txtProvisional.Text = provisionalSeats
        Call clear()
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) 'setting colors to differentiate between booked seats and available seats
        If CType(sender, PictureBox).Image Is availableIcon Then
            CType(sender, PictureBox).Image = provisionalIcon
            provisionalSeats += 1
            availableSeats -= 1

        ElseIf CType(sender, PictureBox).Image Is provisionalIcon
            CType(sender, PictureBox).Image = availableIcon
            provisionalSeats -= 1
            availableSeats += 1
        End If
        txtAvailable.Text = availableSeats
        txtProvisional.Text = provisionalSeats
        seats = provisionalSeats
        txtSeats.Text = seats
        totalCost = provisionalSeats * COST
        txtTotalCost.Text = ("$") & totalCost.ToString
    End Sub
    'clearing the textboxes
    Sub clear()
        txtTotalPayment.Clear()
        txtFirstName.Clear()
        txtTotalCost.Clear()
        txtChange.Clear()
        txtSeats.Clear()
        txtID.Clear()
    End Sub

End Class