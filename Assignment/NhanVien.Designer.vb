<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNhanVien
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
        Me.grbDanhSachSP = New System.Windows.Forms.GroupBox()
        Me.txtMatKhau = New System.Windows.Forms.TextBox()
        Me.lblMatKhau = New System.Windows.Forms.Label()
        Me.dgvNhanVien = New System.Windows.Forms.DataGridView()
        Me.lblChonHinhNV = New System.Windows.Forms.Label()
        Me.txtSoDT = New System.Windows.Forms.TextBox()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.txtTenNV = New System.Windows.Forms.TextBox()
        Me.txtTenTK = New System.Windows.Forms.TextBox()
        Me.txtMaNV = New System.Windows.Forms.TextBox()
        Me.lblDiaChi = New System.Windows.Forms.Label()
        Me.lblSoDT = New System.Windows.Forms.Label()
        Me.lblTenTK = New System.Windows.Forms.Label()
        Me.lblTenNV = New System.Windows.Forms.Label()
        Me.lblMaNV = New System.Windows.Forms.Label()
        Me.ptbHinhAnh = New System.Windows.Forms.PictureBox()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.lblThongTinSP = New System.Windows.Forms.Label()
        Me.grbDanhSachSP.SuspendLayout()
        CType(Me.dgvNhanVien, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbHinhAnh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grbDanhSachSP
        '
        Me.grbDanhSachSP.BackColor = System.Drawing.Color.PaleTurquoise
        Me.grbDanhSachSP.Controls.Add(Me.txtMatKhau)
        Me.grbDanhSachSP.Controls.Add(Me.lblMatKhau)
        Me.grbDanhSachSP.Controls.Add(Me.dgvNhanVien)
        Me.grbDanhSachSP.Controls.Add(Me.lblChonHinhNV)
        Me.grbDanhSachSP.Controls.Add(Me.txtSoDT)
        Me.grbDanhSachSP.Controls.Add(Me.txtDiaChi)
        Me.grbDanhSachSP.Controls.Add(Me.txtTenNV)
        Me.grbDanhSachSP.Controls.Add(Me.txtTenTK)
        Me.grbDanhSachSP.Controls.Add(Me.txtMaNV)
        Me.grbDanhSachSP.Controls.Add(Me.lblDiaChi)
        Me.grbDanhSachSP.Controls.Add(Me.lblSoDT)
        Me.grbDanhSachSP.Controls.Add(Me.lblTenTK)
        Me.grbDanhSachSP.Controls.Add(Me.lblTenNV)
        Me.grbDanhSachSP.Controls.Add(Me.lblMaNV)
        Me.grbDanhSachSP.Controls.Add(Me.ptbHinhAnh)
        Me.grbDanhSachSP.Controls.Add(Me.btnThoat)
        Me.grbDanhSachSP.Controls.Add(Me.btnXoa)
        Me.grbDanhSachSP.Controls.Add(Me.btnSua)
        Me.grbDanhSachSP.Controls.Add(Me.btnThem)
        Me.grbDanhSachSP.Controls.Add(Me.lblThongTinSP)
        Me.grbDanhSachSP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbDanhSachSP.Location = New System.Drawing.Point(11, 12)
        Me.grbDanhSachSP.Name = "grbDanhSachSP"
        Me.grbDanhSachSP.Size = New System.Drawing.Size(606, 409)
        Me.grbDanhSachSP.TabIndex = 4
        Me.grbDanhSachSP.TabStop = False
        Me.grbDanhSachSP.Text = "Danh sách nhân viên"
        '
        'txtMatKhau
        '
        Me.txtMatKhau.BackColor = System.Drawing.Color.White
        Me.txtMatKhau.Location = New System.Drawing.Point(133, 282)
        Me.txtMatKhau.Name = "txtMatKhau"
        Me.txtMatKhau.Size = New System.Drawing.Size(156, 22)
        Me.txtMatKhau.TabIndex = 32
        '
        'lblMatKhau
        '
        Me.lblMatKhau.AutoSize = True
        Me.lblMatKhau.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMatKhau.Location = New System.Drawing.Point(11, 285)
        Me.lblMatKhau.Name = "lblMatKhau"
        Me.lblMatKhau.Size = New System.Drawing.Size(65, 16)
        Me.lblMatKhau.TabIndex = 31
        Me.lblMatKhau.Text = "Mật khẩu:"
        '
        'dgvNhanVien
        '
        Me.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvNhanVien.BackgroundColor = System.Drawing.Color.White
        Me.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNhanVien.Location = New System.Drawing.Point(14, 21)
        Me.dgvNhanVien.Name = "dgvNhanVien"
        Me.dgvNhanVien.Size = New System.Drawing.Size(577, 159)
        Me.dgvNhanVien.TabIndex = 30
        '
        'lblChonHinhNV
        '
        Me.lblChonHinhNV.AutoSize = True
        Me.lblChonHinhNV.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChonHinhNV.Location = New System.Drawing.Point(342, 375)
        Me.lblChonHinhNV.Name = "lblChonHinhNV"
        Me.lblChonHinhNV.Size = New System.Drawing.Size(126, 16)
        Me.lblChonHinhNV.TabIndex = 29
        Me.lblChonHinhNV.Text = "Chọn hình nhân viên"
        '
        'txtSoDT
        '
        Me.txtSoDT.BackColor = System.Drawing.Color.White
        Me.txtSoDT.Location = New System.Drawing.Point(133, 372)
        Me.txtSoDT.Name = "txtSoDT"
        Me.txtSoDT.Size = New System.Drawing.Size(156, 22)
        Me.txtSoDT.TabIndex = 28
        '
        'txtDiaChi
        '
        Me.txtDiaChi.BackColor = System.Drawing.Color.White
        Me.txtDiaChi.Location = New System.Drawing.Point(133, 342)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(156, 22)
        Me.txtDiaChi.TabIndex = 27
        '
        'txtTenNV
        '
        Me.txtTenNV.BackColor = System.Drawing.Color.White
        Me.txtTenNV.Location = New System.Drawing.Point(133, 312)
        Me.txtTenNV.Name = "txtTenNV"
        Me.txtTenNV.Size = New System.Drawing.Size(156, 22)
        Me.txtTenNV.TabIndex = 26
        '
        'txtTenTK
        '
        Me.txtTenTK.BackColor = System.Drawing.Color.White
        Me.txtTenTK.Location = New System.Drawing.Point(133, 252)
        Me.txtTenTK.Name = "txtTenTK"
        Me.txtTenTK.Size = New System.Drawing.Size(156, 22)
        Me.txtTenTK.TabIndex = 25
        '
        'txtMaNV
        '
        Me.txtMaNV.BackColor = System.Drawing.Color.White
        Me.txtMaNV.Location = New System.Drawing.Point(133, 222)
        Me.txtMaNV.Name = "txtMaNV"
        Me.txtMaNV.Size = New System.Drawing.Size(156, 22)
        Me.txtMaNV.TabIndex = 24
        '
        'lblDiaChi
        '
        Me.lblDiaChi.AutoSize = True
        Me.lblDiaChi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiaChi.Location = New System.Drawing.Point(11, 345)
        Me.lblDiaChi.Name = "lblDiaChi"
        Me.lblDiaChi.Size = New System.Drawing.Size(51, 16)
        Me.lblDiaChi.TabIndex = 23
        Me.lblDiaChi.Text = "Địa chỉ:"
        '
        'lblSoDT
        '
        Me.lblSoDT.AutoSize = True
        Me.lblSoDT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSoDT.Location = New System.Drawing.Point(11, 375)
        Me.lblSoDT.Name = "lblSoDT"
        Me.lblSoDT.Size = New System.Drawing.Size(89, 16)
        Me.lblSoDT.TabIndex = 22
        Me.lblSoDT.Text = "Số điện thoại:"
        '
        'lblTenTK
        '
        Me.lblTenTK.AutoSize = True
        Me.lblTenTK.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTenTK.Location = New System.Drawing.Point(11, 255)
        Me.lblTenTK.Name = "lblTenTK"
        Me.lblTenTK.Size = New System.Drawing.Size(92, 16)
        Me.lblTenTK.TabIndex = 21
        Me.lblTenTK.Text = "Tên tài khoản:"
        '
        'lblTenNV
        '
        Me.lblTenNV.AutoSize = True
        Me.lblTenNV.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTenNV.Location = New System.Drawing.Point(11, 315)
        Me.lblTenNV.Name = "lblTenNV"
        Me.lblTenNV.Size = New System.Drawing.Size(95, 16)
        Me.lblTenNV.TabIndex = 20
        Me.lblTenNV.Text = "Tên nhân viên:"
        '
        'lblMaNV
        '
        Me.lblMaNV.AutoSize = True
        Me.lblMaNV.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaNV.Location = New System.Drawing.Point(11, 225)
        Me.lblMaNV.Name = "lblMaNV"
        Me.lblMaNV.Size = New System.Drawing.Size(90, 16)
        Me.lblMaNV.TabIndex = 19
        Me.lblMaNV.Text = "Mã nhân viên:"
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
        Me.lblThongTinSP.Size = New System.Drawing.Size(118, 16)
        Me.lblThongTinSP.TabIndex = 12
        Me.lblThongTinSP.Text = "Tạo tài khoản mới:"
        '
        'frmNhanVien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(629, 433)
        Me.Controls.Add(Me.grbDanhSachSP)
        Me.Name = "frmNhanVien"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quản lý nhân viên"
        Me.grbDanhSachSP.ResumeLayout(False)
        Me.grbDanhSachSP.PerformLayout()
        CType(Me.dgvNhanVien, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbHinhAnh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grbDanhSachSP As System.Windows.Forms.GroupBox
    Friend WithEvents txtMatKhau As System.Windows.Forms.TextBox
    Friend WithEvents lblMatKhau As System.Windows.Forms.Label
    Friend WithEvents dgvNhanVien As System.Windows.Forms.DataGridView
    Friend WithEvents lblChonHinhNV As System.Windows.Forms.Label
    Friend WithEvents txtSoDT As System.Windows.Forms.TextBox
    Friend WithEvents txtDiaChi As System.Windows.Forms.TextBox
    Friend WithEvents txtTenNV As System.Windows.Forms.TextBox
    Friend WithEvents txtTenTK As System.Windows.Forms.TextBox
    Friend WithEvents txtMaNV As System.Windows.Forms.TextBox
    Friend WithEvents lblDiaChi As System.Windows.Forms.Label
    Friend WithEvents lblSoDT As System.Windows.Forms.Label
    Friend WithEvents lblTenTK As System.Windows.Forms.Label
    Friend WithEvents lblTenNV As System.Windows.Forms.Label
    Friend WithEvents lblMaNV As System.Windows.Forms.Label
    Friend WithEvents ptbHinhAnh As System.Windows.Forms.PictureBox
    Friend WithEvents btnThoat As System.Windows.Forms.Button
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents btnSua As System.Windows.Forms.Button
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents lblThongTinSP As System.Windows.Forms.Label
End Class
