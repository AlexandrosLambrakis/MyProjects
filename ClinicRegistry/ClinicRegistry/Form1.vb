Imports System
Imports System.Globalization

Public Class Form1
    Public Button As Integer
    Dim PresentDate As String
    Dim connection As New OleDb.OleDbConnection
    Dim dbProvider As String
    Dim dbSource As String
    Dim dbFolder As String
    Dim db As String
    Dim FullDatabasePath As String
    Dim ds As New DataSet
    Dim da As OleDb.OleDbDataAdapter
    Dim Sql As String
    Dim MaxRows As Integer
    Dim MainIRows As Integer = 0
    Private Sub Resetbuttons()
        Button2.Visible = False
        Button1.Visible = False
        ButtonDelete.Visible = False
        LebelSelection.Text = "-"
    End Sub
    Private Sub SelectionLabel()
        Dim I As Integer = 0
        While I <= MaxRows
            If DataGridView1.Rows(I).Selected = True Then
                LebelSelection.Text = Convert.ToString(I + 1)
                I = MaxRows + 1
            Else
                LebelSelection.Text = "-"
            End If
            I += 1
        End While
    End Sub
    Function AreaCalculation(Area As Integer) As Integer
        If Area = -1 Then
            If MaxRows Mod 2 = 0 Then
                Return MaxRows / 2
            Else
                Return (MaxRows - 1) / 2
            End If
        Else
            If Area Mod 2 = 0 Then
                Return Area / 2
            Else
                Return (Area - 1) / 2
            End If
        End If
    End Function
    Function searchmachid(str As String) As Integer
        Dim i As Integer
        Dim flag As Boolean = False
        For i = 0 To MaxRows
            If ds.Tables("PatientInfo").Rows(i).Item("IDnumber") = str Then
                flag = True
                Return i
                i = MaxRows
            End If
        Next
        If flag = False Then
            Return -1
        End If
    End Function
    Function DetermineSearchTXt() As Integer
        Dim match As Integer
        If LTrim(RTrim(SearchNameTxtBOx.Text)) = "" Then
            Return -1
        ElseIf LTrim(RTrim(SearchNameTxtBOx.Text)).Contains("1") Or LTrim(RTrim(SearchNameTxtBOx.Text)).Contains("2") Or LTrim(RTrim(SearchNameTxtBOx.Text)).Contains("3") Or LTrim(RTrim(SearchNameTxtBOx.Text)).Contains("4") Or LTrim(RTrim(SearchNameTxtBOx.Text)).Contains("5") Or LTrim(RTrim(SearchNameTxtBOx.Text)).Contains("6") Or LTrim(RTrim(SearchNameTxtBOx.Text)).Contains("7") Or LTrim(RTrim(SearchNameTxtBOx.Text)).Contains("8") Or LTrim(RTrim(SearchNameTxtBOx.Text)).Contains("9") Or LTrim(RTrim(SearchNameTxtBOx.Text)).Contains("0") Then
            match = searchmachid(LTrim(RTrim(SearchNameTxtBOx.Text)))
            Return match
        Else
            Order()
            match = Searchmatchsurname()
            Return match
        End If

    End Function
    Sub Swaprows(i As Integer, j As Integer)
        Dim cb As New OleDb.OleDbCommandBuilder(da)
        Dim dsNewRow As DataRow

        dsNewRow = ds.Tables("PatientInfo").NewRow()
        dsNewRow.Item("Firstname") = ds.Tables("PatientInfo").Rows(i).Item("Firstname")
        dsNewRow.Item("Surname") = ds.Tables("PatientInfo").Rows(i).Item("Surname")
        dsNewRow.Item("IDnumber") = ds.Tables("PatientInfo").Rows(i).Item("IDnumber")
        dsNewRow.Item("DoB") = ds.Tables("PatientInfo").Rows(i).Item("DoB")
        dsNewRow.Item("Adress") = ds.Tables("PatientInfo").Rows(i).Item("Adress")
        dsNewRow.Item("Sex") = ds.Tables("PatientInfo").Rows(i).Item("Sex")
        dsNewRow.Item("RoomTypes") = ds.Tables("PatientInfo").Rows(i).Item("RoomTypes")
        dsNewRow.Item("DoS") = ds.Tables("PatientInfo").Rows(i).Item("DoS")
        dsNewRow.Item("Age") = ds.Tables("PatientInfo").Rows(i).Item("Age")
        dsNewRow.Item("Income") = ds.Tables("PatientInfo").Rows(i).Item("Income")
        dsNewRow.Item("Insurance") = ds.Tables("PatientInfo").Rows(i).Item("Insurance")
        dsNewRow.Item("Active") = ds.Tables("PatientInfo").Rows(i).Item("Active")
        ds.Tables("PatientInfo").Rows.Add(dsNewRow)
        MaxRows = ds.Tables("PatientInfo").Rows.Count - 1
        ds.Tables("PatientInfo").Rows(i).Item("Firstname") = ds.Tables("PatientInfo").Rows(j).Item("Firstname")
        ds.Tables("PatientInfo").Rows(i).Item("Surname") = ds.Tables("PatientInfo").Rows(j).Item("Surname")
        ds.Tables("PatientInfo").Rows(i).Item("IDnumber") = ds.Tables("PatientInfo").Rows(j).Item("IDnumber")
        ds.Tables("PatientInfo").Rows(i).Item("DoB") = ds.Tables("PatientInfo").Rows(j).Item("DoB")
        ds.Tables("PatientInfo").Rows(i).Item("Adress") = ds.Tables("PatientInfo").Rows(j).Item("Adress")
        ds.Tables("PatientInfo").Rows(i).Item("Sex") = ds.Tables("PatientInfo").Rows(j).Item("Sex")
        ds.Tables("PatientInfo").Rows(i).Item("RoomTypes") = ds.Tables("PatientInfo").Rows(j).Item("RoomTypes")
        ds.Tables("PatientInfo").Rows(i).Item("DoS") = ds.Tables("PatientInfo").Rows(j).Item("DoS")

        ds.Tables("PatientInfo").Rows(i).Item("Age") = ds.Tables("PatientInfo").Rows(j).Item("Age")
        ds.Tables("PatientInfo").Rows(i).Item("Income") = ds.Tables("PatientInfo").Rows(j).Item("Income")
        ds.Tables("PatientInfo").Rows(i).Item("Insurance") = ds.Tables("PatientInfo").Rows(j).Item("Insurance")
        ds.Tables("PatientInfo").Rows(i).Item("Active") = ds.Tables("PatientInfo").Rows(j).Item("Active")

        ds.Tables("PatientInfo").Rows(j).Item("Firstname") = ds.Tables("PatientInfo").Rows(MaxRows).Item("Firstname")
        ds.Tables("PatientInfo").Rows(j).Item("Surname") = ds.Tables("PatientInfo").Rows(MaxRows).Item("Surname")
        ds.Tables("PatientInfo").Rows(j).Item("IDnumber") = ds.Tables("PatientInfo").Rows(MaxRows).Item("IDnumber")

        ds.Tables("PatientInfo").Rows(j).Item("Adress") = ds.Tables("PatientInfo").Rows(MaxRows).Item("Adress")
        ds.Tables("PatientInfo").Rows(j).Item("Sex") = ds.Tables("PatientInfo").Rows(MaxRows).Item("Sex")
        ds.Tables("PatientInfo").Rows(j).Item("RoomTypes") = ds.Tables("PatientInfo").Rows(MaxRows).Item("RoomTypes")
        ds.Tables("PatientInfo").Rows(j).Item("DoS") = ds.Tables("PatientInfo").Rows(MaxRows).Item("DoS")

        ds.Tables("PatientInfo").Rows(j).Item("Age") = ds.Tables("PatientInfo").Rows(MaxRows).Item("Age")
        ds.Tables("PatientInfo").Rows(j).Item("Income") = ds.Tables("PatientInfo").Rows(MaxRows).Item("Income")
        ds.Tables("PatientInfo").Rows(j).Item("Insurance") = ds.Tables("PatientInfo").Rows(MaxRows).Item("Insurance")
        ds.Tables("PatientInfo").Rows(j).Item("Active") = ds.Tables("PatientInfo").Rows(MaxRows).Item("Active")

        ds.Tables("PatientInfo").Rows(MaxRows).Delete()
    End Sub
    Private Sub Order()
        Dim i As Integer
        Dim MaxRowsCopy As Integer
        Dim j As Integer = 0
        Dim MaxStrI As Integer
        Dim MinStrI As Integer
        Dim Compare As Integer
        MaxRows = ds.Tables("PatientInfo").Rows.Count
        MaxRowsCopy = MaxRows - 1
        While (j <= MaxRowsCopy / 2)
            MinStrI = MaxRowsCopy - j
            MaxStrI = j
            For i = j To MaxRowsCopy - j
                Compare = String.Compare(ds.Tables("PatientInfo").Rows(MinStrI).Item("Surname"), ds.Tables("PatientInfo").Rows(i).Item("Surname"), True, New CultureInfo("el-GR"))
                If Compare > 0 Then
                    MinStrI = i
                ElseIf Compare < 0 Then
                    Compare = String.Compare(ds.Tables("PatientInfo").Rows(MaxStrI).Item("Surname"), ds.Tables("PatientInfo").Rows(i).Item("Surname"), True, New CultureInfo("el-GR"))
                    If Compare < 0 Then
                        MaxStrI = i
                    End If
                End If
            Next

            Swaprows(MinStrI, j)
            Swaprows(MaxStrI, MaxRowsCopy - j)
            j += 1
        End While
    End Sub
    Function Searchmatchsurname() As Integer
        Dim I As Integer
        Dim Area As Integer = -1
        Dim flag As Boolean = False

        Dim CompareStr As Integer
        Dim TxtBxStr As String = SearchNameTxtBOx.Text
        Area = AreaCalculation(Area)
        I = Area
        While Area >= 2
                CompareStr = String.Compare(ds.Tables("PatientInfo").Rows(I).Item("Surname"), TxtBxStr, True, New CultureInfo("el-GR"))
                If CompareStr = 0 Then
                    Return I
                    I = -2
                    Area = 0
                    flag = True
                ElseIf CompareStr < 0 Then
                    Area = AreaCalculation(Area)
                    I += Area
                Else
                    Area = AreaCalculation(Area)
                    I -= Area
                End If

        End While
        If CompareStr <> 0 Then
            While I > -1 And I < MaxRows + 1
                CompareStr = String.Compare(ds.Tables("PatientInfo").Rows(I).Item("Surname"), TxtBxStr, True, New CultureInfo("el-GR"))
                If CompareStr <> 0 Then
                    If CompareStr > 0 Then
                        I -= 1
                    Else
                        I += 1
                    End If
                Else
                    Return I
                    flag = True
                    I = -2
                End If
            End While
        End If
        If flag = False Then
            Return -1
        End If
    End Function
    Function StrSlice(StrDate As String) As Integer
        Dim substrings() As String = StrDate.Split("/"c)
        Dim i As Integer = 0
        Dim year As Integer
        For Each substring In substrings
            year = Convert.ToInt32(substring)
        Next
        Return year
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        PresentDate = Format(Now(), "short date")

        LabelDate.Text = PresentDate

        dbProvider = "PROVIDER=Microsoft.Jet.OLEDB.4.0;"
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

        DataGridView1.DataSource = ds.Tables("PatientInfo")
        MaxRows = ds.Tables("PatientInfo").Rows.Count - 1
        Button2.Visible = False
        Button1.Visible = False
        ButtonDelete.Visible = False
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonSelect.Click
        SelectionLabel()
        If LebelSelection.Text = "-" Or LebelSelection.Text = "" Then
            MessageBox.Show("Δεν έχει επιλεχθεί σειρά")
        Else
            MainIRows = Convert.ToInt32(LebelSelection.Text) - 1
            Button2.Visible = True
            Button1.Visible = True
            ButtonDelete.Visible = True
        End If


    End Sub

    Private Sub ButtonSearch_Click(sender As Object, e As EventArgs) Handles ButtonSearch.Click
        Dim irows As Integer
        MaxRows = ds.Tables("PatientInfo").Rows.Count - 1
        irows =  DetermineSearchTXt()
        If irows = -1 Then
            MessageBox.Show("Ο ασθενής δεν βρέθηκε")
        Else
            MessageBox.Show(irows)
            DataGridView1.Rows(irows).Selected = True
            DataGridView1.FirstDisplayedScrollingRowIndex = irows
        End If

    End Sub

    Private Sub ButtonAddNew_Click(sender As Object, e As EventArgs) Handles ButtonAddNew.Click
        Button = -1
        NewRegisterForm1.Show()
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        SelectionLabel()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Button = MainIRows
        NewRegisterForm1.Show()
        Me.Close()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim result As Double = 0
        Dim Extra As Double = 0
        Dim discount As Double = 0
        If ds.Tables("PatientInfo").Rows(MainIRows).Item("Active") = False Then
            MessageBox.Show("Ο ασθενής που διαλέξατε εχει πάρει εξιτηριο")
        Else
            If ds.Tables("PatientInfo").Rows(MainIRows).Item("RoomTypes") = "Μονόκλινο" Then
                result = 100 * Convert.ToDouble(ds.Tables("PatientInfo").Rows(MainIRows).Item("DoS"))
            ElseIf ds.Tables("PatientInfo").Rows(MainIRows).Item("RoomTypes") = "Δύκλινο" Then
                result = 50 * Convert.ToDouble(ds.Tables("PatientInfo").Rows(MainIRows).Item("DoS"))
            ElseIf ds.Tables("PatientInfo").Rows(MainIRows).Item("RoomTypes") = "Τρίκλινο" Then
                result = 30 * Convert.ToDouble(ds.Tables("PatientInfo").Rows(MainIRows).Item("DoS"))
            Else
                result = 20 * Convert.ToDouble(ds.Tables("PatientInfo").Rows(MainIRows).Item("DoS"))
            End If
            If ds.Tables("PatientInfo").Rows(MainIRows).Item("income") > 12000 Then
                Extra = ((result / Convert.ToDouble(ds.Tables("PatientInfo").Rows(MainIRows).Item("DoS"))) * 0.05) * Convert.ToInt32(ds.Tables("PatientInfo").Rows(MainIRows).Item("DoS"))
            End If
            If ds.Tables("PatientInfo").Rows(MainIRows).Item("DoS") = True Then
                discount = (result / Convert.ToDouble(ds.Tables("PatientInfo").Rows(MainIRows).Item("DoS"))) * 0.1
            End If
            result = result + Extra - discount
            Dim answer As Integer = MessageBox.Show("Το συνολικό κόστος του ασθενή είναι " & result & "ευρώ, με έκπτωση " & discount & "ευρώ και έξτρα χρέωση " & Extra & "ευρώ πατήστε Yes αν ολοκληρώατε τη συναλλαγή", "caption", MessageBoxButtons.YesNoCancel)
            If answer = DialogResult.Yes Then
                ds.Tables("PatientInfo").Rows(MainIRows).Item("Active") = False
                Resetbuttons()
            End If
        End If

    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        Dim cb As New OleDb.OleDbCommandBuilder(da)
        Dim answer As Integer = MessageBox.Show("Είστε σίγουροι ότι θέλετε να διαγράψετε τον ασθενή;", "caption", MessageBoxButtons.YesNoCancel)
        If answer = DialogResult.Yes Then
            ds.Tables("PatientInfo").Rows(MainIRows).Delete()
            connection.Open()
            da.Update(ds, "PatientInfo")
            connection.Close()
            MaxRows -= 1
            Resetbuttons()
        End If
    End Sub
End Class