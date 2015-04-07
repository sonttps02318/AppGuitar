<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThemSanPham
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmThemSanPham))
        Me.ofdHinhAnh = New System.Windows.Forms.OpenFileDialog()
        Me.grbDanhSachSP = New System.Windows.Forms.GroupBox()
        Me.dgvThemSanPham = New System.Windows.Forms.DataGridView()
        Me.lblChonHinh = New System.Windows.Forms.Label()
        Me.txtLoaiSP = New System.Windows.Forms.TextBox()
        Me.txtDonGia = New System.Windows.Forms.TextBox()
        Me.txtSoLuong = New System.Windows.Forms.TextBox()
        Me.txtTenSP = New System.Windows.Forms.TextBox()
        Me.txtMaSP = New System.Windows.Forms.TextBox()
        Me.lblDonGia = New System.Windows.Forms.Label()
        Me.lblLoaiSP = New System.Windows.Forms.Label()
        Me.lblTenSP = New System.Windows.Forms.Label()
        Me.lblSoLuong = New System.Windows.Forms.Label()
        Me.lblMaSP = New System.Windows.Forms.Label()
        Me.ptbHinhAnh = New System.Windows.Forms.PictureBox()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.lblThongTinSP = New System.Windows.Forms.Label()
        Me.grbDanhSachSP.SuspendLayout()
        CType(Me.dgvThemSanPham, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbHinhAnh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ofdHinhAnh
        '
        Me.ofdHinhAnh.FileName = "OpenFileDialog1"
        '
        'grbDanhSachSP
        '
        Me.grbDanhSachSP.BackColor = System.Drawing.Color.PaleTurquoise
        Me.grbDanhSachSP.Controls.Add(Me.dgvThemSanPham)
        Me.grbDanhSachSP.Controls.Add(Me.lblChonHinh)
        Me.grbDanhSachSP.Controls.Add(Me.txtLoaiSP)
        Me.grbDanhSachSP.Controls.Add(Me.txtDonGia)
        Me.grbDanhSachSP.Controls.Add(Me.txtSoLuong)
        Me.grbDanhSachSP.Controls.Add(Me.txtTenSP)
        Me.grbDanhSachSP.Controls.Add(Me.txtMaSP)
        Me.grbDanhSachSP.Controls.Add(Me.lblDonGia)
        Me.grbDanhSachSP.Controls.Add(Me.lblLoaiSP)
        Me.grbDanhSachSP.Controls.Add(Me.lblTenSP)
        Me.grbDanhSachSP.Controls.Add(Me.lblSoLuong)
        Me.grbDanhSachSP.Controls.Add(Me.lblMaSP)
        Me.grbDanhSachSP.Controls.Add(Me.ptbHinhAnh)
        Me.grbDanhSachSP.Controls.Add(Me.btnThoat)
        Me.grbDanhSachSP.Controls.Add(Me.btnXoa)
        Me.grbDanhSachSP.Controls.Add(Me.btnSua)
        Me.grbDanhSachSP.Controls.Add(Me.btnThem)
        Me.grbDanhSachSP.Controls.Add(Me.lblThongTinSP)
        Me.grbDanhSachSP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbDanhSachSP.Location = New System.Drawing.Point(12, 12)
        Me.grbDanhSachSP.Name = "grbDanhSachSP"
        Me.grbDanhSachSP.Size = New System.Drawing.Size(606, 398)
        Me.grbDanhSachSP.TabIndex = 3
        Me.grbDanhSachSP.TabStop = False
        Me.grbDanhSachSP.Text = "Danh sách sản phẩm"
        '
        'dgvThemSanPham
        '
        Me.dgvThemSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvThemSanPham.BackgroundColor = System.Drawing.Color.White
        Me.dgvThemSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvThemSanPham.Location = New System.Drawing.Point(14, 21)
        Me.dgvThemSanPham.Name = "dgvThemSanPham"
        Me.dgvThemSanPham.ReadOnly = True
        Me.dgvThemSanPham.Size = New System.Drawing.Size(577, 159)
        Me.dgvThemSanPham.TabIndex = 30
        '
        'lblChonHinh
        '
        Me.lblChonHinh.AutoSize = True
        Me.lblChonHinh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChonHinh.Location = New System.Drawing.Point(342, 375)
        Me.lblChonHinh.Name = "lblChonHinh"
        Me.lblChonHinh.Size = New System.Drawing.Size(128, 16)
        Me.lblChonHinh.TabIndex = 29
        Me.lblChonHinh.Text = "Chọn hình sản phẩm"
        '
        'txtLoaiSP
        '
        Me.txtLoaiSP.BackColor = System.Drawing.Color.White
        Me.txtLoaiSP.Location = New System.Drawing.Point(133, 350)
        Me.txtLoaiSP.Name = "txtLoaiSP"
        Me.txtLoaiSP.Size = New System.Drawing.Size(156, 22)
        Me.txtLoaiSP.TabIndex = 28
        '
        'txtDonGia
        '
        Me.txtDonGia.BackColor = System.Drawing.Color.White
        Me.txtDonGia.Location = New System.Drawing.Point(133, 318)
        Me.txtDonGia.Name = "txtDonGia"
        Me.txtDonGia.Size = New System.Drawing.Size(156, 22)
        Me.txtDonGia.TabIndex = 27
        '
        'txtSoLuong
        '
        Me.txtSoLuong.BackColor = System.Drawing.Color.White
        Me.txtSoLuong.Location = New System.Drawing.Point(133, 286)
        Me.txtSoLuong.Name = "txtSoLuong"
        Me.txtSoLuong.Size = New System.Drawing.Size(156, 22)
        Me.txtSoLuong.TabIndex = 26
        '
        'txtTenSP
        '
        Me.txtTenSP.BackColor = System.Drawing.Color.White
        Me.txtTenSP.Location = New System.Drawing.Point(133, 254)
        Me.txtTenSP.Name = "txtTenSP"
        Me.txtTenSP.Size = New System.Drawing.Size(156, 22)
        Me.txtTenSP.TabIndex = 25
        '
        'txtMaSP
        '
        Me.txtMaSP.BackColor = System.Drawing.Color.White
        Me.txtMaSP.Location = New System.Drawing.Point(133, 222)
        Me.txtMaSP.Name = "txtMaSP"
        Me.txtMaSP.Size = New System.Drawing.Size(156, 22)
        Me.txtMaSP.TabIndex = 24
        '
        'lblDonGia
        '
        Me.lblDonGia.AutoSize = True
        Me.lblDonGia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDonGia.Location = New System.Drawing.Point(11, 321)
        Me.lblDonGia.Name = "lblDonGia"
        Me.lblDonGia.Size = New System.Drawing.Size(57, 16)
        Me.lblDonGia.TabIndex = 23
        Me.lblDonGia.Text = "Đơn giá:"
        '
        'lblLoaiSP
        '
        Me.lblLoaiSP.AutoSize = True
        Me.lblLoaiSP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoaiSP.Location = New System.Drawing.Point(11, 353)
        Me.lblLoaiSP.Name = "lblLoaiSP"
        Me.lblLoaiSP.Size = New System.Drawing.Size(99, 16)
        Me.lblLoaiSP.TabIndex = 22
        Me.lblLoaiSP.Text = "Loại sản phẩm:"
        '
        'lblTenSP
        '
        Me.lblTenSP.AutoSize = True
        Me.lblTenSP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTenSP.Location = New System.Drawing.Point(11, 257)
        Me.lblTenSP.Name = "lblTenSP"
        Me.lblTenSP.Size = New System.Drawing.Size(97, 16)
        Me.lblTenSP.TabIndex = 21
        Me.lblTenSP.Text = "Tên sản phẩm:"
        '
        'lblSoLuong
        '
        Me.lblSoLuong.AutoSize = True
        Me.lblSoLuong.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSoLuong.Location = New System.Drawing.Point(11, 289)
        Me.lblSoLuong.Name = "lblSoLuong"
        Me.lblSoLuong.Size = New System.Drawing.Size(68, 16)
        Me.lblSoLuong.TabIndex = 20
        Me.lblSoLuong.Text = "Số Lượng:"
        '
        'lblMaSP
        '
        Me.lblMaSP.AutoSize = True
        Me.lblMaSP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaSP.Location = New System.Drawing.Point(11, 225)
        Me.lblMaSP.Name = "lblMaSP"
        Me.lblMaSP.Size = New System.Drawing.Size(89, 16)
        Me.lblMaSP.TabIndex = 19
        Me.lblMaSP.Text = "Mã sản phẩm"
        '
        'ptbHinhAnh
        '
        Me.ptbHinhAnh.BackColor = System.Drawing.Color.White
        Me.ptbHinhAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ptbHinhAnh.Image = Global.Assignment.My.Resources.Resources.AddMedia
        Me.ptbHinhAnh.Location = New System.Drawing.Point(313, 208)
        Me.ptbHinhAnh.Name = "ptbHinhAnh"
        Me.ptbHinhAnh.Size = New System.Drawing.Size(182, 164)
        Me.ptbHinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbHinhAnh.TabIndex = 18
        Me.ptbHinhAnh.TabStop = False
        '
        'btnThoat
        '
        Me.btnThoat.Location = New System.Drawing.Point(516, 346)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(75, 30)
        Me.btnThoat.TabIndex = 17
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(516, 300)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 30)
        Me.btnXoa.TabIndex = 16
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(516, 254)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(75, 30)
        Me.btnSua.TabIndex = 15
        Me.btnSua.Text = "Sữa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(516, 208)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 30)
        Me.btnThem.TabIndex = 14
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'lblThongTinSP
        '
        Me.lblThongTinSP.AutoSize = True
        Me.lblThongTinSP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblThongTinSP.Location = New System.Drawing.Point(11, 194)
        Me.lblThongTinSP.Name = "lblThongTinSP"
        Me.lblThongTinSP.Size = New System.Drawing.Size(128, 16)
        Me.lblThongTinSP.TabIndex = 12
        Me.lblThongTinSP.Text = "Thông tin sản phẩm:"
        '
        'frmThemSanPham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(629, 422)
        Me.Controls.Add(Me.grbDanhSachSP)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmThemSanPham"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thêm sản phẩm"
        Me.grbDanhSachSP.ResumeLayout(False)
        Me.grbDanhSachSP.PerformLayout()
        CType(Me.dgvThemSanPham, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbHinhAnh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ofdHinhAnh As System.Windows.Forms.OpenFileDialog
    Friend WithEvents grbDanhSachSP As System.Windows.Forms.GroupBox
    Friend WithEvents btnThoat As System.Windows.Forms.Button
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents btnSua As System.Windows.Forms.Button
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents lblThongTinSP As System.Windows.Forms.Label
    Friend WithEvents lblChonHinh As System.Windows.Forms.Label
    Friend WithEvents txtLoaiSP As System.Windows.Forms.TextBox
    Friend WithEvents txtDonGia As System.Windows.Forms.TextBox
    Friend WithEvents txtSoLuong As System.Windows.Forms.TextBox
    Friend WithEvents txtTenSP As System.Windows.Forms.TextBox
    Friend WithEvents txtMaSP As System.Windows.Forms.TextBox
    Friend WithEvents lblDonGia As System.Windows.Forms.Label
    Friend WithEvents lblLoaiSP As System.Windows.Forms.Label
    Friend WithEvents lblTenSP As System.Windows.Forms.Label
    Friend WithEvents lblSoLuong As System.Windows.Forms.Label
    Friend WithEvents lblMaSP As System.Windows.Forms.Label
    Friend WithEvents ptbHinhAnh As System.Windows.Forms.PictureBox
    Friend WithEvents dgvThemSanPham As System.Windows.Forms.DataGridView
End Class
