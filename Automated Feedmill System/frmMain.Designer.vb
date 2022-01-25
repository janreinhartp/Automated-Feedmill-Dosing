<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.drawer = New System.Windows.Forms.Panel()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Buttons = New System.Windows.Forms.Panel()
        Me.btnSettings = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnUserSettings = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnReports = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnSiloSettings = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnFormula = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnBatching = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnAutomaticControl = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Title = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.content = New System.Windows.Forms.Panel()
        Me.pnlAutomaticControl = New System.Windows.Forms.Panel()
        Me.Panel63 = New System.Windows.Forms.Panel()
        Me.swtSiloGate8 = New Bunifu.Framework.UI.BunifuSwitch()
        Me.swtSiloGate7 = New Bunifu.Framework.UI.BunifuSwitch()
        Me.Label119 = New System.Windows.Forms.Label()
        Me.Label120 = New System.Windows.Forms.Label()
        Me.swtSiloGate5 = New Bunifu.Framework.UI.BunifuSwitch()
        Me.swtSiloGate4 = New Bunifu.Framework.UI.BunifuSwitch()
        Me.Label113 = New System.Windows.Forms.Label()
        Me.Label114 = New System.Windows.Forms.Label()
        Me.swtSiloGate2 = New Bunifu.Framework.UI.BunifuSwitch()
        Me.Label116 = New System.Windows.Forms.Label()
        Me.swtSiloGate1 = New Bunifu.Framework.UI.BunifuSwitch()
        Me.Label117 = New System.Windows.Forms.Label()
        Me.Label118 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.swtMixingPump = New Bunifu.Framework.UI.BunifuSwitch()
        Me.Label109 = New System.Windows.Forms.Label()
        Me.swtMixingElev = New Bunifu.Framework.UI.BunifuSwitch()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.swtMixingBotGate = New Bunifu.Framework.UI.BunifuSwitch()
        Me.swtMixer = New Bunifu.Framework.UI.BunifuSwitch()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.swtMixingTopGate = New Bunifu.Framework.UI.BunifuSwitch()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.swtBatchElev = New Bunifu.Framework.UI.BunifuSwitch()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.swtBatchGate = New Bunifu.Framework.UI.BunifuSwitch()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.swtElev3 = New Bunifu.Framework.UI.BunifuSwitch()
        Me.swtElev2 = New Bunifu.Framework.UI.BunifuSwitch()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.swtElev1 = New Bunifu.Framework.UI.BunifuSwitch()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.swtHamMillElev2 = New Bunifu.Framework.UI.BunifuSwitch()
        Me.swtHamMill2 = New Bunifu.Framework.UI.BunifuSwitch()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.swtHamMillFeed2 = New Bunifu.Framework.UI.BunifuSwitch()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.swtHamMillElev1 = New Bunifu.Framework.UI.BunifuSwitch()
        Me.swtHamMill1 = New Bunifu.Framework.UI.BunifuSwitch()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.swtHamMillFeed1 = New Bunifu.Framework.UI.BunifuSwitch()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pnlSettings = New System.Windows.Forms.Panel()
        Me.cmbardComport = New System.Windows.Forms.ComboBox()
        Me.Label112 = New System.Windows.Forms.Label()
        Me.btnCalibrate = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.txtbSettingsScreenPosition = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnSettingsSave = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.txtbSettingsLiquidAdjust = New System.Windows.Forms.TextBox()
        Me.txtbSettingsBatchAdjust = New System.Windows.Forms.TextBox()
        Me.Label105 = New System.Windows.Forms.Label()
        Me.Label106 = New System.Windows.Forms.Label()
        Me.Label104 = New System.Windows.Forms.Label()
        Me.cmbLiquicComPort = New System.Windows.Forms.ComboBox()
        Me.cmbScaleComPort = New System.Windows.Forms.ComboBox()
        Me.cmbPLCComPort = New System.Windows.Forms.ComboBox()
        Me.Label103 = New System.Windows.Forms.Label()
        Me.Label102 = New System.Windows.Forms.Label()
        Me.Label99 = New System.Windows.Forms.Label()
        Me.Label90 = New System.Windows.Forms.Label()
        Me.pnlFormula = New System.Windows.Forms.Panel()
        Me.Label107 = New System.Windows.Forms.Label()
        Me.Label96 = New System.Windows.Forms.Label()
        Me.txtbFormCoco = New System.Windows.Forms.TextBox()
        Me.Label93 = New System.Windows.Forms.Label()
        Me.txtbFormMolasses = New System.Windows.Forms.TextBox()
        Me.Label81 = New System.Windows.Forms.Label()
        Me.lblFormulaId = New System.Windows.Forms.Label()
        Me.btnDeleteFormula = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnUpdateFormula = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnAddFormula = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.dgvFormula = New System.Windows.Forms.DataGridView()
        Me.cmbFormSiloSet = New System.Windows.Forms.ComboBox()
        Me.Label72 = New System.Windows.Forms.Label()
        Me.txtbFormulaName = New System.Windows.Forms.TextBox()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.Panel25 = New System.Windows.Forms.Panel()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.Panel26 = New System.Windows.Forms.Panel()
        Me.lblFormulaSilo9 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtbFormSilo9 = New System.Windows.Forms.TextBox()
        Me.Panel27 = New System.Windows.Forms.Panel()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.Panel28 = New System.Windows.Forms.Panel()
        Me.lblFormulaSilo8 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtbFormSilo8 = New System.Windows.Forms.TextBox()
        Me.Panel29 = New System.Windows.Forms.Panel()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.txtbFormSilo6 = New System.Windows.Forms.TextBox()
        Me.Panel30 = New System.Windows.Forms.Panel()
        Me.lblFormulaSilo6 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Panel31 = New System.Windows.Forms.Panel()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.txtbFormSilo7 = New System.Windows.Forms.TextBox()
        Me.Panel32 = New System.Windows.Forms.Panel()
        Me.lblFormulaSilo7 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Panel33 = New System.Windows.Forms.Panel()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.txtbFormSilo3 = New System.Windows.Forms.TextBox()
        Me.Panel34 = New System.Windows.Forms.Panel()
        Me.lblFormulaSilo3 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Panel35 = New System.Windows.Forms.Panel()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.txtbFormSilo1 = New System.Windows.Forms.TextBox()
        Me.Panel36 = New System.Windows.Forms.Panel()
        Me.lblFormulaSilo1 = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Panel37 = New System.Windows.Forms.Panel()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txtbFormSilo5 = New System.Windows.Forms.TextBox()
        Me.Panel38 = New System.Windows.Forms.Panel()
        Me.lblFormulaSilo5 = New System.Windows.Forms.Label()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.Panel39 = New System.Windows.Forms.Panel()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtbFormSilo4 = New System.Windows.Forms.TextBox()
        Me.Panel40 = New System.Windows.Forms.Panel()
        Me.lblFormulaSilo4 = New System.Windows.Forms.Label()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.Panel41 = New System.Windows.Forms.Panel()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.txtbFormSilo2 = New System.Windows.Forms.TextBox()
        Me.Panel42 = New System.Windows.Forms.Panel()
        Me.lblFormulaSilo2 = New System.Windows.Forms.Label()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.pnlBatching = New System.Windows.Forms.Panel()
        Me.lblbatchingCoco = New System.Windows.Forms.Label()
        Me.lblbatchingMol = New System.Windows.Forms.Label()
        Me.Label110 = New System.Windows.Forms.Label()
        Me.Label111 = New System.Windows.Forms.Label()
        Me.gbBatchingStatus = New System.Windows.Forms.GroupBox()
        Me.Label84 = New System.Windows.Forms.Label()
        Me.lblliquidCurrentTargetLoad = New System.Windows.Forms.Label()
        Me.Label108 = New System.Windows.Forms.Label()
        Me.lblliquidcurrent = New System.Windows.Forms.Label()
        Me.lblbatchno = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.lblBatchActiveSilo = New System.Windows.Forms.Label()
        Me.lblBatchBinCurrent = New System.Windows.Forms.Label()
        Me.lblBatchCurrentTarget = New System.Windows.Forms.Label()
        Me.lblBatchTotalTarget = New System.Windows.Forms.Label()
        Me.cmbFormulaBatching = New System.Windows.Forms.ComboBox()
        Me.btnStartBatching = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Panel19 = New System.Windows.Forms.Panel()
        Me.Panel20 = New System.Windows.Forms.Panel()
        Me.lblBatchSiloMaterial9 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.lblBatchSiloWeight9 = New System.Windows.Forms.Label()
        Me.Panel21 = New System.Windows.Forms.Panel()
        Me.Panel22 = New System.Windows.Forms.Panel()
        Me.lblBatchSiloMaterial8 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.lblBatchSiloWeight8 = New System.Windows.Forms.Label()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.lblBatchSiloMaterial6 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.lblBatchSiloWeight6 = New System.Windows.Forms.Label()
        Me.Panel23 = New System.Windows.Forms.Panel()
        Me.Panel24 = New System.Windows.Forms.Panel()
        Me.lblBatchSiloMaterial7 = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.lblBatchSiloWeight7 = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.lblBatchSiloMaterial3 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.lblBatchSiloWeight3 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.lblBatchSiloMaterial1 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.lblBatchSiloWeight1 = New System.Windows.Forms.Label()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.lblBatchSiloMaterial5 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.lblBatchSiloWeight5 = New System.Windows.Forms.Label()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.lblBatchSiloMaterial4 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.lblBatchSiloWeight4 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.lblBatchSiloMaterial2 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.lblBatchSiloWeight2 = New System.Windows.Forms.Label()
        Me.pnlReports = New System.Windows.Forms.Panel()
        Me.Panel62 = New System.Windows.Forms.Panel()
        Me.crviewr = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Panel43 = New System.Windows.Forms.Panel()
        Me.pnlDate = New System.Windows.Forms.Panel()
        Me.dtpFrom = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.dtpTo = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.pnlBatchID = New System.Windows.Forms.Panel()
        Me.txtbReportBatchID = New Bunifu.Framework.UI.BunifuTextbox()
        Me.Label78 = New System.Windows.Forms.Label()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.chkBoxIndividual = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.chkReportsByDate = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.btnReportShow = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.pnlWelcome = New System.Windows.Forms.Panel()
        Me.Panel65 = New System.Windows.Forms.Panel()
        Me.lblConWeightLiquid = New System.Windows.Forms.Label()
        Me.Label87 = New System.Windows.Forms.Label()
        Me.pbWeighingLiquid = New System.Windows.Forms.PictureBox()
        Me.lblTextCon = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Panel64 = New System.Windows.Forms.Panel()
        Me.lblConWeight = New System.Windows.Forms.Label()
        Me.Label75 = New System.Windows.Forms.Label()
        Me.pbWeighing = New System.Windows.Forms.PictureBox()
        Me.pnlPLC = New System.Windows.Forms.Panel()
        Me.lblConPLC = New System.Windows.Forms.Label()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.pbPLC = New System.Windows.Forms.PictureBox()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.pnlUsers = New System.Windows.Forms.Panel()
        Me.btnUserDelete = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnUserEdit = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnUserAdd = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.lblUserID = New System.Windows.Forms.Label()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.cmbUserPosition = New System.Windows.Forms.ComboBox()
        Me.cmbUserStatus = New System.Windows.Forms.ComboBox()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.txtbUserPassword = New System.Windows.Forms.TextBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.txtbUserUsername = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.txtbUserLName = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txtbUserMName = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtbUserFName = New System.Windows.Forms.TextBox()
        Me.dgvUsers = New System.Windows.Forms.DataGridView()
        Me.pnlSiloSettings = New System.Windows.Forms.Panel()
        Me.lblSiloSetNo = New System.Windows.Forms.Label()
        Me.btnSiloSetDelete = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnSiloSetEdit = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnSiloSetAdd = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.dgvSiloSettings = New System.Windows.Forms.DataGridView()
        Me.Label73 = New System.Windows.Forms.Label()
        Me.txtbSiloSetName = New System.Windows.Forms.TextBox()
        Me.Label74 = New System.Windows.Forms.Label()
        Me.Panel44 = New System.Windows.Forms.Panel()
        Me.Panel45 = New System.Windows.Forms.Panel()
        Me.Label76 = New System.Windows.Forms.Label()
        Me.Label77 = New System.Windows.Forms.Label()
        Me.txtbSiloSetSilo9 = New System.Windows.Forms.TextBox()
        Me.Panel46 = New System.Windows.Forms.Panel()
        Me.Panel47 = New System.Windows.Forms.Panel()
        Me.Label79 = New System.Windows.Forms.Label()
        Me.Label80 = New System.Windows.Forms.Label()
        Me.txtbSiloSetSilo8 = New System.Windows.Forms.TextBox()
        Me.Panel48 = New System.Windows.Forms.Panel()
        Me.txtbSiloSetSilo6 = New System.Windows.Forms.TextBox()
        Me.Panel49 = New System.Windows.Forms.Panel()
        Me.Label82 = New System.Windows.Forms.Label()
        Me.Label83 = New System.Windows.Forms.Label()
        Me.Panel50 = New System.Windows.Forms.Panel()
        Me.txtbSiloSetSilo7 = New System.Windows.Forms.TextBox()
        Me.Panel51 = New System.Windows.Forms.Panel()
        Me.Label85 = New System.Windows.Forms.Label()
        Me.Label86 = New System.Windows.Forms.Label()
        Me.Panel52 = New System.Windows.Forms.Panel()
        Me.txtbSiloSetSilo3 = New System.Windows.Forms.TextBox()
        Me.Panel53 = New System.Windows.Forms.Panel()
        Me.Label88 = New System.Windows.Forms.Label()
        Me.Label89 = New System.Windows.Forms.Label()
        Me.Panel54 = New System.Windows.Forms.Panel()
        Me.txtbSiloSetSilo1 = New System.Windows.Forms.TextBox()
        Me.Panel55 = New System.Windows.Forms.Panel()
        Me.Label91 = New System.Windows.Forms.Label()
        Me.Label92 = New System.Windows.Forms.Label()
        Me.Panel56 = New System.Windows.Forms.Panel()
        Me.txtbSiloSetSilo5 = New System.Windows.Forms.TextBox()
        Me.Panel57 = New System.Windows.Forms.Panel()
        Me.Label94 = New System.Windows.Forms.Label()
        Me.Label95 = New System.Windows.Forms.Label()
        Me.Panel58 = New System.Windows.Forms.Panel()
        Me.txtbSiloSetSilo4 = New System.Windows.Forms.TextBox()
        Me.Panel59 = New System.Windows.Forms.Panel()
        Me.Label97 = New System.Windows.Forms.Label()
        Me.Label98 = New System.Windows.Forms.Label()
        Me.Panel60 = New System.Windows.Forms.Panel()
        Me.txtbSiloSetSilo2 = New System.Windows.Forms.TextBox()
        Me.Panel61 = New System.Windows.Forms.Panel()
        Me.Label100 = New System.Windows.Forms.Label()
        Me.Label101 = New System.Windows.Forms.Label()
        Me.formText = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.btnExit = New Bunifu.Framework.UI.BunifuImageButton()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.conControl = New System.IO.Ports.SerialPort(Me.components)
        Me.dateTimeTimer = New System.Windows.Forms.Timer(Me.components)
        Me.closeTimer = New System.Windows.Forms.Timer(Me.components)
        Me.batchingWeightTimer = New System.Windows.Forms.Timer(Me.components)
        Me.checkCon = New System.Windows.Forms.Timer(Me.components)
        Me.timerUiUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.conArd = New System.IO.Ports.SerialPort(Me.components)
        Me.ardControlTimer = New System.Windows.Forms.Timer(Me.components)
        Me.drawer.SuspendLayout()
        Me.Buttons.SuspendLayout()
        Me.Title.SuspendLayout()
        Me.content.SuspendLayout()
        Me.pnlAutomaticControl.SuspendLayout()
        Me.Panel63.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.pnlSettings.SuspendLayout()
        Me.pnlFormula.SuspendLayout()
        CType(Me.dgvFormula, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel25.SuspendLayout()
        Me.Panel26.SuspendLayout()
        Me.Panel27.SuspendLayout()
        Me.Panel28.SuspendLayout()
        Me.Panel29.SuspendLayout()
        Me.Panel30.SuspendLayout()
        Me.Panel31.SuspendLayout()
        Me.Panel32.SuspendLayout()
        Me.Panel33.SuspendLayout()
        Me.Panel34.SuspendLayout()
        Me.Panel35.SuspendLayout()
        Me.Panel36.SuspendLayout()
        Me.Panel37.SuspendLayout()
        Me.Panel38.SuspendLayout()
        Me.Panel39.SuspendLayout()
        Me.Panel40.SuspendLayout()
        Me.Panel41.SuspendLayout()
        Me.Panel42.SuspendLayout()
        Me.pnlBatching.SuspendLayout()
        Me.gbBatchingStatus.SuspendLayout()
        Me.Panel19.SuspendLayout()
        Me.Panel20.SuspendLayout()
        Me.Panel21.SuspendLayout()
        Me.Panel22.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.Panel23.SuspendLayout()
        Me.Panel24.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel16.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.Panel15.SuspendLayout()
        Me.Panel17.SuspendLayout()
        Me.Panel18.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.pnlReports.SuspendLayout()
        Me.Panel62.SuspendLayout()
        Me.Panel43.SuspendLayout()
        Me.pnlDate.SuspendLayout()
        Me.pnlBatchID.SuspendLayout()
        Me.pnlWelcome.SuspendLayout()
        Me.Panel65.SuspendLayout()
        CType(Me.pbWeighingLiquid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel64.SuspendLayout()
        CType(Me.pbWeighing, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPLC.SuspendLayout()
        CType(Me.pbPLC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlUsers.SuspendLayout()
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSiloSettings.SuspendLayout()
        CType(Me.dgvSiloSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel44.SuspendLayout()
        Me.Panel45.SuspendLayout()
        Me.Panel46.SuspendLayout()
        Me.Panel47.SuspendLayout()
        Me.Panel48.SuspendLayout()
        Me.Panel49.SuspendLayout()
        Me.Panel50.SuspendLayout()
        Me.Panel51.SuspendLayout()
        Me.Panel52.SuspendLayout()
        Me.Panel53.SuspendLayout()
        Me.Panel54.SuspendLayout()
        Me.Panel55.SuspendLayout()
        Me.Panel56.SuspendLayout()
        Me.Panel57.SuspendLayout()
        Me.Panel58.SuspendLayout()
        Me.Panel59.SuspendLayout()
        Me.Panel60.SuspendLayout()
        Me.Panel61.SuspendLayout()
        Me.formText.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'drawer
        '
        Me.drawer.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.drawer.Controls.Add(Me.lblDate)
        Me.drawer.Controls.Add(Me.lblTime)
        Me.drawer.Controls.Add(Me.Buttons)
        Me.drawer.Controls.Add(Me.Title)
        Me.drawer.Dock = System.Windows.Forms.DockStyle.Left
        Me.drawer.Location = New System.Drawing.Point(0, 0)
        Me.drawer.Name = "drawer"
        Me.drawer.Size = New System.Drawing.Size(209, 700)
        Me.drawer.TabIndex = 0
        '
        'lblDate
        '
        Me.lblDate.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblDate.ForeColor = System.Drawing.Color.White
        Me.lblDate.Location = New System.Drawing.Point(18, 615)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(149, 73)
        Me.lblDate.TabIndex = 7
        Me.lblDate.Text = "June 10,2019"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblTime.ForeColor = System.Drawing.Color.White
        Me.lblTime.Location = New System.Drawing.Point(18, 585)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(104, 28)
        Me.lblTime.TabIndex = 6
        Me.lblTime.Text = "10:00 AM"
        '
        'Buttons
        '
        Me.Buttons.Controls.Add(Me.btnSettings)
        Me.Buttons.Controls.Add(Me.btnUserSettings)
        Me.Buttons.Controls.Add(Me.btnReports)
        Me.Buttons.Controls.Add(Me.btnSiloSettings)
        Me.Buttons.Controls.Add(Me.btnFormula)
        Me.Buttons.Controls.Add(Me.btnBatching)
        Me.Buttons.Controls.Add(Me.btnAutomaticControl)
        Me.Buttons.Dock = System.Windows.Forms.DockStyle.Top
        Me.Buttons.Location = New System.Drawing.Point(0, 100)
        Me.Buttons.Name = "Buttons"
        Me.Buttons.Size = New System.Drawing.Size(209, 450)
        Me.Buttons.TabIndex = 5
        '
        'btnSettings
        '
        Me.btnSettings.Activecolor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btnSettings.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSettings.BorderRadius = 0
        Me.btnSettings.ButtonText = "Settings"
        Me.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSettings.DisabledColor = System.Drawing.Color.Gray
        Me.btnSettings.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnSettings.Iconcolor = System.Drawing.Color.Transparent
        Me.btnSettings.Iconimage = Nothing
        Me.btnSettings.Iconimage_right = Global.Automated_Feedmill_System.My.Resources.Resources.Automation_96px
        Me.btnSettings.Iconimage_right_Selected = Nothing
        Me.btnSettings.Iconimage_Selected = Nothing
        Me.btnSettings.IconMarginLeft = 0
        Me.btnSettings.IconMarginRight = 0
        Me.btnSettings.IconRightVisible = True
        Me.btnSettings.IconRightZoom = 50.0R
        Me.btnSettings.IconVisible = True
        Me.btnSettings.IconZoom = 50.0R
        Me.btnSettings.IsTab = False
        Me.btnSettings.Location = New System.Drawing.Point(0, 387)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btnSettings.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnSettings.OnHoverTextColor = System.Drawing.Color.White
        Me.btnSettings.selected = False
        Me.btnSettings.Size = New System.Drawing.Size(209, 63)
        Me.btnSettings.TabIndex = 7
        Me.btnSettings.Text = "Settings"
        Me.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSettings.Textcolor = System.Drawing.Color.Gainsboro
        Me.btnSettings.TextFont = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnUserSettings
        '
        Me.btnUserSettings.Activecolor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btnUserSettings.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btnUserSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUserSettings.BorderRadius = 0
        Me.btnUserSettings.ButtonText = "User Settings"
        Me.btnUserSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUserSettings.DisabledColor = System.Drawing.Color.Gray
        Me.btnUserSettings.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnUserSettings.Iconcolor = System.Drawing.Color.Transparent
        Me.btnUserSettings.Iconimage = Nothing
        Me.btnUserSettings.Iconimage_right = Global.Automated_Feedmill_System.My.Resources.Resources.Admin_Settings_Male_96px
        Me.btnUserSettings.Iconimage_right_Selected = Nothing
        Me.btnUserSettings.Iconimage_Selected = Nothing
        Me.btnUserSettings.IconMarginLeft = 0
        Me.btnUserSettings.IconMarginRight = 0
        Me.btnUserSettings.IconRightVisible = True
        Me.btnUserSettings.IconRightZoom = 50.0R
        Me.btnUserSettings.IconVisible = True
        Me.btnUserSettings.IconZoom = 50.0R
        Me.btnUserSettings.IsTab = False
        Me.btnUserSettings.Location = New System.Drawing.Point(0, 315)
        Me.btnUserSettings.Name = "btnUserSettings"
        Me.btnUserSettings.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btnUserSettings.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnUserSettings.OnHoverTextColor = System.Drawing.Color.White
        Me.btnUserSettings.selected = False
        Me.btnUserSettings.Size = New System.Drawing.Size(209, 63)
        Me.btnUserSettings.TabIndex = 5
        Me.btnUserSettings.Text = "User Settings"
        Me.btnUserSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUserSettings.Textcolor = System.Drawing.Color.Gainsboro
        Me.btnUserSettings.TextFont = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnReports
        '
        Me.btnReports.Activecolor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btnReports.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btnReports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnReports.BorderRadius = 0
        Me.btnReports.ButtonText = "Reports"
        Me.btnReports.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReports.DisabledColor = System.Drawing.Color.Gray
        Me.btnReports.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnReports.Iconcolor = System.Drawing.Color.Transparent
        Me.btnReports.Iconimage = Nothing
        Me.btnReports.Iconimage_right = Global.Automated_Feedmill_System.My.Resources.Resources.Folder_96px
        Me.btnReports.Iconimage_right_Selected = Nothing
        Me.btnReports.Iconimage_Selected = Nothing
        Me.btnReports.IconMarginLeft = 0
        Me.btnReports.IconMarginRight = 0
        Me.btnReports.IconRightVisible = True
        Me.btnReports.IconRightZoom = 50.0R
        Me.btnReports.IconVisible = True
        Me.btnReports.IconZoom = 50.0R
        Me.btnReports.IsTab = False
        Me.btnReports.Location = New System.Drawing.Point(0, 252)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btnReports.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnReports.OnHoverTextColor = System.Drawing.Color.White
        Me.btnReports.selected = False
        Me.btnReports.Size = New System.Drawing.Size(209, 63)
        Me.btnReports.TabIndex = 6
        Me.btnReports.Text = "Reports"
        Me.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReports.Textcolor = System.Drawing.Color.Gainsboro
        Me.btnReports.TextFont = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnSiloSettings
        '
        Me.btnSiloSettings.Activecolor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btnSiloSettings.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btnSiloSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSiloSettings.BorderRadius = 0
        Me.btnSiloSettings.ButtonText = "Silo Settings"
        Me.btnSiloSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSiloSettings.DisabledColor = System.Drawing.Color.Gray
        Me.btnSiloSettings.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSiloSettings.Iconcolor = System.Drawing.Color.Transparent
        Me.btnSiloSettings.Iconimage = Nothing
        Me.btnSiloSettings.Iconimage_right = Global.Automated_Feedmill_System.My.Resources.Resources.Database_Administrator_96px
        Me.btnSiloSettings.Iconimage_right_Selected = Nothing
        Me.btnSiloSettings.Iconimage_Selected = Nothing
        Me.btnSiloSettings.IconMarginLeft = 0
        Me.btnSiloSettings.IconMarginRight = 0
        Me.btnSiloSettings.IconRightVisible = True
        Me.btnSiloSettings.IconRightZoom = 50.0R
        Me.btnSiloSettings.IconVisible = True
        Me.btnSiloSettings.IconZoom = 50.0R
        Me.btnSiloSettings.IsTab = False
        Me.btnSiloSettings.Location = New System.Drawing.Point(0, 189)
        Me.btnSiloSettings.Name = "btnSiloSettings"
        Me.btnSiloSettings.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btnSiloSettings.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnSiloSettings.OnHoverTextColor = System.Drawing.Color.White
        Me.btnSiloSettings.selected = False
        Me.btnSiloSettings.Size = New System.Drawing.Size(209, 63)
        Me.btnSiloSettings.TabIndex = 4
        Me.btnSiloSettings.Text = "Silo Settings"
        Me.btnSiloSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSiloSettings.Textcolor = System.Drawing.Color.Gainsboro
        Me.btnSiloSettings.TextFont = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnFormula
        '
        Me.btnFormula.Activecolor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btnFormula.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btnFormula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnFormula.BorderRadius = 0
        Me.btnFormula.ButtonText = "Formula"
        Me.btnFormula.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFormula.DisabledColor = System.Drawing.Color.Gray
        Me.btnFormula.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnFormula.Iconcolor = System.Drawing.Color.Transparent
        Me.btnFormula.Iconimage = Nothing
        Me.btnFormula.Iconimage_right = Global.Automated_Feedmill_System.My.Resources.Resources.Test_Tube_96px
        Me.btnFormula.Iconimage_right_Selected = Nothing
        Me.btnFormula.Iconimage_Selected = Nothing
        Me.btnFormula.IconMarginLeft = 0
        Me.btnFormula.IconMarginRight = 0
        Me.btnFormula.IconRightVisible = True
        Me.btnFormula.IconRightZoom = 50.0R
        Me.btnFormula.IconVisible = True
        Me.btnFormula.IconZoom = 50.0R
        Me.btnFormula.IsTab = False
        Me.btnFormula.Location = New System.Drawing.Point(0, 126)
        Me.btnFormula.Name = "btnFormula"
        Me.btnFormula.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btnFormula.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnFormula.OnHoverTextColor = System.Drawing.Color.White
        Me.btnFormula.selected = False
        Me.btnFormula.Size = New System.Drawing.Size(209, 63)
        Me.btnFormula.TabIndex = 3
        Me.btnFormula.Text = "Formula"
        Me.btnFormula.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFormula.Textcolor = System.Drawing.Color.Gainsboro
        Me.btnFormula.TextFont = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnBatching
        '
        Me.btnBatching.Activecolor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btnBatching.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btnBatching.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBatching.BorderRadius = 0
        Me.btnBatching.ButtonText = "Batching"
        Me.btnBatching.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBatching.DisabledColor = System.Drawing.Color.Gray
        Me.btnBatching.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBatching.Iconcolor = System.Drawing.Color.Transparent
        Me.btnBatching.Iconimage = Nothing
        Me.btnBatching.Iconimage_right = Global.Automated_Feedmill_System.My.Resources.Resources.Industrial_Scales_Connected_96px
        Me.btnBatching.Iconimage_right_Selected = Nothing
        Me.btnBatching.Iconimage_Selected = Nothing
        Me.btnBatching.IconMarginLeft = 0
        Me.btnBatching.IconMarginRight = 0
        Me.btnBatching.IconRightVisible = True
        Me.btnBatching.IconRightZoom = 50.0R
        Me.btnBatching.IconVisible = True
        Me.btnBatching.IconZoom = 50.0R
        Me.btnBatching.IsTab = False
        Me.btnBatching.Location = New System.Drawing.Point(0, 63)
        Me.btnBatching.Name = "btnBatching"
        Me.btnBatching.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btnBatching.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnBatching.OnHoverTextColor = System.Drawing.Color.White
        Me.btnBatching.selected = False
        Me.btnBatching.Size = New System.Drawing.Size(209, 63)
        Me.btnBatching.TabIndex = 2
        Me.btnBatching.Text = "Batching"
        Me.btnBatching.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBatching.Textcolor = System.Drawing.Color.Gainsboro
        Me.btnBatching.TextFont = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnAutomaticControl
        '
        Me.btnAutomaticControl.Activecolor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btnAutomaticControl.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btnAutomaticControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAutomaticControl.BorderRadius = 0
        Me.btnAutomaticControl.ButtonText = "Automatic Control"
        Me.btnAutomaticControl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAutomaticControl.DisabledColor = System.Drawing.Color.Gray
        Me.btnAutomaticControl.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAutomaticControl.Iconcolor = System.Drawing.Color.Transparent
        Me.btnAutomaticControl.Iconimage = Nothing
        Me.btnAutomaticControl.Iconimage_right = Global.Automated_Feedmill_System.My.Resources.Resources.List_96px
        Me.btnAutomaticControl.Iconimage_right_Selected = Nothing
        Me.btnAutomaticControl.Iconimage_Selected = Nothing
        Me.btnAutomaticControl.IconMarginLeft = 0
        Me.btnAutomaticControl.IconMarginRight = 0
        Me.btnAutomaticControl.IconRightVisible = True
        Me.btnAutomaticControl.IconRightZoom = 50.0R
        Me.btnAutomaticControl.IconVisible = True
        Me.btnAutomaticControl.IconZoom = 50.0R
        Me.btnAutomaticControl.IsTab = False
        Me.btnAutomaticControl.Location = New System.Drawing.Point(0, 0)
        Me.btnAutomaticControl.Name = "btnAutomaticControl"
        Me.btnAutomaticControl.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btnAutomaticControl.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnAutomaticControl.OnHoverTextColor = System.Drawing.Color.White
        Me.btnAutomaticControl.selected = False
        Me.btnAutomaticControl.Size = New System.Drawing.Size(209, 63)
        Me.btnAutomaticControl.TabIndex = 1
        Me.btnAutomaticControl.Text = "Automatic Control"
        Me.btnAutomaticControl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAutomaticControl.Textcolor = System.Drawing.Color.Gainsboro
        Me.btnAutomaticControl.TextFont = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Title
        '
        Me.Title.Controls.Add(Me.Label2)
        Me.Title.Controls.Add(Me.Label1)
        Me.Title.Dock = System.Windows.Forms.DockStyle.Top
        Me.Title.Location = New System.Drawing.Point(0, 0)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(209, 100)
        Me.Title.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(58, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Feedmill"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(31, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ross Farm"
        '
        'content
        '
        Me.content.Controls.Add(Me.pnlAutomaticControl)
        Me.content.Controls.Add(Me.pnlSettings)
        Me.content.Controls.Add(Me.pnlFormula)
        Me.content.Controls.Add(Me.pnlBatching)
        Me.content.Controls.Add(Me.pnlReports)
        Me.content.Controls.Add(Me.pnlWelcome)
        Me.content.Controls.Add(Me.pnlUsers)
        Me.content.Controls.Add(Me.pnlSiloSettings)
        Me.content.Controls.Add(Me.formText)
        Me.content.Dock = System.Windows.Forms.DockStyle.Fill
        Me.content.Location = New System.Drawing.Point(209, 0)
        Me.content.Name = "content"
        Me.content.Size = New System.Drawing.Size(791, 700)
        Me.content.TabIndex = 1
        '
        'pnlAutomaticControl
        '
        Me.pnlAutomaticControl.Controls.Add(Me.Panel63)
        Me.pnlAutomaticControl.Controls.Add(Me.Panel6)
        Me.pnlAutomaticControl.Controls.Add(Me.Panel5)
        Me.pnlAutomaticControl.Controls.Add(Me.Panel4)
        Me.pnlAutomaticControl.Controls.Add(Me.Panel3)
        Me.pnlAutomaticControl.Controls.Add(Me.Panel2)
        Me.pnlAutomaticControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlAutomaticControl.Location = New System.Drawing.Point(0, 94)
        Me.pnlAutomaticControl.Name = "pnlAutomaticControl"
        Me.pnlAutomaticControl.Size = New System.Drawing.Size(791, 606)
        Me.pnlAutomaticControl.TabIndex = 2
        '
        'Panel63
        '
        Me.Panel63.Controls.Add(Me.swtSiloGate8)
        Me.Panel63.Controls.Add(Me.swtSiloGate7)
        Me.Panel63.Controls.Add(Me.Label119)
        Me.Panel63.Controls.Add(Me.Label120)
        Me.Panel63.Controls.Add(Me.swtSiloGate5)
        Me.Panel63.Controls.Add(Me.swtSiloGate4)
        Me.Panel63.Controls.Add(Me.Label113)
        Me.Panel63.Controls.Add(Me.Label114)
        Me.Panel63.Controls.Add(Me.swtSiloGate2)
        Me.Panel63.Controls.Add(Me.Label116)
        Me.Panel63.Controls.Add(Me.swtSiloGate1)
        Me.Panel63.Controls.Add(Me.Label117)
        Me.Panel63.Controls.Add(Me.Label118)
        Me.Panel63.Location = New System.Drawing.Point(31, 199)
        Me.Panel63.Name = "Panel63"
        Me.Panel63.Size = New System.Drawing.Size(732, 114)
        Me.Panel63.TabIndex = 13
        '
        'swtSiloGate8
        '
        Me.swtSiloGate8.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.swtSiloGate8.BorderRadius = 0
        Me.swtSiloGate8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.swtSiloGate8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.swtSiloGate8.Location = New System.Drawing.Point(665, 78)
        Me.swtSiloGate8.Name = "swtSiloGate8"
        Me.swtSiloGate8.Oncolor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.swtSiloGate8.Onoffcolor = System.Drawing.Color.SeaGreen
        Me.swtSiloGate8.Size = New System.Drawing.Size(51, 19)
        Me.swtSiloGate8.TabIndex = 19
        Me.swtSiloGate8.Textcolor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.swtSiloGate8.Value = True
        '
        'swtSiloGate7
        '
        Me.swtSiloGate7.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.swtSiloGate7.BorderRadius = 0
        Me.swtSiloGate7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.swtSiloGate7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.swtSiloGate7.Location = New System.Drawing.Point(665, 43)
        Me.swtSiloGate7.Name = "swtSiloGate7"
        Me.swtSiloGate7.Oncolor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.swtSiloGate7.Onoffcolor = System.Drawing.Color.SeaGreen
        Me.swtSiloGate7.Size = New System.Drawing.Size(51, 19)
        Me.swtSiloGate7.TabIndex = 18
        Me.swtSiloGate7.Textcolor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.swtSiloGate7.Value = True
        '
        'Label119
        '
        Me.Label119.AutoSize = True
        Me.Label119.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.Label119.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label119.Location = New System.Drawing.Point(522, 75)
        Me.Label119.Name = "Label119"
        Me.Label119.Size = New System.Drawing.Size(56, 25)
        Me.Label119.TabIndex = 17
        Me.Label119.Text = "Silo 8"
        '
        'Label120
        '
        Me.Label120.AutoSize = True
        Me.Label120.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.Label120.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label120.Location = New System.Drawing.Point(522, 40)
        Me.Label120.Name = "Label120"
        Me.Label120.Size = New System.Drawing.Size(57, 25)
        Me.Label120.TabIndex = 16
        Me.Label120.Text = "SIlo 7"
        '
        'swtSiloGate5
        '
        Me.swtSiloGate5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.swtSiloGate5.BorderRadius = 0
        Me.swtSiloGate5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.swtSiloGate5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.swtSiloGate5.Location = New System.Drawing.Point(415, 77)
        Me.swtSiloGate5.Name = "swtSiloGate5"
        Me.swtSiloGate5.Oncolor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.swtSiloGate5.Onoffcolor = System.Drawing.Color.SeaGreen
        Me.swtSiloGate5.Size = New System.Drawing.Size(51, 19)
        Me.swtSiloGate5.TabIndex = 14
        Me.swtSiloGate5.Textcolor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.swtSiloGate5.Value = True
        '
        'swtSiloGate4
        '
        Me.swtSiloGate4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.swtSiloGate4.BorderRadius = 0
        Me.swtSiloGate4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.swtSiloGate4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.swtSiloGate4.Location = New System.Drawing.Point(415, 42)
        Me.swtSiloGate4.Name = "swtSiloGate4"
        Me.swtSiloGate4.Oncolor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.swtSiloGate4.Onoffcolor = System.Drawing.Color.SeaGreen
        Me.swtSiloGate4.Size = New System.Drawing.Size(51, 19)
        Me.swtSiloGate4.TabIndex = 12
        Me.swtSiloGate4.Textcolor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.swtSiloGate4.Value = True
        '
        'Label113
        '
        Me.Label113.AutoSize = True
        Me.Label113.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.Label113.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label113.Location = New System.Drawing.Point(272, 74)
        Me.Label113.Name = "Label113"
        Me.Label113.Size = New System.Drawing.Size(56, 25)
        Me.Label113.TabIndex = 11
        Me.Label113.Text = "Silo 5"
        '
        'Label114
        '
        Me.Label114.AutoSize = True
        Me.Label114.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.Label114.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label114.Location = New System.Drawing.Point(272, 39)
        Me.Label114.Name = "Label114"
        Me.Label114.Size = New System.Drawing.Size(56, 25)
        Me.Label114.TabIndex = 10
        Me.Label114.Text = "Silo 4"
        '
        'swtSiloGate2
        '
        Me.swtSiloGate2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.swtSiloGate2.BorderRadius = 0
        Me.swtSiloGate2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.swtSiloGate2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.swtSiloGate2.Location = New System.Drawing.Point(146, 74)
        Me.swtSiloGate2.Name = "swtSiloGate2"
        Me.swtSiloGate2.Oncolor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.swtSiloGate2.Onoffcolor = System.Drawing.Color.SeaGreen
        Me.swtSiloGate2.Size = New System.Drawing.Size(51, 19)
        Me.swtSiloGate2.TabIndex = 8
        Me.swtSiloGate2.Textcolor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.swtSiloGate2.Value = True
        '
        'Label116
        '
        Me.Label116.AutoSize = True
        Me.Label116.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label116.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label116.Location = New System.Drawing.Point(3, 5)
        Me.Label116.Name = "Label116"
        Me.Label116.Size = New System.Drawing.Size(146, 28)
        Me.Label116.TabIndex = 6
        Me.Label116.Text = "Silo Top Gates"
        '
        'swtSiloGate1
        '
        Me.swtSiloGate1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.swtSiloGate1.BorderRadius = 0
        Me.swtSiloGate1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.swtSiloGate1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.swtSiloGate1.Location = New System.Drawing.Point(146, 39)
        Me.swtSiloGate1.Name = "swtSiloGate1"
        Me.swtSiloGate1.Oncolor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.swtSiloGate1.Onoffcolor = System.Drawing.Color.SeaGreen
        Me.swtSiloGate1.Size = New System.Drawing.Size(51, 19)
        Me.swtSiloGate1.TabIndex = 5
        Me.swtSiloGate1.Textcolor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.swtSiloGate1.Value = True
        '
        'Label117
        '
        Me.Label117.AutoSize = True
        Me.Label117.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.Label117.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label117.Location = New System.Drawing.Point(3, 71)
        Me.Label117.Name = "Label117"
        Me.Label117.Size = New System.Drawing.Size(56, 25)
        Me.Label117.TabIndex = 4
        Me.Label117.Text = "Silo 2"
        '
        'Label118
        '
        Me.Label118.AutoSize = True
        Me.Label118.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.Label118.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label118.Location = New System.Drawing.Point(3, 36)
        Me.Label118.Name = "Label118"
        Me.Label118.Size = New System.Drawing.Size(56, 25)
        Me.Label118.TabIndex = 2
        Me.Label118.Text = "Silo 1"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.swtMixingPump)
        Me.Panel6.Controls.Add(Me.Label109)
        Me.Panel6.Controls.Add(Me.swtMixingElev)
        Me.Panel6.Controls.Add(Me.Label23)
        Me.Panel6.Controls.Add(Me.swtMixingBotGate)
        Me.Panel6.Controls.Add(Me.swtMixer)
        Me.Panel6.Controls.Add(Me.Label19)
        Me.Panel6.Controls.Add(Me.Label20)
        Me.Panel6.Controls.Add(Me.swtMixingTopGate)
        Me.Panel6.Controls.Add(Me.Label21)
        Me.Panel6.Controls.Add(Me.Label22)
        Me.Panel6.Location = New System.Drawing.Point(294, 336)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(469, 144)
        Me.Panel6.TabIndex = 12
        '
        'swtMixingPump
        '
        Me.swtMixingPump.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.swtMixingPump.BorderRadius = 0
        Me.swtMixingPump.Cursor = System.Windows.Forms.Cursors.Hand
        Me.swtMixingPump.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.swtMixingPump.Location = New System.Drawing.Point(405, 74)
        Me.swtMixingPump.Name = "swtMixingPump"
        Me.swtMixingPump.Oncolor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.swtMixingPump.Onoffcolor = System.Drawing.Color.SeaGreen
        Me.swtMixingPump.Size = New System.Drawing.Size(51, 19)
        Me.swtMixingPump.TabIndex = 17
        Me.swtMixingPump.Textcolor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.swtMixingPump.Value = True
        '
        'Label109
        '
        Me.Label109.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label109.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.Label109.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label109.Location = New System.Drawing.Point(264, 68)
        Me.Label109.Name = "Label109"
        Me.Label109.Size = New System.Drawing.Size(107, 50)
        Me.Label109.TabIndex = 16
        Me.Label109.Text = "Molasses / Cocooil"
        '
        'swtMixingElev
        '
        Me.swtMixingElev.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.swtMixingElev.BorderRadius = 0
        Me.swtMixingElev.Cursor = System.Windows.Forms.Cursors.Hand
        Me.swtMixingElev.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.swtMixingElev.Location = New System.Drawing.Point(405, 42)
        Me.swtMixingElev.Name = "swtMixingElev"
        Me.swtMixingElev.Oncolor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.swtMixingElev.Onoffcolor = System.Drawing.Color.SeaGreen
        Me.swtMixingElev.Size = New System.Drawing.Size(51, 19)
        Me.swtMixingElev.TabIndex = 15
        Me.swtMixingElev.Textcolor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.swtMixingElev.Value = True
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label23.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.Label23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label23.Location = New System.Drawing.Point(262, 39)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(75, 25)
        Me.Label23.TabIndex = 13
        Me.Label23.Text = "Elevator"
        '
        'swtMixingBotGate
        '
        Me.swtMixingBotGate.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.swtMixingBotGate.BorderRadius = 0
        Me.swtMixingBotGate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.swtMixingBotGate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.swtMixingBotGate.Location = New System.Drawing.Point(146, 109)
        Me.swtMixingBotGate.Name = "swtMixingBotGate"
        Me.swtMixingBotGate.Oncolor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.swtMixingBotGate.Onoffcolor = System.Drawing.Color.SeaGreen
        Me.swtMixingBotGate.Size = New System.Drawing.Size(51, 19)
        Me.swtMixingBotGate.TabIndex = 9
        Me.swtMixingBotGate.Textcolor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.swtMixingBotGate.Value = True
        '
        'swtMixer
        '
        Me.swtMixer.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.swtMixer.BorderRadius = 0
        Me.swtMixer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.swtMixer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.swtMixer.Location = New System.Drawing.Point(146, 74)
        Me.swtMixer.Name = "swtMixer"
        Me.swtMixer.Oncolor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.swtMixer.Onoffcolor = System.Drawing.Color.SeaGreen
        Me.swtMixer.Size = New System.Drawing.Size(51, 19)
        Me.swtMixer.TabIndex = 8
        Me.swtMixer.Textcolor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.swtMixer.Value = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(3, 106)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(113, 25)
        Me.Label19.TabIndex = 7
        Me.Label19.Text = "Bottom Gate"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(3, 5)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(123, 28)
        Me.Label20.TabIndex = 6
        Me.Label20.Text = "Mixing Line"
        '
        'swtMixingTopGate
        '
        Me.swtMixingTopGate.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.swtMixingTopGate.BorderRadius = 0
        Me.swtMixingTopGate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.swtMixingTopGate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.swtMixingTopGate.Location = New System.Drawing.Point(146, 39)
        Me.swtMixingTopGate.Name = "swtMixingTopGate"
        Me.swtMixingTopGate.Oncolor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.swtMixingTopGate.Onoffcolor = System.Drawing.Color.SeaGreen
        Me.swtMixingTopGate.Size = New System.Drawing.Size(51, 19)
        Me.swtMixingTopGate.TabIndex = 5
        Me.swtMixingTopGate.Textcolor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.swtMixingTopGate.Value = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(3, 71)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(55, 25)
        Me.Label21.TabIndex = 4
        Me.Label21.Text = "Mixer"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.Label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label22.Location = New System.Drawing.Point(3, 36)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(82, 25)
        Me.Label22.TabIndex = 2
        Me.Label22.Text = "Top Gate"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.swtBatchElev)
        Me.Panel5.Controls.Add(Me.Label15)
        Me.Panel5.Controls.Add(Me.swtBatchGate)
        Me.Panel5.Controls.Add(Me.Label16)
        Me.Panel5.Controls.Add(Me.Label17)
        Me.Panel5.Controls.Add(Me.Label18)
        Me.Panel5.Location = New System.Drawing.Point(31, 336)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(200, 144)
        Me.Panel5.TabIndex = 11
        '
        'swtBatchElev
        '
        Me.swtBatchElev.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.swtBatchElev.BorderRadius = 0
        Me.swtBatchElev.Cursor = System.Windows.Forms.Cursors.Hand
        Me.swtBatchElev.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.swtBatchElev.Location = New System.Drawing.Point(146, 108)
        Me.swtBatchElev.Name = "swtBatchElev"
        Me.swtBatchElev.Oncolor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.swtBatchElev.Onoffcolor = System.Drawing.Color.SeaGreen
        Me.swtBatchElev.Size = New System.Drawing.Size(51, 19)
        Me.swtBatchElev.TabIndex = 10
        Me.swtBatchElev.Textcolor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.swtBatchElev.Value = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(3, 105)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(75, 25)
        Me.Label15.TabIndex = 9
        Me.Label15.Text = "Elevator"
        '
        'swtBatchGate
        '
        Me.swtBatchGate.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.swtBatchGate.BorderRadius = 0
        Me.swtBatchGate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.swtBatchGate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.swtBatchGate.Location = New System.Drawing.Point(146, 74)
        Me.swtBatchGate.Name = "swtBatchGate"
        Me.swtBatchGate.Oncolor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.swtBatchGate.Onoffcolor = System.Drawing.Color.SeaGreen
        Me.swtBatchGate.Size = New System.Drawing.Size(51, 19)
        Me.swtBatchGate.TabIndex = 8
        Me.swtBatchGate.Textcolor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.swtBatchGate.Value = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(3, 5)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(141, 28)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "Batching Line"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(3, 71)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(48, 25)
        Me.Label17.TabIndex = 4
        Me.Label17.Text = "Gate"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(3, 36)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(80, 25)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "Batching"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.swtElev3)
        Me.Panel4.Controls.Add(Me.swtElev2)
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Controls.Add(Me.Label12)
        Me.Panel4.Controls.Add(Me.swtElev1)
        Me.Panel4.Controls.Add(Me.Label13)
        Me.Panel4.Controls.Add(Me.Label14)
        Me.Panel4.Location = New System.Drawing.Point(31, 36)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(200, 144)
        Me.Panel4.TabIndex = 10
        '
        'swtElev3
        '
        Me.swtElev3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.swtElev3.BorderRadius = 0
        Me.swtElev3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.swtElev3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.swtElev3.Location = New System.Drawing.Point(146, 109)
        Me.swtElev3.Name = "swtElev3"
        Me.swtElev3.Oncolor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.swtElev3.Onoffcolor = System.Drawing.Color.SeaGreen
        Me.swtElev3.Size = New System.Drawing.Size(51, 19)
        Me.swtElev3.TabIndex = 9
        Me.swtElev3.Textcolor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.swtElev3.Value = True
        '
        'swtElev2
        '
        Me.swtElev2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.swtElev2.BorderRadius = 0
        Me.swtElev2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.swtElev2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.swtElev2.Location = New System.Drawing.Point(146, 74)
        Me.swtElev2.Name = "swtElev2"
        Me.swtElev2.Oncolor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.swtElev2.Onoffcolor = System.Drawing.Color.SeaGreen
        Me.swtElev2.Size = New System.Drawing.Size(51, 19)
        Me.swtElev2.TabIndex = 8
        Me.swtElev2.Textcolor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.swtElev2.Value = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(3, 106)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 25)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Elevator 3"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(3, 5)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(107, 28)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Input Line"
        '
        'swtElev1
        '
        Me.swtElev1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.swtElev1.BorderRadius = 0
        Me.swtElev1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.swtElev1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.swtElev1.Location = New System.Drawing.Point(146, 39)
        Me.swtElev1.Name = "swtElev1"
        Me.swtElev1.Oncolor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.swtElev1.Onoffcolor = System.Drawing.Color.SeaGreen
        Me.swtElev1.Size = New System.Drawing.Size(51, 19)
        Me.swtElev1.TabIndex = 5
        Me.swtElev1.Textcolor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.swtElev1.Value = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(3, 71)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(90, 25)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Elevator 2"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(3, 36)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(90, 25)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Elevator 1"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.swtHamMillElev2)
        Me.Panel3.Controls.Add(Me.swtHamMill2)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.swtHamMillFeed2)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Location = New System.Drawing.Point(563, 36)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(200, 144)
        Me.Panel3.TabIndex = 10
        '
        'swtHamMillElev2
        '
        Me.swtHamMillElev2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.swtHamMillElev2.BorderRadius = 0
        Me.swtHamMillElev2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.swtHamMillElev2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.swtHamMillElev2.Location = New System.Drawing.Point(146, 109)
        Me.swtHamMillElev2.Name = "swtHamMillElev2"
        Me.swtHamMillElev2.Oncolor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.swtHamMillElev2.Onoffcolor = System.Drawing.Color.SeaGreen
        Me.swtHamMillElev2.Size = New System.Drawing.Size(51, 19)
        Me.swtHamMillElev2.TabIndex = 9
        Me.swtHamMillElev2.Textcolor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.swtHamMillElev2.Value = True
        '
        'swtHamMill2
        '
        Me.swtHamMill2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.swtHamMill2.BorderRadius = 0
        Me.swtHamMill2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.swtHamMill2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.swtHamMill2.Location = New System.Drawing.Point(146, 74)
        Me.swtHamMill2.Name = "swtHamMill2"
        Me.swtHamMill2.Oncolor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.swtHamMill2.Onoffcolor = System.Drawing.Color.SeaGreen
        Me.swtHamMill2.Size = New System.Drawing.Size(51, 19)
        Me.swtHamMill2.TabIndex = 8
        Me.swtHamMill2.Textcolor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.swtHamMill2.Value = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(3, 106)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 25)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Elevator"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(3, 5)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(154, 28)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Hammer Mill 2"
        '
        'swtHamMillFeed2
        '
        Me.swtHamMillFeed2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.swtHamMillFeed2.BorderRadius = 0
        Me.swtHamMillFeed2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.swtHamMillFeed2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.swtHamMillFeed2.Location = New System.Drawing.Point(146, 39)
        Me.swtHamMillFeed2.Name = "swtHamMillFeed2"
        Me.swtHamMillFeed2.Oncolor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.swtHamMillFeed2.Onoffcolor = System.Drawing.Color.SeaGreen
        Me.swtHamMillFeed2.Size = New System.Drawing.Size(51, 19)
        Me.swtHamMillFeed2.TabIndex = 5
        Me.swtHamMillFeed2.Textcolor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.swtHamMillFeed2.Value = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(3, 71)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(114, 25)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Hammer Mill"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(3, 36)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 25)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Feeder"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.swtHamMillElev1)
        Me.Panel2.Controls.Add(Me.swtHamMill1)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.swtHamMillFeed1)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(297, 36)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 144)
        Me.Panel2.TabIndex = 7
        '
        'swtHamMillElev1
        '
        Me.swtHamMillElev1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.swtHamMillElev1.BorderRadius = 0
        Me.swtHamMillElev1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.swtHamMillElev1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.swtHamMillElev1.Location = New System.Drawing.Point(146, 109)
        Me.swtHamMillElev1.Name = "swtHamMillElev1"
        Me.swtHamMillElev1.Oncolor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.swtHamMillElev1.Onoffcolor = System.Drawing.Color.SeaGreen
        Me.swtHamMillElev1.Size = New System.Drawing.Size(51, 19)
        Me.swtHamMillElev1.TabIndex = 9
        Me.swtHamMillElev1.Textcolor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.swtHamMillElev1.Value = True
        '
        'swtHamMill1
        '
        Me.swtHamMill1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.swtHamMill1.BorderRadius = 0
        Me.swtHamMill1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.swtHamMill1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.swtHamMill1.Location = New System.Drawing.Point(146, 74)
        Me.swtHamMill1.Name = "swtHamMill1"
        Me.swtHamMill1.Oncolor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.swtHamMill1.Onoffcolor = System.Drawing.Color.SeaGreen
        Me.swtHamMill1.Size = New System.Drawing.Size(51, 19)
        Me.swtHamMill1.TabIndex = 8
        Me.swtHamMill1.Textcolor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.swtHamMill1.Value = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(3, 106)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 25)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Elevator"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(3, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(154, 28)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Hammer Mill 1"
        '
        'swtHamMillFeed1
        '
        Me.swtHamMillFeed1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.swtHamMillFeed1.BorderRadius = 0
        Me.swtHamMillFeed1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.swtHamMillFeed1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.swtHamMillFeed1.Location = New System.Drawing.Point(146, 39)
        Me.swtHamMillFeed1.Name = "swtHamMillFeed1"
        Me.swtHamMillFeed1.Oncolor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.swtHamMillFeed1.Onoffcolor = System.Drawing.Color.SeaGreen
        Me.swtHamMillFeed1.Size = New System.Drawing.Size(51, 19)
        Me.swtHamMillFeed1.TabIndex = 5
        Me.swtHamMillFeed1.Textcolor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.swtHamMillFeed1.Value = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(3, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 25)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Hammer Mill"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(3, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Feeder"
        '
        'pnlSettings
        '
        Me.pnlSettings.Controls.Add(Me.cmbardComport)
        Me.pnlSettings.Controls.Add(Me.Label112)
        Me.pnlSettings.Controls.Add(Me.btnCalibrate)
        Me.pnlSettings.Controls.Add(Me.txtbSettingsScreenPosition)
        Me.pnlSettings.Controls.Add(Me.Label24)
        Me.pnlSettings.Controls.Add(Me.Label25)
        Me.pnlSettings.Controls.Add(Me.BunifuFlatButton1)
        Me.pnlSettings.Controls.Add(Me.btnSettingsSave)
        Me.pnlSettings.Controls.Add(Me.txtbSettingsLiquidAdjust)
        Me.pnlSettings.Controls.Add(Me.txtbSettingsBatchAdjust)
        Me.pnlSettings.Controls.Add(Me.Label105)
        Me.pnlSettings.Controls.Add(Me.Label106)
        Me.pnlSettings.Controls.Add(Me.Label104)
        Me.pnlSettings.Controls.Add(Me.cmbLiquicComPort)
        Me.pnlSettings.Controls.Add(Me.cmbScaleComPort)
        Me.pnlSettings.Controls.Add(Me.cmbPLCComPort)
        Me.pnlSettings.Controls.Add(Me.Label103)
        Me.pnlSettings.Controls.Add(Me.Label102)
        Me.pnlSettings.Controls.Add(Me.Label99)
        Me.pnlSettings.Controls.Add(Me.Label90)
        Me.pnlSettings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlSettings.Location = New System.Drawing.Point(0, 94)
        Me.pnlSettings.Name = "pnlSettings"
        Me.pnlSettings.Size = New System.Drawing.Size(791, 606)
        Me.pnlSettings.TabIndex = 18
        '
        'cmbardComport
        '
        Me.cmbardComport.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Automated_Feedmill_System.My.MySettings.Default, "ardComPort", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cmbardComport.FormattingEnabled = True
        Me.cmbardComport.Location = New System.Drawing.Point(180, 96)
        Me.cmbardComport.Name = "cmbardComport"
        Me.cmbardComport.Size = New System.Drawing.Size(121, 21)
        Me.cmbardComport.TabIndex = 46
        Me.cmbardComport.Text = Global.Automated_Feedmill_System.My.MySettings.Default.ardComPort
        '
        'Label112
        '
        Me.Label112.AutoSize = True
        Me.Label112.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label112.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!)
        Me.Label112.ForeColor = System.Drawing.Color.Black
        Me.Label112.Location = New System.Drawing.Point(32, 93)
        Me.Label112.Name = "Label112"
        Me.Label112.Size = New System.Drawing.Size(136, 21)
        Me.Label112.TabIndex = 44
        Me.Label112.Text = "Arduino Com Port:"
        '
        'btnCalibrate
        '
        Me.btnCalibrate.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnCalibrate.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btnCalibrate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCalibrate.BorderRadius = 0
        Me.btnCalibrate.ButtonText = "Calibrate"
        Me.btnCalibrate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCalibrate.DisabledColor = System.Drawing.Color.Gray
        Me.btnCalibrate.Iconcolor = System.Drawing.Color.Transparent
        Me.btnCalibrate.Iconimage = Global.Automated_Feedmill_System.My.Resources.Resources.Industrial_Scales_Connected_96px
        Me.btnCalibrate.Iconimage_right = Nothing
        Me.btnCalibrate.Iconimage_right_Selected = Nothing
        Me.btnCalibrate.Iconimage_Selected = Nothing
        Me.btnCalibrate.IconMarginLeft = 0
        Me.btnCalibrate.IconMarginRight = 0
        Me.btnCalibrate.IconRightVisible = True
        Me.btnCalibrate.IconRightZoom = 0R
        Me.btnCalibrate.IconVisible = True
        Me.btnCalibrate.IconZoom = 50.0R
        Me.btnCalibrate.IsTab = False
        Me.btnCalibrate.Location = New System.Drawing.Point(270, 226)
        Me.btnCalibrate.Name = "btnCalibrate"
        Me.btnCalibrate.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btnCalibrate.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnCalibrate.OnHoverTextColor = System.Drawing.Color.White
        Me.btnCalibrate.selected = False
        Me.btnCalibrate.Size = New System.Drawing.Size(120, 48)
        Me.btnCalibrate.TabIndex = 43
        Me.btnCalibrate.Text = "Calibrate"
        Me.btnCalibrate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnCalibrate.Textcolor = System.Drawing.Color.White
        Me.btnCalibrate.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtbSettingsScreenPosition
        '
        Me.txtbSettingsScreenPosition.Location = New System.Drawing.Point(561, 79)
        Me.txtbSettingsScreenPosition.Name = "txtbSettingsScreenPosition"
        Me.txtbSettingsScreenPosition.Size = New System.Drawing.Size(100, 20)
        Me.txtbSettingsScreenPosition.TabIndex = 42
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label24.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!)
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(438, 78)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(118, 21)
        Me.Label24.TabIndex = 40
        Me.Label24.Text = "Screen Position:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label25.Font = New System.Drawing.Font("Segoe UI Semilight", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(438, 42)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(227, 28)
        Me.Label25.TabIndex = 39
        Me.Label25.Text = "Overview Screen Position:"
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 0
        Me.BunifuFlatButton1.ButtonText = "Cancel"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = Global.Automated_Feedmill_System.My.Resources.Resources.Trash_Can_96px
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 0
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = True
        Me.BunifuFlatButton1.IconRightZoom = 0R
        Me.BunifuFlatButton1.IconVisible = True
        Me.BunifuFlatButton1.IconZoom = 50.0R
        Me.BunifuFlatButton1.IsTab = False
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(172, 483)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(120, 48)
        Me.BunifuFlatButton1.TabIndex = 38
        Me.BunifuFlatButton1.Text = "Cancel"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.btnSettingsSave.Location = New System.Drawing.Point(37, 483)
        Me.btnSettingsSave.Name = "btnSettingsSave"
        Me.btnSettingsSave.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btnSettingsSave.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnSettingsSave.OnHoverTextColor = System.Drawing.Color.White
        Me.btnSettingsSave.selected = False
        Me.btnSettingsSave.Size = New System.Drawing.Size(120, 48)
        Me.btnSettingsSave.TabIndex = 37
        Me.btnSettingsSave.Text = "Save"
        Me.btnSettingsSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnSettingsSave.Textcolor = System.Drawing.Color.White
        Me.btnSettingsSave.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtbSettingsLiquidAdjust
        '
        Me.txtbSettingsLiquidAdjust.Location = New System.Drawing.Point(128, 256)
        Me.txtbSettingsLiquidAdjust.Name = "txtbSettingsLiquidAdjust"
        Me.txtbSettingsLiquidAdjust.Size = New System.Drawing.Size(100, 20)
        Me.txtbSettingsLiquidAdjust.TabIndex = 31
        '
        'txtbSettingsBatchAdjust
        '
        Me.txtbSettingsBatchAdjust.Location = New System.Drawing.Point(148, 227)
        Me.txtbSettingsBatchAdjust.Name = "txtbSettingsBatchAdjust"
        Me.txtbSettingsBatchAdjust.Size = New System.Drawing.Size(100, 20)
        Me.txtbSettingsBatchAdjust.TabIndex = 30
        '
        'Label105
        '
        Me.Label105.AutoSize = True
        Me.Label105.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label105.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!)
        Me.Label105.ForeColor = System.Drawing.Color.Black
        Me.Label105.Location = New System.Drawing.Point(35, 255)
        Me.Label105.Name = "Label105"
        Me.Label105.Size = New System.Drawing.Size(95, 21)
        Me.Label105.TabIndex = 29
        Me.Label105.Text = "Liquid Scale:"
        '
        'Label106
        '
        Me.Label106.AutoSize = True
        Me.Label106.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label106.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!)
        Me.Label106.ForeColor = System.Drawing.Color.Black
        Me.Label106.Location = New System.Drawing.Point(35, 226)
        Me.Label106.Name = "Label106"
        Me.Label106.Size = New System.Drawing.Size(113, 21)
        Me.Label106.TabIndex = 28
        Me.Label106.Text = "Batching Scale:"
        '
        'Label104
        '
        Me.Label104.AutoSize = True
        Me.Label104.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label104.Font = New System.Drawing.Font("Segoe UI Semilight", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label104.ForeColor = System.Drawing.Color.Black
        Me.Label104.Location = New System.Drawing.Point(32, 186)
        Me.Label104.Name = "Label104"
        Me.Label104.Size = New System.Drawing.Size(184, 28)
        Me.Label104.TabIndex = 27
        Me.Label104.Text = "Batching Calibration:"
        '
        'cmbLiquicComPort
        '
        Me.cmbLiquicComPort.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Automated_Feedmill_System.My.MySettings.Default, "liquidScaleComport", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cmbLiquicComPort.FormattingEnabled = True
        Me.cmbLiquicComPort.Location = New System.Drawing.Point(197, 148)
        Me.cmbLiquicComPort.Name = "cmbLiquicComPort"
        Me.cmbLiquicComPort.Size = New System.Drawing.Size(121, 21)
        Me.cmbLiquicComPort.TabIndex = 26
        Me.cmbLiquicComPort.Text = Global.Automated_Feedmill_System.My.MySettings.Default.liquidScaleComport
        '
        'cmbScaleComPort
        '
        Me.cmbScaleComPort.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Automated_Feedmill_System.My.MySettings.Default, "batchScaleComport", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cmbScaleComPort.FormattingEnabled = True
        Me.cmbScaleComPort.Location = New System.Drawing.Point(215, 121)
        Me.cmbScaleComPort.Name = "cmbScaleComPort"
        Me.cmbScaleComPort.Size = New System.Drawing.Size(121, 21)
        Me.cmbScaleComPort.TabIndex = 25
        Me.cmbScaleComPort.Text = Global.Automated_Feedmill_System.My.MySettings.Default.batchScaleComport
        '
        'cmbPLCComPort
        '
        Me.cmbPLCComPort.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Automated_Feedmill_System.My.MySettings.Default, "plcComport", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cmbPLCComPort.FormattingEnabled = True
        Me.cmbPLCComPort.Location = New System.Drawing.Point(148, 67)
        Me.cmbPLCComPort.Name = "cmbPLCComPort"
        Me.cmbPLCComPort.Size = New System.Drawing.Size(121, 21)
        Me.cmbPLCComPort.TabIndex = 24
        Me.cmbPLCComPort.Text = Global.Automated_Feedmill_System.My.MySettings.Default.plcComport
        '
        'Label103
        '
        Me.Label103.AutoSize = True
        Me.Label103.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label103.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!)
        Me.Label103.ForeColor = System.Drawing.Color.Black
        Me.Label103.Location = New System.Drawing.Point(32, 148)
        Me.Label103.Name = "Label103"
        Me.Label103.Size = New System.Drawing.Size(162, 21)
        Me.Label103.TabIndex = 23
        Me.Label103.Text = "Liquid Scale Com Port:"
        '
        'Label102
        '
        Me.Label102.AutoSize = True
        Me.Label102.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label102.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!)
        Me.Label102.ForeColor = System.Drawing.Color.Black
        Me.Label102.Location = New System.Drawing.Point(32, 119)
        Me.Label102.Name = "Label102"
        Me.Label102.Size = New System.Drawing.Size(180, 21)
        Me.Label102.TabIndex = 22
        Me.Label102.Text = "Batching Scale Com Port:"
        '
        'Label99
        '
        Me.Label99.AutoSize = True
        Me.Label99.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label99.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!)
        Me.Label99.ForeColor = System.Drawing.Color.Black
        Me.Label99.Location = New System.Drawing.Point(32, 67)
        Me.Label99.Name = "Label99"
        Me.Label99.Size = New System.Drawing.Size(106, 21)
        Me.Label99.TabIndex = 21
        Me.Label99.Text = "PLC Com Port:"
        '
        'Label90
        '
        Me.Label90.AutoSize = True
        Me.Label90.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label90.Font = New System.Drawing.Font("Segoe UI Semilight", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label90.ForeColor = System.Drawing.Color.Black
        Me.Label90.Location = New System.Drawing.Point(32, 31)
        Me.Label90.Name = "Label90"
        Me.Label90.Size = New System.Drawing.Size(183, 28)
        Me.Label90.TabIndex = 20
        Me.Label90.Text = "Connection Settings:"
        '
        'pnlFormula
        '
        Me.pnlFormula.Controls.Add(Me.Label107)
        Me.pnlFormula.Controls.Add(Me.Label96)
        Me.pnlFormula.Controls.Add(Me.txtbFormCoco)
        Me.pnlFormula.Controls.Add(Me.Label93)
        Me.pnlFormula.Controls.Add(Me.txtbFormMolasses)
        Me.pnlFormula.Controls.Add(Me.Label81)
        Me.pnlFormula.Controls.Add(Me.lblFormulaId)
        Me.pnlFormula.Controls.Add(Me.btnDeleteFormula)
        Me.pnlFormula.Controls.Add(Me.btnUpdateFormula)
        Me.pnlFormula.Controls.Add(Me.btnAddFormula)
        Me.pnlFormula.Controls.Add(Me.dgvFormula)
        Me.pnlFormula.Controls.Add(Me.cmbFormSiloSet)
        Me.pnlFormula.Controls.Add(Me.Label72)
        Me.pnlFormula.Controls.Add(Me.txtbFormulaName)
        Me.pnlFormula.Controls.Add(Me.Label71)
        Me.pnlFormula.Controls.Add(Me.Panel25)
        Me.pnlFormula.Controls.Add(Me.Panel27)
        Me.pnlFormula.Controls.Add(Me.Panel29)
        Me.pnlFormula.Controls.Add(Me.Panel31)
        Me.pnlFormula.Controls.Add(Me.Panel33)
        Me.pnlFormula.Controls.Add(Me.Panel35)
        Me.pnlFormula.Controls.Add(Me.Panel37)
        Me.pnlFormula.Controls.Add(Me.Panel39)
        Me.pnlFormula.Controls.Add(Me.Panel41)
        Me.pnlFormula.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlFormula.Location = New System.Drawing.Point(0, 94)
        Me.pnlFormula.Name = "pnlFormula"
        Me.pnlFormula.Size = New System.Drawing.Size(791, 606)
        Me.pnlFormula.TabIndex = 13
        '
        'Label107
        '
        Me.Label107.BackColor = System.Drawing.Color.Transparent
        Me.Label107.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.Label107.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label107.Location = New System.Drawing.Point(421, 524)
        Me.Label107.Name = "Label107"
        Me.Label107.Size = New System.Drawing.Size(36, 25)
        Me.Label107.TabIndex = 43
        Me.Label107.Text = "KG"
        Me.Label107.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label96
        '
        Me.Label96.BackColor = System.Drawing.Color.Transparent
        Me.Label96.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.Label96.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label96.Location = New System.Drawing.Point(167, 524)
        Me.Label96.Name = "Label96"
        Me.Label96.Size = New System.Drawing.Size(36, 25)
        Me.Label96.TabIndex = 42
        Me.Label96.Text = "KG"
        Me.Label96.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtbFormCoco
        '
        Me.txtbFormCoco.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbFormCoco.Location = New System.Drawing.Point(361, 523)
        Me.txtbFormCoco.Name = "txtbFormCoco"
        Me.txtbFormCoco.Size = New System.Drawing.Size(54, 27)
        Me.txtbFormCoco.TabIndex = 41
        '
        'Label93
        '
        Me.Label93.AutoSize = True
        Me.Label93.BackColor = System.Drawing.Color.Transparent
        Me.Label93.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label93.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label93.Location = New System.Drawing.Point(273, 525)
        Me.Label93.Name = "Label93"
        Me.Label93.Size = New System.Drawing.Size(84, 23)
        Me.Label93.TabIndex = 40
        Me.Label93.Text = "Coco Oil :"
        '
        'txtbFormMolasses
        '
        Me.txtbFormMolasses.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbFormMolasses.Location = New System.Drawing.Point(108, 523)
        Me.txtbFormMolasses.Name = "txtbFormMolasses"
        Me.txtbFormMolasses.Size = New System.Drawing.Size(54, 27)
        Me.txtbFormMolasses.TabIndex = 39
        '
        'Label81
        '
        Me.Label81.AutoSize = True
        Me.Label81.BackColor = System.Drawing.Color.Transparent
        Me.Label81.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label81.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label81.Location = New System.Drawing.Point(10, 525)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(92, 23)
        Me.Label81.TabIndex = 38
        Me.Label81.Text = "Mollasses :"
        '
        'lblFormulaId
        '
        Me.lblFormulaId.AutoSize = True
        Me.lblFormulaId.BackColor = System.Drawing.Color.Transparent
        Me.lblFormulaId.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblFormulaId.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.lblFormulaId.Location = New System.Drawing.Point(640, 42)
        Me.lblFormulaId.Name = "lblFormulaId"
        Me.lblFormulaId.Size = New System.Drawing.Size(17, 20)
        Me.lblFormulaId.TabIndex = 37
        Me.lblFormulaId.Text = "0"
        '
        'btnDeleteFormula
        '
        Me.btnDeleteFormula.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnDeleteFormula.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btnDeleteFormula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDeleteFormula.BorderRadius = 0
        Me.btnDeleteFormula.ButtonText = "Delete"
        Me.btnDeleteFormula.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeleteFormula.DisabledColor = System.Drawing.Color.Gray
        Me.btnDeleteFormula.Iconcolor = System.Drawing.Color.Transparent
        Me.btnDeleteFormula.Iconimage = Global.Automated_Feedmill_System.My.Resources.Resources.Trash_Can_96px
        Me.btnDeleteFormula.Iconimage_right = Nothing
        Me.btnDeleteFormula.Iconimage_right_Selected = Nothing
        Me.btnDeleteFormula.Iconimage_Selected = Nothing
        Me.btnDeleteFormula.IconMarginLeft = 0
        Me.btnDeleteFormula.IconMarginRight = 0
        Me.btnDeleteFormula.IconRightVisible = True
        Me.btnDeleteFormula.IconRightZoom = 0R
        Me.btnDeleteFormula.IconVisible = True
        Me.btnDeleteFormula.IconZoom = 50.0R
        Me.btnDeleteFormula.IsTab = False
        Me.btnDeleteFormula.Location = New System.Drawing.Point(519, 293)
        Me.btnDeleteFormula.Name = "btnDeleteFormula"
        Me.btnDeleteFormula.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btnDeleteFormula.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnDeleteFormula.OnHoverTextColor = System.Drawing.Color.White
        Me.btnDeleteFormula.selected = False
        Me.btnDeleteFormula.Size = New System.Drawing.Size(120, 48)
        Me.btnDeleteFormula.TabIndex = 36
        Me.btnDeleteFormula.Text = "Delete"
        Me.btnDeleteFormula.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnDeleteFormula.Textcolor = System.Drawing.Color.White
        Me.btnDeleteFormula.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnUpdateFormula
        '
        Me.btnUpdateFormula.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnUpdateFormula.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btnUpdateFormula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUpdateFormula.BorderRadius = 0
        Me.btnUpdateFormula.ButtonText = "Edit"
        Me.btnUpdateFormula.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdateFormula.DisabledColor = System.Drawing.Color.Gray
        Me.btnUpdateFormula.Iconcolor = System.Drawing.Color.Transparent
        Me.btnUpdateFormula.Iconimage = Global.Automated_Feedmill_System.My.Resources.Resources.Edit_96px
        Me.btnUpdateFormula.Iconimage_right = Nothing
        Me.btnUpdateFormula.Iconimage_right_Selected = Nothing
        Me.btnUpdateFormula.Iconimage_Selected = Nothing
        Me.btnUpdateFormula.IconMarginLeft = 0
        Me.btnUpdateFormula.IconMarginRight = 0
        Me.btnUpdateFormula.IconRightVisible = True
        Me.btnUpdateFormula.IconRightZoom = 0R
        Me.btnUpdateFormula.IconVisible = True
        Me.btnUpdateFormula.IconZoom = 50.0R
        Me.btnUpdateFormula.IsTab = False
        Me.btnUpdateFormula.Location = New System.Drawing.Point(519, 239)
        Me.btnUpdateFormula.Name = "btnUpdateFormula"
        Me.btnUpdateFormula.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btnUpdateFormula.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnUpdateFormula.OnHoverTextColor = System.Drawing.Color.White
        Me.btnUpdateFormula.selected = False
        Me.btnUpdateFormula.Size = New System.Drawing.Size(120, 48)
        Me.btnUpdateFormula.TabIndex = 35
        Me.btnUpdateFormula.Text = "Edit"
        Me.btnUpdateFormula.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnUpdateFormula.Textcolor = System.Drawing.Color.White
        Me.btnUpdateFormula.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnAddFormula
        '
        Me.btnAddFormula.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnAddFormula.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btnAddFormula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddFormula.BorderRadius = 0
        Me.btnAddFormula.ButtonText = "Add"
        Me.btnAddFormula.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddFormula.DisabledColor = System.Drawing.Color.Gray
        Me.btnAddFormula.Iconcolor = System.Drawing.Color.Transparent
        Me.btnAddFormula.Iconimage = Global.Automated_Feedmill_System.My.Resources.Resources.Save_96px
        Me.btnAddFormula.Iconimage_right = Nothing
        Me.btnAddFormula.Iconimage_right_Selected = Nothing
        Me.btnAddFormula.Iconimage_Selected = Nothing
        Me.btnAddFormula.IconMarginLeft = 0
        Me.btnAddFormula.IconMarginRight = 0
        Me.btnAddFormula.IconRightVisible = True
        Me.btnAddFormula.IconRightZoom = 0R
        Me.btnAddFormula.IconVisible = True
        Me.btnAddFormula.IconZoom = 50.0R
        Me.btnAddFormula.IsTab = False
        Me.btnAddFormula.Location = New System.Drawing.Point(519, 185)
        Me.btnAddFormula.Name = "btnAddFormula"
        Me.btnAddFormula.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btnAddFormula.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnAddFormula.OnHoverTextColor = System.Drawing.Color.White
        Me.btnAddFormula.selected = False
        Me.btnAddFormula.Size = New System.Drawing.Size(120, 48)
        Me.btnAddFormula.TabIndex = 34
        Me.btnAddFormula.Text = "Add"
        Me.btnAddFormula.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnAddFormula.Textcolor = System.Drawing.Color.White
        Me.btnAddFormula.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'dgvFormula
        '
        Me.dgvFormula.AllowUserToAddRows = False
        Me.dgvFormula.AllowUserToDeleteRows = False
        Me.dgvFormula.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvFormula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFormula.Location = New System.Drawing.Point(523, 367)
        Me.dgvFormula.Name = "dgvFormula"
        Me.dgvFormula.ReadOnly = True
        Me.dgvFormula.Size = New System.Drawing.Size(240, 150)
        Me.dgvFormula.TabIndex = 33
        '
        'cmbFormSiloSet
        '
        Me.cmbFormSiloSet.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.cmbFormSiloSet.FormattingEnabled = True
        Me.cmbFormSiloSet.Location = New System.Drawing.Point(519, 132)
        Me.cmbFormSiloSet.Name = "cmbFormSiloSet"
        Me.cmbFormSiloSet.Size = New System.Drawing.Size(200, 28)
        Me.cmbFormSiloSet.TabIndex = 32
        '
        'Label72
        '
        Me.Label72.AutoSize = True
        Me.Label72.BackColor = System.Drawing.Color.Transparent
        Me.Label72.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label72.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label72.Location = New System.Drawing.Point(519, 104)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(92, 20)
        Me.Label72.TabIndex = 31
        Me.Label72.Text = "Silo Settings"
        '
        'txtbFormulaName
        '
        Me.txtbFormulaName.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbFormulaName.Location = New System.Drawing.Point(519, 69)
        Me.txtbFormulaName.Name = "txtbFormulaName"
        Me.txtbFormulaName.Size = New System.Drawing.Size(200, 27)
        Me.txtbFormulaName.TabIndex = 30
        '
        'Label71
        '
        Me.Label71.AutoSize = True
        Me.Label71.BackColor = System.Drawing.Color.Transparent
        Me.Label71.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label71.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label71.Location = New System.Drawing.Point(519, 41)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(115, 20)
        Me.Label71.TabIndex = 29
        Me.Label71.Text = "Formula Name:"
        '
        'Panel25
        '
        Me.Panel25.BackColor = System.Drawing.Color.Transparent
        Me.Panel25.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel25.Controls.Add(Me.Label67)
        Me.Panel25.Controls.Add(Me.Panel26)
        Me.Panel25.Controls.Add(Me.txtbFormSilo9)
        Me.Panel25.Location = New System.Drawing.Point(340, 341)
        Me.Panel25.Name = "Panel25"
        Me.Panel25.Size = New System.Drawing.Size(157, 153)
        Me.Panel25.TabIndex = 28
        '
        'Label67
        '
        Me.Label67.BackColor = System.Drawing.Color.Transparent
        Me.Label67.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.Label67.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label67.Location = New System.Drawing.Point(86, 125)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(36, 25)
        Me.Label67.TabIndex = 21
        Me.Label67.Text = "KG"
        Me.Label67.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel26
        '
        Me.Panel26.BackColor = System.Drawing.Color.Transparent
        Me.Panel26.BackgroundImage = Global.Automated_Feedmill_System.My.Resources.Resources.silo
        Me.Panel26.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel26.Controls.Add(Me.lblFormulaSilo9)
        Me.Panel26.Controls.Add(Me.Label28)
        Me.Panel26.Location = New System.Drawing.Point(0, 2)
        Me.Panel26.Name = "Panel26"
        Me.Panel26.Size = New System.Drawing.Size(157, 121)
        Me.Panel26.TabIndex = 11
        '
        'lblFormulaSilo9
        '
        Me.lblFormulaSilo9.BackColor = System.Drawing.Color.Transparent
        Me.lblFormulaSilo9.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.lblFormulaSilo9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.lblFormulaSilo9.Location = New System.Drawing.Point(13, 52)
        Me.lblFormulaSilo9.Name = "lblFormulaSilo9"
        Me.lblFormulaSilo9.Size = New System.Drawing.Size(126, 39)
        Me.lblFormulaSilo9.TabIndex = 9
        Me.lblFormulaSilo9.Text = "Raw Mats"
        Me.lblFormulaSilo9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label28.Location = New System.Drawing.Point(54, 16)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(51, 23)
        Me.Label28.TabIndex = 8
        Me.Label28.Text = "Silo 9"
        '
        'txtbFormSilo9
        '
        Me.txtbFormSilo9.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbFormSilo9.Location = New System.Drawing.Point(33, 124)
        Me.txtbFormSilo9.Name = "txtbFormSilo9"
        Me.txtbFormSilo9.Size = New System.Drawing.Size(54, 27)
        Me.txtbFormSilo9.TabIndex = 20
        '
        'Panel27
        '
        Me.Panel27.BackColor = System.Drawing.Color.Transparent
        Me.Panel27.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel27.Controls.Add(Me.Label64)
        Me.Panel27.Controls.Add(Me.Panel28)
        Me.Panel27.Controls.Add(Me.txtbFormSilo8)
        Me.Panel27.Location = New System.Drawing.Point(177, 341)
        Me.Panel27.Name = "Panel27"
        Me.Panel27.Size = New System.Drawing.Size(157, 153)
        Me.Panel27.TabIndex = 27
        '
        'Label64
        '
        Me.Label64.BackColor = System.Drawing.Color.Transparent
        Me.Label64.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.Label64.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label64.Location = New System.Drawing.Point(88, 124)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(36, 25)
        Me.Label64.TabIndex = 19
        Me.Label64.Text = "KG"
        Me.Label64.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel28
        '
        Me.Panel28.BackColor = System.Drawing.Color.Transparent
        Me.Panel28.BackgroundImage = Global.Automated_Feedmill_System.My.Resources.Resources.silo
        Me.Panel28.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel28.Controls.Add(Me.lblFormulaSilo8)
        Me.Panel28.Controls.Add(Me.Label32)
        Me.Panel28.Location = New System.Drawing.Point(0, 2)
        Me.Panel28.Name = "Panel28"
        Me.Panel28.Size = New System.Drawing.Size(157, 121)
        Me.Panel28.TabIndex = 11
        '
        'lblFormulaSilo8
        '
        Me.lblFormulaSilo8.BackColor = System.Drawing.Color.Transparent
        Me.lblFormulaSilo8.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.lblFormulaSilo8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.lblFormulaSilo8.Location = New System.Drawing.Point(13, 52)
        Me.lblFormulaSilo8.Name = "lblFormulaSilo8"
        Me.lblFormulaSilo8.Size = New System.Drawing.Size(126, 39)
        Me.lblFormulaSilo8.TabIndex = 9
        Me.lblFormulaSilo8.Text = "Raw Mats"
        Me.lblFormulaSilo8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label32.Location = New System.Drawing.Point(54, 16)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(51, 23)
        Me.Label32.TabIndex = 8
        Me.Label32.Text = "Silo 8"
        '
        'txtbFormSilo8
        '
        Me.txtbFormSilo8.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbFormSilo8.Location = New System.Drawing.Point(35, 123)
        Me.txtbFormSilo8.Name = "txtbFormSilo8"
        Me.txtbFormSilo8.Size = New System.Drawing.Size(54, 27)
        Me.txtbFormSilo8.TabIndex = 18
        '
        'Panel29
        '
        Me.Panel29.BackColor = System.Drawing.Color.Transparent
        Me.Panel29.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel29.Controls.Add(Me.Label38)
        Me.Panel29.Controls.Add(Me.txtbFormSilo6)
        Me.Panel29.Controls.Add(Me.Panel30)
        Me.Panel29.Location = New System.Drawing.Point(340, 182)
        Me.Panel29.Name = "Panel29"
        Me.Panel29.Size = New System.Drawing.Size(157, 153)
        Me.Panel29.TabIndex = 25
        '
        'Label38
        '
        Me.Label38.BackColor = System.Drawing.Color.Transparent
        Me.Label38.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.Label38.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label38.Location = New System.Drawing.Point(86, 124)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(36, 25)
        Me.Label38.TabIndex = 17
        Me.Label38.Text = "KG"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtbFormSilo6
        '
        Me.txtbFormSilo6.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbFormSilo6.Location = New System.Drawing.Point(33, 124)
        Me.txtbFormSilo6.Name = "txtbFormSilo6"
        Me.txtbFormSilo6.Size = New System.Drawing.Size(54, 27)
        Me.txtbFormSilo6.TabIndex = 16
        '
        'Panel30
        '
        Me.Panel30.BackColor = System.Drawing.Color.Transparent
        Me.Panel30.BackgroundImage = Global.Automated_Feedmill_System.My.Resources.Resources.silo
        Me.Panel30.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel30.Controls.Add(Me.lblFormulaSilo6)
        Me.Panel30.Controls.Add(Me.Label36)
        Me.Panel30.Location = New System.Drawing.Point(0, 2)
        Me.Panel30.Name = "Panel30"
        Me.Panel30.Size = New System.Drawing.Size(157, 121)
        Me.Panel30.TabIndex = 11
        '
        'lblFormulaSilo6
        '
        Me.lblFormulaSilo6.BackColor = System.Drawing.Color.Transparent
        Me.lblFormulaSilo6.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.lblFormulaSilo6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.lblFormulaSilo6.Location = New System.Drawing.Point(13, 52)
        Me.lblFormulaSilo6.Name = "lblFormulaSilo6"
        Me.lblFormulaSilo6.Size = New System.Drawing.Size(126, 39)
        Me.lblFormulaSilo6.TabIndex = 9
        Me.lblFormulaSilo6.Text = "Raw Mats"
        Me.lblFormulaSilo6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.BackColor = System.Drawing.Color.Transparent
        Me.Label36.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label36.Location = New System.Drawing.Point(54, 16)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(51, 23)
        Me.Label36.TabIndex = 8
        Me.Label36.Text = "Silo 6"
        '
        'Panel31
        '
        Me.Panel31.BackColor = System.Drawing.Color.Transparent
        Me.Panel31.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel31.Controls.Add(Me.Label42)
        Me.Panel31.Controls.Add(Me.txtbFormSilo7)
        Me.Panel31.Controls.Add(Me.Panel32)
        Me.Panel31.Location = New System.Drawing.Point(14, 341)
        Me.Panel31.Name = "Panel31"
        Me.Panel31.Size = New System.Drawing.Size(157, 153)
        Me.Panel31.TabIndex = 26
        '
        'Label42
        '
        Me.Label42.BackColor = System.Drawing.Color.Transparent
        Me.Label42.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.Label42.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label42.Location = New System.Drawing.Point(86, 124)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(36, 25)
        Me.Label42.TabIndex = 17
        Me.Label42.Text = "KG"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtbFormSilo7
        '
        Me.txtbFormSilo7.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbFormSilo7.Location = New System.Drawing.Point(33, 123)
        Me.txtbFormSilo7.Name = "txtbFormSilo7"
        Me.txtbFormSilo7.Size = New System.Drawing.Size(54, 27)
        Me.txtbFormSilo7.TabIndex = 16
        '
        'Panel32
        '
        Me.Panel32.BackColor = System.Drawing.Color.Transparent
        Me.Panel32.BackgroundImage = Global.Automated_Feedmill_System.My.Resources.Resources.silo
        Me.Panel32.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel32.Controls.Add(Me.lblFormulaSilo7)
        Me.Panel32.Controls.Add(Me.Label41)
        Me.Panel32.Location = New System.Drawing.Point(0, 2)
        Me.Panel32.Name = "Panel32"
        Me.Panel32.Size = New System.Drawing.Size(157, 121)
        Me.Panel32.TabIndex = 11
        '
        'lblFormulaSilo7
        '
        Me.lblFormulaSilo7.BackColor = System.Drawing.Color.Transparent
        Me.lblFormulaSilo7.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.lblFormulaSilo7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.lblFormulaSilo7.Location = New System.Drawing.Point(13, 52)
        Me.lblFormulaSilo7.Name = "lblFormulaSilo7"
        Me.lblFormulaSilo7.Size = New System.Drawing.Size(126, 39)
        Me.lblFormulaSilo7.TabIndex = 9
        Me.lblFormulaSilo7.Text = "Raw Mats"
        Me.lblFormulaSilo7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.BackColor = System.Drawing.Color.Transparent
        Me.Label41.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label41.Location = New System.Drawing.Point(54, 16)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(51, 23)
        Me.Label41.TabIndex = 8
        Me.Label41.Text = "Silo 7"
        '
        'Panel33
        '
        Me.Panel33.BackColor = System.Drawing.Color.Transparent
        Me.Panel33.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel33.Controls.Add(Me.Label47)
        Me.Panel33.Controls.Add(Me.txtbFormSilo3)
        Me.Panel33.Controls.Add(Me.Panel34)
        Me.Panel33.Location = New System.Drawing.Point(340, 20)
        Me.Panel33.Name = "Panel33"
        Me.Panel33.Size = New System.Drawing.Size(157, 153)
        Me.Panel33.TabIndex = 21
        '
        'Label47
        '
        Me.Label47.BackColor = System.Drawing.Color.Transparent
        Me.Label47.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.Label47.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label47.Location = New System.Drawing.Point(86, 126)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(36, 25)
        Me.Label47.TabIndex = 15
        Me.Label47.Text = "KG"
        Me.Label47.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtbFormSilo3
        '
        Me.txtbFormSilo3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbFormSilo3.Location = New System.Drawing.Point(33, 125)
        Me.txtbFormSilo3.Name = "txtbFormSilo3"
        Me.txtbFormSilo3.Size = New System.Drawing.Size(54, 27)
        Me.txtbFormSilo3.TabIndex = 14
        '
        'Panel34
        '
        Me.Panel34.BackColor = System.Drawing.Color.Transparent
        Me.Panel34.BackgroundImage = Global.Automated_Feedmill_System.My.Resources.Resources.silo
        Me.Panel34.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel34.Controls.Add(Me.lblFormulaSilo3)
        Me.Panel34.Controls.Add(Me.Label46)
        Me.Panel34.Location = New System.Drawing.Point(0, 2)
        Me.Panel34.Name = "Panel34"
        Me.Panel34.Size = New System.Drawing.Size(157, 121)
        Me.Panel34.TabIndex = 11
        '
        'lblFormulaSilo3
        '
        Me.lblFormulaSilo3.BackColor = System.Drawing.Color.Transparent
        Me.lblFormulaSilo3.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.lblFormulaSilo3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.lblFormulaSilo3.Location = New System.Drawing.Point(13, 52)
        Me.lblFormulaSilo3.Name = "lblFormulaSilo3"
        Me.lblFormulaSilo3.Size = New System.Drawing.Size(126, 39)
        Me.lblFormulaSilo3.TabIndex = 9
        Me.lblFormulaSilo3.Text = "Raw Mats"
        Me.lblFormulaSilo3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.BackColor = System.Drawing.Color.Transparent
        Me.Label46.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label46.Location = New System.Drawing.Point(54, 16)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(51, 23)
        Me.Label46.TabIndex = 8
        Me.Label46.Text = "Silo 3"
        '
        'Panel35
        '
        Me.Panel35.BackColor = System.Drawing.Color.Transparent
        Me.Panel35.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel35.Controls.Add(Me.Label52)
        Me.Panel35.Controls.Add(Me.txtbFormSilo1)
        Me.Panel35.Controls.Add(Me.Panel36)
        Me.Panel35.Location = New System.Drawing.Point(14, 20)
        Me.Panel35.Name = "Panel35"
        Me.Panel35.Size = New System.Drawing.Size(157, 153)
        Me.Panel35.TabIndex = 20
        '
        'Label52
        '
        Me.Label52.BackColor = System.Drawing.Color.Transparent
        Me.Label52.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.Label52.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label52.Location = New System.Drawing.Point(79, 125)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(36, 25)
        Me.Label52.TabIndex = 13
        Me.Label52.Text = "KG"
        Me.Label52.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtbFormSilo1
        '
        Me.txtbFormSilo1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbFormSilo1.Location = New System.Drawing.Point(26, 124)
        Me.txtbFormSilo1.Name = "txtbFormSilo1"
        Me.txtbFormSilo1.Size = New System.Drawing.Size(54, 27)
        Me.txtbFormSilo1.TabIndex = 12
        '
        'Panel36
        '
        Me.Panel36.BackColor = System.Drawing.Color.Transparent
        Me.Panel36.BackgroundImage = Global.Automated_Feedmill_System.My.Resources.Resources.silo
        Me.Panel36.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel36.Controls.Add(Me.lblFormulaSilo1)
        Me.Panel36.Controls.Add(Me.Label50)
        Me.Panel36.Location = New System.Drawing.Point(0, 2)
        Me.Panel36.Name = "Panel36"
        Me.Panel36.Size = New System.Drawing.Size(157, 121)
        Me.Panel36.TabIndex = 11
        '
        'lblFormulaSilo1
        '
        Me.lblFormulaSilo1.BackColor = System.Drawing.Color.Transparent
        Me.lblFormulaSilo1.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.lblFormulaSilo1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.lblFormulaSilo1.Location = New System.Drawing.Point(13, 52)
        Me.lblFormulaSilo1.Name = "lblFormulaSilo1"
        Me.lblFormulaSilo1.Size = New System.Drawing.Size(126, 39)
        Me.lblFormulaSilo1.TabIndex = 9
        Me.lblFormulaSilo1.Text = "Raw Mats"
        Me.lblFormulaSilo1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.BackColor = System.Drawing.Color.Transparent
        Me.Label50.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label50.Location = New System.Drawing.Point(54, 16)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(49, 23)
        Me.Label50.TabIndex = 8
        Me.Label50.Text = "Silo 1"
        '
        'Panel37
        '
        Me.Panel37.BackColor = System.Drawing.Color.Transparent
        Me.Panel37.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel37.Controls.Add(Me.Label33)
        Me.Panel37.Controls.Add(Me.txtbFormSilo5)
        Me.Panel37.Controls.Add(Me.Panel38)
        Me.Panel37.Location = New System.Drawing.Point(177, 182)
        Me.Panel37.Name = "Panel37"
        Me.Panel37.Size = New System.Drawing.Size(157, 153)
        Me.Panel37.TabIndex = 24
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.Label33.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.Label33.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label33.Location = New System.Drawing.Point(88, 126)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(36, 25)
        Me.Label33.TabIndex = 17
        Me.Label33.Text = "KG"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtbFormSilo5
        '
        Me.txtbFormSilo5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbFormSilo5.Location = New System.Drawing.Point(35, 125)
        Me.txtbFormSilo5.Name = "txtbFormSilo5"
        Me.txtbFormSilo5.Size = New System.Drawing.Size(54, 27)
        Me.txtbFormSilo5.TabIndex = 16
        '
        'Panel38
        '
        Me.Panel38.BackColor = System.Drawing.Color.Transparent
        Me.Panel38.BackgroundImage = Global.Automated_Feedmill_System.My.Resources.Resources.silo
        Me.Panel38.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel38.Controls.Add(Me.lblFormulaSilo5)
        Me.Panel38.Controls.Add(Me.Label62)
        Me.Panel38.Location = New System.Drawing.Point(0, 2)
        Me.Panel38.Name = "Panel38"
        Me.Panel38.Size = New System.Drawing.Size(157, 121)
        Me.Panel38.TabIndex = 11
        '
        'lblFormulaSilo5
        '
        Me.lblFormulaSilo5.BackColor = System.Drawing.Color.Transparent
        Me.lblFormulaSilo5.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.lblFormulaSilo5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.lblFormulaSilo5.Location = New System.Drawing.Point(13, 52)
        Me.lblFormulaSilo5.Name = "lblFormulaSilo5"
        Me.lblFormulaSilo5.Size = New System.Drawing.Size(126, 39)
        Me.lblFormulaSilo5.TabIndex = 9
        Me.lblFormulaSilo5.Text = "Raw Mats"
        Me.lblFormulaSilo5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.BackColor = System.Drawing.Color.Transparent
        Me.Label62.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label62.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label62.Location = New System.Drawing.Point(54, 16)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(51, 23)
        Me.Label62.TabIndex = 8
        Me.Label62.Text = "Silo 5"
        '
        'Panel39
        '
        Me.Panel39.BackColor = System.Drawing.Color.Transparent
        Me.Panel39.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel39.Controls.Add(Me.Label29)
        Me.Panel39.Controls.Add(Me.txtbFormSilo4)
        Me.Panel39.Controls.Add(Me.Panel40)
        Me.Panel39.Location = New System.Drawing.Point(14, 182)
        Me.Panel39.Name = "Panel39"
        Me.Panel39.Size = New System.Drawing.Size(157, 153)
        Me.Panel39.TabIndex = 23
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.Label29.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label29.Location = New System.Drawing.Point(86, 125)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(36, 25)
        Me.Label29.TabIndex = 15
        Me.Label29.Text = "KG"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtbFormSilo4
        '
        Me.txtbFormSilo4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbFormSilo4.Location = New System.Drawing.Point(33, 124)
        Me.txtbFormSilo4.Name = "txtbFormSilo4"
        Me.txtbFormSilo4.Size = New System.Drawing.Size(54, 27)
        Me.txtbFormSilo4.TabIndex = 14
        '
        'Panel40
        '
        Me.Panel40.BackColor = System.Drawing.Color.Transparent
        Me.Panel40.BackgroundImage = Global.Automated_Feedmill_System.My.Resources.Resources.silo
        Me.Panel40.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel40.Controls.Add(Me.lblFormulaSilo4)
        Me.Panel40.Controls.Add(Me.Label66)
        Me.Panel40.Location = New System.Drawing.Point(0, 2)
        Me.Panel40.Name = "Panel40"
        Me.Panel40.Size = New System.Drawing.Size(157, 121)
        Me.Panel40.TabIndex = 11
        '
        'lblFormulaSilo4
        '
        Me.lblFormulaSilo4.BackColor = System.Drawing.Color.Transparent
        Me.lblFormulaSilo4.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.lblFormulaSilo4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.lblFormulaSilo4.Location = New System.Drawing.Point(13, 52)
        Me.lblFormulaSilo4.Name = "lblFormulaSilo4"
        Me.lblFormulaSilo4.Size = New System.Drawing.Size(126, 39)
        Me.lblFormulaSilo4.TabIndex = 9
        Me.lblFormulaSilo4.Text = "Raw Mats"
        Me.lblFormulaSilo4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.BackColor = System.Drawing.Color.Transparent
        Me.Label66.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label66.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label66.Location = New System.Drawing.Point(54, 16)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(52, 23)
        Me.Label66.TabIndex = 8
        Me.Label66.Text = "Silo 4"
        '
        'Panel41
        '
        Me.Panel41.BackColor = System.Drawing.Color.Transparent
        Me.Panel41.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel41.Controls.Add(Me.Label70)
        Me.Panel41.Controls.Add(Me.txtbFormSilo2)
        Me.Panel41.Controls.Add(Me.Panel42)
        Me.Panel41.Location = New System.Drawing.Point(177, 20)
        Me.Panel41.Name = "Panel41"
        Me.Panel41.Size = New System.Drawing.Size(157, 153)
        Me.Panel41.TabIndex = 22
        '
        'Label70
        '
        Me.Label70.BackColor = System.Drawing.Color.Transparent
        Me.Label70.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.Label70.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label70.Location = New System.Drawing.Point(88, 125)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(36, 25)
        Me.Label70.TabIndex = 15
        Me.Label70.Text = "KG"
        Me.Label70.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtbFormSilo2
        '
        Me.txtbFormSilo2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbFormSilo2.Location = New System.Drawing.Point(35, 124)
        Me.txtbFormSilo2.Name = "txtbFormSilo2"
        Me.txtbFormSilo2.Size = New System.Drawing.Size(54, 27)
        Me.txtbFormSilo2.TabIndex = 14
        '
        'Panel42
        '
        Me.Panel42.BackColor = System.Drawing.Color.Transparent
        Me.Panel42.BackgroundImage = Global.Automated_Feedmill_System.My.Resources.Resources.silo
        Me.Panel42.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel42.Controls.Add(Me.lblFormulaSilo2)
        Me.Panel42.Controls.Add(Me.Label69)
        Me.Panel42.Location = New System.Drawing.Point(0, 2)
        Me.Panel42.Name = "Panel42"
        Me.Panel42.Size = New System.Drawing.Size(157, 121)
        Me.Panel42.TabIndex = 11
        '
        'lblFormulaSilo2
        '
        Me.lblFormulaSilo2.BackColor = System.Drawing.Color.Transparent
        Me.lblFormulaSilo2.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.lblFormulaSilo2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.lblFormulaSilo2.Location = New System.Drawing.Point(13, 52)
        Me.lblFormulaSilo2.Name = "lblFormulaSilo2"
        Me.lblFormulaSilo2.Size = New System.Drawing.Size(126, 39)
        Me.lblFormulaSilo2.TabIndex = 9
        Me.lblFormulaSilo2.Text = "Raw Mats"
        Me.lblFormulaSilo2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.BackColor = System.Drawing.Color.Transparent
        Me.Label69.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label69.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label69.Location = New System.Drawing.Point(54, 16)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(51, 23)
        Me.Label69.TabIndex = 8
        Me.Label69.Text = "Silo 2"
        '
        'pnlBatching
        '
        Me.pnlBatching.Controls.Add(Me.lblbatchingCoco)
        Me.pnlBatching.Controls.Add(Me.lblbatchingMol)
        Me.pnlBatching.Controls.Add(Me.Label110)
        Me.pnlBatching.Controls.Add(Me.Label111)
        Me.pnlBatching.Controls.Add(Me.gbBatchingStatus)
        Me.pnlBatching.Controls.Add(Me.cmbFormulaBatching)
        Me.pnlBatching.Controls.Add(Me.btnStartBatching)
        Me.pnlBatching.Controls.Add(Me.Panel19)
        Me.pnlBatching.Controls.Add(Me.Panel21)
        Me.pnlBatching.Controls.Add(Me.Panel12)
        Me.pnlBatching.Controls.Add(Me.Panel23)
        Me.pnlBatching.Controls.Add(Me.Panel10)
        Me.pnlBatching.Controls.Add(Me.Panel7)
        Me.pnlBatching.Controls.Add(Me.Panel14)
        Me.pnlBatching.Controls.Add(Me.Panel17)
        Me.pnlBatching.Controls.Add(Me.Panel8)
        Me.pnlBatching.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBatching.Location = New System.Drawing.Point(0, 94)
        Me.pnlBatching.Name = "pnlBatching"
        Me.pnlBatching.Size = New System.Drawing.Size(791, 606)
        Me.pnlBatching.TabIndex = 13
        '
        'lblbatchingCoco
        '
        Me.lblbatchingCoco.BackColor = System.Drawing.Color.Transparent
        Me.lblbatchingCoco.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.lblbatchingCoco.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.lblbatchingCoco.Location = New System.Drawing.Point(383, 532)
        Me.lblbatchingCoco.Name = "lblbatchingCoco"
        Me.lblbatchingCoco.Size = New System.Drawing.Size(72, 25)
        Me.lblbatchingCoco.TabIndex = 48
        Me.lblbatchingCoco.Text = "0 KG"
        Me.lblbatchingCoco.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblbatchingMol
        '
        Me.lblbatchingMol.BackColor = System.Drawing.Color.Transparent
        Me.lblbatchingMol.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.lblbatchingMol.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.lblbatchingMol.Location = New System.Drawing.Point(128, 534)
        Me.lblbatchingMol.Name = "lblbatchingMol"
        Me.lblbatchingMol.Size = New System.Drawing.Size(72, 25)
        Me.lblbatchingMol.TabIndex = 47
        Me.lblbatchingMol.Text = "0 KG"
        Me.lblbatchingMol.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label110
        '
        Me.Label110.AutoSize = True
        Me.Label110.BackColor = System.Drawing.Color.Transparent
        Me.Label110.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label110.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label110.Location = New System.Drawing.Point(293, 534)
        Me.Label110.Name = "Label110"
        Me.Label110.Size = New System.Drawing.Size(84, 23)
        Me.Label110.TabIndex = 46
        Me.Label110.Text = "Coco Oil :"
        '
        'Label111
        '
        Me.Label111.AutoSize = True
        Me.Label111.BackColor = System.Drawing.Color.Transparent
        Me.Label111.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label111.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label111.Location = New System.Drawing.Point(30, 534)
        Me.Label111.Name = "Label111"
        Me.Label111.Size = New System.Drawing.Size(92, 23)
        Me.Label111.TabIndex = 44
        Me.Label111.Text = "Mollasses :"
        '
        'gbBatchingStatus
        '
        Me.gbBatchingStatus.Controls.Add(Me.Label84)
        Me.gbBatchingStatus.Controls.Add(Me.lblliquidCurrentTargetLoad)
        Me.gbBatchingStatus.Controls.Add(Me.Label108)
        Me.gbBatchingStatus.Controls.Add(Me.lblliquidcurrent)
        Me.gbBatchingStatus.Controls.Add(Me.lblbatchno)
        Me.gbBatchingStatus.Controls.Add(Me.Label26)
        Me.gbBatchingStatus.Controls.Add(Me.Label60)
        Me.gbBatchingStatus.Controls.Add(Me.Label54)
        Me.gbBatchingStatus.Controls.Add(Me.Label58)
        Me.gbBatchingStatus.Controls.Add(Me.Label53)
        Me.gbBatchingStatus.Controls.Add(Me.lblBatchActiveSilo)
        Me.gbBatchingStatus.Controls.Add(Me.lblBatchBinCurrent)
        Me.gbBatchingStatus.Controls.Add(Me.lblBatchCurrentTarget)
        Me.gbBatchingStatus.Controls.Add(Me.lblBatchTotalTarget)
        Me.gbBatchingStatus.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbBatchingStatus.Location = New System.Drawing.Point(532, 172)
        Me.gbBatchingStatus.Name = "gbBatchingStatus"
        Me.gbBatchingStatus.Size = New System.Drawing.Size(231, 397)
        Me.gbBatchingStatus.TabIndex = 30
        Me.gbBatchingStatus.TabStop = False
        Me.gbBatchingStatus.Text = "Batching Status"
        '
        'Label84
        '
        Me.Label84.AutoSize = True
        Me.Label84.BackColor = System.Drawing.Color.Transparent
        Me.Label84.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label84.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label84.Location = New System.Drawing.Point(14, 332)
        Me.Label84.Name = "Label84"
        Me.Label84.Size = New System.Drawing.Size(207, 20)
        Me.Label84.TabIndex = 35
        Me.Label84.Text = "Liquid Current Target Weight"
        '
        'lblliquidCurrentTargetLoad
        '
        Me.lblliquidCurrentTargetLoad.AutoSize = True
        Me.lblliquidCurrentTargetLoad.BackColor = System.Drawing.Color.Transparent
        Me.lblliquidCurrentTargetLoad.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblliquidCurrentTargetLoad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.lblliquidCurrentTargetLoad.Location = New System.Drawing.Point(14, 357)
        Me.lblliquidCurrentTargetLoad.Name = "lblliquidCurrentTargetLoad"
        Me.lblliquidCurrentTargetLoad.Size = New System.Drawing.Size(55, 20)
        Me.lblliquidCurrentTargetLoad.TabIndex = 34
        Me.lblliquidCurrentTargetLoad.Text = "000 KG"
        '
        'Label108
        '
        Me.Label108.AutoSize = True
        Me.Label108.BackColor = System.Drawing.Color.Transparent
        Me.Label108.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label108.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label108.Location = New System.Drawing.Point(14, 182)
        Me.Label108.Name = "Label108"
        Me.Label108.Size = New System.Drawing.Size(178, 20)
        Me.Label108.TabIndex = 32
        Me.Label108.Text = "Liquids Current Weight : "
        '
        'lblliquidcurrent
        '
        Me.lblliquidcurrent.AutoSize = True
        Me.lblliquidcurrent.BackColor = System.Drawing.Color.Transparent
        Me.lblliquidcurrent.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblliquidcurrent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.lblliquidcurrent.Location = New System.Drawing.Point(14, 207)
        Me.lblliquidcurrent.Name = "lblliquidcurrent"
        Me.lblliquidcurrent.Size = New System.Drawing.Size(55, 20)
        Me.lblliquidcurrent.TabIndex = 33
        Me.lblliquidcurrent.Text = "000 KG"
        '
        'lblbatchno
        '
        Me.lblbatchno.AutoSize = True
        Me.lblbatchno.BackColor = System.Drawing.Color.Transparent
        Me.lblbatchno.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblbatchno.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.lblbatchno.Location = New System.Drawing.Point(14, 57)
        Me.lblbatchno.Name = "lblbatchno"
        Me.lblbatchno.Size = New System.Drawing.Size(89, 20)
        Me.lblbatchno.TabIndex = 31
        Me.lblbatchno.Text = "0000000000"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label26.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label26.Location = New System.Drawing.Point(14, 32)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(113, 20)
        Me.Label26.TabIndex = 30
        Me.Label26.Text = "Batch Number:"
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.BackColor = System.Drawing.Color.Transparent
        Me.Label60.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label60.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label60.Location = New System.Drawing.Point(14, 282)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(161, 20)
        Me.Label60.TabIndex = 28
        Me.Label60.Text = "Current Target Weight"
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.BackColor = System.Drawing.Color.Transparent
        Me.Label54.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label54.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label54.Location = New System.Drawing.Point(14, 132)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(152, 20)
        Me.Label54.TabIndex = 23
        Me.Label54.Text = "Bin Current Weight : "
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.BackColor = System.Drawing.Color.Transparent
        Me.Label58.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label58.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label58.Location = New System.Drawing.Point(14, 232)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(88, 20)
        Me.Label58.TabIndex = 26
        Me.Label58.Text = "Active Silo :"
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.BackColor = System.Drawing.Color.Transparent
        Me.Label53.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label53.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label53.Location = New System.Drawing.Point(14, 82)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(150, 20)
        Me.Label53.TabIndex = 22
        Me.Label53.Text = "Total Target Weight :"
        '
        'lblBatchActiveSilo
        '
        Me.lblBatchActiveSilo.AutoSize = True
        Me.lblBatchActiveSilo.BackColor = System.Drawing.Color.Transparent
        Me.lblBatchActiveSilo.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblBatchActiveSilo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.lblBatchActiveSilo.Location = New System.Drawing.Point(14, 257)
        Me.lblBatchActiveSilo.Name = "lblBatchActiveSilo"
        Me.lblBatchActiveSilo.Size = New System.Drawing.Size(44, 20)
        Me.lblBatchActiveSilo.TabIndex = 27
        Me.lblBatchActiveSilo.Text = "Silo 1"
        '
        'lblBatchBinCurrent
        '
        Me.lblBatchBinCurrent.AutoSize = True
        Me.lblBatchBinCurrent.BackColor = System.Drawing.Color.Transparent
        Me.lblBatchBinCurrent.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblBatchBinCurrent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.lblBatchBinCurrent.Location = New System.Drawing.Point(14, 157)
        Me.lblBatchBinCurrent.Name = "lblBatchBinCurrent"
        Me.lblBatchBinCurrent.Size = New System.Drawing.Size(55, 20)
        Me.lblBatchBinCurrent.TabIndex = 24
        Me.lblBatchBinCurrent.Text = "000 KG"
        '
        'lblBatchCurrentTarget
        '
        Me.lblBatchCurrentTarget.AutoSize = True
        Me.lblBatchCurrentTarget.BackColor = System.Drawing.Color.Transparent
        Me.lblBatchCurrentTarget.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblBatchCurrentTarget.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.lblBatchCurrentTarget.Location = New System.Drawing.Point(14, 307)
        Me.lblBatchCurrentTarget.Name = "lblBatchCurrentTarget"
        Me.lblBatchCurrentTarget.Size = New System.Drawing.Size(55, 20)
        Me.lblBatchCurrentTarget.TabIndex = 25
        Me.lblBatchCurrentTarget.Text = "000 KG"
        '
        'lblBatchTotalTarget
        '
        Me.lblBatchTotalTarget.AutoSize = True
        Me.lblBatchTotalTarget.BackColor = System.Drawing.Color.Transparent
        Me.lblBatchTotalTarget.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblBatchTotalTarget.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.lblBatchTotalTarget.Location = New System.Drawing.Point(14, 107)
        Me.lblBatchTotalTarget.Name = "lblBatchTotalTarget"
        Me.lblBatchTotalTarget.Size = New System.Drawing.Size(55, 20)
        Me.lblBatchTotalTarget.TabIndex = 29
        Me.lblBatchTotalTarget.Text = "000 KG"
        '
        'cmbFormulaBatching
        '
        Me.cmbFormulaBatching.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFormulaBatching.FormattingEnabled = True
        Me.cmbFormulaBatching.Location = New System.Drawing.Point(530, 60)
        Me.cmbFormulaBatching.Name = "cmbFormulaBatching"
        Me.cmbFormulaBatching.Size = New System.Drawing.Size(220, 33)
        Me.cmbFormulaBatching.TabIndex = 21
        Me.cmbFormulaBatching.Text = "Select Formula"
        '
        'btnStartBatching
        '
        Me.btnStartBatching.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnStartBatching.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btnStartBatching.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnStartBatching.BorderRadius = 0
        Me.btnStartBatching.ButtonText = "Start Batching"
        Me.btnStartBatching.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStartBatching.DisabledColor = System.Drawing.Color.Gray
        Me.btnStartBatching.Iconcolor = System.Drawing.Color.Transparent
        Me.btnStartBatching.Iconimage = Global.Automated_Feedmill_System.My.Resources.Resources.Refresh_96px
        Me.btnStartBatching.Iconimage_right = Nothing
        Me.btnStartBatching.Iconimage_right_Selected = Nothing
        Me.btnStartBatching.Iconimage_Selected = Nothing
        Me.btnStartBatching.IconMarginLeft = 0
        Me.btnStartBatching.IconMarginRight = 0
        Me.btnStartBatching.IconRightVisible = True
        Me.btnStartBatching.IconRightZoom = 0R
        Me.btnStartBatching.IconVisible = True
        Me.btnStartBatching.IconZoom = 70.0R
        Me.btnStartBatching.IsTab = False
        Me.btnStartBatching.Location = New System.Drawing.Point(532, 104)
        Me.btnStartBatching.Name = "btnStartBatching"
        Me.btnStartBatching.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btnStartBatching.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnStartBatching.OnHoverTextColor = System.Drawing.Color.White
        Me.btnStartBatching.selected = False
        Me.btnStartBatching.Size = New System.Drawing.Size(158, 48)
        Me.btnStartBatching.TabIndex = 20
        Me.btnStartBatching.Text = "Start Batching"
        Me.btnStartBatching.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnStartBatching.Textcolor = System.Drawing.Color.White
        Me.btnStartBatching.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Panel19
        '
        Me.Panel19.BackColor = System.Drawing.Color.Transparent
        Me.Panel19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel19.Controls.Add(Me.Panel20)
        Me.Panel19.Controls.Add(Me.lblBatchSiloWeight9)
        Me.Panel19.Location = New System.Drawing.Point(353, 346)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(157, 153)
        Me.Panel19.TabIndex = 19
        '
        'Panel20
        '
        Me.Panel20.BackColor = System.Drawing.Color.Transparent
        Me.Panel20.BackgroundImage = Global.Automated_Feedmill_System.My.Resources.Resources.silo
        Me.Panel20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel20.Controls.Add(Me.lblBatchSiloMaterial9)
        Me.Panel20.Controls.Add(Me.Label45)
        Me.Panel20.Location = New System.Drawing.Point(0, 2)
        Me.Panel20.Name = "Panel20"
        Me.Panel20.Size = New System.Drawing.Size(157, 121)
        Me.Panel20.TabIndex = 11
        '
        'lblBatchSiloMaterial9
        '
        Me.lblBatchSiloMaterial9.BackColor = System.Drawing.Color.Transparent
        Me.lblBatchSiloMaterial9.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.lblBatchSiloMaterial9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.lblBatchSiloMaterial9.Location = New System.Drawing.Point(13, 52)
        Me.lblBatchSiloMaterial9.Name = "lblBatchSiloMaterial9"
        Me.lblBatchSiloMaterial9.Size = New System.Drawing.Size(126, 39)
        Me.lblBatchSiloMaterial9.TabIndex = 9
        Me.lblBatchSiloMaterial9.Text = "Raw Mats"
        Me.lblBatchSiloMaterial9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.BackColor = System.Drawing.Color.Transparent
        Me.Label45.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label45.Location = New System.Drawing.Point(54, 16)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(49, 23)
        Me.Label45.TabIndex = 8
        Me.Label45.Text = "Silo 1"
        '
        'lblBatchSiloWeight9
        '
        Me.lblBatchSiloWeight9.BackColor = System.Drawing.Color.Transparent
        Me.lblBatchSiloWeight9.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.lblBatchSiloWeight9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.lblBatchSiloWeight9.Location = New System.Drawing.Point(45, 125)
        Me.lblBatchSiloWeight9.Name = "lblBatchSiloWeight9"
        Me.lblBatchSiloWeight9.Size = New System.Drawing.Size(72, 25)
        Me.lblBatchSiloWeight9.TabIndex = 10
        Me.lblBatchSiloWeight9.Text = "0 KG"
        Me.lblBatchSiloWeight9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel21
        '
        Me.Panel21.BackColor = System.Drawing.Color.Transparent
        Me.Panel21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel21.Controls.Add(Me.Panel22)
        Me.Panel21.Controls.Add(Me.lblBatchSiloWeight8)
        Me.Panel21.Location = New System.Drawing.Point(190, 346)
        Me.Panel21.Name = "Panel21"
        Me.Panel21.Size = New System.Drawing.Size(157, 153)
        Me.Panel21.TabIndex = 18
        '
        'Panel22
        '
        Me.Panel22.BackColor = System.Drawing.Color.Transparent
        Me.Panel22.BackgroundImage = Global.Automated_Feedmill_System.My.Resources.Resources.silo
        Me.Panel22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel22.Controls.Add(Me.lblBatchSiloMaterial8)
        Me.Panel22.Controls.Add(Me.Label48)
        Me.Panel22.Location = New System.Drawing.Point(0, 2)
        Me.Panel22.Name = "Panel22"
        Me.Panel22.Size = New System.Drawing.Size(157, 121)
        Me.Panel22.TabIndex = 11
        '
        'lblBatchSiloMaterial8
        '
        Me.lblBatchSiloMaterial8.BackColor = System.Drawing.Color.Transparent
        Me.lblBatchSiloMaterial8.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.lblBatchSiloMaterial8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.lblBatchSiloMaterial8.Location = New System.Drawing.Point(13, 52)
        Me.lblBatchSiloMaterial8.Name = "lblBatchSiloMaterial8"
        Me.lblBatchSiloMaterial8.Size = New System.Drawing.Size(126, 39)
        Me.lblBatchSiloMaterial8.TabIndex = 9
        Me.lblBatchSiloMaterial8.Text = "Raw Mats"
        Me.lblBatchSiloMaterial8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.BackColor = System.Drawing.Color.Transparent
        Me.Label48.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label48.Location = New System.Drawing.Point(54, 16)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(49, 23)
        Me.Label48.TabIndex = 8
        Me.Label48.Text = "Silo 1"
        '
        'lblBatchSiloWeight8
        '
        Me.lblBatchSiloWeight8.BackColor = System.Drawing.Color.Transparent
        Me.lblBatchSiloWeight8.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.lblBatchSiloWeight8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.lblBatchSiloWeight8.Location = New System.Drawing.Point(45, 125)
        Me.lblBatchSiloWeight8.Name = "lblBatchSiloWeight8"
        Me.lblBatchSiloWeight8.Size = New System.Drawing.Size(72, 25)
        Me.lblBatchSiloWeight8.TabIndex = 10
        Me.lblBatchSiloWeight8.Text = "0 KG"
        Me.lblBatchSiloWeight8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.Transparent
        Me.Panel12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel12.Controls.Add(Me.Panel13)
        Me.Panel12.Controls.Add(Me.lblBatchSiloWeight6)
        Me.Panel12.Location = New System.Drawing.Point(353, 187)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(157, 153)
        Me.Panel12.TabIndex = 16
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.Transparent
        Me.Panel13.BackgroundImage = Global.Automated_Feedmill_System.My.Resources.Resources.silo
        Me.Panel13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel13.Controls.Add(Me.lblBatchSiloMaterial6)
        Me.Panel13.Controls.Add(Me.Label34)
        Me.Panel13.Location = New System.Drawing.Point(0, 2)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(157, 121)
        Me.Panel13.TabIndex = 11
        '
        'lblBatchSiloMaterial6
        '
        Me.lblBatchSiloMaterial6.BackColor = System.Drawing.Color.Transparent
        Me.lblBatchSiloMaterial6.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.lblBatchSiloMaterial6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.lblBatchSiloMaterial6.Location = New System.Drawing.Point(13, 52)
        Me.lblBatchSiloMaterial6.Name = "lblBatchSiloMaterial6"
        Me.lblBatchSiloMaterial6.Size = New System.Drawing.Size(126, 39)
        Me.lblBatchSiloMaterial6.TabIndex = 9
        Me.lblBatchSiloMaterial6.Text = "Raw Mats"
        Me.lblBatchSiloMaterial6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.BackColor = System.Drawing.Color.Transparent
        Me.Label34.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label34.Location = New System.Drawing.Point(54, 16)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(49, 23)
        Me.Label34.TabIndex = 8
        Me.Label34.Text = "Silo 1"
        '
        'lblBatchSiloWeight6
        '
        Me.lblBatchSiloWeight6.BackColor = System.Drawing.Color.Transparent
        Me.lblBatchSiloWeight6.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.lblBatchSiloWeight6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.lblBatchSiloWeight6.Location = New System.Drawing.Point(45, 125)
        Me.lblBatchSiloWeight6.Name = "lblBatchSiloWeight6"
        Me.lblBatchSiloWeight6.Size = New System.Drawing.Size(72, 25)
        Me.lblBatchSiloWeight6.TabIndex = 10
        Me.lblBatchSiloWeight6.Text = "0 KG"
        Me.lblBatchSiloWeight6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel23
        '
        Me.Panel23.BackColor = System.Drawing.Color.Transparent
        Me.Panel23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel23.Controls.Add(Me.Panel24)
        Me.Panel23.Controls.Add(Me.lblBatchSiloWeight7)
        Me.Panel23.Location = New System.Drawing.Point(27, 346)
        Me.Panel23.Name = "Panel23"
        Me.Panel23.Size = New System.Drawing.Size(157, 153)
        Me.Panel23.TabIndex = 17
        '
        'Panel24
        '
        Me.Panel24.BackColor = System.Drawing.Color.Transparent
        Me.Panel24.BackgroundImage = Global.Automated_Feedmill_System.My.Resources.Resources.silo
        Me.Panel24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel24.Controls.Add(Me.lblBatchSiloMaterial7)
        Me.Panel24.Controls.Add(Me.Label51)
        Me.Panel24.Location = New System.Drawing.Point(0, 2)
        Me.Panel24.Name = "Panel24"
        Me.Panel24.Size = New System.Drawing.Size(157, 121)
        Me.Panel24.TabIndex = 11
        '
        'lblBatchSiloMaterial7
        '
        Me.lblBatchSiloMaterial7.BackColor = System.Drawing.Color.Transparent
        Me.lblBatchSiloMaterial7.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.lblBatchSiloMaterial7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.lblBatchSiloMaterial7.Location = New System.Drawing.Point(13, 52)
        Me.lblBatchSiloMaterial7.Name = "lblBatchSiloMaterial7"
        Me.lblBatchSiloMaterial7.Size = New System.Drawing.Size(126, 39)
        Me.lblBatchSiloMaterial7.TabIndex = 9
        Me.lblBatchSiloMaterial7.Text = "Raw Mats"
        Me.lblBatchSiloMaterial7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.BackColor = System.Drawing.Color.Transparent
        Me.Label51.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label51.Location = New System.Drawing.Point(54, 16)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(49, 23)
        Me.Label51.TabIndex = 8
        Me.Label51.Text = "Silo 1"
        '
        'lblBatchSiloWeight7
        '
        Me.lblBatchSiloWeight7.BackColor = System.Drawing.Color.Transparent
        Me.lblBatchSiloWeight7.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.lblBatchSiloWeight7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.lblBatchSiloWeight7.Location = New System.Drawing.Point(45, 125)
        Me.lblBatchSiloWeight7.Name = "lblBatchSiloWeight7"
        Me.lblBatchSiloWeight7.Size = New System.Drawing.Size(72, 25)
        Me.lblBatchSiloWeight7.TabIndex = 10
        Me.lblBatchSiloWeight7.Text = "0 KG"
        Me.lblBatchSiloWeight7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.Transparent
        Me.Panel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel10.Controls.Add(Me.Panel11)
        Me.Panel10.Controls.Add(Me.lblBatchSiloWeight3)
        Me.Panel10.Location = New System.Drawing.Point(353, 25)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(157, 153)
        Me.Panel10.TabIndex = 13
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.Transparent
        Me.Panel11.BackgroundImage = Global.Automated_Feedmill_System.My.Resources.Resources.silo
        Me.Panel11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel11.Controls.Add(Me.lblBatchSiloMaterial3)
        Me.Panel11.Controls.Add(Me.Label31)
        Me.Panel11.Location = New System.Drawing.Point(0, 2)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(157, 121)
        Me.Panel11.TabIndex = 11
        '
        'lblBatchSiloMaterial3
        '
        Me.lblBatchSiloMaterial3.BackColor = System.Drawing.Color.Transparent
        Me.lblBatchSiloMaterial3.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.lblBatchSiloMaterial3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.lblBatchSiloMaterial3.Location = New System.Drawing.Point(13, 52)
        Me.lblBatchSiloMaterial3.Name = "lblBatchSiloMaterial3"
        Me.lblBatchSiloMaterial3.Size = New System.Drawing.Size(126, 39)
        Me.lblBatchSiloMaterial3.TabIndex = 9
        Me.lblBatchSiloMaterial3.Text = "Raw Mats"
        Me.lblBatchSiloMaterial3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.Color.Transparent
        Me.Label31.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label31.Location = New System.Drawing.Point(54, 16)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(49, 23)
        Me.Label31.TabIndex = 8
        Me.Label31.Text = "Silo 1"
        '
        'lblBatchSiloWeight3
        '
        Me.lblBatchSiloWeight3.BackColor = System.Drawing.Color.Transparent
        Me.lblBatchSiloWeight3.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.lblBatchSiloWeight3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.lblBatchSiloWeight3.Location = New System.Drawing.Point(45, 125)
        Me.lblBatchSiloWeight3.Name = "lblBatchSiloWeight3"
        Me.lblBatchSiloWeight3.Size = New System.Drawing.Size(72, 25)
        Me.lblBatchSiloWeight3.TabIndex = 10
        Me.lblBatchSiloWeight3.Text = "0 KG"
        Me.lblBatchSiloWeight3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Transparent
        Me.Panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel7.Controls.Add(Me.Panel16)
        Me.Panel7.Controls.Add(Me.lblBatchSiloWeight1)
        Me.Panel7.Location = New System.Drawing.Point(27, 25)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(157, 153)
        Me.Panel7.TabIndex = 12
        '
        'Panel16
        '
        Me.Panel16.BackColor = System.Drawing.Color.Transparent
        Me.Panel16.BackgroundImage = Global.Automated_Feedmill_System.My.Resources.Resources.silo
        Me.Panel16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel16.Controls.Add(Me.lblBatchSiloMaterial1)
        Me.Panel16.Controls.Add(Me.Label44)
        Me.Panel16.Location = New System.Drawing.Point(0, 2)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(157, 121)
        Me.Panel16.TabIndex = 11
        '
        'lblBatchSiloMaterial1
        '
        Me.lblBatchSiloMaterial1.BackColor = System.Drawing.Color.Transparent
        Me.lblBatchSiloMaterial1.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.lblBatchSiloMaterial1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.lblBatchSiloMaterial1.Location = New System.Drawing.Point(13, 52)
        Me.lblBatchSiloMaterial1.Name = "lblBatchSiloMaterial1"
        Me.lblBatchSiloMaterial1.Size = New System.Drawing.Size(126, 39)
        Me.lblBatchSiloMaterial1.TabIndex = 9
        Me.lblBatchSiloMaterial1.Text = "Raw Mats"
        Me.lblBatchSiloMaterial1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.BackColor = System.Drawing.Color.Transparent
        Me.Label44.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label44.Location = New System.Drawing.Point(54, 16)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(49, 23)
        Me.Label44.TabIndex = 8
        Me.Label44.Text = "Silo 1"
        '
        'lblBatchSiloWeight1
        '
        Me.lblBatchSiloWeight1.BackColor = System.Drawing.Color.Transparent
        Me.lblBatchSiloWeight1.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.lblBatchSiloWeight1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.lblBatchSiloWeight1.Location = New System.Drawing.Point(45, 125)
        Me.lblBatchSiloWeight1.Name = "lblBatchSiloWeight1"
        Me.lblBatchSiloWeight1.Size = New System.Drawing.Size(72, 25)
        Me.lblBatchSiloWeight1.TabIndex = 10
        Me.lblBatchSiloWeight1.Text = "0 KG"
        Me.lblBatchSiloWeight1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.Transparent
        Me.Panel14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel14.Controls.Add(Me.Panel15)
        Me.Panel14.Controls.Add(Me.lblBatchSiloWeight5)
        Me.Panel14.Location = New System.Drawing.Point(190, 187)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(157, 153)
        Me.Panel14.TabIndex = 15
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.Color.Transparent
        Me.Panel15.BackgroundImage = Global.Automated_Feedmill_System.My.Resources.Resources.silo
        Me.Panel15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel15.Controls.Add(Me.lblBatchSiloMaterial5)
        Me.Panel15.Controls.Add(Me.Label37)
        Me.Panel15.Location = New System.Drawing.Point(0, 2)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(157, 121)
        Me.Panel15.TabIndex = 11
        '
        'lblBatchSiloMaterial5
        '
        Me.lblBatchSiloMaterial5.BackColor = System.Drawing.Color.Transparent
        Me.lblBatchSiloMaterial5.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.lblBatchSiloMaterial5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.lblBatchSiloMaterial5.Location = New System.Drawing.Point(13, 52)
        Me.lblBatchSiloMaterial5.Name = "lblBatchSiloMaterial5"
        Me.lblBatchSiloMaterial5.Size = New System.Drawing.Size(126, 39)
        Me.lblBatchSiloMaterial5.TabIndex = 9
        Me.lblBatchSiloMaterial5.Text = "Raw Mats"
        Me.lblBatchSiloMaterial5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.BackColor = System.Drawing.Color.Transparent
        Me.Label37.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label37.Location = New System.Drawing.Point(54, 16)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(49, 23)
        Me.Label37.TabIndex = 8
        Me.Label37.Text = "Silo 1"
        '
        'lblBatchSiloWeight5
        '
        Me.lblBatchSiloWeight5.BackColor = System.Drawing.Color.Transparent
        Me.lblBatchSiloWeight5.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.lblBatchSiloWeight5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.lblBatchSiloWeight5.Location = New System.Drawing.Point(45, 125)
        Me.lblBatchSiloWeight5.Name = "lblBatchSiloWeight5"
        Me.lblBatchSiloWeight5.Size = New System.Drawing.Size(72, 25)
        Me.lblBatchSiloWeight5.TabIndex = 10
        Me.lblBatchSiloWeight5.Text = "0 KG"
        Me.lblBatchSiloWeight5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel17
        '
        Me.Panel17.BackColor = System.Drawing.Color.Transparent
        Me.Panel17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel17.Controls.Add(Me.Panel18)
        Me.Panel17.Controls.Add(Me.lblBatchSiloWeight4)
        Me.Panel17.Location = New System.Drawing.Point(27, 187)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(157, 153)
        Me.Panel17.TabIndex = 14
        '
        'Panel18
        '
        Me.Panel18.BackColor = System.Drawing.Color.Transparent
        Me.Panel18.BackgroundImage = Global.Automated_Feedmill_System.My.Resources.Resources.silo
        Me.Panel18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel18.Controls.Add(Me.lblBatchSiloMaterial4)
        Me.Panel18.Controls.Add(Me.Label40)
        Me.Panel18.Location = New System.Drawing.Point(0, 2)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(157, 121)
        Me.Panel18.TabIndex = 11
        '
        'lblBatchSiloMaterial4
        '
        Me.lblBatchSiloMaterial4.BackColor = System.Drawing.Color.Transparent
        Me.lblBatchSiloMaterial4.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.lblBatchSiloMaterial4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.lblBatchSiloMaterial4.Location = New System.Drawing.Point(13, 52)
        Me.lblBatchSiloMaterial4.Name = "lblBatchSiloMaterial4"
        Me.lblBatchSiloMaterial4.Size = New System.Drawing.Size(126, 39)
        Me.lblBatchSiloMaterial4.TabIndex = 9
        Me.lblBatchSiloMaterial4.Text = "Raw Mats"
        Me.lblBatchSiloMaterial4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.BackColor = System.Drawing.Color.Transparent
        Me.Label40.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label40.Location = New System.Drawing.Point(54, 16)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(49, 23)
        Me.Label40.TabIndex = 8
        Me.Label40.Text = "Silo 1"
        '
        'lblBatchSiloWeight4
        '
        Me.lblBatchSiloWeight4.BackColor = System.Drawing.Color.Transparent
        Me.lblBatchSiloWeight4.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.lblBatchSiloWeight4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.lblBatchSiloWeight4.Location = New System.Drawing.Point(45, 125)
        Me.lblBatchSiloWeight4.Name = "lblBatchSiloWeight4"
        Me.lblBatchSiloWeight4.Size = New System.Drawing.Size(72, 25)
        Me.lblBatchSiloWeight4.TabIndex = 10
        Me.lblBatchSiloWeight4.Text = "0 KG"
        Me.lblBatchSiloWeight4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Transparent
        Me.Panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel8.Controls.Add(Me.Panel9)
        Me.Panel8.Controls.Add(Me.lblBatchSiloWeight2)
        Me.Panel8.Location = New System.Drawing.Point(190, 25)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(157, 153)
        Me.Panel8.TabIndex = 13
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.Transparent
        Me.Panel9.BackgroundImage = Global.Automated_Feedmill_System.My.Resources.Resources.silo
        Me.Panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel9.Controls.Add(Me.lblBatchSiloMaterial2)
        Me.Panel9.Controls.Add(Me.Label27)
        Me.Panel9.Location = New System.Drawing.Point(0, 2)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(157, 121)
        Me.Panel9.TabIndex = 11
        '
        'lblBatchSiloMaterial2
        '
        Me.lblBatchSiloMaterial2.BackColor = System.Drawing.Color.Transparent
        Me.lblBatchSiloMaterial2.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.lblBatchSiloMaterial2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.lblBatchSiloMaterial2.Location = New System.Drawing.Point(13, 52)
        Me.lblBatchSiloMaterial2.Name = "lblBatchSiloMaterial2"
        Me.lblBatchSiloMaterial2.Size = New System.Drawing.Size(126, 39)
        Me.lblBatchSiloMaterial2.TabIndex = 9
        Me.lblBatchSiloMaterial2.Text = "Raw Mats"
        Me.lblBatchSiloMaterial2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label27.Location = New System.Drawing.Point(54, 16)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(49, 23)
        Me.Label27.TabIndex = 8
        Me.Label27.Text = "Silo 1"
        '
        'lblBatchSiloWeight2
        '
        Me.lblBatchSiloWeight2.BackColor = System.Drawing.Color.Transparent
        Me.lblBatchSiloWeight2.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.lblBatchSiloWeight2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.lblBatchSiloWeight2.Location = New System.Drawing.Point(45, 125)
        Me.lblBatchSiloWeight2.Name = "lblBatchSiloWeight2"
        Me.lblBatchSiloWeight2.Size = New System.Drawing.Size(72, 25)
        Me.lblBatchSiloWeight2.TabIndex = 10
        Me.lblBatchSiloWeight2.Text = "0 KG"
        Me.lblBatchSiloWeight2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pnlReports
        '
        Me.pnlReports.Controls.Add(Me.Panel62)
        Me.pnlReports.Controls.Add(Me.Panel43)
        Me.pnlReports.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlReports.Location = New System.Drawing.Point(0, 94)
        Me.pnlReports.Name = "pnlReports"
        Me.pnlReports.Size = New System.Drawing.Size(791, 606)
        Me.pnlReports.TabIndex = 31
        '
        'Panel62
        '
        Me.Panel62.Controls.Add(Me.crviewr)
        Me.Panel62.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel62.Location = New System.Drawing.Point(0, 153)
        Me.Panel62.Name = "Panel62"
        Me.Panel62.Size = New System.Drawing.Size(791, 453)
        Me.Panel62.TabIndex = 1
        '
        'crviewr
        '
        Me.crviewr.ActiveViewIndex = -1
        Me.crviewr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crviewr.Cursor = System.Windows.Forms.Cursors.Default
        Me.crviewr.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crviewr.Location = New System.Drawing.Point(0, 0)
        Me.crviewr.Name = "crviewr"
        Me.crviewr.Size = New System.Drawing.Size(791, 453)
        Me.crviewr.TabIndex = 0
        Me.crviewr.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Panel43
        '
        Me.Panel43.Controls.Add(Me.pnlDate)
        Me.Panel43.Controls.Add(Me.pnlBatchID)
        Me.Panel43.Controls.Add(Me.Label78)
        Me.Panel43.Controls.Add(Me.Label68)
        Me.Panel43.Controls.Add(Me.chkBoxIndividual)
        Me.Panel43.Controls.Add(Me.chkReportsByDate)
        Me.Panel43.Controls.Add(Me.btnReportShow)
        Me.Panel43.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel43.Location = New System.Drawing.Point(0, 0)
        Me.Panel43.Name = "Panel43"
        Me.Panel43.Size = New System.Drawing.Size(791, 153)
        Me.Panel43.TabIndex = 0
        '
        'pnlDate
        '
        Me.pnlDate.Controls.Add(Me.dtpFrom)
        Me.pnlDate.Controls.Add(Me.dtpTo)
        Me.pnlDate.Controls.Add(Me.Label65)
        Me.pnlDate.Location = New System.Drawing.Point(26, 77)
        Me.pnlDate.Name = "pnlDate"
        Me.pnlDate.Size = New System.Drawing.Size(353, 58)
        Me.pnlDate.TabIndex = 14
        '
        'dtpFrom
        '
        Me.dtpFrom.BackColor = System.Drawing.Color.SeaGreen
        Me.dtpFrom.BorderRadius = 0
        Me.dtpFrom.ForeColor = System.Drawing.Color.White
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFrom.FormatCustom = ""
        Me.dtpFrom.Location = New System.Drawing.Point(3, 18)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(160, 36)
        Me.dtpFrom.TabIndex = 6
        Me.dtpFrom.Value = New Date(2019, 7, 6, 0, 0, 0, 0)
        '
        'dtpTo
        '
        Me.dtpTo.BackColor = System.Drawing.Color.SeaGreen
        Me.dtpTo.BorderRadius = 0
        Me.dtpTo.ForeColor = System.Drawing.Color.White
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTo.FormatCustom = ""
        Me.dtpTo.Location = New System.Drawing.Point(186, 18)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(160, 36)
        Me.dtpTo.TabIndex = 7
        Me.dtpTo.Value = New Date(2019, 7, 6, 0, 0, 0, 0)
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label65.Location = New System.Drawing.Point(166, 24)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(17, 24)
        Me.Label65.TabIndex = 8
        Me.Label65.Text = "-"
        '
        'pnlBatchID
        '
        Me.pnlBatchID.Controls.Add(Me.txtbReportBatchID)
        Me.pnlBatchID.Location = New System.Drawing.Point(26, 76)
        Me.pnlBatchID.Name = "pnlBatchID"
        Me.pnlBatchID.Size = New System.Drawing.Size(308, 58)
        Me.pnlBatchID.TabIndex = 15
        '
        'txtbReportBatchID
        '
        Me.txtbReportBatchID.BackColor = System.Drawing.Color.Silver
        Me.txtbReportBatchID.BackgroundImage = CType(resources.GetObject("txtbReportBatchID.BackgroundImage"), System.Drawing.Image)
        Me.txtbReportBatchID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.txtbReportBatchID.ForeColor = System.Drawing.Color.SeaGreen
        Me.txtbReportBatchID.Icon = CType(resources.GetObject("txtbReportBatchID.Icon"), System.Drawing.Image)
        Me.txtbReportBatchID.Location = New System.Drawing.Point(3, 6)
        Me.txtbReportBatchID.Name = "txtbReportBatchID"
        Me.txtbReportBatchID.Size = New System.Drawing.Size(213, 42)
        Me.txtbReportBatchID.TabIndex = 0
        Me.txtbReportBatchID.text = "Enter Batch ID"
        '
        'Label78
        '
        Me.Label78.AutoSize = True
        Me.Label78.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label78.Location = New System.Drawing.Point(65, 16)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(174, 20)
        Me.Label78.TabIndex = 13
        Me.Label78.Text = "Individual Batch Report"
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label68.Location = New System.Drawing.Point(65, 41)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(66, 20)
        Me.Label68.TabIndex = 12
        Me.Label68.Text = "By Date"
        '
        'chkBoxIndividual
        '
        Me.chkBoxIndividual.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.chkBoxIndividual.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.chkBoxIndividual.Checked = True
        Me.chkBoxIndividual.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.chkBoxIndividual.ForeColor = System.Drawing.Color.White
        Me.chkBoxIndividual.Location = New System.Drawing.Point(31, 16)
        Me.chkBoxIndividual.Name = "chkBoxIndividual"
        Me.chkBoxIndividual.Size = New System.Drawing.Size(20, 20)
        Me.chkBoxIndividual.TabIndex = 11
        '
        'chkReportsByDate
        '
        Me.chkReportsByDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.chkReportsByDate.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.chkReportsByDate.Checked = True
        Me.chkReportsByDate.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.chkReportsByDate.ForeColor = System.Drawing.Color.White
        Me.chkReportsByDate.Location = New System.Drawing.Point(31, 42)
        Me.chkReportsByDate.Name = "chkReportsByDate"
        Me.chkReportsByDate.Size = New System.Drawing.Size(20, 20)
        Me.chkReportsByDate.TabIndex = 10
        '
        'btnReportShow
        '
        Me.btnReportShow.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnReportShow.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnReportShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnReportShow.BorderRadius = 0
        Me.btnReportShow.ButtonText = "Show Report"
        Me.btnReportShow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReportShow.DisabledColor = System.Drawing.Color.Gray
        Me.btnReportShow.Iconcolor = System.Drawing.Color.Transparent
        Me.btnReportShow.Iconimage = CType(resources.GetObject("btnReportShow.Iconimage"), System.Drawing.Image)
        Me.btnReportShow.Iconimage_right = Nothing
        Me.btnReportShow.Iconimage_right_Selected = Nothing
        Me.btnReportShow.Iconimage_Selected = Nothing
        Me.btnReportShow.IconMarginLeft = 0
        Me.btnReportShow.IconMarginRight = 0
        Me.btnReportShow.IconRightVisible = True
        Me.btnReportShow.IconRightZoom = 0R
        Me.btnReportShow.IconVisible = True
        Me.btnReportShow.IconZoom = 90.0R
        Me.btnReportShow.IsTab = False
        Me.btnReportShow.Location = New System.Drawing.Point(503, 12)
        Me.btnReportShow.Name = "btnReportShow"
        Me.btnReportShow.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnReportShow.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnReportShow.OnHoverTextColor = System.Drawing.Color.White
        Me.btnReportShow.selected = False
        Me.btnReportShow.Size = New System.Drawing.Size(241, 48)
        Me.btnReportShow.TabIndex = 5
        Me.btnReportShow.Text = "Show Report"
        Me.btnReportShow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReportShow.Textcolor = System.Drawing.Color.White
        Me.btnReportShow.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'pnlWelcome
        '
        Me.pnlWelcome.Controls.Add(Me.Panel65)
        Me.pnlWelcome.Controls.Add(Me.lblTextCon)
        Me.pnlWelcome.Controls.Add(Me.lblName)
        Me.pnlWelcome.Controls.Add(Me.Panel64)
        Me.pnlWelcome.Controls.Add(Me.pnlPLC)
        Me.pnlWelcome.Controls.Add(Me.Label59)
        Me.pnlWelcome.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlWelcome.Location = New System.Drawing.Point(0, 94)
        Me.pnlWelcome.Name = "pnlWelcome"
        Me.pnlWelcome.Size = New System.Drawing.Size(791, 606)
        Me.pnlWelcome.TabIndex = 31
        '
        'Panel65
        '
        Me.Panel65.Controls.Add(Me.lblConWeightLiquid)
        Me.Panel65.Controls.Add(Me.Label87)
        Me.Panel65.Controls.Add(Me.pbWeighingLiquid)
        Me.Panel65.Location = New System.Drawing.Point(501, 369)
        Me.Panel65.Name = "Panel65"
        Me.Panel65.Size = New System.Drawing.Size(200, 200)
        Me.Panel65.TabIndex = 16
        '
        'lblConWeightLiquid
        '
        Me.lblConWeightLiquid.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConWeightLiquid.Location = New System.Drawing.Point(18, 135)
        Me.lblConWeightLiquid.Name = "lblConWeightLiquid"
        Me.lblConWeightLiquid.Size = New System.Drawing.Size(168, 30)
        Me.lblConWeightLiquid.TabIndex = 12
        Me.lblConWeightLiquid.Text = "Connecting"
        Me.lblConWeightLiquid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label87
        '
        Me.Label87.AutoSize = True
        Me.Label87.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label87.Location = New System.Drawing.Point(27, 21)
        Me.Label87.Name = "Label87"
        Me.Label87.Size = New System.Drawing.Size(152, 30)
        Me.Label87.TabIndex = 11
        Me.Label87.Text = "LIQUID SCALE"
        '
        'pbWeighingLiquid
        '
        Me.pbWeighingLiquid.Image = Global.Automated_Feedmill_System.My.Resources.Resources.loading
        Me.pbWeighingLiquid.Location = New System.Drawing.Point(67, 57)
        Me.pbWeighingLiquid.Name = "pbWeighingLiquid"
        Me.pbWeighingLiquid.Size = New System.Drawing.Size(70, 70)
        Me.pbWeighingLiquid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbWeighingLiquid.TabIndex = 9
        Me.pbWeighingLiquid.TabStop = False
        '
        'lblTextCon
        '
        Me.lblTextCon.AutoSize = True
        Me.lblTextCon.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblTextCon.Font = New System.Drawing.Font("Segoe UI Semilight", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTextCon.ForeColor = System.Drawing.Color.Black
        Me.lblTextCon.Location = New System.Drawing.Point(240, 175)
        Me.lblTextCon.Name = "lblTextCon"
        Me.lblTextCon.Size = New System.Drawing.Size(304, 28)
        Me.lblTextCon.TabIndex = 17
        Me.lblTextCon.Text = "Wait for PLC and Scales to Connect"
        '
        'lblName
        '
        Me.lblName.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblName.ForeColor = System.Drawing.Color.Black
        Me.lblName.Location = New System.Drawing.Point(170, 77)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(428, 37)
        Me.lblName.TabIndex = 16
        Me.lblName.Text = "John Doe"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel64
        '
        Me.Panel64.Controls.Add(Me.lblConWeight)
        Me.Panel64.Controls.Add(Me.Label75)
        Me.Panel64.Controls.Add(Me.pbWeighing)
        Me.Panel64.Location = New System.Drawing.Point(294, 368)
        Me.Panel64.Name = "Panel64"
        Me.Panel64.Size = New System.Drawing.Size(200, 200)
        Me.Panel64.TabIndex = 15
        '
        'lblConWeight
        '
        Me.lblConWeight.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConWeight.Location = New System.Drawing.Point(18, 135)
        Me.lblConWeight.Name = "lblConWeight"
        Me.lblConWeight.Size = New System.Drawing.Size(168, 30)
        Me.lblConWeight.TabIndex = 12
        Me.lblConWeight.Text = "Connecting"
        Me.lblConWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label75
        '
        Me.Label75.AutoSize = True
        Me.Label75.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label75.Location = New System.Drawing.Point(7, 20)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(187, 30)
        Me.Label75.TabIndex = 11
        Me.Label75.Text = "BATCHING SCALE"
        '
        'pbWeighing
        '
        Me.pbWeighing.Image = Global.Automated_Feedmill_System.My.Resources.Resources.loading
        Me.pbWeighing.Location = New System.Drawing.Point(67, 57)
        Me.pbWeighing.Name = "pbWeighing"
        Me.pbWeighing.Size = New System.Drawing.Size(70, 70)
        Me.pbWeighing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbWeighing.TabIndex = 9
        Me.pbWeighing.TabStop = False
        '
        'pnlPLC
        '
        Me.pnlPLC.Controls.Add(Me.lblConPLC)
        Me.pnlPLC.Controls.Add(Me.Label61)
        Me.pnlPLC.Controls.Add(Me.pbPLC)
        Me.pnlPLC.Location = New System.Drawing.Point(89, 369)
        Me.pnlPLC.Name = "pnlPLC"
        Me.pnlPLC.Size = New System.Drawing.Size(200, 200)
        Me.pnlPLC.TabIndex = 14
        '
        'lblConPLC
        '
        Me.lblConPLC.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConPLC.Location = New System.Drawing.Point(18, 135)
        Me.lblConPLC.Name = "lblConPLC"
        Me.lblConPLC.Size = New System.Drawing.Size(168, 30)
        Me.lblConPLC.TabIndex = 12
        Me.lblConPLC.Text = "Connecting"
        Me.lblConPLC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label61.Location = New System.Drawing.Point(78, 20)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(49, 30)
        Me.Label61.TabIndex = 11
        Me.Label61.Text = "PLC"
        '
        'pbPLC
        '
        Me.pbPLC.Image = Global.Automated_Feedmill_System.My.Resources.Resources.loading
        Me.pbPLC.Location = New System.Drawing.Point(67, 57)
        Me.pbPLC.Name = "pbPLC"
        Me.pbPLC.Size = New System.Drawing.Size(70, 70)
        Me.pbPLC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbPLC.TabIndex = 9
        Me.pbPLC.TabStop = False
        '
        'Label59
        '
        Me.Label59.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label59.ForeColor = System.Drawing.Color.Black
        Me.Label59.Location = New System.Drawing.Point(169, 28)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(428, 37)
        Me.Label59.TabIndex = 8
        Me.Label59.Text = "Welcome"
        Me.Label59.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pnlUsers
        '
        Me.pnlUsers.Controls.Add(Me.btnUserDelete)
        Me.pnlUsers.Controls.Add(Me.btnUserEdit)
        Me.pnlUsers.Controls.Add(Me.btnUserAdd)
        Me.pnlUsers.Controls.Add(Me.lblUserID)
        Me.pnlUsers.Controls.Add(Me.Label57)
        Me.pnlUsers.Controls.Add(Me.cmbUserPosition)
        Me.pnlUsers.Controls.Add(Me.cmbUserStatus)
        Me.pnlUsers.Controls.Add(Me.Label56)
        Me.pnlUsers.Controls.Add(Me.Label55)
        Me.pnlUsers.Controls.Add(Me.Label49)
        Me.pnlUsers.Controls.Add(Me.txtbUserPassword)
        Me.pnlUsers.Controls.Add(Me.Label43)
        Me.pnlUsers.Controls.Add(Me.txtbUserUsername)
        Me.pnlUsers.Controls.Add(Me.Label39)
        Me.pnlUsers.Controls.Add(Me.txtbUserLName)
        Me.pnlUsers.Controls.Add(Me.Label35)
        Me.pnlUsers.Controls.Add(Me.txtbUserMName)
        Me.pnlUsers.Controls.Add(Me.Label30)
        Me.pnlUsers.Controls.Add(Me.txtbUserFName)
        Me.pnlUsers.Controls.Add(Me.dgvUsers)
        Me.pnlUsers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlUsers.Location = New System.Drawing.Point(0, 94)
        Me.pnlUsers.Name = "pnlUsers"
        Me.pnlUsers.Size = New System.Drawing.Size(791, 606)
        Me.pnlUsers.TabIndex = 0
        '
        'btnUserDelete
        '
        Me.btnUserDelete.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnUserDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btnUserDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUserDelete.BorderRadius = 0
        Me.btnUserDelete.ButtonText = "Delete"
        Me.btnUserDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUserDelete.DisabledColor = System.Drawing.Color.Gray
        Me.btnUserDelete.Iconcolor = System.Drawing.Color.Transparent
        Me.btnUserDelete.Iconimage = Global.Automated_Feedmill_System.My.Resources.Resources.Trash_Can_96px
        Me.btnUserDelete.Iconimage_right = Nothing
        Me.btnUserDelete.Iconimage_right_Selected = Nothing
        Me.btnUserDelete.Iconimage_Selected = Nothing
        Me.btnUserDelete.IconMarginLeft = 0
        Me.btnUserDelete.IconMarginRight = 0
        Me.btnUserDelete.IconRightVisible = True
        Me.btnUserDelete.IconRightZoom = 0R
        Me.btnUserDelete.IconVisible = True
        Me.btnUserDelete.IconZoom = 50.0R
        Me.btnUserDelete.IsTab = False
        Me.btnUserDelete.Location = New System.Drawing.Point(506, 171)
        Me.btnUserDelete.Name = "btnUserDelete"
        Me.btnUserDelete.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btnUserDelete.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnUserDelete.OnHoverTextColor = System.Drawing.Color.White
        Me.btnUserDelete.selected = False
        Me.btnUserDelete.Size = New System.Drawing.Size(120, 48)
        Me.btnUserDelete.TabIndex = 39
        Me.btnUserDelete.Text = "Delete"
        Me.btnUserDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnUserDelete.Textcolor = System.Drawing.Color.White
        Me.btnUserDelete.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnUserEdit
        '
        Me.btnUserEdit.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnUserEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btnUserEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUserEdit.BorderRadius = 0
        Me.btnUserEdit.ButtonText = "Edit"
        Me.btnUserEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUserEdit.DisabledColor = System.Drawing.Color.Gray
        Me.btnUserEdit.Iconcolor = System.Drawing.Color.Transparent
        Me.btnUserEdit.Iconimage = Global.Automated_Feedmill_System.My.Resources.Resources.Edit_96px
        Me.btnUserEdit.Iconimage_right = Nothing
        Me.btnUserEdit.Iconimage_right_Selected = Nothing
        Me.btnUserEdit.Iconimage_Selected = Nothing
        Me.btnUserEdit.IconMarginLeft = 0
        Me.btnUserEdit.IconMarginRight = 0
        Me.btnUserEdit.IconRightVisible = True
        Me.btnUserEdit.IconRightZoom = 0R
        Me.btnUserEdit.IconVisible = True
        Me.btnUserEdit.IconZoom = 50.0R
        Me.btnUserEdit.IsTab = False
        Me.btnUserEdit.Location = New System.Drawing.Point(506, 117)
        Me.btnUserEdit.Name = "btnUserEdit"
        Me.btnUserEdit.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btnUserEdit.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnUserEdit.OnHoverTextColor = System.Drawing.Color.White
        Me.btnUserEdit.selected = False
        Me.btnUserEdit.Size = New System.Drawing.Size(120, 48)
        Me.btnUserEdit.TabIndex = 38
        Me.btnUserEdit.Text = "Edit"
        Me.btnUserEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnUserEdit.Textcolor = System.Drawing.Color.White
        Me.btnUserEdit.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnUserAdd
        '
        Me.btnUserAdd.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnUserAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btnUserAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUserAdd.BorderRadius = 0
        Me.btnUserAdd.ButtonText = "Add"
        Me.btnUserAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUserAdd.DisabledColor = System.Drawing.Color.Gray
        Me.btnUserAdd.Iconcolor = System.Drawing.Color.Transparent
        Me.btnUserAdd.Iconimage = Global.Automated_Feedmill_System.My.Resources.Resources.Save_96px
        Me.btnUserAdd.Iconimage_right = Nothing
        Me.btnUserAdd.Iconimage_right_Selected = Nothing
        Me.btnUserAdd.Iconimage_Selected = Nothing
        Me.btnUserAdd.IconMarginLeft = 0
        Me.btnUserAdd.IconMarginRight = 0
        Me.btnUserAdd.IconRightVisible = True
        Me.btnUserAdd.IconRightZoom = 0R
        Me.btnUserAdd.IconVisible = True
        Me.btnUserAdd.IconZoom = 50.0R
        Me.btnUserAdd.IsTab = False
        Me.btnUserAdd.Location = New System.Drawing.Point(506, 63)
        Me.btnUserAdd.Name = "btnUserAdd"
        Me.btnUserAdd.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btnUserAdd.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnUserAdd.OnHoverTextColor = System.Drawing.Color.White
        Me.btnUserAdd.selected = False
        Me.btnUserAdd.Size = New System.Drawing.Size(120, 48)
        Me.btnUserAdd.TabIndex = 37
        Me.btnUserAdd.Text = "Add"
        Me.btnUserAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnUserAdd.Textcolor = System.Drawing.Color.White
        Me.btnUserAdd.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'lblUserID
        '
        Me.lblUserID.AutoSize = True
        Me.lblUserID.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserID.Location = New System.Drawing.Point(198, 26)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(19, 21)
        Me.lblUserID.TabIndex = 16
        Me.lblUserID.Text = "0"
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label57.Location = New System.Drawing.Point(130, 26)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(72, 21)
        Me.Label57.TabIndex = 15
        Me.Label57.Text = "User ID : "
        '
        'cmbUserPosition
        '
        Me.cmbUserPosition.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUserPosition.FormattingEnabled = True
        Me.cmbUserPosition.Items.AddRange(New Object() {"Administrator", "Operator", "Clerk"})
        Me.cmbUserPosition.Location = New System.Drawing.Point(245, 280)
        Me.cmbUserPosition.Name = "cmbUserPosition"
        Me.cmbUserPosition.Size = New System.Drawing.Size(210, 29)
        Me.cmbUserPosition.TabIndex = 14
        Me.cmbUserPosition.Text = "Select Position"
        '
        'cmbUserStatus
        '
        Me.cmbUserStatus.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUserStatus.FormattingEnabled = True
        Me.cmbUserStatus.Items.AddRange(New Object() {"Activated", "Deactivated"})
        Me.cmbUserStatus.Location = New System.Drawing.Point(245, 244)
        Me.cmbUserStatus.Name = "cmbUserStatus"
        Me.cmbUserStatus.Size = New System.Drawing.Size(210, 29)
        Me.cmbUserStatus.TabIndex = 13
        Me.cmbUserStatus.Text = "Select Status"
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label56.Location = New System.Drawing.Point(130, 285)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(76, 21)
        Me.Label56.TabIndex = 12
        Me.Label56.Text = "Position : "
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.Location = New System.Drawing.Point(130, 248)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(63, 21)
        Me.Label55.TabIndex = 11
        Me.Label55.Text = "Status : "
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.Location = New System.Drawing.Point(130, 211)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(87, 21)
        Me.Label49.TabIndex = 10
        Me.Label49.Text = "Password : "
        '
        'txtbUserPassword
        '
        Me.txtbUserPassword.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbUserPassword.Location = New System.Drawing.Point(244, 208)
        Me.txtbUserPassword.Name = "txtbUserPassword"
        Me.txtbUserPassword.Size = New System.Drawing.Size(210, 29)
        Me.txtbUserPassword.TabIndex = 9
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(130, 176)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(92, 21)
        Me.Label43.TabIndex = 8
        Me.Label43.Text = "Username : "
        '
        'txtbUserUsername
        '
        Me.txtbUserUsername.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbUserUsername.Location = New System.Drawing.Point(244, 172)
        Me.txtbUserUsername.Name = "txtbUserUsername"
        Me.txtbUserUsername.Size = New System.Drawing.Size(210, 29)
        Me.txtbUserUsername.TabIndex = 7
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(130, 138)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(91, 21)
        Me.Label39.TabIndex = 6
        Me.Label39.Text = "Last Name :"
        '
        'txtbUserLName
        '
        Me.txtbUserLName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbUserLName.Location = New System.Drawing.Point(245, 136)
        Me.txtbUserLName.Name = "txtbUserLName"
        Me.txtbUserLName.Size = New System.Drawing.Size(210, 29)
        Me.txtbUserLName.TabIndex = 5
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(130, 104)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(111, 21)
        Me.Label35.TabIndex = 4
        Me.Label35.Text = "Middle Name :"
        '
        'txtbUserMName
        '
        Me.txtbUserMName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbUserMName.Location = New System.Drawing.Point(245, 100)
        Me.txtbUserMName.Name = "txtbUserMName"
        Me.txtbUserMName.Size = New System.Drawing.Size(210, 29)
        Me.txtbUserMName.TabIndex = 3
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(130, 68)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(97, 21)
        Me.Label30.TabIndex = 2
        Me.Label30.Text = "First Name : "
        '
        'txtbUserFName
        '
        Me.txtbUserFName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbUserFName.Location = New System.Drawing.Point(245, 64)
        Me.txtbUserFName.Name = "txtbUserFName"
        Me.txtbUserFName.Size = New System.Drawing.Size(210, 29)
        Me.txtbUserFName.TabIndex = 1
        '
        'dgvUsers
        '
        Me.dgvUsers.AllowUserToAddRows = False
        Me.dgvUsers.AllowUserToDeleteRows = False
        Me.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsers.Location = New System.Drawing.Point(134, 350)
        Me.dgvUsers.Name = "dgvUsers"
        Me.dgvUsers.ReadOnly = True
        Me.dgvUsers.Size = New System.Drawing.Size(492, 209)
        Me.dgvUsers.TabIndex = 0
        '
        'pnlSiloSettings
        '
        Me.pnlSiloSettings.Controls.Add(Me.lblSiloSetNo)
        Me.pnlSiloSettings.Controls.Add(Me.btnSiloSetDelete)
        Me.pnlSiloSettings.Controls.Add(Me.btnSiloSetEdit)
        Me.pnlSiloSettings.Controls.Add(Me.btnSiloSetAdd)
        Me.pnlSiloSettings.Controls.Add(Me.dgvSiloSettings)
        Me.pnlSiloSettings.Controls.Add(Me.Label73)
        Me.pnlSiloSettings.Controls.Add(Me.txtbSiloSetName)
        Me.pnlSiloSettings.Controls.Add(Me.Label74)
        Me.pnlSiloSettings.Controls.Add(Me.Panel44)
        Me.pnlSiloSettings.Controls.Add(Me.Panel46)
        Me.pnlSiloSettings.Controls.Add(Me.Panel48)
        Me.pnlSiloSettings.Controls.Add(Me.Panel50)
        Me.pnlSiloSettings.Controls.Add(Me.Panel52)
        Me.pnlSiloSettings.Controls.Add(Me.Panel54)
        Me.pnlSiloSettings.Controls.Add(Me.Panel56)
        Me.pnlSiloSettings.Controls.Add(Me.Panel58)
        Me.pnlSiloSettings.Controls.Add(Me.Panel60)
        Me.pnlSiloSettings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlSiloSettings.Location = New System.Drawing.Point(0, 94)
        Me.pnlSiloSettings.Name = "pnlSiloSettings"
        Me.pnlSiloSettings.Size = New System.Drawing.Size(791, 606)
        Me.pnlSiloSettings.TabIndex = 37
        '
        'lblSiloSetNo
        '
        Me.lblSiloSetNo.AutoSize = True
        Me.lblSiloSetNo.BackColor = System.Drawing.Color.Transparent
        Me.lblSiloSetNo.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblSiloSetNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.lblSiloSetNo.Location = New System.Drawing.Point(640, 104)
        Me.lblSiloSetNo.Name = "lblSiloSetNo"
        Me.lblSiloSetNo.Size = New System.Drawing.Size(17, 20)
        Me.lblSiloSetNo.TabIndex = 37
        Me.lblSiloSetNo.Text = "0"
        '
        'btnSiloSetDelete
        '
        Me.btnSiloSetDelete.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnSiloSetDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btnSiloSetDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSiloSetDelete.BorderRadius = 0
        Me.btnSiloSetDelete.ButtonText = "Delete"
        Me.btnSiloSetDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSiloSetDelete.DisabledColor = System.Drawing.Color.Gray
        Me.btnSiloSetDelete.Iconcolor = System.Drawing.Color.Transparent
        Me.btnSiloSetDelete.Iconimage = Global.Automated_Feedmill_System.My.Resources.Resources.Trash_Can_96px
        Me.btnSiloSetDelete.Iconimage_right = Nothing
        Me.btnSiloSetDelete.Iconimage_right_Selected = Nothing
        Me.btnSiloSetDelete.Iconimage_Selected = Nothing
        Me.btnSiloSetDelete.IconMarginLeft = 0
        Me.btnSiloSetDelete.IconMarginRight = 0
        Me.btnSiloSetDelete.IconRightVisible = True
        Me.btnSiloSetDelete.IconRightZoom = 0R
        Me.btnSiloSetDelete.IconVisible = True
        Me.btnSiloSetDelete.IconZoom = 50.0R
        Me.btnSiloSetDelete.IsTab = False
        Me.btnSiloSetDelete.Location = New System.Drawing.Point(519, 252)
        Me.btnSiloSetDelete.Name = "btnSiloSetDelete"
        Me.btnSiloSetDelete.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btnSiloSetDelete.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnSiloSetDelete.OnHoverTextColor = System.Drawing.Color.White
        Me.btnSiloSetDelete.selected = False
        Me.btnSiloSetDelete.Size = New System.Drawing.Size(120, 48)
        Me.btnSiloSetDelete.TabIndex = 36
        Me.btnSiloSetDelete.Text = "Delete"
        Me.btnSiloSetDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnSiloSetDelete.Textcolor = System.Drawing.Color.White
        Me.btnSiloSetDelete.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnSiloSetEdit
        '
        Me.btnSiloSetEdit.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnSiloSetEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btnSiloSetEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSiloSetEdit.BorderRadius = 0
        Me.btnSiloSetEdit.ButtonText = "Edit"
        Me.btnSiloSetEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSiloSetEdit.DisabledColor = System.Drawing.Color.Gray
        Me.btnSiloSetEdit.Iconcolor = System.Drawing.Color.Transparent
        Me.btnSiloSetEdit.Iconimage = Global.Automated_Feedmill_System.My.Resources.Resources.Edit_96px
        Me.btnSiloSetEdit.Iconimage_right = Nothing
        Me.btnSiloSetEdit.Iconimage_right_Selected = Nothing
        Me.btnSiloSetEdit.Iconimage_Selected = Nothing
        Me.btnSiloSetEdit.IconMarginLeft = 0
        Me.btnSiloSetEdit.IconMarginRight = 0
        Me.btnSiloSetEdit.IconRightVisible = True
        Me.btnSiloSetEdit.IconRightZoom = 0R
        Me.btnSiloSetEdit.IconVisible = True
        Me.btnSiloSetEdit.IconZoom = 50.0R
        Me.btnSiloSetEdit.IsTab = False
        Me.btnSiloSetEdit.Location = New System.Drawing.Point(519, 198)
        Me.btnSiloSetEdit.Name = "btnSiloSetEdit"
        Me.btnSiloSetEdit.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btnSiloSetEdit.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnSiloSetEdit.OnHoverTextColor = System.Drawing.Color.White
        Me.btnSiloSetEdit.selected = False
        Me.btnSiloSetEdit.Size = New System.Drawing.Size(120, 48)
        Me.btnSiloSetEdit.TabIndex = 35
        Me.btnSiloSetEdit.Text = "Edit"
        Me.btnSiloSetEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnSiloSetEdit.Textcolor = System.Drawing.Color.White
        Me.btnSiloSetEdit.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnSiloSetAdd
        '
        Me.btnSiloSetAdd.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnSiloSetAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btnSiloSetAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSiloSetAdd.BorderRadius = 0
        Me.btnSiloSetAdd.ButtonText = "Add"
        Me.btnSiloSetAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSiloSetAdd.DisabledColor = System.Drawing.Color.Gray
        Me.btnSiloSetAdd.Iconcolor = System.Drawing.Color.Transparent
        Me.btnSiloSetAdd.Iconimage = Global.Automated_Feedmill_System.My.Resources.Resources.Save_96px
        Me.btnSiloSetAdd.Iconimage_right = Nothing
        Me.btnSiloSetAdd.Iconimage_right_Selected = Nothing
        Me.btnSiloSetAdd.Iconimage_Selected = Nothing
        Me.btnSiloSetAdd.IconMarginLeft = 0
        Me.btnSiloSetAdd.IconMarginRight = 0
        Me.btnSiloSetAdd.IconRightVisible = True
        Me.btnSiloSetAdd.IconRightZoom = 0R
        Me.btnSiloSetAdd.IconVisible = True
        Me.btnSiloSetAdd.IconZoom = 50.0R
        Me.btnSiloSetAdd.IsTab = False
        Me.btnSiloSetAdd.Location = New System.Drawing.Point(519, 144)
        Me.btnSiloSetAdd.Name = "btnSiloSetAdd"
        Me.btnSiloSetAdd.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btnSiloSetAdd.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnSiloSetAdd.OnHoverTextColor = System.Drawing.Color.White
        Me.btnSiloSetAdd.selected = False
        Me.btnSiloSetAdd.Size = New System.Drawing.Size(120, 48)
        Me.btnSiloSetAdd.TabIndex = 34
        Me.btnSiloSetAdd.Text = "Add"
        Me.btnSiloSetAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnSiloSetAdd.Textcolor = System.Drawing.Color.White
        Me.btnSiloSetAdd.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'dgvSiloSettings
        '
        Me.dgvSiloSettings.AllowUserToAddRows = False
        Me.dgvSiloSettings.AllowUserToDeleteRows = False
        Me.dgvSiloSettings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSiloSettings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSiloSettings.Location = New System.Drawing.Point(519, 319)
        Me.dgvSiloSettings.Name = "dgvSiloSettings"
        Me.dgvSiloSettings.ReadOnly = True
        Me.dgvSiloSettings.Size = New System.Drawing.Size(240, 198)
        Me.dgvSiloSettings.TabIndex = 33
        '
        'Label73
        '
        Me.Label73.AutoSize = True
        Me.Label73.BackColor = System.Drawing.Color.Transparent
        Me.Label73.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label73.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label73.Location = New System.Drawing.Point(519, 104)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(119, 20)
        Me.Label73.TabIndex = 31
        Me.Label73.Text = "Silo Setting No :"
        '
        'txtbSiloSetName
        '
        Me.txtbSiloSetName.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbSiloSetName.Location = New System.Drawing.Point(519, 69)
        Me.txtbSiloSetName.Name = "txtbSiloSetName"
        Me.txtbSiloSetName.Size = New System.Drawing.Size(200, 27)
        Me.txtbSiloSetName.TabIndex = 30
        '
        'Label74
        '
        Me.Label74.AutoSize = True
        Me.Label74.BackColor = System.Drawing.Color.Transparent
        Me.Label74.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label74.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label74.Location = New System.Drawing.Point(519, 41)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(135, 20)
        Me.Label74.TabIndex = 29
        Me.Label74.Text = "Silo Setting Name:"
        '
        'Panel44
        '
        Me.Panel44.BackColor = System.Drawing.Color.Transparent
        Me.Panel44.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel44.Controls.Add(Me.Panel45)
        Me.Panel44.Controls.Add(Me.txtbSiloSetSilo9)
        Me.Panel44.Location = New System.Drawing.Point(340, 363)
        Me.Panel44.Name = "Panel44"
        Me.Panel44.Size = New System.Drawing.Size(157, 153)
        Me.Panel44.TabIndex = 28
        '
        'Panel45
        '
        Me.Panel45.BackColor = System.Drawing.Color.Transparent
        Me.Panel45.BackgroundImage = Global.Automated_Feedmill_System.My.Resources.Resources.silo
        Me.Panel45.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel45.Controls.Add(Me.Label76)
        Me.Panel45.Controls.Add(Me.Label77)
        Me.Panel45.Location = New System.Drawing.Point(0, 2)
        Me.Panel45.Name = "Panel45"
        Me.Panel45.Size = New System.Drawing.Size(157, 121)
        Me.Panel45.TabIndex = 11
        '
        'Label76
        '
        Me.Label76.BackColor = System.Drawing.Color.Transparent
        Me.Label76.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.Label76.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label76.Location = New System.Drawing.Point(13, 52)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(126, 39)
        Me.Label76.TabIndex = 9
        Me.Label76.Text = "Raw Mats"
        Me.Label76.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label77
        '
        Me.Label77.AutoSize = True
        Me.Label77.BackColor = System.Drawing.Color.Transparent
        Me.Label77.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label77.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label77.Location = New System.Drawing.Point(54, 16)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(51, 23)
        Me.Label77.TabIndex = 8
        Me.Label77.Text = "Silo 9"
        '
        'txtbSiloSetSilo9
        '
        Me.txtbSiloSetSilo9.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbSiloSetSilo9.Location = New System.Drawing.Point(29, 124)
        Me.txtbSiloSetSilo9.Name = "txtbSiloSetSilo9"
        Me.txtbSiloSetSilo9.Size = New System.Drawing.Size(100, 27)
        Me.txtbSiloSetSilo9.TabIndex = 20
        '
        'Panel46
        '
        Me.Panel46.BackColor = System.Drawing.Color.Transparent
        Me.Panel46.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel46.Controls.Add(Me.Panel47)
        Me.Panel46.Controls.Add(Me.txtbSiloSetSilo8)
        Me.Panel46.Location = New System.Drawing.Point(177, 363)
        Me.Panel46.Name = "Panel46"
        Me.Panel46.Size = New System.Drawing.Size(157, 153)
        Me.Panel46.TabIndex = 27
        '
        'Panel47
        '
        Me.Panel47.BackColor = System.Drawing.Color.Transparent
        Me.Panel47.BackgroundImage = Global.Automated_Feedmill_System.My.Resources.Resources.silo
        Me.Panel47.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel47.Controls.Add(Me.Label79)
        Me.Panel47.Controls.Add(Me.Label80)
        Me.Panel47.Location = New System.Drawing.Point(0, 2)
        Me.Panel47.Name = "Panel47"
        Me.Panel47.Size = New System.Drawing.Size(157, 121)
        Me.Panel47.TabIndex = 11
        '
        'Label79
        '
        Me.Label79.BackColor = System.Drawing.Color.Transparent
        Me.Label79.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.Label79.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label79.Location = New System.Drawing.Point(13, 52)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(126, 39)
        Me.Label79.TabIndex = 9
        Me.Label79.Text = "Raw Mats"
        Me.Label79.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label80
        '
        Me.Label80.AutoSize = True
        Me.Label80.BackColor = System.Drawing.Color.Transparent
        Me.Label80.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label80.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label80.Location = New System.Drawing.Point(54, 16)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(51, 23)
        Me.Label80.TabIndex = 8
        Me.Label80.Text = "Silo 8"
        '
        'txtbSiloSetSilo8
        '
        Me.txtbSiloSetSilo8.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbSiloSetSilo8.Location = New System.Drawing.Point(28, 124)
        Me.txtbSiloSetSilo8.Name = "txtbSiloSetSilo8"
        Me.txtbSiloSetSilo8.Size = New System.Drawing.Size(100, 27)
        Me.txtbSiloSetSilo8.TabIndex = 18
        '
        'Panel48
        '
        Me.Panel48.BackColor = System.Drawing.Color.Transparent
        Me.Panel48.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel48.Controls.Add(Me.txtbSiloSetSilo6)
        Me.Panel48.Controls.Add(Me.Panel49)
        Me.Panel48.Location = New System.Drawing.Point(340, 204)
        Me.Panel48.Name = "Panel48"
        Me.Panel48.Size = New System.Drawing.Size(157, 153)
        Me.Panel48.TabIndex = 25
        '
        'txtbSiloSetSilo6
        '
        Me.txtbSiloSetSilo6.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbSiloSetSilo6.Location = New System.Drawing.Point(29, 124)
        Me.txtbSiloSetSilo6.Name = "txtbSiloSetSilo6"
        Me.txtbSiloSetSilo6.Size = New System.Drawing.Size(100, 27)
        Me.txtbSiloSetSilo6.TabIndex = 16
        '
        'Panel49
        '
        Me.Panel49.BackColor = System.Drawing.Color.Transparent
        Me.Panel49.BackgroundImage = Global.Automated_Feedmill_System.My.Resources.Resources.silo
        Me.Panel49.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel49.Controls.Add(Me.Label82)
        Me.Panel49.Controls.Add(Me.Label83)
        Me.Panel49.Location = New System.Drawing.Point(0, 2)
        Me.Panel49.Name = "Panel49"
        Me.Panel49.Size = New System.Drawing.Size(157, 121)
        Me.Panel49.TabIndex = 11
        '
        'Label82
        '
        Me.Label82.BackColor = System.Drawing.Color.Transparent
        Me.Label82.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.Label82.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label82.Location = New System.Drawing.Point(13, 52)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(126, 39)
        Me.Label82.TabIndex = 9
        Me.Label82.Text = "Raw Mats"
        Me.Label82.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label83
        '
        Me.Label83.AutoSize = True
        Me.Label83.BackColor = System.Drawing.Color.Transparent
        Me.Label83.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label83.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label83.Location = New System.Drawing.Point(54, 16)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(51, 23)
        Me.Label83.TabIndex = 8
        Me.Label83.Text = "Silo 6"
        '
        'Panel50
        '
        Me.Panel50.BackColor = System.Drawing.Color.Transparent
        Me.Panel50.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel50.Controls.Add(Me.txtbSiloSetSilo7)
        Me.Panel50.Controls.Add(Me.Panel51)
        Me.Panel50.Location = New System.Drawing.Point(14, 363)
        Me.Panel50.Name = "Panel50"
        Me.Panel50.Size = New System.Drawing.Size(157, 153)
        Me.Panel50.TabIndex = 26
        '
        'txtbSiloSetSilo7
        '
        Me.txtbSiloSetSilo7.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbSiloSetSilo7.Location = New System.Drawing.Point(28, 124)
        Me.txtbSiloSetSilo7.Name = "txtbSiloSetSilo7"
        Me.txtbSiloSetSilo7.Size = New System.Drawing.Size(100, 27)
        Me.txtbSiloSetSilo7.TabIndex = 16
        '
        'Panel51
        '
        Me.Panel51.BackColor = System.Drawing.Color.Transparent
        Me.Panel51.BackgroundImage = Global.Automated_Feedmill_System.My.Resources.Resources.silo
        Me.Panel51.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel51.Controls.Add(Me.Label85)
        Me.Panel51.Controls.Add(Me.Label86)
        Me.Panel51.Location = New System.Drawing.Point(0, 2)
        Me.Panel51.Name = "Panel51"
        Me.Panel51.Size = New System.Drawing.Size(157, 121)
        Me.Panel51.TabIndex = 11
        '
        'Label85
        '
        Me.Label85.BackColor = System.Drawing.Color.Transparent
        Me.Label85.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.Label85.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label85.Location = New System.Drawing.Point(13, 52)
        Me.Label85.Name = "Label85"
        Me.Label85.Size = New System.Drawing.Size(126, 39)
        Me.Label85.TabIndex = 9
        Me.Label85.Text = "Raw Mats"
        Me.Label85.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label86
        '
        Me.Label86.AutoSize = True
        Me.Label86.BackColor = System.Drawing.Color.Transparent
        Me.Label86.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label86.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label86.Location = New System.Drawing.Point(54, 16)
        Me.Label86.Name = "Label86"
        Me.Label86.Size = New System.Drawing.Size(51, 23)
        Me.Label86.TabIndex = 8
        Me.Label86.Text = "Silo 7"
        '
        'Panel52
        '
        Me.Panel52.BackColor = System.Drawing.Color.Transparent
        Me.Panel52.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel52.Controls.Add(Me.txtbSiloSetSilo3)
        Me.Panel52.Controls.Add(Me.Panel53)
        Me.Panel52.Location = New System.Drawing.Point(340, 42)
        Me.Panel52.Name = "Panel52"
        Me.Panel52.Size = New System.Drawing.Size(157, 153)
        Me.Panel52.TabIndex = 21
        '
        'txtbSiloSetSilo3
        '
        Me.txtbSiloSetSilo3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbSiloSetSilo3.Location = New System.Drawing.Point(29, 124)
        Me.txtbSiloSetSilo3.Name = "txtbSiloSetSilo3"
        Me.txtbSiloSetSilo3.Size = New System.Drawing.Size(100, 27)
        Me.txtbSiloSetSilo3.TabIndex = 14
        '
        'Panel53
        '
        Me.Panel53.BackColor = System.Drawing.Color.Transparent
        Me.Panel53.BackgroundImage = Global.Automated_Feedmill_System.My.Resources.Resources.silo
        Me.Panel53.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel53.Controls.Add(Me.Label88)
        Me.Panel53.Controls.Add(Me.Label89)
        Me.Panel53.Location = New System.Drawing.Point(0, 2)
        Me.Panel53.Name = "Panel53"
        Me.Panel53.Size = New System.Drawing.Size(157, 121)
        Me.Panel53.TabIndex = 11
        '
        'Label88
        '
        Me.Label88.BackColor = System.Drawing.Color.Transparent
        Me.Label88.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.Label88.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label88.Location = New System.Drawing.Point(13, 52)
        Me.Label88.Name = "Label88"
        Me.Label88.Size = New System.Drawing.Size(126, 39)
        Me.Label88.TabIndex = 9
        Me.Label88.Text = "Raw Mats"
        Me.Label88.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label89
        '
        Me.Label89.AutoSize = True
        Me.Label89.BackColor = System.Drawing.Color.Transparent
        Me.Label89.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label89.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label89.Location = New System.Drawing.Point(54, 16)
        Me.Label89.Name = "Label89"
        Me.Label89.Size = New System.Drawing.Size(51, 23)
        Me.Label89.TabIndex = 8
        Me.Label89.Text = "Silo 3"
        '
        'Panel54
        '
        Me.Panel54.BackColor = System.Drawing.Color.Transparent
        Me.Panel54.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel54.Controls.Add(Me.txtbSiloSetSilo1)
        Me.Panel54.Controls.Add(Me.Panel55)
        Me.Panel54.Location = New System.Drawing.Point(14, 42)
        Me.Panel54.Name = "Panel54"
        Me.Panel54.Size = New System.Drawing.Size(157, 153)
        Me.Panel54.TabIndex = 20
        '
        'txtbSiloSetSilo1
        '
        Me.txtbSiloSetSilo1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbSiloSetSilo1.Location = New System.Drawing.Point(25, 124)
        Me.txtbSiloSetSilo1.Name = "txtbSiloSetSilo1"
        Me.txtbSiloSetSilo1.Size = New System.Drawing.Size(100, 27)
        Me.txtbSiloSetSilo1.TabIndex = 12
        '
        'Panel55
        '
        Me.Panel55.BackColor = System.Drawing.Color.Transparent
        Me.Panel55.BackgroundImage = Global.Automated_Feedmill_System.My.Resources.Resources.silo
        Me.Panel55.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel55.Controls.Add(Me.Label91)
        Me.Panel55.Controls.Add(Me.Label92)
        Me.Panel55.Location = New System.Drawing.Point(0, 2)
        Me.Panel55.Name = "Panel55"
        Me.Panel55.Size = New System.Drawing.Size(157, 121)
        Me.Panel55.TabIndex = 11
        '
        'Label91
        '
        Me.Label91.BackColor = System.Drawing.Color.Transparent
        Me.Label91.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.Label91.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label91.Location = New System.Drawing.Point(13, 52)
        Me.Label91.Name = "Label91"
        Me.Label91.Size = New System.Drawing.Size(126, 39)
        Me.Label91.TabIndex = 9
        Me.Label91.Text = "Raw Mats"
        Me.Label91.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label92
        '
        Me.Label92.AutoSize = True
        Me.Label92.BackColor = System.Drawing.Color.Transparent
        Me.Label92.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label92.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label92.Location = New System.Drawing.Point(54, 16)
        Me.Label92.Name = "Label92"
        Me.Label92.Size = New System.Drawing.Size(49, 23)
        Me.Label92.TabIndex = 8
        Me.Label92.Text = "Silo 1"
        '
        'Panel56
        '
        Me.Panel56.BackColor = System.Drawing.Color.Transparent
        Me.Panel56.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel56.Controls.Add(Me.txtbSiloSetSilo5)
        Me.Panel56.Controls.Add(Me.Panel57)
        Me.Panel56.Location = New System.Drawing.Point(177, 204)
        Me.Panel56.Name = "Panel56"
        Me.Panel56.Size = New System.Drawing.Size(157, 153)
        Me.Panel56.TabIndex = 24
        '
        'txtbSiloSetSilo5
        '
        Me.txtbSiloSetSilo5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbSiloSetSilo5.Location = New System.Drawing.Point(28, 125)
        Me.txtbSiloSetSilo5.Name = "txtbSiloSetSilo5"
        Me.txtbSiloSetSilo5.Size = New System.Drawing.Size(100, 27)
        Me.txtbSiloSetSilo5.TabIndex = 16
        '
        'Panel57
        '
        Me.Panel57.BackColor = System.Drawing.Color.Transparent
        Me.Panel57.BackgroundImage = Global.Automated_Feedmill_System.My.Resources.Resources.silo
        Me.Panel57.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel57.Controls.Add(Me.Label94)
        Me.Panel57.Controls.Add(Me.Label95)
        Me.Panel57.Location = New System.Drawing.Point(0, 2)
        Me.Panel57.Name = "Panel57"
        Me.Panel57.Size = New System.Drawing.Size(157, 121)
        Me.Panel57.TabIndex = 11
        '
        'Label94
        '
        Me.Label94.BackColor = System.Drawing.Color.Transparent
        Me.Label94.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.Label94.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label94.Location = New System.Drawing.Point(13, 52)
        Me.Label94.Name = "Label94"
        Me.Label94.Size = New System.Drawing.Size(126, 39)
        Me.Label94.TabIndex = 9
        Me.Label94.Text = "Raw Mats"
        Me.Label94.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label95
        '
        Me.Label95.AutoSize = True
        Me.Label95.BackColor = System.Drawing.Color.Transparent
        Me.Label95.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label95.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label95.Location = New System.Drawing.Point(54, 16)
        Me.Label95.Name = "Label95"
        Me.Label95.Size = New System.Drawing.Size(51, 23)
        Me.Label95.TabIndex = 8
        Me.Label95.Text = "Silo 5"
        '
        'Panel58
        '
        Me.Panel58.BackColor = System.Drawing.Color.Transparent
        Me.Panel58.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel58.Controls.Add(Me.txtbSiloSetSilo4)
        Me.Panel58.Controls.Add(Me.Panel59)
        Me.Panel58.Location = New System.Drawing.Point(14, 204)
        Me.Panel58.Name = "Panel58"
        Me.Panel58.Size = New System.Drawing.Size(157, 153)
        Me.Panel58.TabIndex = 23
        '
        'txtbSiloSetSilo4
        '
        Me.txtbSiloSetSilo4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbSiloSetSilo4.Location = New System.Drawing.Point(25, 123)
        Me.txtbSiloSetSilo4.Name = "txtbSiloSetSilo4"
        Me.txtbSiloSetSilo4.Size = New System.Drawing.Size(100, 27)
        Me.txtbSiloSetSilo4.TabIndex = 14
        '
        'Panel59
        '
        Me.Panel59.BackColor = System.Drawing.Color.Transparent
        Me.Panel59.BackgroundImage = Global.Automated_Feedmill_System.My.Resources.Resources.silo
        Me.Panel59.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel59.Controls.Add(Me.Label97)
        Me.Panel59.Controls.Add(Me.Label98)
        Me.Panel59.Location = New System.Drawing.Point(0, 2)
        Me.Panel59.Name = "Panel59"
        Me.Panel59.Size = New System.Drawing.Size(157, 121)
        Me.Panel59.TabIndex = 11
        '
        'Label97
        '
        Me.Label97.BackColor = System.Drawing.Color.Transparent
        Me.Label97.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.Label97.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label97.Location = New System.Drawing.Point(13, 52)
        Me.Label97.Name = "Label97"
        Me.Label97.Size = New System.Drawing.Size(126, 39)
        Me.Label97.TabIndex = 9
        Me.Label97.Text = "Raw Mats"
        Me.Label97.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label98
        '
        Me.Label98.AutoSize = True
        Me.Label98.BackColor = System.Drawing.Color.Transparent
        Me.Label98.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label98.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label98.Location = New System.Drawing.Point(54, 16)
        Me.Label98.Name = "Label98"
        Me.Label98.Size = New System.Drawing.Size(52, 23)
        Me.Label98.TabIndex = 8
        Me.Label98.Text = "Silo 4"
        '
        'Panel60
        '
        Me.Panel60.BackColor = System.Drawing.Color.Transparent
        Me.Panel60.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel60.Controls.Add(Me.txtbSiloSetSilo2)
        Me.Panel60.Controls.Add(Me.Panel61)
        Me.Panel60.Location = New System.Drawing.Point(177, 42)
        Me.Panel60.Name = "Panel60"
        Me.Panel60.Size = New System.Drawing.Size(157, 153)
        Me.Panel60.TabIndex = 22
        '
        'txtbSiloSetSilo2
        '
        Me.txtbSiloSetSilo2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbSiloSetSilo2.Location = New System.Drawing.Point(28, 124)
        Me.txtbSiloSetSilo2.Name = "txtbSiloSetSilo2"
        Me.txtbSiloSetSilo2.Size = New System.Drawing.Size(100, 27)
        Me.txtbSiloSetSilo2.TabIndex = 14
        '
        'Panel61
        '
        Me.Panel61.BackColor = System.Drawing.Color.Transparent
        Me.Panel61.BackgroundImage = Global.Automated_Feedmill_System.My.Resources.Resources.silo
        Me.Panel61.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel61.Controls.Add(Me.Label100)
        Me.Panel61.Controls.Add(Me.Label101)
        Me.Panel61.Location = New System.Drawing.Point(0, 2)
        Me.Panel61.Name = "Panel61"
        Me.Panel61.Size = New System.Drawing.Size(157, 121)
        Me.Panel61.TabIndex = 11
        '
        'Label100
        '
        Me.Label100.BackColor = System.Drawing.Color.Transparent
        Me.Label100.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.Label100.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label100.Location = New System.Drawing.Point(13, 52)
        Me.Label100.Name = "Label100"
        Me.Label100.Size = New System.Drawing.Size(126, 39)
        Me.Label100.TabIndex = 9
        Me.Label100.Text = "Raw Mats"
        Me.Label100.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label101
        '
        Me.Label101.AutoSize = True
        Me.Label101.BackColor = System.Drawing.Color.Transparent
        Me.Label101.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label101.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label101.Location = New System.Drawing.Point(54, 16)
        Me.Label101.Name = "Label101"
        Me.Label101.Size = New System.Drawing.Size(51, 23)
        Me.Label101.TabIndex = 8
        Me.Label101.Text = "Silo 2"
        '
        'formText
        '
        Me.formText.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.formText.Controls.Add(Me.Panel1)
        Me.formText.Controls.Add(Me.lblTitle)
        Me.formText.Dock = System.Windows.Forms.DockStyle.Top
        Me.formText.Location = New System.Drawing.Point(0, 0)
        Me.formText.Name = "formText"
        Me.formText.Size = New System.Drawing.Size(791, 94)
        Me.formText.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(8, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label63)
        Me.Panel1.Controls.Add(Me.btnExit)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(791, 34)
        Me.Panel1.TabIndex = 1
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Font = New System.Drawing.Font("Segoe UI Semilight", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label63.ForeColor = System.Drawing.Color.White
        Me.Label63.Location = New System.Drawing.Point(265, 2)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(238, 28)
        Me.Label63.TabIndex = 2
        Me.Label63.Text = "Ross Farm Feedmill System"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(8, Byte), Integer))
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.ErrorImage = Global.Automated_Feedmill_System.My.Resources.Resources.Delete_96px
        Me.btnExit.Image = Global.Automated_Feedmill_System.My.Resources.Resources.Delete_96px
        Me.btnExit.ImageActive = Nothing
        Me.btnExit.Location = New System.Drawing.Point(737, 3)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(40, 30)
        Me.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnExit.TabIndex = 1
        Me.btnExit.TabStop = False
        Me.btnExit.Zoom = 10
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(169, 43)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(428, 37)
        Me.lblTitle.TabIndex = 7
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 30
        Me.BunifuElipse1.TargetControl = Me
        '
        'dateTimeTimer
        '
        '
        'closeTimer
        '
        Me.closeTimer.Interval = 1000
        '
        'batchingWeightTimer
        '
        '
        'checkCon
        '
        Me.checkCon.Interval = 1000
        '
        'timerUiUpdate
        '
        Me.timerUiUpdate.Interval = 500
        '
        'ardControlTimer
        '
        Me.ardControlTimer.Interval = 500
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1000, 700)
        Me.Controls.Add(Me.content)
        Me.Controls.Add(Me.drawer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.drawer.ResumeLayout(False)
        Me.drawer.PerformLayout()
        Me.Buttons.ResumeLayout(False)
        Me.Title.ResumeLayout(False)
        Me.Title.PerformLayout()
        Me.content.ResumeLayout(False)
        Me.pnlAutomaticControl.ResumeLayout(False)
        Me.Panel63.ResumeLayout(False)
        Me.Panel63.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.pnlSettings.ResumeLayout(False)
        Me.pnlSettings.PerformLayout()
        Me.pnlFormula.ResumeLayout(False)
        Me.pnlFormula.PerformLayout()
        CType(Me.dgvFormula, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel25.ResumeLayout(False)
        Me.Panel25.PerformLayout()
        Me.Panel26.ResumeLayout(False)
        Me.Panel26.PerformLayout()
        Me.Panel27.ResumeLayout(False)
        Me.Panel27.PerformLayout()
        Me.Panel28.ResumeLayout(False)
        Me.Panel28.PerformLayout()
        Me.Panel29.ResumeLayout(False)
        Me.Panel29.PerformLayout()
        Me.Panel30.ResumeLayout(False)
        Me.Panel30.PerformLayout()
        Me.Panel31.ResumeLayout(False)
        Me.Panel31.PerformLayout()
        Me.Panel32.ResumeLayout(False)
        Me.Panel32.PerformLayout()
        Me.Panel33.ResumeLayout(False)
        Me.Panel33.PerformLayout()
        Me.Panel34.ResumeLayout(False)
        Me.Panel34.PerformLayout()
        Me.Panel35.ResumeLayout(False)
        Me.Panel35.PerformLayout()
        Me.Panel36.ResumeLayout(False)
        Me.Panel36.PerformLayout()
        Me.Panel37.ResumeLayout(False)
        Me.Panel37.PerformLayout()
        Me.Panel38.ResumeLayout(False)
        Me.Panel38.PerformLayout()
        Me.Panel39.ResumeLayout(False)
        Me.Panel39.PerformLayout()
        Me.Panel40.ResumeLayout(False)
        Me.Panel40.PerformLayout()
        Me.Panel41.ResumeLayout(False)
        Me.Panel41.PerformLayout()
        Me.Panel42.ResumeLayout(False)
        Me.Panel42.PerformLayout()
        Me.pnlBatching.ResumeLayout(False)
        Me.pnlBatching.PerformLayout()
        Me.gbBatchingStatus.ResumeLayout(False)
        Me.gbBatchingStatus.PerformLayout()
        Me.Panel19.ResumeLayout(False)
        Me.Panel20.ResumeLayout(False)
        Me.Panel20.PerformLayout()
        Me.Panel21.ResumeLayout(False)
        Me.Panel22.ResumeLayout(False)
        Me.Panel22.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        Me.Panel23.ResumeLayout(False)
        Me.Panel24.ResumeLayout(False)
        Me.Panel24.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel16.ResumeLayout(False)
        Me.Panel16.PerformLayout()
        Me.Panel14.ResumeLayout(False)
        Me.Panel15.ResumeLayout(False)
        Me.Panel15.PerformLayout()
        Me.Panel17.ResumeLayout(False)
        Me.Panel18.ResumeLayout(False)
        Me.Panel18.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.pnlReports.ResumeLayout(False)
        Me.Panel62.ResumeLayout(False)
        Me.Panel43.ResumeLayout(False)
        Me.Panel43.PerformLayout()
        Me.pnlDate.ResumeLayout(False)
        Me.pnlDate.PerformLayout()
        Me.pnlBatchID.ResumeLayout(False)
        Me.pnlWelcome.ResumeLayout(False)
        Me.pnlWelcome.PerformLayout()
        Me.Panel65.ResumeLayout(False)
        Me.Panel65.PerformLayout()
        CType(Me.pbWeighingLiquid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel64.ResumeLayout(False)
        Me.Panel64.PerformLayout()
        CType(Me.pbWeighing, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPLC.ResumeLayout(False)
        Me.pnlPLC.PerformLayout()
        CType(Me.pbPLC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlUsers.ResumeLayout(False)
        Me.pnlUsers.PerformLayout()
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSiloSettings.ResumeLayout(False)
        Me.pnlSiloSettings.PerformLayout()
        CType(Me.dgvSiloSettings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel44.ResumeLayout(False)
        Me.Panel44.PerformLayout()
        Me.Panel45.ResumeLayout(False)
        Me.Panel45.PerformLayout()
        Me.Panel46.ResumeLayout(False)
        Me.Panel46.PerformLayout()
        Me.Panel47.ResumeLayout(False)
        Me.Panel47.PerformLayout()
        Me.Panel48.ResumeLayout(False)
        Me.Panel48.PerformLayout()
        Me.Panel49.ResumeLayout(False)
        Me.Panel49.PerformLayout()
        Me.Panel50.ResumeLayout(False)
        Me.Panel50.PerformLayout()
        Me.Panel51.ResumeLayout(False)
        Me.Panel51.PerformLayout()
        Me.Panel52.ResumeLayout(False)
        Me.Panel52.PerformLayout()
        Me.Panel53.ResumeLayout(False)
        Me.Panel53.PerformLayout()
        Me.Panel54.ResumeLayout(False)
        Me.Panel54.PerformLayout()
        Me.Panel55.ResumeLayout(False)
        Me.Panel55.PerformLayout()
        Me.Panel56.ResumeLayout(False)
        Me.Panel56.PerformLayout()
        Me.Panel57.ResumeLayout(False)
        Me.Panel57.PerformLayout()
        Me.Panel58.ResumeLayout(False)
        Me.Panel58.PerformLayout()
        Me.Panel59.ResumeLayout(False)
        Me.Panel59.PerformLayout()
        Me.Panel60.ResumeLayout(False)
        Me.Panel60.PerformLayout()
        Me.Panel61.ResumeLayout(False)
        Me.Panel61.PerformLayout()
        Me.formText.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents drawer As Panel
    Friend WithEvents content As Panel
    Friend WithEvents formText As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnExit As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Buttons As Panel
    Friend WithEvents Title As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlAutomaticControl As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents swtHamMillFeed1 As Bunifu.Framework.UI.BunifuSwitch
    Friend WithEvents Panel6 As Panel
    Friend WithEvents swtMixingElev As Bunifu.Framework.UI.BunifuSwitch
    Friend WithEvents Label23 As Label
    Friend WithEvents swtMixingBotGate As Bunifu.Framework.UI.BunifuSwitch
    Friend WithEvents swtMixer As Bunifu.Framework.UI.BunifuSwitch
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents swtMixingTopGate As Bunifu.Framework.UI.BunifuSwitch
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents swtBatchGate As Bunifu.Framework.UI.BunifuSwitch
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents swtElev3 As Bunifu.Framework.UI.BunifuSwitch
    Friend WithEvents swtElev2 As Bunifu.Framework.UI.BunifuSwitch
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents swtElev1 As Bunifu.Framework.UI.BunifuSwitch
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents swtHamMillElev2 As Bunifu.Framework.UI.BunifuSwitch
    Friend WithEvents swtHamMill2 As Bunifu.Framework.UI.BunifuSwitch
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents swtHamMillFeed2 As Bunifu.Framework.UI.BunifuSwitch
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents swtHamMillElev1 As Bunifu.Framework.UI.BunifuSwitch
    Friend WithEvents swtHamMill1 As Bunifu.Framework.UI.BunifuSwitch
    Friend WithEvents pnlBatching As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel16 As Panel
    Friend WithEvents lblBatchSiloMaterial1 As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents lblBatchSiloWeight1 As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents Label54 As Label
    Friend WithEvents Label53 As Label
    Friend WithEvents cmbFormulaBatching As ComboBox
    Friend WithEvents btnStartBatching As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Panel19 As Panel
    Friend WithEvents Panel20 As Panel
    Friend WithEvents lblBatchSiloMaterial9 As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents lblBatchSiloWeight9 As Label
    Friend WithEvents Panel21 As Panel
    Friend WithEvents Panel22 As Panel
    Friend WithEvents lblBatchSiloMaterial8 As Label
    Friend WithEvents Label48 As Label
    Friend WithEvents lblBatchSiloWeight8 As Label
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Panel13 As Panel
    Friend WithEvents lblBatchSiloMaterial6 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents lblBatchSiloWeight6 As Label
    Friend WithEvents Panel23 As Panel
    Friend WithEvents Panel24 As Panel
    Friend WithEvents lblBatchSiloMaterial7 As Label
    Friend WithEvents Label51 As Label
    Friend WithEvents lblBatchSiloWeight7 As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents lblBatchSiloMaterial3 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents lblBatchSiloWeight3 As Label
    Friend WithEvents Panel14 As Panel
    Friend WithEvents Panel15 As Panel
    Friend WithEvents lblBatchSiloMaterial5 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents lblBatchSiloWeight5 As Label
    Friend WithEvents Panel17 As Panel
    Friend WithEvents Panel18 As Panel
    Friend WithEvents lblBatchSiloMaterial4 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents lblBatchSiloWeight4 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents lblBatchSiloMaterial2 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents lblBatchSiloWeight2 As Label
    Friend WithEvents lblBatchTotalTarget As Label
    Friend WithEvents Label60 As Label
    Friend WithEvents lblBatchActiveSilo As Label
    Friend WithEvents Label58 As Label
    Friend WithEvents lblBatchCurrentTarget As Label
    Friend WithEvents lblBatchBinCurrent As Label
    Friend WithEvents btnAutomaticControl As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents lblDate As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents btnReports As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnUserSettings As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnSiloSettings As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnFormula As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnBatching As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label63 As Label
    Friend WithEvents gbBatchingStatus As GroupBox
    Friend WithEvents swtBatchElev As Bunifu.Framework.UI.BunifuSwitch
    Friend WithEvents Label15 As Label
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents conControl As IO.Ports.SerialPort
    Friend WithEvents dateTimeTimer As Timer
    Friend WithEvents closeTimer As Timer
    Friend WithEvents pnlFormula As Panel
    Friend WithEvents btnDeleteFormula As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnUpdateFormula As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnAddFormula As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents dgvFormula As DataGridView
    Friend WithEvents cmbFormSiloSet As ComboBox
    Friend WithEvents Label72 As Label
    Friend WithEvents txtbFormulaName As TextBox
    Friend WithEvents Label71 As Label
    Friend WithEvents Panel25 As Panel
    Friend WithEvents Label67 As Label
    Friend WithEvents Panel26 As Panel
    Friend WithEvents lblFormulaSilo9 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents txtbFormSilo9 As TextBox
    Friend WithEvents Panel27 As Panel
    Friend WithEvents Label64 As Label
    Friend WithEvents Panel28 As Panel
    Friend WithEvents lblFormulaSilo8 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents txtbFormSilo8 As TextBox
    Friend WithEvents Panel29 As Panel
    Friend WithEvents Label38 As Label
    Friend WithEvents txtbFormSilo6 As TextBox
    Friend WithEvents Panel30 As Panel
    Friend WithEvents lblFormulaSilo6 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Panel31 As Panel
    Friend WithEvents Label42 As Label
    Friend WithEvents txtbFormSilo7 As TextBox
    Friend WithEvents Panel32 As Panel
    Friend WithEvents lblFormulaSilo7 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents Panel33 As Panel
    Friend WithEvents Label47 As Label
    Friend WithEvents txtbFormSilo3 As TextBox
    Friend WithEvents Panel34 As Panel
    Friend WithEvents lblFormulaSilo3 As Label
    Friend WithEvents Label46 As Label
    Friend WithEvents Panel35 As Panel
    Friend WithEvents Label52 As Label
    Friend WithEvents txtbFormSilo1 As TextBox
    Friend WithEvents Panel36 As Panel
    Friend WithEvents lblFormulaSilo1 As Label
    Friend WithEvents Label50 As Label
    Friend WithEvents Panel37 As Panel
    Friend WithEvents Label33 As Label
    Friend WithEvents txtbFormSilo5 As TextBox
    Friend WithEvents Panel38 As Panel
    Friend WithEvents lblFormulaSilo5 As Label
    Friend WithEvents Label62 As Label
    Friend WithEvents Panel39 As Panel
    Friend WithEvents Label29 As Label
    Friend WithEvents txtbFormSilo4 As TextBox
    Friend WithEvents Panel40 As Panel
    Friend WithEvents lblFormulaSilo4 As Label
    Friend WithEvents Label66 As Label
    Friend WithEvents Panel41 As Panel
    Friend WithEvents Label70 As Label
    Friend WithEvents txtbFormSilo2 As TextBox
    Friend WithEvents Panel42 As Panel
    Friend WithEvents lblFormulaSilo2 As Label
    Friend WithEvents Label69 As Label
    Friend WithEvents btnSettings As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents pnlSiloSettings As Panel
    Friend WithEvents btnSiloSetDelete As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnSiloSetEdit As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnSiloSetAdd As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents dgvSiloSettings As DataGridView
    Friend WithEvents Label73 As Label
    Friend WithEvents txtbSiloSetName As TextBox
    Friend WithEvents Label74 As Label
    Friend WithEvents Panel44 As Panel
    Friend WithEvents Panel45 As Panel
    Friend WithEvents Label76 As Label
    Friend WithEvents Label77 As Label
    Friend WithEvents txtbSiloSetSilo9 As TextBox
    Friend WithEvents Panel46 As Panel
    Friend WithEvents Panel47 As Panel
    Friend WithEvents Label79 As Label
    Friend WithEvents Label80 As Label
    Friend WithEvents txtbSiloSetSilo8 As TextBox
    Friend WithEvents Panel48 As Panel
    Friend WithEvents txtbSiloSetSilo6 As TextBox
    Friend WithEvents Panel49 As Panel
    Friend WithEvents Label82 As Label
    Friend WithEvents Label83 As Label
    Friend WithEvents Panel50 As Panel
    Friend WithEvents txtbSiloSetSilo7 As TextBox
    Friend WithEvents Panel51 As Panel
    Friend WithEvents Label85 As Label
    Friend WithEvents Label86 As Label
    Friend WithEvents Panel52 As Panel
    Friend WithEvents txtbSiloSetSilo3 As TextBox
    Friend WithEvents Panel53 As Panel
    Friend WithEvents Label88 As Label
    Friend WithEvents Label89 As Label
    Friend WithEvents Panel54 As Panel
    Friend WithEvents txtbSiloSetSilo1 As TextBox
    Friend WithEvents Panel55 As Panel
    Friend WithEvents Label91 As Label
    Friend WithEvents Label92 As Label
    Friend WithEvents Panel56 As Panel
    Friend WithEvents txtbSiloSetSilo5 As TextBox
    Friend WithEvents Panel57 As Panel
    Friend WithEvents Label94 As Label
    Friend WithEvents Label95 As Label
    Friend WithEvents Panel58 As Panel
    Friend WithEvents txtbSiloSetSilo4 As TextBox
    Friend WithEvents Panel59 As Panel
    Friend WithEvents Label97 As Label
    Friend WithEvents Label98 As Label
    Friend WithEvents Panel60 As Panel
    Friend WithEvents txtbSiloSetSilo2 As TextBox
    Friend WithEvents Panel61 As Panel
    Friend WithEvents Label100 As Label
    Friend WithEvents Label101 As Label
    Friend WithEvents lblSiloSetNo As Label
    Friend WithEvents lblFormulaId As Label
    Friend WithEvents lblbatchno As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents batchingWeightTimer As Timer
    Friend WithEvents pnlReports As Panel
    Friend WithEvents Panel62 As Panel
    Friend WithEvents crviewr As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Panel43 As Panel
    Friend WithEvents pnlUsers As Panel
    Friend WithEvents dgvUsers As DataGridView
    Friend WithEvents btnUserDelete As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnUserEdit As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnUserAdd As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents lblUserID As Label
    Friend WithEvents Label57 As Label
    Friend WithEvents cmbUserPosition As ComboBox
    Friend WithEvents cmbUserStatus As ComboBox
    Friend WithEvents Label56 As Label
    Friend WithEvents Label55 As Label
    Friend WithEvents Label49 As Label
    Friend WithEvents txtbUserPassword As TextBox
    Friend WithEvents Label43 As Label
    Friend WithEvents txtbUserUsername As TextBox
    Friend WithEvents Label39 As Label
    Friend WithEvents txtbUserLName As TextBox
    Friend WithEvents Label35 As Label
    Friend WithEvents txtbUserMName As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents txtbUserFName As TextBox
    Friend WithEvents pnlWelcome As Panel
    Friend WithEvents Label59 As Label
    Friend WithEvents pbPLC As PictureBox
    Friend WithEvents Panel64 As Panel
    Friend WithEvents lblConWeight As Label
    Friend WithEvents Label75 As Label
    Friend WithEvents pbWeighing As PictureBox
    Friend WithEvents pnlPLC As Panel
    Friend WithEvents lblConPLC As Label
    Friend WithEvents Label61 As Label
    Friend WithEvents checkCon As Timer
    Friend WithEvents btnReportShow As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents dtpFrom As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents dtpTo As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents chkReportsByDate As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents Label65 As Label
    Friend WithEvents Label78 As Label
    Friend WithEvents Label68 As Label
    Friend WithEvents chkBoxIndividual As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents pnlBatchID As Panel
    Friend WithEvents txtbReportBatchID As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents pnlDate As Panel
    Friend WithEvents timerUiUpdate As Timer
    Friend WithEvents lblName As Label
    Friend WithEvents Panel65 As Panel
    Friend WithEvents lblConWeightLiquid As Label
    Friend WithEvents Label87 As Label
    Friend WithEvents pbWeighingLiquid As PictureBox
    Friend WithEvents lblTextCon As Label
    Friend WithEvents pnlSettings As Panel
    Friend WithEvents txtbSettingsLiquidAdjust As TextBox
    Friend WithEvents txtbSettingsBatchAdjust As TextBox
    Friend WithEvents Label105 As Label
    Friend WithEvents Label106 As Label
    Friend WithEvents Label104 As Label
    Friend WithEvents cmbLiquicComPort As ComboBox
    Friend WithEvents cmbScaleComPort As ComboBox
    Friend WithEvents cmbPLCComPort As ComboBox
    Friend WithEvents Label103 As Label
    Friend WithEvents Label102 As Label
    Friend WithEvents Label99 As Label
    Friend WithEvents Label90 As Label
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnSettingsSave As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label107 As Label
    Friend WithEvents Label96 As Label
    Friend WithEvents txtbFormCoco As TextBox
    Friend WithEvents Label93 As Label
    Friend WithEvents txtbFormMolasses As TextBox
    Friend WithEvents Label81 As Label
    Friend WithEvents lblbatchingCoco As Label
    Friend WithEvents lblbatchingMol As Label
    Friend WithEvents Label110 As Label
    Friend WithEvents Label111 As Label
    Friend WithEvents Label108 As Label
    Friend WithEvents lblliquidcurrent As Label
    Friend WithEvents Panel63 As Panel
    Friend WithEvents swtSiloGate8 As Bunifu.Framework.UI.BunifuSwitch
    Friend WithEvents swtSiloGate7 As Bunifu.Framework.UI.BunifuSwitch
    Friend WithEvents Label119 As Label
    Friend WithEvents Label120 As Label
    Friend WithEvents swtSiloGate5 As Bunifu.Framework.UI.BunifuSwitch
    Friend WithEvents swtSiloGate4 As Bunifu.Framework.UI.BunifuSwitch
    Friend WithEvents Label113 As Label
    Friend WithEvents Label114 As Label
    Friend WithEvents swtSiloGate2 As Bunifu.Framework.UI.BunifuSwitch
    Friend WithEvents Label116 As Label
    Friend WithEvents swtSiloGate1 As Bunifu.Framework.UI.BunifuSwitch
    Friend WithEvents Label117 As Label
    Friend WithEvents Label118 As Label
    Friend WithEvents conArd As IO.Ports.SerialPort
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents txtbSettingsScreenPosition As TextBox
    Friend WithEvents btnCalibrate As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label84 As Label
    Friend WithEvents lblliquidCurrentTargetLoad As Label
    Friend WithEvents swtMixingPump As Bunifu.Framework.UI.BunifuSwitch
    Friend WithEvents Label109 As Label
    Friend WithEvents Label112 As Label
    Friend WithEvents ardControlTimer As Timer
    Friend WithEvents cmbardComport As ComboBox
End Class
