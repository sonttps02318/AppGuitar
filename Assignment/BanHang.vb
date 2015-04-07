Imports System.IO
Public Class frmDatHang

    'khai báo biến
    Dim tong As Decimal
    Dim kq1 As Decimal
    Dim kq2 As Decimal
    Dim kq3 As Decimal
    Dim kq4 As Decimal
    Dim kq5 As Decimal
    Dim StrGia1 As Decimal

  
    'xứ lý sự kiện chọn số lượng của ComboBox Genius và tính tổng
    Private Sub cbbGenius_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbbGenius.SelectedValueChanged, cbbGenius.FormatStringChanged
        'nếu mục check sản phẩm đc chọn thì tính tổng

        If chkGenius.Checked = True And cbbGenius.SelectedItem = True Then
            tong = cbbGenius.SelectedItem * String.Format("{0:n}", lblGia1.Text)
            lblKQ1.Text = String.Format("{0:n}", tong)
            lblKQ1.Text = String.Format("{0:n}", tong)
        Else
            MessageBox.Show("Chọn sản phẩm tương ứng với mục số lượng đang chọn", "Thông báo",
                      MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        'xét điều kiện chkgenius
        If chkGenius.Checked = True Then
            kq1 = (cbbGenius.SelectedIndex + 1) * lblGia1.Text
        Else
            kq1 = 0
        End If

        'xét điều kiện chkc70
        If chkC70.Checked = True Then
            kq2 = (cbbC70.SelectedIndex + 1) * lblGia2.Text
        Else
            kq2 = 0
        End If

        'xét điều kiện chkukele
        If chkUkele.Checked = True Then
            kq3 = (cbbUkele.SelectedIndex + 1) * lblGia3.Text
        Else
            kq3 = 0
        End If

        'xét điều kiện chkmg
        If chkMG.Checked = True Then
            kq4 = (cbbMG.SelectedIndex + 1) * lblGia4.Text
        Else
            kq4 = 0
        End If

        'xét điều kiện chkgenius
        If chkPacifica.Checked = True Then
            kq5 = (cbbPACIFICA.SelectedIndex + 1) * lblGia5.Text
        Else
            kq5 = 0
        End If

        'tíng tổng sản phẩm
        tong = kq1 + kq2 + kq3 + kq4 + kq5
        lblTongThanhTien.Text = String.Format("{0:n}", tong) & " " & "VNĐ"
    End Sub

    'xứ lý sự kiện chọn số lượng của ComboBox C70 và tính tổng
    Private Sub cbbC70_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbbC70.SelectedValueChanged
        'nếu mục check sản phẩm đc chọn thì tính tổng
        If chkC70.Checked = True And cbbC70.SelectedItem = True Then
            tong = cbbC70.SelectedItem * String.Format("{0:n}", lblGia2.Text)
            lblKQ2.Text = String.Format("{0:n}", tong)
        Else
            MessageBox.Show("Chọn sản phẩm tương ứng với mục số lượng đang chọn", "Thông báo",
                      MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        'xét điều kiện chkgenius
        If chkGenius.Checked = True Then
            kq1 = (cbbGenius.SelectedIndex + 1) * lblGia1.Text
        Else
            kq1 = 0
        End If

        'xét điều kiện chkc70
        If chkC70.Checked = True Then
            kq2 = (cbbC70.SelectedIndex + 1) * lblGia2.Text
        Else
            kq2 = 0
        End If

        'xét điều kiện chkukele
        If chkUkele.Checked = True Then
            kq3 = (cbbUkele.SelectedIndex + 1) * lblGia3.Text
        Else
            kq3 = 0
        End If

        'xét điều kiện chkmg
        If chkMG.Checked = True Then
            kq4 = (cbbMG.SelectedIndex + 1) * lblGia4.Text
        Else
            kq4 = 0
        End If

        'xét điều kiện chkgenius
        If chkPacifica.Checked = True Then
            kq5 = (cbbPACIFICA.SelectedIndex + 1) * lblGia5.Text
        Else
            kq5 = 0
        End If

        'tíng tổng sản phẩm
        tong = kq1 + kq2 + kq3 + kq4 + kq5
        lblTongThanhTien.Text = String.Format("{0:n}", tong) & " " & "VNĐ"
    End Sub

    'xứ lý sự kiện chọn số lượng của ComboBox Ukele và tính tổng
    Private Sub cbbUkele_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbbUkele.SelectedValueChanged
        'nếu mục check sản phẩm đc chọn thì tính tổng
        If chkUkele.Checked = True And cbbUkele.SelectedItem = True Then
            tong = cbbUkele.SelectedItem * String.Format("{0:n}", lblGia3.Text)
            lblKQ3.Text = String.Format("{0:n}", tong)
        Else
            MessageBox.Show("Chọn sản phẩm tương ứng với mục số lượng đang chọn", "Thông báo",
                      MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        'xét điều kiện chkgenius
        If chkGenius.Checked = True Then
            kq1 = (cbbGenius.SelectedIndex + 1) * lblGia1.Text
        Else
            kq1 = 0
        End If

        'xét điều kiện chkc70
        If chkC70.Checked = True Then
            kq2 = (cbbC70.SelectedIndex + 1) * lblGia2.Text
        Else
            kq2 = 0
        End If

        'xét điều kiện chkukele
        If chkUkele.Checked = True Then
            kq3 = (cbbUkele.SelectedIndex + 1) * lblGia3.Text
        Else
            kq3 = 0
        End If

        'xét điều kiện chkmg
        If chkMG.Checked = True Then
            kq4 = (cbbMG.SelectedIndex + 1) * lblGia4.Text
        Else
            kq4 = 0
        End If

        'xét điều kiện chkgenius
        If chkPacifica.Checked = True Then
            kq5 = (cbbPACIFICA.SelectedIndex + 1) * lblGia5.Text
        Else
            kq5 = 0
        End If

        'tíng tổng sản phẩm
        tong = kq1 + kq2 + kq3 + kq4 + kq5
        lblTongThanhTien.Text = String.Format("{0:n}", tong) & " " & "VNĐ"
    End Sub

    'xứ lý sự kiện chọn số lượng của ComboBox MG và tính tổng
    Private Sub cbbMG_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbbMG.SelectedValueChanged
        'nếu mục check sản phẩm đc chọn thì tính tổng
        If chkMG.Checked = True And cbbMG.SelectedItem = True Then
            tong = cbbMG.SelectedItem * String.Format("{0:n}", lblGia4.Text)
            lblKQ4.Text = String.Format("{0:n}", tong)
        Else
            MessageBox.Show("Chọn sản phẩm tương ứng với mục số lượng đang chọn", "Thông báo",
                      MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


        'xét điều kiện chkgenius
        If chkGenius.Checked = True Then
            kq1 = (cbbGenius.SelectedIndex + 1) * lblGia1.Text
        Else
            kq1 = 0
        End If

        'xét điều kiện chkc70
        If chkC70.Checked = True Then
            kq2 = (cbbC70.SelectedIndex + 1) * lblGia2.Text
        Else
            kq2 = 0
        End If

        'xét điều kiện chkukele
        If chkUkele.Checked = True Then
            kq3 = (cbbUkele.SelectedIndex + 1) * lblGia3.Text
        Else
            kq3 = 0
        End If

        'xét điều kiện chkmg
        If chkMG.Checked = True Then
            kq4 = (cbbMG.SelectedIndex + 1) * lblGia4.Text
        Else
            kq4 = 0
        End If

        'xét điều kiện chkgenius
        If chkPacifica.Checked = True Then
            kq5 = (cbbPACIFICA.SelectedIndex + 1) * lblGia5.Text
        Else
            kq5 = 0
        End If

        'tíng tổng sản phẩm
        tong = kq1 + kq2 + kq3 + kq4 + kq5
        lblTongThanhTien.Text = String.Format("{0:n}", tong) & " " & "VNĐ"

    End Sub

    'xứ lý sự kiện chọn số lượng của ComboBox PACIFICA và tính tổng
    Private Sub cbbPACIFICA_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbbPACIFICA.SelectedValueChanged
        'nếu mục check sản phẩm đc chọn thì tính tổng
        If chkPacifica.Checked = True And cbbPACIFICA.SelectedItem = True Then
            tong = cbbPACIFICA.SelectedItem * String.Format("{0:n}", lblGia5.Text)
            lblKQ5.Text = String.Format("{0:n}", tong)
        Else
            MessageBox.Show("Chọn sản phẩm tương ứng với mục số lượng đang chọn", "Thông báo",
                      MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


        'xét điều kiện chkgenius
        If chkGenius.Checked = True Then
            kq1 = (cbbGenius.SelectedIndex + 1) * lblGia1.Text
        Else
            kq1 = 0
        End If

        'xét điều kiện chkc70
        If chkC70.Checked = True Then
            kq2 = (cbbC70.SelectedIndex + 1) * lblGia2.Text
        Else
            kq2 = 0
        End If

        'xét điều kiện chkukele
        If chkUkele.Checked = True Then
            kq3 = (cbbUkele.SelectedIndex + 1) * lblGia3.Text
        Else
            kq3 = 0
        End If

        'xét điều kiện chkmg
        If chkMG.Checked = True Then
            kq4 = (cbbMG.SelectedIndex + 1) * lblGia4.Text
        Else
            kq4 = 0
        End If

        'xét điều kiện chkgenius
        If chkPacifica.Checked = True Then
            kq5 = (cbbPACIFICA.SelectedIndex + 1) * lblGia5.Text
        Else
            kq5 = 0
        End If

        'tíng tổng sản phẩm
        tong = kq1 + kq2 + kq3 + kq4 + kq5
        lblTongThanhTien.Text = String.Format("{0:n}", tong) & " " & "VNĐ"
    End Sub

    'xử lý sự kiện Button Print và ghi xuống file
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

        If txtTenKH.Text = "" OrElse txtSoDonHang.Text = "" Then
            MessageBox.Show("Xin nhập đầy đủ thông tin cần thiết", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else

            'đưa dữ liệu xuống file
            Dim luu As New StreamWriter("donhang.txt", True)
            Dim thongtin As String = String.Concat(txtSoDonHang.Text, vbTab, txtTenKH.Text, vbTab, txtDC.Text, vbTab, txtSoDT.Text, vbTab, cbbTP.Text, vbTab, chkGenius.Text, vbTab, cbbGenius.Text, vbTab, chkC70.Text, vbTab, cbbC70.Text, vbTab, chkUkele.Text, vbTab, cbbUkele.Text, vbTab, chkMG.Text, vbTab, cbbMG.Text, vbTab, chkPacifica.Text, vbTab, cbbPACIFICA.Text, vbTab, lblTongThanhTien.Text)
            'ghi vào file donhang.txt
            luu.WriteLine(thongtin)
            'đóng file
            luu.Close()

            'thông báo in hóa đơn thành công
            MessageBox.Show("Hóa đơn được in thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        'xóa dữ liệu khi đã lưu hoàn tất
        txtSoDonHang.Text = ""
        txtTenKH.Text = ""
        txtDC.Text = ""
        txtSoDT.Text = ""
        chkGenius.Checked = False
        chkC70.Checked = False
        chkMG.Checked = False
        chkPacifica.Checked = False
        chkUkele.Checked = False
        lblKQ1.Text = ""
        lblKQ2.Text = ""
        lblKQ3.Text = ""
        lblKQ4.Text = ""
        lblKQ5.Text = ""
        lblTongThanhTien.Text = ""
        txtSoDonHang.Focus()
    End Sub


End Class

