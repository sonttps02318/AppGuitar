Public Class frmBanQuyen

    Private Sub btnCheckUpdate_Click(sender As Object, e As EventArgs) Handles btnCheckUpdate.Click
        MessageBox.Show("Bạn đang xài phiên bản mới nhất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    'đóng form
    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Close()
    End Sub
End Class