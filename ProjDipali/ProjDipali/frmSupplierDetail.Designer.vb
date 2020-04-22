<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSupplierDetail
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
        Me.txtSRcode = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtSRName = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSCode = New System.Windows.Forms.TextBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnModify = New System.Windows.Forms.Button()
        Me.txtSEmail = New System.Windows.Forms.TextBox()
        Me.txtSName = New System.Windows.Forms.TextBox()
        Me.txtSRAmount = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtSphoneno = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(336, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Supplier Detail"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Blue
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(721, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(18, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "X"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Blue
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(29, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 17)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Go To Main"
        '
        'txtSRcode
        '
        Me.txtSRcode.Location = New System.Drawing.Point(504, 151)
        Me.txtSRcode.Name = "txtSRcode"
        Me.txtSRcode.Size = New System.Drawing.Size(100, 20)
        Me.txtSRcode.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(428, 157)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 13)
        Me.Label10.TabIndex = 99
        Me.Label10.Text = "Raw Code:"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(32, 239)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(724, 199)
        Me.DataGridView1.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(422, 95)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 13)
        Me.Label9.TabIndex = 96
        Me.Label9.Text = "Raw Name :"
        '
        'txtSRName
        '
        Me.txtSRName.Location = New System.Drawing.Point(504, 88)
        Me.txtSRName.Name = "txtSRName"
        Me.txtSRName.Size = New System.Drawing.Size(100, 20)
        Me.txtSRName.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(164, 182)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 13)
        Me.Label8.TabIndex = 94
        Me.Label8.Text = "Email Id :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(134, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 13)
        Me.Label5.TabIndex = 93
        Me.Label5.Text = "Supplier Name :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(414, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 92
        Me.Label4.Text = "Raw Amount :"
        '
        'txtSCode
        '
        Me.txtSCode.Location = New System.Drawing.Point(241, 85)
        Me.txtSCode.Name = "txtSCode"
        Me.txtSCode.Size = New System.Drawing.Size(100, 20)
        Me.txtSCode.TabIndex = 0
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(483, 202)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 31)
        Me.btnDelete.TabIndex = 9
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnModify
        '
        Me.btnModify.Location = New System.Drawing.Point(365, 202)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(75, 31)
        Me.btnModify.TabIndex = 8
        Me.btnModify.Text = "MODIFY"
        Me.btnModify.UseVisualStyleBackColor = True
        '
        'txtSEmail
        '
        Me.txtSEmail.Location = New System.Drawing.Point(241, 176)
        Me.txtSEmail.Name = "txtSEmail"
        Me.txtSEmail.Size = New System.Drawing.Size(100, 20)
        Me.txtSEmail.TabIndex = 3
        '
        'txtSName
        '
        Me.txtSName.Location = New System.Drawing.Point(239, 115)
        Me.txtSName.Name = "txtSName"
        Me.txtSName.Size = New System.Drawing.Size(100, 20)
        Me.txtSName.TabIndex = 1
        '
        'txtSRAmount
        '
        Me.txtSRAmount.Location = New System.Drawing.Point(504, 122)
        Me.txtSRAmount.Name = "txtSRAmount"
        Me.txtSRAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtSRAmount.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(138, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 90
        Me.Label2.Text = "Supplier Code :"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(236, 202)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 31)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtSphoneno
        '
        Me.txtSphoneno.Location = New System.Drawing.Point(239, 150)
        Me.txtSphoneno.Name = "txtSphoneno"
        Me.txtSphoneno.Size = New System.Drawing.Size(100, 20)
        Me.txtSphoneno.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(153, 153)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 101
        Me.Label1.Text = "Phone No :"
        '
        'frmSupplierDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSphoneno)
        Me.Controls.Add(Me.txtSRcode)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtSRName)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSCode)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnModify)
        Me.Controls.Add(Me.txtSEmail)
        Me.Controls.Add(Me.txtSName)
        Me.Controls.Add(Me.txtSRAmount)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSupplierDetail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSupplierDetail"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtSRcode As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents txtSRName As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSCode As TextBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnModify As Button
    Friend WithEvents txtSEmail As TextBox
    Friend WithEvents txtSName As TextBox
    Friend WithEvents txtSRAmount As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents txtSphoneno As TextBox
    Friend WithEvents Label1 As Label
End Class
