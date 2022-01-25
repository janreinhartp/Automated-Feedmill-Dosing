<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnExit = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnLogin = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.txtbPassword = New Bunifu.Framework.UI.BunifuTextbox()
        Me.txtbUser = New Bunifu.Framework.UI.BunifuTextbox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 50
        Me.BunifuElipse1.TargetControl = Me
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnExit)
        Me.Panel2.Controls.Add(Me.btnLogin)
        Me.Panel2.Controls.Add(Me.txtbPassword)
        Me.Panel2.Controls.Add(Me.txtbUser)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(420, 380)
        Me.Panel2.TabIndex = 3
        '
        'btnExit
        '
        Me.btnExit.Activecolor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExit.BorderRadius = 0
        Me.btnExit.ButtonText = "Exit"
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.DisabledColor = System.Drawing.Color.Gray
        Me.btnExit.Iconcolor = System.Drawing.Color.Transparent
        Me.btnExit.Iconimage = Global.Automated_Feedmill_System.My.Resources.Resources.Delete_96px_blk
        Me.btnExit.Iconimage_right = Nothing
        Me.btnExit.Iconimage_right_Selected = Nothing
        Me.btnExit.Iconimage_Selected = Nothing
        Me.btnExit.IconMarginLeft = 0
        Me.btnExit.IconMarginRight = 0
        Me.btnExit.IconRightVisible = True
        Me.btnExit.IconRightZoom = 0R
        Me.btnExit.IconVisible = True
        Me.btnExit.IconZoom = 70.0R
        Me.btnExit.IsTab = False
        Me.btnExit.Location = New System.Drawing.Point(229, 302)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.btnExit.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(8, Byte), Integer))
        Me.btnExit.OnHoverTextColor = System.Drawing.Color.White
        Me.btnExit.selected = False
        Me.btnExit.Size = New System.Drawing.Size(126, 46)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.Textcolor = System.Drawing.Color.Black
        Me.btnExit.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnLogin
        '
        Me.btnLogin.Activecolor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLogin.BorderRadius = 0
        Me.btnLogin.ButtonText = "Login"
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.DisabledColor = System.Drawing.Color.Gray
        Me.btnLogin.Iconcolor = System.Drawing.Color.Transparent
        Me.btnLogin.Iconimage = Global.Automated_Feedmill_System.My.Resources.Resources.User_96px_blk
        Me.btnLogin.Iconimage_right = Nothing
        Me.btnLogin.Iconimage_right_Selected = Nothing
        Me.btnLogin.Iconimage_Selected = Nothing
        Me.btnLogin.IconMarginLeft = 0
        Me.btnLogin.IconMarginRight = 0
        Me.btnLogin.IconRightVisible = True
        Me.btnLogin.IconRightZoom = 0R
        Me.btnLogin.IconVisible = True
        Me.btnLogin.IconZoom = 70.0R
        Me.btnLogin.IsTab = False
        Me.btnLogin.Location = New System.Drawing.Point(65, 302)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.btnLogin.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(8, Byte), Integer))
        Me.btnLogin.OnHoverTextColor = System.Drawing.Color.White
        Me.btnLogin.selected = False
        Me.btnLogin.Size = New System.Drawing.Size(126, 46)
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.Text = "Login"
        Me.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogin.Textcolor = System.Drawing.Color.Black
        Me.btnLogin.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtbPassword
        '
        Me.txtbPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.txtbPassword.BackgroundImage = CType(resources.GetObject("txtbPassword.BackgroundImage"), System.Drawing.Image)
        Me.txtbPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.txtbPassword.ForeColor = System.Drawing.Color.White
        Me.txtbPassword.Icon = CType(resources.GetObject("txtbPassword.Icon"), System.Drawing.Image)
        Me.txtbPassword.Location = New System.Drawing.Point(65, 225)
        Me.txtbPassword.Name = "txtbPassword"
        Me.txtbPassword.Size = New System.Drawing.Size(290, 42)
        Me.txtbPassword.TabIndex = 3
        Me.txtbPassword.text = "Password"
        '
        'txtbUser
        '
        Me.txtbUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.txtbUser.BackgroundImage = CType(resources.GetObject("txtbUser.BackgroundImage"), System.Drawing.Image)
        Me.txtbUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.txtbUser.ForeColor = System.Drawing.Color.White
        Me.txtbUser.Icon = CType(resources.GetObject("txtbUser.Icon"), System.Drawing.Image)
        Me.txtbUser.Location = New System.Drawing.Point(65, 177)
        Me.txtbUser.Name = "txtbUser"
        Me.txtbUser.Size = New System.Drawing.Size(290, 42)
        Me.txtbUser.TabIndex = 2
        Me.txtbUser.text = "Username"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Automated_Feedmill_System.My.Resources.Resources.loginUI
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(420, 380)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 380)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLogin"
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtbUser As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents txtbPassword As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents btnExit As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnLogin As Bunifu.Framework.UI.BunifuFlatButton
End Class
