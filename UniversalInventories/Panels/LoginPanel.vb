Imports MetroFramework
Imports System.Data.SqlClient

Public Class LoginPanel

    Public successfulLogin As Boolean = False
    Public Shared employeeID As String

    Private Sub LoginPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Fill
        usernameLabel.FontSize = MetroFramework.MetroLabelSize.Tall

        passwordLabel.FontSize = MetroFramework.MetroLabelSize.Tall


    End Sub

    Private Sub loginButton_Click(sender As Object, e As EventArgs) Handles loginButton.Click
        Try
            Dim id As String = CInt(usernameTextbox.Text)
            Dim password As String = passwordTextbox.Text

            EmployeeTableAdapter.loginTest(DsSystem.EMPLOYEE, id, password)
            If DsSystem.EMPLOYEE.Rows.Count = 1 Then
                MainForm.employeeID = DsSystem.EMPLOYEE.Rows(0).Item(0)

                MainForm.lblNameSurname.Visible = False
                MainForm.lblNameSurname.Text = DsSystem.EMPLOYEE.Rows(0).Item(1) & " " & DsSystem.EMPLOYEE.Rows(0).Item(2)
                MainForm.lblUsername.Text = DsSystem.EMPLOYEE.Rows(0).Item(1) & " " & DsSystem.EMPLOYEE.Rows(0).Item(2)
                MainForm.lblUsername.Visible = True
                MainForm.lblEmployeeID.Text = DsSystem.EMPLOYEE.Rows(0).Item(0)
                MainForm.lblEmployeeID.Visible = False
                MainForm.lblEmpRole.Text = DsSystem.EMPLOYEE.Rows(0).Item(10)
                MainForm.lblEmpRole.Visible = False

                MainForm.displayPanel.Controls.Clear()
                MainForm.loginLogoutTile.Visible = True
                MainForm.newSaleTile.Visible = True
                MainForm.aboutTile.Visible = True
                MainForm.lblNameSurnameTEXT.Visible = True
                MainForm.lblEmployeeIDTEXT.Visible = False
                MainForm.lblEmpRoleTEXT.Visible = False
                usernameTextbox.Clear()
                passwordTextbox.Clear()
                If DsSystem.EMPLOYEE.Rows(0).Item(10).Equals("Manager") Then
                    MainForm.managementTasksTile.Visible = True
                    MainForm.viewLowStockTile.Visible = True
                    MainForm.viewOrdersTile.Visible = True
                End If
                MessageBox.Show("Login successful!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                MessageBox.Show("Error! Username or password incorrect.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error! Username or password incorrect.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub passwordTextbox_KeyDown(sender As Object, e As KeyEventArgs) Handles passwordTextbox.KeyDown
        If e.KeyCode = Keys.Enter Then
            loginButton_Click(sender, e)
        End If
    End Sub
End Class
