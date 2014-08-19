<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnPilih = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtKartu = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboId = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtAlamat = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtUmur = New System.Windows.Forms.TextBox()
        Me.TxtPekerjaan = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dg1 = New System.Windows.Forms.DataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtNoKend = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtJenis = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtMerk = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnPilih1 = New System.Windows.Forms.Button()
        Me.btnPilih2 = New System.Windows.Forms.Button()
        Me.btnPilih3 = New System.Windows.Forms.Button()
        Me.ofd1 = New System.Windows.Forms.OpenFileDialog()
        Me.ofd2 = New System.Windows.Forms.OpenFileDialog()
        Me.ofd3 = New System.Windows.Forms.OpenFileDialog()
        Me.pictureFoto1 = New System.Windows.Forms.PictureBox()
        Me.pictureFoto2 = New System.Windows.Forms.PictureBox()
        Me.pictureFoto3 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureFoto1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureFoto2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureFoto3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(84, 69)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Pilih Menu:"
        '
        'BtnPilih
        '
        Me.BtnPilih.Location = New System.Drawing.Point(237, 67)
        Me.BtnPilih.Name = "BtnPilih"
        Me.BtnPilih.Size = New System.Drawing.Size(75, 23)
        Me.BtnPilih.TabIndex = 2
        Me.BtnPilih.Text = "PILIH"
        Me.BtnPilih.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(352, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(205, 22)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "KELOLA PENGGUNA"
        '
        'TxtKartu
        '
        Me.TxtKartu.Location = New System.Drawing.Point(507, 159)
        Me.TxtKartu.Name = "TxtKartu"
        Me.TxtKartu.Size = New System.Drawing.Size(100, 20)
        Me.TxtKartu.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(416, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "ID Kartu :"
        '
        'TxtId
        '
        Me.TxtId.Location = New System.Drawing.Point(507, 194)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(100, 20)
        Me.TxtId.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(416, 197)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "No. Identitas : "
        '
        'ComboId
        '
        Me.ComboId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboId.FormattingEnabled = True
        Me.ComboId.Location = New System.Drawing.Point(507, 119)
        Me.ComboId.Name = "ComboId"
        Me.ComboId.Size = New System.Drawing.Size(121, 21)
        Me.ComboId.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(416, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "ID Pengguna :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(416, 232)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Nama : "
        '
        'TxtNama
        '
        Me.TxtNama.Location = New System.Drawing.Point(507, 229)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(100, 20)
        Me.TxtNama.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(619, 165)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Alamat Hunian :"
        '
        'TxtAlamat
        '
        Me.TxtAlamat.Location = New System.Drawing.Point(733, 162)
        Me.TxtAlamat.Name = "TxtAlamat"
        Me.TxtAlamat.Size = New System.Drawing.Size(100, 20)
        Me.TxtAlamat.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(416, 264)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Umur : "
        '
        'TxtUmur
        '
        Me.TxtUmur.Location = New System.Drawing.Point(507, 261)
        Me.TxtUmur.Name = "TxtUmur"
        Me.TxtUmur.Size = New System.Drawing.Size(100, 20)
        Me.TxtUmur.TabIndex = 15
        '
        'TxtPekerjaan
        '
        Me.TxtPekerjaan.Location = New System.Drawing.Point(507, 287)
        Me.TxtPekerjaan.Name = "TxtPekerjaan"
        Me.TxtPekerjaan.Size = New System.Drawing.Size(100, 20)
        Me.TxtPekerjaan.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(415, 290)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Pekerjaan :"
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Location = New System.Drawing.Point(548, 465)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(75, 23)
        Me.BtnSimpan.TabIndex = 18
        Me.BtnSimpan.Text = "SIMPAN"
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(629, 465)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.BtnUpdate.TabIndex = 19
        Me.BtnUpdate.Text = "UPDATE"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnHapus
        '
        Me.BtnHapus.Location = New System.Drawing.Point(710, 465)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(75, 23)
        Me.BtnHapus.TabIndex = 20
        Me.BtnHapus.Text = "HAPUS"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dg1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 122)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(397, 372)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Anggota"
        '
        'dg1
        '
        Me.dg1.AllowUserToAddRows = False
        Me.dg1.AllowUserToDeleteRows = False
        Me.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg1.Location = New System.Drawing.Point(10, 19)
        Me.dg1.Name = "dg1"
        Me.dg1.ReadOnly = True
        Me.dg1.Size = New System.Drawing.Size(381, 347)
        Me.dg1.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(619, 203)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "No. Kendaraan :"
        '
        'TxtNoKend
        '
        Me.TxtNoKend.Location = New System.Drawing.Point(733, 200)
        Me.TxtNoKend.Name = "TxtNoKend"
        Me.TxtNoKend.Size = New System.Drawing.Size(100, 20)
        Me.TxtNoKend.TabIndex = 23
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(619, 235)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 13)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Jenis Mobil :"
        '
        'TxtJenis
        '
        Me.TxtJenis.Location = New System.Drawing.Point(733, 232)
        Me.TxtJenis.Name = "TxtJenis"
        Me.TxtJenis.Size = New System.Drawing.Size(100, 20)
        Me.TxtJenis.TabIndex = 25
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(619, 270)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 13)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "Merk Mobil :"
        '
        'TxtMerk
        '
        Me.TxtMerk.Location = New System.Drawing.Point(733, 266)
        Me.TxtMerk.Name = "TxtMerk"
        Me.TxtMerk.Size = New System.Drawing.Size(100, 20)
        Me.TxtMerk.TabIndex = 27
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(416, 321)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(34, 13)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "Foto :"
        '
        'btnPilih1
        '
        Me.btnPilih1.Location = New System.Drawing.Point(518, 416)
        Me.btnPilih1.Name = "btnPilih1"
        Me.btnPilih1.Size = New System.Drawing.Size(75, 23)
        Me.btnPilih1.TabIndex = 32
        Me.btnPilih1.Text = "PILIH"
        Me.btnPilih1.UseVisualStyleBackColor = True
        '
        'btnPilih2
        '
        Me.btnPilih2.Location = New System.Drawing.Point(638, 416)
        Me.btnPilih2.Name = "btnPilih2"
        Me.btnPilih2.Size = New System.Drawing.Size(75, 23)
        Me.btnPilih2.TabIndex = 33
        Me.btnPilih2.Text = "PILIH"
        Me.btnPilih2.UseVisualStyleBackColor = True
        '
        'btnPilih3
        '
        Me.btnPilih3.Location = New System.Drawing.Point(748, 416)
        Me.btnPilih3.Name = "btnPilih3"
        Me.btnPilih3.Size = New System.Drawing.Size(75, 23)
        Me.btnPilih3.TabIndex = 34
        Me.btnPilih3.Text = "PILIH"
        Me.btnPilih3.UseVisualStyleBackColor = True
        '
        'ofd1
        '
        Me.ofd1.FileName = "OpenFileDialog1"
        '
        'ofd2
        '
        Me.ofd2.FileName = "OpenFileDialog1"
        '
        'ofd3
        '
        Me.ofd3.FileName = "OpenFileDialog1"
        '
        'pictureFoto1
        '
        Me.pictureFoto1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pictureFoto1.Image = CType(resources.GetObject("pictureFoto1.Image"), System.Drawing.Image)
        Me.pictureFoto1.Location = New System.Drawing.Point(500, 313)
        Me.pictureFoto1.Name = "pictureFoto1"
        Me.pictureFoto1.Size = New System.Drawing.Size(107, 97)
        Me.pictureFoto1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureFoto1.TabIndex = 35
        Me.pictureFoto1.TabStop = False
        '
        'pictureFoto2
        '
        Me.pictureFoto2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pictureFoto2.Image = CType(resources.GetObject("pictureFoto2.Image"), System.Drawing.Image)
        Me.pictureFoto2.Location = New System.Drawing.Point(613, 313)
        Me.pictureFoto2.Name = "pictureFoto2"
        Me.pictureFoto2.Size = New System.Drawing.Size(107, 97)
        Me.pictureFoto2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureFoto2.TabIndex = 36
        Me.pictureFoto2.TabStop = False
        '
        'pictureFoto3
        '
        Me.pictureFoto3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pictureFoto3.Image = CType(resources.GetObject("pictureFoto3.Image"), System.Drawing.Image)
        Me.pictureFoto3.Location = New System.Drawing.Point(733, 313)
        Me.pictureFoto3.Name = "pictureFoto3"
        Me.pictureFoto3.Size = New System.Drawing.Size(107, 97)
        Me.pictureFoto3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureFoto3.TabIndex = 37
        Me.pictureFoto3.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(840, 501)
        Me.Controls.Add(Me.pictureFoto3)
        Me.Controls.Add(Me.pictureFoto2)
        Me.Controls.Add(Me.pictureFoto1)
        Me.Controls.Add(Me.btnPilih3)
        Me.Controls.Add(Me.btnPilih2)
        Me.Controls.Add(Me.btnPilih1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TxtMerk)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TxtJenis)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TxtNoKend)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtPekerjaan)
        Me.Controls.Add(Me.TxtUmur)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtAlamat)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtNama)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ComboId)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtId)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtKartu)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnPilih)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kelola Pengguna"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureFoto1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureFoto2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureFoto3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnPilih As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtKartu As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtId As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ComboId As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtNama As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtAlamat As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtUmur As System.Windows.Forms.TextBox
    Friend WithEvents TxtPekerjaan As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents BtnSimpan As System.Windows.Forms.Button
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnHapus As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtNoKend As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TxtJenis As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TxtMerk As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnPilih1 As System.Windows.Forms.Button
    Friend WithEvents btnPilih2 As System.Windows.Forms.Button
    Friend WithEvents btnPilih3 As System.Windows.Forms.Button
    Friend WithEvents ofd1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ofd2 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ofd3 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents pictureFoto1 As System.Windows.Forms.PictureBox
    Friend WithEvents pictureFoto2 As System.Windows.Forms.PictureBox
    Friend WithEvents pictureFoto3 As System.Windows.Forms.PictureBox
    Friend WithEvents dg1 As System.Windows.Forms.DataGridView
End Class
