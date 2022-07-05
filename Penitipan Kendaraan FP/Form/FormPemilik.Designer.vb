<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPemilik
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPemilik))
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnFormLokasi = New Guna.UI2.WinForms.Guna2Button()
        Me.btnKeluar = New Guna.UI2.WinForms.Guna2Button()
        Me.btnFormTransaksi = New Guna.UI2.WinForms.Guna2Button()
        Me.btnFormPemilik = New Guna.UI2.WinForms.Guna2Button()
        Me.btnFormKendaraan = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.txtPlatNomor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIDKendaraan = New System.Windows.Forms.TextBox()
        Me.cmbMerkK = New System.Windows.Forms.ComboBox()
        Me.txtNamaPemilik = New System.Windows.Forms.TextBox()
        Me.txtAlamatP = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.DGPemilik = New System.Windows.Forms.DataGridView()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSimpan = New Guna.UI2.WinForms.Guna2Button()
        Me.btnHapus = New Guna.UI2.WinForms.Guna2Button()
        Me.btnTambah = New Guna.UI2.WinForms.Guna2Button()
        Me.btnEdit = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGPemilik, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Guna2Panel1.Location = New System.Drawing.Point(-1, -6)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1245, 77)
        Me.Guna2Panel1.TabIndex = 0
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BackColor = System.Drawing.Color.LightGray
        Me.Guna2Panel3.Controls.Add(Me.btnFormLokasi)
        Me.Guna2Panel3.Controls.Add(Me.btnKeluar)
        Me.Guna2Panel3.Controls.Add(Me.btnFormTransaksi)
        Me.Guna2Panel3.Controls.Add(Me.btnFormPemilik)
        Me.Guna2Panel3.Controls.Add(Me.btnFormKendaraan)
        Me.Guna2Panel3.Location = New System.Drawing.Point(0, 71)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(159, 824)
        Me.Guna2Panel3.TabIndex = 1
        '
        'btnFormLokasi
        '
        Me.btnFormLokasi.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnFormLokasi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnFormLokasi.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnFormLokasi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnFormLokasi.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnFormLokasi.ForeColor = System.Drawing.Color.White
        Me.btnFormLokasi.Location = New System.Drawing.Point(21, 301)
        Me.btnFormLokasi.Name = "btnFormLokasi"
        Me.btnFormLokasi.Size = New System.Drawing.Size(120, 45)
        Me.btnFormLokasi.TabIndex = 27
        Me.btnFormLokasi.Text = "Form Lokasi"
        '
        'btnKeluar
        '
        Me.btnKeluar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnKeluar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnKeluar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnKeluar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnKeluar.FillColor = System.Drawing.Color.Brown
        Me.btnKeluar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnKeluar.ForeColor = System.Drawing.Color.White
        Me.btnKeluar.Location = New System.Drawing.Point(21, 32)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(120, 45)
        Me.btnKeluar.TabIndex = 26
        Me.btnKeluar.Text = "Keluar"
        '
        'btnFormTransaksi
        '
        Me.btnFormTransaksi.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnFormTransaksi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnFormTransaksi.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnFormTransaksi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnFormTransaksi.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnFormTransaksi.ForeColor = System.Drawing.Color.White
        Me.btnFormTransaksi.Location = New System.Drawing.Point(21, 231)
        Me.btnFormTransaksi.Name = "btnFormTransaksi"
        Me.btnFormTransaksi.Size = New System.Drawing.Size(120, 45)
        Me.btnFormTransaksi.TabIndex = 24
        Me.btnFormTransaksi.Text = "Form Pencatatan"
        '
        'btnFormPemilik
        '
        Me.btnFormPemilik.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnFormPemilik.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnFormPemilik.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnFormPemilik.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnFormPemilik.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnFormPemilik.ForeColor = System.Drawing.Color.White
        Me.btnFormPemilik.Location = New System.Drawing.Point(21, 100)
        Me.btnFormPemilik.Name = "btnFormPemilik"
        Me.btnFormPemilik.Size = New System.Drawing.Size(120, 45)
        Me.btnFormPemilik.TabIndex = 25
        Me.btnFormPemilik.Text = "Form Pemilik"
        '
        'btnFormKendaraan
        '
        Me.btnFormKendaraan.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnFormKendaraan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnFormKendaraan.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnFormKendaraan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnFormKendaraan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnFormKendaraan.ForeColor = System.Drawing.Color.White
        Me.btnFormKendaraan.Location = New System.Drawing.Point(21, 164)
        Me.btnFormKendaraan.Name = "btnFormKendaraan"
        Me.btnFormKendaraan.Size = New System.Drawing.Size(120, 45)
        Me.btnFormKendaraan.TabIndex = 23
        Me.btnFormKendaraan.Text = "Form Kendaraan"
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.DragStartTransparencyValue = 1.0R
        Me.Guna2DragControl1.TargetControl = Me.Guna2Panel1
        Me.Guna2DragControl1.UseTransparentDrag = True
        '
        'txtPlatNomor
        '
        Me.txtPlatNomor.Location = New System.Drawing.Point(473, 171)
        Me.txtPlatNomor.Name = "txtPlatNomor"
        Me.txtPlatNomor.PlaceholderText = "Plat Nomor"
        Me.txtPlatNomor.Size = New System.Drawing.Size(405, 25)
        Me.txtPlatNomor.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(595, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 34)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "FORM PEMILIK"
        '
        'txtIDKendaraan
        '
        Me.txtIDKendaraan.Location = New System.Drawing.Point(679, 218)
        Me.txtIDKendaraan.Name = "txtIDKendaraan"
        Me.txtIDKendaraan.PlaceholderText = "Id Kendaraan"
        Me.txtIDKendaraan.Size = New System.Drawing.Size(199, 25)
        Me.txtIDKendaraan.TabIndex = 4
        '
        'cmbMerkK
        '
        Me.cmbMerkK.FormattingEnabled = True
        Me.cmbMerkK.Location = New System.Drawing.Point(473, 218)
        Me.cmbMerkK.Name = "cmbMerkK"
        Me.cmbMerkK.Size = New System.Drawing.Size(188, 25)
        Me.cmbMerkK.TabIndex = 5
        '
        'txtNamaPemilik
        '
        Me.txtNamaPemilik.Location = New System.Drawing.Point(473, 265)
        Me.txtNamaPemilik.Name = "txtNamaPemilik"
        Me.txtNamaPemilik.PlaceholderText = "Nama Pemilik"
        Me.txtNamaPemilik.Size = New System.Drawing.Size(405, 25)
        Me.txtNamaPemilik.TabIndex = 6
        '
        'txtAlamatP
        '
        Me.txtAlamatP.Location = New System.Drawing.Point(473, 312)
        Me.txtAlamatP.Name = "txtAlamatP"
        Me.txtAlamatP.PlaceholderText = "Alamat"
        Me.txtAlamatP.Size = New System.Drawing.Size(405, 25)
        Me.txtAlamatP.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCari)
        Me.GroupBox1.Controls.Add(Me.txtCari)
        Me.GroupBox1.Location = New System.Drawing.Point(509, 438)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(339, 93)
        Me.GroupBox1.TabIndex = 49
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Masukkan plat yang dicari"
        '
        'btnCari
        '
        Me.btnCari.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnCari.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCari.ForeColor = System.Drawing.SystemColors.Window
        Me.btnCari.Image = CType(resources.GetObject("btnCari.Image"), System.Drawing.Image)
        Me.btnCari.Location = New System.Drawing.Point(272, 20)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(61, 61)
        Me.btnCari.TabIndex = 12
        Me.btnCari.UseMnemonic = False
        Me.btnCari.UseVisualStyleBackColor = False
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(19, 36)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(226, 25)
        Me.txtCari.TabIndex = 0
        '
        'DGPemilik
        '
        Me.DGPemilik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGPemilik.Location = New System.Drawing.Point(321, 560)
        Me.DGPemilik.Name = "DGPemilik"
        Me.DGPemilik.RowTemplate.Height = 27
        Me.DGPemilik.Size = New System.Drawing.Size(732, 298)
        Me.DGPemilik.TabIndex = 48
        '
        'btnCancel
        '
        Me.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(886, 365)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(117, 45)
        Me.btnCancel.TabIndex = 54
        Me.btnCancel.Text = "Cancel"
        '
        'btnSimpan
        '
        Me.btnSimpan.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSimpan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSimpan.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSimpan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSimpan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSimpan.ForeColor = System.Drawing.Color.White
        Me.btnSimpan.Location = New System.Drawing.Point(752, 365)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(117, 45)
        Me.btnSimpan.TabIndex = 53
        Me.btnSimpan.Text = "Simpan"
        '
        'btnHapus
        '
        Me.btnHapus.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnHapus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnHapus.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnHapus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnHapus.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnHapus.ForeColor = System.Drawing.Color.White
        Me.btnHapus.Location = New System.Drawing.Point(619, 365)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(117, 45)
        Me.btnHapus.TabIndex = 52
        Me.btnHapus.Text = "Hapus"
        '
        'btnTambah
        '
        Me.btnTambah.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnTambah.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnTambah.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnTambah.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnTambah.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnTambah.ForeColor = System.Drawing.Color.White
        Me.btnTambah.Location = New System.Drawing.Point(353, 365)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(117, 45)
        Me.btnTambah.TabIndex = 50
        Me.btnTambah.Text = "Tambah"
        '
        'btnEdit
        '
        Me.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnEdit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(487, 365)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(117, 45)
        Me.btnEdit.TabIndex = 51
        Me.btnEdit.Text = "Edit"
        '
        'FormPemilik
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1242, 894)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DGPemilik)
        Me.Controls.Add(Me.txtAlamatP)
        Me.Controls.Add(Me.txtNamaPemilik)
        Me.Controls.Add(Me.cmbMerkK)
        Me.Controls.Add(Me.txtIDKendaraan)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPlatNomor)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormPemilik"
        Me.Text = "Form1"
        Me.Guna2Panel3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGPemilik, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnFormLokasi As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnKeluar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnFormTransaksi As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnFormPemilik As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnFormKendaraan As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents txtPlatNomor As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtIDKendaraan As TextBox
    Friend WithEvents cmbMerkK As ComboBox
    Friend WithEvents txtNamaPemilik As TextBox
    Friend WithEvents txtAlamatP As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnCari As Button
    Friend WithEvents txtCari As TextBox
    Friend WithEvents DGPemilik As DataGridView
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSimpan As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnHapus As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnTambah As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnEdit As Guna.UI2.WinForms.Guna2Button
End Class
