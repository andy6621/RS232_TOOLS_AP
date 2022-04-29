'Code Starts here ....
'Import Systems which we are gonna use in our code
Imports System
Imports System.ComponentModel
Imports System.Threading
Imports System.IO.Ports

#Const MCU_PROTOCOL_CMD_SYS_READY_NOTICE = &H1

'frmMain is the name of our form ....
'Here starts our main form code .....
Public Class frmMain
    Dim myPort As Array
    Delegate Sub SetTextCallback(ByVal [text] As String)
    Dim act As Integer
    Dim AUTO_SEND As Integer = False
    Dim Gbuff() As Byte
    Dim strPort As String
    Dim CMD_Action As Boolean = False


    'Page Load Code Starts Here....
    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        myPort = IO.Ports.SerialPort.GetPortNames()
        ' cmbBaud.Items.Add(9600)
        ' cmbBaud.Items.Add(19200)
        'cmbBaud.Items.Add(38400)
        'cmbBaud.Items.Add(57600)
        cmbBaud.Items.Add(115200)

        For i = 0 To UBound(myPort)
            cmbPort.Items.Add(myPort(i))
        Next

        'Call GetSerialPortNames()

        cmbPort.Text = cmbPort.Items.Item(0)
        cmbBaud.Text = cmbBaud.Items.Item(0)
        btnDisconnect.Enabled = False

        GroupBox2.Enabled = False
        btnGroupBox.Enabled = True
        GroupBox3.Enabled = False
        GroupBox1.Enabled = False
        btnGroupBox.Enabled = False

        SerialPort1.BaudRate = "115200"
        Timer1.Enabled = False

        Button8.Enabled = False
        Label4.Visible = False

        Timer3.Enabled = True

        Timer2.Interval = 1000 '設Timer2的時間間隔為1000毫秒，也就是1秒
        Timer2.Enabled = True '啟動Timer2
    End Sub
    Function ReceiveSerialData() As String
        ' Receive strings from a serial port.
        Dim returnStr As String = ""

        Dim com1 As IO.Ports.SerialPort = Nothing
        Try
            ' com1 = My.Computer.Ports.OpenSerialPort("COM21")
            com1 = SerialPort1
            com1.ReadTimeout = 10000
            Do
                Dim Incoming As String = com1.ReadLine()
                If Incoming Is Nothing Then
                    Exit Do
                Else
                    returnStr &= Incoming & vbCrLf
                End If
            Loop
        Catch ex As TimeoutException
            returnStr = "Error: Serial Port read timed out."
        Finally
            If com1 IsNot Nothing Then com1.Close()
        End Try

        Return returnStr
    End Function
    Sub GetSerialPortNames()
        ' Show all available COM ports.
        For Each sp As String In My.Computer.Ports.SerialPortNames
            cmbPort.Items.Add(sp)
        Next
    End Sub
    Private Declare Function timeGetTime Lib "winmm.dll" () As Long

    Sub Delay(ByVal DelayTime As Long) '单位是毫秒
        DelayTime = DelayTime + timeGetTime
        Do While timeGetTime < DelayTime
            'DoEvents()
        Loop
    End Sub
    'Page Load Code Ends Here ....

    'Connect Button Code Starts Here ....
    Private Sub btnConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnect.Click
        SerialPort1.PortName = cmbPort.Text
        SerialPort1.BaudRate = cmbBaud.Text
        SerialPort1.Parity = IO.Ports.Parity.None
        SerialPort1.StopBits = IO.Ports.StopBits.One
        SerialPort1.DataBits = 8

        Me.SerialPort1.ReadBufferSize = 4096
        Me.SerialPort1.ReadTimeout = -1
        'Me.SerialPort1.ReceivedBytesThreshold = 1
        Me.SerialPort1.RtsEnable = Enabled
        Me.SerialPort1.WriteBufferSize = 2048
        Me.SerialPort1.WriteTimeout = -1
        Me.SerialPort1.DtrEnable = Enabled

        SerialPort1.Open()
        btnConnect.Enabled = False
        btnDisconnect.Enabled = True

        GroupBox2.Enabled = True
        btnGroupBox.Enabled = True
        GroupBox3.Enabled = True
        GroupBox1.Enabled = True
        Button8.Enabled = True
        Label4.Visible = True

        cmbPort.Enabled = False

        Timer2.Interval = 1000 '設Timer2的時間間隔為1000毫秒，也就是1秒
        Timer2.Enabled = True '啟動Timer2

        Timer3.Interval = 500 '設Timer5的時間間隔為500毫秒，也就是0.5秒
        Timer3.Enabled = True '啟動Timer2

    End Sub
    'Connect Button Code Ends Here ....

    'Disconnect Button Code Starts Here ....
    Private Sub btnDisconnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisconnect.Click
        SerialPort1.Close()
        btnConnect.Enabled = True
        btnDisconnect.Enabled = False

        GroupBox2.Enabled = False
        btnGroupBox.Enabled = False
        GroupBox3.Enabled = False
        GroupBox1.Enabled = False
        Button8.Enabled = False
        Label4.Visible = False

        Timer2.Enabled = False
        Timer1.Enabled = False
        Timer3.Enabled = False
        ComboBox1.SelectedIndex = 0
        Button3.Text = "開始"

        txtTransmit.Text = ""
        rtbReceived.Text = ""
        DEBUGTextBox1.Text = ""
        TextBox1.Text = "MENU"

        cmbPort.Enabled = True

        Button3.BackColor = Color.Empty

    End Sub
    'Disconnect Button Code Ends Here ....

    'Send Button Code Starts Here ....
    Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click

        Dim strbuff As String = ""

        strbuff = txtTransmit.Text

        Me.DEBUGTextBox1.Text &= txtTransmit.Text

        'buff = HexStr2ByteArray(strbuff)
        ' buff = strbuff
        SerialPort1.Write(DEBUGTextBox1.Text)
        'Me.DEBUGTextBox1.Text &= ByteArrayToHex(buff)
        'DEBUGTextBox1.SelectionStart = DEBUGTextBox1.Text.Length   '文本的选取长度
        'DEBUGTextBox1.ScrollToCaret()  '关键之语句：将焦点滚动到文本内容后
        'DEBUGTextBox1.Focus()
        '        txtTransmit.Text = ByteArrayToHex(buff)
        txtTransmit.Text = DEBUGTextBox1.Text

        'DEBUGTextBox1.SelectionStart = DEBUGTextBox1.Text.Length   '文本的选取长度
        'DEBUGTextBox1.ScrollToCaret()  '关键之语句：将焦点滚动到文本内容后
        'DEBUGTextBox1.Focus()
    End Sub
    'Send Button Code Ends Here ....
    ' Private Function UnicodeBytesToString(
    ' ByVal bytes() As Byte) As String

    '    Return System.Text.Encoding.Unicode.GetString(bytes)
    ' End Function

    'Serial Port Receiving Code Starts Here ....
    Private Sub SerialPort1_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        'ReceivedText(SerialPort1.ReadExisting())
        Dim buff() As Byte
        Dim s As String = ""
        Dim fw As String = ""
        Dim strbuff As String = ""

        '  Dim myArr() : myArr = Array(84, 104, 105, 115, 32, _
        ' 105, 115, 32, 97, 32, 116, 101, 115, 116, 33)

        If DirectCast(sender, SerialPort).BytesToRead > 0 Then
            ReDim buff(SerialPort1.BytesToRead - 1)

            SerialPort1.Read(buff, 0, buff.Length)

            '  strbuff = Me.rtbReceived.Text

            'For i As Integer = 0 To buff.Length - 1
            ' s += buff(i).ToString("X2") & ","
            'temp = buff(i)
            's += UnicodeBytesToString(buff)

            '  If j < 22 Then
            'j = j + 1
            '  End If

            '     Next
            ' rtbReceived.Text = rtbReceived.Text & s & vbCrLf

            ' For Each c In buff
            's = s & Chr(c)
            'Next c
            'For i As Integer = 0 To buff.Length - 1
            '    s += buff(i).ToString("X2")
            '    If j < 22 Then
            '        j = j + 1
            '    End If
            'Next

            s = ByteArrayToStr(buff)
            ' DEBUGTextBox1.Text = fw
            'ReceivedText(s)

            'strbuf = s

            '    x = s.IndexOf("Curr.FW:")


            '        Me.DEBUGTextBox1.Text = AsciiStringoHexString(s)

            'x = s.IndexOf("FW:")
            '   If x > 1 Then
            's.CopyTo(x, fw, 0, 1)
            'Debug.Print("TEST")
            '      arrayA = s.ToCharArray
            'str1 = "aabbccddeeff"
            ' s.CopyTo(x + 3, arrayA, 0, 4 - 1)
            ' act = 1
            '       s += "Rev:" + arrayA(10).ToString + arrayA(11).ToString + arrayA(12).ToString + arrayA(13).ToString
            '        ReceivedText(s)
            '     Else
            ' ReceivedText2(s)

            ReceivedText(s)

        End If
        'End If

    End Sub
    'Serial Port Receiving Code Ends Here ....
    'Serial Port Receiving Code(Invoke) Starts Here ....
    Private Sub ReceivedText(ByVal [text] As String)
        Dim Str As String = ""
        Dim Str2 As String = ""
        Dim Str_number As Integer

        If Me.rtbReceived.InvokeRequired Then
            Dim x As New SetTextCallback(AddressOf ReceivedText)
            Me.Invoke(x, New Object() {(text)})
        Else
            'buff = HexStr2ByteArray([text])
            Str = [text]

            Me.rtbReceived.Text &= [text]
            Me.rtbReceived.SelectionStart = Me.rtbReceived.Text.Length   '文本的选取长度
            Me.rtbReceived.ScrollToCaret()  '关键之语句：将焦点滚动到文本内容后
            Me.rtbReceived.Focus()

            Me.DEBUGTextBox1.Text = ""
            Str_number = InStr(1, Str, "STX")

            If Str_number > 0 Then
                Me.DEBUGTextBox1.Text &= "STX ADDR=" & Str_number.ToString() & " "
                If (InStr(1, Str, "ETX") = (Str_number + 11)) Then
                    Me.DEBUGTextBox1.Text &= Mid(Str, Str_number + 3, 2)
                    TextBox5.Text = Mid(Str, Str_number + 3, 2)
                Else
                    Me.DEBUGTextBox1.Text &= " " & "Error CMD"
                End If
            Else
                Me.DEBUGTextBox1.Text &= " " & "CMD not thing=" & Str
            End If

            Me.DEBUGTextBox1.SelectionStart = Me.DEBUGTextBox1.Text.Length   '文本的选取长度
            Me.DEBUGTextBox1.ScrollToCaret()  '关键之语句：将焦点滚动到文本内容后
            Me.DEBUGTextBox1.Focus()
            CMD_Action = False
        End If


    End Sub
    Private Sub ReceivedText2(ByVal Str As String)
        If Me.DEBUGTextBox1.InvokeRequired Then
            Dim x As New SetTextCallback(AddressOf ReceivedText2)
            Me.Invoke(x, New Object() {(Text)})
        Else
            DEBUGTextBox1.Text &= Str
            DEBUGTextBox1.SelectionStart = DEBUGTextBox1.Text.Length   '文本的选取长度
            DEBUGTextBox1.ScrollToCaret()  '关键之语句：将焦点滚动到文本内容后
            DEBUGTextBox1.Focus()
        End If
    End Sub
    'Serial Port Receiving Code(Invoke) Ends Here ....

    'Com Port Change Warning Code Starts Here ....
    Private Sub cmbPort_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPort.SelectedIndexChanged
        If SerialPort1.IsOpen = False Then
            SerialPort1.PortName = cmbPort.Text
        Else
            MsgBox("Valid only if port is Closed", vbCritical)
        End If
    End Sub
    'Com Port Change Warning Code Ends Here ....

    'Baud Rate Change Warning Code Starts Here ....
    Private Sub cmbBaud_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBaud.SelectedIndexChanged
        If SerialPort1.IsOpen = False Then
            SerialPort1.BaudRate = cmbBaud.Text
        Else
            MsgBox("Valid only if port is Closed", vbCritical)
        End If
    End Sub
    'Baud Rate Change Warning Code Ends Here ....

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        'If AUTO_SEND== True Then
        'If CheckBox2.Checked = True Then
        SendCMD(16)
        'End If
        'End If



        ' If rtbReceived.Lines.Length > 100 Then
        'Dim temp As String = ""
        'temp = TextBox1.Text.Remove(0, TextBox1.Lines(0).Length + 2) '去除第一行和換行符號
        'rtbReceived.Text = "" '清空
        'TextBox1.AppendText(temp) '附加文字 ，其游標會自動再最後一行
        'TextBox1.Focus() '取得焦點
        'End If
    End Sub
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick

        Dim DayString, TimeString As String '用來顯示日期與時間字串變數
        'DayString = Format(Now, "Long Date") '指定DayString為時間格式為有西元年的日期
        DayString = Format(Now, "yyyy/MM/dd") '指定DayString為時間格式為有西元年的日期
        'TimeString = Format(Now, "AMPM(hh:mm:ss)") 'Format(Now, "AMPM hh:mm:ss") '指定TimeString為時間格式AMPM hh:mm:ss
        TimeString = TimeOfDay.ToString("tt h:mm:ss ")
        Label4.Text = DayString + Space(1) + TimeString '將結果Show在Label1(space(1)為空一格)
    End Sub
    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        If Timer1.Enabled = True Then
            If Button3.BackColor = Color.Red Then
                Button3.BackColor = Color.Empty
            Else
                Button3.BackColor = Color.Red
            End If
        End If
    End Sub

    Private Sub rtbReceived_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rtbReceived.TextChanged
        '    If rtbReceived.Lines.Length > 2 Then
        rtbReceived.SelectionStart = Len(rtbReceived.Text)
        'Dim temp As String = ""
        'temp = rtbReceived.Text.Remove(0, rtbReceived.Lines(0).Length + 2) '去除第一行和換行符號
        'rtbReceived.Text = "" '清空
        ' rtbReceived.AppendText(temp) '附加文字 ，其游標會自動再最後一行
        'rtbReceived.Focus() '取得焦點
        '        Else
        'Me.DEBUGTextBox1.Text &= ">"

        '       rtbReceived.SelStart = Len(rtbReceived.Text)
        '  End If
    End Sub
    Private Function UnicodeBytesToString(ByVal bytes() As Byte) As String
        Return System.Text.Encoding.Unicode.GetString(bytes)
    End Function
    Public Function HexStr2ByteArray(ByVal data As String) As Byte()
        Dim sendData As Byte() = New Byte((data.Length / 2) - 1) {}
        For i As Integer = 0 To (sendData.Length - 1)
            sendData(i) = CByte(Convert.ToInt32(data.Substring(i * 2, 2), 16))
        Next i
        Return sendData
    End Function

    Public Function ByteArrayToHex(ByVal comByte As Byte()) As String
        'create a new StringBuilder object
        Dim builder As New System.Text.StringBuilder(comByte.Length * 2)
        'loop through each byte in the array
        For Each data As Byte In comByte
            builder.Append(Convert.ToString(data, 16).PadLeft(2, "0"c).PadRight(2, " "c))
            'convert the byte to a string and add to the stringbuilder
        Next
        'return the converted value
        Return builder.ToString().ToUpper()
    End Function

    Private Sub btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SendCMD(0)

        '        Dim buff() As Byte '= {&H7E, &H1, &H1, &H0, &H0}
        '        Dim strbuff As String
        '        strbuff = Replace(strDVRreadyNotice, ",", "")
        '        buff = HexStr2ByteArray(strbuff)
        '        SerialPort1.Write(buff, 0, 5)
        '        Me.DEBUGTextBox1.Text &= ByteArrayToHex(buff)

        '        DEBUGTextBox1.SelectionStart = DEBUGTextBox1.Text.Length   '文本的选取长度
        '        DEBUGTextBox1.ScrollToCaret()  '关键之语句：将焦点滚动到文本内容后
        '        DEBUGTextBox1.Focus()

        '        txtTransmit.Text = ByteArrayToHex(buff)
    End Sub

    Public Function AsciiStringToHexString(ByVal asciiString As String) As String
        Dim ascii() As Byte = System.Text.Encoding.Default.GetBytes(asciiString)
        Dim count As Integer = ascii.Length
        Dim hexArray(count - 1) As String
        For idx As Integer = 0 To count - 1
            hexArray(idx) = ascii(idx).ToString("x2")
            'SerialPort1.Write(HexStringToByteArray(strTmp[i]), 0, 1) 
        Next
        Return String.Join(" ", hexArray)
    End Function


    Public Function HexStringToAsciiString(ByVal hexString As String) As String
        Dim array() As String = hexString.Split(New Char() {" "c}, StringSplitOptions.RemoveEmptyEntries)
        For idx As Integer = 0 To array.Length - 1
            array(idx) = Chr(CInt(String.Format("&h{0}", array(idx))))
        Next
        Return String.Join(String.Empty, array)
    End Function
    ' 將字串轉成byte陣列
    Shared Function StrToByteArray(ByVal str As String) As Byte()
        Dim encoding As New System.Text.ASCIIEncoding()
        Return encoding.GetBytes(str)
    End Function

    ' 將byte陣列轉成字串
    Shared Function ByteArrayToStr(ByVal bt As Byte()) As String
        Dim encoding As New System.Text.ASCIIEncoding()
        Return encoding.GetString(bt)
    End Function

    Private Sub Delay(ByVal ASecond As Integer)
        Dim before
        before = Timer
        Do
            DoEvents()
        Loop Until (Int(Timer - before) = ASecond)
    End Sub
    'Private Sub tbxASCII_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbxASCII.TextChanged
    '  If Me.ActiveControl Is sender Then
    '  tbxHex.Text = AsciiStringToHexString(tbxASCII.Text)
    '   End If
    'End Sub

    'Private Sub tbxHex_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbxHex.TextChanged
    '     If Me.ActiveControl Is sender Then
    '          '  tbxASCII.Text = HexStringToAsciiString(tbxHex.Text)
    '       End If
    '    End Sub

    Private Sub btnCLRMessage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        ' DEBUGTextBox1.Text = ""
        ' txtTransmit.Text = ""
        ' rtbReceived.Text = ""
        Me.Close()


    End Sub
    Private Sub SendCMD(ByVal idx As String)
        '        Dim strDVRreadyNotice As String = "7E,01,01,00,00,"  'DVRreadyNotice
        '        Dim strbtnWDT As String = "7E,02,01,00,03,"  'DVRreadyNotice
        '        Dim strbtnWDT As String = "7E,02,01,00,03,"  'DVRreadyNotice

        Dim strbuff As String = ""
        If idx = 0 Then
            strbuff = Replace("7E,01,01,00,00", ",", "")   'DVRreadyNotice
        ElseIf idx = 1 Then
            strbuff = Replace("7E,02,01,00,03,", ",", "") 'DVR WDT KICK
        ElseIf idx = 2 Then
            strbuff = Replace("7E,03,01,00,02,", ",", "") 'MCU Entry sleep mode
        ElseIf idx = 3 Then
            strbuff = Replace("7E,04,01,00,05,", ",", "") 'DISTANCE_RESET
        ElseIf idx = 4 Then
            strbuff = Replace("7E,11,01,00,10,", ",", "") 'DVR reboot RESET
        ElseIf idx = 5 Then
            strbuff = Replace("7E,12,01,00,13,", ",", "") 'DVR shutdown RESET
        ElseIf idx = 6 Then
            strbuff = Replace("7E,05,08,01,05,02,06,03,07,04,08,05,", ",", "") 'Encoder deviation setting
        ElseIf idx = 7 Then
            'strbuff = Replace("7E,10,01,00,11,", ",", "") 'MCU FW VERSION
            Me.rtbReceived.Text = ""
            strbuff = "FW" + Chr(13)  'MCU FW VERSION
        ElseIf idx = 8 Then
            strbuff = Replace("7E,06,01,01,06,", ",", "") 'CAM INC 0.1V 
        ElseIf idx = 9 Then
            strbuff = Replace("7E,06,01,00,07,", ",", "") 'CAM DEC 0.1V
        ElseIf idx = 10 Then
            strbuff = Replace("7E,83,01,00,82,", ",", "") 'factory mode
        ElseIf idx = 11 Then
            strbuff = Replace("7E,30,00,30,", ",", "") 'isp mode
        ElseIf idx = 12 Then
            strbuff = Replace("7E,08,01,01,08,", ",", "") 'pwer start 1
        ElseIf idx = 13 Then
            strbuff = Replace("7E,08,01,00,09,", ",", "") 'pwer start 0
        ElseIf idx = 14 Then
            strbuff = Replace("7E,07,01,00,06,", ",", "") 'WDT Enable=0
        ElseIf idx = 15 Then
            strbuff = Replace("7E,07,01,01,07,", ",", "") 'WDT Enable=1
        ElseIf idx = 16 Then
            Me.rtbReceived.Text = ""
            strbuff = TextBox1.Text + Chr(13)  '自動傳送資料
        ElseIf idx = 17 Then
            Me.rtbReceived.Text = ""
            strbuff = "UP" + Chr(13)  'UP KEY
        ElseIf idx = 18 Then
            Me.rtbReceived.Text = ""
            strbuff = "DOWN" + Chr(13)  'DOWN KEY
        ElseIf idx = 19 Then
            Me.rtbReceived.Text = ""
            strbuff = "SELECT" + Chr(13)  'SELECT KEY
        ElseIf idx = 20 Then
            Me.rtbReceived.Text = ""
            strbuff = "JUMP" + Chr(13)  'JUMP KEY
        ElseIf idx = 21 Then
            Me.rtbReceived.Text = ""
            TextBox5.Text = "?" : CMD_Action = True
            strbuff = "CMDR" + " " + TextBox6.Text + " " + TextBox2.Text + " " + Chr(13)  'CMD Read
        ElseIf idx = 22 Then
            Me.rtbReceived.Text = ""
            TextBox5.Text = "?" : CMD_Action = True
            strbuff = "CMDW" + " " + TextBox6.Text + " " + _
                TextBox3.Text + " " + TextBox4.Text + Chr(13)  'CMD Write
        End If

        '  buff = HexStr2ByteArray(strbuff)
        'SerialPort1.Write(strbuff, 0, buff.Length)
        If SerialPort1.IsOpen = True Then
            SerialPort1.Write(strbuff)
        End If

        'Me.DEBUGTextBox1.Text &= ByteArrayToHex(buff)
        'txtTransmit.Text = ByteArrayToHex(buff)
        txtTransmit.Text = strbuff 'ByteArrayToHex(buff)

        '   DEBUGTextBox1.Text = AsciiStringToHexString(strbuff)
        '   DEBUGTextBox1.SelectionStart = DEBUGTextBox1.Text.Length   '文本的选取长度
        '  DEBUGTextBox1.ScrollToCaret()  '关键之语句：将焦点滚动到文本内容后
        ' DEBUGTextBox1.Focus()

    End Sub
   

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer2.Enabled = False
        Timer1.Enabled = False
        Timer3.Enabled = False
        Me.Close()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Me.rtbReceived.Text = ""
        Me.DEBUGTextBox1.Text = ""
        TextBox5.Text = "_"
    End Sub
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Me.DEBUGTextBox1.Text = ""
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        SendCMD(16)
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Timer1.Enabled = False And ComboBox1.SelectedIndex <> 0 And TextBox1.Text <> "" Then
            Timer1.Enabled = True
            Button3.Text = "停止"
            Button3.BackColor = Color.Red

        Else
            Timer1.Enabled = False
            Button3.Text = "開始"
            Button3.BackColor = Color.Empty

            If ComboBox1.SelectedIndex <> 0 Then
                Me.rtbReceived.Text = "停止自動傳送命令"
            End If
            ' ComboBox1.SelectedIndex = 0
        End If

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        'Me.rtbReceived.Text = "開始自動傳送命令"
        If ComboBox1.SelectedIndex = 0 Then
            Timer1.Enabled = False
        Else
            'Timer1.Enabled = True
            If ComboBox1.SelectedIndex = 1 Then
                Timer1.Interval = 1000
            ElseIf ComboBox1.SelectedIndex = 2 Then
                Timer1.Interval = 2000
            ElseIf ComboBox1.SelectedIndex = 3 Then
                Timer1.Interval = 3000
            ElseIf ComboBox1.SelectedIndex = 4 Then
                Timer1.Interval = 4000
            ElseIf ComboBox1.SelectedIndex = 5 Then
                Timer1.Interval = 5000
            ElseIf ComboBox1.SelectedIndex = 6 Then
                Timer1.Interval = 6000
            ElseIf ComboBox1.SelectedIndex = 7 Then
                Timer1.Interval = 7000
            ElseIf ComboBox1.SelectedIndex = 8 Then
                Timer1.Interval = 8000
            ElseIf ComboBox1.SelectedIndex = 9 Then
                Timer1.Interval = 9000
            ElseIf ComboBox1.SelectedIndex = 10 Then
                Timer1.Interval = 10000
            End If

        End If

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        SendCMD(17)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        SendCMD(18)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        SendCMD(19)
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        SendCMD(20)
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        'If CMD_Action = False Then
        SendCMD(21)
        'End If
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        '  If CMD_Action = False Then
        SendCMD(22)
        '   End If
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Dim intNumber As Integer = 0
        '   If CMD_Action = False Then
        intNumber = Val("&H" + TextBox4.Text + "&")
        If intNumber >= 255 Then
            intNumber = 255
            TextBox4.Text = Hex(intNumber)
        Else

            TextBox4.Text = Hex(intNumber + 1)
        End If

        SendCMD(22)
        '  End If
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Dim intNumber As Integer = 0
        ' If CMD_Action = False Then
        intNumber = Val("&H" + TextBox4.Text + "&")
        If intNumber <= 0 Then
            intNumber = 0
            TextBox4.Text = Hex(intNumber)
        Else
            TextBox4.Text = Hex(intNumber - 1)
        End If

        SendCMD(22)

        ' End If
    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            'MsgBox("輸入的值是" & TextBox2.Text)
            Dim intNumber As Integer = 0

            ' If CMD_Action = False Then
            TextBox4.Text = UCase(TextBox4.Text)

            intNumber = Val("&H" + (TextBox4.Text) + "&")

            TextBox4.Text = Hex(intNumber)

            If intNumber >= 255 Then
                intNumber = 255
                TextBox4.Text = Hex(intNumber)
            ElseIf intNumber <= 0 Then
                intNumber = 0
                TextBox4.Text = Hex(intNumber)
            End If

            SendCMD(22)
            'End If

        End If
    End Sub

    Private Function Timer() As Object
        Throw New NotImplementedException
    End Function

    Private Sub DoEvents()
        Throw New NotImplementedException
    End Sub

    Private Sub btnMCUREV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMCUREV.Click
        SendCMD(7)
    End Sub

    Private Sub DEBUGTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DEBUGTextBox1.TextChanged

    End Sub
End Class
'Whole Code Ends Here ....