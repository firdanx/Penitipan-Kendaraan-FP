Public Class FormLokasi
    Dim modeProses As Integer
    Dim baris As Integer

    Private Sub AturButton(st As Boolean)
        btnTambah.Enabled = st
        btnEdit.Enabled = st
        btnHapus.Enabled = st
        btnSimpan.Enabled = Not st
        btnCancel.Enabled = Not st

        GroupBox1.Enabled = st

    End Sub

    Private Sub IsiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGLokasi.Rows(br)
                txtIdLokasi.Text = .Cells(0).Value.ToString
                txtLetakLokasi.Text = .Cells(1).Value.ToString
            End With
        End If
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        If MsgBox("Apakah anda yakin ingin keluar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
            Environment.Exit(1)
        End If
    End Sub

    Private Sub btnFormKendaraan_Click(sender As Object, e As EventArgs) Handles btnFormKendaraan.Click
        Me.Hide()
        FormKendaraan.Show()
    End Sub

    Private Sub btnFormPemilik_Click(sender As Object, e As EventArgs) Handles btnFormPemilik.Click
        Me.Hide()
        FormPemilik.Show()
    End Sub

    Private Sub btnFormPencatatan_Click(sender As Object, e As EventArgs) Handles btnFormPencatatan.Click
        Me.Hide()
        FormPencatatan.Show()
    End Sub

    Private Sub btnFormLokasi_Click(sender As Object, e As EventArgs) Handles btnFormLokasi.Click
        MsgBox("Anda sudah berada di form lokasi")
    End Sub

    Private Sub RefreshGrid()
        DTGrid = KontrolLokasi.tampilData.ToTable
        DGLokasi.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGLokasi.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGLokasi.CurrentCell = DGLokasi.Item(1, baris)
            AturButton(True)
            IsiBox(baris)
        End If
    End Sub

    Private Sub FormLokasi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGrid()

        txtIdLokasi.Enabled = False
    End Sub

    Private Sub TampilCari(kunci As String)
        DTGrid = KontrolLokasi.cariData(kunci).ToTable

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGLokasi.DataSource = DTGrid
            DGLokasi.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGLokasi.CurrentCell = DGLokasi.Item(1, baris)
            IsiBox(baris)
        Else
            MsgBox("Data Tidak Ditemukan")
            RefreshGrid()
        End If
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        AturButton(False)
        modeProses = 1
        txtIdLokasi.Text = KontrolLokasi.kodebaru()
        txtLetakLokasi.Text = ""
        txtLetakLokasi.Focus()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        AturButton(False)
        txtLetakLokasi.Focus()
        modeProses = 2
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim status_referensi As Boolean
        status_referensi = KontrolLokasi.cekLokasiDireferensi(txtIdLokasi.Text)
        If status_referensi Then
            MsgBox("Data masih digunakan, tidak boleh dihapus", MsgBoxStyle.Exclamation, "peringatan")
            Exit Sub
        End If

        If MsgBox("Apakah Anda yakin akan menghapus " & txtIdLokasi.Text & "-" & txtLetakLokasi.Text & "?",
                  MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
            KontrolLokasi.deleteData(txtIdLokasi.Text)
        End If
        RefreshGrid()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        With EntitasLokasi
            .IdLokasi = txtIdLokasi.Text
            .LetakLokasi = txtLetakLokasi.Text
        End With

        If modeProses = 1 Then
            KontrolLokasi.InsertData(EntitasLokasi)
            modeProses = 0
        ElseIf modeProses = 2 Then
            KontrolLokasi.updateData(EntitasLokasi)
            modeProses = 0
        End If
        MsgBox("Data telah tersimpan", MsgBoxStyle.Information, "Info")
        RefreshGrid()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        RefreshGrid()
        AturButton(True)
        modeProses = 0
    End Sub

    Private Sub DGLokasi_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGLokasi.CellClick
        If modeProses = 0 Then
            baris = e.RowIndex
            DGLokasi.Rows(baris).Selected = True
            IsiBox(baris)
        End If
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        If txtCari.Text = "" Then
            Call RefreshGrid()
        Else
            Call TampilCari(txtCari.Text)
            txtCari.Focus()
        End If
    End Sub
End Class