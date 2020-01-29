<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class insertProductPanel
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
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.nameTxt = New MetroFramework.Controls.MetroTextBox()
        Me.categoryTxt = New MetroFramework.Controls.MetroTextBox()
        Me.btnInsert = New MetroFramework.Controls.MetroButton()
        Me.btnBack = New MetroFramework.Controls.MetroButton()
        Me.QuantityNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.descriptionTxt = New System.Windows.Forms.TextBox()
        Me.cmbSuppliers = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.priceNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.markupNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.thresholdNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.costPriceNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.cmbCategory = New MetroFramework.Controls.MetroComboBox()
        Me.cbNewCategory = New MetroFramework.Controls.MetroCheckBox()
        Me.NumericUpDownVAT = New System.Windows.Forms.NumericUpDown()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel12 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel13 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel14 = New MetroFramework.Controls.MetroLabel()
        Me.btnVAT = New MetroFramework.Controls.MetroButton()
        Me.ProductTableAdapter = New UniversalInventories.DSSystemTableAdapters.PRODUCTTableAdapter()
        Me.DsSystem = New UniversalInventories.DSSystem()
        Me.SupplierTableAdapter = New UniversalInventories.DSSystemTableAdapters.SUPPLIERTableAdapter()
        Me.Product_SUPPLIERTableAdapter = New UniversalInventories.DSSystemTableAdapters.PRODUCT_SUPPLIERTableAdapter()
        Me.ProductcategoryTableAdapter = New UniversalInventories.DSSystemTableAdapters.PRODUCTCATEGORYTableAdapter()
        Me.MetroToolTip1 = New MetroFramework.Components.MetroToolTip()
        Me.VatTableAdapter1 = New UniversalInventories.DSSystemTableAdapters.VATTableAdapter()
        CType(Me.QuantityNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.priceNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.markupNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.thresholdNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.costPriceNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownVAT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSystem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(28, 30)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(95, 19)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Product Name"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(28, 196)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(144, 19)
        Me.MetroLabel2.TabIndex = 1
        Me.MetroLabel2.Text = "Product Price (Incl VAT)"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(539, 277)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(114, 19)
        Me.MetroLabel3.TabIndex = 2
        Me.MetroLabel3.Text = "Product Category"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(539, 115)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(124, 19)
        Me.MetroLabel4.TabIndex = 3
        Me.MetroLabel4.Text = "Product Description"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(28, 236)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(108, 19)
        Me.MetroLabel5.TabIndex = 4
        Me.MetroLabel5.Text = "Product Quantity"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(28, 72)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(168, 19)
        Me.MetroLabel6.TabIndex = 5
        Me.MetroLabel6.Text = "Product Cost Price Per Unit"
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(28, 114)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(173, 19)
        Me.MetroLabel7.TabIndex = 6
        Me.MetroLabel7.Text = "Product Markup Percentage"
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(28, 277)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(118, 19)
        Me.MetroLabel8.TabIndex = 7
        Me.MetroLabel8.Text = "Reorder Threshold"
        '
        'nameTxt
        '
        '
        '
        '
        Me.nameTxt.CustomButton.Image = Nothing
        Me.nameTxt.CustomButton.Location = New System.Drawing.Point(128, 1)
        Me.nameTxt.CustomButton.Name = ""
        Me.nameTxt.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.nameTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.nameTxt.CustomButton.TabIndex = 1
        Me.nameTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.nameTxt.CustomButton.UseSelectable = True
        Me.nameTxt.CustomButton.Visible = False
        Me.nameTxt.Lines = New String(-1) {}
        Me.nameTxt.Location = New System.Drawing.Point(232, 26)
        Me.nameTxt.MaxLength = 100
        Me.nameTxt.Name = "nameTxt"
        Me.nameTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.nameTxt.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.nameTxt.SelectedText = ""
        Me.nameTxt.SelectionLength = 0
        Me.nameTxt.SelectionStart = 0
        Me.nameTxt.ShortcutsEnabled = True
        Me.nameTxt.Size = New System.Drawing.Size(150, 23)
        Me.nameTxt.TabIndex = 8
        Me.MetroToolTip1.SetToolTip(Me.nameTxt, "Enter product name")
        Me.nameTxt.UseSelectable = True
        Me.nameTxt.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.nameTxt.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'categoryTxt
        '
        '
        '
        '
        Me.categoryTxt.CustomButton.Image = Nothing
        Me.categoryTxt.CustomButton.Location = New System.Drawing.Point(128, 1)
        Me.categoryTxt.CustomButton.Name = ""
        Me.categoryTxt.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.categoryTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.categoryTxt.CustomButton.TabIndex = 1
        Me.categoryTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.categoryTxt.CustomButton.UseSelectable = True
        Me.categoryTxt.CustomButton.Visible = False
        Me.categoryTxt.Lines = New String(-1) {}
        Me.categoryTxt.Location = New System.Drawing.Point(692, 325)
        Me.categoryTxt.MaxLength = 100
        Me.categoryTxt.Name = "categoryTxt"
        Me.categoryTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.categoryTxt.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.categoryTxt.SelectedText = ""
        Me.categoryTxt.SelectionLength = 0
        Me.categoryTxt.SelectionStart = 0
        Me.categoryTxt.ShortcutsEnabled = True
        Me.categoryTxt.Size = New System.Drawing.Size(150, 23)
        Me.categoryTxt.TabIndex = 19
        Me.MetroToolTip1.SetToolTip(Me.categoryTxt, "Enter category")
        Me.categoryTxt.UseSelectable = True
        Me.categoryTxt.Visible = False
        Me.categoryTxt.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.categoryTxt.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(386, 401)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(150, 35)
        Me.btnInsert.TabIndex = 20
        Me.btnInsert.Text = "Add Product"
        Me.btnInsert.UseSelectable = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(386, 445)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(150, 35)
        Me.btnBack.TabIndex = 21
        Me.btnBack.Text = "Back To Manage Products"
        Me.btnBack.UseSelectable = True
        '
        'QuantityNumericUpDown
        '
        Me.QuantityNumericUpDown.Location = New System.Drawing.Point(232, 235)
        Me.QuantityNumericUpDown.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.QuantityNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.QuantityNumericUpDown.Name = "QuantityNumericUpDown"
        Me.QuantityNumericUpDown.Size = New System.Drawing.Size(150, 20)
        Me.QuantityNumericUpDown.TabIndex = 13
        Me.MetroToolTip1.SetToolTip(Me.QuantityNumericUpDown, "Quantity")
        Me.QuantityNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'descriptionTxt
        '
        Me.descriptionTxt.Location = New System.Drawing.Point(692, 116)
        Me.descriptionTxt.MaxLength = 500
        Me.descriptionTxt.Multiline = True
        Me.descriptionTxt.Name = "descriptionTxt"
        Me.descriptionTxt.Size = New System.Drawing.Size(150, 99)
        Me.descriptionTxt.TabIndex = 16
        Me.MetroToolTip1.SetToolTip(Me.descriptionTxt, "Description")
        '
        'cmbSuppliers
        '
        Me.cmbSuppliers.FormattingEnabled = True
        Me.cmbSuppliers.ItemHeight = 23
        Me.cmbSuppliers.Location = New System.Drawing.Point(692, 20)
        Me.cmbSuppliers.Name = "cmbSuppliers"
        Me.cmbSuppliers.Size = New System.Drawing.Size(143, 29)
        Me.cmbSuppliers.TabIndex = 15
        Me.MetroToolTip1.SetToolTip(Me.cmbSuppliers, "Supplier")
        Me.cmbSuppliers.UseSelectable = True
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(539, 30)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(57, 19)
        Me.MetroLabel9.TabIndex = 22
        Me.MetroLabel9.Text = "Supplier"
        '
        'priceNumericUpDown
        '
        Me.priceNumericUpDown.DecimalPlaces = 2
        Me.priceNumericUpDown.Location = New System.Drawing.Point(232, 195)
        Me.priceNumericUpDown.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.priceNumericUpDown.Name = "priceNumericUpDown"
        Me.priceNumericUpDown.Size = New System.Drawing.Size(150, 20)
        Me.priceNumericUpDown.TabIndex = 12
        Me.MetroToolTip1.SetToolTip(Me.priceNumericUpDown, "Price incl. VAT")
        '
        'markupNumericUpDown
        '
        Me.markupNumericUpDown.DecimalPlaces = 2
        Me.markupNumericUpDown.Location = New System.Drawing.Point(232, 114)
        Me.markupNumericUpDown.Maximum = New Decimal(New Integer() {300, 0, 0, 0})
        Me.markupNumericUpDown.Name = "markupNumericUpDown"
        Me.markupNumericUpDown.Size = New System.Drawing.Size(150, 20)
        Me.markupNumericUpDown.TabIndex = 10
        Me.MetroToolTip1.SetToolTip(Me.markupNumericUpDown, "Enter markup percentage")
        '
        'thresholdNumericUpDown
        '
        Me.thresholdNumericUpDown.Location = New System.Drawing.Point(232, 277)
        Me.thresholdNumericUpDown.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.thresholdNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.thresholdNumericUpDown.Name = "thresholdNumericUpDown"
        Me.thresholdNumericUpDown.Size = New System.Drawing.Size(150, 20)
        Me.thresholdNumericUpDown.TabIndex = 14
        Me.MetroToolTip1.SetToolTip(Me.thresholdNumericUpDown, "Reorder threshold")
        Me.thresholdNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'costPriceNumericUpDown
        '
        Me.costPriceNumericUpDown.DecimalPlaces = 2
        Me.costPriceNumericUpDown.Location = New System.Drawing.Point(232, 71)
        Me.costPriceNumericUpDown.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.costPriceNumericUpDown.Name = "costPriceNumericUpDown"
        Me.costPriceNumericUpDown.Size = New System.Drawing.Size(150, 20)
        Me.costPriceNumericUpDown.TabIndex = 9
        Me.MetroToolTip1.SetToolTip(Me.costPriceNumericUpDown, "Enter cost price")
        '
        'cmbCategory
        '
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.ItemHeight = 23
        Me.cmbCategory.Location = New System.Drawing.Point(692, 268)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(150, 29)
        Me.cmbCategory.TabIndex = 17
        Me.MetroToolTip1.SetToolTip(Me.cmbCategory, "Category")
        Me.cmbCategory.UseSelectable = True
        '
        'cbNewCategory
        '
        Me.cbNewCategory.AutoSize = True
        Me.cbNewCategory.Location = New System.Drawing.Point(692, 304)
        Me.cbNewCategory.Name = "cbNewCategory"
        Me.cbNewCategory.Size = New System.Drawing.Size(98, 15)
        Me.cbNewCategory.TabIndex = 18
        Me.cbNewCategory.Text = "New Category"
        Me.cbNewCategory.UseSelectable = True
        '
        'NumericUpDownVAT
        '
        Me.NumericUpDownVAT.Enabled = False
        Me.NumericUpDownVAT.Location = New System.Drawing.Point(232, 156)
        Me.NumericUpDownVAT.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.NumericUpDownVAT.Name = "NumericUpDownVAT"
        Me.NumericUpDownVAT.ReadOnly = True
        Me.NumericUpDownVAT.Size = New System.Drawing.Size(150, 20)
        Me.NumericUpDownVAT.TabIndex = 11
        Me.MetroToolTip1.SetToolTip(Me.NumericUpDownVAT, "VAT percentage")
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.Location = New System.Drawing.Point(28, 157)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(95, 19)
        Me.MetroLabel10.TabIndex = 25
        Me.MetroLabel10.Text = "Product VAT %"
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.Location = New System.Drawing.Point(213, 71)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(17, 19)
        Me.MetroLabel11.TabIndex = 26
        Me.MetroLabel11.Text = "R"
        '
        'MetroLabel12
        '
        Me.MetroLabel12.AutoSize = True
        Me.MetroLabel12.Location = New System.Drawing.Point(213, 195)
        Me.MetroLabel12.Name = "MetroLabel12"
        Me.MetroLabel12.Size = New System.Drawing.Size(17, 19)
        Me.MetroLabel12.TabIndex = 27
        Me.MetroLabel12.Text = "R"
        '
        'MetroLabel13
        '
        Me.MetroLabel13.AutoSize = True
        Me.MetroLabel13.Location = New System.Drawing.Point(382, 114)
        Me.MetroLabel13.Name = "MetroLabel13"
        Me.MetroLabel13.Size = New System.Drawing.Size(20, 19)
        Me.MetroLabel13.TabIndex = 28
        Me.MetroLabel13.Text = "%"
        '
        'MetroLabel14
        '
        Me.MetroLabel14.AutoSize = True
        Me.MetroLabel14.Location = New System.Drawing.Point(382, 157)
        Me.MetroLabel14.Name = "MetroLabel14"
        Me.MetroLabel14.Size = New System.Drawing.Size(20, 19)
        Me.MetroLabel14.TabIndex = 29
        Me.MetroLabel14.Text = "%"
        '
        'btnVAT
        '
        Me.btnVAT.Location = New System.Drawing.Point(408, 157)
        Me.btnVAT.Name = "btnVAT"
        Me.btnVAT.Size = New System.Drawing.Size(69, 19)
        Me.btnVAT.TabIndex = 30
        Me.btnVAT.Text = "Change VAT"
        Me.btnVAT.UseSelectable = True
        '
        'ProductTableAdapter
        '
        Me.ProductTableAdapter.ClearBeforeFill = True
        '
        'DsSystem
        '
        Me.DsSystem.DataSetName = "DSSystem"
        Me.DsSystem.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SupplierTableAdapter
        '
        Me.SupplierTableAdapter.ClearBeforeFill = True
        '
        'Product_SUPPLIERTableAdapter
        '
        Me.Product_SUPPLIERTableAdapter.ClearBeforeFill = True
        '
        'ProductcategoryTableAdapter
        '
        Me.ProductcategoryTableAdapter.ClearBeforeFill = True
        '
        'MetroToolTip1
        '
        Me.MetroToolTip1.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroToolTip1.StyleManager = Nothing
        Me.MetroToolTip1.Theme = MetroFramework.MetroThemeStyle.[Default]
        '
        'VatTableAdapter1
        '
        Me.VatTableAdapter1.ClearBeforeFill = True
        '
        'insertProductPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnVAT)
        Me.Controls.Add(Me.MetroLabel14)
        Me.Controls.Add(Me.MetroLabel13)
        Me.Controls.Add(Me.MetroLabel12)
        Me.Controls.Add(Me.MetroLabel11)
        Me.Controls.Add(Me.NumericUpDownVAT)
        Me.Controls.Add(Me.MetroLabel10)
        Me.Controls.Add(Me.cbNewCategory)
        Me.Controls.Add(Me.cmbCategory)
        Me.Controls.Add(Me.costPriceNumericUpDown)
        Me.Controls.Add(Me.thresholdNumericUpDown)
        Me.Controls.Add(Me.markupNumericUpDown)
        Me.Controls.Add(Me.priceNumericUpDown)
        Me.Controls.Add(Me.MetroLabel9)
        Me.Controls.Add(Me.cmbSuppliers)
        Me.Controls.Add(Me.descriptionTxt)
        Me.Controls.Add(Me.QuantityNumericUpDown)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.categoryTxt)
        Me.Controls.Add(Me.nameTxt)
        Me.Controls.Add(Me.MetroLabel8)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Name = "insertProductPanel"
        Me.Size = New System.Drawing.Size(923, 490)
        CType(Me.QuantityNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.priceNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.markupNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.thresholdNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.costPriceNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownVAT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSystem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProductTableAdapter As DSSystemTableAdapters.PRODUCTTableAdapter
	Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
	Friend WithEvents nameTxt As MetroFramework.Controls.MetroTextBox
    Friend WithEvents categoryTxt As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnInsert As MetroFramework.Controls.MetroButton
    Friend WithEvents DsSystem As DSSystem
    Friend WithEvents btnBack As MetroFramework.Controls.MetroButton
    Friend WithEvents QuantityNumericUpDown As NumericUpDown
    Friend WithEvents descriptionTxt As TextBox
    Friend WithEvents cmbSuppliers As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents SupplierTableAdapter As DSSystemTableAdapters.SUPPLIERTableAdapter
    Friend WithEvents priceNumericUpDown As NumericUpDown
    Friend WithEvents markupNumericUpDown As NumericUpDown
    Friend WithEvents thresholdNumericUpDown As NumericUpDown
    Friend WithEvents costPriceNumericUpDown As NumericUpDown
    Friend WithEvents Product_SUPPLIERTableAdapter As DSSystemTableAdapters.PRODUCT_SUPPLIERTableAdapter
    Friend WithEvents cmbCategory As MetroFramework.Controls.MetroComboBox
    Friend WithEvents ProductcategoryTableAdapter As DSSystemTableAdapters.PRODUCTCATEGORYTableAdapter
    Friend WithEvents cbNewCategory As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents NumericUpDownVAT As NumericUpDown
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel12 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel13 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel14 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnVAT As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroToolTip1 As MetroFramework.Components.MetroToolTip
    Friend WithEvents VatTableAdapter1 As DSSystemTableAdapters.VATTableAdapter
End Class
