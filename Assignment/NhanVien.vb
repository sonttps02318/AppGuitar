Imports System.Data.SqlClient
Imports System.Data.DataTable


Public Class frmNhanVien
    Dim bang As New DataTable
    Dim ConnectionLoad As String = "workstation id=thaison.mssql.somee.com;packet size=4096;user id=ps02318;pwd=P@ssword12;data source=thaison.mssql.somee.com;persist security info=False;initial catalog=thaison"

    Public Sub TaiDuLieu()

        'Tạo kết nối
        Dim Connect As New SqlConnection(ConnectionLoad)
        Dim SQL As New SqlDataAdapter("select * from NhanVien", Connect)

        Try

            'Đổ dữ liệu trên Datatable vào Table trên máy
            SQL.Fill(bang)

        Catch ex As Exception
        End Try

        'Hiển thị dữ liệu Từ Datatable ra giao diện thông qua Datagridview
        dgvNhanVien.DataSource = bang
        Connect.Close() 'đóng kết nối

    End Sub


    'xử lý sự kiện form load Nhân viên
    Private Sub frmNhanVien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Tạo kết nối
        Dim Connect As New SqlConnection(ConnectionLoad)
        Dim SQL As New SqlDataAdapter("select * from NhanVien", Connect)

        Try
            'mở kết nối
            Connect.Open()
            'Đổ dữ liệu trên Table vào Datatable trên máy
            SQL.Fill(bang)

        Catch ex As Exception
        End Try

        'Hiển thị dữ liệu Từ Datatable ra giao diện thông qua Datagridview
        dgvNhanVien.DataSource = bang
        Connect.Close() 'đóng kết nối



        'nếu là tài khoản là user thì vô hiệu hóa 3 nút thêm, sữa và xóa
        If frmMain.lblHienThi.Text = "User" Then
            btnSua.Enabled = False
            btnXoa.Enabled = False
            btnThem.Enabled = False
            txtMaNV.Clear()
            txtTenTK.Clear()
            txtMatKhau.Clear()
            txtTenNV.Clear()
            txtDiaChi.Clear()
            txtSoDT.Clear()
            dgvNhanVien.Visible = False

        End If

        dgvNhanVien.GridColor = Drawing.Color.PaleTurquoise

    End Sub





    'Xử lý sự kiện thêm nhân viên
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        'Kết nối tới Database Online trên Somee thông qua chuổi kết nối
        Dim Connect As New SqlConnection(ConnectionLoad)
        Dim InsertSP As New SqlDataAdapter("INSERT INTO NhanVien VALUES ('" & txtMaNV.Text & "','" & txtTenTK.Text & "','" & txtMatKhau.Text & "',N'" & txtTenNV.Text & "',N'" & txtDiaChi.Text & "','" & txtSoDT.Text & "')", Connect)

        Try
            'Mở kết nối
            Connect.Open()
            InsertSP.Fill(bang)

            'Thông báo khi thêm sản phẩm thành công
            MessageBox.Show("Nhân viên mới đã được thêm vào dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception

            'Thông báo khi thêm sản phẩm không thành công
            MessageBox.Show("Vui lòng kiểm tra lại thông tin nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        'chuyển dữ liệu qua bảng
        dgvNhanVien.DataSource = bang
        'đóng kết nối
        Connect.Close()

        'tải lại sản phẩm vừa thêm lên DataGridView
        bang.Clear()
        dgvNhanVien.DataSource = Nothing
        TaiDuLieu()
    End Sub




    'xử lý sự kiện Sữa thông tin nhân viên
    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        'Kết nối tới Database Online trên Somee thông qua chuổi kết nối
        Dim Connect As New SqlConnection(ConnectionLoad)

        'Mở kết nối
        Connect.Open()

        'Dùng lệnh UPdate để sữa thông tin nhân viên
        Dim UpdateNV As String = "UPDATE NhanVien SET MaNV = @MaNV, TenTK = @TenTK, MatKhau = @MatKhau, TenNV = @TenNV, DiaChi = @DiaChi, SoDT = @SoDT WHERE MaNV = @MaNV"

        Dim cmd As New SqlCommand(UpdateNV, Connect)
        Try
            'Cập nhập dữ liệu
            cmd.Parameters.AddWithValue("@MaNV", txtMaNV.Text)
            cmd.Parameters.AddWithValue("@TenTK", txtTenTK.Text)
            cmd.Parameters.AddWithValue("@MatKhau", txtMatKhau.Text)
            cmd.Parameters.AddWithValue("@TenNV", txtTenNV.Text)
            cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text)
            cmd.Parameters.AddWithValue("@SoDT", txtSoDT.Text)
            'Thực thi câu lệnh và cập nhập dữ liệu lên Database
            cmd.ExecuteNonQuery()

            'Thông báo khi cập nhập sản phẩm thành công
            MessageBox.Show("Thông tin nhân viên đã được cập nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)

            'Kết thúc kết nối
            Connect.Close()

        Catch ex As Exception
            'Thông báo khi cập nhập sản phẩm không thành công
            MessageBox.Show("Vui lòng kiểm tra lại thông tin nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

        'tải lại sản phẩm lên DataGridView
        bang.Clear()
        dgvNhanVien.DataSource = bang
        dgvNhanVien.DataSource = Nothing
        TaiDuLieu()
    End Sub


    'Xử lý sự kiện khi nhấn vào btnXoa
    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        'Kết nối tới Database Online trên Somee thông qua chuổi kết nối
        Dim Connect As New SqlConnection(ConnectionLoad)
        'Mở kết nối
        Connect.Open()
        'Dùng lệnh Delete để xóa dữ liệu
        Dim DeleteNV As String = "Delete From NhanVien Where MaNV = @MaNV"

        Dim cmd As New SqlCommand(DeleteNV, Connect)
        Try

            'Khai báo biến dialog kiểu DialogResult nắm giữ hộp thoại 2 nút hỏi Yes và No
            Dim dialog As DialogResult = MessageBox.Show("Bạn muốn xóa nhân viên này ?",
                                        "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            'Nếu nhấp nút Yes thì đóng form đang nhập và kết thúc ứng dụng
            If (dialog = DialogResult.Yes) Then
                'Xóa dữ liệu
                cmd.Parameters.AddWithValue("@MaNV", txtMaNV.Text)

                'Thực thi câu lệnh và cập nhập dữ liệu lên Database
                cmd.ExecuteNonQuery()
                'Thông báo khi xóa nhân viên thành công
                MessageBox.Show("Thông tin & Tài khoản của nhân viên đã được xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'Kết thúc kết nối
                Connect.Close()
            End If
           


        Catch ex As Exception

        End Try

        'tải lại sản phẩm lên DataGridView
        bang.Clear()
        dgvNhanVien.DataSource = bang
        dgvNhanVien.DataSource = Nothing
        TaiDuLieu()
    End Sub



    'xử lý sự kiện btnThoát
    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        'đóng ứng dụng
        Me.Close()
    End Sub


    'Xử lý sự kiện nhấp vào hình ảnh
    Private Sub ptbHinhAnh_Click(sender As Object, e As EventArgs) Handles ptbHinhAnh.Click
        MessageBox.Show("Hình ảnh sẽ được cập nhập sau !!!")
    End Sub



    'xử lý sự kiện click vào nhân viên bất kỳ sẽ hiện thông tin lên textbox tương ứng
    Private Sub dgvNhanVien_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvNhanVien.CellContentClick
        Dim selected As Integer = dgvNhanVien.CurrentCell.RowIndex
        txtMaNV.Text = dgvNhanVien.Item(0, selected).Value
        txtTenTK.Text = dgvNhanVien.Item(1, selected).Value
        txtMatKhau.Text = dgvNhanVien.Item(2, selected).Value
        txtTenNV.Text = dgvNhanVien.Item(3, selected).Value
        txtDiaChi.Text = dgvNhanVien.Item(4, selected).Value
        txtSoDT.Text = dgvNhanVien.Item(5, selected).Value
    End Sub
End Class