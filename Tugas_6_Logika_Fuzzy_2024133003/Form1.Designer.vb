<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        txtTugas1 = New TextBox()
        LabelT2 = New Label()
        txtTugas2 = New TextBox()
        LabelT3 = New Label()
        txtTugas3 = New TextBox()
        LabelT4 = New Label()
        txtTugas4 = New TextBox()
        LabelT5 = New Label()
        txtTugas5 = New TextBox()
        Label2 = New Label()
        txtUTS = New TextBox()
        Label3 = New Label()
        txtUAS = New TextBox()
        btnHitung = New Button()
        btnReset = New Button()
        Label4 = New Label()
        lblNilaiAkhir = New Label()
        Label5 = New Label()
        lblRendah = New Label()
        Label6 = New Label()
        Label7 = New Label()
        lblSedang = New Label()
        lblTinggi = New Label()
        Label8 = New Label()
        Label9 = New Label()
        lblKinerja = New Label()
        Label10 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(40, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(117, 15)
        Label1.TabIndex = 0
        Label1.Text = "Nilai Tugas 1 (0-100):"
        ' 
        ' txtTugas1
        ' 
        txtTugas1.Location = New Point(170, 22)
        txtTugas1.Name = "txtTugas1"
        txtTugas1.Size = New Size(360, 23)
        txtTugas1.TabIndex = 1
        ' 
        ' LabelT2
        ' 
        LabelT2.AutoSize = True
        LabelT2.Location = New Point(40, 55)
        LabelT2.Name = "LabelT2"
        LabelT2.Size = New Size(117, 15)
        LabelT2.TabIndex = 2
        LabelT2.Text = "Nilai Tugas 2 (0-100):"
        ' 
        ' txtTugas2
        ' 
        txtTugas2.Location = New Point(170, 52)
        txtTugas2.Name = "txtTugas2"
        txtTugas2.Size = New Size(360, 23)
        txtTugas2.TabIndex = 3
        ' 
        ' LabelT3
        ' 
        LabelT3.AutoSize = True
        LabelT3.Location = New Point(40, 85)
        LabelT3.Name = "LabelT3"
        LabelT3.Size = New Size(117, 15)
        LabelT3.TabIndex = 4
        LabelT3.Text = "Nilai Tugas 3 (0-100):"
        ' 
        ' txtTugas3
        ' 
        txtTugas3.Location = New Point(170, 82)
        txtTugas3.Name = "txtTugas3"
        txtTugas3.Size = New Size(360, 23)
        txtTugas3.TabIndex = 5
        ' 
        ' LabelT4
        ' 
        LabelT4.AutoSize = True
        LabelT4.Location = New Point(40, 115)
        LabelT4.Name = "LabelT4"
        LabelT4.Size = New Size(117, 15)
        LabelT4.TabIndex = 6
        LabelT4.Text = "Nilai Tugas 4 (0-100):"
        ' 
        ' txtTugas4
        ' 
        txtTugas4.Location = New Point(170, 112)
        txtTugas4.Name = "txtTugas4"
        txtTugas4.Size = New Size(360, 23)
        txtTugas4.TabIndex = 7
        ' 
        ' LabelT5
        ' 
        LabelT5.AutoSize = True
        LabelT5.Location = New Point(40, 145)
        LabelT5.Name = "LabelT5"
        LabelT5.Size = New Size(117, 15)
        LabelT5.TabIndex = 8
        LabelT5.Text = "Nilai Tugas 5 (0-100):"
        ' 
        ' txtTugas5
        ' 
        txtTugas5.Location = New Point(170, 142)
        txtTugas5.Name = "txtTugas5"
        txtTugas5.Size = New Size(360, 23)
        txtTugas5.TabIndex = 9
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(60, 185)
        Label2.Name = "Label2"
        Label2.Size = New Size(97, 15)
        Label2.TabIndex = 10
        Label2.Text = "Nilai UTS (0-100):"
        ' 
        ' txtUTS
        ' 
        txtUTS.Location = New Point(170, 182)
        txtUTS.Name = "txtUTS"
        txtUTS.Size = New Size(360, 23)
        txtUTS.TabIndex = 11
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(60, 215)
        Label3.Name = "Label3"
        Label3.Size = New Size(99, 15)
        Label3.TabIndex = 12
        Label3.Text = "Nilai UAS (0-100):"
        ' 
        ' txtUAS
        ' 
        txtUAS.Location = New Point(170, 212)
        txtUAS.Name = "txtUAS"
        txtUAS.Size = New Size(360, 23)
        txtUAS.TabIndex = 13
        ' 
        ' btnHitung
        ' 
        btnHitung.Location = New Point(365, 248)
        btnHitung.Name = "btnHitung"
        btnHitung.Size = New Size(80, 28)
        btnHitung.TabIndex = 14
        btnHitung.Text = "Hitung"
        btnHitung.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(450, 248)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(80, 28)
        btnReset.TabIndex = 15
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        Label4.Location = New Point(365, 295)
        Label4.Name = "Label4"
        Label4.Size = New Size(67, 15)
        Label4.TabIndex = 23
        Label4.Text = "Nilai Akhir:"
        ' 
        ' lblNilaiAkhir
        ' 
        lblNilaiAkhir.AutoSize = True
        lblNilaiAkhir.Location = New Point(365, 315)
        lblNilaiAkhir.Name = "lblNilaiAkhir"
        lblNilaiAkhir.Size = New Size(28, 15)
        lblNilaiAkhir.TabIndex = 24
        lblNilaiAkhir.Text = "0.00"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(170, 320)
        Label5.Name = "Label5"
        Label5.Size = New Size(50, 15)
        Label5.TabIndex = 17
        Label5.Text = "Rendah:"
        ' 
        ' lblRendah
        ' 
        lblRendah.AutoSize = True
        lblRendah.Location = New Point(170, 338)
        lblRendah.Name = "lblRendah"
        lblRendah.Size = New Size(28, 15)
        lblRendah.TabIndex = 18
        lblRendah.Text = "0.00"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(170, 360)
        Label6.Name = "Label6"
        Label6.Size = New Size(49, 15)
        Label6.TabIndex = 19
        Label6.Text = "Sedang:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(170, 400)
        Label7.Name = "Label7"
        Label7.Size = New Size(43, 15)
        Label7.TabIndex = 21
        Label7.Text = "Tinggi:"
        ' 
        ' lblSedang
        ' 
        lblSedang.AutoSize = True
        lblSedang.Location = New Point(170, 378)
        lblSedang.Name = "lblSedang"
        lblSedang.Size = New Size(28, 15)
        lblSedang.TabIndex = 20
        lblSedang.Text = "0.00"
        ' 
        ' lblTinggi
        ' 
        lblTinggi.AutoSize = True
        lblTinggi.Location = New Point(170, 418)
        lblTinggi.Name = "lblTinggi"
        lblTinggi.Size = New Size(28, 15)
        lblTinggi.TabIndex = 22
        lblTinggi.Text = "0.00"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        Label8.Location = New Point(170, 295)
        Label8.Name = "Label8"
        Label8.Size = New Size(144, 15)
        Label8.TabIndex = 16
        Label8.Text = "Nilai Keanggotaan Fuzzy:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        Label9.Location = New Point(365, 345)
        Label9.Name = "Label9"
        Label9.Size = New Size(49, 15)
        Label9.TabIndex = 25
        Label9.Text = "Kinerja:"
        ' 
        ' lblKinerja
        ' 
        lblKinerja.AutoSize = True
        lblKinerja.Location = New Point(365, 365)
        lblKinerja.Name = "lblKinerja"
        lblKinerja.Size = New Size(28, 15)
        lblKinerja.TabIndex = 26
        lblKinerja.Text = "0.00"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(40, 5)
        Label10.Name = "Label10"
        Label10.Size = New Size(266, 15)
        Label10.TabIndex = 27
        Label10.Text = "Nilai Akhir akan diambil rata dari 5 tugas tersebut"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(600, 470)
        Controls.Add(Label10)
        Controls.Add(lblKinerja)
        Controls.Add(Label9)
        Controls.Add(lblNilaiAkhir)
        Controls.Add(Label4)
        Controls.Add(lblTinggi)
        Controls.Add(Label7)
        Controls.Add(lblSedang)
        Controls.Add(Label6)
        Controls.Add(lblRendah)
        Controls.Add(Label5)
        Controls.Add(Label8)
        Controls.Add(btnReset)
        Controls.Add(btnHitung)
        Controls.Add(txtUAS)
        Controls.Add(Label3)
        Controls.Add(txtUTS)
        Controls.Add(Label2)
        Controls.Add(txtTugas5)
        Controls.Add(LabelT5)
        Controls.Add(txtTugas4)
        Controls.Add(LabelT4)
        Controls.Add(txtTugas3)
        Controls.Add(LabelT3)
        Controls.Add(txtTugas2)
        Controls.Add(LabelT2)
        Controls.Add(txtTugas1)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Evaluasi Logika Fuzzy DSS"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtTugas1 As TextBox
    Friend WithEvents LabelT2 As Label
    Friend WithEvents txtTugas2 As TextBox
    Friend WithEvents LabelT3 As Label
    Friend WithEvents txtTugas3 As TextBox
    Friend WithEvents LabelT4 As Label
    Friend WithEvents txtTugas4 As TextBox
    Friend WithEvents LabelT5 As Label
    Friend WithEvents txtTugas5 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUTS As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUAS As TextBox
    Friend WithEvents btnHitung As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents lblNilaiAkhir As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblRendah As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblSedang As Label
    Friend WithEvents lblTinggi As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblKinerja As Label
    Friend WithEvents Label10 As Label

End Class