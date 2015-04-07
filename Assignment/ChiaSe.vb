Imports System.IO
Imports System.Data.DataTable
Imports System.Data.SqlClient
'-------------------------------------------------------
'Định nghĩa kiểu dữ liệu mới
'-------------------------------------------------------

Public Structure SanPham
    Dim masp As String
    Dim tsp As String
    Dim lsp As String
    Dim sl As String
    Dim gia As String
    Dim HinhAnh As String
End Structure

Public Class ChiaSe


    'Khai báo danh sách sản phẩm dùng chung
    Public Shared DSSP As New List(Of SanPham)


    Shared Sub TaiDuLieu()
        Dim bang As New DataTable
        Dim ConnectionLoad As String = "workstation id=thaison.mssql.somee.com;packet size=4096;user id=ps02318;pwd=P@ssword12;data source=thaison.mssql.somee.com;persist security info=False;initial catalog=thaison"
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
        Connect.Close() 'đóng kết nối
        'Hiển thị dữ liệu Từ Datatable ra giao diện thông qua Datagridview
        frmXemSanPham.dgvXemSanPham.DataSource = bang
        'đưa dữ liệu xuống file
        Dim luu As New StreamWriter("SP.txt", True)
        Dim thongtin As String = String.Concat(bang)
        'ghi vào file SP.txt
        luu.WriteLine(thongtin)
        'đóng file


        'mở file chứa danh sản phẩm để đọc
        Dim FileName As String = "SP.txt"
        Dim Reader As New StreamReader(FileName)
        'xóa sạch DSSP đã tải trước đó để chứa danh sách mới
        DSSP.Clear()
        'thực hiện công việc cho đến hết file
        Do Until Reader.EndOfStream
            'đọc 1 hàng từ file
            Dim Row As String = Reader.ReadLine()

            'tách hàng vừa đọc thành nhiều cột
            Dim Columns() As String = Row.Split(ControlChars.Tab)
            If (Columns.Length = 5) Then
                'tạo một sản phẩm mới
                Dim SP As New SanPham()
                'chuyển các cột thành vào các thuộc tính của SanPham
                SP.masp = Columns(0)
                SP.tsp = Columns(1)
                SP.sl = Columns(2)
                SP.gia = Columns(3)
                SP.lsp = Columns(4)

                ChiaSe.DSSP.Add(SP) 'bổ sung sinh viên vào DSSV
            End If
        Loop
        Reader.Close() ' đóng file dữ liệu
        luu.Close()



    End Sub


End Class


