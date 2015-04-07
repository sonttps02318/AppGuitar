<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmXemSanPham
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmXemSanPham))
        Me.grbThongTinSP = New System.Windows.Forms.GroupBox()
        Me.dgvXemSanPham = New System.Windows.Forms.DataGridView()
        Me.btnHienThi = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.btnDong = New System.Windows.Forms.Button()
        Me.lblDanhSachSP = New System.Windows.Forms.Label()
        Me.txtMaLSP = New System.Windows.Forms.TextBox()
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
        Me.grbTimKiem = New System.Windows.Forms.GroupBox()
        Me.btnTimKiem = New System.Windows.Forms.Button()
        Me.cbbTimKiem = New System.Windows.Forms.ComboBox()
        Me.grbThongTinSP.SuspendLayout()
        CType(Me.dgvXemSanPham, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbHinhAnh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbTimKiem.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbThongTinSP
        '
        Me.grbThongTinSP.BackColor = System.Drawing.Color.PaleTurquoise
        Me.grbThongTinSP.Controls.Add(Me.dgvXemSanPham)
        Me.grbThongTinSP.Controls.Add(Me.btnHienThi)
        Me.grbThongTinSP.Controls.Add(Me.btnLast)
        Me.grbThongTinSP.Controls.Add(Me.btnFirst)
        Me.grbThongTinSP.Controls.Add(Me.btnNext)
        Me.grbThongTinSP.Controls.Add(Me.btnPrev)
        Me.grbThongTinSP.Controls.Add(Me.btnDong)
        Me.grbThongTinSP.Controls.Add(Me.lblDanhSachSP)
        Me.grbThongTinSP.Controls.Add(Me.txtMaLSP)
        Me.grbThongTinSP.Controls.Add(Me.txtDonGia)
        Me.grbThongTinSP.Controls.Add(Me.txtSoLuong)
        Me.grbThongTinSP.Controls.Add(Me.txtTenSP)
        Me.grbThongTinSP.Controls.Add(Me.txtMaSP)
        Me.grbThongTinSP.Controls.Add(Me.lblDonGia)
        Me.grbThongTinSP.Controls.Add(Me.lblLoaiSP)
        Me.grbThongTinSP.Controls.Add(Me.lblTenSP)
        Me.grbThongTinSP.Controls.Add(Me.lblSoLuong)
        Me.grbThongTinSP.Controls.Add(Me.lblMaSP)
        Me.grbThongTinSP.Controls.Add(Me.ptbHinhAnh)
        Me.grbThongTinSP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbThongTinSP.Location = New System.Drawing.Point(12, 81)
        Me.grbThongTinSP.Name = "grbThongTinSP"
        Me.grbThongTinSP.Size = New System.Drawing.Size(569, 452)
        Me.grbThongTinSP.TabIndex = 2
        Me.grbThongTinSP.TabStop = False
        Me.grbThongTinSP.Text = "Thông tin sản phẩm"
        '
        'dgvXemSanPham
        '
        Me.dgvXemSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvXemSanPham.BackgroundColor = System.Drawing.Color.White
        Me.dgvXemSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvXemSanPham.Location = New System.Drawing.Point(9, 262)
        Me.dgvXemSanPham.Name = "dgvXemSanPham"
        Me.dgvXemSanPham.ReadOnly = True
        Me.dgvXemSanPham.Size = New System.Drawing.Size(548, 184)
        Me.dgvXemSanPham.TabIndex = 27
        '
        'btnHienThi
        '
        Me.btnHienThi.Location = New System.Drawing.Point(219, 195)
        Me.btnHienThi.Name = "btnHienThi"
        Me.btnHienThi.Size = New System.Drawing.Size(54, 27)
        Me.btnHienThi.TabIndex = 26
        Me.btnHienThi.UseVisualStyleBackColor = True
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(359, 195)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(54, 27)
        Me.btnLast.TabIndex = 25
        Me.btnLast.Text = ">|"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(79, 195)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(54, 27)
        Me.btnFirst.TabIndex = 24
        Me.btnFirst.Text = "|<"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(289, 195)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(54, 27)
        Me.btnNext.TabIndex = 23
        Me.btnNext.Text = ">"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrev
        '
        Me.btnPrev.Location = New System.Drawing.Point(149, 195)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(54, 27)
        Me.btnPrev.TabIndex = 22
        Me.btnPrev.Text = "<"
        Me.btnPrev.UseVisualStyleBackColor = True
        '
        'btnDong
        '
        Me.btnDong.Location = New System.Drawing.Point(429, 195)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(82, 27)
        Me.btnDong.TabIndex = 21
        Me.btnDong.Text = "Đóng"
        Me.btnDong.UseVisualStyleBackColor = True
        '
        'lblDanhSachSP
        '
        Me.lblDanhSachSP.AutoSize = True
        Me.lblDanhSachSP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDanhSachSP.Location = New System.Drawing.Point(6, 234)
        Me.lblDanhSachSP.Name = "lblDanhSachSP"
        Me.lblDanhSachSP.Size = New System.Drawing.Size(137, 16)
        Me.lblDanhSachSP.TabIndex = 12
        Me.lblDanhSachSP.Text = "Danh sách sản phẩm:"
        '
        'txtMaLSP
        '
        Me.txtMaLSP.BackColor = System.Drawing.Color.White
        Me.txtMaLSP.Location = New System.Drawing.Point(128, 156)
        Me.txtMaLSP.Name = "txtMaLSP"
        Me.txtMaLSP.ReadOnly = True
        Me.txtMaLSP.Size = New System.Drawing.Size(150, 22)
        Me.txtMaLSP.TabIndex = 10
        '
        'txtDonGia
        '
        Me.txtDonGia.BackColor = System.Drawing.Color.White
        Me.txtDonGia.Location = New System.Drawing.Point(128, 124)
        Me.txtDonGia.Name = "txtDonGia"
        Me.txtDonGia.ReadOnly = True
        Me.txtDonGia.Size = New System.Drawing.Size(150, 22)
        Me.txtDonGia.TabIndex = 9
        '
        'txtSoLuong
        '
        Me.txtSoLuong.BackColor = System.Drawing.Color.White
        Me.txtSoLuong.Location = New System.Drawing.Point(128, 92)
        Me.txtSoLuong.Name = "txtSoLuong"
        Me.txtSoLuong.ReadOnly = True
        Me.txtSoLuong.Size = New System.Drawing.Size(150, 22)
        Me.txtSoLuong.TabIndex = 8
        '
        'txtTenSP
        '
        Me.txtTenSP.BackColor = System.Drawing.Color.White
        Me.txtTenSP.Location = New System.Drawing.Point(128, 60)
        Me.txtTenSP.Name = "txtTenSP"
        Me.txtTenSP.ReadOnly = True
        Me.txtTenSP.Size = New System.Drawing.Size(150, 22)
        Me.txtTenSP.TabIndex = 7
        '
        'txtMaSP
        '
        Me.txtMaSP.BackColor = System.Drawing.Color.White
        Me.txtMaSP.Location = New System.Drawing.Point(128, 28)
        Me.txtMaSP.Name = "txtMaSP"
        Me.txtMaSP.ReadOnly = True
        Me.txtMaSP.Size = New System.Drawing.Size(150, 22)
        Me.txtMaSP.TabIndex = 6
        '
        'lblDonGia
        '
        Me.lblDonGia.AutoSize = True
        Me.lblDonGia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDonGia.Location = New System.Drawing.Point(6, 127)
        Me.lblDonGia.Name = "lblDonGia"
        Me.lblDonGia.Size = New System.Drawing.Size(57, 16)
        Me.lblDonGia.TabIndex = 5
        Me.lblDonGia.Text = "Đơn giá:"
        '
        'lblLoaiSP
        '
        Me.lblLoaiSP.AutoSize = True
        Me.lblLoaiSP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoaiSP.Location = New System.Drawing.Point(6, 159)
        Me.lblLoaiSP.Name = "lblLoaiSP"
        Me.lblLoaiSP.Size = New System.Drawing.Size(99, 16)
        Me.lblLoaiSP.TabIndex = 4
        Me.lblLoaiSP.Text = "Loại sản phẩm:"
        '
        'lblTenSP
        '
        Me.lblTenSP.AutoSize = True
        Me.lblTenSP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTenSP.Location = New System.Drawing.Point(6, 63)
        Me.lblTenSP.Name = "lblTenSP"
        Me.lblTenSP.Size = New System.Drawing.Size(97, 16)
        Me.lblTenSP.TabIndex = 3
        Me.lblTenSP.Text = "Tên sản phẩm:"
        '
        'lblSoLuong
        '
        Me.lblSoLuong.AutoSize = True
        Me.lblSoLuong.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSoLuong.Location = New System.Drawing.Point(6, 95)
        Me.lblSoLuong.Name = "lblSoLuong"
        Me.lblSoLuong.Size = New System.Drawing.Size(64, 16)
        Me.lblSoLuong.TabIndex = 2
        Me.lblSoLuong.Text = "Số lượng:"
        '
        'lblMaSP
        '
        Me.lblMaSP.AutoSize = True
        Me.lblMaSP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaSP.Location = New System.Drawing.Point(6, 31)
        Me.lblMaSP.Name = "lblMaSP"
        Me.lblMaSP.Size = New System.Drawing.Size(92, 16)
        Me.lblMaSP.TabIndex = 1
        Me.lblMaSP.Text = "Mã sản phẩm:"
        '
        'ptbHinhAnh
        '
        Me.ptbHinhAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ptbHinhAnh.Image = Global.Assignment.My.Resources.Resources.AddMedia
        Me.ptbHinhAnh.Location = New System.Drawing.Point(332, 28)
        Me.ptbHinhAnh.Name = "ptbHinhAnh"
        Me.ptbHinhAnh.Size = New System.Drawing.Size(225, 150)
        Me.ptbHinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbHinhAnh.TabIndex = 0
        Me.ptbHinhAnh.TabStop = False
        '
        'grbTimKiem
        '
        Me.grbTimKiem.BackColor = System.Drawing.Color.PaleTurquoise
        Me.grbTimKiem.Controls.Add(Me.btnTimKiem)
        Me.grbTimKiem.Controls.Add(Me.cbbTimKiem)
        Me.grbTimKiem.Location = New System.Drawing.Point(12, 12)
        Me.grbTimKiem.Name = "grbTimKiem"
        Me.grbTimKiem.Size = New System.Drawing.Size(570, 62)
        Me.grbTimKiem.TabIndex = 3
        Me.grbTimKiem.TabStop = False
        Me.grbTimKiem.Text = "Tìm kiếm sản phẩm"
        '
        'btnTimKiem
        '
        Me.btnTimKiem.Location = New System.Drawing.Point(346, 19)
        Me.btnTimKiem.Name = "btnTimKiem"
        Me.btnTimKiem.Size = New System.Drawing.Size(108, 27)
        Me.btnTimKiem.TabIndex = 27
        Me.btnTimKiem.Text = "Tìm kiếm"
        Me.btnTimKiem.UseVisualStyleBackColor = True
        '
        'cbbTimKiem
        '
        Me.cbbTimKiem.BackColor = System.Drawing.Color.GhostWhite
        Me.cbbTimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbTimKiem.FormattingEnabled = True
        Me.cbbTimKiem.Location = New System.Drawing.Point(136, 21)
        Me.cbbTimKiem.Name = "cbbTimKiem"
        Me.cbbTimKiem.Size = New System.Drawing.Size(194, 24)
        Me.cbbTimKiem.TabIndex = 0
        '
        'frmXemSanPham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(593, 545)
        Me.Controls.Add(Me.grbTimKiem)
        Me.Controls.Add(Me.grbThongTinSP)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmXemSanPham"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thông Tin Sản Phẩm"
        Me.grbThongTinSP.ResumeLayout(False)
        Me.grbThongTinSP.PerformLayout()
        CType(Me.dgvXemSanPham, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbHinhAnh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbTimKiem.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grbThongTinSP As System.Windows.Forms.GroupBox
    Friend WithEvents btnHienThi As System.Windows.Forms.Button
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents btnFirst As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnPrev As System.Windows.Forms.Button
    Friend WithEvents btnDong As System.Windows.Forms.Button
    Friend WithEvents lblDanhSachSP As System.Windows.Forms.Label
    Friend WithEvents txtMaLSP As System.Windows.Forms.TextBox
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
    Friend WithEvents grbTimKiem As System.Windows.Forms.GroupBox
    Friend WithEvents btnTimKiem As System.Windows.Forms.Button
    Friend WithEvents cbbTimKiem As System.Windows.Forms.ComboBox
    Friend WithEvents dgvXemSanPham As System.Windows.Forms.DataGridView
End Class
