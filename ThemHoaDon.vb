Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmThemHoaDon

    'Khai báo biến với chuỗi kết nối tới CSDL
    Dim tbHoaDon As New DataTable
    Dim strKetNoi As String = "workstation id=datptps02404DB.mssql.somee.com;packet size=4096;user id=datptps02404_SQLLogin_1;pwd=ah1dm4bxyz;data source=datptps02404DB.mssql.somee.com;persist security info=False;initial catalog=datptps02404DB"

    'Xử lý sự kiện nút thoát -> Đóng form và clear tất cả textbox
    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        txtTongTien.Clear()
        txtMaNV.Clear()
        dtp1.Value = Today()
        txtMaKhachHang.Clear()
        txtMaHoaDon.Clear()
        Me.Close()
    End Sub

    'Xử lý sự kiện click btn Thêm
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim KetNoi As New SqlConnection(strKetNoi)
        KetNoi.Open()
        Dim strThem As String = "INSERT INTO HOADON VALUES(N'" + txtMaHoaDon.Text + "',N'" + txtMaKhachHang.Text + "','" + String.Format("{0:MM/dd/yyyy}", dtp1.Value.Date) + "','" + txtTongTien.Text + "',N'" + txtMaNV.Text + "')"
        Dim Data As New SqlCommand(strThem, KetNoi)
        Try
            Data.ExecuteNonQuery()

            KetNoi.Close()
        Catch ex As Exception
            MessageBox.Show("Thêm dữ liệu không thành công!")

        End Try
        MessageBox.Show("Thêm dữ liệu thành công!")
        frmHoaDon.DgvHoaDon.DataSource = Nothing
        frmHoaDon.LoadHD()
    End Sub

    'Sự kiện nút Nhập lại -> Clear toàn bộ các textbox
    Private Sub btnNhapLai_Click(sender As Object, e As EventArgs) Handles btnNhapLai.Click
        txtTongTien.Clear()
        txtMaNV.Clear()
        dtp1.Value = Today()
        txtMaKhachHang.Clear()
        txtMaHoaDon.Clear()
    End Sub

    'Sự kiện khi đóng form -> Clear toàn bộ các textbox
    Private Sub frmThemKhachHang_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        txtTongTien.Clear()
        txtMaNV.Clear()
        dtp1.Value = Today()
        txtMaKhachHang.Clear()
        txtMaHoaDon.Clear()
    End Sub
End Class