Public Class Form1

    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim t1, t2, t3, t4, t5 As Double
        Dim uts, uas As Double

        ' 1. Validasi 5 Input Tugas (0-100)
        If Not Double.TryParse(txtTugas1.Text, t1) OrElse t1 < 0 OrElse t1 > 100 Then
            MessageBox.Show("Nilai Tugas 1 harus berupa angka 0 - 100!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtTugas1.Focus()
            Return
        End If

        If Not Double.TryParse(txtTugas2.Text, t2) OrElse t2 < 0 OrElse t2 > 100 Then
            MessageBox.Show("Nilai Tugas 2 harus berupa angka 0 - 100!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtTugas2.Focus()
            Return
        End If

        If Not Double.TryParse(txtTugas3.Text, t3) OrElse t3 < 0 OrElse t3 > 100 Then
            MessageBox.Show("Nilai Tugas 3 harus berupa angka 0 - 100!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtTugas3.Focus()
            Return
        End If

        If Not Double.TryParse(txtTugas4.Text, t4) OrElse t4 < 0 OrElse t4 > 100 Then
            MessageBox.Show("Nilai Tugas 4 harus berupa angka 0 - 100!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtTugas4.Focus()
            Return
        End If

        If Not Double.TryParse(txtTugas5.Text, t5) OrElse t5 < 0 OrElse t5 > 100 Then
            MessageBox.Show("Nilai Tugas 5 harus berupa angka 0 - 100!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtTugas5.Focus()
            Return
        End If

        ' 2. Validasi UTS dan UAS (0-100)
        If Not Double.TryParse(txtUTS.Text, uts) OrElse uts < 0 OrElse uts > 100 Then
            MessageBox.Show("Nilai UTS harus berupa angka 0 - 100!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUTS.Focus()
            Return
        End If

        If Not Double.TryParse(txtUAS.Text, uas) OrElse uas < 0 OrElse uas > 100 Then
            MessageBox.Show("Nilai UAS harus berupa angka 0 - 100!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUAS.Focus()
            Return
        End If

        ' 3. Hitung Rata-Rata Tugas & Nilai Akhir
        Dim rataTugas As Double = (t1 + t2 + t3 + t4 + t5) / 5.0
        Dim nilaiAkhir As Double = (rataTugas * 0.5) + (uts * 0.25) + (uas * 0.25)

        ' 4. Fuzzifikasi (Derajat Keanggotaan)
        ' Kurva Linier Rendah (0 - 60)
        Dim uRendah As Double = 0
        If nilaiAkhir <= 40 Then
            uRendah = 1.0
        ElseIf nilaiAkhir > 40 AndAlso nilaiAkhir < 60 Then
            uRendah = (60 - nilaiAkhir) / (60 - 40)
        Else
            uRendah = 0.0
        End If

        ' Kurva Segitiga Sedang (40 - 80)
        Dim uSedang As Double = 0
        If nilaiAkhir <= 40 OrElse nilaiAkhir >= 80 Then
            uSedang = 0.0
        ElseIf nilaiAkhir > 40 AndAlso nilaiAkhir <= 60 Then
            uSedang = (nilaiAkhir - 40) / (60 - 40)
        ElseIf nilaiAkhir > 60 AndAlso nilaiAkhir < 80 Then
            uSedang = (80 - nilaiAkhir) / (80 - 60)
        End If

        ' Kurva Linier Tinggi (60 - 100)
        Dim uTinggi As Double = 0
        If nilaiAkhir <= 60 Then
            uTinggi = 0.0
        ElseIf nilaiAkhir > 60 AndAlso nilaiAkhir < 80 Then
            uTinggi = (nilaiAkhir - 60) / (80 - 60)
        Else
            uTinggi = 1.0
        End If

        ' 5. Penentuan Kinerja
        Dim kinerja As String = ""
        If uTinggi >= uSedang AndAlso uTinggi >= uRendah Then
            kinerja = "Sangat Baik (Tinggi)"
        ElseIf uSedang >= uRendah Then
            kinerja = "Cukup (Sedang)"
        Else
            kinerja = "Kurang (Rendah)"
        End If

        ' 6. Tampilkan Hasil Ke Form
        lblNilaiAkhir.Text = nilaiAkhir.ToString("F2")
        lblRendah.Text = uRendah.ToString("F2")
        lblSedang.Text = uSedang.ToString("F2")
        lblTinggi.Text = uTinggi.ToString("F2")
        lblKinerja.Text = kinerja
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ' Kosongkan semua input
        txtTugas1.Clear()
        txtTugas2.Clear()
        txtTugas3.Clear()
        txtTugas4.Clear()
        txtTugas5.Clear()
        txtUTS.Clear()
        txtUAS.Clear()

        ' Reset output
        lblNilaiAkhir.Text = "0.00"
        lblRendah.Text = "0.00"
        lblSedang.Text = "0.00"
        lblTinggi.Text = "0.00"
        lblKinerja.Text = "-"

        txtTugas1.Focus()
    End Sub

End Class