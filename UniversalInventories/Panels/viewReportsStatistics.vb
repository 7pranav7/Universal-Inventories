Public Class viewReportsStatistics
    Private Sub viewReportsStatistics_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dVsTSalesTile.TextAlign = ContentAlignment.MiddleCenter
        pVsQTile.TextAlign = ContentAlignment.MiddleCenter
        pVsSValueTile.TextAlign = ContentAlignment.MiddleCenter
        dVsProductsSoldTile.TextAlign = ContentAlignment.MiddleCenter
        categoryVsSalesTile.TextAlign = ContentAlignment.MiddleCenter
        dVsAccProfitTile.TextAlign = ContentAlignment.MiddleCenter
        dVsNoSalesTile.TextAlign = ContentAlignment.MiddleCenter
        pVsPrevSaleTotalTile.TextAlign = ContentAlignment.MiddleCenter
        pVsQSoldRateTile.TextAlign = ContentAlignment.MiddleCenter
        pVsQSoldRateTile.Text = "Products Vs. Quantity Sold" & Environment.NewLine & "Rate"

        SaledatevsaccprofitTableAdapter.Fill(DsSystem.SALEDATEVSACCPROFIT)
        Dim profit As Double
        For i As Integer = 0 To DsSystem.SALEDATEVSACCPROFIT.Rows.Count - 1
            profit += (CDbl(DsSystem.SALEDATEVSACCPROFIT.Rows(i).Item(2)) - CDbl(DsSystem.SALEDATEVSACCPROFIT.Rows(i).Item(1)))
        Next
        lblProfit.Text = FormatCurrency(profit)


        ProductvsqsoldrateTableAdapter.Fill(DsSystem.PRODUCTVSQSOLDRATE)
        Dim totalQuantity As Double
        Dim max As Double = 0
        Dim name As String = ""
        For i As Integer = 0 To DsSystem.PRODUCTVSQSOLDRATE.Rows.Count - 1
            totalQuantity += CDbl(DsSystem.PRODUCTVSQSOLDRATE.Rows(i).Item(1))
        Next

        For i As Integer = 0 To DsSystem.PRODUCTVSQSOLDRATE.Rows.Count - 1
            Dim percent As Double = CDbl(DsSystem.PRODUCTVSQSOLDRATE.Rows(i).Item(1)) / totalQuantity * 100
            If percent > max Then
                max = percent
                name = DsSystem.PRODUCTVSQSOLDRATE.Rows(i).Item(0)
            End If
        Next
        lblBestProduct.Text = name


        SaledatevstotalTableAdapter.Fill(DsSystem.SALEDATEVSTOTAL)
        Dim totalSales As Double
        For i As Integer = 0 To DsSystem.SALEDATEVSTOTAL.Rows.Count - 1
            totalSales += CDbl(DsSystem.SALEDATEVSTOTAL.Rows(i).Item(1))
        Next
        lblSalesTotal.Text = FormatCurrency(totalSales)
    End Sub

    Private Sub pVsQTile_Click(sender As Object, e As EventArgs) Handles pVsQTile.Click
        ProductTableAdapter.FillSale(DsSystem.PRODUCT)
        MainForm.graphPanel.graph.Series.Clear()
        MainForm.graphPanel.Label1.Visible = True
        MainForm.graphPanel.Label1.Text = "Bar Chart: Product Vs. Quantity Currently in Stock"
        MainForm.graphPanel.graph.ChartAreas("ChartArea1").AxisX.Title = "Products"
        MainForm.graphPanel.graph.ChartAreas("ChartArea1").AxisY.Title = "Quantity"

        MainForm.graphPanel.graph.ChartAreas("ChartArea1").CursorX.IsUserSelectionEnabled = True
        MainForm.graphPanel.graph.ChartAreas("ChartArea1").CursorY.IsUserSelectionEnabled = True
        MainForm.graphPanel.graph.ChartAreas("ChartArea1").AxisX.ScaleView.Zoomable = True
        MainForm.graphPanel.graph.ChartAreas("ChartArea1").AxisY.ScaleView.Zoomable = True
        MainForm.graphPanel.graph.ChartAreas("ChartArea1").CursorX.AutoScroll = True
        MainForm.graphPanel.graph.ChartAreas("ChartArea1").CursorY.AutoScroll = True

        MainForm.graphPanel.graph.Series.Add("Product Vs. Quantity")
        For i As Integer = 0 To DsSystem.PRODUCT.Rows.Count - 1
            MainForm.graphPanel.graph.Series("Product Vs. Quantity").Points.AddXY(DsSystem.PRODUCT.Rows(i).Item(1), DsSystem.PRODUCT.Rows(i).Item(3))
        Next

        MainForm.displayPanel.Controls.Clear()
        MainForm.displayPanel.Controls.Add(MainForm.graphPanel)
    End Sub

    Private Sub pVsSValueTile_Click(sender As Object, e As EventArgs) Handles pVsSValueTile.Click
        ProductTableAdapter.FillSale(DsSystem.PRODUCT)
        MainForm.graphPanel.graph.Series.Clear()
        MainForm.graphPanel.Label1.Visible = True
        MainForm.graphPanel.Label1.Text = "Bar Chart: Product Vs. Stock Value"
        MainForm.graphPanel.graph.ChartAreas("ChartArea1").CursorX.IsUserSelectionEnabled = True
        MainForm.graphPanel.graph.ChartAreas("ChartArea1").CursorY.IsUserSelectionEnabled = True
        MainForm.graphPanel.graph.ChartAreas("ChartArea1").AxisX.ScaleView.Zoomable = True
        MainForm.graphPanel.graph.ChartAreas("ChartArea1").AxisY.ScaleView.Zoomable = True
        MainForm.graphPanel.graph.ChartAreas("ChartArea1").CursorX.AutoScroll = True
        MainForm.graphPanel.graph.ChartAreas("ChartArea1").CursorY.AutoScroll = True
        MainForm.graphPanel.graph.ChartAreas("ChartArea1").AxisX.Title = "Products"
        MainForm.graphPanel.graph.ChartAreas("ChartArea1").AxisY.Title = "Price (ZAR)"
        MainForm.graphPanel.graph.Series.Add("Product Vs. Stock Value (Markup Price)")
        MainForm.graphPanel.graph.Series.Add("Product Vs. Stock Value (Cost Price)")
        For i As Integer = 0 To DsSystem.PRODUCT.Rows.Count - 1
            Dim stockVal As Double = CDbl(DsSystem.PRODUCT.Rows(i).Item(3)) * CDbl(DsSystem.PRODUCT.Rows(i).Item(2))
            Dim costPriceVale As Double = CDbl(DsSystem.PRODUCT.Rows(i).Item(3)) * CDbl(DsSystem.PRODUCT.Rows(i).Item(6))
            MainForm.graphPanel.graph.Series("Product Vs. Stock Value (Markup Price)").Points.AddXY(DsSystem.PRODUCT.Rows(i).Item(1), stockVal)
            MainForm.graphPanel.graph.Series("Product Vs. Stock Value (Cost Price)").Points.AddXY(DsSystem.PRODUCT.Rows(i).Item(1), costPriceVale)
        Next

        MainForm.displayPanel.Controls.Clear()
        MainForm.displayPanel.Controls.Add(MainForm.graphPanel)
    End Sub

    Private Sub dVsTSalesTile_Click(sender As Object, e As EventArgs) Handles dVsTSalesTile.Click
        SaledatevstotalTableAdapter.Fill(DsSystem.SALEDATEVSTOTAL)
        MainForm.graphPanel.graph.Series.Clear()
        MainForm.graphPanel.Label1.Visible = True
        MainForm.graphPanel.Label1.Text = "Bar Chart: Date Vs. Total Sales"
        MainForm.graphPanel.graph.ChartAreas("ChartArea1").CursorX.IsUserSelectionEnabled = True
        MainForm.graphPanel.graph.ChartAreas("ChartArea1").CursorY.IsUserSelectionEnabled = True
        MainForm.graphPanel.graph.ChartAreas("ChartArea1").AxisX.ScaleView.Zoomable = True
        MainForm.graphPanel.graph.ChartAreas("ChartArea1").AxisY.ScaleView.Zoomable = True
        MainForm.graphPanel.graph.ChartAreas("ChartArea1").CursorX.AutoScroll = True
        MainForm.graphPanel.graph.ChartAreas("ChartArea1").CursorY.AutoScroll = True
        MainForm.graphPanel.graph.ChartAreas("ChartArea1").AxisX.Title = "Date"
        MainForm.graphPanel.graph.ChartAreas("ChartArea1").AxisY.Title = "Price (ZAR)"
        MainForm.graphPanel.graph.Series.Add("Date Vs. Total Sales")
        For i As Integer = 0 To DsSystem.SALEDATEVSTOTAL.Rows.Count - 1
            MainForm.graphPanel.graph.Series("Date Vs. Total Sales").Points.AddXY(CStr(DsSystem.SALEDATEVSTOTAL.Rows(i).Item(0)), DsSystem.SALEDATEVSTOTAL.Rows(i).Item(1))
        Next

        MainForm.displayPanel.Controls.Clear()
        MainForm.displayPanel.Controls.Add(MainForm.graphPanel)
    End Sub

    Private Sub dVsProductsSoldTile_Click(sender As Object, e As EventArgs) Handles dVsProductsSoldTile.Click
        SaledatevsqsoldTableAdapter.Fill(DsSystem.SALEDATEVSQSOLD)
        MainForm.graphPanel.graph.Series.Clear()
        MainForm.graphPanel.Label1.Visible = True
        MainForm.graphPanel.Label1.Text = "Bar Chart: Date Vs. No. of Products Sold"
        MainForm.graphPanel.graph.ChartAreas("ChartArea1").CursorX.IsUserSelectionEnabled = True
        MainForm.graphPanel.graph.ChartAreas("ChartArea1").CursorY.IsUserSelectionEnabled = True
        MainForm.graphPanel.graph.ChartAreas("ChartArea1").AxisX.ScaleView.Zoomable = True
        MainForm.graphPanel.graph.ChartAreas("ChartArea1").AxisY.ScaleView.Zoomable = True
        MainForm.graphPanel.graph.ChartAreas("ChartArea1").CursorX.AutoScroll = True
        MainForm.graphPanel.graph.ChartAreas("ChartArea1").CursorY.AutoScroll = True
        MainForm.graphPanel.graph.ChartAreas("ChartArea1").AxisX.Title = "Date"
        MainForm.graphPanel.graph.ChartAreas("ChartArea1").AxisY.Title = "Products Sold"
        MainForm.graphPanel.graph.Series.Add("Date Vs. No. of Products Sold")
        For i As Integer = 0 To DsSystem.SALEDATEVSQSOLD.Rows.Count - 1
            MainForm.graphPanel.graph.Series("Date Vs. No. of Products Sold").Points.AddXY(CStr(DsSystem.SALEDATEVSQSOLD.Rows(i).Item(0)), DsSystem.SALEDATEVSQSOLD.Rows(i).Item(1))
        Next

        MainForm.displayPanel.Controls.Clear()
        MainForm.displayPanel.Controls.Add(MainForm.graphPanel)
    End Sub

    Private Sub categoryVsSalesTile_Click(sender As Object, e As EventArgs) Handles categoryVsSalesTile.Click
        CategoryvstotalTableAdapter.Fill(DsSystem.CATEGORYVSTOTAL)
        MainForm.graphPanel.Label1.Visible = True
        MainForm.graphPanel.graph.Series.Clear()
        MainForm.graphPanel.graph.ChartAreas("ChartArea1").AxisX.Title = "Pie Chart: Product Category Vs. Total Sales"

        MainForm.graphPanel.graph.Series.Add("Product Category Vs. Total Sales")
        MainForm.graphPanel.graph.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Pie
        MainForm.graphPanel.graph.Series("Product Category Vs. Total Sales").IsValueShownAsLabel = True
        MainForm.graphPanel.graph.Series("Product Category Vs. Total Sales").LabelFormat = "#.##%"
        Dim finalTotal As Double
        For i As Integer = 0 To DsSystem.CATEGORYVSTOTAL.Rows.Count - 1
            finalTotal += CDbl(DsSystem.CATEGORYVSTOTAL.Rows(i).Item(1))
        Next

        For i As Integer = 0 To DsSystem.CATEGORYVSTOTAL.Rows.Count - 1

            Dim total As Double = CDbl(DsSystem.CATEGORYVSTOTAL.Rows(i).Item(1))
            Dim percentage As Double = total / finalTotal
            MainForm.graphPanel.graph.Series("Product Category Vs. Total Sales").Points.AddXY(CStr(DsSystem.CATEGORYVSTOTAL.Rows(i).Item(0)), percentage)
        Next



        MainForm.displayPanel.Controls.Clear()
        MainForm.displayPanel.Controls.Add(MainForm.graphPanel)
    End Sub

    Private Sub dVsAccProfitTile_Click(sender As Object, e As EventArgs) Handles dVsAccProfitTile.Click
        SaledatevsaccprofitTableAdapter.Fill(DsSystem.SALEDATEVSACCPROFIT)
        MainForm.graphPanel.graph.Series.Clear()
        MainForm.graphPanel.Label1.Visible = True
        MainForm.graphPanel.Label1.Text = "Line Chart: Date Vs. Accumulated Profit"
        MainForm.graphPanel.graph.ChartAreas("ChartArea1").CursorX.IsUserSelectionEnabled = True
        MainForm.graphPanel.graph.ChartAreas("ChartArea1").CursorY.IsUserSelectionEnabled = True
        MainForm.graphPanel.graph.ChartAreas("ChartArea1").AxisX.ScaleView.Zoomable = True
        MainForm.graphPanel.graph.ChartAreas("ChartArea1").AxisY.ScaleView.Zoomable = True
        MainForm.graphPanel.graph.ChartAreas("ChartArea1").CursorX.AutoScroll = True
        MainForm.graphPanel.graph.ChartAreas("ChartArea1").CursorY.AutoScroll = True
        MainForm.graphPanel.graph.ChartAreas("ChartArea1").AxisX.Title = "Date"
        MainForm.graphPanel.graph.ChartAreas("ChartArea1").AxisY.Title = "Price (ZAR)"
        MainForm.graphPanel.graph.Series.Add("Date Vs. Accumulated Profit")
        MainForm.graphPanel.graph.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Line

        Dim profit As Double
        For i As Integer = 0 To DsSystem.SALEDATEVSACCPROFIT.Rows.Count - 1
            profit += (CDbl(DsSystem.SALEDATEVSACCPROFIT.Rows(i).Item(2)) - CDbl(DsSystem.SALEDATEVSACCPROFIT.Rows(i).Item(1)))
            MainForm.graphPanel.graph.Series("Date Vs. Accumulated Profit").Points.AddXY(CStr(DsSystem.SALEDATEVSACCPROFIT.Rows(i).Item(0)), profit)
        Next

        MainForm.displayPanel.Controls.Clear()
        MainForm.displayPanel.Controls.Add(MainForm.graphPanel)
    End Sub

    Private Sub dVsNoSalesTile_Click(sender As Object, e As EventArgs) Handles dVsNoSalesTile.Click
        SaledatevsnumsalesTableAdapter.Fill(DsSystem.SALEDATEVSNUMSALES)
        MainForm.graphPanel.graph.Series.Clear()
        MainForm.graphPanel.Label1.Visible = True
        MainForm.graphPanel.Label1.Text = "Line Chart: Date Vs. No. of Sales"
        MainForm.graphPanel.graph.ChartAreas("ChartArea1").CursorX.IsUserSelectionEnabled = True
        MainForm.graphPanel.graph.ChartAreas("ChartArea1").CursorY.IsUserSelectionEnabled = True
        MainForm.graphPanel.graph.ChartAreas("ChartArea1").AxisX.ScaleView.Zoomable = True
        MainForm.graphPanel.graph.ChartAreas("ChartArea1").AxisY.ScaleView.Zoomable = True
        MainForm.graphPanel.graph.ChartAreas("ChartArea1").CursorX.AutoScroll = True
        MainForm.graphPanel.graph.ChartAreas("ChartArea1").CursorY.AutoScroll = True
        MainForm.graphPanel.graph.ChartAreas("ChartArea1").AxisX.Title = "Date"
        MainForm.graphPanel.graph.ChartAreas("ChartArea1").AxisY.Title = "No. of Sales"
        MainForm.graphPanel.graph.Series.Add("Date Vs. No. of Sales")
        MainForm.graphPanel.graph.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Line

        For i As Integer = 0 To DsSystem.SALEDATEVSNUMSALES.Rows.Count - 1
            MainForm.graphPanel.graph.Series("Date Vs. No. of Sales").Points.AddXY(CStr(DsSystem.SALEDATEVSNUMSALES.Rows(i).Item(0)), DsSystem.SALEDATEVSNUMSALES.Rows(i).Item(1))
        Next

        MainForm.displayPanel.Controls.Clear()
        MainForm.displayPanel.Controls.Add(MainForm.graphPanel)
    End Sub

    Private Sub pVsPrevSaleTotalTile_Click(sender As Object, e As EventArgs) Handles pVsPrevSaleTotalTile.Click
        ProductvstotalsalesTableAdapter.Fill(DsSystem.PRODUCTVSTOTALSALES)
        MainForm.graphPanel.graph.Series.Clear()
        MainForm.graphPanel.Label1.Visible = True
        MainForm.graphPanel.Label1.Text = "Bar Chart: Products Vs. Previous Sale Totals"
        MainForm.graphPanel.graph.ChartAreas("ChartArea1").CursorX.IsUserSelectionEnabled = True
        MainForm.graphPanel.graph.ChartAreas("ChartArea1").CursorY.IsUserSelectionEnabled = True
        MainForm.graphPanel.graph.ChartAreas("ChartArea1").AxisX.ScaleView.Zoomable = True
        MainForm.graphPanel.graph.ChartAreas("ChartArea1").AxisY.ScaleView.Zoomable = True
        MainForm.graphPanel.graph.ChartAreas("ChartArea1").CursorX.AutoScroll = True
        MainForm.graphPanel.graph.ChartAreas("ChartArea1").CursorY.AutoScroll = True
        MainForm.graphPanel.graph.ChartAreas("ChartArea1").AxisX.Title = "Products"
        MainForm.graphPanel.graph.ChartAreas("ChartArea1").AxisY.Title = "Price (ZAR)"
        MainForm.graphPanel.graph.Series.Add("Products Vs. Prev Sale Totals")

        For i As Integer = 0 To DsSystem.PRODUCTVSTOTALSALES.Rows.Count - 1
            MainForm.graphPanel.graph.Series("Products Vs. Prev Sale Totals").Points.AddXY(DsSystem.PRODUCTVSTOTALSALES.Rows(i).Item(0), DsSystem.PRODUCTVSTOTALSALES.Rows(i).Item(1))
        Next

        MainForm.displayPanel.Controls.Clear()
        MainForm.displayPanel.Controls.Add(MainForm.graphPanel)
    End Sub

    Private Sub pVsQSoldRateTile_Click(sender As Object, e As EventArgs) Handles pVsQSoldRateTile.Click
        ProductvsqsoldrateTableAdapter.Fill(DsSystem.PRODUCTVSQSOLDRATE)
        MainForm.graphPanel.graph.Series.Clear()
        MainForm.graphPanel.Label1.Visible = True
        MainForm.graphPanel.Label1.Text = "Bar Chart: Products Vs. Quantity Sold Rate"
        MainForm.graphPanel.graph.ChartAreas("ChartArea1").CursorX.IsUserSelectionEnabled = True
        MainForm.graphPanel.graph.ChartAreas("ChartArea1").CursorY.IsUserSelectionEnabled = True
        MainForm.graphPanel.graph.ChartAreas("ChartArea1").AxisX.ScaleView.Zoomable = True
        MainForm.graphPanel.graph.ChartAreas("ChartArea1").AxisY.ScaleView.Zoomable = True
        MainForm.graphPanel.graph.ChartAreas("ChartArea1").CursorX.AutoScroll = True
        MainForm.graphPanel.graph.ChartAreas("ChartArea1").CursorY.AutoScroll = True
        MainForm.graphPanel.graph.ChartAreas("ChartArea1").AxisX.Title = "Products"
        MainForm.graphPanel.graph.ChartAreas("ChartArea1").AxisY.Title = "Quantity Sold Rate"
        MainForm.graphPanel.graph.Series.Add("Products Vs. Quantity Sold Rate")
        Dim totalQuantity As Double
        For i As Integer = 0 To DsSystem.PRODUCTVSQSOLDRATE.Rows.Count - 1
            totalQuantity += CDbl(DsSystem.PRODUCTVSQSOLDRATE.Rows(i).Item(1))
        Next

        For i As Integer = 0 To DsSystem.PRODUCTVSQSOLDRATE.Rows.Count - 1
            Dim percent As Double = CDbl(DsSystem.PRODUCTVSQSOLDRATE.Rows(i).Item(1)) / totalQuantity * 100
            MainForm.graphPanel.graph.Series("Products Vs. Quantity Sold Rate").Points.AddXY(DsSystem.PRODUCTVSQSOLDRATE.Rows(i).Item(0), percent)
        Next

        MainForm.displayPanel.Controls.Clear()
        MainForm.displayPanel.Controls.Add(MainForm.graphPanel)
    End Sub

	Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        MainForm.displayPanel.Controls.Clear()
        MainForm.reportsPanel = New reportsPanel
        MainForm.displayPanel.Controls.Add(MainForm.reportsPanel)
	End Sub

    Private Sub txtSupplier_Click(sender As Object, e As EventArgs) Handles txtSupplier.Click
        Dim screen = New supplierReportForm
        screen.Show()
    End Sub
End Class
