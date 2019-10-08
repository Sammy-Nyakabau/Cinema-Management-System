Public Class Receipt3
    Public MytotalCost, MytotalPayment, MyChange, MySeats As Integer

    Public MycustomerID As String
    Public MyfirstName As String

    Private Sub Receipt3_Load(sender As Object, e As EventArgs) Handles Me.Load
        MytotalCost = Cinema3.totalCost
        MytotalPayment = Cinema3.totalPayment
        MyChange = Cinema3.change
        MycustomerID = Cinema3.customerID
        MyfirstName = Cinema3.firstName
        MySeats = Cinema3.seats

        lblID.Text = MycustomerID
        lblName.Text = MyfirstName
        lblSeats.Text = MySeats
        lblTotalCost.Text = ("$") & MytotalCost
        lblTotalPayment.Text = ("$") & MytotalPayment
        lblChange.Text = ("$") & MyChange
    End Sub
End Class