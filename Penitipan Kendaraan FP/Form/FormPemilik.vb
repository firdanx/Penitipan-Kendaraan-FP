Imports System.Data.Odbc
Public Class FormPemilik
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
            With DGPemilik.Rows(br)
                txtPlatNomor.Text = .Cells(0).Value.ToString
                'txtIDKategori.Text = .Cells(1).Value.ToString
                txtNamaPemilik.Text = .Cells(2).Value.ToString
                txtAlamatP.Text = .Cells(3).Value.ToString
            End With
        End If
    End Sub
    Private Sub TampilCari(kunci As String)
        DTGrid = KontrolPemilik.cariData(kunci).ToTable

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGPemilik.DataSource = DTGrid
            DGPemilik.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGPemilik.CurrentCell = DGPemilik.Item(1, baris)
            IsiBox(baris)
        Else
            MsgBox("Data Tidak Ditemukan")
            RefreshGrid()
        End If
    End Sub

    Private Sub btnFormKendaraan_Click(sender As Object, e As EventArgs) Handles btnFormKendaraan.Click
        Me.Hide()
        FormKendaraan.Show()
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        If MsgBox("Apakah anda yakin ingin keluar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
            Environment.Exit(1)
        End If
    End Sub

    Private Sub btnFormPemilik_Click(sender As Object, e As EventArgs) Handles btnFormPemilik.Click
        MsgBox("Anda sudah berada di form pemilik")
    End Sub

    Private Sub btnFormTransaksi_Click(sender As Object, e As EventArgs) Handles btnFormTransaksi.Click
        Me.Hide()
        FormPencatatan.Show()
    End Sub

    Private Sub btnFormLokasi_Click(sender As Object, e As EventArgs) Handles btnFormLokasi.Click
        Me.Hide()
        FormLokasi.Show()
    End Sub

    Private Sub RefreshGrid()
        DTGrid = KontrolPemilik.tampilData.ToTable
        DGPemilik.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGPemilik.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGPemilik.CurrentCell = DGPemilik.Item(1, baris)
            AturButton(True)
            IsiBox(baris)
        End If
    End Sub

    Private Sub FormPemilik_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGrid()
        TampilKendaraan()

    End Sub

    Sub TampilKendaraan()
        CMD = New OdbcCommand("select model_kendaraan from tbl_kendaraan", BUKAKONEKSI)
        DTR = CMD.ExecuteReader
        cmbMerkK.Items.Clear()
        Do While DTR.Read
            cmbMerkK.Items.Add(DTR.Item("model_kendaraan"))
        Loop
        BUKAKONEKSI.Close()
    End Sub

    Private Sub cmbMerkK_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMerkK.SelectedIndexChanged
        CMD = New OdbcCommand("select * from tbl_kendaraan where model_kendaraan='" & cmbMerkK.Text & "'", BUKAKONEKSI)
        DTR = CMD.ExecuteReader
        DTR.Read()
        If DTR.HasRows Then
            txtIDKendaraan.Text = DTR.Item("id_kendaraan")
        Else
            MsgBox("Model kendaraan tidak terdaftar")
        End If
    End Sub

    Private Sub DGPemilik_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGPemilik.CellClick
        If modeProses = 0 Then
            baris = e.RowIndex
            DGPemilik.Rows(baris).Selected = True
            IsiBox(baris)
        End If
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        AturButton(False)
        modeProses = 1
        txtPlatNomor.Text = ""
        txtIDKendaraan.Text = ""
        txtNamaPemilik.Text = ""
        txtAlamatP.Text = ""
        txtPlatNomor.Focus()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        AturButton(False)
        txtPlatNomor.Focus()
        modeProses = 2
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim status_referensi As Boolean
        status_referensi = KontrolPemilik.cekPemilikDireferensi(txtPlatNomor.Text)
        If status_referensi Then
            MsgBox("Data masih digunakan, tidak boleh dihapus", MsgBoxStyle.Exclamation, "peringatan")
            Exit Sub
        End If

        If MsgBox("Apakah Anda yakin akan menghapus " & txtPlatNomor.Text & "-" & txtNamaPemilik.Text & "?",
                  MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
            KontrolPemilik.deleteData(txtPlatNomor.Text)
        End If
        RefreshGrid()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        With EntitasPemilik
            .PlatNomor = txtPlatNomor.Text
            .IdKendaraan = txtIDKendaraan.Text
            .NamaPemilik = txtNamaPemilik.Text
            .Alamat = txtAlamatP.Text
        End With

        If modeProses = 1 Then
            KontrolPemilik.InsertData(EntitasPemilik)
            modeProses = 0
        ElseIf modeProses = 2 Then
            KontrolPemilik.updateData(EntitasPemilik)
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

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        If txtCari.Text = "" Then
            Call RefreshGrid()
        Else
            Call TampilCari(txtCari.Text)
            txtCari.Focus()
        End If
    End Sub

End Class