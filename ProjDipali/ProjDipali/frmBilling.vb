Imports System.Data.SqlClient
Public Class frmBilling
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

    Private Sub frmBilling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Display()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = "insert into tbl_billing values(" & CInt(txtBNo.Text) & ",'" & DateTimePicker1.Text & "','" & txtCname.Text & "','" & txtRDetail.Text & "','" & txtDiscount.Text & "','" & txtTransport.Text & "'," & CInt(txtTotal.Text) & ")"
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
            cmd.CommandText = "select * from tbl_billing"
            rd = cmd.ExecuteReader()
            DataGridView1.Columns.Add("c1", "Bill No")
            DataGridView1.Columns.Add("c2", "Bill Date")
            DataGridView1.Columns.Add("c3", "Customer Name")
            DataGridView1.Columns.Add("c4", "Raw Detail")
            DataGridView1.Columns.Add("c5", "Discount")
            DataGridView1.Columns.Add("c6", "Transport Detail")
            DataGridView1.Columns.Add("c7", "Total")

            While rd.Read()
                DataGridView1.Rows.Add(rd("billno").ToString(), rd("bdate"), rd("cname"), rd("rawdetail"), rd("discount"), rd("transportdetail"), rd("total").ToString())
            End While
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            cn.Close()
        End Try

    End Sub

    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click
        Try
            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = "update tbl_billing set bdate ='" & DateTimePicker1.Text & "',cname='" & txtCname.Text & "',rawdetail='" & txtRDetail.Text & "',discount=''" & txtDiscount.Text & "', transportdetail='" & txtTransport.Text & "', total='" & txtTotal.Text & "' where billno=" & CInt(txtBNo.Text)
            cmd.ExecuteReader()
            MessageBox.Show("Record Modified")
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            cn.Close()
        End Try
        Display()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = "delete from tbl_billing where billno=" & CInt(txtBNo.Text)
            cmd.ExecuteReader()
            MessageBox.Show("Record Deleted")
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            cn.Close()
        End Try
        Display()
    End Sub
End Class