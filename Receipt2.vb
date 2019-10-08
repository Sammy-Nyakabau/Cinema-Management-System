Public Class Receipt2
    Public MytotalCost, MytotalPayment, MyChange, MySeats As Integer

    Public MycustomerID As String
    Public MyfirstName As String
    Private Sub Receipt1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MytotalCost = Cinema2.totalCost
        MytotalPayment = Cinema2.totalPayment
        MyChange = Cinema2.change
        MycustomerID = Cinema2.customerID
        MyfirstName = Cinema2.firstName
        MySeats = Cinema2.seats

        lblID.Text = MycustomerID
        lblName.Text = MyfirstName
        lblSeats.Text = MySeats
        lblTotalCost.Text = ("$") & MytotalCost
        lblTotalPayment.Text = ("$") & MytotalPayment
        lblChange.Text = ("$") & MyChange
    End Sub

End Class