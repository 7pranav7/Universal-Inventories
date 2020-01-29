Public Class insertEmployeePanel
    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        If nameTxt.Text.Equals("") Or surnameTxt.Text.Equals("") Or numberTxt.Text.Equals("") Or emailTxt.Text.Equals("") Or addressTxt.Text.Equals("") Or suburbTxt.Text.Equals("") Or cityTxt.Text.Equals("") Or provinceTxt.Text.Equals("") Or postalTxt.Text.Equals("") Or cmbType.SelectedItem Is Nothing Or passwordTxt.Text.Equals("") Then
            MessageBox.Show("Error! All fields must be filled in", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            If emailValidation() = True And lblAlreadyInUse.Visible = False And cellValidation() = True And postalValidation() = True Then
                If passwordTxt.Text.Length > 6 Then
                    EmployeeTableAdapter1.Insert(nameTxt.Text, surnameTxt.Text, numberTxt.Text, emailTxt.Text, addressTxt.Text, suburbTxt.Text, cityTxt.Text, provinceTxt.Text, postalTxt.Text, cmbType.SelectedItem, passwordTxt.Text)
                    EmployeeTableAdapter1.Fill(DsSystem1.EMPLOYEE)
                    MessageBox.Show("Employee added successfully!", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    MainForm.displayPanel.Controls.Clear()
                    MainForm.employeesPanel.EMPLOYEETableAdapter.Fill(MainForm.employeesPanel.DSSystem.EMPLOYEE)
                    MainForm.displayPanel.Controls.Add(MainForm.employeesPanel)
                Else
                    MessageBox.Show("Password must be at least 6 characters.", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    passwordTxt.Focus()
                End If

            Else
                MessageBox.Show("Error! Please enter a valid email address.", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End If





    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        MainForm.displayPanel.Controls.Clear()
        MainForm.displayPanel.Controls.Add(MainForm.employeesPanel)
    End Sub
    Private Function emailValidation() As Boolean
        If emailTxt.Text.Equals("") Then
            Return False
        End If
        Dim email As String = emailTxt.Text
        If email.Substring(0, 1).Equals(".") Then
            Return False
        End If

        If email.Contains(",") Or email.Contains("~") Or email.Contains("`") Or email.Contains("!") Or email.Contains("#") Or email.Contains("$") Or email.Contains("%") Or email.Contains("^") Or email.Contains("&") Or email.Contains("8") Or email.Contains("(") Or email.Contains(")") Or email.Contains("+") Or email.Contains("=") Or email.Contains("/") Or email.Contains("\") Or email.Contains("|") Or email.Contains("{") Or email.Contains("}") Or email.Contains(";") Or email.Contains(":") Or email.Contains("'") Or email.Contains("?") Or email.Contains(">") Or email.Contains("<") Then
            Return False

        End If
        For i As Integer = 0 To email.Length - 1
            If i = email.Length - 1 Then
                If email.Substring(i).Equals(".") Or email.Substring(i).Equals("-") Or email.Substring(i).Equals("_") Then
                    Return False
                End If
            End If
            If email.Substring(i, 1).Equals(".") Or email.Substring(i, 1).Equals("-") Or email.Substring(i, 1).Equals("_") Then
                If i = email.Length - 1 Then
                    Return False
                Else
                    Dim c As Char
                    Try
                        c = email.Substring(i + 1, 1)
                    Catch ex As Exception
                        c = email.Substring(i + 1)
                    End Try

                    Dim asc As Integer = AscW(c)
                    If (asc < 65 Or (asc > 90 And asc < 97) Or asc > 122) Then
                        Return False
                    End If
                End If
            End If
        Next

        Dim afterAt As String = email.Substring(email.LastIndexOf("@"))
        If afterAt.Contains(".") = False Then
            Return False
        End If
        If afterAt.Substring(1, 1).Equals(".") Then
            Return False
        End If
        Dim last As String = afterAt.Substring(afterAt.LastIndexOf("."))
        If last.Length <= 2 Then
            Return False
        End If
        Return True
    End Function

    Private Sub emailTxt_Leave(sender As Object, e As EventArgs) Handles emailTxt.Leave
        EmployeeTableAdapter1.FillByEmail(DsSystem1.EMPLOYEE, emailTxt.Text)
        If (DsSystem1.EMPLOYEE.Rows.Count > 0) Then
            lblAlreadyInUse.Visible = True
        Else
            lblAlreadyInUse.Visible = False
        End If
    End Sub
    Private Function cellValidation() As Boolean
        Dim cell As String = numberTxt.Text
        For i As Integer = 0 To cell.Length - 1
            Dim c As Char = cell.Substring(i, 1)
            Dim asc As Integer = AscW(c)
            If (asc < 48 Or asc > 57) Then
                Return False
            End If

        Next
        Return True
    End Function

    Private Function postalValidation() As Boolean
        Dim post As String = postalTxt.Text
        For i As Integer = 0 To post.Length - 1
            Dim c As Char = post.Substring(i, 1)
            Dim asc As Integer = AscW(c)
            If (asc < 48 Or asc > 57) Then
                Return False
            End If

        Next
        Return True
    End Function
End Class
