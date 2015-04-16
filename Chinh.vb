Public Class frmChinh

    'Sự kiện khi ấn nút mniThoat
    Private Sub mniThoat_Click(sender As Object, e As EventArgs) Handles mniThoat.Click
        Me.Close()
    End Sub
    'Sự kiện khi ấn mniKhachHang
    Private Sub mniKhachHang_Click(sender As Object, e As EventArgs) Handles mniKhachHang.Click
        frmKhachHang.ShowDialog()
    End Sub

    'Sự kiện khi ấn mniHoaDon
    Private Sub mniNhapDiem_Click(sender As Object, e As EventArgs) Handles mniHoaDon.Click
        frmHoaDon.ShowDialog()
    End Sub

    'Xử lý sự kiện ấn mniTTBQ
    Private Sub mniTTBQ_Click(sender As Object, e As EventArgs) Handles mniTTBQ.Click
        frmBanQuyen.ShowDialog()
    End Sub

    'Sự kiện khi ấn mni đăng xuất
    Private Sub mniDangXuat_Click(sender As Object, e As EventArgs) Handles mniDangXuat.Click
        frmDangNhap.txtDangNhap.Clear()
        frmDangNhap.txtMatKhau.Clear()
        frmDangNhap.Show()
        frmDangNhap.txtDangNhap.Focus()
        Me.Hide()
    End Sub

    'Xử lý sự kiện khi đóng form Chinh
    Private Sub frmChinh_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmDangNhap.Close()
    End Sub

    'Hiển thị form KhachHang khi click
    Private Sub PtbKhachHang_Click(sender As Object, e As EventArgs) Handles ptbKhachHang.Click
        frmKhachHang.ShowDialog()
    End Sub
    'Hiển thịn form HoaDon khi click
    Private Sub PtbHoaDon_Click(sender As Object, e As EventArgs) Handles ptbHoaDon.Click
        frmHoaDon.ShowDialog()
    End Sub
End Class