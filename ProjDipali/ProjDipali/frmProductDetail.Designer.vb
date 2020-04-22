<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductDetail
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
        Me.txtPMachine = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnModify = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.txtPStock = New System.Windows.Forms.TextBox()
        Me.txtPCost = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPid = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(332, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Product Detail"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Blue
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(739, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(18, 17)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "X"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Blue
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(47, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 17)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Go To Main"
        '
        'txtPMachine
        '
        Me.txtPMachine.Location = New System.Drawing.Point(413, 99)
        Me.txtPMachine.Name = "txtPMachine"
        Me.txtPMachine.Size = New System.Drawing.Size(122, 20)
        Me.txtPMachine.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(299, 99)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(108, 13)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "Production Machine :"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(398, 218)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 7
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnModify
        '
        Me.btnModify.Location = New System.Drawing.Point(286, 218)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(75, 23)
        Me.btnModify.TabIndex = 6
        Me.btnModify.Text = "MODIFY"
        Me.btnModify.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(50, 255)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(599, 183)
        Me.DataGridView1.TabIndex = 41
        '
        'txtWeight
        '
        Me.txtWeight.Location = New System.Drawing.Point(413, 53)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(122, 20)
        Me.txtWeight.TabIndex = 3
        '
        'txtPStock
        '
        Me.txtPStock.Location = New System.Drawing.Point(191, 134)
        Me.txtPStock.Name = "txtPStock"
        Me.txtPStock.Size = New System.Drawing.Size(100, 20)
        Me.txtPStock.TabIndex = 2
        '
        'txtPCost
        '
        Me.txtPCost.Location = New System.Drawing.Point(191, 95)
        Me.txtPCost.Name = "txtPCost"
        Me.txtPCost.Size = New System.Drawing.Size(100, 20)
        Me.txtPCost.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(360, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Weight :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(120, 141)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Stock :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(99, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Product Id :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(127, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Cost :"
        '
        'txtPid
        '
        Me.txtPid.Location = New System.Drawing.Point(191, 56)
        Me.txtPid.Name = "txtPid"
        Me.txtPid.Size = New System.Drawing.Size(100, 20)
        Me.txtPid.TabIndex = 0
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(178, 218)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'frmProductDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtPMachine)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnModify)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtWeight)
        Me.Controls.Add(Me.txtPStock)
        Me.Controls.Add(Me.txtPCost)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPid)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmProductDetail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmProductDetail"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPMachine As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnModify As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents txtPStock As TextBox
    Friend WithEvents txtPCost As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPid As TextBox
    Friend WithEvents btnSave As Button
End Class
