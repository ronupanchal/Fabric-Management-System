Imports System.Data.SqlClient
Public Class frmTransportDetail
    Dim cs As String = "Data Source=DESKTOP-1L8UME0\SQLEXPRESS;Initial Catalog=db_fabric;Integrated Security=True"
    Dim cn As New SqlConnection(cs)
    Dim cmd As New SqlCommand()
    Dim rd As SqlDataReader

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = "insert into tbl_transport values(" & CInt(txtTid.Text) & ",'" & txtTCost.Text & "'," & txtTDistance.Text & ",'" & txtTMode.Text & "')"
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
            cmd.CommandText = "select * from tbl_transport"
            rd = cmd.ExecuteReader()
            DataGridView1.Columns.Add("c1", "Transport Id")
            DataGridView1.Columns.Add("c2", "Transport Cost")
            DataGridView1.Columns.Add("c3", "Transport Distance")
            DataGridView1.Columns.Add("c4", "Transport Mode")

            While rd.Read()
                DataGridView1.Rows.Add(rd("transportid").ToString(), rd("transportcost"), rd("transportdistance").ToString(), rd("transportmode"))
            End While
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            cn.Close()
        End Try

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Dim f As New frmMain()
        f.Show()
        Me.Hide()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Me.Dispose()
    End Sub

    Private Sub frmTransportDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Display()
    End Sub

    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click
        Try
            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = "update tbl_transport set transportcost ='" & txtTCost.Text & "',transportdistance=" & txtTDistance.Text & ",transportmode='" & txtTMode.Text & "' where transportid=" & CInt(txtTid.Text)
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
            cmd.CommandText = "delete from tbl_transport where transportid=" & CInt(txtTid.Text)
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