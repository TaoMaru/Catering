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
    Const _cdecVeggie As Decimal = 29.99D
    Const _cdecLoyaltyRate As Decimal = 0.05D

    'declare constant variables, order choice:
    Const _cstrFruit As String = "Fruit Platter"
    Const _cstrDeli As String = "Deli Meat Platter"
    Const _cstrPita As String = "Pita Platter"
    Const _cstrGrill As String = "Grill Platter"
    Const _cstrVeggie As String = "Veggie Platter"
    Const _cstrPrePay As String = "Pre-Pay"
    Const _cstrPickup As String = "Pay at Pickup"

    Private Sub frmCatering_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'uses btnClear event to reset form
        btnClear.PerformClick()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'resets txtPoints to blank, resets focus onto txtPoints
        'resets rad selections & clears orderChoice, totalCost, discount values
        txtPoints.Clear()
        txtPoints.Focus()
        radFruit.Checked = True
        radPrePay.Checked = True
        lblTotalCost.Text = ""
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' checks platter choice, calculates discount, displays total
        'declare order variables:
        Dim strPoints As String
        Dim intPoints As Integer
        Dim decTotalCost As Decimal
        Dim strTotalCost As String
        Dim decDiscount As Decimal
        Dim intDiscountMuliplier As Integer
        Dim strOrderChoice As String
        Dim strPaymentChoice As String
        Dim strCostMsg As String = "Your order {0} costs {1} using {2} after discount of {3} Loyalty Points"

        'declare msgBox
        Dim strAlert As String = "Please enter a positive number or 0"

        strPoints = txtPoints.Text
        If IsNumeric(strPoints) Then
            intPoints = Convert.ToInt32(strPoints)
            If intPoints > 0 Then
                intDiscountMuliplier = intPoints \ 10
                'check which platter selected:
                If radFruit.Checked Then
                    decTotalCost = _cdecFruit
                    strOrderChoice = _cstrFruit
                ElseIf radDeliMeat.Checked Then
                    decTotalCost = _cdecDeli
                    strOrderChoice = _cstrDeli
                ElseIf radPita.Checked Then
                    decTotalCost = _cdecPita
                    strOrderChoice = _cstrPita
                ElseIf radGrill.Checked Then
                    decTotalCost = _cdecGrill
                    strOrderChoice = _cstrGrill
                Else
                    decTotalCost = _cdecVeggie
                    strOrderChoice = _cstrVeggie
                End If
                'calculate discount
                decDiscount = _cdecLoyaltyRate * intDiscountMuliplier * decTotalCost
                decTotalCost -= decDiscount
                If decTotalCost < 0 Then
                    decTotalCost = 0
                End If
                'display total cost
                strTotalCost = decTotalCost.ToString("C2")
                If radPrePay.Checked Then
                    strPaymentChoice = _cstrPrePay
                Else
                    strPaymentChoice = _cstrPickup
                End If
                strCostMsg = String.Format(strCostMsg, strOrderChoice, strTotalCost, strPaymentChoice,
                                           strPoints)
                lblTotalCost.Text = strCostMsg
            Else
                MsgBox(strAlert, vbOKOnly, "Invalid input")
                txtPoints.Clear()
                txtPoints.Focus()
            End If
        Else
            MsgBox(strAlert, vbOKOnly, "Invalid input")
            txtPoints.Clear()
            txtPoints.Focus()
        End If

    End Sub
End Class
