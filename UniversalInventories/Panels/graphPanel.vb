Public Class graphPanel
    Private Sub graphPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Label1.Visible = False
        MainForm.displayPanel.Controls.Clear()
        MainForm.graphPanel = New graphPanel
        MainForm.displayPanel.Controls.Add(MainForm.viewReportsPanel)
    End Sub
End Class
