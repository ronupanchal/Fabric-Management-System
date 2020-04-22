<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProcessingDetail
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
        Me.txtPId = New System.Windows.Forms.TextBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnModify = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtPCode = New System.Windows.Forms.TextBox()
        Me.txtPMachine = New System.Windows.Forms.TextBox()
        Me.txtPRaw = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPDate = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtRWeight = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(331, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Processing Detail"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Blue
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(742, 27)
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
        Me.Label7.Location = New System.Drawing.Point(50, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 17)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Go To Main"
        '
        'txtPId
        '
        Me.txtPId.Location = New System.Drawing.Point(242, 72)
        Me.txtPId.Name = "txtPId"
        Me.txtPId.Size = New System.Drawing.Size(100, 20)
        Me.txtPId.TabIndex = 0
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(417, 183)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 31)
        Me.btnDelete.TabIndex = 8
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnModify
        '
        Me.btnModify.Location = New System.Drawing.Point(417, 129)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(75, 31)
        Me.btnModify.TabIndex = 7
        Me.btnModify.Text = "MODIFY"
        Me.btnModify.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(53, 241)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(707, 206)
        Me.DataGridView1.TabIndex = 11
        '
        'txtPCode
        '
        Me.txtPCode.Location = New System.Drawing.Point(242, 183)
        Me.txtPCode.Name = "txtPCode"
        Me.txtPCode.Size = New System.Drawing.Size(100, 20)
        Me.txtPCode.TabIndex = 4
        '
        'txtPMachine
        '
        Me.txtPMachine.Location = New System.Drawing.Point(242, 156)
        Me.txtPMachine.Name = "txtPMachine"
        Me.txtPMachine.Size = New System.Drawing.Size(100, 20)
        Me.txtPMachine.TabIndex = 3
        '
        'txtPRaw
        '
        Me.txtPRaw.Location = New System.Drawing.Point(242, 129)
        Me.txtPRaw.Name = "txtPRaw"
        Me.txtPRaw.Size = New System.Drawing.Size(100, 20)
        Me.txtPRaw.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(164, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Process Id :"
        '
        'txtPDate
        '
        Me.txtPDate.Location = New System.Drawing.Point(242, 99)
        Me.txtPDate.Name = "txtPDate"
        Me.txtPDate.Size = New System.Drawing.Size(100, 20)
        Me.txtPDate.TabIndex = 1
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(417, 72)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 31)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(150, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Process Date :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(150, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Process Raw :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(132, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 13)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Process Machine :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(134, 186)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 13)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "Processing Code :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(155, 212)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 13)
        Me.Label9.TabIndex = 48
        Me.Label9.Text = "Raw Weight :"
        '
        'txtRWeight
        '
        Me.txtRWeight.Location = New System.Drawing.Point(242, 209)
        Me.txtRWeight.Name = "txtRWeight"
        Me.txtRWeight.Size = New System.Drawing.Size(100, 20)
        Me.txtRWeight.TabIndex = 5
        '
        'frmProcessingDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtRWeight)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPId)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnModify)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtPCode)
        Me.Controls.Add(Me.txtPMachine)
        Me.Controls.Add(Me.txtPRaw)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPDate)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmProcessingDetail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmProcessingDetail"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPId As TextBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnModify As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtPCode As TextBox
    Friend WithEvents txtPMachine As TextBox
    Friend WithEvents txtPRaw As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPDate As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtRWeight As TextBox
End Class
