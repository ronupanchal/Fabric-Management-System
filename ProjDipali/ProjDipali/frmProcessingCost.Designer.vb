<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProcessingCost
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
        Me.txtPId = New System.Windows.Forms.TextBox()
        Me.txtGWeight = New System.Windows.Forms.TextBox()
        Me.txtPCost = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFGood = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtFinishGoodCode = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(326, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Processing Cost"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Blue
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(735, 21)
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
        Me.Label7.Location = New System.Drawing.Point(43, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 17)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Go To Main"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(404, 183)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 31)
        Me.btnDelete.TabIndex = 7
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnModify
        '
        Me.btnModify.Location = New System.Drawing.Point(404, 132)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(75, 31)
        Me.btnModify.TabIndex = 6
        Me.btnModify.Text = "MODIFY"
        Me.btnModify.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(87, 232)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(599, 206)
        Me.DataGridView1.TabIndex = 25
        '
        'txtPId
        '
        Me.txtPId.Location = New System.Drawing.Point(229, 195)
        Me.txtPId.Name = "txtPId"
        Me.txtPId.Size = New System.Drawing.Size(100, 20)
        Me.txtPId.TabIndex = 4
        '
        'txtGWeight
        '
        Me.txtGWeight.Location = New System.Drawing.Point(229, 162)
        Me.txtGWeight.Name = "txtGWeight"
        Me.txtGWeight.Size = New System.Drawing.Size(100, 20)
        Me.txtGWeight.TabIndex = 3
        '
        'txtPCost
        '
        Me.txtPCost.Location = New System.Drawing.Point(229, 135)
        Me.txtPCost.Name = "txtPCost"
        Me.txtPCost.Size = New System.Drawing.Size(100, 20)
        Me.txtPCost.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(108, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Finish Good Weight :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(104, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Finish Process Good :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(151, 202)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Process Id :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(139, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Process Cost :"
        '
        'txtFGood
        '
        Me.txtFGood.Location = New System.Drawing.Point(229, 105)
        Me.txtFGood.Name = "txtFGood"
        Me.txtFGood.Size = New System.Drawing.Size(100, 20)
        Me.txtFGood.TabIndex = 1
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(404, 72)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 31)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(117, 75)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 13)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Finish Good Code :"
        '
        'txtFinishGoodCode
        '
        Me.txtFinishGoodCode.Location = New System.Drawing.Point(229, 72)
        Me.txtFinishGoodCode.Name = "txtFinishGoodCode"
        Me.txtFinishGoodCode.Size = New System.Drawing.Size(100, 20)
        Me.txtFinishGoodCode.TabIndex = 0
        '
        'frmProcessingCost
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtFinishGoodCode)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnModify)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtPId)
        Me.Controls.Add(Me.txtGWeight)
        Me.Controls.Add(Me.txtPCost)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtFGood)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmProcessingCost"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmProcessingCost"
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
    Friend WithEvents txtPId As TextBox
    Friend WithEvents txtGWeight As TextBox
    Friend WithEvents txtPCost As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtFGood As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents txtFinishGoodCode As TextBox
End Class
