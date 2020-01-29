Public Class saleView

    Private Sub saleManagementPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SALETableAdapter.Fill(DSSystem.SALE)
        JOINT_SALE_PRODUCTTableAdapter.Fill(DSSystem.JOINT_SALE_PRODUCT, SALEDataGridView.CurrentRow.Cells(0).Value)
        JOINT_EMPLOYEE_SALETableAdapter.Fill(DSSystem.JOINT_EMPLOYEE_SALE, SALEDataGridView.CurrentRow.Cells(0).Value)
        setProfitCost()
    End Sub

    Private Sub SALEDataGridView_SelectionChanged(sender As Object, e As EventArgs) Handles SALEDataGridView.SelectionChanged
        Try
            lblPurchaseType.Text = ""
            lblEmp.Text = ""
            txtCost.Text = ""
            txtProfit.Text = ""
            txtSaleTotal.Text = ""
            lblCustomerID.Text = ""
            lblStatus.Text = ""

            JOINT_SALE_PRODUCTTableAdapter.Fill(DSSystem.JOINT_SALE_PRODUCT, SALEDataGridView.CurrentRow.Cells(0).Value)
            JOINT_EMPLOYEE_SALETableAdapter.Fill(DSSystem.JOINT_EMPLOYEE_SALE, SALEDataGridView.CurrentRow.Cells(0).Value)
            lblEmp.Text = JOINT_EMPLOYEE_SALEDataGridView.Rows(0).Cells(0).Value & " " & JOINT_EMPLOYEE_SALEDataGridView.Rows(0).Cells(1).Value
            setProfitCost()
            txtSaleTotal.Text = FormatCurrency(CDbl(SALEDataGridView.CurrentRow.Cells(2).Value))

            If SALEDataGridView.CurrentRow.Cells(3).Value = False And SALEDataGridView.CurrentRow.Cells(4).Value = False Then
                lblPurchaseType.ForeColor = Color.Black
                lblPurchaseType.Text = "In-Store Purchase"
                lblCustIDText.Visible = False
                lblCustomerID.Visible = False
                lblStatus.Visible = False
                lblStatusText.Visible = False
            ElseIf SALEDataGridView.CurrentRow.Cells(3).Value = False And SALEDataGridView.CurrentRow.Cells(4).Value = True Then
                lblPurchaseType.Text = "In-Store Purchase for Delivery"
                lblPurchaseType.ForeColor = Color.DarkOrange
                lblCustIDText.Visible = True
                lblCustomerID.Visible = True
                lblStatus.Visible = True
                lblStatusText.Visible = True
                Dim custID As Integer = CInt(DSSystem.SALE.Rows(SALEDataGridView.CurrentRow.Index).Item(6))
                lblCustomerID.Text = custID

                Dim status As Boolean = CBool(DSSystem.SALE.Rows(SALEDataGridView.CurrentRow.Index).Item(7))
                If status = True Then
                    lblStatus.Text = "Completed"
                    lblStatus.ForeColor = Color.LimeGreen
                Else
                    lblStatus.Text = "NOT COMPLETE"
                    lblStatus.ForeColor = Color.Red
                End If
            ElseIf SALEDataGridView.CurrentRow.Cells(3).Value = True And SALEDataGridView.CurrentRow.Cells(4).Value = True Then
                lblPurchaseType.Text = "Online Purchase for Delivery"
                lblPurchaseType.ForeColor = Color.DarkOrange
                lblCustIDText.Visible = True
                lblCustomerID.Visible = True
                lblStatus.Visible = True
                lblStatusText.Visible = True
                Dim custID As Integer = CInt(DSSystem.SALE.Rows(SALEDataGridView.CurrentRow.Index).Item(6))
                lblCustomerID.Text = custID

                Dim status As Boolean = CBool(DSSystem.SALE.Rows(SALEDataGridView.CurrentRow.Index).Item(7))
                If status = True Then
                    lblStatus.Text = "Completed"
                    lblStatus.ForeColor = Color.LimeGreen
                Else
                    lblStatus.Text = "NOT COMPLETE"
                    lblStatus.ForeColor = Color.Red
                End If
            ElseIf SALEDataGridView.CurrentRow.Cells(3).Value = True And SALEDataGridView.CurrentRow.Cells(4).Value = False Then
                lblPurchaseType.Text = "Online Purchase for Pickup"
                lblPurchaseType.ForeColor = Color.DarkOrange
                lblCustIDText.Visible = True
                lblCustomerID.Visible = True
                lblStatus.Visible = True
                lblStatusText.Visible = True
                Dim custID As Integer = CInt(DSSystem.SALE.Rows(SALEDataGridView.CurrentRow.Index).Item(6))
                lblCustomerID.Text = custID

                Dim status As Boolean = CBool(DSSystem.SALE.Rows(SALEDataGridView.CurrentRow.Index).Item(7))
                If status = True Then
                    lblStatus.Text = "Completed"
                    lblStatus.ForeColor = Color.LimeGreen
                Else
                    lblStatus.Text = "NOT COMPLETE"
                    lblStatus.ForeColor = Color.Red
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtSaleID_TextChanged(sender As Object, e As EventArgs) Handles txtSaleID.TextChanged

        Try
            If txtSaleID.Text.Equals("") = False Then
                DSSystem.JOINT_SALE_PRODUCT.Rows.Clear()
                DSSystem.JOINT_EMPLOYEE_SALE.Rows.Clear()
                SALETableAdapter.SearchBySaleID(DSSystem.SALE, CInt(txtSaleID.Text))
            Else
                SALETableAdapter.Fill(DSSystem.SALE)
            End If
        Catch ex As Exception
            MessageBox.Show("Error! Sale ID contains digits only.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtSaleID.SelectAll()

        End Try
    End Sub

    Private Sub DateTime_ValueChanged(sender As Object, e As EventArgs) Handles DateTime.ValueChanged
        Try
            Dim d As Date = DateTime.Value
            DSSystem.JOINT_SALE_PRODUCT.Rows.Clear()
            DSSystem.JOINT_EMPLOYEE_SALE.Rows.Clear()
            SALETableAdapter.SearchByDate(DSSystem.SALE, d)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        DateTime.ResetText()
        SALETableAdapter.Fill(DSSystem.SALE)
        SALEDataGridView.Focus()

    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        Try
            Dim fromDate As Date = FromDateTime.Value
            Dim toDate As Date = ToDateTime.Value
            If fromDate < toDate Then
                DSSystem.JOINT_SALE_PRODUCT.Rows.Clear()
                DSSystem.JOINT_EMPLOYEE_SALE.Rows.Clear()
                SALETableAdapter.FillBetweenDates(DSSystem.SALE, fromDate, toDate)
            Else
                MessageBox.Show("To Date cannot be before or equal to From Date.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            SALEDataGridView.Focus()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnReset2_Click(sender As Object, e As EventArgs) Handles btnReset2.Click
        FromDateTime.ResetText()
        ToDateTime.ResetText()
        SALETableAdapter.Fill(DSSystem.SALE)
        SALEDataGridView.Focus()
    End Sub

    Private Function getCostTotal() As Double
        Dim total As Double
        For i As Integer = 0 To JOINT_SALE_PRODUCTDataGridView.RowCount - 1
            total += (CDbl(JOINT_SALE_PRODUCTDataGridView.Rows(i).Cells(2).Value) * CDbl(JOINT_SALE_PRODUCTDataGridView.Rows(i).Cells(4).Value))
        Next
        Return total
    End Function

    Private Sub setProfitCost()
        Dim cost As Double = getCostTotal()
        txtCost.Text = FormatCurrency(cost)
        Dim profit As Double = CDbl(SALEDataGridView.CurrentRow.Cells(2).Value) - cost
        txtProfit.Text = FormatCurrency(profit)
    End Sub

    Private Sub cbViewOrdersOnly_CheckedChanged(sender As Object, e As EventArgs) Handles cbViewOrdersOnly.CheckedChanged
        If cbViewOrdersOnly.Checked = True Then
            DSSystem.JOINT_SALE_PRODUCT.Rows.Clear()
            DSSystem.JOINT_EMPLOYEE_SALE.Rows.Clear()
            SALETableAdapter.FillByOrderSALEVIEW(DSSystem.SALE)
        Else
            SALETableAdapter.Fill(DSSystem.SALE)
        End If
    End Sub
End Class
