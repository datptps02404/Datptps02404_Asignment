Imports System.Data.SqlClient
Public Class frmDangNhap
    'Sự kiện khi ấn nút đăng nhập
    Private Sub btnDangNhap_Click(sender As Object, e As EventArgs) Handles btnDangNhap.Click

        Dim chuoiKetNoi As String = "workstation id=datptps02404DB.mssql.somee.com;packet size=4096;user id=datptps02404_SQLLogin_1;pwd=ah1dm4bxyz;data source=datptps02404DB.mssql.somee.com;persist security info=False;initial catalog=datptps02404DB"

        Dim KetNoi As SqlConnection = New SqlConnection(chuoiKetNoi)
        Dim sqlAdapter As New SqlDataAdapter("select * from NhanVien where TenDangNhap='" & txtDangNhap.Text & "' and MatKhau='" & txtMatKhau.Text & "' ", KetNoi)
        Dim tb As New DataTable

        Try
            KetNoi.Open()
            sqlAdapter.Fill(tb)
            If tb.Rows.Count > 0 Then
                MessageBox.Show("Đăng nhập thành công!")
                frmChinh.Show()
                frmChinh.lblToolStrip.Text = "Welcome " + txtDangNhap.Text + "!"
                Me.Hide()
            Else
                'MessageBox.Show("Sai tài khoản hoặc mật khẩu!")
                lblLoiDangNhap.Visible = True
                lblLoiDangNhap.Text = "Sai tài khoản hoặc mật khẩu!"

            End If

        Catch ex As Exception
            MessageBox.Show("Sự cố mạng không thể kết nối đến Server! Vui lòng thử lại sau.")
        End Try

    End Sub
    'Sự kiện khi thay đổi nội dung các textbox
    Private Sub txtDangNhap_TextChanged(sender As Object, e As EventArgs) Handles txtDangNhap.TextChanged
        lblLoiDangNhap.Hide()
    End Sub

    Private Sub txtMatKhau_TextChanged(sender As Object, e As EventArgs) Handles txtMatKhau.TextChanged
        lblLoiDangNhap.Hide()
    End Sub
    'Sự kiện khi enter trong txtMatkhau

    Private Sub txtMatKhau_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMatKhau.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnDangNhap.PerformClick()
        End If
    End Sub
    'Sự kiện khi ấn thoát

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub


End Class