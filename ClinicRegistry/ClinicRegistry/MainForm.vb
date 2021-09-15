Public Class MainForm

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
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartRegister.Click
        Form1.Show()
        Me.Hide()
    End Sub
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim I As Integer
        Dim Active As Integer = 0
        Dim Woman As Integer = 0
        Dim UnderAged As Integer = 0
        Dim Dwoman As Integer = 0
        Dim DUnderAged As Integer = 0

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
        MaxRows = ds.Tables("PatientInfo").Rows.Count - 1


        For I = 0 To MaxRows
            If ds.Tables("PatientInfo").Rows(I).Item("Active") = True Then
                Active += 1
                If (ds.Tables("PatientInfo").Rows(I).Item("Sex") = True) Then
                    Woman += 1

                End If
                If ds.Tables("PatientInfo").Rows(I).Item("Age") < 18 Then
                    UnderAged += 1

                End If
            Else
                If ds.Tables("PatientInfo").Rows(I).Item("Sex") = True Then
                    Dwoman += 1

                End If
                If ds.Tables("PatientInfo").Rows(I).Item("Age") < 18 Then
                    DUnderAged += 1

                End If
            End If

        Next
        LabelMaxRows.Text = Convert.ToString(MaxRows + 1)
        LabelActive.Text = Convert.ToString(Active)
        LabelAM.Text = Convert.ToString(Active - Woman)
        LabelDM.Text = Convert.ToString(MaxRows + 1 - Dwoman - Woman)
        LabelAW.Text = Convert.ToString(Woman)
        labelDW.Text = Convert.ToString(Dwoman + Woman)
        LabelDU.Text = Convert.ToString(UnderAged + DUnderAged)
        LabelAU.Text = Convert.ToString(+UnderAged)
        LabelDA.Text = Convert.ToString(Active - UnderAged)
        LabelAA.Text = Convert.ToString(MaxRows + 1 - DUnderAged - UnderAged)
    End Sub
End Class
