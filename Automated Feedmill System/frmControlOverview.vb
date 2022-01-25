Imports System
Imports System.Threading
Imports System.IO.Ports
Imports System.ComponentModel
Delegate Sub SetTextCallback(ByVal [text] As String)
Public Class frmControlOverview
    Public weight As String
    Public weightLiquid As String
    Private Sub FrmControlOverview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conWeight.PortName = My.Settings.batchScaleComport
        conWeight.BaudRate = "9600"

        conWeightLiquid.PortName = My.Settings.liquidScaleComport
        conWeightLiquid.BaudRate = "9600"

        conWeightTimer.Start()
    End Sub
    Private Sub conWeight_DataReceived(sender As System.Object, e As System.IO.Ports.SerialDataReceivedEventArgs) Handles conWeight.DataReceived
        receivedText(conWeight.ReadExisting())
    End Sub
    Private Sub receivedText(ByVal [text] As String)
        If Me.lblWeight.InvokeRequired Then
            Dim x As New SetTextCallback(AddressOf receivedText)
            Me.Invoke(x, New Object() {(text)})
        Else


            Dim reverseString As String = [text]
            Dim revString As String = StrReverse(reverseString)
            Dim clean As String
            clean = revString.Replace("=", "")
            weight = clean
            Me.lblWeight.Text = clean + " KG" 'append text
        End If
    End Sub

    Private Sub conWeightLiquid_DataReceived(sender As System.Object, e As System.IO.Ports.SerialDataReceivedEventArgs) Handles conWeightLiquid.DataReceived
        receivedTextliquid(conWeightLiquid.ReadExisting())
    End Sub
    Private Sub receivedTextliquid(ByVal [text] As String)
        If Me.lblWeight.InvokeRequired Then
            Dim x As New SetTextCallback(AddressOf receivedTextliquid)
            Me.Invoke(x, New Object() {(text)})
        Else


            Dim reverseString As String = [text]
            Dim revString As String = StrReverse(reverseString)
            Dim clean As String
            clean = revString.Replace("=", "")
            weightLiquid = clean
            Me.lblweightLiquid.Text = clean + " KG" 'append text
        End If
    End Sub

    Private Sub ConWeightTimer_Tick(sender As Object, e As EventArgs) Handles conWeightTimer.Tick
        Try
            conWeightLiquid.Open()
            Me.Text = "PLC to VB.Net"
        Catch ex As Exception
            Me.Text = ex.Message
        End Try
        Try
            conWeight.Open()
            Me.Text = "PLC to VB.Net"
        Catch ex As Exception
            Me.Text = ex.Message
        End Try

        If (conWeightLiquid.IsOpen = True) And (conWeight.IsOpen = True) Then
            conWeightTimer.Stop()
        End If
    End Sub


End Class