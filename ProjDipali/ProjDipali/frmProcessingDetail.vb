Imports System.Data.SqlClient
Public Class frmProcessingDetail
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

    Private Sub frmProcessingDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = "insert into tbl_processing_detail values(" & CInt(txtPId.Text) & ",'" & txtPDate.Text & "','" & txtPRaw.Text & "','" & txtPMachine.Text & "','" & txtPCode.Text & "'," & CInt(txtRWeight.Text) & ")"
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
            cmd.CommandText = "select * from tbl_processing_detail"
            rd = cmd.ExecuteReader()
            DataGridView1.Columns.Add("c1", "Processing Id")
            DataGridView1.Columns.Add("c2", "Processing Date")
            DataGridView1.Columns.Add("c3", "Processing Raw")
            DataGridView1.Columns.Add("c4", "Processing Machine")
            DataGridView1.Columns.Add("c5", "Processing Code")
            DataGridView1.Columns.Add("c6", "Raw Weight")

            While rd.Read()
                DataGridView1.Rows.Add(rd("proid").ToString(), rd("prodate"), rd("proraw"), rd("promachine"), rd("procode"), rd("rawweight").ToString())
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
            cmd.CommandText = "update tbl_processing_detail set prodate ='" & txtPDate.Text & "',proraw='" & txtPRaw.Text & "',promachine='" & txtPMachine.Text & "' where proid=" & CInt(txtPId.Text)
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
            cmd.CommandText = "delete from tbl_processing_detail where proid=" & CInt(txtPId.Text)
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