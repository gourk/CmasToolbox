Public Class CMASString

#Region "Variables"
    Private _CMAS As String
    Private _UniqueID As String
    Private _IO As CMASReader
    Private _Reader1 As CMASReader
    Private _Reader2 As CMASReader
#End Region

#Region "Propriétés"
    ReadOnly Property UniqueID() As String
        Get
            Return _UniqueID
        End Get
    End Property
    Property Reader1ID() As String
        Get
            Return _Reader1.ID
        End Get
        Set(ByVal value As String)
            _Reader1.ID = value
        End Set
    End Property
    Property Reader1Type() As String
        Get
            Return _Reader1.Type
        End Get
        Set(ByVal value As String)
            _Reader1.Type = value
        End Set
    End Property
    Property Reader2ID() As String
        Get
            Return _Reader2.ID
        End Get
        Set(ByVal value As String)
            _Reader2.ID = value
        End Set
    End Property
    Property Reader2Type() As String
        Get
            Return _Reader2.Type
        End Get
        Set(ByVal value As String)
            _Reader2.Type = value
        End Set
    End Property
    Property IOID() As String
        Get
            Return _IO.ID
        End Get
        Set(ByVal value As String)
            _IO.ID = value
        End Set
    End Property
#End Region

#Region "Constructeur/Destructeur"
    Public Sub New(ByVal UniqueID As String)
        _UniqueID = UniqueID
        _IO = New CMASReader("02", "0")
        _Reader1 = New CMASReader("03", "2")
        _Reader2 = New CMASReader("04", "2")
    End Sub
#End Region

#Region "Méthodes privées"
    
#End Region

#Region "Méthodes publiques"
    Public Function Identify() As String
        Return "!!009903" + _UniqueID
    End Function
    Public Function ChangeID(ByVal id1 As String, ByVal id2 As String, ByVal id3 As String, ByVal type1 As String, ByVal type2 As String) As String
        Dim commande As String
        _IO.ID = id1
        _Reader1.ID = id2
        _Reader1.Type = type1
        _Reader2.ID = id3
        _Reader2.Type = type2
        commande = "!!009904" & _UniqueID & _IO.ID & _Reader1.ID & _Reader2.ID & _Reader1.Type & _Reader2.Type
        Return commande
    End Function
#End Region
End Class
