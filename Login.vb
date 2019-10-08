Public Class LoginInfo
    ' Declaring variables to capture username and password
    Dim username As String
    Dim password As String

    ' timer that shows the day's time and date
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = TimeOfDay
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'UsersDataSet.Admin' table. You can move, or remove it, as needed.
        Me.AdminTableAdapter.Fill(Me.UsersDataSet.Admin)
        Timer1.Start()
        lblDate.Text = Date.Today
    End Sub

    ' method that clears the textboxes
    Public Sub Clear()
        txtPassword.Clear()
        txtUsername.Clear()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

Start:
        ' assigning the entered credentials to variables
        password = txtPassword.Text
        username = txtUsername.Text

        ' comparing the entered credentials with records stored in the database
        If Me.AdminTableAdapter.ScalarQueryAdmin(username, password) Then
            Me.Hide()
            Menu_Admin.Show()
        Else
            MessageBox.Show("Invalid Username And/Or Password", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation)
            Clear()
            If DialogResult = DialogResult.Retry Then

                GoTo Start
            End If
        End If
    End Sub

    ' this method takes customers through the system
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkVisitor.LinkClicked
        Me.Hide()
        Menu_Visitor.Show()
    End Sub
End Class
