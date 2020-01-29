Imports MetroFramework
Public Class productsPanel
    Private Sub productsPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PRODUCTTableAdapter.Fill(DSSystem.PRODUCT)
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        PRODUCTBindingSource.EndEdit()
        PRODUCTTableAdapter.Update(DSSystem.PRODUCT)
        ProductDataGridView.Focus()
        ProductDataGridView_SelectionChanged(sender, e)
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Dim result As DialogResult = MessageBox.Show("Is product supplied by a new supplier?", "Product Supplier", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            MessageBox.Show("Please add new supplier first before adding new product.", "Product Supplier", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
        If result = DialogResult.No Then
            MainForm.displayPanel.Controls.Clear()
            MainForm.insertProductPanel = New insertProductPanel
            MainForm.displayPanel.Controls.Add(MainForm.insertProductPanel)
            PRODUCTTableAdapter.Fill(DSSystem.PRODUCT)

        End If
        ProductDataGridView.Focus()
    End Sub



    Private Sub searchByNameTxt_TextChanged(sender As Object, e As EventArgs) Handles searchByNameTxt.TextChanged
        PRODUCTTableAdapter.SearchByProductName(DSSystem.PRODUCT, searchByNameTxt.Text)
    End Sub

    Private Sub searchByIDTxt_TextChanged(sender As Object, e As EventArgs) Handles searchByIDTxt.TextChanged
        Try
            If searchByIDTxt.Text.Equals("") = False Then
                Dim s As Integer = CInt(searchByIDTxt.Text)
                PRODUCTTableAdapter.SearchByProductID(DSSystem.PRODUCT, s)
            Else
                PRODUCTTableAdapter.Fill(DSSystem.PRODUCT)
            End If
        Catch ex As Exception
            MessageBox.Show("Error! Product ID contains digits only.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            searchByIDTxt.SelectAll()

        End Try
    End Sub

    Private Sub btnDeactivate_Click(sender As Object, e As EventArgs) Handles btnDeactivate.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to deactivate selected product?", "Deactivate Selected Product", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            txtQuantity.Text = "-1"
            btnUpdate_Click(sender, e)

        End If
        ProductDataGridView.Focus()
    End Sub

    Private Sub ProductDataGridView_SelectionChanged(sender As Object, e As EventArgs) Handles ProductDataGridView.SelectionChanged
        Try
            JoinT_PRODUCT_SUPPLIERTableAdapter.FillByProductID(DSSystem.JOINT_PRODUCT_SUPPLIER, CInt(ProductDataGridView.CurrentRow.Cells(0).Value))

            txtSupplier.Text = DSSystem.JOINT_PRODUCT_SUPPLIER.Rows(0).Item(1)
            txtLastSupplied.Text = DSSystem.JOINT_PRODUCT_SUPPLIER.Rows(0).Item(3)

            If ProductDataGridView.CurrentRow.Cells(3).Value > 0 Then
                lblActive.Text = "Active"
                lblActive.ForeColor = Color.LimeGreen
            Else
                lblActive.Text = "Inactive"
                lblActive.ForeColor = Color.Red
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnAddStock_Click(sender As Object, e As EventArgs) Handles btnAddStock.Click
        Try
            Dim quantity As Integer = CInt(InputBox("Enter stock quantity to add:"))
            txtQuantity.Text = CStr(CInt(txtQuantity.Text) + quantity)
            Dim cpr As Double = CDbl(InputBox("Enter cost price per unit:"))
            Dim dateTime As DateTime = Now()
            cpTxt.Text = FormatCurrency(cpr)
            cpTxt_Leave(sender, e)
            Try

                Product_SUPPLIERTableAdapter.Insert1(CInt(ProductDataGridView.CurrentRow.Cells(0).Value), CInt(DSSystem.JOINT_PRODUCT_SUPPLIER.Rows(0).Item(2)), dateTime, quantity, cpr)
                PRODUCTBindingSource.EndEdit()
                PRODUCTTableAdapter.Update(DSSystem.PRODUCT)
                ProductDataGridView_SelectionChanged(sender, e)
                MessageBox.Show("Stock quantity has been addded successfully!", "Add Stock", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ProductDataGridView.Focus()
            Catch ex As Exception
                MessageBox.Show("Error! Stock has already been added today. Please try again tomorrow." & ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                PRODUCTTableAdapter.Fill(DSSystem.PRODUCT)
                ProductDataGridView.Focus()
            End Try
        Catch ex As Exception
            MessageBox.Show("Error! Please enter digits only and use a comma for decimals.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            PRODUCTTableAdapter.Fill(DSSystem.PRODUCT)
            ProductDataGridView.Focus()
        End Try

    End Sub

    Private Sub markupTxt_Leave(sender As Object, e As EventArgs) Handles markupTxt.Leave
        Try

            Dim markup As Double = CDbl(markupTxt.Text)
            priceTxt.Text = FormatCurrency(CStr(CDbl(((cpTxt.Text) * ((100 + markup) / 100)) * ((100 + MainForm.insertProductPanel.vat) / 100))))
        Catch ex As Exception
            MessageBox.Show("Error! Please enter digits only.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub priceTxt_Leave(sender As Object, e As EventArgs) Handles priceTxt.Leave
        Try

            Dim price As Double = CDbl(priceTxt.Text)
            markupTxt.Text = Format((((price / ((100 + MainForm.insertProductPanel.vat) / 100)) / CDbl(cpTxt.Text) * 100) - 100), "Standard")
        Catch ex As Exception
            MessageBox.Show("Error! Please enter digits only.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cpTxt_Leave(sender As Object, e As EventArgs) Handles cpTxt.Leave
        Try
            Dim costPrice As Double = CDbl(cpTxt.Text)
            priceTxt.Text = FormatCurrency(CStr(CDbl(((cpTxt.Text) * ((100 + CDbl(markupTxt.Text)) / 100)) * ((100 + MainForm.insertProductPanel.vat) / 100))))
        Catch ex As Exception
            MessageBox.Show("Error! Please enter digits only.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnVAT_Click(sender As Object, e As EventArgs) Handles btnVAT.Click
        Dim result As DialogResult = MessageBox.Show("Changing VAT percentage will result in updating every product price with the new VAT percentage." & vbLf & " Are you sure you want to continue?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)
        MetroLabel1.Focus()

        If result = DialogResult.Yes Then
            Dim newVAT As Double
            Try
                newVAT = InputBox("Enter new VAT percentage:")

                MainForm.insertProductPanel.vat = newVAT
                PRODUCTTableAdapter.UpdateVAT(newVAT)
                PRODUCTTableAdapter.Fill(DSSystem.PRODUCT)
                newVAT = newVAT / 100
                VatTableAdapter1.UpdateQuery(newVAT)
                MessageBox.Show("VAT percentage updated successfully!", "VAT Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'If System.IO.File.Exists("vat.txt") Then
                'Dim writer As New System.IO.StreamWriter("vat.txt")
                'writer.Write(newVAT)
                'writer.Close()
                'MainForm.insertProductPanel.vat = newVAT
                '
                'PRODUCTTableAdapter.UpdateVAT(newVAT)
                ' PRODUCTTableAdapter.Fill(DSSystem.PRODUCT)
                'MessageBox.Show("VAT percentage updated successfully!", "VAT Update", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' End If



            Catch ex As Exception
                MessageBox.Show("Please enter a valid number.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If
    End Sub
End Class
