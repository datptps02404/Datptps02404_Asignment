<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThemHoaDon
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmThemHoaDon))
        Me.grbThongTin = New System.Windows.Forms.GroupBox()
        Me.txtTongTien = New System.Windows.Forms.TextBox()
        Me.txtMaNV = New System.Windows.Forms.TextBox()
        Me.txtMaKhachHang = New System.Windows.Forms.TextBox()
        Me.txtMaHoaDon = New System.Windows.Forms.TextBox()
        Me.lblTongTien = New System.Windows.Forms.Label()
        Me.lblGioiTinh = New System.Windows.Forms.Label()
        Me.lblNgayLap = New System.Windows.Forms.Label()
        Me.lblTen = New System.Windows.Forms.Label()
        Me.lblMaHoaDon = New System.Windows.Forms.Label()
        Me.ofdHinhSV = New System.Windows.Forms.OpenFileDialog()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.btnNhapLai = New System.Windows.Forms.Button()
        Me.dtp1 = New System.Windows.Forms.DateTimePicker()
        Me.grbThongTin.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbThongTin
        '
        Me.grbThongTin.BackColor = System.Drawing.Color.LightGray
        Me.grbThongTin.Controls.Add(Me.dtp1)
        Me.grbThongTin.Controls.Add(Me.txtTongTien)
        Me.grbThongTin.Controls.Add(Me.txtMaNV)
        Me.grbThongTin.Controls.Add(Me.txtMaKhachHang)
        Me.grbThongTin.Controls.Add(Me.txtMaHoaDon)
        Me.grbThongTin.Controls.Add(Me.lblTongTien)
        Me.grbThongTin.Controls.Add(Me.lblGioiTinh)
        Me.grbThongTin.Controls.Add(Me.lblNgayLap)
        Me.grbThongTin.Controls.Add(Me.lblTen)
        Me.grbThongTin.Controls.Add(Me.lblMaHoaDon)
        Me.grbThongTin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.grbThongTin.ForeColor = System.Drawing.Color.SlateGray
        Me.grbThongTin.Location = New System.Drawing.Point(12, 12)
        Me.grbThongTin.Name = "grbThongTin"
        Me.grbThongTin.Size = New System.Drawing.Size(403, 246)
        Me.grbThongTin.TabIndex = 0
        Me.grbThongTin.TabStop = False
        Me.grbThongTin.Text = "Thông tin"
        '
        'txtTongTien
        '
        Me.txtTongTien.ForeColor = System.Drawing.Color.Black
        Me.txtTongTien.Location = New System.Drawing.Point(118, 132)
        Me.txtTongTien.Name = "txtTongTien"
        Me.txtTongTien.Size = New System.Drawing.Size(254, 22)
        Me.txtTongTien.TabIndex = 8
        '
        'txtMaNV
        '
        Me.txtMaNV.ForeColor = System.Drawing.Color.Black
        Me.txtMaNV.Location = New System.Drawing.Point(118, 168)
        Me.txtMaNV.Name = "txtMaNV"
        Me.txtMaNV.Size = New System.Drawing.Size(254, 22)
        Me.txtMaNV.TabIndex = 9
        '
        'txtMaKhachHang
        '
        Me.txtMaKhachHang.ForeColor = System.Drawing.Color.Black
        Me.txtMaKhachHang.Location = New System.Drawing.Point(118, 60)
        Me.txtMaKhachHang.Name = "txtMaKhachHang"
        Me.txtMaKhachHang.Size = New System.Drawing.Size(254, 22)
        Me.txtMaKhachHang.TabIndex = 6
        '
        'txtMaHoaDon
        '
        Me.txtMaHoaDon.ForeColor = System.Drawing.Color.Black
        Me.txtMaHoaDon.Location = New System.Drawing.Point(118, 24)
        Me.txtMaHoaDon.Name = "txtMaHoaDon"
        Me.txtMaHoaDon.Size = New System.Drawing.Size(254, 22)
        Me.txtMaHoaDon.TabIndex = 5
        '
        'lblTongTien
        '
        Me.lblTongTien.AutoSize = True
        Me.lblTongTien.ForeColor = System.Drawing.Color.Black
        Me.lblTongTien.Location = New System.Drawing.Point(6, 135)
        Me.lblTongTien.Name = "lblTongTien"
        Me.lblTongTien.Size = New System.Drawing.Size(67, 16)
        Me.lblTongTien.TabIndex = 4
        Me.lblTongTien.Text = "Tổng tiền:"
        '
        'lblGioiTinh
        '
        Me.lblGioiTinh.AutoSize = True
        Me.lblGioiTinh.ForeColor = System.Drawing.Color.Black
        Me.lblGioiTinh.Location = New System.Drawing.Point(6, 171)
        Me.lblGioiTinh.Name = "lblGioiTinh"
        Me.lblGioiTinh.Size = New System.Drawing.Size(90, 16)
        Me.lblGioiTinh.TabIndex = 3
        Me.lblGioiTinh.Text = "Mã nhân viên:"
        '
        'lblNgayLap
        '
        Me.lblNgayLap.AutoSize = True
        Me.lblNgayLap.ForeColor = System.Drawing.Color.Black
        Me.lblNgayLap.Location = New System.Drawing.Point(6, 99)
        Me.lblNgayLap.Name = "lblNgayLap"
        Me.lblNgayLap.Size = New System.Drawing.Size(66, 16)
        Me.lblNgayLap.TabIndex = 2
        Me.lblNgayLap.Text = "Ngày lập:"
        '
        'lblTen
        '
        Me.lblTen.AutoSize = True
        Me.lblTen.ForeColor = System.Drawing.Color.Black
        Me.lblTen.Location = New System.Drawing.Point(6, 63)
        Me.lblTen.Name = "lblTen"
        Me.lblTen.Size = New System.Drawing.Size(107, 16)
        Me.lblTen.TabIndex = 1
        Me.lblTen.Text = "Mã khách hàng:*"
        '
        'lblMaHoaDon
        '
        Me.lblMaHoaDon.AutoSize = True
        Me.lblMaHoaDon.ForeColor = System.Drawing.Color.Black
        Me.lblMaHoaDon.Location = New System.Drawing.Point(6, 27)
        Me.lblMaHoaDon.Name = "lblMaHoaDon"
        Me.lblMaHoaDon.Size = New System.Drawing.Size(90, 16)
        Me.lblMaHoaDon.TabIndex = 0
        Me.lblMaHoaDon.Text = "Mã hóa đơn: *"
        '
        'ofdHinhSV
        '
        Me.ofdHinhSV.FileName = ".png"
        '
        'btnThem
        '
        Me.btnThem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnThem.Location = New System.Drawing.Point(48, 285)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(80, 25)
        Me.btnThem.TabIndex = 10
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnThoat
        '
        Me.btnThoat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnThoat.Location = New System.Drawing.Point(304, 285)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(80, 25)
        Me.btnThoat.TabIndex = 12
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'btnNhapLai
        '
        Me.btnNhapLai.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnNhapLai.Location = New System.Drawing.Point(176, 285)
        Me.btnNhapLai.Name = "btnNhapLai"
        Me.btnNhapLai.Size = New System.Drawing.Size(80, 25)
        Me.btnNhapLai.TabIndex = 11
        Me.btnNhapLai.Text = "Nhập lại"
        Me.btnNhapLai.UseVisualStyleBackColor = True
        '
        'dtp1
        '
        Me.dtp1.Location = New System.Drawing.Point(118, 94)
        Me.dtp1.Name = "dtp1"
        Me.dtp1.Size = New System.Drawing.Size(254, 22)
        Me.dtp1.TabIndex = 7
        '
        'frmThemHoaDon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(427, 335)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnNhapLai)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.grbThongTin)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmThemHoaDon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thêm hóa đơn"
        Me.grbThongTin.ResumeLayout(false)
        Me.grbThongTin.PerformLayout
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents grbThongTin As System.Windows.Forms.GroupBox
    Friend WithEvents txtMaNV As System.Windows.Forms.TextBox
    Friend WithEvents txtMaKhachHang As System.Windows.Forms.TextBox
    Friend WithEvents txtMaHoaDon As System.Windows.Forms.TextBox
    Friend WithEvents lblTongTien As System.Windows.Forms.Label
    Friend WithEvents lblGioiTinh As System.Windows.Forms.Label
    Friend WithEvents lblNgayLap As System.Windows.Forms.Label
    Friend WithEvents lblTen As System.Windows.Forms.Label
    Friend WithEvents lblMaHoaDon As System.Windows.Forms.Label
    Friend WithEvents ofdHinhSV As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents btnThoat As System.Windows.Forms.Button
    Friend WithEvents txtTongTien As System.Windows.Forms.TextBox
    Friend WithEvents btnNhapLai As System.Windows.Forms.Button
    Friend WithEvents dtp1 As System.Windows.Forms.DateTimePicker
End Class
