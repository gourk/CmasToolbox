Public Class EthernetParameters

#Region "Variables"
    Private _AdresseIP As String
    Private _Masque As String
    Private _Passerelle As String
    Private _Port As String
    Private _Vitesse As Int16
    Private _Duplex As Int16
#End Region

#Region "Constructeur/Destructeur"
    Public Sub New(ByVal adresseip As String, ByVal masque As String, ByVal passerelle As String, ByVal port As Integer, ByVal vitesse As Int16, ByVal duplex As Int16)
        _CheckAdress(adresseip)
        _CheckAdress(masque)
        _CheckAdress(passerelle)
        _CheckPort(port)
        _AdresseIP = _TransformAdress(adresseip)
        _Masque = _TransformAdress(masque)
        _Passerelle = _TransformAdress(passerelle)
        _Port = Hex(port)
        _Vitesse = vitesse
        _Duplex = duplex
        'MessageBox.Show(_AdresseIP + ":" + _Port + "/" + _Masque + "/" + _Passerelle)
    End Sub
#End Region

#Region "Méthodes privées"
    Private Sub _CheckAdress(ByVal Adress As String)
        Dim rg As New System.Text.RegularExpressions.Regex("^(25[0-5]|2[0-4]\d|[0-1]?\d?\d)(\.(25[0-5]|2[0-4]\d|[0-1]?\d?\d)){3}$")
        If rg.IsMatch(Adress) = False Then
            Throw (New Exception("Invalid adress " + Adress))
        End If
    End Sub
    Private Sub _CheckPort(ByVal Port As Integer)
        Dim rg As New System.Text.RegularExpressions.Regex("^[0-9]{1,6}$")
        If rg.IsMatch(Port.ToString) = False Or Port > 65635 Then
            Throw (New Exception("Invalid port " + Port.ToString))
        End If
    End Sub
    Private Function _TransformAdress(ByVal Adress As String) As String
        Dim rg As New System.Text.RegularExpressions.Regex("\.")
        Dim retour As String = ""
        Dim AdSp As String() = rg.Split(Adress)
        For Each ad As String In AdSp
            Select Case Hex(ad).Length
                Case 1
                    retour = retour & "0" & Hex(ad)
                Case Else
                    retour = retour & Hex(ad)
            End Select
        Next
        Return retour
    End Function
#End Region

#Region "Méthodes publiques"
    Public Function CommandCMASAT() As String
        Return "!!644999" + _AdresseIP + _Masque + _Passerelle + _Port + _Vitesse.ToString + _Duplex.ToString
    End Function
    Public Function CommandCMASIU() As String
        Return "@UCE" + _AdresseIP + _Masque + _Passerelle + _Port + _Vitesse.ToString + _Duplex.ToString
    End Function
#End Region

End Class
