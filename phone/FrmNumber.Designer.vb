<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNumber
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmNumber))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.BtnCall = New System.Windows.Forms.Button
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.TxtMobile = New System.Windows.Forms.TextBox
        Me.TxtPhoneNumber = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.RBtnMobile = New System.Windows.Forms.RadioButton
        Me.RBtnPhone = New System.Windows.Forms.RadioButton
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.BtnCancel)
        Me.Panel1.Controls.Add(Me.BtnCall)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(6, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(284, 151)
        Me.Panel1.TabIndex = 0
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnCancel.BackgroundImage = Global.phone.My.Resources.Resources.button
        Me.BtnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancel.ForeColor = System.Drawing.Color.White
        Me.BtnCancel.Location = New System.Drawing.Point(29, 107)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(103, 29)
        Me.BtnCancel.TabIndex = 7
        Me.BtnCancel.Text = "انصراف"
        Me.BtnCancel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'BtnCall
        '
        Me.BtnCall.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnCall.BackgroundImage = Global.phone.My.Resources.Resources.button
        Me.BtnCall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCall.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCall.ForeColor = System.Drawing.Color.White
        Me.BtnCall.Location = New System.Drawing.Point(150, 107)
        Me.BtnCall.Name = "BtnCall"
        Me.BtnCall.Size = New System.Drawing.Size(103, 29)
        Me.BtnCall.TabIndex = 6
        Me.BtnCall.Text = "تماس"
        Me.BtnCall.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnCall.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.TxtMobile)
        Me.Panel3.Controls.Add(Me.TxtPhoneNumber)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(8, 29)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(212, 70)
        Me.Panel3.TabIndex = 0
        '
        'TxtMobile
        '
        Me.TxtMobile.BackColor = System.Drawing.Color.White
        Me.TxtMobile.Location = New System.Drawing.Point(18, 36)
        Me.TxtMobile.Name = "TxtMobile"
        Me.TxtMobile.ReadOnly = True
        Me.TxtMobile.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtMobile.Size = New System.Drawing.Size(125, 22)
        Me.TxtMobile.TabIndex = 2
        Me.TxtMobile.TabStop = False
        '
        'TxtPhoneNumber
        '
        Me.TxtPhoneNumber.BackColor = System.Drawing.Color.White
        Me.TxtPhoneNumber.Location = New System.Drawing.Point(18, 8)
        Me.TxtPhoneNumber.Name = "TxtPhoneNumber"
        Me.TxtPhoneNumber.ReadOnly = True
        Me.TxtPhoneNumber.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtPhoneNumber.Size = New System.Drawing.Size(125, 22)
        Me.TxtPhoneNumber.TabIndex = 1
        Me.TxtPhoneNumber.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(149, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 14)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "موبایل:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(149, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 14)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "تلفن:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(231, 14)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "شماره مورد نظر جهت تماس را انتخاب نمایید:"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.RBtnMobile)
        Me.Panel2.Controls.Add(Me.RBtnPhone)
        Me.Panel2.Location = New System.Drawing.Point(212, 29)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(55, 70)
        Me.Panel2.TabIndex = 1
        '
        'RBtnMobile
        '
        Me.RBtnMobile.AutoSize = True
        Me.RBtnMobile.Location = New System.Drawing.Point(7, 38)
        Me.RBtnMobile.Name = "RBtnMobile"
        Me.RBtnMobile.Size = New System.Drawing.Size(37, 18)
        Me.RBtnMobile.TabIndex = 2
        Me.RBtnMobile.Text = "←"
        Me.RBtnMobile.UseVisualStyleBackColor = True
        '
        'RBtnPhone
        '
        Me.RBtnPhone.AutoSize = True
        Me.RBtnPhone.Checked = True
        Me.RBtnPhone.Location = New System.Drawing.Point(7, 10)
        Me.RBtnPhone.Name = "RBtnPhone"
        Me.RBtnPhone.Size = New System.Drawing.Size(37, 18)
        Me.RBtnPhone.TabIndex = 1
        Me.RBtnPhone.TabStop = True
        Me.RBtnPhone.Text = "←"
        Me.RBtnPhone.UseVisualStyleBackColor = True
        '
        'FrmNumber
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImage = Global.phone.My.Resources.Resources.button
        Me.ClientSize = New System.Drawing.Size(296, 167)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmNumber"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "تماس"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtPhoneNumber As System.Windows.Forms.TextBox
    Friend WithEvents TxtMobile As System.Windows.Forms.TextBox
    Friend WithEvents RBtnPhone As System.Windows.Forms.RadioButton
    Friend WithEvents RBtnMobile As System.Windows.Forms.RadioButton
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnCall As System.Windows.Forms.Button
End Class
