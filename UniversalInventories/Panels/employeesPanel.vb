﻿Public Class employeesPanel
	Private Sub employeesPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		EMPLOYEETableAdapter.Fill(DSSystem.EMPLOYEE)
	End Sub


    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If emailValidation() = True Then
            Try
                EMPLOYEEBindingSource.EndEdit()
                EMPLOYEETableAdapter.Update(DSSystem.EMPLOYEE)
            Catch ex As Exception
                MessageBox.Show("Error! Update failed. " & ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Error! Email is not valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        EmployeeDataGridView.Focus()
    End Sub

    Private Sub searchTxt_TextChanged(sender As Object, e As EventArgs) Handles searchTxt.TextChanged
		Try
			If searchTxt.Text.Equals("") = False Then
				Dim s As Integer = CInt(searchTxt.Text)
				EMPLOYEETableAdapter.FillByEmpID(DSSystem.EMPLOYEE, s)
			Else
				EMPLOYEETableAdapter.Fill(DSSystem.EMPLOYEE)
			End If
		Catch ex As Exception
			MessageBox.Show("Error! Employee ID contains digits only.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			searchTxt.SelectAll()

		End Try
	End Sub

	Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        MainForm.displayPanel.Controls.Clear()
        MainForm.insertEmployeePanel = New insertEmployeePanel
        MainForm.displayPanel.Controls.Add(MainForm.insertEmployeePanel)
	End Sub

	Private Sub searchByNameTxt_TextChanged(sender As Object, e As EventArgs) Handles searchByNameTxt.TextChanged
		EMPLOYEETableAdapter.searchByName(DSSystem.EMPLOYEE, searchByNameTxt.Text)
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
End Class
