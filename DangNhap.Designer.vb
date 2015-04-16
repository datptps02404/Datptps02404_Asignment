<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDangNhap
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDangNhap))
        Me.lblTenDangNhap = New System.Windows.Forms.Label()
        Me.lblMatKhau = New System.Windows.Forms.Label()
        Me.txtDangNhap = New System.Windows.Forms.TextBox()
        Me.txtMatKhau = New System.Windows.Forms.TextBox()
        Me.btnDangNhap = New System.Windows.Forms.Button()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.grbDangNhap = New System.Windows.Forms.GroupBox()
        Me.lblLoiDangNhap = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.grbDangNhap.SuspendLayout
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'lblTenDangNhap
        '
        Me.lblTenDangNhap.AutoSize = true
        Me.lblTenDangNhap.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163,Byte))
        Me.lblTenDangNhap.ForeColor = System.Drawing.Color.Black
        Me.lblTenDangNhap.Location = New System.Drawing.Point(6, 74)
        Me.lblTenDangNhap.Name = "lblTenDangNhap"
        Me.lblTenDangNhap.Size = New System.Drawing.Size(102, 16)
        Me.lblTenDangNhap.TabIndex = 0
        Me.lblTenDangNhap.Text = "Tên đăng nhập:"
        '
        'lblMatKhau
        '
        Me.lblMatKhau.AutoSize = true
        Me.lblMatKhau.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163,Byte))
        Me.lblMatKhau.ForeColor = System.Drawing.Color.Black
        Me.lblMatKhau.Location = New System.Drawing.Point(43, 106)
        Me.lblMatKhau.Name = "lblMatKhau"
        Me.lblMatKhau.Size = New System.Drawing.Size(65, 16)
        Me.lblMatKhau.TabIndex = 1
        Me.lblMatKhau.Text = "Mật khẩu:"
        '
        'txtDangNhap
        '
        Me.txtDangNhap.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163,Byte))
        Me.txtDangNhap.Location = New System.Drawing.Point(121, 68)
        Me.txtDangNhap.Name = "txtDangNhap"
        Me.txtDangNhap.Size = New System.Drawing.Size(201, 26)
        Me.txtDangNhap.TabIndex = 3
        '
        'txtMatKhau
        '
        Me.txtMatKhau.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163,Byte))
        Me.txtMatKhau.Location = New System.Drawing.Point(121, 100)
        Me.txtMatKhau.Name = "txtMatKhau"
        Me.txtMatKhau.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtMatKhau.Size = New System.Drawing.Size(201, 26)
        Me.txtMatKhau.TabIndex = 4
        '
        'btnDangNhap
        '
        Me.btnDangNhap.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163,Byte))
        Me.btnDangNhap.ForeColor = System.Drawing.Color.Black
        Me.btnDangNhap.Location = New System.Drawing.Point(121, 141)
        Me.btnDangNhap.Name = "btnDangNhap"
        Me.btnDangNhap.Size = New System.Drawing.Size(91, 25)
        Me.btnDangNhap.TabIndex = 6
        Me.btnDangNhap.Text = "Đăng nhập"
        Me.btnDangNhap.UseVisualStyleBackColor = true
        '
        'btnThoat
        '
        Me.btnThoat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163,Byte))
        Me.btnThoat.ForeColor = System.Drawing.Color.Black
        Me.btnThoat.Location = New System.Drawing.Point(231, 141)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(91, 25)
        Me.btnThoat.TabIndex = 7
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = true
        '
        'grbDangNhap
        '
        Me.grbDangNhap.Controls.Add(Me.lblLoiDangNhap)
        Me.grbDangNhap.Controls.Add(Me.lblTenDangNhap)
        Me.grbDangNhap.Controls.Add(Me.btnThoat)
        Me.grbDangNhap.Controls.Add(Me.txtDangNhap)
        Me.grbDangNhap.Controls.Add(Me.btnDangNhap)
        Me.grbDangNhap.Controls.Add(Me.lblMatKhau)
        Me.grbDangNhap.Controls.Add(Me.txtMatKhau)
        Me.grbDangNhap.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163,Byte))
        Me.grbDangNhap.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.grbDangNhap.Location = New System.Drawing.Point(154, 12)
        Me.grbDangNhap.Name = "grbDangNhap"
        Me.grbDangNhap.Size = New System.Drawing.Size(333, 177)
        Me.grbDangNhap.TabIndex = 8
        Me.grbDangNhap.TabStop = false
        Me.grbDangNhap.Text = "Đăng nhập"
        '
        'lblLoiDangNhap
        '
        Me.lblLoiDangNhap.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163,Byte))
        Me.lblLoiDangNhap.ForeColor = System.Drawing.Color.Red
        Me.lblLoiDangNhap.Location = New System.Drawing.Point(118, 25)
        Me.lblLoiDangNhap.Name = "lblLoiDangNhap"
        Me.lblLoiDangNhap.Size = New System.Drawing.Size(201, 26)
        Me.lblLoiDangNhap.TabIndex = 8
        Me.lblLoiDangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Datptps02404_Asignment.My.Resources.Resources.ban_hang
        Me.PictureBox1.Location = New System.Drawing.Point(12, 39)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(130, 130)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = false
        '
        'frmDangNhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 200)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.grbDangNhap)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "frmDangNhap"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quản lý bán hàng"
        Me.grbDangNhap.ResumeLayout(false)
        Me.grbDangNhap.PerformLayout
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents lblTenDangNhap As System.Windows.Forms.Label
    Friend WithEvents lblMatKhau As System.Windows.Forms.Label
    Friend WithEvents txtDangNhap As System.Windows.Forms.TextBox
    Friend WithEvents txtMatKhau As System.Windows.Forms.TextBox
    Friend WithEvents btnDangNhap As System.Windows.Forms.Button
    Friend WithEvents btnThoat As System.Windows.Forms.Button
    Friend WithEvents grbDangNhap As System.Windows.Forms.GroupBox
    Private WithEvents lblLoiDangNhap As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
