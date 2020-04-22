Imports System.Windows.Forms

Public Class Login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtUsername.Text = "admin" And txtPassword.Text = "123" Then
            MessageBox.Show("Login Successfully...!")
            Dim f As New frmMain()
            f.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid Username or Password...!")
        End If
    End Sub
End Class