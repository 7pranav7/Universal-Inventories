<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class taskManagementPanel
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
        Me.employeesTile = New MetroFramework.Controls.MetroTile()
        Me.customersTile = New MetroFramework.Controls.MetroTile()
        Me.salesTile = New MetroFramework.Controls.MetroTile()
        Me.suppliersTile = New MetroFramework.Controls.MetroTile()
        Me.productsTile = New MetroFramework.Controls.MetroTile()
        Me.reportsTile = New MetroFramework.Controls.MetroTile()
        Me.SuspendLayout()
        '
        'employeesTile
        '
        Me.employeesTile.ActiveControl = Nothing
        Me.employeesTile.BackColor = System.Drawing.Color.MediumTurquoise
        Me.employeesTile.Location = New System.Drawing.Point(466, 301)
        Me.employeesTile.Name = "employeesTile"
        Me.employeesTile.Size = New System.Drawing.Size(226, 102)
        Me.employeesTile.TabIndex = 0
        Me.employeesTile.Text = "Manage Employees"
        Me.employeesTile.UseSelectable = True
        '
        'customersTile
        '
        Me.customersTile.ActiveControl = Nothing
        Me.customersTile.BackColor = System.Drawing.Color.MediumTurquoise
        Me.customersTile.Location = New System.Drawing.Point(466, 193)
        Me.customersTile.Name = "customersTile"
        Me.customersTile.Size = New System.Drawing.Size(226, 102)
        Me.customersTile.TabIndex = 1
        Me.customersTile.Text = "Manage Customers"
        Me.customersTile.UseSelectable = True
        '
        'salesTile
        '
        Me.salesTile.ActiveControl = Nothing
        Me.salesTile.BackColor = System.Drawing.Color.MediumTurquoise
        Me.salesTile.Location = New System.Drawing.Point(234, 85)
        Me.salesTile.Name = "salesTile"
        Me.salesTile.Size = New System.Drawing.Size(226, 102)
        Me.salesTile.TabIndex = 2
        Me.salesTile.Text = "View Sales"
        Me.salesTile.UseSelectable = True
        '
        'suppliersTile
        '
        Me.suppliersTile.ActiveControl = Nothing
        Me.suppliersTile.BackColor = System.Drawing.Color.MediumTurquoise
        Me.suppliersTile.Location = New System.Drawing.Point(234, 301)
        Me.suppliersTile.Name = "suppliersTile"
        Me.suppliersTile.Size = New System.Drawing.Size(226, 102)
        Me.suppliersTile.TabIndex = 3
        Me.suppliersTile.Text = "Manage Suppliers"
        Me.suppliersTile.UseSelectable = True
        '
        'productsTile
        '
        Me.productsTile.ActiveControl = Nothing
        Me.productsTile.BackColor = System.Drawing.Color.MediumTurquoise
        Me.productsTile.Location = New System.Drawing.Point(234, 193)
        Me.productsTile.Name = "productsTile"
        Me.productsTile.Size = New System.Drawing.Size(226, 102)
        Me.productsTile.TabIndex = 4
        Me.productsTile.Text = "Manage Products"
        Me.productsTile.UseSelectable = True
        '
        'reportsTile
        '
        Me.reportsTile.ActiveControl = Nothing
        Me.reportsTile.BackColor = System.Drawing.Color.MediumTurquoise
        Me.reportsTile.Location = New System.Drawing.Point(466, 85)
        Me.reportsTile.Name = "reportsTile"
        Me.reportsTile.Size = New System.Drawing.Size(226, 102)
        Me.reportsTile.TabIndex = 5
        Me.reportsTile.Text = "View Reports && Statistics"
        Me.reportsTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.reportsTile.UseSelectable = True
        '
        'taskManagementPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.reportsTile)
        Me.Controls.Add(Me.productsTile)
        Me.Controls.Add(Me.suppliersTile)
        Me.Controls.Add(Me.salesTile)
        Me.Controls.Add(Me.customersTile)
        Me.Controls.Add(Me.employeesTile)
        Me.Name = "taskManagementPanel"
        Me.Size = New System.Drawing.Size(923, 490)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents employeesTile As MetroFramework.Controls.MetroTile
	Friend WithEvents customersTile As MetroFramework.Controls.MetroTile
	Friend WithEvents salesTile As MetroFramework.Controls.MetroTile
	Friend WithEvents suppliersTile As MetroFramework.Controls.MetroTile
	Friend WithEvents productsTile As MetroFramework.Controls.MetroTile
	Friend WithEvents reportsTile As MetroFramework.Controls.MetroTile
End Class
