<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChinh
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChinh))
        Me.msi1 = New System.Windows.Forms.MenuStrip()
        Me.mniUngDung = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniDangXuat = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniThoat = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniCongCu = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniKhachHang = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniHoaDon = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThôngTinToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniTTBQ = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblToolStrip = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ptbHoaDon = New System.Windows.Forms.PictureBox()
        Me.ptbKhachHang = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.msi1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.ptbHoaDon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbKhachHang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'msi1
        '
        Me.msi1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.msi1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniUngDung, Me.mniCongCu, Me.ThôngTinToolStripMenuItem})
        Me.msi1.Location = New System.Drawing.Point(0, 0)
        Me.msi1.Name = "msi1"
        Me.msi1.Size = New System.Drawing.Size(731, 25)
        Me.msi1.TabIndex = 0
        Me.msi1.Text = "MenuStrip1"
        '
        'mniUngDung
        '
        Me.mniUngDung.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniDangXuat, Me.mniThoat})
        Me.mniUngDung.Name = "mniUngDung"
        Me.mniUngDung.Size = New System.Drawing.Size(74, 21)
        Me.mniUngDung.Text = "Hệ thống"
        '
        'mniDangXuat
        '
        Me.mniDangXuat.Image = Global.Datptps02404_Asignment.My.Resources.Resources._Exit
        Me.mniDangXuat.Name = "mniDangXuat"
        Me.mniDangXuat.Size = New System.Drawing.Size(135, 22)
        Me.mniDangXuat.Text = "Đăng xuất"
        '
        'mniThoat
        '
        Me.mniThoat.Image = Global.Datptps02404_Asignment.My.Resources.Resources.Delete
        Me.mniThoat.Name = "mniThoat"
        Me.mniThoat.Size = New System.Drawing.Size(135, 22)
        Me.mniThoat.Text = "Thoát"
        '
        'mniCongCu
        '
        Me.mniCongCu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniKhachHang, Me.mniHoaDon})
        Me.mniCongCu.Name = "mniCongCu"
        Me.mniCongCu.Size = New System.Drawing.Size(68, 21)
        Me.mniCongCu.Text = "Công cụ"
        '
        'mniKhachHang
        '
        Me.mniKhachHang.Image = Global.Datptps02404_Asignment.My.Resources.Resources.quan_ly_thong_tin_khach_hang
        Me.mniKhachHang.Name = "mniKhachHang"
        Me.mniKhachHang.Size = New System.Drawing.Size(144, 22)
        Me.mniKhachHang.Text = "Khách hàng"
        '
        'mniHoaDon
        '
        Me.mniHoaDon.Image = Global.Datptps02404_Asignment.My.Resources.Resources.Money_Calculator_icon
        Me.mniHoaDon.Name = "mniHoaDon"
        Me.mniHoaDon.Size = New System.Drawing.Size(144, 22)
        Me.mniHoaDon.Text = "Hóa đơn"
        '
        'ThôngTinToolStripMenuItem
        '
        Me.ThôngTinToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniTTBQ})
        Me.ThôngTinToolStripMenuItem.Name = "ThôngTinToolStripMenuItem"
        Me.ThôngTinToolStripMenuItem.Size = New System.Drawing.Size(75, 21)
        Me.ThôngTinToolStripMenuItem.Text = "Thông tin"
        '
        'mniTTBQ
        '
        Me.mniTTBQ.Image = Global.Datptps02404_Asignment.My.Resources.Resources.Info
        Me.mniTTBQ.Name = "mniTTBQ"
        Me.mniTTBQ.Size = New System.Drawing.Size(196, 22)
        Me.mniTTBQ.Text = "Thông tin bản quyền"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.Gainsboro
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblToolStrip})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 443)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(731, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblToolStrip
        '
        Me.lblToolStrip.AutoSize = False
        Me.lblToolStrip.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblToolStrip.Name = "lblToolStrip"
        Me.lblToolStrip.Size = New System.Drawing.Size(150, 17)
        Me.lblToolStrip.Text = "ToolStripStatusLabel1"
        Me.lblToolStrip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ptbHoaDon
        '
        Me.ptbHoaDon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ptbHoaDon.Image = Global.Datptps02404_Asignment.My.Resources.Resources.Money_Calculator_icon
        Me.ptbHoaDon.Location = New System.Drawing.Point(409, 195)
        Me.ptbHoaDon.Name = "ptbHoaDon"
        Me.ptbHoaDon.Size = New System.Drawing.Size(200, 200)
        Me.ptbHoaDon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbHoaDon.TabIndex = 4
        Me.ptbHoaDon.TabStop = False
        '
        'ptbKhachHang
        '
        Me.ptbKhachHang.BackColor = System.Drawing.Color.White
        Me.ptbKhachHang.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ptbKhachHang.Image = Global.Datptps02404_Asignment.My.Resources.Resources.quan_ly_thong_tin_khach_hang
        Me.ptbKhachHang.Location = New System.Drawing.Point(106, 195)
        Me.ptbKhachHang.Name = "ptbKhachHang"
        Me.ptbKhachHang.Size = New System.Drawing.Size(200, 200)
        Me.ptbKhachHang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbKhachHang.TabIndex = 3
        Me.ptbKhachHang.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.Datptps02404_Asignment.My.Resources.Resources.Logo_FPT_Polytechnic
        Me.PictureBox1.Location = New System.Drawing.Point(193, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(343, 128)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'frmChinh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(731, 465)
        Me.Controls.Add(Me.ptbHoaDon)
        Me.Controls.Add(Me.ptbKhachHang)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.msi1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.msi1
        Me.MaximizeBox = False
        Me.Name = "frmChinh"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hệ thống quản lý bán hàng"
        Me.msi1.ResumeLayout(False)
        Me.msi1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.ptbHoaDon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbKhachHang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents msi1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mniUngDung As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniCongCu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ThôngTinToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblToolStrip As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents mniDangXuat As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniThoat As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniKhachHang As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniHoaDon As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniTTBQ As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ptbKhachHang As System.Windows.Forms.PictureBox
    Friend WithEvents ptbHoaDon As System.Windows.Forms.PictureBox
End Class
