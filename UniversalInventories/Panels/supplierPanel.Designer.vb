<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class supplierPanel
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
        Me.SupplierDataGridView = New System.Windows.Forms.DataGridView()
        Me.SupplierIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SuppliernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SuppliernumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplieremailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplieraddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SuppliersuburbDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SuppliercityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierprovinceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierpostalcodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SUPPLIERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSSystem = New UniversalInventories.DSSystem()
        Me.SUPPLIERTableAdapter = New UniversalInventories.DSSystemTableAdapters.SUPPLIERTableAdapter()
        Me.btnInsert = New MetroFramework.Controls.MetroButton()
        Me.btnUpdate = New MetroFramework.Controls.MetroButton()
        Me.searchTxt = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.postatTxt = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.addressTxt = New MetroFramework.Controls.MetroTextBox()
        Me.suburbTxt = New MetroFramework.Controls.MetroTextBox()
        Me.cityTxt = New MetroFramework.Controls.MetroTextBox()
        Me.provinceTxt = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.emailTxt = New MetroFramework.Controls.MetroTextBox()
        Me.numberTxt = New MetroFramework.Controls.MetroTextBox()
        Me.nameTxt = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.txtSearchID = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroToolTip1 = New MetroFramework.Components.MetroToolTip()
        CType(Me.SupplierDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SUPPLIERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSSystem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SupplierDataGridView
        '
        Me.SupplierDataGridView.AllowUserToAddRows = False
        Me.SupplierDataGridView.AllowUserToDeleteRows = False
        Me.SupplierDataGridView.AutoGenerateColumns = False
        Me.SupplierDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SupplierDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SupplierIDDataGridViewTextBoxColumn, Me.SuppliernameDataGridViewTextBoxColumn, Me.SuppliernumberDataGridViewTextBoxColumn, Me.SupplieremailDataGridViewTextBoxColumn, Me.SupplieraddressDataGridViewTextBoxColumn, Me.SuppliersuburbDataGridViewTextBoxColumn, Me.SuppliercityDataGridViewTextBoxColumn, Me.SupplierprovinceDataGridViewTextBoxColumn, Me.SupplierpostalcodeDataGridViewTextBoxColumn})
        Me.SupplierDataGridView.DataSource = Me.SUPPLIERBindingSource
        Me.SupplierDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.SupplierDataGridView.MultiSelect = False
        Me.SupplierDataGridView.Name = "SupplierDataGridView"
        Me.SupplierDataGridView.ReadOnly = True
        Me.SupplierDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.SupplierDataGridView.Size = New System.Drawing.Size(917, 261)
        Me.SupplierDataGridView.TabIndex = 0
        Me.MetroToolTip1.SetToolTip(Me.SupplierDataGridView, "Suppliers")
        '
        'SupplierIDDataGridViewTextBoxColumn
        '
        Me.SupplierIDDataGridViewTextBoxColumn.DataPropertyName = "supplier_ID"
        Me.SupplierIDDataGridViewTextBoxColumn.HeaderText = "Supplier ID"
        Me.SupplierIDDataGridViewTextBoxColumn.Name = "SupplierIDDataGridViewTextBoxColumn"
        Me.SupplierIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SuppliernameDataGridViewTextBoxColumn
        '
        Me.SuppliernameDataGridViewTextBoxColumn.DataPropertyName = "supplier_name"
        Me.SuppliernameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.SuppliernameDataGridViewTextBoxColumn.Name = "SuppliernameDataGridViewTextBoxColumn"
        Me.SuppliernameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SuppliernumberDataGridViewTextBoxColumn
        '
        Me.SuppliernumberDataGridViewTextBoxColumn.DataPropertyName = "supplier_number"
        Me.SuppliernumberDataGridViewTextBoxColumn.HeaderText = "Number"
        Me.SuppliernumberDataGridViewTextBoxColumn.Name = "SuppliernumberDataGridViewTextBoxColumn"
        Me.SuppliernumberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SupplieremailDataGridViewTextBoxColumn
        '
        Me.SupplieremailDataGridViewTextBoxColumn.DataPropertyName = "supplier_email"
        Me.SupplieremailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.SupplieremailDataGridViewTextBoxColumn.Name = "SupplieremailDataGridViewTextBoxColumn"
        Me.SupplieremailDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SupplieraddressDataGridViewTextBoxColumn
        '
        Me.SupplieraddressDataGridViewTextBoxColumn.DataPropertyName = "supplier_address"
        Me.SupplieraddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.SupplieraddressDataGridViewTextBoxColumn.Name = "SupplieraddressDataGridViewTextBoxColumn"
        Me.SupplieraddressDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SuppliersuburbDataGridViewTextBoxColumn
        '
        Me.SuppliersuburbDataGridViewTextBoxColumn.DataPropertyName = "supplier_suburb"
        Me.SuppliersuburbDataGridViewTextBoxColumn.HeaderText = "Suburb"
        Me.SuppliersuburbDataGridViewTextBoxColumn.Name = "SuppliersuburbDataGridViewTextBoxColumn"
        Me.SuppliersuburbDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SuppliercityDataGridViewTextBoxColumn
        '
        Me.SuppliercityDataGridViewTextBoxColumn.DataPropertyName = "supplier_city"
        Me.SuppliercityDataGridViewTextBoxColumn.HeaderText = "Cty"
        Me.SuppliercityDataGridViewTextBoxColumn.Name = "SuppliercityDataGridViewTextBoxColumn"
        Me.SuppliercityDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SupplierprovinceDataGridViewTextBoxColumn
        '
        Me.SupplierprovinceDataGridViewTextBoxColumn.DataPropertyName = "supplier_province"
        Me.SupplierprovinceDataGridViewTextBoxColumn.HeaderText = "Province"
        Me.SupplierprovinceDataGridViewTextBoxColumn.Name = "SupplierprovinceDataGridViewTextBoxColumn"
        Me.SupplierprovinceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SupplierpostalcodeDataGridViewTextBoxColumn
        '
        Me.SupplierpostalcodeDataGridViewTextBoxColumn.DataPropertyName = "supplier_postal_code"
        Me.SupplierpostalcodeDataGridViewTextBoxColumn.HeaderText = "Postal Code"
        Me.SupplierpostalcodeDataGridViewTextBoxColumn.Name = "SupplierpostalcodeDataGridViewTextBoxColumn"
        Me.SupplierpostalcodeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SUPPLIERBindingSource
        '
        Me.SUPPLIERBindingSource.DataMember = "SUPPLIER"
        Me.SUPPLIERBindingSource.DataSource = Me.DSSystem
        '
        'DSSystem
        '
        Me.DSSystem.DataSetName = "DSSystem"
        Me.DSSystem.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SUPPLIERTableAdapter
        '
        Me.SUPPLIERTableAdapter.ClearBeforeFill = True
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(711, 390)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(158, 35)
        Me.btnInsert.TabIndex = 41
        Me.btnInsert.Text = "Add A Supplier"
        Me.btnInsert.UseSelectable = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(711, 349)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(158, 35)
        Me.btnUpdate.TabIndex = 40
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseSelectable = True
        '
        'searchTxt
        '
        '
        '
        '
        Me.searchTxt.CustomButton.Image = Nothing
        Me.searchTxt.CustomButton.Location = New System.Drawing.Point(123, 1)
        Me.searchTxt.CustomButton.Name = ""
        Me.searchTxt.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.searchTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.searchTxt.CustomButton.TabIndex = 1
        Me.searchTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.searchTxt.CustomButton.UseSelectable = True
        Me.searchTxt.CustomButton.Visible = False
        Me.searchTxt.Lines = New String(-1) {}
        Me.searchTxt.Location = New System.Drawing.Point(180, 457)
        Me.searchTxt.MaxLength = 32767
        Me.searchTxt.Name = "searchTxt"
        Me.searchTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.searchTxt.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.searchTxt.SelectedText = ""
        Me.searchTxt.SelectionLength = 0
        Me.searchTxt.SelectionStart = 0
        Me.searchTxt.ShortcutsEnabled = True
        Me.searchTxt.Size = New System.Drawing.Size(145, 23)
        Me.searchTxt.TabIndex = 39
        Me.MetroToolTip1.SetToolTip(Me.searchTxt, "Enter supplier name")
        Me.searchTxt.UseSelectable = True
        Me.searchTxt.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.searchTxt.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.Location = New System.Drawing.Point(14, 459)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(158, 19)
        Me.MetroLabel11.TabIndex = 46
        Me.MetroLabel11.Text = "Search By Supplier Name"
        '
        'postatTxt
        '
        '
        '
        '
        Me.postatTxt.CustomButton.Image = Nothing
        Me.postatTxt.CustomButton.Location = New System.Drawing.Point(136, 1)
        Me.postatTxt.CustomButton.Name = ""
        Me.postatTxt.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.postatTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.postatTxt.CustomButton.TabIndex = 1
        Me.postatTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.postatTxt.CustomButton.UseSelectable = True
        Me.postatTxt.CustomButton.Visible = False
        Me.postatTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SUPPLIERBindingSource, "supplier_postal_code", True))
        Me.postatTxt.Lines = New String(-1) {}
        Me.postatTxt.Location = New System.Drawing.Point(498, 402)
        Me.postatTxt.MaxLength = 4
        Me.postatTxt.Name = "postatTxt"
        Me.postatTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.postatTxt.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.postatTxt.SelectedText = ""
        Me.postatTxt.SelectionLength = 0
        Me.postatTxt.SelectionStart = 0
        Me.postatTxt.ShortcutsEnabled = True
        Me.postatTxt.Size = New System.Drawing.Size(158, 23)
        Me.postatTxt.TabIndex = 38
        Me.MetroToolTip1.SetToolTip(Me.postatTxt, "Postal code")
        Me.postatTxt.UseSelectable = True
        Me.postatTxt.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.postatTxt.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(401, 406)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(79, 19)
        Me.MetroLabel9.TabIndex = 42
        Me.MetroLabel9.Text = "Postal Code"
        '
        'addressTxt
        '
        '
        '
        '
        Me.addressTxt.CustomButton.Image = Nothing
        Me.addressTxt.CustomButton.Location = New System.Drawing.Point(136, 1)
        Me.addressTxt.CustomButton.Name = ""
        Me.addressTxt.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.addressTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.addressTxt.CustomButton.TabIndex = 1
        Me.addressTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.addressTxt.CustomButton.UseSelectable = True
        Me.addressTxt.CustomButton.Visible = False
        Me.addressTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SUPPLIERBindingSource, "supplier_address", True))
        Me.addressTxt.Lines = New String(-1) {}
        Me.addressTxt.Location = New System.Drawing.Point(96, 402)
        Me.addressTxt.MaxLength = 100
        Me.addressTxt.Name = "addressTxt"
        Me.addressTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.addressTxt.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.addressTxt.SelectedText = ""
        Me.addressTxt.SelectionLength = 0
        Me.addressTxt.SelectionStart = 0
        Me.addressTxt.ShortcutsEnabled = True
        Me.addressTxt.Size = New System.Drawing.Size(158, 23)
        Me.addressTxt.TabIndex = 34
        Me.MetroToolTip1.SetToolTip(Me.addressTxt, "Address")
        Me.addressTxt.UseSelectable = True
        Me.addressTxt.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.addressTxt.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'suburbTxt
        '
        '
        '
        '
        Me.suburbTxt.CustomButton.Image = Nothing
        Me.suburbTxt.CustomButton.Location = New System.Drawing.Point(136, 1)
        Me.suburbTxt.CustomButton.Name = ""
        Me.suburbTxt.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.suburbTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.suburbTxt.CustomButton.TabIndex = 1
        Me.suburbTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.suburbTxt.CustomButton.UseSelectable = True
        Me.suburbTxt.CustomButton.Visible = False
        Me.suburbTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SUPPLIERBindingSource, "supplier_suburb", True))
        Me.suburbTxt.Lines = New String(-1) {}
        Me.suburbTxt.Location = New System.Drawing.Point(498, 275)
        Me.suburbTxt.MaxLength = 100
        Me.suburbTxt.Name = "suburbTxt"
        Me.suburbTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.suburbTxt.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.suburbTxt.SelectedText = ""
        Me.suburbTxt.SelectionLength = 0
        Me.suburbTxt.SelectionStart = 0
        Me.suburbTxt.ShortcutsEnabled = True
        Me.suburbTxt.Size = New System.Drawing.Size(158, 23)
        Me.suburbTxt.TabIndex = 35
        Me.MetroToolTip1.SetToolTip(Me.suburbTxt, "Suburb")
        Me.suburbTxt.UseSelectable = True
        Me.suburbTxt.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.suburbTxt.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'cityTxt
        '
        '
        '
        '
        Me.cityTxt.CustomButton.Image = Nothing
        Me.cityTxt.CustomButton.Location = New System.Drawing.Point(136, 1)
        Me.cityTxt.CustomButton.Name = ""
        Me.cityTxt.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.cityTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.cityTxt.CustomButton.TabIndex = 1
        Me.cityTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.cityTxt.CustomButton.UseSelectable = True
        Me.cityTxt.CustomButton.Visible = False
        Me.cityTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SUPPLIERBindingSource, "supplier_city", True))
        Me.cityTxt.Lines = New String(-1) {}
        Me.cityTxt.Location = New System.Drawing.Point(498, 315)
        Me.cityTxt.MaxLength = 100
        Me.cityTxt.Name = "cityTxt"
        Me.cityTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.cityTxt.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.cityTxt.SelectedText = ""
        Me.cityTxt.SelectionLength = 0
        Me.cityTxt.SelectionStart = 0
        Me.cityTxt.ShortcutsEnabled = True
        Me.cityTxt.Size = New System.Drawing.Size(158, 23)
        Me.cityTxt.TabIndex = 36
        Me.MetroToolTip1.SetToolTip(Me.cityTxt, "City")
        Me.cityTxt.UseSelectable = True
        Me.cityTxt.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.cityTxt.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'provinceTxt
        '
        '
        '
        '
        Me.provinceTxt.CustomButton.Image = Nothing
        Me.provinceTxt.CustomButton.Location = New System.Drawing.Point(136, 1)
        Me.provinceTxt.CustomButton.Name = ""
        Me.provinceTxt.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.provinceTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.provinceTxt.CustomButton.TabIndex = 1
        Me.provinceTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.provinceTxt.CustomButton.UseSelectable = True
        Me.provinceTxt.CustomButton.Visible = False
        Me.provinceTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SUPPLIERBindingSource, "supplier_province", True))
        Me.provinceTxt.Lines = New String(-1) {}
        Me.provinceTxt.Location = New System.Drawing.Point(498, 358)
        Me.provinceTxt.MaxLength = 100
        Me.provinceTxt.Name = "provinceTxt"
        Me.provinceTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.provinceTxt.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.provinceTxt.SelectedText = ""
        Me.provinceTxt.SelectionLength = 0
        Me.provinceTxt.SelectionStart = 0
        Me.provinceTxt.ShortcutsEnabled = True
        Me.provinceTxt.Size = New System.Drawing.Size(158, 23)
        Me.provinceTxt.TabIndex = 37
        Me.MetroToolTip1.SetToolTip(Me.provinceTxt, "Province")
        Me.provinceTxt.UseSelectable = True
        Me.provinceTxt.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.provinceTxt.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(401, 362)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(59, 19)
        Me.MetroLabel8.TabIndex = 37
        Me.MetroLabel8.Text = "Province"
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(401, 319)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(31, 19)
        Me.MetroLabel7.TabIndex = 36
        Me.MetroLabel7.Text = "City"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(401, 279)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(51, 19)
        Me.MetroLabel6.TabIndex = 35
        Me.MetroLabel6.Text = "Suburb"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(14, 406)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(56, 19)
        Me.MetroLabel5.TabIndex = 34
        Me.MetroLabel5.Text = "Address"
        '
        'emailTxt
        '
        '
        '
        '
        Me.emailTxt.CustomButton.Image = Nothing
        Me.emailTxt.CustomButton.Location = New System.Drawing.Point(136, 1)
        Me.emailTxt.CustomButton.Name = ""
        Me.emailTxt.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.emailTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.emailTxt.CustomButton.TabIndex = 1
        Me.emailTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.emailTxt.CustomButton.UseSelectable = True
        Me.emailTxt.CustomButton.Visible = False
        Me.emailTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SUPPLIERBindingSource, "supplier_email", True))
        Me.emailTxt.Lines = New String(-1) {}
        Me.emailTxt.Location = New System.Drawing.Point(96, 358)
        Me.emailTxt.MaxLength = 100
        Me.emailTxt.Name = "emailTxt"
        Me.emailTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.emailTxt.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.emailTxt.SelectedText = ""
        Me.emailTxt.SelectionLength = 0
        Me.emailTxt.SelectionStart = 0
        Me.emailTxt.ShortcutsEnabled = True
        Me.emailTxt.Size = New System.Drawing.Size(158, 23)
        Me.emailTxt.TabIndex = 33
        Me.MetroToolTip1.SetToolTip(Me.emailTxt, "Email")
        Me.emailTxt.UseSelectable = True
        Me.emailTxt.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.emailTxt.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'numberTxt
        '
        '
        '
        '
        Me.numberTxt.CustomButton.Image = Nothing
        Me.numberTxt.CustomButton.Location = New System.Drawing.Point(136, 1)
        Me.numberTxt.CustomButton.Name = ""
        Me.numberTxt.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.numberTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.numberTxt.CustomButton.TabIndex = 1
        Me.numberTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.numberTxt.CustomButton.UseSelectable = True
        Me.numberTxt.CustomButton.Visible = False
        Me.numberTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SUPPLIERBindingSource, "supplier_number", True))
        Me.numberTxt.Lines = New String(-1) {}
        Me.numberTxt.Location = New System.Drawing.Point(96, 315)
        Me.numberTxt.MaxLength = 10
        Me.numberTxt.Name = "numberTxt"
        Me.numberTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.numberTxt.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.numberTxt.SelectedText = ""
        Me.numberTxt.SelectionLength = 0
        Me.numberTxt.SelectionStart = 0
        Me.numberTxt.ShortcutsEnabled = True
        Me.numberTxt.Size = New System.Drawing.Size(158, 23)
        Me.numberTxt.TabIndex = 32
        Me.MetroToolTip1.SetToolTip(Me.numberTxt, "Number")
        Me.numberTxt.UseSelectable = True
        Me.numberTxt.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.numberTxt.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
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
        Me.nameTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SUPPLIERBindingSource, "supplier_name", True))
        Me.nameTxt.Lines = New String(-1) {}
        Me.nameTxt.Location = New System.Drawing.Point(96, 275)
        Me.nameTxt.MaxLength = 100
        Me.nameTxt.Name = "nameTxt"
        Me.nameTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.nameTxt.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.nameTxt.SelectedText = ""
        Me.nameTxt.SelectionLength = 0
        Me.nameTxt.SelectionStart = 0
        Me.nameTxt.ShortcutsEnabled = True
        Me.nameTxt.Size = New System.Drawing.Size(158, 23)
        Me.nameTxt.TabIndex = 31
        Me.MetroToolTip1.SetToolTip(Me.nameTxt, "Supplier name")
        Me.nameTxt.UseSelectable = True
        Me.nameTxt.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.nameTxt.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(14, 362)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(41, 19)
        Me.MetroLabel4.TabIndex = 29
        Me.MetroLabel4.Text = "Email"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(14, 319)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(58, 19)
        Me.MetroLabel3.TabIndex = 28
        Me.MetroLabel3.Text = "Number"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(14, 279)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(45, 19)
        Me.MetroLabel1.TabIndex = 26
        Me.MetroLabel1.Text = "Name"
        '
        'txtSearchID
        '
        '
        '
        '
        Me.txtSearchID.CustomButton.Image = Nothing
        Me.txtSearchID.CustomButton.Location = New System.Drawing.Point(123, 1)
        Me.txtSearchID.CustomButton.Name = ""
        Me.txtSearchID.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtSearchID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSearchID.CustomButton.TabIndex = 1
        Me.txtSearchID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSearchID.CustomButton.UseSelectable = True
        Me.txtSearchID.CustomButton.Visible = False
        Me.txtSearchID.Lines = New String(-1) {}
        Me.txtSearchID.Location = New System.Drawing.Point(525, 457)
        Me.txtSearchID.MaxLength = 32767
        Me.txtSearchID.Name = "txtSearchID"
        Me.txtSearchID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearchID.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSearchID.SelectedText = ""
        Me.txtSearchID.SelectionLength = 0
        Me.txtSearchID.SelectionStart = 0
        Me.txtSearchID.ShortcutsEnabled = True
        Me.txtSearchID.Size = New System.Drawing.Size(145, 23)
        Me.txtSearchID.TabIndex = 47
        Me.MetroToolTip1.SetToolTip(Me.txtSearchID, "Enter supplier ID")
        Me.txtSearchID.UseSelectable = True
        Me.txtSearchID.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSearchID.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(378, 459)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(134, 19)
        Me.MetroLabel2.TabIndex = 48
        Me.MetroLabel2.Text = "Search By Supplier ID"
        '
        'MetroToolTip1
        '
        Me.MetroToolTip1.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroToolTip1.StyleManager = Nothing
        Me.MetroToolTip1.Theme = MetroFramework.MetroThemeStyle.[Default]
        '
        'supplierPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.txtSearchID)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.searchTxt)
        Me.Controls.Add(Me.MetroLabel11)
        Me.Controls.Add(Me.postatTxt)
        Me.Controls.Add(Me.MetroLabel9)
        Me.Controls.Add(Me.addressTxt)
        Me.Controls.Add(Me.suburbTxt)
        Me.Controls.Add(Me.cityTxt)
        Me.Controls.Add(Me.provinceTxt)
        Me.Controls.Add(Me.MetroLabel8)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.emailTxt)
        Me.Controls.Add(Me.numberTxt)
        Me.Controls.Add(Me.nameTxt)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.SupplierDataGridView)
        Me.Name = "supplierPanel"
        Me.Size = New System.Drawing.Size(923, 490)
        CType(Me.SupplierDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SUPPLIERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSSystem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SupplierDataGridView As DataGridView
	Friend WithEvents SupplierIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents SuppliernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents SuppliernumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents SupplieremailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents SupplieraddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents SuppliersuburbDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents SuppliercityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents SupplierprovinceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents SupplierpostalcodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents SUPPLIERBindingSource As BindingSource
	Friend WithEvents DSSystem As DSSystem
	Friend WithEvents SUPPLIERTableAdapter As DSSystemTableAdapters.SUPPLIERTableAdapter
	Friend WithEvents btnInsert As MetroFramework.Controls.MetroButton
	Friend WithEvents btnUpdate As MetroFramework.Controls.MetroButton
	Friend WithEvents searchTxt As MetroFramework.Controls.MetroTextBox
	Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
	Friend WithEvents postatTxt As MetroFramework.Controls.MetroTextBox
	Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
	Friend WithEvents addressTxt As MetroFramework.Controls.MetroTextBox
	Friend WithEvents suburbTxt As MetroFramework.Controls.MetroTextBox
	Friend WithEvents cityTxt As MetroFramework.Controls.MetroTextBox
	Friend WithEvents provinceTxt As MetroFramework.Controls.MetroTextBox
	Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
	Friend WithEvents emailTxt As MetroFramework.Controls.MetroTextBox
	Friend WithEvents numberTxt As MetroFramework.Controls.MetroTextBox
	Friend WithEvents nameTxt As MetroFramework.Controls.MetroTextBox
	Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtSearchID As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroToolTip1 As MetroFramework.Components.MetroToolTip
End Class
