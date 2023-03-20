' Prgram Name: Catering
' Developer: Maria Jackson
' Date: March 20, 2023
' Purpose: The app allows user selection of party platter type, payment type, and entry of
''          loyalty points. The total cost is calculated with a discount applied at a rate
''          determined by loyalty points entered, platter choice, and payment option.
''          Total cost is displayed, and user may clear input and start over at any time.
Public Class frmCatering

    'declare constant variables, pricing:
    Const _cdecFruit As Decimal = 24.99D
    Const _cdecDeli As Decimal = 34.99D
    Const _cdecPita As Decimal = 44.99D
    Const _cdecGrill As Decimal = 54.99D
    Const _cdecVeggie As Decimal = 39.99D
    Const _cdecLoyaltyRate As Decimal = 0.05D

    'declare order variables:
    Dim strPoints As String
    Dim decPoints As Decimal
    Dim decTotalCost As Decimal
    Dim strTotalCost As String
    Dim decDiscount As Decimal
    Dim intDiscountMuliplier As Integer
    Dim strCostMsg As String = "Your order {0} costs {1} using {2} after discount of {3} Loyalty Points"

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
