Public Class salePanel
    Dim customerID As Integer
    Private Sub salePanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PRODUCTTableAdapter.FillSale(DSSystem.PRODUCT)
    End Sub

    Private Sub btnAddtoInvoice_Click(sender As Object, e As EventArgs) Handles btnAddtoInvoice.Click
        If quantityNumericUpDown.Value > ProductDataGridView.CurrentRow.Cells(3).Value Then
            MessageBox.Show("Error! Not enough stock.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            INVOICEDataGridView.Focus()
        Else
            Dim DR As DataRow = InvoiceDsSystem.INVOICE.NewINVOICERow
            DR.Item(0) = ProductDataGridView.CurrentRow.Cells(0).Value
            DR.Item(1) = ProductDataGridView.CurrentRow.Cells(1).Value
            DR.Item(2) = ProductDataGridView.CurrentRow.Cells(2).Value
            For i As Integer = 0 To DSSystem.PRODUCT.Rows.Count - 1
                If ProductDataGridView.CurrentRow.Cells(0).Value = DSSystem.PRODUCT.Rows(i).Item(0) Then
                    DR.Item(3) = DSSystem.PRODUCT.Rows(i).Item(6)
                End If
            Next

            DR.Item(4) = quantityNumericUpDown.Value
            Dim subtotal As Double = quantityNumericUpDown.Value * CDbl(ProductDataGridView.CurrentRow.Cells(2).Value)
            DR.Item(5) = subtotal
            Try
                InvoiceDsSystem.INVOICE.AddINVOICERow(DR)
                ProductDataGridView.CurrentRow.Cells(3).Value -= quantityNumericUpDown.Value
                txtTotal.Text = FormatCurrency(getTotal())
                If ProductDataGridView.CurrentRow.Cells(3).Value < DSSystem.PRODUCT.Rows(ProductDataGridView.CurrentRow.Index).Item(8) Then
                    If MainForm.lblEmpRole.Text.Equals("Manager") Then
                        MessageBox.Show(ProductDataGridView.CurrentRow.Cells(1).Value & " stock levels are low.", "Stock Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Else
                        MessageBox.Show(ProductDataGridView.CurrentRow.Cells(1).Value & " stock levels are low. Please notify Manager", "Stock Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If

                End If
            Catch ex As Exception
                MessageBox.Show("Error! Item already added to invoice. To change quantity remove item from invoice then add item again with correct quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            INVOICEDataGridView.Focus()


        End If
    End Sub

    Private Function getTotal() As Double
        Dim total As Double
        For i As Integer = 0 To INVOICEDataGridView.RowCount - 1
            total += INVOICEDataGridView.Rows(i).Cells(5).Value
        Next
        Return total
    End Function





    Private Sub searchByNameTxt_TextChanged(sender As Object, e As EventArgs) Handles searchByNameTxt.TextChanged
        PRODUCTTableAdapter.SearchByProductNameSale(DSSystem.PRODUCT, searchByNameTxt.Text)
    End Sub

    Private Sub searchByIDTxt_TextChanged(sender As Object, e As EventArgs) Handles searchByIDTxt.TextChanged
        Try
            If searchByIDTxt.Text.Equals("") = False Then
                Dim s As Integer = CInt(searchByIDTxt.Text)
                PRODUCTTableAdapter.SearchByProductIDSale(DSSystem.PRODUCT, s)
            Else
                PRODUCTTableAdapter.FillSale(DSSystem.PRODUCT)
            End If
        Catch ex As Exception
            MessageBox.Show("Error! Product ID contains digits only.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            searchByIDTxt.SelectAll()

        End Try

    End Sub

    Private Sub btnRemoveFromInvoice_Click(sender As Object, e As EventArgs) Handles btnRemoveFromInvoice.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to remove product from invoice?", "Remove from Invoice", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dim quantity As Integer = INVOICEDataGridView.CurrentRow.Cells(4).Value
            Dim ID As Integer = INVOICEDataGridView.CurrentRow.Cells(0).Value
            InvoiceDsSystem.INVOICE.Rows(INVOICEDataGridView.CurrentRow.Index).Delete()
            For i As Integer = 0 To ProductDataGridView.RowCount - 1
                If ProductDataGridView.Rows(i).Cells(0).Value = ID Then
                    ProductDataGridView.Rows(i).Cells(3).Value += quantity
                End If
            Next
            txtTotal.Text = FormatCurrency(getTotal())
            INVOICEDataGridView.Focus()

        End If


    End Sub

	Private Sub btnProcess_Click(sender As Object, e As EventArgs) Handles btnProcess.Click

		If INVOICEDataGridView.RowCount > 0 Then
			Try
				Dim amt As Double = CDbl(InputBox("Enter amount received: "))
				If amt < CDbl(txtTotal.Text) Then
					MessageBox.Show("Error! Insufficient amount of money received.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
					INVOICEDataGridView.Focus()
				Else
					Dim change As Double = amt - CDbl(txtTotal.Text)
					MessageBox.Show(FormatCurrency(change) & " to be given in change.", "Change", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Try
                        PRODUCTBindingSource.EndEdit()
                        PRODUCTTableAdapter.Update(DSSystem.PRODUCT)
                        Dim saleID As Integer
                        MainForm.ReceiptPanel = New ReceiptPanel
                        If cbDelivery.Checked = True Then
                            saleID = SaleTableAdapter.Insert1(Date.Now(), CDbl(txtTotal.Text), False, True, MainForm.employeeID, customerID, False)
                            ReceiptPanel.customerString = "Delivery for " & DSSystem.CUSTOMER.Rows(0).Item(1) & " " & DSSystem.CUSTOMER.Rows(0).Item(2) & vbLf & vbLf & "Contact Number: " & DSSystem.CUSTOMER.Rows(0).Item(3) & vbLf & vbLf & "Address: " & vbLf & DSSystem.CUSTOMER.Rows(0).Item(5) & vbLf & DSSystem.CUSTOMER.Rows(0).Item(6) & vbLf & DSSystem.CUSTOMER.Rows(0).Item(7) & vbLf & DSSystem.CUSTOMER.Rows(0).Item(8) & vbLf & DSSystem.CUSTOMER.Rows(0).Item(9)
                        Else
                            saleID = SaleTableAdapter.Insert1(Date.Now(), CDbl(txtTotal.Text), False, False, MainForm.employeeID, Nothing, True)
                            ReceiptPanel.customerString = ""
                        End If


                        ReceiptPanel.saleID = saleID

                        For i As Integer = 0 To INVOICEDataGridView.RowCount - 1
                            Sale_ItemTableAdapter.Insert(INVOICEDataGridView.Rows(i).Cells(0).Value, saleID, INVOICEDataGridView.Rows(i).Cells(2).Value, INVOICEDataGridView.Rows(i).Cells(4).Value, INVOICEDataGridView.Rows(i).Cells(5).Value, INVOICEDataGridView.Rows(i).Cells(3).Value)
                        Next




                        MainForm.displayPanel.Controls.Clear()
                        MainForm.displayPanel.Controls.Add(MainForm.ReceiptPanel)
                    Catch ex As Exception
                        MessageBox.Show("Error! Process sale failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        INVOICEDataGridView.Focus()
                    End Try


                End If
			Catch ex As Exception
				MessageBox.Show("Error! Enter a valid amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
				INVOICEDataGridView.Focus()
			End Try

		Else
			MessageBox.Show("Error! No products added to invoice.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			INVOICEDataGridView.Focus()
		End If

	End Sub



    Private Sub cbDelivery_Click(sender As Object, e As EventArgs) Handles cbDelivery.Click
        Dim result As DialogResult = MessageBox.Show("Does Customer have an account?", "Delivery", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then
            If MainForm.lblEmpRole.Text.Equals("Manager") Then
                MessageBox.Show("Please add Customer to system first then process sale for delivery.", "Delivery", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Please ask manager to login and add Customer", "Delivery", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            cbDelivery.Checked = False
        ElseIf result = DialogResult.Yes Then
            Dim email As String = InputBox("Enter Customer Email: ")
            'Dim password As String = InputBox("Ask Customer to enter their password: ")
            CustomerTableAdapter.FillByEmail(DSSystem.CUSTOMER, email)
            If DSSystem.CUSTOMER.Rows.Count = 1 Then
                customerID = DSSystem.CUSTOMER.Rows(0).Item(0)
            Else
                MessageBox.Show("Email not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cbDelivery.Checked = False
            End If
        End If
    End Sub

    Private Sub txtDesc_TextChanged(sender As Object, e As EventArgs) Handles txtDesc.TextChanged
        PRODUCTTableAdapter.SearchByProductDescription(DSSystem.PRODUCT, txtDesc.Text)
    End Sub


End Class
