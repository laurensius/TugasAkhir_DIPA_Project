<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIParent1
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.KelolaPenggunaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KelolaPenggunaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.KelolaPetugasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerateKartuParkirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogPetugasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControlToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerifikasiKeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KelolaPenggunaToolStripMenuItem, Me.ControlToolStripMenuItem, Me.DisplayToolStripMenuItem, Me.VerifikasiKeluarToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(632, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'KelolaPenggunaToolStripMenuItem
        '
        Me.KelolaPenggunaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KelolaPenggunaToolStripMenuItem1, Me.KelolaPetugasToolStripMenuItem, Me.GenerateKartuParkirToolStripMenuItem, Me.LogPetugasToolStripMenuItem})
        Me.KelolaPenggunaToolStripMenuItem.Name = "KelolaPenggunaToolStripMenuItem"
        Me.KelolaPenggunaToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.KelolaPenggunaToolStripMenuItem.Text = "Kelola Data"
        '
        'KelolaPenggunaToolStripMenuItem1
        '
        Me.KelolaPenggunaToolStripMenuItem1.Name = "KelolaPenggunaToolStripMenuItem1"
        Me.KelolaPenggunaToolStripMenuItem1.Size = New System.Drawing.Size(185, 22)
        Me.KelolaPenggunaToolStripMenuItem1.Text = "Kelola Anggota"
        '
        'KelolaPetugasToolStripMenuItem
        '
        Me.KelolaPetugasToolStripMenuItem.Name = "KelolaPetugasToolStripMenuItem"
        Me.KelolaPetugasToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.KelolaPetugasToolStripMenuItem.Text = "Kelola Petugas"
        '
        'GenerateKartuParkirToolStripMenuItem
        '
        Me.GenerateKartuParkirToolStripMenuItem.Name = "GenerateKartuParkirToolStripMenuItem"
        Me.GenerateKartuParkirToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.GenerateKartuParkirToolStripMenuItem.Text = "Generate Kartu Parkir"
        '
        'LogPetugasToolStripMenuItem
        '
        Me.LogPetugasToolStripMenuItem.Name = "LogPetugasToolStripMenuItem"
        Me.LogPetugasToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.LogPetugasToolStripMenuItem.Text = "Log Petugas"
        '
        'ControlToolStripMenuItem
        '
        Me.ControlToolStripMenuItem.Name = "ControlToolStripMenuItem"
        Me.ControlToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ControlToolStripMenuItem.Text = "Control"
        '
        'DisplayToolStripMenuItem
        '
        Me.DisplayToolStripMenuItem.Name = "DisplayToolStripMenuItem"
        Me.DisplayToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.DisplayToolStripMenuItem.Text = "Display"
        '
        'VerifikasiKeluarToolStripMenuItem
        '
        Me.VerifikasiKeluarToolStripMenuItem.Name = "VerifikasiKeluarToolStripMenuItem"
        Me.VerifikasiKeluarToolStripMenuItem.Size = New System.Drawing.Size(102, 20)
        Me.VerifikasiKeluarToolStripMenuItem.Text = "Verifikasi Keluar"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 431)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(632, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(39, 17)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'MDIParent1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.ControlBox = False
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "MDIParent1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DIPA (Digital Integrated Parking Allocation)"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents KelolaPenggunaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ControlToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisplayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KelolaPenggunaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerateKartuParkirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KelolaPetugasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerifikasiKeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogPetugasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
