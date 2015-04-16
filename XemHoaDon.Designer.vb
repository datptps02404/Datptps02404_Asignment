<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmXemHoaDon
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmXemHoaDon))
        Me.txtMaHoaDon = New System.Windows.Forms.TextBox()
        Me.txtMaKhachHang = New System.Windows.Forms.TextBox()
        Me.txtTongTien = New System.Windows.Forms.TextBox()
        Me.txtMaNhanVien = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnLuuThayDoi = New System.Windows.Forms.Button()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.dtp2 = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'txtMaHoaDon
        '
        Me.txtMaHoaDon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaHoaDon.Location = New System.Drawing.Point(131, 11)
        Me.txtMaHoaDon.Name = "txtMaHoaDon"
        Me.txtMaHoaDon.ReadOnly = True
        Me.txtMaHoaDon.Size = New System.Drawing.Size(230, 21)
        Me.txtMaHoaDon.TabIndex = 0
        '
        'txtMaKhachHang
        '
        Me.txtMaKhachHang.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaKhachHang.Location = New System.Drawing.Point(131, 49)
        Me.txtMaKhachHang.Name = "txtMaKhachHang"
        Me.txtMaKhachHang.ReadOnly = True
        Me.txtMaKhachHang.Size = New System.Drawing.Size(230, 21)
        Me.txtMaKhachHang.TabIndex = 1
        '
        'txtTongTien
        '
        Me.txtTongTien.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTongTien.Location = New System.Drawing.Point(131, 125)
        Me.txtTongTien.Name = "txtTongTien"
        Me.txtTongTien.ReadOnly = True
        Me.txtTongTien.Size = New System.Drawing.Size(230, 21)
        Me.txtTongTien.TabIndex = 3
        '
        'txtMaNhanVien
        '
        Me.txtMaNhanVien.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaNhanVien.Location = New System.Drawing.Point(131, 163)
        Me.txtMaNhanVien.Multiline = True
        Me.txtMaNhanVien.Name = "txtMaNhanVien"
        Me.txtMaNhanVien.ReadOnly = True
        Me.txtMaNhanVien.Size = New System.Drawing.Size(230, 18)
        Me.txtMaNhanVien.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 15)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Mã hóa đơn:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Mã khách hàng:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Ngày lập:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 15)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Tổng tiền:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 166)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 15)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Mã nhân viên:"
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(43, 210)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(75, 23)
        Me.btnSua.TabIndex = 11
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnLuuThayDoi
        '
        Me.btnLuuThayDoi.Enabled = False
        Me.btnLuuThayDoi.Location = New System.Drawing.Point(150, 210)
        Me.btnLuuThayDoi.Name = "btnLuuThayDoi"
        Me.btnLuuThayDoi.Size = New System.Drawing.Size(75, 23)
        Me.btnLuuThayDoi.TabIndex = 12
        Me.btnLuuThayDoi.Text = "Lưu thay đổi"
        Me.btnLuuThayDoi.UseVisualStyleBackColor = True
        '
        'btnThoat
        '
        Me.btnThoat.Location = New System.Drawing.Point(258, 210)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(75, 23)
        Me.btnThoat.TabIndex = 13
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'dtp2
        '
        Me.dtp2.Enabled = False
        Me.dtp2.Location = New System.Drawing.Point(133, 86)
        Me.dtp2.Name = "dtp2"
        Me.dtp2.Size = New System.Drawing.Size(228, 20)
        Me.dtp2.TabIndex = 14
        '
        'frmXemHoaDon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(379, 251)
        Me.Controls.Add(Me.dtp2)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnLuuThayDoi)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMaNhanVien)
        Me.Controls.Add(Me.txtTongTien)
        Me.Controls.Add(Me.txtMaKhachHang)
        Me.Controls.Add(Me.txtMaHoaDon)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmXemHoaDon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Xem"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMaHoaDon As System.Windows.Forms.TextBox
    Friend WithEvents txtMaKhachHang As System.Windows.Forms.TextBox
    Friend WithEvents txtTongTien As System.Windows.Forms.TextBox
    Friend WithEvents txtMaNhanVien As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnSua As System.Windows.Forms.Button
    Friend WithEvents btnLuuThayDoi As System.Windows.Forms.Button
    Friend WithEvents btnThoat As System.Windows.Forms.Button
    Friend WithEvents dtp2 As System.Windows.Forms.DateTimePicker
End Class
