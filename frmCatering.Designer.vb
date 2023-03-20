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
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Location = New System.Drawing.Point(136, 34)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(51, 17)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Label1"
        '
        'lblSubheading
        '
        Me.lblSubheading.AutoSize = True
        Me.lblSubheading.Location = New System.Drawing.Point(139, 81)
        Me.lblSubheading.Name = "lblSubheading"
        Me.lblSubheading.Size = New System.Drawing.Size(51, 17)
        Me.lblSubheading.TabIndex = 1
        Me.lblSubheading.Text = "Label2"
        '
        'lblLoyaltyPoints
        '
        Me.lblLoyaltyPoints.AutoSize = True
        Me.lblLoyaltyPoints.Location = New System.Drawing.Point(497, 352)
        Me.lblLoyaltyPoints.Name = "lblLoyaltyPoints"
        Me.lblLoyaltyPoints.Size = New System.Drawing.Size(51, 17)
        Me.lblLoyaltyPoints.TabIndex = 2
        Me.lblLoyaltyPoints.Text = "Label3"
        '
        'txtPoints
        '
        Me.txtPoints.Location = New System.Drawing.Point(708, 352)
        Me.txtPoints.Name = "txtPoints"
        Me.txtPoints.Size = New System.Drawing.Size(100, 22)
        Me.txtPoints.TabIndex = 3
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
        Me.lblPayment.AutoSize = True
        Me.lblPayment.Location = New System.Drawing.Point(203, 568)
        Me.lblPayment.Name = "lblPayment"
        Me.lblPayment.Size = New System.Drawing.Size(51, 17)
        Me.lblPayment.TabIndex = 5
        Me.lblPayment.Text = "Label4"
        '
        'radFruit
        '
        Me.radFruit.AutoSize = True
        Me.radFruit.Location = New System.Drawing.Point(78, 45)
        Me.radFruit.Name = "radFruit"
        Me.radFruit.Size = New System.Drawing.Size(115, 21)
        Me.radFruit.TabIndex = 6
        Me.radFruit.TabStop = True
        Me.radFruit.Text = "RadioButton1"
        Me.radFruit.UseVisualStyleBackColor = True
        '
        'radDeliMeat
        '
        Me.radDeliMeat.AutoSize = True
        Me.radDeliMeat.Location = New System.Drawing.Point(78, 84)
        Me.radDeliMeat.Name = "radDeliMeat"
        Me.radDeliMeat.Size = New System.Drawing.Size(115, 21)
        Me.radDeliMeat.TabIndex = 7
        Me.radDeliMeat.TabStop = True
        Me.radDeliMeat.Text = "RadioButton2"
        Me.radDeliMeat.UseVisualStyleBackColor = True
        '
        'radPita
        '
        Me.radPita.AutoSize = True
        Me.radPita.Location = New System.Drawing.Point(78, 129)
        Me.radPita.Name = "radPita"
        Me.radPita.Size = New System.Drawing.Size(115, 21)
        Me.radPita.TabIndex = 8
        Me.radPita.TabStop = True
        Me.radPita.Text = "RadioButton3"
        Me.radPita.UseVisualStyleBackColor = True
        '
        'radGrill
        '
        Me.radGrill.AutoSize = True
        Me.radGrill.Location = New System.Drawing.Point(78, 170)
        Me.radGrill.Name = "radGrill"
        Me.radGrill.Size = New System.Drawing.Size(115, 21)
        Me.radGrill.TabIndex = 9
        Me.radGrill.TabStop = True
        Me.radGrill.Text = "RadioButton4"
        Me.radGrill.UseVisualStyleBackColor = True
        '
        'radVeggie
        '
        Me.radVeggie.AutoSize = True
        Me.radVeggie.Location = New System.Drawing.Point(78, 198)
        Me.radVeggie.Name = "radVeggie"
        Me.radVeggie.Size = New System.Drawing.Size(115, 21)
        Me.radVeggie.TabIndex = 10
        Me.radVeggie.TabStop = True
        Me.radVeggie.Text = "RadioButton5"
        Me.radVeggie.UseVisualStyleBackColor = True
        '
        'grpPlatterOptions
        '
        Me.grpPlatterOptions.Controls.Add(Me.radFruit)
        Me.grpPlatterOptions.Controls.Add(Me.radVeggie)
        Me.grpPlatterOptions.Controls.Add(Me.radDeliMeat)
        Me.grpPlatterOptions.Controls.Add(Me.radGrill)
        Me.grpPlatterOptions.Controls.Add(Me.radPita)
        Me.grpPlatterOptions.Location = New System.Drawing.Point(45, 131)
        Me.grpPlatterOptions.Name = "grpPlatterOptions"
        Me.grpPlatterOptions.Size = New System.Drawing.Size(272, 253)
        Me.grpPlatterOptions.TabIndex = 11
        Me.grpPlatterOptions.TabStop = False
        Me.grpPlatterOptions.Text = "GroupBox1"
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Location = New System.Drawing.Point(484, 568)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(51, 17)
        Me.lblTotalCost.TabIndex = 12
        Me.lblTotalCost.Text = "Label5"
        '
        'radPrePay
        '
        Me.radPrePay.AutoSize = True
        Me.radPrePay.Location = New System.Drawing.Point(37, 30)
        Me.radPrePay.Name = "radPrePay"
        Me.radPrePay.Size = New System.Drawing.Size(115, 21)
        Me.radPrePay.TabIndex = 13
        Me.radPrePay.TabStop = True
        Me.radPrePay.Text = "RadioButton6"
        Me.radPrePay.UseVisualStyleBackColor = True
        '
        'radPickupPay
        '
        Me.radPickupPay.AutoSize = True
        Me.radPickupPay.Location = New System.Drawing.Point(37, 57)
        Me.radPickupPay.Name = "radPickupPay"
        Me.radPickupPay.Size = New System.Drawing.Size(115, 21)
        Me.radPickupPay.TabIndex = 14
        Me.radPickupPay.TabStop = True
        Me.radPickupPay.Text = "RadioButton7"
        Me.radPickupPay.UseVisualStyleBackColor = True
        '
        'grpPayOption
        '
        Me.grpPayOption.Controls.Add(Me.radPrePay)
        Me.grpPayOption.Controls.Add(Me.radPickupPay)
        Me.grpPayOption.Location = New System.Drawing.Point(76, 405)
        Me.grpPayOption.Name = "grpPayOption"
        Me.grpPayOption.Size = New System.Drawing.Size(200, 100)
        Me.grpPayOption.TabIndex = 15
        Me.grpPayOption.TabStop = False
        Me.grpPayOption.Text = "GroupBox2"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(460, 434)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 16
        Me.btnCalculate.Text = "Button1"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(689, 435)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 17
        Me.btnClear.Text = "Button2"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'frmCatering
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
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
