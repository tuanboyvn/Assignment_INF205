Public Class frmQLBH
    Private _DBAccess As New DataBaseAccess

    Private _isLoading As Boolean = False


    Private Sub LoadDataOnComBoBox()
        Dim sqlQuery As String = "SELECT id_loai_sp, ten_loai From dbo.loai_sp"
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.cmbProductType.DataSource = dTable
        Me.cmbProductType.ValueMember = "id_loai_sp"
        Me.cmbProductType.DisplayMember = "ten_loai"
    End Sub

    Private Sub LoadDataOnGridView(id_loai_sp As String)
        Dim sqlQuery As String = _
            String.Format("SELECT id_sp, ten_sp, gia_sp, mo_ta  From dbo.san_pham Where id_loai_sp = '{0}'", id_loai_sp)
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.dgvProduct.DataSource = dTable
        With Me.dgvProduct
            .Columns(0).HeaderText = "Product ID"
            .Columns(1).HeaderText = "Product Name"
            .Columns(2).HeaderText = "Price"
            .Columns(3).HeaderText = "Description"
        End With
    End Sub

    Private Sub frmQLBH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _isLoading = True
        LoadDataOnComBoBox()
        LoadDataOnComBoBoxBill()
        LoadDataOnGridView(Me.cmbProductType.SelectedValue)
        LoadDataOnGridViewBill(Me.cmbCustomer.SelectedValue)
        _isLoading = False
    End Sub

    Private Sub cmbProductType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProductType.SelectedIndexChanged
        If Not _isLoading Then
            LoadDataOnGridView(Me.cmbProductType.SelectedValue)
        End If
    End Sub

    Private Sub SearchProduct(id_loai_sp As String, value As String)
        Dim sqlQuery As String = _
            String.Format("SELECT id_sp, ten_sp, gia_sp, mo_ta  From dbo.san_pham Where id_loai_sp = '{0}'", id_loai_sp)
        If Me.cmbSearch.SelectedIndex = 0 Then
            sqlQuery += String.Format(" AND id_sp LIKE '{0}%'", value)
        ElseIf Me.cmbSearch.SelectedIndex = 1 Then
            sqlQuery += String.Format(" AND ten_sp LIKE '{0}%'", value)
        End If
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.dgvProduct.DataSource = dTable
        With Me.dgvProduct
            .Columns(0).HeaderText = "Product ID"
            .Columns(1).HeaderText = "Product Name"
            .Columns(2).HeaderText = "Price"
            .Columns(3).HeaderText = "Description"
        End With
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        SearchProduct(Me.cmbProductType.SelectedValue, Me.txtSearch.Text)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim frm As New frmProduct(False)
        frm.txtProductTypeID.Text = Me.cmbProductType.SelectedValue
        frm.ShowDialog()
        If frm.DialogResult = Windows.Forms.DialogResult.OK Then
            LoadDataOnGridView(Me.cmbProductType.SelectedValue)
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim frm As New frmProduct(True)
        frm.txtProductTypeID.Text = Me.cmbProductType.SelectedValue
        frm.txtProductID.ReadOnly = True
        With Me.dgvProduct
            frm.txtProductID.Text = .Rows(.CurrentCell.RowIndex).Cells("id_sp").Value
            frm.txtProductName.Text = .Rows(.CurrentCell.RowIndex).Cells("ten_sp").Value
            frm.txtPrice.Text = .Rows(.CurrentCell.RowIndex).Cells("gia_sp").Value
            frm.txtDescription.Text = .Rows(.CurrentCell.RowIndex).Cells("mo_ta").Value
        End With
        frm.ShowDialog()
        If frm.DialogResult = Windows.Forms.DialogResult.OK Then
            LoadDataOnGridView(Me.cmbProductType.SelectedValue)
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim ProductID As String = Me.dgvProduct.Rows(Me.dgvProduct.CurrentCell.RowIndex).Cells("id_sp").Value
        Dim sqlQuery As String = String.Format("DELETE san_pham Where id_sp = '{0}'", ProductID)

        If _DBAccess.ExecuteNoneQuery(sqlQuery) Then
            MessageBox.Show("Da xoa du lieu thanh cong!")
            LoadDataOnGridView(Me.cmbProductType.SelectedValue)
        Else
            MessageBox.Show("Loi xoa du lieu!")
        End If
    End Sub

    ' *********TAB BILL*********
    Private Sub LoadDataOnComBoBoxBill()
        Dim sqlQuery As String = "SELECT id_kh, ten_kh From dbo.khach_hang"
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.cmbCustomer.DataSource = dTable
        Me.cmbCustomer.ValueMember = "id_kh"
        Me.cmbCustomer.DisplayMember = "ten_kh"
    End Sub

    Private Sub LoadDataOnGridViewBill(id_kh As String)
        Dim sqlQuery As String = _
            String.Format("SELECT id_hd, ngay_mua From dbo.hoa_don Where id_kh = '{0}'", id_kh)
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.dgvBill.DataSource = dTable
        With Me.dgvBill
            .Columns(0).HeaderText = "Bill ID"
            .Columns(1).HeaderText = "Date Buy"
        End With
    End Sub

    Private Sub cmbCustomer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCustomer.SelectedIndexChanged
        If Not _isLoading Then
            LoadDataOnGridViewBill(Me.cmbCustomer.SelectedValue)
        End If
    End Sub

    Private Sub SearchBill(id_kh As String, value As String)
        Dim sqlQuery As String = _
            String.Format("SELECT id_hd, ngay_mua From dbo.hoa_don Where id_kh = '{0}'", id_kh)
        If Me.cmbSearchBill.SelectedIndex = 0 Then
            sqlQuery += String.Format(" AND id_hd LIKE '{0}%'", value)
        ElseIf Me.cmbSearchBill.SelectedIndex = 1 Then
            sqlQuery += String.Format(" AND ngay_mua LIKE '{0}%'", value)
        End If
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.dgvBill.DataSource = dTable
        With Me.dgvBill
            .Columns(0).HeaderText = "Bill ID"
            .Columns(1).HeaderText = "Date Buy"
        End With
    End Sub

    Private Sub txtSearchBill_TextChanged(sender As Object, e As EventArgs) Handles txtSearchBill.TextChanged
        SearchBill(Me.cmbCustomer.SelectedValue, Me.txtSearchBill.Text)
    End Sub

    Private Sub btnAddBill_Click(sender As Object, e As EventArgs) Handles btnAddBill.Click
        Dim frm As New frmBill(False)
        frm.txtCustomerID.Text = Me.cmbCustomer.SelectedValue
        frm.ShowDialog()
        If frm.DialogResult = Windows.Forms.DialogResult.OK Then
            LoadDataOnGridViewBill(Me.cmbCustomer.SelectedValue)
        End If
    End Sub

    Private Sub btnEditBill_Click(sender As Object, e As EventArgs) Handles btnEditBill.Click
        Dim frm As New frmBill(True)
        frm.txtCustomerID.Text = Me.cmbCustomer.SelectedValue
        frm.txtBillID.ReadOnly = True
        With Me.dgvBill
            frm.txtBillID.Text = .Rows(.CurrentCell.RowIndex).Cells("id_hd").Value
            frm.txtDateBuy.Text = .Rows(.CurrentCell.RowIndex).Cells("ngay_mua").Value
        End With
        frm.ShowDialog()
        If frm.DialogResult = Windows.Forms.DialogResult.OK Then
            LoadDataOnGridViewBill(Me.cmbCustomer.SelectedValue)
        End If
    End Sub

    Private Sub btnDeleteBill_Click(sender As Object, e As EventArgs) Handles btnDeleteBill.Click
        Dim BillID As String = Me.dgvBill.Rows(Me.dgvBill.CurrentCell.RowIndex).Cells("id_hd").Value
        Dim sqlQuery As String = String.Format("DELETE hoa_don Where id_hd = '{0}'", BillID)

        If _DBAccess.ExecuteNoneQuery(sqlQuery) Then
            MessageBox.Show("Da xoa du lieu thanh cong!")
            LoadDataOnGridViewBill(Me.cmbCustomer.SelectedValue)
        Else
            MessageBox.Show("Loi xoa du lieu!")
        End If
    End Sub
End Class
