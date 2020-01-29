<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class insertSupplier
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
        Me.btnBack = New MetroFramework.Controls.MetroButton()
        Me.btnInsert = New MetroFramework.Controls.MetroButton()
        Me.postalTxt = New MetroFramework.Controls.MetroTextBox()
        Me.provinceTxt = New MetroFramework.Controls.MetroTextBox()
        Me.cityTxt = New MetroFramework.Controls.MetroTextBox()
        Me.suburbTxt = New MetroFramework.Controls.MetroTextBox()
        Me.addressTxt = New MetroFramework.Controls.MetroTextBox()
        Me.emailTxt = New MetroFramework.Controls.MetroTextBox()
        Me.numberTxt = New MetroFramework.Controls.MetroTextBox()
        Me.nameTxt = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.DsSystem1 = New UniversalInventories.DSSystem()
        Me.SupplierTableAdapter1 = New UniversalInventories.DSSystemTableAdapters.SUPPLIERTableAdapter()
        Me.MetroToolTip1 = New MetroFramework.Components.MetroToolTip()
        CType(Me.DsSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(381, 419)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(158, 35)
        Me.btnBack.TabIndex = 67
        Me.btnBack.Text = "Back To Manage Suppliers"
        Me.btnBack.UseSelectable = True
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(381, 364)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(158, 35)
        Me.btnInsert.TabIndex = 66
        Me.btnInsert.Text = "Add Supplier"
        Me.btnInsert.UseSelectable = True
        '
        'postalTxt
        '
        '
        '
        '
        Me.postalTxt.CustomButton.Image = Nothing
        Me.postalTxt.CustomButton.Location = New System.Drawing.Point(111, 1)
        Me.postalTxt.CustomButton.Name = ""
        Me.postalTxt.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.postalTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.postalTxt.CustomButton.TabIndex = 1
        Me.postalTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.postalTxt.CustomButton.UseSelectable = True
        Me.postalTxt.CustomButton.Visible = False
        Me.postalTxt.Lines = New String(-1) {}
        Me.postalTxt.Location = New System.Drawing.Point(671, 280)
        Me.postalTxt.MaxLength = 4
        Me.postalTxt.Name = "postalTxt"
        Me.postalTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.postalTxt.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.postalTxt.SelectedText = ""
        Me.postalTxt.SelectionLength = 0
        Me.postalTxt.SelectionStart = 0
        Me.postalTxt.ShortcutsEnabled = True
        Me.postalTxt.Size = New System.Drawing.Size(133, 23)
        Me.postalTxt.TabIndex = 65
        Me.MetroToolTip1.SetToolTip(Me.postalTxt, "Enter postal code")
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
        Me.provinceTxt.CustomButton.Location = New System.Drawing.Point(111, 1)
        Me.provinceTxt.CustomButton.Name = ""
        Me.provinceTxt.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.provinceTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.provinceTxt.CustomButton.TabIndex = 1
        Me.provinceTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.provinceTxt.CustomButton.UseSelectable = True
        Me.provinceTxt.CustomButton.Visible = False
        Me.provinceTxt.Lines = New String(-1) {}
        Me.provinceTxt.Location = New System.Drawing.Point(671, 215)
        Me.provinceTxt.MaxLength = 100
        Me.provinceTxt.Name = "provinceTxt"
        Me.provinceTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.provinceTxt.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.provinceTxt.SelectedText = ""
        Me.provinceTxt.SelectionLength = 0
        Me.provinceTxt.SelectionStart = 0
        Me.provinceTxt.ShortcutsEnabled = True
        Me.provinceTxt.Size = New System.Drawing.Size(133, 23)
        Me.provinceTxt.TabIndex = 64
        Me.MetroToolTip1.SetToolTip(Me.provinceTxt, "Enter province")
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
        Me.cityTxt.CustomButton.Location = New System.Drawing.Point(111, 1)
        Me.cityTxt.CustomButton.Name = ""
        Me.cityTxt.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.cityTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.cityTxt.CustomButton.TabIndex = 1
        Me.cityTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.cityTxt.CustomButton.UseSelectable = True
        Me.cityTxt.CustomButton.Visible = False
        Me.cityTxt.Lines = New String(-1) {}
        Me.cityTxt.Location = New System.Drawing.Point(671, 152)
        Me.cityTxt.MaxLength = 100
        Me.cityTxt.Name = "cityTxt"
        Me.cityTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.cityTxt.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.cityTxt.SelectedText = ""
        Me.cityTxt.SelectionLength = 0
        Me.cityTxt.SelectionStart = 0
        Me.cityTxt.ShortcutsEnabled = True
        Me.cityTxt.Size = New System.Drawing.Size(133, 23)
        Me.cityTxt.TabIndex = 63
        Me.MetroToolTip1.SetToolTip(Me.cityTxt, "Enter city")
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
        Me.suburbTxt.CustomButton.Location = New System.Drawing.Point(111, 1)
        Me.suburbTxt.CustomButton.Name = ""
        Me.suburbTxt.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.suburbTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.suburbTxt.CustomButton.TabIndex = 1
        Me.suburbTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.suburbTxt.CustomButton.UseSelectable = True
        Me.suburbTxt.CustomButton.Visible = False
        Me.suburbTxt.Lines = New String(-1) {}
        Me.suburbTxt.Location = New System.Drawing.Point(671, 86)
        Me.suburbTxt.MaxLength = 100
        Me.suburbTxt.Name = "suburbTxt"
        Me.suburbTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.suburbTxt.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.suburbTxt.SelectedText = ""
        Me.suburbTxt.SelectionLength = 0
        Me.suburbTxt.SelectionStart = 0
        Me.suburbTxt.ShortcutsEnabled = True
        Me.suburbTxt.Size = New System.Drawing.Size(133, 23)
        Me.suburbTxt.TabIndex = 62
        Me.MetroToolTip1.SetToolTip(Me.suburbTxt, "Enter suburb")
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
        Me.addressTxt.CustomButton.Location = New System.Drawing.Point(111, 1)
        Me.addressTxt.CustomButton.Name = ""
        Me.addressTxt.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.addressTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.addressTxt.CustomButton.TabIndex = 1
        Me.addressTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.addressTxt.CustomButton.UseSelectable = True
        Me.addressTxt.CustomButton.Visible = False
        Me.addressTxt.Lines = New String(-1) {}
        Me.addressTxt.Location = New System.Drawing.Point(247, 280)
        Me.addressTxt.MaxLength = 100
        Me.addressTxt.Name = "addressTxt"
        Me.addressTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.addressTxt.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.addressTxt.SelectedText = ""
        Me.addressTxt.SelectionLength = 0
        Me.addressTxt.SelectionStart = 0
        Me.addressTxt.ShortcutsEnabled = True
        Me.addressTxt.Size = New System.Drawing.Size(133, 23)
        Me.addressTxt.TabIndex = 61
        Me.MetroToolTip1.SetToolTip(Me.addressTxt, "Enter address")
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
        Me.emailTxt.CustomButton.Location = New System.Drawing.Point(111, 1)
        Me.emailTxt.CustomButton.Name = ""
        Me.emailTxt.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.emailTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.emailTxt.CustomButton.TabIndex = 1
        Me.emailTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.emailTxt.CustomButton.UseSelectable = True
        Me.emailTxt.CustomButton.Visible = False
        Me.emailTxt.Lines = New String(-1) {}
        Me.emailTxt.Location = New System.Drawing.Point(247, 215)
        Me.emailTxt.MaxLength = 100
        Me.emailTxt.Name = "emailTxt"
        Me.emailTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.emailTxt.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.emailTxt.SelectedText = ""
        Me.emailTxt.SelectionLength = 0
        Me.emailTxt.SelectionStart = 0
        Me.emailTxt.ShortcutsEnabled = True
        Me.emailTxt.Size = New System.Drawing.Size(133, 23)
        Me.emailTxt.TabIndex = 60
        Me.MetroToolTip1.SetToolTip(Me.emailTxt, "Enter email")
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
        Me.numberTxt.CustomButton.Location = New System.Drawing.Point(111, 1)
        Me.numberTxt.CustomButton.Name = ""
        Me.numberTxt.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.numberTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.numberTxt.CustomButton.TabIndex = 1
        Me.numberTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.numberTxt.CustomButton.UseSelectable = True
        Me.numberTxt.CustomButton.Visible = False
        Me.numberTxt.Lines = New String(-1) {}
        Me.numberTxt.Location = New System.Drawing.Point(247, 152)
        Me.numberTxt.MaxLength = 10
        Me.numberTxt.Name = "numberTxt"
        Me.numberTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.numberTxt.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.numberTxt.SelectedText = ""
        Me.numberTxt.SelectionLength = 0
        Me.numberTxt.SelectionStart = 0
        Me.numberTxt.ShortcutsEnabled = True
        Me.numberTxt.Size = New System.Drawing.Size(133, 23)
        Me.numberTxt.TabIndex = 59
        Me.MetroToolTip1.SetToolTip(Me.numberTxt, "Enter contact number")
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
        Me.nameTxt.CustomButton.Location = New System.Drawing.Point(111, 1)
        Me.nameTxt.CustomButton.Name = ""
        Me.nameTxt.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.nameTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.nameTxt.CustomButton.TabIndex = 1
        Me.nameTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.nameTxt.CustomButton.UseSelectable = True
        Me.nameTxt.CustomButton.Visible = False
        Me.nameTxt.Lines = New String(-1) {}
        Me.nameTxt.Location = New System.Drawing.Point(247, 86)
        Me.nameTxt.MaxLength = 100
        Me.nameTxt.Name = "nameTxt"
        Me.nameTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.nameTxt.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.nameTxt.SelectedText = ""
        Me.nameTxt.SelectionLength = 0
        Me.nameTxt.SelectionStart = 0
        Me.nameTxt.ShortcutsEnabled = True
        Me.nameTxt.Size = New System.Drawing.Size(133, 23)
        Me.nameTxt.TabIndex = 58
        Me.MetroToolTip1.SetToolTip(Me.nameTxt, "Enter supplier name")
        Me.nameTxt.UseSelectable = True
        Me.nameTxt.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.nameTxt.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(560, 284)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(79, 19)
        Me.MetroLabel9.TabIndex = 56
        Me.MetroLabel9.Text = "Postal Code"
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(560, 219)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(59, 19)
        Me.MetroLabel8.TabIndex = 55
        Me.MetroLabel8.Text = "Province"
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(560, 156)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(31, 19)
        Me.MetroLabel7.TabIndex = 54
        Me.MetroLabel7.Text = "City"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(560, 90)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(51, 19)
        Me.MetroLabel6.TabIndex = 53
        Me.MetroLabel6.Text = "Suburb"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(154, 284)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(56, 19)
        Me.MetroLabel5.TabIndex = 52
        Me.MetroLabel5.Text = "Address"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(154, 219)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(41, 19)
        Me.MetroLabel4.TabIndex = 51
        Me.MetroLabel4.Text = "Email"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(154, 156)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(58, 19)
        Me.MetroLabel3.TabIndex = 50
        Me.MetroLabel3.Text = "Number"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(154, 90)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(45, 19)
        Me.MetroLabel1.TabIndex = 48
        Me.MetroLabel1.Text = "Name"
        '
        'DsSystem1
        '
        Me.DsSystem1.DataSetName = "DSSystem"
        Me.DsSystem1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SupplierTableAdapter1
        '
        Me.SupplierTableAdapter1.ClearBeforeFill = True
        '
        'MetroToolTip1
        '
        Me.MetroToolTip1.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroToolTip1.StyleManager = Nothing
        Me.MetroToolTip1.Theme = MetroFramework.MetroThemeStyle.[Default]
        '
        'insertSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.postalTxt)
        Me.Controls.Add(Me.provinceTxt)
        Me.Controls.Add(Me.cityTxt)
        Me.Controls.Add(Me.suburbTxt)
        Me.Controls.Add(Me.addressTxt)
        Me.Controls.Add(Me.emailTxt)
        Me.Controls.Add(Me.numberTxt)
        Me.Controls.Add(Me.nameTxt)
        Me.Controls.Add(Me.MetroLabel9)
        Me.Controls.Add(Me.MetroLabel8)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Name = "insertSupplier"
        Me.Size = New System.Drawing.Size(923, 490)
        CType(Me.DsSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As MetroFramework.Controls.MetroButton
	Friend WithEvents btnInsert As MetroFramework.Controls.MetroButton
	Friend WithEvents postalTxt As MetroFramework.Controls.MetroTextBox
	Friend WithEvents provinceTxt As MetroFramework.Controls.MetroTextBox
	Friend WithEvents cityTxt As MetroFramework.Controls.MetroTextBox
	Friend WithEvents suburbTxt As MetroFramework.Controls.MetroTextBox
	Friend WithEvents addressTxt As MetroFramework.Controls.MetroTextBox
	Friend WithEvents emailTxt As MetroFramework.Controls.MetroTextBox
	Friend WithEvents numberTxt As MetroFramework.Controls.MetroTextBox
	Friend WithEvents nameTxt As MetroFramework.Controls.MetroTextBox
	Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
	Friend WithEvents DsSystem1 As DSSystem
	Friend WithEvents SupplierTableAdapter1 As DSSystemTableAdapters.SUPPLIERTableAdapter
    Friend WithEvents MetroToolTip1 As MetroFramework.Components.MetroToolTip
End Class
