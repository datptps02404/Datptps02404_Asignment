<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKhachHang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKhachHang))
        Me.DgvKhachHang = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnNhapLai = New System.Windows.Forms.Button()
        Me.btnLocDuLieu = New System.Windows.Forms.Button()
        Me.txtTen = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtDienThoai = New System.Windows.Forms.TextBox()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.txtMa = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTimKiem = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnThem = New System.Windows.Forms.ToolStripButton()
        Me.btnXem = New System.Windows.Forms.ToolStripButton()
        Me.btnXoa = New System.Windows.Forms.ToolStripButton()
        Me.btnThoat = New System.Windows.Forms.ToolStripButton()
        CType(Me.DgvKhachHang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DgvKhachHang
        '
        Me.DgvKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvKhachHang.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvKhachHang.Location = New System.Drawing.Point(12, 41)
        Me.DgvKhachHang.Name = "DgvKhachHang"
        Me.DgvKhachHang.Size = New System.Drawing.Size(592, 376)
        Me.DgvKhachHang.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btnRefresh)
        Me.Panel1.Controls.Add(Me.btnNhapLai)
        Me.Panel1.Controls.Add(Me.btnLocDuLieu)
        Me.Panel1.Controls.Add(Me.txtTen)
        Me.Panel1.Controls.Add(Me.txtEmail)
        Me.Panel1.Controls.Add(Me.txtDienThoai)
        Me.Panel1.Controls.Add(Me.txtDiaChi)
        Me.Panel1.Controls.Add(Me.txtMa)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblTimKiem)
        Me.Panel1.Location = New System.Drawing.Point(620, 41)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(264, 376)
        Me.Panel1.TabIndex = 1
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(7, 202)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 13
        Me.btnRefresh.Text = "Tẩy bộ lọc"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnNhapLai
        '
        Me.btnNhapLai.Location = New System.Drawing.Point(94, 202)
        Me.btnNhapLai.Name = "btnNhapLai"
        Me.btnNhapLai.Size = New System.Drawing.Size(75, 23)
        Me.btnNhapLai.TabIndex = 12
        Me.btnNhapLai.Text = "Nhập lại"
        Me.btnNhapLai.UseVisualStyleBackColor = True
        '
        'btnLocDuLieu
        '
        Me.btnLocDuLieu.Location = New System.Drawing.Point(180, 202)
        Me.btnLocDuLieu.Name = "btnLocDuLieu"
        Me.btnLocDuLieu.Size = New System.Drawing.Size(75, 23)
        Me.btnLocDuLieu.TabIndex = 11
        Me.btnLocDuLieu.Text = "Lọc dữ liệu"
        Me.btnLocDuLieu.UseVisualStyleBackColor = True
        '
        'txtTen
        '
        Me.txtTen.Location = New System.Drawing.Point(71, 60)
        Me.txtTen.Name = "txtTen"
        Me.txtTen.Size = New System.Drawing.Size(184, 20)
        Me.txtTen.TabIndex = 10
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(71, 91)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(184, 20)
        Me.txtEmail.TabIndex = 9
        '
        'txtDienThoai
        '
        Me.txtDienThoai.Location = New System.Drawing.Point(71, 123)
        Me.txtDienThoai.Name = "txtDienThoai"
        Me.txtDienThoai.Size = New System.Drawing.Size(184, 20)
        Me.txtDienThoai.TabIndex = 8
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Location = New System.Drawing.Point(71, 153)
        Me.txtDiaChi.Multiline = True
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(184, 43)
        Me.txtDiaChi.TabIndex = 7
        '
        'txtMa
        '
        Me.txtMa.Location = New System.Drawing.Point(71, 29)
        Me.txtMa.Name = "txtMa"
        Me.txtMa.Size = New System.Drawing.Size(184, 20)
        Me.txtMa.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 15)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Tên:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Email:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Địa chỉ:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Điện thoại:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Mã số:"
        '
        'lblTimKiem
        '
        Me.lblTimKiem.AutoSize = True
        Me.lblTimKiem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimKiem.ForeColor = System.Drawing.Color.Gray
        Me.lblTimKiem.Location = New System.Drawing.Point(3, 0)
        Me.lblTimKiem.Name = "lblTimKiem"
        Me.lblTimKiem.Size = New System.Drawing.Size(133, 16)
        Me.lblTimKiem.TabIndex = 0
        Me.lblTimKiem.Text = "Thông tin tìm kiếm"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnThem, Me.btnXem, Me.btnXoa, Me.btnThoat})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(896, 38)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnThem
        '
        Me.btnThem.Image = Global.Datptps02404_Asignment.My.Resources.Resources.add_1_icon
        Me.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnThem.Margin = New System.Windows.Forms.Padding(12, 1, 0, 2)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Padding = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.btnThem.Size = New System.Drawing.Size(92, 35)
        Me.btnThem.Text = "Thêm mới"
        Me.btnThem.ToolTipText = "Thêm mới"
        '
        'btnXem
        '
        Me.btnXem.Image = Global.Datptps02404_Asignment.My.Resources.Resources.Edit
        Me.btnXem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnXem.Name = "btnXem"
        Me.btnXem.Padding = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.btnXem.Size = New System.Drawing.Size(85, 35)
        Me.btnXem.Text = "Xem/Sửa"
        '
        'btnXoa
        '
        Me.btnXoa.Image = Global.Datptps02404_Asignment.My.Resources.Resources.Delete
        Me.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Padding = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.btnXoa.Size = New System.Drawing.Size(57, 35)
        Me.btnXoa.Text = "Xóa"
        '
        'btnThoat
        '
        Me.btnThoat.Image = Global.Datptps02404_Asignment.My.Resources.Resources._Exit
        Me.btnThoat.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Padding = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.btnThoat.Size = New System.Drawing.Size(68, 35)
        Me.btnThoat.Text = "Thoát"
        '
        'frmKhachHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(896, 426)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DgvKhachHang)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmKhachHang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Khách hàng"
        CType(Me.DgvKhachHang,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        Me.ToolStrip1.ResumeLayout(false)
        Me.ToolStrip1.PerformLayout
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents DgvKhachHang As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnXem As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnThem As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnXoa As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnThoat As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblTimKiem As System.Windows.Forms.Label
    Friend WithEvents btnLocDuLieu As System.Windows.Forms.Button
    Friend WithEvents txtTen As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtDienThoai As System.Windows.Forms.TextBox
    Friend WithEvents txtDiaChi As System.Windows.Forms.TextBox
    Friend WithEvents txtMa As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnNhapLai As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
End Class
