Public Class frmBill

    Private _DBAccess As New DataBaseAccess

    Private _isEdit As Boolean = False

    Public Sub New(IsEdit As Boolean)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _isEdit = IsEdit
    End Sub

    Private Function InsertBill() As Boolean
        Dim sqlQuery As String = "INSERT INTO hoa_don (id_hd, id_kh, ngay_mua) "
        sqlQuery += String.Format("VALUES ('{0}', '{1}', '{2}')", _
                                  txtBillID.Text, txtCustomerID.Text, txtDateBuy.Text)
        Return _DBAccess.ExecuteNoneQuery(sqlQuery)
    End Function

    Private Function UpdateBill() As Boolean
        Dim sqlQuery As String = String.Format("UPDATE hoa_don SET ngay_mua = '{0}' WHERE id_hd = '{1}'", _
                                               Me.txtDateBuy.Text, Me.txtBillID.Text)
        Return _DBAccess.ExecuteNoneQuery(sqlQuery)
    End Function

    Private Function IsEmpty() As Boolean
        Return (String.IsNullOrEmpty(txtBillID.Text) OrElse String.IsNullOrEmpty(txtCustomerID.Text) OrElse _
            String.IsNullOrEmpty(txtDateBuy.Text))
    End Function

    Private Sub btnOKBill_Click(sender As Object, e As EventArgs) Handles btnOKBill.Click
        If IsEmpty() Then
            MessageBox.Show("Hay nhap gia tri vao truoc khi ghi vao database", "Error", MessageBoxButtons.OK)
        Else
            If _isEdit Then
                If UpdateBill() Then
                    MessageBox.Show("Sua du lieu thanh cong!", "Information", MessageBoxButtons.OK)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    MessageBox.Show("Loi sua du lieu!", "Error", MessageBoxButtons.OK)
                    Me.DialogResult = Windows.Forms.DialogResult.No
                End If
            Else
                If InsertBill() Then
                    MessageBox.Show("Them du lieu thanh cong!", "Information", MessageBoxButtons.OK)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    MessageBox.Show("Loi them du lieu!", "Error", MessageBoxButtons.OK)
                    Me.DialogResult = Windows.Forms.DialogResult.No
                End If
            End If
            Me.Close()
        End If
    End Sub

    Private Sub btnCancelBill_Click(sender As Object, e As EventArgs) Handles btnCancelBill.Click
        Me.Close()
    End Sub
End Class