<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLokasi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLokasi))
        Me.btnFormLokasi = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSimpan = New Guna.UI2.WinForms.Guna2Button()
        Me.btnKeluar = New Guna.UI2.WinForms.Guna2Button()
        Me.btnFormPemilik = New Guna.UI2.WinForms.Guna2Button()
        Me.btnFormKendaraan = New Guna.UI2.WinForms.Guna2Button()
        Me.btnFormPencatatan = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnHapus = New Guna.UI2.WinForms.Guna2Button()
        Me.txtIdLokasi = New System.Windows.Forms.TextBox()
        Me.DGLokasi = New System.Windows.Forms.DataGridView()
        Me.btnTambah = New Guna.UI2.WinForms.Guna2Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtLetakLokasi = New System.Windows.Forms.TextBox()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.btnEdit = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.DGLokasi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnFormLokasi
        '
        Me.btnFormLokasi.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnFormLokasi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnFormLokasi.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnFormLokasi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnFormLokasi.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnFormLokasi.ForeColor = System.Drawing.Color.White
        Me.btnFormLokasi.Location = New System.Drawing.Point(23, 325)
        Me.btnFormLokasi.Name = "btnFormLokasi"
        Me.btnFormLokasi.Size = New System.Drawing.Size(120, 45)
        Me.btnFormLokasi.TabIndex = 21
        Me.btnFormLokasi.Text = "Form Lokasi"
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCari)
        Me.GroupBox1.Controls.Add(Me.txtCari)
        Me.GroupBox1.Location = New System.Drawing.Point(451, 353)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(339, 93)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Masukkan lokasi yang dicari"
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
        Me.btnCancel.Location = New System.Drawing.Point(832, 273)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(117, 45)
        Me.btnCancel.TabIndex = 39
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
        Me.btnSimpan.Location = New System.Drawing.Point(698, 273)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(117, 45)
        Me.btnSimpan.TabIndex = 38
        Me.btnSimpan.Text = "Simpan"
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
        Me.btnFormPemilik.Location = New System.Drawing.Point(23, 191)
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
        Me.btnFormKendaraan.Location = New System.Drawing.Point(23, 124)
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
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.LightGray
        Me.Guna2Panel2.Controls.Add(Me.btnFormLokasi)
        Me.Guna2Panel2.Controls.Add(Me.btnKeluar)
        Me.Guna2Panel2.Controls.Add(Me.btnFormPemilik)
        Me.Guna2Panel2.Controls.Add(Me.btnFormKendaraan)
        Me.Guna2Panel2.Controls.Add(Me.btnFormPencatatan)
        Me.Guna2Panel2.Location = New System.Drawing.Point(1, 66)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(165, 755)
        Me.Guna2Panel2.TabIndex = 37
        '
        'btnHapus
        '
        Me.btnHapus.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnHapus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnHapus.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnHapus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnHapus.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnHapus.ForeColor = System.Drawing.Color.White
        Me.btnHapus.Location = New System.Drawing.Point(565, 273)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(117, 45)
        Me.btnHapus.TabIndex = 36
        Me.btnHapus.Text = "Hapus"
        '
        'txtIdLokasi
        '
        Me.txtIdLokasi.Location = New System.Drawing.Point(377, 172)
        Me.txtIdLokasi.Name = "txtIdLokasi"
        Me.txtIdLokasi.PlaceholderText = "Id Lokasi"
        Me.txtIdLokasi.Size = New System.Drawing.Size(470, 25)
        Me.txtIdLokasi.TabIndex = 34
        '
        'DGLokasi
        '
        Me.DGLokasi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGLokasi.Location = New System.Drawing.Point(263, 481)
        Me.DGLokasi.Name = "DGLokasi"
        Me.DGLokasi.RowTemplate.Height = 27
        Me.DGLokasi.Size = New System.Drawing.Size(732, 298)
        Me.DGLokasi.TabIndex = 33
        '
        'btnTambah
        '
        Me.btnTambah.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnTambah.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnTambah.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnTambah.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnTambah.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnTambah.ForeColor = System.Drawing.Color.White
        Me.btnTambah.Location = New System.Drawing.Point(299, 273)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(117, 45)
        Me.btnTambah.TabIndex = 32
        Me.btnTambah.Text = "Tambah"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(494, 248)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 17)
        Me.Label2.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(526, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 34)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "FORM LOKASI"
        '
        'txtLetakLokasi
        '
        Me.txtLetakLokasi.Location = New System.Drawing.Point(377, 220)
        Me.txtLetakLokasi.Name = "txtLetakLokasi"
        Me.txtLetakLokasi.PlaceholderText = "Letak Lokasi"
        Me.txtLetakLokasi.Size = New System.Drawing.Size(470, 25)
        Me.txtLetakLokasi.TabIndex = 28
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(1898, 15)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(45, 29)
        Me.Guna2ControlBox1.TabIndex = 4
        '
        'btnEdit
        '
        Me.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnEdit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(433, 273)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(117, 45)
        Me.btnEdit.TabIndex = 35
        Me.btnEdit.Text = "Edit"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Guna2Panel1.Controls.Add(Me.Guna2ControlBox1)
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1079, 66)
        Me.Guna2Panel1.TabIndex = 27
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.DragStartTransparencyValue = 1.0R
        Me.Guna2DragControl1.TargetControl = Me.Guna2Panel1
        Me.Guna2DragControl1.UseTransparentDrag = True
        '
        'FormLokasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1076, 812)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.txtIdLokasi)
        Me.Controls.Add(Me.DGLokasi)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtLetakLokasi)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormLokasi"
        Me.Text = "FormLokasi"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Guna2Panel2.ResumeLayout(False)
        CType(Me.DGLokasi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnFormLokasi As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCari As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtCari As TextBox
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSimpan As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnKeluar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnFormPemilik As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnFormKendaraan As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnFormPencatatan As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnHapus As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtIdLokasi As TextBox
    Friend WithEvents DGLokasi As DataGridView
    Friend WithEvents btnTambah As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtLetakLokasi As TextBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents btnEdit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
End Class
