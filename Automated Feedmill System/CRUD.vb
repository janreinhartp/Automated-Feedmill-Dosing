Imports System.Data
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Module CRUD
    'FOR SILO SETTINGS
    Function addSIloSettings() As Integer
        connect()

        conn.Open()

        cmd = conn.CreateCommand

        cmd.CommandText = "SELECT * FROM tblsilosettings WHERE SILO_SETTING_ID='" & frmMain.lblSiloSetNo.Text & "'"

        dr = cmd.ExecuteReader()

        If dr.HasRows Then
            MsgBox("Silo Setting Already Exist!", vbExclamation, "Point of Sale")
        Else


            conn.Close()
            conn.Open()
            cmd = conn.CreateCommand
            cmd.CommandText = String.Format("INSERT INTO tblsilosettings (SILO_SETTING_ID,SILO_SETTING_NAME,SILO1,SILO2,SILO3,SILO4,SILO5,SILO6,SILO7,SILO8,SILO9) VALUES 
                                                                         ('" & frmMain.lblSiloSetNo.Text & "','" & frmMain.txtbSiloSetName.Text & "','" & frmMain.txtbSiloSetSilo1.Text & "','" & frmMain.txtbSiloSetSilo2.Text & "','" & frmMain.txtbSiloSetSilo3.Text & "','" & frmMain.txtbSiloSetSilo4.Text & "',
                                                                            '" & frmMain.txtbSiloSetSilo5.Text & "','" & frmMain.txtbSiloSetSilo6.Text & "','" & frmMain.txtbSiloSetSilo7.Text & "','" & frmMain.txtbSiloSetSilo8.Text & "','" & frmMain.txtbSiloSetSilo9.Text & "')")
            cmd.ExecuteNonQuery()


            clearSiloSet()

        End If
        dr.Close()

        conn.Close()
        clearSiloSet()
        LoadSiloSettings()
        Return 0
    End Function

    Function deleteSiloSettings() As Integer
        If MsgBox("Are you sure do you want to delete this Silo Setting?", vbQuestion + vbYesNo, "Confirmation") = vbYes Then
            Dim siloNo As Integer = CInt(frmMain.lblSiloSetNo.Text)

            connect()
            conn.Open()

            cmd = conn.CreateCommand

            cmd.CommandText = String.Format("DELETE FROM tblsilosettings WHERE SILO_SETTING_ID= '" & siloNo & "' ")

            Dim affectedRows As Integer = cmd.ExecuteNonQuery

            If affectedRows > 0 Then
                MsgBox("Successfully deleted!", vbInformation, "Point of Sale")
            Else
                MsgBox("Failed to delete!", vbExclamation, "Point of Sale")
            End If

            conn.Close()
            clearSiloSet()
        End If

        Return 0
    End Function

    Function updateSiloSettings() As Integer
        connect()

        conn.Open()
        cmd = conn.CreateCommand
        cmd.CommandText = String.Format("UPDATE tblsilosettings SET SILO_SETTING_NAME='" & frmMain.txtbSiloSetName.Text & "', SILO1='" & frmMain.txtbSiloSetSilo1.Text & "',SILO2='" & frmMain.txtbSiloSetSilo2.Text & "',SILO3='" & frmMain.txtbSiloSetSilo3.Text & "',SILO4='" & frmMain.txtbSiloSetSilo4.Text & "',SILO5='" & frmMain.txtbSiloSetSilo5.Text & "',SILO6='" & frmMain.txtbSiloSetSilo6.Text & "',SILO7='" & frmMain.txtbSiloSetSilo7.Text & "',SILO8='" & frmMain.txtbSiloSetSilo8.Text & "',SILO9='" & frmMain.txtbSiloSetSilo9.Text & "'  WHERE SILO_SETTING_ID='" & frmMain.lblSiloSetNo.Text & "'")



        Dim affectedRows As Integer = cmd.ExecuteNonQuery

        If affectedRows > 0 Then
            MsgBox("Successfully updated!", vbInformation, "Point of Sale")
        Else
            MsgBox("Failed to update!", vbInformation, "Point of Sale")
        End If

        conn.Close()
        clearSiloSet()
        Return 0
    End Function

    Dim siloID As Integer
    Function getSiloID() As Integer
        Try
            connect()
            conn.Open()

            cmd = conn.CreateCommand
            cmd.CommandText = "SELECT MAX(SILO_SETTING_ID) FROM tblsilosettings"
            siloID = cmd.ExecuteScalar
            siloID += 1
        Catch ex As Exception
            siloID = 1
        End Try

        conn.Close()
        frmMain.lblSiloSetNo.Text = siloID
        Return 0
    End Function

    Function clearSiloSet() As Integer
        frmMain.txtbSiloSetName.Clear()
        frmMain.lblSiloSetNo.Text = 0
        frmMain.txtbSiloSetSilo1.Clear()
        frmMain.txtbSiloSetSilo2.Clear()
        frmMain.txtbSiloSetSilo3.Clear()
        frmMain.txtbSiloSetSilo4.Clear()
        frmMain.txtbSiloSetSilo5.Clear()
        frmMain.txtbSiloSetSilo6.Clear()
        frmMain.txtbSiloSetSilo7.Clear()
        frmMain.txtbSiloSetSilo8.Clear()
        frmMain.txtbSiloSetSilo9.Clear()
        getSiloID()
        LoadSiloSettings()
        Return 0
    End Function

    Function LoadSiloSettings() As Integer
        connect()
        conn.Open()
        cmd = conn.CreateCommand

        cmd.CommandText = "SELECT SILO_SETTING_ID, SILO_SETTING_NAME FROM tblsilosettings"

        dr = cmd.ExecuteReader()

        If dr.HasRows Then
            Dim dtUsers As New DataTable
            dtUsers.Load(dr)
            frmMain.dgvSiloSettings.DataSource = dtUsers
        Else

        End If
        Try
            'Renaming the columns
            frmMain.dgvSiloSettings.Columns(0).HeaderCell.Value = "ID"
            frmMain.dgvSiloSettings.Columns(1).HeaderCell.Value = "Silo Setting Name"
            frmMain.dgvSiloSettings.ClearSelection() 'No initial selection
        Catch ex As Exception

        End Try

        conn.Close()

        Return 0
    End Function

    Function dgvClickSiloSettings() As Integer
        frmMain.lblSiloSetNo.Text = frmMain.dgvSiloSettings.SelectedRows(0).Cells(0).Value

        connect()
        conn.Open()
        cmd = conn.CreateCommand
        cmd.CommandText = "SELECT * FROM tblsilosettings WHERE SILO_SETTING_ID='" & frmMain.lblSiloSetNo.Text & "'"
        dr = cmd.ExecuteReader()

        If dr.HasRows Then
            dr.Read()
            frmMain.txtbSiloSetName.Text = dr.Item("SILO_SETTING_NAME").ToString
            frmMain.lblSiloSetNo.Text = dr.Item("SILO_SETTING_ID").ToString
            frmMain.txtbSiloSetSilo1.Text = dr.Item("SILO1").ToString
            frmMain.txtbSiloSetSilo2.Text = dr.Item("SILO2").ToString
            frmMain.txtbSiloSetSilo3.Text = dr.Item("SILO3").ToString
            frmMain.txtbSiloSetSilo4.Text = dr.Item("SILO4").ToString
            frmMain.txtbSiloSetSilo5.Text = dr.Item("SILO5").ToString
            frmMain.txtbSiloSetSilo6.Text = dr.Item("SILO6").ToString
            frmMain.txtbSiloSetSilo7.Text = dr.Item("SILO7").ToString
            frmMain.txtbSiloSetSilo8.Text = dr.Item("SILO8").ToString
            frmMain.txtbSiloSetSilo9.Text = dr.Item("SILO9").ToString

        Else
            MsgBox("Settings Not Found", vbExclamation, "Point of Sale")

        End If

        dr.Close()
        conn.Close()
        Return 0

    End Function


    'FOR Formulation
    Function addFormula() As Integer
        connect()

        conn.Open()

        cmd = conn.CreateCommand

        cmd.CommandText = "SELECT * FROM tblformula WHERE FORMULA_ID='" & frmMain.lblFormulaId.Text & "'"

        dr = cmd.ExecuteReader()

        If dr.HasRows Then
            MsgBox("Formula Already Exist!", vbExclamation, "Point of Sale")
        Else


            conn.Close()
            conn.Open()
            cmd = conn.CreateCommand
            cmd.CommandText = String.Format("INSERT INTO tblformula (FORMULA_ID,FORMULA_NAME,SILO_SETTING_ID,SILO1_WEIGHT,SILO2_WEIGHT,SILO3_WEIGHT,SILO4_WEIGHT,SILO5_WEIGHT,SILO6_WEIGHT,SILO7_WEIGHT,SILO8_WEIGHT,SILO9_WEIGHT,MOLASSES,COCOOIL) VALUES 
                                                                         ('" & frmMain.lblFormulaId.Text & "','" & frmMain.txtbFormulaName.Text & "','" & formulaSiloSettingId & "','" & frmMain.txtbFormSilo1.Text & "','" & frmMain.txtbFormSilo2.Text & "','" & frmMain.txtbFormSilo3.Text & "',
                                                                            '" & frmMain.txtbFormSilo4.Text & "','" & frmMain.txtbFormSilo5.Text & "','" & frmMain.txtbFormSilo6.Text & "','" & frmMain.txtbFormSilo7.Text & "','" & frmMain.txtbFormSilo8.Text & "','" & frmMain.txtbFormSilo9.Text & "','" & frmMain.txtbFormMolasses.Text & "','" & frmMain.txtbFormCoco.Text & "')")
            cmd.ExecuteNonQuery()
        End If
        dr.Close()
        conn.Close()
        clearFormula()
        Return 0
    End Function

    Function deleteFormula() As Integer
        If MsgBox("Are you sure do you want to delete this Formula?", vbQuestion + vbYesNo, "Confirmation") = vbYes Then


            connect()
            conn.Open()

            cmd = conn.CreateCommand

            cmd.CommandText = String.Format("DELETE FROM tblformula WHERE FORMULA_ID= '" & frmMain.lblFormulaId.Text & "' ")

            Dim affectedRows As Integer = cmd.ExecuteNonQuery

            If affectedRows > 0 Then
                MsgBox("Successfully deleted!", vbInformation, "Point of Sale")
            Else
                MsgBox("Failed to delete!", vbExclamation, "Point of Sale")
            End If

            conn.Close()
            clearFormula()
        End If

        Return 0
    End Function
    Function formulaLoadSiloSetting() As Integer
        connect()
        conn.Open()
        cmd = conn.CreateCommand

        cmd.CommandText = "SELECT SILO_SETTING_NAME FROM tblsilosettings"
        Dim adapter As New MySqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)

        frmMain.cmbFormSiloSet.DataSource = table
        frmMain.cmbFormSiloSet.DisplayMember = "SILO_SETTING_NAME"


        frmMain.cmbFormSiloSet.SelectedItem = Nothing
        frmMain.cmbFormSiloSet.Text = "Select Silo Settings"
        Return 0
    End Function

    Function dgvClickFormula() As Integer
        frmMain.lblFormulaId.Text = frmMain.dgvFormula.SelectedRows(0).Cells(0).Value

        frmMain.txtbFormSilo1.Enabled = True
        frmMain.txtbFormSilo2.Enabled = True
        frmMain.txtbFormSilo3.Enabled = True
        frmMain.txtbFormSilo4.Enabled = True
        frmMain.txtbFormSilo5.Enabled = True
        frmMain.txtbFormSilo6.Enabled = True
        frmMain.txtbFormSilo7.Enabled = True
        frmMain.txtbFormSilo8.Enabled = True
        frmMain.txtbFormSilo9.Enabled = True

        connect()
        conn.Open()
        cmd = conn.CreateCommand
        cmd.CommandText = "SELECT * FROM tblformula WHERE FORMULA_ID='" & frmMain.lblFormulaId.Text & "'"
        dr = cmd.ExecuteReader()

        If dr.HasRows Then
            dr.Read()
            frmMain.txtbFormulaName.Text = dr.Item("FORMULA_NAME").ToString
            formulaSiloSettingId = dr.Item("SILO_SETTING_ID").ToString
            frmMain.txtbFormSilo1.Text = dr.Item("SILO1_WEIGHT").ToString
            frmMain.txtbFormSilo2.Text = dr.Item("SILO2_WEIGHT").ToString
            frmMain.txtbFormSilo3.Text = dr.Item("SILO3_WEIGHT").ToString
            frmMain.txtbFormSilo4.Text = dr.Item("SILO4_WEIGHT").ToString
            frmMain.txtbFormSilo5.Text = dr.Item("SILO5_WEIGHT").ToString
            frmMain.txtbFormSilo6.Text = dr.Item("SILO6_WEIGHT").ToString
            frmMain.txtbFormSilo7.Text = dr.Item("SILO7_WEIGHT").ToString
            frmMain.txtbFormSilo8.Text = dr.Item("SILO8_WEIGHT").ToString
            frmMain.txtbFormSilo9.Text = dr.Item("SILO9_WEIGHT").ToString
            frmMain.txtbFormCoco.Text = dr.Item("MOLASSES").ToString
            frmMain.txtbFormMolasses.Text = dr.Item("COCOOIL").ToString
        Else
            MsgBox("Settings Not Found", vbExclamation, "Point of Sale")

        End If

        dr.Close()
        conn.Close()

        selectSiloSetOnFormula()
        Return 0
    End Function

    Public formulaSiloSettingId As Integer

    Function selectSiloSetOnFormulaUsingName() As Integer

        connect()

        conn.Open()

        cmd = conn.CreateCommand

        cmd.CommandText = "SELECT * FROM tblsilosettings WHERE SILO_SETTING_NAME='" & frmMain.cmbFormSiloSet.Text & "'"

        dr = cmd.ExecuteReader()

        If dr.HasRows Then
            dr.Read()
            If dr.Item("SILO1").ToString = "" Then
                frmMain.txtbFormSilo1.Enabled = False

            Else
                frmMain.txtbFormSilo1.Enabled = True
            End If
            If dr.Item("SILO2").ToString = "" Then
                frmMain.txtbFormSilo2.Enabled = False
            Else
                frmMain.txtbFormSilo2.Enabled = True
            End If
            If dr.Item("SILO3").ToString = "" Then
                frmMain.txtbFormSilo3.Enabled = False
            Else
                frmMain.txtbFormSilo3.Enabled = True
            End If

            If dr.Item("SILO4").ToString = "" Then
                frmMain.txtbFormSilo4.Enabled = False
            Else
                frmMain.txtbFormSilo4.Enabled = True
            End If
            If dr.Item("SILO5").ToString = "" Then
                frmMain.txtbFormSilo5.Enabled = False
            Else
                frmMain.txtbFormSilo5.Enabled = True
            End If
            If dr.Item("SILO6").ToString = "" Then
                frmMain.txtbFormSilo6.Enabled = False
            Else
                frmMain.txtbFormSilo6.Enabled = True
            End If
            If dr.Item("SILO7").ToString = "" Then
                frmMain.txtbFormSilo7.Enabled = False
            Else
                frmMain.txtbFormSilo7.Enabled = True
            End If
            If dr.Item("SILO8").ToString = "" Then
                frmMain.txtbFormSilo8.Enabled = False
            Else
                frmMain.txtbFormSilo8.Enabled = True
            End If
            If dr.Item("SILO9").ToString = "" Then
                frmMain.txtbFormSilo9.Enabled = False

            Else
                frmMain.txtbFormSilo9.Enabled = True

            End If

            frmMain.lblFormulaSilo1.Text = dr.Item("SILO1").ToString
            frmMain.lblFormulaSilo2.Text = dr.Item("SILO2").ToString
            frmMain.lblFormulaSilo3.Text = dr.Item("SILO3").ToString
            frmMain.lblFormulaSilo4.Text = dr.Item("SILO4").ToString
            frmMain.lblFormulaSilo5.Text = dr.Item("SILO5").ToString
            frmMain.lblFormulaSilo6.Text = dr.Item("SILO6").ToString
            frmMain.lblFormulaSilo7.Text = dr.Item("SILO7").ToString
            frmMain.lblFormulaSilo8.Text = dr.Item("SILO8").ToString
            frmMain.lblFormulaSilo9.Text = dr.Item("SILO9").ToString
            formulaSiloSettingId = dr.Item("SILO_SETTING_ID")
            frmMain.cmbFormSiloSet.Text = dr.Item("SILO_SETTING_NAME").ToString
        Else



        End If

        dr.Close()
        conn.Close()


        Return 0
    End Function

    Function selectSiloSetOnFormula() As Integer

        connect()

        conn.Open()

        cmd = conn.CreateCommand

        cmd.CommandText = "SELECT * FROM tblsilosettings WHERE SILO_SETTING_ID='" & formulaSiloSettingId & "'"

        dr = cmd.ExecuteReader()

        If dr.HasRows Then
            dr.Read()
            If dr.Item("SILO1").ToString = "" Then
                frmMain.txtbFormSilo1.Enabled = False

            Else
                frmMain.txtbFormSilo1.Enabled = True
            End If
            If dr.Item("SILO2").ToString = "" Then
                frmMain.txtbFormSilo2.Enabled = False
            Else
                frmMain.txtbFormSilo2.Enabled = True
            End If
            If dr.Item("SILO3").ToString = "" Then
                frmMain.txtbFormSilo3.Enabled = False
            Else
                frmMain.txtbFormSilo3.Enabled = True
            End If

            If dr.Item("SILO4").ToString = "" Then
                frmMain.txtbFormSilo4.Enabled = False
            Else
                frmMain.txtbFormSilo4.Enabled = True
            End If
            If dr.Item("SILO5").ToString = "" Then
                frmMain.txtbFormSilo5.Enabled = False
            Else
                frmMain.txtbFormSilo5.Enabled = True
            End If
            If dr.Item("SILO6").ToString = "" Then
                frmMain.txtbFormSilo6.Enabled = False
            Else
                frmMain.txtbFormSilo6.Enabled = True
            End If
            If dr.Item("SILO7").ToString = "" Then
                frmMain.txtbFormSilo7.Enabled = False
            Else
                frmMain.txtbFormSilo7.Enabled = True
            End If
            If dr.Item("SILO8").ToString = "" Then
                frmMain.txtbFormSilo8.Enabled = False
            Else
                frmMain.txtbFormSilo8.Enabled = True
            End If
            If dr.Item("SILO9").ToString = "" Then
                frmMain.txtbFormSilo9.Enabled = False

            Else
                frmMain.txtbFormSilo9.Enabled = True

            End If

            frmMain.lblFormulaSilo1.Text = dr.Item("SILO1").ToString
            frmMain.lblFormulaSilo2.Text = dr.Item("SILO2").ToString
            frmMain.lblFormulaSilo3.Text = dr.Item("SILO3").ToString
            frmMain.lblFormulaSilo4.Text = dr.Item("SILO4").ToString
            frmMain.lblFormulaSilo5.Text = dr.Item("SILO5").ToString
            frmMain.lblFormulaSilo6.Text = dr.Item("SILO6").ToString
            frmMain.lblFormulaSilo7.Text = dr.Item("SILO7").ToString
            frmMain.lblFormulaSilo8.Text = dr.Item("SILO8").ToString
            frmMain.lblFormulaSilo9.Text = dr.Item("SILO9").ToString
            formulaSiloSettingId = dr.Item("SILO_SETTING_ID")
            frmMain.cmbFormSiloSet.Text = dr.Item("SILO_SETTING_NAME").ToString
        Else



        End If

        dr.Close()
        conn.Close()


        Return 0
    End Function
    Function updateFormula() As Integer
        connect()

        conn.Open()
        cmd = conn.CreateCommand
        cmd.CommandText = String.Format("UPDATE tblformula SET FORMULA_NAME='" & frmMain.txtbFormulaName.Text & "',SILO_SETTING_ID='" & formulaSiloSettingId & "', SILO1_WEIGHT='" & frmMain.txtbFormSilo1.Text & "',SILO2_WEIGHT='" & frmMain.txtbFormSilo2.Text & "',SILO3_WEIGHT='" & frmMain.txtbFormSilo3.Text & "',SILO4_WEIGHT='" & frmMain.txtbFormSilo4.Text & "',SILO5_WEIGHT='" & frmMain.txtbFormSilo5.Text & "',SILO6_WEIGHT='" & frmMain.txtbFormSilo6.Text & "',SILO7_WEIGHT='" & frmMain.txtbFormSilo7.Text & "',SILO8_WEIGHT='" & frmMain.txtbFormSilo8.Text & "',SILO9_WEIGHT='" & frmMain.txtbFormSilo9.Text & "',MOLASSES='" & frmMain.txtbFormMolasses.Text & "',COCOOIL='" & frmMain.txtbFormCoco.Text & "'  WHERE FORMULA_ID='" & frmMain.lblFormulaId.Text & "'")



        Dim affectedRows As Integer = cmd.ExecuteNonQuery

        If affectedRows > 0 Then
            MsgBox("Successfully updated!", vbInformation, "Point of Sale")
        Else
            MsgBox("Failed to update!", vbInformation, "Point of Sale")
        End If

        conn.Close()
        clearSiloSet()
        Return 0
    End Function

    Dim formulaID As Integer
    Function getFormulaID() As Integer
        Try
            connect()
            conn.Open()

            cmd = conn.CreateCommand
            cmd.CommandText = "SELECT MAX(FORMULA_ID) FROM tblformula"
            formulaID = cmd.ExecuteScalar
            formulaID += 1
        Catch ex As Exception
            formulaID = 1
        End Try

        conn.Close()
        frmMain.lblFormulaId.Text = formulaID
        Return 0
    End Function

    Function clearFormula() As Integer
        frmMain.cmbFormSiloSet.SelectedItem = 0
        frmMain.txtbFormulaName.Clear()
        frmMain.lblFormulaId.Text = 0
        frmMain.txtbFormSilo1.Clear()
        frmMain.txtbFormSilo2.Clear()
        frmMain.txtbFormSilo3.Clear()
        frmMain.txtbFormSilo4.Clear()
        frmMain.txtbFormSilo5.Clear()
        frmMain.txtbFormSilo6.Clear()
        frmMain.txtbFormSilo7.Clear()
        frmMain.txtbFormSilo8.Clear()
        frmMain.txtbFormSilo9.Clear()
        frmMain.txtbFormCoco.Clear()
        frmMain.txtbFormMolasses.Clear()

        frmMain.txtbFormSilo1.Enabled = True
        frmMain.txtbFormSilo2.Enabled = True
        frmMain.txtbFormSilo3.Enabled = True
        frmMain.txtbFormSilo4.Enabled = True
        frmMain.txtbFormSilo5.Enabled = True
        frmMain.txtbFormSilo6.Enabled = True
        frmMain.txtbFormSilo7.Enabled = True
        frmMain.txtbFormSilo8.Enabled = True
        frmMain.txtbFormSilo9.Enabled = True

        frmMain.lblFormulaSilo1.Text = "Raw Mats"
        frmMain.lblFormulaSilo2.Text = "Raw Mats"
        frmMain.lblFormulaSilo3.Text = "Raw Mats"
        frmMain.lblFormulaSilo4.Text = "Raw Mats"
        frmMain.lblFormulaSilo5.Text = "Raw Mats"
        frmMain.lblFormulaSilo6.Text = "Raw Mats"
        frmMain.lblFormulaSilo7.Text = "Raw Mats"
        frmMain.lblFormulaSilo8.Text = "Raw Mats"
        frmMain.lblFormulaSilo9.Text = "Raw Mats"


        getFormulaID()
        loadFormula()
        Return 0
    End Function

    Function loadFormula() As Integer
        connect()
        conn.Open()
        cmd = conn.CreateCommand

        cmd.CommandText = "SELECT FORMULA_ID, FORMULA_NAME FROM tblformula"

        dr = cmd.ExecuteReader()

        If dr.HasRows Then
            Dim dtUsers As New DataTable
            dtUsers.Load(dr)
            frmMain.dgvFormula.DataSource = dtUsers
        Else

        End If
        Try
            'Renaming the columns
            frmMain.dgvFormula.Columns(0).HeaderCell.Value = "ID"
            frmMain.dgvFormula.Columns(1).HeaderCell.Value = "formula Name"
            frmMain.dgvFormula.ClearSelection() 'No initial selection
        Catch ex As Exception

        End Try

        conn.Close()

        Return 0
    End Function

    'FOR User
    Function addUser() As Integer
        connect()

        conn.Open()

        cmd = conn.CreateCommand

        cmd.CommandText = "SELECT * FROM tblusers WHERE USER_ID='" & frmMain.lblUserID.Text & "'"

        dr = cmd.ExecuteReader()

        If dr.HasRows Then
            MsgBox("USER Already Exist!", vbExclamation, "Point of Sale")
        Else


            conn.Close()
            conn.Open()
            cmd = conn.CreateCommand
            cmd.CommandText = String.Format("INSERT INTO tblusers (USER_ID,F_NAME,M_NAME,L_NAME,USERNAME,PASSWORD,STATUS,POSITION) VALUES 
                                                                         ('" & frmMain.lblUserID.Text & "','" & frmMain.txtbUserFName.Text & "','" & frmMain.txtbUserMName.Text & "','" & frmMain.txtbUserLName.Text & "','" & frmMain.txtbUserUsername.Text & "','" & frmMain.txtbUserPassword.Text & "',
                                                                            '" & frmMain.cmbUserPosition.Text & "','" & frmMain.cmbUserStatus.Text & "')")
            cmd.ExecuteNonQuery()
        End If
        dr.Close()
        conn.Close()
        clearUser()

        Return 0
    End Function
    Function updateUser() As Integer
        connect()

        conn.Open()
        cmd = conn.CreateCommand
        cmd.CommandText = String.Format("UPDATE tblusers SET F_NAME='" & frmMain.txtbUserFName.Text & "',M_NAME='" & frmMain.txtbUserMName.Text & "', L_NAME='" & frmMain.txtbUserLName.Text & "',USERNAME='" & frmMain.txtbUserUsername.Text & "',PASSWORD='" & frmMain.txtbUserPassword.Text & "',STATUS='" & frmMain.cmbUserStatus.Text & "',POSITION='" & frmMain.cmbUserPosition.Text & "'  WHERE USER_ID='" & frmMain.lblUserID.Text & "'")



        Dim affectedRows As Integer = cmd.ExecuteNonQuery

        If affectedRows > 0 Then
            MsgBox("Successfully updated!", vbInformation, "Point of Sale")
        Else
            MsgBox("Failed to update!", vbInformation, "Point of Sale")
        End If

        conn.Close()
        clearUser()
        Return 0
    End Function
    Function deleteUser() As Integer
        If MsgBox("Are you sure do you want to delete this Formula?", vbQuestion + vbYesNo, "Confirmation") = vbYes Then


            connect()
            conn.Open()

            cmd = conn.CreateCommand

            cmd.CommandText = String.Format("DELETE FROM tblusers WHERE USER_ID= '" & frmMain.lblUserID.Text & "' ")

            Dim affectedRows As Integer = cmd.ExecuteNonQuery

            If affectedRows > 0 Then
                MsgBox("Successfully deleted!", vbInformation, "Point of Sale")
            Else
                MsgBox("Failed to delete!", vbExclamation, "Point of Sale")
            End If

            conn.Close()
            clearUser()
        End If

        Return 0
    End Function

    Dim userID As Integer
    Function getUserID() As Integer
        Try
            connect()
            conn.Open()

            cmd = conn.CreateCommand
            cmd.CommandText = "SELECT MAX(USER_ID) FROM tblusers"
            userID = cmd.ExecuteScalar
            userID += 1
        Catch ex As Exception
            userID = 1
        End Try

        conn.Close()
        frmMain.lblUserID.Text = userID
        Return 0
    End Function
    Function clearUser() As Integer
        frmMain.cmbUserPosition.SelectedIndex = -1
        frmMain.cmbUserStatus.SelectedIndex = -1
        frmMain.cmbUserPosition.Text = "Select Status"
        frmMain.cmbUserStatus.Text = "Select Position"
        frmMain.txtbUserFName.Clear()
        frmMain.lblUserID.Text = 0
        frmMain.txtbUserMName.Clear()
        frmMain.txtbUserLName.Clear()
        frmMain.txtbUserPassword.Clear()
        frmMain.txtbUserUsername.Clear()

        getUserID()
        loadUser()
        Return 0
    End Function

    Function loadUser() As Integer
        connect()
        conn.Open()
        cmd = conn.CreateCommand

        cmd.CommandText = "SELECT * FROM tblusers"

        dr = cmd.ExecuteReader()

        If dr.HasRows Then
            Dim dtUsers As New DataTable
            dtUsers.Load(dr)
            frmMain.dgvUsers.DataSource = dtUsers
        Else

        End If
        Try
            'Renaming the columns
            frmMain.dgvUsers.Columns(0).HeaderCell.Value = "User ID"
            frmMain.dgvUsers.Columns(1).HeaderCell.Value = "First Name"
            frmMain.dgvUsers.Columns(2).HeaderCell.Value = "Middle Name"
            frmMain.dgvUsers.Columns(3).HeaderCell.Value = "Last Name"
            frmMain.dgvUsers.Columns(4).HeaderCell.Value = "Username"
            frmMain.dgvUsers.Columns(5).HeaderCell.Value = "Password"
            frmMain.dgvUsers.Columns(6).HeaderCell.Value = "Status"
            frmMain.dgvUsers.Columns(7).HeaderCell.Value = "Position"
            frmMain.dgvFormula.ClearSelection() 'No initial selection
        Catch ex As Exception

        End Try

        conn.Close()

        Return 0
    End Function

    Function dgvClickUser() As Integer
        frmMain.lblUserID.Text = frmMain.dgvUsers.SelectedRows(0).Cells(0).Value
        frmMain.txtbUserFName.Text = frmMain.dgvUsers.SelectedRows(0).Cells(1).Value
        frmMain.txtbUserMName.Text = frmMain.dgvUsers.SelectedRows(0).Cells(2).Value
        frmMain.txtbUserLName.Text = frmMain.dgvUsers.SelectedRows(0).Cells(3).Value
        frmMain.txtbUserUsername.Text = frmMain.dgvUsers.SelectedRows(0).Cells(4).Value
        frmMain.txtbUserPassword.Text = frmMain.dgvUsers.SelectedRows(0).Cells(5).Value
        frmMain.cmbUserStatus.Text = frmMain.dgvUsers.SelectedRows(0).Cells(6).Value
        frmMain.cmbUserPosition.Text = frmMain.dgvUsers.SelectedRows(0).Cells(7).Value

        Return 0
    End Function

    Function showReport() As Integer
        Dim dt As New reportDataSet


        connect()
        conn.Open()
        cmd = conn.CreateCommand
        cmd.CommandText = "SELECT BATCHING_ID,DATE_TIME,F_NAME,M_NAME,L_NAME,POSITION,FORMULA_NAME,SILO1
,SILO1_WEIGHT,SILO2,SILO2_WEIGHT,SILO3,SILO3_WEIGHT,SILO4,SILO4_WEIGHT,SILO5,SILO5_WEIGHT,SILO6,SILO6_WEIGHT,SILO7,SILO7_WEIGHT,SILO8,SILO8_WEIGHT,SILO9,SILO9_WEIGHT,TOTAL_WEIGHT,MOLASSES,COCOOIL FROM tblbatching as batch
INNER JOIN tblformula as formula on batch.FORMULA_ID = formula.FORMULA_ID
INNER Join tblsilosettings as siloset on batch.SILO_SETTING = siloset.SILO_SETTING_ID
INNER JOIN tblusers as user on batch.OPERATOR_ID = user.USER_ID WHERE DATE BETWEEN @d1 and @d2 "
        cmd.Parameters.Add("@d1", MySqlDbType.Date).Value = frmMain.dtpFrom.Value ' + " 11:59:00"
        cmd.Parameters.Add("@d2", MySqlDbType.Date).Value = frmMain.dtpTo.Value '+ " 11:59:00"

        adp.SelectCommand = cmd
        adp.Fill(dt, "getReportData")
        Dim report As New BatchingReports

        report.SetDataSource(dt)
        frmMain.crviewr.ReportSource = report
        frmMain.crviewr.Refresh()
        frmMain.crviewr.RefreshReport()

        conn.Close()
        Return 0
    End Function
    Function showBatchReport() As Integer
        Dim dt As New reportDataSet

        connect()
        conn.Open()
        cmd = conn.CreateCommand
        cmd.CommandText = "SELECT BATCHING_ID,DATE_TIME,F_NAME,M_NAME,L_NAME,POSITION,FORMULA_NAME,SILO1
        ,SILO1_WEIGHT,SILO2,SILO2_WEIGHT,SILO3,SILO3_WEIGHT,SILO4,SILO4_WEIGHT,SILO5,SILO5_WEIGHT,SILO6,SILO6_WEIGHT,SILO7,SILO7_WEIGHT,SILO8,SILO8_WEIGHT,SILO9,SILO9_WEIGHT,TOTAL_WEIGHT,MOLASSES,COCOOIL FROM tblbatching as batch
        INNER JOIN tblformula as formula on batch.FORMULA_ID = formula.FORMULA_ID
        INNER Join tblsilosettings as siloset on batch.SILO_SETTING = siloset.SILO_SETTING_ID
        INNER JOIN tblusers as user on batch.OPERATOR_ID = user.USER_ID WHERE BATCHING_ID='" & frmMain.txtbReportBatchID.text & "' "
        adp.SelectCommand = cmd
        adp.Fill(dt, "getReportData")
        Dim report As New BatchReport

        report.SetDataSource(dt)
        frmMain.crviewr.ReportSource = report
        frmMain.crviewr.Refresh()
        frmMain.crviewr.RefreshReport()
        conn.Close()
        Return 0
    End Function



End Module
