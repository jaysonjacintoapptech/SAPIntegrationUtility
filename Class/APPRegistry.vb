Imports Microsoft.Win32
Public Class APPRegistry
    Private regKey As RegistryKey
    Private _Key As String
    Sub New(Key)
        _Key = Key
    End Sub
    Public Sub CreateKey()
        regKey = Registry.LocalMachine.OpenSubKey("SOFTWARE", True)
        regKey.CreateSubKey(_Key)
        regKey.Close()
    End Sub
    Public Sub CreateSubKey(ByRef Keyname As String, ByRef Keyvalue As String)
        regKey = Registry.LocalMachine.OpenSubKey("Software\\" & _Key & "", True)
        regKey.SetValue(Keyname, Keyvalue)
        regKey.Close()
    End Sub

    Public Function GetKeyValue(ByRef Keyname As String) As String
        Dim _Keyname As String
        Try
            If Not isExist() Then
                CreateSubKey(Keyname, "")
            Else
                regKey = Registry.LocalMachine.OpenSubKey("Software\\" & _Key & "", True)
                _Keyname = regKey.GetValue(Keyname)
                regKey.Close()
            End If
        Catch ex As Exception
            regKey = Registry.LocalMachine.OpenSubKey("Software\\" & _Key & "", True)
            _Keyname = regKey.GetValue(Keyname)
            regKey.Close()
        End Try
        Return _Keyname
    End Function
    Public Function isExist() As Boolean
        If Registry.LocalMachine.OpenSubKey("Software\\" & _Key & "", True) Is Nothing Then
            Return False
        End If
        Return True
    End Function
End Class
