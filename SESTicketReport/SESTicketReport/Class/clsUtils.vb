Imports System
Imports System.Globalization
Imports System.Threading
Imports System.Security.Cryptography
Imports System.Text
Imports System.Configuration

Public Class clsUtils
    Implements IDisposable

    '---Culture Info
    Dim specifier As String = "G"
    Dim culture As CultureInfo = CultureInfo.InvariantCulture

    Public Sub New()
        Thread.CurrentThread.CurrentCulture = New CultureInfo("en-US")
    End Sub

    Public Function GetDateTimeUTC() As DateTime
        Dim dateNow As Date = Date.Now
        Return TimeZoneInfo.ConvertTimeToUtc(dateNow)
    End Function

    Public Function IsServerOnline(ByVal ServerName As String) As Boolean
        Try

            Dim nMS As Integer = System.Configuration.ConfigurationManager.AppSettings("PingMS")

            If My.Computer.Network.Ping(ServerName) Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function FormataNumeroBD(strNumero As String) As String
        Return strNumero.Replace(".", "").Replace(",", ".")
    End Function

    Public Function RoundUD(ByVal numD As Decimal, _
                        ByVal places As Integer, _
                        ByVal UorD As Boolean) As Decimal

        'UorD - True = up, false = down
        Dim dr As Decimal
        Try
            Dim r As Decimal = CDec(10 ^ (places + 1)) 'raise to places + 1
            dr = Math.Truncate(r * numD)
            If UorD Then 'no adjustment for down
                'up
                dr += 5
            End If
            dr = Math.Truncate(dr / 10) * 10
            dr = dr / r
        Catch ex As Exception
            Stop
        End Try
        Return dr
    End Function

    Public Function IsInt(ByVal texto As String) As Boolean
        Try
            Convert.ToInt32(texto)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function ConcatDecimalStr(ByVal str As String, Optional QdeDecimal As Integer = 2) As String
        If str <> "" Then
            If IsInt(str) = True And QdeDecimal = 2 Then
                Return str & ".00"
            ElseIf IsInt(str) = True And QdeDecimal = 4 Then
                Return str & ".0000"
            Else
                Dim n As Double = Convert.ToDouble(str)
                Return n.ToString("n" & QdeDecimal & "")
            End If
        Else
            Return str
        End If
    End Function

    'Public Sub TextBoxMoeda(ByRef txt As TextBox)
    '    Dim n As String = String.Empty
    '    Dim v As Double = 0
    '    Dim ci As New CultureInfo("en-US")

    '    Try
    '        n = txt.Text.Replace(",", "").Replace(".", "")
    '        If n.Equals("") Then n = "000"
    '        n = n.PadLeft(3, "0")
    '        If n.Length > 3 And n.Substring(0, 1) = "0" Then n = n.Substring(1, n.Length - 1)

    '        v = Convert.ToDouble(n) / 100
    '        txt.Text = String.Format(ci, "{0:N}", v)

    '        txt.SelectionStart = txt.Text.Length

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "TextBoxMoeda")
    '    End Try

    '    'obs: Property textbox1_TextChanged
    'End Sub

    'Public Sub TextBoxDecimal(ByRef txt As TextBox)
    '    Dim n As String = String.Empty
    '    Dim v As Double = 0
    '    Dim ci As New CultureInfo("en-US")

    '    Try
    '        n = txt.Text.Replace(",", "").Replace(".", "")
    '        If n.Equals("") Then n = "000"
    '        n = n.PadLeft(3, "0")
    '        'If n.Length > 3 And n.Substring(0, 1) = "0" Then n = n.Substring(1, n.Length - 1)

    '        v = Convert.ToDouble(n) / 10000
    '        txt.Text = v.ToString("0.0000")
    '        'txt.Text = String.Format(ci, "%.3f", v)

    '        txt.SelectionStart = txt.Text.Length

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "TextBoxMoeda")
    '    End Try

    '    'obs: Property textbox1_TextChanged
    'End Sub

    'Public Sub AscTextOnlyNumber(ByRef TextBox As TextBox, ByRef e As KeyPressEventArgs, chrDecimal As String)
    '    If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = vbBack And Not e.KeyChar = chrDecimal Then e.Handled = True
    '    If e.KeyChar = chrDecimal And (InStr(TextBox.Text, chrDecimal)) > 0 Then e.Handled = True

    'End Sub

    Public Function TrataTxtData(sDate As String) As Object
        If sDate <> "  /  /" And sDate <> "12:00:00 AM" And sDate <> "00:00:00" Then
            Return CDate(sDate)
        Else
            Return Nothing
        End If
    End Function

    Public Function TrataTxtInt(sNumero As String) As Integer
        If sNumero <> "" Then
            Return CInt(sNumero)
        Else : Return 0
        End If
    End Function

    Public Function TrataDBNull(ByRef Param As Object) As Object

        If IsDBNull(Param) Then
            Return Nothing
        Else
            Return Param
        End If

    End Function

    Public Function SQLConvStrDate(strDate As String) As String

        If strDate <> "  /  /" And strDate <> "12:00:00 AM" And strDate <> "00:00:00" Then
            Dim timeFormat As String = "yyyy-MM-dd"
            Dim myDate As Date = CDate(strDate)
            Return ("'" + myDate.ToString(timeFormat) + "'")
        Else
            Return "NULL"
        End If

    End Function

    Public Function SQLConvStrDatetime(strDate As String) As String

        If strDate <> "  /  /" And strDate <> "12:00:00 AM" And strDate <> "00:00:00" Then
            Dim timeFormat As String = "yyyy-MM-dd hh:mm:ss tt"
            Dim myDate As Date = CDate(strDate)
            Return ("'" + myDate.ToString(timeFormat) + "'")
        Else
            Return "NULL"
        End If

    End Function

    Public Function SQLConvStrNull(Value As Object, ByVal bType As String) As String

        If IsDBNull(Value) Then
            Return "NULL"
            Exit Function
        End If


        If UCase(bType) = "S" Then
            If Value = "" Then
                Return "NULL"
            Else
                Return "'" + Replace(Value, "'", "''") + "'"
            End If
            Exit Function
        End If

        If UCase(bType) = "N" Then
            If Value.ToString = "" Then
                Return "NULL"
                Exit Function
            End If

            Dim num As Double = CDbl(Replace(Value, ",", ""))

            Return "" + num.ToString("N4").Replace(",", "") + ""
            Exit Function
        End If

        If UCase(bType) = "D" Then
            Dim dt As Date = Value
            Return "'" + dt.ToString + "'"
            Exit Function
        End If

        If UCase(bType) = "B" Then
            If Value = True Then
                Return "TRUE"
            ElseIf Value = False Then
                Return "FALSE"
            Else
                Return "NULL"
            End If
        End If

        If UCase(bType) = "B2" Then
            If Value = True Then
                Return 1
            ElseIf Value = False Then
                Return 0
            Else
                Return "NULL"
            End If
        End If


        Return "NULL"

    End Function

    Public Function isDate(ByVal Data As String) As Boolean

        Try

            Thread.CurrentThread.CurrentCulture = New CultureInfo("pt-BR")

            If Data <> "  /  /" Then
                Dim d As Date = Data

            End If
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function ConvertStrMD5(sInput As String) As String

        Dim md5 As MD5 = System.Security.Cryptography.MD5.Create()
        Dim inputBytes As Byte() = System.Text.Encoding.ASCII.GetBytes(sInput)
        Dim hash As Byte() = md5.ComputeHash(inputBytes)
        Dim sb As New StringBuilder()
        For i As Integer = 0 To hash.Length - 1
            sb.Append(hash(i).ToString("x2"))
        Next

        Return sb.ToString
    End Function


#Region "IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                ' TODO: dispose managed state (managed objects).
            End If

            ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
            ' TODO: set large fields to null.
        End If
        Me.disposedValue = True
    End Sub

    ' TODO: override Finalize() only if Dispose(ByVal disposing As Boolean) above has code to free unmanaged resources.
    'Protected Overrides Sub Finalize()
    '    ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
    '    Dispose(False)
    '    MyBase.Finalize()
    'End Sub

    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region

End Class
