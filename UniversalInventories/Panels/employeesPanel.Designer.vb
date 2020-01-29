<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class employeesPanel
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
        Me.EmployeeDataGridView = New System.Windows.Forms.DataGridView()
        Me.EmpIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpsurnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpnumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpemailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpaddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpsuburbDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpcityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpprovinceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmppostalcodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmptypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmppasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMPLOYEEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSSystem = New UniversalInventories.DSSystem()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.nameTxt = New MetroFramework.Controls.MetroTextBox()
        Me.surnameTxt = New MetroFramework.Controls.MetroTextBox()
        Me.numberTxt = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.addressTxt = New MetroFramework.Controls.MetroTextBox()
        Me.emailTxt = New MetroFramework.Controls.MetroTextBox()
        Me.suburbTxt = New MetroFramework.Controls.MetroTextBox()
        Me.cityTxt = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel12 = New MetroFramework.Controls.MetroLabel()
        Me.typeTxt = New MetroFramework.Controls.MetroTextBox()
        Me.postalTxt = New MetroFramework.Controls.MetroTextBox()
        Me.provinceTxt = New MetroFramework.Controls.MetroTextBox()
        Me.passwordTxt = New MetroFramework.Controls.MetroTextBox()
        Me.btnUpdate = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel13 = New MetroFramework.Controls.MetroLabel()
        Me.searchTxt = New MetroFramework.Controls.MetroTextBox()
        Me.btnInsert = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.searchByNameTxt = New MetroFramework.Controls.MetroTextBox()
        Me.EMPLOYEETableAdapter = New UniversalInventories.DSSystemTableAdapters.EMPLOYEETableAdapter()
        Me.MetroToolTip1 = New MetroFramework.Components.MetroToolTip()
        CType(Me.EmployeeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMPLOYEEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSSystem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EmployeeDataGridView
        '
        Me.EmployeeDataGridView.AllowUserToAddRows = False
        Me.EmployeeDataGridView.AllowUserToDeleteRows = False
        Me.EmployeeDataGridView.AutoGenerateColumns = False
        Me.EmployeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmployeeDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmpIDDataGridViewTextBoxColumn, Me.EmpnameDataGridViewTextBoxColumn, Me.EmpsurnameDataGridViewTextBoxColumn, Me.EmpnumberDataGridViewTextBoxColumn, Me.EmpemailDataGridViewTextBoxColumn, Me.EmpaddressDataGridViewTextBoxColumn, Me.EmpsuburbDataGridViewTextBoxColumn, Me.EmpcityDataGridViewTextBoxColumn, Me.EmpprovinceDataGridViewTextBoxColumn, Me.EmppostalcodeDataGridViewTextBoxColumn, Me.EmptypeDataGridViewTextBoxColumn, Me.EmppasswordDataGridViewTextBoxColumn})
        Me.EmployeeDataGridView.DataSource = Me.EMPLOYEEBindingSource
        Me.EmployeeDataGridView.Location = New System.Drawing.Point(1, 2)
        Me.EmployeeDataGridView.Name = "EmployeeDataGridView"
        Me.EmployeeDataGridView.ReadOnly = True
        Me.EmployeeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.EmployeeDataGridView.Size = New System.Drawing.Size(920, 259)
        Me.EmployeeDataGridView.TabIndex = 0
        Me.MetroToolTip1.SetToolTip(Me.EmployeeDataGridView, "Employees")
        '
        'EmpIDDataGridViewTextBoxColumn
        '
        Me.EmpIDDataGridViewTextBoxColumn.DataPropertyName = "emp_ID"
        Me.EmpIDDataGridViewTextBoxColumn.HeaderText = "Employee ID"
        Me.EmpIDDataGridViewTextBoxColumn.Name = "EmpIDDataGridViewTextBoxColumn"
        Me.EmpIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmpnameDataGridViewTextBoxColumn
        '
        Me.EmpnameDataGridViewTextBoxColumn.DataPropertyName = "emp_name"
        Me.EmpnameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.EmpnameDataGridViewTextBoxColumn.Name = "EmpnameDataGridViewTextBoxColumn"
        Me.EmpnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmpsurnameDataGridViewTextBoxColumn
        '
        Me.EmpsurnameDataGridViewTextBoxColumn.DataPropertyName = "emp_surname"
        Me.EmpsurnameDataGridViewTextBoxColumn.HeaderText = "Surname"
        Me.EmpsurnameDataGridViewTextBoxColumn.Name = "EmpsurnameDataGridViewTextBoxColumn"
        Me.EmpsurnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmpnumberDataGridViewTextBoxColumn
        '
        Me.EmpnumberDataGridViewTextBoxColumn.DataPropertyName = "emp_number"
        Me.EmpnumberDataGridViewTextBoxColumn.HeaderText = "Number"
        Me.EmpnumberDataGridViewTextBoxColumn.Name = "EmpnumberDataGridViewTextBoxColumn"
        Me.EmpnumberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmpemailDataGridViewTextBoxColumn
        '
        Me.EmpemailDataGridViewTextBoxColumn.DataPropertyName = "emp_email"
        Me.EmpemailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmpemailDataGridViewTextBoxColumn.Name = "EmpemailDataGridViewTextBoxColumn"
        Me.EmpemailDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmpaddressDataGridViewTextBoxColumn
        '
        Me.EmpaddressDataGridViewTextBoxColumn.DataPropertyName = "emp_address"
        Me.EmpaddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.EmpaddressDataGridViewTextBoxColumn.Name = "EmpaddressDataGridViewTextBoxColumn"
        Me.EmpaddressDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmpsuburbDataGridViewTextBoxColumn
        '
        Me.EmpsuburbDataGridViewTextBoxColumn.DataPropertyName = "emp_suburb"
        Me.EmpsuburbDataGridViewTextBoxColumn.HeaderText = "Suburb"
        Me.EmpsuburbDataGridViewTextBoxColumn.Name = "EmpsuburbDataGridViewTextBoxColumn"
        Me.EmpsuburbDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmpcityDataGridViewTextBoxColumn
        '
        Me.EmpcityDataGridViewTextBoxColumn.DataPropertyName = "emp_city"
        Me.EmpcityDataGridViewTextBoxColumn.HeaderText = "City"
        Me.EmpcityDataGridViewTextBoxColumn.Name = "EmpcityDataGridViewTextBoxColumn"
        Me.EmpcityDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmpprovinceDataGridViewTextBoxColumn
        '
        Me.EmpprovinceDataGridViewTextBoxColumn.DataPropertyName = "emp_province"
        Me.EmpprovinceDataGridViewTextBoxColumn.HeaderText = "Province"
        Me.EmpprovinceDataGridViewTextBoxColumn.Name = "EmpprovinceDataGridViewTextBoxColumn"
        Me.EmpprovinceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmppostalcodeDataGridViewTextBoxColumn
        '
        Me.EmppostalcodeDataGridViewTextBoxColumn.DataPropertyName = "emp_postal_code"
        Me.EmppostalcodeDataGridViewTextBoxColumn.HeaderText = "Postal Code"
        Me.EmppostalcodeDataGridViewTextBoxColumn.Name = "EmppostalcodeDataGridViewTextBoxColumn"
        Me.EmppostalcodeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmptypeDataGridViewTextBoxColumn
        '
        Me.EmptypeDataGridViewTextBoxColumn.DataPropertyName = "emp_type"
        Me.EmptypeDataGridViewTextBoxColumn.HeaderText = "Employee Type"
        Me.EmptypeDataGridViewTextBoxColumn.Name = "EmptypeDataGridViewTextBoxColumn"
        Me.EmptypeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmppasswordDataGridViewTextBoxColumn
        '
        Me.EmppasswordDataGridViewTextBoxColumn.DataPropertyName = "emp_password"
        Me.EmppasswordDataGridViewTextBoxColumn.HeaderText = "Password"
        Me.EmppasswordDataGridViewTextBoxColumn.Name = "EmppasswordDataGridViewTextBoxColumn"
        Me.EmppasswordDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EMPLOYEEBindingSource
        '
        Me.EMPLOYEEBindingSource.DataMember = "EMPLOYEE"
        Me.EMPLOYEEBindingSource.DataSource = Me.DSSystem
        '
        'DSSystem
        '
        Me.DSSystem.DataSetName = "DSSystem"
        Me.DSSystem.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(18, 289)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(45, 19)
        Me.MetroLabel2.TabIndex = 2
        Me.MetroLabel2.Text = "Name"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(18, 324)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(61, 19)
        Me.MetroLabel3.TabIndex = 3
        Me.MetroLabel3.Text = "Surname"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(18, 359)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(58, 19)
        Me.MetroLabel4.TabIndex = 4
        Me.MetroLabel4.Text = "Number"
        '
        'nameTxt
        '
        '
        '
        '
        Me.nameTxt.CustomButton.Image = Nothing
        Me.nameTxt.CustomButton.Location = New System.Drawing.Point(104, 1)
        Me.nameTxt.CustomButton.Name = ""
        Me.nameTxt.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.nameTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.nameTxt.CustomButton.TabIndex = 1
        Me.nameTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.nameTxt.CustomButton.UseSelectable = True
        Me.nameTxt.CustomButton.Visible = False
        Me.nameTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLOYEEBindingSource, "emp_name", True))
        Me.nameTxt.Lines = New String(-1) {}
        Me.nameTxt.Location = New System.Drawing.Point(105, 285)
        Me.nameTxt.MaxLength = 100
        Me.nameTxt.Name = "nameTxt"
        Me.nameTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.nameTxt.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.nameTxt.SelectedText = ""
        Me.nameTxt.SelectionLength = 0
        Me.nameTxt.SelectionStart = 0
        Me.nameTxt.ShortcutsEnabled = True
        Me.nameTxt.Size = New System.Drawing.Size(126, 23)
        Me.nameTxt.TabIndex = 6
        Me.MetroToolTip1.SetToolTip(Me.nameTxt, "Employee name")
        Me.nameTxt.UseSelectable = True
        Me.nameTxt.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.nameTxt.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'surnameTxt
        '
        '
        '
        '
        Me.surnameTxt.CustomButton.Image = Nothing
        Me.surnameTxt.CustomButton.Location = New System.Drawing.Point(104, 1)
        Me.surnameTxt.CustomButton.Name = ""
        Me.surnameTxt.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.surnameTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.surnameTxt.CustomButton.TabIndex = 1
        Me.surnameTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.surnameTxt.CustomButton.UseSelectable = True
        Me.surnameTxt.CustomButton.Visible = False
        Me.surnameTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLOYEEBindingSource, "emp_surname", True))
        Me.surnameTxt.Lines = New String(-1) {}
        Me.surnameTxt.Location = New System.Drawing.Point(105, 320)
        Me.surnameTxt.MaxLength = 100
        Me.surnameTxt.Name = "surnameTxt"
        Me.surnameTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.surnameTxt.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.surnameTxt.SelectedText = ""
        Me.surnameTxt.SelectionLength = 0
        Me.surnameTxt.SelectionStart = 0
        Me.surnameTxt.ShortcutsEnabled = True
        Me.surnameTxt.Size = New System.Drawing.Size(126, 23)
        Me.surnameTxt.TabIndex = 7
        Me.MetroToolTip1.SetToolTip(Me.surnameTxt, "Employee surname")
        Me.surnameTxt.UseSelectable = True
        Me.surnameTxt.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.surnameTxt.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'numberTxt
        '
        '
        '
        '
        Me.numberTxt.CustomButton.Image = Nothing
        Me.numberTxt.CustomButton.Location = New System.Drawing.Point(104, 1)
        Me.numberTxt.CustomButton.Name = ""
        Me.numberTxt.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.numberTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.numberTxt.CustomButton.TabIndex = 1
        Me.numberTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.numberTxt.CustomButton.UseSelectable = True
        Me.numberTxt.CustomButton.Visible = False
        Me.numberTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLOYEEBindingSource, "emp_number", True))
        Me.numberTxt.Lines = New String(-1) {}
        Me.numberTxt.Location = New System.Drawing.Point(105, 355)
        Me.numberTxt.MaxLength = 10
        Me.numberTxt.Name = "numberTxt"
        Me.numberTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.numberTxt.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.numberTxt.SelectedText = ""
        Me.numberTxt.SelectionLength = 0
        Me.numberTxt.SelectionStart = 0
        Me.numberTxt.ShortcutsEnabled = True
        Me.numberTxt.Size = New System.Drawing.Size(126, 23)
        Me.numberTxt.TabIndex = 8
        Me.MetroToolTip1.SetToolTip(Me.numberTxt, "Number")
        Me.numberTxt.UseSelectable = True
        Me.numberTxt.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.numberTxt.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(18, 394)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(41, 19)
        Me.MetroLabel5.TabIndex = 9
        Me.MetroLabel5.Text = "Email"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(287, 289)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(56, 19)
        Me.MetroLabel6.TabIndex = 10
        Me.MetroLabel6.Text = "Address"
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(287, 324)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(51, 19)
        Me.MetroLabel7.TabIndex = 11
        Me.MetroLabel7.Text = "Suburb"
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(287, 359)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(31, 19)
        Me.MetroLabel8.TabIndex = 12
        Me.MetroLabel8.Text = "City"
        '
        'addressTxt
        '
        '
        '
        '
        Me.addressTxt.CustomButton.Image = Nothing
        Me.addressTxt.CustomButton.Location = New System.Drawing.Point(104, 1)
        Me.addressTxt.CustomButton.Name = ""
        Me.addressTxt.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.addressTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.addressTxt.CustomButton.TabIndex = 1
        Me.addressTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.addressTxt.CustomButton.UseSelectable = True
        Me.addressTxt.CustomButton.Visible = False
        Me.addressTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLOYEEBindingSource, "emp_address", True))
        Me.addressTxt.Lines = New String(-1) {}
        Me.addressTxt.Location = New System.Drawing.Point(372, 285)
        Me.addressTxt.MaxLength = 100
        Me.addressTxt.Name = "addressTxt"
        Me.addressTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.addressTxt.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.addressTxt.SelectedText = ""
        Me.addressTxt.SelectionLength = 0
        Me.addressTxt.SelectionStart = 0
        Me.addressTxt.ShortcutsEnabled = True
        Me.addressTxt.Size = New System.Drawing.Size(126, 23)
        Me.addressTxt.TabIndex = 10
        Me.MetroToolTip1.SetToolTip(Me.addressTxt, "Address")
        Me.addressTxt.UseSelectable = True
        Me.addressTxt.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.addressTxt.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'emailTxt
        '
        '
        '
        '
        Me.emailTxt.CustomButton.Image = Nothing
        Me.emailTxt.CustomButton.Location = New System.Drawing.Point(104, 1)
        Me.emailTxt.CustomButton.Name = ""
        Me.emailTxt.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.emailTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.emailTxt.CustomButton.TabIndex = 1
        Me.emailTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.emailTxt.CustomButton.UseSelectable = True
        Me.emailTxt.CustomButton.Visible = False
        Me.emailTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLOYEEBindingSource, "emp_email", True))
        Me.emailTxt.Lines = New String(-1) {}
        Me.emailTxt.Location = New System.Drawing.Point(105, 390)
        Me.emailTxt.MaxLength = 100
        Me.emailTxt.Name = "emailTxt"
        Me.emailTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.emailTxt.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.emailTxt.SelectedText = ""
        Me.emailTxt.SelectionLength = 0
        Me.emailTxt.SelectionStart = 0
        Me.emailTxt.ShortcutsEnabled = True
        Me.emailTxt.Size = New System.Drawing.Size(126, 23)
        Me.emailTxt.TabIndex = 9
        Me.MetroToolTip1.SetToolTip(Me.emailTxt, "Email")
        Me.emailTxt.UseSelectable = True
        Me.emailTxt.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.emailTxt.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'suburbTxt
        '
        '
        '
        '
        Me.suburbTxt.CustomButton.Image = Nothing
        Me.suburbTxt.CustomButton.Location = New System.Drawing.Point(104, 1)
        Me.suburbTxt.CustomButton.Name = ""
        Me.suburbTxt.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.suburbTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.suburbTxt.CustomButton.TabIndex = 1
        Me.suburbTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.suburbTxt.CustomButton.UseSelectable = True
        Me.suburbTxt.CustomButton.Visible = False
        Me.suburbTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLOYEEBindingSource, "emp_suburb", True))
        Me.suburbTxt.Lines = New String(-1) {}
        Me.suburbTxt.Location = New System.Drawing.Point(372, 320)
        Me.suburbTxt.MaxLength = 100
        Me.suburbTxt.Name = "suburbTxt"
        Me.suburbTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.suburbTxt.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.suburbTxt.SelectedText = ""
        Me.suburbTxt.SelectionLength = 0
        Me.suburbTxt.SelectionStart = 0
        Me.suburbTxt.ShortcutsEnabled = True
        Me.suburbTxt.Size = New System.Drawing.Size(126, 23)
        Me.suburbTxt.TabIndex = 11
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
        Me.cityTxt.CustomButton.Location = New System.Drawing.Point(104, 1)
        Me.cityTxt.CustomButton.Name = ""
        Me.cityTxt.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.cityTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.cityTxt.CustomButton.TabIndex = 1
        Me.cityTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.cityTxt.CustomButton.UseSelectable = True
        Me.cityTxt.CustomButton.Visible = False
        Me.cityTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLOYEEBindingSource, "emp_city", True))
        Me.cityTxt.Lines = New String(-1) {}
        Me.cityTxt.Location = New System.Drawing.Point(372, 355)
        Me.cityTxt.MaxLength = 100
        Me.cityTxt.Name = "cityTxt"
        Me.cityTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.cityTxt.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.cityTxt.SelectedText = ""
        Me.cityTxt.SelectionLength = 0
        Me.cityTxt.SelectionStart = 0
        Me.cityTxt.ShortcutsEnabled = True
        Me.cityTxt.Size = New System.Drawing.Size(126, 23)
        Me.cityTxt.TabIndex = 12
        Me.MetroToolTip1.SetToolTip(Me.cityTxt, "City")
        Me.cityTxt.UseSelectable = True
        Me.cityTxt.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.cityTxt.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(287, 394)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(59, 19)
        Me.MetroLabel9.TabIndex = 17
        Me.MetroLabel9.Text = "Province"
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.Location = New System.Drawing.Point(543, 289)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(79, 19)
        Me.MetroLabel10.TabIndex = 18
        Me.MetroLabel10.Text = "Postal Code"
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.Location = New System.Drawing.Point(543, 324)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(98, 19)
        Me.MetroLabel11.TabIndex = 19
        Me.MetroLabel11.Text = "Employee Type"
        '
        'MetroLabel12
        '
        Me.MetroLabel12.AutoSize = True
        Me.MetroLabel12.Location = New System.Drawing.Point(546, 359)
        Me.MetroLabel12.Name = "MetroLabel12"
        Me.MetroLabel12.Size = New System.Drawing.Size(63, 19)
        Me.MetroLabel12.TabIndex = 20
        Me.MetroLabel12.Text = "Password"
        '
        'typeTxt
        '
        '
        '
        '
        Me.typeTxt.CustomButton.Image = Nothing
        Me.typeTxt.CustomButton.Location = New System.Drawing.Point(104, 1)
        Me.typeTxt.CustomButton.Name = ""
        Me.typeTxt.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.typeTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.typeTxt.CustomButton.TabIndex = 1
        Me.typeTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.typeTxt.CustomButton.UseSelectable = True
        Me.typeTxt.CustomButton.Visible = False
        Me.typeTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLOYEEBindingSource, "emp_type", True))
        Me.typeTxt.Lines = New String(-1) {}
        Me.typeTxt.Location = New System.Drawing.Point(657, 320)
        Me.typeTxt.MaxLength = 15
        Me.typeTxt.Name = "typeTxt"
        Me.typeTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.typeTxt.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.typeTxt.SelectedText = ""
        Me.typeTxt.SelectionLength = 0
        Me.typeTxt.SelectionStart = 0
        Me.typeTxt.ShortcutsEnabled = True
        Me.typeTxt.Size = New System.Drawing.Size(126, 23)
        Me.typeTxt.TabIndex = 15
        Me.MetroToolTip1.SetToolTip(Me.typeTxt, "Employee type")
        Me.typeTxt.UseSelectable = True
        Me.typeTxt.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.typeTxt.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'postalTxt
        '
        '
        '
        '
        Me.postalTxt.CustomButton.Image = Nothing
        Me.postalTxt.CustomButton.Location = New System.Drawing.Point(104, 1)
        Me.postalTxt.CustomButton.Name = ""
        Me.postalTxt.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.postalTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.postalTxt.CustomButton.TabIndex = 1
        Me.postalTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.postalTxt.CustomButton.UseSelectable = True
        Me.postalTxt.CustomButton.Visible = False
        Me.postalTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLOYEEBindingSource, "emp_postal_code", True))
        Me.postalTxt.Lines = New String(-1) {}
        Me.postalTxt.Location = New System.Drawing.Point(657, 289)
        Me.postalTxt.MaxLength = 4
        Me.postalTxt.Name = "postalTxt"
        Me.postalTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.postalTxt.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.postalTxt.SelectedText = ""
        Me.postalTxt.SelectionLength = 0
        Me.postalTxt.SelectionStart = 0
        Me.postalTxt.ShortcutsEnabled = True
        Me.postalTxt.Size = New System.Drawing.Size(126, 23)
        Me.postalTxt.TabIndex = 14
        Me.MetroToolTip1.SetToolTip(Me.postalTxt, "Postal code")
        Me.postalTxt.UseSelectable = True
        Me.postalTxt.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.postalTxt.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'provinceTxt
        '
        '
        '
        '
        Me.provinceTxt.CustomButton.Image = Nothing
        Me.provinceTxt.CustomButton.Location = New System.Drawing.Point(104, 1)
        Me.provinceTxt.CustomButton.Name = ""
        Me.provinceTxt.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.provinceTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.provinceTxt.CustomButton.TabIndex = 1
        Me.provinceTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.provinceTxt.CustomButton.UseSelectable = True
        Me.provinceTxt.CustomButton.Visible = False
        Me.provinceTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLOYEEBindingSource, "emp_province", True))
        Me.provinceTxt.Lines = New String(-1) {}
        Me.provinceTxt.Location = New System.Drawing.Point(372, 390)
        Me.provinceTxt.MaxLength = 100
        Me.provinceTxt.Name = "provinceTxt"
        Me.provinceTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.provinceTxt.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.provinceTxt.SelectedText = ""
        Me.provinceTxt.SelectionLength = 0
        Me.provinceTxt.SelectionStart = 0
        Me.provinceTxt.ShortcutsEnabled = True
        Me.provinceTxt.Size = New System.Drawing.Size(126, 23)
        Me.provinceTxt.TabIndex = 13
        Me.MetroToolTip1.SetToolTip(Me.provinceTxt, "Province")
        Me.provinceTxt.UseSelectable = True
        Me.provinceTxt.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.provinceTxt.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'passwordTxt
        '
        '
        '
        '
        Me.passwordTxt.CustomButton.Image = Nothing
        Me.passwordTxt.CustomButton.Location = New System.Drawing.Point(104, 1)
        Me.passwordTxt.CustomButton.Name = ""
        Me.passwordTxt.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.passwordTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.passwordTxt.CustomButton.TabIndex = 1
        Me.passwordTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.passwordTxt.CustomButton.UseSelectable = True
        Me.passwordTxt.CustomButton.Visible = False
        Me.passwordTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLOYEEBindingSource, "emp_password", True))
        Me.passwordTxt.Lines = New String(-1) {}
        Me.passwordTxt.Location = New System.Drawing.Point(657, 355)
        Me.passwordTxt.MaxLength = 15
        Me.passwordTxt.Name = "passwordTxt"
        Me.passwordTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.passwordTxt.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.passwordTxt.SelectedText = ""
        Me.passwordTxt.SelectionLength = 0
        Me.passwordTxt.SelectionStart = 0
        Me.passwordTxt.ShortcutsEnabled = True
        Me.passwordTxt.Size = New System.Drawing.Size(126, 23)
        Me.passwordTxt.TabIndex = 16
        Me.MetroToolTip1.SetToolTip(Me.passwordTxt, "Password")
        Me.passwordTxt.UseSelectable = True
        Me.passwordTxt.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.passwordTxt.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(657, 384)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(126, 35)
        Me.btnUpdate.TabIndex = 17
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseSelectable = True
        '
        'MetroLabel13
        '
        Me.MetroLabel13.AutoSize = True
        Me.MetroLabel13.Location = New System.Drawing.Point(397, 455)
        Me.MetroLabel13.Name = "MetroLabel13"
        Me.MetroLabel13.Size = New System.Drawing.Size(144, 19)
        Me.MetroLabel13.TabIndex = 27
        Me.MetroLabel13.Text = "Search Employee By ID"
        '
        'searchTxt
        '
        '
        '
        '
        Me.searchTxt.CustomButton.Image = Nothing
        Me.searchTxt.CustomButton.Location = New System.Drawing.Point(136, 1)
        Me.searchTxt.CustomButton.Name = ""
        Me.searchTxt.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.searchTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.searchTxt.CustomButton.TabIndex = 1
        Me.searchTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.searchTxt.CustomButton.UseSelectable = True
        Me.searchTxt.CustomButton.Visible = False
        Me.searchTxt.Lines = New String(-1) {}
        Me.searchTxt.Location = New System.Drawing.Point(564, 454)
        Me.searchTxt.MaxLength = 32767
        Me.searchTxt.Name = "searchTxt"
        Me.searchTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.searchTxt.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.searchTxt.SelectedText = ""
        Me.searchTxt.SelectionLength = 0
        Me.searchTxt.SelectionStart = 0
        Me.searchTxt.ShortcutsEnabled = True
        Me.searchTxt.Size = New System.Drawing.Size(158, 23)
        Me.searchTxt.TabIndex = 19
        Me.MetroToolTip1.SetToolTip(Me.searchTxt, "Enter employee ID")
        Me.searchTxt.UseSelectable = True
        Me.searchTxt.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.searchTxt.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(768, 445)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(142, 35)
        Me.btnInsert.TabIndex = 20
        Me.btnInsert.Text = "Add An Employee"
        Me.btnInsert.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(18, 455)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(168, 19)
        Me.MetroLabel1.TabIndex = 30
        Me.MetroLabel1.Text = "Search Employee By Name"
        '
        'searchByNameTxt
        '
        '
        '
        '
        Me.searchByNameTxt.CustomButton.Image = Nothing
        Me.searchByNameTxt.CustomButton.Location = New System.Drawing.Point(136, 1)
        Me.searchByNameTxt.CustomButton.Name = ""
        Me.searchByNameTxt.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.searchByNameTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.searchByNameTxt.CustomButton.TabIndex = 1
        Me.searchByNameTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.searchByNameTxt.CustomButton.UseSelectable = True
        Me.searchByNameTxt.CustomButton.Visible = False
        Me.searchByNameTxt.Lines = New String(-1) {}
        Me.searchByNameTxt.Location = New System.Drawing.Point(198, 454)
        Me.searchByNameTxt.MaxLength = 32767
        Me.searchByNameTxt.Name = "searchByNameTxt"
        Me.searchByNameTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.searchByNameTxt.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.searchByNameTxt.SelectedText = ""
        Me.searchByNameTxt.SelectionLength = 0
        Me.searchByNameTxt.SelectionStart = 0
        Me.searchByNameTxt.ShortcutsEnabled = True
        Me.searchByNameTxt.Size = New System.Drawing.Size(158, 23)
        Me.searchByNameTxt.TabIndex = 18
        Me.MetroToolTip1.SetToolTip(Me.searchByNameTxt, "Enter employee name")
        Me.searchByNameTxt.UseSelectable = True
        Me.searchByNameTxt.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.searchByNameTxt.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'EMPLOYEETableAdapter
        '
        Me.EMPLOYEETableAdapter.ClearBeforeFill = True
        '
        'MetroToolTip1
        '
        Me.MetroToolTip1.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroToolTip1.StyleManager = Nothing
        Me.MetroToolTip1.Theme = MetroFramework.MetroThemeStyle.[Default]
        '
        'employeesPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.searchByNameTxt)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.searchTxt)
        Me.Controls.Add(Me.MetroLabel13)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.passwordTxt)
        Me.Controls.Add(Me.provinceTxt)
        Me.Controls.Add(Me.postalTxt)
        Me.Controls.Add(Me.typeTxt)
        Me.Controls.Add(Me.MetroLabel12)
        Me.Controls.Add(Me.MetroLabel11)
        Me.Controls.Add(Me.MetroLabel10)
        Me.Controls.Add(Me.MetroLabel9)
        Me.Controls.Add(Me.cityTxt)
        Me.Controls.Add(Me.suburbTxt)
        Me.Controls.Add(Me.emailTxt)
        Me.Controls.Add(Me.addressTxt)
        Me.Controls.Add(Me.MetroLabel8)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.numberTxt)
        Me.Controls.Add(Me.surnameTxt)
        Me.Controls.Add(Me.nameTxt)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.EmployeeDataGridView)
        Me.Name = "employeesPanel"
        Me.Size = New System.Drawing.Size(923, 490)
        CType(Me.EmployeeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMPLOYEEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSSystem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EmployeeDataGridView As DataGridView
	Friend WithEvents EMPLOYEEBindingSource As BindingSource
	Friend WithEvents DSSystem As DSSystem
	Friend WithEvents EMPLOYEETableAdapter As DSSystemTableAdapters.EMPLOYEETableAdapter
	Friend WithEvents EmpIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents EmpnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents EmpsurnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents EmpnumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents EmpemailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents EmpaddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents EmpsuburbDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents EmpcityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents EmpprovinceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents EmppostalcodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents EmptypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents EmppasswordDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
	Friend WithEvents nameTxt As MetroFramework.Controls.MetroTextBox
	Friend WithEvents surnameTxt As MetroFramework.Controls.MetroTextBox
	Friend WithEvents numberTxt As MetroFramework.Controls.MetroTextBox
	Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
	Friend WithEvents addressTxt As MetroFramework.Controls.MetroTextBox
	Friend WithEvents emailTxt As MetroFramework.Controls.MetroTextBox
	Friend WithEvents suburbTxt As MetroFramework.Controls.MetroTextBox
	Friend WithEvents cityTxt As MetroFramework.Controls.MetroTextBox
	Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel12 As MetroFramework.Controls.MetroLabel
	Friend WithEvents typeTxt As MetroFramework.Controls.MetroTextBox
	Friend WithEvents postalTxt As MetroFramework.Controls.MetroTextBox
	Friend WithEvents provinceTxt As MetroFramework.Controls.MetroTextBox
	Friend WithEvents passwordTxt As MetroFramework.Controls.MetroTextBox
	Friend WithEvents btnUpdate As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel13 As MetroFramework.Controls.MetroLabel
    Friend WithEvents searchTxt As MetroFramework.Controls.MetroTextBox
	Friend WithEvents btnInsert As MetroFramework.Controls.MetroButton
	Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
	Friend WithEvents searchByNameTxt As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroToolTip1 As MetroFramework.Components.MetroToolTip
End Class
