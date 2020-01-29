<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class viewReportsStatistics
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pVsQTile = New MetroFramework.Controls.MetroTile()
        Me.pVsSValueTile = New MetroFramework.Controls.MetroTile()
        Me.dVsTSalesTile = New MetroFramework.Controls.MetroTile()
        Me.dVsAccProfitTile = New MetroFramework.Controls.MetroTile()
        Me.categoryVsSalesTile = New MetroFramework.Controls.MetroTile()
        Me.dVsProductsSoldTile = New MetroFramework.Controls.MetroTile()
        Me.pVsQSoldRateTile = New MetroFramework.Controls.MetroTile()
        Me.pVsPrevSaleTotalTile = New MetroFramework.Controls.MetroTile()
        Me.dVsNoSalesTile = New MetroFramework.Controls.MetroTile()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.DsSystem = New UniversalInventories.DSSystem()
        Me.ProductTableAdapter = New UniversalInventories.DSSystemTableAdapters.PRODUCTTableAdapter()
        Me.SaledatevstotalTableAdapter = New UniversalInventories.DSSystemTableAdapters.SALEDATEVSTOTALTableAdapter()
        Me.SaledatevsqsoldTableAdapter = New UniversalInventories.DSSystemTableAdapters.SALEDATEVSQSOLDTableAdapter()
        Me.CategoryvstotalTableAdapter = New UniversalInventories.DSSystemTableAdapters.CATEGORYVSTOTALTableAdapter()
        Me.SaledatevsaccprofitTableAdapter = New UniversalInventories.DSSystemTableAdapters.SALEDATEVSACCPROFITTableAdapter()
        Me.SaledatevsnumsalesTableAdapter = New UniversalInventories.DSSystemTableAdapters.SALEDATEVSNUMSALESTableAdapter()
        Me.ProductvstotalsalesTableAdapter = New UniversalInventories.DSSystemTableAdapters.PRODUCTVSTOTALSALESTableAdapter()
        Me.ProductvsqsoldrateTableAdapter = New UniversalInventories.DSSystemTableAdapters.PRODUCTVSQSOLDRATETableAdapter()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.lblBestProduct = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.lblProfit = New MetroFramework.Controls.MetroLabel()
        Me.lblSalesTotal = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.btnGenerate = New MetroFramework.Controls.MetroButton()
        Me.txtSupplier = New MetroFramework.Controls.MetroButton()
        CType(Me.DsSystem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pVsQTile
        '
        Me.pVsQTile.ActiveControl = Nothing
        Me.pVsQTile.BackColor = System.Drawing.Color.DodgerBlue
        Me.pVsQTile.ForeColor = System.Drawing.Color.White
        Me.pVsQTile.Location = New System.Drawing.Point(63, 69)
        Me.pVsQTile.Name = "pVsQTile"
        Me.pVsQTile.Size = New System.Drawing.Size(226, 102)
        Me.pVsQTile.TabIndex = 6
        Me.pVsQTile.Text = "Products Vs. Quantity"
        Me.pVsQTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        Me.pVsQTile.UseCustomBackColor = True
        Me.pVsQTile.UseCustomForeColor = True
        Me.pVsQTile.UseSelectable = True
        '
        'pVsSValueTile
        '
        Me.pVsSValueTile.ActiveControl = Nothing
        Me.pVsSValueTile.BackColor = System.Drawing.Color.DodgerBlue
        Me.pVsSValueTile.ForeColor = System.Drawing.Color.White
        Me.pVsSValueTile.Location = New System.Drawing.Point(63, 195)
        Me.pVsSValueTile.Name = "pVsSValueTile"
        Me.pVsSValueTile.Size = New System.Drawing.Size(226, 102)
        Me.pVsSValueTile.TabIndex = 7
        Me.pVsSValueTile.Text = "Products Vs. Stock Value"
        Me.pVsSValueTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        Me.pVsSValueTile.UseCustomBackColor = True
        Me.pVsSValueTile.UseCustomForeColor = True
        Me.pVsSValueTile.UseSelectable = True
        '
        'dVsTSalesTile
        '
        Me.dVsTSalesTile.ActiveControl = Nothing
        Me.dVsTSalesTile.BackColor = System.Drawing.Color.DodgerBlue
        Me.dVsTSalesTile.ForeColor = System.Drawing.Color.White
        Me.dVsTSalesTile.Location = New System.Drawing.Point(63, 321)
        Me.dVsTSalesTile.Name = "dVsTSalesTile"
        Me.dVsTSalesTile.Size = New System.Drawing.Size(226, 102)
        Me.dVsTSalesTile.TabIndex = 8
        Me.dVsTSalesTile.Text = "Date Vs. Total Sales"
        Me.dVsTSalesTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        Me.dVsTSalesTile.UseCustomBackColor = True
        Me.dVsTSalesTile.UseCustomForeColor = True
        Me.dVsTSalesTile.UseSelectable = True
        '
        'dVsAccProfitTile
        '
        Me.dVsAccProfitTile.ActiveControl = Nothing
        Me.dVsAccProfitTile.BackColor = System.Drawing.Color.DodgerBlue
        Me.dVsAccProfitTile.ForeColor = System.Drawing.Color.White
        Me.dVsAccProfitTile.Location = New System.Drawing.Point(348, 320)
        Me.dVsAccProfitTile.Name = "dVsAccProfitTile"
        Me.dVsAccProfitTile.Size = New System.Drawing.Size(226, 102)
        Me.dVsAccProfitTile.TabIndex = 11
        Me.dVsAccProfitTile.Text = "Date Vs. Accumulated Profit"
        Me.dVsAccProfitTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        Me.dVsAccProfitTile.UseCustomBackColor = True
        Me.dVsAccProfitTile.UseCustomForeColor = True
        Me.dVsAccProfitTile.UseSelectable = True
        '
        'categoryVsSalesTile
        '
        Me.categoryVsSalesTile.ActiveControl = Nothing
        Me.categoryVsSalesTile.BackColor = System.Drawing.Color.DodgerBlue
        Me.categoryVsSalesTile.ForeColor = System.Drawing.Color.White
        Me.categoryVsSalesTile.Location = New System.Drawing.Point(348, 194)
        Me.categoryVsSalesTile.Name = "categoryVsSalesTile"
        Me.categoryVsSalesTile.Size = New System.Drawing.Size(226, 102)
        Me.categoryVsSalesTile.TabIndex = 10
        Me.categoryVsSalesTile.Text = "Product Category Vs. Sales"
        Me.categoryVsSalesTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        Me.categoryVsSalesTile.UseCustomBackColor = True
        Me.categoryVsSalesTile.UseCustomForeColor = True
        Me.categoryVsSalesTile.UseSelectable = True
        '
        'dVsProductsSoldTile
        '
        Me.dVsProductsSoldTile.ActiveControl = Nothing
        Me.dVsProductsSoldTile.BackColor = System.Drawing.Color.DodgerBlue
        Me.dVsProductsSoldTile.ForeColor = System.Drawing.Color.White
        Me.dVsProductsSoldTile.Location = New System.Drawing.Point(348, 68)
        Me.dVsProductsSoldTile.Name = "dVsProductsSoldTile"
        Me.dVsProductsSoldTile.Size = New System.Drawing.Size(226, 102)
        Me.dVsProductsSoldTile.TabIndex = 9
        Me.dVsProductsSoldTile.Text = "Date Vs. No. of Products Sold"
        Me.dVsProductsSoldTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        Me.dVsProductsSoldTile.UseCustomBackColor = True
        Me.dVsProductsSoldTile.UseCustomForeColor = True
        Me.dVsProductsSoldTile.UseSelectable = True
        '
        'pVsQSoldRateTile
        '
        Me.pVsQSoldRateTile.ActiveControl = Nothing
        Me.pVsQSoldRateTile.BackColor = System.Drawing.Color.DodgerBlue
        Me.pVsQSoldRateTile.ForeColor = System.Drawing.Color.White
        Me.pVsQSoldRateTile.Location = New System.Drawing.Point(635, 321)
        Me.pVsQSoldRateTile.Name = "pVsQSoldRateTile"
        Me.pVsQSoldRateTile.Size = New System.Drawing.Size(226, 102)
        Me.pVsQSoldRateTile.TabIndex = 14
        Me.pVsQSoldRateTile.Text = "Products Vs. Quantity Sold Rate"
        Me.pVsQSoldRateTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        Me.pVsQSoldRateTile.UseCustomBackColor = True
        Me.pVsQSoldRateTile.UseCustomForeColor = True
        Me.pVsQSoldRateTile.UseSelectable = True
        '
        'pVsPrevSaleTotalTile
        '
        Me.pVsPrevSaleTotalTile.ActiveControl = Nothing
        Me.pVsPrevSaleTotalTile.BackColor = System.Drawing.Color.DodgerBlue
        Me.pVsPrevSaleTotalTile.ForeColor = System.Drawing.Color.White
        Me.pVsPrevSaleTotalTile.Location = New System.Drawing.Point(635, 195)
        Me.pVsPrevSaleTotalTile.Name = "pVsPrevSaleTotalTile"
        Me.pVsPrevSaleTotalTile.Size = New System.Drawing.Size(226, 102)
        Me.pVsPrevSaleTotalTile.TabIndex = 13
        Me.pVsPrevSaleTotalTile.Text = "Products Vs. Prev Sale Totals"
        Me.pVsPrevSaleTotalTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        Me.pVsPrevSaleTotalTile.UseCustomBackColor = True
        Me.pVsPrevSaleTotalTile.UseCustomForeColor = True
        Me.pVsPrevSaleTotalTile.UseSelectable = True
        '
        'dVsNoSalesTile
        '
        Me.dVsNoSalesTile.ActiveControl = Nothing
        Me.dVsNoSalesTile.BackColor = System.Drawing.Color.DodgerBlue
        Me.dVsNoSalesTile.ForeColor = System.Drawing.Color.White
        Me.dVsNoSalesTile.Location = New System.Drawing.Point(635, 69)
        Me.dVsNoSalesTile.Name = "dVsNoSalesTile"
        Me.dVsNoSalesTile.Size = New System.Drawing.Size(226, 102)
        Me.dVsNoSalesTile.TabIndex = 12
        Me.dVsNoSalesTile.Text = "Date Vs. No. of Sales"
        Me.dVsNoSalesTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        Me.dVsNoSalesTile.UseCustomBackColor = True
        Me.dVsNoSalesTile.UseCustomForeColor = True
        Me.dVsNoSalesTile.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(63, 22)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(65, 25)
        Me.MetroLabel1.TabIndex = 15
        Me.MetroLabel1.Text = "Charts:"
        '
        'DsSystem
        '
        Me.DsSystem.DataSetName = "DSSystem"
        Me.DsSystem.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductTableAdapter
        '
        Me.ProductTableAdapter.ClearBeforeFill = True
        '
        'SaledatevstotalTableAdapter
        '
        Me.SaledatevstotalTableAdapter.ClearBeforeFill = True
        '
        'SaledatevsqsoldTableAdapter
        '
        Me.SaledatevsqsoldTableAdapter.ClearBeforeFill = True
        '
        'CategoryvstotalTableAdapter
        '
        Me.CategoryvstotalTableAdapter.ClearBeforeFill = True
        '
        'SaledatevsaccprofitTableAdapter
        '
        Me.SaledatevsaccprofitTableAdapter.ClearBeforeFill = True
        '
        'SaledatevsnumsalesTableAdapter
        '
        Me.SaledatevsnumsalesTableAdapter.ClearBeforeFill = True
        '
        'ProductvstotalsalesTableAdapter
        '
        Me.ProductvstotalsalesTableAdapter.ClearBeforeFill = True
        '
        'ProductvsqsoldrateTableAdapter
        '
        Me.ProductvsqsoldrateTableAdapter.ClearBeforeFill = True
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(396, 440)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(132, 19)
        Me.MetroLabel3.TabIndex = 18
        Me.MetroLabel3.Text = "Best Selling Product: "
        '
        'lblBestProduct
        '
        Me.lblBestProduct.AutoSize = True
        Me.lblBestProduct.Location = New System.Drawing.Point(396, 464)
        Me.lblBestProduct.Name = "lblBestProduct"
        Me.lblBestProduct.Size = New System.Drawing.Size(132, 19)
        Me.lblBestProduct.TabIndex = 19
        Me.lblBestProduct.Text = "Best Selling Product: "
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(111, 440)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(130, 19)
        Me.MetroLabel2.TabIndex = 16
        Me.MetroLabel2.Text = "Total Profit Till Date: "
        '
        'lblProfit
        '
        Me.lblProfit.AutoSize = True
        Me.lblProfit.ForeColor = System.Drawing.Color.LimeGreen
        Me.lblProfit.Location = New System.Drawing.Point(135, 464)
        Me.lblProfit.Name = "lblProfit"
        Me.lblProfit.Size = New System.Drawing.Size(83, 19)
        Me.lblProfit.TabIndex = 17
        Me.lblProfit.Text = "MetroLabel3"
        Me.lblProfit.UseCustomForeColor = True
        '
        'lblSalesTotal
        '
        Me.lblSalesTotal.AutoSize = True
        Me.lblSalesTotal.ForeColor = System.Drawing.Color.LimeGreen
        Me.lblSalesTotal.Location = New System.Drawing.Point(708, 464)
        Me.lblSalesTotal.Name = "lblSalesTotal"
        Me.lblSalesTotal.Size = New System.Drawing.Size(83, 19)
        Me.lblSalesTotal.TabIndex = 21
        Me.lblSalesTotal.Text = "MetroLabel3"
        Me.lblSalesTotal.UseCustomForeColor = True
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(686, 440)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(127, 19)
        Me.MetroLabel5.TabIndex = 20
        Me.MetroLabel5.Text = "Total Sales Till Date: "
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(732, 18)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(129, 29)
        Me.btnGenerate.TabIndex = 22
        Me.btnGenerate.Text = "Sales Report"
        Me.btnGenerate.UseSelectable = True
        '
        'txtSupplier
        '
        Me.txtSupplier.Location = New System.Drawing.Point(586, 18)
        Me.txtSupplier.Name = "txtSupplier"
        Me.txtSupplier.Size = New System.Drawing.Size(129, 29)
        Me.txtSupplier.TabIndex = 23
        Me.txtSupplier.Text = "Supplier Report"
        Me.txtSupplier.UseSelectable = True
        '
        'viewReportsStatistics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.txtSupplier)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.lblSalesTotal)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.lblBestProduct)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.lblProfit)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.pVsQSoldRateTile)
        Me.Controls.Add(Me.pVsPrevSaleTotalTile)
        Me.Controls.Add(Me.dVsNoSalesTile)
        Me.Controls.Add(Me.dVsAccProfitTile)
        Me.Controls.Add(Me.categoryVsSalesTile)
        Me.Controls.Add(Me.dVsProductsSoldTile)
        Me.Controls.Add(Me.dVsTSalesTile)
        Me.Controls.Add(Me.pVsSValueTile)
        Me.Controls.Add(Me.pVsQTile)
        Me.Name = "viewReportsStatistics"
        Me.Size = New System.Drawing.Size(923, 490)
        CType(Me.DsSystem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pVsQTile As MetroFramework.Controls.MetroTile
    Friend WithEvents pVsSValueTile As MetroFramework.Controls.MetroTile
    Friend WithEvents dVsTSalesTile As MetroFramework.Controls.MetroTile
    Friend WithEvents DsSystem As DSSystem
    Friend WithEvents ProductTableAdapter As DSSystemTableAdapters.PRODUCTTableAdapter
    Friend WithEvents SaledatevstotalTableAdapter As DSSystemTableAdapters.SALEDATEVSTOTALTableAdapter
    Friend WithEvents dVsAccProfitTile As MetroFramework.Controls.MetroTile
    Friend WithEvents categoryVsSalesTile As MetroFramework.Controls.MetroTile
    Friend WithEvents dVsProductsSoldTile As MetroFramework.Controls.MetroTile
    Friend WithEvents pVsQSoldRateTile As MetroFramework.Controls.MetroTile
    Friend WithEvents pVsPrevSaleTotalTile As MetroFramework.Controls.MetroTile
    Friend WithEvents dVsNoSalesTile As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents SaledatevsqsoldTableAdapter As DSSystemTableAdapters.SALEDATEVSQSOLDTableAdapter
    Friend WithEvents CategoryvstotalTableAdapter As DSSystemTableAdapters.CATEGORYVSTOTALTableAdapter
    Friend WithEvents SaledatevsaccprofitTableAdapter As DSSystemTableAdapters.SALEDATEVSACCPROFITTableAdapter
    Friend WithEvents SaledatevsnumsalesTableAdapter As DSSystemTableAdapters.SALEDATEVSNUMSALESTableAdapter
    Friend WithEvents ProductvstotalsalesTableAdapter As DSSystemTableAdapters.PRODUCTVSTOTALSALESTableAdapter
    Friend WithEvents ProductvsqsoldrateTableAdapter As DSSystemTableAdapters.PRODUCTVSQSOLDRATETableAdapter
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblBestProduct As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblProfit As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblSalesTotal As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
	Friend WithEvents btnGenerate As MetroFramework.Controls.MetroButton
    Friend WithEvents txtSupplier As MetroFramework.Controls.MetroButton
End Class
