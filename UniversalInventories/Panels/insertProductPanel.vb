Imports MetroFramework
Imports System.IO

Public Class insertProductPanel
    Public vat As Double
    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Dim price As Decimal
        Dim quantity As Integer
        Dim cpr As Decimal
        Dim markup As Decimal
        Dim threshold As Integer

        If Decimal.TryParse(priceNumericUpDown.Value, price) Then
            If (Integer.TryParse(QuantityNumericUpDown.Value, quantity)) Then
                If (Decimal.TryParse(costPriceNumericUpDown.Value, cpr)) Then
                    If (Decimal.TryParse(markupNumericUpDown.Value, markup)) Then
                        If (Integer.TryParse(thresholdNumericUpDown.Value, threshold)) Then
                            If nameTxt.Text.Length = 0 Then
                                MessageBox.Show("Please Enter Product Name", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Else
                                If supplierID >= 100 Then

                                    If cbNewCategory.Checked = False And cmbCategory.SelectedIndex = -1 Then
                                        MessageBox.Show("Please Select Category", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    ElseIf cbNewCategory.Checked = True And categoryTxt.Text.Length = 0 Then
                                        MessageBox.Show("Please Enter Category", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    ElseIf cbNewCategory.Checked = True Then
                                        Dim productID As Integer = ProductTableAdapter.InsertQuery(nameTxt.Text, price, quantity, descriptionTxt.Text, categoryTxt.Text, cpr, markup, threshold)
                                        ProductTableAdapter.Fill(DsSystem.PRODUCT)
                                        Product_SUPPLIERTableAdapter.Insert(productID, supplierID, Date.Now(), quantity, cpr)

                                        MessageBox.Show("Product added successfully!", "Add Product", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        MainForm.displayPanel.Controls.Clear()
                                        MainForm.productsPanel = New productsPanel
                                        MainForm.productsPanel.PRODUCTTableAdapter.Fill(MainForm.productsPanel.DSSystem.PRODUCT)
                                        MainForm.displayPanel.Controls.Add(MainForm.productsPanel)
                                    ElseIf cbNewCategory.Checked = False Then
                                        Dim productID As Integer = ProductTableAdapter.InsertQuery(nameTxt.Text, price, quantity, descriptionTxt.Text, cmbCategory.SelectedItem, cpr, markup, threshold)
                                        ProductTableAdapter.Fill(DsSystem.PRODUCT)
                                        Product_SUPPLIERTableAdapter.Insert(productID, supplierID, Date.Now(), quantity, cpr)

                                        MessageBox.Show("Product added successfully!", "Add Product", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        MainForm.displayPanel.Controls.Clear()
                                        MainForm.productsPanel = New productsPanel
                                        MainForm.productsPanel.PRODUCTTableAdapter.Fill(MainForm.productsPanel.DSSystem.PRODUCT)
                                        MainForm.displayPanel.Controls.Add(MainForm.productsPanel)

                                    End If



                                Else
                                    MessageBox.Show("Please Select Supplier", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                End If
                            End If





                        Else
                            MessageBox.Show("Incorrect Threshold", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Else
                        MessageBox.Show("Incorrect Markup", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("Incorrect Cost Price Per Unit", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Incorrect Product Quantity", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Incorrect Product Price", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        MainForm.displayPanel.Controls.Clear()
        MainForm.displayPanel.Controls.Add(MainForm.productsPanel)
    End Sub

    Private Sub insertProductPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SupplierTableAdapter.Fill(DsSystem.SUPPLIER)
        For i As Integer = 0 To DsSystem.SUPPLIER.Rows.Count - 1
            If cmbSuppliers.Items.Contains(DsSystem.SUPPLIER.Rows(i).Item(1)) = False Then
                cmbSuppliers.Items.Add(DsSystem.SUPPLIER.Rows(i).Item(1))
            End If
        Next
        ProductcategoryTableAdapter.Fill(DsSystem.PRODUCTCATEGORY)
        For i As Integer = 0 To DsSystem.PRODUCTCATEGORY.Rows.Count - 1
            cmbCategory.Items.Add(DsSystem.PRODUCTCATEGORY.Rows(i).Item(0))
        Next


        VatTableAdapter1.Fill(DsSystem.VAT)
        vat = CDbl((CDbl(DsSystem.VAT.Rows(0).Item(1))) * 100)

        NumericUpDownVAT.Value = vat
    End Sub


    Dim supplierID As Integer
    Private Sub cmbSuppliers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSuppliers.SelectedIndexChanged
        Try
            supplierID = SupplierTableAdapter.FillBySupplierName(cmbSuppliers.SelectedItem)

        Catch ex As Exception

        End Try

    End Sub

    Private Sub markupNumericUpDown_ValueChanged(sender As Object, e As EventArgs) Handles markupNumericUpDown.ValueChanged
        priceNumericUpDown.Value = CDbl(costPriceNumericUpDown.Value * ((100 + markupNumericUpDown.Value) / 100) * (100 + NumericUpDownVAT.Value) / 100)
    End Sub

    Private Sub priceNumericUpDown_ValueChanged(sender As Object, e As EventArgs) Handles priceNumericUpDown.ValueChanged
        Try
            markupNumericUpDown.Value = CDbl(((priceNumericUpDown.Value / ((100 + NumericUpDownVAT.Value) / 100)) / costPriceNumericUpDown.Value * 100) - 100)
        Catch ex As Exception
            MessageBox.Show("Markup Percentage will be less than zero below this price. Please enter markup percentage again.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub costPriceNumericUpDown_ValueChanged(sender As Object, e As EventArgs) Handles costPriceNumericUpDown.ValueChanged
        priceNumericUpDown.Value = CDbl(costPriceNumericUpDown.Value * ((100 + markupNumericUpDown.Value) / 100) * (100 + NumericUpDownVAT.Value) / 100)
    End Sub

    Private Sub cbNewCategory_CheckedChanged(sender As Object, e As EventArgs) Handles cbNewCategory.CheckedChanged
        If cbNewCategory.Checked = True Then
            categoryTxt.Visible = True
            cmbCategory.Enabled = False
        Else
            cmbCategory.Enabled = True
            categoryTxt.Visible = False
        End If
    End Sub

    Private Sub NumericUpDownVAT_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDownVAT.ValueChanged
        priceNumericUpDown.Value = CDbl(costPriceNumericUpDown.Value * ((100 + markupNumericUpDown.Value) / 100) * (100 + NumericUpDownVAT.Value) / 100)
    End Sub

    Private Sub btnVAT_Click(sender As Object, e As EventArgs) Handles btnVAT.Click
        Dim result As DialogResult = MessageBox.Show("Changing VAT percentage will result in updating every product price with the new VAT percentage." & vbLf & " Are you sure you want to continue?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)
        MetroLabel1.Focus()

        If result = DialogResult.Yes Then
            Dim newVAT As Double
            Try
                newVAT = InputBox("Enter new VAT percentage:")
                ProductTableAdapter.UpdateVAT(newVAT)
                vat = newVAT
                NumericUpDownVAT.Value = vat
                newVAT = newVAT / 100
                VatTableAdapter1.UpdateQuery(newVAT)


                MainForm.productsPanel = New productsPanel
                MessageBox.Show("VAT percentage updated successfully!", "VAT Update", MessageBoxButtons.OK, MessageBoxIcon.Information)

                'If System.IO.File.Exists("vat.txt") Then
                'Dim writer As New System.IO.StreamWriter("vat.txt")
                'writer.Write(newVAT)
                'writer.Close()


                '        End If



            Catch ex As Exception
                MessageBox.Show("Please enter a valid number.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If
    End Sub
End Class
