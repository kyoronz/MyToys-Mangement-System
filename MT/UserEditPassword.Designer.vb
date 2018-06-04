<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserEditPassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserEditPassword))
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblusr = New System.Windows.Forms.Label()
        Me.colon1 = New System.Windows.Forms.Label()
        Me.txtusr = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.lbloldpsw = New System.Windows.Forms.Label()
        Me.colon2 = New System.Windows.Forms.Label()
        Me.txtoldpsw = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblnewpsw = New System.Windows.Forms.Label()
        Me.colon3 = New System.Windows.Forms.Label()
        Me.txtnewpsw = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel4 = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblrepsw = New System.Windows.Forms.Label()
        Me.colon4 = New System.Windows.Forms.Label()
        Me.txtrepsw = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel5 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnconfirm = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.FlowLayoutPanel3.SuspendLayout()
        Me.FlowLayoutPanel4.SuspendLayout()
        Me.FlowLayoutPanel5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.lblusr)
        Me.FlowLayoutPanel1.Controls.Add(Me.colon1)
        Me.FlowLayoutPanel1.Controls.Add(Me.txtusr)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(19, 28)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(244, 35)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'lblusr
        '
        Me.lblusr.AutoSize = True
        Me.lblusr.Location = New System.Drawing.Point(12, 10)
        Me.lblusr.Margin = New System.Windows.Forms.Padding(12, 10, 45, 0)
        Me.lblusr.Name = "lblusr"
        Me.lblusr.Size = New System.Drawing.Size(55, 13)
        Me.lblusr.TabIndex = 0
        Me.lblusr.Text = "Username"
        '
        'colon1
        '
        Me.colon1.AutoSize = True
        Me.colon1.Location = New System.Drawing.Point(115, 10)
        Me.colon1.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.colon1.Name = "colon1"
        Me.colon1.Size = New System.Drawing.Size(10, 13)
        Me.colon1.TabIndex = 1
        Me.colon1.Text = ":"
        '
        'txtusr
        '
        Me.txtusr.Location = New System.Drawing.Point(131, 8)
        Me.txtusr.Margin = New System.Windows.Forms.Padding(3, 8, 3, 3)
        Me.txtusr.Name = "txtusr"
        Me.txtusr.Size = New System.Drawing.Size(100, 20)
        Me.txtusr.TabIndex = 0
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.lbloldpsw)
        Me.FlowLayoutPanel2.Controls.Add(Me.colon2)
        Me.FlowLayoutPanel2.Controls.Add(Me.txtoldpsw)
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(19, 69)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(244, 35)
        Me.FlowLayoutPanel2.TabIndex = 1
        '
        'lbloldpsw
        '
        Me.lbloldpsw.AutoSize = True
        Me.lbloldpsw.Location = New System.Drawing.Point(12, 10)
        Me.lbloldpsw.Margin = New System.Windows.Forms.Padding(12, 10, 28, 0)
        Me.lbloldpsw.Name = "lbloldpsw"
        Me.lbloldpsw.Size = New System.Drawing.Size(72, 13)
        Me.lbloldpsw.TabIndex = 0
        Me.lbloldpsw.Text = "Old Password"
        '
        'colon2
        '
        Me.colon2.AutoSize = True
        Me.colon2.Location = New System.Drawing.Point(115, 10)
        Me.colon2.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.colon2.Name = "colon2"
        Me.colon2.Size = New System.Drawing.Size(10, 13)
        Me.colon2.TabIndex = 1
        Me.colon2.Text = ":"
        '
        'txtoldpsw
        '
        Me.txtoldpsw.Location = New System.Drawing.Point(131, 8)
        Me.txtoldpsw.Margin = New System.Windows.Forms.Padding(3, 8, 3, 3)
        Me.txtoldpsw.Name = "txtoldpsw"
        Me.txtoldpsw.Size = New System.Drawing.Size(100, 20)
        Me.txtoldpsw.TabIndex = 1
        Me.txtoldpsw.UseSystemPasswordChar = True
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.Controls.Add(Me.lblnewpsw)
        Me.FlowLayoutPanel3.Controls.Add(Me.colon3)
        Me.FlowLayoutPanel3.Controls.Add(Me.txtnewpsw)
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(19, 110)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(244, 35)
        Me.FlowLayoutPanel3.TabIndex = 2
        '
        'lblnewpsw
        '
        Me.lblnewpsw.AutoSize = True
        Me.lblnewpsw.Location = New System.Drawing.Point(12, 10)
        Me.lblnewpsw.Margin = New System.Windows.Forms.Padding(12, 10, 22, 0)
        Me.lblnewpsw.Name = "lblnewpsw"
        Me.lblnewpsw.Size = New System.Drawing.Size(78, 13)
        Me.lblnewpsw.TabIndex = 0
        Me.lblnewpsw.Text = "New Password"
        '
        'colon3
        '
        Me.colon3.AutoSize = True
        Me.colon3.Location = New System.Drawing.Point(115, 10)
        Me.colon3.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.colon3.Name = "colon3"
        Me.colon3.Size = New System.Drawing.Size(10, 13)
        Me.colon3.TabIndex = 1
        Me.colon3.Text = ":"
        '
        'txtnewpsw
        '
        Me.txtnewpsw.Location = New System.Drawing.Point(131, 8)
        Me.txtnewpsw.Margin = New System.Windows.Forms.Padding(3, 8, 3, 3)
        Me.txtnewpsw.Name = "txtnewpsw"
        Me.txtnewpsw.Size = New System.Drawing.Size(100, 20)
        Me.txtnewpsw.TabIndex = 2
        Me.txtnewpsw.UseSystemPasswordChar = True
        '
        'FlowLayoutPanel4
        '
        Me.FlowLayoutPanel4.Controls.Add(Me.lblrepsw)
        Me.FlowLayoutPanel4.Controls.Add(Me.colon4)
        Me.FlowLayoutPanel4.Controls.Add(Me.txtrepsw)
        Me.FlowLayoutPanel4.Location = New System.Drawing.Point(19, 151)
        Me.FlowLayoutPanel4.Name = "FlowLayoutPanel4"
        Me.FlowLayoutPanel4.Size = New System.Drawing.Size(244, 35)
        Me.FlowLayoutPanel4.TabIndex = 3
        '
        'lblrepsw
        '
        Me.lblrepsw.AutoSize = True
        Me.lblrepsw.Location = New System.Drawing.Point(12, 10)
        Me.lblrepsw.Margin = New System.Windows.Forms.Padding(12, 10, 3, 0)
        Me.lblrepsw.Name = "lblrepsw"
        Me.lblrepsw.Size = New System.Drawing.Size(97, 13)
        Me.lblrepsw.TabIndex = 0
        Me.lblrepsw.Text = "Re-enter Password"
        '
        'colon4
        '
        Me.colon4.AutoSize = True
        Me.colon4.Location = New System.Drawing.Point(115, 10)
        Me.colon4.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.colon4.Name = "colon4"
        Me.colon4.Size = New System.Drawing.Size(10, 13)
        Me.colon4.TabIndex = 1
        Me.colon4.Text = ":"
        '
        'txtrepsw
        '
        Me.txtrepsw.Location = New System.Drawing.Point(131, 8)
        Me.txtrepsw.Margin = New System.Windows.Forms.Padding(3, 8, 3, 3)
        Me.txtrepsw.Name = "txtrepsw"
        Me.txtrepsw.Size = New System.Drawing.Size(100, 20)
        Me.txtrepsw.TabIndex = 3
        Me.txtrepsw.UseSystemPasswordChar = True
        '
        'FlowLayoutPanel5
        '
        Me.FlowLayoutPanel5.Controls.Add(Me.btnconfirm)
        Me.FlowLayoutPanel5.Controls.Add(Me.btncancel)
        Me.FlowLayoutPanel5.Location = New System.Drawing.Point(55, 247)
        Me.FlowLayoutPanel5.Name = "FlowLayoutPanel5"
        Me.FlowLayoutPanel5.Size = New System.Drawing.Size(244, 32)
        Me.FlowLayoutPanel5.TabIndex = 4
        '
        'btnconfirm
        '
        Me.btnconfirm.Location = New System.Drawing.Point(19, 3)
        Me.btnconfirm.Margin = New System.Windows.Forms.Padding(19, 3, 3, 3)
        Me.btnconfirm.Name = "btnconfirm"
        Me.btnconfirm.Size = New System.Drawing.Size(75, 23)
        Me.btnconfirm.TabIndex = 4
        Me.btnconfirm.Text = "Confirm"
        Me.btnconfirm.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Location = New System.Drawing.Point(153, 3)
        Me.btncancel.Margin = New System.Windows.Forms.Padding(56, 3, 3, 3)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 23)
        Me.btncancel.TabIndex = 5
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FloralWhite
        Me.GroupBox1.Controls.Add(Me.FlowLayoutPanel1)
        Me.GroupBox1.Controls.Add(Me.FlowLayoutPanel3)
        Me.GroupBox1.Controls.Add(Me.FlowLayoutPanel4)
        Me.GroupBox1.Controls.Add(Me.FlowLayoutPanel2)
        Me.GroupBox1.Location = New System.Drawing.Point(36, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(285, 204)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Password details"
        '
        'UserEditPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(357, 306)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.FlowLayoutPanel5)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "UserEditPassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Password"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.FlowLayoutPanel3.PerformLayout()
        Me.FlowLayoutPanel4.ResumeLayout(False)
        Me.FlowLayoutPanel4.PerformLayout()
        Me.FlowLayoutPanel5.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents lblusr As Label
    Friend WithEvents colon1 As Label
    Friend WithEvents txtusr As TextBox
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents lbloldpsw As Label
    Friend WithEvents colon2 As Label
    Friend WithEvents txtoldpsw As TextBox
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents lblnewpsw As Label
    Friend WithEvents colon3 As Label
    Friend WithEvents txtnewpsw As TextBox
    Friend WithEvents FlowLayoutPanel4 As FlowLayoutPanel
    Friend WithEvents lblrepsw As Label
    Friend WithEvents colon4 As Label
    Friend WithEvents txtrepsw As TextBox
    Friend WithEvents FlowLayoutPanel5 As FlowLayoutPanel
    Friend WithEvents btnconfirm As Button
    Friend WithEvents btncancel As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
