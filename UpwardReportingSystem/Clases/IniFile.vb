Imports System.Runtime.InteropServices
Imports System.Text

Imports System.IO

Public Class IniFile
    Private iniPath As String

    ' Declare the GetPrivateProfileString API function from kernel32.dll
    <DllImport("kernel32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function GetPrivateProfileString(
        ByVal lpAppName As String,
        ByVal lpKeyName As String,
        ByVal lpDefault As String,
        ByVal lpReturnedString As StringBuilder,
        ByVal nSize As Integer,
        ByVal lpFileName As String) As Integer
    End Function

    ' Constructor that sets the path to the INI file
    Public Sub New(ByVal path As String)
        iniPath = path
    End Sub

    ' Method to read a value from the INI file
    Public Function ReadValue(ByVal section As String, ByVal key As String) As String
        Dim sb As New StringBuilder(255)
        Dim result As Integer = GetPrivateProfileString(section, key, Nothing, sb, sb.Capacity, iniPath)

        ' Debug output
        Console.WriteLine("Reading from INI file: {iniPath}")
        Console.WriteLine("Section: {section}, Key: {key}, Result Count: {result}")
        If result > 0 Then
            Console.WriteLine("Value retrieved: " & sb.ToString())
        Else
            Console.WriteLine("No value found or error occurred.")
        End If

        Return sb.ToString()
    End Function
End Class

