Imports System.Text
Imports System.IO

Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents CtxtMenu As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents List As System.Windows.Forms.ListBox
    Friend WithEvents txtSend As System.Windows.Forms.TextBox
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPort As System.Windows.Forms.TextBox
    Friend WithEvents txtIP As System.Windows.Forms.TextBox
    Friend WithEvents btnDisconnect As System.Windows.Forms.Button
    Friend WithEvents btnConnect As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnSendFile As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents btnSendEthernetAT As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnRetroActive As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lstIUethDplx As System.Windows.Forms.ListBox
    Friend WithEvents lstIUethSpeed As System.Windows.Forms.ListBox
    Friend WithEvents btnSendEthernetIU As System.Windows.Forms.Button
    Friend WithEvents txtIUethGW As System.Windows.Forms.TextBox
    Friend WithEvents txtIUethMask As System.Windows.Forms.TextBox
    Friend WithEvents txtIUethPort As System.Windows.Forms.TextBox
    Friend WithEvents txtIUethIP As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents lbID4 As System.Windows.Forms.Label
    Friend WithEvents lbID3 As System.Windows.Forms.Label
    Friend WithEvents lbID2 As System.Windows.Forms.Label
    Friend WithEvents lbID1 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnRQID As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtR2ID4 As System.Windows.Forms.TextBox
    Friend WithEvents txtR1ID4 As System.Windows.Forms.TextBox
    Friend WithEvents txtR2ID3 As System.Windows.Forms.TextBox
    Friend WithEvents txtR1ID3 As System.Windows.Forms.TextBox
    Friend WithEvents txtR2ID2 As System.Windows.Forms.TextBox
    Friend WithEvents txtR1ID2 As System.Windows.Forms.TextBox
    Friend WithEvents txtR2ID1 As System.Windows.Forms.TextBox
    Friend WithEvents txtR1ID1 As System.Windows.Forms.TextBox
    Friend WithEvents txtR2Typ4 As System.Windows.Forms.TextBox
    Friend WithEvents txtR2Typ3 As System.Windows.Forms.TextBox
    Friend WithEvents txtR2Typ2 As System.Windows.Forms.TextBox
    Friend WithEvents txtR2Typ1 As System.Windows.Forms.TextBox
    Friend WithEvents txtR1Typ3 As System.Windows.Forms.TextBox
    Friend WithEvents txtR1Typ4 As System.Windows.Forms.TextBox
    Friend WithEvents txtR1Typ2 As System.Windows.Forms.TextBox
    Friend WithEvents txtR1Typ1 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtIO4 As System.Windows.Forms.TextBox
    Friend WithEvents txtIO3 As System.Windows.Forms.TextBox
    Friend WithEvents txtIO2 As System.Windows.Forms.TextBox
    Friend WithEvents txtIO1 As System.Windows.Forms.TextBox
    Friend WithEvents btnGet3 As System.Windows.Forms.Button
    Friend WithEvents btnGet2 As System.Windows.Forms.Button
    Friend WithEvents btnGet1 As System.Windows.Forms.Button
    Friend WithEvents btnGet4 As System.Windows.Forms.Button
    Friend WithEvents btnSet4 As System.Windows.Forms.Button
    Friend WithEvents btnSet3 As System.Windows.Forms.Button
    Friend WithEvents btnSet2 As System.Windows.Forms.Button
    Friend WithEvents btnSet1 As System.Windows.Forms.Button
    Friend WithEvents btnIdentify4 As System.Windows.Forms.Button
    Friend WithEvents btnIdentify3 As System.Windows.Forms.Button
    Friend WithEvents btnIdentify2 As System.Windows.Forms.Button
    Friend WithEvents btnIdentify1 As System.Windows.Forms.Button


    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents lbIUID4 As System.Windows.Forms.Label
    Friend WithEvents lbIUID3 As System.Windows.Forms.Label
    Friend WithEvents lbIUID2 As System.Windows.Forms.Label
    Friend WithEvents lbIUID1 As System.Windows.Forms.Label
    Friend WithEvents LabelIU1 As System.Windows.Forms.Label
    Friend WithEvents btnIURQID As System.Windows.Forms.Button
    'Friend WithEvents LabelIU7 As System.Windows.Forms.Label
    'Friend WithEvents LabelIU6 As System.Windows.Forms.Label
    Friend WithEvents txtIUR1ID4 As System.Windows.Forms.TextBox
    Friend WithEvents txtIUR1ID3 As System.Windows.Forms.TextBox
    Friend WithEvents txtIUR1ID2 As System.Windows.Forms.TextBox
    Friend WithEvents txtIUR1ID1 As System.Windows.Forms.TextBox
    Friend WithEvents txtIUR2Typ4 As System.Windows.Forms.TextBox
    Friend WithEvents txtIUR2Typ3 As System.Windows.Forms.TextBox
    Friend WithEvents txtIUR2Typ2 As System.Windows.Forms.TextBox
    Friend WithEvents txtIUR2Typ1 As System.Windows.Forms.TextBox
    Friend WithEvents txtIUR1Typ3 As System.Windows.Forms.TextBox
    Friend WithEvents txtIUR1Typ4 As System.Windows.Forms.TextBox
    Friend WithEvents txtIUR1Typ2 As System.Windows.Forms.TextBox
    Friend WithEvents txtIUR1Typ1 As System.Windows.Forms.TextBox
    'Friend WithEvents LabelIU8 As System.Windows.Forms.Label
    Friend WithEvents btnIUSetSlave As System.Windows.Forms.Button
    Friend WithEvents btnIUIdentify As System.Windows.Forms.Button
    Friend WithEvents btnIUSetReader As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents ctrlService As System.ServiceProcess.ServiceController
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents lbService As System.Windows.Forms.ListBox
    Friend WithEvents lbStatus As System.Windows.Forms.Label
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents btnVersion As System.Windows.Forms.Button
    'Friend WithEvents LabelIU2 As System.Windows.Forms.Label
    'Friend WithEvents LabelIU3 As System.Windows.Forms.Label
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.CtxtMenu = New System.Windows.Forms.ContextMenu
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.List = New System.Windows.Forms.ListBox
        Me.txtSend = New System.Windows.Forms.TextBox
        Me.btnSend = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtPort = New System.Windows.Forms.TextBox
        Me.txtIP = New System.Windows.Forms.TextBox
        Me.btnDisconnect = New System.Windows.Forms.Button
        Me.btnConnect = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnVersion = New System.Windows.Forms.Button
        Me.btnRetroActive = New System.Windows.Forms.Button
        Me.btnSendFile = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.btnSendEthernetAT = New System.Windows.Forms.Button
        Me.btnReset = New System.Windows.Forms.Button
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.ListBox2 = New System.Windows.Forms.ListBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.btnIdentify4 = New System.Windows.Forms.Button
        Me.btnIdentify3 = New System.Windows.Forms.Button
        Me.btnIdentify2 = New System.Windows.Forms.Button
        Me.btnIdentify1 = New System.Windows.Forms.Button
        Me.btnSet4 = New System.Windows.Forms.Button
        Me.btnSet3 = New System.Windows.Forms.Button
        Me.btnSet2 = New System.Windows.Forms.Button
        Me.btnSet1 = New System.Windows.Forms.Button
        Me.btnGet4 = New System.Windows.Forms.Button
        Me.btnGet3 = New System.Windows.Forms.Button
        Me.btnGet2 = New System.Windows.Forms.Button
        Me.btnGet1 = New System.Windows.Forms.Button
        Me.txtIO4 = New System.Windows.Forms.TextBox
        Me.txtIO3 = New System.Windows.Forms.TextBox
        Me.txtIO2 = New System.Windows.Forms.TextBox
        Me.txtIO1 = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtR2Typ4 = New System.Windows.Forms.TextBox
        Me.txtR2Typ3 = New System.Windows.Forms.TextBox
        Me.txtR2Typ2 = New System.Windows.Forms.TextBox
        Me.txtR2Typ1 = New System.Windows.Forms.TextBox
        Me.txtR1Typ3 = New System.Windows.Forms.TextBox
        Me.txtR1Typ4 = New System.Windows.Forms.TextBox
        Me.txtR1Typ2 = New System.Windows.Forms.TextBox
        Me.txtR1Typ1 = New System.Windows.Forms.TextBox
        Me.txtR2ID4 = New System.Windows.Forms.TextBox
        Me.txtR1ID4 = New System.Windows.Forms.TextBox
        Me.txtR2ID3 = New System.Windows.Forms.TextBox
        Me.txtR1ID3 = New System.Windows.Forms.TextBox
        Me.txtR2ID2 = New System.Windows.Forms.TextBox
        Me.txtR1ID2 = New System.Windows.Forms.TextBox
        Me.txtR2ID1 = New System.Windows.Forms.TextBox
        Me.txtR1ID1 = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.lbID4 = New System.Windows.Forms.Label
        Me.lbID3 = New System.Windows.Forms.Label
        Me.lbID2 = New System.Windows.Forms.Label
        Me.lbID1 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnRQID = New System.Windows.Forms.Button
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.lstIUethDplx = New System.Windows.Forms.ListBox
        Me.lstIUethSpeed = New System.Windows.Forms.ListBox
        Me.btnSendEthernetIU = New System.Windows.Forms.Button
        Me.txtIUethGW = New System.Windows.Forms.TextBox
        Me.txtIUethMask = New System.Windows.Forms.TextBox
        Me.txtIUethPort = New System.Windows.Forms.TextBox
        Me.txtIUethIP = New System.Windows.Forms.TextBox
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnIUSetReader = New System.Windows.Forms.Button
        Me.btnIUIdentify = New System.Windows.Forms.Button
        Me.btnIUSetSlave = New System.Windows.Forms.Button
        Me.txtIUR2Typ4 = New System.Windows.Forms.TextBox
        Me.txtIUR2Typ3 = New System.Windows.Forms.TextBox
        Me.txtIUR2Typ2 = New System.Windows.Forms.TextBox
        Me.txtIUR2Typ1 = New System.Windows.Forms.TextBox
        Me.txtIUR1Typ3 = New System.Windows.Forms.TextBox
        Me.txtIUR1Typ4 = New System.Windows.Forms.TextBox
        Me.txtIUR1Typ2 = New System.Windows.Forms.TextBox
        Me.txtIUR1Typ1 = New System.Windows.Forms.TextBox
        Me.txtIUR1ID4 = New System.Windows.Forms.TextBox
        Me.txtIUR1ID3 = New System.Windows.Forms.TextBox
        Me.txtIUR1ID2 = New System.Windows.Forms.TextBox
        Me.txtIUR1ID1 = New System.Windows.Forms.TextBox
        Me.lbIUID4 = New System.Windows.Forms.Label
        Me.lbIUID3 = New System.Windows.Forms.Label
        Me.lbIUID2 = New System.Windows.Forms.Label
        Me.lbIUID1 = New System.Windows.Forms.Label
        Me.LabelIU1 = New System.Windows.Forms.Label
        Me.btnIURQID = New System.Windows.Forms.Button
        Me.TabPage5 = New System.Windows.Forms.TabPage
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.btnRefresh = New System.Windows.Forms.Button
        Me.lbStatus = New System.Windows.Forms.Label
        Me.lbService = New System.Windows.Forms.ListBox
        Me.btnStop = New System.Windows.Forms.Button
        Me.btnStart = New System.Windows.Forms.Button
        Me.ctrlService = New System.ServiceProcess.ServiceController
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'CtxtMenu
        '
        Me.CtxtMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem2, Me.MenuItem1})
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 0
        Me.MenuItem2.Text = "Effacer"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 1
        Me.MenuItem1.Text = "Enregistrer..."
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.List)
        Me.Panel1.Controls.Add(Me.txtSend)
        Me.Panel1.Controls.Add(Me.btnSend)
        Me.Panel1.Location = New System.Drawing.Point(44, 78)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(629, 312)
        Me.Panel1.TabIndex = 99
        '
        'List
        '
        Me.List.ContextMenu = Me.CtxtMenu
        Me.List.Location = New System.Drawing.Point(83, 13)
        Me.List.Name = "List"
        Me.List.Size = New System.Drawing.Size(464, 251)
        Me.List.TabIndex = 99
        '
        'txtSend
        '
        Me.txtSend.Enabled = False
        Me.txtSend.Location = New System.Drawing.Point(83, 277)
        Me.txtSend.Name = "txtSend"
        Me.txtSend.Size = New System.Drawing.Size(384, 20)
        Me.txtSend.TabIndex = 7
        Me.txtSend.Text = "@v"
        '
        'btnSend
        '
        Me.btnSend.Enabled = False
        Me.btnSend.Location = New System.Drawing.Point(475, 277)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(75, 20)
        Me.btnSend.TabIndex = 8
        Me.btnSend.Text = "Send"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtPort)
        Me.GroupBox1.Controls.Add(Me.txtIP)
        Me.GroupBox1.Controls.Add(Me.btnDisconnect)
        Me.GroupBox1.Controls.Add(Me.btnConnect)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(443, 66)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Connection"
        '
        'txtPort
        '
        Me.txtPort.Location = New System.Drawing.Point(164, 24)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(76, 20)
        Me.txtPort.TabIndex = 1
        Me.txtPort.Text = "20003"
        '
        'txtIP
        '
        Me.txtIP.Location = New System.Drawing.Point(22, 23)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(136, 20)
        Me.txtIP.TabIndex = 0
        Me.txtIP.Text = "169.254.99.201"
        '
        'btnDisconnect
        '
        Me.btnDisconnect.Enabled = False
        Me.btnDisconnect.Location = New System.Drawing.Point(354, 24)
        Me.btnDisconnect.Name = "btnDisconnect"
        Me.btnDisconnect.Size = New System.Drawing.Size(75, 20)
        Me.btnDisconnect.TabIndex = 3
        Me.btnDisconnect.Text = "Disconnect"
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(273, 24)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(75, 20)
        Me.btnConnect.TabIndex = 2
        Me.btnConnect.Text = "Connect"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnVersion)
        Me.GroupBox2.Controls.Add(Me.btnRetroActive)
        Me.GroupBox2.Controls.Add(Me.btnSendFile)
        Me.GroupBox2.Controls.Add(Me.btnClear)
        Me.GroupBox2.Enabled = False
        Me.GroupBox2.Location = New System.Drawing.Point(164, 9)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(392, 66)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Commands"
        '
        'btnVersion
        '
        Me.btnVersion.Enabled = False
        Me.btnVersion.Location = New System.Drawing.Point(9, 19)
        Me.btnVersion.Name = "btnVersion"
        Me.btnVersion.Size = New System.Drawing.Size(99, 39)
        Me.btnVersion.TabIndex = 7
        Me.btnVersion.Text = "Version"
        Me.btnVersion.UseVisualStyleBackColor = True
        '
        'btnRetroActive
        '
        Me.btnRetroActive.Enabled = False
        Me.btnRetroActive.Location = New System.Drawing.Point(283, 19)
        Me.btnRetroActive.Name = "btnRetroActive"
        Me.btnRetroActive.Size = New System.Drawing.Size(90, 39)
        Me.btnRetroActive.TabIndex = 6
        Me.btnRetroActive.Text = "Retro-active pooling"
        Me.btnRetroActive.UseVisualStyleBackColor = True
        '
        'btnSendFile
        '
        Me.btnSendFile.Enabled = False
        Me.btnSendFile.Location = New System.Drawing.Point(219, 19)
        Me.btnSendFile.Name = "btnSendFile"
        Me.btnSendFile.Size = New System.Drawing.Size(58, 39)
        Me.btnSendFile.TabIndex = 5
        Me.btnSendFile.Text = "Send file"
        Me.btnSendFile.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Enabled = False
        Me.btnClear.Location = New System.Drawing.Point(114, 19)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(99, 39)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear terminal"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'TextBox4
        '
        Me.TextBox4.Enabled = False
        Me.TextBox4.Location = New System.Drawing.Point(11, 31)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(136, 20)
        Me.TextBox4.TabIndex = 9
        Me.TextBox4.Text = "169.254.99.201"
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(442, 32)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(76, 20)
        Me.TextBox2.TabIndex = 12
        Me.TextBox2.Text = "20003"
        '
        'TextBox5
        '
        Me.TextBox5.Enabled = False
        Me.TextBox5.Location = New System.Drawing.Point(155, 32)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(136, 20)
        Me.TextBox5.TabIndex = 10
        Me.TextBox5.Text = "255.255.0.0"
        '
        'TextBox6
        '
        Me.TextBox6.Enabled = False
        Me.TextBox6.Location = New System.Drawing.Point(297, 32)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(136, 20)
        Me.TextBox6.TabIndex = 11
        Me.TextBox6.Text = "0.0.0.0"
        '
        'btnSendEthernetAT
        '
        Me.btnSendEthernetAT.Enabled = False
        Me.btnSendEthernetAT.Location = New System.Drawing.Point(179, 68)
        Me.btnSendEthernetAT.Name = "btnSendEthernetAT"
        Me.btnSendEthernetAT.Size = New System.Drawing.Size(155, 19)
        Me.btnSendEthernetAT.TabIndex = 15
        Me.btnSendEthernetAT.Text = "Send Ethernet Parameters"
        Me.btnSendEthernetAT.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Enabled = False
        Me.btnReset.Location = New System.Drawing.Point(361, 68)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(108, 19)
        Me.btnReset.TabIndex = 16
        Me.btnReset.Text = "Reset to defaults"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.Enabled = False
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"10 Mb", "100 Mb", "Auto"})
        Me.ListBox1.Location = New System.Drawing.Point(529, 32)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(77, 43)
        Me.ListBox1.TabIndex = 13
        '
        'ListBox2
        '
        Me.ListBox2.Enabled = False
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Items.AddRange(New Object() {"Full Duplex", "Half Duplex"})
        Me.ListBox2.Location = New System.Drawing.Point(615, 32)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(80, 43)
        Me.ListBox2.TabIndex = 14
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ListBox2)
        Me.GroupBox3.Controls.Add(Me.ListBox1)
        Me.GroupBox3.Controls.Add(Me.btnReset)
        Me.GroupBox3.Controls.Add(Me.btnSendEthernetAT)
        Me.GroupBox3.Controls.Add(Me.TextBox6)
        Me.GroupBox3.Controls.Add(Me.TextBox5)
        Me.GroupBox3.Controls.Add(Me.TextBox2)
        Me.GroupBox3.Controls.Add(Me.TextBox4)
        Me.GroupBox3.Enabled = False
        Me.GroupBox3.Location = New System.Drawing.Point(9, 29)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(712, 102)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Set Ethernet Parameters (CMAS only)"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(12, 84)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(735, 449)
        Me.TabControl1.TabIndex = 99
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(727, 423)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "UDP Menu"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox5)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(727, 423)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "CMAS AT Init"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btnIdentify4)
        Me.GroupBox5.Controls.Add(Me.btnIdentify3)
        Me.GroupBox5.Controls.Add(Me.btnIdentify2)
        Me.GroupBox5.Controls.Add(Me.btnIdentify1)
        Me.GroupBox5.Controls.Add(Me.btnSet4)
        Me.GroupBox5.Controls.Add(Me.btnSet3)
        Me.GroupBox5.Controls.Add(Me.btnSet2)
        Me.GroupBox5.Controls.Add(Me.btnSet1)
        Me.GroupBox5.Controls.Add(Me.btnGet4)
        Me.GroupBox5.Controls.Add(Me.btnGet3)
        Me.GroupBox5.Controls.Add(Me.btnGet2)
        Me.GroupBox5.Controls.Add(Me.btnGet1)
        Me.GroupBox5.Controls.Add(Me.txtIO4)
        Me.GroupBox5.Controls.Add(Me.txtIO3)
        Me.GroupBox5.Controls.Add(Me.txtIO2)
        Me.GroupBox5.Controls.Add(Me.txtIO1)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.txtR2Typ4)
        Me.GroupBox5.Controls.Add(Me.txtR2Typ3)
        Me.GroupBox5.Controls.Add(Me.txtR2Typ2)
        Me.GroupBox5.Controls.Add(Me.txtR2Typ1)
        Me.GroupBox5.Controls.Add(Me.txtR1Typ3)
        Me.GroupBox5.Controls.Add(Me.txtR1Typ4)
        Me.GroupBox5.Controls.Add(Me.txtR1Typ2)
        Me.GroupBox5.Controls.Add(Me.txtR1Typ1)
        Me.GroupBox5.Controls.Add(Me.txtR2ID4)
        Me.GroupBox5.Controls.Add(Me.txtR1ID4)
        Me.GroupBox5.Controls.Add(Me.txtR2ID3)
        Me.GroupBox5.Controls.Add(Me.txtR1ID3)
        Me.GroupBox5.Controls.Add(Me.txtR2ID2)
        Me.GroupBox5.Controls.Add(Me.txtR1ID2)
        Me.GroupBox5.Controls.Add(Me.txtR2ID1)
        Me.GroupBox5.Controls.Add(Me.txtR1ID1)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.lbID4)
        Me.GroupBox5.Controls.Add(Me.lbID3)
        Me.GroupBox5.Controls.Add(Me.lbID2)
        Me.GroupBox5.Controls.Add(Me.lbID1)
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Controls.Add(Me.btnRQID)
        Me.GroupBox5.Enabled = False
        Me.GroupBox5.Location = New System.Drawing.Point(9, 170)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(712, 166)
        Me.GroupBox5.TabIndex = 13
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "String Management"
        '
        'btnIdentify4
        '
        Me.btnIdentify4.Enabled = False
        Me.btnIdentify4.Location = New System.Drawing.Point(645, 131)
        Me.btnIdentify4.Name = "btnIdentify4"
        Me.btnIdentify4.Size = New System.Drawing.Size(60, 20)
        Me.btnIdentify4.TabIndex = 39
        Me.btnIdentify4.Text = "Identify"
        Me.btnIdentify4.UseVisualStyleBackColor = True
        '
        'btnIdentify3
        '
        Me.btnIdentify3.Enabled = False
        Me.btnIdentify3.Location = New System.Drawing.Point(645, 105)
        Me.btnIdentify3.Name = "btnIdentify3"
        Me.btnIdentify3.Size = New System.Drawing.Size(60, 20)
        Me.btnIdentify3.TabIndex = 31
        Me.btnIdentify3.Text = "Identify"
        Me.btnIdentify3.UseVisualStyleBackColor = True
        '
        'btnIdentify2
        '
        Me.btnIdentify2.Enabled = False
        Me.btnIdentify2.Location = New System.Drawing.Point(645, 75)
        Me.btnIdentify2.Name = "btnIdentify2"
        Me.btnIdentify2.Size = New System.Drawing.Size(60, 20)
        Me.btnIdentify2.TabIndex = 23
        Me.btnIdentify2.Text = "Identify"
        Me.btnIdentify2.UseVisualStyleBackColor = True
        '
        'btnIdentify1
        '
        Me.btnIdentify1.Enabled = False
        Me.btnIdentify1.Location = New System.Drawing.Point(645, 47)
        Me.btnIdentify1.Name = "btnIdentify1"
        Me.btnIdentify1.Size = New System.Drawing.Size(60, 20)
        Me.btnIdentify1.TabIndex = 15
        Me.btnIdentify1.Text = "Identify"
        Me.btnIdentify1.UseVisualStyleBackColor = True
        '
        'btnSet4
        '
        Me.btnSet4.Enabled = False
        Me.btnSet4.Location = New System.Drawing.Point(585, 131)
        Me.btnSet4.Name = "btnSet4"
        Me.btnSet4.Size = New System.Drawing.Size(50, 20)
        Me.btnSet4.TabIndex = 38
        Me.btnSet4.Text = "Set"
        Me.btnSet4.UseVisualStyleBackColor = True
        '
        'btnSet3
        '
        Me.btnSet3.Enabled = False
        Me.btnSet3.Location = New System.Drawing.Point(585, 105)
        Me.btnSet3.Name = "btnSet3"
        Me.btnSet3.Size = New System.Drawing.Size(50, 20)
        Me.btnSet3.TabIndex = 30
        Me.btnSet3.Text = "Set"
        Me.btnSet3.UseVisualStyleBackColor = True
        '
        'btnSet2
        '
        Me.btnSet2.Enabled = False
        Me.btnSet2.Location = New System.Drawing.Point(585, 75)
        Me.btnSet2.Name = "btnSet2"
        Me.btnSet2.Size = New System.Drawing.Size(50, 20)
        Me.btnSet2.TabIndex = 22
        Me.btnSet2.Text = "Set"
        Me.btnSet2.UseVisualStyleBackColor = True
        '
        'btnSet1
        '
        Me.btnSet1.Enabled = False
        Me.btnSet1.Location = New System.Drawing.Point(585, 47)
        Me.btnSet1.Name = "btnSet1"
        Me.btnSet1.Size = New System.Drawing.Size(50, 20)
        Me.btnSet1.TabIndex = 14
        Me.btnSet1.Text = "Set"
        Me.btnSet1.UseVisualStyleBackColor = True
        '
        'btnGet4
        '
        Me.btnGet4.Enabled = False
        Me.btnGet4.Location = New System.Drawing.Point(522, 131)
        Me.btnGet4.Name = "btnGet4"
        Me.btnGet4.Size = New System.Drawing.Size(50, 20)
        Me.btnGet4.TabIndex = 37
        Me.btnGet4.Text = "Get"
        Me.btnGet4.UseVisualStyleBackColor = True
        '
        'btnGet3
        '
        Me.btnGet3.Enabled = False
        Me.btnGet3.Location = New System.Drawing.Point(522, 105)
        Me.btnGet3.Name = "btnGet3"
        Me.btnGet3.Size = New System.Drawing.Size(50, 20)
        Me.btnGet3.TabIndex = 29
        Me.btnGet3.Text = "Get"
        Me.btnGet3.UseVisualStyleBackColor = True
        '
        'btnGet2
        '
        Me.btnGet2.Enabled = False
        Me.btnGet2.Location = New System.Drawing.Point(522, 75)
        Me.btnGet2.Name = "btnGet2"
        Me.btnGet2.Size = New System.Drawing.Size(50, 20)
        Me.btnGet2.TabIndex = 21
        Me.btnGet2.Text = "Get"
        Me.btnGet2.UseVisualStyleBackColor = True
        '
        'btnGet1
        '
        Me.btnGet1.Enabled = False
        Me.btnGet1.Location = New System.Drawing.Point(522, 47)
        Me.btnGet1.Name = "btnGet1"
        Me.btnGet1.Size = New System.Drawing.Size(50, 20)
        Me.btnGet1.TabIndex = 13
        Me.btnGet1.Text = "Get"
        Me.btnGet1.UseVisualStyleBackColor = True
        '
        'txtIO4
        '
        Me.txtIO4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIO4.Location = New System.Drawing.Point(445, 131)
        Me.txtIO4.Name = "txtIO4"
        Me.txtIO4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtIO4.Size = New System.Drawing.Size(58, 20)
        Me.txtIO4.TabIndex = 36
        Me.txtIO4.Text = "00"
        Me.txtIO4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtIO3
        '
        Me.txtIO3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIO3.Location = New System.Drawing.Point(445, 105)
        Me.txtIO3.Name = "txtIO3"
        Me.txtIO3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtIO3.Size = New System.Drawing.Size(58, 20)
        Me.txtIO3.TabIndex = 28
        Me.txtIO3.Text = "00"
        Me.txtIO3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtIO2
        '
        Me.txtIO2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIO2.Location = New System.Drawing.Point(445, 75)
        Me.txtIO2.Name = "txtIO2"
        Me.txtIO2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtIO2.Size = New System.Drawing.Size(58, 20)
        Me.txtIO2.TabIndex = 20
        Me.txtIO2.Text = "00"
        Me.txtIO2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtIO1
        '
        Me.txtIO1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIO1.Location = New System.Drawing.Point(445, 47)
        Me.txtIO1.Name = "txtIO1"
        Me.txtIO1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtIO1.Size = New System.Drawing.Size(58, 20)
        Me.txtIO1.TabIndex = 12
        Me.txtIO1.Text = "00"
        Me.txtIO1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(445, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "ID I/O Box"
        '
        'txtR2Typ4
        '
        Me.txtR2Typ4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtR2Typ4.Location = New System.Drawing.Point(411, 131)
        Me.txtR2Typ4.Name = "txtR2Typ4"
        Me.txtR2Typ4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtR2Typ4.Size = New System.Drawing.Size(20, 20)
        Me.txtR2Typ4.TabIndex = 35
        Me.txtR2Typ4.Text = "0"
        Me.txtR2Typ4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtR2Typ3
        '
        Me.txtR2Typ3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtR2Typ3.Location = New System.Drawing.Point(411, 105)
        Me.txtR2Typ3.Name = "txtR2Typ3"
        Me.txtR2Typ3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtR2Typ3.Size = New System.Drawing.Size(20, 20)
        Me.txtR2Typ3.TabIndex = 27
        Me.txtR2Typ3.Text = "0"
        Me.txtR2Typ3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtR2Typ2
        '
        Me.txtR2Typ2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtR2Typ2.Location = New System.Drawing.Point(411, 75)
        Me.txtR2Typ2.Name = "txtR2Typ2"
        Me.txtR2Typ2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtR2Typ2.Size = New System.Drawing.Size(20, 20)
        Me.txtR2Typ2.TabIndex = 19
        Me.txtR2Typ2.Text = "0"
        Me.txtR2Typ2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtR2Typ1
        '
        Me.txtR2Typ1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtR2Typ1.Location = New System.Drawing.Point(411, 47)
        Me.txtR2Typ1.Name = "txtR2Typ1"
        Me.txtR2Typ1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtR2Typ1.Size = New System.Drawing.Size(20, 20)
        Me.txtR2Typ1.TabIndex = 11
        Me.txtR2Typ1.Text = "0"
        Me.txtR2Typ1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtR1Typ3
        '
        Me.txtR1Typ3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtR1Typ3.Location = New System.Drawing.Point(304, 105)
        Me.txtR1Typ3.Name = "txtR1Typ3"
        Me.txtR1Typ3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtR1Typ3.Size = New System.Drawing.Size(20, 20)
        Me.txtR1Typ3.TabIndex = 25
        Me.txtR1Typ3.Text = "0"
        Me.txtR1Typ3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtR1Typ4
        '
        Me.txtR1Typ4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtR1Typ4.Location = New System.Drawing.Point(304, 131)
        Me.txtR1Typ4.Name = "txtR1Typ4"
        Me.txtR1Typ4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtR1Typ4.Size = New System.Drawing.Size(20, 20)
        Me.txtR1Typ4.TabIndex = 33
        Me.txtR1Typ4.Text = "0"
        Me.txtR1Typ4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtR1Typ2
        '
        Me.txtR1Typ2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtR1Typ2.Location = New System.Drawing.Point(304, 75)
        Me.txtR1Typ2.Name = "txtR1Typ2"
        Me.txtR1Typ2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtR1Typ2.Size = New System.Drawing.Size(20, 20)
        Me.txtR1Typ2.TabIndex = 17
        Me.txtR1Typ2.Text = "0"
        Me.txtR1Typ2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtR1Typ1
        '
        Me.txtR1Typ1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtR1Typ1.Location = New System.Drawing.Point(304, 47)
        Me.txtR1Typ1.Name = "txtR1Typ1"
        Me.txtR1Typ1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtR1Typ1.Size = New System.Drawing.Size(20, 20)
        Me.txtR1Typ1.TabIndex = 9
        Me.txtR1Typ1.Text = "0"
        Me.txtR1Typ1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtR2ID4
        '
        Me.txtR2ID4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtR2ID4.Location = New System.Drawing.Point(339, 131)
        Me.txtR2ID4.Name = "txtR2ID4"
        Me.txtR2ID4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtR2ID4.Size = New System.Drawing.Size(64, 20)
        Me.txtR2ID4.TabIndex = 34
        Me.txtR2ID4.Text = "00"
        Me.txtR2ID4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtR1ID4
        '
        Me.txtR1ID4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtR1ID4.Location = New System.Drawing.Point(229, 131)
        Me.txtR1ID4.Name = "txtR1ID4"
        Me.txtR1ID4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtR1ID4.Size = New System.Drawing.Size(64, 20)
        Me.txtR1ID4.TabIndex = 32
        Me.txtR1ID4.Text = "00"
        Me.txtR1ID4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtR2ID3
        '
        Me.txtR2ID3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtR2ID3.Location = New System.Drawing.Point(339, 105)
        Me.txtR2ID3.Name = "txtR2ID3"
        Me.txtR2ID3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtR2ID3.Size = New System.Drawing.Size(64, 20)
        Me.txtR2ID3.TabIndex = 26
        Me.txtR2ID3.Text = "00"
        Me.txtR2ID3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtR1ID3
        '
        Me.txtR1ID3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtR1ID3.Location = New System.Drawing.Point(229, 105)
        Me.txtR1ID3.Name = "txtR1ID3"
        Me.txtR1ID3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtR1ID3.Size = New System.Drawing.Size(64, 20)
        Me.txtR1ID3.TabIndex = 24
        Me.txtR1ID3.Text = "00"
        Me.txtR1ID3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtR2ID2
        '
        Me.txtR2ID2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtR2ID2.Location = New System.Drawing.Point(339, 75)
        Me.txtR2ID2.Name = "txtR2ID2"
        Me.txtR2ID2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtR2ID2.Size = New System.Drawing.Size(64, 20)
        Me.txtR2ID2.TabIndex = 18
        Me.txtR2ID2.Text = "00"
        Me.txtR2ID2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtR1ID2
        '
        Me.txtR1ID2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtR1ID2.Location = New System.Drawing.Point(229, 75)
        Me.txtR1ID2.Name = "txtR1ID2"
        Me.txtR1ID2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtR1ID2.Size = New System.Drawing.Size(64, 20)
        Me.txtR1ID2.TabIndex = 16
        Me.txtR1ID2.Text = "00"
        Me.txtR1ID2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtR2ID1
        '
        Me.txtR2ID1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtR2ID1.Location = New System.Drawing.Point(339, 47)
        Me.txtR2ID1.Name = "txtR2ID1"
        Me.txtR2ID1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtR2ID1.Size = New System.Drawing.Size(64, 20)
        Me.txtR2ID1.TabIndex = 10
        Me.txtR2ID1.Text = "00"
        Me.txtR2ID1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtR1ID1
        '
        Me.txtR1ID1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtR1ID1.Location = New System.Drawing.Point(229, 47)
        Me.txtR1ID1.MaxLength = 99
        Me.txtR1ID1.Name = "txtR1ID1"
        Me.txtR1ID1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtR1ID1.Size = New System.Drawing.Size(64, 20)
        Me.txtR1ID1.TabIndex = 8
        Me.txtR1ID1.Text = "00"
        Me.txtR1ID1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(339, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "ID Reader 2         "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(226, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "ID Reader 1            "
        '
        'lbID4
        '
        Me.lbID4.AutoSize = True
        Me.lbID4.Location = New System.Drawing.Point(113, 138)
        Me.lbID4.Name = "lbID4"
        Me.lbID4.Size = New System.Drawing.Size(103, 13)
        Me.lbID4.TabIndex = 5
        Me.lbID4.Text = "0000000000000000"
        '
        'lbID3
        '
        Me.lbID3.AutoSize = True
        Me.lbID3.Location = New System.Drawing.Point(113, 109)
        Me.lbID3.Name = "lbID3"
        Me.lbID3.Size = New System.Drawing.Size(103, 13)
        Me.lbID3.TabIndex = 4
        Me.lbID3.Text = "0000000000000000"
        '
        'lbID2
        '
        Me.lbID2.AutoSize = True
        Me.lbID2.Location = New System.Drawing.Point(113, 82)
        Me.lbID2.Name = "lbID2"
        Me.lbID2.Size = New System.Drawing.Size(103, 13)
        Me.lbID2.TabIndex = 3
        Me.lbID2.Text = "0000000000000000"
        '
        'lbID1
        '
        Me.lbID1.AutoSize = True
        Me.lbID1.Location = New System.Drawing.Point(113, 54)
        Me.lbID1.Name = "lbID1"
        Me.lbID1.Size = New System.Drawing.Size(103, 13)
        Me.lbID1.TabIndex = 2
        Me.lbID1.Text = "0000000000000000"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(113, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Unique ID                "
        '
        'btnRQID
        '
        Me.btnRQID.Location = New System.Drawing.Point(11, 26)
        Me.btnRQID.Name = "btnRQID"
        Me.btnRQID.Size = New System.Drawing.Size(95, 125)
        Me.btnRQID.TabIndex = 0
        Me.btnRQID.Text = "Identify Slaves"
        Me.btnRQID.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox4)
        Me.TabPage3.Controls.Add(Me.GroupBox6)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(727, 423)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "CMAS IU Init"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lstIUethDplx)
        Me.GroupBox4.Controls.Add(Me.lstIUethSpeed)
        Me.GroupBox4.Controls.Add(Me.btnSendEthernetIU)
        Me.GroupBox4.Controls.Add(Me.txtIUethGW)
        Me.GroupBox4.Controls.Add(Me.txtIUethMask)
        Me.GroupBox4.Controls.Add(Me.txtIUethPort)
        Me.GroupBox4.Controls.Add(Me.txtIUethIP)
        Me.GroupBox4.Enabled = False
        Me.GroupBox4.Location = New System.Drawing.Point(9, 18)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(712, 102)
        Me.GroupBox4.TabIndex = 13
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Set Ethernet Parameters (CMAS only)"
        '
        'lstIUethDplx
        '
        Me.lstIUethDplx.Enabled = False
        Me.lstIUethDplx.FormattingEnabled = True
        Me.lstIUethDplx.Items.AddRange(New Object() {"Full Duplex", "Half Duplex"})
        Me.lstIUethDplx.Location = New System.Drawing.Point(615, 32)
        Me.lstIUethDplx.Name = "lstIUethDplx"
        Me.lstIUethDplx.Size = New System.Drawing.Size(80, 43)
        Me.lstIUethDplx.TabIndex = 22
        '
        'lstIUethSpeed
        '
        Me.lstIUethSpeed.Enabled = False
        Me.lstIUethSpeed.FormattingEnabled = True
        Me.lstIUethSpeed.Items.AddRange(New Object() {"10 Mb", "100 Mb", "Auto"})
        Me.lstIUethSpeed.Location = New System.Drawing.Point(529, 32)
        Me.lstIUethSpeed.Name = "lstIUethSpeed"
        Me.lstIUethSpeed.Size = New System.Drawing.Size(77, 43)
        Me.lstIUethSpeed.TabIndex = 21
        '
        'btnSendEthernetIU
        '
        Me.btnSendEthernetIU.Enabled = False
        Me.btnSendEthernetIU.Location = New System.Drawing.Point(275, 68)
        Me.btnSendEthernetIU.Name = "btnSendEthernetIU"
        Me.btnSendEthernetIU.Size = New System.Drawing.Size(155, 19)
        Me.btnSendEthernetIU.TabIndex = 23
        Me.btnSendEthernetIU.Text = "Send Ethernet Parameters"
        Me.btnSendEthernetIU.UseVisualStyleBackColor = True
        '
        'txtIUethGW
        '
        Me.txtIUethGW.Enabled = False
        Me.txtIUethGW.Location = New System.Drawing.Point(297, 32)
        Me.txtIUethGW.Name = "txtIUethGW"
        Me.txtIUethGW.Size = New System.Drawing.Size(136, 20)
        Me.txtIUethGW.TabIndex = 19
        Me.txtIUethGW.Text = "0.0.0.0"
        '
        'txtIUethMask
        '
        Me.txtIUethMask.Enabled = False
        Me.txtIUethMask.Location = New System.Drawing.Point(155, 32)
        Me.txtIUethMask.Name = "txtIUethMask"
        Me.txtIUethMask.Size = New System.Drawing.Size(136, 20)
        Me.txtIUethMask.TabIndex = 18
        Me.txtIUethMask.Text = "255.255.0.0"
        '
        'txtIUethPort
        '
        Me.txtIUethPort.Enabled = False
        Me.txtIUethPort.Location = New System.Drawing.Point(442, 32)
        Me.txtIUethPort.Name = "txtIUethPort"
        Me.txtIUethPort.Size = New System.Drawing.Size(76, 20)
        Me.txtIUethPort.TabIndex = 20
        Me.txtIUethPort.Text = "20003"
        '
        'txtIUethIP
        '
        Me.txtIUethIP.Enabled = False
        Me.txtIUethIP.Location = New System.Drawing.Point(11, 31)
        Me.txtIUethIP.Name = "txtIUethIP"
        Me.txtIUethIP.Size = New System.Drawing.Size(136, 20)
        Me.txtIUethIP.TabIndex = 17
        Me.txtIUethIP.Text = "169.254.99.201"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label5)
        Me.GroupBox6.Controls.Add(Me.Label4)
        Me.GroupBox6.Controls.Add(Me.btnIUSetReader)
        Me.GroupBox6.Controls.Add(Me.btnIUIdentify)
        Me.GroupBox6.Controls.Add(Me.btnIUSetSlave)
        Me.GroupBox6.Controls.Add(Me.txtIUR2Typ4)
        Me.GroupBox6.Controls.Add(Me.txtIUR2Typ3)
        Me.GroupBox6.Controls.Add(Me.txtIUR2Typ2)
        Me.GroupBox6.Controls.Add(Me.txtIUR2Typ1)
        Me.GroupBox6.Controls.Add(Me.txtIUR1Typ3)
        Me.GroupBox6.Controls.Add(Me.txtIUR1Typ4)
        Me.GroupBox6.Controls.Add(Me.txtIUR1Typ2)
        Me.GroupBox6.Controls.Add(Me.txtIUR1Typ1)
        Me.GroupBox6.Controls.Add(Me.txtIUR1ID4)
        Me.GroupBox6.Controls.Add(Me.txtIUR1ID3)
        Me.GroupBox6.Controls.Add(Me.txtIUR1ID2)
        Me.GroupBox6.Controls.Add(Me.txtIUR1ID1)
        Me.GroupBox6.Controls.Add(Me.lbIUID4)
        Me.GroupBox6.Controls.Add(Me.lbIUID3)
        Me.GroupBox6.Controls.Add(Me.lbIUID2)
        Me.GroupBox6.Controls.Add(Me.lbIUID1)
        Me.GroupBox6.Controls.Add(Me.LabelIU1)
        Me.GroupBox6.Controls.Add(Me.btnIURQID)
        Me.GroupBox6.Enabled = False
        Me.GroupBox6.Location = New System.Drawing.Point(9, 170)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(712, 166)
        Me.GroupBox6.TabIndex = 13
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "String Management"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(348, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Reader Type"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(265, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "ID reader 1  "
        '
        'btnIUSetReader
        '
        Me.btnIUSetReader.Enabled = False
        Me.btnIUSetReader.Location = New System.Drawing.Point(537, 48)
        Me.btnIUSetReader.Name = "btnIUSetReader"
        Me.btnIUSetReader.Size = New System.Drawing.Size(60, 104)
        Me.btnIUSetReader.TabIndex = 21
        Me.btnIUSetReader.Text = "Set Readers"
        Me.btnIUSetReader.UseVisualStyleBackColor = True
        '
        'btnIUIdentify
        '
        Me.btnIUIdentify.Enabled = False
        Me.btnIUIdentify.Location = New System.Drawing.Point(635, 47)
        Me.btnIUIdentify.Name = "btnIUIdentify"
        Me.btnIUIdentify.Size = New System.Drawing.Size(60, 104)
        Me.btnIUIdentify.TabIndex = 22
        Me.btnIUIdentify.Text = "Start Identify"
        Me.btnIUIdentify.UseVisualStyleBackColor = True
        '
        'btnIUSetSlave
        '
        Me.btnIUSetSlave.Enabled = False
        Me.btnIUSetSlave.Location = New System.Drawing.Point(440, 47)
        Me.btnIUSetSlave.Name = "btnIUSetSlave"
        Me.btnIUSetSlave.Size = New System.Drawing.Size(60, 104)
        Me.btnIUSetSlave.TabIndex = 20
        Me.btnIUSetSlave.Text = "Set I²C Slave ID's"
        Me.btnIUSetSlave.UseVisualStyleBackColor = True
        '
        'txtIUR2Typ4
        '
        Me.txtIUR2Typ4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIUR2Typ4.Location = New System.Drawing.Point(395, 131)
        Me.txtIUR2Typ4.Name = "txtIUR2Typ4"
        Me.txtIUR2Typ4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtIUR2Typ4.Size = New System.Drawing.Size(20, 20)
        Me.txtIUR2Typ4.TabIndex = 19
        Me.txtIUR2Typ4.Text = "0"
        Me.txtIUR2Typ4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtIUR2Typ3
        '
        Me.txtIUR2Typ3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIUR2Typ3.Location = New System.Drawing.Point(395, 105)
        Me.txtIUR2Typ3.Name = "txtIUR2Typ3"
        Me.txtIUR2Typ3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtIUR2Typ3.Size = New System.Drawing.Size(20, 20)
        Me.txtIUR2Typ3.TabIndex = 16
        Me.txtIUR2Typ3.Text = "0"
        Me.txtIUR2Typ3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtIUR2Typ2
        '
        Me.txtIUR2Typ2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIUR2Typ2.Location = New System.Drawing.Point(395, 75)
        Me.txtIUR2Typ2.Name = "txtIUR2Typ2"
        Me.txtIUR2Typ2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtIUR2Typ2.Size = New System.Drawing.Size(20, 20)
        Me.txtIUR2Typ2.TabIndex = 13
        Me.txtIUR2Typ2.Text = "0"
        Me.txtIUR2Typ2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtIUR2Typ1
        '
        Me.txtIUR2Typ1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIUR2Typ1.Location = New System.Drawing.Point(395, 47)
        Me.txtIUR2Typ1.Name = "txtIUR2Typ1"
        Me.txtIUR2Typ1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtIUR2Typ1.Size = New System.Drawing.Size(20, 20)
        Me.txtIUR2Typ1.TabIndex = 10
        Me.txtIUR2Typ1.Text = "0"
        Me.txtIUR2Typ1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtIUR1Typ3
        '
        Me.txtIUR1Typ3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIUR1Typ3.Location = New System.Drawing.Point(351, 105)
        Me.txtIUR1Typ3.Name = "txtIUR1Typ3"
        Me.txtIUR1Typ3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtIUR1Typ3.Size = New System.Drawing.Size(20, 20)
        Me.txtIUR1Typ3.TabIndex = 15
        Me.txtIUR1Typ3.Text = "0"
        Me.txtIUR1Typ3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtIUR1Typ4
        '
        Me.txtIUR1Typ4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIUR1Typ4.Location = New System.Drawing.Point(351, 131)
        Me.txtIUR1Typ4.Name = "txtIUR1Typ4"
        Me.txtIUR1Typ4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtIUR1Typ4.Size = New System.Drawing.Size(20, 20)
        Me.txtIUR1Typ4.TabIndex = 18
        Me.txtIUR1Typ4.Text = "0"
        Me.txtIUR1Typ4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtIUR1Typ2
        '
        Me.txtIUR1Typ2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIUR1Typ2.Location = New System.Drawing.Point(351, 75)
        Me.txtIUR1Typ2.Name = "txtIUR1Typ2"
        Me.txtIUR1Typ2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtIUR1Typ2.Size = New System.Drawing.Size(20, 20)
        Me.txtIUR1Typ2.TabIndex = 12
        Me.txtIUR1Typ2.Text = "0"
        Me.txtIUR1Typ2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtIUR1Typ1
        '
        Me.txtIUR1Typ1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIUR1Typ1.Location = New System.Drawing.Point(351, 47)
        Me.txtIUR1Typ1.Name = "txtIUR1Typ1"
        Me.txtIUR1Typ1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtIUR1Typ1.Size = New System.Drawing.Size(20, 20)
        Me.txtIUR1Typ1.TabIndex = 9
        Me.txtIUR1Typ1.Text = "0"
        Me.txtIUR1Typ1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtIUR1ID4
        '
        Me.txtIUR1ID4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIUR1ID4.Location = New System.Drawing.Point(265, 131)
        Me.txtIUR1ID4.Name = "txtIUR1ID4"
        Me.txtIUR1ID4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtIUR1ID4.Size = New System.Drawing.Size(64, 20)
        Me.txtIUR1ID4.TabIndex = 17
        Me.txtIUR1ID4.Text = "5"
        Me.txtIUR1ID4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtIUR1ID3
        '
        Me.txtIUR1ID3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIUR1ID3.Location = New System.Drawing.Point(265, 105)
        Me.txtIUR1ID3.Name = "txtIUR1ID3"
        Me.txtIUR1ID3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtIUR1ID3.Size = New System.Drawing.Size(64, 20)
        Me.txtIUR1ID3.TabIndex = 14
        Me.txtIUR1ID3.Text = "4"
        Me.txtIUR1ID3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtIUR1ID2
        '
        Me.txtIUR1ID2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIUR1ID2.Location = New System.Drawing.Point(265, 75)
        Me.txtIUR1ID2.Name = "txtIUR1ID2"
        Me.txtIUR1ID2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtIUR1ID2.Size = New System.Drawing.Size(64, 20)
        Me.txtIUR1ID2.TabIndex = 11
        Me.txtIUR1ID2.Text = "3"
        Me.txtIUR1ID2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtIUR1ID1
        '
        Me.txtIUR1ID1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIUR1ID1.Location = New System.Drawing.Point(265, 47)
        Me.txtIUR1ID1.MaxLength = 99
        Me.txtIUR1ID1.Name = "txtIUR1ID1"
        Me.txtIUR1ID1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtIUR1ID1.Size = New System.Drawing.Size(64, 20)
        Me.txtIUR1ID1.TabIndex = 8
        Me.txtIUR1ID1.Text = "2"
        Me.txtIUR1ID1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbIUID4
        '
        Me.lbIUID4.AutoSize = True
        Me.lbIUID4.Location = New System.Drawing.Point(144, 138)
        Me.lbIUID4.Name = "lbIUID4"
        Me.lbIUID4.Size = New System.Drawing.Size(103, 13)
        Me.lbIUID4.TabIndex = 5
        Me.lbIUID4.Text = "0000000000000000"
        '
        'lbIUID3
        '
        Me.lbIUID3.AutoSize = True
        Me.lbIUID3.Location = New System.Drawing.Point(144, 109)
        Me.lbIUID3.Name = "lbIUID3"
        Me.lbIUID3.Size = New System.Drawing.Size(103, 13)
        Me.lbIUID3.TabIndex = 4
        Me.lbIUID3.Text = "0000000000000000"
        '
        'lbIUID2
        '
        Me.lbIUID2.AutoSize = True
        Me.lbIUID2.Location = New System.Drawing.Point(144, 82)
        Me.lbIUID2.Name = "lbIUID2"
        Me.lbIUID2.Size = New System.Drawing.Size(103, 13)
        Me.lbIUID2.TabIndex = 3
        Me.lbIUID2.Text = "0000000000000000"
        '
        'lbIUID1
        '
        Me.lbIUID1.AutoSize = True
        Me.lbIUID1.Location = New System.Drawing.Point(144, 54)
        Me.lbIUID1.Name = "lbIUID1"
        Me.lbIUID1.Size = New System.Drawing.Size(103, 13)
        Me.lbIUID1.TabIndex = 2
        Me.lbIUID1.Text = "0000000000000000"
        '
        'LabelIU1
        '
        Me.LabelIU1.AutoSize = True
        Me.LabelIU1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LabelIU1.Location = New System.Drawing.Point(144, 26)
        Me.LabelIU1.Name = "LabelIU1"
        Me.LabelIU1.Size = New System.Drawing.Size(103, 13)
        Me.LabelIU1.TabIndex = 1
        Me.LabelIU1.Text = "Unique ID                "
        '
        'btnIURQID
        '
        Me.btnIURQID.Location = New System.Drawing.Point(11, 26)
        Me.btnIURQID.Name = "btnIURQID"
        Me.btnIURQID.Size = New System.Drawing.Size(95, 125)
        Me.btnIURQID.TabIndex = 0
        Me.btnIURQID.Text = "Identify Slaves"
        Me.btnIURQID.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.PictureBox1)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(727, 423)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Different readers"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CMASToolbox.My.Resources.Resources.Different_reader
        Me.PictureBox1.Location = New System.Drawing.Point(32, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(603, 356)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.PictureBox2)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(727, 423)
        Me.TabPage4.TabIndex = 5
        Me.TabPage4.Text = "Stringnet commands"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.CMASToolbox.My.Resources.Resources.StringnetCommands
        Me.PictureBox2.Location = New System.Drawing.Point(-1, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(728, 421)
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.btnRefresh)
        Me.GroupBox7.Controls.Add(Me.lbStatus)
        Me.GroupBox7.Controls.Add(Me.lbService)
        Me.GroupBox7.Controls.Add(Me.btnStop)
        Me.GroupBox7.Controls.Add(Me.btnStart)
        Me.GroupBox7.Location = New System.Drawing.Point(456, 12)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(291, 80)
        Me.GroupBox7.TabIndex = 0
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Services Management"
        '
        'btnRefresh
        '
        Me.btnRefresh.Enabled = False
        Me.btnRefresh.Location = New System.Drawing.Point(210, 54)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 7
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'lbStatus
        '
        Me.lbStatus.AutoSize = True
        Me.lbStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbStatus.Location = New System.Drawing.Point(132, 16)
        Me.lbStatus.Name = "lbStatus"
        Me.lbStatus.Size = New System.Drawing.Size(103, 16)
        Me.lbStatus.TabIndex = 6
        Me.lbStatus.Text = "Requesting ..."
        '
        'lbService
        '
        Me.lbService.FormattingEnabled = True
        Me.lbService.Items.AddRange(New Object() {"Efficient Autotask", "EfficientAgent"})
        Me.lbService.Location = New System.Drawing.Point(6, 21)
        Me.lbService.Name = "lbService"
        Me.lbService.Size = New System.Drawing.Size(120, 30)
        Me.lbService.TabIndex = 5
        '
        'btnStop
        '
        Me.btnStop.Enabled = False
        Me.btnStop.Location = New System.Drawing.Point(87, 54)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(75, 23)
        Me.btnStop.TabIndex = 4
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Enabled = False
        Me.btnStart.Location = New System.Drawing.Point(6, 54)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 3
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(759, 545)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CMAS Toolbox"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim UDPmenu As ClassUDPmenu
    Dim CMAS(4), CurrentCMAS As CMASString

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "CMAS Toolbox " + My.Application.Info.Version.ToString
        btnConnect.Focus()
        btnConnect.Select()
        ListBox1.SetSelected(0, True)
        ListBox2.SetSelected(0, True)
        lstIUethDplx.SetSelected(0, True)
        lstIUethSpeed.SetSelected(0, True)
        lbService.SetSelected(0, True)
        GetStatus()
    End Sub

#Region "Connexion/Déconnexion"

    Private Sub txtIP_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIP.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Connection()
        End If
    End Sub

    Private Sub txtPort_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPort.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Connection()
        End If
    End Sub

    Private Sub btnConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnect.Click
        Connection()
    End Sub

    Private Sub btnDisconnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisconnect.Click
        Disconnect()
    End Sub

    Private Sub Disconnect()
        UDPmenu.Deconnect()
        btnConnect.Enabled = True
        btnDisconnect.Enabled = False
        txtIP.Enabled = True
        txtPort.Enabled = True
        txtSend.Enabled = False
        btnSend.Enabled = False
        btnClear.Enabled = False
        btnVersion.Enabled = False
        btnSendFile.Enabled = False
        btnRetroActive.Enabled = False
        btnSendEthernetAT.Enabled = False
        btnSendEthernetIU.Enabled = False
        btnIUSetSlave.Enabled = False
        btnIUSetReader.Enabled = False
        btnIUIdentify.Enabled = False
        btnReset.Enabled = False
        TextBox4.Enabled = False
        TextBox5.Enabled = False
        TextBox6.Enabled = False
        TextBox2.Enabled = False
        ListBox1.Enabled = False
        ListBox2.Enabled = False
        txtIUethGW.Enabled = False
        txtIUethMask.Enabled = False
        txtIUethPort.Enabled = False
        txtIUethIP.Enabled = False
        lstIUethDplx.Enabled = False
        lstIUethSpeed.Enabled = False
        GroupBox2.Enabled = False
        GroupBox3.Enabled = False
        GroupBox4.Enabled = False
        GroupBox5.Enabled = False
        GroupBox6.Enabled = False
    End Sub

    Private Sub Connection()
        Try
            UDPmenu = New ClassUDPmenu(txtIP.Text, Convert.ToInt32(txtPort.Text))
            If UDPmenu.Open = True Then
                btnConnect.Enabled = False
                btnDisconnect.Enabled = True
                txtIP.Enabled = False
                txtPort.Enabled = False
                GroupBox2.Enabled = True
                GroupBox3.Enabled = True
                GroupBox4.Enabled = True
                GroupBox5.Enabled = True
                GroupBox6.Enabled = True
                btnSend.Enabled = True
                btnVersion.Enabled = True
                btnClear.Enabled = True
                btnSendFile.Enabled = True
                btnSendEthernetAT.Enabled = True
                btnSendEthernetIU.Enabled = True
                btnReset.Enabled = True
                btnRetroActive.Enabled = True
                TextBox4.Enabled = True
                TextBox5.Enabled = True
                TextBox6.Enabled = True
                TextBox2.Enabled = True
                ListBox1.Enabled = True
                ListBox2.Enabled = True
                txtIUethGW.Enabled = True
                txtIUethMask.Enabled = True
                txtIUethPort.Enabled = True
                txtIUethIP.Enabled = True
                lstIUethDplx.Enabled = True
                lstIUethSpeed.Enabled = True
                UDPmenu.Connect()
                With txtSend
                    .Enabled = True
                    .Focus()
                    .SelectAll()
                End With
            Else
                MessageBox.Show("Can't reach terminal " & txtIP.Text, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "Envoi"
    Private Sub Envoi(ByVal Commande As String)
        Dim reponse As String() = {"", "", "", ""}
        Cursor.Current = Cursors.WaitCursor
        List.Items.Add(">Send: " + Commande)
        reponse = UDPmenu.Envoi(Commande)
        For Each rep As String In reponse
            If rep <> "" Then
                List.Items.Add(">Recv: " + rep)
            End If
        Next
        List.Focus()
        Cursor.Current = Cursors.Default
    End Sub
    Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click
        Envoi(txtSend.Text)
        txtSend.Focus()
        txtSend.SelectAll()
    End Sub
    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSend.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Envoi(txtSend.Text)
            txtSend.Focus()
            txtSend.SelectAll()
        End If
    End Sub
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        List.Items.Clear()
    End Sub
#End Region

#Region "Commandes"
    Private Sub btnVersion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVersion.Click
        Dim reponse As String() = {"", "", "", ""}
        Dim chVersion As String()
        Dim Product As String = ""
        Dim Version As String = ""
        Dim type As Integer = 0
        Dim Caractere_Separateur As Char() = {CChar(".")}
        Cursor.Current = Cursors.WaitCursor
        List.Items.Add("Retrieve terminal version ...")
        reponse = UDPmenu.Envoi("@v")
        For Each rep As String In reponse
            If rep <> "" Then
                List.Items.Add(">Recv: " + rep)
                chVersion = rep.Split(Caractere_Separateur)
                If chVersion(0).StartsWith("v") Then
                    chVersion(0) = chVersion(0).Substring(1)
                End If
                Select Case chVersion.GetLength(0)
                    Case 4
                        List.Items.Add(">Version : " + UDPmenu.RetrieveVersion(chVersion(0), chVersion(1), chVersion(2), chVersion(3)))
                    Case Else
                        List.Items.Add("Impossible to determine terminal version")
                End Select
            End If
        Next
        List.Focus()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Envoi("@CO10000")
        Envoi("RDA00")
    End Sub

    Private Sub btnSendFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSendFile.Click
        With OpenFileDialog1
            .Title = "Ouvrir un fichier de commandes ATTEND"
            .Multiselect = False
            .CheckFileExists = True
            .CheckPathExists = True
            .ValidateNames = True
        End With
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            If MessageBox.Show("Etes vous sur d'envoyer le fichier " + OpenFileDialog1.FileName + " au lecteur " + UDPmenu.AdresseIP + ":" + UDPmenu.Port.ToString + " ?", _
                                "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                Dim contenu() As String = File.ReadAllLines(OpenFileDialog1.FileName)
                For Each commande As String In contenu
                    Envoi(commande)
                Next
            End If
        End If
    End Sub

    Private Sub btnRetroActive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetroActive.Click

        Dim jour, mois, annee As String

        If RetroActive.ShowDialog() = Windows.Forms.DialogResult.OK Then
            jour = RetroActive.MonthCalendar1.SelectionStart.Day.ToString
            mois = RetroActive.MonthCalendar1.SelectionStart.Month.ToString
            annee = RetroActive.MonthCalendar1.SelectionStart.Year.ToString

            If jour.Length = 1 Then
                jour = "0" + jour
            End If
            If mois.Length = 1 Then
                mois = "0" + mois
            End If
            If annee.Length > 2 Then
                annee = annee.Substring(2, 2)
            End If
            Envoi("@CO10000")
            Envoi("RQ" + annee + mois + jour + "00")
        End If

    End Sub
#End Region

#Region "CMAS AT Init"
    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        Envoi("!!645113579")
    End Sub

    Private Sub btnSendEthernet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSendEthernetAT.Click
        Dim Vitesse, Duplex As Short
        Dim Conf As EthernetParameters
        Try
            Select Case ListBox1.SelectedItem.ToString
                Case "Auto"
                    Vitesse = 0
                Case "100 Mb"
                    Vitesse = 1
                Case "10 Mb"
                    Vitesse = 2
            End Select
            Select Case ListBox2.SelectedItem.ToString
                Case "Half Duplex"
                    Duplex = 0
                Case "Full Duplex"
                    Duplex = 1
            End Select
            Conf = New EthernetParameters(TextBox4.Text, TextBox5.Text, TextBox6.Text, Convert.ToInt32(TextBox2.Text), Vitesse, Duplex)
            Envoi(Conf.CommandCMASAT)
            MessageBox.Show("You need to reboot CMAS device!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnRQID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRQID.Click
        Dim UniqueID() As String = {""}
        Dim i As Integer = 0
        Dim id As String = ""
        Try
            Cursor.Current = Cursors.WaitCursor
            btnGet1.Enabled = False
            btnSet1.Enabled = False
            btnIdentify1.Enabled = False
            btnGet2.Enabled = False
            btnSet2.Enabled = False
            btnIdentify2.Enabled = False
            btnGet3.Enabled = False
            btnSet3.Enabled = False
            btnIdentify3.Enabled = False
            btnGet4.Enabled = False
            btnSet4.Enabled = False
            btnIdentify4.Enabled = False
            With lbID1
                .Text = "0000000000000000"
                .ForeColor = Color.Black
            End With
            With txtR1ID1
                .ForeColor = Color.Black
                .Text = "0"
            End With
            With txtR1Typ1
                .ForeColor = Color.Black
                .Text = "0"
            End With
            With txtR2ID1
                .ForeColor = Color.Black
                .Text = "0"
            End With
            With txtR2Typ1
                .ForeColor = Color.Black
                .Text = "0"
            End With
            With txtIO1
                .ForeColor = Color.Black
                .Text = "0"
            End With
            With lbID2
                .Text = "0000000000000000"
                .ForeColor = Color.Black
            End With
            With txtR1ID2
                .ForeColor = Color.Black
                .Text = "0"
            End With
            With txtR1Typ2
                .ForeColor = Color.Black
                .Text = "0"
            End With
            With txtR2ID2
                .ForeColor = Color.Black
                .Text = "0"
            End With
            With txtR2Typ2
                .ForeColor = Color.Black
                .Text = "0"
            End With
            With txtIO2
                .ForeColor = Color.Black
                .Text = "0"
            End With
            With lbID3
                .Text = "0000000000000000"
                .ForeColor = Color.Black
            End With
            With txtR1ID3
                .ForeColor = Color.Black
                .Text = "0"
            End With
            With txtR1Typ3
                .ForeColor = Color.Black
                .Text = "0"
            End With
            With txtR2ID3
                .ForeColor = Color.Black
                .Text = "0"
            End With
            With txtR2Typ3
                .ForeColor = Color.Black
                .Text = "0"
            End With
            With txtIO3
                .ForeColor = Color.Black
                .Text = "0"
            End With
            With lbID4
                .Text = "0000000000000000"
                .ForeColor = Color.Black
            End With
            With txtR1ID4
                .ForeColor = Color.Black
                .Text = "0"
            End With
            With txtR1Typ4
                .ForeColor = Color.Black
                .Text = "0"
            End With
            With txtR2ID4
                .ForeColor = Color.Black
                .Text = "0"
            End With
            With txtR2Typ4
                .ForeColor = Color.Black
                .Text = "0"
            End With
            With txtIO4
                .ForeColor = Color.Black
                .Text = "0"
            End With
            UDPmenu.Envoi("!1")
            UniqueID = UDPmenu.Envoi("!!009902")
            UDPmenu.Envoi("!0")
            For i = 0 To UniqueID.Length - 1
                id = UniqueID(i)
                If (id <> "" And id <> "timeout") Then
                    Select Case i
                        Case 0
                            Dim CMAS1 As New CMASString(id.Substring(6, 16))
                            With lbID1
                                .ForeColor = Color.DarkRed
                                .Text = CMAS1.UniqueID
                            End With
                            CMAS1 = RqCurrentString(CMAS1)
                            With txtR1ID1
                                .ForeColor = Color.DarkRed
                                .Text = CMAS1.Reader1ID
                            End With
                            With txtR1Typ1
                                .ForeColor = Color.DarkRed
                                .Text = CMAS1.Reader1Type
                            End With
                            With txtR2ID1
                                .ForeColor = Color.DarkRed
                                .Text = CMAS1.Reader2ID
                            End With
                            With txtR2Typ1
                                .ForeColor = Color.DarkRed
                                .Text = CMAS1.Reader2Type
                            End With
                            With txtIO1
                                .ForeColor = Color.DarkRed
                                .Text = CMAS1.IOID
                            End With
                            btnGet1.Enabled = True
                            btnSet1.Enabled = True
                            btnIdentify1.Enabled = True
                            CMAS(i) = CMAS1
                        Case 1
                            Dim CMAS2 As New CMASString(id.Substring(6, 16))
                            With lbID2
                                .ForeColor = Color.DarkRed
                                .Text = CMAS2.UniqueID
                            End With
                            CMAS2 = RqCurrentString(CMAS2)
                            With txtR1ID2
                                .ForeColor = Color.DarkRed
                                .Text = CMAS2.Reader1ID
                            End With
                            With txtR1Typ2
                                .ForeColor = Color.DarkRed
                                .Text = CMAS2.Reader1Type
                            End With
                            With txtR2ID2
                                .ForeColor = Color.DarkRed
                                .Text = CMAS2.Reader2ID
                            End With
                            With txtR2Typ2
                                .ForeColor = Color.DarkRed
                                .Text = CMAS2.Reader2Type
                            End With
                            With txtIO2
                                .ForeColor = Color.DarkRed
                                .Text = CMAS2.IOID
                            End With
                            btnGet2.Enabled = True
                            btnSet2.Enabled = True
                            btnIdentify2.Enabled = True
                            CMAS(i) = CMAS2
                        Case 2
                            Dim CMAS3 As New CMASString(id.Substring(6, 16))
                            With lbID3
                                .ForeColor = Color.DarkRed
                                .Text = CMAS3.UniqueID
                            End With
                            CMAS3 = RqCurrentString(CMAS3)
                            With txtR1ID3
                                .ForeColor = Color.DarkRed
                                .Text = CMAS3.Reader1ID
                            End With
                            With txtR1Typ3
                                .ForeColor = Color.DarkRed
                                .Text = CMAS3.Reader1Type
                            End With
                            With txtR2ID3
                                .ForeColor = Color.DarkRed
                                .Text = CMAS3.Reader2ID
                            End With
                            With txtR2Typ3
                                .ForeColor = Color.DarkRed
                                .Text = CMAS3.Reader2Type
                            End With
                            With txtIO3
                                .ForeColor = Color.DarkRed
                                .Text = CMAS3.IOID
                            End With
                            btnGet3.Enabled = True
                            btnSet3.Enabled = True
                            btnIdentify3.Enabled = True
                            CMAS(i) = CMAS3
                        Case 3
                            Dim CMAS4 As New CMASString(id.Substring(6, 16))
                            With lbID4
                                .ForeColor = Color.DarkRed
                                .Text = CMAS4.UniqueID
                            End With
                            CMAS4 = RqCurrentString(CMAS4)
                            With txtR1ID4
                                .ForeColor = Color.DarkRed
                                .Text = CMAS4.Reader1ID
                            End With
                            With txtR1Typ4
                                .ForeColor = Color.DarkRed
                                .Text = CMAS4.Reader1Type
                            End With
                            With txtR2ID4
                                .ForeColor = Color.DarkRed
                                .Text = CMAS4.Reader2ID
                            End With
                            With txtR2Typ4
                                .ForeColor = Color.DarkRed
                                .Text = CMAS4.Reader2Type
                            End With
                            With txtIO4
                                .ForeColor = Color.DarkRed
                                .Text = CMAS4.IOID
                            End With
                            btnGet4.Enabled = True
                            btnSet4.Enabled = True
                            btnIdentify4.Enabled = True
                            CMAS(i) = CMAS4
                    End Select
                End If
            Next
            Cursor.Current = Cursors.Default
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function RqCurrentString(ByVal myCMAS As CMASString) As CMASString
        Dim reponse(), rep As String
        Try
            UDPmenu.Envoi("!1")
            reponse = UDPmenu.Envoi("!!009905" + myCMAS.UniqueID)
            UDPmenu.Envoi("!0")
            rep = reponse.GetValue(0).ToString()
            If (rep <> "" Or rep <> "timeout") And rep.Length = 15 Then
                myCMAS.IOID = rep.Substring(0, 2)
                myCMAS.Reader1ID = rep.Substring(6, 2)
                myCMAS.Reader1Type = rep.Substring(9, 1)
                myCMAS.Reader2ID = rep.Substring(10, 2)
                myCMAS.Reader2Type = rep.Substring(13, 1)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return myCMAS
    End Function

    Private Function CMASSet(ByVal myCMAS As CMASString, ByVal IO As String, ByVal R1Id As String, ByVal R2Id As String, ByVal R1Type As String, ByVal R2Type As String) As CMASString
        UDPmenu.Envoi("!1")
        UDPmenu.Envoi(myCMAS.ChangeID(IO, R1Id, R2Id, R1Type, R2Type))
        UDPmenu.Envoi("!0")
        Return myCMAS
    End Function

    Private Sub btnGet1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGet1.Click
        Cursor.Current = Cursors.WaitCursor
        CurrentCMAS = CMAS(0)
        With lbID1
            .ForeColor = Color.DarkRed
            .Text = CurrentCMAS.UniqueID
        End With
        CurrentCMAS = RqCurrentString(CurrentCMAS)
        With txtR1ID1
            .ForeColor = Color.DarkRed
            .Text = CurrentCMAS.Reader1ID
        End With
        With txtR1Typ1
            .ForeColor = Color.DarkRed
            .Text = CurrentCMAS.Reader1Type
        End With
        With txtR2ID1
            .ForeColor = Color.DarkRed
            .Text = CurrentCMAS.Reader2ID
        End With
        With txtR2Typ1
            .ForeColor = Color.DarkRed
            .Text = CurrentCMAS.Reader2Type
        End With
        With txtIO1
            .ForeColor = Color.DarkRed
            .Text = CurrentCMAS.IOID
        End With
        btnGet1.Enabled = True
        btnSet1.Enabled = True
        btnIdentify1.Enabled = True
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub btnGet2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGet2.Click
        Cursor.Current = Cursors.WaitCursor
        CurrentCMAS = CMAS(1)
        With lbID2
            .ForeColor = Color.DarkRed
            .Text = CurrentCMAS.UniqueID
        End With
        CurrentCMAS = RqCurrentString(CurrentCMAS)
        With txtR1ID2
            .ForeColor = Color.DarkRed
            .Text = CurrentCMAS.Reader1ID
        End With
        With txtR1Typ2
            .ForeColor = Color.DarkRed
            .Text = CurrentCMAS.Reader1Type
        End With
        With txtR2ID2
            .ForeColor = Color.DarkRed
            .Text = CurrentCMAS.Reader2ID
        End With
        With txtR2Typ2
            .ForeColor = Color.DarkRed
            .Text = CurrentCMAS.Reader2Type
        End With
        With txtIO2
            .ForeColor = Color.DarkRed
            .Text = CurrentCMAS.IOID
        End With
        btnGet2.Enabled = True
        btnSet2.Enabled = True
        btnIdentify2.Enabled = True
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub btnGet3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGet3.Click
        Cursor.Current = Cursors.WaitCursor
        CurrentCMAS = CMAS(2)
        With lbID3
            .ForeColor = Color.DarkRed
            .Text = CurrentCMAS.UniqueID
        End With
        CurrentCMAS = RqCurrentString(CurrentCMAS)
        With txtR1ID3
            .ForeColor = Color.DarkRed
            .Text = CurrentCMAS.Reader1ID
        End With
        With txtR1Typ3
            .ForeColor = Color.DarkRed
            .Text = CurrentCMAS.Reader1Type
        End With
        With txtR2ID3
            .ForeColor = Color.DarkRed
            .Text = CurrentCMAS.Reader2ID
        End With
        With txtR2Typ3
            .ForeColor = Color.DarkRed
            .Text = CurrentCMAS.Reader2Type
        End With
        With txtIO3
            .ForeColor = Color.DarkRed
            .Text = CurrentCMAS.IOID
        End With
        btnGet3.Enabled = True
        btnSet3.Enabled = True
        btnIdentify3.Enabled = True
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub btnGet4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGet4.Click
        Cursor.Current = Cursors.WaitCursor
        CurrentCMAS = CMAS(3)
        With lbID4
            .ForeColor = Color.DarkRed
            .Text = CurrentCMAS.UniqueID
        End With
        CurrentCMAS = RqCurrentString(CurrentCMAS)
        With txtR1ID4
            .ForeColor = Color.DarkRed
            .Text = CurrentCMAS.Reader1ID
        End With
        With txtR1Typ4
            .ForeColor = Color.DarkRed
            .Text = CurrentCMAS.Reader1Type
        End With
        With txtR2ID4
            .ForeColor = Color.DarkRed
            .Text = CurrentCMAS.Reader2ID
        End With
        With txtR2Typ4
            .ForeColor = Color.DarkRed
            .Text = CurrentCMAS.Reader2Type
        End With
        With txtIO4
            .ForeColor = Color.DarkRed
            .Text = CurrentCMAS.IOID
        End With
        btnGet4.Enabled = True
        btnSet4.Enabled = True
        btnIdentify4.Enabled = True
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub btnSet1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSet1.Click
        Cursor.Current = Cursors.WaitCursor
        CMAS(0) = CMASSet(CMAS(0), txtIO1.Text, txtR1ID1.Text, txtR2ID1.Text, txtR1Typ1.Text, txtR2Typ1.Text)
        Cursor.Current = Cursors.Default
    End Sub
    Private Sub btnSet2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSet2.Click
        Cursor.Current = Cursors.WaitCursor
        CMAS(1) = CMASSet(CMAS(1), txtIO2.Text, txtR1ID2.Text, txtR2ID2.Text, txtR1Typ2.Text, txtR2Typ2.Text)
        Cursor.Current = Cursors.Default
    End Sub
    Private Sub btnSet3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSet3.Click
        Cursor.Current = Cursors.WaitCursor
        CMAS(2) = CMASSet(CMAS(2), txtIO3.Text, txtR1ID3.Text, txtR2ID3.Text, txtR1Typ3.Text, txtR2Typ3.Text)
        Cursor.Current = Cursors.Default
    End Sub
    Private Sub btnSet4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSet4.Click
        Cursor.Current = Cursors.WaitCursor
        CMAS(3) = CMASSet(CMAS(3), txtIO4.Text, txtR1ID4.Text, txtR2ID4.Text, txtR1Typ4.Text, txtR2Typ4.Text)
        Cursor.Current = Cursors.Default
    End Sub
    Private Sub btnIdentify1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIdentify1.Click
        Cursor.Current = Cursors.WaitCursor
        CurrentCMAS = CMAS(0)
        UDPmenu.Envoi(CurrentCMAS.Identify)
        Cursor.Current = Cursors.Default
    End Sub
    Private Sub btnIdentify2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIdentify2.Click
        Cursor.Current = Cursors.WaitCursor
        CurrentCMAS = CMAS(1)
        UDPmenu.Envoi(CurrentCMAS.Identify)
        Cursor.Current = Cursors.Default
    End Sub
    Private Sub btnIdentify3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIdentify3.Click
        Cursor.Current = Cursors.WaitCursor
        CurrentCMAS = CMAS(2)
        UDPmenu.Envoi(CurrentCMAS.Identify)
        Cursor.Current = Cursors.Default
    End Sub
    Private Sub btnIdentify4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIdentify4.Click
        Cursor.Current = Cursors.WaitCursor
        CurrentCMAS = CMAS(3)
        UDPmenu.Envoi(CurrentCMAS.Identify)
        Cursor.Current = Cursors.Default
    End Sub
#End Region

#Region "CMAS IU Init"
    Private Sub btnSendEthernetIU_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSendEthernetIU.Click
        Dim Vitesse, Duplex As Short
        Dim Conf As EthernetParameters
        Try
            Select Case lstIUethSpeed.SelectedItem.ToString
                Case "Auto"
                    Vitesse = 0
                Case "100 Mb"
                    Vitesse = 1
                Case "10 Mb"
                    Vitesse = 2
            End Select
            Select Case lstIUethDplx.SelectedItem.ToString
                Case "Half Duplex"
                    Duplex = 0
                Case "Full Duplex"
                    Duplex = 1
            End Select
            Conf = New EthernetParameters(txtIUethIP.Text, txtIUethMask.Text, txtIUethGW.Text, Convert.ToInt32(txtIUethPort.Text), Vitesse, Duplex)
            Envoi(Conf.CommandCMASIU)
            MessageBox.Show("You need to reboot CMAS device!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnIURQID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIURQID.Click
        Dim Reponse(), ID As String
        Dim i As Integer = 0
        Try
            Cursor.Current = Cursors.WaitCursor
            Reponse = UDPmenu.Envoi("?US00")
            Cursor.Current = Cursors.Default
            ID = Reponse(0)
            If String.Compare(ID, "timeout") = 0 Then
                MessageBox.Show("Time out", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf String.Compare(ID, "") <> 0 Then
                CMAS(0) = New CMASString(ID.Substring(2, 16))
                lbIUID1.Text = ID.Substring(2, 16)
                CMAS(1) = New CMASString(ID.Substring(18, 16))
                lbIUID2.Text = ID.Substring(18, 16)
                CMAS(2) = New CMASString(ID.Substring(34, 16))
                lbIUID3.Text = ID.Substring(34, 16)
                CMAS(3) = New CMASString(ID.Substring(50, 16))
                lbIUID4.Text = ID.Substring(50, 16)
                btnIUSetSlave.Enabled = True
                btnIUSetReader.Enabled = True
                btnIUIdentify.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnIUSetReader_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIUSetReader.Click
        Dim commande As String
        Try
            If txtIUR1Typ1.Text <> "" And txtIUR2Typ1.Text <> "" And txtIUR1Typ2.Text <> "" And txtIUR2Typ2.Text <> "" And txtIUR1Typ3.Text <> "" And txtIUR2Typ3.Text <> "" And txtIUR1Typ4.Text <> "" And txtIUR2Typ4.Text <> "" Then
                Cursor.Current = Cursors.WaitCursor
                commande = "@UCR" + txtIUR1Typ1.Text + txtIUR2Typ1.Text + txtIUR1Typ2.Text + txtIUR2Typ2.Text + txtIUR1Typ3.Text + txtIUR2Typ3.Text + txtIUR1Typ4.Text + txtIUR2Typ4.Text + "00"
                UDPmenu.Envoi(commande)
                Cursor.Current = Cursors.Default
            Else
                MessageBox.Show("Reader type must be between 0 and 10", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnIUIdentify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIUIdentify.Click
        Dim commande As String = "@UI"
        Try
            If btnIUIdentify.Text = "Start Identify" Then
                btnIUIdentify.Text = "Stop Identify"
                commande = commande + lbIUID1.Text + lbIUID2.Text + lbIUID3.Text + lbIUID4.Text + "00"
            Else
                btnIUIdentify.Text = "Start Identify"
                commande = commande + "00"
            End If
            UDPmenu.Envoi(commande)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnIUSetSlave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIUSetSlave.Click
        Dim commande As String = "@UL"
        Dim id(3, 1), idtrie(3) As String
        Dim i As Integer
        Try
            id(0, 0) = txtIUR1ID1.Text
            id(0, 1) = lbIUID1.Text
            id(1, 0) = txtIUR1ID2.Text
            id(1, 1) = lbIUID2.Text
            id(2, 0) = txtIUR1ID3.Text
            id(2, 1) = lbIUID3.Text
            id(3, 0) = txtIUR1ID4.Text
            id(3, 1) = lbIUID4.Text
            For i = 0 To 3
                Select Case id(i, 0)
                    Case "2"
                        idtrie(0) = id(i, 1)
                    Case "3"
                        idtrie(1) = id(i, 1)
                    Case "4"
                        idtrie(2) = id(i, 1)
                    Case "5"
                        idtrie(3) = id(i, 1)
                    Case Else
                End Select
            Next
            For Each Uniqueid As String In idtrie
                commande = commande + Uniqueid
            Next
            UDPmenu.Envoi(commande + "00")
            btnIUSetSlave.Enabled = False
            btnIUSetReader.Enabled = False
            btnIUIdentify.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "Log"
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        With SaveFileDialog1
            .CreatePrompt = True
            .OverwritePrompt = True
            .DefaultExt = "txt"
        End With
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim i As Integer
            Dim contenu As String()
            contenu = New String(List.Items.Count) {}
            For i = 0 To List.Items.Count - 1
                contenu(i) = List.Items.Item(i).ToString
            Next
            File.WriteAllLines(SaveFileDialog1.FileName, contenu)

        End If
    End Sub
#End Region

#Region "Services Management"
    Private Sub lbService_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbService.SelectedIndexChanged
        GetStatus()
    End Sub

    Private Sub GetStatus()
        Try
            Dim ctrlService As New ServiceProcess.ServiceController(lbService.Text)
            ctrlService.Refresh()
            lbStatus.Text = ctrlService.Status.ToString
            If ctrlService.Status.Equals(ServiceProcess.ServiceControllerStatus.Running) Or _
                ctrlService.Status.Equals(ServiceProcess.ServiceControllerStatus.StartPending) Then
                btnStop.Enabled = True
                btnStart.Enabled = False
            Else
                btnStop.Enabled = False
                btnStart.Enabled = True
            End If
            btnRefresh.Enabled = True
        Catch ex As Exception
            lbStatus.Text = "Not Installed"
            btnStart.Enabled = False
            btnStop.Enabled = False
            Cursor.Current = Cursors.Default
        End Try
    End Sub
    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        Cursor.Current = Cursors.WaitCursor
        Dim ctrlService As New ServiceProcess.ServiceController(lbService.Text)
        ctrlService.Start()
        While ctrlService.Status.Equals(ServiceProcess.ServiceControllerStatus.StartPending)
            GetStatus()
            ctrlService.Refresh()
        End While
        Cursor.Current = Cursors.Default
    End Sub
    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
        Cursor.Current = Cursors.WaitCursor
        Dim ctrlService As New ServiceProcess.ServiceController(lbService.Text)
        ctrlService.Stop()
        While ctrlService.Status.Equals(ServiceProcess.ServiceControllerStatus.StopPending)
            lbStatus.Text = "Stop in progess"
            GetStatus()
            ctrlService.Refresh()
        End While
        Cursor.Current = Cursors.Default
    End Sub
    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        GetStatus()
    End Sub
#End Region

End Class
