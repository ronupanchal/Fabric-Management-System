Imports System.Data.SqlClient
Public Class frmPurchaseDetail
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

    Private Sub frmPurchaseDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Display()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Try
            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = "insert into tbl_purchase_detail values(" & CInt(txtRcode.Text) & ",'" & txtRName.Text & "','" & txtCategory.Text & "','" & DateTimePicker1.Text & "'," & CInt(txtAmount.Text) & ", " & CInt(txtWeight.Text) & " )"
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
            cmd.CommandText = "select * from tbl_purchase_detail"
            rd = cmd.ExecuteReader()
            DataGridView1.Columns.Add("c1", "Raw Code")
            DataGridView1.Columns.Add("c2", "Raw Name")
            DataGridView1.Columns.Add("c3", "Category")
            DataGridView1.Columns.Add("c4", "Purchase Date")
            DataGridView1.Columns.Add("c5", "Amount")
            DataGridView1.Columns.Add("c6", "Weight")

            While rd.Read()
                DataGridView1.Rows.Add(rd("rowcode").ToString(), rd("rowname"), rd("category"), rd("purdate"), rd("amount"), rd("weight"))
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
            cmd.CommandText = "update tbl_purchase_detail set rowname ='" & txtRName.Text & "',category='" & txtCategory.Text & "',purdate='" & DateTimePicker1.Text & "',amount=" & CInt(txtAmount.Text) & ", weight=" & CInt(txtWeight.Text) & " where rowcode=" & CInt(txtRcode.Text)
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
            cmd.CommandText = "delete from tbl_purchase_detail where rowcode=" & CInt(txtRcode.Text)
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