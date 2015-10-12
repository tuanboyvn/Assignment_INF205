Public Class frmProduct

    Private _DBAccess As New DataBaseAccess

    Private _isEdit As Boolean = False

    Public Sub New(IsEdit As Boolean)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _isEdit = IsEdit
    End Sub

    Private Function InsertProduct() As Boolean
        Dim sqlQuery As String = "INSERT INTO san_pham (id_sp, id_loai_sp, ten_sp, gia_sp, mo_ta) "
        sqlQuery += String.Format("VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')", _
                                  txtProductID.Text, txtProductTypeID.Text, txtProductName.Text, txtPrice.Text, txtDescription.Text)
        Return _DBAccess.ExecuteNoneQuery(sqlQuery)
    End Function

    Private Function UpdateProduct() As Boolean
        Dim sqlQuery As String = String.Format("UPDATE san_pham SET ten_sp = '{0}', gia_sp = '{1}', mo_ta = '{2}' WHERE id_sp = '{3}'", _
                                               Me.txtProductName.Text, Me.txtPrice.Text, Me.txtDescription.Text, Me.txtProductID.Text)
        Return _DBAccess.ExecuteNoneQuery(sqlQuery)
    End Function


    Private Function IsEmpty() As Boolean
        Return (String.IsNullOrEmpty(txtProductID.Text) OrElse String.IsNullOrEmpty(txtProductTypeID.Text) OrElse _
            String.IsNullOrEmpty(txtProductName.Text) OrElse String.IsNullOrEmpty(txtPrice.Text) OrElse _
            String.IsNullOrEmpty(txtDescription.Text))
    End Function

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If IsEmpty() Then
            MessageBox.Show("Hay nhap gia tri vao truoc khi ghi vao database", "Error", MessageBoxButtons.OK)
        Else
            If _isEdit Then
                If UpdateProduct() Then
                    MessageBox.Show("Sua du lieu thanh cong!", "Information", MessageBoxButtons.OK)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    MessageBox.Show("Loi sua du lieu!", "Error", MessageBoxButtons.OK)
                    Me.DialogResult = Windows.Forms.DialogResult.No
                End If
            Else
                If InsertProduct() Then
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

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    
End Class