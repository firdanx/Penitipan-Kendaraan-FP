Public Class ClsEntKendaraan
    Private _idKendaraan As String
    Private _merkKendaraan As String
    Private _modelKendaraan As String

    Public Property IdKendaraan As String
        Get
            Return _idKendaraan
        End Get
        Set(value As String)
            _idKendaraan = value
        End Set
    End Property

    Public Property MerkKendaraan As String
        Get
            Return _merkKendaraan
        End Get
        Set(value As String)
            _merkKendaraan = value
        End Set
    End Property

    Public Property ModelKendaraan As String
        Get
            Return _modelKendaraan
        End Get
        Set(value As String)
            _modelKendaraan = value
        End Set
    End Property
End Class
