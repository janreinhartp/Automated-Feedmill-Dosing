<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmControlOverview
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.conWeight = New System.IO.Ports.SerialPort(Me.components)
        Me.conWeightTimer = New System.Windows.Forms.Timer(Me.components)
        Me.conWeightLiquid = New System.IO.Ports.SerialPort(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblweightLiquid = New System.Windows.Forms.Label()
        Me.pbMixingBottomGate = New System.Windows.Forms.PictureBox()
        Me.pbMixingTopGate = New System.Windows.Forms.PictureBox()
        Me.pbBatchGate = New System.Windows.Forms.PictureBox()
        Me.pbElev7 = New System.Windows.Forms.PictureBox()
        Me.pbMixer = New System.Windows.Forms.PictureBox()
        Me.pbMixingConveyer = New System.Windows.Forms.PictureBox()
        Me.pbMixingMolasses = New System.Windows.Forms.PictureBox()
        Me.pbMixingCoco = New System.Windows.Forms.PictureBox()
        Me.pbAirComp = New System.Windows.Forms.PictureBox()
        Me.pbElev6 = New System.Windows.Forms.PictureBox()
        Me.pbBatchConveyer = New System.Windows.Forms.PictureBox()
        Me.pbSilo9 = New System.Windows.Forms.PictureBox()
        Me.pbSilo8 = New System.Windows.Forms.PictureBox()
        Me.pbSilo7 = New System.Windows.Forms.PictureBox()
        Me.pbSilo6 = New System.Windows.Forms.PictureBox()
        Me.pbSilo5 = New System.Windows.Forms.PictureBox()
        Me.pbSilo3 = New System.Windows.Forms.PictureBox()
        Me.pbSilo4 = New System.Windows.Forms.PictureBox()
        Me.pbSilo2 = New System.Windows.Forms.PictureBox()
        Me.pbSilo1 = New System.Windows.Forms.PictureBox()
        Me.pbTopAuger3 = New System.Windows.Forms.PictureBox()
        Me.pbTopAuger2 = New System.Windows.Forms.PictureBox()
        Me.pbTopAuger1 = New System.Windows.Forms.PictureBox()
        Me.pbHamMill1 = New System.Windows.Forms.PictureBox()
        Me.pbHamMillScrew1 = New System.Windows.Forms.PictureBox()
        Me.pbHamMillFeed1 = New System.Windows.Forms.PictureBox()
        Me.pbElev4 = New System.Windows.Forms.PictureBox()
        Me.pbHamMill2 = New System.Windows.Forms.PictureBox()
        Me.pbHamMillScrew2 = New System.Windows.Forms.PictureBox()
        Me.pbHamMillFeed2 = New System.Windows.Forms.PictureBox()
        Me.pbElev5 = New System.Windows.Forms.PictureBox()
        Me.pbElev3 = New System.Windows.Forms.PictureBox()
        Me.pbDust2 = New System.Windows.Forms.PictureBox()
        Me.pbElev1 = New System.Windows.Forms.PictureBox()
        Me.pbDust1 = New System.Windows.Forms.PictureBox()
        Me.pbElev2 = New System.Windows.Forms.PictureBox()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.pbMixingBottomGate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbMixingTopGate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBatchGate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbElev7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbMixer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbMixingConveyer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbMixingMolasses, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbMixingCoco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbAirComp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbElev6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBatchConveyer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSilo9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSilo8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSilo7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSilo6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSilo5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSilo3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSilo4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSilo2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSilo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbTopAuger3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbTopAuger2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbTopAuger1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbHamMill1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbHamMillScrew1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbHamMillFeed1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbElev4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbHamMill2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbHamMillScrew2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbHamMillFeed2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbElev5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbElev3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbDust2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbElev1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbDust1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbElev2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'conWeight
        '
        '
        'conWeightTimer
        '
        '
        'conWeightLiquid
        '
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.Automated_Feedmill_System.My.Resources.Resources.OverView
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.lblweightLiquid)
        Me.Panel1.Controls.Add(Me.pbMixingBottomGate)
        Me.Panel1.Controls.Add(Me.pbMixingTopGate)
        Me.Panel1.Controls.Add(Me.pbBatchGate)
        Me.Panel1.Controls.Add(Me.pbElev7)
        Me.Panel1.Controls.Add(Me.pbMixer)
        Me.Panel1.Controls.Add(Me.pbMixingConveyer)
        Me.Panel1.Controls.Add(Me.pbMixingMolasses)
        Me.Panel1.Controls.Add(Me.pbMixingCoco)
        Me.Panel1.Controls.Add(Me.pbAirComp)
        Me.Panel1.Controls.Add(Me.pbElev6)
        Me.Panel1.Controls.Add(Me.pbBatchConveyer)
        Me.Panel1.Controls.Add(Me.pbSilo9)
        Me.Panel1.Controls.Add(Me.pbSilo8)
        Me.Panel1.Controls.Add(Me.pbSilo7)
        Me.Panel1.Controls.Add(Me.pbSilo6)
        Me.Panel1.Controls.Add(Me.pbSilo5)
        Me.Panel1.Controls.Add(Me.pbSilo3)
        Me.Panel1.Controls.Add(Me.pbSilo4)
        Me.Panel1.Controls.Add(Me.pbSilo2)
        Me.Panel1.Controls.Add(Me.pbSilo1)
        Me.Panel1.Controls.Add(Me.pbTopAuger3)
        Me.Panel1.Controls.Add(Me.pbTopAuger2)
        Me.Panel1.Controls.Add(Me.pbTopAuger1)
        Me.Panel1.Controls.Add(Me.pbHamMill1)
        Me.Panel1.Controls.Add(Me.pbHamMillScrew1)
        Me.Panel1.Controls.Add(Me.pbHamMillFeed1)
        Me.Panel1.Controls.Add(Me.pbElev4)
        Me.Panel1.Controls.Add(Me.pbHamMill2)
        Me.Panel1.Controls.Add(Me.pbHamMillScrew2)
        Me.Panel1.Controls.Add(Me.pbHamMillFeed2)
        Me.Panel1.Controls.Add(Me.pbElev5)
        Me.Panel1.Controls.Add(Me.pbElev3)
        Me.Panel1.Controls.Add(Me.pbDust2)
        Me.Panel1.Controls.Add(Me.pbElev1)
        Me.Panel1.Controls.Add(Me.pbDust1)
        Me.Panel1.Controls.Add(Me.pbElev2)
        Me.Panel1.Controls.Add(Me.lblWeight)
        Me.Panel1.Location = New System.Drawing.Point(45, 75)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1350, 750)
        Me.Panel1.TabIndex = 0
        '
        'lblweightLiquid
        '
        Me.lblweightLiquid.Font = New System.Drawing.Font("Segoe UI Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblweightLiquid.Location = New System.Drawing.Point(902, 518)
        Me.lblweightLiquid.Name = "lblweightLiquid"
        Me.lblweightLiquid.Size = New System.Drawing.Size(208, 44)
        Me.lblweightLiquid.TabIndex = 36
        Me.lblweightLiquid.Text = "asdasd"
        Me.lblweightLiquid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbMixingBottomGate
        '
        Me.pbMixingBottomGate.BackColor = System.Drawing.Color.Transparent
        Me.pbMixingBottomGate.Image = Global.Automated_Feedmill_System.My.Resources.Resources.Red_Icon
        Me.pbMixingBottomGate.Location = New System.Drawing.Point(962, 394)
        Me.pbMixingBottomGate.Name = "pbMixingBottomGate"
        Me.pbMixingBottomGate.Size = New System.Drawing.Size(20, 20)
        Me.pbMixingBottomGate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbMixingBottomGate.TabIndex = 35
        Me.pbMixingBottomGate.TabStop = False
        '
        'pbMixingTopGate
        '
        Me.pbMixingTopGate.BackColor = System.Drawing.Color.Transparent
        Me.pbMixingTopGate.Image = Global.Automated_Feedmill_System.My.Resources.Resources.Red_Icon
        Me.pbMixingTopGate.Location = New System.Drawing.Point(962, 301)
        Me.pbMixingTopGate.Name = "pbMixingTopGate"
        Me.pbMixingTopGate.Size = New System.Drawing.Size(20, 20)
        Me.pbMixingTopGate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbMixingTopGate.TabIndex = 34
        Me.pbMixingTopGate.TabStop = False
        '
        'pbBatchGate
        '
        Me.pbBatchGate.BackColor = System.Drawing.Color.Transparent
        Me.pbBatchGate.Image = Global.Automated_Feedmill_System.My.Resources.Resources.Red_Icon
        Me.pbBatchGate.Location = New System.Drawing.Point(584, 453)
        Me.pbBatchGate.Name = "pbBatchGate"
        Me.pbBatchGate.Size = New System.Drawing.Size(20, 20)
        Me.pbBatchGate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbBatchGate.TabIndex = 33
        Me.pbBatchGate.TabStop = False
        '
        'pbElev7
        '
        Me.pbElev7.BackColor = System.Drawing.Color.Transparent
        Me.pbElev7.Image = Global.Automated_Feedmill_System.My.Resources.Resources.Red_Icon
        Me.pbElev7.Location = New System.Drawing.Point(1044, 182)
        Me.pbElev7.Name = "pbElev7"
        Me.pbElev7.Size = New System.Drawing.Size(20, 20)
        Me.pbElev7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbElev7.TabIndex = 32
        Me.pbElev7.TabStop = False
        '
        'pbMixer
        '
        Me.pbMixer.BackColor = System.Drawing.Color.Transparent
        Me.pbMixer.Image = Global.Automated_Feedmill_System.My.Resources.Resources.Red_Icon
        Me.pbMixer.Location = New System.Drawing.Point(1030, 351)
        Me.pbMixer.Name = "pbMixer"
        Me.pbMixer.Size = New System.Drawing.Size(20, 20)
        Me.pbMixer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbMixer.TabIndex = 31
        Me.pbMixer.TabStop = False
        '
        'pbMixingConveyer
        '
        Me.pbMixingConveyer.BackColor = System.Drawing.Color.Transparent
        Me.pbMixingConveyer.Image = Global.Automated_Feedmill_System.My.Resources.Resources.Red_Icon
        Me.pbMixingConveyer.Location = New System.Drawing.Point(885, 453)
        Me.pbMixingConveyer.Name = "pbMixingConveyer"
        Me.pbMixingConveyer.Size = New System.Drawing.Size(20, 20)
        Me.pbMixingConveyer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbMixingConveyer.TabIndex = 30
        Me.pbMixingConveyer.TabStop = False
        '
        'pbMixingMolasses
        '
        Me.pbMixingMolasses.BackColor = System.Drawing.Color.Transparent
        Me.pbMixingMolasses.Image = Global.Automated_Feedmill_System.My.Resources.Resources.Red_Icon
        Me.pbMixingMolasses.Location = New System.Drawing.Point(926, 640)
        Me.pbMixingMolasses.Name = "pbMixingMolasses"
        Me.pbMixingMolasses.Size = New System.Drawing.Size(20, 20)
        Me.pbMixingMolasses.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbMixingMolasses.TabIndex = 29
        Me.pbMixingMolasses.TabStop = False
        '
        'pbMixingCoco
        '
        Me.pbMixingCoco.BackColor = System.Drawing.Color.Transparent
        Me.pbMixingCoco.Image = Global.Automated_Feedmill_System.My.Resources.Resources.Red_Icon
        Me.pbMixingCoco.Location = New System.Drawing.Point(852, 640)
        Me.pbMixingCoco.Name = "pbMixingCoco"
        Me.pbMixingCoco.Size = New System.Drawing.Size(20, 20)
        Me.pbMixingCoco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbMixingCoco.TabIndex = 28
        Me.pbMixingCoco.TabStop = False
        '
        'pbAirComp
        '
        Me.pbAirComp.BackColor = System.Drawing.Color.Transparent
        Me.pbAirComp.Image = Global.Automated_Feedmill_System.My.Resources.Resources.Red_Icon
        Me.pbAirComp.Location = New System.Drawing.Point(566, 652)
        Me.pbAirComp.Name = "pbAirComp"
        Me.pbAirComp.Size = New System.Drawing.Size(20, 20)
        Me.pbAirComp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbAirComp.TabIndex = 27
        Me.pbAirComp.TabStop = False
        '
        'pbElev6
        '
        Me.pbElev6.BackColor = System.Drawing.Color.Transparent
        Me.pbElev6.Image = Global.Automated_Feedmill_System.My.Resources.Resources.Red_Icon
        Me.pbElev6.Location = New System.Drawing.Point(831, 202)
        Me.pbElev6.Name = "pbElev6"
        Me.pbElev6.Size = New System.Drawing.Size(20, 20)
        Me.pbElev6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbElev6.TabIndex = 26
        Me.pbElev6.TabStop = False
        '
        'pbBatchConveyer
        '
        Me.pbBatchConveyer.BackColor = System.Drawing.Color.Transparent
        Me.pbBatchConveyer.Image = Global.Automated_Feedmill_System.My.Resources.Resources.Red_Icon
        Me.pbBatchConveyer.Location = New System.Drawing.Point(550, 500)
        Me.pbBatchConveyer.Name = "pbBatchConveyer"
        Me.pbBatchConveyer.Size = New System.Drawing.Size(20, 20)
        Me.pbBatchConveyer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbBatchConveyer.TabIndex = 25
        Me.pbBatchConveyer.TabStop = False
        '
        'pbSilo9
        '
        Me.pbSilo9.BackColor = System.Drawing.Color.Transparent
        Me.pbSilo9.Image = Global.Automated_Feedmill_System.My.Resources.Resources.Red_Icon
        Me.pbSilo9.Location = New System.Drawing.Point(796, 277)
        Me.pbSilo9.Name = "pbSilo9"
        Me.pbSilo9.Size = New System.Drawing.Size(20, 20)
        Me.pbSilo9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbSilo9.TabIndex = 24
        Me.pbSilo9.TabStop = False
        '
        'pbSilo8
        '
        Me.pbSilo8.BackColor = System.Drawing.Color.Transparent
        Me.pbSilo8.Image = Global.Automated_Feedmill_System.My.Resources.Resources.Red_Icon
        Me.pbSilo8.Location = New System.Drawing.Point(760, 277)
        Me.pbSilo8.Name = "pbSilo8"
        Me.pbSilo8.Size = New System.Drawing.Size(20, 20)
        Me.pbSilo8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbSilo8.TabIndex = 23
        Me.pbSilo8.TabStop = False
        '
        'pbSilo7
        '
        Me.pbSilo7.BackColor = System.Drawing.Color.Transparent
        Me.pbSilo7.Image = Global.Automated_Feedmill_System.My.Resources.Resources.Red_Icon
        Me.pbSilo7.Location = New System.Drawing.Point(724, 277)
        Me.pbSilo7.Name = "pbSilo7"
        Me.pbSilo7.Size = New System.Drawing.Size(20, 20)
        Me.pbSilo7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbSilo7.TabIndex = 22
        Me.pbSilo7.TabStop = False
        '
        'pbSilo6
        '
        Me.pbSilo6.BackColor = System.Drawing.Color.Transparent
        Me.pbSilo6.Image = Global.Automated_Feedmill_System.My.Resources.Resources.Red_Icon
        Me.pbSilo6.Location = New System.Drawing.Point(690, 277)
        Me.pbSilo6.Name = "pbSilo6"
        Me.pbSilo6.Size = New System.Drawing.Size(20, 20)
        Me.pbSilo6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbSilo6.TabIndex = 21
        Me.pbSilo6.TabStop = False
        '
        'pbSilo5
        '
        Me.pbSilo5.BackColor = System.Drawing.Color.Transparent
        Me.pbSilo5.Image = Global.Automated_Feedmill_System.My.Resources.Resources.Red_Icon
        Me.pbSilo5.Location = New System.Drawing.Point(655, 277)
        Me.pbSilo5.Name = "pbSilo5"
        Me.pbSilo5.Size = New System.Drawing.Size(20, 20)
        Me.pbSilo5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbSilo5.TabIndex = 20
        Me.pbSilo5.TabStop = False
        '
        'pbSilo3
        '
        Me.pbSilo3.BackColor = System.Drawing.Color.Transparent
        Me.pbSilo3.Image = Global.Automated_Feedmill_System.My.Resources.Resources.Red_Icon
        Me.pbSilo3.Location = New System.Drawing.Point(584, 277)
        Me.pbSilo3.Name = "pbSilo3"
        Me.pbSilo3.Size = New System.Drawing.Size(20, 20)
        Me.pbSilo3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbSilo3.TabIndex = 19
        Me.pbSilo3.TabStop = False
        '
        'pbSilo4
        '
        Me.pbSilo4.BackColor = System.Drawing.Color.Transparent
        Me.pbSilo4.Image = Global.Automated_Feedmill_System.My.Resources.Resources.Red_Icon
        Me.pbSilo4.Location = New System.Drawing.Point(620, 277)
        Me.pbSilo4.Name = "pbSilo4"
        Me.pbSilo4.Size = New System.Drawing.Size(20, 20)
        Me.pbSilo4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbSilo4.TabIndex = 19
        Me.pbSilo4.TabStop = False
        '
        'pbSilo2
        '
        Me.pbSilo2.BackColor = System.Drawing.Color.Transparent
        Me.pbSilo2.Image = Global.Automated_Feedmill_System.My.Resources.Resources.Red_Icon
        Me.pbSilo2.Location = New System.Drawing.Point(550, 277)
        Me.pbSilo2.Name = "pbSilo2"
        Me.pbSilo2.Size = New System.Drawing.Size(20, 20)
        Me.pbSilo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbSilo2.TabIndex = 18
        Me.pbSilo2.TabStop = False
        '
        'pbSilo1
        '
        Me.pbSilo1.BackColor = System.Drawing.Color.Transparent
        Me.pbSilo1.Image = Global.Automated_Feedmill_System.My.Resources.Resources.Red_Icon
        Me.pbSilo1.Location = New System.Drawing.Point(515, 277)
        Me.pbSilo1.Name = "pbSilo1"
        Me.pbSilo1.Size = New System.Drawing.Size(20, 20)
        Me.pbSilo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbSilo1.TabIndex = 17
        Me.pbSilo1.TabStop = False
        '
        'pbTopAuger3
        '
        Me.pbTopAuger3.Image = Global.Automated_Feedmill_System.My.Resources.Resources.Red_Icon
        Me.pbTopAuger3.Location = New System.Drawing.Point(783, 164)
        Me.pbTopAuger3.Name = "pbTopAuger3"
        Me.pbTopAuger3.Size = New System.Drawing.Size(20, 20)
        Me.pbTopAuger3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbTopAuger3.TabIndex = 16
        Me.pbTopAuger3.TabStop = False
        '
        'pbTopAuger2
        '
        Me.pbTopAuger2.Image = Global.Automated_Feedmill_System.My.Resources.Resources.Red_Icon
        Me.pbTopAuger2.Location = New System.Drawing.Point(681, 164)
        Me.pbTopAuger2.Name = "pbTopAuger2"
        Me.pbTopAuger2.Size = New System.Drawing.Size(20, 20)
        Me.pbTopAuger2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbTopAuger2.TabIndex = 15
        Me.pbTopAuger2.TabStop = False
        '
        'pbTopAuger1
        '
        Me.pbTopAuger1.Image = Global.Automated_Feedmill_System.My.Resources.Resources.Red_Icon
        Me.pbTopAuger1.Location = New System.Drawing.Point(579, 164)
        Me.pbTopAuger1.Name = "pbTopAuger1"
        Me.pbTopAuger1.Size = New System.Drawing.Size(20, 20)
        Me.pbTopAuger1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbTopAuger1.TabIndex = 14
        Me.pbTopAuger1.TabStop = False
        '
        'pbHamMill1
        '
        Me.pbHamMill1.Image = Global.Automated_Feedmill_System.My.Resources.Resources.Red_Icon
        Me.pbHamMill1.Location = New System.Drawing.Point(341, 233)
        Me.pbHamMill1.Name = "pbHamMill1"
        Me.pbHamMill1.Size = New System.Drawing.Size(20, 20)
        Me.pbHamMill1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbHamMill1.TabIndex = 13
        Me.pbHamMill1.TabStop = False
        '
        'pbHamMillScrew1
        '
        Me.pbHamMillScrew1.Image = Global.Automated_Feedmill_System.My.Resources.Resources.Red_Icon
        Me.pbHamMillScrew1.Location = New System.Drawing.Point(412, 248)
        Me.pbHamMillScrew1.Name = "pbHamMillScrew1"
        Me.pbHamMillScrew1.Size = New System.Drawing.Size(20, 20)
        Me.pbHamMillScrew1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbHamMillScrew1.TabIndex = 12
        Me.pbHamMillScrew1.TabStop = False
        '
        'pbHamMillFeed1
        '
        Me.pbHamMillFeed1.Image = Global.Automated_Feedmill_System.My.Resources.Resources.Red_Icon
        Me.pbHamMillFeed1.Location = New System.Drawing.Point(389, 150)
        Me.pbHamMillFeed1.Name = "pbHamMillFeed1"
        Me.pbHamMillFeed1.Size = New System.Drawing.Size(20, 20)
        Me.pbHamMillFeed1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbHamMillFeed1.TabIndex = 11
        Me.pbHamMillFeed1.TabStop = False
        '
        'pbElev4
        '
        Me.pbElev4.Image = Global.Automated_Feedmill_System.My.Resources.Resources.Red_Icon
        Me.pbElev4.Location = New System.Drawing.Point(411, 3)
        Me.pbElev4.Name = "pbElev4"
        Me.pbElev4.Size = New System.Drawing.Size(20, 20)
        Me.pbElev4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbElev4.TabIndex = 10
        Me.pbElev4.TabStop = False
        '
        'pbHamMill2
        '
        Me.pbHamMill2.Image = Global.Automated_Feedmill_System.My.Resources.Resources.Red_Icon
        Me.pbHamMill2.Location = New System.Drawing.Point(341, 568)
        Me.pbHamMill2.Name = "pbHamMill2"
        Me.pbHamMill2.Size = New System.Drawing.Size(20, 20)
        Me.pbHamMill2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbHamMill2.TabIndex = 9
        Me.pbHamMill2.TabStop = False
        '
        'pbHamMillScrew2
        '
        Me.pbHamMillScrew2.Image = Global.Automated_Feedmill_System.My.Resources.Resources.Red_Icon
        Me.pbHamMillScrew2.Location = New System.Drawing.Point(416, 582)
        Me.pbHamMillScrew2.Name = "pbHamMillScrew2"
        Me.pbHamMillScrew2.Size = New System.Drawing.Size(20, 20)
        Me.pbHamMillScrew2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbHamMillScrew2.TabIndex = 8
        Me.pbHamMillScrew2.TabStop = False
        '
        'pbHamMillFeed2
        '
        Me.pbHamMillFeed2.Image = Global.Automated_Feedmill_System.My.Resources.Resources.Red_Icon
        Me.pbHamMillFeed2.Location = New System.Drawing.Point(389, 484)
        Me.pbHamMillFeed2.Name = "pbHamMillFeed2"
        Me.pbHamMillFeed2.Size = New System.Drawing.Size(20, 20)
        Me.pbHamMillFeed2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbHamMillFeed2.TabIndex = 7
        Me.pbHamMillFeed2.TabStop = False
        '
        'pbElev5
        '
        Me.pbElev5.Image = Global.Automated_Feedmill_System.My.Resources.Resources.Red_Icon
        Me.pbElev5.Location = New System.Drawing.Point(411, 340)
        Me.pbElev5.Name = "pbElev5"
        Me.pbElev5.Size = New System.Drawing.Size(20, 20)
        Me.pbElev5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbElev5.TabIndex = 6
        Me.pbElev5.TabStop = False
        '
        'pbElev3
        '
        Me.pbElev3.Image = Global.Automated_Feedmill_System.My.Resources.Resources.Red_Icon
        Me.pbElev3.Location = New System.Drawing.Point(270, 373)
        Me.pbElev3.Name = "pbElev3"
        Me.pbElev3.Size = New System.Drawing.Size(20, 20)
        Me.pbElev3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbElev3.TabIndex = 5
        Me.pbElev3.TabStop = False
        '
        'pbDust2
        '
        Me.pbDust2.Image = Global.Automated_Feedmill_System.My.Resources.Resources.Red_Icon
        Me.pbDust2.Location = New System.Drawing.Point(228, 405)
        Me.pbDust2.Name = "pbDust2"
        Me.pbDust2.Size = New System.Drawing.Size(20, 20)
        Me.pbDust2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbDust2.TabIndex = 4
        Me.pbDust2.TabStop = False
        '
        'pbElev1
        '
        Me.pbElev1.Image = Global.Automated_Feedmill_System.My.Resources.Resources.Red_Icon
        Me.pbElev1.Location = New System.Drawing.Point(119, 292)
        Me.pbElev1.Name = "pbElev1"
        Me.pbElev1.Size = New System.Drawing.Size(20, 20)
        Me.pbElev1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbElev1.TabIndex = 3
        Me.pbElev1.TabStop = False
        '
        'pbDust1
        '
        Me.pbDust1.Image = Global.Automated_Feedmill_System.My.Resources.Resources.Red_Icon
        Me.pbDust1.Location = New System.Drawing.Point(232, 73)
        Me.pbDust1.Name = "pbDust1"
        Me.pbDust1.Size = New System.Drawing.Size(20, 20)
        Me.pbDust1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbDust1.TabIndex = 2
        Me.pbDust1.TabStop = False
        '
        'pbElev2
        '
        Me.pbElev2.Image = Global.Automated_Feedmill_System.My.Resources.Resources.Red_Icon
        Me.pbElev2.Location = New System.Drawing.Point(266, 44)
        Me.pbElev2.Name = "pbElev2"
        Me.pbElev2.Size = New System.Drawing.Size(20, 20)
        Me.pbElev2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbElev2.TabIndex = 1
        Me.pbElev2.TabStop = False
        '
        'lblWeight
        '
        Me.lblWeight.Font = New System.Drawing.Font("Segoe UI Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeight.Location = New System.Drawing.Point(558, 370)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(208, 44)
        Me.lblWeight.TabIndex = 0
        Me.lblWeight.Text = " "
        Me.lblWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmControlOverview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1440, 900)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmControlOverview"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmControlOverview"
        Me.Panel1.ResumeLayout(False)
        CType(Me.pbMixingBottomGate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbMixingTopGate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBatchGate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbElev7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbMixer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbMixingConveyer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbMixingMolasses, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbMixingCoco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbAirComp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbElev6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBatchConveyer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSilo9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSilo8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSilo7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSilo6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSilo5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSilo3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSilo4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSilo2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSilo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbTopAuger3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbTopAuger2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbTopAuger1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbHamMill1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbHamMillScrew1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbHamMillFeed1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbElev4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbHamMill2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbHamMillScrew2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbHamMillFeed2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbElev5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbElev3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbDust2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbElev1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbDust1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbElev2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents conWeight As IO.Ports.SerialPort
    Friend WithEvents lblWeight As Label
    Friend WithEvents conWeightTimer As Timer
    Friend WithEvents pbElev2 As PictureBox
    Friend WithEvents pbSilo1 As PictureBox
    Friend WithEvents pbTopAuger3 As PictureBox
    Friend WithEvents pbTopAuger2 As PictureBox
    Friend WithEvents pbTopAuger1 As PictureBox
    Friend WithEvents pbHamMill1 As PictureBox
    Friend WithEvents pbHamMillScrew1 As PictureBox
    Friend WithEvents pbHamMillFeed1 As PictureBox
    Friend WithEvents pbElev4 As PictureBox
    Friend WithEvents pbHamMill2 As PictureBox
    Friend WithEvents pbHamMillScrew2 As PictureBox
    Friend WithEvents pbHamMillFeed2 As PictureBox
    Friend WithEvents pbElev5 As PictureBox
    Friend WithEvents pbElev3 As PictureBox
    Friend WithEvents pbDust2 As PictureBox
    Friend WithEvents pbElev1 As PictureBox
    Friend WithEvents pbDust1 As PictureBox
    Friend WithEvents pbMixingBottomGate As PictureBox
    Friend WithEvents pbMixingTopGate As PictureBox
    Friend WithEvents pbBatchGate As PictureBox
    Friend WithEvents pbElev7 As PictureBox
    Friend WithEvents pbMixer As PictureBox
    Friend WithEvents pbMixingConveyer As PictureBox
    Friend WithEvents pbMixingMolasses As PictureBox
    Friend WithEvents pbMixingCoco As PictureBox
    Friend WithEvents pbAirComp As PictureBox
    Friend WithEvents pbElev6 As PictureBox
    Friend WithEvents pbBatchConveyer As PictureBox
    Friend WithEvents pbSilo9 As PictureBox
    Friend WithEvents pbSilo8 As PictureBox
    Friend WithEvents pbSilo7 As PictureBox
    Friend WithEvents pbSilo6 As PictureBox
    Friend WithEvents pbSilo5 As PictureBox
    Friend WithEvents pbSilo3 As PictureBox
    Friend WithEvents pbSilo4 As PictureBox
    Friend WithEvents pbSilo2 As PictureBox
    Friend WithEvents conWeightLiquid As IO.Ports.SerialPort
    Friend WithEvents lblweightLiquid As Label
End Class
