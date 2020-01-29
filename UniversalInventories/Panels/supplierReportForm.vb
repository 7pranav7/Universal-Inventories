Public Class supplierReportForm
    Private Sub supplierReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProductTableAdapter.Fill(DsSystem.PRODUCT)
        ProducT_SUPPLIERTableAdapter.Fill(DsSystem.PRODUCT_SUPPLIER)
        SupplierTableAdapter.Fill(DsSystem.SUPPLIER)
        supplierReport.SetDataSource(DsSystem)
    End Sub
End Class