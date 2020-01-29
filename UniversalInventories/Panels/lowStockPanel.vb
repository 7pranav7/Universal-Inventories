Public Class lowStockPanel
    Private Sub lowStockPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PRODUCTTableAdapter.LowStockFill(DSSystem.PRODUCT)
    End Sub

    Private Sub PRODUCTDataGridView_SelectionChanged(sender As Object, e As EventArgs) Handles PRODUCTDataGridView.SelectionChanged
        Dim supplierID As Integer = CInt(ProducT_SUPPLIERTableAdapter.getProductID(PRODUCTDataGridView.CurrentRow.Cells(0).Value))
        SupplierTableAdapter.FillBySupplierID(DSSystem.SUPPLIER, supplierID)
        txtSupplier.Text = DSSystem.SUPPLIER.Rows(0).Item(1)
        txtNumber.Text = DSSystem.SUPPLIER.Rows(0).Item(2)
        txtEmail.Text = DSSystem.SUPPLIER.Rows(0).Item(3)
        ListBox.Items.Clear()
        For i As Integer = 4 To 8
            ListBox.Items.Add(DSSystem.SUPPLIER.Rows(0).Item(i))
        Next
    End Sub
End Class
