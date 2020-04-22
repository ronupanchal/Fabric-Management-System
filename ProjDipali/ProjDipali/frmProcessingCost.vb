Imports System.Data.SqlClient
Public Class frmProcessingCost
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
            cmd.CommandText = "insert into tbl_processing_cost values(" & CInt(txtFinishGoodCode.Text) & ",'" & txtFGood.Text & "'," & CInt(txtPCost.Text) & "," & CInt(txtGWeight.Text) & "," & CInt(txtPId.Text) & ")"
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
            cmd.CommandText = "select * from tbl_processing_cost"
            rd = cmd.ExecuteReader()
            DataGridView1.Columns.Add("c1", "Finish Good Code")
            DataGridView1.Columns.Add("c2", "Finish Good")
            DataGridView1.Columns.Add("c3", "Processing Cost")
            DataGridView1.Columns.Add("c4", "Finish Good Weight")
            DataGridView1.Columns.Add("c5", "Processing Id")

            While rd.Read()
                DataGridView1.Rows.Add(rd("finishgoodcode").ToString(), rd("finishgood"), rd("procost").ToString(), rd("finishgoodweight").ToString(), rd("proid").ToString())
            End While
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            cn.Close()
        End Try

    End Sub

    Private Sub frmProcessingCost_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Display()
    End Sub

    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click
        Try
            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = "update tbl_processing_cost set finishgood ='" & txtFGood.Text & "',procost=" & txtPCost.Text & ",finishgoodweight=" & txtGWeight.Text & " where finishgoodcode=" & CInt(txtFinishGoodCode.Text)
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
            cmd.CommandText = "delete from tbl_processing_cost where finishgoodcode=" & CInt(txtFinishGoodCode.Text)
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