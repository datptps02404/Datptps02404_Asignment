Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmXemHoaDon
    'Khai báo biến, gán các giá trị
    Dim strKetNoi As String = "workstation id=datptps02404DB.mssql.somee.com;packet size=4096;user id=datptps02404_SQLLogin_1;pwd=ah1dm4bxyz;data source=datptps02404DB.mssql.somee.com;persist security info=False;initial catalog=datptps02404DB"
    Dim tbKhachHang As New DataTable

    'Sự kiện khi ấn nút Thoát ->  Đóng form, Clear tất cả textbox và đưa các textbox về trạng thái read only, vô hiệu hóa nút Lưu thay đổi
    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        txtMaNhanVien.Clear()
        dtp2.Value = Today()
        txtMaHoaDon.Clear()
        txtTongTien.Clear()
        txtMaKhachHang.Clear()

        txtMaHoaDon.ReadOnly = True
        txtMaKhachHang.ReadOnly = True
        dtp2.Enabled = False
        txtMaNhanVien.ReadOnly = True
        txtTongTien.ReadOnly = True

        btnLuuThayDoi.Enabled = False

        Me.Close()
    End Sub

    'Sự kiện khi Load form 
    Private Sub frmXem_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '-> Load các thông tin từ form Khach Hang qua các textbox
        Dim Index As Integer = frmHoaDon.DgvHoaDon.CurrentCell.RowIndex
        txtMaHoaDon.Text = frmHoaDon.DgvHoaDon.Item(0, Index).Value
        txtMaKhachHang.Text = frmHoaDon.DgvHoaDon.Item(1, Index).Value
        dtp2.Value = frmHoaDon.DgvHoaDon.Item(2, Index).Value
        txtTongTien.Text = frmHoaDon.DgvHoaDon.Item(3, Index).Value
        txtMaNhanVien.Text = frmHoaDon.DgvHoaDon.Item(4, Index).Value

    End Sub

    'Sự kiện khi ấn nút sửa -> Enable nút lưu thay đổi, cho phép sửa giá trị các textbox
    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        btnLuuThayDoi.Enabled = True
        txtMaKhachHang.ReadOnly = False
        dtp2.Enabled = True
        txtMaNhanVien.ReadOnly = False
        txtTongTien.ReadOnly = False

    End Sub

    'Sự kiện khi ấn nút lưu thay đổi -> Cập nhật các thông tin thay đổi lên server
    Private Sub btnLuuThayDoi_Click(sender As Object, e As EventArgs) Handles btnLuuThayDoi.Click

        Dim KetNoi As New SqlConnection(strKetNoi)
        KetNoi.Open()
        Dim strSuaKH As String = "UPDATE HoaDon SET MaKhachHang = N'" + txtMaKhachHang.Text + "',NgayLap = '" + String.Format("{0:MM/dd/yyyy}", dtp2.Value.Date) + "', MaNhanVien = '" + txtMaNhanVien.Text + "' WHERE MaHoaDon = '" + txtMaHoaDon.Text + "'"
        Dim Data As New SqlCommand(strSuaKH, KetNoi)
        Try
            Data.ExecuteNonQuery()
            KetNoi.Close()
        Catch ex As Exception
            MessageBox.Show("Xảy ra lỗi!")
        End Try
        MessageBox.Show("Cập nhật dữ liệu thành công!")
        frmHoaDon.DgvHoaDon.DataSource = Nothing
        'Load lại Datagribview ở form khach hang
        frmHoaDon.LoadHD()
        'Disable nút Lưu thay đổi
        btnLuuThayDoi.Enabled = False
        'Vô hiệu hóa các Textbox
        txtMaKhachHang.ReadOnly = True
        dtp2.Enabled = False
        txtMaNhanVien.ReadOnly = True
        txtTongTien.ReadOnly = True

    End Sub
End Class