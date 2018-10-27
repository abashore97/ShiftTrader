<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTakeShift
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
        Me.txtEmailBody = New System.Windows.Forms.TextBox()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtEmailBody
        '
        Me.txtEmailBody.Location = New System.Drawing.Point(43, 112)
        Me.txtEmailBody.Multiline = True
        Me.txtEmailBody.Name = "txtEmailBody"
        Me.txtEmailBody.ReadOnly = True
        Me.txtEmailBody.Size = New System.Drawing.Size(575, 300)
        Me.txtEmailBody.TabIndex = 0
        '
        'btnDone
        '
        Me.btnDone.Location = New System.Drawing.Point(672, 426)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(91, 28)
        Me.btnDone.TabIndex = 1
        Me.btnDone.Text = "Done"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(39, 68)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(155, 20)
        Me.lblEmail.TabIndex = 3
        Me.lblEmail.Text = "Co-Worker's Email:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(200, 66)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(217, 22)
        Me.txtEmail.TabIndex = 4
        '
        'lblPrompt
        '
        Me.lblPrompt.AutoSize = True
        Me.lblPrompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrompt.Location = New System.Drawing.Point(38, 9)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(451, 29)
        Me.lblPrompt.TabIndex = 5
        Me.lblPrompt.Text = "Please copy and paste into an email draft"
        '
        'frmTakeShift
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(768, 461)
        Me.Controls.Add(Me.lblPrompt)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.txtEmailBody)
        Me.Name = "frmTakeShift"
        Me.RightToLeftLayout = True
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Take Shift"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtEmailBody As TextBox
    Friend WithEvents btnDone As Button
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblPrompt As Label
End Class
