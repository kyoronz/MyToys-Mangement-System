<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Order
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Order))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtpid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtpname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rtxtodesc = New System.Windows.Forms.RichTextBox()
        Me.rtxtdesc = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtcustname = New System.Windows.Forms.TextBox()
        Me.txtcontact = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(96, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Product ID"
        '
        'txtpid
        '
        Me.txtpid.BackColor = System.Drawing.Color.FloralWhite
        Me.txtpid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtpid.Location = New System.Drawing.Point(160, 91)
        Me.txtpid.Name = "txtpid"
        Me.txtpid.ReadOnly = True
        Me.txtpid.Size = New System.Drawing.Size(272, 13)
        Me.txtpid.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(79, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Product Name"
        '
        'txtpname
        '
        Me.txtpname.BackColor = System.Drawing.Color.FloralWhite
        Me.txtpname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtpname.Location = New System.Drawing.Point(160, 124)
        Me.txtpname.Name = "txtpname"
        Me.txtpname.ReadOnly = True
        Me.txtpname.Size = New System.Drawing.Size(272, 13)
        Me.txtpname.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 13)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Original Product Description"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 228)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 13)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Customisation Description"
        '
        'rtxtodesc
        '
        Me.rtxtodesc.BackColor = System.Drawing.Color.FloralWhite
        Me.rtxtodesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rtxtodesc.Location = New System.Drawing.Point(160, 159)
        Me.rtxtodesc.Name = "rtxtodesc"
        Me.rtxtodesc.ReadOnly = True
        Me.rtxtodesc.Size = New System.Drawing.Size(272, 50)
        Me.rtxtodesc.TabIndex = 4
        Me.rtxtodesc.Text = ""
        '
        'rtxtdesc
        '
        Me.rtxtdesc.BackColor = System.Drawing.Color.FloralWhite
        Me.rtxtdesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rtxtdesc.Location = New System.Drawing.Point(160, 225)
        Me.rtxtdesc.Name = "rtxtdesc"
        Me.rtxtdesc.ReadOnly = True
        Me.rtxtdesc.Size = New System.Drawing.Size(272, 125)
        Me.rtxtdesc.TabIndex = 5
        Me.rtxtdesc.Text = ""
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(139, 414)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Approve"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(314, 414)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Reject"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(72, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 13)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Customer Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(63, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 13)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Customer Contact"
        '
        'txtcustname
        '
        Me.txtcustname.BackColor = System.Drawing.Color.FloralWhite
        Me.txtcustname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtcustname.Location = New System.Drawing.Point(160, 25)
        Me.txtcustname.Name = "txtcustname"
        Me.txtcustname.ReadOnly = True
        Me.txtcustname.Size = New System.Drawing.Size(272, 13)
        Me.txtcustname.TabIndex = 0
        '
        'txtcontact
        '
        Me.txtcontact.BackColor = System.Drawing.Color.FloralWhite
        Me.txtcontact.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtcontact.Location = New System.Drawing.Point(160, 58)
        Me.txtcontact.Name = "txtcontact"
        Me.txtcontact.ReadOnly = True
        Me.txtcontact.Size = New System.Drawing.Size(272, 13)
        Me.txtcontact.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FloralWhite
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.rtxtdesc)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.rtxtodesc)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtcontact)
        Me.GroupBox1.Controls.Add(Me.txtpid)
        Me.GroupBox1.Controls.Add(Me.txtpname)
        Me.GroupBox1.Controls.Add(Me.txtcustname)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(40, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(461, 367)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Order
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(548, 459)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Order"
        Me.Text = "Order Approval"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtpid As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtpname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents rtxtodesc As RichTextBox
    Friend WithEvents rtxtdesc As RichTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtcustname As TextBox
    Friend WithEvents txtcontact As TextBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
