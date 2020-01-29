<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class supplierReportForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.DsSystem = New UniversalInventories.DSSystem()
        Me.ProductTableAdapter = New UniversalInventories.DSSystemTableAdapters.PRODUCTTableAdapter()
        Me.ProducT_SUPPLIERTableAdapter = New UniversalInventories.DSSystemTableAdapters.PRODUCT_SUPPLIERTableAdapter()
        Me.SupplierTableAdapter = New UniversalInventories.DSSystemTableAdapters.SUPPLIERTableAdapter()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.supplierReport = New UniversalInventories.supplierReport()
        CType(Me.DsSystem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DsSystem
        '
        Me.DsSystem.DataSetName = "DSSystem"
        Me.DsSystem.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductTableAdapter
        '
        Me.ProductTableAdapter.ClearBeforeFill = True
        '
        'ProducT_SUPPLIERTableAdapter
        '
        Me.ProducT_SUPPLIERTableAdapter.ClearBeforeFill = True
        '
        'SupplierTableAdapter
        '
        Me.SupplierTableAdapter.ClearBeforeFill = True
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = 0
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Me.supplierReport
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1130, 681)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'supplierReportForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1130, 681)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "supplierReportForm"
        Me.Text = "Supplier Report"
        CType(Me.DsSystem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DsSystem As DSSystem
    Friend WithEvents ProductTableAdapter As DSSystemTableAdapters.PRODUCTTableAdapter
    Friend WithEvents ProducT_SUPPLIERTableAdapter As DSSystemTableAdapters.PRODUCT_SUPPLIERTableAdapter
    Friend WithEvents SupplierTableAdapter As DSSystemTableAdapters.SUPPLIERTableAdapter
    Friend WithEvents supplierReport As supplierReport
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
