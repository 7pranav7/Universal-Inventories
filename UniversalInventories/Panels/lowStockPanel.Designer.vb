<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lowStockPanel
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
        Me.DSSystem = New UniversalInventories.DSSystem()
        Me.PRODUCTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PRODUCTTableAdapter = New UniversalInventories.DSSystemTableAdapters.PRODUCTTableAdapter()
        Me.TableAdapterManager = New UniversalInventories.DSSystemTableAdapters.TableAdapterManager()
        Me.PRODUCTDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.ProducT_SUPPLIERTableAdapter = New UniversalInventories.DSSystemTableAdapters.PRODUCT_SUPPLIERTableAdapter()
        Me.SupplierTableAdapter = New UniversalInventories.DSSystemTableAdapters.SUPPLIERTableAdapter()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.txtSupplier = New MetroFramework.Controls.MetroTextBox()
        Me.txtNumber = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.txtEmail = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.ListBox = New System.Windows.Forms.ListBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroToolTip1 = New MetroFramework.Components.MetroToolTip()
        CType(Me.DSSystem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUCTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUCTDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DSSystem
        '
        Me.DSSystem.DataSetName = "DSSystem"
        Me.DSSystem.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PRODUCTBindingSource
        '
        Me.PRODUCTBindingSource.DataMember = "PRODUCT"
        Me.PRODUCTBindingSource.DataSource = Me.DSSystem
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
        'PRODUCTDataGridView
        '
        Me.PRODUCTDataGridView.AllowUserToAddRows = False
        Me.PRODUCTDataGridView.AllowUserToDeleteRows = False
        Me.PRODUCTDataGridView.AutoGenerateColumns = False
        Me.PRODUCTDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PRODUCTDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn6})
        Me.PRODUCTDataGridView.DataSource = Me.PRODUCTBindingSource
        Me.PRODUCTDataGridView.Location = New System.Drawing.Point(87, 83)
        Me.PRODUCTDataGridView.MultiSelect = False
        Me.PRODUCTDataGridView.Name = "PRODUCTDataGridView"
        Me.PRODUCTDataGridView.ReadOnly = True
        Me.PRODUCTDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.PRODUCTDataGridView.Size = New System.Drawing.Size(744, 224)
        Me.PRODUCTDataGridView.TabIndex = 1
        Me.MetroToolTip1.SetToolTip(Me.PRODUCTDataGridView, "Products")
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
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "product_quantity"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Quantity"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "reorder_threshold"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Reorder Threshold"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "product_price"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Price"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "cost_price_per_unit"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Cost Price"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "product_category"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Category"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(87, 36)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(136, 25)
        Me.MetroLabel1.TabIndex = 2
        Me.MetroLabel1.Text = "Low Stock Items:"
        '
        'ProducT_SUPPLIERTableAdapter
        '
        Me.ProducT_SUPPLIERTableAdapter.ClearBeforeFill = True
        '
        'SupplierTableAdapter
        '
        Me.SupplierTableAdapter.ClearBeforeFill = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(109, 334)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(57, 19)
        Me.MetroLabel2.TabIndex = 3
        Me.MetroLabel2.Text = "Supplier"
        '
        'txtSupplier
        '
        '
        '
        '
        Me.txtSupplier.CustomButton.Image = Nothing
        Me.txtSupplier.CustomButton.Location = New System.Drawing.Point(128, 1)
        Me.txtSupplier.CustomButton.Name = ""
        Me.txtSupplier.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtSupplier.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSupplier.CustomButton.TabIndex = 1
        Me.txtSupplier.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSupplier.CustomButton.UseSelectable = True
        Me.txtSupplier.CustomButton.Visible = False
        Me.txtSupplier.Lines = New String(-1) {}
        Me.txtSupplier.Location = New System.Drawing.Point(226, 330)
        Me.txtSupplier.MaxLength = 32767
        Me.txtSupplier.Name = "txtSupplier"
        Me.txtSupplier.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSupplier.ReadOnly = True
        Me.txtSupplier.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSupplier.SelectedText = ""
        Me.txtSupplier.SelectionLength = 0
        Me.txtSupplier.SelectionStart = 0
        Me.txtSupplier.ShortcutsEnabled = True
        Me.txtSupplier.Size = New System.Drawing.Size(150, 23)
        Me.txtSupplier.TabIndex = 4
        Me.MetroToolTip1.SetToolTip(Me.txtSupplier, "Supplier")
        Me.txtSupplier.UseSelectable = True
        Me.txtSupplier.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSupplier.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
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
        Me.txtNumber.Location = New System.Drawing.Point(226, 369)
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
        Me.txtNumber.TabIndex = 6
        Me.MetroToolTip1.SetToolTip(Me.txtNumber, "Contact number")
        Me.txtNumber.UseSelectable = True
        Me.txtNumber.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNumber.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(109, 373)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(107, 19)
        Me.MetroLabel3.TabIndex = 5
        Me.MetroLabel3.Text = "Contact Number"
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
        Me.txtEmail.Location = New System.Drawing.Point(226, 407)
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
        Me.txtEmail.TabIndex = 8
        Me.MetroToolTip1.SetToolTip(Me.txtEmail, "Email")
        Me.txtEmail.UseSelectable = True
        Me.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtEmail.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(109, 411)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(41, 19)
        Me.MetroLabel4.TabIndex = 7
        Me.MetroLabel4.Text = "Email"
        '
        'ListBox
        '
        Me.ListBox.Enabled = False
        Me.ListBox.FormattingEnabled = True
        Me.ListBox.Location = New System.Drawing.Point(464, 352)
        Me.ListBox.Name = "ListBox"
        Me.ListBox.Size = New System.Drawing.Size(190, 82)
        Me.ListBox.TabIndex = 9
        Me.MetroToolTip1.SetToolTip(Me.ListBox, "Supplier address")
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(464, 330)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(56, 19)
        Me.MetroLabel5.TabIndex = 10
        Me.MetroLabel5.Text = "Address"
        '
        'MetroToolTip1
        '
        Me.MetroToolTip1.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroToolTip1.StyleManager = Nothing
        Me.MetroToolTip1.Theme = MetroFramework.MetroThemeStyle.[Default]
        '
        'lowStockPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.ListBox)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.txtSupplier)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.PRODUCTDataGridView)
        Me.Name = "lowStockPanel"
        Me.Size = New System.Drawing.Size(923, 490)
        CType(Me.DSSystem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUCTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUCTDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DSSystem As DSSystem
    Friend WithEvents PRODUCTBindingSource As BindingSource
    Friend WithEvents PRODUCTTableAdapter As DSSystemTableAdapters.PRODUCTTableAdapter
    Friend WithEvents TableAdapterManager As DSSystemTableAdapters.TableAdapterManager
    Friend WithEvents PRODUCTDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents ProducT_SUPPLIERTableAdapter As DSSystemTableAdapters.PRODUCT_SUPPLIERTableAdapter
    Friend WithEvents SupplierTableAdapter As DSSystemTableAdapters.SUPPLIERTableAdapter
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtSupplier As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtNumber As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtEmail As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents ListBox As ListBox
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroToolTip1 As MetroFramework.Components.MetroToolTip
End Class
