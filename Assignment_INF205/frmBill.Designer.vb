<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBill
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
        Me.btnCancelBill = New System.Windows.Forms.Button()
        Me.btnOKBill = New System.Windows.Forms.Button()
        Me.txtDateBuy = New System.Windows.Forms.TextBox()
        Me.lbDateBuy = New System.Windows.Forms.Label()
        Me.txtBillID = New System.Windows.Forms.TextBox()
        Me.lbBillID = New System.Windows.Forms.Label()
        Me.txtCustomerID = New System.Windows.Forms.TextBox()
        Me.lbCustomerID = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCancelBill
        '
        Me.btnCancelBill.Location = New System.Drawing.Point(175, 160)
        Me.btnCancelBill.Name = "btnCancelBill"
        Me.btnCancelBill.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelBill.TabIndex = 21
        Me.btnCancelBill.Text = "&Cancel"
        Me.btnCancelBill.UseVisualStyleBackColor = True
        '
        'btnOKBill
        '
        Me.btnOKBill.Location = New System.Drawing.Point(66, 160)
        Me.btnOKBill.Name = "btnOKBill"
        Me.btnOKBill.Size = New System.Drawing.Size(75, 23)
        Me.btnOKBill.TabIndex = 22
        Me.btnOKBill.Text = "&OK"
        Me.btnOKBill.UseVisualStyleBackColor = True
        '
        'txtDateBuy
        '
        Me.txtDateBuy.Location = New System.Drawing.Point(125, 110)
        Me.txtDateBuy.Name = "txtDateBuy"
        Me.txtDateBuy.Size = New System.Drawing.Size(137, 20)
        Me.txtDateBuy.TabIndex = 16
        '
        'lbDateBuy
        '
        Me.lbDateBuy.AutoSize = True
        Me.lbDateBuy.Location = New System.Drawing.Point(32, 113)
        Me.lbDateBuy.Name = "lbDateBuy"
        Me.lbDateBuy.Size = New System.Drawing.Size(54, 13)
        Me.lbDateBuy.TabIndex = 15
        Me.lbDateBuy.Text = "Date Buy:"
        '
        'txtBillID
        '
        Me.txtBillID.Location = New System.Drawing.Point(125, 67)
        Me.txtBillID.Name = "txtBillID"
        Me.txtBillID.Size = New System.Drawing.Size(137, 20)
        Me.txtBillID.TabIndex = 14
        '
        'lbBillID
        '
        Me.lbBillID.AutoSize = True
        Me.lbBillID.Location = New System.Drawing.Point(33, 70)
        Me.lbBillID.Name = "lbBillID"
        Me.lbBillID.Size = New System.Drawing.Size(37, 13)
        Me.lbBillID.TabIndex = 13
        Me.lbBillID.Text = "Bill ID:"
        '
        'txtCustomerID
        '
        Me.txtCustomerID.Location = New System.Drawing.Point(125, 27)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.ReadOnly = True
        Me.txtCustomerID.Size = New System.Drawing.Size(137, 20)
        Me.txtCustomerID.TabIndex = 12
        '
        'lbCustomerID
        '
        Me.lbCustomerID.AutoSize = True
        Me.lbCustomerID.Location = New System.Drawing.Point(34, 30)
        Me.lbCustomerID.Name = "lbCustomerID"
        Me.lbCustomerID.Size = New System.Drawing.Size(68, 13)
        Me.lbCustomerID.TabIndex = 11
        Me.lbCustomerID.Text = "Customer ID:"
        '
        'frmBill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(319, 214)
        Me.Controls.Add(Me.btnCancelBill)
        Me.Controls.Add(Me.btnOKBill)
        Me.Controls.Add(Me.txtDateBuy)
        Me.Controls.Add(Me.lbDateBuy)
        Me.Controls.Add(Me.txtBillID)
        Me.Controls.Add(Me.lbBillID)
        Me.Controls.Add(Me.txtCustomerID)
        Me.Controls.Add(Me.lbCustomerID)
        Me.Name = "frmBill"
        Me.Text = "Bill"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancelBill As System.Windows.Forms.Button
    Friend WithEvents btnOKBill As System.Windows.Forms.Button
    Friend WithEvents txtDateBuy As System.Windows.Forms.TextBox
    Friend WithEvents lbDateBuy As System.Windows.Forms.Label
    Friend WithEvents txtBillID As System.Windows.Forms.TextBox
    Friend WithEvents lbBillID As System.Windows.Forms.Label
    Friend WithEvents txtCustomerID As System.Windows.Forms.TextBox
    Friend WithEvents lbCustomerID As System.Windows.Forms.Label
End Class
