Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim File As String = "C:\Windows\System32\Drivers\etc\hosts"
        'Dim File As String = "C:\\testfile.txt"
        hostspath.Text = File
        Dim url As String = urlbox.Text

    End Sub

    Private Sub browsefile_Click(sender As Object, e As EventArgs) Handles browsefile.Click

        OpenFileDialog1.Title = "Please Select a File"
        OpenFileDialog1.InitialDirectory = "C:\Windows\System32\Drivers\etc\"
        OpenFileDialog1.ShowDialog()

    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Dim strm As System.IO.Stream
        strm = OpenFileDialog1.OpenFile()
        hostspath.Text = OpenFileDialog1.FileName.ToString()
        If Not (strm Is Nothing) Then
            strm.Close()
            If hostspath.Text.Contains("hosts") Then
                hosterror.Text = " "
                Dim File As String = hostspath.Text

            Else
                Dim File As String = " "
                hostspath.Text = " "
                hosterror.ForeColor = Color.Red
                hosterror.Text = "This is not a valid hosts file."
            End If
        End If

    End Sub


    Private Sub addbutt_Click(sender As Object, e As EventArgs) Handles addbutt.Click

        'Set Strings
        Dim File As String = hostspath.Text
        Dim url As String = urlbox.Text

        If hostspath.Text = " " Then
            hosterror.ForeColor = Color.Red
            hosterror.Text = "Please enter a hosts file!"
            urlbox.Text = " "
        Else
            'If the urlbox is blank, Display Error
            If urlbox.Text = "" Or urlbox.Text = " " Then
                urldisp.ForeColor = Color.Red
                Me.urldisp.Text = "Please enter a URL."
                urlbox.Text = " "
            Else

                'Read the file for any matching words
                'If exists, goto Error
                Dim lines() As String = Filter(System.IO.File.ReadAllLines(File), url)
                If UBound(lines) = -1 Then
                    Label12.ForeColor = Color.Coral
                    Me.urldisp.Text = url & " can be added!"
                    processbutt.Enabled = True
                Else
                    urldisp.ForeColor = Color.Red
                    Me.urldisp.Text = url & " already exists!"
                    urlbox.Text = " "
                    processbutt.Enabled = False
                End If

            End If
        End If

    End Sub


    Private Sub processbutt_Click_1(sender As Object, e As EventArgs) Handles processbutt.Click
        'Set Strings
        Dim File As String = hostspath.Text
        Dim url As String = urlbox.Text

        'Write to the file
        My.Computer.FileSystem.WriteAllText(File, Environment.NewLine & "#" & url & Environment.NewLine & "74.125.224.72 " & url & Environment.NewLine & "74.125.224.72 www." & url, True)
        Dim lines() As String = Filter(System.IO.File.ReadAllLines(File), url)
        If UBound(lines) = -1 Then
            MsgBox(url & " added successfully!")
        Else
            MsgBox(url & " was not added correctly", MsgBoxStyle.Exclamation, "Error")
        End If


    End Sub


    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
		'Showed an AboutBox
        'AboutBox1.Show()
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
		'Showed a form that read the read.me/readme.txt file
        'readme.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()

    End Sub
End Class
