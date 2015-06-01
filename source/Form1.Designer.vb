<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.hostspath = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.browsefile = New System.Windows.Forms.Button()
        Me.addbutt = New System.Windows.Forms.Button()
        Me.urlbox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.processbutt = New System.Windows.Forms.Button()
        Me.hosterror = New System.Windows.Forms.Label()
        Me.urldisp = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'hostspath
        '
        Me.hostspath.BackColor = System.Drawing.Color.Coral
        Me.hostspath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.hostspath.Enabled = False
        Me.hostspath.ForeColor = System.Drawing.Color.White
        Me.hostspath.Location = New System.Drawing.Point(84, 31)
        Me.hostspath.Name = "hostspath"
        Me.hostspath.Size = New System.Drawing.Size(174, 20)
        Me.hostspath.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(11, 31)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 13)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "hosts path:"
        '
        'browsefile
        '
        Me.browsefile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.browsefile.Location = New System.Drawing.Point(264, 27)
        Me.browsefile.Name = "browsefile"
        Me.browsefile.Size = New System.Drawing.Size(75, 24)
        Me.browsefile.TabIndex = 1
        Me.browsefile.Text = "Browse..."
        Me.browsefile.UseVisualStyleBackColor = True
        '
        'addbutt
        '
        Me.addbutt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addbutt.Location = New System.Drawing.Point(264, 84)
        Me.addbutt.Name = "addbutt"
        Me.addbutt.Size = New System.Drawing.Size(75, 26)
        Me.addbutt.TabIndex = 2
        Me.addbutt.Text = "Process"
        Me.addbutt.UseVisualStyleBackColor = True
        '
        'urlbox
        '
        Me.urlbox.BackColor = System.Drawing.Color.Coral
        Me.urlbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.urlbox.ForeColor = System.Drawing.Color.White
        Me.urlbox.Location = New System.Drawing.Point(114, 89)
        Me.urlbox.Name = "urlbox"
        Me.urlbox.Size = New System.Drawing.Size(144, 20)
        Me.urlbox.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Enter URL"
        '
        'processbutt
        '
        Me.processbutt.Enabled = False
        Me.processbutt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.processbutt.Location = New System.Drawing.Point(132, 151)
        Me.processbutt.Name = "processbutt"
        Me.processbutt.Size = New System.Drawing.Size(75, 24)
        Me.processbutt.TabIndex = 5
        Me.processbutt.Text = "Add!"
        Me.processbutt.UseVisualStyleBackColor = True
        '
        'hosterror
        '
        Me.hosterror.AutoSize = True
        Me.hosterror.BackColor = System.Drawing.Color.Transparent
        Me.hosterror.Location = New System.Drawing.Point(81, 64)
        Me.hosterror.Name = "hosterror"
        Me.hosterror.Size = New System.Drawing.Size(10, 13)
        Me.hosterror.TabIndex = 8
        Me.hosterror.Text = " "
        '
        'urldisp
        '
        Me.urldisp.AutoSize = True
        Me.urldisp.Location = New System.Drawing.Point(81, 119)
        Me.urldisp.Name = "urldisp"
        Me.urldisp.Size = New System.Drawing.Size(13, 13)
        Me.urldisp.TabIndex = 9
        Me.urldisp.Text = "  "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(74, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "www."
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.HelpToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(346, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.HelpToolStripMenuItem.Text = "Readme"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(346, 189)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.urldisp)
        Me.Controls.Add(Me.hosterror)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.hostspath)
        Me.Controls.Add(Me.processbutt)
        Me.Controls.Add(Me.browsefile)
        Me.Controls.Add(Me.urlbox)
        Me.Controls.Add(Me.addbutt)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.Color.Coral
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hosts Exception Adder"
        Me.TransparencyKey = System.Drawing.Color.Silver
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents hostspath As System.Windows.Forms.TextBox
    Friend WithEvents browsefile As System.Windows.Forms.Button
    Friend WithEvents addbutt As System.Windows.Forms.Button
    Friend WithEvents urlbox As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents processbutt As System.Windows.Forms.Button
    Friend WithEvents hosterror As System.Windows.Forms.Label
    Friend WithEvents urldisp As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FileSystemWatcher1 As System.IO.FileSystemWatcher
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
