<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewRegisterForm1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelSurname = New System.Windows.Forms.Label()
        Me.SurnameTxtbx = New System.Windows.Forms.TextBox()
        Me.LabelName = New System.Windows.Forms.Label()
        Me.NameTxtbox = New System.Windows.Forms.TextBox()
        Me.LabelIDNum = New System.Windows.Forms.Label()
        Me.LabelDOB = New System.Windows.Forms.Label()
        Me.IDNumTxtbox = New System.Windows.Forms.TextBox()
        Me.LabelAdress = New System.Windows.Forms.Label()
        Me.AddressTxtbox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RDBwoman = New System.Windows.Forms.RadioButton()
        Me.RDBman = New System.Windows.Forms.RadioButton()
        Me.BackToForm1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtBxDOBDay = New System.Windows.Forms.TextBox()
        Me.TxtBxDOBMonth = New System.Windows.Forms.TextBox()
        Me.TxtBxDOBYear = New System.Windows.Forms.TextBox()
        Me.RDBsingle = New System.Windows.Forms.RadioButton()
        Me.RDBpair = New System.Windows.Forms.RadioButton()
        Me.RDBthreesome = New System.Windows.Forms.RadioButton()
        Me.RDBorgy = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LabelAge = New System.Windows.Forms.Label()
        Me.Label1StayDays = New System.Windows.Forms.Label()
        Me.LabelIncome = New System.Windows.Forms.Label()
        Me.IncomeTxtBox = New System.Windows.Forms.TextBox()
        Me.RDByes = New System.Windows.Forms.RadioButton()
        Me.RDBno = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.SaveRegister = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.StayDaysTxtbx = New System.Windows.Forms.TextBox()
        Me.AgeTxtbx = New System.Windows.Forms.TextBox()
        Me.FullPatientInfoTableAdapter1 = New ClinicRegistry.FullPatientInfoDataSetTableAdapters.FullPatientInfoTableAdapter()
        Me.TableAdapterManager1 = New ClinicRegistry.FullPatientInfoDataSetTableAdapters.TableAdapterManager()
        Me.FullPatientInfoDataSet1 = New ClinicRegistry.FullPatientInfoDataSet()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.FullPatientInfoDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(278, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Εισάγεται τα στοιχεία της καταχώρησης"
        '
        'LabelSurname
        '
        Me.LabelSurname.AutoSize = True
        Me.LabelSurname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.LabelSurname.Location = New System.Drawing.Point(22, 69)
        Me.LabelSurname.Name = "LabelSurname"
        Me.LabelSurname.Size = New System.Drawing.Size(62, 16)
        Me.LabelSurname.TabIndex = 1
        Me.LabelSurname.Text = "Επώνυμο"
        '
        'SurnameTxtbx
        '
        Me.SurnameTxtbx.Location = New System.Drawing.Point(24, 88)
        Me.SurnameTxtbx.Name = "SurnameTxtbx"
        Me.SurnameTxtbx.Size = New System.Drawing.Size(242, 20)
        Me.SurnameTxtbx.TabIndex = 2
        '
        'LabelName
        '
        Me.LabelName.AutoSize = True
        Me.LabelName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.LabelName.Location = New System.Drawing.Point(22, 127)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.Size = New System.Drawing.Size(48, 16)
        Me.LabelName.TabIndex = 3
        Me.LabelName.Text = "Όνομα"
        '
        'NameTxtbox
        '
        Me.NameTxtbox.Location = New System.Drawing.Point(25, 146)
        Me.NameTxtbox.Name = "NameTxtbox"
        Me.NameTxtbox.Size = New System.Drawing.Size(242, 20)
        Me.NameTxtbox.TabIndex = 4
        '
        'LabelIDNum
        '
        Me.LabelIDNum.AutoSize = True
        Me.LabelIDNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.LabelIDNum.Location = New System.Drawing.Point(22, 186)
        Me.LabelIDNum.Name = "LabelIDNum"
        Me.LabelIDNum.Size = New System.Drawing.Size(131, 16)
        Me.LabelIDNum.TabIndex = 5
        Me.LabelIDNum.Text = "Αριθμός ταυτότητας"
        '
        'LabelDOB
        '
        Me.LabelDOB.AutoSize = True
        Me.LabelDOB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.LabelDOB.Location = New System.Drawing.Point(22, 249)
        Me.LabelDOB.Name = "LabelDOB"
        Me.LabelDOB.Size = New System.Drawing.Size(139, 16)
        Me.LabelDOB.TabIndex = 6
        Me.LabelDOB.Text = "Ημερομηνία γέννησης"
        '
        'IDNumTxtbox
        '
        Me.IDNumTxtbox.Location = New System.Drawing.Point(25, 205)
        Me.IDNumTxtbox.Name = "IDNumTxtbox"
        Me.IDNumTxtbox.Size = New System.Drawing.Size(242, 20)
        Me.IDNumTxtbox.TabIndex = 7
        '
        'LabelAdress
        '
        Me.LabelAdress.AutoSize = True
        Me.LabelAdress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.LabelAdress.Location = New System.Drawing.Point(22, 309)
        Me.LabelAdress.Name = "LabelAdress"
        Me.LabelAdress.Size = New System.Drawing.Size(70, 16)
        Me.LabelAdress.TabIndex = 11
        Me.LabelAdress.Text = "Διεύθυνση"
        '
        'AddressTxtbox
        '
        Me.AddressTxtbox.Location = New System.Drawing.Point(24, 338)
        Me.AddressTxtbox.Name = "AddressTxtbox"
        Me.AddressTxtbox.Size = New System.Drawing.Size(242, 20)
        Me.AddressTxtbox.TabIndex = 12
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RDBwoman)
        Me.GroupBox1.Controls.Add(Me.RDBman)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(25, 379)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(241, 47)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Φύλο"
        '
        'RDBwoman
        '
        Me.RDBwoman.AutoSize = True
        Me.RDBwoman.Location = New System.Drawing.Point(152, 18)
        Me.RDBwoman.Name = "RDBwoman"
        Me.RDBwoman.Size = New System.Drawing.Size(72, 20)
        Me.RDBwoman.TabIndex = 1
        Me.RDBwoman.TabStop = True
        Me.RDBwoman.Text = "Γυναίκα"
        Me.RDBwoman.UseVisualStyleBackColor = True
        '
        'RDBman
        '
        Me.RDBman.AutoSize = True
        Me.RDBman.Location = New System.Drawing.Point(3, 18)
        Me.RDBman.Name = "RDBman"
        Me.RDBman.Size = New System.Drawing.Size(71, 20)
        Me.RDBman.TabIndex = 0
        Me.RDBman.TabStop = True
        Me.RDBman.Text = "Άνδρας"
        Me.RDBman.UseVisualStyleBackColor = True
        '
        'BackToForm1
        '
        Me.BackToForm1.Location = New System.Drawing.Point(68, 508)
        Me.BackToForm1.Name = "BackToForm1"
        Me.BackToForm1.Size = New System.Drawing.Size(75, 23)
        Me.BackToForm1.TabIndex = 16
        Me.BackToForm1.Text = "Πίσω"
        Me.BackToForm1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(273, 91)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 13)
        Me.Label7.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(273, 149)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 13)
        Me.Label8.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(273, 208)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 13)
        Me.Label9.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(168, 270)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Η/Μ/Χ"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(273, 341)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(0, 13)
        Me.Label11.TabIndex = 21
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(272, 401)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(0, 13)
        Me.Label12.TabIndex = 22
        '
        'TxtBxDOBDay
        '
        Me.TxtBxDOBDay.Location = New System.Drawing.Point(28, 268)
        Me.TxtBxDOBDay.Name = "TxtBxDOBDay"
        Me.TxtBxDOBDay.Size = New System.Drawing.Size(24, 20)
        Me.TxtBxDOBDay.TabIndex = 40
        '
        'TxtBxDOBMonth
        '
        Me.TxtBxDOBMonth.Location = New System.Drawing.Point(68, 268)
        Me.TxtBxDOBMonth.Name = "TxtBxDOBMonth"
        Me.TxtBxDOBMonth.Size = New System.Drawing.Size(26, 20)
        Me.TxtBxDOBMonth.TabIndex = 41
        '
        'TxtBxDOBYear
        '
        Me.TxtBxDOBYear.Location = New System.Drawing.Point(109, 270)
        Me.TxtBxDOBYear.Name = "TxtBxDOBYear"
        Me.TxtBxDOBYear.Size = New System.Drawing.Size(52, 20)
        Me.TxtBxDOBYear.TabIndex = 42
        '
        'RDBsingle
        '
        Me.RDBsingle.AutoSize = True
        Me.RDBsingle.Location = New System.Drawing.Point(27, 21)
        Me.RDBsingle.Name = "RDBsingle"
        Me.RDBsingle.Size = New System.Drawing.Size(93, 20)
        Me.RDBsingle.TabIndex = 0
        Me.RDBsingle.TabStop = True
        Me.RDBsingle.Text = "Μονόκλινο"
        Me.RDBsingle.UseVisualStyleBackColor = True
        '
        'RDBpair
        '
        Me.RDBpair.AutoSize = True
        Me.RDBpair.Location = New System.Drawing.Point(27, 63)
        Me.RDBpair.Name = "RDBpair"
        Me.RDBpair.Size = New System.Drawing.Size(71, 20)
        Me.RDBpair.TabIndex = 1
        Me.RDBpair.TabStop = True
        Me.RDBpair.Text = "Δίκλινο"
        Me.RDBpair.UseVisualStyleBackColor = True
        '
        'RDBthreesome
        '
        Me.RDBthreesome.AutoSize = True
        Me.RDBthreesome.Location = New System.Drawing.Point(203, 21)
        Me.RDBthreesome.Name = "RDBthreesome"
        Me.RDBthreesome.Size = New System.Drawing.Size(79, 20)
        Me.RDBthreesome.TabIndex = 2
        Me.RDBthreesome.TabStop = True
        Me.RDBthreesome.Text = "Τρίκλινο"
        Me.RDBthreesome.UseVisualStyleBackColor = True
        '
        'RDBorgy
        '
        Me.RDBorgy.AutoSize = True
        Me.RDBorgy.Location = New System.Drawing.Point(203, 63)
        Me.RDBorgy.Name = "RDBorgy"
        Me.RDBorgy.Size = New System.Drawing.Size(97, 20)
        Me.RDBorgy.TabIndex = 3
        Me.RDBorgy.TabStop = True
        Me.RDBorgy.Text = "Τετράκλινο"
        Me.RDBorgy.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RDBorgy)
        Me.GroupBox3.Controls.Add(Me.RDBthreesome)
        Me.GroupBox3.Controls.Add(Me.RDBpair)
        Me.GroupBox3.Controls.Add(Me.RDBsingle)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(358, 88)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(336, 100)
        Me.GroupBox3.TabIndex = 23
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Τύπος δωματίου"
        '
        'LabelAge
        '
        Me.LabelAge.AutoSize = True
        Me.LabelAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.LabelAge.Location = New System.Drawing.Point(355, 191)
        Me.LabelAge.Name = "LabelAge"
        Me.LabelAge.Size = New System.Drawing.Size(150, 16)
        Me.LabelAge.TabIndex = 24
        Me.LabelAge.Text = "Ηλικία φιλοξενούμενου"
        '
        'Label1StayDays
        '
        Me.Label1StayDays.AutoSize = True
        Me.Label1StayDays.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label1StayDays.Location = New System.Drawing.Point(355, 249)
        Me.Label1StayDays.Name = "Label1StayDays"
        Me.Label1StayDays.Size = New System.Drawing.Size(119, 16)
        Me.Label1StayDays.TabIndex = 26
        Me.Label1StayDays.Text = "Ημέρες νοσηλείας"
        '
        'LabelIncome
        '
        Me.LabelIncome.AutoSize = True
        Me.LabelIncome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.LabelIncome.Location = New System.Drawing.Point(355, 309)
        Me.LabelIncome.Name = "LabelIncome"
        Me.LabelIncome.Size = New System.Drawing.Size(141, 16)
        Me.LabelIncome.TabIndex = 30
        Me.LabelIncome.Text = "Εισοδηματικά κριτήρια"
        '
        'IncomeTxtBox
        '
        Me.IncomeTxtBox.Location = New System.Drawing.Point(358, 334)
        Me.IncomeTxtBox.Name = "IncomeTxtBox"
        Me.IncomeTxtBox.Size = New System.Drawing.Size(246, 20)
        Me.IncomeTxtBox.TabIndex = 31
        '
        'RDByes
        '
        Me.RDByes.AutoSize = True
        Me.RDByes.Location = New System.Drawing.Point(21, 21)
        Me.RDByes.Name = "RDByes"
        Me.RDByes.Size = New System.Drawing.Size(46, 20)
        Me.RDByes.TabIndex = 0
        Me.RDByes.TabStop = True
        Me.RDByes.Text = "Ναι"
        Me.RDByes.UseVisualStyleBackColor = True
        '
        'RDBno
        '
        Me.RDBno.AutoSize = True
        Me.RDBno.Location = New System.Drawing.Point(163, 21)
        Me.RDBno.Name = "RDBno"
        Me.RDBno.Size = New System.Drawing.Size(46, 20)
        Me.RDBno.TabIndex = 1
        Me.RDBno.TabStop = True
        Me.RDBno.Text = "Όχι"
        Me.RDBno.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RDBno)
        Me.GroupBox2.Controls.Add(Me.RDByes)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(358, 388)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(258, 54)
        Me.GroupBox2.TabIndex = 32
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ιδιωτική ασφάλιση"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(788, 388)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(0, 13)
        Me.Label14.TabIndex = 34
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(785, 451)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(0, 13)
        Me.Label13.TabIndex = 35
        '
        'SaveRegister
        '
        Me.SaveRegister.Location = New System.Drawing.Point(575, 508)
        Me.SaveRegister.Name = "SaveRegister"
        Me.SaveRegister.Size = New System.Drawing.Size(90, 23)
        Me.SaveRegister.TabIndex = 36
        Me.SaveRegister.Text = "Αποθήκευση"
        Me.SaveRegister.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(665, 133)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(0, 13)
        Me.Label19.TabIndex = 37
        '
        'StayDaysTxtbx
        '
        Me.StayDaysTxtbx.Location = New System.Drawing.Point(358, 270)
        Me.StayDaysTxtbx.Name = "StayDaysTxtbx"
        Me.StayDaysTxtbx.Size = New System.Drawing.Size(33, 20)
        Me.StayDaysTxtbx.TabIndex = 44
        '
        'AgeTxtbx
        '
        Me.AgeTxtbx.Location = New System.Drawing.Point(358, 210)
        Me.AgeTxtbx.Name = "AgeTxtbx"
        Me.AgeTxtbx.Size = New System.Drawing.Size(33, 20)
        Me.AgeTxtbx.TabIndex = 43
        '
        'FullPatientInfoTableAdapter1
        '
        Me.FullPatientInfoTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.FullPatientInfoTableAdapter = Me.FullPatientInfoTableAdapter1
        Me.TableAdapterManager1.UpdateOrder = ClinicRegistry.FullPatientInfoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.UpdateInsertDelete
        '
        'FullPatientInfoDataSet1
        '
        Me.FullPatientInfoDataSet1.DataSetName = "FullPatientInfoDataSet"
        Me.FullPatientInfoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NewRegisterForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(748, 553)
        Me.Controls.Add(Me.StayDaysTxtbx)
        Me.Controls.Add(Me.AgeTxtbx)
        Me.Controls.Add(Me.TxtBxDOBYear)
        Me.Controls.Add(Me.TxtBxDOBMonth)
        Me.Controls.Add(Me.TxtBxDOBDay)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.SaveRegister)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.IncomeTxtBox)
        Me.Controls.Add(Me.LabelIncome)
        Me.Controls.Add(Me.Label1StayDays)
        Me.Controls.Add(Me.LabelAge)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.BackToForm1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.AddressTxtbox)
        Me.Controls.Add(Me.LabelAdress)
        Me.Controls.Add(Me.IDNumTxtbox)
        Me.Controls.Add(Me.LabelDOB)
        Me.Controls.Add(Me.LabelIDNum)
        Me.Controls.Add(Me.NameTxtbox)
        Me.Controls.Add(Me.LabelName)
        Me.Controls.Add(Me.SurnameTxtbx)
        Me.Controls.Add(Me.LabelSurname)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Name = "NewRegisterForm1"
        Me.Text = "Clinic Patient Registry/ New Patient"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.FullPatientInfoDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LabelSurname As System.Windows.Forms.Label
    Friend WithEvents SurnameTxtbx As System.Windows.Forms.TextBox
    Friend WithEvents LabelName As System.Windows.Forms.Label
    Friend WithEvents NameTxtbox As System.Windows.Forms.TextBox
    Friend WithEvents LabelIDNum As System.Windows.Forms.Label
    Friend WithEvents LabelDOB As System.Windows.Forms.Label
    Friend WithEvents IDNumTxtbox As System.Windows.Forms.TextBox
    Friend WithEvents LabelAdress As System.Windows.Forms.Label
    Friend WithEvents AddressTxtbox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RDBwoman As System.Windows.Forms.RadioButton
    Friend WithEvents RDBman As System.Windows.Forms.RadioButton
    Friend WithEvents BackToForm1 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TxtBxDOBDay As TextBox
    Friend WithEvents TxtBxDOBMonth As TextBox
    Friend WithEvents TxtBxDOBYear As TextBox
    Friend WithEvents RDBsingle As RadioButton
    Friend WithEvents RDBpair As RadioButton
    Friend WithEvents RDBthreesome As RadioButton
    Friend WithEvents RDBorgy As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents LabelAge As Label
    Friend WithEvents Label1StayDays As Label
    Friend WithEvents LabelIncome As Label
    Friend WithEvents IncomeTxtBox As TextBox
    Friend WithEvents RDByes As RadioButton
    Friend WithEvents RDBno As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents SaveRegister As Button
    Friend WithEvents Label19 As Label
    Friend WithEvents StayDaysTxtbx As TextBox
    Friend WithEvents AgeTxtbx As TextBox
    Friend WithEvents FullPatientInfoTableAdapter1 As FullPatientInfoDataSetTableAdapters.FullPatientInfoTableAdapter
    Friend WithEvents TableAdapterManager1 As FullPatientInfoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FullPatientInfoDataSet1 As FullPatientInfoDataSet
End Class
