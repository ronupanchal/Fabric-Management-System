Imports System.Data.SqlClient
Public Class frmWarehouseDetail
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

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = "insert into tbl_warehouse values(" & CInt(txtWid.Text) & ",'" & txtWName.Text & "','" & txtMname.Text & "','" & txtWRent.Text & "','" & txtWAddress.Text & "','" & txtWStock.Text & "')"
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
            cmd.CommandText = "select * from tbl_warehouse"
            rd = cmd.ExecuteReader()
            DataGridView1.Columns.Add("c1", "Warehouse Id")
            DataGridView1.Columns.Add("c2", "Warehouse Name")
            DataGridView1.Columns.Add("c3", "Manager Name")
            DataGridView1.Columns.Add("c4", "Warehouse Rent")
            DataGridView1.Columns.Add("c5", "Warehouse Address")
            DataGridView1.Columns.Add("c6", "Warehouse Stock")

            While rd.Read()
                DataGridView1.Rows.Add(rd("wid").ToString(), rd("wname"), rd("managername"), rd("rent"), rd("address"), rd("wstock"))
            End While
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            cn.Close()
        End Try

    End Sub

    Private Sub frmTransportDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Display()
    End Sub

    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click
        Try
            cn.Open()
            cmd.Connection = cn
            'cmd.CommandText = "update tbl_warehouse set transportcost ='" & txtTCost.Text & "',transportdistance=" & txtTDistance.Text & ",transportmode='" & txtTMode.Text & "' where transportid=" & CInt(txtTid.Text)
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
            cmd.CommandText = "delete from tbl_warehouse where wid=" & CInt(txtWid.Text)
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