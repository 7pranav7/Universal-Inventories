<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class productsPanel
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
        Me.ProductDataGridView = New System.Windows.Forms.DataGridView()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.btnUpdate = New MetroFramework.Controls.MetroButton()
        Me.descripTxt = New MetroFramework.Controls.MetroTextBox()
        Me.categoryTxt = New MetroFramework.Controls.MetroTextBox()
        Me.txtQuantity = New MetroFramework.Controls.MetroTextBox()
        Me.priceTxt = New MetroFramework.Controls.MetroTextBox()
        Me.nameTxt = New MetroFramework.Controls.MetroTextBox()
        Me.markupTxt = New MetroFramework.Controls.MetroTextBox()
        Me.cpTxt = New MetroFramework.Controls.MetroTextBox()
        Me.threshholdTxt = New MetroFramework.Controls.MetroTextBox()
        Me.btnInsert = New MetroFramework.Controls.MetroButton()
        Me.btnDeactivate = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.searchByNameTxt = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.searchByIDTxt = New MetroFramework.Controls.MetroTextBox()
        Me.txtSupplier = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.txtLastSupplied = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel12 = New MetroFramework.Controls.MetroLabel()
        Me.lblActive = New MetroFramework.Controls.MetroLabel()
        Me.btnAddStock = New MetroFramework.Controls.MetroButton()
        Me.btnVAT = New MetroFramework.Controls.MetroButton()
        Me.MetroToolTip1 = New MetroFramework.Components.MetroToolTip()
        Me.PRODUCTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSSystem = New UniversalInventories.DSSystem()
        Me.ProductIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductpriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductquantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductdescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductcategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostpriceperunitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductmarkuppercentageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReorderthresholdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODUCTTableAdapter = New UniversalInventories.DSSystemTableAdapters.PRODUCTTableAdapter()
        Me.JoinT_PRODUCT_SUPPLIERTableAdapter = New UniversalInventories.DSSystemTableAdapters.JOINT_PRODUCT_SUPPLIERTableAdapter()
        Me.Product_SUPPLIERTableAdapter = New UniversalInventories.DSSystemTableAdapters.PRODUCT_SUPPLIERTableAdapter()
        Me.VatTableAdapter1 = New UniversalInventories.DSSystemTableAdapters.VATTableAdapter()
        CType(Me.ProductDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUCTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSSystem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProductDataGridView
        '
        Me.ProductDataGridView.AllowUserToAddRows = False
        Me.ProductDataGridView.AllowUserToDeleteRows = False
        Me.ProductDataGridView.AutoGenerateColumns = False
        Me.ProductDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductIDDataGridViewTextBoxColumn, Me.ProductnameDataGridViewTextBoxColumn, Me.ProductpriceDataGridViewTextBoxColumn, Me.ProductquantityDataGridViewTextBoxColumn, Me.ProductdescriptionDataGridViewTextBoxColumn, Me.ProductcategoryDataGridViewTextBoxColumn, Me.CostpriceperunitDataGridViewTextBoxColumn, Me.ProductmarkuppercentageDataGridViewTextBoxColumn, Me.ReorderthresholdDataGridViewTextBoxColumn})
        Me.ProductDataGridView.DataSource = Me.PRODUCTBindingSource
        Me.ProductDataGridView.Location = New System.Drawing.Point(1, 0)
        Me.ProductDataGridView.MultiSelect = False
        Me.ProductDataGridView.Name = "ProductDataGridView"
        Me.ProductDataGridView.ReadOnly = True
        Me.ProductDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ProductDataGridView.Size = New System.Drawing.Size(920, 265)
        Me.ProductDataGridView.TabIndex = 0
        Me.MetroToolTip1.SetToolTip(Me.ProductDataGridView, "Products")
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(3, 283)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(45, 19)
        Me.MetroLabel1.TabIndex = 1
        Me.MetroLabel1.Text = "Name"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(3, 320)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(69, 19)
        Me.MetroLabel2.TabIndex = 2
        Me.MetroLabel2.Text = "Price (Incl)"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(3, 353)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(58, 19)
        Me.MetroLabel3.TabIndex = 3
        Me.MetroLabel3.Text = "Quantity"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(3, 388)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(74, 19)
        Me.MetroLabel4.TabIndex = 4
        Me.MetroLabel4.Text = "Description"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(3, 422)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(64, 19)
        Me.MetroLabel5.TabIndex = 5
        Me.MetroLabel5.Text = "Category"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(328, 283)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(118, 19)
        Me.MetroLabel6.TabIndex = 6
        Me.MetroLabel6.Text = "Cost Price Per Unit"
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(328, 320)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(123, 19)
        Me.MetroLabel7.TabIndex = 7
        Me.MetroLabel7.Text = "Markup Percentage"
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(328, 353)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(66, 19)
        Me.MetroLabel8.TabIndex = 8
        Me.MetroLabel8.Text = "Threshold"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(717, 329)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(158, 35)
        Me.btnUpdate.TabIndex = 33
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseSelectable = True
        '
        'descripTxt
        '
        '
        '
        '
        Me.descripTxt.CustomButton.Image = Nothing
        Me.descripTxt.CustomButton.Location = New System.Drawing.Point(136, 1)
        Me.descripTxt.CustomButton.Name = ""
        Me.descripTxt.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.descripTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.descripTxt.CustomButton.TabIndex = 1
        Me.descripTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.descripTxt.CustomButton.UseSelectable = True
        Me.descripTxt.CustomButton.Visible = False
        Me.descripTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUCTBindingSource, "product_description", True))
        Me.descripTxt.Lines = New String(-1) {}
        Me.descripTxt.Location = New System.Drawing.Point(86, 384)
        Me.descripTxt.MaxLength = 500
        Me.descripTxt.Name = "descripTxt"
        Me.descripTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.descripTxt.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.descripTxt.SelectedText = ""
        Me.descripTxt.SelectionLength = 0
        Me.descripTxt.SelectionStart = 0
        Me.descripTxt.ShortcutsEnabled = True
        Me.descripTxt.Size = New System.Drawing.Size(158, 23)
        Me.descripTxt.TabIndex = 23
        Me.MetroToolTip1.SetToolTip(Me.descripTxt, "Description")
        Me.descripTxt.UseSelectable = True
        Me.descripTxt.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.descripTxt.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'categoryTxt
        '
        '
        '
        '
        Me.categoryTxt.CustomButton.Image = Nothing
        Me.categoryTxt.CustomButton.Location = New System.Drawing.Point(136, 1)
        Me.categoryTxt.CustomButton.Name = ""
        Me.categoryTxt.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.categoryTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.categoryTxt.CustomButton.TabIndex = 1
        Me.categoryTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.categoryTxt.CustomButton.UseSelectable = True
        Me.categoryTxt.CustomButton.Visible = False
        Me.categoryTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUCTBindingSource, "product_category", True))
        Me.categoryTxt.Lines = New String(-1) {}
        Me.categoryTxt.Location = New System.Drawing.Point(86, 418)
        Me.categoryTxt.MaxLength = 100
        Me.categoryTxt.Name = "categoryTxt"
        Me.categoryTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.categoryTxt.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.categoryTxt.SelectedText = ""
        Me.categoryTxt.SelectionLength = 0
        Me.categoryTxt.SelectionStart = 0
        Me.categoryTxt.ShortcutsEnabled = True
        Me.categoryTxt.Size = New System.Drawing.Size(158, 23)
        Me.categoryTxt.TabIndex = 24
        Me.MetroToolTip1.SetToolTip(Me.categoryTxt, "Category")
        Me.categoryTxt.UseSelectable = True
        Me.categoryTxt.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.categoryTxt.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtQuantity
        '
        '
        '
        '
        Me.txtQuantity.CustomButton.Image = Nothing
        Me.txtQuantity.CustomButton.Location = New System.Drawing.Point(136, 1)
        Me.txtQuantity.CustomButton.Name = ""
        Me.txtQuantity.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtQuantity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtQuantity.CustomButton.TabIndex = 1
        Me.txtQuantity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtQuantity.CustomButton.UseSelectable = True
        Me.txtQuantity.CustomButton.Visible = False
        Me.txtQuantity.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUCTBindingSource, "product_quantity", True))
        Me.txtQuantity.Enabled = False
        Me.txtQuantity.Lines = New String(-1) {}
        Me.txtQuantity.Location = New System.Drawing.Point(86, 349)
        Me.txtQuantity.MaxLength = 32767
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtQuantity.ReadOnly = True
        Me.txtQuantity.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtQuantity.SelectedText = ""
        Me.txtQuantity.SelectionLength = 0
        Me.txtQuantity.SelectionStart = 0
        Me.txtQuantity.ShortcutsEnabled = True
        Me.txtQuantity.Size = New System.Drawing.Size(158, 23)
        Me.txtQuantity.TabIndex = 22
        Me.MetroToolTip1.SetToolTip(Me.txtQuantity, "Quantity")
        Me.txtQuantity.UseSelectable = True
        Me.txtQuantity.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtQuantity.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'priceTxt
        '
        '
        '
        '
        Me.priceTxt.CustomButton.Image = Nothing
        Me.priceTxt.CustomButton.Location = New System.Drawing.Point(136, 1)
        Me.priceTxt.CustomButton.Name = ""
        Me.priceTxt.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.priceTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.priceTxt.CustomButton.TabIndex = 1
        Me.priceTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.priceTxt.CustomButton.UseSelectable = True
        Me.priceTxt.CustomButton.Visible = False
        Me.priceTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUCTBindingSource, "product_price", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.priceTxt.Lines = New String(-1) {}
        Me.priceTxt.Location = New System.Drawing.Point(86, 316)
        Me.priceTxt.MaxLength = 32767
        Me.priceTxt.Name = "priceTxt"
        Me.priceTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.priceTxt.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.priceTxt.SelectedText = ""
        Me.priceTxt.SelectionLength = 0
        Me.priceTxt.SelectionStart = 0
        Me.priceTxt.ShortcutsEnabled = True
        Me.priceTxt.Size = New System.Drawing.Size(158, 23)
        Me.priceTxt.TabIndex = 21
        Me.MetroToolTip1.SetToolTip(Me.priceTxt, "Price including VAT")
        Me.priceTxt.UseSelectable = True
        Me.priceTxt.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.priceTxt.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'nameTxt
        '
        '
        '
        '
        Me.nameTxt.CustomButton.Image = Nothing
        Me.nameTxt.CustomButton.Location = New System.Drawing.Point(136, 1)
        Me.nameTxt.CustomButton.Name = ""
        Me.nameTxt.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.nameTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.nameTxt.CustomButton.TabIndex = 1
        Me.nameTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.nameTxt.CustomButton.UseSelectable = True
        Me.nameTxt.CustomButton.Visible = False
        Me.nameTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUCTBindingSource, "product_name", True))
        Me.nameTxt.Lines = New String(-1) {}
        Me.nameTxt.Location = New System.Drawing.Point(86, 283)
        Me.nameTxt.MaxLength = 100
        Me.nameTxt.Name = "nameTxt"
        Me.nameTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.nameTxt.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.nameTxt.SelectedText = ""
        Me.nameTxt.SelectionLength = 0
        Me.nameTxt.SelectionStart = 0
        Me.nameTxt.ShortcutsEnabled = True
        Me.nameTxt.Size = New System.Drawing.Size(158, 23)
        Me.nameTxt.TabIndex = 20
        Me.MetroToolTip1.SetToolTip(Me.nameTxt, "Product name")
        Me.nameTxt.UseSelectable = True
        Me.nameTxt.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.nameTxt.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'markupTxt
        '
        '
        '
        '
        Me.markupTxt.CustomButton.Image = Nothing
        Me.markupTxt.CustomButton.Location = New System.Drawing.Point(136, 1)
        Me.markupTxt.CustomButton.Name = ""
        Me.markupTxt.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.markupTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.markupTxt.CustomButton.TabIndex = 1
        Me.markupTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.markupTxt.CustomButton.UseSelectable = True
        Me.markupTxt.CustomButton.Visible = False
        Me.markupTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUCTBindingSource, "product_markup_percentage", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.markupTxt.Lines = New String(-1) {}
        Me.markupTxt.Location = New System.Drawing.Point(475, 316)
        Me.markupTxt.MaxLength = 32767
        Me.markupTxt.Name = "markupTxt"
        Me.markupTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.markupTxt.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.markupTxt.SelectedText = ""
        Me.markupTxt.SelectionLength = 0
        Me.markupTxt.SelectionStart = 0
        Me.markupTxt.ShortcutsEnabled = True
        Me.markupTxt.Size = New System.Drawing.Size(158, 23)
        Me.markupTxt.TabIndex = 26
        Me.MetroToolTip1.SetToolTip(Me.markupTxt, "Markup percentage")
        Me.markupTxt.UseSelectable = True
        Me.markupTxt.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.markupTxt.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'cpTxt
        '
        '
        '
        '
        Me.cpTxt.CustomButton.Image = Nothing
        Me.cpTxt.CustomButton.Location = New System.Drawing.Point(136, 1)
        Me.cpTxt.CustomButton.Name = ""
        Me.cpTxt.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.cpTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.cpTxt.CustomButton.TabIndex = 1
        Me.cpTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.cpTxt.CustomButton.UseSelectable = True
        Me.cpTxt.CustomButton.Visible = False
        Me.cpTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUCTBindingSource, "cost_price_per_unit", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.cpTxt.Lines = New String(-1) {}
        Me.cpTxt.Location = New System.Drawing.Point(475, 283)
        Me.cpTxt.MaxLength = 32767
        Me.cpTxt.Name = "cpTxt"
        Me.cpTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.cpTxt.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.cpTxt.SelectedText = ""
        Me.cpTxt.SelectionLength = 0
        Me.cpTxt.SelectionStart = 0
        Me.cpTxt.ShortcutsEnabled = True
        Me.cpTxt.Size = New System.Drawing.Size(158, 23)
        Me.cpTxt.TabIndex = 25
        Me.MetroToolTip1.SetToolTip(Me.cpTxt, "Cost price")
        Me.cpTxt.UseSelectable = True
        Me.cpTxt.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.cpTxt.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'threshholdTxt
        '
        '
        '
        '
        Me.threshholdTxt.CustomButton.Image = Nothing
        Me.threshholdTxt.CustomButton.Location = New System.Drawing.Point(136, 1)
        Me.threshholdTxt.CustomButton.Name = ""
        Me.threshholdTxt.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.threshholdTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.threshholdTxt.CustomButton.TabIndex = 1
        Me.threshholdTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.threshholdTxt.CustomButton.UseSelectable = True
        Me.threshholdTxt.CustomButton.Visible = False
        Me.threshholdTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUCTBindingSource, "reorder_threshold", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N0"))
        Me.threshholdTxt.Lines = New String(-1) {}
        Me.threshholdTxt.Location = New System.Drawing.Point(475, 349)
        Me.threshholdTxt.MaxLength = 32767
        Me.threshholdTxt.Name = "threshholdTxt"
        Me.threshholdTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.threshholdTxt.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.threshholdTxt.SelectedText = ""
        Me.threshholdTxt.SelectionLength = 0
        Me.threshholdTxt.SelectionStart = 0
        Me.threshholdTxt.ShortcutsEnabled = True
        Me.threshholdTxt.Size = New System.Drawing.Size(158, 23)
        Me.threshholdTxt.TabIndex = 27
        Me.MetroToolTip1.SetToolTip(Me.threshholdTxt, "Reorder threshold")
        Me.threshholdTxt.UseSelectable = True
        Me.threshholdTxt.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.threshholdTxt.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(717, 376)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(158, 35)
        Me.btnInsert.TabIndex = 34
        Me.btnInsert.Text = "Add New Product"
        Me.btnInsert.UseSelectable = True
        '
        'btnDeactivate
        '
        Me.btnDeactivate.Location = New System.Drawing.Point(717, 423)
        Me.btnDeactivate.Name = "btnDeactivate"
        Me.btnDeactivate.Size = New System.Drawing.Size(158, 35)
        Me.btnDeactivate.TabIndex = 35
        Me.btnDeactivate.Text = "Deactivate Selected Product"
        Me.btnDeactivate.UseSelectable = True
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.Location = New System.Drawing.Point(15, 459)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(180, 19)
        Me.MetroLabel10.TabIndex = 23
        Me.MetroLabel10.Text = "Search For Product By Name"
        '
        'searchByNameTxt
        '
        '
        '
        '
        Me.searchByNameTxt.CustomButton.Image = Nothing
        Me.searchByNameTxt.CustomButton.Location = New System.Drawing.Point(107, 1)
        Me.searchByNameTxt.CustomButton.Name = ""
        Me.searchByNameTxt.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.searchByNameTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.searchByNameTxt.CustomButton.TabIndex = 1
        Me.searchByNameTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.searchByNameTxt.CustomButton.UseSelectable = True
        Me.searchByNameTxt.CustomButton.Visible = False
        Me.searchByNameTxt.Lines = New String(-1) {}
        Me.searchByNameTxt.Location = New System.Drawing.Point(201, 459)
        Me.searchByNameTxt.MaxLength = 32767
        Me.searchByNameTxt.Name = "searchByNameTxt"
        Me.searchByNameTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.searchByNameTxt.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.searchByNameTxt.SelectedText = ""
        Me.searchByNameTxt.SelectionLength = 0
        Me.searchByNameTxt.SelectionStart = 0
        Me.searchByNameTxt.ShortcutsEnabled = True
        Me.searchByNameTxt.Size = New System.Drawing.Size(129, 23)
        Me.searchByNameTxt.TabIndex = 30
        Me.MetroToolTip1.SetToolTip(Me.searchByNameTxt, "Enter product name")
        Me.searchByNameTxt.UseSelectable = True
        Me.searchByNameTxt.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.searchByNameTxt.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(369, 459)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(156, 19)
        Me.MetroLabel9.TabIndex = 25
        Me.MetroLabel9.Text = "Search For Product By ID"
        '
        'searchByIDTxt
        '
        '
        '
        '
        Me.searchByIDTxt.CustomButton.Image = Nothing
        Me.searchByIDTxt.CustomButton.Location = New System.Drawing.Point(80, 1)
        Me.searchByIDTxt.CustomButton.Name = ""
        Me.searchByIDTxt.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.searchByIDTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.searchByIDTxt.CustomButton.TabIndex = 1
        Me.searchByIDTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.searchByIDTxt.CustomButton.UseSelectable = True
        Me.searchByIDTxt.CustomButton.Visible = False
        Me.searchByIDTxt.Lines = New String(-1) {}
        Me.searchByIDTxt.Location = New System.Drawing.Point(531, 459)
        Me.searchByIDTxt.MaxLength = 32767
        Me.searchByIDTxt.Name = "searchByIDTxt"
        Me.searchByIDTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.searchByIDTxt.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.searchByIDTxt.SelectedText = ""
        Me.searchByIDTxt.SelectionLength = 0
        Me.searchByIDTxt.SelectionStart = 0
        Me.searchByIDTxt.ShortcutsEnabled = True
        Me.searchByIDTxt.Size = New System.Drawing.Size(102, 23)
        Me.searchByIDTxt.TabIndex = 31
        Me.MetroToolTip1.SetToolTip(Me.searchByIDTxt, "Enter product ID")
        Me.searchByIDTxt.UseSelectable = True
        Me.searchByIDTxt.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.searchByIDTxt.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtSupplier
        '
        '
        '
        '
        Me.txtSupplier.CustomButton.Image = Nothing
        Me.txtSupplier.CustomButton.Location = New System.Drawing.Point(136, 1)
        Me.txtSupplier.CustomButton.Name = ""
        Me.txtSupplier.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtSupplier.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSupplier.CustomButton.TabIndex = 1
        Me.txtSupplier.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSupplier.CustomButton.UseSelectable = True
        Me.txtSupplier.CustomButton.Visible = False
        Me.txtSupplier.Enabled = False
        Me.txtSupplier.Lines = New String(-1) {}
        Me.txtSupplier.Location = New System.Drawing.Point(475, 384)
        Me.txtSupplier.MaxLength = 32767
        Me.txtSupplier.Name = "txtSupplier"
        Me.txtSupplier.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSupplier.ReadOnly = True
        Me.txtSupplier.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSupplier.SelectedText = ""
        Me.txtSupplier.SelectionLength = 0
        Me.txtSupplier.SelectionStart = 0
        Me.txtSupplier.ShortcutsEnabled = True
        Me.txtSupplier.Size = New System.Drawing.Size(158, 23)
        Me.txtSupplier.TabIndex = 28
        Me.MetroToolTip1.SetToolTip(Me.txtSupplier, "Supplier")
        Me.txtSupplier.UseSelectable = True
        Me.txtSupplier.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSupplier.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.Location = New System.Drawing.Point(328, 384)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(78, 19)
        Me.MetroLabel11.TabIndex = 27
        Me.MetroLabel11.Text = "Supplied By"
        '
        'txtLastSupplied
        '
        '
        '
        '
        Me.txtLastSupplied.CustomButton.Image = Nothing
        Me.txtLastSupplied.CustomButton.Location = New System.Drawing.Point(136, 1)
        Me.txtLastSupplied.CustomButton.Name = ""
        Me.txtLastSupplied.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtLastSupplied.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtLastSupplied.CustomButton.TabIndex = 1
        Me.txtLastSupplied.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtLastSupplied.CustomButton.UseSelectable = True
        Me.txtLastSupplied.CustomButton.Visible = False
        Me.txtLastSupplied.Enabled = False
        Me.txtLastSupplied.Lines = New String(-1) {}
        Me.txtLastSupplied.Location = New System.Drawing.Point(475, 422)
        Me.txtLastSupplied.MaxLength = 32767
        Me.txtLastSupplied.Name = "txtLastSupplied"
        Me.txtLastSupplied.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLastSupplied.ReadOnly = True
        Me.txtLastSupplied.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtLastSupplied.SelectedText = ""
        Me.txtLastSupplied.SelectionLength = 0
        Me.txtLastSupplied.SelectionStart = 0
        Me.txtLastSupplied.ShortcutsEnabled = True
        Me.txtLastSupplied.Size = New System.Drawing.Size(158, 23)
        Me.txtLastSupplied.TabIndex = 29
        Me.MetroToolTip1.SetToolTip(Me.txtLastSupplied, "Last supplied")
        Me.txtLastSupplied.UseSelectable = True
        Me.txtLastSupplied.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtLastSupplied.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel12
        '
        Me.MetroLabel12.AutoSize = True
        Me.MetroLabel12.Location = New System.Drawing.Point(328, 422)
        Me.MetroLabel12.Name = "MetroLabel12"
        Me.MetroLabel12.Size = New System.Drawing.Size(86, 19)
        Me.MetroLabel12.TabIndex = 29
        Me.MetroLabel12.Text = "Last Supplied"
        '
        'lblActive
        '
        Me.lblActive.AutoSize = True
        Me.lblActive.FontSize = MetroFramework.MetroLabelSize.Small
        Me.lblActive.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lblActive.ForeColor = System.Drawing.Color.LimeGreen
        Me.lblActive.Location = New System.Drawing.Point(243, 358)
        Me.lblActive.Name = "lblActive"
        Me.lblActive.Size = New System.Drawing.Size(40, 15)
        Me.lblActive.TabIndex = 30
        Me.lblActive.Text = "Active"
        Me.lblActive.UseCustomForeColor = True
        '
        'btnAddStock
        '
        Me.btnAddStock.Location = New System.Drawing.Point(717, 283)
        Me.btnAddStock.Name = "btnAddStock"
        Me.btnAddStock.Size = New System.Drawing.Size(158, 35)
        Me.btnAddStock.TabIndex = 32
        Me.btnAddStock.Text = "Add Stock"
        Me.btnAddStock.UseSelectable = True
        '
        'btnVAT
        '
        Me.btnVAT.Location = New System.Drawing.Point(250, 320)
        Me.btnVAT.Name = "btnVAT"
        Me.btnVAT.Size = New System.Drawing.Size(72, 19)
        Me.btnVAT.TabIndex = 36
        Me.btnVAT.Text = "Change VAT"
        Me.btnVAT.UseSelectable = True
        '
        'MetroToolTip1
        '
        Me.MetroToolTip1.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroToolTip1.StyleManager = Nothing
        Me.MetroToolTip1.Theme = MetroFramework.MetroThemeStyle.[Default]
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
        Me.ProductquantityDataGridViewTextBoxColumn.Width = 75
        '
        'ProductdescriptionDataGridViewTextBoxColumn
        '
        Me.ProductdescriptionDataGridViewTextBoxColumn.DataPropertyName = "product_description"
        Me.ProductdescriptionDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.ProductdescriptionDataGridViewTextBoxColumn.Name = "ProductdescriptionDataGridViewTextBoxColumn"
        Me.ProductdescriptionDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProductdescriptionDataGridViewTextBoxColumn.Width = 101
        '
        'ProductcategoryDataGridViewTextBoxColumn
        '
        Me.ProductcategoryDataGridViewTextBoxColumn.DataPropertyName = "product_category"
        Me.ProductcategoryDataGridViewTextBoxColumn.HeaderText = "Category"
        Me.ProductcategoryDataGridViewTextBoxColumn.Name = "ProductcategoryDataGridViewTextBoxColumn"
        Me.ProductcategoryDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CostpriceperunitDataGridViewTextBoxColumn
        '
        Me.CostpriceperunitDataGridViewTextBoxColumn.DataPropertyName = "cost_price_per_unit"
        Me.CostpriceperunitDataGridViewTextBoxColumn.HeaderText = "Cost Price Per Unit"
        Me.CostpriceperunitDataGridViewTextBoxColumn.Name = "CostpriceperunitDataGridViewTextBoxColumn"
        Me.CostpriceperunitDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProductmarkuppercentageDataGridViewTextBoxColumn
        '
        Me.ProductmarkuppercentageDataGridViewTextBoxColumn.DataPropertyName = "product_markup_percentage"
        Me.ProductmarkuppercentageDataGridViewTextBoxColumn.HeaderText = "Markup Percentage"
        Me.ProductmarkuppercentageDataGridViewTextBoxColumn.Name = "ProductmarkuppercentageDataGridViewTextBoxColumn"
        Me.ProductmarkuppercentageDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ReorderthresholdDataGridViewTextBoxColumn
        '
        Me.ReorderthresholdDataGridViewTextBoxColumn.DataPropertyName = "reorder_threshold"
        Me.ReorderthresholdDataGridViewTextBoxColumn.HeaderText = "Threshold"
        Me.ReorderthresholdDataGridViewTextBoxColumn.Name = "ReorderthresholdDataGridViewTextBoxColumn"
        Me.ReorderthresholdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PRODUCTTableAdapter
        '
        Me.PRODUCTTableAdapter.ClearBeforeFill = True
        '
        'JoinT_PRODUCT_SUPPLIERTableAdapter
        '
        Me.JoinT_PRODUCT_SUPPLIERTableAdapter.ClearBeforeFill = True
        '
        'Product_SUPPLIERTableAdapter
        '
        Me.Product_SUPPLIERTableAdapter.ClearBeforeFill = True
        '
        'VatTableAdapter1
        '
        Me.VatTableAdapter1.ClearBeforeFill = True
        '
        'productsPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.btnVAT)
        Me.Controls.Add(Me.btnAddStock)
        Me.Controls.Add(Me.lblActive)
        Me.Controls.Add(Me.txtLastSupplied)
        Me.Controls.Add(Me.MetroLabel12)
        Me.Controls.Add(Me.txtSupplier)
        Me.Controls.Add(Me.MetroLabel11)
        Me.Controls.Add(Me.searchByIDTxt)
        Me.Controls.Add(Me.MetroLabel9)
        Me.Controls.Add(Me.searchByNameTxt)
        Me.Controls.Add(Me.MetroLabel10)
        Me.Controls.Add(Me.btnDeactivate)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.threshholdTxt)
        Me.Controls.Add(Me.cpTxt)
        Me.Controls.Add(Me.markupTxt)
        Me.Controls.Add(Me.nameTxt)
        Me.Controls.Add(Me.priceTxt)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.categoryTxt)
        Me.Controls.Add(Me.descripTxt)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.MetroLabel8)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.ProductDataGridView)
        Me.Name = "productsPanel"
        Me.Size = New System.Drawing.Size(923, 490)
        CType(Me.ProductDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUCTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSSystem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProductDataGridView As DataGridView
	Friend WithEvents PRODUCTBindingSource As BindingSource
	Friend WithEvents DSSystem As DSSystem
	Friend WithEvents PRODUCTTableAdapter As DSSystemTableAdapters.PRODUCTTableAdapter
	Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
	Friend WithEvents btnUpdate As MetroFramework.Controls.MetroButton
	Friend WithEvents descripTxt As MetroFramework.Controls.MetroTextBox
	Friend WithEvents categoryTxt As MetroFramework.Controls.MetroTextBox
	Friend WithEvents txtQuantity As MetroFramework.Controls.MetroTextBox
	Friend WithEvents priceTxt As MetroFramework.Controls.MetroTextBox
	Friend WithEvents nameTxt As MetroFramework.Controls.MetroTextBox
	Friend WithEvents markupTxt As MetroFramework.Controls.MetroTextBox
	Friend WithEvents cpTxt As MetroFramework.Controls.MetroTextBox
	Friend WithEvents threshholdTxt As MetroFramework.Controls.MetroTextBox
	Friend WithEvents btnInsert As MetroFramework.Controls.MetroButton
	Friend WithEvents btnDeactivate As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents searchByNameTxt As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents searchByIDTxt As MetroFramework.Controls.MetroTextBox
    Friend WithEvents ProductIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductpriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductquantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductdescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductcategoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CostpriceperunitDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductmarkuppercentageDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReorderthresholdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents txtSupplier As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents JoinT_PRODUCT_SUPPLIERTableAdapter As DSSystemTableAdapters.JOINT_PRODUCT_SUPPLIERTableAdapter
    Friend WithEvents txtLastSupplied As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel12 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblActive As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnAddStock As MetroFramework.Controls.MetroButton
    Friend WithEvents Product_SUPPLIERTableAdapter As DSSystemTableAdapters.PRODUCT_SUPPLIERTableAdapter
    Friend WithEvents btnVAT As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroToolTip1 As MetroFramework.Components.MetroToolTip
    Friend WithEvents VatTableAdapter1 As DSSystemTableAdapters.VATTableAdapter
End Class
