'chèn dữ liệu hệ thống SQL CLient
Imports System.Data.SqlClient
Public Class frmLogin

    'Sự kiện khi click vào button đăng nhập
    Private Sub btnDangNhap_Click(sender As Object, e As EventArgs) Handles btnDangNhap.Click
        'khai báo chuỗi kết nối tới Database trên Somee
        Dim ConnectionDN As String = "workstation id=thaison.mssql.somee.com;packet size=4096;user id=ps02318;pwd=P@ssword12;data source=thaison.mssql.somee.com;persist security info=False;initial catalog=thaison"

        'Tạo kết nối
        Dim ConnectDN As SqlConnection = New SqlConnection(ConnectionDN)
        'truy xuất và gán tên đăng nhập, mật khẩu trên Database Somee với textbox tương ứng
        Dim sqlAdapter As New SqlDataAdapter("select * from NhanVien where TenTK='" & txtTenDangNhap.Text & "' and MatKhau='" & txtMatKhau.Text & "' ", ConnectDN)


        'tạo bảng dữ liệu mới
        Dim tb As New DataTable

        Try
            ConnectDN.Open() 'mở kết nối
            sqlAdapter.Fill(tb) 'đổ dữ liệu vào bảng
            If tb.Rows.Count > 0 Then
                'tên đăng nhập và mật khẩu đúng sẽ hiện thông báo
                MessageBox.Show("Kết nối và đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Hide() 'ẩn form đăng nhập
                frmMain.Show() 'hiện from main

                'Hiển thị vai trò đăng nhập trong Form Main
                If txtTenDangNhap.Text = "admin" Then
                    frmMain.lblHienThi.Text = "Admin"
                Else
                    frmMain.lblHienThi.Text = "User"
                End If
            Else
                'tên đăng nhập hoặc mật khẩu sai sẽ hiện thông báo
                MessageBox.Show("Bạn đã nhập sai tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtTenDangNhap.Clear() 'xóa tên đăng nhập
                txtMatKhau.Clear()      'xóa mật khẩu đã nhập
                txtTenDangNhap.Focus()  'con nháy hiển thị ở textbox đăng nhập
            End If

        Catch ex As Exception
        End Try


    End Sub


    'Sự kiện khi click vào button Thoat
    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
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



    'Nhấp phím Enter trong textbox tài khoản
    Private Sub txtTenDangNhap_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTenDangNhap.KeyDown
        If e.KeyCode = Keys.Enter Then 'nếu phím nhấn là phím Enter thì
            txtMatKhau.Focus()          'chuyển con nháy đến textbox mật khẩu
        End If
    End Sub

    'Nhấp phím Enter trong textbox mật khẩu
    Private Sub txtMatKhau_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMatKhau.KeyDown
        If e.KeyCode = Keys.Enter Then 'nếu phím nhấn là phím Enter thì
            btnDangNhap.PerformClick()  'Click vào button đăng nhập
        End If
    End Sub



    Private Sub cbbVaiTro_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then 'nếu phím nhấn là phím Enter thì
            btnDangNhap.PerformClick()  'Click vào button đăng nhập
        End If
    End Sub



End Class
