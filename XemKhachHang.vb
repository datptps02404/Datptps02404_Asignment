Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmXem
    'Khai báo biến, gán các giá trị
    Dim strKetNoi As String = "workstation id=datptps02404DB.mssql.somee.com;packet size=4096;user id=datptps02404_SQLLogin_1;pwd=ah1dm4bxyz;data source=datptps02404DB.mssql.somee.com;persist security info=False;initial catalog=datptps02404DB"
    Dim tbKhachHang As New DataTable

    'Sự kiện khi ấn nút Thoát ->  Đóng form, Clear tất cả textbox và đưa các textbox về trạng thái read only, vô hiệu hóa nút Lưu thay đổi
    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        txtDiaChi.Clear()
        txtEmail.Clear()
        txtMa.Clear()
        txtSdt.Clear()
        txtTen.Clear()

        txtMa.ReadOnly = True
        txtTen.ReadOnly = True
        txtEmail.ReadOnly = True
        txtDiaChi.ReadOnly = True
        txtSdt.ReadOnly = True

        btnLuuThayDoi.Enabled = False

        Me.Close()
    End Sub

    'Sự kiện khi Load form 
    Private Sub frmXem_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '-> Load các thông tin từ form Khach Hang qua các textbox
        Dim Index As Integer = frmKhachHang.DgvKhachHang.CurrentCell.RowIndex
        txtMa.Text = frmKhachHang.DgvKhachHang.Item(0, Index).Value
        txtTen.Text = frmKhachHang.DgvKhachHang.Item(1, Index).Value
        txtEmail.Text = frmKhachHang.DgvKhachHang.Item(2, Index).Value
        txtDiaChi.Text = frmKhachHang.DgvKhachHang.Item(3, Index).Value
        txtSdt.Text = frmKhachHang.DgvKhachHang.Item(4, Index).Value

        'Load các hóa đơn tương ứng với khách hàng lên datagribview
        Dim tbLichSu As New DataTable
        Dim KetNoi As New SqlConnection(strKetNoi)
        Dim strLichSu As New SqlDataAdapter("SELECT MaHoaDon AS 'Mã hóa đơn',MaKhachHang As 'Mã khách hàng',Convert(Varchar(10),NgayLap,3) AS 'Ngày lập', PARSENAME(CONVERT(Varchar,Convert(money,TongTienHoaDon),1),2 )+' '+'VNĐ' AS 'Tổng tiền',MaNhanVien AS 'Mã NV' From HoaDon WHERE MaKhachHang = '" + txtMa.Text + "'", KetNoi)
        Try
            KetNoi.Open()
            strLichSu.Fill(tbLichSu)
        Catch ex As Exception

        End Try
        dgvLichSu.DataSource = tbLichSu
        KetNoi.Close()
    End Sub

    'Sự kiện khi ấn nút sửa -> Enable nút lưu thay đổi, cho phép sửa giá trị các textbox
    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        btnLuuThayDoi.Enabled = True
        txtTen.ReadOnly = False
        txtEmail.ReadOnly = False
        txtDiaChi.ReadOnly = False
        txtSdt.ReadOnly = False
    End Sub

    'Sự kiện khi ấn nút lưu thay đổi -> Cập nhật các thông tin thay đổi lên server
    Private Sub btnLuuThayDoi_Click(sender As Object, e As EventArgs) Handles btnLuuThayDoi.Click

        Dim KetNoi As New SqlConnection(strKetNoi)
        KetNoi.Open()
        Dim strSuaKH As String = "UPDATE KhachHang SET TenKhachHang = N'" + txtTen.Text + "', Email = @Email, DiaChi = N'" + txtDiaChi.Text + "', DienThoai = @DienThoai WHERE MaKhachHang = @MaKhachHang"
        Dim Data As New SqlCommand(strSuaKH, KetNoi)
        Try
            Data.Parameters.AddWithValue("@MaKhachHang", txtMa.Text)
            Data.Parameters.AddWithValue("@Email", txtEmail.Text)
            Data.Parameters.AddWithValue("@DienThoai", txtSdt.Text)
            Data.ExecuteNonQuery()
            KetNoi.Close()
        Catch ex As Exception
            MessageBox.Show("Xảy ra lỗi!")
        End Try
        MessageBox.Show("Cập nhật dữ liệu thành công!")
        frmKhachHang.DgvKhachHang.DataSource = Nothing
        'Load lại Datagribview ở form khach hang
        frmKhachHang.LoadKH()
        'Disable nút Lưu thay đổi
        btnLuuThayDoi.Enabled = False
        'Vô hiệu hóa các Textbox
        txtTen.ReadOnly = True
        txtEmail.ReadOnly = True
        txtDiaChi.ReadOnly = True
        txtSdt.ReadOnly = True

    End Sub
End Class