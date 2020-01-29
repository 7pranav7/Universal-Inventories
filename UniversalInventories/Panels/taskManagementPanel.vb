Imports MetroFramework
Public Class taskManagementPanel
	Public Shared productPanel As productsPanel = New productsPanel
	Private Sub taskManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		employeesTile.TileTextFontSize = MetroTileTextSize.Tall
		employeesTile.TileTextFontWeight = MetroTileTextWeight.Bold
		employeesTile.TextAlign = ContentAlignment.MiddleCenter

		customersTile.TileTextFontSize = MetroTileTextSize.Tall
		customersTile.TileTextFontWeight = MetroTileTextWeight.Bold
		customersTile.TextAlign = ContentAlignment.MiddleCenter

		productsTile.TileTextFontSize = MetroTileTextSize.Tall
		productsTile.TileTextFontWeight = MetroTileTextWeight.Bold
		productsTile.TextAlign = ContentAlignment.MiddleCenter

		salesTile.TileTextFontSize = MetroTileTextSize.Tall
		salesTile.TileTextFontWeight = MetroTileTextWeight.Bold
		salesTile.TextAlign = ContentAlignment.MiddleCenter

        reportsTile.TileTextFontSize = MetroTileTextSize.Tall
        reportsTile.TileTextFontWeight = MetroTileTextWeight.Bold
        reportsTile.TextAlign = ContentAlignment.MiddleCenter
        reportsTile.Text = "View Reports && " & Environment.NewLine & "Statistics"

        suppliersTile.TileTextFontSize = MetroTileTextSize.Tall
        suppliersTile.TileTextFontWeight = MetroTileTextWeight.Bold
        suppliersTile.TextAlign = ContentAlignment.MiddleCenter



    End Sub

	Private Sub productsTile_Click(sender As Object, e As EventArgs) Handles productsTile.Click
        MainForm.displayPanel.Controls.Clear()
        MainForm.productsPanel = New productsPanel
        MainForm.displayPanel.Controls.Add(MainForm.productsPanel)
	End Sub

	Private Sub employeesTile_Click(sender As Object, e As EventArgs) Handles employeesTile.Click
        MainForm.displayPanel.Controls.Clear()
        MainForm.employeesPanel = New employeesPanel
        MainForm.displayPanel.Controls.Add(MainForm.employeesPanel)
	End Sub

    Private Sub salesTile_Click(sender As Object, e As EventArgs) Handles salesTile.Click
        MainForm.displayPanel.Controls.Clear()
        MainForm.saleView = New saleView
        MainForm.displayPanel.Controls.Add(MainForm.saleView)
    End Sub

	Private Sub customersTile_Click(sender As Object, e As EventArgs) Handles customersTile.Click
        MainForm.displayPanel.Controls.Clear()
        MainForm.customerPanel = New customerPanel
        MainForm.displayPanel.Controls.Add(MainForm.customerPanel)
	End Sub

	Private Sub suppliersTile_Click(sender As Object, e As EventArgs) Handles suppliersTile.Click
        MainForm.displayPanel.Controls.Clear()
        MainForm.supplierPanel = New supplierPanel
        MainForm.displayPanel.Controls.Add(MainForm.supplierPanel)
	End Sub

    Private Sub reportsTile_Click(sender As Object, e As EventArgs) Handles reportsTile.Click
        MainForm.displayPanel.Controls.Clear()
        MainForm.viewReportsPanel = New viewReportsStatistics
        MainForm.displayPanel.Controls.Add(MainForm.viewReportsPanel)
    End Sub
End Class
