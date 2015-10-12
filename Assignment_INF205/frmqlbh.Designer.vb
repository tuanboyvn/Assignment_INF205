<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQLBH
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
        Me.dgvProduct = New System.Windows.Forms.DataGridView()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lbSearch = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbProductType = New System.Windows.Forms.Label()
        Me.cmbProductType = New System.Windows.Forms.ComboBox()
        Me.cmbSearch = New System.Windows.Forms.ComboBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpProduct = New System.Windows.Forms.TabPage()
        Me.tpBill = New System.Windows.Forms.TabPage()
        Me.cmbSearchBill = New System.Windows.Forms.ComboBox()
        Me.dgvBill = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbCustomer = New System.Windows.Forms.Label()
        Me.cmbCustomer = New System.Windows.Forms.ComboBox()
        Me.btnAddBill = New System.Windows.Forms.Button()
        Me.txtSearchBill = New System.Windows.Forms.TextBox()
        Me.btnEditBill = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnDeleteBill = New System.Windows.Forms.Button()
        Me.tpBillDetail = New System.Windows.Forms.TabPage()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        CType(Me.dgvProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tpProduct.SuspendLayout()
        Me.tpBill.SuspendLayout()
        CType(Me.dgvBill, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.tpBillDetail.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvProduct
        '
        Me.dgvProduct.AllowUserToAddRows = False
        Me.dgvProduct.AllowUserToDeleteRows = False
        Me.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProduct.Location = New System.Drawing.Point(15, 62)
        Me.dgvProduct.MultiSelect = False
        Me.dgvProduct.Name = "dgvProduct"
        Me.dgvProduct.ReadOnly = True
        Me.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProduct.Size = New System.Drawing.Size(437, 248)
        Me.dgvProduct.TabIndex = 0
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(478, 62)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(127, 23)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(478, 91)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(127, 23)
        Me.btnEdit.TabIndex = 2
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(478, 120)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(127, 23)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'lbSearch
        '
        Me.lbSearch.AutoSize = True
        Me.lbSearch.Location = New System.Drawing.Point(15, 23)
        Me.lbSearch.Name = "lbSearch"
        Me.lbSearch.Size = New System.Drawing.Size(27, 13)
        Me.lbSearch.TabIndex = 5
        Me.lbSearch.Text = "Title"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(176, 20)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(276, 20)
        Me.txtSearch.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbProductType)
        Me.GroupBox1.Controls.Add(Me.cmbProductType)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(478, 163)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(143, 91)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filter"
        '
        'lbProductType
        '
        Me.lbProductType.AutoSize = True
        Me.lbProductType.Location = New System.Drawing.Point(18, 16)
        Me.lbProductType.Name = "lbProductType"
        Me.lbProductType.Size = New System.Drawing.Size(71, 13)
        Me.lbProductType.TabIndex = 6
        Me.lbProductType.Text = "Product Type"
        '
        'cmbProductType
        '
        Me.cmbProductType.FormattingEnabled = True
        Me.cmbProductType.Location = New System.Drawing.Point(21, 44)
        Me.cmbProductType.Name = "cmbProductType"
        Me.cmbProductType.Size = New System.Drawing.Size(106, 21)
        Me.cmbProductType.TabIndex = 0
        '
        'cmbSearch
        '
        Me.cmbSearch.FormattingEnabled = True
        Me.cmbSearch.Items.AddRange(New Object() {"Product ID", "Product Name"})
        Me.cmbSearch.Location = New System.Drawing.Point(48, 20)
        Me.cmbSearch.Name = "cmbSearch"
        Me.cmbSearch.Size = New System.Drawing.Size(121, 21)
        Me.cmbSearch.TabIndex = 9
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpProduct)
        Me.TabControl1.Controls.Add(Me.tpBill)
        Me.TabControl1.Controls.Add(Me.tpBillDetail)
        Me.TabControl1.Location = New System.Drawing.Point(-1, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(642, 349)
        Me.TabControl1.TabIndex = 10
        '
        'tpProduct
        '
        Me.tpProduct.Controls.Add(Me.cmbSearch)
        Me.tpProduct.Controls.Add(Me.dgvProduct)
        Me.tpProduct.Controls.Add(Me.GroupBox1)
        Me.tpProduct.Controls.Add(Me.btnAdd)
        Me.tpProduct.Controls.Add(Me.txtSearch)
        Me.tpProduct.Controls.Add(Me.btnEdit)
        Me.tpProduct.Controls.Add(Me.lbSearch)
        Me.tpProduct.Controls.Add(Me.btnDelete)
        Me.tpProduct.Location = New System.Drawing.Point(4, 22)
        Me.tpProduct.Name = "tpProduct"
        Me.tpProduct.Padding = New System.Windows.Forms.Padding(3)
        Me.tpProduct.Size = New System.Drawing.Size(634, 323)
        Me.tpProduct.TabIndex = 0
        Me.tpProduct.Text = "Product"
        Me.tpProduct.UseVisualStyleBackColor = True
        '
        'tpBill
        '
        Me.tpBill.Controls.Add(Me.cmbSearchBill)
        Me.tpBill.Controls.Add(Me.dgvBill)
        Me.tpBill.Controls.Add(Me.GroupBox2)
        Me.tpBill.Controls.Add(Me.btnAddBill)
        Me.tpBill.Controls.Add(Me.txtSearchBill)
        Me.tpBill.Controls.Add(Me.btnEditBill)
        Me.tpBill.Controls.Add(Me.Label2)
        Me.tpBill.Controls.Add(Me.btnDeleteBill)
        Me.tpBill.Location = New System.Drawing.Point(4, 22)
        Me.tpBill.Name = "tpBill"
        Me.tpBill.Padding = New System.Windows.Forms.Padding(3)
        Me.tpBill.Size = New System.Drawing.Size(634, 323)
        Me.tpBill.TabIndex = 1
        Me.tpBill.Text = "Bill"
        Me.tpBill.UseVisualStyleBackColor = True
        '
        'cmbSearchBill
        '
        Me.cmbSearchBill.FormattingEnabled = True
        Me.cmbSearchBill.Items.AddRange(New Object() {"Bill ID", "Data Buy"})
        Me.cmbSearchBill.Location = New System.Drawing.Point(51, 14)
        Me.cmbSearchBill.Name = "cmbSearchBill"
        Me.cmbSearchBill.Size = New System.Drawing.Size(121, 21)
        Me.cmbSearchBill.TabIndex = 17
        '
        'dgvBill
        '
        Me.dgvBill.AllowUserToAddRows = False
        Me.dgvBill.AllowUserToDeleteRows = False
        Me.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBill.Location = New System.Drawing.Point(18, 56)
        Me.dgvBill.MultiSelect = False
        Me.dgvBill.Name = "dgvBill"
        Me.dgvBill.ReadOnly = True
        Me.dgvBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBill.Size = New System.Drawing.Size(437, 248)
        Me.dgvBill.TabIndex = 10
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbCustomer)
        Me.GroupBox2.Controls.Add(Me.cmbCustomer)
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(481, 157)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(143, 91)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filter"
        '
        'lbCustomer
        '
        Me.lbCustomer.AutoSize = True
        Me.lbCustomer.Location = New System.Drawing.Point(18, 16)
        Me.lbCustomer.Name = "lbCustomer"
        Me.lbCustomer.Size = New System.Drawing.Size(51, 13)
        Me.lbCustomer.TabIndex = 6
        Me.lbCustomer.Text = "Customer"
        '
        'cmbCustomer
        '
        Me.cmbCustomer.FormattingEnabled = True
        Me.cmbCustomer.Location = New System.Drawing.Point(21, 44)
        Me.cmbCustomer.Name = "cmbCustomer"
        Me.cmbCustomer.Size = New System.Drawing.Size(106, 21)
        Me.cmbCustomer.TabIndex = 0
        '
        'btnAddBill
        '
        Me.btnAddBill.Location = New System.Drawing.Point(481, 56)
        Me.btnAddBill.Name = "btnAddBill"
        Me.btnAddBill.Size = New System.Drawing.Size(127, 23)
        Me.btnAddBill.TabIndex = 11
        Me.btnAddBill.Text = "Add"
        Me.btnAddBill.UseVisualStyleBackColor = True
        '
        'txtSearchBill
        '
        Me.txtSearchBill.Location = New System.Drawing.Point(179, 14)
        Me.txtSearchBill.Name = "txtSearchBill"
        Me.txtSearchBill.Size = New System.Drawing.Size(276, 20)
        Me.txtSearchBill.TabIndex = 15
        '
        'btnEditBill
        '
        Me.btnEditBill.Location = New System.Drawing.Point(481, 85)
        Me.btnEditBill.Name = "btnEditBill"
        Me.btnEditBill.Size = New System.Drawing.Size(127, 23)
        Me.btnEditBill.TabIndex = 12
        Me.btnEditBill.Text = "Edit"
        Me.btnEditBill.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Title"
        '
        'btnDeleteBill
        '
        Me.btnDeleteBill.Location = New System.Drawing.Point(481, 114)
        Me.btnDeleteBill.Name = "btnDeleteBill"
        Me.btnDeleteBill.Size = New System.Drawing.Size(127, 23)
        Me.btnDeleteBill.TabIndex = 13
        Me.btnDeleteBill.Text = "Delete"
        Me.btnDeleteBill.UseVisualStyleBackColor = True
        '
        'tpBillDetail
        '
        Me.tpBillDetail.Controls.Add(Me.ComboBox3)
        Me.tpBillDetail.Controls.Add(Me.DataGridView2)
        Me.tpBillDetail.Controls.Add(Me.GroupBox3)
        Me.tpBillDetail.Controls.Add(Me.Button4)
        Me.tpBillDetail.Controls.Add(Me.TextBox2)
        Me.tpBillDetail.Controls.Add(Me.Button5)
        Me.tpBillDetail.Controls.Add(Me.Label4)
        Me.tpBillDetail.Controls.Add(Me.Button6)
        Me.tpBillDetail.Location = New System.Drawing.Point(4, 22)
        Me.tpBillDetail.Name = "tpBillDetail"
        Me.tpBillDetail.Size = New System.Drawing.Size(634, 323)
        Me.tpBillDetail.TabIndex = 2
        Me.tpBillDetail.Text = "Bill Details"
        Me.tpBillDetail.UseVisualStyleBackColor = True
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"Product ID", "Product Name"})
        Me.ComboBox3.Location = New System.Drawing.Point(47, 16)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox3.TabIndex = 17
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(14, 58)
        Me.DataGridView2.MultiSelect = False
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(437, 248)
        Me.DataGridView2.TabIndex = 10
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.ComboBox4)
        Me.GroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox3.Location = New System.Drawing.Point(477, 159)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(143, 91)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Filter"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Product Type"
        '
        'ComboBox4
        '
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(21, 44)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(106, 21)
        Me.ComboBox4.TabIndex = 0
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(477, 58)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(127, 23)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "Add"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(175, 16)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(276, 20)
        Me.TextBox2.TabIndex = 15
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(477, 87)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(127, 23)
        Me.Button5.TabIndex = 12
        Me.Button5.Text = "Edit"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Title"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(477, 116)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(127, 23)
        Me.Button6.TabIndex = 13
        Me.Button6.Text = "Delete"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'frmQLBH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 348)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmQLBH"
        Me.Text = "QUAN LI BAN HANG"
        CType(Me.dgvProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.tpProduct.ResumeLayout(False)
        Me.tpProduct.PerformLayout()
        Me.tpBill.ResumeLayout(False)
        Me.tpBill.PerformLayout()
        CType(Me.dgvBill, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.tpBillDetail.ResumeLayout(False)
        Me.tpBillDetail.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvProduct As System.Windows.Forms.DataGridView
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents lbSearch As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbProductType As System.Windows.Forms.Label
    Friend WithEvents cmbProductType As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSearch As System.Windows.Forms.ComboBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tpProduct As System.Windows.Forms.TabPage
    Friend WithEvents tpBill As System.Windows.Forms.TabPage
    Friend WithEvents tpBillDetail As System.Windows.Forms.TabPage
    Friend WithEvents cmbSearchBill As System.Windows.Forms.ComboBox
    Friend WithEvents dgvBill As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lbCustomer As System.Windows.Forms.Label
    Friend WithEvents cmbCustomer As System.Windows.Forms.ComboBox
    Friend WithEvents btnAddBill As System.Windows.Forms.Button
    Friend WithEvents txtSearchBill As System.Windows.Forms.TextBox
    Friend WithEvents btnEditBill As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnDeleteBill As System.Windows.Forms.Button
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button

End Class
