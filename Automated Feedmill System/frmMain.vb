Imports System.ComponentModel
Imports System.Threading
Imports System.Data
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports System.IO.Ports

Public Class frmMain
    Public KeepAliveDelegate As Threading.TimerCallback
    Public KeepAliveTimer As System.Threading.Timer
    Public KeepAliveDelegateUI As Threading.TimerCallback
    Public KeepAliveTimerUI As System.Threading.Timer

    Public Declare Function GetTickCount Lib "kernel32" () As Long
    Public CommandOK As Boolean
    Public motor1, motor2, motor3, motor4, motor5, motor6, motor7, motor8, motor9, motor10, motor11, motor12, motor13, motor14, motor15, motor16, motor17, motor18, motor19, motor20, motor21, motor22, motor23, motor24, motor25, motor26, motor27, motor28, motor29, motor30, motor31, motor32, motor33, motor34, motor35, motor36, motor37, motor38, motor39, motor40 As Boolean
    Public SiloSensor1, SiloSensor2, SiloSensor3, SiloSensor4, SiloSensor5, SiloSensor6 As Boolean
    Public commandArd As String
    Public commandArdLast As String
    Public commandArr(7) As Char

    Dim receivedData As String = ""
    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadoverview()
        LoadPLC()
        dateTimeTimer.Start()
        disableControl()
        checkCon.Start()
        chkReportsByDate.Checked = False
        pnlDate.Visible = False
        loadPorts()

        txtbSettingsBatchAdjust.Text = My.Settings.batchingWeightAdjustment.ToString
        txtbSettingsLiquidAdjust.Text = My.Settings.liquidWeightAdjustment.ToString
        txtbSettingsScreenPosition.Text = My.Settings.screenPosition.ToString
        conUIupdate()
        SPSetup()

        Try
            conArd.Open()
            If conArd.IsOpen = True Then
                ardControlTimer.Start()

            Else
                ardControlTimer.Stop()
            End If
        Catch ex As Exception

        End Try
    End Sub
    Public Sub SPSetup()    'Serial Port Setup
        conArd.PortName = My.Settings.ardComPort  ' "COM3"
        conArd.BaudRate = 9600
        conArd.DataBits = 8
        conArd.Parity = Parity.None
        conArd.StopBits = StopBits.One
        conArd.Handshake = Handshake.None
        conArd.Encoding = System.Text.Encoding.Default
        conArd.ReadTimeout = 10000
    End Sub

    Private Sub ArdControlTimer_Tick(sender As Object, e As EventArgs) Handles ardControlTimer.Tick
        If motor1 = False Then
            commandArr(0) = "0"
        Else
            commandArr(0) = "1"
        End If
        If motor2 = False Then
            commandArr(1) = "0"
        Else
            commandArr(1) = "1"
        End If
        If motor3 = False Then
            commandArr(2) = "0"
        Else
            commandArr(2) = "1"
        End If
        If motor4 = False Then
            commandArr(3) = "0"
        Else
            commandArr(3) = "1"
        End If
        If motor5 = False Then
            commandArr(4) = "0"
        Else
            commandArr(4) = "1"
        End If
        If motor6 = False Then
            commandArr(5) = "0"
        Else
            commandArr(5) = "1"
        End If
        If motor7 = False Then
            commandArr(6) = "0"
        Else
            commandArr(6) = "1"
        End If
        If motor8 = False Then
            commandArr(7) = "0"
        Else
            commandArr(7) = "1"
        End If
        commandArd = New String(commandArr)
        If commandArd <> commandArdLast Then
            conArd.WriteLine(commandArd)
            commandArdLast = commandArd
        End If
    End Sub
    Function ReceiveSerialData() As String
        Dim Incoming As String
        Try
            Incoming = conArd.ReadExisting()
            If Incoming Is Nothing Then
                Return "nothing" & vbCrLf
                Return "nothing" & vbCrLf
            Else
                Return Incoming
            End If
        Catch ex As TimeoutException
            Return "Error: Serial Port read timed out."
        End Try

    End Function
    Private Sub DateTimeTimer_Tick(sender As Object, e As EventArgs) Handles dateTimeTimer.Tick
        lblTime.Text = TimeOfDay.ToString("h:mm tt")
        lblDate.Text = Today.ToString("D")
    End Sub
    'Disable Panel When load
    Public Function disableControl() As Integer
        pnlUsers.Visible = False
        pnlSiloSettings.Visible = False
        pnlBatching.Visible = False
        pnlFormula.Visible = False
        pnlAutomaticControl.Visible = False
        pnlReports.Visible = False
        pnlSettings.Visible = False
        Return 0
    End Function


    'Load Overview with Full Screen
    Public Function loadoverview() As Integer
        frmControlOverview.Show()
        Dim screen As Screen
        screen = Screen.AllScreens(0)
        frmControlOverview.StartPosition = FormStartPosition.Manual
        frmControlOverview.Location = screen.Bounds.Location + New Point(0, 0)
        frmControlOverview.Show()
        frmControlOverview.WindowState = FormWindowState.Maximized
        Return 0
    End Function

    'Exit Function
    Dim i As Integer
    Private Sub CloseTimer_Tick(sender As Object, e As EventArgs) Handles closeTimer.Tick
        motorFalse()
        i += 1
        If i >= 5 Then
            End
        End If
    End Sub

    'Button for Automatic Control
    Private Sub BtnAutomaticControl_Click(sender As Object, e As EventArgs) Handles btnAutomaticControl.Click
        If (conControl.IsOpen = True) Then
            lblTitle.Text = "Automatic Control"
            pnlUsers.Visible = False
            pnlSiloSettings.Visible = False
            pnlBatching.Visible = False
            pnlFormula.Visible = False
            pnlAutomaticControl.Visible = True
            pnlReports.Visible = False
            pnlWelcome.Visible = False
            pnlSettings.Visible = False
        Else
            pnlWelcome.Visible = True
            lblTextCon.Text = "PLC is not connected. Call the administrator."
        End If


    End Sub

    'Button for Batching
    Private Sub BtnBatching_Click(sender As Object, e As EventArgs) Handles btnBatching.Click
        If (frmControlOverview.conWeight.IsOpen = True) Then
            If batchingWeightTimer.Enabled = True Then
                lblTitle.Text = "BATCHING"
                pnlUsers.Visible = False
                pnlSiloSettings.Visible = False
                pnlBatching.Visible = True
                pnlFormula.Visible = False
                pnlAutomaticControl.Visible = False
                pnlReports.Visible = False
                pnlWelcome.Visible = False
                pnlSettings.Visible = False
            Else
                lblTitle.Text = "BATCHING"
                pnlUsers.Visible = False
                pnlSiloSettings.Visible = False
                pnlBatching.Visible = True
                pnlFormula.Visible = False
                pnlAutomaticControl.Visible = False
                pnlReports.Visible = False
                pnlWelcome.Visible = False
                pnlSettings.Visible = False
                batchingloadFormula()
                ClearBatching()
                batchingStatus = False
                batchingWeightTimer.Start()
            End If
        Else
            pnlWelcome.Visible = True
            lblTextCon.Text = "Scale is not connected. Call the administrator."
        End If



    End Sub



    Private Sub CmbFormSiloSet_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFormSiloSet.SelectedIndexChanged
        selectSiloSetOnFormulaUsingName()
    End Sub

    Private Sub BtnSiloSettings_Click(sender As Object, e As EventArgs) Handles btnSiloSettings.Click
        lblTitle.Text = "SILO SETTINGS"
        pnlUsers.Visible = False
        pnlSiloSettings.Visible = True
        pnlBatching.Visible = False
        pnlFormula.Visible = False
        pnlAutomaticControl.Visible = False
        pnlReports.Visible = False
        pnlWelcome.Visible = False
        pnlSettings.Visible = False
        LoadSiloSettings()
        clearSiloSet()
    End Sub
    'Button for Formula
    Private Sub BtnFormula_Click(sender As Object, e As EventArgs) Handles btnFormula.Click
        lblTitle.Text = "FORMULA"
        pnlUsers.Visible = False
        pnlSiloSettings.Visible = False
        pnlBatching.Visible = False
        pnlFormula.Visible = True
        pnlAutomaticControl.Visible = False
        pnlReports.Visible = False
        pnlWelcome.Visible = False
        pnlSettings.Visible = False
        formulaLoadSiloSetting()
        loadFormula()
        clearFormula()
    End Sub
    'Button for Close
    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        closeTimer.Start()
    End Sub



    'Buttons for Input Line
    Private Sub SwtElev1_Click(sender As Object, e As EventArgs) Handles swtElev1.Click
        If swtElev1.Value = True Then
            motor1 = True
        Else
            motor1 = False
        End If
    End Sub



    Private Sub SwtElev2_Click(sender As Object, e As EventArgs) Handles swtElev2.Click
        If swtElev2.Value = True Then
            motor2 = True
        Else
            motor2 = False
        End If
    End Sub
    Private Sub SwtElev3_Click(sender As Object, e As EventArgs) Handles swtElev3.Click
        If swtElev3.Value = True Then
            motor3 = True
        Else
            motor3 = False
        End If
    End Sub



    'Buttons for Hammer Mill 1
    Private Sub SwtHamMillFeed1_Click(sender As Object, e As EventArgs) Handles swtHamMillFeed1.Click
        If swtHamMillFeed1.Value = True Then
            motor4 = True
        Else
            motor4 = False
        End If
    End Sub
    Private Sub SwtHamMill1_Click(sender As Object, e As EventArgs) Handles swtHamMill1.Click
        If swtHamMill1.Value = True Then
            motor5 = True
        Else
            motor5 = False
        End If
    End Sub
    Private Sub SwtHamMillElev1_Click(sender As Object, e As EventArgs) Handles swtHamMillElev1.Click
        If swtHamMillElev1.Value = True Then
            motor6 = True
        Else
            motor6 = False
        End If
    End Sub

    'Buttons for Hammer Mill 2
    Private Sub SwtHamMillFeed2_Click(sender As Object, e As EventArgs) Handles swtHamMillFeed2.Click
        If swtHamMillFeed2.Value = True Then
            motor7 = True
        Else
            motor7 = False
        End If
    End Sub



    Private Sub SwtHamMill2_Click(sender As Object, e As EventArgs) Handles swtHamMill2.Click
        If swtHamMill2.Value = True Then
            motor8 = True
        Else
            motor8 = False
        End If
    End Sub
    Private Sub SwtHamMillElev2_Click(sender As Object, e As EventArgs) Handles swtHamMillElev2.Click
        If swtHamMillElev2.Value = True Then
            motor9 = True
        Else
            motor9 = False
        End If
    End Sub

    'Buttons for Batching
    Private Sub SwtBatchGate_Click(sender As Object, e As EventArgs) Handles swtBatchGate.Click
        If batchingStatus = True Then
            MsgBox("Batching is currently processing")
            swtBatchGate.Value = False

        Else
            If swtBatchGate.Value = True Then
                motor30 = True
            Else
                motor30 = False
            End If
        End If
    End Sub



    Private Sub SwtBatchElev_Click(sender As Object, e As EventArgs) Handles swtBatchElev.Click
        If batchingStatus = True Then
            MsgBox("Batching is currently processing")
            swtBatchElev.Value = False

        Else
            If swtBatchElev.Value = True Then
                motor29 = True
            Else
                motor29 = False
            End If
        End If


    End Sub

    'Buttons for Mixing
    Private Sub SwtMixingTopGate_Click(sender As Object, e As EventArgs) Handles swtMixingTopGate.Click
        If swtMixingTopGate.Value = True Then
            motor10 = True
        Else
            motor10 = False
        End If
    End Sub
    Private Sub SwtMixer_Click(sender As Object, e As EventArgs) Handles swtMixer.Click
        If swtMixer.Value = True Then
            motor11 = True
        Else
            motor11 = False
        End If
    End Sub



    Private Sub SwtMixingBotGate_Click(sender As Object, e As EventArgs) Handles swtMixingBotGate.Click
        If swtMixingBotGate.Value = True Then
            motor12 = True
        Else
            motor12 = False
        End If
    End Sub






    Private Sub SwtMixingElev_Click(sender As Object, e As EventArgs) Handles swtMixingElev.Click
        If swtMixingElev.Value = True Then
            motor13 = True
        Else
            motor13 = False
        End If
    End Sub
    Private Sub BtnUserAdd_Click(sender As Object, e As EventArgs) Handles btnUserAdd.Click
        If txtbUserFName.Text = Nothing Or txtbUserLName.Text = Nothing Or txtbUserMName.Text = Nothing Or txtbUserUsername.Text = Nothing Or txtbUserPassword.Text = Nothing Or cmbUserPosition.SelectedItem = Nothing Or cmbUserStatus.SelectedItem = Nothing Then
            MsgBox("Enter All Necessary Data")
        Else
            addUser()
        End If
    End Sub

    Private Sub BtnUserSettings_Click(sender As Object, e As EventArgs) Handles btnUserSettings.Click
        lblTitle.Text = "USER SETTINGS"
        pnlUsers.Visible = True
        pnlSiloSettings.Visible = False
        pnlBatching.Visible = False
        pnlFormula.Visible = False
        pnlAutomaticControl.Visible = False
        pnlReports.Visible = False
        pnlWelcome.Visible = False
        pnlSettings.Visible = False
        clearUser()
    End Sub
    Private Sub CmbFormSiloSet_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbFormSiloSet.SelectedValueChanged
        selectSiloSetOnFormulaUsingName()
    End Sub

    Private Sub BtnSettingsSave_Click(sender As Object, e As EventArgs) Handles btnSettingsSave.Click
        My.Settings.plcComport = cmbPLCComPort.Text
        My.Settings.batchScaleComport = cmbScaleComPort.Text
        My.Settings.liquidScaleComport = cmbLiquicComPort.Text
        My.Settings.ardComPort = cmbArdComport.Text
        My.Settings.liquidWeightAdjustment = CDbl(txtbSettingsLiquidAdjust.Text)
        My.Settings.batchingWeightAdjustment = CDbl(txtbSettingsBatchAdjust.Text)
        My.Settings.screenPosition = CInt(txtbSettingsScreenPosition.Text)
        Try
            My.Settings.Save()
            MsgBox("Settings Successfully Saved" & vbCrLf & "Program will restart.")
            Application.Restart()
        Catch ex As Exception
            MsgBox("Error in saving settings" & vbCrLf & ex.Message)
        End Try

    End Sub

    Private Sub BtnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        lblTitle.Text = "REPORTS"
        pnlUsers.Visible = False
        pnlSiloSettings.Visible = False
        pnlBatching.Visible = False
        pnlFormula.Visible = False
        pnlAutomaticControl.Visible = False
        pnlReports.Visible = True
        pnlWelcome.Visible = False
        pnlSettings.Visible = False
    End Sub

    Private Sub DgvUsers_SelectionChanged(sender As Object, e As EventArgs) Handles dgvUsers.SelectionChanged
        If dgvUsers.SelectedRows.Count > 0 Then
            dgvClickUser()
        End If
    End Sub

    Private Sub BtnUserEdit_Click(sender As Object, e As EventArgs) Handles btnUserEdit.Click
        If txtbUserFName.Text = Nothing Or txtbUserLName.Text = Nothing Or txtbUserMName.Text = Nothing Or txtbUserUsername.Text = Nothing Or txtbUserPassword.Text = Nothing Or cmbUserPosition.SelectedItem = Nothing Or cmbUserStatus.SelectedItem = Nothing Then
            MsgBox("Enter All Necessary Data")
        Else
            updateUser()
        End If

    End Sub

    Private Sub BtnUserDelete_Click(sender As Object, e As EventArgs) Handles btnUserDelete.Click

        deleteUser()

    End Sub

    Private Sub TimerUiUpdate_Tick(sender As Object, e As EventArgs) Handles timerUiUpdate.Tick

    End Sub

    Private Sub SwtSiloGate1_Click(sender As Object, e As EventArgs) Handles swtSiloGate1.Click
        If swtSiloGate1.Value = True Then
            motor1 = True
        Else
            motor1 = False
        End If
    End Sub

    Private Sub SwtSiloGate2_Click(sender As Object, e As EventArgs) Handles swtSiloGate2.Click
        If swtSiloGate2.Value = True Then

            motor2 = True
        Else

            motor2 = False

        End If
    End Sub

    Private Sub SwtSiloGate4_Click(sender As Object, e As EventArgs) Handles swtSiloGate4.Click
        If swtSiloGate4.Value = True Then

            motor3 = True

        Else

            motor3 = False
        End If
    End Sub

    Private Sub SwtSiloGate5_Click(sender As Object, e As EventArgs) Handles swtSiloGate5.Click
        If swtSiloGate5.Value = True Then
            motor4 = True

        Else

            motor4 = False
        End If
    End Sub

    Private Sub SwtSiloGate7_Click(sender As Object, e As EventArgs) Handles swtSiloGate7.Click
        If swtSiloGate7.Value = True Then

            motor5 = True

        Else

            motor5 = False

        End If
    End Sub

    Private Sub SwtSiloGate8_Click(sender As Object, e As EventArgs) Handles swtSiloGate8.Click
        If swtSiloGate8.Value = True Then
            motor6 = True

        Else

            motor6 = False

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        checkAllMotor()

    End Sub

    Private Sub BtnCalibrate_Click(sender As Object, e As EventArgs) Handles btnCalibrate.Click
        frmWeightAdjusment.Show()

    End Sub

    Private Sub SwtMixingPump_Click(sender As Object, e As EventArgs) Handles swtMixingPump.Click
        If swtMixingPump.Value = True Then
            motor32 = True
        Else
            motor32 = False
        End If
    End Sub

    Private Sub BtnReportShow_Click(sender As Object, e As EventArgs) Handles btnReportShow.Click
        If chkReportsByDate.Checked = True And chkBoxIndividual.Checked = False Then
            showReport()
        Else
            showBatchReport()
        End If

    End Sub

    Private Sub ChkBoxIndividual_OnChange(sender As Object, e As EventArgs) Handles chkBoxIndividual.OnChange
        If chkBoxIndividual.Checked = True Then
            chkReportsByDate.Checked = False
            pnlDate.Visible = False
            pnlBatchID.Visible = True
        End If
    End Sub



    Private Sub ChkReportsByDate_OnChange(sender As Object, e As EventArgs) Handles chkReportsByDate.OnChange
        If chkReportsByDate.Checked = True Then
            chkBoxIndividual.Checked = False
            pnlBatchID.Visible = False
            pnlDate.Visible = True
        End If
    End Sub

    Private Sub BtnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        lblTitle.Text = "SETTINGS"
        pnlUsers.Visible = False
        pnlSiloSettings.Visible = False
        pnlBatching.Visible = False
        pnlFormula.Visible = False
        pnlAutomaticControl.Visible = False
        pnlReports.Visible = False
        pnlWelcome.Visible = False
        pnlSettings.Visible = True

    End Sub

    Dim myPort As Array
    Function loadPorts() As Integer
        myPort = IO.Ports.SerialPort.GetPortNames()
        cmbPLCComPort.Items.AddRange(myPort)
        cmbLiquicComPort.Items.AddRange(myPort)
        cmbScaleComPort.Items.AddRange(myPort)
        cmbardComport.Items.AddRange(myPort)
        Return 0
    End Function



    'FOR SILO SETTINGS
    Private Sub DgvSiloSettings_SelectionChanged(sender As Object, e As EventArgs) Handles dgvSiloSettings.SelectionChanged
        If dgvSiloSettings.SelectedRows.Count > 0 Then
            dgvClickSiloSettings()
        End If
    End Sub


    Private Sub BtnSiloSetEdit_Click(sender As Object, e As EventArgs) Handles btnSiloSetEdit.Click
        If txtbFormulaName.Text = Nothing Then
            MsgBox("Enter All Necessary Data")
        Else
            updateSiloSettings()
        End If


    End Sub
    Private Sub BtnSiloSetAdd_Click(sender As Object, e As EventArgs) Handles btnSiloSetAdd.Click
        If txtbFormulaName.Text = Nothing Then
            MsgBox("Enter All Necessary Data")
        Else
            addSIloSettings()
        End If


    End Sub
    Private Sub BtnSiloSetDelete_Click(sender As Object, e As EventArgs) Handles btnSiloSetDelete.Click
        deleteSiloSettings()
    End Sub


    'For Formula
    Private Sub BtnAddFormula_Click(sender As Object, e As EventArgs) Handles btnAddFormula.Click
        If txtbFormulaName.Text <> "" Or cmbFormulaBatching.SelectedItem <> "" Then
            addFormula()

        Else
            MsgBox("Enter All Necessary Data")
        End If
    End Sub

    Private Sub BtnUpdateFormula_Click(sender As Object, e As EventArgs) Handles btnUpdateFormula.Click
        If txtbFormulaName.Text = Nothing Then
            MsgBox("Enter All Necessary Data")
        Else
            updateFormula()
        End If

    End Sub

    Private Sub BtnDeleteFormula_Click(sender As Object, e As EventArgs) Handles btnDeleteFormula.Click
        deleteFormula()
    End Sub

    Private Sub DgvFormula_SelectionChanged(sender As Object, e As EventArgs) Handles dgvFormula.SelectionChanged
        If dgvFormula.SelectedRows.Count > 0 Then
            dgvClickFormula()
        End If
    End Sub

    'Prevent Key Press Letter on Formula
    Private Sub TxtbFormSilo1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbFormSilo1.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
          AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtbFormSilo2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbFormSilo2.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
          AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtbFormSilo3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbFormSilo3.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
          AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtbFormSilo4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbFormSilo4.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
          AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtbFormSilo5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbFormSilo5.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
          AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtbFormSilo6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbFormSilo6.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
          AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtbFormSilo7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbFormSilo7.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
          AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtbFormSilo8_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbFormSilo8.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
          AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtbFormSilo9_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbFormSilo9.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
          AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
    End Sub

    Private Sub CmbFormulaBatching_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbFormulaBatching.SelectedValueChanged
        batchSelectFormula()
    End Sub


    Private Sub BtnStartBatching_Click(sender As Object, e As EventArgs) Handles btnStartBatching.Click
        If reselectFormula = True Then
            If batchingStatus = True Then
                MsgBox("Batch" + " " + batchID + " " + "is currently processing." & vbCrLf & "Please wait before starting a new batch.")
            Else
                MsgBox("Please Reselect formula")
            End If
        Else
            If swtBatchElev.Value = True Or swtBatchGate.Value = True Then
                MsgBox("Close Batch Bin Gate and Stop the batching Elevator")
            Else
                If batchingStatus = True Then
                    MsgBox("Batch" + " " + batchID + " " + "is currently processing." & vbCrLf & "Please wait before starting a new batch.")
                Else
                    If cmbFormulaBatching.Text = "Select Formula" Then
                        MsgBox("Please Select Formula")
                    Else
                        batchingWeightTimer.Start()
                        batchingStatus = True
                        reselectFormula = True
                        currentSilo = "Silo1"
                        currentTargetLoad = CInt(silo1Value)
                        liquidCurrentTargetLoad = CInt(molasses)

                        targetWeight = CInt(silo1Value) + CInt(silo2Value) + CInt(silo3Value) + CInt(silo4Value) +
                            CInt(silo5Value) + CInt(silo6Value) + CInt(silo7Value) + CInt(silo8Value) + CInt(silo9Value) + CInt(molasses) + CInt(cocooil)

                        batch.Start()


                    End If
                End If
            End If
        End If


    End Sub


    'Control

    'For motor control PLC
    Public Sub LoadPLC()
        motorFalse()
        conControl.PortName = My.Settings.plcComport  'serial port number = 1
        conControl.BaudRate = 9600
        conControl.DataBits = 7
        conControl.Parity = IO.Ports.Parity.Even
        conControl.StopBits = IO.Ports.StopBits.One
        conControl.ReadTimeout = 1000
        CommandOK = False

        Try
            conControl.Open()
            Me.Text = "PLC to VB.Net"
        Catch ex As Exception
            Me.Text = ex.Message
        End Try


    End Sub
    Function checkAllMotor() As Integer
        motor1 = True
        motor2 = True
        motor3 = True
        motor4 = True
        motor5 = True
        motor6 = True
        motor7 = True
        motor8 = True
        motor9 = True
        motor10 = True
        motor11 = True
        motor12 = True
        motor13 = True
        motor14 = True
        motor15 = True
        motor16 = True
        motor17 = True
        motor18 = True
        motor19 = True
        motor20 = True
        motor21 = True
        motor22 = True
        motor23 = True
        motor24 = True
        motor25 = True
        motor26 = True
        motor27 = True
        motor28 = True
        motor29 = True
        motor30 = True
        motor31 = True
        motor32 = True
        motor33 = True
        motor34 = True
        motor35 = True
        motor36 = True
        motor37 = True
        motor38 = True
        motor39 = True
        motor40 = True

        Return 0

    End Function
    Public Sub motorAllOff()
        motor1 = False
        motor2 = False
        motor3 = False
        motor4 = False
        motor5 = False
        motor6 = False
        motor7 = False
        motor8 = False
        motor9 = False
        motor10 = False
        motor11 = False
        motor12 = False
        motor13 = False
        motor14 = False
        motor15 = False
        motor16 = False
        motor17 = False
        motor18 = False
        motor19 = False
        motor20 = False
        motor21 = False
        motor22 = False
        motor23 = False
        motor24 = False
        motor25 = False
        motor26 = False
        motor27 = False
        motor28 = False
        motor29 = False
        motor30 = False
        motor31 = False
        motor32 = False
    End Sub
    Public Function motorFalse() As Integer
        motor1 = False
        motor2 = False
        motor3 = False
        motor4 = False
        motor5 = False
        motor6 = False
        motor7 = False
        motor8 = False
        motor9 = False
        motor10 = False
        motor11 = False
        motor12 = False
        motor13 = False
        motor14 = False
        motor15 = False
        motor16 = False
        motor17 = False
        motor18 = False
        motor19 = False
        motor20 = False
        motor21 = False
        motor22 = False
        motor23 = False
        motor24 = False
        motor25 = False
        motor26 = False
        motor27 = False
        motor28 = False
        motor29 = False
        motor30 = False
        motor31 = False

        swtElev1.Value = False
        swtElev2.Value = False
        swtElev3.Value = False
        swtHamMill1.Value = False
        swtHamMill2.Value = False
        swtHamMillElev1.Value = False
        swtHamMillElev2.Value = False
        swtHamMillFeed1.Value = False
        swtHamMillFeed2.Value = False

        swtSiloGate1.Value = False
        swtSiloGate2.Value = False
        swtSiloGate4.Value = False
        swtSiloGate5.Value = False
        swtSiloGate7.Value = False
        swtSiloGate8.Value = False

        swtMixer.Value = False
        swtMixingBotGate.Value = False
        swtMixingElev.Value = False
        swtMixingTopGate.Value = False
        swtBatchElev.Value = False
        swtBatchGate.Value = False
        Return 0
    End Function

    Private Sub Write_D(ByVal D_Start As Integer, ByVal D_Value_Array() As Integer)
        If CommandOK = False Then Exit Sub

        'D start
        Dim DStart As String = "000" & CStr(Hex(2 * D_Start))
        Dim DStartStr As String = DStart.Substring(DStart.Length - 3)


        'number of data
        Dim Num_data_buff As String = "00" & CStr(Hex(D_Value_Array.Length * 2))
        Dim Num_data_str As String = Num_data_buff.Substring(Num_data_buff.Length - 2)


        'Value string
        Dim i As Integer
        Dim value_buf0, value_buf1, value_buf2, value_buf3 As String
        Dim D_Value_Str As String

        D_Value_Str = ""
        For i = 0 To (D_Value_Array.Length - 1) Step 1
            value_buf0 = "0000" & CStr(Hex(D_Value_Array(i)))
            value_buf1 = value_buf0.Substring(value_buf0.Length - 4)
            value_buf2 = value_buf1.Substring(0, 2)
            value_buf3 = value_buf1.Substring(2, 2)

            D_Value_Str = D_Value_Str & value_buf3 & value_buf2
        Next


        Dim CommandBuf As String
        Dim Command As String

        CommandBuf = "11" & DStartStr & Num_data_str & D_Value_Str & CStr(Chr(&H3))
        Dim SumCheckData As String = SumCheck(CommandBuf)
        Command = CStr(Chr(&H2)) & CommandBuf & SumCheckData

        If (conControl.IsOpen = True) Then
            conControl.Write(Command)
            Dim ReadTimeout As Long
            ReadTimeout = GetTickCount + 100
            Do While GetTickCount < ReadTimeout
                Application.DoEvents()
                Try
                    If conControl.BytesToRead = 1 Then
                        If conControl.ReadByte = &H6 Then
                            CommandOK = True
                            Exit Sub
                        End If
                    End If
                Catch ex As Exception
                    CommandOK = False
                    Me.Text = ex.Message
                    Exit Sub
                End Try
            Loop

            CommandOK = False
        End If
    End Sub

    Private Function Read_D(ByVal D_Start As Integer, ByVal Num_of_D As Byte) As Integer()
        Dim D_Values(Num_of_D - 1) As Integer
        If CommandOK = False Then Return New Integer() {}


        'D start
        Dim DStart As String = "000" & CStr(Hex(2 * D_Start))
        Dim DStartStr As String = DStart.Substring(DStart.Length - 3)


        'number of data
        Dim Num_data_buff As String = "00" & CStr(Hex(Num_of_D * 2))
        Dim Num_data_str As String = Num_data_buff.Substring(Num_data_buff.Length - 2)

        '.01-000-10.55

        Dim CommandBuf As String
        Dim Command As String

        CommandBuf = "01" & DStartStr & Num_data_str & CStr(Chr(&H3))
        Dim SumCheckData As String = SumCheck(CommandBuf)
        Command = CStr(Chr(&H2)) & CommandBuf & SumCheckData

        If (conControl.IsOpen = True) Then
            conControl.Write(Command)

            Dim TotalDataRead As Long = (Num_of_D * 4) + 4
            Dim ReadTimeout As Long
            Dim ReceivedStr As String
            Dim i As Integer
            ReceivedStr = ""
            ReadTimeout = GetTickCount + 100
            Dim Buffer(0 To TotalDataRead - 1) As Byte
            Do While GetTickCount < ReadTimeout
                Application.DoEvents()
                Try
                    If conControl.BytesToRead = TotalDataRead Then
                        conControl.Read(Buffer, 0, TotalDataRead)
                        If ASCII_Normalize(Buffer(0)) = &H2 Then
                            For i = 1 To (TotalDataRead - 3) Step 1
                                ReceivedStr = ReceivedStr & Convert.ToChar(ASCII_Normalize(Buffer(i)))
                            Next

                            Dim SumCheckStr1 As String = SumCheck(ReceivedStr)

                            For i = (TotalDataRead - 2) To (TotalDataRead - 1) Step 1
                                ReceivedStr = ReceivedStr & Convert.ToChar(ASCII_Normalize(Buffer(i)))
                            Next

                            Dim SumCheckStr2 As String = ReceivedStr.Substring(ReceivedStr.Length - 2)
                            If SumCheckStr1 = SumCheckStr2 Then
                                Dim Value_Str As String = ReceivedStr.Substring(0, (Num_of_D * 4))
                                Dim x As Integer = 0
                                Dim DValues_Str(Num_of_D - 1) As String
                                For i = 0 To (Value_Str.Length - 1) Step 4
                                    DValues_Str(x) = Value_Str.Substring(i + 2, 2) & Value_Str.Substring(i, 2)
                                    D_Values(x) = Convert.ToInt16(DValues_Str(x), 16)
                                    x = x + 1
                                Next

                                Return D_Values
                            End If

                        End If

                        Exit Do
                    End If

                Catch ex As Exception
                    CommandOK = False
                    Me.Text = ex.Message
                    Return New Integer() {}
                End Try
            Loop

        End If


        Return New Integer() {}
    End Function
    Private Function SumCheck(ByVal Command As String) As String
        Dim i As Integer
        Dim Sum As Long
        Sum = 0
        For i = 1 To Command.Length Step 1
            Sum = Sum + Asc(Mid(Command, i, 1))
        Next

        Dim SumCheck_buff As String = "00" & CStr(Hex(Sum))
        SumCheck = SumCheck_buff.Substring(SumCheck_buff.Length - 2)
    End Function



    Private Function ASCII_Normalize(ByVal ASCII_Val As Byte) As Byte
        'CODE 02 HEX 82 - 02
        'CODE 03 HEX 03 - 03
        'CHAR '0' HEX 30 - 30
        'CHAR '1' HEX B1 - 31
        'CHAR '2' HEX B2 - 32
        'CHAR '3' HEX 33 - 33
        'CHAR '4' HEX B4 - 34
        'CHAR '5' HEX 35 - 35
        'CHAR '6' HEX 36 - 36
        'CHAR '7' HEX B7 - 37
        'CHAR '8' HEX B8 - 38
        'CHAR '9' HEX 39 - 39
        'CHAR 'A' HEX 41 - 41
        'CHAR 'B' HEX 42 - 42
        'CHAR 'C' HEX C3 - 43
        'CHAR 'D' HEX 44 - 44
        'CHAR 'E' HEX C5 - 45
        'CHAR 'F' HEX C6 - 46
        Dim ASCII_Normal As Byte
        ASCII_Normal = 0
        Select Case ASCII_Val
            Case &H82
                ASCII_Normal = &H2

            Case &HB1
                ASCII_Normal = &H31

            Case &HB2
                ASCII_Normal = &H32

            Case &HB4
                ASCII_Normal = &H34

            Case &HB7
                ASCII_Normal = &H37

            Case &HB8
                ASCII_Normal = &H38

            Case &HC3
                ASCII_Normal = &H43

            Case &HC5
                ASCII_Normal = &H45

            Case &HC6
                ASCII_Normal = &H46

            Case Else
                ASCII_Normal = ASCII_Val
        End Select


        Return ASCII_Normal
    End Function



    Private Sub AccessControl()

        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf AccessControl))
        Else
            If (conControl.IsOpen = True) Then
                CommandOK = True
                'WRITE FROM D0 T0 D3
                Dim Write_Value(31) As Integer
                If motor1 = True Then Write_Value(0) = 1 Else Write_Value(0) = 0
                If motor2 = True Then Write_Value(1) = 1 Else Write_Value(1) = 0
                If motor3 = True Then Write_Value(2) = 1 Else Write_Value(2) = 0
                If motor4 = True Then Write_Value(3) = 1 Else Write_Value(3) = 0
                If motor5 = True Then Write_Value(4) = 1 Else Write_Value(4) = 0
                If motor6 = True Then Write_Value(5) = 1 Else Write_Value(5) = 0
                If motor7 = True Then Write_Value(6) = 1 Else Write_Value(6) = 0
                If motor8 = True Then Write_Value(7) = 1 Else Write_Value(7) = 0
                If motor9 = True Then Write_Value(8) = 1 Else Write_Value(8) = 0
                If motor10 = True Then Write_Value(9) = 1 Else Write_Value(9) = 0
                If motor11 = True Then Write_Value(10) = 1 Else Write_Value(10) = 0
                If motor12 = True Then Write_Value(11) = 1 Else Write_Value(11) = 0
                If motor13 = True Then Write_Value(12) = 1 Else Write_Value(12) = 0
                If motor14 = True Then Write_Value(13) = 1 Else Write_Value(13) = 0
                If motor15 = True Then Write_Value(14) = 1 Else Write_Value(14) = 0
                If motor16 = True Then Write_Value(15) = 1 Else Write_Value(15) = 0
                If motor17 = True Then Write_Value(16) = 1 Else Write_Value(16) = 0
                If motor18 = True Then Write_Value(17) = 1 Else Write_Value(17) = 0
                If motor19 = True Then Write_Value(18) = 1 Else Write_Value(18) = 0
                If motor20 = True Then Write_Value(19) = 1 Else Write_Value(19) = 0
                If motor21 = True Then Write_Value(20) = 1 Else Write_Value(20) = 0
                If motor22 = True Then Write_Value(21) = 1 Else Write_Value(21) = 0
                If motor23 = True Then Write_Value(22) = 1 Else Write_Value(22) = 0
                If motor24 = True Then Write_Value(23) = 1 Else Write_Value(23) = 0
                If motor25 = True Then Write_Value(24) = 1 Else Write_Value(24) = 0
                If motor26 = True Then Write_Value(25) = 1 Else Write_Value(25) = 0
                If motor27 = True Then Write_Value(26) = 1 Else Write_Value(26) = 0
                If motor28 = True Then Write_Value(27) = 1 Else Write_Value(27) = 0
                If motor29 = True Then Write_Value(28) = 1 Else Write_Value(28) = 0
                If motor30 = True Then Write_Value(29) = 1 Else Write_Value(29) = 0
                If motor31 = True Then Write_Value(30) = 1 Else Write_Value(30) = 0
                If motor32 = True Then Write_Value(31) = 1 Else Write_Value(31) = 0
                ' If motor33 = True Then Write_Value(32) = 1 Else Write_Value(32) = 0
                'If motor34 = True Then Write_Value(33) = 1 Else Write_Value(34) = 0
                'If motor35 = True Then Write_Value(34) = 1 Else Write_Value(34) = 0
                ' If motor36 = True Then Write_Value(35) = 1 Else Write_Value(35) = 0
                ' If motor37 = True Then Write_Value(36) = 1 Else Write_Value(36) = 0
                ' If motor38 = True Then Write_Value(37) = 1 Else Write_Value(37) = 0
                ' If motor39 = True Then Write_Value(38) = 1 Else Write_Value(38) = 0
               ' If motor40 = True Then Write_Value(39) = 1 Else Write_Value(39) = 0
                Write_D(0, Write_Value)

                Dim D_Values() As Integer = Read_D(40, 6)
                If D_Values.Length = 6 Then
                    ' If D_Values(0) = 1 Then SiloSensor1 = True Else SiloSensor1 = False
                    '  If D_Values(1) = 1 Then SiloSensor2 = True Else SiloSensor2 = False
                    '  If D_Values(2) = 1 Then SiloSensor3 = True Else SiloSensor3 = False
                    '  If D_Values(3) = 1 Then SiloSensor4 = True Else SiloSensor4 = False
                    '  If D_Values(4) = 1 Then SiloSensor5 = True Else SiloSensor5 = False
                    '  If D_Values(5) = 1 Then SiloSensor6 = True Else SiloSensor6 = False

                    '  If D_Values(0) = 1 Then test1.Text = "TRUE" Else test1.Text = "False"
                    '  If D_Values(1) = 1 Then test2.Text = "TRUE" Else test2.Text = "False"
                    '  If D_Values(2) = 1 Then test3.Text = "TRUE" Else test3.Text = "False"
                    ' If D_Values(3) = 1 Then test4.Text = "TRUE" Else test4.Text = "False"
                    ' If D_Values(4) = 1 Then test5.Text = "TRUE" Else test5.Text = "False"
                    ' If D_Values(5) = 1 Then test6.Text = "TRUE" Else test6.Text = "False"
                End If

            End If
        End If
    End Sub

    Private Sub KeepAliveTimerHandler(ByVal state As Object)
        AccessControl()
    End Sub
    Private Sub KeepAliveTimerHandlerUI(ByVal state As Object)
        UIUpdate()
    End Sub

    'Batching

    Private Sub BatchingWeightTimer_Tick(sender As Object, e As EventArgs) Handles batchingWeightTimer.Tick
        Try
            binCurrentLoad = CDbl(frmControlOverview.weight)
            liquidCurrentLoad = CDbl(frmControlOverview.weightLiquid)
        Catch ex As Exception

        End Try

        batchID = lblbatchno.Text

        lblBatchActiveSilo.Text = currentSilo
        lblBatchBinCurrent.Text = binCurrentLoad
        lblBatchTotalTarget.Text = targetWeight
        lblBatchCurrentTarget.Text = currentTargetLoad
        lblliquidcurrent.Text = liquidCurrentLoad
        lblliquidCurrentTargetLoad.Text = liquidCurrentTargetLoad


        motor18 = siloMotor1
        motor19 = siloMotor2
        motor20 = siloMotor3
        motor21 = siloMotor4
        motor22 = siloMotor5
        motor23 = siloMotor6
        motor24 = siloMotor7
        motor25 = siloMotor8
        motor26 = siloMotor9
        motor27 = siloMotor10
        motor28 = siloMotor11
        motor29 = chainConve
        motor30 = bingate
    End Sub


    'checking
    Public Sub conplcopen()
        KeepAliveDelegate = AddressOf KeepAliveTimerHandler
        KeepAliveTimer = New System.Threading.Timer(KeepAliveDelegate, Nothing, 1000, 1000)
        KeepAliveTimer.Change(500, 500)
    End Sub

    Private Sub CheckCon_Tick(sender As Object, e As EventArgs) Handles checkCon.Tick
        If (conControl.IsOpen = False) Or (frmControlOverview.conWeight.IsOpen = False) Or (frmControlOverview.conWeightLiquid.IsOpen = False) Then


            If (conControl.IsOpen = True) Then

                pbPLC.Image = My.Resources.Link_104px
                lblConPLC.Text = "Connected"


            Else

                pbPLC.Image = My.Resources.loading
                lblConPLC.Text = "Connecting"
            End If

            If (frmControlOverview.conWeight.IsOpen = True) Then

                pbWeighing.Image = My.Resources.Link_104px
                lblConWeight.Text = "Connected"
            Else
                pbWeighing.Image = My.Resources.loading
                lblConWeight.Text = "Connecting"
            End If

            If (frmControlOverview.conWeightLiquid.IsOpen = True) Then

                pbWeighingLiquid.Image = My.Resources.Link_104px
                lblConWeightLiquid.Text = "Connected"
            Else
                pbWeighingLiquid.Image = My.Resources.loading
                lblConWeightLiquid.Text = "Connecting"
            End If

        Else
            pbPLC.Image = My.Resources.Link_104px
            lblConPLC.Text = "Connected"
            pbWeighing.Image = My.Resources.Link_104px
            lblConWeight.Text = "Connected"

            pbWeighingLiquid.Image = My.Resources.Link_104px
            lblConWeightLiquid.Text = "Connected"

            conplcopen()
            Me.checkCon.Stop()
            MsgBox("Successfully Connected to all Device")
        End If
    End Sub
    Public Sub conUIupdate()
        KeepAliveDelegateUI = AddressOf KeepAliveTimerHandlerUI
        KeepAliveTimerUI = New System.Threading.Timer(KeepAliveDelegateUI, Nothing, 1000, 1000)
        KeepAliveTimerUI.Change(500, 500)
    End Sub
    Private Sub UIUpdate()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf UIUpdate))
        Else


            If SiloSensor1 = True Then
                motor1 = False
                swtSiloGate1.Value = False
            End If
            If SiloSensor2 = True Then
                motor2 = False
                swtSiloGate2.Value = False
            End If
            If SiloSensor3 = True Then
                motor3 = False
                swtSiloGate4.Value = False
            End If
            If SiloSensor4 = True Then
                motor4 = False
                swtSiloGate5.Value = False
            End If
            If SiloSensor5 = True Then
                motor5 = False
                swtSiloGate7.Value = False
            End If
            If SiloSensor6 = True Then
                motor6 = False
                swtSiloGate8.Value = False
            End If


            'Elev 1
            If motor1 = True Then
                frmControlOverview.pbElev1.Image = My.Resources.Green_Icon
                frmControlOverview.pbTopAuger1.Image = My.Resources.Green_Icon
            Else
                frmControlOverview.pbElev1.Image = My.Resources.Red_Icon
                frmControlOverview.pbTopAuger1.Image = My.Resources.Red_Icon
            End If
            'Elev 2
            If motor2 = True Then
                frmControlOverview.pbElev2.Image = My.Resources.Green_Icon
                frmControlOverview.pbDust1.Image = My.Resources.Green_Icon
            Else
                frmControlOverview.pbElev2.Image = My.Resources.Red_Icon
                frmControlOverview.pbDust1.Image = My.Resources.Red_Icon
            End If
            'Elev 3
            If motor3 = True Then
                frmControlOverview.pbElev3.Image = My.Resources.Green_Icon
                frmControlOverview.pbDust2.Image = My.Resources.Green_Icon
            Else
                frmControlOverview.pbElev3.Image = My.Resources.Red_Icon
                frmControlOverview.pbDust2.Image = My.Resources.Red_Icon
            End If
            'Hammer Mill 1 feeder
            If motor4 = True Then
                frmControlOverview.pbHamMillFeed1.Image = My.Resources.Green_Icon

            Else
                frmControlOverview.pbHamMillFeed1.Image = My.Resources.Red_Icon

            End If
            'Hammer Mill 1
            If motor5 = True Then
                frmControlOverview.pbHamMill1.Image = My.Resources.Green_Icon
            Else
                frmControlOverview.pbHamMill1.Image = My.Resources.Red_Icon
            End If
            'Hammer Mill 1 Elev
            If motor6 = True Then
                frmControlOverview.pbHamMillScrew1.Image = My.Resources.Green_Icon
                frmControlOverview.pbElev4.Image = My.Resources.Green_Icon
                frmControlOverview.pbTopAuger2.Image = My.Resources.Green_Icon
            Else
                frmControlOverview.pbHamMillScrew1.Image = My.Resources.Red_Icon
                frmControlOverview.pbElev4.Image = My.Resources.Red_Icon
                frmControlOverview.pbTopAuger2.Image = My.Resources.Red_Icon
            End If
            'Hammer Mill 2 feeder
            If motor7 = True Then
                frmControlOverview.pbHamMillFeed2.Image = My.Resources.Green_Icon
            Else
                frmControlOverview.pbHamMillFeed2.Image = My.Resources.Red_Icon
            End If
            'Hammer Mill 1
            If motor8 = True Then
                frmControlOverview.pbHamMill2.Image = My.Resources.Green_Icon
            Else
                frmControlOverview.pbHamMill2.Image = My.Resources.Red_Icon
            End If
            'Hammer Mill 1 Elev
            If motor9 = True Then
                frmControlOverview.pbHamMillScrew2.Image = My.Resources.Green_Icon
                frmControlOverview.pbElev5.Image = My.Resources.Green_Icon
                frmControlOverview.pbTopAuger3.Image = My.Resources.Green_Icon
            Else
                frmControlOverview.pbHamMillScrew2.Image = My.Resources.Red_Icon
                frmControlOverview.pbElev5.Image = My.Resources.Red_Icon
                frmControlOverview.pbTopAuger3.Image = My.Resources.Red_Icon
            End If

            If motor10 = True Then
                frmControlOverview.pbMixingTopGate.Image = My.Resources.Green_Icon
            Else
                frmControlOverview.pbMixingTopGate.Image = My.Resources.Red_Icon
            End If
            If motor11 = True Then
                frmControlOverview.pbMixer.Image = My.Resources.Green_Icon
            Else

                frmControlOverview.pbMixer.Image = My.Resources.Red_Icon
            End If
            If motor12 = True Then
                frmControlOverview.pbMixingBottomGate.Image = My.Resources.Green_Icon
            Else
                frmControlOverview.pbMixingBottomGate.Image = My.Resources.Red_Icon
            End If
            If motor13 = True Then
                frmControlOverview.pbMixingMolasses.Image = My.Resources.Green_Icon
            Else
                frmControlOverview.pbMixingMolasses.Image = My.Resources.Red_Icon
            End If
            If motor14 = True Then
                frmControlOverview.pbMixingCoco.Image = My.Resources.Green_Icon
            Else
                frmControlOverview.pbMixingCoco.Image = My.Resources.Red_Icon
            End If
            If motor15 = True Then
                frmControlOverview.pbMixingConveyer.Image = My.Resources.Green_Icon
                frmControlOverview.pbElev7.Image = My.Resources.Green_Icon
            Else
                frmControlOverview.pbMixingConveyer.Image = My.Resources.Red_Icon
                frmControlOverview.pbElev7.Image = My.Resources.Red_Icon
            End If
            If motor16 = True Then
                frmControlOverview.pbBatchGate.Image = My.Resources.Green_Icon
            Else
                frmControlOverview.pbBatchGate.Image = My.Resources.Red_Icon
            End If
            If motor17 = True Then
                frmControlOverview.pbBatchConveyer.Image = My.Resources.Green_Icon
            Else
                frmControlOverview.pbBatchConveyer.Image = My.Resources.Red_Icon
            End If
            If motor18 = True Then

            Else

            End If
            If motor19 = True Then

            Else

            End If
            If motor20 = True Then

            Else

            End If
            If motor21 = True Then

            Else

            End If
            If motor22 = True Then

            Else

            End If
            If motor23 = True Then
                frmControlOverview.pbSilo1.Image = My.Resources.Green_Icon
            Else
                frmControlOverview.pbSilo1.Image = My.Resources.Red_Icon
            End If
            If motor24 = True Then
                frmControlOverview.pbSilo2.Image = My.Resources.Green_Icon
            Else
                frmControlOverview.pbSilo2.Image = My.Resources.Red_Icon
            End If
            If motor25 = True Then
                frmControlOverview.pbSilo3.Image = My.Resources.Green_Icon
            Else
                frmControlOverview.pbSilo3.Image = My.Resources.Red_Icon
            End If
            If motor26 = True Then
                frmControlOverview.pbSilo4.Image = My.Resources.Green_Icon
            Else
                frmControlOverview.pbSilo4.Image = My.Resources.Red_Icon
            End If
            If motor27 = True Then
                frmControlOverview.pbSilo5.Image = My.Resources.Green_Icon
            Else
                frmControlOverview.pbSilo5.Image = My.Resources.Red_Icon
            End If
            If motor28 = True Then
                frmControlOverview.pbSilo6.Image = My.Resources.Green_Icon
            Else
                frmControlOverview.pbSilo6.Image = My.Resources.Red_Icon
            End If
            If motor29 = True Then
                frmControlOverview.pbSilo7.Image = My.Resources.Green_Icon
            Else
                frmControlOverview.pbSilo7.Image = My.Resources.Red_Icon
            End If
            If motor30 = True Then
                frmControlOverview.pbSilo8.Image = My.Resources.Green_Icon
            Else
                frmControlOverview.pbSilo8.Image = My.Resources.Red_Icon
            End If
            If motor31 = True Then
                frmControlOverview.pbSilo9.Image = My.Resources.Green_Icon
            Else
                frmControlOverview.pbSilo9.Image = My.Resources.Red_Icon
            End If
        End If
    End Sub
    'Ui Update Timer

End Class