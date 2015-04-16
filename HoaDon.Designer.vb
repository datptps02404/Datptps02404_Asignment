<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHoaDon
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHoaDon))
        Me.DgvHoaDon = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtNgayLap = New System.Windows.Forms.TextBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnNhapLai = New System.Windows.Forms.Button()
        Me.btnLocDuLieu = New System.Windows.Forms.Button()
        Me.txtMaKH = New System.Windows.Forms.TextBox()
        Me.txtTongTien = New System.Windows.Forms.TextBox()
        Me.txtMaNV = New System.Windows.Forms.TextBox()
        Me.txtMaHD = New System.Windows.Forms.TextBox()
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
        CType(Me.DgvHoaDon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DgvHoaDon
        '
        Me.DgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvHoaDon.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvHoaDon.Location = New System.Drawing.Point(12, 41)
        Me.DgvHoaDon.Name = "DgvHoaDon"
        Me.DgvHoaDon.Size = New System.Drawing.Size(592, 376)
        Me.DgvHoaDon.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.txtNgayLap)
        Me.Panel1.Controls.Add(Me.btnRefresh)
        Me.Panel1.Controls.Add(Me.btnNhapLai)
        Me.Panel1.Controls.Add(Me.btnLocDuLieu)
        Me.Panel1.Controls.Add(Me.txtMaKH)
        Me.Panel1.Controls.Add(Me.txtTongTien)
        Me.Panel1.Controls.Add(Me.txtMaNV)
        Me.Panel1.Controls.Add(Me.txtMaHD)
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
        'txtNgayLap
        '
        Me.txtNgayLap.Enabled = False
        Me.txtNgayLap.Location = New System.Drawing.Point(71, 91)
        Me.txtNgayLap.Name = "txtNgayLap"
        Me.txtNgayLap.Size = New System.Drawing.Size(184, 20)
        Me.txtNgayLap.TabIndex = 11
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(7, 202)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 14
        Me.btnRefresh.Text = "Tẩy bộ lọc"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnNhapLai
        '
        Me.btnNhapLai.Location = New System.Drawing.Point(94, 202)
        Me.btnNhapLai.Name = "btnNhapLai"
        Me.btnNhapLai.Size = New System.Drawing.Size(75, 23)
        Me.btnNhapLai.TabIndex = 15
        Me.btnNhapLai.Text = "Nhập lại"
        Me.btnNhapLai.UseVisualStyleBackColor = True
        '
        'btnLocDuLieu
        '
        Me.btnLocDuLieu.Location = New System.Drawing.Point(180, 202)
        Me.btnLocDuLieu.Name = "btnLocDuLieu"
        Me.btnLocDuLieu.Size = New System.Drawing.Size(75, 23)
        Me.btnLocDuLieu.TabIndex = 16
        Me.btnLocDuLieu.Text = "Lọc dữ liệu"
        Me.btnLocDuLieu.UseVisualStyleBackColor = True
        '
        'txtMaKH
        '
        Me.txtMaKH.Location = New System.Drawing.Point(71, 60)
        Me.txtMaKH.Name = "txtMaKH"
        Me.txtMaKH.Size = New System.Drawing.Size(184, 20)
        Me.txtMaKH.TabIndex = 10
        '
        'txtTongTien
        '
        Me.txtTongTien.Enabled = False
        Me.txtTongTien.Location = New System.Drawing.Point(71, 123)
        Me.txtTongTien.Name = "txtTongTien"
        Me.txtTongTien.Size = New System.Drawing.Size(184, 20)
        Me.txtTongTien.TabIndex = 12
        '
        'txtMaNV
        '
        Me.txtMaNV.Location = New System.Drawing.Point(71, 153)
        Me.txtMaNV.Multiline = True
        Me.txtMaNV.Name = "txtMaNV"
        Me.txtMaNV.Size = New System.Drawing.Size(184, 43)
        Me.txtMaNV.TabIndex = 13
        '
        'txtMaHD
        '
        Me.txtMaHD.Location = New System.Drawing.Point(71, 29)
        Me.txtMaHD.Name = "txtMaHD"
        Me.txtMaHD.Size = New System.Drawing.Size(184, 20)
        Me.txtMaHD.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 15)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Mã KH:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Ngày lập:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Mã NV:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tổng tiền:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Mã HĐ:"
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
        'frmHoaDon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(896, 426)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DgvHoaDon)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmHoaDon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hóa đơn"
        CType(Me.DgvHoaDon,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        Me.ToolStrip1.ResumeLayout(false)
        Me.ToolStrip1.PerformLayout
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents DgvHoaDon As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnXem As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnThem As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnXoa As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnThoat As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblTimKiem As System.Windows.Forms.Label
    Friend WithEvents btnLocDuLieu As System.Windows.Forms.Button
    Friend WithEvents txtMaKH As System.Windows.Forms.TextBox
    Friend WithEvents txtTongTien As System.Windows.Forms.TextBox
    Friend WithEvents txtMaNV As System.Windows.Forms.TextBox
    Friend WithEvents txtMaHD As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnNhapLai As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents txtNgayLap As System.Windows.Forms.TextBox
End Class
