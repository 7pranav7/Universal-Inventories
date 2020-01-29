Public Class viewOrdersPanel
    Private Sub viewOrdersPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblOrderType.Visible = False
        Try
            SALETableAdapter.OrderFill(DSSystem.SALE)
            JOINT_SALE_PRODUCTTableAdapter.Fill(DSSystem.JOINT_SALE_PRODUCT, SALEDataGridView.CurrentRow.Cells(0).Value)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub SALEDataGridView_SelectionChanged(sender As Object, e As EventArgs) Handles SALEDataGridView.SelectionChanged
        lblOrderType.Visible = True
        Try
            JOINT_SALE_PRODUCTTableAdapter.Fill(DSSystem.JOINT_SALE_PRODUCT, SALEDataGridView.CurrentRow.Cells(0).Value)

            If DSSystem.SALE.Rows(SALEDataGridView.CurrentRow.Index).Item(3) = True And DSSystem.SALE.Rows(SALEDataGridView.CurrentRow.Index).Item(4) = True Then
                lblOrderType.Text = "Online Purchase for Delivery"
            ElseIf DSSystem.SALE.Rows(SALEDataGridView.CurrentRow.Index).Item(3) = True And DSSystem.SALE.Rows(SALEDataGridView.CurrentRow.Index).Item(4) = False Then
                lblOrderType.Text = "Online Purchase for Pickup"
            ElseIf DSSystem.SALE.Rows(SALEDataGridView.CurrentRow.Index).Item(3) = False And DSSystem.SALE.Rows(SALEDataGridView.CurrentRow.Index).Item(4) = True Then
                lblOrderType.Text = "In-Store Purchase for Delivery"

            End If

            Dim customerID As Integer = CInt(SALEDataGridView.CurrentRow.Cells(3).Value)
            CustomerTableAdapter.FillByCustID(DSSystem.CUSTOMER, customerID)
            txtName.Text = DSSystem.CUSTOMER.Rows(0).Item(1) & " " & DSSystem.CUSTOMER.Rows(0).Item(2)
            txtNumber.Text = DSSystem.CUSTOMER.Rows(0).Item(3)
            txtEmail.Text = DSSystem.CUSTOMER.Rows(0).Item(4)
            ListBox.Items.Clear()
            For i As Integer = 5 To 9
                ListBox.Items.Add(DSSystem.CUSTOMER.Rows(0).Item(i))
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
        Try
            SALEDataGridView.CurrentRow.Cells(4).Value = True
            SALEBindingSource.EndEdit()
            SALETableAdapter.Update(DSSystem.SALE)
            SALETableAdapter.OrderFill(DSSystem.SALE)
            SALEDataGridView.Focus()
            MessageBox.Show("Order Completed!", "Order", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error! Order not Completed.", "Order Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class
