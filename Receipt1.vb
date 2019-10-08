Public Class Receipt1
    Public MytotalCost, MytotalPayment, MyChange, MySeats As Integer



    Public MycustomerID As String
    Public MyfirstName As String
    Private Sub Receipt1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MytotalCost = Cinema1.totalCost
        MytotalPayment = Cinema1.totalPayment
        MyChange = Cinema1.change
        MycustomerID = Cinema1.customerID
        MyfirstName = Cinema1.firstName
        MySeats = Cinema1.seats

        lblID.Text = MycustomerID
        lblName.Text = MyfirstName
        lblSeats.Text = MySeats
        lblTotalCost.Text = ("$") & MytotalCost
        lblTotalPayment.Text = ("$") & MytotalPayment
        lblChange.Text = ("$") & MyChange
    End Sub
End Class