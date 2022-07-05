Imports System.Data.Odbc
Public Class FormPencatatan
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
            With DGPencatatan.Rows(br)
                txtIdPencatatan.Text = .Cells(0).Value.ToString
                cmbPlatNomor.Text = .Cells(1).Value.ToString
                txtIdLokasi.Text = .Cells(2).Value.ToString
                dt1.Text = .Cells(4).Value.ToString
                dt2.Text = .Cells(5).Value.ToString
                txtJmlHari.Text = .Cells(6).Value.ToString
                txtTagihan.Text = .Cells(7).Value.ToString
            End With
        End If
    End Sub
    Private Sub TampilCari(kunci As String)
        DTGrid = KontrolPencatatan.cariData(kunci).ToTable

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGPencatatan.DataSource = DTGrid
            DGPencatatan.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGPencatatan.CurrentCell = DGPencatatan.Item(1, baris)
            IsiBox(baris)
        Else
            MsgBox("Data Tidak Ditemukan")
            RefreshGrid()
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
        Me.Hide()
        FormKendaraan.Show()
    End Sub

    Private Sub btnFormPencatatan_Click(sender As Object, e As EventArgs) Handles btnFormPencatatan.Click
        MsgBox("Anda sudah berada di form pencatatan")
    End Sub

    Private Sub btnFormLokasi_Click(sender As Object, e As EventArgs) Handles btnFormLokasi.Click
        Me.Hide()
        FormLokasi.Show()
    End Sub

    Private Sub RefreshGrid()
        DTGrid = KontrolPencatatan.tampilData.ToTable
        DGPencatatan.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGPencatatan.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGPencatatan.CurrentCell = DGPencatatan.Item(1, baris)
            AturButton(True)
            IsiBox(baris)
        End If
    End Sub

    Private Sub FormKendaraan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblIDPegawai.Text = KODELOG
        txtIdPencatatan.Enabled = False
        RefreshGrid()
        TampilPlatNomor()
        TampilLokasi()

    End Sub

    Sub TampilPlatNomor()
        CMD = New OdbcCommand("select plat_nomor from tbl_pemilik", BUKAKONEKSI)
        DTR = CMD.ExecuteReader
        cmbPlatNomor.Items.Clear()
        Do While DTR.Read
            cmbPlatNomor.Items.Add(DTR.Item("plat_nomor"))
        Loop
        BUKAKONEKSI.Close()
    End Sub

    Private Sub cmbPlatNomor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPlatNomor.SelectedIndexChanged
        CMD = New OdbcCommand("select * from tbl_pemilik where plat_nomor='" & cmbPlatNomor.Text & "'", BUKAKONEKSI)
        DTR = CMD.ExecuteReader
        DTR.Read()
        If DTR.HasRows Then
            txtPlatNomor.Text = DTR.Item("plat_nomor")
        Else
            MsgBox("Plat kendaraan tidak terdaftar")
        End If
    End Sub

    Sub TampilLokasi()
        CMD = New OdbcCommand("select letak_lokasi from tbl_lokasi", BUKAKONEKSI)
        DTR = CMD.ExecuteReader
        cmbLokasi.Items.Clear()
        Do While DTR.Read
            cmbLokasi.Items.Add(DTR.Item("letak_lokasi"))
        Loop
        BUKAKONEKSI.Close()
    End Sub
    Private Sub cmbLokasi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLokasi.SelectedIndexChanged
        CMD = New OdbcCommand("select * from tbl_lokasi where letak_lokasi='" & cmbLokasi.Text & "'", BUKAKONEKSI)
        DTR = CMD.ExecuteReader
        DTR.Read()
        If DTR.HasRows Then
            txtIdLokasi.Text = DTR.Item("id_lokasi")
        Else
            MsgBox("Lokasi tidak terdaftar")
        End If
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        AturButton(False)
        modeProses = 1
        txtIdPencatatan.Text = KontrolPencatatan.kodebaru()
        txtPlatNomor.Text = ""
        txtIdLokasi.Text = ""
        lblIDPegawai.Text = KODELOG
        dt1.Text = ""
        dt2.Text = ""
        txtJmlHari.Text = ""
        txtTagihan.Text = ""
        txtPlatNomor.Focus()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        AturButton(False)
        txtPlatNomor.Focus()
        modeProses = 2
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If MsgBox("Apakah Anda yakin akan menghapus " & txtIdPencatatan.Text & "-" & txtPlatNomor.Text & "?",
                  MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
            KontrolPencatatan.deleteData(txtIdPencatatan.Text)
        End If
        RefreshGrid()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim Dtone As String
        Dim Dttwo As String
        Dtone = dt1.Value.ToString("yyyy-MM-dd HH:mm:ss")
        Dttwo = dt2.Value.ToString("yyyy-MM-dd HH:mm:ss")

        With EntitasPencatatan
            .IdPencatatan = txtIdPencatatan.Text
            .PlatNomor = cmbPlatNomor.Text
            .IdLokasi = txtIdLokasi.Text
            .IdPegawai = lblIDPegawai.Text
            .WaktuKedatangan = Dtone
            .WaktuPengambilan = Dttwo
            .JumlahHari = txtJmlHari.Text
            .Tagihan = txtTagihan.Text
        End With

        If modeProses = 1 Then
            KontrolPencatatan.InsertData(EntitasPencatatan)
            modeProses = 0
        ElseIf modeProses = 2 Then
            KontrolPencatatan.updateData(EntitasPencatatan)
            modeProses = 0
        End If
        MsgBox("Data telah tersimpan" & EntitasPencatatan.WaktuKedatangan, MsgBoxStyle.Information, "Info")
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

    Private Sub DGPencatatan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGPencatatan.CellClick
        If modeProses = 0 Then
            baris = e.RowIndex
            DGPencatatan.Rows(baris).Selected = True
            IsiBox(baris)
        End If
    End Sub
End Class