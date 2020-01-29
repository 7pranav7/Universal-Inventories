<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReceiptPanel
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
        Me.SALE_ITEMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SALE_ITEMTableAdapter = New UniversalInventories.DSSystemTableAdapters.SALE_ITEMTableAdapter()
        Me.TableAdapterManager = New UniversalInventories.DSSystemTableAdapters.TableAdapterManager()
        Me.SALE_ITEMDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SALEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SALETableAdapter = New UniversalInventories.DSSystemTableAdapters.SALETableAdapter()
        Me.SALEDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtReceipt = New System.Windows.Forms.RichTextBox()
        Me.EMPLOYEEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EMPLOYEETableAdapter = New UniversalInventories.DSSystemTableAdapters.EMPLOYEETableAdapter()
        Me.EMPLOYEEDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODUCTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PRODUCTTableAdapter = New UniversalInventories.DSSystemTableAdapters.PRODUCTTableAdapter()
        Me.PRODUCTDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnFinish = New MetroFramework.Controls.MetroButton()
        Me.MetroToolTip1 = New MetroFramework.Components.MetroToolTip()
        CType(Me.DSSystem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SALE_ITEMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SALE_ITEMDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SALEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SALEDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMPLOYEEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMPLOYEEDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUCTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUCTDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DSSystem
        '
        Me.DSSystem.DataSetName = "DSSystem"
        Me.DSSystem.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SALE_ITEMBindingSource
        '
        Me.SALE_ITEMBindingSource.DataMember = "SALE_ITEM"
        Me.SALE_ITEMBindingSource.DataSource = Me.DSSystem
        '
        'SALE_ITEMTableAdapter
        '
        Me.SALE_ITEMTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CUSTOMERTableAdapter = Nothing
        Me.TableAdapterManager.EMPLOYEETableAdapter = Nothing
        Me.TableAdapterManager.PRODUCT_SUPPLIERTableAdapter = Nothing
        Me.TableAdapterManager.PRODUCTTableAdapter = Nothing
        Me.TableAdapterManager.SALE_ITEMTableAdapter = Me.SALE_ITEMTableAdapter
        Me.TableAdapterManager.SALETableAdapter = Nothing
        Me.TableAdapterManager.SUPPLIERTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = UniversalInventories.DSSystemTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SALE_ITEMDataGridView
        '
        Me.SALE_ITEMDataGridView.AllowUserToAddRows = False
        Me.SALE_ITEMDataGridView.AllowUserToDeleteRows = False
        Me.SALE_ITEMDataGridView.AutoGenerateColumns = False
        Me.SALE_ITEMDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SALE_ITEMDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.SALE_ITEMDataGridView.DataSource = Me.SALE_ITEMBindingSource
        Me.SALE_ITEMDataGridView.Enabled = False
        Me.SALE_ITEMDataGridView.Location = New System.Drawing.Point(1100, 180)
        Me.SALE_ITEMDataGridView.Name = "SALE_ITEMDataGridView"
        Me.SALE_ITEMDataGridView.ReadOnly = True
        Me.SALE_ITEMDataGridView.Size = New System.Drawing.Size(104, 29)
        Me.SALE_ITEMDataGridView.TabIndex = 1
        Me.SALE_ITEMDataGridView.Visible = False
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
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "sale_ID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Sale ID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "item_price"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Item Price"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "item_quantity"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Quantity"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "subtotal"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Subtotal"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
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
        'SALEDataGridView
        '
        Me.SALEDataGridView.AllowUserToAddRows = False
        Me.SALEDataGridView.AllowUserToDeleteRows = False
        Me.SALEDataGridView.AutoGenerateColumns = False
        Me.SALEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SALEDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.SALEDataGridView.DataSource = Me.SALEBindingSource
        Me.SALEDataGridView.Enabled = False
        Me.SALEDataGridView.Location = New System.Drawing.Point(1173, 55)
        Me.SALEDataGridView.Name = "SALEDataGridView"
        Me.SALEDataGridView.ReadOnly = True
        Me.SALEDataGridView.Size = New System.Drawing.Size(43, 21)
        Me.SALEDataGridView.TabIndex = 1
        Me.SALEDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "sale_ID"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Sale ID"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "sale_date"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Sale Date"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "total_amount"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "emp_ID"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Employee ID"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'txtReceipt
        '
        Me.txtReceipt.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReceipt.Location = New System.Drawing.Point(101, 17)
        Me.txtReceipt.Name = "txtReceipt"
        Me.txtReceipt.ReadOnly = True
        Me.txtReceipt.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.txtReceipt.Size = New System.Drawing.Size(721, 381)
        Me.txtReceipt.TabIndex = 2
        Me.txtReceipt.Text = "Sale Receipt"
        Me.MetroToolTip1.SetToolTip(Me.txtReceipt, "Sales receipt")
        '
        'EMPLOYEEBindingSource
        '
        Me.EMPLOYEEBindingSource.DataMember = "EMPLOYEE"
        Me.EMPLOYEEBindingSource.DataSource = Me.DSSystem
        '
        'EMPLOYEETableAdapter
        '
        Me.EMPLOYEETableAdapter.ClearBeforeFill = True
        '
        'EMPLOYEEDataGridView
        '
        Me.EMPLOYEEDataGridView.AllowUserToAddRows = False
        Me.EMPLOYEEDataGridView.AllowUserToDeleteRows = False
        Me.EMPLOYEEDataGridView.AutoGenerateColumns = False
        Me.EMPLOYEEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EMPLOYEEDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.EMPLOYEEDataGridView.DataSource = Me.EMPLOYEEBindingSource
        Me.EMPLOYEEDataGridView.Enabled = False
        Me.EMPLOYEEDataGridView.Location = New System.Drawing.Point(1155, 111)
        Me.EMPLOYEEDataGridView.Name = "EMPLOYEEDataGridView"
        Me.EMPLOYEEDataGridView.ReadOnly = True
        Me.EMPLOYEEDataGridView.Size = New System.Drawing.Size(61, 31)
        Me.EMPLOYEEDataGridView.TabIndex = 3
        Me.EMPLOYEEDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "emp_ID"
        Me.DataGridViewTextBoxColumn10.HeaderText = "emp_ID"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "emp_name"
        Me.DataGridViewTextBoxColumn11.HeaderText = "emp_name"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "emp_surname"
        Me.DataGridViewTextBoxColumn12.HeaderText = "emp_surname"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
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
        'PRODUCTDataGridView
        '
        Me.PRODUCTDataGridView.AllowUserToAddRows = False
        Me.PRODUCTDataGridView.AllowUserToDeleteRows = False
        Me.PRODUCTDataGridView.AutoGenerateColumns = False
        Me.PRODUCTDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PRODUCTDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21})
        Me.PRODUCTDataGridView.DataSource = Me.PRODUCTBindingSource
        Me.PRODUCTDataGridView.Enabled = False
        Me.PRODUCTDataGridView.Location = New System.Drawing.Point(1189, 3)
        Me.PRODUCTDataGridView.Name = "PRODUCTDataGridView"
        Me.PRODUCTDataGridView.ReadOnly = True
        Me.PRODUCTDataGridView.Size = New System.Drawing.Size(42, 37)
        Me.PRODUCTDataGridView.TabIndex = 4
        Me.PRODUCTDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "product_ID"
        Me.DataGridViewTextBoxColumn13.HeaderText = "product_ID"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "product_name"
        Me.DataGridViewTextBoxColumn14.HeaderText = "product_name"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "product_price"
        Me.DataGridViewTextBoxColumn15.HeaderText = "product_price"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "product_quantity"
        Me.DataGridViewTextBoxColumn16.HeaderText = "product_quantity"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "product_description"
        Me.DataGridViewTextBoxColumn17.HeaderText = "product_description"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "product_category"
        Me.DataGridViewTextBoxColumn18.HeaderText = "product_category"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "cost_price_per_unit"
        Me.DataGridViewTextBoxColumn19.HeaderText = "cost_price_per_unit"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "product_markup_percentage"
        Me.DataGridViewTextBoxColumn20.HeaderText = "product_markup_percentage"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "reorder_threshold"
        Me.DataGridViewTextBoxColumn21.HeaderText = "reorder_threshold"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        '
        'btnFinish
        '
        Me.btnFinish.Location = New System.Drawing.Point(404, 423)
        Me.btnFinish.Name = "btnFinish"
        Me.btnFinish.Size = New System.Drawing.Size(115, 36)
        Me.btnFinish.TabIndex = 5
        Me.btnFinish.Text = "Finish"
        Me.btnFinish.UseSelectable = True
        '
        'MetroToolTip1
        '
        Me.MetroToolTip1.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroToolTip1.StyleManager = Nothing
        Me.MetroToolTip1.Theme = MetroFramework.MetroThemeStyle.[Default]
        '
        'ReceiptPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnFinish)
        Me.Controls.Add(Me.PRODUCTDataGridView)
        Me.Controls.Add(Me.EMPLOYEEDataGridView)
        Me.Controls.Add(Me.txtReceipt)
        Me.Controls.Add(Me.SALEDataGridView)
        Me.Controls.Add(Me.SALE_ITEMDataGridView)
        Me.Name = "ReceiptPanel"
        Me.Size = New System.Drawing.Size(923, 490)
        CType(Me.DSSystem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SALE_ITEMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SALE_ITEMDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SALEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SALEDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMPLOYEEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMPLOYEEDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUCTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUCTDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DSSystem As DSSystem
    Friend WithEvents SALE_ITEMBindingSource As BindingSource
    Friend WithEvents SALE_ITEMTableAdapter As DSSystemTableAdapters.SALE_ITEMTableAdapter
    Friend WithEvents TableAdapterManager As DSSystemTableAdapters.TableAdapterManager
    Friend WithEvents SALE_ITEMDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents SALEBindingSource As BindingSource
    Friend WithEvents SALETableAdapter As DSSystemTableAdapters.SALETableAdapter
    Friend WithEvents SALEDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents txtReceipt As RichTextBox
    Friend WithEvents EMPLOYEEBindingSource As BindingSource
    Friend WithEvents EMPLOYEETableAdapter As DSSystemTableAdapters.EMPLOYEETableAdapter
    Friend WithEvents EMPLOYEEDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents PRODUCTBindingSource As BindingSource
    Friend WithEvents PRODUCTTableAdapter As DSSystemTableAdapters.PRODUCTTableAdapter
    Friend WithEvents PRODUCTDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents btnFinish As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroToolTip1 As MetroFramework.Components.MetroToolTip
End Class
