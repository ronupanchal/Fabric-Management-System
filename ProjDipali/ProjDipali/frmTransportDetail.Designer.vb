<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransportDetail
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
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtTid = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTCost = New System.Windows.Forms.TextBox()
        Me.txtTDistance = New System.Windows.Forms.TextBox()
        Me.txtTMode = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnModify = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(160, 202)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtTid
        '
        Me.txtTid.Location = New System.Drawing.Point(173, 40)
        Me.txtTid.Name = "txtTid"
        Me.txtTid.Size = New System.Drawing.Size(100, 20)
        Me.txtTid.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(58, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Transport Cost :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(58, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Transport Id :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(46, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Transport Distance :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(46, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Transport Mode :"
        '
        'txtTCost
        '
        Me.txtTCost.Location = New System.Drawing.Point(173, 83)
        Me.txtTCost.Name = "txtTCost"
        Me.txtTCost.Size = New System.Drawing.Size(100, 20)
        Me.txtTCost.TabIndex = 1
        '
        'txtTDistance
        '
        Me.txtTDistance.Location = New System.Drawing.Point(173, 125)
        Me.txtTDistance.Name = "txtTDistance"
        Me.txtTDistance.Size = New System.Drawing.Size(100, 20)
        Me.txtTDistance.TabIndex = 2
        '
        'txtTMode
        '
        Me.txtTMode.Location = New System.Drawing.Point(173, 158)
        Me.txtTMode.Name = "txtTMode"
        Me.txtTMode.Size = New System.Drawing.Size(100, 20)
        Me.txtTMode.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(341, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Transport Detail"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Blue
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(731, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(18, 17)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "X"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Blue
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(39, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 17)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Go To Main"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(32, 239)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(599, 199)
        Me.DataGridView1.TabIndex = 10
        '
        'btnModify
        '
        Me.btnModify.Location = New System.Drawing.Point(268, 202)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(75, 23)
        Me.btnModify.TabIndex = 5
        Me.btnModify.Text = "MODIFY"
        Me.btnModify.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(380, 202)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 6
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'frmTransportDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnModify)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtTMode)
        Me.Controls.Add(Me.txtTDistance)
        Me.Controls.Add(Me.txtTCost)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTid)
        Me.Controls.Add(Me.btnSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmTransportDetail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmTransportDetail"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSave As Button
    Friend WithEvents txtTid As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTCost As TextBox
    Friend WithEvents txtTDistance As TextBox
    Friend WithEvents txtTMode As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnModify As Button
    Friend WithEvents btnDelete As Button
End Class
