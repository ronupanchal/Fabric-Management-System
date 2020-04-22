<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWarehouseDetail
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnModify = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtWRent = New System.Windows.Forms.TextBox()
        Me.txtMname = New System.Windows.Forms.TextBox()
        Me.txtWName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtWid = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtWAddress = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtWStock = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(326, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Warehouse Detail"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Blue
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(723, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(18, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "X"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Blue
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(31, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 17)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Go To Main"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(419, 218)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 8
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnModify
        '
        Me.btnModify.Location = New System.Drawing.Point(307, 218)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(75, 23)
        Me.btnModify.TabIndex = 7
        Me.btnModify.Text = "MODIFY"
        Me.btnModify.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(71, 255)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(599, 183)
        Me.DataGridView1.TabIndex = 11
        '
        'txtWRent
        '
        Me.txtWRent.Location = New System.Drawing.Point(212, 173)
        Me.txtWRent.Name = "txtWRent"
        Me.txtWRent.Size = New System.Drawing.Size(100, 20)
        Me.txtWRent.TabIndex = 3
        '
        'txtMname
        '
        Me.txtMname.Location = New System.Drawing.Point(212, 134)
        Me.txtMname.Name = "txtMname"
        Me.txtMname.Size = New System.Drawing.Size(100, 20)
        Me.txtMname.TabIndex = 2
        '
        'txtWName
        '
        Me.txtWName.Location = New System.Drawing.Point(212, 95)
        Me.txtWName.Name = "txtWName"
        Me.txtWName.Size = New System.Drawing.Size(100, 20)
        Me.txtWName.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(135, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Rent :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(85, 139)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Manager Name :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(91, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Warehouse Id :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(72, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Warehouse Name :"
        '
        'txtWid
        '
        Me.txtWid.Location = New System.Drawing.Point(212, 56)
        Me.txtWid.Name = "txtWid"
        Me.txtWid.Size = New System.Drawing.Size(100, 20)
        Me.txtWid.TabIndex = 0
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(199, 218)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtWAddress
        '
        Me.txtWAddress.Location = New System.Drawing.Point(471, 60)
        Me.txtWAddress.Multiline = True
        Me.txtWAddress.Name = "txtWAddress"
        Me.txtWAddress.Size = New System.Drawing.Size(122, 67)
        Me.txtWAddress.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(402, 60)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 13)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Address :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(357, 144)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 13)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Warehouse Stock :"
        '
        'txtWStock
        '
        Me.txtWStock.Location = New System.Drawing.Point(471, 144)
        Me.txtWStock.Name = "txtWStock"
        Me.txtWStock.Size = New System.Drawing.Size(122, 20)
        Me.txtWStock.TabIndex = 5
        '
        'frmWarehouseDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtWStock)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtWAddress)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnModify)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtWRent)
        Me.Controls.Add(Me.txtMname)
        Me.Controls.Add(Me.txtWName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtWid)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmWarehouseDetail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmWarehouseDetail"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnModify As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtWRent As TextBox
    Friend WithEvents txtMname As TextBox
    Friend WithEvents txtWName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtWid As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents txtWAddress As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtWStock As TextBox
End Class
