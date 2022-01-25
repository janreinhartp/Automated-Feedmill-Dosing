Public Class frmWeightAdjusment
    Dim targetWeight As Integer = 10
    Dim batchweight As Double
    Dim liquidweight As Double
    Dim currentTest As String
    Dim currentWeightAdjustmentBatch As Double
    Dim currentWeightAdjustmentLiquid As Double

    Dim silo1WeightAdjusment, silo2WeightAdjusment, silo3WeightAdjusment, silo4WeightAdjusment, silo5WeightAdjusment,
    silo6WeightAdjusment, silo7WeightAdjusment, silo8WeightAdjusment, silo9WeightAdjusment, molassesWeightAdjusment, cocoOilWeightAdjusment As Double

    Dim siloTestLoad As Double
    Private Sub FrmWeightAdjusment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timerUiUpdate.Start()
    End Sub

    Private Sub BtnWeightAdjustmentStart_Click(sender As Object, e As EventArgs) Handles btnWeightAdjustmentStart.Click
        weightAdjustmentCalculator()
    End Sub

    Private Sub TimerUiUpdate_Tick(sender As Object, e As EventArgs) Handles timerUiUpdate.Tick
        batchweight = CDbl(frmControlOverview.weight)
        liquidweight = CDbl(frmControlOverview.weightLiquid)
    End Sub

    Public Sub weightAdjustmentCalculator()
        Do
            Select Case currentTest
                Case "Silo1"
                    Do
                        siloMotor1 = True
                        If batchweight >= siloTestLoad Then
                            siloMotor1 = False
                            System.Threading.Thread.Sleep(5000)
                            currentSilo = "Silo2"
                            silo1WeightAdjusment = batchweight - siloTestLoad
                            Exit Do
                        End If
                    Loop
                Case "Silo2"
                    Do
                        siloMotor2 = True
                        If batchweight >= (siloTestLoad * 2) Then
                            siloMotor2 = False
                            System.Threading.Thread.Sleep(5000)
                            currentSilo = "Silo3"
                            silo2WeightAdjusment = batchweight - (siloTestLoad * 2) - silo1WeightAdjusment
                            Exit Do
                        End If
                    Loop
                Case "Silo3"
                    Do
                        siloMotor3 = True
                        If batchweight >= (siloTestLoad * 3) Then
                            siloMotor2 = False
                            System.Threading.Thread.Sleep(5000)
                            currentSilo = "Silo4"
                            silo3WeightAdjusment = batchweight - (siloTestLoad * 3) - silo1WeightAdjusment - silo2WeightAdjusment
                            Exit Do
                        End If
                    Loop
                Case "Silo4"
                    Do
                        siloMotor4 = True
                        If batchweight >= (siloTestLoad * 4) Then
                            siloMotor4 = False
                            System.Threading.Thread.Sleep(5000)
                            currentSilo = "Silo5"
                            silo4WeightAdjusment = batchweight - (siloTestLoad * 4) - silo1WeightAdjusment - silo2WeightAdjusment - silo3WeightAdjusment
                            Exit Do
                        End If
                    Loop
                Case "Silo5"
                    Do
                        siloMotor5 = True
                        If batchweight >= (siloTestLoad * 5) Then
                            siloMotor5 = False
                            System.Threading.Thread.Sleep(5000)
                            currentSilo = "Silo6"
                            silo5WeightAdjusment = batchweight - (siloTestLoad * 5) - silo1WeightAdjusment - silo2WeightAdjusment - silo3WeightAdjusment - silo4WeightAdjusment
                            Exit Do
                        End If
                    Loop
                Case "Silo6"
                    Do
                        siloMotor6 = True
                        If batchweight >= (siloTestLoad * 6) Then
                            siloMotor6 = False
                            System.Threading.Thread.Sleep(5000)
                            currentSilo = "Silo7"
                            silo6WeightAdjusment = batchweight - (siloTestLoad * 6) - silo1WeightAdjusment - silo2WeightAdjusment - silo3WeightAdjusment - silo4WeightAdjusment - silo5WeightAdjusment
                            Exit Do
                        End If
                    Loop
                Case "Silo7"
                    Do
                        siloMotor7 = True
                        If batchweight >= (siloTestLoad * 7) Then
                            siloMotor7 = False
                            System.Threading.Thread.Sleep(5000)
                            currentSilo = "Silo8"
                            silo7WeightAdjusment = batchweight - (siloTestLoad * 7) - silo1WeightAdjusment - silo2WeightAdjusment - silo3WeightAdjusment - silo4WeightAdjusment - silo5WeightAdjusment - silo6WeightAdjusment
                            Exit Do
                        End If
                    Loop
                Case "Silo8"
                    Do
                        siloMotor8 = True
                        If batchweight >= (siloTestLoad * 8) Then
                            siloMotor8 = False
                            System.Threading.Thread.Sleep(5000)
                            currentSilo = "Silo9"
                            silo8WeightAdjusment = batchweight - (siloTestLoad * 8) - silo1WeightAdjusment - silo2WeightAdjusment - silo3WeightAdjusment - silo4WeightAdjusment - silo5WeightAdjusment - silo6WeightAdjusment - silo7WeightAdjusment
                            Exit Do
                        End If
                    Loop
                Case "Silo9"
                    Do
                        siloMotor9 = True
                        If batchweight >= (siloTestLoad * 9) Then
                            siloMotor9 = False
                            System.Threading.Thread.Sleep(5000)
                            currentSilo = "Molasses"
                            silo9WeightAdjusment = batchweight - (siloTestLoad * 9) - silo1WeightAdjusment - silo2WeightAdjusment - silo3WeightAdjusment - silo4WeightAdjusment - silo5WeightAdjusment - silo6WeightAdjusment - silo7WeightAdjusment - silo8WeightAdjusment
                            Exit Do
                        End If
                    Loop
                Case "Molasses"
                    Do
                        siloMotor10 = True
                        If liquidweight >= siloTestLoad Then
                            siloMotor10 = False
                            System.Threading.Thread.Sleep(5000)
                            molassesWeightAdjusment = batchweight - siloTestLoad
                            currentSilo = "finish"
                            Exit Do
                        End If
                    Loop
                Case "CocoOil"
                    Do
                        siloMotor11 = True
                        If liquidweight >= (siloTestLoad * 2) Then
                            siloMotor11 = False
                            System.Threading.Thread.Sleep(5000)
                            cocoOilWeightAdjusment = batchweight - (siloTestLoad * 2) - molassesWeightAdjusment
                            currentSilo = "finish"
                            Exit Do
                        End If
                    Loop
                Case "Finish"
                    lblCurrentSilo1WeightAdjustment.Text = silo1WeightAdjusment + " " + "KG"
                    lblCurrentSilo2WeightAdjustment.Text = silo2WeightAdjusment + " " + "KG"
                    lblCurrentSilo3WeightAdjustment.Text = silo3WeightAdjusment + " " + "KG"
                    lblCurrentSilo4WeightAdjustment.Text = silo4WeightAdjusment + " " + "KG"
                    lblCurrentSilo5WeightAdjustment.Text = silo5WeightAdjusment + " " + "KG"
                    lblCurrentSilo6WeightAdjustment.Text = silo6WeightAdjusment + " " + "KG"
                    lblCurrentSilo7WeightAdjustment.Text = silo7WeightAdjusment + " " + "KG"
                    lblCurrentSilo8WeightAdjustment.Text = silo8WeightAdjusment + " " + "KG"
                    lblCurrentSilo9WeightAdjustment.Text = silo9WeightAdjusment + " " + "KG"
                    lblCurrentMolassesWeightAdjustment.Text = molassesWeightAdjusment + " " + "KG"
                    lblCurrentCocooilWeightAdjustment.Text = cocoOilWeightAdjusment + " " + "KG"
                    MsgBox("Weight Adjustment Calculated")
                    Exit Do
            End Select
        Loop
    End Sub

    Private Sub BtnSettingsSave_Click(sender As Object, e As EventArgs) Handles btnSettingsSave.Click
        My.Settings.silo1Adjustment = silo1WeightAdjusment
        My.Settings.silo2Adjustment = silo2WeightAdjusment
        My.Settings.silo3Adjustment = silo3WeightAdjusment
        My.Settings.silo4Adjustment = silo4WeightAdjusment
        My.Settings.silo5Adjustment = silo5WeightAdjusment
        My.Settings.silo6Adjustment = silo6WeightAdjusment
        My.Settings.silo7Adjustment = silo7WeightAdjusment
        My.Settings.silo8Adjustment = silo8WeightAdjusment
        My.Settings.silo9Adjustment = silo9WeightAdjusment
        My.Settings.molassesAdjustment = molassesWeightAdjusment
        My.Settings.cocoOilAdjustment = cocoOilWeightAdjusment

        Try
            My.Settings.Save()
            MsgBox("Settings Successfully Saved")
            Me.Close()
            frmMain.Show()
        Catch ex As Exception
            MsgBox("Error in saving settings" & vbCrLf & ex.Message)
        End Try
    End Sub
End Class