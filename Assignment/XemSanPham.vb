Imports System.Data.SqlClient
Imports System.Data.DataTable
Imports System.IO

Public Class frmXemSanPham

    Dim bang As New DataTable
    Dim ConnectionLoad As String = "workstation id=thaison.mssql.somee.com;packet size=4096;user id=ps02318;pwd=P@ssword12;data source=thaison.mssql.somee.com;persist security info=False;initial catalog=thaison"

    Public Sub TaiDuLieu()

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
        dgvXemSanPham.DataSource = bang
        Connect.Close() 'đóng kết nối

    End Sub

    'xử lý xự kiện Form Load Xem sản phẩm
    Private Sub frmXemSanPham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        dgvXemSanPham.DataSource = bang
        Connect.Close() 'đóng kết nối

        dgvXemSanPham.GridColor = Drawing.Color.PaleTurquoise

    End Sub

    'xử lý sự kiện click vào sản phẩm bất kỳ sẽ hiện thông tin lên textbox tương ứng
    Private Sub dgvXemSanPham_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvXemSanPham.CellContentClick
        Dim selected As Integer = dgvXemSanPham.CurrentCell.RowIndex
        txtMaSP.Text = dgvXemSanPham.Item(0, selected).Value
        txtTenSP.Text = dgvXemSanPham.Item(1, selected).Value
        txtSoLuong.Text = dgvXemSanPham.Item(2, selected).Value
        txtDonGia.Text = dgvXemSanPham.Item(3, selected).Value
        txtMaLSP.Text = dgvXemSanPham.Item(4, selected).Value

    End Sub


    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        'Đóng ứng dụng
        Me.Close()
    End Sub




    'hiển thị Form
    Sub HienThiForm(ByVal i As Integer)
        'lấy i tại vị trí  i từ DSSV
        Dim SP As SanPham = ChiaSe.DSSP(i)

        'cung cấp thônh tin cho các thành phần của sản phẩm
        txtMaSP.Text = SP.masp
        txtTenSP.Text = SP.tsp
        txtSoLuong.Text = SP.sl
        txtDonGia.Text = SP.gia
        txtMaLSP.Text = SP.lsp
        'chọn mục tương ứng cho cbo tìm kiếm
        If (i >= 0 And i <= ChiaSe.DSSP.Count - 1) Then
            cbbTimKiem.SelectedIndex = i
        End If
    End Sub


    ' hiển thị combobox tìm kiếm
    Sub HienThiComboBoxTimKiem()
        'xóa các mục trong cbb tìm kiếm trước khi thêm vào
        cbbTimKiem.Items.Clear()
        'duyệt DSSV và thêm vào cbb tìm kiemt61
        For i As Integer = 0 To ChiaSe.DSSP.Count - 1
            Dim SP As SanPham = ChiaSe.DSSP(i)
            'gán tên sản phẩm để hiển thị trên combobox
            txtTenSP.Text = SP.tsp
            cbbTimKiem.Items.Add(txtTenSP.Text)
        Next
    End Sub


    ''cập nhập trạng thái
    Sub CapNhapTrangThai(ByVal i As Integer)
        'hiển thị vị trí hiện tại
        btnHienThi.Text = (i + 1)

        'điều khiển trạng thái
        btnFirst.Enabled = (i <> 0)
        btnPrev.Enabled = (i <> 0)
        btnNext.Enabled = (i <> bang.Rows.Count - 1)
        btnLast.Enabled = (i <> ChiaSe.DSSP.Count - 1)
    End Sub

    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs) Handles btnTimKiem.Click
        'Lấy vị trí mục chọn của cbb Tim kiếm
        Dim i As Integer = cbbTimKiem.SelectedIndex
        'hiển thị SV tại vị trí i trên form
        Me.HienThiForm(i)
        'Cập nhập trạng thái các nút điều hướng
        Me.CapNhapTrangThai(i)
    End Sub


    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        'vị trí đầu tiên
        Dim i As Integer = 0
        Me.HienThiForm(i)
        Me.CapNhapTrangThai(i)
    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        'lấy vị trí kế kế trước
        Dim i As Integer = Val(btnHienThi.Text) - 1 - 1
        'hiển thị sv ở vị trí i lên form
        Me.HienThiForm(i)
        'Cập nhập trạng thái các nút điều hướng
        Me.CapNhapTrangThai(i)
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        'lấy vị trí kế sau
        Dim i As Integer = Val(btnHienThi.Text) - 1 + 1
        'hiển thị sinh viên ở vị trí i lên form
        Me.HienThiForm(i)
        'cập nhập trạng thái các nút điều hướng
        Me.CapNhapTrangThai(i)
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        'lấy vị trí cuối của sinh viên
        Dim i As Integer = ChiaSe.DSSP.Count - 1
        'hiển thị sinh viên ở vị trí i lên form
        Me.HienThiForm(i)
        'cập nhập trạng thái các nút điều hướng
        Me.CapNhapTrangThai(i)
    End Sub


End Class
