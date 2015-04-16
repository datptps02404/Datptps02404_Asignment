<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThemKhachHang
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmThemKhachHang))
        Me.grbThongTin = New System.Windows.Forms.GroupBox()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.txtDienThoai = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtTenKhachHang = New System.Windows.Forms.TextBox()
        Me.txtMaKhachHang = New System.Windows.Forms.TextBox()
        Me.lblQueQuan = New System.Windows.Forms.Label()
        Me.lblGioiTinh = New System.Windows.Forms.Label()
        Me.lblNgaySinh = New System.Windows.Forms.Label()
        Me.lblTen = New System.Windows.Forms.Label()
        Me.lblMSSV = New System.Windows.Forms.Label()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.btnNhapLai = New System.Windows.Forms.Button()
        Me.grbThongTin.SuspendLayout
        Me.SuspendLayout
        '
        'grbThongTin
        '
        Me.grbThongTin.BackColor = System.Drawing.Color.LightGray
        Me.grbThongTin.Controls.Add(Me.txtDiaChi)
        Me.grbThongTin.Controls.Add(Me.txtDienThoai)
        Me.grbThongTin.Controls.Add(Me.txtEmail)
        Me.grbThongTin.Controls.Add(Me.txtTenKhachHang)
        Me.grbThongTin.Controls.Add(Me.txtMaKhachHang)
        Me.grbThongTin.Controls.Add(Me.lblQueQuan)
        Me.grbThongTin.Controls.Add(Me.lblGioiTinh)
        Me.grbThongTin.Controls.Add(Me.lblNgaySinh)
        Me.grbThongTin.Controls.Add(Me.lblTen)
        Me.grbThongTin.Controls.Add(Me.lblMSSV)
        Me.grbThongTin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163,Byte))
        Me.grbThongTin.ForeColor = System.Drawing.Color.SlateGray
        Me.grbThongTin.Location = New System.Drawing.Point(12, 12)
        Me.grbThongTin.Name = "grbThongTin"
        Me.grbThongTin.Size = New System.Drawing.Size(403, 246)
        Me.grbThongTin.TabIndex = 0
        Me.grbThongTin.TabStop = false
        Me.grbThongTin.Text = "Thông tin"
        '
        'txtDiaChi
        '
        Me.txtDiaChi.ForeColor = System.Drawing.Color.Black
        Me.txtDiaChi.Location = New System.Drawing.Point(118, 132)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(254, 22)
        Me.txtDiaChi.TabIndex = 8
        '
        'txtDienThoai
        '
        Me.txtDienThoai.ForeColor = System.Drawing.Color.Black
        Me.txtDienThoai.Location = New System.Drawing.Point(118, 168)
        Me.txtDienThoai.Multiline = true
        Me.txtDienThoai.Name = "txtDienThoai"
        Me.txtDienThoai.Size = New System.Drawing.Size(254, 66)
        Me.txtDienThoai.TabIndex = 9
        '
        'txtEmail
        '
        Me.txtEmail.ForeColor = System.Drawing.Color.Black
        Me.txtEmail.Location = New System.Drawing.Point(118, 96)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(254, 22)
        Me.txtEmail.TabIndex = 7
        '
        'txtTenKhachHang
        '
        Me.txtTenKhachHang.ForeColor = System.Drawing.Color.Black
        Me.txtTenKhachHang.Location = New System.Drawing.Point(118, 60)
        Me.txtTenKhachHang.Name = "txtTenKhachHang"
        Me.txtTenKhachHang.Size = New System.Drawing.Size(254, 22)
        Me.txtTenKhachHang.TabIndex = 6
        '
        'txtMaKhachHang
        '
        Me.txtMaKhachHang.ForeColor = System.Drawing.Color.Black
        Me.txtMaKhachHang.Location = New System.Drawing.Point(118, 24)
        Me.txtMaKhachHang.Name = "txtMaKhachHang"
        Me.txtMaKhachHang.Size = New System.Drawing.Size(254, 22)
        Me.txtMaKhachHang.TabIndex = 5
        '
        'lblQueQuan
        '
        Me.lblQueQuan.AutoSize = true
        Me.lblQueQuan.ForeColor = System.Drawing.Color.Black
        Me.lblQueQuan.Location = New System.Drawing.Point(6, 135)
        Me.lblQueQuan.Name = "lblQueQuan"
        Me.lblQueQuan.Size = New System.Drawing.Size(75, 16)
        Me.lblQueQuan.TabIndex = 4
        Me.lblQueQuan.Text = "Điện thoại*:"
        '
        'lblGioiTinh
        '
        Me.lblGioiTinh.AutoSize = true
        Me.lblGioiTinh.ForeColor = System.Drawing.Color.Black
        Me.lblGioiTinh.Location = New System.Drawing.Point(6, 171)
        Me.lblGioiTinh.Name = "lblGioiTinh"
        Me.lblGioiTinh.Size = New System.Drawing.Size(51, 16)
        Me.lblGioiTinh.TabIndex = 3
        Me.lblGioiTinh.Text = "Địa chỉ:"
        '
        'lblNgaySinh
        '
        Me.lblNgaySinh.AutoSize = true
        Me.lblNgaySinh.ForeColor = System.Drawing.Color.Black
        Me.lblNgaySinh.Location = New System.Drawing.Point(6, 99)
        Me.lblNgaySinh.Name = "lblNgaySinh"
        Me.lblNgaySinh.Size = New System.Drawing.Size(45, 16)
        Me.lblNgaySinh.TabIndex = 2
        Me.lblNgaySinh.Text = "Email:"
        '
        'lblTen
        '
        Me.lblTen.AutoSize = true
        Me.lblTen.ForeColor = System.Drawing.Color.Black
        Me.lblTen.Location = New System.Drawing.Point(6, 63)
        Me.lblTen.Name = "lblTen"
        Me.lblTen.Size = New System.Drawing.Size(112, 16)
        Me.lblTen.TabIndex = 1
        Me.lblTen.Text = "Tên khách hàng:*"
        '
        'lblMSSV
        '
        Me.lblMSSV.AutoSize = true
        Me.lblMSSV.ForeColor = System.Drawing.Color.Black
        Me.lblMSSV.Location = New System.Drawing.Point(6, 27)
        Me.lblMSSV.Name = "lblMSSV"
        Me.lblMSSV.Size = New System.Drawing.Size(110, 16)
        Me.lblMSSV.TabIndex = 0
        Me.lblMSSV.Text = "Mã khách hàng: *"
        '
        'btnThem
        '
        Me.btnThem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163,Byte))
        Me.btnThem.Location = New System.Drawing.Point(48, 285)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(80, 25)
        Me.btnThem.TabIndex = 10
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = true
        '
        'btnThoat
        '
        Me.btnThoat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163,Byte))
        Me.btnThoat.Location = New System.Drawing.Point(304, 285)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(80, 25)
        Me.btnThoat.TabIndex = 12
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = true
        '
        'btnNhapLai
        '
        Me.btnNhapLai.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163,Byte))
        Me.btnNhapLai.Location = New System.Drawing.Point(176, 285)
        Me.btnNhapLai.Name = "btnNhapLai"
        Me.btnNhapLai.Size = New System.Drawing.Size(80, 25)
        Me.btnNhapLai.TabIndex = 11
        Me.btnNhapLai.Text = "Nhập lại"
        Me.btnNhapLai.UseVisualStyleBackColor = true
        '
        'frmThemKhachHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = true
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(427, 335)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnNhapLai)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.grbThongTin)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "frmThemKhachHang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thêm khách hàng"
        Me.grbThongTin.ResumeLayout(false)
        Me.grbThongTin.PerformLayout
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents grbThongTin As System.Windows.Forms.GroupBox
    Friend WithEvents txtDienThoai As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtTenKhachHang As System.Windows.Forms.TextBox
    Friend WithEvents txtMaKhachHang As System.Windows.Forms.TextBox
    Friend WithEvents lblQueQuan As System.Windows.Forms.Label
    Friend WithEvents lblGioiTinh As System.Windows.Forms.Label
    Friend WithEvents lblNgaySinh As System.Windows.Forms.Label
    Friend WithEvents lblTen As System.Windows.Forms.Label
    Friend WithEvents lblMSSV As System.Windows.Forms.Label
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents btnThoat As System.Windows.Forms.Button
    Friend WithEvents txtDiaChi As System.Windows.Forms.TextBox
    Friend WithEvents btnNhapLai As System.Windows.Forms.Button
End Class
