Public Class FormKendaraan
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
            With DGKendaraan.Rows(br)
                txtIdKendaraan.Text = .Cells(0).Value.ToString
                txtMerK.Text = .Cells(1).Value.ToString
                txtModelK.Text = .Cells(2).Value.ToString
            End With
        End If
    End Sub
    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        If MsgBox("Apakah anda yakin ingin keluar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
            Environment.Exit(1)
        End If
    End Sub

    Private Sub btnFormPemilik_Click(sender As Object, e As EventArgs) Handles btnFormPemilik.Click
        Me.Hide()
        FormPemilik.Show()
    End Sub

    Private Sub btnFormKendaraan_Click(sender As Object, e As EventArgs) Handles btnFormKendaraan.Click
        MsgBox("Anda sudah berada di form kendaran")
    End Sub

    Private Sub btnFormPencatatan_Click(sender As Object, e As EventArgs) Handles btnFormPencatatan.Click
        Me.Hide()
        FormPencatatan.Show()
    End Sub

    Private Sub btnFormLokasi_Click(sender As Object, e As EventArgs) Handles btnFormLokasi.Click
        Me.Hide()
        FormLokasi.Show()
    End Sub

    Private Sub RefreshGrid()
        DTGrid = KontrolKendaraan.tampilData.ToTable
        DGKendaraan.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGKendaraan.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGKendaraan.CurrentCell = DGKendaraan.Item(1, baris)
            AturButton(True)
            IsiBox(baris)
        End If
    End Sub

    Private Sub FormKendaraan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGrid()

        txtIdKendaraan.Enabled = False

    End Sub

    Private Sub TampilCari(kunci As String)
        DTGrid = KontrolKendaraan.cariData(kunci).ToTable

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGKendaraan.DataSource = DTGrid
            DGKendaraan.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGKendaraan.CurrentCell = DGKendaraan.Item(1, baris)
            IsiBox(baris)
        Else
            MsgBox("Data Tidak Ditemukan")
            RefreshGrid()
        End If
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        AturButton(False)
        modeProses = 1
        txtIdKendaraan.Text = KontrolKendaraan.kodebaru()
        txtMerK.Text = ""
        txtModelK.Text = ""
        txtMerK.Focus()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        AturButton(False)
        txtMerK.Focus()
        modeProses = 2
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim status_referensi As Boolean
        status_referensi = KontrolKendaraan.cekKendaraanDireferensi(txtIdKendaraan.Text)
        If status_referensi Then
            MsgBox("Data masih digunakan, tidak boleh dihapus", MsgBoxStyle.Exclamation, "peringatan")
            Exit Sub
        End If

        If MsgBox("Apakah Anda yakin akan menghapus " & txtIdKendaraan.Text & "-" & txtModelK.Text & "?",
                  MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
            KontrolKendaraan.deleteData(txtIdKendaraan.Text)
        End If
        RefreshGrid()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        With EntitasKendaraan
            .IdKendaraan = txtIdKendaraan.Text
            .MerkKendaraan = txtMerK.Text
            .ModelKendaraan = txtModelK.Text
        End With

        If modeProses = 1 Then
            KontrolKendaraan.InsertData(EntitasKendaraan)
            modeProses = 0
        ElseIf modeProses = 2 Then
            KontrolKendaraan.updateData(EntitasKendaraan)
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

    Private Sub DGKendaraan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGKendaraan.CellClick
        If modeProses = 0 Then
            baris = e.RowIndex
            DGKendaraan.Rows(baris).Selected = True
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