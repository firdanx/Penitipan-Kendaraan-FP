Public Class ClsEntLokasi
    Private _idLokasi As String
    Private _letakLokasi As String

    Public Property IdLokasi As String
        Get
            Return _idLokasi
        End Get
        Set(value As String)
            _idLokasi = value
        End Set
    End Property

    Public Property LetakLokasi As String
        Get
            Return _letakLokasi
        End Get
        Set(value As String)
            _letakLokasi = value
        End Set
    End Property
End Class
