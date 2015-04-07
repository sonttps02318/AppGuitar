Imports System.Data.SqlClient
Imports System.Data.DataTable



Public Class frmThemSanPham
    Dim bang As New DataTable
    Dim ConnectionLoad As String = "workstation id=thaison.mssql.somee.com;packet size=4096;user id=ps02318;pwd=P@ssword12;data source=thaison.mssql.somee.com;persist security info=False;initial catalog=thaison"

    Public Sub TaiDuLieu()

        'Tạo kết nối
        Dim Connect As New SqlConnection(ConnectionLoad)
        Dim SQL As New SqlDataAdapter("select * from SanPham", Connect)

        Try
           
            'Đổ dữ liệu trên Datatable vào Table trên máy
            SQL.Fill(bang)

        Catch ex As Exception
        End Try

        'Hiển thị dữ liệu Từ Datatable ra giao diện thông qua Datagridview
        dgvThemSanPham.DataSource = bang
        Connect.Close() 'đóng kết nối

    End Sub

   
    'xử lý sự kiện form load ThemSanPham
    Private Sub frmThemSanPham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Tạo kết nối
        Dim Connect As New SqlConnection(ConnectionLoad)
        Dim SQL As New SqlDataAdapter("select * from SanPham", Connect)

        Try
            'mở kết nối
            Connect.Open()
            'Đổ dữ liệu trên Table vào Datatable trên máy
            SQL.Fill(bang)

        Catch ex As Exception
        End Try

        'Hiển thị dữ liệu Từ Datatable ra giao diện thông qua Datagridview
        dgvThemSanPham.DataSource = bang
        Connect.Close() 'đóng kết nối

        'nếu là tài khoản là user thì vô hiệu hóa nút xóa
        If frmMain.lblHienThi.Text = "User" Then
            btnXoa.Enabled = False

        Else
            'còn tài khoản admin thì ngược lại
            btnXoa.Enabled = True

        End If


        dgvThemSanPham.GridColor = Drawing.Color.PaleTurquoise


    End Sub




    'Xử lý sự kiện thêm sản phẩm
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        'Kết nối tới Database Online trên Somee thông qua chuổi kết nối
        Dim Connect As New SqlConnection(ConnectionLoad)
        Dim InsertSP As New SqlDataAdapter("INSERT INTO Sanpham VALUES ('" & txtMaSP.Text & "','" & txtTenSP.Text & "','" & txtSoLuong.Text & "','" & txtDonGia.Text & "','" & txtLoaiSP.Text & "')",Connect)

        Try
            'Mở kết nối
            Connect.Open()
            InsertSP.Fill(bang)

            'Thông báo khi thêm sản phẩm thành công
            MessageBox.Show("Sản phẩm đã được thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception

            'Thông báo khi thêm sản phẩm không thành công
            MessageBox.Show("Vui lòng kiểm tra lại thông tin sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        'chuyển dữ liệu qua bảng
        dgvThemSanPham.DataSource = bang
        'đóng kết nối
        Connect.Close()

        'tải lại sản phẩm vừa thêm lên DataGridView
        bang.Clear()
        dgvThemSanPham.DataSource = Nothing
        TaiDuLieu()
    End Sub





    'xử lý sự kiện Sữa một sản phẩm bất kỳ
    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        'Kết nối tới Database Online trên Somee thông qua chuổi kết nối
        Dim Connect As New SqlConnection(ConnectionLoad)

        'Mở kết nối
        Connect.Open()

        'Dùng lệnh UPdate để sữa dữ liệu
        Dim UpdateSP As String = "UPDATE Sanpham SET MaSP = @MaSP, TenSP = @TenSP, SoLuong = @SoLuong, DonGia = @DonGia, MaLSP = @MaLSP WHERE MaSP = @MaSP"

        Dim cmd As New SqlCommand(UpdateSP, Connect)
        Try
            'Cập nhập dữ liệu
            cmd.Parameters.AddWithValue("@MaSP", txtMaSP.Text)
            cmd.Parameters.AddWithValue("@TenSP", txtTenSP.Text)
            cmd.Parameters.AddWithValue("@SoLuong", txtSoLuong.Text)
            cmd.Parameters.AddWithValue("@DonGia", txtDonGia.Text)
            cmd.Parameters.AddWithValue("@MaLSP", txtLoaiSP.Text)

            'Thực thi câu lệnh và cập nhập dữ liệu lên Database
            cmd.ExecuteNonQuery()

            'Thông báo khi cập nhập sản phẩm thành công
            MessageBox.Show("Dữ liệu đã được cập nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)

            'Kết thúc kết nối
            Connect.Close()

        Catch ex As Exception
            'Thông báo khi cập nhập sản phẩm không thành công
            MessageBox.Show("Vui lòng kiểm tra lại dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

        'tải lại sản phẩm lên DataGridView
        bang.Clear()
        dgvThemSanPham.DataSource = bang
        dgvThemSanPham.DataSource = Nothing
        TaiDuLieu()
    End Sub




    'Xử lý sự kiện khi nhấn vào btnXoa
    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        'Kết nối tới Database Online trên Somee thông qua chuổi kết nối
        Dim Connect As New SqlConnection(ConnectionLoad)
        'Mở kết nối
        Connect.Open()
        'Dùng lệnh Delete để xóa dữ liệu
        Dim DeleteSP As String = "Delete From Sanpham Where MaSP = @MaSP"

        Dim cmd As New SqlCommand(DeleteSP, Connect)
        Try


            'Khai báo biến dialog kiểu DialogResult nắm giữ hộp thoại 2 nút hỏi Yes và No
            Dim dialog As DialogResult = MessageBox.Show("Bạn muốn xóa sản phẩm này ?",
                                        "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            'Nếu nhấp nút Yes thì đóng form đang nhập và kết thúc ứng dụng
            If (dialog = DialogResult.Yes) Then
              
                'Xóa dữ liệu
                cmd.Parameters.AddWithValue("@MaSP", txtMaSP.Text)

                'Thực thi câu lệnh và cập nhập dữ liệu lên Database
                cmd.ExecuteNonQuery()
                'Thông báo khi xóa sản phẩm thành công
                MessageBox.Show("Sản phẩm đã được xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'Kết thúc kết nối
                Connect.Close()

            End If
          

        Catch ex As Exception

        End Try

        'tải lại sản phẩm lên DataGridView
        bang.Clear()
        dgvThemSanPham.DataSource = bang
        dgvThemSanPham.DataSource = Nothing
        TaiDuLieu()
    End Sub





    'xử lý sự kiện btnThoát
    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        'đóng ứng dụng
        Me.Close()
    End Sub




    'xử lý sự kiện lưu hình ảnh
    Private Sub ptbHinhAnh_Click(sender As Object, e As EventArgs) Handles ptbHinhAnh.Click

        'chọn hình ảnh
        If ofdHinhAnh.ShowDialog() = DialogResult.OK Then
            'copy file vào thư mục nguồn
            FileCopy(ofdHinhAnh.FileName, ofdHinhAnh.SafeFileName)
            ptbHinhAnh.ImageLocation = ofdHinhAnh.SafeFileName
        End If
    End Sub





    'xử lý sự kiện click vào sản phẩm bất kỳ sẽ hiện thông tin lên textbox tương ứng
    Private Sub dgvThemSanPham_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvThemSanPham.CellContentClick
        Dim selected As Integer = dgvThemSanPham.CurrentCell.RowIndex
        txtMaSP.Text = dgvThemSanPham.Item(0, selected).Value
        txtTenSP.Text = dgvThemSanPham.Item(1, selected).Value
        txtSoLuong.Text = dgvThemSanPham.Item(2, selected).Value
        txtDonGia.Text = dgvThemSanPham.Item(3, selected).Value
        txtLoaiSP.Text = dgvThemSanPham.Item(4, selected).Value
    End Sub

    'xử lý sự kiện chỉ cho nhập số vào txtdongia
    Private Sub txtDonGia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDonGia.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub


    'xử lý sự kiện chỉ cho nhập số vào txtSoLuong
    Private Sub txtSoLuong_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSoLuong.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub
End Class