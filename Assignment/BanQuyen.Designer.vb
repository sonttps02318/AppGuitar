<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBanQuyen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBanQuyen))
        Me.lblMauXanh = New System.Windows.Forms.Label()
        Me.lblThongTin = New System.Windows.Forms.Label()
        Me.lblThaiSon = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.btnCheckUpdate = New System.Windows.Forms.Button()
        Me.lblMauXanh2 = New System.Windows.Forms.Label()
        Me.lblMauTrang = New System.Windows.Forms.Label()
        Me.lblShow_MaSV = New System.Windows.Forms.Label()
        Me.lblShow_Lop = New System.Windows.Forms.Label()
        Me.lblTen_NguoiPT = New System.Windows.Forms.Label()
        Me.lblMaSV = New System.Windows.Forms.Label()
        Me.lblLop = New System.Windows.Forms.Label()
        Me.lblNguoiPT = New System.Windows.Forms.Label()
        Me.btnDong = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblMauXanh
        '
        Me.lblMauXanh.BackColor = System.Drawing.Color.PaleTurquoise
        Me.lblMauXanh.Location = New System.Drawing.Point(12, 9)
        Me.lblMauXanh.Name = "lblMauXanh"
        Me.lblMauXanh.Size = New System.Drawing.Size(617, 196)
        Me.lblMauXanh.TabIndex = 0
        '
        'lblThongTin
        '
        Me.lblThongTin.BackColor = System.Drawing.Color.PaleTurquoise
        Me.lblThongTin.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblThongTin.Location = New System.Drawing.Point(115, 23)
        Me.lblThongTin.Name = "lblThongTin"
        Me.lblThongTin.Size = New System.Drawing.Size(411, 29)
        Me.lblThongTin.TabIndex = 2
        Me.lblThongTin.Text = "THÔNG TIN BẢN QUYỀN PHẦN MỀM"
        '
        'lblThaiSon
        '
        Me.lblThaiSon.BackColor = System.Drawing.Color.PaleTurquoise
        Me.lblThaiSon.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblThaiSon.ForeColor = System.Drawing.Color.Red
        Me.lblThaiSon.Location = New System.Drawing.Point(222, 68)
        Me.lblThaiSon.Name = "lblThaiSon"
        Me.lblThaiSon.Size = New System.Drawing.Size(196, 29)
        Me.lblThaiSon.TabIndex = 3
        Me.lblThaiSon.Text = "Thái Sơn Guitar's"
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.BackColor = System.Drawing.Color.PaleTurquoise
        Me.lblVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.Location = New System.Drawing.Point(194, 113)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(252, 16)
        Me.lblVersion.TabIndex = 4
        Me.lblVersion.Text = "Version: 2015.1 Build 2 (04/04/2015)"
        '
        'btnCheckUpdate
        '
        Me.btnCheckUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckUpdate.Location = New System.Drawing.Point(237, 145)
        Me.btnCheckUpdate.Name = "btnCheckUpdate"
        Me.btnCheckUpdate.Size = New System.Drawing.Size(167, 33)
        Me.btnCheckUpdate.TabIndex = 5
        Me.btnCheckUpdate.Text = "Check for Update"
        Me.btnCheckUpdate.UseVisualStyleBackColor = True
        '
        'lblMauXanh2
        '
        Me.lblMauXanh2.BackColor = System.Drawing.Color.PaleTurquoise
        Me.lblMauXanh2.Location = New System.Drawing.Point(0, 205)
        Me.lblMauXanh2.Name = "lblMauXanh2"
        Me.lblMauXanh2.Size = New System.Drawing.Size(641, 203)
        Me.lblMauXanh2.TabIndex = 1
        '
        'lblMauTrang
        '
        Me.lblMauTrang.BackColor = System.Drawing.Color.White
        Me.lblMauTrang.Location = New System.Drawing.Point(12, 205)
        Me.lblMauTrang.Name = "lblMauTrang"
        Me.lblMauTrang.Size = New System.Drawing.Size(617, 192)
        Me.lblMauTrang.TabIndex = 7
        '
        'lblShow_MaSV
        '
        Me.lblShow_MaSV.AutoSize = True
        Me.lblShow_MaSV.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShow_MaSV.ForeColor = System.Drawing.Color.Red
        Me.lblShow_MaSV.Location = New System.Drawing.Point(334, 309)
        Me.lblShow_MaSV.Name = "lblShow_MaSV"
        Me.lblShow_MaSV.Size = New System.Drawing.Size(68, 16)
        Me.lblShow_MaSV.TabIndex = 14
        Me.lblShow_MaSV.Text = "PS02318"
        '
        'lblShow_Lop
        '
        Me.lblShow_Lop.AutoSize = True
        Me.lblShow_Lop.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShow_Lop.ForeColor = System.Drawing.Color.Red
        Me.lblShow_Lop.Location = New System.Drawing.Point(334, 273)
        Me.lblShow_Lop.Name = "lblShow_Lop"
        Me.lblShow_Lop.Size = New System.Drawing.Size(60, 16)
        Me.lblShow_Lop.TabIndex = 13
        Me.lblShow_Lop.Text = "PT9303"
        '
        'lblTen_NguoiPT
        '
        Me.lblTen_NguoiPT.AutoSize = True
        Me.lblTen_NguoiPT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTen_NguoiPT.ForeColor = System.Drawing.Color.Red
        Me.lblTen_NguoiPT.Location = New System.Drawing.Point(334, 237)
        Me.lblTen_NguoiPT.Name = "lblTen_NguoiPT"
        Me.lblTen_NguoiPT.Size = New System.Drawing.Size(93, 16)
        Me.lblTen_NguoiPT.TabIndex = 12
        Me.lblTen_NguoiPT.Text = "Tạ Thái Sơn"
        '
        'lblMaSV
        '
        Me.lblMaSV.AutoSize = True
        Me.lblMaSV.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaSV.Location = New System.Drawing.Point(200, 309)
        Me.lblMaSV.Name = "lblMaSV"
        Me.lblMaSV.Size = New System.Drawing.Size(119, 16)
        Me.lblMaSV.TabIndex = 11
        Me.lblMaSV.Text = "Mã số sinh viên:"
        '
        'lblLop
        '
        Me.lblLop.AutoSize = True
        Me.lblLop.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLop.Location = New System.Drawing.Point(218, 273)
        Me.lblLop.Name = "lblLop"
        Me.lblLop.Size = New System.Drawing.Size(101, 16)
        Me.lblLop.TabIndex = 10
        Me.lblLop.Text = "Sinh viên lớp:"
        '
        'lblNguoiPT
        '
        Me.lblNguoiPT.AutoSize = True
        Me.lblNguoiPT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNguoiPT.Location = New System.Drawing.Point(123, 237)
        Me.lblNguoiPT.Name = "lblNguoiPT"
        Me.lblNguoiPT.Size = New System.Drawing.Size(196, 16)
        Me.lblNguoiPT.TabIndex = 8
        Me.lblNguoiPT.Text = "Người phát triển phần mềm:"
        '
        'btnDong
        '
        Me.btnDong.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDong.Location = New System.Drawing.Point(278, 355)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(84, 29)
        Me.btnDong.TabIndex = 16
        Me.btnDong.Text = "Đóng"
        Me.btnDong.UseVisualStyleBackColor = True
        '
        'frmBanQuyen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(641, 406)
        Me.Controls.Add(Me.btnDong)
        Me.Controls.Add(Me.lblShow_MaSV)
        Me.Controls.Add(Me.lblShow_Lop)
        Me.Controls.Add(Me.lblTen_NguoiPT)
        Me.Controls.Add(Me.lblMaSV)
        Me.Controls.Add(Me.lblLop)
        Me.Controls.Add(Me.lblNguoiPT)
        Me.Controls.Add(Me.lblMauTrang)
        Me.Controls.Add(Me.btnCheckUpdate)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.lblThaiSon)
        Me.Controls.Add(Me.lblThongTin)
        Me.Controls.Add(Me.lblMauXanh2)
        Me.Controls.Add(Me.lblMauXanh)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmBanQuyen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thông tin phần mềm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMauXanh As System.Windows.Forms.Label
    Friend WithEvents lblThongTin As System.Windows.Forms.Label
    Friend WithEvents lblThaiSon As System.Windows.Forms.Label
    Friend WithEvents lblVersion As System.Windows.Forms.Label
    Friend WithEvents btnCheckUpdate As System.Windows.Forms.Button
    Friend WithEvents lblMauXanh2 As System.Windows.Forms.Label
    Friend WithEvents lblMauTrang As System.Windows.Forms.Label
    Friend WithEvents lblShow_MaSV As System.Windows.Forms.Label
    Friend WithEvents lblShow_Lop As System.Windows.Forms.Label
    Friend WithEvents lblTen_NguoiPT As System.Windows.Forms.Label
    Friend WithEvents lblMaSV As System.Windows.Forms.Label
    Friend WithEvents lblLop As System.Windows.Forms.Label
    Friend WithEvents lblNguoiPT As System.Windows.Forms.Label
    Friend WithEvents btnDong As System.Windows.Forms.Button
End Class
