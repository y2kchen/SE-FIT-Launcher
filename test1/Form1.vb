Imports System
Imports System.Diagnostics
Imports System.ComponentModel
Imports System.IO





Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Form1_Activated(sender, e)
    End Sub

    Private Sub RichTextBox1_Enter(sender As Object, e As EventArgs) Handles RichTextBox1.Enter
        
    End Sub

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        'Static Dim n As Integer = 0
        Static Dim maxProcessorAffinity As Integer = 0
        Static Dim cores As Integer = 0
        Dim i, id, core64(64) As Integer
        Button2.Enabled = True
        Try
            If maxProcessorAffinity = 0 Then
                'n += 1
                ' Get all processes running on the local computer. 
                Dim localAll As Process() = Process.GetProcesses()

                For Each p As Process In localAll
                    Try
                        If maxProcessorAffinity < p.ProcessorAffinity.ToInt64 Then
                            maxProcessorAffinity = p.ProcessorAffinity.ToInt64
                        End If
                    Catch ex As Exception

                    End Try
                Next

                Dim temp = maxProcessorAffinity
                While temp > 0
                    temp \= 2
                    cores += 1
                End While
                Me.Text = "SE-FIT Launcher detects " + cores.ToString + " cores."
                Label2.Text = "(0 - " + (cores - 1).ToString + ")"
                NumericUpDown1.Maximum = cores - 1
            End If
            RichTextBox1.Clear()
            For id = 0 To cores - 1
                core64(id) = 0
            Next
            Dim localByName As Process() = Process.GetProcessesByName("SE-FIT")
            If localByName.Length > 0 Then
                For Each p As Process In localByName
                    RichTextBox1.AppendText("SE-FIT process " + p.Id.ToString + ", affinity: " + p.ProcessorAffinity.ToString() + ", core: ")
                    i = 1
                    id = 0
                    While id < cores
                        If p.ProcessorAffinity.ToInt64 And i Then
                            RichTextBox1.AppendText(id.ToString + "  ")
                            core64(id) += 1
                        End If
                        i = i * 2
                        id += 1
                    End While
                    RichTextBox1.AppendText(vbNewLine)
                Next
            Else

            End If
            id = 0
            For i = 1 To cores - 1 Step 1
                If core64(id) > core64(i) Then
                    id = i
                End If
            Next
            NumericUpDown1.Value = id
            'RichTextBox1.AppendText("Target core # " + id.ToString + vbNewLine)

        Catch ex As Exception
            Button2.Enabled = False
            MessageBox.Show("Could not access process list.", "Error!")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1_Activated(sender, e)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim a As String = ""
        Dim z, x As Integer
        z = 0
        x = NumericUpDown1.Value
        While x > 3
            x = x - 4
            z += 1
        End While
        Select Case x
            Case 0
                a = "1"
            Case 1
                a = "2"
            Case 2
                a = "4"
            Case 3
                a = "8"
        End Select
        While z > 0
            z -= 1
            a += "0"
        End While
        'Me.Text = a
        'System.Diagnostics.Process.Start()
        '"C:\Windows\System32\cmd.exe /C START /high /affinity 1 SE-FIT.exe"
        If Not File.Exists("SE-FIT.exe") Then
            MessageBox.Show("Could not find SE-FIT.exe in the current directory.", "Error!")
            Return
        End If
        Try
            Dim gSEProcess As Process = New Process
            With gSEProcess.StartInfo
                .FileName = "cmd.exe"
                '.FileName = "C:\Windows\System32\cmd.exe"
                '.Arguments = "/C START /high /affinity " + a + " SE-FIT.exe"
                .Arguments = "/C START /affinity " + a + " SE-FIT.exe"
                .UseShellExecute = False
                .CreateNoWindow = True
                '.RedirectStandardOutput = True
                '.RedirectStandardError = True
                '.RedirectStandardInput = True
                '.WorkingDirectory = bwdpath
                '.WindowStyle = ProcessWindowStyle.Hidden
                'If 1 Then
                '  gSEProcess.ProcessorAffinity = Marshal.ReadInt64(gProcessorAffinity)
                'End If
                '.Arguments = ""
                '.CreateNoWindow = False
                '.RedirectStandardOutput = False ' WITHOUT THIS LEVOLVER FREEZES AFTER REPEATED DUMP COMMANDS!
                '.RedirectStandardError = False
                '.RedirectStandardInput = False
                '.WindowStyle = ProcessWindowStyle.Normal
            End With
            'Start evolver.exe in the background
            gSEProcess.Start()
        Catch ex As Exception
            MessageBox.Show("Could not find SE-FIT.exe in the current directory.", "Error!")
        End Try

    End Sub
End Class
