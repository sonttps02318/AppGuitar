Public Class frmMain


    'Sự kiện khi click vào menu item Thoát
    Private Sub mniThoat_Click(sender As Object, e As EventArgs) Handles mniThoat.Click
        'Khai báo biến dialog kiểu DialogResult nắm giữ hộp thoại 2 nút hỏi Yes và No
        Dim dialog As DialogResult = MessageBox.Show("Bạn muốn kết thúc ứng dụng ?",
                                    "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        'Nếu nhấp nút Yes thì đóng form đang nhập và kết thúc ứng dụng
        If (dialog = DialogResult.Yes) Then
            'Đóng ứng dụng
            Me.Close()
            Application.Exit()
        End If
    End Sub

    'Sự kiện khi click vào menu item Đăng xuất
    Private Sub mniDangXuat_Click(sender As Object, e As EventArgs) Handles mniDangXuat.Click
        frmLogin.Show()
        frmLogin.txtTenDangNhap.Clear()
        frmLogin.txtMatKhau.Clear()
        frmLogin.txtTenDangNhap.Focus()
        Me.Hide()
    End Sub

    Private Sub mniThemSanPham_Click(sender As Object, e As EventArgs) Handles mniThemSanPham.Click
        frmThemSanPham.Show()
    End Sub

    Private Sub mniXemThongTinSanPham_Click(sender As Object, e As EventArgs) Handles mniXemThongTinSanPham.Click
        frmXemSanPham.Show()
    End Sub

    Private Sub mniBanQuyen_Click(sender As Object, e As EventArgs)
        frmBanQuyen.Show()
    End Sub

    Private Sub mniBanQuyen_Click_1(sender As Object, e As EventArgs) Handles mniBanQuyen.Click
        frmBanQuyen.ShowDialog()
    End Sub

    Private Sub mniTroGiup_Click(sender As Object, e As EventArgs) Handles mniTroGiup.Click
        Help.ShowHelp(Me, "HuongDanSuDung.chm")
    End Sub

    Private Sub mniBanHang_Click(sender As Object, e As EventArgs) Handles mniBanHang.Click
        frmDatHang.ShowDialog()
    End Sub

    Private Sub NhânViênToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NhânViênToolStripMenuItem.Click
        frmNhanVien.ShowDialog()
    End Sub
End Class