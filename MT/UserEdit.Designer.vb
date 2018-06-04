<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserEdit))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.FlowLayoutPanel5 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnprev = New System.Windows.Forms.Button()
        Me.btnnext = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblusr = New System.Windows.Forms.Label()
        Me.colon2 = New System.Windows.Forms.Label()
        Me.txtusr = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblacctype = New System.Windows.Forms.Label()
        Me.colon3 = New System.Windows.Forms.Label()
        Me.cboxacctype = New System.Windows.Forms.ComboBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblname = New System.Windows.Forms.Label()
        Me.colon1 = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.btneditpsw = New System.Windows.Forms.Button()
        Me.btnback = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btneditdetails = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel4 = New System.Windows.Forms.FlowLayoutPanel()
        Me.GroupBox1.SuspendLayout()
        Me.FlowLayoutPanel5.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.FlowLayoutPanel3.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FloralWhite
        Me.GroupBox1.Controls.Add(Me.FlowLayoutPanel5)
        Me.GroupBox1.Controls.Add(Me.FlowLayoutPanel2)
        Me.GroupBox1.Controls.Add(Me.FlowLayoutPanel3)
        Me.GroupBox1.Controls.Add(Me.FlowLayoutPanel1)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(285, 243)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Account info"
        '
        'FlowLayoutPanel5
        '
        Me.FlowLayoutPanel5.Controls.Add(Me.btnprev)
        Me.FlowLayoutPanel5.Controls.Add(Me.btnnext)
        Me.FlowLayoutPanel5.Location = New System.Drawing.Point(25, 166)
        Me.FlowLayoutPanel5.Name = "FlowLayoutPanel5"
        Me.FlowLayoutPanel5.Size = New System.Drawing.Size(220, 62)
        Me.FlowLayoutPanel5.TabIndex = 3
        '
        'btnprev
        '
        Me.btnprev.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprev.Location = New System.Drawing.Point(7, 8)
        Me.btnprev.Margin = New System.Windows.Forms.Padding(7, 8, 3, 3)
        Me.btnprev.Name = "btnprev"
        Me.btnprev.Size = New System.Drawing.Size(100, 46)
        Me.btnprev.TabIndex = 0
        Me.btnprev.Text = "Prev"
        Me.btnprev.UseVisualStyleBackColor = True
        '
        'btnnext
        '
        Me.btnnext.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnext.Location = New System.Drawing.Point(113, 8)
        Me.btnnext.Margin = New System.Windows.Forms.Padding(3, 8, 3, 3)
        Me.btnnext.Name = "btnnext"
        Me.btnnext.Size = New System.Drawing.Size(100, 46)
        Me.btnnext.TabIndex = 1
        Me.btnnext.Text = "Next"
        Me.btnnext.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.lblusr)
        Me.FlowLayoutPanel2.Controls.Add(Me.colon2)
        Me.FlowLayoutPanel2.Controls.Add(Me.txtusr)
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(15, 76)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(244, 35)
        Me.FlowLayoutPanel2.TabIndex = 1
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
        'colon2
        '
        Me.colon2.AutoSize = True
        Me.colon2.Location = New System.Drawing.Point(89, 10)
        Me.colon2.Margin = New System.Windows.Forms.Padding(19, 10, 3, 0)
        Me.colon2.Name = "colon2"
        Me.colon2.Size = New System.Drawing.Size(10, 13)
        Me.colon2.TabIndex = 1
        Me.colon2.Text = ":"
        '
        'txtusr
        '
        Me.txtusr.Location = New System.Drawing.Point(105, 8)
        Me.txtusr.Margin = New System.Windows.Forms.Padding(3, 8, 3, 3)
        Me.txtusr.Name = "txtusr"
        Me.txtusr.Size = New System.Drawing.Size(100, 20)
        Me.txtusr.TabIndex = 0
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.Controls.Add(Me.lblacctype)
        Me.FlowLayoutPanel3.Controls.Add(Me.colon3)
        Me.FlowLayoutPanel3.Controls.Add(Me.cboxacctype)
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(15, 117)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(244, 35)
        Me.FlowLayoutPanel3.TabIndex = 2
        '
        'lblacctype
        '
        Me.lblacctype.AutoSize = True
        Me.lblacctype.Location = New System.Drawing.Point(12, 10)
        Me.lblacctype.Margin = New System.Windows.Forms.Padding(12, 10, 0, 0)
        Me.lblacctype.Name = "lblacctype"
        Me.lblacctype.Size = New System.Drawing.Size(74, 13)
        Me.lblacctype.TabIndex = 0
        Me.lblacctype.Text = "Account Type"
        '
        'colon3
        '
        Me.colon3.AutoSize = True
        Me.colon3.Location = New System.Drawing.Point(89, 10)
        Me.colon3.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.colon3.Name = "colon3"
        Me.colon3.Size = New System.Drawing.Size(10, 13)
        Me.colon3.TabIndex = 1
        Me.colon3.Text = ":"
        '
        'cboxacctype
        '
        Me.cboxacctype.FormattingEnabled = True
        Me.cboxacctype.Location = New System.Drawing.Point(105, 8)
        Me.cboxacctype.Margin = New System.Windows.Forms.Padding(3, 8, 3, 3)
        Me.cboxacctype.Name = "cboxacctype"
        Me.cboxacctype.Size = New System.Drawing.Size(121, 21)
        Me.cboxacctype.TabIndex = 0
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.lblname)
        Me.FlowLayoutPanel1.Controls.Add(Me.colon1)
        Me.FlowLayoutPanel1.Controls.Add(Me.txtname)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(15, 35)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(244, 35)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Location = New System.Drawing.Point(12, 10)
        Me.lblname.Margin = New System.Windows.Forms.Padding(12, 10, 3, 0)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(35, 13)
        Me.lblname.TabIndex = 0
        Me.lblname.Text = "Name"
        '
        'colon1
        '
        Me.colon1.AutoSize = True
        Me.colon1.Location = New System.Drawing.Point(89, 10)
        Me.colon1.Margin = New System.Windows.Forms.Padding(39, 10, 3, 0)
        Me.colon1.Name = "colon1"
        Me.colon1.Size = New System.Drawing.Size(10, 13)
        Me.colon1.TabIndex = 1
        Me.colon1.Text = ":"
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(105, 8)
        Me.txtname.Margin = New System.Windows.Forms.Padding(3, 8, 3, 3)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(100, 20)
        Me.txtname.TabIndex = 0
        '
        'btneditpsw
        '
        Me.btneditpsw.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneditpsw.Location = New System.Drawing.Point(5, 166)
        Me.btneditpsw.Margin = New System.Windows.Forms.Padding(5, 3, 3, 3)
        Me.btneditpsw.Name = "btneditpsw"
        Me.btneditpsw.Size = New System.Drawing.Size(109, 46)
        Me.btneditpsw.TabIndex = 3
        Me.btneditpsw.Text = "Edit Password"
        Me.btneditpsw.UseVisualStyleBackColor = True
        '
        'btnback
        '
        Me.btnback.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback.Location = New System.Drawing.Point(5, 114)
        Me.btnback.Margin = New System.Windows.Forms.Padding(5, 3, 3, 3)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(109, 46)
        Me.btnback.TabIndex = 2
        Me.btnback.Text = "Back"
        Me.btnback.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Location = New System.Drawing.Point(5, 62)
        Me.btndelete.Margin = New System.Windows.Forms.Padding(5, 3, 3, 3)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(109, 46)
        Me.btndelete.TabIndex = 1
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btneditdetails
        '
        Me.btneditdetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneditdetails.Location = New System.Drawing.Point(5, 10)
        Me.btneditdetails.Margin = New System.Windows.Forms.Padding(5, 10, 3, 3)
        Me.btneditdetails.Name = "btneditdetails"
        Me.btneditdetails.Size = New System.Drawing.Size(109, 46)
        Me.btneditdetails.TabIndex = 0
        Me.btneditdetails.Text = "Edit Details"
        Me.btneditdetails.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel4
        '
        Me.FlowLayoutPanel4.BackColor = System.Drawing.Color.FloralWhite
        Me.FlowLayoutPanel4.Controls.Add(Me.btneditdetails)
        Me.FlowLayoutPanel4.Controls.Add(Me.btndelete)
        Me.FlowLayoutPanel4.Controls.Add(Me.btnback)
        Me.FlowLayoutPanel4.Controls.Add(Me.btneditpsw)
        Me.FlowLayoutPanel4.Location = New System.Drawing.Point(326, 52)
        Me.FlowLayoutPanel4.Name = "FlowLayoutPanel4"
        Me.FlowLayoutPanel4.Size = New System.Drawing.Size(118, 243)
        Me.FlowLayoutPanel4.TabIndex = 5
        '
        'UserEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(473, 351)
        Me.Controls.Add(Me.FlowLayoutPanel4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "UserEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View and Edit User"
        Me.GroupBox1.ResumeLayout(False)
        Me.FlowLayoutPanel5.ResumeLayout(False)
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.FlowLayoutPanel3.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.FlowLayoutPanel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnnext As Button
    Friend WithEvents btnprev As Button
    Friend WithEvents btneditpsw As Button
    Friend WithEvents btnback As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents btneditdetails As Button
    Friend WithEvents FlowLayoutPanel5 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents lblusr As Label
    Friend WithEvents colon2 As Label
    Friend WithEvents txtusr As TextBox
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents lblacctype As Label
    Friend WithEvents colon3 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents lblname As Label
    Friend WithEvents colon1 As Label
    Friend WithEvents txtname As TextBox
    Friend WithEvents FlowLayoutPanel4 As FlowLayoutPanel
    Friend WithEvents cboxacctype As ComboBox
End Class
