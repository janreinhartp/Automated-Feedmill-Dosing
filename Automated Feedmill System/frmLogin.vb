Public Class frmLogin
    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtbPassword._TextBox.PasswordChar = "*"
    End Sub
    Function login() As Integer
        connect()

        conn.Open()

        cmd = conn.CreateCommand

        cmd.CommandText = "SELECT * FROM tblusers WHERE USERNAME='" & txtbUser.text & "' AND PASSWORD='" & txtbPassword.text & "' AND STATUS='Activated'"

        dr = cmd.ExecuteReader()

        If dr.HasRows Then
            dr.Read()
            If UCase(dr.Item("USERNAME").ToString) = UCase(txtbUser.text) And dr.Item("PASSWORD").ToString = txtbPassword.text Then
                If dr.Item("POSITION").ToString = "Administrator" Then
                    frmMain.btnFormula.Enabled = True
                    frmMain.btnSiloSettings.Enabled = True
                    frmMain.btnReports.Enabled = True
                    frmMain.btnUserSettings.Enabled = True
                    frmMain.btnSettings.Enabled = False
                    frmMain.btnBatching.Enabled = True
                    frmMain.btnAutomaticControl.Enabled = True

                    frmMain.btnFormula.Visible = True
                    frmMain.btnSiloSettings.Visible = True
                    frmMain.btnReports.Visible = True
                    frmMain.btnUserSettings.Visible = True
                    frmMain.btnSettings.Visible = False
                    frmMain.btnBatching.Visible = True
                    frmMain.btnAutomaticControl.Visible = True

                    frmMain.lblName.Text = dr.Item("F_NAME") + " " + dr.Item("L_NAME")
                    OperatorID = dr.Item("USER_ID")
                    frmMain.Show()
                    Me.Hide()

                ElseIf dr.Item("POSITION").ToString = "Operator" Then
                    frmMain.btnFormula.Enabled = False
                    frmMain.btnSiloSettings.Enabled = False
                    frmMain.btnReports.Enabled = False
                    frmMain.btnUserSettings.Enabled = False
                    frmMain.btnSettings.Enabled = False
                    frmMain.btnBatching.Enabled = True
                    frmMain.btnAutomaticControl.Enabled = True

                    frmMain.btnFormula.Visible = False
                    frmMain.btnSiloSettings.Visible = False
                    frmMain.btnReports.Visible = False
                    frmMain.btnUserSettings.Visible = False
                    frmMain.btnSettings.Visible = False
                    frmMain.btnBatching.Visible = True
                    frmMain.btnAutomaticControl.Visible = True

                    frmMain.lblName.Text = dr.Item("F_NAME") + " " + dr.Item("L_NAME")
                    OperatorID = dr.Item("USER_ID")
                    frmMain.Show()
                    Me.Hide()

                ElseIf dr.Item("POSITION").ToString = "Maintenance" Then
                    frmMain.btnFormula.Enabled = True
                    frmMain.btnSiloSettings.Enabled = True
                    frmMain.btnReports.Enabled = True
                    frmMain.btnUserSettings.Enabled = True
                    frmMain.btnSettings.Enabled = True
                    frmMain.btnBatching.Enabled = True
                    frmMain.btnAutomaticControl.Enabled = True

                    frmMain.btnFormula.Visible = True
                    frmMain.btnSiloSettings.Visible = True
                    frmMain.btnReports.Visible = True
                    frmMain.btnUserSettings.Visible = True
                    frmMain.btnSettings.Visible = True
                    frmMain.btnBatching.Visible = True
                    frmMain.btnAutomaticControl.Visible = True

                    frmMain.lblName.Text = dr.Item("F_NAME") + " " + dr.Item("L_NAME")
                    OperatorID = dr.Item("USER_ID")
                    frmMain.Show()
                    Me.Hide()

                ElseIf dr.Item("POSITION").ToString = "Clerk" Then
                    frmMain.btnFormula.Enabled = False
                    frmMain.btnSiloSettings.Enabled = False
                    frmMain.btnReports.Enabled = True
                    frmMain.btnUserSettings.Enabled = False
                    frmMain.btnSettings.Enabled = False
                    frmMain.btnBatching.Enabled = False
                    frmMain.btnAutomaticControl.Enabled = False

                    frmMain.btnFormula.Visible = False
                    frmMain.btnSiloSettings.Visible = False
                    frmMain.btnReports.Visible = True
                    frmMain.btnUserSettings.Visible = False
                    frmMain.btnSettings.Visible = False
                    frmMain.btnBatching.Visible = False
                    frmMain.btnAutomaticControl.Visible = False

                    frmMain.lblName.Text = dr.Item("F_NAME") + " " + dr.Item("L_NAME")
                    OperatorID = dr.Item("USER_ID")
                    frmMain.Show()
                    Me.Hide()
                End If

            Else
                MsgBox("Invalid Username\Password.", vbExclamation, "Point of Sale")
                txtbUser.text = ""
                txtbPassword.text = ""
                txtbUser.Focus()
            End If
        Else
            MsgBox("User Account not found.", vbExclamation, "Point of Sale")
            txtbUser.text = ""
            txtbPassword.text = ""
            txtbUser.Focus()
        End If


        dr.Close()
        conn.Close()
        Return 0
    End Function

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        login()

    End Sub

    Private Sub TxtbPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            login()
        End If
    End Sub
End Class