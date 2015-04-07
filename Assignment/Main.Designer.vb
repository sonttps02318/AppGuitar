<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.mnsMenu = New System.Windows.Forms.MenuStrip()
        Me.mniHeThong = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniDangXuat = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniThoat = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniQuanLySanPham = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniThemSanPham = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniBanHang = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniXemThongTinSanPham = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLýNhânViênToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NhânViênToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniThongTin = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniBanQuyen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniTroGiup = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblTenCuaHang = New System.Windows.Forms.Label()
        Me.lblAmNhacTrongToi = New System.Windows.Forms.Label()
        Me.stsBot = New System.Windows.Forms.StatusStrip()
        Me.lblTen = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblVaiTro = New System.Windows.Forms.Label()
        Me.lblHienThi = New System.Windows.Forms.Label()
        Me.ptbGuitar = New System.Windows.Forms.PictureBox()
        Me.mnsMenu.SuspendLayout()
        Me.stsBot.SuspendLayout()
        CType(Me.ptbGuitar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnsMenu
        '
        Me.mnsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniHeThong, Me.mniQuanLySanPham, Me.QuảnLýNhânViênToolStripMenuItem, Me.mniThongTin})
        Me.mnsMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnsMenu.Name = "mnsMenu"
        Me.mnsMenu.Size = New System.Drawing.Size(645, 24)
        Me.mnsMenu.TabIndex = 0
        Me.mnsMenu.Text = "MenuStrip1"
        '
        'mniHeThong
        '
        Me.mniHeThong.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniDangXuat, Me.mniThoat})
        Me.mniHeThong.Name = "mniHeThong"
        Me.mniHeThong.Size = New System.Drawing.Size(69, 20)
        Me.mniHeThong.Text = "Hệ thống"
        '
        'mniDangXuat
        '
        Me.mniDangXuat.Image = Global.Assignment.My.Resources.Resources._Exit
        Me.mniDangXuat.Name = "mniDangXuat"
        Me.mniDangXuat.Size = New System.Drawing.Size(127, 22)
        Me.mniDangXuat.Text = "Đăng xuất"
        '
        'mniThoat
        '
        Me.mniThoat.Image = Global.Assignment.My.Resources.Resources.Exit_button
        Me.mniThoat.Name = "mniThoat"
        Me.mniThoat.Size = New System.Drawing.Size(127, 22)
        Me.mniThoat.Text = "Thoát"
        '
        'mniQuanLySanPham
        '
        Me.mniQuanLySanPham.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniThemSanPham, Me.mniBanHang, Me.mniXemThongTinSanPham})
        Me.mniQuanLySanPham.Name = "mniQuanLySanPham"
        Me.mniQuanLySanPham.Size = New System.Drawing.Size(115, 20)
        Me.mniQuanLySanPham.Text = "Quản lý sản phẩm"
        '
        'mniThemSanPham
        '
        Me.mniThemSanPham.Image = Global.Assignment.My.Resources.Resources.Add
        Me.mniThemSanPham.Name = "mniThemSanPham"
        Me.mniThemSanPham.Size = New System.Drawing.Size(205, 22)
        Me.mniThemSanPham.Text = "Thêm sản phẩm"
        '
        'mniBanHang
        '
        Me.mniBanHang.Image = Global.Assignment.My.Resources.Resources.i
        Me.mniBanHang.Name = "mniBanHang"
        Me.mniBanHang.Size = New System.Drawing.Size(205, 22)
        Me.mniBanHang.Text = "Bán hàng"
        '
        'mniXemThongTinSanPham
        '
        Me.mniXemThongTinSanPham.Image = Global.Assignment.My.Resources.Resources.Book
        Me.mniXemThongTinSanPham.Name = "mniXemThongTinSanPham"
        Me.mniXemThongTinSanPham.Size = New System.Drawing.Size(205, 22)
        Me.mniXemThongTinSanPham.Text = "Xem thông tin sản phẩm"
        '
        'QuảnLýNhânViênToolStripMenuItem
        '
        Me.QuảnLýNhânViênToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NhânViênToolStripMenuItem})
        Me.QuảnLýNhânViênToolStripMenuItem.Name = "QuảnLýNhânViênToolStripMenuItem"
        Me.QuảnLýNhânViênToolStripMenuItem.Size = New System.Drawing.Size(115, 20)
        Me.QuảnLýNhânViênToolStripMenuItem.Text = "Quản lý nhân viên"
        '
        'NhânViênToolStripMenuItem
        '
        Me.NhânViênToolStripMenuItem.Image = Global.Assignment.My.Resources.Resources.them_hinh
        Me.NhânViênToolStripMenuItem.Name = "NhânViênToolStripMenuItem"
        Me.NhânViênToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.NhânViênToolStripMenuItem.Text = "Nhân viên"
        '
        'mniThongTin
        '
        Me.mniThongTin.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniBanQuyen, Me.mniTroGiup})
        Me.mniThongTin.Name = "mniThongTin"
        Me.mniThongTin.Size = New System.Drawing.Size(71, 20)
        Me.mniThongTin.Text = "Thông tin"
        '
        'mniBanQuyen
        '
        Me.mniBanQuyen.Image = Global.Assignment.My.Resources.Resources.Info
        Me.mniBanQuyen.Name = "mniBanQuyen"
        Me.mniBanQuyen.Size = New System.Drawing.Size(130, 22)
        Me.mniBanQuyen.Text = "Bản quyền"
        '
        'mniTroGiup
        '
        Me.mniTroGiup.Image = Global.Assignment.My.Resources.Resources.Help
        Me.mniTroGiup.Name = "mniTroGiup"
        Me.mniTroGiup.Size = New System.Drawing.Size(130, 22)
        Me.mniTroGiup.Text = "Trợ giúp"
        '
        'lblTenCuaHang
        '
        Me.lblTenCuaHang.AutoSize = True
        Me.lblTenCuaHang.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTenCuaHang.ForeColor = System.Drawing.Color.Red
        Me.lblTenCuaHang.Location = New System.Drawing.Point(-5, 200)
        Me.lblTenCuaHang.Name = "lblTenCuaHang"
        Me.lblTenCuaHang.Size = New System.Drawing.Size(194, 25)
        Me.lblTenCuaHang.TabIndex = 2
        Me.lblTenCuaHang.Text = "Thái Sơn Guitar's"
        '
        'lblAmNhacTrongToi
        '
        Me.lblAmNhacTrongToi.AutoSize = True
        Me.lblAmNhacTrongToi.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmNhacTrongToi.ForeColor = System.Drawing.Color.Red
        Me.lblAmNhacTrongToi.Location = New System.Drawing.Point(9, 243)
        Me.lblAmNhacTrongToi.Name = "lblAmNhacTrongToi"
        Me.lblAmNhacTrongToi.Size = New System.Drawing.Size(187, 25)
        Me.lblAmNhacTrongToi.TabIndex = 3
        Me.lblAmNhacTrongToi.Text = "Âm nhạc trong Tôi"
        '
        'stsBot
        '
        Me.stsBot.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblTen})
        Me.stsBot.Location = New System.Drawing.Point(0, 478)
        Me.stsBot.Name = "stsBot"
        Me.stsBot.Size = New System.Drawing.Size(645, 22)
        Me.stsBot.TabIndex = 4
        Me.stsBot.Text = "StatusStrip1"
        '
        'lblTen
        '
        Me.lblTen.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblTen.Image = Global.Assignment.My.Resources.Resources.vit
        Me.lblTen.Name = "lblTen"
        Me.lblTen.Size = New System.Drawing.Size(188, 17)
        Me.lblTen.Text = "Tạ Thái Sơn - PS02318 - PT9303"
        '
        'lblVaiTro
        '
        Me.lblVaiTro.AutoSize = True
        Me.lblVaiTro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVaiTro.Location = New System.Drawing.Point(3, 450)
        Me.lblVaiTro.Name = "lblVaiTro"
        Me.lblVaiTro.Size = New System.Drawing.Size(158, 16)
        Me.lblVaiTro.TabIndex = 5
        Me.lblVaiTro.Text = "Đăng nhập với vai trò:"
        '
        'lblHienThi
        '
        Me.lblHienThi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHienThi.ForeColor = System.Drawing.Color.Blue
        Me.lblHienThi.Location = New System.Drawing.Point(167, 450)
        Me.lblHienThi.Name = "lblHienThi"
        Me.lblHienThi.Size = New System.Drawing.Size(134, 16)
        Me.lblHienThi.TabIndex = 6
        '
        'ptbGuitar
        '
        Me.ptbGuitar.Image = Global.Assignment.My.Resources.Resources.bg
        Me.ptbGuitar.Location = New System.Drawing.Point(90, 26)
        Me.ptbGuitar.Name = "ptbGuitar"
        Me.ptbGuitar.Size = New System.Drawing.Size(648, 450)
        Me.ptbGuitar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.ptbGuitar.TabIndex = 1
        Me.ptbGuitar.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(645, 500)
        Me.Controls.Add(Me.lblHienThi)
        Me.Controls.Add(Me.lblVaiTro)
        Me.Controls.Add(Me.stsBot)
        Me.Controls.Add(Me.lblAmNhacTrongToi)
        Me.Controls.Add(Me.lblTenCuaHang)
        Me.Controls.Add(Me.ptbGuitar)
        Me.Controls.Add(Me.mnsMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnsMenu
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Phần mềm quản lý đàn Guitar"
        Me.mnsMenu.ResumeLayout(False)
        Me.mnsMenu.PerformLayout()
        Me.stsBot.ResumeLayout(False)
        Me.stsBot.PerformLayout()
        CType(Me.ptbGuitar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnsMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents mniHeThong As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniDangXuat As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniThoat As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniQuanLySanPham As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniThemSanPham As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniXemThongTinSanPham As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniThongTin As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniBanQuyen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ptbGuitar As System.Windows.Forms.PictureBox
    Friend WithEvents lblTenCuaHang As System.Windows.Forms.Label
    Friend WithEvents lblAmNhacTrongToi As System.Windows.Forms.Label
    Friend WithEvents stsBot As System.Windows.Forms.StatusStrip
    Friend WithEvents lblTen As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblVaiTro As System.Windows.Forms.Label
    Friend WithEvents lblHienThi As System.Windows.Forms.Label
    Friend WithEvents mniBanHang As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniTroGiup As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuảnLýNhânViênToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NhânViênToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
