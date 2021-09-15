<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ButtonSelect = New System.Windows.Forms.Button()
        Me.ButtonSearch = New System.Windows.Forms.Button()
        Me.ButtonAddNew = New System.Windows.Forms.Button()
        Me.SearchNameTxtBOx = New System.Windows.Forms.TextBox()
        Me.LebelSelection = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelDate = New System.Windows.Forms.Label()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonSelect
        '
        Me.ButtonSelect.Location = New System.Drawing.Point(944, 130)
        Me.ButtonSelect.Name = "ButtonSelect"
        Me.ButtonSelect.Size = New System.Drawing.Size(197, 23)
        Me.ButtonSelect.TabIndex = 1
        Me.ButtonSelect.Text = "Επιλογή Ασθενή"
        Me.ButtonSelect.UseVisualStyleBackColor = True
        '
        'ButtonSearch
        '
        Me.ButtonSearch.Location = New System.Drawing.Point(1038, 38)
        Me.ButtonSearch.Name = "ButtonSearch"
        Me.ButtonSearch.Size = New System.Drawing.Size(114, 23)
        Me.ButtonSearch.TabIndex = 2
        Me.ButtonSearch.Text = "Αναζήτηση Ασθενή"
        Me.ButtonSearch.UseVisualStyleBackColor = True
        '
        'ButtonAddNew
        '
        Me.ButtonAddNew.Location = New System.Drawing.Point(955, 582)
        Me.ButtonAddNew.Name = "ButtonAddNew"
        Me.ButtonAddNew.Size = New System.Drawing.Size(197, 23)
        Me.ButtonAddNew.TabIndex = 3
        Me.ButtonAddNew.Text = "Προσθήκη Νέου"
        Me.ButtonAddNew.UseVisualStyleBackColor = True
        '
        'SearchNameTxtBOx
        '
        Me.SearchNameTxtBOx.Location = New System.Drawing.Point(935, 12)
        Me.SearchNameTxtBOx.Name = "SearchNameTxtBOx"
        Me.SearchNameTxtBOx.Size = New System.Drawing.Size(217, 20)
        Me.SearchNameTxtBOx.TabIndex = 4
        '
        'LebelSelection
        '
        Me.LebelSelection.AutoSize = True
        Me.LebelSelection.Location = New System.Drawing.Point(941, 101)
        Me.LebelSelection.Name = "LebelSelection"
        Me.LebelSelection.Size = New System.Drawing.Size(0, 13)
        Me.LebelSelection.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(944, 223)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Αλλαγή στοιχείων"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(944, 175)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(123, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "MONEY"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(917, 577)
        Me.DataGridView1.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 607)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 9
        '
        'LabelDate
        '
        Me.LabelDate.AutoSize = True
        Me.LabelDate.Location = New System.Drawing.Point(31, 607)
        Me.LabelDate.Name = "LabelDate"
        Me.LabelDate.Size = New System.Drawing.Size(39, 13)
        Me.LabelDate.TabIndex = 10
        Me.LabelDate.Text = "Label2"
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Location = New System.Drawing.Point(955, 481)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(128, 23)
        Me.ButtonDelete.TabIndex = 11
        Me.ButtonDelete.Text = "Διαγραφή"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1164, 629)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.LabelDate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LebelSelection)
        Me.Controls.Add(Me.SearchNameTxtBOx)
        Me.Controls.Add(Me.ButtonAddNew)
        Me.Controls.Add(Me.ButtonSearch)
        Me.Controls.Add(Me.ButtonSelect)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FirstnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SurnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdnumDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AgeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ButtonSelect As Button
    Friend WithEvents ButtonSearch As Button
    Friend WithEvents ButtonAddNew As Button
    Friend WithEvents SearchNameTxtBOx As TextBox
    Friend WithEvents LebelSelection As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelDate As Label
    Friend WithEvents ButtonDelete As Button
End Class
