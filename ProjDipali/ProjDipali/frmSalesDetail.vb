Imports System.Data.SqlClient
Public Class frmSalesDetail
    Dim cs As String = "Data Source=DESKTOP-1L8UME0\SQLEXPRESS;Initial Catalog=db_fabric;Integrated Security=True"
    Dim cn As New SqlConnection(cs)
    Dim cmd As New SqlCommand()
    Dim rd As SqlDataReader
    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Dim f As New frmMain()
        f.Show()
        Me.Hide()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Me.Dispose()
    End Sub

    Private Sub frmSalesDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Try
            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = "insert into tbl_sales_detail values(" & CInt(txtSNo.Text) & ",'" & DateTimePicker1.Text & "','" & txtSRaw.Text & "','" & txtWeight.Text & "'," & CInt(txtAmount.Text) & ")"
            cmd.ExecuteReader()
            MessageBox.Show("Record Saved")
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            cn.Close()
        End Try
        Display()
    End Sub

    Public Sub Display()
        DataGridView1.Rows.Clear()
        DataGridView1.Columns.Clear()
        Try
            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = "select * from tbl_sales_detail"
            rd = cmd.ExecuteReader()
            DataGridView1.Columns.Add("c1", "Sales No")
            DataGridView1.Columns.Add("c2", "Sales Date")
            DataGridView1.Columns.Add("c3", "Raw Name")
            DataGridView1.Columns.Add("c4", "Raw Weight")
            DataGridView1.Columns.Add("c4", "Amount")

            While rd.Read()
                DataGridView1.Rows.Add(rd("salesno").ToString(), rd("salesdate"), rd("raw"), rd("rawweight"), rd("amount").ToString())
            End While
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            cn.Close()
        End Try

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = "delete from tbl_sales_detail where salesno=" & CInt(txtSNo.Text)
            cmd.ExecuteReader()
            MessageBox.Show("Record Deleted")
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            cn.Close()
        End Try
        Display()
    End Sub

    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click
        Try
            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = "update tbl_sales_detail set salesdate ='" & DateTimePicker1.Text & "',raw='" & txtSRaw.Text & "',rawweight='" & txtWeight.Text & "',amount='" & txtAmount.Text & "'  where salesno=" & CInt(txtSNo.Text)
            cmd.ExecuteReader()
            MessageBox.Show("Record Modified")
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            cn.Close()
        End Try
        Display()
    End Sub
End Class