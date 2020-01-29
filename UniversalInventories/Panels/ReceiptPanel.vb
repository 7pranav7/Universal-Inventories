Public Class ReceiptPanel
    Public Shared saleID As Integer
    Public Shared customerString As String = ""

    Private Sub ReceiptPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SALE_ITEMTableAdapter.FillBySaleID(DSSystem.SALE_ITEM, saleID)
        SALETableAdapter.FillBySaleID(DSSystem.SALE, saleID)
        EMPLOYEETableAdapter.FillByEmpID(DSSystem.EMPLOYEE, SALEDataGridView.Rows(0).Cells(3).Value)
        PRODUCTTableAdapter.Fill(DSSystem.PRODUCT)
        txtReceipt.Font = New Font(txtReceipt.Font.Name, 10, FontStyle.Regular)
        txtReceipt.Text &= vbLf & "Sale Number: " & SALEDataGridView.Rows(0).Cells(0).Value
        txtReceipt.Text &= vbLf & "Date: " & SALEDataGridView.Rows(0).Cells(1).Value
        txtReceipt.Text &= vbLf & "Cashier: " & EMPLOYEEDataGridView.Rows(0).Cells(1).Value
        txtReceipt.Text &= vbLf & "---------------------------------------------------------------------------------------"
        Dim out As String = String.Format("{0}{1}{2}", "Item".PadRight(63), "Quantity".PadRight(8), "Subtotal".PadLeft(15))
        txtReceipt.Text &= vbLf & out
        txtReceipt.Text &= vbLf & "---------------------------------------------------------------------------------------"
        For i As Integer = 0 To SALE_ITEMDataGridView.RowCount - 1

            Dim productID As Integer = SALE_ITEMDataGridView.Rows(i).Cells(0).Value
            For j As Integer = 0 To PRODUCTDataGridView.RowCount - 1
                If PRODUCTDataGridView.Rows(j).Cells(0).Value = productID Then

                    txtReceipt.Text &= vbLf & String.Format("{0}{1}{2}", CStr(PRODUCTDataGridView.Rows(j).Cells(1).Value).PadRight(63), CStr(SALE_ITEMDataGridView.Rows(i).Cells(3).Value).PadLeft(8), FormatCurrency(SALE_ITEMDataGridView.Rows(i).Cells(4).Value).PadLeft(15))
                    Exit For

                End If
            Next

        Next
        txtReceipt.Text &= vbLf & "---------------------------------------------------------------------------------------"
        Dim tax As Double = SALEDataGridView.Rows(0).Cells(2).Value * (MainForm.insertProductPanel.vat / 100)
        txtReceipt.Text &= vbLf & String.Format("{0}{1}", "VAT Exclusive Total: ".PadLeft(75), FormatCurrency(SALEDataGridView.Rows(0).Cells(2).Value - tax).PadRight(20))
        txtReceipt.Text &= vbLf & String.Format("{0}{1}", "VAT Total: ".PadLeft(75), FormatCurrency(tax).PadRight(20))
        txtReceipt.Text &= vbLf & String.Format("{0}{1}", "Final Total: ".PadLeft(75), FormatCurrency(SALEDataGridView.Rows(0).Cells(2).Value).PadRight(20))
        txtReceipt.Text &= vbLf & vbLf & "Thank You For Your Purchase!"
        txtReceipt.Text &= vbLf & vbLf & customerString

    End Sub

    Private Sub btnFinish_Click(sender As Object, e As EventArgs) Handles btnFinish.Click
        MainForm.displayPanel.Controls.Clear()
        MainForm.salePanel = New salePanel
        MainForm.displayPanel.Controls.Add(MainForm.salePanel)
    End Sub
End Class
