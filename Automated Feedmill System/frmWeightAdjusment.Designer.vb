<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWeightAdjusment
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
        Me.components = New System.ComponentModel.Container()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblliquidweight = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblWeightAdjustmentLiquid = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnWeightAdjustmentStart = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnSettingsSave = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.timerUiUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblCurrentSilo8WeightAdjustment = New System.Windows.Forms.Label()
        Me.lblCurrentSilo9WeightAdjustment = New System.Windows.Forms.Label()
        Me.lblCurrentSilo7WeightAdjustment = New System.Windows.Forms.Label()
        Me.lblCurrentSilo6WeightAdjustment = New System.Windows.Forms.Label()
        Me.lblCurrentSilo5WeightAdjustment = New System.Windows.Forms.Label()
        Me.lblCurrentSilo4WeightAdjustment = New System.Windows.Forms.Label()
        Me.lblCurrentSilo3WeightAdjustment = New System.Windows.Forms.Label()
        Me.lblCurrentSilo2WeightAdjustment = New System.Windows.Forms.Label()
        Me.lblCurrentSilo1WeightAdjustment = New System.Windows.Forms.Label()
        Me.lblCurrentMolassesWeightAdjustment = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.lblCurrentCocooilWeightAdjustment = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtbFormSilo1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 30
        Me.BunifuElipse1.TargetControl = Me
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(163, 27)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(486, 44)
        Me.lblTitle.TabIndex = 37
        Me.lblTitle.Text = "Batching Calibration"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(257, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(204, 44)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Batching Bin"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblliquidweight
        '
        Me.lblliquidweight.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblliquidweight.Location = New System.Drawing.Point(257, 146)
        Me.lblliquidweight.Name = "lblliquidweight"
        Me.lblliquidweight.Size = New System.Drawing.Size(204, 44)
        Me.lblliquidweight.TabIndex = 41
        Me.lblliquidweight.Text = "000.00"
        Me.lblliquidweight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(41, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 30)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Silo 1 :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(257, 247)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(204, 44)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Current Silo Calibrating"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(257, 286)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(204, 44)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Silo 1"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblWeightAdjustmentLiquid
        '
        Me.lblWeightAdjustmentLiquid.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblWeightAdjustmentLiquid.Location = New System.Drawing.Point(516, 286)
        Me.lblWeightAdjustmentLiquid.Name = "lblWeightAdjustmentLiquid"
        Me.lblWeightAdjustmentLiquid.Size = New System.Drawing.Size(204, 44)
        Me.lblWeightAdjustmentLiquid.TabIndex = 49
        Me.lblWeightAdjustmentLiquid.Text = "20 KG"
        Me.lblWeightAdjustmentLiquid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(517, 247)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(204, 44)
        Me.Label11.TabIndex = 47
        Me.Label11.Text = "Weight Adjustment"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnWeightAdjustmentStart
        '
        Me.btnWeightAdjustmentStart.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnWeightAdjustmentStart.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btnWeightAdjustmentStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnWeightAdjustmentStart.BorderRadius = 0
        Me.btnWeightAdjustmentStart.ButtonText = "Start"
        Me.btnWeightAdjustmentStart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnWeightAdjustmentStart.DisabledColor = System.Drawing.Color.Gray
        Me.btnWeightAdjustmentStart.Iconcolor = System.Drawing.Color.Transparent
        Me.btnWeightAdjustmentStart.Iconimage = Global.Automated_Feedmill_System.My.Resources.Resources.Play_96px
        Me.btnWeightAdjustmentStart.Iconimage_right = Nothing
        Me.btnWeightAdjustmentStart.Iconimage_right_Selected = Nothing
        Me.btnWeightAdjustmentStart.Iconimage_Selected = Nothing
        Me.btnWeightAdjustmentStart.IconMarginLeft = 0
        Me.btnWeightAdjustmentStart.IconMarginRight = 0
        Me.btnWeightAdjustmentStart.IconRightVisible = True
        Me.btnWeightAdjustmentStart.IconRightZoom = 0R
        Me.btnWeightAdjustmentStart.IconVisible = True
        Me.btnWeightAdjustmentStart.IconZoom = 50.0R
        Me.btnWeightAdjustmentStart.IsTab = False
        Me.btnWeightAdjustmentStart.Location = New System.Drawing.Point(521, 503)
        Me.btnWeightAdjustmentStart.Name = "btnWeightAdjustmentStart"
        Me.btnWeightAdjustmentStart.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btnWeightAdjustmentStart.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnWeightAdjustmentStart.OnHoverTextColor = System.Drawing.Color.White
        Me.btnWeightAdjustmentStart.selected = False
        Me.btnWeightAdjustmentStart.Size = New System.Drawing.Size(120, 48)
        Me.btnWeightAdjustmentStart.TabIndex = 51
        Me.btnWeightAdjustmentStart.Text = "Start"
        Me.btnWeightAdjustmentStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnWeightAdjustmentStart.Textcolor = System.Drawing.Color.White
        Me.btnWeightAdjustmentStart.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnSettingsSave
        '
        Me.btnSettingsSave.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnSettingsSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btnSettingsSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSettingsSave.BorderRadius = 0
        Me.btnSettingsSave.ButtonText = "Save"
        Me.btnSettingsSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSettingsSave.DisabledColor = System.Drawing.Color.Gray
        Me.btnSettingsSave.Iconcolor = System.Drawing.Color.Transparent
        Me.btnSettingsSave.Iconimage = Global.Automated_Feedmill_System.My.Resources.Resources.Save_96px
        Me.btnSettingsSave.Iconimage_right = Nothing
        Me.btnSettingsSave.Iconimage_right_Selected = Nothing
        Me.btnSettingsSave.Iconimage_Selected = Nothing
        Me.btnSettingsSave.IconMarginLeft = 0
        Me.btnSettingsSave.IconMarginRight = 0
        Me.btnSettingsSave.IconRightVisible = True
        Me.btnSettingsSave.IconRightZoom = 0R
        Me.btnSettingsSave.IconVisible = True
        Me.btnSettingsSave.IconZoom = 50.0R
        Me.btnSettingsSave.IsTab = False
        Me.btnSettingsSave.Location = New System.Drawing.Point(659, 503)
        Me.btnSettingsSave.Name = "btnSettingsSave"
        Me.btnSettingsSave.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btnSettingsSave.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnSettingsSave.OnHoverTextColor = System.Drawing.Color.White
        Me.btnSettingsSave.selected = False
        Me.btnSettingsSave.Size = New System.Drawing.Size(120, 48)
        Me.btnSettingsSave.TabIndex = 50
        Me.btnSettingsSave.Text = "Save"
        Me.btnSettingsSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnSettingsSave.Textcolor = System.Drawing.Color.White
        Me.btnSettingsSave.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'timerUiUpdate
        '
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(41, 140)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 30)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Silo 2 :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(41, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 30)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Silo 3 :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(41, 216)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 30)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Silo 4 :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(41, 254)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 30)
        Me.Label8.TabIndex = 55
        Me.Label8.Text = "Silo 5 :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(41, 292)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 30)
        Me.Label9.TabIndex = 56
        Me.Label9.Text = "Silo 6 :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(41, 330)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 30)
        Me.Label10.TabIndex = 57
        Me.Label10.Text = "Silo 7 :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label12.Location = New System.Drawing.Point(41, 406)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 30)
        Me.Label12.TabIndex = 58
        Me.Label12.Text = "Silo 9 :"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.Location = New System.Drawing.Point(41, 368)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 30)
        Me.Label13.TabIndex = 59
        Me.Label13.Text = "Silo 8 :"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCurrentSilo8WeightAdjustment
        '
        Me.lblCurrentSilo8WeightAdjustment.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblCurrentSilo8WeightAdjustment.Location = New System.Drawing.Point(106, 368)
        Me.lblCurrentSilo8WeightAdjustment.Name = "lblCurrentSilo8WeightAdjustment"
        Me.lblCurrentSilo8WeightAdjustment.Size = New System.Drawing.Size(59, 30)
        Me.lblCurrentSilo8WeightAdjustment.TabIndex = 68
        Me.lblCurrentSilo8WeightAdjustment.Text = "00"
        Me.lblCurrentSilo8WeightAdjustment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCurrentSilo9WeightAdjustment
        '
        Me.lblCurrentSilo9WeightAdjustment.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblCurrentSilo9WeightAdjustment.Location = New System.Drawing.Point(106, 406)
        Me.lblCurrentSilo9WeightAdjustment.Name = "lblCurrentSilo9WeightAdjustment"
        Me.lblCurrentSilo9WeightAdjustment.Size = New System.Drawing.Size(59, 30)
        Me.lblCurrentSilo9WeightAdjustment.TabIndex = 67
        Me.lblCurrentSilo9WeightAdjustment.Text = "00"
        Me.lblCurrentSilo9WeightAdjustment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCurrentSilo7WeightAdjustment
        '
        Me.lblCurrentSilo7WeightAdjustment.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblCurrentSilo7WeightAdjustment.Location = New System.Drawing.Point(106, 330)
        Me.lblCurrentSilo7WeightAdjustment.Name = "lblCurrentSilo7WeightAdjustment"
        Me.lblCurrentSilo7WeightAdjustment.Size = New System.Drawing.Size(59, 30)
        Me.lblCurrentSilo7WeightAdjustment.TabIndex = 66
        Me.lblCurrentSilo7WeightAdjustment.Text = "00"
        Me.lblCurrentSilo7WeightAdjustment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCurrentSilo6WeightAdjustment
        '
        Me.lblCurrentSilo6WeightAdjustment.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblCurrentSilo6WeightAdjustment.Location = New System.Drawing.Point(106, 292)
        Me.lblCurrentSilo6WeightAdjustment.Name = "lblCurrentSilo6WeightAdjustment"
        Me.lblCurrentSilo6WeightAdjustment.Size = New System.Drawing.Size(59, 30)
        Me.lblCurrentSilo6WeightAdjustment.TabIndex = 65
        Me.lblCurrentSilo6WeightAdjustment.Text = "00"
        Me.lblCurrentSilo6WeightAdjustment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCurrentSilo5WeightAdjustment
        '
        Me.lblCurrentSilo5WeightAdjustment.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblCurrentSilo5WeightAdjustment.Location = New System.Drawing.Point(106, 254)
        Me.lblCurrentSilo5WeightAdjustment.Name = "lblCurrentSilo5WeightAdjustment"
        Me.lblCurrentSilo5WeightAdjustment.Size = New System.Drawing.Size(59, 30)
        Me.lblCurrentSilo5WeightAdjustment.TabIndex = 64
        Me.lblCurrentSilo5WeightAdjustment.Text = "00"
        Me.lblCurrentSilo5WeightAdjustment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCurrentSilo4WeightAdjustment
        '
        Me.lblCurrentSilo4WeightAdjustment.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblCurrentSilo4WeightAdjustment.Location = New System.Drawing.Point(106, 216)
        Me.lblCurrentSilo4WeightAdjustment.Name = "lblCurrentSilo4WeightAdjustment"
        Me.lblCurrentSilo4WeightAdjustment.Size = New System.Drawing.Size(59, 30)
        Me.lblCurrentSilo4WeightAdjustment.TabIndex = 63
        Me.lblCurrentSilo4WeightAdjustment.Text = "00"
        Me.lblCurrentSilo4WeightAdjustment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCurrentSilo3WeightAdjustment
        '
        Me.lblCurrentSilo3WeightAdjustment.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblCurrentSilo3WeightAdjustment.Location = New System.Drawing.Point(106, 178)
        Me.lblCurrentSilo3WeightAdjustment.Name = "lblCurrentSilo3WeightAdjustment"
        Me.lblCurrentSilo3WeightAdjustment.Size = New System.Drawing.Size(59, 30)
        Me.lblCurrentSilo3WeightAdjustment.TabIndex = 62
        Me.lblCurrentSilo3WeightAdjustment.Text = "00"
        Me.lblCurrentSilo3WeightAdjustment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCurrentSilo2WeightAdjustment
        '
        Me.lblCurrentSilo2WeightAdjustment.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblCurrentSilo2WeightAdjustment.Location = New System.Drawing.Point(106, 140)
        Me.lblCurrentSilo2WeightAdjustment.Name = "lblCurrentSilo2WeightAdjustment"
        Me.lblCurrentSilo2WeightAdjustment.Size = New System.Drawing.Size(59, 30)
        Me.lblCurrentSilo2WeightAdjustment.TabIndex = 61
        Me.lblCurrentSilo2WeightAdjustment.Text = "00"
        Me.lblCurrentSilo2WeightAdjustment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCurrentSilo1WeightAdjustment
        '
        Me.lblCurrentSilo1WeightAdjustment.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblCurrentSilo1WeightAdjustment.Location = New System.Drawing.Point(106, 102)
        Me.lblCurrentSilo1WeightAdjustment.Name = "lblCurrentSilo1WeightAdjustment"
        Me.lblCurrentSilo1WeightAdjustment.Size = New System.Drawing.Size(59, 30)
        Me.lblCurrentSilo1WeightAdjustment.TabIndex = 60
        Me.lblCurrentSilo1WeightAdjustment.Text = "00"
        Me.lblCurrentSilo1WeightAdjustment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCurrentMolassesWeightAdjustment
        '
        Me.lblCurrentMolassesWeightAdjustment.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblCurrentMolassesWeightAdjustment.Location = New System.Drawing.Point(144, 436)
        Me.lblCurrentMolassesWeightAdjustment.Name = "lblCurrentMolassesWeightAdjustment"
        Me.lblCurrentMolassesWeightAdjustment.Size = New System.Drawing.Size(59, 30)
        Me.lblCurrentMolassesWeightAdjustment.TabIndex = 70
        Me.lblCurrentMolassesWeightAdjustment.Text = "00"
        Me.lblCurrentMolassesWeightAdjustment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label24.Location = New System.Drawing.Point(41, 436)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(97, 30)
        Me.Label24.TabIndex = 69
        Me.Label24.Text = "Molasses :"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCurrentCocooilWeightAdjustment
        '
        Me.lblCurrentCocooilWeightAdjustment.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblCurrentCocooilWeightAdjustment.Location = New System.Drawing.Point(144, 466)
        Me.lblCurrentCocooilWeightAdjustment.Name = "lblCurrentCocooilWeightAdjustment"
        Me.lblCurrentCocooilWeightAdjustment.Size = New System.Drawing.Size(59, 30)
        Me.lblCurrentCocooilWeightAdjustment.TabIndex = 72
        Me.lblCurrentCocooilWeightAdjustment.Text = "00"
        Me.lblCurrentCocooilWeightAdjustment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label26.Location = New System.Drawing.Point(41, 466)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(97, 30)
        Me.Label26.TabIndex = 71
        Me.Label26.Text = "Coco Oil :"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label27
        '
        Me.Label27.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label27.Location = New System.Drawing.Point(516, 146)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(204, 44)
        Me.Label27.TabIndex = 74
        Me.Label27.Text = "000.00"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label28.Location = New System.Drawing.Point(516, 102)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(204, 44)
        Me.Label28.TabIndex = 73
        Me.Label28.Text = "Liquid Bin"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label29
        '
        Me.Label29.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label29.Location = New System.Drawing.Point(257, 354)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(204, 44)
        Me.Label29.TabIndex = 75
        Me.Label29.Text = "Test Load"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtbFormSilo1
        '
        Me.txtbFormSilo1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbFormSilo1.Location = New System.Drawing.Point(308, 401)
        Me.txtbFormSilo1.Name = "txtbFormSilo1"
        Me.txtbFormSilo1.Size = New System.Drawing.Size(102, 27)
        Me.txtbFormSilo1.TabIndex = 76
        '
        'frmWeightAdjusment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(813, 577)
        Me.Controls.Add(Me.txtbFormSilo1)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.lblCurrentCocooilWeightAdjustment)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.lblCurrentMolassesWeightAdjustment)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.lblCurrentSilo8WeightAdjustment)
        Me.Controls.Add(Me.lblCurrentSilo9WeightAdjustment)
        Me.Controls.Add(Me.lblCurrentSilo7WeightAdjustment)
        Me.Controls.Add(Me.lblCurrentSilo6WeightAdjustment)
        Me.Controls.Add(Me.lblCurrentSilo5WeightAdjustment)
        Me.Controls.Add(Me.lblCurrentSilo4WeightAdjustment)
        Me.Controls.Add(Me.lblCurrentSilo3WeightAdjustment)
        Me.Controls.Add(Me.lblCurrentSilo2WeightAdjustment)
        Me.Controls.Add(Me.lblCurrentSilo1WeightAdjustment)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnWeightAdjustmentStart)
        Me.Controls.Add(Me.btnSettingsSave)
        Me.Controls.Add(Me.lblWeightAdjustmentLiquid)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblliquidweight)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmWeightAdjusment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmWeightAdjusment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents lblWeightAdjustmentLiquid As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblliquidweight As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnWeightAdjustmentStart As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnSettingsSave As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents timerUiUpdate As Timer
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents lblCurrentCocooilWeightAdjustment As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents lblCurrentMolassesWeightAdjustment As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents lblCurrentSilo8WeightAdjustment As Label
    Friend WithEvents lblCurrentSilo9WeightAdjustment As Label
    Friend WithEvents lblCurrentSilo7WeightAdjustment As Label
    Friend WithEvents lblCurrentSilo6WeightAdjustment As Label
    Friend WithEvents lblCurrentSilo5WeightAdjustment As Label
    Friend WithEvents lblCurrentSilo4WeightAdjustment As Label
    Friend WithEvents lblCurrentSilo3WeightAdjustment As Label
    Friend WithEvents lblCurrentSilo2WeightAdjustment As Label
    Friend WithEvents lblCurrentSilo1WeightAdjustment As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents txtbFormSilo1 As TextBox
End Class
