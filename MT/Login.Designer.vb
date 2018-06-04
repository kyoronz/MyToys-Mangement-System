<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblusr = New System.Windows.Forms.Label()
        Me.colon1 = New System.Windows.Forms.Label()
        Me.txtusr = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblpsw = New System.Windows.Forms.Label()
        Me.colon2 = New System.Windows.Forms.Label()
        Me.txtpsw = New System.Windows.Forms.TextBox()
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.lblalert1 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.lblusr)
        Me.FlowLayoutPanel1.Controls.Add(Me.colon1)
        Me.FlowLayoutPanel1.Controls.Add(Me.txtusr)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(77, 201)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(206, 35)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'lblusr
        '
        Me.lblusr.AutoSize = True
        Me.lblusr.Location = New System.Drawing.Point(12, 10)
        Me.lblusr.Margin = New System.Windows.Forms.Padding(12, 10, 3, 0)
        Me.lblusr.Name = "lblusr"
        Me.lblusr.Size = New System.Drawing.Size(55, 13)
        Me.lblusr.TabIndex = 0
        Me.lblusr.Text = "Username"
        '
        'colon1
        '
        Me.colon1.AutoSize = True
        Me.colon1.Location = New System.Drawing.Point(73, 10)
        Me.colon1.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.colon1.Name = "colon1"
        Me.colon1.Size = New System.Drawing.Size(10, 13)
        Me.colon1.TabIndex = 1
        Me.colon1.Text = ":"
        '
        'txtusr
        '
        Me.txtusr.Location = New System.Drawing.Point(89, 8)
        Me.txtusr.Margin = New System.Windows.Forms.Padding(3, 8, 3, 3)
        Me.txtusr.Name = "txtusr"
        Me.txtusr.Size = New System.Drawing.Size(100, 20)
        Me.txtusr.TabIndex = 1
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.lblpsw)
        Me.FlowLayoutPanel2.Controls.Add(Me.colon2)
        Me.FlowLayoutPanel2.Controls.Add(Me.txtpsw)
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(77, 253)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(206, 35)
        Me.FlowLayoutPanel2.TabIndex = 1
        '
        'lblpsw
        '
        Me.lblpsw.AutoSize = True
        Me.lblpsw.Location = New System.Drawing.Point(12, 10)
        Me.lblpsw.Margin = New System.Windows.Forms.Padding(12, 10, 3, 0)
        Me.lblpsw.Name = "lblpsw"
        Me.lblpsw.Size = New System.Drawing.Size(53, 13)
        Me.lblpsw.TabIndex = 0
        Me.lblpsw.Text = "Password"
        '
        'colon2
        '
        Me.colon2.AutoSize = True
        Me.colon2.Location = New System.Drawing.Point(73, 10)
        Me.colon2.Margin = New System.Windows.Forms.Padding(5, 10, 3, 0)
        Me.colon2.Name = "colon2"
        Me.colon2.Size = New System.Drawing.Size(10, 13)
        Me.colon2.TabIndex = 1
        Me.colon2.Text = ":"
        '
        'txtpsw
        '
        Me.txtpsw.Location = New System.Drawing.Point(89, 8)
        Me.txtpsw.Margin = New System.Windows.Forms.Padding(3, 8, 3, 3)
        Me.txtpsw.Name = "txtpsw"
        Me.txtpsw.Size = New System.Drawing.Size(100, 20)
        Me.txtpsw.TabIndex = 2
        Me.txtpsw.UseSystemPasswordChar = True
        '
        'logo
        '
        Me.logo.BackgroundImage = CType(resources.GetObject("logo.BackgroundImage"), System.Drawing.Image)
        Me.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.logo.Location = New System.Drawing.Point(33, 23)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(307, 158)
        Me.logo.TabIndex = 1
        Me.logo.TabStop = False
        '
        'lblalert1
        '
        Me.lblalert1.AutoSize = True
        Me.lblalert1.ForeColor = System.Drawing.Color.Red
        Me.lblalert1.Location = New System.Drawing.Point(78, 300)
        Me.lblalert1.Name = "lblalert1"
        Me.lblalert1.Size = New System.Drawing.Size(0, 13)
        Me.lblalert1.TabIndex = 2
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.Controls.Add(Me.btnlogin)
        Me.FlowLayoutPanel3.Controls.Add(Me.btnexit)
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(77, 329)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(206, 32)
        Me.FlowLayoutPanel3.TabIndex = 3
        '
        'btnlogin
        '
        Me.btnlogin.Location = New System.Drawing.Point(4, 3)
        Me.btnlogin.Margin = New System.Windows.Forms.Padding(4, 3, 45, 3)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(75, 23)
        Me.btnlogin.TabIndex = 4
        Me.btnlogin.Text = "Log in"
        Me.btnlogin.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.Location = New System.Drawing.Point(127, 3)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(75, 23)
        Me.btnexit.TabIndex = 5
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(377, 383)
        Me.ControlBox = False
        Me.Controls.Add(Me.FlowLayoutPanel3)
        Me.Controls.Add(Me.lblalert1)
        Me.Controls.Add(Me.logo)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents lblusr As Label
    Friend WithEvents colon1 As Label
    Friend WithEvents txtusr As TextBox
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents lblpsw As Label
    Friend WithEvents colon2 As Label
    Friend WithEvents txtpsw As TextBox
    Friend WithEvents logo As PictureBox
    Friend WithEvents lblalert1 As Label
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents btnlogin As Button
    Friend WithEvents btnexit As Button
End Class
