Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialization code if needed
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles usernametxt.TextChanged
        ' Handle text changed event if needed
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles loginbtn.Click
        Dim username As String = usernametxt.Text
        Dim password As String = passwordtxt.Text

        ' Check if the username and password are empty
        If String.IsNullOrWhiteSpace(username) Then
            MessageBox.Show("Please input a username.")
            Return
        End If

        If String.IsNullOrWhiteSpace(password) Then
            MessageBox.Show("Please input a password.")
            Return
        End If

        ' Login Logic
        If username = "admin" AndAlso password = "password" Then
            MessageBox.Show("Login successful!")
        Else
            MessageBox.Show("Invalid username or password.")
        End If
    End Sub

    Private Sub passwordtxt_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs)
        ' Handle mask input rejection if needed
    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles passwordtxt.TextChanged

    End Sub
End Class