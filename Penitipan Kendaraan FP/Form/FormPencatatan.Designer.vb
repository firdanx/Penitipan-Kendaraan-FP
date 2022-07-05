<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPencatatan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPencatatan))
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnFormLokasi = New Guna.UI2.WinForms.Guna2Button()
        Me.btnKeluar = New Guna.UI2.WinForms.Guna2Button()
        Me.btnFormPemilik = New Guna.UI2.WinForms.Guna2Button()
        Me.btnFormKendaraan = New Guna.UI2.WinForms.Guna2Button()
        Me.btnFormPencatatan = New Guna.UI2.WinForms.Guna2Button()
        Me.txtIdPencatatan = New System.Windows.Forms.TextBox()
        Me.txtIdLokasi = New System.Windows.Forms.TextBox()
        Me.cmbPlatNomor = New System.Windows.Forms.ComboBox()
        Me.cmbLokasi = New System.Windows.Forms.ComboBox()
        Me.lblIDPegawai = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dt1 = New System.Windows.Forms.DateTimePicker()
        Me.dt2 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtJmlHari = New System.Windows.Forms.TextBox()
        Me.txtTagihan = New System.Windows.Forms.TextBox()
        Me.DGPencatatan = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSimpan = New Guna.UI2.WinForms.Guna2Button()
        Me.btnHapus = New Guna.UI2.WinForms.Guna2Button()
        Me.btnTambah = New Guna.UI2.WinForms.Guna2Button()
        Me.btnEdit = New Guna.UI2.WinForms.Guna2Button()
        Me.txtPlatNomor = New System.Windows.Forms.TextBox()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.DGPencatatan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Guna2Panel1.Location = New System.Drawing.Point(-1, -1)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1271, 78)
        Me.Guna2Panel1.TabIndex = 0
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.DragStartTransparencyValue = 1.0R
        Me.Guna2DragControl1.TargetControl = Me.Guna2Panel1
        Me.Guna2DragControl1.UseTransparentDrag = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(672, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(212, 34)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "FORM PENCATATAN"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.LightGray
        Me.Guna2Panel2.Controls.Add(Me.btnFormLokasi)
        Me.Guna2Panel2.Controls.Add(Me.btnKeluar)
        Me.Guna2Panel2.Controls.Add(Me.btnFormPemilik)
        Me.Guna2Panel2.Controls.Add(Me.btnFormKendaraan)
        Me.Guna2Panel2.Controls.Add(Me.btnFormPencatatan)
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 55)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(165, 966)
        Me.Guna2Panel2.TabIndex = 23
        '
        'btnFormLokasi
        '
        Me.btnFormLokasi.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnFormLokasi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnFormLokasi.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnFormLokasi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnFormLokasi.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnFormLokasi.ForeColor = System.Drawing.Color.White
        Me.btnFormLokasi.Location = New System.Drawing.Point(23, 324)
        Me.btnFormLokasi.Name = "btnFormLokasi"
        Me.btnFormLokasi.Size = New System.Drawing.Size(120, 45)
        Me.btnFormLokasi.TabIndex = 21
        Me.btnFormLokasi.Text = "Form Lokasi"
        '
        'btnKeluar
        '
        Me.btnKeluar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnKeluar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnKeluar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnKeluar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnKeluar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnKeluar.FillColor = System.Drawing.Color.Brown
        Me.btnKeluar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnKeluar.ForeColor = System.Drawing.Color.White
        Me.btnKeluar.Location = New System.Drawing.Point(23, 57)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(120, 45)
        Me.btnKeluar.TabIndex = 20
        Me.btnKeluar.Text = "Keluar"
        '
        'btnFormPemilik
        '
        Me.btnFormPemilik.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnFormPemilik.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnFormPemilik.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnFormPemilik.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnFormPemilik.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnFormPemilik.ForeColor = System.Drawing.Color.White
        Me.btnFormPemilik.Location = New System.Drawing.Point(23, 125)
        Me.btnFormPemilik.Name = "btnFormPemilik"
        Me.btnFormPemilik.Size = New System.Drawing.Size(120, 45)
        Me.btnFormPemilik.TabIndex = 19
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
        Me.btnFormKendaraan.Location = New System.Drawing.Point(23, 189)
        Me.btnFormKendaraan.Name = "btnFormKendaraan"
        Me.btnFormKendaraan.Size = New System.Drawing.Size(120, 45)
        Me.btnFormKendaraan.TabIndex = 16
        Me.btnFormKendaraan.Text = "Form Kendaraan"
        '
        'btnFormPencatatan
        '
        Me.btnFormPencatatan.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnFormPencatatan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnFormPencatatan.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnFormPencatatan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnFormPencatatan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnFormPencatatan.ForeColor = System.Drawing.Color.White
        Me.btnFormPencatatan.Location = New System.Drawing.Point(23, 256)
        Me.btnFormPencatatan.Name = "btnFormPencatatan"
        Me.btnFormPencatatan.Size = New System.Drawing.Size(120, 45)
        Me.btnFormPencatatan.TabIndex = 18
        Me.btnFormPencatatan.Text = "Form Pencatatan"
        '
        'txtIdPencatatan
        '
        Me.txtIdPencatatan.Location = New System.Drawing.Point(525, 180)
        Me.txtIdPencatatan.Name = "txtIdPencatatan"
        Me.txtIdPencatatan.PlaceholderText = "Id Pencatatan"
        Me.txtIdPencatatan.Size = New System.Drawing.Size(470, 25)
        Me.txtIdPencatatan.TabIndex = 26
        '
        'txtIdLokasi
        '
        Me.txtIdLokasi.Location = New System.Drawing.Point(758, 276)
        Me.txtIdLokasi.Name = "txtIdLokasi"
        Me.txtIdLokasi.PlaceholderText = "Id Lokasi"
        Me.txtIdLokasi.Size = New System.Drawing.Size(237, 25)
        Me.txtIdLokasi.TabIndex = 25
        '
        'cmbPlatNomor
        '
        Me.cmbPlatNomor.FormattingEnabled = True
        Me.cmbPlatNomor.Location = New System.Drawing.Point(525, 228)
        Me.cmbPlatNomor.Name = "cmbPlatNomor"
        Me.cmbPlatNomor.Size = New System.Drawing.Size(214, 25)
        Me.cmbPlatNomor.TabIndex = 28
        '
        'cmbLokasi
        '
        Me.cmbLokasi.FormattingEnabled = True
        Me.cmbLokasi.Location = New System.Drawing.Point(525, 276)
        Me.cmbLokasi.Name = "cmbLokasi"
        Me.cmbLokasi.Size = New System.Drawing.Size(214, 25)
        Me.cmbLokasi.TabIndex = 29
        '
        'lblIDPegawai
        '
        Me.lblIDPegawai.AutoSize = True
        Me.lblIDPegawai.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblIDPegawai.Location = New System.Drawing.Point(1093, 100)
        Me.lblIDPegawai.Name = "lblIDPegawai"
        Me.lblIDPegawai.Size = New System.Drawing.Size(15, 15)
        Me.lblIDPegawai.TabIndex = 31
        Me.lblIDPegawai.Text = "X"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(1011, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 15)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "ID Pegawai :"
        '
        'dt1
        '
        Me.dt1.CustomFormat = "yyyy-MM-dd HH:mm:ss"
        Me.dt1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt1.Location = New System.Drawing.Point(525, 344)
        Me.dt1.Name = "dt1"
        Me.dt1.Size = New System.Drawing.Size(214, 25)
        Me.dt1.TabIndex = 32
        '
        'dt2
        '
        Me.dt2.CustomFormat = "yyyy-MM-dd HH:mm:ss"
        Me.dt2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt2.Location = New System.Drawing.Point(758, 344)
        Me.dt2.Name = "dt2"
        Me.dt2.Size = New System.Drawing.Size(237, 25)
        Me.dt2.TabIndex = 33
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(525, 326)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 15)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Kedatangan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(758, 326)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 15)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Pengambilan"
        '
        'txtJmlHari
        '
        Me.txtJmlHari.Location = New System.Drawing.Point(525, 389)
        Me.txtJmlHari.Name = "txtJmlHari"
        Me.txtJmlHari.PlaceholderText = "Jumlah Hari"
        Me.txtJmlHari.Size = New System.Drawing.Size(214, 25)
        Me.txtJmlHari.TabIndex = 36
        '
        'txtTagihan
        '
        Me.txtTagihan.Location = New System.Drawing.Point(758, 389)
        Me.txtTagihan.Name = "txtTagihan"
        Me.txtTagihan.PlaceholderText = "Tagihan"
        Me.txtTagihan.Size = New System.Drawing.Size(237, 25)
        Me.txtTagihan.TabIndex = 37
        '
        'DGPencatatan
        '
        Me.DGPencatatan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGPencatatan.Location = New System.Drawing.Point(331, 667)
        Me.DGPencatatan.Name = "DGPencatatan"
        Me.DGPencatatan.RowTemplate.Height = 27
        Me.DGPencatatan.Size = New System.Drawing.Size(835, 298)
        Me.DGPencatatan.TabIndex = 62
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCari)
        Me.GroupBox1.Controls.Add(Me.txtCari)
        Me.GroupBox1.Location = New System.Drawing.Point(590, 444)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(339, 93)
        Me.GroupBox1.TabIndex = 63
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Masukkan id yang dicari"
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
        'btnCancel
        '
        Me.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(963, 576)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(117, 45)
        Me.btnCancel.TabIndex = 68
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
        Me.btnSimpan.Location = New System.Drawing.Point(829, 576)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(117, 45)
        Me.btnSimpan.TabIndex = 67
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
        Me.btnHapus.Location = New System.Drawing.Point(696, 576)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(117, 45)
        Me.btnHapus.TabIndex = 66
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
        Me.btnTambah.Location = New System.Drawing.Point(430, 576)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(117, 45)
        Me.btnTambah.TabIndex = 64
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
        Me.btnEdit.Location = New System.Drawing.Point(564, 576)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(117, 45)
        Me.btnEdit.TabIndex = 65
        Me.btnEdit.Text = "Edit"
        '
        'txtPlatNomor
        '
        Me.txtPlatNomor.Location = New System.Drawing.Point(758, 228)
        Me.txtPlatNomor.Name = "txtPlatNomor"
        Me.txtPlatNomor.Size = New System.Drawing.Size(237, 25)
        Me.txtPlatNomor.TabIndex = 69
        Me.txtPlatNomor.Visible = False
        '
        'FormPencatatan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1268, 1020)
        Me.Controls.Add(Me.txtPlatNomor)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.DGPencatatan)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtTagihan)
        Me.Controls.Add(Me.txtJmlHari)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dt2)
        Me.Controls.Add(Me.dt1)
        Me.Controls.Add(Me.lblIDPegawai)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbLokasi)
        Me.Controls.Add(Me.cmbPlatNomor)
        Me.Controls.Add(Me.txtIdPencatatan)
        Me.Controls.Add(Me.txtIdLokasi)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormPencatatan"
        Me.Text = "Form4"
        Me.Guna2Panel2.ResumeLayout(False)
        CType(Me.DGPencatatan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnKeluar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnFormPemilik As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnFormKendaraan As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnFormPencatatan As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtIdPencatatan As TextBox
    Friend WithEvents txtIdLokasi As TextBox
    Friend WithEvents cmbPlatNomor As ComboBox
    Friend WithEvents cmbLokasi As ComboBox
    Friend WithEvents lblIDPegawai As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dt1 As DateTimePicker
    Friend WithEvents dt2 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtJmlHari As TextBox
    Friend WithEvents txtTagihan As TextBox
    Friend WithEvents btnFormLokasi As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DGPencatatan As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnCari As Button
    Friend WithEvents txtCari As TextBox
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSimpan As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnHapus As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnTambah As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnEdit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtPlatNomor As TextBox
End Class
