Public Class CMASReader
#Region "Variables"
    Private _ID As String
    Private _Type As String
#End Region

#Region "Propriétés"
    Property ID() As String
        Get
            Return _ID
        End Get
        Set(ByVal value As String)
            _ID = value
        End Set
    End Property
    Property Type() As String
        Get
            Return _Type
        End Get
        Set(ByVal value As String)
            _Type = value
        End Set
    End Property
#End Region


#Region "Constructeur/Destructeur"
    Public Sub New(ByVal id As String, ByVal type As String)
        _ID = id
        _Type = type
    End Sub
#End Region
End Class
