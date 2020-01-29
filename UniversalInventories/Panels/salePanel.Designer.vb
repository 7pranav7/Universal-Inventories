<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class salePanel
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
        Me.components = New System.ComponentModel.Container()
        Me.ProductDataGridView = New System.Windows.Forms.DataGridView()
        Me.ProductIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductpriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductquantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductdescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductcategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODUCTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSSystem = New UniversalInventories.DSSystem()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.searchByIDTxt = New System.Windows.Forms.MaskedTextBox()
        Me.searchByNameTxt = New System.Windows.Forms.MaskedTextBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.txtTotal = New MetroFramework.Controls.MetroTextBox()
        Me.btnProcess = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.txtCurrentItem = New System.Windows.Forms.MaskedTextBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.quantityNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.btnAddtoInvoice = New MetroFramework.Controls.MetroButton()
        Me.INVOICEDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cost_price_per_unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.product_quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.INVOICEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InvoiceDsSystem = New UniversalInventories.DSSystem()
        Me.btnRemoveFromInvoice = New MetroFramework.Controls.MetroButton()
        Me.PRODUCTTableAdapter = New UniversalInventories.DSSystemTableAdapters.PRODUCTTableAdapter()
        Me.TableAdapterManager = New UniversalInventories.DSSystemTableAdapters.TableAdapterManager()
        Me.Sale_ItemTableAdapter = New UniversalInventories.DSSystemTableAdapters.SALE_ITEMTableAdapter()
        Me.SaleTableAdapter = New UniversalInventories.DSSystemTableAdapters.SALETableAdapter()
        Me.cbDelivery = New MetroFramework.Controls.MetroCheckBox()
        Me.CustomerTableAdapter = New UniversalInventories.DSSystemTableAdapters.CUSTOMERTableAdapter()
        Me.txtDesc = New System.Windows.Forms.MaskedTextBox()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroToolTip1 = New MetroFramework.Components.MetroToolTip()
        CType(Me.ProductDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUCTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSSystem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.quantityNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INVOICEDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INVOICEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvoiceDsSystem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProductDataGridView
        '
        Me.ProductDataGridView.AllowUserToAddRows = False
        Me.ProductDataGridView.AllowUserToDeleteRows = False
        Me.ProductDataGridView.AutoGenerateColumns = False
        Me.ProductDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductIDDataGridViewTextBoxColumn, Me.ProductnameDataGridViewTextBoxColumn, Me.ProductpriceDataGridViewTextBoxColumn, Me.ProductquantityDataGridViewTextBoxColumn, Me.ProductdescriptionDataGridViewTextBoxColumn, Me.ProductcategoryDataGridViewTextBoxColumn})
        Me.ProductDataGridView.DataSource = Me.PRODUCTBindingSource
        Me.ProductDataGridView.Location = New System.Drawing.Point(19, 52)
        Me.ProductDataGridView.MultiSelect = False
        Me.ProductDataGridView.Name = "ProductDataGridView"
        Me.ProductDataGridView.ReadOnly = True
        Me.ProductDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ProductDataGridView.Size = New System.Drawing.Size(644, 150)
        Me.ProductDataGridView.TabIndex = 0
        Me.MetroToolTip1.SetToolTip(Me.ProductDataGridView, "Products")
        '
        'ProductIDDataGridViewTextBoxColumn
        '
        Me.ProductIDDataGridViewTextBoxColumn.DataPropertyName = "product_ID"
        Me.ProductIDDataGridViewTextBoxColumn.HeaderText = "Product ID"
        Me.ProductIDDataGridViewTextBoxColumn.Name = "ProductIDDataGridViewTextBoxColumn"
        Me.ProductIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProductnameDataGridViewTextBoxColumn
        '
        Me.ProductnameDataGridViewTextBoxColumn.DataPropertyName = "product_name"
        Me.ProductnameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.ProductnameDataGridViewTextBoxColumn.Name = "ProductnameDataGridViewTextBoxColumn"
        Me.ProductnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProductpriceDataGridViewTextBoxColumn
        '
        Me.ProductpriceDataGridViewTextBoxColumn.DataPropertyName = "product_price"
        Me.ProductpriceDataGridViewTextBoxColumn.HeaderText = "Price"
        Me.ProductpriceDataGridViewTextBoxColumn.Name = "ProductpriceDataGridViewTextBoxColumn"
        Me.ProductpriceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProductquantityDataGridViewTextBoxColumn
        '
        Me.ProductquantityDataGridViewTextBoxColumn.DataPropertyName = "product_quantity"
        Me.ProductquantityDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.ProductquantityDataGridViewTextBoxColumn.Name = "ProductquantityDataGridViewTextBoxColumn"
        Me.ProductquantityDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProductdescriptionDataGridViewTextBoxColumn
        '
        Me.ProductdescriptionDataGridViewTextBoxColumn.DataPropertyName = "product_description"
        Me.ProductdescriptionDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.ProductdescriptionDataGridViewTextBoxColumn.Name = "ProductdescriptionDataGridViewTextBoxColumn"
        Me.ProductdescriptionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProductcategoryDataGridViewTextBoxColumn
        '
        Me.ProductcategoryDataGridViewTextBoxColumn.DataPropertyName = "product_category"
        Me.ProductcategoryDataGridViewTextBoxColumn.HeaderText = "Category"
        Me.ProductcategoryDataGridViewTextBoxColumn.Name = "ProductcategoryDataGridViewTextBoxColumn"
        Me.ProductcategoryDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PRODUCTBindingSource
        '
        Me.PRODUCTBindingSource.DataMember = "PRODUCT"
        Me.PRODUCTBindingSource.DataSource = Me.DSSystem
        '
        'DSSystem
        '
        Me.DSSystem.DataSetName = "DSSystem"
        Me.DSSystem.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(19, 12)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(106, 19)
        Me.MetroLabel1.TabIndex = 1
        Me.MetroLabel1.Text = "Search by Name"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(367, 12)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(82, 19)
        Me.MetroLabel2.TabIndex = 3
        Me.MetroLabel2.Text = "Search by ID"
        '
        'searchByIDTxt
        '
        Me.searchByIDTxt.Location = New System.Drawing.Point(455, 11)
        Me.searchByIDTxt.Name = "searchByIDTxt"
        Me.searchByIDTxt.Size = New System.Drawing.Size(100, 20)
        Me.searchByIDTxt.TabIndex = 7
        Me.MetroToolTip1.SetToolTip(Me.searchByIDTxt, "Enter product ID")
        '
        'searchByNameTxt
        '
        Me.searchByNameTxt.Location = New System.Drawing.Point(131, 12)
        Me.searchByNameTxt.Name = "searchByNameTxt"
        Me.searchByNameTxt.Size = New System.Drawing.Size(100, 20)
        Me.searchByNameTxt.TabIndex = 6
        Me.MetroToolTip1.SetToolTip(Me.searchByNameTxt, "Enter product name")
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel3.Location = New System.Drawing.Point(485, 380)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(50, 25)
        Me.MetroLabel3.TabIndex = 7
        Me.MetroLabel3.Text = "Total:"
        '
        'txtTotal
        '
        '
        '
        '
        Me.txtTotal.CustomButton.Image = Nothing
        Me.txtTotal.CustomButton.Location = New System.Drawing.Point(100, 1)
        Me.txtTotal.CustomButton.Name = ""
        Me.txtTotal.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtTotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtTotal.CustomButton.TabIndex = 1
        Me.txtTotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtTotal.CustomButton.UseSelectable = True
        Me.txtTotal.CustomButton.Visible = False
        Me.txtTotal.Lines = New String(-1) {}
        Me.txtTotal.Location = New System.Drawing.Point(541, 382)
        Me.txtTotal.MaxLength = 32767
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtTotal.SelectedText = ""
        Me.txtTotal.SelectionLength = 0
        Me.txtTotal.SelectionStart = 0
        Me.txtTotal.ShortcutsEnabled = True
        Me.txtTotal.Size = New System.Drawing.Size(122, 23)
        Me.txtTotal.TabIndex = 14
        Me.MetroToolTip1.SetToolTip(Me.txtTotal, "Total")
        Me.txtTotal.UseSelectable = True
        Me.txtTotal.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtTotal.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnProcess
        '
        Me.btnProcess.BackColor = System.Drawing.Color.White
        Me.btnProcess.Location = New System.Drawing.Point(772, 441)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(129, 34)
        Me.btnProcess.TabIndex = 12
        Me.btnProcess.Text = "Proceed To Payment"
        Me.btnProcess.UseSelectable = True
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(680, 85)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(86, 19)
        Me.MetroLabel4.TabIndex = 13
        Me.MetroLabel4.Text = "Current item:"
        '
        'txtCurrentItem
        '
        Me.txtCurrentItem.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUCTBindingSource, "product_name", True))
        Me.txtCurrentItem.Location = New System.Drawing.Point(772, 84)
        Me.txtCurrentItem.Name = "txtCurrentItem"
        Me.txtCurrentItem.ReadOnly = True
        Me.txtCurrentItem.Size = New System.Drawing.Size(129, 20)
        Me.txtCurrentItem.TabIndex = 9
        Me.MetroToolTip1.SetToolTip(Me.txtCurrentItem, "Current Item")
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(680, 116)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(61, 19)
        Me.MetroLabel5.TabIndex = 15
        Me.MetroLabel5.Text = "Quantity:"
        '
        'quantityNumericUpDown
        '
        Me.quantityNumericUpDown.Location = New System.Drawing.Point(772, 115)
        Me.quantityNumericUpDown.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.quantityNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.quantityNumericUpDown.Name = "quantityNumericUpDown"
        Me.quantityNumericUpDown.Size = New System.Drawing.Size(129, 20)
        Me.quantityNumericUpDown.TabIndex = 10
        Me.quantityNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.MetroToolTip1.SetToolTip(Me.quantityNumericUpDown, "Quantity")
        Me.quantityNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btnAddtoInvoice
        '
        Me.btnAddtoInvoice.Location = New System.Drawing.Point(772, 168)
        Me.btnAddtoInvoice.Name = "btnAddtoInvoice"
        Me.btnAddtoInvoice.Size = New System.Drawing.Size(129, 34)
        Me.btnAddtoInvoice.TabIndex = 11
        Me.btnAddtoInvoice.Text = "Add to Invoice"
        Me.btnAddtoInvoice.UseSelectable = True
        '
        'INVOICEDataGridView
        '
        Me.INVOICEDataGridView.AllowUserToAddRows = False
        Me.INVOICEDataGridView.AllowUserToDeleteRows = False
        Me.INVOICEDataGridView.AutoGenerateColumns = False
        Me.INVOICEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.INVOICEDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.cost_price_per_unit, Me.product_quantity, Me.subtotal})
        Me.INVOICEDataGridView.DataSource = Me.INVOICEBindingSource
        Me.INVOICEDataGridView.Location = New System.Drawing.Point(19, 227)
        Me.INVOICEDataGridView.MultiSelect = False
        Me.INVOICEDataGridView.Name = "INVOICEDataGridView"
        Me.INVOICEDataGridView.ReadOnly = True
        Me.INVOICEDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.INVOICEDataGridView.Size = New System.Drawing.Size(644, 148)
        Me.INVOICEDataGridView.TabIndex = 17
        Me.MetroToolTip1.SetToolTip(Me.INVOICEDataGridView, "Invoice")
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "product_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Product ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "product_name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "product_price"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Price"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'cost_price_per_unit
        '
        Me.cost_price_per_unit.DataPropertyName = "cost_price_per_unit"
        Me.cost_price_per_unit.HeaderText = "Cost Price"
        Me.cost_price_per_unit.Name = "cost_price_per_unit"
        Me.cost_price_per_unit.ReadOnly = True
        '
        'product_quantity
        '
        Me.product_quantity.DataPropertyName = "product_quantity"
        Me.product_quantity.HeaderText = "Quantity"
        Me.product_quantity.Name = "product_quantity"
        Me.product_quantity.ReadOnly = True
        '
        'subtotal
        '
        Me.subtotal.DataPropertyName = "subtotal"
        Me.subtotal.HeaderText = "Subtotal"
        Me.subtotal.Name = "subtotal"
        Me.subtotal.ReadOnly = True
        '
        'INVOICEBindingSource
        '
        Me.INVOICEBindingSource.DataMember = "INVOICE"
        Me.INVOICEBindingSource.DataSource = Me.InvoiceDsSystem
        '
        'InvoiceDsSystem
        '
        Me.InvoiceDsSystem.DataSetName = "DSSystem"
        Me.InvoiceDsSystem.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnRemoveFromInvoice
        '
        Me.btnRemoveFromInvoice.Location = New System.Drawing.Point(19, 382)
        Me.btnRemoveFromInvoice.Name = "btnRemoveFromInvoice"
        Me.btnRemoveFromInvoice.Size = New System.Drawing.Size(129, 34)
        Me.btnRemoveFromInvoice.TabIndex = 13
        Me.btnRemoveFromInvoice.Text = "Remove from Invoice"
        Me.btnRemoveFromInvoice.UseSelectable = True
        '
        'PRODUCTTableAdapter
        '
        Me.PRODUCTTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CUSTOMERTableAdapter = Nothing
        Me.TableAdapterManager.EMPLOYEETableAdapter = Nothing
        Me.TableAdapterManager.PRODUCT_SUPPLIERTableAdapter = Nothing
        Me.TableAdapterManager.PRODUCTTableAdapter = Me.PRODUCTTableAdapter
        Me.TableAdapterManager.SALE_ITEMTableAdapter = Nothing
        Me.TableAdapterManager.SALETableAdapter = Nothing
        Me.TableAdapterManager.SUPPLIERTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = UniversalInventories.DSSystemTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Sale_ItemTableAdapter
        '
        Me.Sale_ItemTableAdapter.ClearBeforeFill = True
        '
        'SaleTableAdapter
        '
        Me.SaleTableAdapter.ClearBeforeFill = True
        '
        'cbDelivery
        '
        Me.cbDelivery.AutoSize = True
        Me.cbDelivery.Location = New System.Drawing.Point(801, 360)
        Me.cbDelivery.Name = "cbDelivery"
        Me.cbDelivery.Size = New System.Drawing.Size(65, 15)
        Me.cbDelivery.TabIndex = 18
        Me.cbDelivery.Text = "Delivery"
        Me.cbDelivery.UseSelectable = True
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'txtDesc
        '
        Me.txtDesc.Location = New System.Drawing.Point(801, 12)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(100, 20)
        Me.txtDesc.TabIndex = 8
        Me.MetroToolTip1.SetToolTip(Me.txtDesc, "Enter product description")
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(660, 12)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(135, 19)
        Me.MetroLabel6.TabIndex = 19
        Me.MetroLabel6.Text = "Search by Description"
        '
        'MetroToolTip1
        '
        Me.MetroToolTip1.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroToolTip1.StyleManager = Nothing
        Me.MetroToolTip1.Theme = MetroFramework.MetroThemeStyle.[Default]
        '
        'salePanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.cbDelivery)
        Me.Controls.Add(Me.btnRemoveFromInvoice)
        Me.Controls.Add(Me.INVOICEDataGridView)
        Me.Controls.Add(Me.btnAddtoInvoice)
        Me.Controls.Add(Me.quantityNumericUpDown)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.txtCurrentItem)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.btnProcess)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.searchByNameTxt)
        Me.Controls.Add(Me.searchByIDTxt)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.ProductDataGridView)
        Me.Name = "salePanel"
        Me.Size = New System.Drawing.Size(1000, 519)
        CType(Me.ProductDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUCTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSSystem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.quantityNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INVOICEDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INVOICEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvoiceDsSystem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DSSystem As DSSystem
    Friend WithEvents PRODUCTBindingSource As BindingSource
    Friend WithEvents PRODUCTTableAdapter As DSSystemTableAdapters.PRODUCTTableAdapter
    Friend WithEvents ProductDataGridView As DataGridView
    Friend WithEvents ProductIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductpriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductquantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductdescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductcategoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents searchByIDTxt As MaskedTextBox
    Friend WithEvents searchByNameTxt As MaskedTextBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtTotal As MetroFramework.Controls.MetroTextBox
    Friend WithEvents InvoiceDsSystem As DSSystem
    Friend WithEvents btnProcess As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtCurrentItem As MaskedTextBox
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents quantityNumericUpDown As NumericUpDown
    Friend WithEvents btnAddtoInvoice As MetroFramework.Controls.MetroButton
    Friend WithEvents INVOICEBindingSource As BindingSource
    Friend WithEvents TableAdapterManager As DSSystemTableAdapters.TableAdapterManager
    Friend WithEvents INVOICEDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents btnRemoveFromInvoice As MetroFramework.Controls.MetroButton
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents cost_price_per_unit As DataGridViewTextBoxColumn
    Friend WithEvents product_quantity As DataGridViewTextBoxColumn
    Friend WithEvents subtotal As DataGridViewTextBoxColumn
    Friend WithEvents Sale_ItemTableAdapter As DSSystemTableAdapters.SALE_ITEMTableAdapter
    Friend WithEvents SaleTableAdapter As DSSystemTableAdapters.SALETableAdapter
    Friend WithEvents cbDelivery As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CustomerTableAdapter As DSSystemTableAdapters.CUSTOMERTableAdapter
    Friend WithEvents txtDesc As MaskedTextBox
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroToolTip1 As MetroFramework.Components.MetroToolTip
End Class
