Imports System
Imports System.Threading
Imports System.IO.Ports
Imports System.ComponentModel
Imports System.Data.SqlClient

Module batching
    Public Formula As Integer
    Public Silo_settings As Integer
    Public targetWeight As Integer
    Public binCurrentLoad As Double
    Public liquidCurrentLoad As Double
    Public liquidCurrentTargetLoad
    Public currentTargetLoad As Integer
    Public currentSilo As String
    Public batch As Thread
    Public OperatorID As Integer
    Public batchID As String

    Public reselectFormula As Boolean
    Public batchingStatus As Boolean

    Public silo1Value, silo2Value, silo3Value, silo4Value, silo5Value, silo6Value, silo7Value, silo8Value, silo9Value, molasses, cocooil As String
    Public siloMotor1, siloMotor2, siloMotor3, siloMotor4, siloMotor5, siloMotor6, siloMotor7, siloMotor8, siloMotor9, siloMotor10, siloMotor11, chainConve, bingate As Boolean

    Function batchingloadFormula() As Integer
        frmMain.cmbFormulaBatching.Items.Clear()

        connect()
        conn.Open()
        cmd = conn.CreateCommand

        cmd.CommandText = "SELECT FORMULA_NAME FROM tblformula"
        dr = cmd.ExecuteReader()

        While dr.Read()
            frmMain.cmbFormulaBatching.Items.Add(dr.GetString(0))
        End While
        dr.Close()
        conn.Close()
        frmMain.cmbFormulaBatching.SelectedItem = 0
        Return 0
    End Function

    Public Sub GenerateBatchID()
        Dim InvoiceNo As String
        Dim prefix As String
        Dim CurrDate As String
        CurrDate = Format(Now, "yyMMdd")

        Try
            connect()
            conn.Open()

            cmd = conn.CreateCommand
            cmd.CommandText = "SELECT MAX(BATCHING_ID) FROM tblbatching"

            InvoiceNo = cmd.ExecuteScalar
            prefix = cmd.ExecuteScalar
            prefix = Microsoft.VisualBasic.Left(prefix, 6)

            If prefix = CurrDate Then

                InvoiceNo = Mid(InvoiceNo, 7, 6)

                If Val(InvoiceNo) < 9 Then
                    InvoiceNo = Val(InvoiceNo) + 1
                    frmMain.lblbatchno.Text = CurrDate + "00000" + InvoiceNo
                ElseIf Val(InvoiceNo) < 99 Then
                    InvoiceNo = Val(InvoiceNo) + 1
                    frmMain.lblbatchno.Text = CurrDate + "0000" + InvoiceNo
                ElseIf Val(InvoiceNo) < 999 Then
                    InvoiceNo = Val(InvoiceNo) + 1
                    frmMain.lblbatchno.Text = CurrDate + "000" + InvoiceNo
                ElseIf Val(InvoiceNo) < 9999 Then
                    InvoiceNo = Val(InvoiceNo) + 1
                    frmMain.lblbatchno.Text = CurrDate + "00" + InvoiceNo
                ElseIf Val(InvoiceNo) < 99999 Then
                    InvoiceNo = Val(InvoiceNo) + 1
                    frmMain.lblbatchno.Text = CurrDate + "0" + InvoiceNo
                Else
                    InvoiceNo = Val(InvoiceNo) + 1
                    frmMain.lblbatchno.Text = CurrDate + InvoiceNo
                    batchID = CurrDate + InvoiceNo
                End If

            Else
                frmMain.lblbatchno.Text = CurrDate + "000001"
                batchID = CurrDate + "000001"
            End If

            conn.Close()

        Catch ex As Exception
            frmMain.lblbatchno.Text = CurrDate + "000001"
            batchID = CurrDate + "000001"
        End Try
    End Sub

    Public Sub batchSelectFormula()
        batch = New Thread(AddressOf batching)
        GenerateBatchID()

        connect()

        conn.Open()

        cmd = conn.CreateCommand

        cmd.CommandText = "SELECT * FROM tblformula INNER JOIN tblsilosettings ON tblformula.SILO_SETTING_ID=tblsilosettings.SILO_SETTING_ID WHERE FORMULA_NAME='" & frmMain.cmbFormulaBatching.Text & "'"

        dr = cmd.ExecuteReader()

        If dr.HasRows Then
            dr.Read()
            frmMain.lblBatchSiloWeight1.Text = dr.Item("SILO1_WEIGHT").ToString + " " + "KG"
            frmMain.lblBatchSiloWeight2.Text = dr.Item("SILO2_WEIGHT").ToString + " " + "KG"
            frmMain.lblBatchSiloWeight3.Text = dr.Item("SILO3_WEIGHT").ToString + " " + "KG"
            frmMain.lblBatchSiloWeight4.Text = dr.Item("SILO4_WEIGHT").ToString + " " + "KG"
            frmMain.lblBatchSiloWeight5.Text = dr.Item("SILO5_WEIGHT").ToString + " " + "KG"
            frmMain.lblBatchSiloWeight6.Text = dr.Item("SILO6_WEIGHT").ToString + " " + "KG"
            frmMain.lblBatchSiloWeight7.Text = dr.Item("SILO7_WEIGHT").ToString + " " + "KG"
            frmMain.lblBatchSiloWeight8.Text = dr.Item("SILO8_WEIGHT").ToString + " " + "KG"
            frmMain.lblBatchSiloWeight9.Text = dr.Item("SILO9_WEIGHT").ToString + " " + "KG"

            frmMain.lblbatchingMol.Text = dr.Item("MOLASSES").ToString + " " + "KG"
            frmMain.lblbatchingCoco.Text = dr.Item("COCOOIL").ToString + " " + "KG"

            silo1Value = dr.Item("SILO1_WEIGHT").ToString
            silo2Value = dr.Item("SILO2_WEIGHT").ToString
            silo3Value = dr.Item("SILO3_WEIGHT").ToString
            silo4Value = dr.Item("SILO4_WEIGHT").ToString
            silo5Value = dr.Item("SILO5_WEIGHT").ToString
            silo6Value = dr.Item("SILO6_WEIGHT").ToString
            silo7Value = dr.Item("SILO7_WEIGHT").ToString
            silo8Value = dr.Item("SILO8_WEIGHT").ToString
            silo9Value = dr.Item("SILO9_WEIGHT").ToString
            molasses = dr.Item("MOLASSES").ToString
            cocooil = dr.Item("COCOOIL").ToString

            frmMain.lblBatchSiloMaterial1.Text = dr.Item("SILO1").ToString
            frmMain.lblBatchSiloMaterial2.Text = dr.Item("SILO2").ToString
            frmMain.lblBatchSiloMaterial3.Text = dr.Item("SILO3").ToString
            frmMain.lblBatchSiloMaterial4.Text = dr.Item("SILO4").ToString
            frmMain.lblBatchSiloMaterial5.Text = dr.Item("SILO5").ToString
            frmMain.lblBatchSiloMaterial6.Text = dr.Item("SILO6").ToString
            frmMain.lblBatchSiloMaterial7.Text = dr.Item("SILO7").ToString
            frmMain.lblBatchSiloMaterial8.Text = dr.Item("SILO8").ToString
            frmMain.lblBatchSiloMaterial9.Text = dr.Item("SILO9").ToString

            If frmMain.lblBatchSiloMaterial1.Text = "" Then
                frmMain.lblBatchSiloWeight1.Visible = False
            End If
            If frmMain.lblBatchSiloMaterial2.Text = "" Then
                frmMain.lblBatchSiloWeight2.Visible = False
            End If
            If frmMain.lblBatchSiloMaterial3.Text = "" Then
                frmMain.lblBatchSiloWeight3.Visible = False
            End If
            If frmMain.lblBatchSiloMaterial4.Text = "" Then
                frmMain.lblBatchSiloWeight4.Visible = False
            End If
            If frmMain.lblBatchSiloMaterial5.Text = "" Then
                frmMain.lblBatchSiloWeight5.Visible = False
            End If
            If frmMain.lblBatchSiloMaterial6.Text = "" Then
                frmMain.lblBatchSiloWeight6.Visible = False
            End If
            If frmMain.lblBatchSiloMaterial7.Text = "" Then
                frmMain.lblBatchSiloWeight7.Visible = False
            End If
            If frmMain.lblBatchSiloMaterial8.Text = "" Then
                frmMain.lblBatchSiloWeight8.Visible = False
            End If
            If frmMain.lblBatchSiloMaterial9.Text = "" Then
                frmMain.lblBatchSiloWeight9.Visible = False
            End If

            Formula = dr.Item("FORMULA_ID").ToString
            Silo_settings = dr.Item("SILO_SETTING_ID").ToString

        Else
            ClearBatching()
            frmMain.cmbFormulaBatching.SelectedIndex = 0
            frmMain.cmbFormulaBatching.Text = "Select Formula"

        End If

        dr.Close()
        conn.Close()
        reselectFormula = False
    End Sub

    Public Sub ClearBatching()
        frmMain.lblBatchSiloWeight1.Text = "0" + "KG"
        frmMain.lblBatchSiloWeight1.Text = "0" + "KG"
        frmMain.lblBatchSiloWeight1.Text = "0" + "KG"
        frmMain.lblBatchSiloWeight1.Text = "0" + "KG"
        frmMain.lblBatchSiloWeight1.Text = "0" + "KG"
        frmMain.lblBatchSiloWeight1.Text = "0" + "KG"
        frmMain.lblBatchSiloWeight1.Text = "0" + "KG"
        frmMain.lblBatchSiloWeight1.Text = "0" + "KG"
        frmMain.lblBatchSiloWeight1.Text = "0" + "KG"

        frmMain.lblBatchSiloMaterial1.Text = "Raw Mats"
        frmMain.lblBatchSiloMaterial2.Text = "Raw Mats"
        frmMain.lblBatchSiloMaterial3.Text = "Raw Mats"
        frmMain.lblBatchSiloMaterial4.Text = "Raw Mats"
        frmMain.lblBatchSiloMaterial5.Text = "Raw Mats"
        frmMain.lblBatchSiloMaterial6.Text = "Raw Mats"
        frmMain.lblBatchSiloMaterial7.Text = "Raw Mats"
        frmMain.lblBatchSiloMaterial8.Text = "Raw Mats"
        frmMain.lblBatchSiloMaterial9.Text = "Raw Mats"

        frmMain.cmbFormulaBatching.SelectedItem = 0
        frmMain.cmbFormSiloSet.Text = "Select Formula"

    End Sub

    Function record() As Integer


        Dim dateToday As String
        dateToday = Format(Now, "yyMMdd")
        Dim timeToday As String
        timeToday = Format(Now, "h:mm tt")

        connect()

        conn.Open()

        cmd = conn.CreateCommand

        cmd.CommandText = "SELECT * FROM tblbatching WHERE BATCHING_ID='" & batchID & "'"

        dr = cmd.ExecuteReader()

        If dr.HasRows Then
            MsgBox("Product code already exists!", vbExclamation, "Point of Sale")
        Else
            Dim StringDate As String

            StringDate = Date.Today.ToString("yyyy-MM-dd")


            conn.Close()
            conn.Open()
            cmd = conn.CreateCommand
            cmd.CommandText = String.Format("INSERT INTO tblbatching (BATCHING_ID,OPERATOR_ID,FORMULA_ID,SILO_SETTING, DATE_TIME,TOTAL_WEIGHT,DATE) VALUES(
                                                                '" & batchID & "','" & OperatorID & "','" & Formula & "','" & Silo_settings & "','" & DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") & "','" & targetWeight & "','" & StringDate & "')")
            cmd.ExecuteNonQuery()


        End If

        dr.Close()
        conn.Close()

        If MsgBox("Do you want to print a copy of Batching Report?", vbQuestion + vbYesNo, "Confirmation") = vbYes Then
            Dim dt As New reportDataSet


            connect()
            conn.Open()
            cmd = conn.CreateCommand
            cmd.CommandText = "SELECT BATCHING_ID,DATE_TIME,F_NAME,M_NAME,L_NAME,POSITION,FORMULA_NAME,SILO1
,SILO1_WEIGHT,SILO2,SILO2_WEIGHT,SILO3,SILO3_WEIGHT,SILO4,SILO4_WEIGHT,SILO5,SILO5_WEIGHT,SILO6,SILO6_WEIGHT,SILO7,SILO7_WEIGHT,SILO8,SILO8_WEIGHT,SILO9,SILO9_WEIGHT,TOTAL_WEIGHT,MOLASSES,COCOOIL FROM tblbatching as batch
INNER JOIN tblformula as formula on batch.FORMULA_ID = formula.FORMULA_ID
INNER Join tblsilosettings as siloset on batch.SILO_SETTING = siloset.SILO_SETTING_ID
INNER JOIN tblusers as user on batch.OPERATOR_ID = user.USER_ID WHERE BATCHING_ID='" & batchID & "' "
            adp.SelectCommand = cmd
            adp.Fill(dt, "getReportData")
            Dim report As New BatchReport

            report.SetDataSource(dt)
            frmMain.crviewr.ReportSource = report
            frmMain.crviewr.Refresh()
            frmMain.crviewr.RefreshReport()
            report.PrintToPrinter(1, False, 0, 0)
            conn.Close()
        End If

        Return 0
    End Function

    Public Sub batching()


        frmMain.btnStartBatching.Enabled = False
        Do
            Select Case currentSilo
                Case "Silo1"
                    Do
                        siloMotor1 = True
                        If binCurrentLoad >= currentTargetLoad Then
                            siloMotor1 = False
                            System.Threading.Thread.Sleep(5000)
                            currentSilo = "Silo2"
                            currentTargetLoad += CInt(silo2Value)
                            Exit Do
                        End If
                    Loop



                Case "Silo2"
                    Do
                        siloMotor2 = True
                        If binCurrentLoad >= currentTargetLoad Then
                            siloMotor2 = False
                            System.Threading.Thread.Sleep(5000)
                            currentSilo = "Silo3"
                            currentTargetLoad += CInt(silo3Value)
                            Exit Do
                        End If
                    Loop
                Case "Silo3"
                    Do
                        siloMotor3 = True
                        If binCurrentLoad >= currentTargetLoad Then
                            siloMotor3 = False
                            System.Threading.Thread.Sleep(5000)
                            currentSilo = "Silo4"
                            currentTargetLoad += CInt(silo4Value)
                            Exit Do
                        End If
                    Loop
                Case "Silo4"
                    Do
                        siloMotor4 = True
                        If binCurrentLoad >= currentTargetLoad Then
                            siloMotor4 = False
                            System.Threading.Thread.Sleep(5000)
                            currentSilo = "Silo5"
                            currentTargetLoad += CInt(silo5Value)
                            Exit Do
                        End If
                    Loop
                Case "Silo5"
                    Do
                        siloMotor5 = True
                        If binCurrentLoad >= currentTargetLoad Then
                            siloMotor5 = False
                            System.Threading.Thread.Sleep(5000)
                            currentSilo = "Silo6"
                            currentTargetLoad += CInt(silo6Value)
                            Exit Do
                        End If
                    Loop
                Case "Silo6"
                    Do
                        siloMotor6 = True
                        If binCurrentLoad >= currentTargetLoad Then
                            siloMotor6 = False
                            System.Threading.Thread.Sleep(5000)
                            currentSilo = "Silo7"
                            currentTargetLoad += CInt(silo7Value)
                            Exit Do
                        End If
                    Loop
                Case "Silo7"
                    Do
                        siloMotor7 = True
                        If binCurrentLoad >= currentTargetLoad Then
                            siloMotor7 = False
                            System.Threading.Thread.Sleep(5000)
                            currentSilo = "Silo8"
                            currentTargetLoad += CInt(silo8Value)
                            Exit Do
                        End If
                    Loop
                Case "Silo8"
                    Do
                        siloMotor8 = True
                        If binCurrentLoad >= currentTargetLoad Then
                            siloMotor8 = False
                            System.Threading.Thread.Sleep(5000)
                            currentSilo = "Silo9"
                            currentTargetLoad += CInt(silo9Value)
                            Exit Do
                        End If
                    Loop
                Case "Silo9"
                    Do
                        siloMotor9 = True
                        If binCurrentLoad >= currentTargetLoad Then
                            siloMotor9 = False
                            System.Threading.Thread.Sleep(5000)
                            currentSilo = "Molasses"
                            Exit Do
                        End If
                    Loop
                Case "Molasses"
                    Do
                        siloMotor9 = True
                        If liquidCurrentLoad >= liquidCurrentTargetLoad Then
                            siloMotor9 = False
                            System.Threading.Thread.Sleep(5000)
                            liquidCurrentTargetLoad += cocooil
                            currentSilo = "Cocooil"
                            Exit Do
                        End If
                    Loop
                Case "Cocooil"
                    Do
                        siloMotor9 = True
                        If liquidCurrentLoad >= liquidCurrentTargetLoad Then
                            siloMotor9 = False
                            System.Threading.Thread.Sleep(5000)
                            currentSilo = "finish"
                            Exit Do
                        End If
                    Loop
                Case Else
                    binToMixer()
                    record()

                    MsgBox("Finish")
                    clearBatchingD()
                    batch.Abort()
                    Exit Do
            End Select


        Loop


    End Sub

    Function binToMixer() As Integer

        chainConve = True
        System.Threading.Thread.Sleep(5000)

        Do
            bingate = True
            If binCurrentLoad <= 0 Then
                bingate = False

                System.Threading.Thread.Sleep(2000)
                Exit Do
            End If
        Loop
        System.Threading.Thread.Sleep(2000)

        chainConve = False

        Return 0
    End Function

    Function clearBatchingD() As Integer
        frmMain.lblBatchSiloMaterial1.Text = "Raw Mats"
        frmMain.lblBatchSiloMaterial2.Text = "Raw Mats"
        frmMain.lblBatchSiloMaterial3.Text = "Raw Mats"
        frmMain.lblBatchSiloMaterial4.Text = "Raw Mats"
        frmMain.lblBatchSiloMaterial5.Text = "Raw Mats"
        frmMain.lblBatchSiloMaterial6.Text = "Raw Mats"
        frmMain.lblBatchSiloMaterial7.Text = "Raw Mats"
        frmMain.lblBatchSiloMaterial8.Text = "Raw Mats"
        frmMain.lblBatchSiloMaterial9.Text = "Raw Mats"

        frmMain.lblBatchSiloWeight1.Text = "0 KG"
        frmMain.lblBatchSiloWeight2.Text = "0 KG"
        frmMain.lblBatchSiloWeight3.Text = "0 KG"
        frmMain.lblBatchSiloWeight4.Text = "0 KG"
        frmMain.lblBatchSiloWeight5.Text = "0 KG"
        frmMain.lblBatchSiloWeight6.Text = "0 KG"
        frmMain.lblBatchSiloWeight7.Text = "0 KG"
        frmMain.lblBatchSiloWeight8.Text = "0 KG"
        frmMain.lblBatchSiloWeight9.Text = "0 KG"
        frmMain.lblbatchingCoco.Text = "0 KG"
        frmMain.lblbatchingMol.Text = "0 KG"

        frmMain.cmbFormulaBatching.SelectedIndex = -1
        frmMain.cmbFormulaBatching.Text = "Select Formula"

        Silo_settings = 0
        Formula = 0
        targetWeight = 0
        liquidCurrentTargetLoad = 0
        currentSilo = ""
        currentTargetLoad = 0
        batchingStatus = False
        GenerateBatchID()
        Return 0
    End Function
    Public Sub ClearBatchingData()
        frmMain.lblBatchSiloMaterial1.Text = "Raw Mats"
        frmMain.lblBatchSiloMaterial2.Text = "Raw Mats"
        frmMain.lblBatchSiloMaterial3.Text = "Raw Mats"
        frmMain.lblBatchSiloMaterial4.Text = "Raw Mats"
        frmMain.lblBatchSiloMaterial5.Text = "Raw Mats"
        frmMain.lblBatchSiloMaterial6.Text = "Raw Mats"
        frmMain.lblBatchSiloMaterial7.Text = "Raw Mats"
        frmMain.lblBatchSiloMaterial8.Text = "Raw Mats"
        frmMain.lblBatchSiloMaterial9.Text = "Raw Mats"

        frmMain.lblBatchSiloWeight1.Text = "0 KG"
        frmMain.lblBatchSiloWeight2.Text = "0 KG"
        frmMain.lblBatchSiloWeight3.Text = "0 KG"
        frmMain.lblBatchSiloWeight4.Text = "0 KG"
        frmMain.lblBatchSiloWeight5.Text = "0 KG"
        frmMain.lblBatchSiloWeight6.Text = "0 KG"
        frmMain.lblBatchSiloWeight7.Text = "0 KG"
        frmMain.lblBatchSiloWeight8.Text = "0 KG"
        frmMain.lblBatchSiloWeight9.Text = "0 KG"
        frmMain.lblbatchingCoco.Text = "0 KG"
        frmMain.lblbatchingMol.Text = "0 KG"

        frmMain.cmbFormulaBatching.SelectedIndex = -1
        frmMain.cmbFormulaBatching.Text = "Select Formula"

        Silo_settings = 0
        Formula = 0
        targetWeight = 0
        liquidCurrentTargetLoad = 0
        currentSilo = ""
        currentTargetLoad = 0
        batchingStatus = False
        GenerateBatchID()

    End Sub
End Module
