<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class customerPanel
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
        Me.CustomerDataGridView = New System.Windows.Forms.DataGridView()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.surnameTxt = New MetroFramework.Controls.MetroTextBox()
        Me.nameTxt = New MetroFramework.Controls.MetroTextBox()
        Me.numberTxt = New MetroFramework.Controls.MetroTextBox()
        Me.emailTxt = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.provinceTxt = New MetroFramework.Controls.MetroTextBox()
        Me.cityTxt = New MetroFramework.Controls.MetroTextBox()
        Me.suburbTxt = New MetroFramework.Controls.MetroTextBox()
        Me.addressTxt = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.postalTxt = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.searchTxt = New MetroFramework.Controls.MetroTextBox()
        Me.btnUpdate = New MetroFramework.Controls.MetroButton()
        Me.btnInsert = New MetroFramework.Controls.MetroButton()
        Me.passwordTxt = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel12 = New MetroFramework.Controls.MetroLabel()
        Me.txtSearchID = New MetroFramework.Controls.MetroTextBox()
        Me.MetroToolTip1 = New MetroFramework.Components.MetroToolTip()
        Me.CUSTOMERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSSystem = New UniversalInventories.DSSystem()
        Me.CustomerIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustsurnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustnumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustemailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustaddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustsuburbDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustcityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustprovinceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustpostalcodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustpasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUSTOMERTableAdapter = New UniversalInventories.DSSystemTableAdapters.CUSTOMERTableAdapter()
        CType(Me.CustomerDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CUSTOMERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSSystem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CustomerDataGridView
        '
        Me.CustomerDataGridView.AllowUserToAddRows = False
        Me.CustomerDataGridView.AllowUserToDeleteRows = False
        Me.CustomerDataGridView.AutoGenerateColumns = False
        Me.CustomerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CustomerDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CustomerIDDataGridViewTextBoxColumn, Me.CustnameDataGridViewTextBoxColumn, Me.CustsurnameDataGridViewTextBoxColumn, Me.CustnumberDataGridViewTextBoxColumn, Me.CustemailDataGridViewTextBoxColumn, Me.CustaddressDataGridViewTextBoxColumn, Me.CustsuburbDataGridViewTextBoxColumn, Me.CustcityDataGridViewTextBoxColumn, Me.CustprovinceDataGridViewTextBoxColumn, Me.CustpostalcodeDataGridViewTextBoxColumn, Me.CustpasswordDataGridViewTextBoxColumn})
        Me.CustomerDataGridView.DataSource = Me.CUSTOMERBindingSource
        Me.CustomerDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.CustomerDataGridView.MultiSelect = False
        Me.CustomerDataGridView.Name = "CustomerDataGridView"
        Me.CustomerDataGridView.ReadOnly = True
        Me.CustomerDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CustomerDataGridView.Size = New System.Drawing.Size(917, 239)
        Me.CustomerDataGridView.TabIndex = 0
        Me.MetroToolTip1.SetToolTip(Me.CustomerDataGridView, "Customers")
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(12, 252)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(45, 19)
        Me.MetroLabel1.TabIndex = 1
        Me.MetroLabel1.Text = "Name"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(12, 292)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(61, 19)
        Me.MetroLabel2.TabIndex = 2
        Me.MetroLabel2.Text = "Surname"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(12, 335)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(58, 19)
        Me.MetroLabel3.TabIndex = 3
        Me.MetroLabel3.Text = "Number"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(12, 378)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(41, 19)
        Me.MetroLabel4.TabIndex = 4
        Me.MetroLabel4.Text = "Email"
        '
        'surnameTxt
        '
        '
        '
        '
        Me.surnameTxt.CustomButton.Image = Nothing
        Me.surnameTxt.CustomButton.Location = New System.Drawing.Point(136, 1)
        Me.surnameTxt.CustomButton.Name = ""
        Me.surnameTxt.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.surnameTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.surnameTxt.CustomButton.TabIndex = 1
        Me.surnameTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.surnameTxt.CustomButton.UseSelectable = True
        Me.surnameTxt.CustomButton.Visible = False
        Me.surnameTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "cust_surname", True))
        Me.surnameTxt.Lines = New String(-1) {}
        Me.surnameTxt.Location = New System.Drawing.Point(115, 288)
        Me.surnameTxt.MaxLength = 100
        Me.surnameTxt.Name = "surnameTxt"
        Me.surnameTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.surnameTxt.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.surnameTxt.SelectedText = ""
        Me.surnameTxt.SelectionLength = 0
        Me.surnameTxt.SelectionStart = 0
        Me.surnameTxt.ShortcutsEnabled = True
        Me.surnameTxt.Size = New System.Drawing.Size(158, 23)
        Me.surnameTxt.TabIndex = 6
        Me.MetroToolTip1.SetToolTip(Me.surnameTxt, "Surname")
        Me.surnameTxt.UseSelectable = True
        Me.surnameTxt.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.surnameTxt.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
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
        Me.nameTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "cust_name", True))
        Me.nameTxt.Lines = New String(-1) {}
        Me.nameTxt.Location = New System.Drawing.Point(115, 248)
        Me.nameTxt.MaxLength = 100
        Me.nameTxt.Name = "nameTxt"
        Me.nameTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.nameTxt.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.nameTxt.SelectedText = ""
        Me.nameTxt.SelectionLength = 0
        Me.nameTxt.SelectionStart = 0
        Me.nameTxt.ShortcutsEnabled = True
        Me.nameTxt.Size = New System.Drawing.Size(158, 23)
        Me.nameTxt.TabIndex = 5
        Me.MetroToolTip1.SetToolTip(Me.nameTxt, "Name")
        Me.nameTxt.UseSelectable = True
        Me.nameTxt.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.nameTxt.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
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
        Me.numberTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "cust_number", True))
        Me.numberTxt.Lines = New String(-1) {}
        Me.numberTxt.Location = New System.Drawing.Point(115, 331)
        Me.numberTxt.MaxLength = 10
        Me.numberTxt.Name = "numberTxt"
        Me.numberTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.numberTxt.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.numberTxt.SelectedText = ""
        Me.numberTxt.SelectionLength = 0
        Me.numberTxt.SelectionStart = 0
        Me.numberTxt.ShortcutsEnabled = True
        Me.numberTxt.Size = New System.Drawing.Size(158, 23)
        Me.numberTxt.TabIndex = 7
        Me.MetroToolTip1.SetToolTip(Me.numberTxt, "Number")
        Me.numberTxt.UseSelectable = True
        Me.numberTxt.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.numberTxt.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
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
        Me.emailTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "cust_email", True))
        Me.emailTxt.Lines = New String(-1) {}
        Me.emailTxt.Location = New System.Drawing.Point(115, 374)
        Me.emailTxt.MaxLength = 100
        Me.emailTxt.Name = "emailTxt"
        Me.emailTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.emailTxt.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.emailTxt.SelectedText = ""
        Me.emailTxt.SelectionLength = 0
        Me.emailTxt.SelectionStart = 0
        Me.emailTxt.ShortcutsEnabled = True
        Me.emailTxt.Size = New System.Drawing.Size(158, 23)
        Me.emailTxt.TabIndex = 8
        Me.MetroToolTip1.SetToolTip(Me.emailTxt, "Email")
        Me.emailTxt.UseSelectable = True
        Me.emailTxt.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.emailTxt.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(12, 422)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(56, 19)
        Me.MetroLabel5.TabIndex = 9
        Me.MetroLabel5.Text = "Address"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(399, 252)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(51, 19)
        Me.MetroLabel6.TabIndex = 10
        Me.MetroLabel6.Text = "Suburb"
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(399, 292)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(31, 19)
        Me.MetroLabel7.TabIndex = 11
        Me.MetroLabel7.Text = "City"
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(399, 335)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(59, 19)
        Me.MetroLabel8.TabIndex = 12
        Me.MetroLabel8.Text = "Province"
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
        Me.provinceTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "cust_province", True))
        Me.provinceTxt.Lines = New String(-1) {}
        Me.provinceTxt.Location = New System.Drawing.Point(496, 331)
        Me.provinceTxt.MaxLength = 100
        Me.provinceTxt.Name = "provinceTxt"
        Me.provinceTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.provinceTxt.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.provinceTxt.SelectedText = ""
        Me.provinceTxt.SelectionLength = 0
        Me.provinceTxt.SelectionStart = 0
        Me.provinceTxt.ShortcutsEnabled = True
        Me.provinceTxt.Size = New System.Drawing.Size(158, 23)
        Me.provinceTxt.TabIndex = 12
        Me.MetroToolTip1.SetToolTip(Me.provinceTxt, "Province")
        Me.provinceTxt.UseSelectable = True
        Me.provinceTxt.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.provinceTxt.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
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
        Me.cityTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "cust_city", True))
        Me.cityTxt.Lines = New String(-1) {}
        Me.cityTxt.Location = New System.Drawing.Point(496, 288)
        Me.cityTxt.MaxLength = 100
        Me.cityTxt.Name = "cityTxt"
        Me.cityTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.cityTxt.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.cityTxt.SelectedText = ""
        Me.cityTxt.SelectionLength = 0
        Me.cityTxt.SelectionStart = 0
        Me.cityTxt.ShortcutsEnabled = True
        Me.cityTxt.Size = New System.Drawing.Size(158, 23)
        Me.cityTxt.TabIndex = 11
        Me.MetroToolTip1.SetToolTip(Me.cityTxt, "City")
        Me.cityTxt.UseSelectable = True
        Me.cityTxt.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.cityTxt.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
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
        Me.suburbTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "cust_suburb", True))
        Me.suburbTxt.Lines = New String(-1) {}
        Me.suburbTxt.Location = New System.Drawing.Point(496, 248)
        Me.suburbTxt.MaxLength = 100
        Me.suburbTxt.Name = "suburbTxt"
        Me.suburbTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.suburbTxt.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.suburbTxt.SelectedText = ""
        Me.suburbTxt.SelectionLength = 0
        Me.suburbTxt.SelectionStart = 0
        Me.suburbTxt.ShortcutsEnabled = True
        Me.suburbTxt.Size = New System.Drawing.Size(158, 23)
        Me.suburbTxt.TabIndex = 10
        Me.MetroToolTip1.SetToolTip(Me.suburbTxt, "Suburb")
        Me.suburbTxt.UseSelectable = True
        Me.suburbTxt.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.suburbTxt.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
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
        Me.addressTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "cust_address", True))
        Me.addressTxt.Lines = New String(-1) {}
        Me.addressTxt.Location = New System.Drawing.Point(115, 418)
        Me.addressTxt.MaxLength = 100
        Me.addressTxt.Name = "addressTxt"
        Me.addressTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.addressTxt.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.addressTxt.SelectedText = ""
        Me.addressTxt.SelectionLength = 0
        Me.addressTxt.SelectionStart = 0
        Me.addressTxt.ShortcutsEnabled = True
        Me.addressTxt.Size = New System.Drawing.Size(158, 23)
        Me.addressTxt.TabIndex = 9
        Me.MetroToolTip1.SetToolTip(Me.addressTxt, "Address")
        Me.addressTxt.UseSelectable = True
        Me.addressTxt.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.addressTxt.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(399, 378)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(79, 19)
        Me.MetroLabel9.TabIndex = 17
        Me.MetroLabel9.Text = "Postal Code"
        '
        'postalTxt
        '
        '
        '
        '
        Me.postalTxt.CustomButton.Image = Nothing
        Me.postalTxt.CustomButton.Location = New System.Drawing.Point(136, 1)
        Me.postalTxt.CustomButton.Name = ""
        Me.postalTxt.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.postalTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.postalTxt.CustomButton.TabIndex = 1
        Me.postalTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.postalTxt.CustomButton.UseSelectable = True
        Me.postalTxt.CustomButton.Visible = False
        Me.postalTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "cust_postal_code", True))
        Me.postalTxt.Lines = New String(-1) {}
        Me.postalTxt.Location = New System.Drawing.Point(496, 374)
        Me.postalTxt.MaxLength = 4
        Me.postalTxt.Name = "postalTxt"
        Me.postalTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.postalTxt.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.postalTxt.SelectedText = ""
        Me.postalTxt.SelectionLength = 0
        Me.postalTxt.SelectionStart = 0
        Me.postalTxt.ShortcutsEnabled = True
        Me.postalTxt.Size = New System.Drawing.Size(158, 23)
        Me.postalTxt.TabIndex = 13
        Me.MetroToolTip1.SetToolTip(Me.postalTxt, "Postal code")
        Me.postalTxt.UseSelectable = True
        Me.postalTxt.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.postalTxt.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.Location = New System.Drawing.Point(3, 462)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(167, 19)
        Me.MetroLabel11.TabIndex = 22
        Me.MetroLabel11.Text = "Search By Customer Name"
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
        Me.searchTxt.Location = New System.Drawing.Point(176, 458)
        Me.searchTxt.MaxLength = 32767
        Me.searchTxt.Name = "searchTxt"
        Me.searchTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.searchTxt.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.searchTxt.SelectedText = ""
        Me.searchTxt.SelectionLength = 0
        Me.searchTxt.SelectionStart = 0
        Me.searchTxt.ShortcutsEnabled = True
        Me.searchTxt.Size = New System.Drawing.Size(145, 23)
        Me.searchTxt.TabIndex = 15
        Me.MetroToolTip1.SetToolTip(Me.searchTxt, "Enter customer name")
        Me.searchTxt.UseSelectable = True
        Me.searchTxt.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.searchTxt.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(715, 365)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(158, 35)
        Me.btnUpdate.TabIndex = 24
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseSelectable = True
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(715, 406)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(158, 35)
        Me.btnInsert.TabIndex = 25
        Me.btnInsert.Text = "Add A Customer"
        Me.btnInsert.UseSelectable = True
        '
        'passwordTxt
        '
        '
        '
        '
        Me.passwordTxt.CustomButton.Image = Nothing
        Me.passwordTxt.CustomButton.Location = New System.Drawing.Point(136, 1)
        Me.passwordTxt.CustomButton.Name = ""
        Me.passwordTxt.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.passwordTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.passwordTxt.CustomButton.TabIndex = 1
        Me.passwordTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.passwordTxt.CustomButton.UseSelectable = True
        Me.passwordTxt.CustomButton.Visible = False
        Me.passwordTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "cust_password", True))
        Me.passwordTxt.Lines = New String(-1) {}
        Me.passwordTxt.Location = New System.Drawing.Point(496, 418)
        Me.passwordTxt.MaxLength = 15
        Me.passwordTxt.Name = "passwordTxt"
        Me.passwordTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.passwordTxt.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.passwordTxt.SelectedText = ""
        Me.passwordTxt.SelectionLength = 0
        Me.passwordTxt.SelectionStart = 0
        Me.passwordTxt.ShortcutsEnabled = True
        Me.passwordTxt.Size = New System.Drawing.Size(158, 23)
        Me.passwordTxt.TabIndex = 14
        Me.MetroToolTip1.SetToolTip(Me.passwordTxt, "Password")
        Me.passwordTxt.UseSelectable = True
        Me.passwordTxt.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.passwordTxt.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.Location = New System.Drawing.Point(399, 422)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(63, 19)
        Me.MetroLabel10.TabIndex = 19
        Me.MetroLabel10.Text = "Password"
        '
        'MetroLabel12
        '
        Me.MetroLabel12.AutoSize = True
        Me.MetroLabel12.Location = New System.Drawing.Point(389, 462)
        Me.MetroLabel12.Name = "MetroLabel12"
        Me.MetroLabel12.Size = New System.Drawing.Size(143, 19)
        Me.MetroLabel12.TabIndex = 26
        Me.MetroLabel12.Text = "Search By Customer ID"
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
        Me.txtSearchID.Location = New System.Drawing.Point(538, 458)
        Me.txtSearchID.MaxLength = 32767
        Me.txtSearchID.Name = "txtSearchID"
        Me.txtSearchID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearchID.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSearchID.SelectedText = ""
        Me.txtSearchID.SelectionLength = 0
        Me.txtSearchID.SelectionStart = 0
        Me.txtSearchID.ShortcutsEnabled = True
        Me.txtSearchID.Size = New System.Drawing.Size(145, 23)
        Me.txtSearchID.TabIndex = 27
        Me.MetroToolTip1.SetToolTip(Me.txtSearchID, "Enter customer ID")
        Me.txtSearchID.UseSelectable = True
        Me.txtSearchID.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSearchID.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroToolTip1
        '
        Me.MetroToolTip1.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroToolTip1.StyleManager = Nothing
        Me.MetroToolTip1.Theme = MetroFramework.MetroThemeStyle.[Default]
        '
        'CUSTOMERBindingSource
        '
        Me.CUSTOMERBindingSource.DataMember = "CUSTOMER"
        Me.CUSTOMERBindingSource.DataSource = Me.DSSystem
        '
        'DSSystem
        '
        Me.DSSystem.DataSetName = "DSSystem"
        Me.DSSystem.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerIDDataGridViewTextBoxColumn
        '
        Me.CustomerIDDataGridViewTextBoxColumn.DataPropertyName = "customer_ID"
        Me.CustomerIDDataGridViewTextBoxColumn.HeaderText = "Customer ID"
        Me.CustomerIDDataGridViewTextBoxColumn.Name = "CustomerIDDataGridViewTextBoxColumn"
        Me.CustomerIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CustnameDataGridViewTextBoxColumn
        '
        Me.CustnameDataGridViewTextBoxColumn.DataPropertyName = "cust_name"
        Me.CustnameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.CustnameDataGridViewTextBoxColumn.Name = "CustnameDataGridViewTextBoxColumn"
        Me.CustnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CustsurnameDataGridViewTextBoxColumn
        '
        Me.CustsurnameDataGridViewTextBoxColumn.DataPropertyName = "cust_surname"
        Me.CustsurnameDataGridViewTextBoxColumn.HeaderText = "Surname"
        Me.CustsurnameDataGridViewTextBoxColumn.Name = "CustsurnameDataGridViewTextBoxColumn"
        Me.CustsurnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CustnumberDataGridViewTextBoxColumn
        '
        Me.CustnumberDataGridViewTextBoxColumn.DataPropertyName = "cust_number"
        Me.CustnumberDataGridViewTextBoxColumn.HeaderText = "Number"
        Me.CustnumberDataGridViewTextBoxColumn.Name = "CustnumberDataGridViewTextBoxColumn"
        Me.CustnumberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CustemailDataGridViewTextBoxColumn
        '
        Me.CustemailDataGridViewTextBoxColumn.DataPropertyName = "cust_email"
        Me.CustemailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.CustemailDataGridViewTextBoxColumn.Name = "CustemailDataGridViewTextBoxColumn"
        Me.CustemailDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CustaddressDataGridViewTextBoxColumn
        '
        Me.CustaddressDataGridViewTextBoxColumn.DataPropertyName = "cust_address"
        Me.CustaddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.CustaddressDataGridViewTextBoxColumn.Name = "CustaddressDataGridViewTextBoxColumn"
        Me.CustaddressDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CustsuburbDataGridViewTextBoxColumn
        '
        Me.CustsuburbDataGridViewTextBoxColumn.DataPropertyName = "cust_suburb"
        Me.CustsuburbDataGridViewTextBoxColumn.HeaderText = "Suburb"
        Me.CustsuburbDataGridViewTextBoxColumn.Name = "CustsuburbDataGridViewTextBoxColumn"
        Me.CustsuburbDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CustcityDataGridViewTextBoxColumn
        '
        Me.CustcityDataGridViewTextBoxColumn.DataPropertyName = "cust_city"
        Me.CustcityDataGridViewTextBoxColumn.HeaderText = "City"
        Me.CustcityDataGridViewTextBoxColumn.Name = "CustcityDataGridViewTextBoxColumn"
        Me.CustcityDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CustprovinceDataGridViewTextBoxColumn
        '
        Me.CustprovinceDataGridViewTextBoxColumn.DataPropertyName = "cust_province"
        Me.CustprovinceDataGridViewTextBoxColumn.HeaderText = "Province"
        Me.CustprovinceDataGridViewTextBoxColumn.Name = "CustprovinceDataGridViewTextBoxColumn"
        Me.CustprovinceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CustpostalcodeDataGridViewTextBoxColumn
        '
        Me.CustpostalcodeDataGridViewTextBoxColumn.DataPropertyName = "cust_postal_code"
        Me.CustpostalcodeDataGridViewTextBoxColumn.HeaderText = "Postal Code"
        Me.CustpostalcodeDataGridViewTextBoxColumn.Name = "CustpostalcodeDataGridViewTextBoxColumn"
        Me.CustpostalcodeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CustpasswordDataGridViewTextBoxColumn
        '
        Me.CustpasswordDataGridViewTextBoxColumn.DataPropertyName = "cust_password"
        Me.CustpasswordDataGridViewTextBoxColumn.HeaderText = "Password"
        Me.CustpasswordDataGridViewTextBoxColumn.Name = "CustpasswordDataGridViewTextBoxColumn"
        Me.CustpasswordDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CUSTOMERTableAdapter
        '
        Me.CUSTOMERTableAdapter.ClearBeforeFill = True
        '
        'customerPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.txtSearchID)
        Me.Controls.Add(Me.MetroLabel12)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.searchTxt)
        Me.Controls.Add(Me.MetroLabel11)
        Me.Controls.Add(Me.passwordTxt)
        Me.Controls.Add(Me.MetroLabel10)
        Me.Controls.Add(Me.postalTxt)
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
        Me.Controls.Add(Me.surnameTxt)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.CustomerDataGridView)
        Me.Name = "customerPanel"
        Me.Size = New System.Drawing.Size(923, 490)
        CType(Me.CustomerDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CUSTOMERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSSystem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CustomerDataGridView As DataGridView
	Friend WithEvents CUSTOMERBindingSource As BindingSource
	Friend WithEvents DSSystem As DSSystem
	Friend WithEvents CUSTOMERTableAdapter As DSSystemTableAdapters.CUSTOMERTableAdapter
	Friend WithEvents CustomerIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents CustnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents CustsurnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents CustnumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents CustemailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents CustaddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents CustsuburbDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents CustcityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents CustprovinceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents CustpostalcodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents CustpasswordDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
	Friend WithEvents surnameTxt As MetroFramework.Controls.MetroTextBox
	Friend WithEvents nameTxt As MetroFramework.Controls.MetroTextBox
	Friend WithEvents numberTxt As MetroFramework.Controls.MetroTextBox
	Friend WithEvents emailTxt As MetroFramework.Controls.MetroTextBox
	Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
	Friend WithEvents provinceTxt As MetroFramework.Controls.MetroTextBox
	Friend WithEvents cityTxt As MetroFramework.Controls.MetroTextBox
	Friend WithEvents suburbTxt As MetroFramework.Controls.MetroTextBox
	Friend WithEvents addressTxt As MetroFramework.Controls.MetroTextBox
	Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
	Friend WithEvents postalTxt As MetroFramework.Controls.MetroTextBox
	Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
	Friend WithEvents searchTxt As MetroFramework.Controls.MetroTextBox
	Friend WithEvents btnUpdate As MetroFramework.Controls.MetroButton
	Friend WithEvents btnInsert As MetroFramework.Controls.MetroButton
	Friend WithEvents passwordTxt As MetroFramework.Controls.MetroTextBox
	Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel12 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtSearchID As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroToolTip1 As MetroFramework.Components.MetroToolTip
End Class
