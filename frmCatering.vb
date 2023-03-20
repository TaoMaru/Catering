Public Class frmCatering
    Private Sub frmCatering_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'uses btnClear event to reset form
        btnClear.PerformClick()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'resets txtPoints to blank, resets focus onto txtPoints
        'resests rad selections
        txtPoints.Clear()
        txtPoints.Focus()
        radFruit.Checked = True
        radPrePay.Checked = True
        lblTotalCost.Text = ""
    End Sub
End Class
