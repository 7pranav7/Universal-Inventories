Imports MetroFramework
Public Class MainForm
    Public Shared employeeID As Integer

    Public Shared loginPanel As LoginPanel = New LoginPanel
    Public Shared salePanel As salePanel = New salePanel
	Public Shared ReceiptPanel As ReceiptPanel = New ReceiptPanel
	Public Shared taskPanel As taskManagementPanel = New taskManagementPanel
	Public Shared insertProductPanel As insertProductPanel = New insertProductPanel
	Public Shared productsPanel As productsPanel = New productsPanel
	Public Shared employeesPanel As employeesPanel = New employeesPanel
    Public Shared insertEmployeePanel As insertEmployeePanel = New insertEmployeePanel
	Public Shared saleView As saleView = New saleView
	Public Shared customerPanel As customerPanel = New customerPanel
	Public Shared insertCustomerPanel As insertCustomerPanel = New insertCustomerPanel
	Public Shared supplierPanel As supplierPanel = New supplierPanel
    Public Shared insertSupplierPanel As insertSupplier = New insertSupplier
    Public Shared viewReportsPanel As viewReportsStatistics = New viewReportsStatistics
    Public Shared graphPanel As graphPanel = New graphPanel
    Public Shared lowStockPanel As lowStockPanel = New lowStockPanel
	Public Shared viewOrdersPanel As viewOrdersPanel = New viewOrdersPanel
	Public Shared reportsPanel As reportsPanel = New reportsPanel
	Dim aboutPanel As AboutPanel = New AboutPanel



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MyBase.StartPosition = FormStartPosition.CenterScreen
        displayPanel.Controls.Clear()
        displayPanel.Controls.Add(loginPanel)
        loginPanel.usernameTextbox.Focus()


        newSaleTile.TileTextFontSize = MetroTileTextSize.Medium
        newSaleTile.TileTextFontWeight = MetroTileTextWeight.Bold
        newSaleTile.TextAlign = ContentAlignment.MiddleCenter

        aboutTile.TileTextFontSize = MetroTileTextSize.Tall
        aboutTile.TileTextFontWeight = MetroTileTextWeight.Bold
        aboutTile.TextAlign = ContentAlignment.MiddleCenter

        managementTasksTile.TileTextFontSize = MetroTileTextSize.Medium
        managementTasksTile.TileTextFontWeight = MetroTileTextWeight.Bold
        managementTasksTile.TextAlign = ContentAlignment.MiddleCenter

        exitTile.TileTextFontSize = MetroTileTextSize.Tall
        exitTile.TileTextFontWeight = MetroTileTextWeight.Bold
        exitTile.TextAlign = ContentAlignment.MiddleCenter

        loginLogoutTile.TileTextFontSize = MetroTileTextSize.Tall
        loginLogoutTile.TileTextFontWeight = MetroTileTextWeight.Bold
        loginLogoutTile.TextAlign = ContentAlignment.MiddleCenter

        viewLowStockTile.TextAlign = ContentAlignment.MiddleCenter
        viewOrdersTile.TextAlign = ContentAlignment.MiddleCenter



    End Sub

    Private Sub aboutTile_MouseClick(sender As Object, e As MouseEventArgs) Handles aboutTile.MouseClick
        displayPanel.Controls.Clear()
        displayPanel.Controls.Add(aboutPanel)
    End Sub

    Dim draggable As Boolean
    Dim mouseX As Integer
    Dim mouseY As Integer

    Private Sub panelTop_MouseDown(sender As Object, e As MouseEventArgs) Handles controlPanel.MouseDown
        draggable = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub panelTop_MouseMove(sender As Object, e As MouseEventArgs) Handles controlPanel.MouseMove
        If draggable Then
            Me.Top = Cursor.Position.Y - mouseY
            Me.Left = Cursor.Position.X - mouseX
        End If
    End Sub

    Private Sub panelTop_MouseUp(sender As Object, e As MouseEventArgs) Handles controlPanel.MouseUp
        draggable = False
    End Sub



    Private Sub exitTile_Click(sender As Object, e As EventArgs) Handles exitTile.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Close()

        End If
    End Sub

    Private Sub loginLogoutTile_Click(sender As Object, e As EventArgs) Handles loginLogoutTile.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            employeeID = 0
            lblEmployeeID.Text = ""
            lblEmpRole.Text = ""
            lblNameSurname.Text = ""
            lblNameSurnameTEXT.Visible = False
            lblEmployeeIDTEXT.Visible = False
            lblEmpRoleTEXT.Visible = False
            loginLogoutTile.Visible = False
            newSaleTile.Visible = False
            managementTasksTile.Visible = False
            aboutTile.Visible = False
            viewLowStockTile.Visible = False
            viewOrdersTile.Visible = False
            lblUsername.Visible = False

            loginPanel = New LoginPanel
            salePanel = New salePanel
            ReceiptPanel = New ReceiptPanel
            taskPanel = New taskManagementPanel
            insertProductPanel = New insertProductPanel
            productsPanel = New productsPanel
            employeesPanel = New employeesPanel
            insertEmployeePanel = New insertEmployeePanel
            saleView = New saleView
            customerPanel = New customerPanel
            insertCustomerPanel = New insertCustomerPanel
            supplierPanel = New supplierPanel
            insertSupplierPanel = New insertSupplier
            viewReportsPanel = New viewReportsStatistics
            graphPanel = New graphPanel
            lowStockPanel = New lowStockPanel
            viewOrdersPanel = New viewOrdersPanel
            Dim aboutPanel = New AboutPanel

            displayPanel.Controls.Clear()

            displayPanel.Controls.Add(loginPanel)

        End If


    End Sub

    Private Sub newSaleTile_Click(sender As Object, e As EventArgs) Handles newSaleTile.Click
        displayPanel.Controls.Clear()
        salePanel = New salePanel
        displayPanel.Controls.Add(salePanel)
    End Sub

	Private Sub managementTasksTile_Click(sender As Object, e As EventArgs) Handles managementTasksTile.Click
		displayPanel.Controls.Clear()
		displayPanel.Controls.Add(taskPanel)
	End Sub

    Private Sub viewLowStockTile_Click(sender As Object, e As EventArgs) Handles viewLowStockTile.Click
        displayPanel.Controls.Clear()
        lowStockPanel = New lowStockPanel
        displayPanel.Controls.Add(lowStockPanel)
    End Sub

	Private Sub viewOrdersTile_Click(sender As Object, e As EventArgs) Handles viewOrdersTile.Click
		displayPanel.Controls.Clear()
		viewOrdersPanel = New viewOrdersPanel
		displayPanel.Controls.Add(viewOrdersPanel)
	End Sub
End Class
