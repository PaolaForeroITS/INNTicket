Imports System
Imports System.Globalization
Imports System.Threading
Imports System.Security.Cryptography
Imports System.Text
Imports System.Configuration

Public Class clsUtils
    Implements IDisposable

    Public Function GetDateTimeUTC(Optional ShortDate As Boolean = False) As String
        Dim dateNow As Date = Date.Now
        Dim str As String = SQLConvStrDatetime(TimeZoneInfo.ConvertTimeToUtc(dateNow))

        If ShortDate = True Then
            str = SQLConvStrDate(TimeZoneInfo.ConvertTimeToUtc(dateNow))
        Else
            str = SQLConvStrDatetime(TimeZoneInfo.ConvertTimeToUtc(dateNow))
        End If

        Return str
    End Function

    Public Function GetDateTime(Optional ShortDate As Boolean = False) As String
        Dim str As String
        If ShortDate = True Then
            str = SQLConvStrDate(DateTime.Now)
        Else
            str = SQLConvStrDatetime(DateTime.Now)
        End If
        Return str
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
            If IsInt(str.Replace(" ", "")) = True Then

                Dim sDecimal As String = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator

                If (QdeDecimal <= 2) Then
                    sDecimal = "00"
                ElseIf QdeDecimal = 3 Then
                    sDecimal = "000"
                ElseIf QdeDecimal = 4 Then
                    sDecimal = "0000"
                ElseIf QdeDecimal = 5 Then
                    sDecimal = "00000"
                End If

                Return str & sDecimal
            Else
                Dim n As Double = Convert.ToDouble(str.Replace(" ", ""))
                Return n.ToString("n" & QdeDecimal & "")
            End If
        Else
            Return str
        End If
    End Function

    Public Sub TextBoxMoeda(ByRef txt As TextBox, Optional decimals As Integer = 2, Optional enablecolor As Boolean = False)
        Dim n As String = String.Empty
        Dim v As Double = 0

        Try
            Dim len As Integer
            Dim format As String = ""
            Dim pad As String = ""
            Dim divby As Integer
            Dim simbol As String = ""

            If txt.Text.Contains("–") Or txt.Text.Contains("-") Then
                simbol = "- "
                If enablecolor = True Then
                    txt.ForeColor = Color.FromArgb(192, 0, 0)
                Else
                    txt.ForeColor = Color.Black
                End If

            Else
                txt.ForeColor = Color.Black
            End If

            If decimals = 2 Then
                len = 3
                pad = "000"
                format = "{0:N}"
                divby = 100
            ElseIf decimals = 3 Then
                len = 4
                format = "{0:N3}"
                pad = "0000"
                divby = 1000
            ElseIf decimals = 4 Then
                len = 5
                pad = "00000"
                format = "{0:N4}"
                divby = 10000
            ElseIf decimals = 5 Then
                len = 5
                pad = "00000"
                format = "{0:N5}"
                divby = 100000
            End If

            n = txt.Text.Replace(",", "").Replace(".", "").Replace("-", "").Replace("–", "").Replace(" ", "").Trim
            If n.Equals("") Then n = pad
            n = n.PadLeft(len, "0")
            If n.Length > len And n.Substring(0, 1) = "0" Then
                n = n.Substring(1, n.Length - 1)
            End If

            v = Convert.ToDouble(n) / divby
            txt.Text = simbol & String.Format(Thread.CurrentThread.CurrentCulture, format, v)

            txt.SelectionStart = txt.Text.Length

        Catch ex As Exception
            MessageBox.Show(ex.Message, "TextBoxMoeda")
        End Try

        'obs: Property textbox1_TextChanged
    End Sub

    Public Function GetNumberDecimal(ByVal num As Double, Optional DefaultNumberDecimals As Integer = 2) As Integer
        Dim posini As Integer
        Dim str As String
        Dim qde As Integer

        If IsInt(num) Then
            qde = DefaultNumberDecimals
        Else
            posini = num.ToString().IndexOf(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
            str = num.ToString().Substring(posini + 1, (num.ToString().Length() - (posini + 1)))
            qde = str.Length
            If qde < 2 Then
                qde = DefaultNumberDecimals
            End If
        End If
        Return qde
    End Function

    Public Sub DateTimePickerFormat(ByRef DateTimePicker As DateTimePicker, Optional InsertTime As Boolean = False)
        DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        DateTimePicker.CustomFormat = Application.CurrentCulture.DateTimeFormat.ShortDatePattern
        If InsertTime = True Then
            DateTimePicker.CustomFormat = DateTimePicker.CustomFormat + " HH:mm:ss"
        End If
    End Sub

    Public Function TrataDBNull(ByRef Param As Object) As Object

        If IsDBNull(Param) Then
            Return Nothing
        Else
            Return Param
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

            Dim dbl As Double = 1.2
            Dim symbDec As String = CStr(dbl).Substring(1, 1)
            Dim symbMil As String = IIf(CStr(dbl).Substring(1, 1) = ",", ".", ",")

            Dim num As Double = CDbl(Replace(Replace(Value, symbMil, ""), " ", ""))
            Dim newValue As String = "" + num.ToString("N5").Replace(symbMil, "").Replace(symbDec, ".") + ""
            Return newValue
            Exit Function

        End If

        If UCase(bType) = "D" Then
            If Value <> "" Then
                Dim dt As Date = Value
                Return "'" + dt.ToString + "'"
                Exit Function
            Else
                Return "NULL"
            End If
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

    '==================================================
    Public Function StrToNumber(ByVal str As String) As Double
        Dim dbl As Double = 1.2
        Dim symbDec As String = CStr(dbl).Substring(1, 1)
        Dim symbMil As String = IIf(CStr(dbl).Substring(1, 1) = ",", ".", ",")
        Dim num As Double = CDbl(Replace(Replace(str, symbMil, ""), " ", ""))
        Return num
    End Function

    Public Function FormatNumber(ByRef nNum As Double) As String
        Dim n As String = String.Empty
        Dim v As Double = 0

        Try

            Dim sValue As String = Me.ConcatDecimalStr(nNum)
            n = sValue.Replace(",", "").Replace(".", "")

            If nNum < 0 Then
                n = n.Replace("-", "")
            End If

            If n.Equals("") Then n = "000"
            n = n.PadLeft(3, "0")
            If n.Length > 3 And n.Substring(0, 1) = "0" Then n = n.Substring(1, n.Length - 1)

            v = Convert.ToDouble(n) / 100

            Dim str As String = ""

            If nNum < 0 Then
                str = ("- " + String.Format(Application.CurrentCulture, "{0:N}", v))
            Else
                str = String.Format(Application.CurrentCulture, "{0:N}", v)
            End If

            Return str

        Catch ex As Exception
            MessageBox.Show(ex.Message, "FormatNumber")
            Return ""
        End Try

    End Function

    Public Function SQLConvStrDate(strDate As String) As String
        Dim timeFormat As String = "yyyy-MM-dd"
        Dim myDate As Date = CDate(strDate)
        Return ("'" + myDate.ToString(timeFormat) + "'")
    End Function

    Public Function SQLConvStrDatetime(strDate As String) As String
        Dim timeFormat As String = "yyyy-MM-dd HH:mm:ss"
        Dim myDate As Date = CDate(strDate)
        Return ("'" + myDate.ToString(timeFormat) + "'")
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
