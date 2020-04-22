Public Class frmMain
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Me.Dispose()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Shell("c:\Windows\System32\calc.exe")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f As New frmBilling()
        f.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim f As New frmProductDetail()
        f.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim f As New frmSupplierDetail()
        f.Show()
        Me.Hide()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim f As New frmSalesDetail()
        f.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim f As New frmPurchaseDetail()
        f.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim f As New frmProcessingDetail()
        f.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim f As New frmProcessingCost()
        f.Show()
        Me.Hide()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim f As New frmWarehouseDetail()
        f.Show()
        Me.Hide()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim f As New frmTransportDetail()
        f.Show()
        Me.Hide()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim f As New frmBillingDetail()
        f.Show()
        Me.Hide()
    End Sub
End Class