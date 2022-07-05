Public Class ClsEntPegawai
    Private _idPegawai As String
    Private _username As String
    Private _password As String
    Private _nama As String

    Public Property IdPegawai As String
        Get
            Return _idPegawai
        End Get
        Set(value As String)
            _idPegawai = value
        End Set
    End Property

    Public Property Username As String
        Get
            Return _username
        End Get
        Set(value As String)
            _username = value
        End Set
    End Property

    Public Property Password As String
        Get
            Return _password
        End Get
        Set(value As String)
            _password = value
        End Set
    End Property

    Public Property Nama As String
        Get
            Return _nama
        End Get
        Set(value As String)
            _nama = value
        End Set
    End Property
End Class
