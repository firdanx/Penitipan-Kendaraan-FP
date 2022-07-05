Public Class ClsEntPemilik
    Private _platNomor As String
    Private _idKendaraan As String
    Private _namaPemilik As String
    Private _alamat As String

    Public Property PlatNomor As String
        Get
            Return _platNomor
        End Get
        Set(value As String)
            _platNomor = value
        End Set
    End Property

    Public Property IdKendaraan As String
        Get
            Return _idKendaraan
        End Get
        Set(value As String)
            _idKendaraan = value
        End Set
    End Property

    Public Property NamaPemilik As String
        Get
            Return _namaPemilik
        End Get
        Set(value As String)
            _namaPemilik = value
        End Set
    End Property

    Public Property Alamat As String
        Get
            Return _alamat
        End Get
        Set(value As String)
            _alamat = value
        End Set
    End Property
End Class
