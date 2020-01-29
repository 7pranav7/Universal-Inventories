<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reportsPanel
	Inherits System.Windows.Forms.UserControl

	'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Me.btnReset = New MetroFramework.Controls.MetroButton()
        Me.btnGenerate = New MetroFramework.Controls.MetroButton()
        Me.ToDateTime = New MetroFramework.Controls.MetroDateTime()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.FromDateTime = New MetroFramework.Controls.MetroDateTime()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.SaleItemGrid = New System.Windows.Forms.DataGridView()
        Me.ProductIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaleIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItempriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemquantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubtotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostpriceperunitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SALEITEMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSSystem = New UniversalInventories.DSSystem()
        Me.SaleGrid = New System.Windows.Forms.DataGridView()
        Me.SaleIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaledateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalamountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsOnlineSaleDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.IsDeliveryDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.EmpIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsCompletedDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.SALEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SALETableAdapter = New UniversalInventories.DSSystemTableAdapters.SALETableAdapter()
        Me.txtReport = New System.Windows.Forms.RichTextBox()
        Me.SALE_ITEMTableAdapter = New UniversalInventories.DSSystemTableAdapters.SALE_ITEMTableAdapter()
        Me.btnBack = New MetroFramework.Controls.MetroButton()
        Me.MetroToolTip1 = New MetroFramework.Components.MetroToolTip()
        CType(Me.SaleItemGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SALEITEMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSSystem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaleGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SALEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(743, 14)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 29)
        Me.btnReset.TabIndex = 23
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseSelectable = True
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(641, 14)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(96, 29)
        Me.btnGenerate.TabIndex = 21
        Me.btnGenerate.Text = "Generate Report"
        Me.btnGenerate.UseSelectable = True
        '
        'ToDateTime
        '
        Me.ToDateTime.Location = New System.Drawing.Point(435, 14)
        Me.ToDateTime.MinimumSize = New System.Drawing.Size(0, 29)
        Me.ToDateTime.Name = "ToDateTime"
        Me.ToDateTime.Size = New System.Drawing.Size(200, 29)
        Me.ToDateTime.TabIndex = 20
        Me.MetroToolTip1.SetToolTip(Me.ToDateTime, "Choose date")
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(407, 19)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(22, 19)
        Me.MetroLabel8.TabIndex = 22
        Me.MetroLabel8.Text = "To"
        '
        'FromDateTime
        '
        Me.FromDateTime.Location = New System.Drawing.Point(201, 14)
        Me.FromDateTime.MinimumSize = New System.Drawing.Size(0, 29)
        Me.FromDateTime.Name = "FromDateTime"
        Me.FromDateTime.Size = New System.Drawing.Size(200, 29)
        Me.FromDateTime.TabIndex = 18
        Me.MetroToolTip1.SetToolTip(Me.FromDateTime, "Choose date")
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(106, 19)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(89, 19)
        Me.MetroLabel7.TabIndex = 19
        Me.MetroLabel7.Text = "Choose From"
        '
        'SaleItemGrid
        '
        Me.SaleItemGrid.AutoGenerateColumns = False
        Me.SaleItemGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SaleItemGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductIDDataGridViewTextBoxColumn, Me.SaleIDDataGridViewTextBoxColumn1, Me.ItempriceDataGridViewTextBoxColumn, Me.ItemquantityDataGridViewTextBoxColumn, Me.SubtotalDataGridViewTextBoxColumn, Me.CostpriceperunitDataGridViewTextBoxColumn})
        Me.SaleItemGrid.DataSource = Me.SALEITEMBindingSource
        Me.SaleItemGrid.Location = New System.Drawing.Point(58, 618)
        Me.SaleItemGrid.Name = "SaleItemGrid"
        Me.SaleItemGrid.Size = New System.Drawing.Size(643, 46)
        Me.SaleItemGrid.TabIndex = 24
        '
        'ProductIDDataGridViewTextBoxColumn
        '
        Me.ProductIDDataGridViewTextBoxColumn.DataPropertyName = "product_ID"
        Me.ProductIDDataGridViewTextBoxColumn.HeaderText = "product_ID"
        Me.ProductIDDataGridViewTextBoxColumn.Name = "ProductIDDataGridViewTextBoxColumn"
        '
        'SaleIDDataGridViewTextBoxColumn1
        '
        Me.SaleIDDataGridViewTextBoxColumn1.DataPropertyName = "sale_ID"
        Me.SaleIDDataGridViewTextBoxColumn1.HeaderText = "sale_ID"
        Me.SaleIDDataGridViewTextBoxColumn1.Name = "SaleIDDataGridViewTextBoxColumn1"
        '
        'ItempriceDataGridViewTextBoxColumn
        '
        Me.ItempriceDataGridViewTextBoxColumn.DataPropertyName = "item_price"
        Me.ItempriceDataGridViewTextBoxColumn.HeaderText = "item_price"
        Me.ItempriceDataGridViewTextBoxColumn.Name = "ItempriceDataGridViewTextBoxColumn"
        '
        'ItemquantityDataGridViewTextBoxColumn
        '
        Me.ItemquantityDataGridViewTextBoxColumn.DataPropertyName = "item_quantity"
        Me.ItemquantityDataGridViewTextBoxColumn.HeaderText = "item_quantity"
        Me.ItemquantityDataGridViewTextBoxColumn.Name = "ItemquantityDataGridViewTextBoxColumn"
        '
        'SubtotalDataGridViewTextBoxColumn
        '
        Me.SubtotalDataGridViewTextBoxColumn.DataPropertyName = "subtotal"
        Me.SubtotalDataGridViewTextBoxColumn.HeaderText = "subtotal"
        Me.SubtotalDataGridViewTextBoxColumn.Name = "SubtotalDataGridViewTextBoxColumn"
        '
        'CostpriceperunitDataGridViewTextBoxColumn
        '
        Me.CostpriceperunitDataGridViewTextBoxColumn.DataPropertyName = "cost_price_per_unit"
        Me.CostpriceperunitDataGridViewTextBoxColumn.HeaderText = "cost_price_per_unit"
        Me.CostpriceperunitDataGridViewTextBoxColumn.Name = "CostpriceperunitDataGridViewTextBoxColumn"
        '
        'SALEITEMBindingSource
        '
        Me.SALEITEMBindingSource.DataMember = "SALE_ITEM"
        Me.SALEITEMBindingSource.DataSource = Me.DSSystem
        '
        'DSSystem
        '
        Me.DSSystem.DataSetName = "DSSystem"
        Me.DSSystem.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SaleGrid
        '
        Me.SaleGrid.AllowUserToAddRows = False
        Me.SaleGrid.AllowUserToDeleteRows = False
        Me.SaleGrid.AutoGenerateColumns = False
        Me.SaleGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SaleGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SaleIDDataGridViewTextBoxColumn, Me.SaledateDataGridViewTextBoxColumn, Me.TotalamountDataGridViewTextBoxColumn, Me.IsOnlineSaleDataGridViewCheckBoxColumn, Me.IsDeliveryDataGridViewCheckBoxColumn, Me.EmpIDDataGridViewTextBoxColumn, Me.CustIDDataGridViewTextBoxColumn, Me.IsCompletedDataGridViewCheckBoxColumn})
        Me.SaleGrid.DataSource = Me.SALEBindingSource
        Me.SaleGrid.Location = New System.Drawing.Point(48, 550)
        Me.SaleGrid.Name = "SaleGrid"
        Me.SaleGrid.Size = New System.Drawing.Size(842, 38)
        Me.SaleGrid.TabIndex = 25
        Me.SaleGrid.Visible = False
        '
        'SaleIDDataGridViewTextBoxColumn
        '
        Me.SaleIDDataGridViewTextBoxColumn.DataPropertyName = "sale_ID"
        Me.SaleIDDataGridViewTextBoxColumn.HeaderText = "sale_ID"
        Me.SaleIDDataGridViewTextBoxColumn.Name = "SaleIDDataGridViewTextBoxColumn"
        Me.SaleIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SaledateDataGridViewTextBoxColumn
        '
        Me.SaledateDataGridViewTextBoxColumn.DataPropertyName = "sale_date"
        Me.SaledateDataGridViewTextBoxColumn.HeaderText = "sale_date"
        Me.SaledateDataGridViewTextBoxColumn.Name = "SaledateDataGridViewTextBoxColumn"
        '
        'TotalamountDataGridViewTextBoxColumn
        '
        Me.TotalamountDataGridViewTextBoxColumn.DataPropertyName = "total_amount"
        Me.TotalamountDataGridViewTextBoxColumn.HeaderText = "total_amount"
        Me.TotalamountDataGridViewTextBoxColumn.Name = "TotalamountDataGridViewTextBoxColumn"
        '
        'IsOnlineSaleDataGridViewCheckBoxColumn
        '
        Me.IsOnlineSaleDataGridViewCheckBoxColumn.DataPropertyName = "isOnlineSale"
        Me.IsOnlineSaleDataGridViewCheckBoxColumn.HeaderText = "isOnlineSale"
        Me.IsOnlineSaleDataGridViewCheckBoxColumn.Name = "IsOnlineSaleDataGridViewCheckBoxColumn"
        '
        'IsDeliveryDataGridViewCheckBoxColumn
        '
        Me.IsDeliveryDataGridViewCheckBoxColumn.DataPropertyName = "isDelivery"
        Me.IsDeliveryDataGridViewCheckBoxColumn.HeaderText = "isDelivery"
        Me.IsDeliveryDataGridViewCheckBoxColumn.Name = "IsDeliveryDataGridViewCheckBoxColumn"
        '
        'EmpIDDataGridViewTextBoxColumn
        '
        Me.EmpIDDataGridViewTextBoxColumn.DataPropertyName = "emp_ID"
        Me.EmpIDDataGridViewTextBoxColumn.HeaderText = "emp_ID"
        Me.EmpIDDataGridViewTextBoxColumn.Name = "EmpIDDataGridViewTextBoxColumn"
        '
        'CustIDDataGridViewTextBoxColumn
        '
        Me.CustIDDataGridViewTextBoxColumn.DataPropertyName = "cust_ID"
        Me.CustIDDataGridViewTextBoxColumn.HeaderText = "cust_ID"
        Me.CustIDDataGridViewTextBoxColumn.Name = "CustIDDataGridViewTextBoxColumn"
        '
        'IsCompletedDataGridViewCheckBoxColumn
        '
        Me.IsCompletedDataGridViewCheckBoxColumn.DataPropertyName = "isCompleted"
        Me.IsCompletedDataGridViewCheckBoxColumn.HeaderText = "isCompleted"
        Me.IsCompletedDataGridViewCheckBoxColumn.Name = "IsCompletedDataGridViewCheckBoxColumn"
        '
        'SALEBindingSource
        '
        Me.SALEBindingSource.DataMember = "SALE"
        Me.SALEBindingSource.DataSource = Me.DSSystem
        '
        'SALETableAdapter
        '
        Me.SALETableAdapter.ClearBeforeFill = True
        '
        'txtReport
        '
        Me.txtReport.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReport.Location = New System.Drawing.Point(97, 49)
        Me.txtReport.Name = "txtReport"
        Me.txtReport.ReadOnly = True
        Me.txtReport.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.txtReport.Size = New System.Drawing.Size(721, 381)
        Me.txtReport.TabIndex = 26
        Me.txtReport.Text = "Sales Report"
        Me.MetroToolTip1.SetToolTip(Me.txtReport, "Sales report")
        '
        'SALE_ITEMTableAdapter
        '
        Me.SALE_ITEMTableAdapter.ClearBeforeFill = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(824, 442)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 28)
        Me.btnBack.TabIndex = 27
        Me.btnBack.Text = "Back"
        Me.btnBack.UseSelectable = True
        '
        'MetroToolTip1
        '
        Me.MetroToolTip1.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroToolTip1.StyleManager = Nothing
        Me.MetroToolTip1.Theme = MetroFramework.MetroThemeStyle.[Default]
        '
        'reportsPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.txtReport)
        Me.Controls.Add(Me.SaleGrid)
        Me.Controls.Add(Me.SaleItemGrid)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.ToDateTime)
        Me.Controls.Add(Me.MetroLabel8)
        Me.Controls.Add(Me.FromDateTime)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Name = "reportsPanel"
        Me.Size = New System.Drawing.Size(923, 490)
        CType(Me.SaleItemGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SALEITEMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSSystem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaleGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SALEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnReset As MetroFramework.Controls.MetroButton
	Friend WithEvents btnGenerate As MetroFramework.Controls.MetroButton
	Friend WithEvents ToDateTime As MetroFramework.Controls.MetroDateTime
	Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
	Friend WithEvents FromDateTime As MetroFramework.Controls.MetroDateTime
	Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
	Friend WithEvents SaleItemGrid As DataGridView
	Friend WithEvents DSSystem As DSSystem
	Friend WithEvents SaleGrid As DataGridView
	Friend WithEvents SaleIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents SaledateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents TotalamountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents IsOnlineSaleDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
	Friend WithEvents IsDeliveryDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
	Friend WithEvents EmpIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents CustIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents IsCompletedDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
	Friend WithEvents SALEBindingSource As BindingSource
	Friend WithEvents SALETableAdapter As DSSystemTableAdapters.SALETableAdapter
	Friend WithEvents txtReport As RichTextBox
	Friend WithEvents ProductIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents SaleIDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
	Friend WithEvents ItempriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents ItemquantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents SubtotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents CostpriceperunitDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents SALEITEMBindingSource As BindingSource
	Friend WithEvents SALE_ITEMTableAdapter As DSSystemTableAdapters.SALE_ITEMTableAdapter
    Friend WithEvents btnBack As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroToolTip1 As MetroFramework.Components.MetroToolTip
End Class
