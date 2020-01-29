<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewOrdersPanel
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
        Me.SALEDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SALEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSSystem = New UniversalInventories.DSSystem()
        Me.JOINT_SALE_PRODUCTDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JOINT_SALE_PRODUCTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.SALETableAdapter = New UniversalInventories.DSSystemTableAdapters.SALETableAdapter()
        Me.TableAdapterManager = New UniversalInventories.DSSystemTableAdapters.TableAdapterManager()
        Me.JOINT_SALE_PRODUCTTableAdapter = New UniversalInventories.DSSystemTableAdapters.JOINT_SALE_PRODUCTTableAdapter()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.ListBox = New System.Windows.Forms.ListBox()
        Me.txtEmail = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.txtNumber = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.txtName = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.CustomerTableAdapter = New UniversalInventories.DSSystemTableAdapters.CUSTOMERTableAdapter()
        Me.btnOrder = New MetroFramework.Controls.MetroButton()
        Me.MetroToolTip1 = New MetroFramework.Components.MetroToolTip()
        Me.lblOrderType = New MetroFramework.Controls.MetroLabel()
        CType(Me.SALEDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SALEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSSystem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JOINT_SALE_PRODUCTDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JOINT_SALE_PRODUCTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SALEDataGridView
        '
        Me.SALEDataGridView.AllowUserToAddRows = False
        Me.SALEDataGridView.AllowUserToDeleteRows = False
        Me.SALEDataGridView.AutoGenerateColumns = False
        Me.SALEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SALEDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn5, Me.DataGridViewCheckBoxColumn3})
        Me.SALEDataGridView.DataSource = Me.SALEBindingSource
        Me.SALEDataGridView.Location = New System.Drawing.Point(42, 16)
        Me.SALEDataGridView.MultiSelect = False
        Me.SALEDataGridView.Name = "SALEDataGridView"
        Me.SALEDataGridView.ReadOnly = True
        Me.SALEDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.SALEDataGridView.Size = New System.Drawing.Size(426, 269)
        Me.SALEDataGridView.TabIndex = 1
        Me.MetroToolTip1.SetToolTip(Me.SALEDataGridView, "Orders")
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
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "cust_ID"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Customer ID"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 88
        '
        'DataGridViewCheckBoxColumn3
        '
        Me.DataGridViewCheckBoxColumn3.DataPropertyName = "isCompleted"
        Me.DataGridViewCheckBoxColumn3.HeaderText = "isCompleted"
        Me.DataGridViewCheckBoxColumn3.Name = "DataGridViewCheckBoxColumn3"
        Me.DataGridViewCheckBoxColumn3.ReadOnly = True
        Me.DataGridViewCheckBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewCheckBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewCheckBoxColumn3.Width = 70
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
        'JOINT_SALE_PRODUCTDataGridView
        '
        Me.JOINT_SALE_PRODUCTDataGridView.AllowUserToAddRows = False
        Me.JOINT_SALE_PRODUCTDataGridView.AllowUserToDeleteRows = False
        Me.JOINT_SALE_PRODUCTDataGridView.AutoGenerateColumns = False
        Me.JOINT_SALE_PRODUCTDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.JOINT_SALE_PRODUCTDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn10})
        Me.JOINT_SALE_PRODUCTDataGridView.DataSource = Me.JOINT_SALE_PRODUCTBindingSource
        Me.JOINT_SALE_PRODUCTDataGridView.Location = New System.Drawing.Point(472, 71)
        Me.JOINT_SALE_PRODUCTDataGridView.MultiSelect = False
        Me.JOINT_SALE_PRODUCTDataGridView.Name = "JOINT_SALE_PRODUCTDataGridView"
        Me.JOINT_SALE_PRODUCTDataGridView.ReadOnly = True
        Me.JOINT_SALE_PRODUCTDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.JOINT_SALE_PRODUCTDataGridView.Size = New System.Drawing.Size(406, 214)
        Me.JOINT_SALE_PRODUCTDataGridView.TabIndex = 2
        Me.MetroToolTip1.SetToolTip(Me.JOINT_SALE_PRODUCTDataGridView, "Order items")
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "product_ID"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Product ID"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 81
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "product_name"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "item_quantity"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Quantity"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 60
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "item_price"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Price"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 60
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "subtotal"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Subtotal"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 60
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
        Me.MetroLabel1.Location = New System.Drawing.Point(472, 34)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(106, 25)
        Me.MetroLabel1.TabIndex = 4
        Me.MetroLabel1.Text = "Order Items:"
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
        Me.TableAdapterManager.VATTableAdapter = Nothing
        '
        'JOINT_SALE_PRODUCTTableAdapter
        '
        Me.JOINT_SALE_PRODUCTTableAdapter.ClearBeforeFill = True
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(472, 357)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(56, 19)
        Me.MetroLabel5.TabIndex = 18
        Me.MetroLabel5.Text = "Address"
        '
        'ListBox
        '
        Me.ListBox.Enabled = False
        Me.ListBox.FormattingEnabled = True
        Me.ListBox.Location = New System.Drawing.Point(472, 379)
        Me.ListBox.Name = "ListBox"
        Me.ListBox.Size = New System.Drawing.Size(190, 82)
        Me.ListBox.TabIndex = 17
        Me.MetroToolTip1.SetToolTip(Me.ListBox, "Customer address")
        '
        'txtEmail
        '
        '
        '
        '
        Me.txtEmail.CustomButton.Image = Nothing
        Me.txtEmail.CustomButton.Location = New System.Drawing.Point(128, 1)
        Me.txtEmail.CustomButton.Name = ""
        Me.txtEmail.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtEmail.CustomButton.TabIndex = 1
        Me.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtEmail.CustomButton.UseSelectable = True
        Me.txtEmail.CustomButton.Visible = False
        Me.txtEmail.Lines = New String(-1) {}
        Me.txtEmail.Location = New System.Drawing.Point(188, 434)
        Me.txtEmail.MaxLength = 32767
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtEmail.SelectedText = ""
        Me.txtEmail.SelectionLength = 0
        Me.txtEmail.SelectionStart = 0
        Me.txtEmail.ShortcutsEnabled = True
        Me.txtEmail.Size = New System.Drawing.Size(150, 23)
        Me.txtEmail.TabIndex = 16
        Me.MetroToolTip1.SetToolTip(Me.txtEmail, "Email")
        Me.txtEmail.UseSelectable = True
        Me.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtEmail.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(71, 438)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(41, 19)
        Me.MetroLabel4.TabIndex = 15
        Me.MetroLabel4.Text = "Email"
        '
        'txtNumber
        '
        '
        '
        '
        Me.txtNumber.CustomButton.Image = Nothing
        Me.txtNumber.CustomButton.Location = New System.Drawing.Point(128, 1)
        Me.txtNumber.CustomButton.Name = ""
        Me.txtNumber.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNumber.CustomButton.TabIndex = 1
        Me.txtNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNumber.CustomButton.UseSelectable = True
        Me.txtNumber.CustomButton.Visible = False
        Me.txtNumber.Lines = New String(-1) {}
        Me.txtNumber.Location = New System.Drawing.Point(188, 396)
        Me.txtNumber.MaxLength = 32767
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNumber.ReadOnly = True
        Me.txtNumber.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNumber.SelectedText = ""
        Me.txtNumber.SelectionLength = 0
        Me.txtNumber.SelectionStart = 0
        Me.txtNumber.ShortcutsEnabled = True
        Me.txtNumber.Size = New System.Drawing.Size(150, 23)
        Me.txtNumber.TabIndex = 14
        Me.MetroToolTip1.SetToolTip(Me.txtNumber, "Contact number")
        Me.txtNumber.UseSelectable = True
        Me.txtNumber.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNumber.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(71, 400)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(107, 19)
        Me.MetroLabel3.TabIndex = 13
        Me.MetroLabel3.Text = "Contact Number"
        '
        'txtName
        '
        '
        '
        '
        Me.txtName.CustomButton.Image = Nothing
        Me.txtName.CustomButton.Location = New System.Drawing.Point(128, 1)
        Me.txtName.CustomButton.Name = ""
        Me.txtName.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtName.CustomButton.TabIndex = 1
        Me.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtName.CustomButton.UseSelectable = True
        Me.txtName.CustomButton.Visible = False
        Me.txtName.Lines = New String(-1) {}
        Me.txtName.Location = New System.Drawing.Point(188, 357)
        Me.txtName.MaxLength = 32767
        Me.txtName.Name = "txtName"
        Me.txtName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtName.ReadOnly = True
        Me.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtName.SelectedText = ""
        Me.txtName.SelectionLength = 0
        Me.txtName.SelectionStart = 0
        Me.txtName.ShortcutsEnabled = True
        Me.txtName.Size = New System.Drawing.Size(150, 23)
        Me.txtName.TabIndex = 12
        Me.MetroToolTip1.SetToolTip(Me.txtName, "Customer name")
        Me.txtName.UseSelectable = True
        Me.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtName.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(71, 361)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(45, 19)
        Me.MetroLabel2.TabIndex = 11
        Me.MetroLabel2.Text = "Name"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel6.Location = New System.Drawing.Point(71, 314)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(182, 25)
        Me.MetroLabel6.TabIndex = 19
        Me.MetroLabel6.Text = "Customer Information:"
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'btnOrder
        '
        Me.btnOrder.Location = New System.Drawing.Point(765, 426)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(113, 35)
        Me.btnOrder.TabIndex = 20
        Me.btnOrder.Text = "Complete Order"
        Me.btnOrder.UseSelectable = True
        '
        'MetroToolTip1
        '
        Me.MetroToolTip1.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroToolTip1.StyleManager = Nothing
        Me.MetroToolTip1.Theme = MetroFramework.MetroThemeStyle.[Default]
        '
        'lblOrderType
        '
        Me.lblOrderType.AutoSize = True
        Me.lblOrderType.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblOrderType.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lblOrderType.ForeColor = System.Drawing.Color.Red
        Me.lblOrderType.Location = New System.Drawing.Point(472, 314)
        Me.lblOrderType.Name = "lblOrderType"
        Me.lblOrderType.Size = New System.Drawing.Size(148, 25)
        Me.lblOrderType.TabIndex = 21
        Me.lblOrderType.Text = "Pickup/Delivery"
        Me.lblOrderType.UseCustomForeColor = True
        '
        'viewOrdersPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblOrderType)
        Me.Controls.Add(Me.btnOrder)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.ListBox)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.JOINT_SALE_PRODUCTDataGridView)
        Me.Controls.Add(Me.SALEDataGridView)
        Me.Name = "viewOrdersPanel"
        Me.Size = New System.Drawing.Size(923, 490)
        CType(Me.SALEDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SALEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSSystem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JOINT_SALE_PRODUCTDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JOINT_SALE_PRODUCTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DSSystem As DSSystem
    Friend WithEvents SALEBindingSource As BindingSource
    Friend WithEvents SALETableAdapter As DSSystemTableAdapters.SALETableAdapter
    Friend WithEvents TableAdapterManager As DSSystemTableAdapters.TableAdapterManager
    Friend WithEvents SALEDataGridView As DataGridView
    Friend WithEvents JOINT_SALE_PRODUCTBindingSource As BindingSource
    Friend WithEvents JOINT_SALE_PRODUCTTableAdapter As DSSystemTableAdapters.JOINT_SALE_PRODUCTTableAdapter
    Friend WithEvents JOINT_SALE_PRODUCTDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents ListBox As ListBox
    Friend WithEvents txtEmail As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtNumber As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents CustomerTableAdapter As DSSystemTableAdapters.CUSTOMERTableAdapter
    Friend WithEvents btnOrder As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroToolTip1 As MetroFramework.Components.MetroToolTip
    Friend WithEvents lblOrderType As MetroFramework.Controls.MetroLabel
End Class
