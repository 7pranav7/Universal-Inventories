<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class saleView
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
        Me.SALEDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SALEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSSystem = New UniversalInventories.DSSystem()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JOINT_SALE_PRODUCTDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JOINT_SALE_PRODUCTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.JOINT_EMPLOYEE_SALEDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.emp_surname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JOINT_EMPLOYEE_SALEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.lblEmp = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.lblPurchaseType = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.DateTime = New MetroFramework.Controls.MetroDateTime()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.txtSaleID = New MetroFramework.Controls.MetroTextBox()
        Me.btnReset = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.FromDateTime = New MetroFramework.Controls.MetroDateTime()
        Me.ToDateTime = New MetroFramework.Controls.MetroDateTime()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.btnFilter = New MetroFramework.Controls.MetroButton()
        Me.btnReset2 = New MetroFramework.Controls.MetroButton()
        Me.SALETableAdapter = New UniversalInventories.DSSystemTableAdapters.SALETableAdapter()
        Me.TableAdapterManager = New UniversalInventories.DSSystemTableAdapters.TableAdapterManager()
        Me.JOINT_SALE_PRODUCTTableAdapter = New UniversalInventories.DSSystemTableAdapters.JOINT_SALE_PRODUCTTableAdapter()
        Me.JOINT_EMPLOYEE_SALETableAdapter = New UniversalInventories.DSSystemTableAdapters.JOINT_EMPLOYEE_SALETableAdapter()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.txtCost = New MetroFramework.Controls.MetroTextBox()
        Me.txtProfit = New MetroFramework.Controls.MetroTextBox()
        Me.txtSaleTotal = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.lblCustomerID = New MetroFramework.Controls.MetroLabel()
        Me.lblCustIDText = New MetroFramework.Controls.MetroLabel()
        Me.CustomerTableAdapter = New UniversalInventories.DSSystemTableAdapters.CUSTOMERTableAdapter()
        Me.lblStatus = New MetroFramework.Controls.MetroLabel()
        Me.lblStatusText = New MetroFramework.Controls.MetroLabel()
        Me.cbViewOrdersOnly = New MetroFramework.Controls.MetroCheckBox()
        Me.MetroToolTip1 = New MetroFramework.Components.MetroToolTip()
        CType(Me.SALEDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SALEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSSystem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JOINT_SALE_PRODUCTDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JOINT_SALE_PRODUCTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JOINT_EMPLOYEE_SALEDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JOINT_EMPLOYEE_SALEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SALEDataGridView
        '
        Me.SALEDataGridView.AllowUserToAddRows = False
        Me.SALEDataGridView.AllowUserToDeleteRows = False
        Me.SALEDataGridView.AutoGenerateColumns = False
        Me.SALEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SALEDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewCheckBoxColumn2})
        Me.SALEDataGridView.DataSource = Me.SALEBindingSource
        Me.SALEDataGridView.Location = New System.Drawing.Point(4, 3)
        Me.SALEDataGridView.MultiSelect = False
        Me.SALEDataGridView.Name = "SALEDataGridView"
        Me.SALEDataGridView.ReadOnly = True
        Me.SALEDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.SALEDataGridView.Size = New System.Drawing.Size(406, 296)
        Me.SALEDataGridView.TabIndex = 1
        Me.MetroToolTip1.SetToolTip(Me.SALEDataGridView, "Sale")
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "sale_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Sale ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 73
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "sale_date"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 72
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "total_amount"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Sale Total"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 78
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "isOnlineSale"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "isOnlineSale"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        Me.DataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewCheckBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewCheckBoxColumn1.Width = 70
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "isDelivery"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "isDelivery"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        Me.DataGridViewCheckBoxColumn2.ReadOnly = True
        Me.DataGridViewCheckBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewCheckBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewCheckBoxColumn2.Width = 70
        '
        'SALEBindingSource
        '
        Me.SALEBindingSource.DataMember = "SALE"
        Me.SALEBindingSource.DataSource = Me.DSSystem
        '
        'DSSystem
        '
        Me.DSSystem.DataSetName = "DSSystem"
        Me.DSSystem.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "product_ID"
        Me.DataGridViewTextBoxColumn4.HeaderText = "product_ID"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "sale_ID"
        Me.DataGridViewTextBoxColumn5.HeaderText = "sale_ID"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "item_price"
        Me.DataGridViewTextBoxColumn6.HeaderText = "item_price"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "item_quantity"
        Me.DataGridViewTextBoxColumn7.HeaderText = "item_quantity"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "subtotal"
        Me.DataGridViewTextBoxColumn8.HeaderText = "subtotal"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "cost_price_per_unit"
        Me.DataGridViewTextBoxColumn9.HeaderText = "cost_price_per_unit"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'JOINT_SALE_PRODUCTDataGridView
        '
        Me.JOINT_SALE_PRODUCTDataGridView.AllowUserToAddRows = False
        Me.JOINT_SALE_PRODUCTDataGridView.AllowUserToDeleteRows = False
        Me.JOINT_SALE_PRODUCTDataGridView.AutoGenerateColumns = False
        Me.JOINT_SALE_PRODUCTDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.JOINT_SALE_PRODUCTDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.Column1, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14})
        Me.JOINT_SALE_PRODUCTDataGridView.DataSource = Me.JOINT_SALE_PRODUCTBindingSource
        Me.JOINT_SALE_PRODUCTDataGridView.Location = New System.Drawing.Point(415, 46)
        Me.JOINT_SALE_PRODUCTDataGridView.MultiSelect = False
        Me.JOINT_SALE_PRODUCTDataGridView.Name = "JOINT_SALE_PRODUCTDataGridView"
        Me.JOINT_SALE_PRODUCTDataGridView.ReadOnly = True
        Me.JOINT_SALE_PRODUCTDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.JOINT_SALE_PRODUCTDataGridView.Size = New System.Drawing.Size(503, 253)
        Me.JOINT_SALE_PRODUCTDataGridView.TabIndex = 2
        Me.MetroToolTip1.SetToolTip(Me.JOINT_SALE_PRODUCTDataGridView, "Sale items")
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "product_ID"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Product ID"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 81
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "product_name"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 118
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "cost_price_per_unit"
        Me.Column1.HeaderText = "Cost Price"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 81
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "item_price"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Price"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Width = 60
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "item_quantity"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Quantity"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Width = 60
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "subtotal"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Subtotal"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Width = 60
        '
        'JOINT_SALE_PRODUCTBindingSource
        '
        Me.JOINT_SALE_PRODUCTBindingSource.DataMember = "JOINT_SALE_PRODUCT"
        Me.JOINT_SALE_PRODUCTBindingSource.DataSource = Me.DSSystem
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(415, 18)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(92, 25)
        Me.MetroLabel1.TabIndex = 3
        Me.MetroLabel1.Text = "Sale Items:"
        '
        'JOINT_EMPLOYEE_SALEDataGridView
        '
        Me.JOINT_EMPLOYEE_SALEDataGridView.AllowUserToAddRows = False
        Me.JOINT_EMPLOYEE_SALEDataGridView.AllowUserToDeleteRows = False
        Me.JOINT_EMPLOYEE_SALEDataGridView.AutoGenerateColumns = False
        Me.JOINT_EMPLOYEE_SALEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.JOINT_EMPLOYEE_SALEDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn15, Me.emp_surname, Me.DataGridViewTextBoxColumn16})
        Me.JOINT_EMPLOYEE_SALEDataGridView.DataSource = Me.JOINT_EMPLOYEE_SALEBindingSource
        Me.JOINT_EMPLOYEE_SALEDataGridView.Enabled = False
        Me.JOINT_EMPLOYEE_SALEDataGridView.Location = New System.Drawing.Point(1064, 46)
        Me.JOINT_EMPLOYEE_SALEDataGridView.MultiSelect = False
        Me.JOINT_EMPLOYEE_SALEDataGridView.Name = "JOINT_EMPLOYEE_SALEDataGridView"
        Me.JOINT_EMPLOYEE_SALEDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.JOINT_EMPLOYEE_SALEDataGridView.Size = New System.Drawing.Size(21, 21)
        Me.JOINT_EMPLOYEE_SALEDataGridView.TabIndex = 3
        Me.JOINT_EMPLOYEE_SALEDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "emp_name"
        Me.DataGridViewTextBoxColumn15.HeaderText = "emp_name"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'emp_surname
        '
        Me.emp_surname.DataPropertyName = "emp_surname"
        Me.emp_surname.HeaderText = "emp_surname"
        Me.emp_surname.Name = "emp_surname"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "emp_ID"
        Me.DataGridViewTextBoxColumn16.HeaderText = "emp_ID"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        '
        'JOINT_EMPLOYEE_SALEBindingSource
        '
        Me.JOINT_EMPLOYEE_SALEBindingSource.DataMember = "JOINT_EMPLOYEE_SALE"
        Me.JOINT_EMPLOYEE_SALEBindingSource.DataSource = Me.DSSystem
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel2.Location = New System.Drawing.Point(706, 28)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(90, 15)
        Me.MetroLabel2.TabIndex = 4
        Me.MetroLabel2.Text = "Sale Handled By:"
        '
        'lblEmp
        '
        Me.lblEmp.AutoSize = True
        Me.lblEmp.FontSize = MetroFramework.MetroLabelSize.Small
        Me.lblEmp.Location = New System.Drawing.Point(802, 28)
        Me.lblEmp.Name = "lblEmp"
        Me.lblEmp.Size = New System.Drawing.Size(30, 15)
        Me.lblEmp.TabIndex = 5
        Me.lblEmp.Text = "emp"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel3.Location = New System.Drawing.Point(674, 302)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(81, 15)
        Me.MetroLabel3.TabIndex = 6
        Me.MetroLabel3.Text = "Purchase Type:"
        '
        'lblPurchaseType
        '
        Me.lblPurchaseType.AutoSize = True
        Me.lblPurchaseType.FontSize = MetroFramework.MetroLabelSize.Small
        Me.lblPurchaseType.Location = New System.Drawing.Point(753, 302)
        Me.lblPurchaseType.Name = "lblPurchaseType"
        Me.lblPurchaseType.Size = New System.Drawing.Size(78, 15)
        Me.lblPurchaseType.TabIndex = 7
        Me.lblPurchaseType.Text = "Purchase Type"
        Me.lblPurchaseType.UseCustomForeColor = True
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(16, 329)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(110, 19)
        Me.MetroLabel4.TabIndex = 8
        Me.MetroLabel4.Text = "Search by Sale ID"
        '
        'DateTime
        '
        Me.DateTime.Location = New System.Drawing.Point(148, 368)
        Me.DateTime.MinimumSize = New System.Drawing.Size(0, 29)
        Me.DateTime.Name = "DateTime"
        Me.DateTime.Size = New System.Drawing.Size(200, 29)
        Me.DateTime.TabIndex = 12
        Me.MetroToolTip1.SetToolTip(Me.DateTime, "Choose date")
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(16, 373)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(97, 19)
        Me.MetroLabel5.TabIndex = 10
        Me.MetroLabel5.Text = "Search by Date"
        '
        'txtSaleID
        '
        '
        '
        '
        Me.txtSaleID.CustomButton.Image = Nothing
        Me.txtSaleID.CustomButton.Location = New System.Drawing.Point(178, 1)
        Me.txtSaleID.CustomButton.Name = ""
        Me.txtSaleID.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtSaleID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSaleID.CustomButton.TabIndex = 1
        Me.txtSaleID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSaleID.CustomButton.UseSelectable = True
        Me.txtSaleID.CustomButton.Visible = False
        Me.txtSaleID.Lines = New String(-1) {}
        Me.txtSaleID.Location = New System.Drawing.Point(148, 325)
        Me.txtSaleID.MaxLength = 32767
        Me.txtSaleID.Name = "txtSaleID"
        Me.txtSaleID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSaleID.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSaleID.SelectedText = ""
        Me.txtSaleID.SelectionLength = 0
        Me.txtSaleID.SelectionStart = 0
        Me.txtSaleID.ShortcutsEnabled = True
        Me.txtSaleID.Size = New System.Drawing.Size(200, 23)
        Me.txtSaleID.TabIndex = 11
        Me.MetroToolTip1.SetToolTip(Me.txtSaleID, "Enter sale ID")
        Me.txtSaleID.UseSelectable = True
        Me.txtSaleID.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSaleID.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(367, 368)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 29)
        Me.btnReset.TabIndex = 13
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseSelectable = True
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(16, 417)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(90, 19)
        Me.MetroLabel6.TabIndex = 13
        Me.MetroLabel6.Text = "Filter by Date:"
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(16, 456)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(41, 19)
        Me.MetroLabel7.TabIndex = 14
        Me.MetroLabel7.Text = "From"
        '
        'FromDateTime
        '
        Me.FromDateTime.Location = New System.Drawing.Point(63, 451)
        Me.FromDateTime.MinimumSize = New System.Drawing.Size(0, 29)
        Me.FromDateTime.Name = "FromDateTime"
        Me.FromDateTime.Size = New System.Drawing.Size(200, 29)
        Me.FromDateTime.TabIndex = 14
        Me.MetroToolTip1.SetToolTip(Me.FromDateTime, "Choose date")
        '
        'ToDateTime
        '
        Me.ToDateTime.Location = New System.Drawing.Point(297, 451)
        Me.ToDateTime.MinimumSize = New System.Drawing.Size(0, 29)
        Me.ToDateTime.Name = "ToDateTime"
        Me.ToDateTime.Size = New System.Drawing.Size(200, 29)
        Me.ToDateTime.TabIndex = 15
        Me.MetroToolTip1.SetToolTip(Me.ToDateTime, "Choose date")
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(269, 456)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(22, 19)
        Me.MetroLabel8.TabIndex = 16
        Me.MetroLabel8.Text = "To"
        '
        'btnFilter
        '
        Me.btnFilter.Location = New System.Drawing.Point(503, 451)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(75, 29)
        Me.btnFilter.TabIndex = 16
        Me.btnFilter.Text = "Filter"
        Me.btnFilter.UseSelectable = True
        '
        'btnReset2
        '
        Me.btnReset2.Location = New System.Drawing.Point(584, 451)
        Me.btnReset2.Name = "btnReset2"
        Me.btnReset2.Size = New System.Drawing.Size(75, 29)
        Me.btnReset2.TabIndex = 17
        Me.btnReset2.Text = "Reset"
        Me.btnReset2.UseSelectable = True
        '
        'SALETableAdapter
        '
        Me.SALETableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CUSTOMERTableAdapter = Nothing
        Me.TableAdapterManager.EMPLOYEETableAdapter = Nothing
        Me.TableAdapterManager.PRODUCT_SUPPLIERTableAdapter = Nothing
        Me.TableAdapterManager.PRODUCTTableAdapter = Nothing
        Me.TableAdapterManager.SALE_ITEMTableAdapter = Nothing
        Me.TableAdapterManager.SALETableAdapter = Me.SALETableAdapter
        Me.TableAdapterManager.SUPPLIERTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = UniversalInventories.DSSystemTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'JOINT_SALE_PRODUCTTableAdapter
        '
        Me.JOINT_SALE_PRODUCTTableAdapter.ClearBeforeFill = True
        '
        'JOINT_EMPLOYEE_SALETableAdapter
        '
        Me.JOINT_EMPLOYEE_SALETableAdapter.ClearBeforeFill = True
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(610, 392)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(102, 19)
        Me.MetroLabel9.TabIndex = 20
        Me.MetroLabel9.Text = "Profit from Sale"
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.Location = New System.Drawing.Point(610, 333)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(79, 19)
        Me.MetroLabel10.TabIndex = 21
        Me.MetroLabel10.Text = "Cost of Sale"
        '
        'txtCost
        '
        '
        '
        '
        Me.txtCost.CustomButton.Image = Nothing
        Me.txtCost.CustomButton.Location = New System.Drawing.Point(94, 1)
        Me.txtCost.CustomButton.Name = ""
        Me.txtCost.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtCost.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCost.CustomButton.TabIndex = 1
        Me.txtCost.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCost.CustomButton.UseSelectable = True
        Me.txtCost.CustomButton.Visible = False
        Me.txtCost.Lines = New String(-1) {}
        Me.txtCost.Location = New System.Drawing.Point(740, 329)
        Me.txtCost.MaxLength = 32767
        Me.txtCost.Name = "txtCost"
        Me.txtCost.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCost.ReadOnly = True
        Me.txtCost.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCost.SelectedText = ""
        Me.txtCost.SelectionLength = 0
        Me.txtCost.SelectionStart = 0
        Me.txtCost.ShortcutsEnabled = True
        Me.txtCost.Size = New System.Drawing.Size(116, 23)
        Me.txtCost.TabIndex = 18
        Me.txtCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.MetroToolTip1.SetToolTip(Me.txtCost, "Cost")
        Me.txtCost.UseSelectable = True
        Me.txtCost.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtCost.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtProfit
        '
        '
        '
        '
        Me.txtProfit.CustomButton.Image = Nothing
        Me.txtProfit.CustomButton.Location = New System.Drawing.Point(94, 1)
        Me.txtProfit.CustomButton.Name = ""
        Me.txtProfit.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtProfit.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtProfit.CustomButton.TabIndex = 1
        Me.txtProfit.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtProfit.CustomButton.UseSelectable = True
        Me.txtProfit.CustomButton.Visible = False
        Me.txtProfit.ForeColor = System.Drawing.Color.LimeGreen
        Me.txtProfit.Lines = New String(-1) {}
        Me.txtProfit.Location = New System.Drawing.Point(740, 388)
        Me.txtProfit.MaxLength = 32767
        Me.txtProfit.Name = "txtProfit"
        Me.txtProfit.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtProfit.ReadOnly = True
        Me.txtProfit.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtProfit.SelectedText = ""
        Me.txtProfit.SelectionLength = 0
        Me.txtProfit.SelectionStart = 0
        Me.txtProfit.ShortcutsEnabled = True
        Me.txtProfit.Size = New System.Drawing.Size(116, 23)
        Me.txtProfit.TabIndex = 20
        Me.txtProfit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.MetroToolTip1.SetToolTip(Me.txtProfit, "Profit")
        Me.txtProfit.UseCustomForeColor = True
        Me.txtProfit.UseSelectable = True
        Me.txtProfit.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtProfit.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtSaleTotal
        '
        '
        '
        '
        Me.txtSaleTotal.CustomButton.Image = Nothing
        Me.txtSaleTotal.CustomButton.Location = New System.Drawing.Point(94, 1)
        Me.txtSaleTotal.CustomButton.Name = ""
        Me.txtSaleTotal.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtSaleTotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSaleTotal.CustomButton.TabIndex = 1
        Me.txtSaleTotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSaleTotal.CustomButton.UseSelectable = True
        Me.txtSaleTotal.CustomButton.Visible = False
        Me.txtSaleTotal.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtSaleTotal.Lines = New String(-1) {}
        Me.txtSaleTotal.Location = New System.Drawing.Point(740, 358)
        Me.txtSaleTotal.MaxLength = 32767
        Me.txtSaleTotal.Name = "txtSaleTotal"
        Me.txtSaleTotal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSaleTotal.ReadOnly = True
        Me.txtSaleTotal.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSaleTotal.SelectedText = ""
        Me.txtSaleTotal.SelectionLength = 0
        Me.txtSaleTotal.SelectionStart = 0
        Me.txtSaleTotal.ShortcutsEnabled = True
        Me.txtSaleTotal.Size = New System.Drawing.Size(116, 23)
        Me.txtSaleTotal.TabIndex = 19
        Me.txtSaleTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.MetroToolTip1.SetToolTip(Me.txtSaleTotal, "Total")
        Me.txtSaleTotal.UseSelectable = True
        Me.txtSaleTotal.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSaleTotal.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.Location = New System.Drawing.Point(610, 362)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(64, 19)
        Me.MetroLabel11.TabIndex = 24
        Me.MetroLabel11.Text = "Sale Total"
        '
        'lblCustomerID
        '
        Me.lblCustomerID.AutoSize = True
        Me.lblCustomerID.FontSize = MetroFramework.MetroLabelSize.Small
        Me.lblCustomerID.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lblCustomerID.ForeColor = System.Drawing.Color.DarkOrange
        Me.lblCustomerID.Location = New System.Drawing.Point(501, 302)
        Me.lblCustomerID.Name = "lblCustomerID"
        Me.lblCustomerID.Size = New System.Drawing.Size(74, 15)
        Me.lblCustomerID.TabIndex = 26
        Me.lblCustomerID.Text = "CustomerID"
        Me.lblCustomerID.UseCustomForeColor = True
        Me.lblCustomerID.Visible = False
        '
        'lblCustIDText
        '
        Me.lblCustIDText.AutoSize = True
        Me.lblCustIDText.FontSize = MetroFramework.MetroLabelSize.Small
        Me.lblCustIDText.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lblCustIDText.ForeColor = System.Drawing.Color.DarkOrange
        Me.lblCustIDText.Location = New System.Drawing.Point(415, 302)
        Me.lblCustIDText.Name = "lblCustIDText"
        Me.lblCustIDText.Size = New System.Drawing.Size(81, 15)
        Me.lblCustIDText.TabIndex = 25
        Me.lblCustIDText.Text = "*Customer ID:"
        Me.lblCustIDText.UseCustomForeColor = True
        Me.lblCustIDText.Visible = False
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.FontSize = MetroFramework.MetroLabelSize.Small
        Me.lblStatus.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lblStatus.ForeColor = System.Drawing.Color.DarkOrange
        Me.lblStatus.Location = New System.Drawing.Point(502, 319)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(68, 15)
        Me.lblStatus.TabIndex = 28
        Me.lblStatus.Text = "Completed"
        Me.lblStatus.UseCustomForeColor = True
        Me.lblStatus.Visible = False
        '
        'lblStatusText
        '
        Me.lblStatusText.AutoSize = True
        Me.lblStatusText.FontSize = MetroFramework.MetroLabelSize.Small
        Me.lblStatusText.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lblStatusText.ForeColor = System.Drawing.Color.DarkOrange
        Me.lblStatusText.Location = New System.Drawing.Point(416, 319)
        Me.lblStatusText.Name = "lblStatusText"
        Me.lblStatusText.Size = New System.Drawing.Size(47, 15)
        Me.lblStatusText.TabIndex = 27
        Me.lblStatusText.Text = "*Status:"
        Me.lblStatusText.UseCustomForeColor = True
        Me.lblStatusText.Visible = False
        '
        'cbViewOrdersOnly
        '
        Me.cbViewOrdersOnly.AutoSize = True
        Me.cbViewOrdersOnly.Location = New System.Drawing.Point(295, 302)
        Me.cbViewOrdersOnly.Name = "cbViewOrdersOnly"
        Me.cbViewOrdersOnly.Size = New System.Drawing.Size(114, 15)
        Me.cbViewOrdersOnly.TabIndex = 30
        Me.cbViewOrdersOnly.Text = "View Orders Only"
        Me.cbViewOrdersOnly.UseSelectable = True
        '
        'MetroToolTip1
        '
        Me.MetroToolTip1.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroToolTip1.StyleManager = Nothing
        Me.MetroToolTip1.Theme = MetroFramework.MetroThemeStyle.[Default]
        '
        'saleView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cbViewOrdersOnly)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lblStatusText)
        Me.Controls.Add(Me.lblCustomerID)
        Me.Controls.Add(Me.lblCustIDText)
        Me.Controls.Add(Me.txtSaleTotal)
        Me.Controls.Add(Me.MetroLabel11)
        Me.Controls.Add(Me.txtProfit)
        Me.Controls.Add(Me.txtCost)
        Me.Controls.Add(Me.MetroLabel10)
        Me.Controls.Add(Me.MetroLabel9)
        Me.Controls.Add(Me.btnReset2)
        Me.Controls.Add(Me.btnFilter)
        Me.Controls.Add(Me.ToDateTime)
        Me.Controls.Add(Me.MetroLabel8)
        Me.Controls.Add(Me.FromDateTime)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.txtSaleID)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.DateTime)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.lblPurchaseType)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.lblEmp)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.JOINT_EMPLOYEE_SALEDataGridView)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.JOINT_SALE_PRODUCTDataGridView)
        Me.Controls.Add(Me.SALEDataGridView)
        Me.Name = "saleView"
        Me.Size = New System.Drawing.Size(923, 490)
        CType(Me.SALEDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SALEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSSystem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JOINT_SALE_PRODUCTDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JOINT_SALE_PRODUCTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JOINT_EMPLOYEE_SALEDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JOINT_EMPLOYEE_SALEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DSSystem As DSSystem
    Friend WithEvents SALEBindingSource As BindingSource
    Friend WithEvents SALETableAdapter As DSSystemTableAdapters.SALETableAdapter
    Friend WithEvents TableAdapterManager As DSSystemTableAdapters.TableAdapterManager
    Friend WithEvents SALEDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents JOINT_SALE_PRODUCTBindingSource As BindingSource
    Friend WithEvents JOINT_SALE_PRODUCTTableAdapter As DSSystemTableAdapters.JOINT_SALE_PRODUCTTableAdapter
    Friend WithEvents JOINT_SALE_PRODUCTDataGridView As DataGridView
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents JOINT_EMPLOYEE_SALEBindingSource As BindingSource
    Friend WithEvents JOINT_EMPLOYEE_SALETableAdapter As DSSystemTableAdapters.JOINT_EMPLOYEE_SALETableAdapter
    Friend WithEvents JOINT_EMPLOYEE_SALEDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents emp_surname As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblEmp As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblPurchaseType As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents DateTime As MetroFramework.Controls.MetroDateTime
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtSaleID As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnReset As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents FromDateTime As MetroFramework.Controls.MetroDateTime
    Friend WithEvents ToDateTime As MetroFramework.Controls.MetroDateTime
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnFilter As MetroFramework.Controls.MetroButton
    Friend WithEvents btnReset2 As MetroFramework.Controls.MetroButton
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtCost As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtProfit As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtSaleTotal As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblCustomerID As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblCustIDText As MetroFramework.Controls.MetroLabel
    Friend WithEvents CustomerTableAdapter As DSSystemTableAdapters.CUSTOMERTableAdapter
    Friend WithEvents lblStatus As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblStatusText As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbViewOrdersOnly As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents MetroToolTip1 As MetroFramework.Components.MetroToolTip
End Class
