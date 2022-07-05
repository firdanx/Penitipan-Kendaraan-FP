Public Class ClsEntPencatatan
    Private _idPencatatan As String
    Private _platNomor As String
    Private _idLokasi As String
    Private _idPegawai As String
    Private _waktuKedatangan As String
    Private _waktuPengambilan As String
    Private _jumlahHari As Integer
    Private _tagihan As Integer

    Public Property IdPencatatan As String
        Get
            Return _idPencatatan
        End Get
        Set(value As String)
            _idPencatatan = value
        End Set
    End Property

    Public Property PlatNomor As String
        Get
            Return _platNomor
        End Get
        Set(value As String)
            _platNomor = value
        End Set
    End Property

    Public Property IdLokasi As String
        Get
            Return _idLokasi
        End Get
        Set(value As String)
            _idLokasi = value
        End Set
    End Property

    Public Property IdPegawai As String
        Get
            Return _idPegawai
        End Get
        Set(value As String)
            _idPegawai = value
        End Set
    End Property

    Public Property WaktuKedatangan As String
        Get
            Return _waktuKedatangan
        End Get
        Set(value As String)
            _waktuKedatangan = value
        End Set
    End Property

    Public Property WaktuPengambilan As String
        Get
            Return _waktuPengambilan
        End Get
        Set(value As String)
            _waktuPengambilan = value
        End Set
    End Property

    Public Property JumlahHari As Integer
        Get
            Return _jumlahHari
        End Get
        Set(value As Integer)
            _jumlahHari = value
        End Set
    End Property

    Public Property Tagihan As Integer
        Get
            Return _tagihan
        End Get
        Set(value As Integer)
            _tagihan = value
        End Set
    End Property
End Class
