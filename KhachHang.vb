Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmKhachHang

    'Khai báo Datatable và tạo thủ tục kết nối Database
    Dim tbKhachHang As New DataTable
    Dim strKetNoi As String = "workstation id=datptps02404DB.mssql.somee.com;packet size=4096;user id=datptps02404_SQLLogin_1;pwd=ah1dm4bxyz;data source=datptps02404DB.mssql.somee.com;persist security info=False;initial catalog=datptps02404DB"

    'Thủ tục Load danh sách khách hàng lên DataGribView
    Public Sub LoadKH()
        tbKhachHang.Clear()
        Dim KetNoi As New SqlConnection(strKetNoi)
        Dim sqlAdapter As New SqlDataAdapter("SELECT MaKhachHang AS 'Mã KH', TenKhachHang AS 'Tên KH', Email, DienThoai AS 'Điện Thoại', DiaChi AS 'Địa chỉ' From KhachHang", KetNoi)
        Try
            sqlAdapter.Fill(tbKhachHang)
        Catch ex As Exception

        End Try
        DgvKhachHang.DataSource = tbKhachHang
        KetNoi.Close()
    End Sub


    'Xử lý sự kiện khi form KhachHang được Load
    Private Sub frmKhachHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.LoadKH()
    End Sub

    'Xử lý sự kiện khi click nút Xóa
    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim KetNoi As New SqlConnection(strKetNoi)
        KetNoi.Open()

        'Query xóa khách hàng
        Dim strXoaKH As String = "DELETE FROM KhachHang WHERE MaKhachHang = @MaKhachHang"

        'Query xóa các hóa đơn tương ứng với khách hàng bị xóa để bảo toàn cấu trúc dữ liệu
        Dim strXoaHD As String = "DELETE FROM HoaDon WHERE MaKhachHang = @MaKhachHang"

        Dim DataHD As New SqlCommand(strXoaHD, KetNoi)
        Dim DataKH As New SqlCommand(strXoaKH, KetNoi)
        Try
            If MessageBox.Show("Các hóa đơn tương ứng với khách hàng cũng sẽ bị xóa, bạn có chắc chắn muốn thực hiện thao tác này?", _
                           "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                DataHD.Parameters.AddWithValue("@MaKhachHang", DgvKhachHang.Item(0, DgvKhachHang.CurrentCell.RowIndex).Value)
                DataKH.Parameters.AddWithValue("@MaKhachHang", DgvKhachHang.Item(0, DgvKhachHang.CurrentCell.RowIndex).Value)
                DataHD.ExecuteNonQuery()
                DataKH.ExecuteNonQuery()
                KetNoi.Close()
                MessageBox.Show("Xóa dữ liệu thành công!")
            End If
        Catch ex As Exception
            MessageBox.Show("Xóa dữ liệu không thành công!")
        End Try

        'Load lại dữ liệu lên Dgv
        DgvKhachHang.DataSource = Nothing
        Me.LoadKH()
    End Sub

    Private Sub btnNhapLai_Click(sender As Object, e As EventArgs) Handles btnNhapLai.Click
        txtDienThoai.Clear()
        txtDiaChi.Clear()
        txtEmail.Clear()
        txtMa.Clear()
        txtTen.Clear()
    End Sub

    'Xử lý sự kiện khi click nút Lọc dữ liệu
    Private Sub btnLocDuLieu_Click(sender As Object, e As EventArgs) Handles btnLocDuLieu.Click

        'Tẩy Dgv
        DgvKhachHang.DataSource = Nothing

        'Gán giá trị khi Textbox để trống
        If txtMa.Text = "" Then
            txtMa.Text = "%"

        End If
        If txtTen.Text = "" Then
            txtTen.Text = "%"

        End If
        If txtEmail.Text = "" Then
            txtEmail.Text = "%"

        End If
        If txtDienThoai.Text = "" Then
            txtDienThoai.Text = "%"

        End If
        If txtDiaChi.Text = "" Then
            txtDiaChi.Text = "%"

        End If

        'Kết nối và chạy query lọc dữ liệu theo điều kiện
        Dim KetNoi As New SqlConnection(strKetNoi)
        KetNoi.Open()
        Dim SqlAdapterTimKiem As New SqlDataAdapter("SELECT MaKhachHang AS 'Mã KH', TenKhachHang AS 'Tên KH', Email, DienThoai AS 'Điện Thoại', DiaChi AS 'Địa chỉ' From KhachHang WHERE MaKhachHang Like N'" + txtMa.Text + "' AND TenKhachHang LIKE N'" + txtTen.Text + "' AND Email LIKE '" + txtEmail.Text + "' AND DiaChi LIKE N'" + txtDiaChi.Text + "' AND DienThoai LIKE '" + txtDienThoai.Text + "'", KetNoi)
        Dim tbTimKiem As New DataTable
        Try

            SqlAdapterTimKiem.Fill(tbTimKiem)


        Catch ex As Exception
            MessageBox.Show("Đã xảy ra lỗi, vui lòng thử lại!")
        End Try

        'Clear các textbox không nhập dữ liệu tìm kiếm
        If txtMa.Text = "%" Then
            txtMa.Clear()

        End If
        If txtTen.Text = "%" Then
            txtTen.Clear()

        End If
        If txtEmail.Text = "%" Then
            txtEmail.Clear()

        End If
        If txtDienThoai.Text = "%" Then
            txtDienThoai.Clear()

        End If
        If txtDiaChi.Text = "%" Then
            txtDiaChi.Clear()
        End If
        DgvKhachHang.DataSource = tbTimKiem
        KetNoi.Close()
    End Sub

    'Xử lý sự kiện khi click nút thêm
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        frmThemKhachHang.ShowDialog()
    End Sub


    'Xử lý sự kiện khi click nút Tẩy bộ lọc
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Me.LoadKH()
    End Sub

    'Xử lý sự kiện khi click nút Xem/Sửa
    Private Sub btnXem_Click(sender As Object, e As EventArgs) Handles btnXem.Click
        frmXem.ShowDialog()
    End Sub

    'Xử lý sự kiện khi thoát form
    Private Sub frmKhachHang_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        'Clear tất cả textbox tìm kiếm
        Me.Close()
        txtDienThoai.Clear()
        txtDiaChi.Clear()
        txtEmail.Clear()
        txtMa.Clear()
        txtTen.Clear()
    End Sub
End Class