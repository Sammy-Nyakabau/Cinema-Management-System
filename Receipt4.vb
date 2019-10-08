Public Class Receipt4
    Public MytotalCost, MytotalPayment, MyChange, MySeats As Integer

    Public MycustomerID As String
    Public MyfirstName As String



    Private Sub Receipt4_Load(sender As Object, e As EventArgs) Handles Me.Load
        MytotalCost = Cinema4.totalCost
        MytotalPayment = Cinema4.totalPayment
        MyChange = Cinema4.change
        MycustomerID = Cinema4.customerID
        MyfirstName = Cinema4.firstName
        MySeats = Cinema4.seats

        lblID.Text = MycustomerID
        lblName.Text = MyfirstName
        lblSeats.Text = MySeats
        lblTotalCost.Text = ("$") & MytotalCost
        lblTotalPayment.Text = ("$") & MytotalPayment
        lblChange.Text = ("$") & MyChange
    End Sub
End Class