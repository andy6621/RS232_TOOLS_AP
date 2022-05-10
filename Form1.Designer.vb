<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.btnDisconnect = New System.Windows.Forms.Button()
        Me.cmbPort = New System.Windows.Forms.ComboBox()
        Me.cmbBaud = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.txtTransmit = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rtbReceived = New System.Windows.Forms.RichTextBox()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DEBUGTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.btnGroupBox = New System.Windows.Forms.GroupBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnMCUREV = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnREGGroup = New System.Windows.Forms.GroupBox()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox36 = New System.Windows.Forms.TextBox()
        Me.REG0F = New System.Windows.Forms.TextBox()
        Me.TextBox35 = New System.Windows.Forms.TextBox()
        Me.REG07 = New System.Windows.Forms.TextBox()
        Me.TextBox34 = New System.Windows.Forms.TextBox()
        Me.REG0E = New System.Windows.Forms.TextBox()
        Me.TextBox33 = New System.Windows.Forms.TextBox()
        Me.REG06 = New System.Windows.Forms.TextBox()
        Me.TextBox32 = New System.Windows.Forms.TextBox()
        Me.REG0D = New System.Windows.Forms.TextBox()
        Me.TextBox31 = New System.Windows.Forms.TextBox()
        Me.REG05 = New System.Windows.Forms.TextBox()
        Me.TextBox30 = New System.Windows.Forms.TextBox()
        Me.REG0C = New System.Windows.Forms.TextBox()
        Me.TextBox29 = New System.Windows.Forms.TextBox()
        Me.REG04 = New System.Windows.Forms.TextBox()
        Me.TextBox28 = New System.Windows.Forms.TextBox()
        Me.REG0B = New System.Windows.Forms.TextBox()
        Me.TextBox27 = New System.Windows.Forms.TextBox()
        Me.REG03 = New System.Windows.Forms.TextBox()
        Me.TextBox26 = New System.Windows.Forms.TextBox()
        Me.REG0A = New System.Windows.Forms.TextBox()
        Me.TextBox25 = New System.Windows.Forms.TextBox()
        Me.REG02 = New System.Windows.Forms.TextBox()
        Me.TextBox24 = New System.Windows.Forms.TextBox()
        Me.REG09 = New System.Windows.Forms.TextBox()
        Me.TextBox23 = New System.Windows.Forms.TextBox()
        Me.REG01 = New System.Windows.Forms.TextBox()
        Me.TextBox22 = New System.Windows.Forms.TextBox()
        Me.REG08 = New System.Windows.Forms.TextBox()
        Me.TextBox52 = New System.Windows.Forms.TextBox()
        Me.REGFF = New System.Windows.Forms.TextBox()
        Me.REGF7 = New System.Windows.Forms.TextBox()
        Me.REGFE = New System.Windows.Forms.TextBox()
        Me.REGF6 = New System.Windows.Forms.TextBox()
        Me.REGFD = New System.Windows.Forms.TextBox()
        Me.REGF5 = New System.Windows.Forms.TextBox()
        Me.REGFC = New System.Windows.Forms.TextBox()
        Me.REGF4 = New System.Windows.Forms.TextBox()
        Me.REGFB = New System.Windows.Forms.TextBox()
        Me.REGF3 = New System.Windows.Forms.TextBox()
        Me.REGFA = New System.Windows.Forms.TextBox()
        Me.REGF2 = New System.Windows.Forms.TextBox()
        Me.REGF9 = New System.Windows.Forms.TextBox()
        Me.REGF1 = New System.Windows.Forms.TextBox()
        Me.REGF8 = New System.Windows.Forms.TextBox()
        Me.REGF0 = New System.Windows.Forms.TextBox()
        Me.TextBox51 = New System.Windows.Forms.TextBox()
        Me.REGDF = New System.Windows.Forms.TextBox()
        Me.REGD7 = New System.Windows.Forms.TextBox()
        Me.REGDE = New System.Windows.Forms.TextBox()
        Me.REGD6 = New System.Windows.Forms.TextBox()
        Me.REGDD = New System.Windows.Forms.TextBox()
        Me.REGD5 = New System.Windows.Forms.TextBox()
        Me.REGDC = New System.Windows.Forms.TextBox()
        Me.REGD4 = New System.Windows.Forms.TextBox()
        Me.REGDB = New System.Windows.Forms.TextBox()
        Me.REGD3 = New System.Windows.Forms.TextBox()
        Me.REGDA = New System.Windows.Forms.TextBox()
        Me.REGD2 = New System.Windows.Forms.TextBox()
        Me.REGD9 = New System.Windows.Forms.TextBox()
        Me.REGD1 = New System.Windows.Forms.TextBox()
        Me.REGD8 = New System.Windows.Forms.TextBox()
        Me.REGD0 = New System.Windows.Forms.TextBox()
        Me.TextBox50 = New System.Windows.Forms.TextBox()
        Me.REGBF = New System.Windows.Forms.TextBox()
        Me.REGB7 = New System.Windows.Forms.TextBox()
        Me.REGBE = New System.Windows.Forms.TextBox()
        Me.REGB6 = New System.Windows.Forms.TextBox()
        Me.REGBD = New System.Windows.Forms.TextBox()
        Me.REGB5 = New System.Windows.Forms.TextBox()
        Me.REGBC = New System.Windows.Forms.TextBox()
        Me.REGB4 = New System.Windows.Forms.TextBox()
        Me.REGBB = New System.Windows.Forms.TextBox()
        Me.REGB3 = New System.Windows.Forms.TextBox()
        Me.REGBA = New System.Windows.Forms.TextBox()
        Me.REGB2 = New System.Windows.Forms.TextBox()
        Me.REGB9 = New System.Windows.Forms.TextBox()
        Me.REGB1 = New System.Windows.Forms.TextBox()
        Me.REGB8 = New System.Windows.Forms.TextBox()
        Me.REGB0 = New System.Windows.Forms.TextBox()
        Me.TextBox49 = New System.Windows.Forms.TextBox()
        Me.REGEF = New System.Windows.Forms.TextBox()
        Me.REGE7 = New System.Windows.Forms.TextBox()
        Me.REGEE = New System.Windows.Forms.TextBox()
        Me.REGE6 = New System.Windows.Forms.TextBox()
        Me.REGED = New System.Windows.Forms.TextBox()
        Me.REGE5 = New System.Windows.Forms.TextBox()
        Me.REGEC = New System.Windows.Forms.TextBox()
        Me.REGE4 = New System.Windows.Forms.TextBox()
        Me.REGEB = New System.Windows.Forms.TextBox()
        Me.REGE3 = New System.Windows.Forms.TextBox()
        Me.REGEA = New System.Windows.Forms.TextBox()
        Me.REGE2 = New System.Windows.Forms.TextBox()
        Me.REGE9 = New System.Windows.Forms.TextBox()
        Me.REGE1 = New System.Windows.Forms.TextBox()
        Me.REGE8 = New System.Windows.Forms.TextBox()
        Me.REGE0 = New System.Windows.Forms.TextBox()
        Me.TextBox48 = New System.Windows.Forms.TextBox()
        Me.REGCF = New System.Windows.Forms.TextBox()
        Me.REGC7 = New System.Windows.Forms.TextBox()
        Me.REGCE = New System.Windows.Forms.TextBox()
        Me.REGC6 = New System.Windows.Forms.TextBox()
        Me.REGCD = New System.Windows.Forms.TextBox()
        Me.REGC5 = New System.Windows.Forms.TextBox()
        Me.REGCC = New System.Windows.Forms.TextBox()
        Me.REGC4 = New System.Windows.Forms.TextBox()
        Me.REGCB = New System.Windows.Forms.TextBox()
        Me.REGC3 = New System.Windows.Forms.TextBox()
        Me.REGCA = New System.Windows.Forms.TextBox()
        Me.REGC2 = New System.Windows.Forms.TextBox()
        Me.REGC9 = New System.Windows.Forms.TextBox()
        Me.REGC1 = New System.Windows.Forms.TextBox()
        Me.REGC8 = New System.Windows.Forms.TextBox()
        Me.REGC0 = New System.Windows.Forms.TextBox()
        Me.TextBox47 = New System.Windows.Forms.TextBox()
        Me.REGAF = New System.Windows.Forms.TextBox()
        Me.REGA7 = New System.Windows.Forms.TextBox()
        Me.REGAE = New System.Windows.Forms.TextBox()
        Me.REGA6 = New System.Windows.Forms.TextBox()
        Me.REGAD = New System.Windows.Forms.TextBox()
        Me.REGA5 = New System.Windows.Forms.TextBox()
        Me.REGAC = New System.Windows.Forms.TextBox()
        Me.REGA4 = New System.Windows.Forms.TextBox()
        Me.REGAB = New System.Windows.Forms.TextBox()
        Me.REGA3 = New System.Windows.Forms.TextBox()
        Me.REGAA = New System.Windows.Forms.TextBox()
        Me.REGA2 = New System.Windows.Forms.TextBox()
        Me.REGA9 = New System.Windows.Forms.TextBox()
        Me.REGA1 = New System.Windows.Forms.TextBox()
        Me.REGA8 = New System.Windows.Forms.TextBox()
        Me.REGA0 = New System.Windows.Forms.TextBox()
        Me.TextBox46 = New System.Windows.Forms.TextBox()
        Me.REG9F = New System.Windows.Forms.TextBox()
        Me.REG97 = New System.Windows.Forms.TextBox()
        Me.REG9E = New System.Windows.Forms.TextBox()
        Me.REG96 = New System.Windows.Forms.TextBox()
        Me.REG9D = New System.Windows.Forms.TextBox()
        Me.REG95 = New System.Windows.Forms.TextBox()
        Me.REG9C = New System.Windows.Forms.TextBox()
        Me.REG94 = New System.Windows.Forms.TextBox()
        Me.REG9B = New System.Windows.Forms.TextBox()
        Me.REG93 = New System.Windows.Forms.TextBox()
        Me.REG9A = New System.Windows.Forms.TextBox()
        Me.REG92 = New System.Windows.Forms.TextBox()
        Me.REG99 = New System.Windows.Forms.TextBox()
        Me.REG91 = New System.Windows.Forms.TextBox()
        Me.REG98 = New System.Windows.Forms.TextBox()
        Me.REG90 = New System.Windows.Forms.TextBox()
        Me.TextBox45 = New System.Windows.Forms.TextBox()
        Me.REG8F = New System.Windows.Forms.TextBox()
        Me.REG87 = New System.Windows.Forms.TextBox()
        Me.REG8E = New System.Windows.Forms.TextBox()
        Me.REG86 = New System.Windows.Forms.TextBox()
        Me.REG8D = New System.Windows.Forms.TextBox()
        Me.REG85 = New System.Windows.Forms.TextBox()
        Me.REG8C = New System.Windows.Forms.TextBox()
        Me.REG84 = New System.Windows.Forms.TextBox()
        Me.REG8B = New System.Windows.Forms.TextBox()
        Me.REG83 = New System.Windows.Forms.TextBox()
        Me.REG8A = New System.Windows.Forms.TextBox()
        Me.REG82 = New System.Windows.Forms.TextBox()
        Me.REG89 = New System.Windows.Forms.TextBox()
        Me.REG81 = New System.Windows.Forms.TextBox()
        Me.REG88 = New System.Windows.Forms.TextBox()
        Me.REG80 = New System.Windows.Forms.TextBox()
        Me.TextBox44 = New System.Windows.Forms.TextBox()
        Me.REG7F = New System.Windows.Forms.TextBox()
        Me.REG77 = New System.Windows.Forms.TextBox()
        Me.REG7E = New System.Windows.Forms.TextBox()
        Me.REG76 = New System.Windows.Forms.TextBox()
        Me.REG7D = New System.Windows.Forms.TextBox()
        Me.REG75 = New System.Windows.Forms.TextBox()
        Me.REG7C = New System.Windows.Forms.TextBox()
        Me.REG74 = New System.Windows.Forms.TextBox()
        Me.REG7B = New System.Windows.Forms.TextBox()
        Me.REG73 = New System.Windows.Forms.TextBox()
        Me.REG7A = New System.Windows.Forms.TextBox()
        Me.REG72 = New System.Windows.Forms.TextBox()
        Me.REG79 = New System.Windows.Forms.TextBox()
        Me.REG71 = New System.Windows.Forms.TextBox()
        Me.REG78 = New System.Windows.Forms.TextBox()
        Me.REG70 = New System.Windows.Forms.TextBox()
        Me.TextBox43 = New System.Windows.Forms.TextBox()
        Me.REG6F = New System.Windows.Forms.TextBox()
        Me.REG67 = New System.Windows.Forms.TextBox()
        Me.REG6E = New System.Windows.Forms.TextBox()
        Me.REG66 = New System.Windows.Forms.TextBox()
        Me.REG6D = New System.Windows.Forms.TextBox()
        Me.REG65 = New System.Windows.Forms.TextBox()
        Me.REG6C = New System.Windows.Forms.TextBox()
        Me.REG64 = New System.Windows.Forms.TextBox()
        Me.REG6B = New System.Windows.Forms.TextBox()
        Me.REG63 = New System.Windows.Forms.TextBox()
        Me.REG6A = New System.Windows.Forms.TextBox()
        Me.REG62 = New System.Windows.Forms.TextBox()
        Me.REG69 = New System.Windows.Forms.TextBox()
        Me.REG61 = New System.Windows.Forms.TextBox()
        Me.REG68 = New System.Windows.Forms.TextBox()
        Me.REG60 = New System.Windows.Forms.TextBox()
        Me.TextBox42 = New System.Windows.Forms.TextBox()
        Me.REG5F = New System.Windows.Forms.TextBox()
        Me.REG57 = New System.Windows.Forms.TextBox()
        Me.REG5E = New System.Windows.Forms.TextBox()
        Me.REG56 = New System.Windows.Forms.TextBox()
        Me.REG5D = New System.Windows.Forms.TextBox()
        Me.REG55 = New System.Windows.Forms.TextBox()
        Me.REG5C = New System.Windows.Forms.TextBox()
        Me.REG54 = New System.Windows.Forms.TextBox()
        Me.REG5B = New System.Windows.Forms.TextBox()
        Me.REG53 = New System.Windows.Forms.TextBox()
        Me.REG5A = New System.Windows.Forms.TextBox()
        Me.REG52 = New System.Windows.Forms.TextBox()
        Me.REG59 = New System.Windows.Forms.TextBox()
        Me.REG51 = New System.Windows.Forms.TextBox()
        Me.REG58 = New System.Windows.Forms.TextBox()
        Me.REG50 = New System.Windows.Forms.TextBox()
        Me.TextBox41 = New System.Windows.Forms.TextBox()
        Me.REG4F = New System.Windows.Forms.TextBox()
        Me.REG47 = New System.Windows.Forms.TextBox()
        Me.REG4E = New System.Windows.Forms.TextBox()
        Me.REG46 = New System.Windows.Forms.TextBox()
        Me.REG4D = New System.Windows.Forms.TextBox()
        Me.REG45 = New System.Windows.Forms.TextBox()
        Me.REG4C = New System.Windows.Forms.TextBox()
        Me.REG44 = New System.Windows.Forms.TextBox()
        Me.REG4B = New System.Windows.Forms.TextBox()
        Me.REG43 = New System.Windows.Forms.TextBox()
        Me.REG4A = New System.Windows.Forms.TextBox()
        Me.REG42 = New System.Windows.Forms.TextBox()
        Me.REG49 = New System.Windows.Forms.TextBox()
        Me.REG41 = New System.Windows.Forms.TextBox()
        Me.REG48 = New System.Windows.Forms.TextBox()
        Me.REG40 = New System.Windows.Forms.TextBox()
        Me.TextBox40 = New System.Windows.Forms.TextBox()
        Me.REG3F = New System.Windows.Forms.TextBox()
        Me.REG37 = New System.Windows.Forms.TextBox()
        Me.REG3E = New System.Windows.Forms.TextBox()
        Me.REG36 = New System.Windows.Forms.TextBox()
        Me.REG3D = New System.Windows.Forms.TextBox()
        Me.REG35 = New System.Windows.Forms.TextBox()
        Me.REG3C = New System.Windows.Forms.TextBox()
        Me.REG34 = New System.Windows.Forms.TextBox()
        Me.REG3B = New System.Windows.Forms.TextBox()
        Me.REG33 = New System.Windows.Forms.TextBox()
        Me.REG3A = New System.Windows.Forms.TextBox()
        Me.REG32 = New System.Windows.Forms.TextBox()
        Me.REG39 = New System.Windows.Forms.TextBox()
        Me.REG31 = New System.Windows.Forms.TextBox()
        Me.REG38 = New System.Windows.Forms.TextBox()
        Me.REG30 = New System.Windows.Forms.TextBox()
        Me.TextBox39 = New System.Windows.Forms.TextBox()
        Me.REG2F = New System.Windows.Forms.TextBox()
        Me.REG27 = New System.Windows.Forms.TextBox()
        Me.REG2E = New System.Windows.Forms.TextBox()
        Me.REG26 = New System.Windows.Forms.TextBox()
        Me.REG2D = New System.Windows.Forms.TextBox()
        Me.REG25 = New System.Windows.Forms.TextBox()
        Me.REG2C = New System.Windows.Forms.TextBox()
        Me.REG24 = New System.Windows.Forms.TextBox()
        Me.REG2B = New System.Windows.Forms.TextBox()
        Me.REG23 = New System.Windows.Forms.TextBox()
        Me.REG2A = New System.Windows.Forms.TextBox()
        Me.REG22 = New System.Windows.Forms.TextBox()
        Me.REG29 = New System.Windows.Forms.TextBox()
        Me.REG21 = New System.Windows.Forms.TextBox()
        Me.REG28 = New System.Windows.Forms.TextBox()
        Me.REG20 = New System.Windows.Forms.TextBox()
        Me.TextBox38 = New System.Windows.Forms.TextBox()
        Me.REG1F = New System.Windows.Forms.TextBox()
        Me.REG17 = New System.Windows.Forms.TextBox()
        Me.REG1E = New System.Windows.Forms.TextBox()
        Me.REG16 = New System.Windows.Forms.TextBox()
        Me.REG1D = New System.Windows.Forms.TextBox()
        Me.REG15 = New System.Windows.Forms.TextBox()
        Me.REG1C = New System.Windows.Forms.TextBox()
        Me.REG14 = New System.Windows.Forms.TextBox()
        Me.REG1B = New System.Windows.Forms.TextBox()
        Me.REG13 = New System.Windows.Forms.TextBox()
        Me.REG1A = New System.Windows.Forms.TextBox()
        Me.REG12 = New System.Windows.Forms.TextBox()
        Me.REG19 = New System.Windows.Forms.TextBox()
        Me.REG11 = New System.Windows.Forms.TextBox()
        Me.REG18 = New System.Windows.Forms.TextBox()
        Me.REG10 = New System.Windows.Forms.TextBox()
        Me.TextBox21 = New System.Windows.Forms.TextBox()
        Me.TextBox37 = New System.Windows.Forms.TextBox()
        Me.REG00 = New System.Windows.Forms.TextBox()
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.btnREGGroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnConnect
        '
        Me.btnConnect.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btnConnect.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnConnect.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnConnect.Location = New System.Drawing.Point(346, 16)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(98, 36)
        Me.btnConnect.TabIndex = 0
        Me.btnConnect.Text = "連接"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'btnDisconnect
        '
        Me.btnDisconnect.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btnDisconnect.ForeColor = System.Drawing.Color.Red
        Me.btnDisconnect.Location = New System.Drawing.Point(346, 58)
        Me.btnDisconnect.Name = "btnDisconnect"
        Me.btnDisconnect.Size = New System.Drawing.Size(98, 40)
        Me.btnDisconnect.TabIndex = 1
        Me.btnDisconnect.Text = "中斷"
        Me.btnDisconnect.UseVisualStyleBackColor = True
        '
        'cmbPort
        '
        Me.cmbPort.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmbPort.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmbPort.FormattingEnabled = True
        Me.cmbPort.Location = New System.Drawing.Point(172, 20)
        Me.cmbPort.Name = "cmbPort"
        Me.cmbPort.Size = New System.Drawing.Size(151, 24)
        Me.cmbPort.TabIndex = 2
        '
        'cmbBaud
        '
        Me.cmbBaud.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmbBaud.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmbBaud.FormattingEnabled = True
        Me.cmbBaud.Location = New System.Drawing.Point(172, 69)
        Me.cmbBaud.Name = "cmbBaud"
        Me.cmbBaud.Size = New System.Drawing.Size(151, 24)
        Me.cmbBaud.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(44, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 24)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = " COM PORT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(45, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 24)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "BAUD RATE"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSend)
        Me.GroupBox1.Controls.Add(Me.txtTransmit)
        Me.GroupBox1.Location = New System.Drawing.Point(176, 623)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(213, 76)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Transmit Data"
        Me.GroupBox1.Visible = False
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(291, 46)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(88, 24)
        Me.btnSend.TabIndex = 1
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'txtTransmit
        '
        Me.txtTransmit.Location = New System.Drawing.Point(20, 49)
        Me.txtTransmit.Name = "txtTransmit"
        Me.txtTransmit.Size = New System.Drawing.Size(248, 22)
        Me.txtTransmit.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rtbReceived)
        Me.GroupBox2.Location = New System.Drawing.Point(571, 91)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(401, 292)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "TX/RX Message"
        '
        'rtbReceived
        '
        Me.rtbReceived.BackColor = System.Drawing.Color.Black
        Me.rtbReceived.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.rtbReceived.ForeColor = System.Drawing.Color.White
        Me.rtbReceived.Location = New System.Drawing.Point(20, 21)
        Me.rtbReceived.Name = "rtbReceived"
        Me.rtbReceived.Size = New System.Drawing.Size(364, 257)
        Me.rtbReceived.TabIndex = 0
        Me.rtbReceived.Text = ""
        '
        'SerialPort1
        '
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DEBUGTextBox1)
        Me.GroupBox3.Location = New System.Drawing.Point(572, 396)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(400, 273)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "RX Message"
        '
        'DEBUGTextBox1
        '
        Me.DEBUGTextBox1.BackColor = System.Drawing.Color.Black
        Me.DEBUGTextBox1.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.DEBUGTextBox1.ForeColor = System.Drawing.Color.White
        Me.DEBUGTextBox1.Location = New System.Drawing.Point(20, 21)
        Me.DEBUGTextBox1.MaxLength = 10
        Me.DEBUGTextBox1.Name = "DEBUGTextBox1"
        Me.DEBUGTextBox1.ReadOnly = True
        Me.DEBUGTextBox1.Size = New System.Drawing.Size(364, 246)
        Me.DEBUGTextBox1.TabIndex = 0
        Me.DEBUGTextBox1.Text = ""
        '
        'btnGroupBox
        '
        Me.btnGroupBox.Location = New System.Drawing.Point(217, 714)
        Me.btnGroupBox.Name = "btnGroupBox"
        Me.btnGroupBox.Size = New System.Drawing.Size(111, 51)
        Me.btnGroupBox.TabIndex = 11
        Me.btnGroupBox.TabStop = False
        Me.btnGroupBox.Text = "GroupBox1"
        '
        'ComboBox3
        '
        Me.ComboBox3.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ComboBox3.ForeColor = System.Drawing.Color.Blue
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"MENU", "SELECT", "JUMP", "UP", "DOWN"})
        Me.ComboBox3.Location = New System.Drawing.Point(254, 210)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(85, 29)
        Me.ComboBox3.TabIndex = 48
        Me.ComboBox3.Text = "MENU"
        '
        'ComboBox2
        '
        Me.ComboBox2.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ComboBox2.ForeColor = System.Drawing.Color.Red
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"VS4210", "TP2824", "EEPROM", "VS8812"})
        Me.ComboBox2.Location = New System.Drawing.Point(245, 292)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(83, 21)
        Me.ComboBox2.TabIndex = 47
        Me.ComboBox2.Text = "VS4210"
        '
        'Button13
        '
        Me.Button13.Location = New System.Drawing.Point(317, 416)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(32, 28)
        Me.Button13.TabIndex = 46
        Me.Button13.Text = "D"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(317, 379)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(32, 27)
        Me.Button12.TabIndex = 45
        Me.Button12.Text = "U"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label9.Location = New System.Drawing.Point(258, 381)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 17)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "資料"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label7.Location = New System.Drawing.Point(258, 325)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 17)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "資料"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label8.Location = New System.Drawing.Point(181, 383)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 17)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "位置"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label6.Location = New System.Drawing.Point(181, 327)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 17)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "位置"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label10.Location = New System.Drawing.Point(252, 271)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 17)
        Me.Label10.TabIndex = 44
        Me.Label10.Text = "IC編號"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label5.Location = New System.Drawing.Point(172, 272)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 17)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "I2C位置"
        '
        'TextBox1
        '
        Me.TextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TextBox1.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Red
        Me.TextBox1.Location = New System.Drawing.Point(167, 292)
        Me.TextBox1.MaxLength = 2
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(60, 23)
        Me.TextBox1.TabIndex = 43
        Me.TextBox1.Text = "40"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(244, 345)
        Me.TextBox5.MaxLength = 2
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(65, 22)
        Me.TextBox5.TabIndex = 42
        Me.TextBox5.Text = "?"
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox4
        '
        Me.TextBox4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TextBox4.Location = New System.Drawing.Point(243, 404)
        Me.TextBox4.MaxLength = 2
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(68, 22)
        Me.TextBox4.TabIndex = 41
        Me.TextBox4.Text = "?"
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox3
        '
        Me.TextBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TextBox3.Location = New System.Drawing.Point(166, 404)
        Me.TextBox3.MaxLength = 2
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(64, 22)
        Me.TextBox3.TabIndex = 40
        Me.TextBox3.Text = "0"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(82, 400)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(68, 37)
        Me.Button11.TabIndex = 39
        Me.Button11.Text = "寫入資料"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TextBox2.Location = New System.Drawing.Point(167, 347)
        Me.TextBox2.MaxLength = 2
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(62, 22)
        Me.TextBox2.TabIndex = 38
        Me.TextBox2.Text = "0"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(82, 341)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(68, 37)
        Me.Button10.TabIndex = 37
        Me.Button10.Text = "讀取資料"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.Control
        Me.Button3.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button3.Location = New System.Drawing.Point(393, 212)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(51, 27)
        Me.Button3.TabIndex = 28
        Me.Button3.Text = "開始"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.SeaGreen
        Me.Button9.Location = New System.Drawing.Point(379, 414)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(79, 30)
        Me.Button9.TabIndex = 25
        Me.Button9.Text = "清除RX"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.Blue
        Me.Button8.Location = New System.Drawing.Point(379, 325)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(79, 28)
        Me.Button8.TabIndex = 25
        Me.Button8.Text = "清除TX"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(330, 118)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(44, 54)
        Me.Button7.TabIndex = 35
        Me.Button7.Text = "JUMP"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(277, 118)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(42, 54)
        Me.Button6.TabIndex = 34
        Me.Button6.Text = "SEL"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ComboBox1.ForeColor = System.Drawing.Color.Blue
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.ComboBox1.Location = New System.Drawing.Point(351, 212)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(36, 28)
        Me.ComboBox1.TabIndex = 30
        Me.ComboBox1.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(273, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 20)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "命令        時間(秒)"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(389, 149)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(52, 23)
        Me.Button5.TabIndex = 33
        Me.Button5.Text = "下"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.Font = New System.Drawing.Font("新細明體", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button2.Location = New System.Drawing.Point(277, 46)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(167, 61)
        Me.Button2.TabIndex = 28
        Me.Button2.Text = "MENU"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(389, 118)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(52, 23)
        Me.Button4.TabIndex = 26
        Me.Button4.Text = "上"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'btnMCUREV
        '
        Me.btnMCUREV.BackColor = System.Drawing.SystemColors.Control
        Me.btnMCUREV.Font = New System.Drawing.Font("新細明體", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btnMCUREV.Location = New System.Drawing.Point(82, 46)
        Me.btnMCUREV.Name = "btnMCUREV"
        Me.btnMCUREV.Size = New System.Drawing.Size(157, 128)
        Me.btnMCUREV.TabIndex = 11
        Me.btnMCUREV.Text = "顯示  版本"
        Me.btnMCUREV.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(871, 50)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(68, 35)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "離開"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Timer2
        '
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("新細明體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label4.Location = New System.Drawing.Point(600, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(10, 21)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Timer3
        '
        Me.Timer3.Interval = 500
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(14, 118)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(552, 551)
        Me.TabControl1.TabIndex = 27
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.CheckBox1)
        Me.TabPage1.Controls.Add(Me.TextBox6)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.ComboBox5)
        Me.TabPage1.Controls.Add(Me.ComboBox4)
        Me.TabPage1.Controls.Add(Me.ComboBox3)
        Me.TabPage1.Controls.Add(Me.btnMCUREV)
        Me.TabPage1.Controls.Add(Me.Button9)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Button7)
        Me.TabPage1.Controls.Add(Me.ComboBox2)
        Me.TabPage1.Controls.Add(Me.Button6)
        Me.TabPage1.Controls.Add(Me.TextBox3)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Button4)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Button11)
        Me.TabPage1.Controls.Add(Me.Button8)
        Me.TabPage1.Controls.Add(Me.Button13)
        Me.TabPage1.Controls.Add(Me.ComboBox1)
        Me.TabPage1.Controls.Add(Me.TextBox4)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.TextBox2)
        Me.TabPage1.Controls.Add(Me.Button3)
        Me.TabPage1.Controls.Add(Me.Button12)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.TextBox5)
        Me.TabPage1.Controls.Add(Me.TextBox1)
        Me.TabPage1.Controls.Add(Me.Button5)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Button10)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(544, 525)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "控制功能"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label16.Location = New System.Drawing.Point(59, 459)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(103, 21)
        Me.Label16.TabIndex = 55
        Me.Label16.Text = "TX Message"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(383, 456)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(97, 25)
        Me.CheckBox1.TabIndex = 54
        Me.CheckBox1.Text = "HOT KEY"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'TextBox6
        '
        Me.TextBox6.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(168, 456)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(142, 29)
        Me.TextBox6.TabIndex = 53
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("微軟正黑體", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label15.Location = New System.Drawing.Point(86, 179)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(0, 35)
        Me.Label15.TabIndex = 52
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label12.Location = New System.Drawing.Point(381, 373)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 12)
        Me.Label12.TabIndex = 51
        Me.Label12.Text = "RX Message"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Blue
        Me.Label11.Location = New System.Drawing.Point(377, 284)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 12)
        Me.Label11.TabIndex = 50
        Me.Label11.Text = "TX/RX Message"
        '
        'ComboBox5
        '
        Me.ComboBox5.ForeColor = System.Drawing.Color.SeaGreen
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Items.AddRange(New Object() {"9", "10", "11", "12", "14", "16", "18", "20"})
        Me.ComboBox5.Location = New System.Drawing.Point(379, 388)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(79, 20)
        Me.ComboBox5.TabIndex = 49
        Me.ComboBox5.Text = "12"
        '
        'ComboBox4
        '
        Me.ComboBox4.ForeColor = System.Drawing.Color.Blue
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Items.AddRange(New Object() {"9", "10", "11", "12", "14", "16", "18", "20"})
        Me.ComboBox4.Location = New System.Drawing.Point(379, 299)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(79, 20)
        Me.ComboBox4.TabIndex = 49
        Me.ComboBox4.Text = "12"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.btnREGGroup)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.TextBox36)
        Me.TabPage2.Controls.Add(Me.REG0F)
        Me.TabPage2.Controls.Add(Me.TextBox35)
        Me.TabPage2.Controls.Add(Me.REG07)
        Me.TabPage2.Controls.Add(Me.TextBox34)
        Me.TabPage2.Controls.Add(Me.REG0E)
        Me.TabPage2.Controls.Add(Me.TextBox33)
        Me.TabPage2.Controls.Add(Me.REG06)
        Me.TabPage2.Controls.Add(Me.TextBox32)
        Me.TabPage2.Controls.Add(Me.REG0D)
        Me.TabPage2.Controls.Add(Me.TextBox31)
        Me.TabPage2.Controls.Add(Me.REG05)
        Me.TabPage2.Controls.Add(Me.TextBox30)
        Me.TabPage2.Controls.Add(Me.REG0C)
        Me.TabPage2.Controls.Add(Me.TextBox29)
        Me.TabPage2.Controls.Add(Me.REG04)
        Me.TabPage2.Controls.Add(Me.TextBox28)
        Me.TabPage2.Controls.Add(Me.REG0B)
        Me.TabPage2.Controls.Add(Me.TextBox27)
        Me.TabPage2.Controls.Add(Me.REG03)
        Me.TabPage2.Controls.Add(Me.TextBox26)
        Me.TabPage2.Controls.Add(Me.REG0A)
        Me.TabPage2.Controls.Add(Me.TextBox25)
        Me.TabPage2.Controls.Add(Me.REG02)
        Me.TabPage2.Controls.Add(Me.TextBox24)
        Me.TabPage2.Controls.Add(Me.REG09)
        Me.TabPage2.Controls.Add(Me.TextBox23)
        Me.TabPage2.Controls.Add(Me.REG01)
        Me.TabPage2.Controls.Add(Me.TextBox22)
        Me.TabPage2.Controls.Add(Me.REG08)
        Me.TabPage2.Controls.Add(Me.TextBox52)
        Me.TabPage2.Controls.Add(Me.REGFF)
        Me.TabPage2.Controls.Add(Me.REGF7)
        Me.TabPage2.Controls.Add(Me.REGFE)
        Me.TabPage2.Controls.Add(Me.REGF6)
        Me.TabPage2.Controls.Add(Me.REGFD)
        Me.TabPage2.Controls.Add(Me.REGF5)
        Me.TabPage2.Controls.Add(Me.REGFC)
        Me.TabPage2.Controls.Add(Me.REGF4)
        Me.TabPage2.Controls.Add(Me.REGFB)
        Me.TabPage2.Controls.Add(Me.REGF3)
        Me.TabPage2.Controls.Add(Me.REGFA)
        Me.TabPage2.Controls.Add(Me.REGF2)
        Me.TabPage2.Controls.Add(Me.REGF9)
        Me.TabPage2.Controls.Add(Me.REGF1)
        Me.TabPage2.Controls.Add(Me.REGF8)
        Me.TabPage2.Controls.Add(Me.REGF0)
        Me.TabPage2.Controls.Add(Me.TextBox51)
        Me.TabPage2.Controls.Add(Me.REGDF)
        Me.TabPage2.Controls.Add(Me.REGD7)
        Me.TabPage2.Controls.Add(Me.REGDE)
        Me.TabPage2.Controls.Add(Me.REGD6)
        Me.TabPage2.Controls.Add(Me.REGDD)
        Me.TabPage2.Controls.Add(Me.REGD5)
        Me.TabPage2.Controls.Add(Me.REGDC)
        Me.TabPage2.Controls.Add(Me.REGD4)
        Me.TabPage2.Controls.Add(Me.REGDB)
        Me.TabPage2.Controls.Add(Me.REGD3)
        Me.TabPage2.Controls.Add(Me.REGDA)
        Me.TabPage2.Controls.Add(Me.REGD2)
        Me.TabPage2.Controls.Add(Me.REGD9)
        Me.TabPage2.Controls.Add(Me.REGD1)
        Me.TabPage2.Controls.Add(Me.REGD8)
        Me.TabPage2.Controls.Add(Me.REGD0)
        Me.TabPage2.Controls.Add(Me.TextBox50)
        Me.TabPage2.Controls.Add(Me.REGBF)
        Me.TabPage2.Controls.Add(Me.REGB7)
        Me.TabPage2.Controls.Add(Me.REGBE)
        Me.TabPage2.Controls.Add(Me.REGB6)
        Me.TabPage2.Controls.Add(Me.REGBD)
        Me.TabPage2.Controls.Add(Me.REGB5)
        Me.TabPage2.Controls.Add(Me.REGBC)
        Me.TabPage2.Controls.Add(Me.REGB4)
        Me.TabPage2.Controls.Add(Me.REGBB)
        Me.TabPage2.Controls.Add(Me.REGB3)
        Me.TabPage2.Controls.Add(Me.REGBA)
        Me.TabPage2.Controls.Add(Me.REGB2)
        Me.TabPage2.Controls.Add(Me.REGB9)
        Me.TabPage2.Controls.Add(Me.REGB1)
        Me.TabPage2.Controls.Add(Me.REGB8)
        Me.TabPage2.Controls.Add(Me.REGB0)
        Me.TabPage2.Controls.Add(Me.TextBox49)
        Me.TabPage2.Controls.Add(Me.REGEF)
        Me.TabPage2.Controls.Add(Me.REGE7)
        Me.TabPage2.Controls.Add(Me.REGEE)
        Me.TabPage2.Controls.Add(Me.REGE6)
        Me.TabPage2.Controls.Add(Me.REGED)
        Me.TabPage2.Controls.Add(Me.REGE5)
        Me.TabPage2.Controls.Add(Me.REGEC)
        Me.TabPage2.Controls.Add(Me.REGE4)
        Me.TabPage2.Controls.Add(Me.REGEB)
        Me.TabPage2.Controls.Add(Me.REGE3)
        Me.TabPage2.Controls.Add(Me.REGEA)
        Me.TabPage2.Controls.Add(Me.REGE2)
        Me.TabPage2.Controls.Add(Me.REGE9)
        Me.TabPage2.Controls.Add(Me.REGE1)
        Me.TabPage2.Controls.Add(Me.REGE8)
        Me.TabPage2.Controls.Add(Me.REGE0)
        Me.TabPage2.Controls.Add(Me.TextBox48)
        Me.TabPage2.Controls.Add(Me.REGCF)
        Me.TabPage2.Controls.Add(Me.REGC7)
        Me.TabPage2.Controls.Add(Me.REGCE)
        Me.TabPage2.Controls.Add(Me.REGC6)
        Me.TabPage2.Controls.Add(Me.REGCD)
        Me.TabPage2.Controls.Add(Me.REGC5)
        Me.TabPage2.Controls.Add(Me.REGCC)
        Me.TabPage2.Controls.Add(Me.REGC4)
        Me.TabPage2.Controls.Add(Me.REGCB)
        Me.TabPage2.Controls.Add(Me.REGC3)
        Me.TabPage2.Controls.Add(Me.REGCA)
        Me.TabPage2.Controls.Add(Me.REGC2)
        Me.TabPage2.Controls.Add(Me.REGC9)
        Me.TabPage2.Controls.Add(Me.REGC1)
        Me.TabPage2.Controls.Add(Me.REGC8)
        Me.TabPage2.Controls.Add(Me.REGC0)
        Me.TabPage2.Controls.Add(Me.TextBox47)
        Me.TabPage2.Controls.Add(Me.REGAF)
        Me.TabPage2.Controls.Add(Me.REGA7)
        Me.TabPage2.Controls.Add(Me.REGAE)
        Me.TabPage2.Controls.Add(Me.REGA6)
        Me.TabPage2.Controls.Add(Me.REGAD)
        Me.TabPage2.Controls.Add(Me.REGA5)
        Me.TabPage2.Controls.Add(Me.REGAC)
        Me.TabPage2.Controls.Add(Me.REGA4)
        Me.TabPage2.Controls.Add(Me.REGAB)
        Me.TabPage2.Controls.Add(Me.REGA3)
        Me.TabPage2.Controls.Add(Me.REGAA)
        Me.TabPage2.Controls.Add(Me.REGA2)
        Me.TabPage2.Controls.Add(Me.REGA9)
        Me.TabPage2.Controls.Add(Me.REGA1)
        Me.TabPage2.Controls.Add(Me.REGA8)
        Me.TabPage2.Controls.Add(Me.REGA0)
        Me.TabPage2.Controls.Add(Me.TextBox46)
        Me.TabPage2.Controls.Add(Me.REG9F)
        Me.TabPage2.Controls.Add(Me.REG97)
        Me.TabPage2.Controls.Add(Me.REG9E)
        Me.TabPage2.Controls.Add(Me.REG96)
        Me.TabPage2.Controls.Add(Me.REG9D)
        Me.TabPage2.Controls.Add(Me.REG95)
        Me.TabPage2.Controls.Add(Me.REG9C)
        Me.TabPage2.Controls.Add(Me.REG94)
        Me.TabPage2.Controls.Add(Me.REG9B)
        Me.TabPage2.Controls.Add(Me.REG93)
        Me.TabPage2.Controls.Add(Me.REG9A)
        Me.TabPage2.Controls.Add(Me.REG92)
        Me.TabPage2.Controls.Add(Me.REG99)
        Me.TabPage2.Controls.Add(Me.REG91)
        Me.TabPage2.Controls.Add(Me.REG98)
        Me.TabPage2.Controls.Add(Me.REG90)
        Me.TabPage2.Controls.Add(Me.TextBox45)
        Me.TabPage2.Controls.Add(Me.REG8F)
        Me.TabPage2.Controls.Add(Me.REG87)
        Me.TabPage2.Controls.Add(Me.REG8E)
        Me.TabPage2.Controls.Add(Me.REG86)
        Me.TabPage2.Controls.Add(Me.REG8D)
        Me.TabPage2.Controls.Add(Me.REG85)
        Me.TabPage2.Controls.Add(Me.REG8C)
        Me.TabPage2.Controls.Add(Me.REG84)
        Me.TabPage2.Controls.Add(Me.REG8B)
        Me.TabPage2.Controls.Add(Me.REG83)
        Me.TabPage2.Controls.Add(Me.REG8A)
        Me.TabPage2.Controls.Add(Me.REG82)
        Me.TabPage2.Controls.Add(Me.REG89)
        Me.TabPage2.Controls.Add(Me.REG81)
        Me.TabPage2.Controls.Add(Me.REG88)
        Me.TabPage2.Controls.Add(Me.REG80)
        Me.TabPage2.Controls.Add(Me.TextBox44)
        Me.TabPage2.Controls.Add(Me.REG7F)
        Me.TabPage2.Controls.Add(Me.REG77)
        Me.TabPage2.Controls.Add(Me.REG7E)
        Me.TabPage2.Controls.Add(Me.REG76)
        Me.TabPage2.Controls.Add(Me.REG7D)
        Me.TabPage2.Controls.Add(Me.REG75)
        Me.TabPage2.Controls.Add(Me.REG7C)
        Me.TabPage2.Controls.Add(Me.REG74)
        Me.TabPage2.Controls.Add(Me.REG7B)
        Me.TabPage2.Controls.Add(Me.REG73)
        Me.TabPage2.Controls.Add(Me.REG7A)
        Me.TabPage2.Controls.Add(Me.REG72)
        Me.TabPage2.Controls.Add(Me.REG79)
        Me.TabPage2.Controls.Add(Me.REG71)
        Me.TabPage2.Controls.Add(Me.REG78)
        Me.TabPage2.Controls.Add(Me.REG70)
        Me.TabPage2.Controls.Add(Me.TextBox43)
        Me.TabPage2.Controls.Add(Me.REG6F)
        Me.TabPage2.Controls.Add(Me.REG67)
        Me.TabPage2.Controls.Add(Me.REG6E)
        Me.TabPage2.Controls.Add(Me.REG66)
        Me.TabPage2.Controls.Add(Me.REG6D)
        Me.TabPage2.Controls.Add(Me.REG65)
        Me.TabPage2.Controls.Add(Me.REG6C)
        Me.TabPage2.Controls.Add(Me.REG64)
        Me.TabPage2.Controls.Add(Me.REG6B)
        Me.TabPage2.Controls.Add(Me.REG63)
        Me.TabPage2.Controls.Add(Me.REG6A)
        Me.TabPage2.Controls.Add(Me.REG62)
        Me.TabPage2.Controls.Add(Me.REG69)
        Me.TabPage2.Controls.Add(Me.REG61)
        Me.TabPage2.Controls.Add(Me.REG68)
        Me.TabPage2.Controls.Add(Me.REG60)
        Me.TabPage2.Controls.Add(Me.TextBox42)
        Me.TabPage2.Controls.Add(Me.REG5F)
        Me.TabPage2.Controls.Add(Me.REG57)
        Me.TabPage2.Controls.Add(Me.REG5E)
        Me.TabPage2.Controls.Add(Me.REG56)
        Me.TabPage2.Controls.Add(Me.REG5D)
        Me.TabPage2.Controls.Add(Me.REG55)
        Me.TabPage2.Controls.Add(Me.REG5C)
        Me.TabPage2.Controls.Add(Me.REG54)
        Me.TabPage2.Controls.Add(Me.REG5B)
        Me.TabPage2.Controls.Add(Me.REG53)
        Me.TabPage2.Controls.Add(Me.REG5A)
        Me.TabPage2.Controls.Add(Me.REG52)
        Me.TabPage2.Controls.Add(Me.REG59)
        Me.TabPage2.Controls.Add(Me.REG51)
        Me.TabPage2.Controls.Add(Me.REG58)
        Me.TabPage2.Controls.Add(Me.REG50)
        Me.TabPage2.Controls.Add(Me.TextBox41)
        Me.TabPage2.Controls.Add(Me.REG4F)
        Me.TabPage2.Controls.Add(Me.REG47)
        Me.TabPage2.Controls.Add(Me.REG4E)
        Me.TabPage2.Controls.Add(Me.REG46)
        Me.TabPage2.Controls.Add(Me.REG4D)
        Me.TabPage2.Controls.Add(Me.REG45)
        Me.TabPage2.Controls.Add(Me.REG4C)
        Me.TabPage2.Controls.Add(Me.REG44)
        Me.TabPage2.Controls.Add(Me.REG4B)
        Me.TabPage2.Controls.Add(Me.REG43)
        Me.TabPage2.Controls.Add(Me.REG4A)
        Me.TabPage2.Controls.Add(Me.REG42)
        Me.TabPage2.Controls.Add(Me.REG49)
        Me.TabPage2.Controls.Add(Me.REG41)
        Me.TabPage2.Controls.Add(Me.REG48)
        Me.TabPage2.Controls.Add(Me.REG40)
        Me.TabPage2.Controls.Add(Me.TextBox40)
        Me.TabPage2.Controls.Add(Me.REG3F)
        Me.TabPage2.Controls.Add(Me.REG37)
        Me.TabPage2.Controls.Add(Me.REG3E)
        Me.TabPage2.Controls.Add(Me.REG36)
        Me.TabPage2.Controls.Add(Me.REG3D)
        Me.TabPage2.Controls.Add(Me.REG35)
        Me.TabPage2.Controls.Add(Me.REG3C)
        Me.TabPage2.Controls.Add(Me.REG34)
        Me.TabPage2.Controls.Add(Me.REG3B)
        Me.TabPage2.Controls.Add(Me.REG33)
        Me.TabPage2.Controls.Add(Me.REG3A)
        Me.TabPage2.Controls.Add(Me.REG32)
        Me.TabPage2.Controls.Add(Me.REG39)
        Me.TabPage2.Controls.Add(Me.REG31)
        Me.TabPage2.Controls.Add(Me.REG38)
        Me.TabPage2.Controls.Add(Me.REG30)
        Me.TabPage2.Controls.Add(Me.TextBox39)
        Me.TabPage2.Controls.Add(Me.REG2F)
        Me.TabPage2.Controls.Add(Me.REG27)
        Me.TabPage2.Controls.Add(Me.REG2E)
        Me.TabPage2.Controls.Add(Me.REG26)
        Me.TabPage2.Controls.Add(Me.REG2D)
        Me.TabPage2.Controls.Add(Me.REG25)
        Me.TabPage2.Controls.Add(Me.REG2C)
        Me.TabPage2.Controls.Add(Me.REG24)
        Me.TabPage2.Controls.Add(Me.REG2B)
        Me.TabPage2.Controls.Add(Me.REG23)
        Me.TabPage2.Controls.Add(Me.REG2A)
        Me.TabPage2.Controls.Add(Me.REG22)
        Me.TabPage2.Controls.Add(Me.REG29)
        Me.TabPage2.Controls.Add(Me.REG21)
        Me.TabPage2.Controls.Add(Me.REG28)
        Me.TabPage2.Controls.Add(Me.REG20)
        Me.TabPage2.Controls.Add(Me.TextBox38)
        Me.TabPage2.Controls.Add(Me.REG1F)
        Me.TabPage2.Controls.Add(Me.REG17)
        Me.TabPage2.Controls.Add(Me.REG1E)
        Me.TabPage2.Controls.Add(Me.REG16)
        Me.TabPage2.Controls.Add(Me.REG1D)
        Me.TabPage2.Controls.Add(Me.REG15)
        Me.TabPage2.Controls.Add(Me.REG1C)
        Me.TabPage2.Controls.Add(Me.REG14)
        Me.TabPage2.Controls.Add(Me.REG1B)
        Me.TabPage2.Controls.Add(Me.REG13)
        Me.TabPage2.Controls.Add(Me.REG1A)
        Me.TabPage2.Controls.Add(Me.REG12)
        Me.TabPage2.Controls.Add(Me.REG19)
        Me.TabPage2.Controls.Add(Me.REG11)
        Me.TabPage2.Controls.Add(Me.REG18)
        Me.TabPage2.Controls.Add(Me.REG10)
        Me.TabPage2.Controls.Add(Me.TextBox21)
        Me.TabPage2.Controls.Add(Me.TextBox37)
        Me.TabPage2.Controls.Add(Me.REG00)
        Me.TabPage2.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(544, 525)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "REG.功能"
        '
        'btnREGGroup
        '
        Me.btnREGGroup.Controls.Add(Me.Button18)
        Me.btnREGGroup.Controls.Add(Me.Button17)
        Me.btnREGGroup.Controls.Add(Me.Button14)
        Me.btnREGGroup.Controls.Add(Me.Button16)
        Me.btnREGGroup.Controls.Add(Me.Button15)
        Me.btnREGGroup.Location = New System.Drawing.Point(128, 463)
        Me.btnREGGroup.Name = "btnREGGroup"
        Me.btnREGGroup.Size = New System.Drawing.Size(405, 59)
        Me.btnREGGroup.TabIndex = 28
        Me.btnREGGroup.TabStop = False
        '
        'Button18
        '
        Me.Button18.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button18.Location = New System.Drawing.Point(174, 14)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(66, 40)
        Me.Button18.TabIndex = 8
        Me.Button18.Text = "Write ALL"
        Me.Button18.UseVisualStyleBackColor = True
        '
        'Button17
        '
        Me.Button17.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button17.Location = New System.Drawing.Point(6, 14)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(54, 39)
        Me.Button17.TabIndex = 7
        Me.Button17.Text = "CLR "
        Me.Button17.UseVisualStyleBackColor = True
        '
        'Button14
        '
        Me.Button14.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button14.Location = New System.Drawing.Point(74, 14)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(94, 40)
        Me.Button14.TabIndex = 1
        Me.Button14.Text = "Read ALL"
        Me.Button14.UseVisualStyleBackColor = True
        '
        'Button16
        '
        Me.Button16.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button16.Location = New System.Drawing.Point(252, 14)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(62, 40)
        Me.Button16.TabIndex = 6
        Me.Button16.Text = "Open"
        Me.Button16.UseVisualStyleBackColor = True
        '
        'Button15
        '
        Me.Button15.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button15.Location = New System.Drawing.Point(331, 14)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(65, 40)
        Me.Button15.TabIndex = 2
        Me.Button15.Text = "Save"
        Me.Button15.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(60, 486)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(70, 21)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "VS4210"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(27, 488)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(27, 16)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "IC:"
        '
        'TextBox36
        '
        Me.TextBox36.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox36.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox36.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox36.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox36.Location = New System.Drawing.Point(508, 6)
        Me.TextBox36.Name = "TextBox36"
        Me.TextBox36.Size = New System.Drawing.Size(25, 19)
        Me.TextBox36.TabIndex = 0
        Me.TextBox36.Text = "0F"
        Me.TextBox36.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG0F
        '
        Me.REG0F.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG0F.Location = New System.Drawing.Point(508, 31)
        Me.REG0F.MaxLength = 2
        Me.REG0F.Name = "REG0F"
        Me.REG0F.Size = New System.Drawing.Size(26, 26)
        Me.REG0F.TabIndex = 0
        Me.REG0F.Text = "00"
        Me.REG0F.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox35
        '
        Me.TextBox35.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox35.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox35.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox35.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox35.Location = New System.Drawing.Point(263, 6)
        Me.TextBox35.Name = "TextBox35"
        Me.TextBox35.Size = New System.Drawing.Size(25, 19)
        Me.TextBox35.TabIndex = 0
        Me.TextBox35.Text = "07"
        Me.TextBox35.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG07
        '
        Me.REG07.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG07.Location = New System.Drawing.Point(263, 31)
        Me.REG07.MaxLength = 2
        Me.REG07.Name = "REG07"
        Me.REG07.Size = New System.Drawing.Size(26, 26)
        Me.REG07.TabIndex = 0
        Me.REG07.Text = "00"
        Me.REG07.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox34
        '
        Me.TextBox34.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox34.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox34.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox34.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox34.Location = New System.Drawing.Point(478, 6)
        Me.TextBox34.Name = "TextBox34"
        Me.TextBox34.Size = New System.Drawing.Size(25, 19)
        Me.TextBox34.TabIndex = 0
        Me.TextBox34.Text = "0E"
        Me.TextBox34.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG0E
        '
        Me.REG0E.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG0E.Location = New System.Drawing.Point(478, 31)
        Me.REG0E.MaxLength = 2
        Me.REG0E.Name = "REG0E"
        Me.REG0E.Size = New System.Drawing.Size(26, 26)
        Me.REG0E.TabIndex = 0
        Me.REG0E.Text = "00"
        Me.REG0E.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox33
        '
        Me.TextBox33.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox33.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox33.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox33.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox33.Location = New System.Drawing.Point(233, 6)
        Me.TextBox33.Name = "TextBox33"
        Me.TextBox33.Size = New System.Drawing.Size(25, 19)
        Me.TextBox33.TabIndex = 0
        Me.TextBox33.Text = "06"
        Me.TextBox33.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG06
        '
        Me.REG06.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG06.Location = New System.Drawing.Point(233, 31)
        Me.REG06.MaxLength = 2
        Me.REG06.Name = "REG06"
        Me.REG06.Size = New System.Drawing.Size(26, 26)
        Me.REG06.TabIndex = 0
        Me.REG06.Text = "00"
        Me.REG06.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox32
        '
        Me.TextBox32.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox32.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox32.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox32.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox32.Location = New System.Drawing.Point(448, 6)
        Me.TextBox32.Name = "TextBox32"
        Me.TextBox32.Size = New System.Drawing.Size(25, 19)
        Me.TextBox32.TabIndex = 0
        Me.TextBox32.Text = "0D"
        Me.TextBox32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG0D
        '
        Me.REG0D.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG0D.Location = New System.Drawing.Point(448, 31)
        Me.REG0D.MaxLength = 2
        Me.REG0D.Name = "REG0D"
        Me.REG0D.Size = New System.Drawing.Size(26, 26)
        Me.REG0D.TabIndex = 0
        Me.REG0D.Text = "00"
        Me.REG0D.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox31
        '
        Me.TextBox31.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox31.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox31.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox31.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox31.Location = New System.Drawing.Point(203, 6)
        Me.TextBox31.Name = "TextBox31"
        Me.TextBox31.Size = New System.Drawing.Size(25, 19)
        Me.TextBox31.TabIndex = 0
        Me.TextBox31.Text = "05"
        Me.TextBox31.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG05
        '
        Me.REG05.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG05.Location = New System.Drawing.Point(203, 31)
        Me.REG05.MaxLength = 2
        Me.REG05.Name = "REG05"
        Me.REG05.Size = New System.Drawing.Size(26, 26)
        Me.REG05.TabIndex = 0
        Me.REG05.Text = "00"
        Me.REG05.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox30
        '
        Me.TextBox30.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox30.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox30.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox30.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox30.Location = New System.Drawing.Point(418, 6)
        Me.TextBox30.Name = "TextBox30"
        Me.TextBox30.Size = New System.Drawing.Size(25, 19)
        Me.TextBox30.TabIndex = 0
        Me.TextBox30.Text = "0C"
        Me.TextBox30.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG0C
        '
        Me.REG0C.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG0C.Location = New System.Drawing.Point(418, 31)
        Me.REG0C.MaxLength = 2
        Me.REG0C.Name = "REG0C"
        Me.REG0C.Size = New System.Drawing.Size(26, 26)
        Me.REG0C.TabIndex = 0
        Me.REG0C.Text = "00"
        Me.REG0C.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox29
        '
        Me.TextBox29.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox29.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox29.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox29.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox29.Location = New System.Drawing.Point(173, 6)
        Me.TextBox29.Name = "TextBox29"
        Me.TextBox29.Size = New System.Drawing.Size(25, 19)
        Me.TextBox29.TabIndex = 0
        Me.TextBox29.Text = "04"
        Me.TextBox29.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG04
        '
        Me.REG04.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG04.Location = New System.Drawing.Point(173, 31)
        Me.REG04.MaxLength = 2
        Me.REG04.Name = "REG04"
        Me.REG04.Size = New System.Drawing.Size(26, 26)
        Me.REG04.TabIndex = 0
        Me.REG04.Text = "00"
        Me.REG04.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox28
        '
        Me.TextBox28.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox28.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox28.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox28.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox28.Location = New System.Drawing.Point(388, 6)
        Me.TextBox28.Name = "TextBox28"
        Me.TextBox28.Size = New System.Drawing.Size(25, 19)
        Me.TextBox28.TabIndex = 0
        Me.TextBox28.Text = "0B"
        Me.TextBox28.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG0B
        '
        Me.REG0B.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG0B.Location = New System.Drawing.Point(388, 31)
        Me.REG0B.MaxLength = 2
        Me.REG0B.Name = "REG0B"
        Me.REG0B.Size = New System.Drawing.Size(26, 26)
        Me.REG0B.TabIndex = 0
        Me.REG0B.Text = "00"
        Me.REG0B.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox27
        '
        Me.TextBox27.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox27.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox27.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox27.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox27.Location = New System.Drawing.Point(143, 6)
        Me.TextBox27.Name = "TextBox27"
        Me.TextBox27.Size = New System.Drawing.Size(25, 19)
        Me.TextBox27.TabIndex = 0
        Me.TextBox27.Text = "03"
        Me.TextBox27.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG03
        '
        Me.REG03.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG03.Location = New System.Drawing.Point(143, 31)
        Me.REG03.MaxLength = 2
        Me.REG03.Name = "REG03"
        Me.REG03.Size = New System.Drawing.Size(26, 26)
        Me.REG03.TabIndex = 0
        Me.REG03.Text = "00"
        Me.REG03.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox26
        '
        Me.TextBox26.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox26.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox26.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox26.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox26.Location = New System.Drawing.Point(358, 6)
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.Size = New System.Drawing.Size(25, 19)
        Me.TextBox26.TabIndex = 0
        Me.TextBox26.Text = "0A"
        Me.TextBox26.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG0A
        '
        Me.REG0A.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG0A.Location = New System.Drawing.Point(358, 31)
        Me.REG0A.MaxLength = 2
        Me.REG0A.Name = "REG0A"
        Me.REG0A.Size = New System.Drawing.Size(26, 26)
        Me.REG0A.TabIndex = 0
        Me.REG0A.Text = "00"
        Me.REG0A.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox25
        '
        Me.TextBox25.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox25.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox25.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox25.Location = New System.Drawing.Point(113, 6)
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Size = New System.Drawing.Size(25, 19)
        Me.TextBox25.TabIndex = 0
        Me.TextBox25.Text = "02"
        Me.TextBox25.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG02
        '
        Me.REG02.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG02.Location = New System.Drawing.Point(113, 31)
        Me.REG02.MaxLength = 2
        Me.REG02.Name = "REG02"
        Me.REG02.Size = New System.Drawing.Size(26, 26)
        Me.REG02.TabIndex = 0
        Me.REG02.Text = "00"
        Me.REG02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox24
        '
        Me.TextBox24.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox24.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox24.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox24.Location = New System.Drawing.Point(328, 6)
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Size = New System.Drawing.Size(25, 19)
        Me.TextBox24.TabIndex = 0
        Me.TextBox24.Text = "09"
        Me.TextBox24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG09
        '
        Me.REG09.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG09.Location = New System.Drawing.Point(328, 31)
        Me.REG09.MaxLength = 2
        Me.REG09.Name = "REG09"
        Me.REG09.Size = New System.Drawing.Size(26, 26)
        Me.REG09.TabIndex = 0
        Me.REG09.Text = "00"
        Me.REG09.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox23
        '
        Me.TextBox23.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox23.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox23.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox23.Location = New System.Drawing.Point(83, 6)
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Size = New System.Drawing.Size(25, 19)
        Me.TextBox23.TabIndex = 0
        Me.TextBox23.Text = "01"
        Me.TextBox23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG01
        '
        Me.REG01.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG01.Location = New System.Drawing.Point(83, 31)
        Me.REG01.MaxLength = 2
        Me.REG01.Name = "REG01"
        Me.REG01.Size = New System.Drawing.Size(26, 26)
        Me.REG01.TabIndex = 0
        Me.REG01.Text = "00"
        Me.REG01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox22
        '
        Me.TextBox22.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox22.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox22.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox22.Location = New System.Drawing.Point(297, 6)
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New System.Drawing.Size(25, 19)
        Me.TextBox22.TabIndex = 0
        Me.TextBox22.Text = "08"
        Me.TextBox22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG08
        '
        Me.REG08.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG08.Location = New System.Drawing.Point(297, 31)
        Me.REG08.MaxLength = 2
        Me.REG08.Name = "REG08"
        Me.REG08.Size = New System.Drawing.Size(26, 26)
        Me.REG08.TabIndex = 0
        Me.REG08.Text = "00"
        Me.REG08.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox52
        '
        Me.TextBox52.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox52.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox52.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox52.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox52.Location = New System.Drawing.Point(21, 444)
        Me.TextBox52.Name = "TextBox52"
        Me.TextBox52.Size = New System.Drawing.Size(25, 19)
        Me.TextBox52.TabIndex = 0
        Me.TextBox52.Text = "F0"
        Me.TextBox52.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGFF
        '
        Me.REGFF.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGFF.Location = New System.Drawing.Point(508, 441)
        Me.REGFF.MaxLength = 2
        Me.REGFF.Name = "REGFF"
        Me.REGFF.Size = New System.Drawing.Size(26, 26)
        Me.REGFF.TabIndex = 0
        Me.REGFF.Text = "00"
        Me.REGFF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGF7
        '
        Me.REGF7.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGF7.Location = New System.Drawing.Point(263, 441)
        Me.REGF7.MaxLength = 2
        Me.REGF7.Name = "REGF7"
        Me.REGF7.Size = New System.Drawing.Size(26, 26)
        Me.REGF7.TabIndex = 0
        Me.REGF7.Text = "00"
        Me.REGF7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGFE
        '
        Me.REGFE.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGFE.Location = New System.Drawing.Point(478, 441)
        Me.REGFE.MaxLength = 2
        Me.REGFE.Name = "REGFE"
        Me.REGFE.Size = New System.Drawing.Size(26, 26)
        Me.REGFE.TabIndex = 0
        Me.REGFE.Text = "00"
        Me.REGFE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGF6
        '
        Me.REGF6.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGF6.Location = New System.Drawing.Point(233, 441)
        Me.REGF6.MaxLength = 2
        Me.REGF6.Name = "REGF6"
        Me.REGF6.Size = New System.Drawing.Size(26, 26)
        Me.REGF6.TabIndex = 0
        Me.REGF6.Text = "00"
        Me.REGF6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGFD
        '
        Me.REGFD.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGFD.Location = New System.Drawing.Point(448, 441)
        Me.REGFD.MaxLength = 2
        Me.REGFD.Name = "REGFD"
        Me.REGFD.Size = New System.Drawing.Size(26, 26)
        Me.REGFD.TabIndex = 0
        Me.REGFD.Text = "00"
        Me.REGFD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGF5
        '
        Me.REGF5.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGF5.Location = New System.Drawing.Point(203, 441)
        Me.REGF5.MaxLength = 2
        Me.REGF5.Name = "REGF5"
        Me.REGF5.Size = New System.Drawing.Size(26, 26)
        Me.REGF5.TabIndex = 0
        Me.REGF5.Text = "00"
        Me.REGF5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGFC
        '
        Me.REGFC.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGFC.Location = New System.Drawing.Point(418, 441)
        Me.REGFC.MaxLength = 2
        Me.REGFC.Name = "REGFC"
        Me.REGFC.Size = New System.Drawing.Size(26, 26)
        Me.REGFC.TabIndex = 0
        Me.REGFC.Text = "00"
        Me.REGFC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGF4
        '
        Me.REGF4.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGF4.Location = New System.Drawing.Point(173, 441)
        Me.REGF4.MaxLength = 2
        Me.REGF4.Name = "REGF4"
        Me.REGF4.Size = New System.Drawing.Size(26, 26)
        Me.REGF4.TabIndex = 0
        Me.REGF4.Text = "00"
        Me.REGF4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGFB
        '
        Me.REGFB.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGFB.Location = New System.Drawing.Point(388, 441)
        Me.REGFB.MaxLength = 2
        Me.REGFB.Name = "REGFB"
        Me.REGFB.Size = New System.Drawing.Size(26, 26)
        Me.REGFB.TabIndex = 0
        Me.REGFB.Text = "00"
        Me.REGFB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGF3
        '
        Me.REGF3.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGF3.Location = New System.Drawing.Point(143, 441)
        Me.REGF3.MaxLength = 2
        Me.REGF3.Name = "REGF3"
        Me.REGF3.Size = New System.Drawing.Size(26, 26)
        Me.REGF3.TabIndex = 0
        Me.REGF3.Text = "00"
        Me.REGF3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGFA
        '
        Me.REGFA.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGFA.Location = New System.Drawing.Point(358, 441)
        Me.REGFA.MaxLength = 2
        Me.REGFA.Name = "REGFA"
        Me.REGFA.Size = New System.Drawing.Size(26, 26)
        Me.REGFA.TabIndex = 0
        Me.REGFA.Text = "00"
        Me.REGFA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGF2
        '
        Me.REGF2.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGF2.Location = New System.Drawing.Point(113, 441)
        Me.REGF2.MaxLength = 2
        Me.REGF2.Name = "REGF2"
        Me.REGF2.Size = New System.Drawing.Size(26, 26)
        Me.REGF2.TabIndex = 0
        Me.REGF2.Text = "00"
        Me.REGF2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGF9
        '
        Me.REGF9.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGF9.Location = New System.Drawing.Point(327, 441)
        Me.REGF9.MaxLength = 2
        Me.REGF9.Name = "REGF9"
        Me.REGF9.Size = New System.Drawing.Size(26, 26)
        Me.REGF9.TabIndex = 0
        Me.REGF9.Text = "00"
        Me.REGF9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGF1
        '
        Me.REGF1.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGF1.Location = New System.Drawing.Point(82, 441)
        Me.REGF1.MaxLength = 2
        Me.REGF1.Name = "REGF1"
        Me.REGF1.Size = New System.Drawing.Size(26, 26)
        Me.REGF1.TabIndex = 0
        Me.REGF1.Text = "00"
        Me.REGF1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGF8
        '
        Me.REGF8.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGF8.Location = New System.Drawing.Point(297, 441)
        Me.REGF8.MaxLength = 2
        Me.REGF8.Name = "REGF8"
        Me.REGF8.Size = New System.Drawing.Size(26, 26)
        Me.REGF8.TabIndex = 0
        Me.REGF8.Text = "00"
        Me.REGF8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGF0
        '
        Me.REGF0.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGF0.Location = New System.Drawing.Point(52, 441)
        Me.REGF0.MaxLength = 2
        Me.REGF0.Name = "REGF0"
        Me.REGF0.Size = New System.Drawing.Size(26, 26)
        Me.REGF0.TabIndex = 0
        Me.REGF0.Text = "00"
        Me.REGF0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox51
        '
        Me.TextBox51.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox51.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox51.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox51.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox51.Location = New System.Drawing.Point(21, 390)
        Me.TextBox51.Name = "TextBox51"
        Me.TextBox51.Size = New System.Drawing.Size(25, 19)
        Me.TextBox51.TabIndex = 0
        Me.TextBox51.Text = "D0"
        Me.TextBox51.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGDF
        '
        Me.REGDF.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGDF.Location = New System.Drawing.Point(508, 387)
        Me.REGDF.MaxLength = 2
        Me.REGDF.Name = "REGDF"
        Me.REGDF.Size = New System.Drawing.Size(26, 26)
        Me.REGDF.TabIndex = 0
        Me.REGDF.Text = "00"
        Me.REGDF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGD7
        '
        Me.REGD7.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGD7.Location = New System.Drawing.Point(263, 387)
        Me.REGD7.MaxLength = 2
        Me.REGD7.Name = "REGD7"
        Me.REGD7.Size = New System.Drawing.Size(26, 26)
        Me.REGD7.TabIndex = 0
        Me.REGD7.Text = "00"
        Me.REGD7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGDE
        '
        Me.REGDE.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGDE.Location = New System.Drawing.Point(478, 387)
        Me.REGDE.MaxLength = 2
        Me.REGDE.Name = "REGDE"
        Me.REGDE.Size = New System.Drawing.Size(26, 26)
        Me.REGDE.TabIndex = 0
        Me.REGDE.Text = "00"
        Me.REGDE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGD6
        '
        Me.REGD6.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGD6.Location = New System.Drawing.Point(233, 387)
        Me.REGD6.MaxLength = 2
        Me.REGD6.Name = "REGD6"
        Me.REGD6.Size = New System.Drawing.Size(26, 26)
        Me.REGD6.TabIndex = 0
        Me.REGD6.Text = "00"
        Me.REGD6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGDD
        '
        Me.REGDD.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGDD.Location = New System.Drawing.Point(448, 387)
        Me.REGDD.MaxLength = 2
        Me.REGDD.Name = "REGDD"
        Me.REGDD.Size = New System.Drawing.Size(26, 26)
        Me.REGDD.TabIndex = 0
        Me.REGDD.Text = "00"
        Me.REGDD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGD5
        '
        Me.REGD5.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGD5.Location = New System.Drawing.Point(203, 387)
        Me.REGD5.MaxLength = 2
        Me.REGD5.Name = "REGD5"
        Me.REGD5.Size = New System.Drawing.Size(26, 26)
        Me.REGD5.TabIndex = 0
        Me.REGD5.Text = "00"
        Me.REGD5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGDC
        '
        Me.REGDC.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGDC.Location = New System.Drawing.Point(418, 387)
        Me.REGDC.MaxLength = 2
        Me.REGDC.Name = "REGDC"
        Me.REGDC.Size = New System.Drawing.Size(26, 26)
        Me.REGDC.TabIndex = 0
        Me.REGDC.Text = "00"
        Me.REGDC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGD4
        '
        Me.REGD4.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGD4.Location = New System.Drawing.Point(173, 387)
        Me.REGD4.MaxLength = 2
        Me.REGD4.Name = "REGD4"
        Me.REGD4.Size = New System.Drawing.Size(26, 26)
        Me.REGD4.TabIndex = 0
        Me.REGD4.Text = "00"
        Me.REGD4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGDB
        '
        Me.REGDB.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGDB.Location = New System.Drawing.Point(388, 387)
        Me.REGDB.MaxLength = 2
        Me.REGDB.Name = "REGDB"
        Me.REGDB.Size = New System.Drawing.Size(26, 26)
        Me.REGDB.TabIndex = 0
        Me.REGDB.Text = "00"
        Me.REGDB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGD3
        '
        Me.REGD3.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGD3.Location = New System.Drawing.Point(143, 387)
        Me.REGD3.MaxLength = 2
        Me.REGD3.Name = "REGD3"
        Me.REGD3.Size = New System.Drawing.Size(26, 26)
        Me.REGD3.TabIndex = 0
        Me.REGD3.Text = "00"
        Me.REGD3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGDA
        '
        Me.REGDA.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGDA.Location = New System.Drawing.Point(358, 387)
        Me.REGDA.MaxLength = 2
        Me.REGDA.Name = "REGDA"
        Me.REGDA.Size = New System.Drawing.Size(26, 26)
        Me.REGDA.TabIndex = 0
        Me.REGDA.Text = "00"
        Me.REGDA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGD2
        '
        Me.REGD2.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGD2.Location = New System.Drawing.Point(113, 387)
        Me.REGD2.MaxLength = 2
        Me.REGD2.Name = "REGD2"
        Me.REGD2.Size = New System.Drawing.Size(26, 26)
        Me.REGD2.TabIndex = 0
        Me.REGD2.Text = "00"
        Me.REGD2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGD9
        '
        Me.REGD9.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGD9.Location = New System.Drawing.Point(327, 387)
        Me.REGD9.MaxLength = 2
        Me.REGD9.Name = "REGD9"
        Me.REGD9.Size = New System.Drawing.Size(26, 26)
        Me.REGD9.TabIndex = 0
        Me.REGD9.Text = "00"
        Me.REGD9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGD1
        '
        Me.REGD1.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGD1.Location = New System.Drawing.Point(82, 387)
        Me.REGD1.MaxLength = 2
        Me.REGD1.Name = "REGD1"
        Me.REGD1.Size = New System.Drawing.Size(26, 26)
        Me.REGD1.TabIndex = 0
        Me.REGD1.Text = "00"
        Me.REGD1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGD8
        '
        Me.REGD8.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGD8.Location = New System.Drawing.Point(297, 387)
        Me.REGD8.MaxLength = 2
        Me.REGD8.Name = "REGD8"
        Me.REGD8.Size = New System.Drawing.Size(26, 26)
        Me.REGD8.TabIndex = 0
        Me.REGD8.Text = "00"
        Me.REGD8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGD0
        '
        Me.REGD0.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGD0.Location = New System.Drawing.Point(52, 387)
        Me.REGD0.MaxLength = 2
        Me.REGD0.Name = "REGD0"
        Me.REGD0.Size = New System.Drawing.Size(26, 26)
        Me.REGD0.TabIndex = 0
        Me.REGD0.Text = "00"
        Me.REGD0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox50
        '
        Me.TextBox50.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox50.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox50.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox50.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox50.Location = New System.Drawing.Point(21, 336)
        Me.TextBox50.Name = "TextBox50"
        Me.TextBox50.Size = New System.Drawing.Size(25, 19)
        Me.TextBox50.TabIndex = 0
        Me.TextBox50.Text = "B0"
        Me.TextBox50.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGBF
        '
        Me.REGBF.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGBF.Location = New System.Drawing.Point(508, 333)
        Me.REGBF.MaxLength = 2
        Me.REGBF.Name = "REGBF"
        Me.REGBF.Size = New System.Drawing.Size(26, 26)
        Me.REGBF.TabIndex = 0
        Me.REGBF.Text = "00"
        Me.REGBF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGB7
        '
        Me.REGB7.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGB7.Location = New System.Drawing.Point(263, 333)
        Me.REGB7.MaxLength = 2
        Me.REGB7.Name = "REGB7"
        Me.REGB7.Size = New System.Drawing.Size(26, 26)
        Me.REGB7.TabIndex = 0
        Me.REGB7.Text = "00"
        Me.REGB7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGBE
        '
        Me.REGBE.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGBE.Location = New System.Drawing.Point(478, 333)
        Me.REGBE.MaxLength = 2
        Me.REGBE.Name = "REGBE"
        Me.REGBE.Size = New System.Drawing.Size(26, 26)
        Me.REGBE.TabIndex = 0
        Me.REGBE.Text = "00"
        Me.REGBE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGB6
        '
        Me.REGB6.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGB6.Location = New System.Drawing.Point(233, 333)
        Me.REGB6.MaxLength = 2
        Me.REGB6.Name = "REGB6"
        Me.REGB6.Size = New System.Drawing.Size(26, 26)
        Me.REGB6.TabIndex = 0
        Me.REGB6.Text = "00"
        Me.REGB6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGBD
        '
        Me.REGBD.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGBD.Location = New System.Drawing.Point(448, 333)
        Me.REGBD.MaxLength = 2
        Me.REGBD.Name = "REGBD"
        Me.REGBD.Size = New System.Drawing.Size(26, 26)
        Me.REGBD.TabIndex = 0
        Me.REGBD.Text = "00"
        Me.REGBD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGB5
        '
        Me.REGB5.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGB5.Location = New System.Drawing.Point(203, 333)
        Me.REGB5.MaxLength = 2
        Me.REGB5.Name = "REGB5"
        Me.REGB5.Size = New System.Drawing.Size(26, 26)
        Me.REGB5.TabIndex = 0
        Me.REGB5.Text = "00"
        Me.REGB5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGBC
        '
        Me.REGBC.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGBC.Location = New System.Drawing.Point(418, 333)
        Me.REGBC.MaxLength = 2
        Me.REGBC.Name = "REGBC"
        Me.REGBC.Size = New System.Drawing.Size(26, 26)
        Me.REGBC.TabIndex = 0
        Me.REGBC.Text = "00"
        Me.REGBC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGB4
        '
        Me.REGB4.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGB4.Location = New System.Drawing.Point(173, 333)
        Me.REGB4.MaxLength = 2
        Me.REGB4.Name = "REGB4"
        Me.REGB4.Size = New System.Drawing.Size(26, 26)
        Me.REGB4.TabIndex = 0
        Me.REGB4.Text = "00"
        Me.REGB4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGBB
        '
        Me.REGBB.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGBB.Location = New System.Drawing.Point(388, 333)
        Me.REGBB.MaxLength = 2
        Me.REGBB.Name = "REGBB"
        Me.REGBB.Size = New System.Drawing.Size(26, 26)
        Me.REGBB.TabIndex = 0
        Me.REGBB.Text = "00"
        Me.REGBB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGB3
        '
        Me.REGB3.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGB3.Location = New System.Drawing.Point(143, 333)
        Me.REGB3.MaxLength = 2
        Me.REGB3.Name = "REGB3"
        Me.REGB3.Size = New System.Drawing.Size(26, 26)
        Me.REGB3.TabIndex = 0
        Me.REGB3.Text = "00"
        Me.REGB3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGBA
        '
        Me.REGBA.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGBA.Location = New System.Drawing.Point(358, 333)
        Me.REGBA.MaxLength = 2
        Me.REGBA.Name = "REGBA"
        Me.REGBA.Size = New System.Drawing.Size(26, 26)
        Me.REGBA.TabIndex = 0
        Me.REGBA.Text = "00"
        Me.REGBA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGB2
        '
        Me.REGB2.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGB2.Location = New System.Drawing.Point(113, 333)
        Me.REGB2.MaxLength = 2
        Me.REGB2.Name = "REGB2"
        Me.REGB2.Size = New System.Drawing.Size(26, 26)
        Me.REGB2.TabIndex = 0
        Me.REGB2.Text = "00"
        Me.REGB2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGB9
        '
        Me.REGB9.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGB9.Location = New System.Drawing.Point(327, 333)
        Me.REGB9.MaxLength = 2
        Me.REGB9.Name = "REGB9"
        Me.REGB9.Size = New System.Drawing.Size(26, 26)
        Me.REGB9.TabIndex = 0
        Me.REGB9.Text = "00"
        Me.REGB9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGB1
        '
        Me.REGB1.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGB1.Location = New System.Drawing.Point(82, 333)
        Me.REGB1.MaxLength = 2
        Me.REGB1.Name = "REGB1"
        Me.REGB1.Size = New System.Drawing.Size(26, 26)
        Me.REGB1.TabIndex = 0
        Me.REGB1.Text = "00"
        Me.REGB1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGB8
        '
        Me.REGB8.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGB8.Location = New System.Drawing.Point(297, 333)
        Me.REGB8.MaxLength = 2
        Me.REGB8.Name = "REGB8"
        Me.REGB8.Size = New System.Drawing.Size(26, 26)
        Me.REGB8.TabIndex = 0
        Me.REGB8.Text = "00"
        Me.REGB8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGB0
        '
        Me.REGB0.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGB0.Location = New System.Drawing.Point(52, 333)
        Me.REGB0.MaxLength = 2
        Me.REGB0.Name = "REGB0"
        Me.REGB0.Size = New System.Drawing.Size(26, 26)
        Me.REGB0.TabIndex = 0
        Me.REGB0.Text = "00"
        Me.REGB0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox49
        '
        Me.TextBox49.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox49.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox49.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox49.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox49.Location = New System.Drawing.Point(21, 417)
        Me.TextBox49.Name = "TextBox49"
        Me.TextBox49.Size = New System.Drawing.Size(25, 19)
        Me.TextBox49.TabIndex = 0
        Me.TextBox49.Text = "E0"
        Me.TextBox49.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGEF
        '
        Me.REGEF.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGEF.Location = New System.Drawing.Point(508, 414)
        Me.REGEF.MaxLength = 2
        Me.REGEF.Name = "REGEF"
        Me.REGEF.Size = New System.Drawing.Size(26, 26)
        Me.REGEF.TabIndex = 0
        Me.REGEF.Text = "00"
        Me.REGEF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGE7
        '
        Me.REGE7.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGE7.Location = New System.Drawing.Point(263, 414)
        Me.REGE7.MaxLength = 2
        Me.REGE7.Name = "REGE7"
        Me.REGE7.Size = New System.Drawing.Size(26, 26)
        Me.REGE7.TabIndex = 0
        Me.REGE7.Text = "00"
        Me.REGE7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGEE
        '
        Me.REGEE.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGEE.Location = New System.Drawing.Point(478, 414)
        Me.REGEE.MaxLength = 2
        Me.REGEE.Name = "REGEE"
        Me.REGEE.Size = New System.Drawing.Size(26, 26)
        Me.REGEE.TabIndex = 0
        Me.REGEE.Text = "00"
        Me.REGEE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGE6
        '
        Me.REGE6.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGE6.Location = New System.Drawing.Point(233, 414)
        Me.REGE6.MaxLength = 2
        Me.REGE6.Name = "REGE6"
        Me.REGE6.Size = New System.Drawing.Size(26, 26)
        Me.REGE6.TabIndex = 0
        Me.REGE6.Text = "00"
        Me.REGE6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGED
        '
        Me.REGED.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGED.Location = New System.Drawing.Point(448, 414)
        Me.REGED.MaxLength = 2
        Me.REGED.Name = "REGED"
        Me.REGED.Size = New System.Drawing.Size(26, 26)
        Me.REGED.TabIndex = 0
        Me.REGED.Text = "00"
        Me.REGED.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGE5
        '
        Me.REGE5.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGE5.Location = New System.Drawing.Point(203, 414)
        Me.REGE5.MaxLength = 2
        Me.REGE5.Name = "REGE5"
        Me.REGE5.Size = New System.Drawing.Size(26, 26)
        Me.REGE5.TabIndex = 0
        Me.REGE5.Text = "00"
        Me.REGE5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGEC
        '
        Me.REGEC.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGEC.Location = New System.Drawing.Point(418, 414)
        Me.REGEC.MaxLength = 2
        Me.REGEC.Name = "REGEC"
        Me.REGEC.Size = New System.Drawing.Size(26, 26)
        Me.REGEC.TabIndex = 0
        Me.REGEC.Text = "00"
        Me.REGEC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGE4
        '
        Me.REGE4.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGE4.Location = New System.Drawing.Point(173, 414)
        Me.REGE4.MaxLength = 2
        Me.REGE4.Name = "REGE4"
        Me.REGE4.Size = New System.Drawing.Size(26, 26)
        Me.REGE4.TabIndex = 0
        Me.REGE4.Text = "00"
        Me.REGE4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGEB
        '
        Me.REGEB.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGEB.Location = New System.Drawing.Point(388, 414)
        Me.REGEB.MaxLength = 2
        Me.REGEB.Name = "REGEB"
        Me.REGEB.Size = New System.Drawing.Size(26, 26)
        Me.REGEB.TabIndex = 0
        Me.REGEB.Text = "00"
        Me.REGEB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGE3
        '
        Me.REGE3.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGE3.Location = New System.Drawing.Point(143, 414)
        Me.REGE3.MaxLength = 2
        Me.REGE3.Name = "REGE3"
        Me.REGE3.Size = New System.Drawing.Size(26, 26)
        Me.REGE3.TabIndex = 0
        Me.REGE3.Text = "00"
        Me.REGE3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGEA
        '
        Me.REGEA.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGEA.Location = New System.Drawing.Point(358, 414)
        Me.REGEA.MaxLength = 2
        Me.REGEA.Name = "REGEA"
        Me.REGEA.Size = New System.Drawing.Size(26, 26)
        Me.REGEA.TabIndex = 0
        Me.REGEA.Text = "00"
        Me.REGEA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGE2
        '
        Me.REGE2.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGE2.Location = New System.Drawing.Point(113, 414)
        Me.REGE2.MaxLength = 2
        Me.REGE2.Name = "REGE2"
        Me.REGE2.Size = New System.Drawing.Size(26, 26)
        Me.REGE2.TabIndex = 0
        Me.REGE2.Text = "00"
        Me.REGE2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGE9
        '
        Me.REGE9.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGE9.Location = New System.Drawing.Point(327, 414)
        Me.REGE9.MaxLength = 2
        Me.REGE9.Name = "REGE9"
        Me.REGE9.Size = New System.Drawing.Size(26, 26)
        Me.REGE9.TabIndex = 0
        Me.REGE9.Text = "00"
        Me.REGE9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGE1
        '
        Me.REGE1.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGE1.Location = New System.Drawing.Point(82, 414)
        Me.REGE1.MaxLength = 2
        Me.REGE1.Name = "REGE1"
        Me.REGE1.Size = New System.Drawing.Size(26, 26)
        Me.REGE1.TabIndex = 0
        Me.REGE1.Text = "00"
        Me.REGE1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGE8
        '
        Me.REGE8.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGE8.Location = New System.Drawing.Point(297, 414)
        Me.REGE8.MaxLength = 2
        Me.REGE8.Name = "REGE8"
        Me.REGE8.Size = New System.Drawing.Size(26, 26)
        Me.REGE8.TabIndex = 0
        Me.REGE8.Text = "00"
        Me.REGE8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGE0
        '
        Me.REGE0.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGE0.Location = New System.Drawing.Point(52, 414)
        Me.REGE0.MaxLength = 2
        Me.REGE0.Name = "REGE0"
        Me.REGE0.Size = New System.Drawing.Size(26, 26)
        Me.REGE0.TabIndex = 0
        Me.REGE0.Text = "00"
        Me.REGE0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox48
        '
        Me.TextBox48.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox48.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox48.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox48.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox48.Location = New System.Drawing.Point(21, 363)
        Me.TextBox48.Name = "TextBox48"
        Me.TextBox48.Size = New System.Drawing.Size(25, 19)
        Me.TextBox48.TabIndex = 0
        Me.TextBox48.Text = "C0"
        Me.TextBox48.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGCF
        '
        Me.REGCF.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGCF.Location = New System.Drawing.Point(508, 360)
        Me.REGCF.MaxLength = 2
        Me.REGCF.Name = "REGCF"
        Me.REGCF.Size = New System.Drawing.Size(26, 26)
        Me.REGCF.TabIndex = 0
        Me.REGCF.Text = "00"
        Me.REGCF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGC7
        '
        Me.REGC7.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGC7.Location = New System.Drawing.Point(263, 360)
        Me.REGC7.MaxLength = 2
        Me.REGC7.Name = "REGC7"
        Me.REGC7.Size = New System.Drawing.Size(26, 26)
        Me.REGC7.TabIndex = 0
        Me.REGC7.Text = "00"
        Me.REGC7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGCE
        '
        Me.REGCE.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGCE.Location = New System.Drawing.Point(478, 360)
        Me.REGCE.MaxLength = 2
        Me.REGCE.Name = "REGCE"
        Me.REGCE.Size = New System.Drawing.Size(26, 26)
        Me.REGCE.TabIndex = 0
        Me.REGCE.Text = "00"
        Me.REGCE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGC6
        '
        Me.REGC6.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGC6.Location = New System.Drawing.Point(233, 360)
        Me.REGC6.MaxLength = 2
        Me.REGC6.Name = "REGC6"
        Me.REGC6.Size = New System.Drawing.Size(26, 26)
        Me.REGC6.TabIndex = 0
        Me.REGC6.Text = "00"
        Me.REGC6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGCD
        '
        Me.REGCD.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGCD.Location = New System.Drawing.Point(448, 360)
        Me.REGCD.MaxLength = 2
        Me.REGCD.Name = "REGCD"
        Me.REGCD.Size = New System.Drawing.Size(26, 26)
        Me.REGCD.TabIndex = 0
        Me.REGCD.Text = "00"
        Me.REGCD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGC5
        '
        Me.REGC5.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGC5.Location = New System.Drawing.Point(203, 360)
        Me.REGC5.MaxLength = 2
        Me.REGC5.Name = "REGC5"
        Me.REGC5.Size = New System.Drawing.Size(26, 26)
        Me.REGC5.TabIndex = 0
        Me.REGC5.Text = "00"
        Me.REGC5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGCC
        '
        Me.REGCC.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGCC.Location = New System.Drawing.Point(418, 360)
        Me.REGCC.MaxLength = 2
        Me.REGCC.Name = "REGCC"
        Me.REGCC.Size = New System.Drawing.Size(26, 26)
        Me.REGCC.TabIndex = 0
        Me.REGCC.Text = "00"
        Me.REGCC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGC4
        '
        Me.REGC4.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGC4.Location = New System.Drawing.Point(173, 360)
        Me.REGC4.MaxLength = 2
        Me.REGC4.Name = "REGC4"
        Me.REGC4.Size = New System.Drawing.Size(26, 26)
        Me.REGC4.TabIndex = 0
        Me.REGC4.Text = "00"
        Me.REGC4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGCB
        '
        Me.REGCB.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGCB.Location = New System.Drawing.Point(388, 360)
        Me.REGCB.MaxLength = 2
        Me.REGCB.Name = "REGCB"
        Me.REGCB.Size = New System.Drawing.Size(26, 26)
        Me.REGCB.TabIndex = 0
        Me.REGCB.Text = "00"
        Me.REGCB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGC3
        '
        Me.REGC3.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGC3.Location = New System.Drawing.Point(143, 360)
        Me.REGC3.MaxLength = 2
        Me.REGC3.Name = "REGC3"
        Me.REGC3.Size = New System.Drawing.Size(26, 26)
        Me.REGC3.TabIndex = 0
        Me.REGC3.Text = "00"
        Me.REGC3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGCA
        '
        Me.REGCA.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGCA.Location = New System.Drawing.Point(358, 360)
        Me.REGCA.MaxLength = 2
        Me.REGCA.Name = "REGCA"
        Me.REGCA.Size = New System.Drawing.Size(26, 26)
        Me.REGCA.TabIndex = 0
        Me.REGCA.Text = "00"
        Me.REGCA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGC2
        '
        Me.REGC2.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGC2.Location = New System.Drawing.Point(113, 360)
        Me.REGC2.MaxLength = 2
        Me.REGC2.Name = "REGC2"
        Me.REGC2.Size = New System.Drawing.Size(26, 26)
        Me.REGC2.TabIndex = 0
        Me.REGC2.Text = "00"
        Me.REGC2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGC9
        '
        Me.REGC9.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGC9.Location = New System.Drawing.Point(327, 360)
        Me.REGC9.MaxLength = 2
        Me.REGC9.Name = "REGC9"
        Me.REGC9.Size = New System.Drawing.Size(26, 26)
        Me.REGC9.TabIndex = 0
        Me.REGC9.Text = "00"
        Me.REGC9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGC1
        '
        Me.REGC1.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGC1.Location = New System.Drawing.Point(82, 360)
        Me.REGC1.MaxLength = 2
        Me.REGC1.Name = "REGC1"
        Me.REGC1.Size = New System.Drawing.Size(26, 26)
        Me.REGC1.TabIndex = 0
        Me.REGC1.Text = "00"
        Me.REGC1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGC8
        '
        Me.REGC8.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGC8.Location = New System.Drawing.Point(297, 360)
        Me.REGC8.MaxLength = 2
        Me.REGC8.Name = "REGC8"
        Me.REGC8.Size = New System.Drawing.Size(26, 26)
        Me.REGC8.TabIndex = 0
        Me.REGC8.Text = "00"
        Me.REGC8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGC0
        '
        Me.REGC0.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGC0.Location = New System.Drawing.Point(52, 360)
        Me.REGC0.MaxLength = 2
        Me.REGC0.Name = "REGC0"
        Me.REGC0.Size = New System.Drawing.Size(26, 26)
        Me.REGC0.TabIndex = 0
        Me.REGC0.Text = "00"
        Me.REGC0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox47
        '
        Me.TextBox47.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox47.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox47.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox47.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox47.Location = New System.Drawing.Point(21, 309)
        Me.TextBox47.Name = "TextBox47"
        Me.TextBox47.Size = New System.Drawing.Size(25, 19)
        Me.TextBox47.TabIndex = 0
        Me.TextBox47.Text = "A0"
        Me.TextBox47.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGAF
        '
        Me.REGAF.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGAF.Location = New System.Drawing.Point(508, 306)
        Me.REGAF.MaxLength = 2
        Me.REGAF.Name = "REGAF"
        Me.REGAF.Size = New System.Drawing.Size(26, 26)
        Me.REGAF.TabIndex = 0
        Me.REGAF.Text = "00"
        Me.REGAF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGA7
        '
        Me.REGA7.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGA7.Location = New System.Drawing.Point(263, 306)
        Me.REGA7.MaxLength = 2
        Me.REGA7.Name = "REGA7"
        Me.REGA7.Size = New System.Drawing.Size(26, 26)
        Me.REGA7.TabIndex = 0
        Me.REGA7.Text = "00"
        Me.REGA7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGAE
        '
        Me.REGAE.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGAE.Location = New System.Drawing.Point(478, 306)
        Me.REGAE.MaxLength = 2
        Me.REGAE.Name = "REGAE"
        Me.REGAE.Size = New System.Drawing.Size(26, 26)
        Me.REGAE.TabIndex = 0
        Me.REGAE.Text = "00"
        Me.REGAE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGA6
        '
        Me.REGA6.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGA6.Location = New System.Drawing.Point(233, 306)
        Me.REGA6.MaxLength = 2
        Me.REGA6.Name = "REGA6"
        Me.REGA6.Size = New System.Drawing.Size(26, 26)
        Me.REGA6.TabIndex = 0
        Me.REGA6.Text = "00"
        Me.REGA6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGAD
        '
        Me.REGAD.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGAD.Location = New System.Drawing.Point(448, 306)
        Me.REGAD.MaxLength = 2
        Me.REGAD.Name = "REGAD"
        Me.REGAD.Size = New System.Drawing.Size(26, 26)
        Me.REGAD.TabIndex = 0
        Me.REGAD.Text = "00"
        Me.REGAD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGA5
        '
        Me.REGA5.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGA5.Location = New System.Drawing.Point(203, 306)
        Me.REGA5.MaxLength = 2
        Me.REGA5.Name = "REGA5"
        Me.REGA5.Size = New System.Drawing.Size(26, 26)
        Me.REGA5.TabIndex = 0
        Me.REGA5.Text = "00"
        Me.REGA5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGAC
        '
        Me.REGAC.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGAC.Location = New System.Drawing.Point(418, 306)
        Me.REGAC.MaxLength = 2
        Me.REGAC.Name = "REGAC"
        Me.REGAC.Size = New System.Drawing.Size(26, 26)
        Me.REGAC.TabIndex = 0
        Me.REGAC.Text = "00"
        Me.REGAC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGA4
        '
        Me.REGA4.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGA4.Location = New System.Drawing.Point(173, 306)
        Me.REGA4.MaxLength = 2
        Me.REGA4.Name = "REGA4"
        Me.REGA4.Size = New System.Drawing.Size(26, 26)
        Me.REGA4.TabIndex = 0
        Me.REGA4.Text = "00"
        Me.REGA4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGAB
        '
        Me.REGAB.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGAB.Location = New System.Drawing.Point(388, 306)
        Me.REGAB.MaxLength = 2
        Me.REGAB.Name = "REGAB"
        Me.REGAB.Size = New System.Drawing.Size(26, 26)
        Me.REGAB.TabIndex = 0
        Me.REGAB.Text = "00"
        Me.REGAB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGA3
        '
        Me.REGA3.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGA3.Location = New System.Drawing.Point(143, 306)
        Me.REGA3.MaxLength = 2
        Me.REGA3.Name = "REGA3"
        Me.REGA3.Size = New System.Drawing.Size(26, 26)
        Me.REGA3.TabIndex = 0
        Me.REGA3.Text = "00"
        Me.REGA3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGAA
        '
        Me.REGAA.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGAA.Location = New System.Drawing.Point(358, 306)
        Me.REGAA.MaxLength = 2
        Me.REGAA.Name = "REGAA"
        Me.REGAA.Size = New System.Drawing.Size(26, 26)
        Me.REGAA.TabIndex = 0
        Me.REGAA.Text = "00"
        Me.REGAA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGA2
        '
        Me.REGA2.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGA2.Location = New System.Drawing.Point(113, 306)
        Me.REGA2.MaxLength = 2
        Me.REGA2.Name = "REGA2"
        Me.REGA2.Size = New System.Drawing.Size(26, 26)
        Me.REGA2.TabIndex = 0
        Me.REGA2.Text = "00"
        Me.REGA2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGA9
        '
        Me.REGA9.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGA9.Location = New System.Drawing.Point(327, 306)
        Me.REGA9.MaxLength = 2
        Me.REGA9.Name = "REGA9"
        Me.REGA9.Size = New System.Drawing.Size(26, 26)
        Me.REGA9.TabIndex = 0
        Me.REGA9.Text = "00"
        Me.REGA9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGA1
        '
        Me.REGA1.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGA1.Location = New System.Drawing.Point(82, 306)
        Me.REGA1.MaxLength = 2
        Me.REGA1.Name = "REGA1"
        Me.REGA1.Size = New System.Drawing.Size(26, 26)
        Me.REGA1.TabIndex = 0
        Me.REGA1.Text = "00"
        Me.REGA1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGA8
        '
        Me.REGA8.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGA8.Location = New System.Drawing.Point(297, 306)
        Me.REGA8.MaxLength = 2
        Me.REGA8.Name = "REGA8"
        Me.REGA8.Size = New System.Drawing.Size(26, 26)
        Me.REGA8.TabIndex = 0
        Me.REGA8.Text = "00"
        Me.REGA8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGA0
        '
        Me.REGA0.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGA0.Location = New System.Drawing.Point(52, 306)
        Me.REGA0.MaxLength = 2
        Me.REGA0.Name = "REGA0"
        Me.REGA0.Size = New System.Drawing.Size(26, 26)
        Me.REGA0.TabIndex = 0
        Me.REGA0.Text = "00"
        Me.REGA0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox46
        '
        Me.TextBox46.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox46.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox46.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox46.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox46.Location = New System.Drawing.Point(21, 282)
        Me.TextBox46.Name = "TextBox46"
        Me.TextBox46.Size = New System.Drawing.Size(25, 19)
        Me.TextBox46.TabIndex = 0
        Me.TextBox46.Text = "90"
        Me.TextBox46.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG9F
        '
        Me.REG9F.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG9F.Location = New System.Drawing.Point(508, 279)
        Me.REG9F.MaxLength = 2
        Me.REG9F.Name = "REG9F"
        Me.REG9F.Size = New System.Drawing.Size(26, 26)
        Me.REG9F.TabIndex = 0
        Me.REG9F.Text = "00"
        Me.REG9F.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG97
        '
        Me.REG97.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG97.Location = New System.Drawing.Point(263, 279)
        Me.REG97.MaxLength = 2
        Me.REG97.Name = "REG97"
        Me.REG97.Size = New System.Drawing.Size(26, 26)
        Me.REG97.TabIndex = 0
        Me.REG97.Text = "00"
        Me.REG97.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG9E
        '
        Me.REG9E.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG9E.Location = New System.Drawing.Point(478, 279)
        Me.REG9E.MaxLength = 2
        Me.REG9E.Name = "REG9E"
        Me.REG9E.Size = New System.Drawing.Size(26, 26)
        Me.REG9E.TabIndex = 0
        Me.REG9E.Text = "00"
        Me.REG9E.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG96
        '
        Me.REG96.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG96.Location = New System.Drawing.Point(233, 279)
        Me.REG96.MaxLength = 2
        Me.REG96.Name = "REG96"
        Me.REG96.Size = New System.Drawing.Size(26, 26)
        Me.REG96.TabIndex = 0
        Me.REG96.Text = "00"
        Me.REG96.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG9D
        '
        Me.REG9D.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG9D.Location = New System.Drawing.Point(448, 279)
        Me.REG9D.MaxLength = 2
        Me.REG9D.Name = "REG9D"
        Me.REG9D.Size = New System.Drawing.Size(26, 26)
        Me.REG9D.TabIndex = 0
        Me.REG9D.Text = "00"
        Me.REG9D.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG95
        '
        Me.REG95.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG95.Location = New System.Drawing.Point(203, 279)
        Me.REG95.MaxLength = 2
        Me.REG95.Name = "REG95"
        Me.REG95.Size = New System.Drawing.Size(26, 26)
        Me.REG95.TabIndex = 0
        Me.REG95.Text = "00"
        Me.REG95.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG9C
        '
        Me.REG9C.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG9C.Location = New System.Drawing.Point(418, 279)
        Me.REG9C.MaxLength = 2
        Me.REG9C.Name = "REG9C"
        Me.REG9C.Size = New System.Drawing.Size(26, 26)
        Me.REG9C.TabIndex = 0
        Me.REG9C.Text = "00"
        Me.REG9C.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG94
        '
        Me.REG94.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG94.Location = New System.Drawing.Point(173, 279)
        Me.REG94.MaxLength = 2
        Me.REG94.Name = "REG94"
        Me.REG94.Size = New System.Drawing.Size(26, 26)
        Me.REG94.TabIndex = 0
        Me.REG94.Text = "00"
        Me.REG94.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG9B
        '
        Me.REG9B.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG9B.Location = New System.Drawing.Point(388, 279)
        Me.REG9B.MaxLength = 2
        Me.REG9B.Name = "REG9B"
        Me.REG9B.Size = New System.Drawing.Size(26, 26)
        Me.REG9B.TabIndex = 0
        Me.REG9B.Text = "00"
        Me.REG9B.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG93
        '
        Me.REG93.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG93.Location = New System.Drawing.Point(143, 279)
        Me.REG93.MaxLength = 2
        Me.REG93.Name = "REG93"
        Me.REG93.Size = New System.Drawing.Size(26, 26)
        Me.REG93.TabIndex = 0
        Me.REG93.Text = "00"
        Me.REG93.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG9A
        '
        Me.REG9A.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG9A.Location = New System.Drawing.Point(358, 279)
        Me.REG9A.MaxLength = 2
        Me.REG9A.Name = "REG9A"
        Me.REG9A.Size = New System.Drawing.Size(26, 26)
        Me.REG9A.TabIndex = 0
        Me.REG9A.Text = "00"
        Me.REG9A.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG92
        '
        Me.REG92.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG92.Location = New System.Drawing.Point(113, 279)
        Me.REG92.MaxLength = 2
        Me.REG92.Name = "REG92"
        Me.REG92.Size = New System.Drawing.Size(26, 26)
        Me.REG92.TabIndex = 0
        Me.REG92.Text = "00"
        Me.REG92.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG99
        '
        Me.REG99.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG99.Location = New System.Drawing.Point(327, 279)
        Me.REG99.MaxLength = 2
        Me.REG99.Name = "REG99"
        Me.REG99.Size = New System.Drawing.Size(26, 26)
        Me.REG99.TabIndex = 0
        Me.REG99.Text = "00"
        Me.REG99.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG91
        '
        Me.REG91.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG91.Location = New System.Drawing.Point(82, 279)
        Me.REG91.MaxLength = 2
        Me.REG91.Name = "REG91"
        Me.REG91.Size = New System.Drawing.Size(26, 26)
        Me.REG91.TabIndex = 0
        Me.REG91.Text = "00"
        Me.REG91.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG98
        '
        Me.REG98.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG98.Location = New System.Drawing.Point(297, 279)
        Me.REG98.MaxLength = 2
        Me.REG98.Name = "REG98"
        Me.REG98.Size = New System.Drawing.Size(26, 26)
        Me.REG98.TabIndex = 0
        Me.REG98.Text = "00"
        Me.REG98.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG90
        '
        Me.REG90.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG90.Location = New System.Drawing.Point(52, 279)
        Me.REG90.MaxLength = 2
        Me.REG90.Name = "REG90"
        Me.REG90.Size = New System.Drawing.Size(26, 26)
        Me.REG90.TabIndex = 0
        Me.REG90.Text = "00"
        Me.REG90.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox45
        '
        Me.TextBox45.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox45.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox45.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox45.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox45.Location = New System.Drawing.Point(21, 255)
        Me.TextBox45.Name = "TextBox45"
        Me.TextBox45.Size = New System.Drawing.Size(25, 19)
        Me.TextBox45.TabIndex = 0
        Me.TextBox45.Text = "80"
        Me.TextBox45.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG8F
        '
        Me.REG8F.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG8F.Location = New System.Drawing.Point(508, 252)
        Me.REG8F.MaxLength = 2
        Me.REG8F.Name = "REG8F"
        Me.REG8F.Size = New System.Drawing.Size(26, 26)
        Me.REG8F.TabIndex = 0
        Me.REG8F.Text = "00"
        Me.REG8F.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG87
        '
        Me.REG87.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG87.Location = New System.Drawing.Point(263, 252)
        Me.REG87.MaxLength = 2
        Me.REG87.Name = "REG87"
        Me.REG87.Size = New System.Drawing.Size(26, 26)
        Me.REG87.TabIndex = 0
        Me.REG87.Text = "00"
        Me.REG87.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG8E
        '
        Me.REG8E.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG8E.Location = New System.Drawing.Point(478, 252)
        Me.REG8E.MaxLength = 2
        Me.REG8E.Name = "REG8E"
        Me.REG8E.Size = New System.Drawing.Size(26, 26)
        Me.REG8E.TabIndex = 0
        Me.REG8E.Text = "00"
        Me.REG8E.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG86
        '
        Me.REG86.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG86.Location = New System.Drawing.Point(233, 252)
        Me.REG86.MaxLength = 2
        Me.REG86.Name = "REG86"
        Me.REG86.Size = New System.Drawing.Size(26, 26)
        Me.REG86.TabIndex = 0
        Me.REG86.Text = "00"
        Me.REG86.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG8D
        '
        Me.REG8D.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG8D.Location = New System.Drawing.Point(448, 252)
        Me.REG8D.MaxLength = 2
        Me.REG8D.Name = "REG8D"
        Me.REG8D.Size = New System.Drawing.Size(26, 26)
        Me.REG8D.TabIndex = 0
        Me.REG8D.Text = "00"
        Me.REG8D.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG85
        '
        Me.REG85.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG85.Location = New System.Drawing.Point(203, 252)
        Me.REG85.MaxLength = 2
        Me.REG85.Name = "REG85"
        Me.REG85.Size = New System.Drawing.Size(26, 26)
        Me.REG85.TabIndex = 0
        Me.REG85.Text = "00"
        Me.REG85.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG8C
        '
        Me.REG8C.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG8C.Location = New System.Drawing.Point(418, 252)
        Me.REG8C.MaxLength = 2
        Me.REG8C.Name = "REG8C"
        Me.REG8C.Size = New System.Drawing.Size(26, 26)
        Me.REG8C.TabIndex = 0
        Me.REG8C.Text = "00"
        Me.REG8C.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG84
        '
        Me.REG84.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG84.Location = New System.Drawing.Point(173, 252)
        Me.REG84.MaxLength = 2
        Me.REG84.Name = "REG84"
        Me.REG84.Size = New System.Drawing.Size(26, 26)
        Me.REG84.TabIndex = 0
        Me.REG84.Text = "00"
        Me.REG84.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG8B
        '
        Me.REG8B.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG8B.Location = New System.Drawing.Point(388, 252)
        Me.REG8B.MaxLength = 2
        Me.REG8B.Name = "REG8B"
        Me.REG8B.Size = New System.Drawing.Size(26, 26)
        Me.REG8B.TabIndex = 0
        Me.REG8B.Text = "00"
        Me.REG8B.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG83
        '
        Me.REG83.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG83.Location = New System.Drawing.Point(143, 252)
        Me.REG83.MaxLength = 2
        Me.REG83.Name = "REG83"
        Me.REG83.Size = New System.Drawing.Size(26, 26)
        Me.REG83.TabIndex = 0
        Me.REG83.Text = "00"
        Me.REG83.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG8A
        '
        Me.REG8A.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG8A.Location = New System.Drawing.Point(358, 252)
        Me.REG8A.MaxLength = 2
        Me.REG8A.Name = "REG8A"
        Me.REG8A.Size = New System.Drawing.Size(26, 26)
        Me.REG8A.TabIndex = 0
        Me.REG8A.Text = "00"
        Me.REG8A.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG82
        '
        Me.REG82.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG82.Location = New System.Drawing.Point(113, 252)
        Me.REG82.MaxLength = 2
        Me.REG82.Name = "REG82"
        Me.REG82.Size = New System.Drawing.Size(26, 26)
        Me.REG82.TabIndex = 0
        Me.REG82.Text = "00"
        Me.REG82.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG89
        '
        Me.REG89.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG89.Location = New System.Drawing.Point(327, 252)
        Me.REG89.MaxLength = 2
        Me.REG89.Name = "REG89"
        Me.REG89.Size = New System.Drawing.Size(26, 26)
        Me.REG89.TabIndex = 0
        Me.REG89.Text = "00"
        Me.REG89.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG81
        '
        Me.REG81.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG81.Location = New System.Drawing.Point(82, 252)
        Me.REG81.MaxLength = 2
        Me.REG81.Name = "REG81"
        Me.REG81.Size = New System.Drawing.Size(26, 26)
        Me.REG81.TabIndex = 0
        Me.REG81.Text = "00"
        Me.REG81.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG88
        '
        Me.REG88.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG88.Location = New System.Drawing.Point(297, 252)
        Me.REG88.MaxLength = 2
        Me.REG88.Name = "REG88"
        Me.REG88.Size = New System.Drawing.Size(26, 26)
        Me.REG88.TabIndex = 0
        Me.REG88.Text = "00"
        Me.REG88.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG80
        '
        Me.REG80.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG80.Location = New System.Drawing.Point(52, 252)
        Me.REG80.MaxLength = 2
        Me.REG80.Name = "REG80"
        Me.REG80.Size = New System.Drawing.Size(26, 26)
        Me.REG80.TabIndex = 0
        Me.REG80.Text = "00"
        Me.REG80.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox44
        '
        Me.TextBox44.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox44.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox44.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox44.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox44.Location = New System.Drawing.Point(21, 223)
        Me.TextBox44.Name = "TextBox44"
        Me.TextBox44.Size = New System.Drawing.Size(25, 19)
        Me.TextBox44.TabIndex = 0
        Me.TextBox44.Text = "70"
        Me.TextBox44.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG7F
        '
        Me.REG7F.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG7F.Location = New System.Drawing.Point(508, 220)
        Me.REG7F.MaxLength = 2
        Me.REG7F.Name = "REG7F"
        Me.REG7F.Size = New System.Drawing.Size(26, 26)
        Me.REG7F.TabIndex = 0
        Me.REG7F.Text = "00"
        Me.REG7F.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG77
        '
        Me.REG77.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG77.Location = New System.Drawing.Point(263, 220)
        Me.REG77.MaxLength = 2
        Me.REG77.Name = "REG77"
        Me.REG77.Size = New System.Drawing.Size(26, 26)
        Me.REG77.TabIndex = 0
        Me.REG77.Text = "00"
        Me.REG77.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG7E
        '
        Me.REG7E.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG7E.Location = New System.Drawing.Point(478, 220)
        Me.REG7E.MaxLength = 2
        Me.REG7E.Name = "REG7E"
        Me.REG7E.Size = New System.Drawing.Size(26, 26)
        Me.REG7E.TabIndex = 0
        Me.REG7E.Text = "00"
        Me.REG7E.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG76
        '
        Me.REG76.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG76.Location = New System.Drawing.Point(233, 220)
        Me.REG76.MaxLength = 2
        Me.REG76.Name = "REG76"
        Me.REG76.Size = New System.Drawing.Size(26, 26)
        Me.REG76.TabIndex = 0
        Me.REG76.Text = "00"
        Me.REG76.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG7D
        '
        Me.REG7D.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG7D.Location = New System.Drawing.Point(448, 220)
        Me.REG7D.MaxLength = 2
        Me.REG7D.Name = "REG7D"
        Me.REG7D.Size = New System.Drawing.Size(26, 26)
        Me.REG7D.TabIndex = 0
        Me.REG7D.Text = "00"
        Me.REG7D.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG75
        '
        Me.REG75.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG75.Location = New System.Drawing.Point(203, 220)
        Me.REG75.MaxLength = 2
        Me.REG75.Name = "REG75"
        Me.REG75.Size = New System.Drawing.Size(26, 26)
        Me.REG75.TabIndex = 0
        Me.REG75.Text = "00"
        Me.REG75.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG7C
        '
        Me.REG7C.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG7C.Location = New System.Drawing.Point(418, 220)
        Me.REG7C.MaxLength = 2
        Me.REG7C.Name = "REG7C"
        Me.REG7C.Size = New System.Drawing.Size(26, 26)
        Me.REG7C.TabIndex = 0
        Me.REG7C.Text = "00"
        Me.REG7C.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG74
        '
        Me.REG74.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG74.Location = New System.Drawing.Point(173, 220)
        Me.REG74.MaxLength = 2
        Me.REG74.Name = "REG74"
        Me.REG74.Size = New System.Drawing.Size(26, 26)
        Me.REG74.TabIndex = 0
        Me.REG74.Text = "00"
        Me.REG74.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG7B
        '
        Me.REG7B.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG7B.Location = New System.Drawing.Point(388, 220)
        Me.REG7B.MaxLength = 2
        Me.REG7B.Name = "REG7B"
        Me.REG7B.Size = New System.Drawing.Size(26, 26)
        Me.REG7B.TabIndex = 0
        Me.REG7B.Text = "00"
        Me.REG7B.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG73
        '
        Me.REG73.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG73.Location = New System.Drawing.Point(143, 220)
        Me.REG73.MaxLength = 2
        Me.REG73.Name = "REG73"
        Me.REG73.Size = New System.Drawing.Size(26, 26)
        Me.REG73.TabIndex = 0
        Me.REG73.Text = "00"
        Me.REG73.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG7A
        '
        Me.REG7A.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG7A.Location = New System.Drawing.Point(358, 220)
        Me.REG7A.MaxLength = 2
        Me.REG7A.Name = "REG7A"
        Me.REG7A.Size = New System.Drawing.Size(26, 26)
        Me.REG7A.TabIndex = 0
        Me.REG7A.Text = "00"
        Me.REG7A.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG72
        '
        Me.REG72.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG72.Location = New System.Drawing.Point(113, 220)
        Me.REG72.MaxLength = 2
        Me.REG72.Name = "REG72"
        Me.REG72.Size = New System.Drawing.Size(26, 26)
        Me.REG72.TabIndex = 0
        Me.REG72.Text = "00"
        Me.REG72.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG79
        '
        Me.REG79.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG79.Location = New System.Drawing.Point(327, 220)
        Me.REG79.MaxLength = 2
        Me.REG79.Name = "REG79"
        Me.REG79.Size = New System.Drawing.Size(26, 26)
        Me.REG79.TabIndex = 0
        Me.REG79.Text = "00"
        Me.REG79.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG71
        '
        Me.REG71.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG71.Location = New System.Drawing.Point(82, 220)
        Me.REG71.MaxLength = 2
        Me.REG71.Name = "REG71"
        Me.REG71.Size = New System.Drawing.Size(26, 26)
        Me.REG71.TabIndex = 0
        Me.REG71.Text = "00"
        Me.REG71.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG78
        '
        Me.REG78.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG78.Location = New System.Drawing.Point(297, 220)
        Me.REG78.MaxLength = 2
        Me.REG78.Name = "REG78"
        Me.REG78.Size = New System.Drawing.Size(26, 26)
        Me.REG78.TabIndex = 0
        Me.REG78.Text = "00"
        Me.REG78.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG70
        '
        Me.REG70.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG70.Location = New System.Drawing.Point(52, 220)
        Me.REG70.MaxLength = 2
        Me.REG70.Name = "REG70"
        Me.REG70.Size = New System.Drawing.Size(26, 26)
        Me.REG70.TabIndex = 0
        Me.REG70.Text = "00"
        Me.REG70.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox43
        '
        Me.TextBox43.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox43.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox43.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox43.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox43.Location = New System.Drawing.Point(21, 196)
        Me.TextBox43.Name = "TextBox43"
        Me.TextBox43.Size = New System.Drawing.Size(25, 19)
        Me.TextBox43.TabIndex = 0
        Me.TextBox43.Text = "60"
        Me.TextBox43.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG6F
        '
        Me.REG6F.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG6F.Location = New System.Drawing.Point(508, 193)
        Me.REG6F.MaxLength = 2
        Me.REG6F.Name = "REG6F"
        Me.REG6F.Size = New System.Drawing.Size(26, 26)
        Me.REG6F.TabIndex = 0
        Me.REG6F.Text = "00"
        Me.REG6F.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG67
        '
        Me.REG67.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG67.Location = New System.Drawing.Point(263, 193)
        Me.REG67.MaxLength = 2
        Me.REG67.Name = "REG67"
        Me.REG67.Size = New System.Drawing.Size(26, 26)
        Me.REG67.TabIndex = 0
        Me.REG67.Text = "00"
        Me.REG67.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG6E
        '
        Me.REG6E.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG6E.Location = New System.Drawing.Point(478, 193)
        Me.REG6E.MaxLength = 2
        Me.REG6E.Name = "REG6E"
        Me.REG6E.Size = New System.Drawing.Size(26, 26)
        Me.REG6E.TabIndex = 0
        Me.REG6E.Text = "00"
        Me.REG6E.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG66
        '
        Me.REG66.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG66.Location = New System.Drawing.Point(233, 193)
        Me.REG66.MaxLength = 2
        Me.REG66.Name = "REG66"
        Me.REG66.Size = New System.Drawing.Size(26, 26)
        Me.REG66.TabIndex = 0
        Me.REG66.Text = "00"
        Me.REG66.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG6D
        '
        Me.REG6D.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG6D.Location = New System.Drawing.Point(448, 193)
        Me.REG6D.MaxLength = 2
        Me.REG6D.Name = "REG6D"
        Me.REG6D.Size = New System.Drawing.Size(26, 26)
        Me.REG6D.TabIndex = 0
        Me.REG6D.Text = "00"
        Me.REG6D.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG65
        '
        Me.REG65.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG65.Location = New System.Drawing.Point(203, 193)
        Me.REG65.MaxLength = 2
        Me.REG65.Name = "REG65"
        Me.REG65.Size = New System.Drawing.Size(26, 26)
        Me.REG65.TabIndex = 0
        Me.REG65.Text = "00"
        Me.REG65.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG6C
        '
        Me.REG6C.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG6C.Location = New System.Drawing.Point(418, 193)
        Me.REG6C.MaxLength = 2
        Me.REG6C.Name = "REG6C"
        Me.REG6C.Size = New System.Drawing.Size(26, 26)
        Me.REG6C.TabIndex = 0
        Me.REG6C.Text = "00"
        Me.REG6C.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG64
        '
        Me.REG64.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG64.Location = New System.Drawing.Point(173, 193)
        Me.REG64.MaxLength = 2
        Me.REG64.Name = "REG64"
        Me.REG64.Size = New System.Drawing.Size(26, 26)
        Me.REG64.TabIndex = 0
        Me.REG64.Text = "00"
        Me.REG64.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG6B
        '
        Me.REG6B.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG6B.Location = New System.Drawing.Point(388, 193)
        Me.REG6B.MaxLength = 2
        Me.REG6B.Name = "REG6B"
        Me.REG6B.Size = New System.Drawing.Size(26, 26)
        Me.REG6B.TabIndex = 0
        Me.REG6B.Text = "00"
        Me.REG6B.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG63
        '
        Me.REG63.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG63.Location = New System.Drawing.Point(143, 193)
        Me.REG63.MaxLength = 2
        Me.REG63.Name = "REG63"
        Me.REG63.Size = New System.Drawing.Size(26, 26)
        Me.REG63.TabIndex = 0
        Me.REG63.Text = "00"
        Me.REG63.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG6A
        '
        Me.REG6A.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG6A.Location = New System.Drawing.Point(358, 193)
        Me.REG6A.MaxLength = 2
        Me.REG6A.Name = "REG6A"
        Me.REG6A.Size = New System.Drawing.Size(26, 26)
        Me.REG6A.TabIndex = 0
        Me.REG6A.Text = "00"
        Me.REG6A.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG62
        '
        Me.REG62.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG62.Location = New System.Drawing.Point(113, 193)
        Me.REG62.MaxLength = 2
        Me.REG62.Name = "REG62"
        Me.REG62.Size = New System.Drawing.Size(26, 26)
        Me.REG62.TabIndex = 0
        Me.REG62.Text = "00"
        Me.REG62.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG69
        '
        Me.REG69.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG69.Location = New System.Drawing.Point(327, 193)
        Me.REG69.MaxLength = 2
        Me.REG69.Name = "REG69"
        Me.REG69.Size = New System.Drawing.Size(26, 26)
        Me.REG69.TabIndex = 0
        Me.REG69.Text = "00"
        Me.REG69.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG61
        '
        Me.REG61.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG61.Location = New System.Drawing.Point(82, 193)
        Me.REG61.MaxLength = 2
        Me.REG61.Name = "REG61"
        Me.REG61.Size = New System.Drawing.Size(26, 26)
        Me.REG61.TabIndex = 0
        Me.REG61.Text = "00"
        Me.REG61.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG68
        '
        Me.REG68.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG68.Location = New System.Drawing.Point(297, 193)
        Me.REG68.MaxLength = 2
        Me.REG68.Name = "REG68"
        Me.REG68.Size = New System.Drawing.Size(26, 26)
        Me.REG68.TabIndex = 0
        Me.REG68.Text = "00"
        Me.REG68.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG60
        '
        Me.REG60.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG60.Location = New System.Drawing.Point(52, 193)
        Me.REG60.MaxLength = 2
        Me.REG60.Name = "REG60"
        Me.REG60.Size = New System.Drawing.Size(26, 26)
        Me.REG60.TabIndex = 0
        Me.REG60.Text = "00"
        Me.REG60.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox42
        '
        Me.TextBox42.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox42.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox42.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox42.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox42.Location = New System.Drawing.Point(21, 169)
        Me.TextBox42.Name = "TextBox42"
        Me.TextBox42.Size = New System.Drawing.Size(25, 19)
        Me.TextBox42.TabIndex = 0
        Me.TextBox42.Text = "50"
        Me.TextBox42.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG5F
        '
        Me.REG5F.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG5F.Location = New System.Drawing.Point(508, 166)
        Me.REG5F.MaxLength = 2
        Me.REG5F.Name = "REG5F"
        Me.REG5F.Size = New System.Drawing.Size(26, 26)
        Me.REG5F.TabIndex = 0
        Me.REG5F.Text = "00"
        Me.REG5F.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG57
        '
        Me.REG57.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG57.Location = New System.Drawing.Point(263, 166)
        Me.REG57.MaxLength = 2
        Me.REG57.Name = "REG57"
        Me.REG57.Size = New System.Drawing.Size(26, 26)
        Me.REG57.TabIndex = 0
        Me.REG57.Text = "00"
        Me.REG57.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG5E
        '
        Me.REG5E.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG5E.Location = New System.Drawing.Point(478, 166)
        Me.REG5E.MaxLength = 2
        Me.REG5E.Name = "REG5E"
        Me.REG5E.Size = New System.Drawing.Size(26, 26)
        Me.REG5E.TabIndex = 0
        Me.REG5E.Text = "00"
        Me.REG5E.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG56
        '
        Me.REG56.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG56.Location = New System.Drawing.Point(233, 166)
        Me.REG56.MaxLength = 2
        Me.REG56.Name = "REG56"
        Me.REG56.Size = New System.Drawing.Size(26, 26)
        Me.REG56.TabIndex = 0
        Me.REG56.Text = "00"
        Me.REG56.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG5D
        '
        Me.REG5D.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG5D.Location = New System.Drawing.Point(448, 166)
        Me.REG5D.MaxLength = 2
        Me.REG5D.Name = "REG5D"
        Me.REG5D.Size = New System.Drawing.Size(26, 26)
        Me.REG5D.TabIndex = 0
        Me.REG5D.Text = "00"
        Me.REG5D.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG55
        '
        Me.REG55.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG55.Location = New System.Drawing.Point(203, 166)
        Me.REG55.MaxLength = 2
        Me.REG55.Name = "REG55"
        Me.REG55.Size = New System.Drawing.Size(26, 26)
        Me.REG55.TabIndex = 0
        Me.REG55.Text = "00"
        Me.REG55.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG5C
        '
        Me.REG5C.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG5C.Location = New System.Drawing.Point(418, 166)
        Me.REG5C.MaxLength = 2
        Me.REG5C.Name = "REG5C"
        Me.REG5C.Size = New System.Drawing.Size(26, 26)
        Me.REG5C.TabIndex = 0
        Me.REG5C.Text = "00"
        Me.REG5C.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG54
        '
        Me.REG54.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG54.Location = New System.Drawing.Point(173, 166)
        Me.REG54.MaxLength = 2
        Me.REG54.Name = "REG54"
        Me.REG54.Size = New System.Drawing.Size(26, 26)
        Me.REG54.TabIndex = 0
        Me.REG54.Text = "00"
        Me.REG54.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG5B
        '
        Me.REG5B.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG5B.Location = New System.Drawing.Point(388, 166)
        Me.REG5B.MaxLength = 2
        Me.REG5B.Name = "REG5B"
        Me.REG5B.Size = New System.Drawing.Size(26, 26)
        Me.REG5B.TabIndex = 0
        Me.REG5B.Text = "00"
        Me.REG5B.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG53
        '
        Me.REG53.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG53.Location = New System.Drawing.Point(143, 166)
        Me.REG53.MaxLength = 2
        Me.REG53.Name = "REG53"
        Me.REG53.Size = New System.Drawing.Size(26, 26)
        Me.REG53.TabIndex = 0
        Me.REG53.Text = "00"
        Me.REG53.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG5A
        '
        Me.REG5A.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG5A.Location = New System.Drawing.Point(358, 166)
        Me.REG5A.MaxLength = 2
        Me.REG5A.Name = "REG5A"
        Me.REG5A.Size = New System.Drawing.Size(26, 26)
        Me.REG5A.TabIndex = 0
        Me.REG5A.Text = "00"
        Me.REG5A.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG52
        '
        Me.REG52.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG52.Location = New System.Drawing.Point(113, 166)
        Me.REG52.MaxLength = 2
        Me.REG52.Name = "REG52"
        Me.REG52.Size = New System.Drawing.Size(26, 26)
        Me.REG52.TabIndex = 0
        Me.REG52.Text = "00"
        Me.REG52.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG59
        '
        Me.REG59.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG59.Location = New System.Drawing.Point(327, 166)
        Me.REG59.MaxLength = 2
        Me.REG59.Name = "REG59"
        Me.REG59.Size = New System.Drawing.Size(26, 26)
        Me.REG59.TabIndex = 0
        Me.REG59.Text = "00"
        Me.REG59.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG51
        '
        Me.REG51.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG51.Location = New System.Drawing.Point(82, 166)
        Me.REG51.MaxLength = 2
        Me.REG51.Name = "REG51"
        Me.REG51.Size = New System.Drawing.Size(26, 26)
        Me.REG51.TabIndex = 0
        Me.REG51.Text = "00"
        Me.REG51.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG58
        '
        Me.REG58.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG58.Location = New System.Drawing.Point(297, 166)
        Me.REG58.MaxLength = 2
        Me.REG58.Name = "REG58"
        Me.REG58.Size = New System.Drawing.Size(26, 26)
        Me.REG58.TabIndex = 0
        Me.REG58.Text = "00"
        Me.REG58.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG50
        '
        Me.REG50.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG50.Location = New System.Drawing.Point(52, 166)
        Me.REG50.MaxLength = 2
        Me.REG50.Name = "REG50"
        Me.REG50.Size = New System.Drawing.Size(26, 26)
        Me.REG50.TabIndex = 0
        Me.REG50.Text = "00"
        Me.REG50.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox41
        '
        Me.TextBox41.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox41.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox41.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox41.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox41.Location = New System.Drawing.Point(21, 142)
        Me.TextBox41.Name = "TextBox41"
        Me.TextBox41.Size = New System.Drawing.Size(25, 19)
        Me.TextBox41.TabIndex = 0
        Me.TextBox41.Text = "40"
        Me.TextBox41.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG4F
        '
        Me.REG4F.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG4F.Location = New System.Drawing.Point(508, 139)
        Me.REG4F.MaxLength = 2
        Me.REG4F.Name = "REG4F"
        Me.REG4F.Size = New System.Drawing.Size(26, 26)
        Me.REG4F.TabIndex = 0
        Me.REG4F.Text = "00"
        Me.REG4F.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG47
        '
        Me.REG47.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG47.Location = New System.Drawing.Point(263, 139)
        Me.REG47.MaxLength = 2
        Me.REG47.Name = "REG47"
        Me.REG47.Size = New System.Drawing.Size(26, 26)
        Me.REG47.TabIndex = 0
        Me.REG47.Text = "00"
        Me.REG47.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG4E
        '
        Me.REG4E.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG4E.Location = New System.Drawing.Point(478, 139)
        Me.REG4E.MaxLength = 2
        Me.REG4E.Name = "REG4E"
        Me.REG4E.Size = New System.Drawing.Size(26, 26)
        Me.REG4E.TabIndex = 0
        Me.REG4E.Text = "00"
        Me.REG4E.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG46
        '
        Me.REG46.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG46.Location = New System.Drawing.Point(233, 139)
        Me.REG46.MaxLength = 2
        Me.REG46.Name = "REG46"
        Me.REG46.Size = New System.Drawing.Size(26, 26)
        Me.REG46.TabIndex = 0
        Me.REG46.Text = "00"
        Me.REG46.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG4D
        '
        Me.REG4D.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG4D.Location = New System.Drawing.Point(448, 139)
        Me.REG4D.MaxLength = 2
        Me.REG4D.Name = "REG4D"
        Me.REG4D.Size = New System.Drawing.Size(26, 26)
        Me.REG4D.TabIndex = 0
        Me.REG4D.Text = "00"
        Me.REG4D.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG45
        '
        Me.REG45.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG45.Location = New System.Drawing.Point(203, 139)
        Me.REG45.MaxLength = 2
        Me.REG45.Name = "REG45"
        Me.REG45.Size = New System.Drawing.Size(26, 26)
        Me.REG45.TabIndex = 0
        Me.REG45.Text = "00"
        Me.REG45.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG4C
        '
        Me.REG4C.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG4C.Location = New System.Drawing.Point(418, 139)
        Me.REG4C.MaxLength = 2
        Me.REG4C.Name = "REG4C"
        Me.REG4C.Size = New System.Drawing.Size(26, 26)
        Me.REG4C.TabIndex = 0
        Me.REG4C.Text = "00"
        Me.REG4C.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG44
        '
        Me.REG44.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG44.Location = New System.Drawing.Point(173, 139)
        Me.REG44.MaxLength = 2
        Me.REG44.Name = "REG44"
        Me.REG44.Size = New System.Drawing.Size(26, 26)
        Me.REG44.TabIndex = 0
        Me.REG44.Text = "00"
        Me.REG44.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG4B
        '
        Me.REG4B.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG4B.Location = New System.Drawing.Point(388, 139)
        Me.REG4B.MaxLength = 2
        Me.REG4B.Name = "REG4B"
        Me.REG4B.Size = New System.Drawing.Size(26, 26)
        Me.REG4B.TabIndex = 0
        Me.REG4B.Text = "00"
        Me.REG4B.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG43
        '
        Me.REG43.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG43.Location = New System.Drawing.Point(143, 139)
        Me.REG43.MaxLength = 2
        Me.REG43.Name = "REG43"
        Me.REG43.Size = New System.Drawing.Size(26, 26)
        Me.REG43.TabIndex = 0
        Me.REG43.Text = "00"
        Me.REG43.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG4A
        '
        Me.REG4A.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG4A.Location = New System.Drawing.Point(358, 139)
        Me.REG4A.MaxLength = 2
        Me.REG4A.Name = "REG4A"
        Me.REG4A.Size = New System.Drawing.Size(26, 26)
        Me.REG4A.TabIndex = 0
        Me.REG4A.Text = "00"
        Me.REG4A.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG42
        '
        Me.REG42.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG42.Location = New System.Drawing.Point(113, 139)
        Me.REG42.MaxLength = 2
        Me.REG42.Name = "REG42"
        Me.REG42.Size = New System.Drawing.Size(26, 26)
        Me.REG42.TabIndex = 0
        Me.REG42.Text = "00"
        Me.REG42.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG49
        '
        Me.REG49.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG49.Location = New System.Drawing.Point(327, 139)
        Me.REG49.MaxLength = 2
        Me.REG49.Name = "REG49"
        Me.REG49.Size = New System.Drawing.Size(26, 26)
        Me.REG49.TabIndex = 0
        Me.REG49.Text = "00"
        Me.REG49.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG41
        '
        Me.REG41.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG41.Location = New System.Drawing.Point(82, 139)
        Me.REG41.MaxLength = 2
        Me.REG41.Name = "REG41"
        Me.REG41.Size = New System.Drawing.Size(26, 26)
        Me.REG41.TabIndex = 0
        Me.REG41.Text = "00"
        Me.REG41.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG48
        '
        Me.REG48.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG48.Location = New System.Drawing.Point(297, 139)
        Me.REG48.MaxLength = 2
        Me.REG48.Name = "REG48"
        Me.REG48.Size = New System.Drawing.Size(26, 26)
        Me.REG48.TabIndex = 0
        Me.REG48.Text = "00"
        Me.REG48.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG40
        '
        Me.REG40.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG40.Location = New System.Drawing.Point(52, 139)
        Me.REG40.MaxLength = 2
        Me.REG40.Name = "REG40"
        Me.REG40.Size = New System.Drawing.Size(26, 26)
        Me.REG40.TabIndex = 0
        Me.REG40.Text = "00"
        Me.REG40.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox40
        '
        Me.TextBox40.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox40.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox40.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox40.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox40.Location = New System.Drawing.Point(21, 115)
        Me.TextBox40.Name = "TextBox40"
        Me.TextBox40.Size = New System.Drawing.Size(25, 19)
        Me.TextBox40.TabIndex = 0
        Me.TextBox40.Text = "30"
        Me.TextBox40.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG3F
        '
        Me.REG3F.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG3F.Location = New System.Drawing.Point(508, 112)
        Me.REG3F.MaxLength = 2
        Me.REG3F.Name = "REG3F"
        Me.REG3F.Size = New System.Drawing.Size(26, 26)
        Me.REG3F.TabIndex = 0
        Me.REG3F.Text = "00"
        Me.REG3F.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG37
        '
        Me.REG37.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG37.Location = New System.Drawing.Point(263, 112)
        Me.REG37.MaxLength = 2
        Me.REG37.Name = "REG37"
        Me.REG37.Size = New System.Drawing.Size(26, 26)
        Me.REG37.TabIndex = 0
        Me.REG37.Text = "00"
        Me.REG37.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG3E
        '
        Me.REG3E.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG3E.Location = New System.Drawing.Point(478, 112)
        Me.REG3E.MaxLength = 2
        Me.REG3E.Name = "REG3E"
        Me.REG3E.Size = New System.Drawing.Size(26, 26)
        Me.REG3E.TabIndex = 0
        Me.REG3E.Text = "00"
        Me.REG3E.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG36
        '
        Me.REG36.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG36.Location = New System.Drawing.Point(233, 112)
        Me.REG36.MaxLength = 2
        Me.REG36.Name = "REG36"
        Me.REG36.Size = New System.Drawing.Size(26, 26)
        Me.REG36.TabIndex = 0
        Me.REG36.Text = "00"
        Me.REG36.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG3D
        '
        Me.REG3D.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG3D.Location = New System.Drawing.Point(448, 112)
        Me.REG3D.MaxLength = 2
        Me.REG3D.Name = "REG3D"
        Me.REG3D.Size = New System.Drawing.Size(26, 26)
        Me.REG3D.TabIndex = 0
        Me.REG3D.Text = "00"
        Me.REG3D.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG35
        '
        Me.REG35.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG35.Location = New System.Drawing.Point(203, 112)
        Me.REG35.MaxLength = 2
        Me.REG35.Name = "REG35"
        Me.REG35.Size = New System.Drawing.Size(26, 26)
        Me.REG35.TabIndex = 0
        Me.REG35.Text = "00"
        Me.REG35.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG3C
        '
        Me.REG3C.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG3C.Location = New System.Drawing.Point(418, 112)
        Me.REG3C.MaxLength = 2
        Me.REG3C.Name = "REG3C"
        Me.REG3C.Size = New System.Drawing.Size(26, 26)
        Me.REG3C.TabIndex = 0
        Me.REG3C.Text = "00"
        Me.REG3C.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG34
        '
        Me.REG34.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG34.Location = New System.Drawing.Point(173, 112)
        Me.REG34.MaxLength = 2
        Me.REG34.Name = "REG34"
        Me.REG34.Size = New System.Drawing.Size(26, 26)
        Me.REG34.TabIndex = 0
        Me.REG34.Text = "00"
        Me.REG34.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG3B
        '
        Me.REG3B.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG3B.Location = New System.Drawing.Point(388, 112)
        Me.REG3B.MaxLength = 2
        Me.REG3B.Name = "REG3B"
        Me.REG3B.Size = New System.Drawing.Size(26, 26)
        Me.REG3B.TabIndex = 0
        Me.REG3B.Text = "00"
        Me.REG3B.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG33
        '
        Me.REG33.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG33.Location = New System.Drawing.Point(143, 112)
        Me.REG33.MaxLength = 2
        Me.REG33.Name = "REG33"
        Me.REG33.Size = New System.Drawing.Size(26, 26)
        Me.REG33.TabIndex = 0
        Me.REG33.Text = "00"
        Me.REG33.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG3A
        '
        Me.REG3A.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG3A.Location = New System.Drawing.Point(358, 112)
        Me.REG3A.MaxLength = 2
        Me.REG3A.Name = "REG3A"
        Me.REG3A.Size = New System.Drawing.Size(26, 26)
        Me.REG3A.TabIndex = 0
        Me.REG3A.Text = "00"
        Me.REG3A.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG32
        '
        Me.REG32.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG32.Location = New System.Drawing.Point(113, 112)
        Me.REG32.MaxLength = 2
        Me.REG32.Name = "REG32"
        Me.REG32.Size = New System.Drawing.Size(26, 26)
        Me.REG32.TabIndex = 0
        Me.REG32.Text = "00"
        Me.REG32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG39
        '
        Me.REG39.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG39.Location = New System.Drawing.Point(327, 112)
        Me.REG39.MaxLength = 2
        Me.REG39.Name = "REG39"
        Me.REG39.Size = New System.Drawing.Size(26, 26)
        Me.REG39.TabIndex = 0
        Me.REG39.Text = "00"
        Me.REG39.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG31
        '
        Me.REG31.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG31.Location = New System.Drawing.Point(82, 112)
        Me.REG31.MaxLength = 2
        Me.REG31.Name = "REG31"
        Me.REG31.Size = New System.Drawing.Size(26, 26)
        Me.REG31.TabIndex = 0
        Me.REG31.Text = "00"
        Me.REG31.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG38
        '
        Me.REG38.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG38.Location = New System.Drawing.Point(297, 112)
        Me.REG38.MaxLength = 2
        Me.REG38.Name = "REG38"
        Me.REG38.Size = New System.Drawing.Size(26, 26)
        Me.REG38.TabIndex = 0
        Me.REG38.Text = "00"
        Me.REG38.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG30
        '
        Me.REG30.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG30.Location = New System.Drawing.Point(52, 112)
        Me.REG30.MaxLength = 2
        Me.REG30.Name = "REG30"
        Me.REG30.Size = New System.Drawing.Size(26, 26)
        Me.REG30.TabIndex = 0
        Me.REG30.Text = "00"
        Me.REG30.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox39
        '
        Me.TextBox39.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox39.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox39.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox39.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox39.Location = New System.Drawing.Point(21, 88)
        Me.TextBox39.Name = "TextBox39"
        Me.TextBox39.Size = New System.Drawing.Size(25, 19)
        Me.TextBox39.TabIndex = 0
        Me.TextBox39.Text = "20"
        Me.TextBox39.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG2F
        '
        Me.REG2F.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG2F.Location = New System.Drawing.Point(508, 85)
        Me.REG2F.MaxLength = 2
        Me.REG2F.Name = "REG2F"
        Me.REG2F.Size = New System.Drawing.Size(26, 26)
        Me.REG2F.TabIndex = 0
        Me.REG2F.Text = "00"
        Me.REG2F.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG27
        '
        Me.REG27.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG27.Location = New System.Drawing.Point(263, 85)
        Me.REG27.MaxLength = 2
        Me.REG27.Name = "REG27"
        Me.REG27.Size = New System.Drawing.Size(26, 26)
        Me.REG27.TabIndex = 0
        Me.REG27.Text = "00"
        Me.REG27.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG2E
        '
        Me.REG2E.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG2E.Location = New System.Drawing.Point(478, 85)
        Me.REG2E.MaxLength = 2
        Me.REG2E.Name = "REG2E"
        Me.REG2E.Size = New System.Drawing.Size(26, 26)
        Me.REG2E.TabIndex = 0
        Me.REG2E.Text = "00"
        Me.REG2E.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG26
        '
        Me.REG26.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG26.Location = New System.Drawing.Point(233, 85)
        Me.REG26.MaxLength = 2
        Me.REG26.Name = "REG26"
        Me.REG26.Size = New System.Drawing.Size(26, 26)
        Me.REG26.TabIndex = 0
        Me.REG26.Text = "00"
        Me.REG26.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG2D
        '
        Me.REG2D.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG2D.Location = New System.Drawing.Point(448, 85)
        Me.REG2D.MaxLength = 2
        Me.REG2D.Name = "REG2D"
        Me.REG2D.Size = New System.Drawing.Size(26, 26)
        Me.REG2D.TabIndex = 0
        Me.REG2D.Text = "00"
        Me.REG2D.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG25
        '
        Me.REG25.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG25.Location = New System.Drawing.Point(203, 85)
        Me.REG25.MaxLength = 2
        Me.REG25.Name = "REG25"
        Me.REG25.Size = New System.Drawing.Size(26, 26)
        Me.REG25.TabIndex = 0
        Me.REG25.Text = "00"
        Me.REG25.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG2C
        '
        Me.REG2C.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG2C.Location = New System.Drawing.Point(418, 85)
        Me.REG2C.MaxLength = 2
        Me.REG2C.Name = "REG2C"
        Me.REG2C.Size = New System.Drawing.Size(26, 26)
        Me.REG2C.TabIndex = 0
        Me.REG2C.Text = "00"
        Me.REG2C.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG24
        '
        Me.REG24.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG24.Location = New System.Drawing.Point(173, 85)
        Me.REG24.MaxLength = 2
        Me.REG24.Name = "REG24"
        Me.REG24.Size = New System.Drawing.Size(26, 26)
        Me.REG24.TabIndex = 0
        Me.REG24.Text = "00"
        Me.REG24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG2B
        '
        Me.REG2B.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG2B.Location = New System.Drawing.Point(388, 85)
        Me.REG2B.MaxLength = 2
        Me.REG2B.Name = "REG2B"
        Me.REG2B.Size = New System.Drawing.Size(26, 26)
        Me.REG2B.TabIndex = 0
        Me.REG2B.Text = "00"
        Me.REG2B.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG23
        '
        Me.REG23.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG23.Location = New System.Drawing.Point(143, 85)
        Me.REG23.MaxLength = 2
        Me.REG23.Name = "REG23"
        Me.REG23.Size = New System.Drawing.Size(26, 26)
        Me.REG23.TabIndex = 0
        Me.REG23.Text = "00"
        Me.REG23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG2A
        '
        Me.REG2A.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG2A.Location = New System.Drawing.Point(358, 85)
        Me.REG2A.MaxLength = 2
        Me.REG2A.Name = "REG2A"
        Me.REG2A.Size = New System.Drawing.Size(26, 26)
        Me.REG2A.TabIndex = 0
        Me.REG2A.Text = "00"
        Me.REG2A.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG22
        '
        Me.REG22.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG22.Location = New System.Drawing.Point(113, 85)
        Me.REG22.MaxLength = 2
        Me.REG22.Name = "REG22"
        Me.REG22.Size = New System.Drawing.Size(26, 26)
        Me.REG22.TabIndex = 0
        Me.REG22.Text = "00"
        Me.REG22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG29
        '
        Me.REG29.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG29.Location = New System.Drawing.Point(327, 85)
        Me.REG29.MaxLength = 2
        Me.REG29.Name = "REG29"
        Me.REG29.Size = New System.Drawing.Size(26, 26)
        Me.REG29.TabIndex = 0
        Me.REG29.Text = "00"
        Me.REG29.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG21
        '
        Me.REG21.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG21.Location = New System.Drawing.Point(82, 85)
        Me.REG21.MaxLength = 2
        Me.REG21.Name = "REG21"
        Me.REG21.Size = New System.Drawing.Size(26, 26)
        Me.REG21.TabIndex = 0
        Me.REG21.Text = "00"
        Me.REG21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG28
        '
        Me.REG28.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG28.Location = New System.Drawing.Point(297, 85)
        Me.REG28.MaxLength = 2
        Me.REG28.Name = "REG28"
        Me.REG28.Size = New System.Drawing.Size(26, 26)
        Me.REG28.TabIndex = 0
        Me.REG28.Text = "00"
        Me.REG28.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG20
        '
        Me.REG20.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG20.Location = New System.Drawing.Point(52, 85)
        Me.REG20.MaxLength = 2
        Me.REG20.Name = "REG20"
        Me.REG20.Size = New System.Drawing.Size(26, 26)
        Me.REG20.TabIndex = 0
        Me.REG20.Text = "00"
        Me.REG20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox38
        '
        Me.TextBox38.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox38.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox38.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox38.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox38.Location = New System.Drawing.Point(21, 61)
        Me.TextBox38.Name = "TextBox38"
        Me.TextBox38.Size = New System.Drawing.Size(25, 19)
        Me.TextBox38.TabIndex = 0
        Me.TextBox38.Text = "10"
        Me.TextBox38.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG1F
        '
        Me.REG1F.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG1F.Location = New System.Drawing.Point(508, 58)
        Me.REG1F.MaxLength = 2
        Me.REG1F.Name = "REG1F"
        Me.REG1F.Size = New System.Drawing.Size(26, 26)
        Me.REG1F.TabIndex = 0
        Me.REG1F.Text = "00"
        Me.REG1F.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG17
        '
        Me.REG17.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG17.Location = New System.Drawing.Point(263, 58)
        Me.REG17.MaxLength = 2
        Me.REG17.Name = "REG17"
        Me.REG17.Size = New System.Drawing.Size(26, 26)
        Me.REG17.TabIndex = 0
        Me.REG17.Text = "00"
        Me.REG17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG1E
        '
        Me.REG1E.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG1E.Location = New System.Drawing.Point(478, 58)
        Me.REG1E.MaxLength = 2
        Me.REG1E.Name = "REG1E"
        Me.REG1E.Size = New System.Drawing.Size(26, 26)
        Me.REG1E.TabIndex = 0
        Me.REG1E.Text = "00"
        Me.REG1E.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG16
        '
        Me.REG16.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG16.Location = New System.Drawing.Point(233, 58)
        Me.REG16.MaxLength = 2
        Me.REG16.Name = "REG16"
        Me.REG16.Size = New System.Drawing.Size(26, 26)
        Me.REG16.TabIndex = 0
        Me.REG16.Text = "00"
        Me.REG16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG1D
        '
        Me.REG1D.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG1D.Location = New System.Drawing.Point(448, 58)
        Me.REG1D.MaxLength = 2
        Me.REG1D.Name = "REG1D"
        Me.REG1D.Size = New System.Drawing.Size(26, 26)
        Me.REG1D.TabIndex = 0
        Me.REG1D.Text = "00"
        Me.REG1D.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG15
        '
        Me.REG15.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG15.Location = New System.Drawing.Point(203, 58)
        Me.REG15.MaxLength = 2
        Me.REG15.Name = "REG15"
        Me.REG15.Size = New System.Drawing.Size(26, 26)
        Me.REG15.TabIndex = 0
        Me.REG15.Text = "00"
        Me.REG15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG1C
        '
        Me.REG1C.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG1C.Location = New System.Drawing.Point(418, 58)
        Me.REG1C.MaxLength = 2
        Me.REG1C.Name = "REG1C"
        Me.REG1C.Size = New System.Drawing.Size(26, 26)
        Me.REG1C.TabIndex = 0
        Me.REG1C.Text = "00"
        Me.REG1C.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG14
        '
        Me.REG14.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG14.Location = New System.Drawing.Point(173, 58)
        Me.REG14.MaxLength = 2
        Me.REG14.Name = "REG14"
        Me.REG14.Size = New System.Drawing.Size(26, 26)
        Me.REG14.TabIndex = 0
        Me.REG14.Text = "00"
        Me.REG14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG1B
        '
        Me.REG1B.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG1B.Location = New System.Drawing.Point(388, 58)
        Me.REG1B.MaxLength = 2
        Me.REG1B.Name = "REG1B"
        Me.REG1B.Size = New System.Drawing.Size(26, 26)
        Me.REG1B.TabIndex = 0
        Me.REG1B.Text = "00"
        Me.REG1B.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG13
        '
        Me.REG13.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG13.Location = New System.Drawing.Point(143, 58)
        Me.REG13.MaxLength = 2
        Me.REG13.Name = "REG13"
        Me.REG13.Size = New System.Drawing.Size(26, 26)
        Me.REG13.TabIndex = 0
        Me.REG13.Text = "00"
        Me.REG13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG1A
        '
        Me.REG1A.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG1A.Location = New System.Drawing.Point(358, 58)
        Me.REG1A.MaxLength = 2
        Me.REG1A.Name = "REG1A"
        Me.REG1A.Size = New System.Drawing.Size(26, 26)
        Me.REG1A.TabIndex = 0
        Me.REG1A.Text = "00"
        Me.REG1A.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG12
        '
        Me.REG12.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG12.Location = New System.Drawing.Point(113, 58)
        Me.REG12.MaxLength = 2
        Me.REG12.Name = "REG12"
        Me.REG12.Size = New System.Drawing.Size(26, 26)
        Me.REG12.TabIndex = 0
        Me.REG12.Text = "00"
        Me.REG12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG19
        '
        Me.REG19.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG19.Location = New System.Drawing.Point(327, 58)
        Me.REG19.MaxLength = 2
        Me.REG19.Name = "REG19"
        Me.REG19.Size = New System.Drawing.Size(26, 26)
        Me.REG19.TabIndex = 0
        Me.REG19.Text = "00"
        Me.REG19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG11
        '
        Me.REG11.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG11.Location = New System.Drawing.Point(82, 58)
        Me.REG11.MaxLength = 2
        Me.REG11.Name = "REG11"
        Me.REG11.Size = New System.Drawing.Size(26, 26)
        Me.REG11.TabIndex = 0
        Me.REG11.Text = "00"
        Me.REG11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG18
        '
        Me.REG18.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG18.Location = New System.Drawing.Point(297, 58)
        Me.REG18.MaxLength = 2
        Me.REG18.Name = "REG18"
        Me.REG18.Size = New System.Drawing.Size(26, 26)
        Me.REG18.TabIndex = 0
        Me.REG18.Text = "00"
        Me.REG18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG10
        '
        Me.REG10.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG10.Location = New System.Drawing.Point(52, 58)
        Me.REG10.MaxLength = 2
        Me.REG10.Name = "REG10"
        Me.REG10.Size = New System.Drawing.Size(26, 26)
        Me.REG10.TabIndex = 0
        Me.REG10.Text = "00"
        Me.REG10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox21
        '
        Me.TextBox21.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox21.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox21.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox21.Location = New System.Drawing.Point(52, 6)
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New System.Drawing.Size(25, 19)
        Me.TextBox21.TabIndex = 0
        Me.TextBox21.Text = "00"
        Me.TextBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox37
        '
        Me.TextBox37.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox37.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox37.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox37.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox37.Location = New System.Drawing.Point(21, 34)
        Me.TextBox37.Name = "TextBox37"
        Me.TextBox37.Size = New System.Drawing.Size(25, 19)
        Me.TextBox37.TabIndex = 0
        Me.TextBox37.Text = "00"
        Me.TextBox37.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG00
        '
        Me.REG00.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG00.Location = New System.Drawing.Point(52, 31)
        Me.REG00.MaxLength = 2
        Me.REG00.Name = "REG00"
        Me.REG00.Size = New System.Drawing.Size(26, 26)
        Me.REG00.TabIndex = 0
        Me.REG00.Text = "00"
        Me.REG00.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Timer5
        '
        Me.Timer5.Interval = 1000
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 675)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnGroupBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbBaud)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmbPort)
        Me.Controls.Add(Me.btnDisconnect)
        Me.Controls.Add(Me.btnConnect)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.Text = "ML076Q TEST TOOL"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.btnREGGroup.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnConnect As System.Windows.Forms.Button
    Friend WithEvents btnDisconnect As System.Windows.Forms.Button
    Friend WithEvents cmbPort As System.Windows.Forms.ComboBox
    Friend WithEvents cmbBaud As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents txtTransmit As System.Windows.Forms.TextBox
    Friend WithEvents rtbReceived As System.Windows.Forms.RichTextBox
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DEBUGTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents btnGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents btnMCUREV As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox5 As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents REG00 As System.Windows.Forms.TextBox
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents REG0F As System.Windows.Forms.TextBox
    Friend WithEvents REG07 As System.Windows.Forms.TextBox
    Friend WithEvents REG0E As System.Windows.Forms.TextBox
    Friend WithEvents REG06 As System.Windows.Forms.TextBox
    Friend WithEvents REG0D As System.Windows.Forms.TextBox
    Friend WithEvents REG05 As System.Windows.Forms.TextBox
    Friend WithEvents REG0C As System.Windows.Forms.TextBox
    Friend WithEvents REG04 As System.Windows.Forms.TextBox
    Friend WithEvents REG0B As System.Windows.Forms.TextBox
    Friend WithEvents REG03 As System.Windows.Forms.TextBox
    Friend WithEvents REG0A As System.Windows.Forms.TextBox
    Friend WithEvents REG02 As System.Windows.Forms.TextBox
    Friend WithEvents REG09 As System.Windows.Forms.TextBox
    Friend WithEvents REG01 As System.Windows.Forms.TextBox
    Friend WithEvents REG08 As System.Windows.Forms.TextBox
    Friend WithEvents Timer4 As System.Windows.Forms.Timer
    Friend WithEvents Button15 As System.Windows.Forms.Button
    Friend WithEvents REG30 As System.Windows.Forms.TextBox
    Friend WithEvents REG20 As System.Windows.Forms.TextBox
    Friend WithEvents REG10 As System.Windows.Forms.TextBox
    Friend WithEvents REGB0 As System.Windows.Forms.TextBox
    Friend WithEvents REGA0 As System.Windows.Forms.TextBox
    Friend WithEvents REG90 As System.Windows.Forms.TextBox
    Friend WithEvents REG80 As System.Windows.Forms.TextBox
    Friend WithEvents REG70 As System.Windows.Forms.TextBox
    Friend WithEvents REG60 As System.Windows.Forms.TextBox
    Friend WithEvents REG50 As System.Windows.Forms.TextBox
    Friend WithEvents REG40 As System.Windows.Forms.TextBox
    Friend WithEvents REGD0 As System.Windows.Forms.TextBox
    Friend WithEvents REGC0 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox36 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox35 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox34 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox33 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox32 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox31 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox30 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox29 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox28 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox27 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox26 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox25 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox24 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox23 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox22 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox52 As System.Windows.Forms.TextBox
    Friend WithEvents REGF0 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox51 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox50 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox49 As System.Windows.Forms.TextBox
    Friend WithEvents REGE0 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox48 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox47 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox46 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox45 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox44 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox43 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox42 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox41 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox40 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox39 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox38 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox21 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox37 As System.Windows.Forms.TextBox
    Friend WithEvents REGFF As System.Windows.Forms.TextBox
    Friend WithEvents REGF7 As System.Windows.Forms.TextBox
    Friend WithEvents REGFE As System.Windows.Forms.TextBox
    Friend WithEvents REGF6 As System.Windows.Forms.TextBox
    Friend WithEvents REGFD As System.Windows.Forms.TextBox
    Friend WithEvents REGF5 As System.Windows.Forms.TextBox
    Friend WithEvents REGFC As System.Windows.Forms.TextBox
    Friend WithEvents REGF4 As System.Windows.Forms.TextBox
    Friend WithEvents REGFB As System.Windows.Forms.TextBox
    Friend WithEvents REGF3 As System.Windows.Forms.TextBox
    Friend WithEvents REGFA As System.Windows.Forms.TextBox
    Friend WithEvents REGF2 As System.Windows.Forms.TextBox
    Friend WithEvents REGF9 As System.Windows.Forms.TextBox
    Friend WithEvents REGF1 As System.Windows.Forms.TextBox
    Friend WithEvents REGF8 As System.Windows.Forms.TextBox
    Friend WithEvents REGDF As System.Windows.Forms.TextBox
    Friend WithEvents REGD7 As System.Windows.Forms.TextBox
    Friend WithEvents REGDE As System.Windows.Forms.TextBox
    Friend WithEvents REGD6 As System.Windows.Forms.TextBox
    Friend WithEvents REGDD As System.Windows.Forms.TextBox
    Friend WithEvents REGD5 As System.Windows.Forms.TextBox
    Friend WithEvents REGDC As System.Windows.Forms.TextBox
    Friend WithEvents REGD4 As System.Windows.Forms.TextBox
    Friend WithEvents REGDB As System.Windows.Forms.TextBox
    Friend WithEvents REGD3 As System.Windows.Forms.TextBox
    Friend WithEvents REGDA As System.Windows.Forms.TextBox
    Friend WithEvents REGD2 As System.Windows.Forms.TextBox
    Friend WithEvents REGD9 As System.Windows.Forms.TextBox
    Friend WithEvents REGD1 As System.Windows.Forms.TextBox
    Friend WithEvents REGD8 As System.Windows.Forms.TextBox
    Friend WithEvents REGBF As System.Windows.Forms.TextBox
    Friend WithEvents REGB7 As System.Windows.Forms.TextBox
    Friend WithEvents REGBE As System.Windows.Forms.TextBox
    Friend WithEvents REGB6 As System.Windows.Forms.TextBox
    Friend WithEvents REGBD As System.Windows.Forms.TextBox
    Friend WithEvents REGB5 As System.Windows.Forms.TextBox
    Friend WithEvents REGBC As System.Windows.Forms.TextBox
    Friend WithEvents REGB4 As System.Windows.Forms.TextBox
    Friend WithEvents REGBB As System.Windows.Forms.TextBox
    Friend WithEvents REGB3 As System.Windows.Forms.TextBox
    Friend WithEvents REGBA As System.Windows.Forms.TextBox
    Friend WithEvents REGB2 As System.Windows.Forms.TextBox
    Friend WithEvents REGB9 As System.Windows.Forms.TextBox
    Friend WithEvents REGB1 As System.Windows.Forms.TextBox
    Friend WithEvents REGB8 As System.Windows.Forms.TextBox
    Friend WithEvents REGEF As System.Windows.Forms.TextBox
    Friend WithEvents REGE7 As System.Windows.Forms.TextBox
    Friend WithEvents REGEE As System.Windows.Forms.TextBox
    Friend WithEvents REGE6 As System.Windows.Forms.TextBox
    Friend WithEvents REGED As System.Windows.Forms.TextBox
    Friend WithEvents REGE5 As System.Windows.Forms.TextBox
    Friend WithEvents REGEC As System.Windows.Forms.TextBox
    Friend WithEvents REGE4 As System.Windows.Forms.TextBox
    Friend WithEvents REGEB As System.Windows.Forms.TextBox
    Friend WithEvents REGE3 As System.Windows.Forms.TextBox
    Friend WithEvents REGEA As System.Windows.Forms.TextBox
    Friend WithEvents REGE2 As System.Windows.Forms.TextBox
    Friend WithEvents REGE9 As System.Windows.Forms.TextBox
    Friend WithEvents REGE1 As System.Windows.Forms.TextBox
    Friend WithEvents REGE8 As System.Windows.Forms.TextBox
    Friend WithEvents REGCF As System.Windows.Forms.TextBox
    Friend WithEvents REGC7 As System.Windows.Forms.TextBox
    Friend WithEvents REGCE As System.Windows.Forms.TextBox
    Friend WithEvents REGC6 As System.Windows.Forms.TextBox
    Friend WithEvents REGCD As System.Windows.Forms.TextBox
    Friend WithEvents REGC5 As System.Windows.Forms.TextBox
    Friend WithEvents REGCC As System.Windows.Forms.TextBox
    Friend WithEvents REGC4 As System.Windows.Forms.TextBox
    Friend WithEvents REGCB As System.Windows.Forms.TextBox
    Friend WithEvents REGC3 As System.Windows.Forms.TextBox
    Friend WithEvents REGCA As System.Windows.Forms.TextBox
    Friend WithEvents REGC2 As System.Windows.Forms.TextBox
    Friend WithEvents REGC9 As System.Windows.Forms.TextBox
    Friend WithEvents REGC1 As System.Windows.Forms.TextBox
    Friend WithEvents REGC8 As System.Windows.Forms.TextBox
    Friend WithEvents REGAF As System.Windows.Forms.TextBox
    Friend WithEvents REGA7 As System.Windows.Forms.TextBox
    Friend WithEvents REGAE As System.Windows.Forms.TextBox
    Friend WithEvents REGA6 As System.Windows.Forms.TextBox
    Friend WithEvents REGAD As System.Windows.Forms.TextBox
    Friend WithEvents REGA5 As System.Windows.Forms.TextBox
    Friend WithEvents REGAC As System.Windows.Forms.TextBox
    Friend WithEvents REGA4 As System.Windows.Forms.TextBox
    Friend WithEvents REGAB As System.Windows.Forms.TextBox
    Friend WithEvents REGA3 As System.Windows.Forms.TextBox
    Friend WithEvents REGAA As System.Windows.Forms.TextBox
    Friend WithEvents REGA2 As System.Windows.Forms.TextBox
    Friend WithEvents REGA9 As System.Windows.Forms.TextBox
    Friend WithEvents REGA1 As System.Windows.Forms.TextBox
    Friend WithEvents REGA8 As System.Windows.Forms.TextBox
    Friend WithEvents REG9F As System.Windows.Forms.TextBox
    Friend WithEvents REG97 As System.Windows.Forms.TextBox
    Friend WithEvents REG9E As System.Windows.Forms.TextBox
    Friend WithEvents REG96 As System.Windows.Forms.TextBox
    Friend WithEvents REG9D As System.Windows.Forms.TextBox
    Friend WithEvents REG95 As System.Windows.Forms.TextBox
    Friend WithEvents REG9C As System.Windows.Forms.TextBox
    Friend WithEvents REG94 As System.Windows.Forms.TextBox
    Friend WithEvents REG9B As System.Windows.Forms.TextBox
    Friend WithEvents REG93 As System.Windows.Forms.TextBox
    Friend WithEvents REG9A As System.Windows.Forms.TextBox
    Friend WithEvents REG92 As System.Windows.Forms.TextBox
    Friend WithEvents REG99 As System.Windows.Forms.TextBox
    Friend WithEvents REG91 As System.Windows.Forms.TextBox
    Friend WithEvents REG98 As System.Windows.Forms.TextBox
    Friend WithEvents REG8F As System.Windows.Forms.TextBox
    Friend WithEvents REG87 As System.Windows.Forms.TextBox
    Friend WithEvents REG8E As System.Windows.Forms.TextBox
    Friend WithEvents REG86 As System.Windows.Forms.TextBox
    Friend WithEvents REG8D As System.Windows.Forms.TextBox
    Friend WithEvents REG85 As System.Windows.Forms.TextBox
    Friend WithEvents REG8C As System.Windows.Forms.TextBox
    Friend WithEvents REG84 As System.Windows.Forms.TextBox
    Friend WithEvents REG8B As System.Windows.Forms.TextBox
    Friend WithEvents REG83 As System.Windows.Forms.TextBox
    Friend WithEvents REG8A As System.Windows.Forms.TextBox
    Friend WithEvents REG82 As System.Windows.Forms.TextBox
    Friend WithEvents REG89 As System.Windows.Forms.TextBox
    Friend WithEvents REG81 As System.Windows.Forms.TextBox
    Friend WithEvents REG88 As System.Windows.Forms.TextBox
    Friend WithEvents REG7F As System.Windows.Forms.TextBox
    Friend WithEvents REG77 As System.Windows.Forms.TextBox
    Friend WithEvents REG7E As System.Windows.Forms.TextBox
    Friend WithEvents REG76 As System.Windows.Forms.TextBox
    Friend WithEvents REG7D As System.Windows.Forms.TextBox
    Friend WithEvents REG75 As System.Windows.Forms.TextBox
    Friend WithEvents REG7C As System.Windows.Forms.TextBox
    Friend WithEvents REG74 As System.Windows.Forms.TextBox
    Friend WithEvents REG7B As System.Windows.Forms.TextBox
    Friend WithEvents REG73 As System.Windows.Forms.TextBox
    Friend WithEvents REG7A As System.Windows.Forms.TextBox
    Friend WithEvents REG72 As System.Windows.Forms.TextBox
    Friend WithEvents REG79 As System.Windows.Forms.TextBox
    Friend WithEvents REG71 As System.Windows.Forms.TextBox
    Friend WithEvents REG78 As System.Windows.Forms.TextBox
    Friend WithEvents REG6F As System.Windows.Forms.TextBox
    Friend WithEvents REG67 As System.Windows.Forms.TextBox
    Friend WithEvents REG6E As System.Windows.Forms.TextBox
    Friend WithEvents REG66 As System.Windows.Forms.TextBox
    Friend WithEvents REG6D As System.Windows.Forms.TextBox
    Friend WithEvents REG65 As System.Windows.Forms.TextBox
    Friend WithEvents REG6C As System.Windows.Forms.TextBox
    Friend WithEvents REG64 As System.Windows.Forms.TextBox
    Friend WithEvents REG6B As System.Windows.Forms.TextBox
    Friend WithEvents REG63 As System.Windows.Forms.TextBox
    Friend WithEvents REG6A As System.Windows.Forms.TextBox
    Friend WithEvents REG62 As System.Windows.Forms.TextBox
    Friend WithEvents REG69 As System.Windows.Forms.TextBox
    Friend WithEvents REG61 As System.Windows.Forms.TextBox
    Friend WithEvents REG68 As System.Windows.Forms.TextBox
    Friend WithEvents REG5F As System.Windows.Forms.TextBox
    Friend WithEvents REG57 As System.Windows.Forms.TextBox
    Friend WithEvents REG5E As System.Windows.Forms.TextBox
    Friend WithEvents REG56 As System.Windows.Forms.TextBox
    Friend WithEvents REG5D As System.Windows.Forms.TextBox
    Friend WithEvents REG55 As System.Windows.Forms.TextBox
    Friend WithEvents REG5C As System.Windows.Forms.TextBox
    Friend WithEvents REG54 As System.Windows.Forms.TextBox
    Friend WithEvents REG5B As System.Windows.Forms.TextBox
    Friend WithEvents REG53 As System.Windows.Forms.TextBox
    Friend WithEvents REG5A As System.Windows.Forms.TextBox
    Friend WithEvents REG52 As System.Windows.Forms.TextBox
    Friend WithEvents REG59 As System.Windows.Forms.TextBox
    Friend WithEvents REG51 As System.Windows.Forms.TextBox
    Friend WithEvents REG58 As System.Windows.Forms.TextBox
    Friend WithEvents REG4F As System.Windows.Forms.TextBox
    Friend WithEvents REG47 As System.Windows.Forms.TextBox
    Friend WithEvents REG4E As System.Windows.Forms.TextBox
    Friend WithEvents REG46 As System.Windows.Forms.TextBox
    Friend WithEvents REG4D As System.Windows.Forms.TextBox
    Friend WithEvents REG45 As System.Windows.Forms.TextBox
    Friend WithEvents REG4C As System.Windows.Forms.TextBox
    Friend WithEvents REG44 As System.Windows.Forms.TextBox
    Friend WithEvents REG4B As System.Windows.Forms.TextBox
    Friend WithEvents REG43 As System.Windows.Forms.TextBox
    Friend WithEvents REG4A As System.Windows.Forms.TextBox
    Friend WithEvents REG42 As System.Windows.Forms.TextBox
    Friend WithEvents REG49 As System.Windows.Forms.TextBox
    Friend WithEvents REG41 As System.Windows.Forms.TextBox
    Friend WithEvents REG48 As System.Windows.Forms.TextBox
    Friend WithEvents REG3F As System.Windows.Forms.TextBox
    Friend WithEvents REG37 As System.Windows.Forms.TextBox
    Friend WithEvents REG3E As System.Windows.Forms.TextBox
    Friend WithEvents REG36 As System.Windows.Forms.TextBox
    Friend WithEvents REG3D As System.Windows.Forms.TextBox
    Friend WithEvents REG35 As System.Windows.Forms.TextBox
    Friend WithEvents REG3C As System.Windows.Forms.TextBox
    Friend WithEvents REG34 As System.Windows.Forms.TextBox
    Friend WithEvents REG3B As System.Windows.Forms.TextBox
    Friend WithEvents REG33 As System.Windows.Forms.TextBox
    Friend WithEvents REG3A As System.Windows.Forms.TextBox
    Friend WithEvents REG32 As System.Windows.Forms.TextBox
    Friend WithEvents REG39 As System.Windows.Forms.TextBox
    Friend WithEvents REG31 As System.Windows.Forms.TextBox
    Friend WithEvents REG38 As System.Windows.Forms.TextBox
    Friend WithEvents REG2F As System.Windows.Forms.TextBox
    Friend WithEvents REG27 As System.Windows.Forms.TextBox
    Friend WithEvents REG2E As System.Windows.Forms.TextBox
    Friend WithEvents REG26 As System.Windows.Forms.TextBox
    Friend WithEvents REG2D As System.Windows.Forms.TextBox
    Friend WithEvents REG25 As System.Windows.Forms.TextBox
    Friend WithEvents REG2C As System.Windows.Forms.TextBox
    Friend WithEvents REG24 As System.Windows.Forms.TextBox
    Friend WithEvents REG2B As System.Windows.Forms.TextBox
    Friend WithEvents REG23 As System.Windows.Forms.TextBox
    Friend WithEvents REG2A As System.Windows.Forms.TextBox
    Friend WithEvents REG22 As System.Windows.Forms.TextBox
    Friend WithEvents REG29 As System.Windows.Forms.TextBox
    Friend WithEvents REG21 As System.Windows.Forms.TextBox
    Friend WithEvents REG28 As System.Windows.Forms.TextBox
    Friend WithEvents REG1F As System.Windows.Forms.TextBox
    Friend WithEvents REG17 As System.Windows.Forms.TextBox
    Friend WithEvents REG1E As System.Windows.Forms.TextBox
    Friend WithEvents REG16 As System.Windows.Forms.TextBox
    Friend WithEvents REG1D As System.Windows.Forms.TextBox
    Friend WithEvents REG15 As System.Windows.Forms.TextBox
    Friend WithEvents REG1C As System.Windows.Forms.TextBox
    Friend WithEvents REG14 As System.Windows.Forms.TextBox
    Friend WithEvents REG1B As System.Windows.Forms.TextBox
    Friend WithEvents REG13 As System.Windows.Forms.TextBox
    Friend WithEvents REG1A As System.Windows.Forms.TextBox
    Friend WithEvents REG12 As System.Windows.Forms.TextBox
    Friend WithEvents REG19 As System.Windows.Forms.TextBox
    Friend WithEvents REG11 As System.Windows.Forms.TextBox
    Friend WithEvents REG18 As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Button16 As System.Windows.Forms.Button
    Friend WithEvents Button17 As System.Windows.Forms.Button
    Friend WithEvents Button18 As System.Windows.Forms.Button
    Friend WithEvents btnREGGroup As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Timer5 As System.Windows.Forms.Timer
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label16 As System.Windows.Forms.Label

End Class
