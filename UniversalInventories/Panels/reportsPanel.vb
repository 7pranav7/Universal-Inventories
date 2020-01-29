Public Class reportsPanel
	Private Sub btnReset2_Click(sender As Object, e As EventArgs) Handles btnReset.Click
		FromDateTime.ResetText()
        ToDateTime.ResetText()
        txtReport.Clear()
        txtReport.Focus()
    End Sub

	Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
		txtReport.Clear()
        txtReport.Font = New Font(txtReport.Font.Name, 10, FontStyle.Regular)
        txtReport.Text = "Sales Report"


        Dim out As String = String.Format("{0}{1}{2}{3}{4}", "Date Of Sale".PadRight(25), "Sale ID".PadRight(17), "Total Cost".PadRight(18), "Total Sales".PadRight(17), "Profit".PadRight(15))
        txtReport.Text &= vbLf & "---------------------------------------------------------------------------------------"
		txtReport.Text &= vbLf & out
		txtReport.Text &= vbLf & "---------------------------------------------------------------------------------------"
		Try
			Dim fromDate As Date = FromDateTime.Value
            Dim toDate As Date = ToDateTime.Value
            If fromDate < toDate Then
                SALETableAdapter.FillBetweenDates(DSSystem.SALE, fromDate, toDate)
                Dim totalProfit As Double
                Dim totalSales As Double
                Dim totalCost As Double
                For i As Integer = 0 To SaleGrid.RowCount - 1
                    SALE_ITEMTableAdapter.FillBySaleID(DSSystem.SALE_ITEM, SaleGrid.Rows(i).Cells(0).Value)
                    Dim costPrice As Double = 0
                    For j As Integer = 0 To SaleItemGrid.RowCount - 1
                        costPrice += (SaleItemGrid.Rows(j).Cells(5).Value) * (SaleItemGrid.Rows(j).Cells(3).Value)
                    Next
                    Dim profit As Double = SaleGrid.Rows(i).Cells(2).Value - costPrice
                    Dim saleDate As String = SaleGrid.Rows(i).Cells(1).Value
                    Dim amount As Double = SaleGrid.Rows(i).Cells(2).Value
                    Dim saleID As Double = SaleGrid.Rows(i).Cells(0).Value
                    totalSales += amount
                    totalProfit += profit
                    totalCost += costPrice
                    If (profit <> 0 And saleDate <> "" AndAlso amount <> 0) Then

                        txtReport.Text &= vbLf & String.Format("{0}{1}{2}{3}{4}", saleDate.PadRight(25), CStr(saleID).PadRight(17), FormatCurrency(costPrice).PadRight(18), FormatCurrency(amount).PadRight(17), FormatCurrency(profit).PadRight(15))
                    End If
                Next
                txtReport.Text &= vbLf & "---------------------------------------------------------------------------------------"

                txtReport.Text &= vbLf & String.Format("{0}{1}", "VAT Exclusive Total:".PadRight(25), FormatCurrency(totalSales / ((100 + MainForm.insertProductPanel.vat) / 100)).PadRight(15))

                txtReport.Text &= vbLf & String.Format("{0}{1}", "VAT Total:".PadRight(25), FormatCurrency(totalSales * (MainForm.insertProductPanel.vat / 100)).PadRight(15))

                txtReport.Text &= vbLf & String.Format("{0}{1}", "Total Sales:".PadRight(25), FormatCurrency(totalSales).PadRight(15))

                txtReport.Text &= vbLf & String.Format("{0}{1}", "Total Cost Of Sales:".PadRight(25), FormatCurrency(totalCost).PadRight(15))

                txtReport.Text &= vbLf & vbLf & String.Format("{0}{1}", "Total Profit:".PadRight(25), FormatCurrency(totalProfit).PadRight(15))

                txtReport.Text &= vbLf & "---------------------------------------------------------------------------------------"

            Else
                MessageBox.Show("To Date cannot be before or equal to From Date.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            txtReport.Focus()
        Catch ex As Exception

		End Try


    End Sub

	Private Sub reportsPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		SaleItemGrid.Visible = False
		SaleGrid.Visible = False
		txtReport.Font = New Font(txtReport.Font.Name, 10, FontStyle.Regular)
        Dim out As String = String.Format("{0}{1}{2}{3}{4}", "Date Of Sale".PadRight(25), "Sale ID".PadRight(17), "Total Cost".PadRight(18), "Total Sales".PadRight(17), "Profit".PadRight(15))
        txtReport.Text &= vbLf & "---------------------------------------------------------------------------------------"
		txtReport.Text &= vbLf & out
		txtReport.Text &= vbLf & "---------------------------------------------------------------------------------------"
	End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        MainForm.displayPanel.Controls.Clear()


        MainForm.displayPanel.Controls.Add(MainForm.viewReportsPanel)
        MainForm.reportsPanel = New reportsPanel
    End Sub
End Class
