Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmHoaDon

    'Khai báo Datatable và tạo thủ tục kết nối Database
    Dim tbHoaDon As New DataTable
    Dim strKetNoi As String = "workstation id=datptps02404DB.mssql.somee.com;packet size=4096;user id=datptps02404_SQLLogin_1;pwd=ah1dm4bxyz;data source=datptps02404DB.mssql.somee.com;persist security info=False;initial catalog=datptps02404DB"

    'Thủ tục Load danh sách hóa đơn lên DataGribView
    Public Sub LoadHD()
        tbHoaDon.Clear()
        Dim KetNoi As New SqlConnection(strKetNoi)
        Dim sqlAdapter As New SqlDataAdapter("Select MaHoaDon AS 'Mã hóa đơn',MaKhachHang As 'Mã khách hàng',Convert(Varchar(10),NgayLap,3) AS 'Ngày lập', PARSENAME(CONVERT(Varchar,Convert(money,TongTienHoaDon),1),2 )+' '+'VNĐ' AS 'Tổng tiền',MaNhanVien AS 'Mã NV' From HoaDon", KetNoi)
        Try
            sqlAdapter.Fill(tbHoaDon)
        Catch ex As Exception

        End Try
        DgvHoaDon.DataSource = tbHoaDon
        KetNoi.Close()
    End Sub


    'Xử lý sự kiện khi form KhachHang được Load
    Private Sub frmHoaDon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.LoadHD()
    End Sub

    'Xử lý sự kiện khi click nút Xóa
    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim KetNoi As New SqlConnection(strKetNoi)
        KetNoi.Open()


        'Query xóa hóa đơn
        Dim strXoaHD As String = "DELETE FROM HoaDon WHERE MaHoaDon = @MaHoaDon"

        Dim DataHD As New SqlCommand(strXoaHD, KetNoi)
        Try
            If MessageBox.Show("Bạn chắc chắn muốn xóa hóa đơn này?", _
                           "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                DataHD.Parameters.AddWithValue("@MaHoaDon", DgvHoaDon.Item(0, DgvHoaDon.CurrentCell.RowIndex).Value)
                DataHD.ExecuteNonQuery()
                KetNoi.Close()
                MessageBox.Show("Xóa dữ liệu thành công!")
            End If
        Catch ex As Exception
            MessageBox.Show("Xóa dữ liệu không thành công!")
        End Try

        'Load lại dữ liệu lên Dgv
        DgvHoaDon.DataSource = Nothing
        Me.LoadHD()
    End Sub

    Private Sub btnNhapLai_Click(sender As Object, e As EventArgs) Handles btnNhapLai.Click
        txtTongTien.Clear()
        txtMaNV.Clear()
        txtNgayLap.Clear()
        txtMaHD.Clear()
        txtMaKH.Clear()
    End Sub

    'Xử lý sự kiện khi click nút Lọc dữ liệu
    Private Sub btnLocDuLieu_Click(sender As Object, e As EventArgs) Handles btnLocDuLieu.Click

        'Tẩy Dgv
        DgvHoaDon.DataSource = Nothing

        'Gán giá trị khi Textbox để trống
        If txtMaHD.Text = "" Then
            txtMaHD.Text = "%"

        End If
        If txtMaKH.Text = "" Then
            txtMaKH.Text = "%"

        End If
        If txtNgayLap.Text = "" Then
            txtNgayLap.Text = "%"

        End If
        If txtTongTien.Text = "" Then
            txtTongTien.Text = "%"

        End If
        If txtMaNV.Text = "" Then
            txtMaNV.Text = "%"

        End If

        'Kết nối và chạy query lọc dữ liệu theo điều kiện
        Dim KetNoi As New SqlConnection(strKetNoi)
        KetNoi.Open()
        Dim SqlAdapterTimKiem As New SqlDataAdapter("SELECT MaHoaDon AS 'Mã hóa đơn',MaKhachHang As 'Mã khách hàng',Convert(Varchar(10),NgayLap,3) AS 'Ngày lập', PARSENAME(CONVERT(Varchar,Convert(money,TongTienHoaDon),1),2 )+' '+'VNĐ' AS 'Tổng tiền',MaNhanVien AS 'Mã NV' From HoaDon WHERE MaHoaDon Like N'" + txtMaHD.Text + "' AND MaKhachHang LIKE N'" + txtMaKH.Text + "' AND MaNhanVien LIKE '" + txtMaNV.Text + "'", KetNoi)
        Dim tbTimKiem As New DataTable
        Try

            SqlAdapterTimKiem.Fill(tbTimKiem)


        Catch ex As Exception
            MessageBox.Show("Đã xảy ra lỗi, vui lòng thử lại!")
        End Try

        'Clear các textbox không nhập dữ liệu tìm kiếm
        If txtMaHD.Text = "%" Then
            txtMaHD.Clear()

        End If
        If txtMaKH.Text = "%" Then
            txtMaKH.Clear()

        End If
        If txtNgayLap.Text = "%" Then
            txtNgayLap.Clear()

        End If
        If txtTongTien.Text = "%" Then
            txtTongTien.Clear()

        End If
        If txtMaNV.Text = "%" Then
            txtMaNV.Clear()
        End If
        DgvHoaDon.DataSource = tbTimKiem
        KetNoi.Close()
    End Sub

    'Xử lý sự kiện khi click nút thêm
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        frmThemHoaDon.ShowDialog()
    End Sub

    'Xử lý sự kiện khi click nút Thoát
    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
        txtTongTien.Clear()
        txtMaNV.Clear()
        txtNgayLap.Clear()
        txtMaHD.Clear()
        txtMaKH.Clear()

    End Sub

    'Xử lý sự kiện khi click nút Tẩy bộ lọc
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Me.LoadHD()
    End Sub

    'Xử lý sự kiện khi click nút Xem/Sửa
    Private Sub btnXem_Click(sender As Object, e As EventArgs) Handles btnXem.Click
        frmXemHoaDon.ShowDialog()
    End Sub
End Class