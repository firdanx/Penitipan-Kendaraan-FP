Imports System.Data.Odbc

Public Class ClsCtlPencatatan : Implements InfProses
    Function kodebaru() As String
        Dim baru As String
        Dim kodeakhir As Integer
        Try
            DTA = New OdbcDataAdapter("select max(right(id_pencatatan,3))from tbl_pencatatan", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "max_kode")
            kodeakhir = Val(DTS.Tables("max_kode").Rows(0).Item(0))
            baru = "PC" & Strings.Right("000" & kodeakhir + 1, 3)
            Return baru
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function InsertData(Ob As Object) As OdbcCommand Implements InfProses.InsertData
        Dim data As New ClsEntPencatatan
        data = Ob
        CMD = New OdbcCommand("insert into tbl_pencatatan values('" & data.IdPencatatan & "','" & data.PlatNomor & "','" & data.IdLokasi & "','" & data.IdPegawai & "','" & data.WaktuKedatangan & "','" & data.WaktuPengambilan & "','" & data.JumlahHari & "','" & data.Tagihan & "')", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OdbcCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function updateData(Ob As Object) As OdbcCommand Implements InfProses.updateData
        Dim data As New ClsEntPencatatan
        data = Ob
        CMD = New OdbcCommand("update tbl_pencatatan set plat_nomor ='" & data.PlatNomor & "', id_lokasi ='" & data.IdLokasi & "', waktu_kedatangan ='" & data.WaktuKedatangan & "', waktu_pengambilan ='" & data.WaktuPengambilan & "', jumlah_hari ='" & data.JumlahHari & "', tagihan ='" & data.Tagihan & "' where id_pencatatan ='" & data.IdPencatatan & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OdbcCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function deleteData(kunci As String) As OdbcCommand Implements InfProses.deleteData
        CMD = New OdbcCommand("delete from tbl_pencatatan " & "where id_pencatatan='" & kunci & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OdbcCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function tampilData() As DataView Implements InfProses.tampilData
        Try
            DTA = New OdbcDataAdapter("select * from tbl_pencatatan", BUKAKONEKSI)

            DTS = New DataSet()
            DTA.Fill(DTS, "Tabel_Pencatatan")
            Dim grid As New DataView(DTS.Tables("Tabel_Pencatatan"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function cariData(kunci As String) As DataView Implements InfProses.cariData
        Try
            DTA = New OdbcDataAdapter("select * from tbl_pencatatan where id_pencatatan " & " like '%" & kunci & "%'", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "Cari_Pencatatan")
            Dim grid As New DataView(DTS.Tables("Cari_Pencatatan"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

End Class
