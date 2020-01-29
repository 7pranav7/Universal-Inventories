<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroStyleExtender1 = New MetroFramework.Components.MetroStyleExtender(Me.components)
        Me.navigationPanel = New System.Windows.Forms.Panel()
        Me.viewOrdersTile = New MetroFramework.Controls.MetroTile()
        Me.viewLowStockTile = New MetroFramework.Controls.MetroTile()
        Me.managementTasksTile = New MetroFramework.Controls.MetroTile()
        Me.exitTile = New MetroFramework.Controls.MetroTile()
        Me.logoPanel = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.newSaleTile = New MetroFramework.Controls.MetroTile()
        Me.aboutTile = New MetroFramework.Controls.MetroTile()
        Me.controlPanel = New System.Windows.Forms.Panel()
        Me.lblUsername = New MetroFramework.Controls.MetroLabel()
        Me.lblEmpRole = New MetroFramework.Controls.MetroLabel()
        Me.lblEmployeeID = New MetroFramework.Controls.MetroLabel()
        Me.lblNameSurname = New MetroFramework.Controls.MetroLabel()
        Me.lblEmpRoleTEXT = New MetroFramework.Controls.MetroLabel()
        Me.lblEmployeeIDTEXT = New MetroFramework.Controls.MetroLabel()
        Me.loginLogoutTile = New MetroFramework.Controls.MetroTile()
        Me.labelUser = New MetroFramework.Controls.MetroLabel()
        Me.lblNameSurnameTEXT = New MetroFramework.Controls.MetroLabel()
        Me.displayPanel = New System.Windows.Forms.Panel()
        Me.navigationPanel.SuspendLayout()
        Me.logoPanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.controlPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(0, 0)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(75, 23)
        Me.MetroButton1.TabIndex = 0
        Me.MetroButton1.UseSelectable = True
        '
        'navigationPanel
        '
        Me.navigationPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.navigationPanel.Controls.Add(Me.viewOrdersTile)
        Me.navigationPanel.Controls.Add(Me.viewLowStockTile)
        Me.navigationPanel.Controls.Add(Me.managementTasksTile)
        Me.navigationPanel.Controls.Add(Me.exitTile)
        Me.navigationPanel.Controls.Add(Me.logoPanel)
        Me.navigationPanel.Controls.Add(Me.newSaleTile)
        Me.navigationPanel.Controls.Add(Me.aboutTile)
        Me.navigationPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.navigationPanel.Location = New System.Drawing.Point(0, 0)
        Me.navigationPanel.Name = "navigationPanel"
        Me.navigationPanel.Size = New System.Drawing.Size(200, 590)
        Me.navigationPanel.TabIndex = 1
        '
        'viewOrdersTile
        '
        Me.viewOrdersTile.ActiveControl = Nothing
        Me.viewOrdersTile.BackColor = System.Drawing.Color.MediumAquamarine
        Me.viewOrdersTile.ForeColor = System.Drawing.Color.Black
        Me.viewOrdersTile.Location = New System.Drawing.Point(23, 228)
        Me.viewOrdersTile.Name = "viewOrdersTile"
        Me.viewOrdersTile.Size = New System.Drawing.Size(150, 47)
        Me.viewOrdersTile.TabIndex = 7
        Me.viewOrdersTile.Text = "View Orders"
        Me.viewOrdersTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        Me.viewOrdersTile.UseCustomBackColor = True
        Me.viewOrdersTile.UseSelectable = True
        Me.viewOrdersTile.Visible = False
        '
        'viewLowStockTile
        '
        Me.viewLowStockTile.ActiveControl = Nothing
        Me.viewLowStockTile.BackColor = System.Drawing.Color.Goldenrod
        Me.viewLowStockTile.ForeColor = System.Drawing.Color.Black
        Me.viewLowStockTile.Location = New System.Drawing.Point(23, 286)
        Me.viewLowStockTile.Name = "viewLowStockTile"
        Me.viewLowStockTile.Size = New System.Drawing.Size(150, 47)
        Me.viewLowStockTile.TabIndex = 6
        Me.viewLowStockTile.Text = "View Low Stock"
        Me.viewLowStockTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        Me.viewLowStockTile.UseCustomBackColor = True
        Me.viewLowStockTile.UseSelectable = True
        Me.viewLowStockTile.Visible = False
        '
        'managementTasksTile
        '
        Me.managementTasksTile.ActiveControl = Nothing
        Me.managementTasksTile.BackColor = System.Drawing.Color.MediumAquamarine
        Me.managementTasksTile.ForeColor = System.Drawing.Color.Black
        Me.managementTasksTile.Location = New System.Drawing.Point(23, 170)
        Me.managementTasksTile.Name = "managementTasksTile"
        Me.managementTasksTile.Size = New System.Drawing.Size(150, 47)
        Me.managementTasksTile.TabIndex = 5
        Me.managementTasksTile.Text = "Management Tasks"
        Me.managementTasksTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Small
        Me.managementTasksTile.UseCustomBackColor = True
        Me.managementTasksTile.UseSelectable = True
        Me.managementTasksTile.Visible = False
        '
        'exitTile
        '
        Me.exitTile.ActiveControl = Nothing
        Me.exitTile.BackColor = System.Drawing.Color.Crimson
        Me.exitTile.ForeColor = System.Drawing.Color.Black
        Me.exitTile.Location = New System.Drawing.Point(12, 531)
        Me.exitTile.Name = "exitTile"
        Me.exitTile.Size = New System.Drawing.Size(167, 47)
        Me.exitTile.TabIndex = 4
        Me.exitTile.Text = "Exit"
        Me.exitTile.UseCustomBackColor = True
        Me.exitTile.UseSelectable = True
        '
        'logoPanel
        '
        Me.logoPanel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.logoPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.logoPanel.Controls.Add(Me.PictureBox1)
        Me.logoPanel.Location = New System.Drawing.Point(-10, 0)
        Me.logoPanel.Name = "logoPanel"
        Me.logoPanel.Size = New System.Drawing.Size(226, 100)
        Me.logoPanel.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.UniversalInventories.My.Resources.Resources.resized_ui
        Me.PictureBox1.Location = New System.Drawing.Point(13, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(194, 94)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'newSaleTile
        '
        Me.newSaleTile.ActiveControl = Nothing
        Me.newSaleTile.BackColor = System.Drawing.Color.MediumAquamarine
        Me.newSaleTile.ForeColor = System.Drawing.Color.Black
        Me.newSaleTile.Location = New System.Drawing.Point(23, 111)
        Me.newSaleTile.Name = "newSaleTile"
        Me.newSaleTile.Size = New System.Drawing.Size(150, 47)
        Me.newSaleTile.TabIndex = 0
        Me.newSaleTile.Text = "New Sale"
        Me.newSaleTile.UseCustomBackColor = True
        Me.newSaleTile.UseSelectable = True
        Me.newSaleTile.Visible = False
        '
        'aboutTile
        '
        Me.aboutTile.ActiveControl = Nothing
        Me.aboutTile.BackColor = System.Drawing.Color.MediumAquamarine
        Me.aboutTile.ForeColor = System.Drawing.Color.Black
        Me.aboutTile.Location = New System.Drawing.Point(12, 473)
        Me.aboutTile.Name = "aboutTile"
        Me.aboutTile.Size = New System.Drawing.Size(167, 47)
        Me.aboutTile.TabIndex = 2
        Me.aboutTile.Text = "About"
        Me.aboutTile.UseCustomBackColor = True
        Me.aboutTile.UseSelectable = True
        Me.aboutTile.Visible = False
        '
        'controlPanel
        '
        Me.controlPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.controlPanel.Controls.Add(Me.lblUsername)
        Me.controlPanel.Controls.Add(Me.lblEmpRole)
        Me.controlPanel.Controls.Add(Me.lblEmployeeID)
        Me.controlPanel.Controls.Add(Me.lblNameSurname)
        Me.controlPanel.Controls.Add(Me.lblEmpRoleTEXT)
        Me.controlPanel.Controls.Add(Me.lblEmployeeIDTEXT)
        Me.controlPanel.Controls.Add(Me.loginLogoutTile)
        Me.controlPanel.Controls.Add(Me.labelUser)
        Me.controlPanel.Controls.Add(Me.lblNameSurnameTEXT)
        Me.controlPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.controlPanel.Location = New System.Drawing.Point(200, 0)
        Me.controlPanel.Name = "controlPanel"
        Me.controlPanel.Size = New System.Drawing.Size(923, 100)
        Me.controlPanel.TabIndex = 2
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblUsername.ForeColor = System.Drawing.Color.White
        Me.lblUsername.Location = New System.Drawing.Point(22, 37)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(92, 25)
        Me.lblUsername.TabIndex = 11
        Me.lblUsername.Text = "UserName"
        Me.lblUsername.UseCustomBackColor = True
        Me.lblUsername.UseCustomForeColor = True
        Me.lblUsername.Visible = False
        '
        'lblEmpRole
        '
        Me.lblEmpRole.AutoSize = True
        Me.lblEmpRole.ForeColor = System.Drawing.Color.White
        Me.lblEmpRole.Location = New System.Drawing.Point(129, 65)
        Me.lblEmpRole.Name = "lblEmpRole"
        Me.lblEmpRole.Size = New System.Drawing.Size(0, 0)
        Me.lblEmpRole.TabIndex = 10
        Me.lblEmpRole.UseCustomBackColor = True
        Me.lblEmpRole.UseCustomForeColor = True
        '
        'lblEmployeeID
        '
        Me.lblEmployeeID.AutoSize = True
        Me.lblEmployeeID.ForeColor = System.Drawing.Color.White
        Me.lblEmployeeID.Location = New System.Drawing.Point(130, 37)
        Me.lblEmployeeID.Name = "lblEmployeeID"
        Me.lblEmployeeID.Size = New System.Drawing.Size(0, 0)
        Me.lblEmployeeID.TabIndex = 9
        Me.lblEmployeeID.UseCustomBackColor = True
        Me.lblEmployeeID.UseCustomForeColor = True
        '
        'lblNameSurname
        '
        Me.lblNameSurname.AutoSize = True
        Me.lblNameSurname.ForeColor = System.Drawing.Color.White
        Me.lblNameSurname.Location = New System.Drawing.Point(129, 9)
        Me.lblNameSurname.Name = "lblNameSurname"
        Me.lblNameSurname.Size = New System.Drawing.Size(0, 0)
        Me.lblNameSurname.TabIndex = 8
        Me.lblNameSurname.UseCustomBackColor = True
        Me.lblNameSurname.UseCustomForeColor = True
        '
        'lblEmpRoleTEXT
        '
        Me.lblEmpRoleTEXT.AutoSize = True
        Me.lblEmpRoleTEXT.ForeColor = System.Drawing.Color.White
        Me.lblEmpRoleTEXT.Location = New System.Drawing.Point(22, 65)
        Me.lblEmpRoleTEXT.Name = "lblEmpRoleTEXT"
        Me.lblEmpRoleTEXT.Size = New System.Drawing.Size(0, 0)
        Me.lblEmpRoleTEXT.TabIndex = 7
        Me.lblEmpRoleTEXT.UseCustomBackColor = True
        Me.lblEmpRoleTEXT.UseCustomForeColor = True
        Me.lblEmpRoleTEXT.Visible = False
        '
        'lblEmployeeIDTEXT
        '
        Me.lblEmployeeIDTEXT.AutoSize = True
        Me.lblEmployeeIDTEXT.ForeColor = System.Drawing.Color.White
        Me.lblEmployeeIDTEXT.Location = New System.Drawing.Point(22, 37)
        Me.lblEmployeeIDTEXT.Name = "lblEmployeeIDTEXT"
        Me.lblEmployeeIDTEXT.Size = New System.Drawing.Size(0, 0)
        Me.lblEmployeeIDTEXT.TabIndex = 6
        Me.lblEmployeeIDTEXT.UseCustomBackColor = True
        Me.lblEmployeeIDTEXT.UseCustomForeColor = True
        Me.lblEmployeeIDTEXT.Visible = False
        '
        'loginLogoutTile
        '
        Me.loginLogoutTile.ActiveControl = Nothing
        Me.loginLogoutTile.BackColor = System.Drawing.Color.MediumAquamarine
        Me.loginLogoutTile.ForeColor = System.Drawing.Color.Black
        Me.loginLogoutTile.Location = New System.Drawing.Point(744, 23)
        Me.loginLogoutTile.Name = "loginLogoutTile"
        Me.loginLogoutTile.Size = New System.Drawing.Size(150, 47)
        Me.loginLogoutTile.TabIndex = 5
        Me.loginLogoutTile.Text = "Logout"
        Me.loginLogoutTile.UseCustomBackColor = True
        Me.loginLogoutTile.UseSelectable = True
        Me.loginLogoutTile.Visible = False
        '
        'labelUser
        '
        Me.labelUser.AutoSize = True
        Me.labelUser.ForeColor = System.Drawing.Color.White
        Me.labelUser.Location = New System.Drawing.Point(829, 8)
        Me.labelUser.Name = "labelUser"
        Me.labelUser.Size = New System.Drawing.Size(0, 0)
        Me.labelUser.TabIndex = 3
        Me.labelUser.UseCustomBackColor = True
        Me.labelUser.UseCustomForeColor = True
        '
        'lblNameSurnameTEXT
        '
        Me.lblNameSurnameTEXT.AutoSize = True
        Me.lblNameSurnameTEXT.ForeColor = System.Drawing.Color.White
        Me.lblNameSurnameTEXT.Location = New System.Drawing.Point(22, 9)
        Me.lblNameSurnameTEXT.Name = "lblNameSurnameTEXT"
        Me.lblNameSurnameTEXT.Size = New System.Drawing.Size(101, 19)
        Me.lblNameSurnameTEXT.TabIndex = 1
        Me.lblNameSurnameTEXT.Text = "Logged In As:   "
        Me.lblNameSurnameTEXT.UseCustomBackColor = True
        Me.lblNameSurnameTEXT.UseCustomForeColor = True
        Me.lblNameSurnameTEXT.Visible = False
        '
        'displayPanel
        '
        Me.displayPanel.BackColor = System.Drawing.Color.White
        Me.displayPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.displayPanel.Location = New System.Drawing.Point(200, 100)
        Me.displayPanel.Name = "displayPanel"
        Me.displayPanel.Size = New System.Drawing.Size(923, 490)
        Me.displayPanel.TabIndex = 3
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1123, 590)
        Me.Controls.Add(Me.displayPanel)
        Me.Controls.Add(Me.controlPanel)
        Me.Controls.Add(Me.navigationPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainForm"
        Me.Text = "Form1"
        Me.navigationPanel.ResumeLayout(False)
        Me.logoPanel.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.controlPanel.ResumeLayout(False)
        Me.controlPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroStyleExtender1 As MetroFramework.Components.MetroStyleExtender
    Friend WithEvents navigationPanel As Panel
    Friend WithEvents logoPanel As Panel
    Friend WithEvents controlPanel As Panel
    Friend WithEvents displayPanel As Panel
    Friend WithEvents newSaleTile As MetroFramework.Controls.MetroTile
    Friend WithEvents aboutTile As MetroFramework.Controls.MetroTile
    Friend WithEvents labelUser As MetroFramework.Controls.MetroLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents loginLogoutTile As MetroFramework.Controls.MetroTile
    Friend WithEvents exitTile As MetroFramework.Controls.MetroTile
    Friend WithEvents managementTasksTile As MetroFramework.Controls.MetroTile
    Friend WithEvents lblEmpRoleTEXT As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblEmployeeIDTEXT As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblEmpRole As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblEmployeeID As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblNameSurname As MetroFramework.Controls.MetroLabel
    Friend WithEvents viewLowStockTile As MetroFramework.Controls.MetroTile
    Friend WithEvents viewOrdersTile As MetroFramework.Controls.MetroTile
    Friend WithEvents lblUsername As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblNameSurnameTEXT As MetroFramework.Controls.MetroLabel
End Class
