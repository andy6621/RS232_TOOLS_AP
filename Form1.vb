'Code Starts here ....
'Import Systems which we are gonna use in our code
Imports System
Imports System.ComponentModel
Imports System.Threading
Imports System.IO.Ports


'frmMain is the name of our form ....
'Here starts our main form code .....
Public Class frmMain

    Const TAB_PAGE0 = 0
    Const TAB_PAGE1 = 1
    Const REG_READ_MODE = 1
    Const REG_WRITE_MODE = 2
    Const FW_TEST_NO = 0
    Const FW_TEST_WAITING = 1
    Const FW_TEST_NG = 2
    Const FW_TEST_PASS = 3

    Dim myPort As Array

    Private Property fileSaveName As Object

    Delegate Sub SetTextCallback(ByVal [text] As String)
    Dim act As Integer
    Dim AUTO_SEND As Integer = False
    Dim Gbuff() As Byte
    Dim strPort As String
    Dim CMD_Action As Boolean = False
    Dim REGValueChenage As Boolean = False

    'Dump 設定
    Dim Dump_Start, Dump_End, Dump_Loop As Integer
    Dim Dump_Timer As Boolean = False


    'WriteREG 設定
    Dim WriteREG_Start, WriteREG_End, WriteREG_Loop As Integer
    Dim WriteREG_Timer As Boolean = False
    Dim RW_REG_Action As Integer = 0

    'FW TEST FLAF
    Dim FW_ACTION As Integer = 0

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
        TabControl1.Enabled = False
        btnGroupBox.Enabled = False

        SerialPort1.BaudRate = "115200"
        Timer1.Enabled = False

        Button8.Enabled = False
        Label4.Visible = False

        Timer3.Enabled = True

        Timer2.Interval = 1000 '設Timer2的時間間隔為1000毫秒，也就是1秒
        Timer2.Enabled = True '啟動Timer2

        'TabControl1.SelectedIndex = 0

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

        Try
            SerialPort1.Open()

            btnConnect.Enabled = False
            btnDisconnect.Enabled = True

            GroupBox2.Enabled = True
            btnGroupBox.Enabled = True
            GroupBox3.Enabled = True
            GroupBox1.Enabled = True
            TabControl1.Enabled = True
            Button8.Enabled = True
            Label4.Visible = True

            cmbPort.Enabled = False

            Timer2.Interval = 1000 '設Timer2的時間間隔為1000毫秒，也就是1秒
            Timer2.Enabled = True '啟動Timer2

            Timer3.Interval = 500 '設Timer5的時間間隔為500毫秒，也就是0.5秒
            Timer3.Enabled = True '啟動Timer2

            cmbBaud.Enabled = False


            Button14.Enabled = True
            Button15.Enabled = True
            TabControl1.Enabled = True

        Catch ex As Exception
            MsgBox(cmbPort.Text & " 有問題無法使用")
        End Try


    End Sub
    'Connect Button Code Ends Here ....

    'Disconnect Button Code Starts Here ....
    Private Sub btnDisconnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisconnect.Click

        Try
            SerialPort1.Close()

            btnConnect.Enabled = True
            btnDisconnect.Enabled = False

            GroupBox2.Enabled = False
            btnGroupBox.Enabled = False
            GroupBox3.Enabled = False
            GroupBox1.Enabled = False
            TabControl1.Enabled = False
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
            'TextBox1.Text = "MENU"

            cmbPort.Enabled = True
            cmbBaud.Enabled = True

            Button3.BackColor = Color.Empty
        Catch ex As Exception
            MsgBox(cmbPort.Text & " 有問題無法關閉")
        End Try


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
        Dim Data As Integer = 0
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

            'Me.DEBUGTextBox1.Text &= vbNewLine
            Str_number = InStr(1, Me.rtbReceived.Text, "STX")

            If Str_number > 0 Then
                '    Me.DEBUGTextBox1.Text &= "STX ADDR=" & Str_number.ToString() & " "
                If (InStr(1, Me.rtbReceived.Text, "ETX") = (Str_number + 11)) Then
                    Me.DEBUGTextBox1.Text &= "R " & Mid(Me.rtbReceived.Text, Str_number + 3, 2) & " " & Mid(Me.rtbReceived.Text, Str_number + 3 + 2, 2) & vbNewLine
                    TextBox5.Text = Mid(Me.rtbReceived.Text, Str_number + 3 + 2, 2)

                    GETREGDATA(Mid(Me.rtbReceived.Text, Str_number + 3, 2), TextBox5.Text)

                    If RW_REG_Action = REG_READ_MODE Then
                        If Dump_Loop < Dump_End Then
                            Dump_Loop += 1
                            TextBox2.Text = Hex(Dump_Loop)
                            SendCMD(21)
                        Else

                            RW_REG_Action = 0
                            Button14.Enabled = True
                            Button15.Enabled = True
                            'TabControl1.Enabled = True
                            btnREGGroup.Enabled = True
                        End If
                    End If

                    If RW_REG_Action = REG_WRITE_MODE Then

                        If WriteREG_Loop < WriteREG_End Then
                            WriteREG_Loop += 1
                            WRITEREGDATA("REG" & Hex(WriteREG_Loop))
                        Else

                            RW_REG_Action = 0
                            btnREGGroup.Enabled = True
                            'Button14.Enabled = True
                            'Button15.Enabled = True
                            'TabControl1.Enabled = True
                        End If

                    End If
                    'If Val(TextBox5.Text) = 0 Then
                    '    TextBox5.Text = "0"
                    'Else
                    '    TextBox5.Text = TextBox5.Text.TrimStart("0")
                    'End If
                    TextBox4.Text = TextBox5.Text
                    'Else
                    '   Me.DEBUGTextBox1.Text &= " " & "Error CMD"
                End If
                'Else
                '   Me.DEBUGTextBox1.Text &= " " & "CMD not thing=" & Me.rtbReceived.Text
            End If

            If InStr(1, Me.rtbReceived.Text, "FW") Then
                FW_ACTION = FW_TEST_PASS
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
    Private Sub PRINT(ByVal str As String)
        DEBUGTextBox1.Text &= str & vbNewLine
    End Sub
    Private Sub GETREGDATA(ByVal Addr As String, ByVal Data As String)

        Dim REG() As TextBox = { _
       REG00, REG01, REG02, REG03, REG04, REG05, REG06, REG07, REG08, REG09, REG0A, REG0B, REG0C, REG0D, REG0E, REG0F, _
       REG10, REG11, REG12, REG13, REG14, REG15, REG16, REG17, REG18, REG19, REG1A, REG1B, REG1C, REG1D, REG1E, REG1F, _
       REG20, REG21, REG22, REG23, REG24, REG25, REG26, REG27, REG28, REG29, REG2A, REG2B, REG2C, REG2D, REG2E, REG2F, _
       REG30, REG31, REG32, REG33, REG34, REG35, REG36, REG37, REG38, REG39, REG3A, REG3B, REG3C, REG3D, REG3E, REG3F, _
       REG40, REG41, REG42, REG43, REG44, REG45, REG46, REG47, REG48, REG49, REG4A, REG4B, REG4C, REG4D, REG4E, REG4F, _
       REG50, REG51, REG52, REG53, REG54, REG55, REG56, REG57, REG58, REG59, REG5A, REG5B, REG5C, REG5D, REG5E, REG5F, _
       REG60, REG61, REG62, REG63, REG64, REG65, REG66, REG67, REG68, REG69, REG6A, REG6B, REG6C, REG6D, REG6E, REG6F, _
       REG70, REG71, REG72, REG73, REG74, REG75, REG76, REG77, REG78, REG79, REG7A, REG7B, REG7C, REG7D, REG7E, REG7F, _
 _
       REG80, REG81, REG82, REG83, REG84, REG85, REG86, REG87, REG88, REG89, REG8A, REG8B, REG8C, REG8D, REG8E, REG8F, _
       REG90, REG91, REG92, REG93, REG94, REG95, REG96, REG97, REG98, REG99, REG9A, REG9B, REG9C, REG9D, REG9E, REG9F, _
       REGA0, REGA1, REGA2, REGA3, REGA4, REGA5, REGA6, REGA7, REGA8, REGA9, REGAA, REGAB, REGAC, REGAD, REGAE, REGAF, _
       REGB0, REGB1, REGB2, REGB3, REGB4, REGB5, REGB6, REGB7, REGB8, REGB9, REGBA, REGBB, REGBC, REGBD, REGBE, REGBF, _
       REGC0, REGC1, REGC2, REGC3, REGC4, REGC5, REGC6, REGC7, REGC8, REGC9, REGCA, REGCB, REGCC, REGCD, REGCE, REGCF, _
       REGD0, REGD1, REGD2, REGD3, REGD4, REGD5, REGD6, REGD7, REGD8, REGD9, REGDA, REGDB, REGDC, REGDD, REGDE, REGDF, _
       REGE0, REGE1, REGE2, REGE3, REGE4, REGE5, REGE6, REGE7, REGE8, REGE9, REGEA, REGEB, REGEC, REGED, REGEE, REGEF, _
       REGF0, REGF1, REGF2, REGF3, REGF4, REGF5, REGF6, REGF7, REGF8, REGF9, REGFA, REGFB, REGFC, REGFD, REGFE, REGFF}

        'Try
        If REG(Integer.Parse(Val("&H" + (Addr) + "&"))).Text <> Data Then

            REG(Integer.Parse(Val("&H" + (Addr) + "&"))).Text = Data
            REG(Integer.Parse(Val("&H" + (Addr) + "&"))).ForeColor = Color.Red
        Else

            If REGValueChenage = True Then
                REG(Integer.Parse(Val("&H" + (Addr) + "&"))).ForeColor = Color.Purple
                REGValueChenage = False
            Else
                REG(Integer.Parse(Val("&H" + (Addr) + "&"))).ForeColor = Color.Empty
            End If

        End If

        '你的程式碼
        'Catch ex As Exception
        '出了錯該怎麼辦？
        'End Try
        'Val("&H" + (Addr) + "&")
    End Sub
    Private Sub WRITEREGDATA(ByVal Str As String)

        Dim REG() As TextBox = { _
       REG00, REG01, REG02, REG03, REG04, REG05, REG06, REG07, REG08, REG09, REG0A, REG0B, REG0C, REG0D, REG0E, REG0F, _
       REG10, REG11, REG12, REG13, REG14, REG15, REG16, REG17, REG18, REG19, REG1A, REG1B, REG1C, REG1D, REG1E, REG1F, _
       REG20, REG21, REG22, REG23, REG24, REG25, REG26, REG27, REG28, REG29, REG2A, REG2B, REG2C, REG2D, REG2E, REG2F, _
       REG30, REG31, REG32, REG33, REG34, REG35, REG36, REG37, REG38, REG39, REG3A, REG3B, REG3C, REG3D, REG3E, REG3F, _
       REG40, REG41, REG42, REG43, REG44, REG45, REG46, REG47, REG48, REG49, REG4A, REG4B, REG4C, REG4D, REG4E, REG4F, _
       REG50, REG51, REG52, REG53, REG54, REG55, REG56, REG57, REG58, REG59, REG5A, REG5B, REG5C, REG5D, REG5E, REG5F, _
       REG60, REG61, REG62, REG63, REG64, REG65, REG66, REG67, REG68, REG69, REG6A, REG6B, REG6C, REG6D, REG6E, REG6F, _
       REG70, REG71, REG72, REG73, REG74, REG75, REG76, REG77, REG78, REG79, REG7A, REG7B, REG7C, REG7D, REG7E, REG7F, _
 _
       REG80, REG81, REG82, REG83, REG84, REG85, REG86, REG87, REG88, REG89, REG8A, REG8B, REG8C, REG8D, REG8E, REG8F, _
       REG90, REG91, REG92, REG93, REG94, REG95, REG96, REG97, REG98, REG99, REG9A, REG9B, REG9C, REG9D, REG9E, REG9F, _
       REGA0, REGA1, REGA2, REGA3, REGA4, REGA5, REGA6, REGA7, REGA8, REGA9, REGAA, REGAB, REGAC, REGAD, REGAE, REGAF, _
       REGB0, REGB1, REGB2, REGB3, REGB4, REGB5, REGB6, REGB7, REGB8, REGB9, REGBA, REGBB, REGBC, REGBD, REGBE, REGBF, _
       REGC0, REGC1, REGC2, REGC3, REGC4, REGC5, REGC6, REGC7, REGC8, REGC9, REGCA, REGCB, REGCC, REGCD, REGCE, REGCF, _
       REGD0, REGD1, REGD2, REGD3, REGD4, REGD5, REGD6, REGD7, REGD8, REGD9, REGDA, REGDB, REGDC, REGDD, REGDE, REGDF, _
       REGE0, REGE1, REGE2, REGE3, REGE4, REGE5, REGE6, REGE7, REGE8, REGE9, REGEA, REGEB, REGEC, REGED, REGEE, REGEF, _
       REGF0, REGF1, REGF2, REGF3, REGF4, REGF5, REGF6, REGF7, REGF8, REGF9, REGFA, REGFB, REGFC, REGFD, REGFE, REGFF}

        TextBox3.Text = Mid(Str, 4, 2)
        TextBox2.Text = TextBox3.Text
        TextBox4.Text = REG(Integer.Parse(Val("&H" + (Mid(Str, 4, 2)) + "&"))).Text
        DEBUGTextBox1.Text &= "W " & TextBox3.Text & " " & TextBox4.Text & " "
        SendCMD(22)

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
        before = Timer()
        Do
            DoEvents()
        Loop Until (Int(Timer() - before) = ASecond)
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
            'strbuff = TextBox1.Text + Chr(13)  '自動傳送資料
            strbuff = ComboBox3.Text + Chr(13)  '自動傳送資料

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
            strbuff = "CMDR" + " " + TextBox1.Text + " " + TextBox2.Text + " " + Chr(13)  'CMD Read
        ElseIf idx = 22 Then
            Me.rtbReceived.Text = ""
            TextBox5.Text = "?" : CMD_Action = True
            strbuff = "CMDW" + " " + TextBox1.Text + " " + _
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
        SerialPort1.Close()
        Timer2.Enabled = False
        Timer1.Enabled = False
        Timer3.Enabled = False
        Me.Close()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Me.rtbReceived.Text = ""
        Label15.Text = ""
        'Me.DEBUGTextBox1.Text = ""
        'TextBox5.Text = "_"
    End Sub
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Me.DEBUGTextBox1.Text = ""
        Label15.Text = ""
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        SendCMD(16)
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Timer1.Enabled = False And ComboBox1.SelectedIndex <> 0 And ComboBox3.Text <> "" Then
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
            Button3.Text = "開始"
            Button3.BackColor = Color.Empty
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
        TextBox3.Text = TextBox2.Text
        SendCMD(21)
        'End If
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        '  If CMD_Action = False Then
        TextBox2.Text = TextBox3.Text
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
        If Asc(e.KeyChar) = 13 Then
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
        FW_ACTION = FW_TEST_WAITING
        Label15.Text = "WAITING"
        Label15.ForeColor = Color.Empty
        Timer5.Interval = 1000
        Timer5.Enabled = True
        SendCMD(7)
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        ' If e.KeyChar = Strings.ChrW(Keys.Return) Then
        Dim intNumber As Integer = 0
        TextBox1.Text = UCase(TextBox1.Text)

        intNumber = Val("&H" + (TextBox1.Text) + "&")

        TextBox1.Text = Hex(intNumber)

        If intNumber >= 255 Then
            intNumber = 255
            TextBox1.Text = Hex(intNumber)
        ElseIf intNumber <= 0 Then
            intNumber = 0
            TextBox1.Text = Hex(intNumber)
        End If
        '  End If
    End Sub


    Private Sub TextBox2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress

        If Asc(e.KeyChar) = 13 Then
            Dim intNumber As Integer = 0
            TextBox2.Text = UCase(TextBox2.Text)

            intNumber = Val("&H" + (TextBox2.Text) + "&")

            TextBox2.Text = Hex(intNumber)

            If intNumber >= 255 Then
                intNumber = 255
                TextBox2.Text = Hex(intNumber)
            ElseIf intNumber <= 0 Then
                intNumber = 0
                TextBox2.Text = Hex(intNumber)
            End If

            TextBox3.Text = TextBox2.Text
            SendCMD(21)

        End If
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Dim intNumber As Integer = 0
            TextBox3.Text = UCase(TextBox3.Text)

            intNumber = Val("&H" + (TextBox3.Text) + "&")

            TextBox3.Text = Hex(intNumber)

            If intNumber >= 255 Then
                intNumber = 255
                TextBox3.Text = Hex(intNumber)
            ElseIf intNumber <= 0 Then
                intNumber = 0
                TextBox3.Text = Hex(intNumber)
            End If
            TextBox2.Text = TextBox3.Text
            SendCMD(22)
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged

        If ComboBox2.SelectedIndex = 0 Then
            TextBox1.Text = "40"
        ElseIf ComboBox2.SelectedIndex = 1 Then
            TextBox1.Text = "88"
        ElseIf ComboBox2.SelectedIndex = 2 Then
            TextBox1.Text = "A0"
        ElseIf ComboBox2.SelectedIndex = 3 Then
            TextBox1.Text = "12"
        End If

        Label14.Text = ComboBox2.Text

    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox4.SelectedIndexChanged
        If ComboBox4.SelectedIndex = 0 Then
            Me.rtbReceived.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        ElseIf ComboBox4.SelectedIndex = 1 Then
            Me.rtbReceived.Font = New System.Drawing.Font("新細明體", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        ElseIf ComboBox4.SelectedIndex = 2 Then
            Me.rtbReceived.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        ElseIf ComboBox4.SelectedIndex = 3 Then
            Me.rtbReceived.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        ElseIf ComboBox4.SelectedIndex = 4 Then
            Me.rtbReceived.Font = New System.Drawing.Font("新細明體", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        ElseIf ComboBox4.SelectedIndex = 5 Then
            Me.rtbReceived.Font = New System.Drawing.Font("新細明體", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        ElseIf ComboBox4.SelectedIndex = 6 Then
            Me.rtbReceived.Font = New System.Drawing.Font("新細明體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Else
            Me.rtbReceived.Font = New System.Drawing.Font("新細明體", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        End If
    End Sub
    Private Sub ComboBox5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox5.SelectedIndexChanged
        If ComboBox5.SelectedIndex = 0 Then
            Me.DEBUGTextBox1.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        ElseIf ComboBox5.SelectedIndex = 1 Then
            Me.DEBUGTextBox1.Font = New System.Drawing.Font("新細明體", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        ElseIf ComboBox5.SelectedIndex = 2 Then
            Me.DEBUGTextBox1.Font = New System.Drawing.Font("新細明體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        ElseIf ComboBox5.SelectedIndex = 3 Then
            Me.DEBUGTextBox1.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        ElseIf ComboBox5.SelectedIndex = 4 Then
            Me.DEBUGTextBox1.Font = New System.Drawing.Font("新細明體", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        ElseIf ComboBox5.SelectedIndex = 5 Then
            Me.DEBUGTextBox1.Font = New System.Drawing.Font("新細明體", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        ElseIf ComboBox5.SelectedIndex = 6 Then
            Me.DEBUGTextBox1.Font = New System.Drawing.Font("新細明體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Else
            Me.DEBUGTextBox1.Font = New System.Drawing.Font("新細明體", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        End If
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Dump_Start = 0
        Dump_End = &HFF&  '0~255
        Dump_Loop = Dump_Start
        RW_REG_Action = REG_READ_MODE  'dump mode
        TextBox2.Text = Hex(Dump_Loop)
        SendCMD(21)
        Button14.Enabled = False
        Button15.Enabled = False
        btnREGGroup.Enabled = False
    End Sub


    Private Sub frmMain_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If TabControl1.Enabled = True And CheckBox1.Checked = True Then

            If UCase(e.KeyChar) = Strings.ChrW(Keys.F) Then
                SendCMD(7)
                FW_ACTION = FW_TEST_WAITING
                Label15.Text = "WAITING"
                Label15.ForeColor = Color.Empty
                Timer5.Interval = 1000
                Timer5.Enabled = True
            ElseIf UCase(e.KeyChar) = Strings.ChrW(Keys.M) Then
                SendCMD(16)
            ElseIf UCase(e.KeyChar) = Strings.ChrW(Keys.J) Then
                SendCMD(20)
            ElseIf UCase(e.KeyChar) = Strings.ChrW(Keys.S) Then
                SendCMD(19)
            ElseIf UCase(e.KeyChar) = Strings.ChrW(Keys.U) Then
                SendCMD(17)
            ElseIf UCase(e.KeyChar) = Strings.ChrW(Keys.D) Then
                SendCMD(18)
            ElseIf Asc(e.KeyChar) = 46 Then   '.
                Dim intNumber As Integer = 0
                intNumber = Val("&H" + TextBox4.Text + "&")
                If intNumber >= 255 Then
                    intNumber = 255
                    TextBox4.Text = Hex(intNumber)
                Else
                    TextBox4.Text = Hex(intNumber + 1)
                End If
                SendCMD(22)
            ElseIf Asc(e.KeyChar) = 44 Then     ',
                Dim intNumber As Integer = 0
                intNumber = Val("&H" + TextBox4.Text + "&")
                If intNumber <= 0 Then
                    intNumber = 0
                    TextBox4.Text = Hex(intNumber)
                Else
                    TextBox4.Text = Hex(intNumber - 1)
                End If
                SendCMD(22)
            ElseIf Asc(e.KeyChar) = 60 Then     '<
                Dim intNumber As Integer = 0
                intNumber = Val("&H" + TextBox4.Text + "&")
                If intNumber < 16 Then
                    intNumber = 0
                    TextBox4.Text = Hex(intNumber)
                Else
                    TextBox4.Text = Hex(intNumber - 16)
                End If
                SendCMD(22)
            ElseIf Asc(e.KeyChar) = 62 Then     '>
                Dim intNumber As Integer = 0
                intNumber = Val("&H" + TextBox4.Text + "&")
                If intNumber > 255 - 16 Then
                    intNumber = 255
                    TextBox4.Text = Hex(intNumber)
                Else
                    TextBox4.Text = Hex(intNumber + 16)
                End If
                SendCMD(22)
            End If
            If UCase(e.KeyChar) = Strings.ChrW(Keys.E) Then
                ExitAPP()
            End If
        End If

    End Sub
    Sub ExitAPP()
        SerialPort1.Close()
        Timer2.Enabled = False
        Timer1.Enabled = False
        Timer3.Enabled = False
        Me.Close()
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click

#Const FileModeAppend = 0
        Dim intSaveFileFlag As Boolean = False
        Dim REG() As TextBox = { _
        REG00, REG01, REG02, REG03, REG04, REG05, REG06, REG07, REG08, REG09, REG0A, REG0B, REG0C, REG0D, REG0E, REG0F, _
        REG10, REG11, REG12, REG13, REG14, REG15, REG16, REG17, REG18, REG19, REG1A, REG1B, REG1C, REG1D, REG1E, REG1F, _
        REG20, REG21, REG22, REG23, REG24, REG25, REG26, REG27, REG28, REG29, REG2A, REG2B, REG2C, REG2D, REG2E, REG2F, _
        REG30, REG31, REG32, REG33, REG34, REG35, REG36, REG37, REG38, REG39, REG3A, REG3B, REG3C, REG3D, REG3E, REG3F, _
        REG40, REG41, REG42, REG43, REG44, REG45, REG46, REG47, REG48, REG49, REG4A, REG4B, REG4C, REG4D, REG4E, REG4F, _
        REG50, REG51, REG52, REG53, REG54, REG55, REG56, REG57, REG58, REG59, REG5A, REG5B, REG5C, REG5D, REG5E, REG5F, _
        REG60, REG61, REG62, REG63, REG64, REG65, REG66, REG67, REG68, REG69, REG6A, REG6B, REG6C, REG6D, REG6E, REG6F, _
        REG70, REG71, REG72, REG73, REG74, REG75, REG76, REG77, REG78, REG79, REG7A, REG7B, REG7C, REG7D, REG7E, REG7F, _
 _
        REG80, REG81, REG82, REG83, REG84, REG85, REG86, REG87, REG88, REG89, REG8A, REG8B, REG8C, REG8D, REG8E, REG8F, _
        REG90, REG91, REG92, REG93, REG94, REG95, REG96, REG97, REG98, REG99, REG9A, REG9B, REG9C, REG9D, REG9E, REG9F, _
        REGA0, REGA1, REGA2, REGA3, REGA4, REGA5, REGA6, REGA7, REGA8, REGA9, REGAA, REGAB, REGAC, REGAD, REGAE, REGAF, _
        REGB0, REGB1, REGB2, REGB3, REGB4, REGB5, REGB6, REGB7, REGB8, REGB9, REGBA, REGBB, REGBC, REGBD, REGBE, REGBF, _
        REGC0, REGC1, REGC2, REGC3, REGC4, REGC5, REGC6, REGC7, REGC8, REGC9, REGCA, REGCB, REGCC, REGCD, REGCE, REGCF, _
        REGD0, REGD1, REGD2, REGD3, REGD4, REGD5, REGD6, REGD7, REGD8, REGD9, REGDA, REGDB, REGDC, REGDD, REGDE, REGDF, _
        REGE0, REGE1, REGE2, REGE3, REGE4, REGE5, REGE6, REGE7, REGE8, REGE9, REGEA, REGEB, REGEC, REGED, REGEE, REGEF, _
        REGF0, REGF1, REGF2, REGF3, REGF4, REGF5, REGF6, REGF7, REGF8, REGF9, REGFA, REGFB, REGFC, REGFD, REGFE, REGFF}

        Dim FileNum As Integer
        Dim strTemp As String
        Dim strTemp2 As String = ""
        Dim DayString, TimeString As String '用來顯示日期與時間字串變數

#If FileModeAppend = 0 Then  '新建資料存檔
        FileNum = FreeFile()
        FileOpen(FileNum, My.Computer.FileSystem.CurrentDirectory() & "\dump.txt", OpenMode.Output)
        DayString = Format(Now, "yyyy/MM/dd") '指定DayString為時間格式為有西元年的日期
        TimeString = TimeOfDay.ToString("tt h:mm:ss ")
        strTemp = "," + DayString + Space(1) + TimeString '將結果Show在Label1(space(1)為空一格)
        PrintLine(FileNum, strTemp)
        strTemp2 &= strTemp & vbNewLine
        For index As Integer = 0 To REG.Count - 1
            strTemp = TextBox1.Text & "," & Mid(REG(index).Name, 4, 2) & "," & REG(index).Text
            PrintLine(FileNum, strTemp)
            strTemp2 &= strTemp & vbNewLine
        Next
        FileClose(FileNum)

        'fileSaveName = Application.GetSaveAsFilename(fileFilter:="Text Files (*.txt), *.txt")
        'If fileSaveName <> False Then
        '    MsgBox("Save as " & fileSaveName)
        'End If


        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Title = "另存新檔"
        saveFileDialog1.Filter = "TXT Files (*.txt*)|*.txt" '"*.txt;*.rtf|*.txt;*.rtf"
        saveFileDialog1.ShowDialog()
        Try
            'myFile = My.Computer.FileSystem.CurrentDirectory() & "\dump.txt"
            'My.Computer.FileSystem.WriteAllText(saveFileDialog1.FileName, "123 test", True)
            My.Computer.FileSystem.WriteAllText(saveFileDialog1.FileName, strTemp2, False)
            'rtbReceived.SaveFile(myFile, RichTextBoxStreamType.RichNoOleObjs)

            'Me.Text = myFile
            intSaveFileFlag = True

        Catch ex As Exception
            ' MsgBox("資料檔案未存檔")
        End Try
#Else    '增加資料存檔
        DayString = Format(Now, "yyyy/MM/dd") '指定DayString為時間格式為有西元年的日期
        TimeString = TimeOfDay.ToString("tt h:mm:ss ")

        If Mid(TimeString, 1, 2) = "上午" Then
            TimeString = "AM" & Mid(TimeString, 3, 9)
        ElseIf Mid(TimeString, 1, 2) = "下午" Then
            TimeString = "FM" & Mid(TimeString, 3, 9)
        End If

        strTemp = "," + DayString + Space(1) + TimeString & vbNewLine '將結果Show在Label1(space(1)為空一格)
        My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.CurrentDirectory() & "\dump.txt", strTemp, True)

        For index As Integer = 0 To REG.Count - 1
            strTemp = TextBox1.Text & "," & Mid(REG(index).Name, 4, 2) & "," & REG(index).Text & vbNewLine
            My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.CurrentDirectory() & "\dump.txt", strTemp, True)
        Next
#End If
        'DEBUGTextBox1.Text &= "存檔完畢!" & vbNewLine
#If FileModeAppend = False Then
        Try
            If intSaveFileFlag = False Then
                MsgBox("暫存器資料未存檔！", vbCritical)
            Else

                MsgBox("暫存器資料存檔完畢！", vbInformation)
            End If
        Catch ex As Exception

        End Try

#Else
        MsgBox("增加資料存檔完畢！")
#End If


    End Sub
    Sub REGKeyCheck(ByVal Index As Integer)
        Dim REG() As TextBox = { _
               REG00, REG01, REG02, REG03, REG04, REG05, REG06, REG07, REG08, REG09, REG0A, REG0B, REG0C, REG0D, REG0E, REG0F, _
               REG10, REG11, REG12, REG13, REG14, REG15, REG16, REG17, REG18, REG19, REG1A, REG1B, REG1C, REG1D, REG1E, REG1F, _
               REG20, REG21, REG22, REG23, REG24, REG25, REG26, REG27, REG28, REG29, REG2A, REG2B, REG2C, REG2D, REG2E, REG2F, _
               REG30, REG31, REG32, REG33, REG34, REG35, REG36, REG37, REG38, REG39, REG3A, REG3B, REG3C, REG3D, REG3E, REG3F, _
               REG40, REG41, REG42, REG43, REG44, REG45, REG46, REG47, REG48, REG49, REG4A, REG4B, REG4C, REG4D, REG4E, REG4F, _
               REG50, REG51, REG52, REG53, REG54, REG55, REG56, REG57, REG58, REG59, REG5A, REG5B, REG5C, REG5D, REG5E, REG5F, _
               REG60, REG61, REG62, REG63, REG64, REG65, REG66, REG67, REG68, REG69, REG6A, REG6B, REG6C, REG6D, REG6E, REG6F, _
               REG70, REG71, REG72, REG73, REG74, REG75, REG76, REG77, REG78, REG79, REG7A, REG7B, REG7C, REG7D, REG7E, REG7F, _
 _
               REG80, REG81, REG82, REG83, REG84, REG85, REG86, REG87, REG88, REG89, REG8A, REG8B, REG8C, REG8D, REG8E, REG8F, _
               REG90, REG91, REG92, REG93, REG94, REG95, REG96, REG97, REG98, REG99, REG9A, REG9B, REG9C, REG9D, REG9E, REG9F, _
               REGA0, REGA1, REGA2, REGA3, REGA4, REGA5, REGA6, REGA7, REGA8, REGA9, REGAA, REGAB, REGAC, REGAD, REGAE, REGAF, _
               REGB0, REGB1, REGB2, REGB3, REGB4, REGB5, REGB6, REGB7, REGB8, REGB9, REGBA, REGBB, REGBC, REGBD, REGBE, REGBF, _
               REGC0, REGC1, REGC2, REGC3, REGC4, REGC5, REGC6, REGC7, REGC8, REGC9, REGCA, REGCB, REGCC, REGCD, REGCE, REGCF, _
               REGD0, REGD1, REGD2, REGD3, REGD4, REGD5, REGD6, REGD7, REGD8, REGD9, REGDA, REGDB, REGDC, REGDD, REGDE, REGDF, _
               REGE0, REGE1, REGE2, REGE3, REGE4, REGE5, REGE6, REGE7, REGE8, REGE9, REGEA, REGEB, REGEC, REGED, REGEE, REGEF, _
               REGF0, REGF1, REGF2, REGF3, REGF4, REGF5, REGF6, REGF7, REGF8, REGF9, REGFA, REGFB, REGFC, REGFD, REGFE, REGFF}

        REG(Index).Text = UCase(REG(Index).Text)
        REG(Index).ForeColor = Color.Blue
        TextBox3.Text = Hex(Index)
        TextBox2.Text = TextBox3.Text
        TextBox4.Text = REG(Index).Text
        REGValueChenage = True
        SendCMD(22)


        ' DEBUGTextBox1.Text &= REG(Index).Name & "W=" & REG(Index).Text & vbNewLine



    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        Dim REG() As TextBox = { _
                      REG00, REG01, REG02, REG03, REG04, REG05, REG06, REG07, REG08, REG09, REG0A, REG0B, REG0C, REG0D, REG0E, REG0F, _
                      REG10, REG11, REG12, REG13, REG14, REG15, REG16, REG17, REG18, REG19, REG1A, REG1B, REG1C, REG1D, REG1E, REG1F, _
                      REG20, REG21, REG22, REG23, REG24, REG25, REG26, REG27, REG28, REG29, REG2A, REG2B, REG2C, REG2D, REG2E, REG2F, _
                      REG30, REG31, REG32, REG33, REG34, REG35, REG36, REG37, REG38, REG39, REG3A, REG3B, REG3C, REG3D, REG3E, REG3F, _
                      REG40, REG41, REG42, REG43, REG44, REG45, REG46, REG47, REG48, REG49, REG4A, REG4B, REG4C, REG4D, REG4E, REG4F, _
                      REG50, REG51, REG52, REG53, REG54, REG55, REG56, REG57, REG58, REG59, REG5A, REG5B, REG5C, REG5D, REG5E, REG5F, _
                      REG60, REG61, REG62, REG63, REG64, REG65, REG66, REG67, REG68, REG69, REG6A, REG6B, REG6C, REG6D, REG6E, REG6F, _
                      REG70, REG71, REG72, REG73, REG74, REG75, REG76, REG77, REG78, REG79, REG7A, REG7B, REG7C, REG7D, REG7E, REG7F, _
 _
                      REG80, REG81, REG82, REG83, REG84, REG85, REG86, REG87, REG88, REG89, REG8A, REG8B, REG8C, REG8D, REG8E, REG8F, _
                      REG90, REG91, REG92, REG93, REG94, REG95, REG96, REG97, REG98, REG99, REG9A, REG9B, REG9C, REG9D, REG9E, REG9F, _
                      REGA0, REGA1, REGA2, REGA3, REGA4, REGA5, REGA6, REGA7, REGA8, REGA9, REGAA, REGAB, REGAC, REGAD, REGAE, REGAF, _
                      REGB0, REGB1, REGB2, REGB3, REGB4, REGB5, REGB6, REGB7, REGB8, REGB9, REGBA, REGBB, REGBC, REGBD, REGBE, REGBF, _
                      REGC0, REGC1, REGC2, REGC3, REGC4, REGC5, REGC6, REGC7, REGC8, REGC9, REGCA, REGCB, REGCC, REGCD, REGCE, REGCF, _
                      REGD0, REGD1, REGD2, REGD3, REGD4, REGD5, REGD6, REGD7, REGD8, REGD9, REGDA, REGDB, REGDC, REGDD, REGDE, REGDF, _
                      REGE0, REGE1, REGE2, REGE3, REGE4, REGE5, REGE6, REGE7, REGE8, REGE9, REGEA, REGEB, REGEC, REGED, REGEE, REGEF, _
                      REGF0, REGF1, REGF2, REGF3, REGF4, REGF5, REGF6, REGF7, REGF8, REGF9, REGFA, REGFB, REGFC, REGFD, REGFE, REGFF}

        ' 例：從 Test.txt 檔案中讀取資料
        Dim FileNum As Integer
        Dim strTemp As String = ""
        Dim strTemp2 As String = ""
        'FileNum = FreeFile()
        'FileOpen(FileNum, My.Computer.FileSystem.CurrentDirectory() & "\dump.txt", OpenMode.Input)
        ''Do Until EOF(FileNum)
        'strTemp &= LineInput(FileNum) & vbNewLine
        ''Loop
        'DEBUGTextBox1.Text &= strTemp
        'FileClose(FileNum)

        Dim openFileDialog1 As New OpenFileDialog()
        Dim intStringNumber As Integer = 0

        openFileDialog1.Title = "開啟檔案"
        openFileDialog1.Filter = "TXT Files (*.txt*)|*.txt" '"*.txt;*.rtf|*.txt;*.rtf"
        openFileDialog1.ShowDialog()
        Try
            'myFile = My.Computer.FileSystem.CurrentDirectory() & "\dump.txt"
            'My.Computer.FileSystem.WriteAllText(saveFileDialog1.FileName, "123 test", True)
            strTemp2 = My.Computer.FileSystem.ReadAllText(openFileDialog1.FileName)
            'rtbReceived.SaveFile(myFile, RichTextBoxStreamType.RichNoOleObjs)

            FileNum = FreeFile()
            FileOpen(FileNum, openFileDialog1.FileName, OpenMode.Input)

            Do Until EOF(FileNum)
                strTemp = LineInput(FileNum) '& vbNewLine
                intStringNumber = InStr(1, strTemp, TextBox1.Text)
                If intStringNumber Then

                    If REG(Integer.Parse(Val("&H" + Mid(strTemp, 1 + 3, 2) + "&"))).Text <> Mid(strTemp, 1 + 6, 2) Then
                        REG(Integer.Parse(Val("&H" + Mid(strTemp, 1 + 3, 2) + "&"))).ForeColor = Color.Red
                    Else
                        REG(Integer.Parse(Val("&H" + Mid(strTemp, 1 + 3, 2) + "&"))).ForeColor = Color.Empty
                    End If

                    REG(Integer.Parse(Val("&H" + Mid(strTemp, 1 + 3, 2) + "&"))).Text = Mid(strTemp, 1 + 6, 2)

                    'DEBUGTextBox1.Text &= Mid(strTemp, 1 + 3, 2) & " " & Mid(strTemp, 1 + 6, 2) & vbNewLine
                    DEBUGTextBox1.Text &= strTemp & vbNewLine
                End If
            Loop

            'DEBUGTextBox1.Text &= strTemp
            FileClose(FileNum)

            'DEBUGTextBox1.Text &= strTemp2

            'Me.Text = myFile
            ' intSaveFileFlag = True
        Catch ex As Exception
            ' MsgBox("資料檔案未存檔")
        End Try



    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click

        Dim REG() As TextBox = { _
                      REG00, REG01, REG02, REG03, REG04, REG05, REG06, REG07, REG08, REG09, REG0A, REG0B, REG0C, REG0D, REG0E, REG0F, _
                      REG10, REG11, REG12, REG13, REG14, REG15, REG16, REG17, REG18, REG19, REG1A, REG1B, REG1C, REG1D, REG1E, REG1F, _
                      REG20, REG21, REG22, REG23, REG24, REG25, REG26, REG27, REG28, REG29, REG2A, REG2B, REG2C, REG2D, REG2E, REG2F, _
                      REG30, REG31, REG32, REG33, REG34, REG35, REG36, REG37, REG38, REG39, REG3A, REG3B, REG3C, REG3D, REG3E, REG3F, _
                      REG40, REG41, REG42, REG43, REG44, REG45, REG46, REG47, REG48, REG49, REG4A, REG4B, REG4C, REG4D, REG4E, REG4F, _
                      REG50, REG51, REG52, REG53, REG54, REG55, REG56, REG57, REG58, REG59, REG5A, REG5B, REG5C, REG5D, REG5E, REG5F, _
                      REG60, REG61, REG62, REG63, REG64, REG65, REG66, REG67, REG68, REG69, REG6A, REG6B, REG6C, REG6D, REG6E, REG6F, _
                      REG70, REG71, REG72, REG73, REG74, REG75, REG76, REG77, REG78, REG79, REG7A, REG7B, REG7C, REG7D, REG7E, REG7F, _
 _
                      REG80, REG81, REG82, REG83, REG84, REG85, REG86, REG87, REG88, REG89, REG8A, REG8B, REG8C, REG8D, REG8E, REG8F, _
                      REG90, REG91, REG92, REG93, REG94, REG95, REG96, REG97, REG98, REG99, REG9A, REG9B, REG9C, REG9D, REG9E, REG9F, _
                      REGA0, REGA1, REGA2, REGA3, REGA4, REGA5, REGA6, REGA7, REGA8, REGA9, REGAA, REGAB, REGAC, REGAD, REGAE, REGAF, _
                      REGB0, REGB1, REGB2, REGB3, REGB4, REGB5, REGB6, REGB7, REGB8, REGB9, REGBA, REGBB, REGBC, REGBD, REGBE, REGBF, _
                      REGC0, REGC1, REGC2, REGC3, REGC4, REGC5, REGC6, REGC7, REGC8, REGC9, REGCA, REGCB, REGCC, REGCD, REGCE, REGCF, _
                      REGD0, REGD1, REGD2, REGD3, REGD4, REGD5, REGD6, REGD7, REGD8, REGD9, REGDA, REGDB, REGDC, REGDD, REGDE, REGDF, _
                      REGE0, REGE1, REGE2, REGE3, REGE4, REGE5, REGE6, REGE7, REGE8, REGE9, REGEA, REGEB, REGEC, REGED, REGEE, REGEF, _
                      REGF0, REGF1, REGF2, REGF3, REGF4, REGF5, REGF6, REGF7, REGF8, REGF9, REGFA, REGFB, REGFC, REGFD, REGFE, REGFF}
        For index As Integer = 0 To 255
            REG(index).Text = "00"
            REG(index).ForeColor = Color.Empty
        Next

    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        WriteREG_Start = 0
        WriteREG_End = &HFF&  '0~255
        WriteREG_Loop = WriteREG_Start
        RW_REG_Action = REG_WRITE_MODE   'Write mode
        TextBox3.Text = Hex(WriteREG_Loop)
        TextBox4.Text = REG00.Text
        btnREGGroup.Enabled = False
        DEBUGTextBox1.Text &= "W " & TextBox3.Text & " " & TextBox4.Text & " "
        SendCMD(22)
        'Button14.Enabled = False
        'Button15.Enabled = False
        'TabControl1.Enabled = False
    End Sub

    Private Sub REG00_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles REG00.KeyPress, REGFF.KeyPress, REGFE.KeyPress, REGFD.KeyPress, REGFC.KeyPress, REGFB.KeyPress, REGFA.KeyPress, REGF9.KeyPress, REGF8.KeyPress, REGF7.KeyPress, REGF6.KeyPress, REGF5.KeyPress, REGF4.KeyPress, REGF3.KeyPress, REGF2.KeyPress, REGF1.KeyPress, REGF0.KeyPress, REGEF.KeyPress, REGEE.KeyPress, REGED.KeyPress, REGEC.KeyPress, REGEB.KeyPress, REGEA.KeyPress, REGE9.KeyPress, REGE8.KeyPress, REGE7.KeyPress, REGE6.KeyPress, REGE5.KeyPress, REGE4.KeyPress, REGE3.KeyPress, REGE2.KeyPress, REGE1.KeyPress, REGE0.KeyPress, REGDF.KeyPress, REGDE.KeyPress, REGDD.KeyPress, REGDC.KeyPress, REGDB.KeyPress, REGDA.KeyPress, REGD9.KeyPress, REGD8.KeyPress, REGD7.KeyPress, REGD6.KeyPress, REGD5.KeyPress, REGD4.KeyPress, REGD3.KeyPress, REGD2.KeyPress, REGD1.KeyPress, REGD0.KeyPress, REGCF.KeyPress, REGCE.KeyPress, REGCD.KeyPress, REGCC.KeyPress, REGCB.KeyPress, REGCA.KeyPress, REGC9.KeyPress, REGC8.KeyPress, REGC7.KeyPress, REGC6.KeyPress, REGC5.KeyPress, REGC4.KeyPress, REGC3.KeyPress, REGC2.KeyPress, REGC1.KeyPress, REGC0.KeyPress, REGBF.KeyPress, REGBE.KeyPress, REGBD.KeyPress, REGBC.KeyPress, REGBB.KeyPress, REGBA.KeyPress, REGB9.KeyPress, REGB8.KeyPress, REGB7.KeyPress, REGB6.KeyPress, REGB5.KeyPress, REGB4.KeyPress, REGB3.KeyPress, REGB2.KeyPress, REGB1.KeyPress, REGB0.KeyPress, REGAF.KeyPress, REGAE.KeyPress, REGAD.KeyPress, REGAC.KeyPress, REGAB.KeyPress, REGAA.KeyPress, REGA9.KeyPress, REGA8.KeyPress, REGA7.KeyPress, REGA6.KeyPress, REGA5.KeyPress, REGA4.KeyPress, REGA3.KeyPress, REGA2.KeyPress, REGA1.KeyPress, REGA0.KeyPress, REG9F.KeyPress, REG9E.KeyPress, REG9D.KeyPress, REG9C.KeyPress, REG9B.KeyPress, REG9A.KeyPress, REG99.KeyPress, REG98.KeyPress, REG97.KeyPress, REG96.KeyPress, REG95.KeyPress, REG94.KeyPress, REG93.KeyPress, REG92.KeyPress, REG91.KeyPress, REG90.KeyPress, REG8F.KeyPress, REG8E.KeyPress, REG8D.KeyPress, REG8C.KeyPress, REG8B.KeyPress, REG8A.KeyPress, REG89.KeyPress, REG88.KeyPress, REG87.KeyPress, REG86.KeyPress, REG85.KeyPress, REG84.KeyPress, REG83.KeyPress, REG82.KeyPress, REG81.KeyPress, REG80.KeyPress, REG7F.KeyPress, REG7E.KeyPress, REG7D.KeyPress, REG7C.KeyPress, REG7B.KeyPress, REG7A.KeyPress, REG79.KeyPress, REG78.KeyPress, REG77.KeyPress, REG76.KeyPress, REG75.KeyPress, REG74.KeyPress, REG73.KeyPress, REG72.KeyPress, REG71.KeyPress, REG70.KeyPress, REG6F.KeyPress, REG6E.KeyPress, REG6D.KeyPress, REG6C.KeyPress, REG6B.KeyPress, REG6A.KeyPress, REG69.KeyPress, REG68.KeyPress, REG67.KeyPress, REG66.KeyPress, REG65.KeyPress, REG64.KeyPress, REG63.KeyPress, REG62.KeyPress, REG61.KeyPress, REG60.KeyPress, REG5F.KeyPress, REG5E.KeyPress, REG5D.KeyPress, REG5C.KeyPress, REG5B.KeyPress, REG5A.KeyPress, REG59.KeyPress, REG58.KeyPress, REG57.KeyPress, REG56.KeyPress, REG55.KeyPress, REG54.KeyPress, REG53.KeyPress, REG52.KeyPress, REG51.KeyPress, REG50.KeyPress, REG4F.KeyPress, REG4E.KeyPress, REG4D.KeyPress, REG4C.KeyPress, REG4B.KeyPress, REG4A.KeyPress, REG49.KeyPress, REG48.KeyPress, REG47.KeyPress, REG46.KeyPress, REG45.KeyPress, REG44.KeyPress, REG43.KeyPress, REG42.KeyPress, REG41.KeyPress, REG40.KeyPress, REG3F.KeyPress, REG3E.KeyPress, REG3D.KeyPress, REG3C.KeyPress, REG3B.KeyPress, REG3A.KeyPress, REG39.KeyPress, REG38.KeyPress, REG37.KeyPress, REG36.KeyPress, REG35.KeyPress, REG34.KeyPress, REG33.KeyPress, REG32.KeyPress, REG31.KeyPress, REG30.KeyPress, REG2F.KeyPress, REG2E.KeyPress, REG2D.KeyPress, REG2C.KeyPress, REG2B.KeyPress, REG2A.KeyPress, REG29.KeyPress, REG28.KeyPress, REG27.KeyPress, REG26.KeyPress, REG25.KeyPress, REG24.KeyPress, REG23.KeyPress, REG22.KeyPress, REG21.KeyPress, REG20.KeyPress, REG1F.KeyPress, REG1E.KeyPress, REG1D.KeyPress, REG1C.KeyPress, REG1B.KeyPress, REG1A.KeyPress, REG19.KeyPress, REG18.KeyPress, REG17.KeyPress, REG16.KeyPress, REG15.KeyPress, REG14.KeyPress, REG13.KeyPress, REG12.KeyPress, REG11.KeyPress, REG10.KeyPress, REG0F.KeyPress, REG0E.KeyPress, REG0D.KeyPress, REG0C.KeyPress, REG0B.KeyPress, REG0A.KeyPress, REG09.KeyPress, REG08.KeyPress, REG07.KeyPress, REG06.KeyPress, REG05.KeyPress, REG04.KeyPress, REG03.KeyPress, REG02.KeyPress, REG01.KeyPress

        '接著就是把該物件的Id顯示出來
        Dim txt As TextBox = CType(sender, TextBox)
        'PRINT(txt.Name)
        If Asc(e.KeyChar) = 13 Then
            WRITEREGDATA(txt.Name)
        End If




    End Sub


    Private Sub Timer5_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer5.Tick
        If FW_ACTION = FW_TEST_WAITING Then
            Label15.Text = "NG"
            Label15.ForeColor = Color.Red
            FW_ACTION = FW_TEST_NG
            Timer5.Interval = 5000
        ElseIf FW_ACTION = FW_TEST_PASS Then
            Label15.Text = "PASS"
            Label15.ForeColor = Color.Green
            FW_ACTION = FW_TEST_NO
            Timer5.Interval = 5000
        Else
            Label15.Text = ""
            Label15.ForeColor = Color.Empty
            Timer5.Interval = 1000
            Timer5.Enabled = False
        End If

    End Sub

    Private Sub TextBox6_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox6.KeyPress
        If Asc(e.KeyChar) = 13 Then            
            If SerialPort1.IsOpen = True Then
                SerialPort1.Write(TextBox6.Text + Chr(13))
            End If
        End If
    End Sub

    Private Sub TextBox6_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextBox6.MouseClick
        TextBox6.Text = ""
    End Sub
End Class
'Whole Code Ends Here ....