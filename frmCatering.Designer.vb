<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCatering
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCatering))
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblSubheading = New System.Windows.Forms.Label()
        Me.lblLoyaltyPoints = New System.Windows.Forms.Label()
        Me.txtPoints = New System.Windows.Forms.TextBox()
        Me.picPlatter = New System.Windows.Forms.PictureBox()
        Me.lblPayment = New System.Windows.Forms.Label()
        Me.radFruit = New System.Windows.Forms.RadioButton()
        Me.radDeliMeat = New System.Windows.Forms.RadioButton()
        Me.radPita = New System.Windows.Forms.RadioButton()
        Me.radGrill = New System.Windows.Forms.RadioButton()
        Me.radVeggie = New System.Windows.Forms.RadioButton()
        Me.grpPlatterOptions = New System.Windows.Forms.GroupBox()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.radPrePay = New System.Windows.Forms.RadioButton()
        Me.radPickupPay = New System.Windows.Forms.RadioButton()
        Me.grpPayOption = New System.Windows.Forms.GroupBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        CType(Me.picPlatter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPlatterOptions.SuspendLayout()
        Me.grpPayOption.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.Font = New System.Drawing.Font("Century Schoolbook", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(83, 9)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(291, 72)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Catering"
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSubheading
        '
        Me.lblSubheading.Font = New System.Drawing.Font("Century Schoolbook", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubheading.Location = New System.Drawing.Point(117, 68)
        Me.lblSubheading.Name = "lblSubheading"
        Me.lblSubheading.Size = New System.Drawing.Size(222, 47)
        Me.lblSubheading.TabIndex = 1
        Me.lblSubheading.Text = "Star Market"
        Me.lblSubheading.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblLoyaltyPoints
        '
        Me.lblLoyaltyPoints.Font = New System.Drawing.Font("Century Schoolbook", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoyaltyPoints.Location = New System.Drawing.Point(451, 329)
        Me.lblLoyaltyPoints.Name = "lblLoyaltyPoints"
        Me.lblLoyaltyPoints.Size = New System.Drawing.Size(315, 65)
        Me.lblLoyaltyPoints.TabIndex = 2
        Me.lblLoyaltyPoints.Text = "Enter Loyalty Points:"
        Me.lblLoyaltyPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPoints
        '
        Me.txtPoints.Font = New System.Drawing.Font("Century Schoolbook", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPoints.Location = New System.Drawing.Point(808, 341)
        Me.txtPoints.Name = "txtPoints"
        Me.txtPoints.Size = New System.Drawing.Size(79, 40)
        Me.txtPoints.TabIndex = 3
        Me.txtPoints.Text = "8888"
        '
        'picPlatter
        '
        Me.picPlatter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picPlatter.Image = CType(resources.GetObject("picPlatter.Image"), System.Drawing.Image)
        Me.picPlatter.Location = New System.Drawing.Point(456, 0)
        Me.picPlatter.Name = "picPlatter"
        Me.picPlatter.Size = New System.Drawing.Size(483, 305)
        Me.picPlatter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPlatter.TabIndex = 4
        Me.picPlatter.TabStop = False
        '
        'lblPayment
        '
        Me.lblPayment.Font = New System.Drawing.Font("Century Schoolbook", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayment.Location = New System.Drawing.Point(169, 588)
        Me.lblPayment.Name = "lblPayment"
        Me.lblPayment.Size = New System.Drawing.Size(148, 43)
        Me.lblPayment.TabIndex = 5
        Me.lblPayment.Text = "Payment:"
        Me.lblPayment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'radFruit
        '
        Me.radFruit.AutoSize = True
        Me.radFruit.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radFruit.Location = New System.Drawing.Point(37, 31)
        Me.radFruit.Name = "radFruit"
        Me.radFruit.Size = New System.Drawing.Size(156, 29)
        Me.radFruit.TabIndex = 6
        Me.radFruit.TabStop = True
        Me.radFruit.Text = "Fruit - 24.99"
        Me.radFruit.UseVisualStyleBackColor = True
        '
        'radDeliMeat
        '
        Me.radDeliMeat.AutoSize = True
        Me.radDeliMeat.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radDeliMeat.Location = New System.Drawing.Point(37, 77)
        Me.radDeliMeat.Name = "radDeliMeat"
        Me.radDeliMeat.Size = New System.Drawing.Size(202, 29)
        Me.radDeliMeat.TabIndex = 7
        Me.radDeliMeat.TabStop = True
        Me.radDeliMeat.Text = "Deli Meat - 34.99"
        Me.radDeliMeat.UseVisualStyleBackColor = True
        '
        'radPita
        '
        Me.radPita.AutoSize = True
        Me.radPita.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPita.Location = New System.Drawing.Point(37, 123)
        Me.radPita.Name = "radPita"
        Me.radPita.Size = New System.Drawing.Size(145, 29)
        Me.radPita.TabIndex = 8
        Me.radPita.TabStop = True
        Me.radPita.Text = "Pita - 44.99"
        Me.radPita.UseVisualStyleBackColor = True
        '
        'radGrill
        '
        Me.radGrill.AutoSize = True
        Me.radGrill.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radGrill.Location = New System.Drawing.Point(37, 169)
        Me.radGrill.Name = "radGrill"
        Me.radGrill.Size = New System.Drawing.Size(150, 29)
        Me.radGrill.TabIndex = 9
        Me.radGrill.TabStop = True
        Me.radGrill.Text = "Grill - 54.99"
        Me.radGrill.UseVisualStyleBackColor = True
        '
        'radVeggie
        '
        Me.radVeggie.AutoSize = True
        Me.radVeggie.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radVeggie.Location = New System.Drawing.Point(37, 215)
        Me.radVeggie.Name = "radVeggie"
        Me.radVeggie.Size = New System.Drawing.Size(170, 29)
        Me.radVeggie.TabIndex = 10
        Me.radVeggie.TabStop = True
        Me.radVeggie.Text = "Veggie - 29.99"
        Me.radVeggie.UseVisualStyleBackColor = True
        '
        'grpPlatterOptions
        '
        Me.grpPlatterOptions.BackColor = System.Drawing.Color.DarkKhaki
        Me.grpPlatterOptions.Controls.Add(Me.radFruit)
        Me.grpPlatterOptions.Controls.Add(Me.radVeggie)
        Me.grpPlatterOptions.Controls.Add(Me.radDeliMeat)
        Me.grpPlatterOptions.Controls.Add(Me.radGrill)
        Me.grpPlatterOptions.Controls.Add(Me.radPita)
        Me.grpPlatterOptions.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPlatterOptions.ForeColor = System.Drawing.Color.Black
        Me.grpPlatterOptions.Location = New System.Drawing.Point(102, 128)
        Me.grpPlatterOptions.Name = "grpPlatterOptions"
        Me.grpPlatterOptions.Size = New System.Drawing.Size(272, 253)
        Me.grpPlatterOptions.TabIndex = 11
        Me.grpPlatterOptions.TabStop = False
        Me.grpPlatterOptions.Text = "Select Platter"
        '
        'lblTotalCost
        '
        Me.lblTotalCost.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.Location = New System.Drawing.Point(343, 574)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(596, 72)
        Me.lblTotalCost.TabIndex = 12
        Me.lblTotalCost.Text = "Your order Option Platter Costs 88888 Using" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Payment Option after Discount of 888" &
    "8 Loyalty Points"
        Me.lblTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'radPrePay
        '
        Me.radPrePay.AutoSize = True
        Me.radPrePay.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPrePay.Location = New System.Drawing.Point(37, 31)
        Me.radPrePay.Name = "radPrePay"
        Me.radPrePay.Size = New System.Drawing.Size(115, 29)
        Me.radPrePay.TabIndex = 13
        Me.radPrePay.TabStop = True
        Me.radPrePay.Text = "Pre-Pay"
        Me.radPrePay.UseVisualStyleBackColor = True
        '
        'radPickupPay
        '
        Me.radPickupPay.AutoSize = True
        Me.radPickupPay.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPickupPay.Location = New System.Drawing.Point(37, 76)
        Me.radPickupPay.Name = "radPickupPay"
        Me.radPickupPay.Size = New System.Drawing.Size(178, 29)
        Me.radPickupPay.TabIndex = 14
        Me.radPickupPay.TabStop = True
        Me.radPickupPay.Text = "Pay at Pickup"
        Me.radPickupPay.UseVisualStyleBackColor = True
        '
        'grpPayOption
        '
        Me.grpPayOption.BackColor = System.Drawing.Color.DarkKhaki
        Me.grpPayOption.Controls.Add(Me.radPrePay)
        Me.grpPayOption.Controls.Add(Me.radPickupPay)
        Me.grpPayOption.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPayOption.ForeColor = System.Drawing.Color.Black
        Me.grpPayOption.Location = New System.Drawing.Point(102, 400)
        Me.grpPayOption.Name = "grpPayOption"
        Me.grpPayOption.Size = New System.Drawing.Size(272, 135)
        Me.grpPayOption.TabIndex = 15
        Me.grpPayOption.TabStop = False
        Me.grpPayOption.Text = "Select Payment"
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.DarkKhaki
        Me.btnCalculate.FlatAppearance.BorderColor = System.Drawing.Color.PapayaWhip
        Me.btnCalculate.FlatAppearance.BorderSize = 2
        Me.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalculate.Font = New System.Drawing.Font("Century Schoolbook", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.Color.Black
        Me.btnCalculate.Location = New System.Drawing.Point(476, 434)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(198, 49)
        Me.btnCalculate.TabIndex = 16
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.DarkKhaki
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.PapayaWhip
        Me.btnClear.FlatAppearance.BorderSize = 2
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Century Schoolbook", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Black
        Me.btnClear.Location = New System.Drawing.Point(730, 434)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(198, 49)
        Me.btnClear.TabIndex = 17
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'frmCatering
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Moccasin
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(940, 675)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.grpPayOption)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.grpPlatterOptions)
        Me.Controls.Add(Me.lblPayment)
        Me.Controls.Add(Me.picPlatter)
        Me.Controls.Add(Me.txtPoints)
        Me.Controls.Add(Me.lblLoyaltyPoints)
        Me.Controls.Add(Me.lblSubheading)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "frmCatering"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catering"
        CType(Me.picPlatter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPlatterOptions.ResumeLayout(False)
        Me.grpPlatterOptions.PerformLayout()
        Me.grpPayOption.ResumeLayout(False)
        Me.grpPayOption.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents lblSubheading As Label
    Friend WithEvents lblLoyaltyPoints As Label
    Friend WithEvents txtPoints As TextBox
    Friend WithEvents picPlatter As PictureBox
    Friend WithEvents lblPayment As Label
    Friend WithEvents radFruit As RadioButton
    Friend WithEvents radDeliMeat As RadioButton
    Friend WithEvents radPita As RadioButton
    Friend WithEvents radGrill As RadioButton
    Friend WithEvents radVeggie As RadioButton
    Friend WithEvents grpPlatterOptions As GroupBox
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents radPrePay As RadioButton
    Friend WithEvents radPickupPay As RadioButton
    Friend WithEvents grpPayOption As GroupBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
End Class
