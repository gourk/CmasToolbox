Imports System.Text
Imports System.Net
Imports System.Net.NetworkInformation

Public Class ClassUDPmenu

#Region "Variables"
    Private Sck As Sockets.Socket
    Private _AdresseIP As String
    Private _Port As Integer
    Private _open As Boolean
#End Region

#Region "Propriétés"
    Property AdresseIP() As String
        Get
            Return _AdresseIP
        End Get
        Set(ByVal value As String)
            _AdresseIP = value
        End Set
    End Property
    Property Open() As Boolean
        Get
            Return _open
        End Get
        Set(ByVal value As Boolean)
            _open = value
        End Set
    End Property
    Property Port() As Integer
        Get
            Return _Port
        End Get
        Set(ByVal value As Integer)
            _Port = value
        End Set
    End Property
#End Region

#Region "Constructeur/Destructeur"
    Public Sub New(ByVal adresseip As String, ByVal port As Integer)
        _CheckAdress(adresseip)
        _CheckPort(port)
        _AdresseIP = adresseip
        _Port = port
        If (Ping()) Then
            _open = True
        Else
            _open = False
        End If
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
    Private Function Ping() As Boolean
        Dim pingSender As Ping = New Ping()
        Dim options As PingOptions = New PingOptions()
        ' Use the default TTL value which is 128,
        options.DontFragment = True
        ' Create a buffer of 32 bytes of data to be transmitted.
        Dim data As String = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"
        Dim buffer() As Byte = Encoding.ASCII.GetBytes(data)
        Dim timeout As Integer = 1000
        Dim reply As PingReply = pingSender.Send(_AdresseIP, timeout, buffer, options)
        If reply.Status = IPStatus.Success Then
            Return True
        Else
            Return False
        End If
    End Function
#End Region

#Region "Méthodes publiques"
    Public Function Connect() As Boolean
        Try
            Sck = New Sockets.Socket(Sockets.AddressFamily.InterNetwork, Sockets.SocketType.Dgram, Sockets.ProtocolType.Udp)
            Sck.SetSocketOption(Sockets.SocketOptionLevel.Socket, Sockets.SocketOptionName.ReceiveTimeout, 10000)
            Sck.SetSocketOption(Sockets.SocketOptionLevel.Socket, Sockets.SocketOptionName.SendTimeout, 10000)
        Catch ex As Sockets.SocketException
            MessageBox.Show(ex.Message)
        End Try
    End Function

    Public Sub Deconnect()
        Sck.Close()
        _open = False
    End Sub

    Public Function Envoi(ByVal Commande As String) As String()
        Dim retstat, i As Integer
        Dim Due As DateTime
        Dim retour As String() = {"", "", "", ""}
        Dim test As String = ""
        Dim sendBytes, rcvBytes As Byte()
        i = 0
        Try
            Dim IP As New IPEndPoint(IPAddress.Parse(_AdresseIP), _Port)
            sendBytes = Encoding.ASCII.GetBytes(Commande)
            retstat = Sck.SendTo(sendBytes, 0, sendBytes.Length, Sockets.SocketFlags.None, IP)
            If retstat > 0 Then
                If Commande = "!0" Or Commande = "!1" Then
                    Due = Now.AddMilliseconds(10)
                Else
                    Due = Now.AddMilliseconds(2500) '2.5 second time-out 
                End If
                Do While Sck.Available = 0 AndAlso Now < Due
                Loop
                If Sck.Available = 0 Then
                    retour.SetValue("timeout", i)
                    Return retour
                End If
                Do While Sck.Available > 0
                    ReDim rcvBytes(Sck.Available - 1)
                    retstat = Sck.ReceiveFrom(rcvBytes, 0, Sck.Available, Sockets.SocketFlags.None, CType(IP, EndPoint))
                    test = Encoding.ASCII.GetString(rcvBytes)
                    retour.SetValue(test, i)
                    Threading.Thread.Sleep(100)
                    i = i + 1
                Loop
            Else
                retour.SetValue("fail on send", i)
                Return retour
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return retour
    End Function

    Public Function RetrieveVersion(ByVal ProductId As String, ByVal VersionId As String, ByVal VersionMoreID As String, ByVal VersionNumber As String) As String
        Dim Retour As String = ""
        Dim Product As String = ""
        Dim Version As String = ""

        '--------Retrieve Product----------
        Select Case ProductId
            '---- Low cost Family ----
            Case "022"
                Product = "Microcap-2"
                Version = ""
            Case "023"
                Product = "Microcap-S5"
                Select Case VersionId
                    Case "220"
                        Version = "Ethernet"
                    Case Else
                        Version = ""
                End Select
            Case "024"
                Product = "Microcap IP"
                Version = "Captor + Hortimax version"
            Case "025"
                Product = "Microcap IP model 2004"
                Select Case VersionId
                    Case "140"
                        Version = "Captor version"
                    Case "240"
                        Version = "Hortimax version"
                    Case Else
                        Version = ""
                End Select
            Case "026"
                Product = "Microcap IP model 2007"
                Select Case VersionId
                    Case "180"
                        Version = "Captor version"
                    Case "280"
                        Version = "Hortimax version"
                    Case Else
                        Version = ""
                End Select
            Case "092"
                Product = "KLM MII terminal"
                Version = "Standard firmware Capnet"
            Case "411"
                Product = "Boxio-32/8"
                Version = ""
                ' ---- Consul Family ----
            Case "811"
                Product = "Consul Standard"
                Version = ""
            Case "812"
                Product = "Consul Attend"
                Version = ""
            Case "813"
                Product = "Consul Captalk"
                Select Case VersionId
                    Case "520"
                        Version = "2 line LCD"
                    Case "540"
                        Version = "4 line LCD"
                    Case Else
                        Version = ""
                End Select
            Case "831"
                Product = "Consul Entry"
                Select Case VersionId
                    Case "120"
                        Version = "2 line LCD"
                    Case "140"
                        Version = "4 line LCD"
                    Case "220"
                        Version = "Slave firmware"
                    Case Else
                        Version = ""
                End Select
                ' ---- Omni Family ----
            Case "851"
                Product = "Omni Cadet (MI)"
                Version = ""
            Case "852"
                Product = "Omni (MI)"
                Select Case VersionId
                    Case "140"
                        Version = "before version 3.4e"
                    Case "240"
                        Version = "Dallas socket"
                    Case "340"
                        Version = "Marin chip"
                    Case Else
                        Version = ""
                End Select
            Case "861"
                Product = "Omni Cadet (MII)"
                Select Case VersionId
                    Case "280"
                        Version = "Cadet fingerprint identify"
                    Case Else
                        Version = ""
                End Select
            Case "862"
                Product = "Omni (MII)"
                Select Case VersionId
                    Case "280"
                        Version = "Attend fingerprint identify"
                    Case Else
                        Version = ""
                End Select
            Case "871"
                Product = "Omni Cadet (MIII)"
                Version = ""
            Case "872"
                Product = "Omni (MIII)"
                Version = ""
            Case "931"
                Product = "Omni String terminal"
                Select Case VersionId
                    Case "120"
                        Version = "2 line LCD"
                    Case "140"
                        Version = "4 line LCD"
                    Case Else
                        Version = ""
                End Select
            Case "932"
                Product = "Omni String reader"
                Version = ""
            Case "941"
                Product = "Omni Access reader"
                Version = "Motorized card reader"
            Case "942"
                Product = "Omni Access reader"
                Version = "eID reader"
                ' ---- UBOX & CMAS Family ----
            Case "681"
                Product = "UBOX model 2004"
                Version = ""
            Case "691"
                Product = "CMAS slave"
                Select Case VersionId
                    Case "100"
                        Version = "CMAS-UU"
                    Case "200"
                        Version = "CMAS-AT_SU (AT slave)"
                    Case "300"
                        Version = "CMAS-IU_SU (IU slave)"
                    Case Else
                        Version = ""
                End Select
            Case "692"
                Product = "CMAS master"
                Select Case VersionId
                    Case "100"
                        Version = "ATTEND firmware"
                    Case "200"
                        Version = "IU firmware"
                    Case Else
                        Version = ""
                End Select
            Case "693"
                Product = "CMAS IO"
                Select Case VersionId
                    Case "200"
                        Version = "CMAS-AT_IO (AT slave)"
                    Case "300"
                        Version = "CMAS-IU_IO (IU slave)"
                    Case Else
                        Version = ""
                End Select
            Case Else
                Product = "Unknow Product"
        End Select

        '--------Retrieve Version----------
        If String.Compare(VersionMoreID, "0000") = 0 Then
            Version = Version + " version " + VersionNumber
        ElseIf VersionMoreID.StartsWith("a") Then
            Version = Version + " Attend " + VersionMoreID.Substring(1)
        ElseIf VersionMoreID.StartsWith("c") Then
            Version = Version + " Clock " + VersionMoreID.Substring(1)
        Else
            Version = Version + " " + VersionMoreID
        End If
        Return (Product + " " + Version)
    End Function
#End Region

End Class
  
