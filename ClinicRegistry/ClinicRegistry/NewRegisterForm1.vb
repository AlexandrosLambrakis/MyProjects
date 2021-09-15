Imports System.Globalization

Public Class NewRegisterForm1
    Dim ISelected As Integer
    Dim connection As New OleDb.OleDbConnection
    Dim dbProvider As String
    Dim dbSource As String
    Dim dbFolder As String
    Dim db As String
    Dim FullDatabasePath As String
    Dim ds As New DataSet
    Dim da As OleDb.OleDbDataAdapter
    Dim Sql As String
    Dim MaxRows As Integer = 0

    Function CheckData() As Boolean
        Dim Flag As Boolean = False

        If LTrim(RTrim(SurnameTxtbx.Text)) = "" Then
            Flag = True
            MessageBox.Show("Συμληρώστε το πεδίο για το Επώνυμο")
        End If
        If LTrim(RTrim(NameTxtbox.Text)) = "" Then
            Flag = True
            MessageBox.Show("Συμληρώστε το πεδίο για το Όνομα")
        End If
        If LTrim(RTrim(IDNumTxtbox.Text)) = "" Then
            Flag = True
            MessageBox.Show("Συμληρώστε το πεδίο με τον αριθμό ταυτότητας")
        End If
        If LTrim(RTrim(TxtBxDOBDay.Text)) = "" Then
            Flag = True
            MessageBox.Show("Συμληρώστε το πεδίο με την ημέρα γεννήσεως")
        End If
        If LTrim(RTrim(TxtBxDOBMonth.Text)) = "" Then
            Flag = True
            MessageBox.Show("Συμληρώστε το πεδίο με το μήνα γεννήσεως")
        End If
        If LTrim(RTrim(TxtBxDOBYear.Text)) = "" Then
            Flag = True
            MessageBox.Show("Συμληρώστε το πεδίο με την χρονολογία γεννήσεως")
        End If
        If LTrim(RTrim(TxtBxDOBYear.Text)) = "" Then
            Flag = True
            MessageBox.Show("Συμληρώστε το πεδίο με τη διεύθυνση")
        End If
        If LTrim(RTrim(IncomeTxtBox.Text)) = "" Then
            Flag = True
            MessageBox.Show("Συμληρώστε το πεδίο με τα εισοήματικά κριτήρια")
        End If
        If LTrim(RTrim(IncomeTxtBox.Text)) = "" Then
            Flag = True
            MessageBox.Show("Συμληρώστε το πεδίο με την ηλικία")
        End If
        If LTrim(RTrim(IncomeTxtBox.Text)) = "" Then
            Flag = True
            MessageBox.Show("Συμληρώστε το πεδίο με τις ημέρες νοσηλείας")
        End If
        If RDBman.Checked = False And RDBwoman.Checked = False Then
            Flag = True
            MessageBox.Show("Συμληρώστε το πεδίο με φύλο του ασθενή")
        End If
        If RDBsingle.Checked = False And RDBpair.Checked = False And RDBthreesome.Checked = False And RDBorgy.Checked = False Then
            Flag = True
            MessageBox.Show("Συμληρώστε το πεδίο με τον τύπο του δωματίου του ασθενή")
        End If
        If RDByes.Checked = False And RDBno.Checked = False Then
            Flag = True
            MessageBox.Show("Συμληρώστε το πεδίο με την ασφάληση του ανσθενή")
        End If
        Return Flag
    End Function
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dbProvider = "PROVIDER=Microsoft.Jet.OLEDB.4.0;"
        ISelected = Form1.Button
        MessageBox.Show(ISelected)
        db = "/FullPatientinfo.mdb"
        dbFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        FullDatabasePath = dbFolder & db

        dbSource = "Data Source = " & FullDatabasePath
        connection.ConnectionString = dbProvider & dbSource

        connection.Open()

        Sql = "Select * FROM FullPatientInfo"
        da = New OleDb.OleDbDataAdapter(Sql, connection)
        da.Fill(ds, "PatientInfo")

        connection.Close()
        MaxRows = ds.Tables("PatientInfo").Rows.Count - 1

        SurnameTxtbx.Clear()
        NameTxtbox.Clear()
        IDNumTxtbox.Clear()
        TxtBxDOBDay.Clear()
        TxtBxDOBMonth.Clear()
        TxtBxDOBYear.Clear()
        AddressTxtbox.Clear()
        IncomeTxtBox.Clear()
        AgeTxtbx.Clear()
        StayDaysTxtbx.Clear()


        RDBman.Checked = False
        RDBwoman.Checked = False
        RDBsingle.Checked = False
        RDBpair.Checked = False
        RDBthreesome.Checked = False
        RDBorgy.Checked = False
        RDByes.Checked = False
        RDBno.Checked = False

        If ISelected <> -1 Then
            SurnameTxtbx.Text = ds.Tables("PatientInfo").Rows(ISelected).Item("Surname")
            NameTxtbox.Text = ds.Tables("PatientInfo").Rows(ISelected).Item("Firstname")
            IDNumTxtbox.Text = ds.Tables("PatientInfo").Rows(ISelected).Item("IDnumber")
            Dim StrDate As String = ds.Tables("PatientInfo").Rows(ISelected).Item("DoB")
            Dim substrings() As String = StrDate.Split("/"c)
            Dim i As Integer = 0
            For Each substring In substrings
                If i = 0 Then
                    TxtBxDOBDay.Text = substring
                ElseIf i = 1 Then
                    TxtBxDOBMonth.Text = substring
                ElseIf i = 2 Then
                    TxtBxDOBYear.Text = substring
                End If
                i += 1
            Next
            AddressTxtbox.Text = ds.Tables("PatientInfo").Rows(ISelected).Item("Adress")
            IncomeTxtBox.Text = Convert.ToString(ds.Tables("PatientInfo").Rows(ISelected).Item("Income"))
            AgeTxtbx.Text = Convert.ToString(ds.Tables("PatientInfo").Rows(ISelected).Item("Age"))
            StayDaysTxtbx.Text = ds.Tables("PatientInfo").Rows(ISelected).Item("DoS")
            If ds.Tables("PatientInfo").Rows(ISelected).Item("Sex") = True Then
                RDBwoman.Checked = True
            Else
                RDBman.Checked = True
            End If

            If ds.Tables("PatientInfo").Rows(ISelected).Item("RoomTypes") = "Μονόκλινο" Then
                RDBsingle.Checked = True
            ElseIf ds.Tables("PatientInfo").Rows(ISelected).Item("RoomTypes") = "Δύκλινο" Then
                RDBpair.Checked = True
            ElseIf ds.Tables("PatientInfo").Rows(ISelected).Item("RoomTypes") = "Τρίκλινο" Then
                RDBthreesome.Checked = True
            Else
                RDBorgy.Checked = True
            End If
            If ds.Tables("PatientInfo").Rows(ISelected).Item("Insurance") = True Then
                RDByes.Checked = True
            Else
                RDBno.Checked = True
            End If
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackToForm1.Click
        Form1.Show()
        Me.Close()
    End Sub
    Private Sub SaveRegister_Click(sender As Object, e As EventArgs) Handles SaveRegister.Click
        Dim Datafail As Boolean
        Dim cb As New OleDb.OleDbCommandBuilder(da)
        Datafail = CheckData()
        If Datafail = True Then
        Else
            If ISelected = -1 Then

                Dim dsNewRow As DataRow
                dsNewRow = ds.Tables("PatientInfo").NewRow()
                dsNewRow.Item("Firstname") = NameTxtbox.Text
                dsNewRow.Item("Surname") = SurnameTxtbx.Text
                dsNewRow.Item("IDnumber") = IDNumTxtbox
                dsNewRow.Item("DoB") = TxtBxDOBDay.Text + "/" + TxtBxDOBMonth.Text + "/" + TxtBxDOBYear.Text
                dsNewRow.Item("Adress") = AddressTxtbox.Text
                If RDBwoman.Checked = True Then
                    dsNewRow.Item("Sex") = True
                Else
                    dsNewRow.Item("Sex") = False
                End If
                If RDBsingle.Checked = True Then
                    dsNewRow.Item("RoomTypes") = "Μονόκλινο"
                ElseIf RDBpair.Checked = True Then
                    dsNewRow.Item("RoomTypes") = "Δύκλινο"
                ElseIf RDBthreesome.Checked = True Then
                    dsNewRow.Item("RoomTypes") = "Τρίκλινο"
                ElseIf RDBorgy.Checked = True Then
                    dsNewRow.Item("RoomTypes") = "Τετράκλινο"
                End If
                dsNewRow.Item("DoS") = StayDaysTxtbx.Text
                dsNewRow.Item("Age") = Convert.ToInt32(AgeTxtbx.Text)
                dsNewRow.Item("Income") = Convert.ToInt32(IncomeTxtBox.Text)

                If RDByes.Checked = True Then
                    dsNewRow.Item("Insurance") = True
                End If
                dsNewRow.Item("Active") = True
                ds.Tables("PatientInfo").Rows.Add(dsNewRow)
            Else
                If ds.Tables("PatientInfo").Rows(ISelected).Item("Surname") <> SurnameTxtbx.Text Then
                    ds.Tables("PatientInfo").Rows(ISelected).Item("Surname") = SurnameTxtbx.Text
                End If
                If ds.Tables("PatientInfo").Rows(ISelected).Item("Firstname") <> NameTxtbox.Text Then
                    ds.Tables("PatientInfo").Rows(ISelected).Item("Firstname") = NameTxtbox.Text
                End If
                If ds.Tables("PatientInfo").Rows(ISelected).Item("IDnumber") <> IDNumTxtbox.Text Then
                    ds.Tables("PatientInfo").Rows(ISelected).Item("IDnumber") = IDNumTxtbox.Text
                End If
                If ds.Tables("PatientInfo").Rows(ISelected).Item("DoB") <> TxtBxDOBDay.Text & "/" & TxtBxDOBMonth.Text & "/" & TxtBxDOBYear.Text Then
                    ds.Tables("PatientInfo").Rows(ISelected).Item("DoB") = TxtBxDOBDay.Text & "/" & TxtBxDOBMonth.Text & "/" & TxtBxDOBYear.Text
                End If
                If ds.Tables("PatientInfo").Rows(ISelected).Item("Adress") <> AddressTxtbox.Text Then
                    ds.Tables("PatientInfo").Rows(ISelected).Item("Adress") = AddressTxtbox.Text
                End If
                If ds.Tables("PatientInfo").Rows(ISelected).Item("Age") <> Convert.ToInt32(AgeTxtbx.Text) Then
                    ds.Tables("PatientInfo").Rows(ISelected).Item("Age") = Convert.ToInt32(AgeTxtbx.Text)
                End If
                If ds.Tables("PatientInfo").Rows(ISelected).Item("Income") = Convert.ToInt32(IncomeTxtBox.Text) Then
                    ds.Tables("PatientInfo").Rows(ISelected).Item("Income") = Convert.ToInt32(IncomeTxtBox.Text)
                End If
                If ds.Tables("PatientInfo").Rows(ISelected).Item("DoS") = StayDaysTxtbx.Text Then
                    ds.Tables("PatientInfo").Rows(ISelected).Item("DoS") = StayDaysTxtbx.Text
                End If
                If Not ((RDBwoman.Checked = True And ds.Tables("PatientInfo").Rows(ISelected).Item("Sex") = True) Or (RDBwoman.Checked = True And ds.Tables("PatientInfo").Rows(ISelected).Item("Sex") = False)) Then
                    If RDBwoman.Checked = True Then
                        ds.Tables("PatientInfo").Rows(ISelected).Item("Sex") = True
                    Else
                        ds.Tables("PatientInfo").Rows(ISelected).Item("Sex") = False
                    End If
                End If
                If (ds.Tables("PatientInfo").Rows(ISelected).Item("RoomTypes") = "Μονόκλινο" And RDBsingle.Checked = False) Or (ds.Tables("PatientInfo").Rows(ISelected).Item("RoomTypes") = "Δύκλινο" And RDBpair.Checked = False) Or (ds.Tables("PatientInfo").Rows(ISelected).Item("RoomTypes") = "Τρίκλινο" And RDBthreesome.Checked = False) Or (ds.Tables("PatientInfo").Rows(ISelected).Item("RoomTypes") = "Τετράκλινο" And RDBorgy.Checked = False) Then
                    If RDBsingle.Checked = True Then
                        ds.Tables("PatientInfo").Rows(ISelected).Item("RoomTypes") = "Μονόκλινο"
                    ElseIf RDBpair.Checked = True Then
                        ds.Tables("PatientInfo").Rows(ISelected).Item("RoomTypes") = "Δύκλινο"
                    ElseIf RDBthreesome.Checked = True Then
                        ds.Tables("PatientInfo").Rows(ISelected).Item("RoomTypes") = "Τρίκλινο"
                    Else
                        ds.Tables("PatientInfo").Rows(ISelected).Item("RoomTypes") = "Τετράκλινο"
                    End If
                End If
                If Not (RDByes.Checked = ds.Tables("PatientInfo").Rows(ISelected).Item("Insurance")) Then
                    If RDByes.Checked = True Then
                        ds.Tables("PatientInfo").Rows(ISelected).Item("Insurance") = True
                    Else
                        ds.Tables("PatientInfo").Rows(ISelected).Item("Insurance") = False
                    End If
                End If
                If ds.Tables("PatientInfo").Rows(ISelected).Item("Active") = False Then
                    ds.Tables("PatientInfo").Rows(ISelected).Item("Active") = True
                End If
            End If
            connection.Open()
            da.Update(ds, "PatientInfo")
            connection.Close()
            Form1.Show()
            Me.Close()
        End If
    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub
End Class