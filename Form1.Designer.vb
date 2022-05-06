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
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button14 = New System.Windows.Forms.Button()
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
        Me.TextBox21 = New System.Windows.Forms.TextBox()
        Me.REG00 = New System.Windows.Forms.TextBox()
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Button15 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnConnect
        '
        Me.btnConnect.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btnConnect.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnConnect.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnConnect.Location = New System.Drawing.Point(323, 50)
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
        Me.btnDisconnect.Location = New System.Drawing.Point(323, 109)
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
        Me.cmbPort.Location = New System.Drawing.Point(149, 54)
        Me.cmbPort.Name = "cmbPort"
        Me.cmbPort.Size = New System.Drawing.Size(151, 24)
        Me.cmbPort.TabIndex = 2
        '
        'cmbBaud
        '
        Me.cmbBaud.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmbBaud.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmbBaud.FormattingEnabled = True
        Me.cmbBaud.Location = New System.Drawing.Point(149, 120)
        Me.cmbBaud.Name = "cmbBaud"
        Me.cmbBaud.Size = New System.Drawing.Size(151, 24)
        Me.cmbBaud.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(21, 54)
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
        Me.Label2.Location = New System.Drawing.Point(22, 120)
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
        Me.GroupBox2.Location = New System.Drawing.Point(570, 64)
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
        Me.rtbReceived.MaxLength = 10
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
        Me.GroupBox3.Location = New System.Drawing.Point(571, 369)
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
        Me.ComboBox3.Location = New System.Drawing.Point(256, 188)
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
        Me.ComboBox2.Location = New System.Drawing.Point(247, 270)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(83, 21)
        Me.ComboBox2.TabIndex = 47
        Me.ComboBox2.Text = "VS4210"
        '
        'Button13
        '
        Me.Button13.Location = New System.Drawing.Point(319, 394)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(32, 28)
        Me.Button13.TabIndex = 46
        Me.Button13.Text = "D"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(319, 357)
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
        Me.Label9.Location = New System.Drawing.Point(260, 359)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 17)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "資料"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label7.Location = New System.Drawing.Point(260, 303)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 17)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "資料"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label8.Location = New System.Drawing.Point(183, 361)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 17)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "位置"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label6.Location = New System.Drawing.Point(183, 305)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 17)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "位置"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label10.Location = New System.Drawing.Point(254, 249)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 17)
        Me.Label10.TabIndex = 44
        Me.Label10.Text = "IC編號"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label5.Location = New System.Drawing.Point(174, 250)
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
        Me.TextBox1.Location = New System.Drawing.Point(169, 270)
        Me.TextBox1.MaxLength = 2
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(60, 23)
        Me.TextBox1.TabIndex = 43
        Me.TextBox1.Text = "40"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(246, 323)
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
        Me.TextBox4.Location = New System.Drawing.Point(245, 382)
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
        Me.TextBox3.Location = New System.Drawing.Point(168, 382)
        Me.TextBox3.MaxLength = 2
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(64, 22)
        Me.TextBox3.TabIndex = 40
        Me.TextBox3.Text = "0"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(84, 378)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(68, 37)
        Me.Button11.TabIndex = 39
        Me.Button11.Text = "寫入資料"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TextBox2.Location = New System.Drawing.Point(169, 325)
        Me.TextBox2.MaxLength = 2
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(62, 22)
        Me.TextBox2.TabIndex = 38
        Me.TextBox2.Text = "0"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(84, 319)
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
        Me.Button3.Location = New System.Drawing.Point(395, 190)
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
        Me.Button9.Location = New System.Drawing.Point(381, 392)
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
        Me.Button8.Location = New System.Drawing.Point(381, 303)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(79, 28)
        Me.Button8.TabIndex = 25
        Me.Button8.Text = "清除TX"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(332, 96)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(44, 54)
        Me.Button7.TabIndex = 35
        Me.Button7.Text = "JUMP"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(279, 96)
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
        Me.ComboBox1.Location = New System.Drawing.Point(353, 190)
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
        Me.Label3.Location = New System.Drawing.Point(275, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 20)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "命令        時間(秒)"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(391, 127)
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
        Me.Button2.Location = New System.Drawing.Point(279, 24)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(167, 61)
        Me.Button2.TabIndex = 28
        Me.Button2.Text = "MENU"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(391, 96)
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
        Me.btnMCUREV.Location = New System.Drawing.Point(84, 24)
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
        Me.Button1.Location = New System.Drawing.Point(870, 23)
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
        Me.Label4.Location = New System.Drawing.Point(599, 31)
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
        Me.TabControl1.Location = New System.Drawing.Point(12, 178)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(552, 464)
        Me.TabControl1.TabIndex = 27
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
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
        Me.TabPage1.Size = New System.Drawing.Size(544, 438)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label12.Location = New System.Drawing.Point(383, 351)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 12)
        Me.Label12.TabIndex = 51
        Me.Label12.Text = "RX Message"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Blue
        Me.Label11.Location = New System.Drawing.Point(379, 262)
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
        Me.ComboBox5.Location = New System.Drawing.Point(381, 366)
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
        Me.ComboBox4.Location = New System.Drawing.Point(381, 277)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(79, 20)
        Me.ComboBox4.TabIndex = 49
        Me.ComboBox4.Text = "12"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.Button15)
        Me.TabPage2.Controls.Add(Me.Button14)
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
        Me.TabPage2.Controls.Add(Me.TextBox21)
        Me.TabPage2.Controls.Add(Me.REG00)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(544, 438)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        '
        'Button14
        '
        Me.Button14.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button14.Location = New System.Drawing.Point(418, 391)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(98, 41)
        Me.Button14.TabIndex = 1
        Me.Button14.Text = "Read ALL."
        Me.Button14.UseVisualStyleBackColor = True
        '
        'TextBox36
        '
        Me.TextBox36.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox36.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox36.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox36.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.TextBox36.Location = New System.Drawing.Point(511, 6)
        Me.TextBox36.Name = "TextBox36"
        Me.TextBox36.Size = New System.Drawing.Size(30, 27)
        Me.TextBox36.TabIndex = 0
        Me.TextBox36.Text = "0F"
        Me.TextBox36.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG0F
        '
        Me.REG0F.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG0F.Location = New System.Drawing.Point(511, 35)
        Me.REG0F.Name = "REG0F"
        Me.REG0F.Size = New System.Drawing.Size(30, 27)
        Me.REG0F.TabIndex = 0
        Me.REG0F.Text = "00" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.REG0F.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox35
        '
        Me.TextBox35.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox35.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox35.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.TextBox35.Location = New System.Drawing.Point(248, 6)
        Me.TextBox35.Name = "TextBox35"
        Me.TextBox35.Size = New System.Drawing.Size(30, 27)
        Me.TextBox35.TabIndex = 0
        Me.TextBox35.Text = "07"
        Me.TextBox35.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG07
        '
        Me.REG07.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG07.Location = New System.Drawing.Point(248, 35)
        Me.REG07.Name = "REG07"
        Me.REG07.Size = New System.Drawing.Size(30, 27)
        Me.REG07.TabIndex = 0
        Me.REG07.Text = "00"
        Me.REG07.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox34
        '
        Me.TextBox34.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox34.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox34.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox34.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.TextBox34.Location = New System.Drawing.Point(481, 6)
        Me.TextBox34.Name = "TextBox34"
        Me.TextBox34.Size = New System.Drawing.Size(30, 27)
        Me.TextBox34.TabIndex = 0
        Me.TextBox34.Text = "0E"
        Me.TextBox34.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG0E
        '
        Me.REG0E.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG0E.Location = New System.Drawing.Point(481, 35)
        Me.REG0E.Name = "REG0E"
        Me.REG0E.Size = New System.Drawing.Size(30, 27)
        Me.REG0E.TabIndex = 0
        Me.REG0E.Text = "00"
        Me.REG0E.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox33
        '
        Me.TextBox33.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox33.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox33.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.TextBox33.Location = New System.Drawing.Point(218, 6)
        Me.TextBox33.Name = "TextBox33"
        Me.TextBox33.Size = New System.Drawing.Size(30, 27)
        Me.TextBox33.TabIndex = 0
        Me.TextBox33.Text = "06"
        Me.TextBox33.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG06
        '
        Me.REG06.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG06.Location = New System.Drawing.Point(218, 35)
        Me.REG06.Name = "REG06"
        Me.REG06.Size = New System.Drawing.Size(30, 27)
        Me.REG06.TabIndex = 0
        Me.REG06.Text = "00"
        Me.REG06.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox32
        '
        Me.TextBox32.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox32.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox32.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.TextBox32.Location = New System.Drawing.Point(451, 6)
        Me.TextBox32.Name = "TextBox32"
        Me.TextBox32.Size = New System.Drawing.Size(30, 27)
        Me.TextBox32.TabIndex = 0
        Me.TextBox32.Text = "0D"
        Me.TextBox32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG0D
        '
        Me.REG0D.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG0D.Location = New System.Drawing.Point(451, 35)
        Me.REG0D.Name = "REG0D"
        Me.REG0D.Size = New System.Drawing.Size(30, 27)
        Me.REG0D.TabIndex = 0
        Me.REG0D.Text = "00"
        Me.REG0D.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox31
        '
        Me.TextBox31.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox31.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox31.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.TextBox31.Location = New System.Drawing.Point(188, 6)
        Me.TextBox31.Name = "TextBox31"
        Me.TextBox31.Size = New System.Drawing.Size(30, 27)
        Me.TextBox31.TabIndex = 0
        Me.TextBox31.Text = "05"
        Me.TextBox31.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG05
        '
        Me.REG05.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG05.Location = New System.Drawing.Point(188, 35)
        Me.REG05.Name = "REG05"
        Me.REG05.Size = New System.Drawing.Size(30, 27)
        Me.REG05.TabIndex = 0
        Me.REG05.Text = "00"
        Me.REG05.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox30
        '
        Me.TextBox30.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox30.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox30.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.TextBox30.Location = New System.Drawing.Point(421, 6)
        Me.TextBox30.Name = "TextBox30"
        Me.TextBox30.Size = New System.Drawing.Size(30, 27)
        Me.TextBox30.TabIndex = 0
        Me.TextBox30.Text = "0C"
        Me.TextBox30.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG0C
        '
        Me.REG0C.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG0C.Location = New System.Drawing.Point(421, 35)
        Me.REG0C.Name = "REG0C"
        Me.REG0C.Size = New System.Drawing.Size(30, 27)
        Me.REG0C.TabIndex = 0
        Me.REG0C.Text = "00"
        Me.REG0C.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox29
        '
        Me.TextBox29.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox29.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox29.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.TextBox29.Location = New System.Drawing.Point(158, 6)
        Me.TextBox29.Name = "TextBox29"
        Me.TextBox29.Size = New System.Drawing.Size(30, 27)
        Me.TextBox29.TabIndex = 0
        Me.TextBox29.Text = "04"
        Me.TextBox29.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG04
        '
        Me.REG04.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG04.Location = New System.Drawing.Point(158, 35)
        Me.REG04.Name = "REG04"
        Me.REG04.Size = New System.Drawing.Size(30, 27)
        Me.REG04.TabIndex = 0
        Me.REG04.Text = "00"
        Me.REG04.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox28
        '
        Me.TextBox28.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox28.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox28.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.TextBox28.Location = New System.Drawing.Point(391, 6)
        Me.TextBox28.Name = "TextBox28"
        Me.TextBox28.Size = New System.Drawing.Size(30, 27)
        Me.TextBox28.TabIndex = 0
        Me.TextBox28.Text = "0B"
        Me.TextBox28.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG0B
        '
        Me.REG0B.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG0B.Location = New System.Drawing.Point(391, 35)
        Me.REG0B.Name = "REG0B"
        Me.REG0B.Size = New System.Drawing.Size(30, 27)
        Me.REG0B.TabIndex = 0
        Me.REG0B.Text = "00"
        Me.REG0B.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox27
        '
        Me.TextBox27.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox27.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox27.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.TextBox27.Location = New System.Drawing.Point(128, 6)
        Me.TextBox27.Name = "TextBox27"
        Me.TextBox27.Size = New System.Drawing.Size(30, 27)
        Me.TextBox27.TabIndex = 0
        Me.TextBox27.Text = "03"
        Me.TextBox27.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG03
        '
        Me.REG03.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG03.Location = New System.Drawing.Point(128, 35)
        Me.REG03.Name = "REG03"
        Me.REG03.Size = New System.Drawing.Size(30, 27)
        Me.REG03.TabIndex = 0
        Me.REG03.Text = "00"
        Me.REG03.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox26
        '
        Me.TextBox26.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox26.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox26.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.TextBox26.Location = New System.Drawing.Point(361, 6)
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.Size = New System.Drawing.Size(30, 27)
        Me.TextBox26.TabIndex = 0
        Me.TextBox26.Text = "0A"
        Me.TextBox26.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG0A
        '
        Me.REG0A.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG0A.Location = New System.Drawing.Point(361, 35)
        Me.REG0A.Name = "REG0A"
        Me.REG0A.Size = New System.Drawing.Size(30, 27)
        Me.REG0A.TabIndex = 0
        Me.REG0A.Text = "00"
        Me.REG0A.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox25
        '
        Me.TextBox25.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox25.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox25.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.TextBox25.Location = New System.Drawing.Point(98, 6)
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Size = New System.Drawing.Size(30, 27)
        Me.TextBox25.TabIndex = 0
        Me.TextBox25.Text = "02"
        Me.TextBox25.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG02
        '
        Me.REG02.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG02.Location = New System.Drawing.Point(98, 35)
        Me.REG02.Name = "REG02"
        Me.REG02.Size = New System.Drawing.Size(30, 27)
        Me.REG02.TabIndex = 0
        Me.REG02.Text = "00"
        Me.REG02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox24
        '
        Me.TextBox24.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox24.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox24.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.TextBox24.Location = New System.Drawing.Point(331, 6)
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Size = New System.Drawing.Size(30, 27)
        Me.TextBox24.TabIndex = 0
        Me.TextBox24.Text = "09"
        Me.TextBox24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG09
        '
        Me.REG09.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG09.Location = New System.Drawing.Point(331, 35)
        Me.REG09.Name = "REG09"
        Me.REG09.Size = New System.Drawing.Size(30, 27)
        Me.REG09.TabIndex = 0
        Me.REG09.Text = "00"
        Me.REG09.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox23
        '
        Me.TextBox23.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox23.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox23.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.TextBox23.Location = New System.Drawing.Point(68, 6)
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Size = New System.Drawing.Size(30, 27)
        Me.TextBox23.TabIndex = 0
        Me.TextBox23.Text = "01"
        Me.TextBox23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG01
        '
        Me.REG01.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG01.Location = New System.Drawing.Point(68, 35)
        Me.REG01.Name = "REG01"
        Me.REG01.Size = New System.Drawing.Size(30, 27)
        Me.REG01.TabIndex = 0
        Me.REG01.Text = "00"
        Me.REG01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox22
        '
        Me.TextBox22.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox22.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox22.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.TextBox22.Location = New System.Drawing.Point(300, 6)
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New System.Drawing.Size(30, 27)
        Me.TextBox22.TabIndex = 0
        Me.TextBox22.Text = "08"
        Me.TextBox22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG08
        '
        Me.REG08.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG08.Location = New System.Drawing.Point(300, 35)
        Me.REG08.Name = "REG08"
        Me.REG08.Size = New System.Drawing.Size(30, 27)
        Me.REG08.TabIndex = 0
        Me.REG08.Text = "00"
        Me.REG08.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox21
        '
        Me.TextBox21.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox21.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox21.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.TextBox21.Location = New System.Drawing.Point(37, 6)
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New System.Drawing.Size(30, 27)
        Me.TextBox21.TabIndex = 0
        Me.TextBox21.Text = "00"
        Me.TextBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG00
        '
        Me.REG00.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG00.Location = New System.Drawing.Point(37, 35)
        Me.REG00.Name = "REG00"
        Me.REG00.Size = New System.Drawing.Size(30, 27)
        Me.REG00.TabIndex = 0
        Me.REG00.Text = "00"
        Me.REG00.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button15
        '
        Me.Button15.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button15.Location = New System.Drawing.Point(297, 391)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(94, 40)
        Me.Button15.TabIndex = 2
        Me.Button15.Text = "Save"
        Me.Button15.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 649)
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
    Friend WithEvents TextBox21 As System.Windows.Forms.TextBox
    Friend WithEvents Timer4 As System.Windows.Forms.Timer
    Friend WithEvents Button15 As System.Windows.Forms.Button

End Class
