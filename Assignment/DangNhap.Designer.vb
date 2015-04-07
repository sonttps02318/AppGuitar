<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.lblTenDangNhap = New System.Windows.Forms.Label()
        Me.txtTenDangNhap = New System.Windows.Forms.TextBox()
        Me.txtMatKhau = New System.Windows.Forms.TextBox()
        Me.lblMatKhau = New System.Windows.Forms.Label()
        Me.btnDangNhap = New System.Windows.Forms.Button()
        Me.ptbLogin = New System.Windows.Forms.PictureBox()
        CType(Me.ptbLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnThoat
        '
        Me.btnThoat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.btnThoat.Location = New System.Drawing.Point(403, 143)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(88, 28)
        Me.btnThoat.TabIndex = 0
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'lblTenDangNhap
        '
        Me.lblTenDangNhap.AutoSize = True
        Me.lblTenDangNhap.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTenDangNhap.Location = New System.Drawing.Point(254, 10)
        Me.lblTenDangNhap.Name = "lblTenDangNhap"
        Me.lblTenDangNhap.Size = New System.Drawing.Size(102, 16)
        Me.lblTenDangNhap.TabIndex = 1
        Me.lblTenDangNhap.Text = "Tên đăng nhập:"
        '
        'txtTenDangNhap
        '
        Me.txtTenDangNhap.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtTenDangNhap.Location = New System.Drawing.Point(257, 34)
        Me.txtTenDangNhap.Name = "txtTenDangNhap"
        Me.txtTenDangNhap.Size = New System.Drawing.Size(234, 23)
        Me.txtTenDangNhap.TabIndex = 2
        '
        'txtMatKhau
        '
        Me.txtMatKhau.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtMatKhau.Location = New System.Drawing.Point(257, 100)
        Me.txtMatKhau.Name = "txtMatKhau"
        Me.txtMatKhau.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtMatKhau.Size = New System.Drawing.Size(234, 23)
        Me.txtMatKhau.TabIndex = 5
        '
        'lblMatKhau
        '
        Me.lblMatKhau.AutoSize = True
        Me.lblMatKhau.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMatKhau.Location = New System.Drawing.Point(257, 70)
        Me.lblMatKhau.Name = "lblMatKhau"
        Me.lblMatKhau.Size = New System.Drawing.Size(65, 16)
        Me.lblMatKhau.TabIndex = 4
        Me.lblMatKhau.Text = "Mật khẩu:"
        '
        'btnDangNhap
        '
        Me.btnDangNhap.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.btnDangNhap.Location = New System.Drawing.Point(309, 143)
        Me.btnDangNhap.Name = "btnDangNhap"
        Me.btnDangNhap.Size = New System.Drawing.Size(88, 28)
        Me.btnDangNhap.TabIndex = 9
        Me.btnDangNhap.Text = "Đăng nhập"
        Me.btnDangNhap.UseVisualStyleBackColor = True
        '
        'ptbLogin
        '
        Me.ptbLogin.Image = Global.Assignment.My.Resources.Resources.login_img
        Me.ptbLogin.Location = New System.Drawing.Point(0, 2)
        Me.ptbLogin.Name = "ptbLogin"
        Me.ptbLogin.Size = New System.Drawing.Size(251, 175)
        Me.ptbLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbLogin.TabIndex = 3
        Me.ptbLogin.TabStop = False
        '
        'frmLogin
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(506, 183)
        Me.Controls.Add(Me.btnDangNhap)
        Me.Controls.Add(Me.txtMatKhau)
        Me.Controls.Add(Me.lblMatKhau)
        Me.Controls.Add(Me.ptbLogin)
        Me.Controls.Add(Me.txtTenDangNhap)
        Me.Controls.Add(Me.lblTenDangNhap)
        Me.Controls.Add(Me.btnThoat)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Đăng nhập"
        CType(Me.ptbLogin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnThoat As System.Windows.Forms.Button
    Friend WithEvents lblTenDangNhap As System.Windows.Forms.Label
    Friend WithEvents txtTenDangNhap As System.Windows.Forms.TextBox
    Friend WithEvents txtMatKhau As System.Windows.Forms.TextBox
    Friend WithEvents lblMatKhau As System.Windows.Forms.Label
    Friend WithEvents btnDangNhap As System.Windows.Forms.Button
    Friend WithEvents ptbLogin As System.Windows.Forms.PictureBox

End Class
