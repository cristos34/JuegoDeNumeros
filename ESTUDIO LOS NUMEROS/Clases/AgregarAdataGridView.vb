Public Class AgregarAdataGridView
    Private _nombrejuego As String
    Private _operacion As String
    Private _respuesta As String

    Public Property nombrejuego As String
        Get
            Return _nombrejuego
        End Get
        Set(value As String)
            _nombrejuego = value
        End Set

    End Property
    Public Property operacion As String
        Get
            Return _operacion
        End Get
        Set(value As String)
            _operacion = value
        End Set

    End Property
    Public Property respuesta As String
        Get
            Return _respuesta
        End Get
        Set(value As String)
            _respuesta = value
        End Set

    End Property


End Class
