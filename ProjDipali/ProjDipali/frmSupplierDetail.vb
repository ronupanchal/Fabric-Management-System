Imports System.Data.SqlClient
Public Class frmSupplierDetail
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

    Private Sub frmSupplierDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Display()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Try
            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = "insert into tbl_supplier_detail values(" & CInt(txtSCode.Text) & ",'" & txtSName.Text & "','" & txtSphoneno.Text & "','" & txtSEmail.Text & "','" & txtSRName.Text & "'," & CInt(txtSRAmount.Text) & "," & CInt(txtSRcode.Text) & ")"
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
            cmd.CommandText = "select * from tbl_supplier_detail"
            rd = cmd.ExecuteReader()
            DataGridView1.Columns.Add("c1", "Supplier Code")
            DataGridView1.Columns.Add("c2", "Supplier Name")
            DataGridView1.Columns.Add("c3", "Phone No")
            DataGridView1.Columns.Add("c4", "Email Id")
            DataGridView1.Columns.Add("c5", "Raw Name")
            DataGridView1.Columns.Add("c6", "Raw Amount")
            DataGridView1.Columns.Add("c7", "Raw Code")

            While rd.Read()
                DataGridView1.Rows.Add(rd("scode").ToString(), rd("sname"), rd("sphoneno"), rd("semail"), rd("raw"), rd("rawamt").ToString(), rd("rawcode").ToString())
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
            cmd.CommandText = "delete from tbl_supplier_detail where scode=" & CInt(txtSCode.Text)
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
            cmd.CommandText = "update tbl_supplier_detail set sname='" & txtSName.Text & "',sphoneno='" & txtSphoneno.Text & "',semail='" & txtSEmail.Text & "',raw='" & txtSRName.Text & "',rawamt=" & CInt(txtSRAmount.Text) & ",rawcode=" & CInt(txtSRcode.Text) & "  where scode=" & CInt(txtSCode.Text)
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