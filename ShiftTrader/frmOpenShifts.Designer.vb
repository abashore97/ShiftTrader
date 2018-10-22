<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOpenShifts
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
        Me.lstOpenShifts = New System.Windows.Forms.ListBox()
        Me.lblOpenShifts = New System.Windows.Forms.Label()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.btnMyShifts = New System.Windows.Forms.Button()
        Me.btnTakeShift = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstOpenShifts
        '
        Me.lstOpenShifts.FormattingEnabled = True
        Me.lstOpenShifts.ItemHeight = 16
        Me.lstOpenShifts.Location = New System.Drawing.Point(49, 64)
        Me.lstOpenShifts.MultiColumn = True
        Me.lstOpenShifts.Name = "lstOpenShifts"
        Me.lstOpenShifts.Size = New System.Drawing.Size(458, 260)
        Me.lstOpenShifts.TabIndex = 0
        '
        'lblOpenShifts
        '
        Me.lblOpenShifts.AutoSize = True
        Me.lblOpenShifts.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOpenShifts.Location = New System.Drawing.Point(44, 24)
        Me.lblOpenShifts.Name = "lblOpenShifts"
        Me.lblOpenShifts.Size = New System.Drawing.Size(121, 25)
        Me.lblOpenShifts.TabIndex = 1
        Me.lblOpenShifts.Text = "Open Shifts:"
        '
        'btnLogOut
        '
        Me.btnLogOut.Location = New System.Drawing.Point(529, 347)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(91, 28)
        Me.btnLogOut.TabIndex = 2
        Me.btnLogOut.Text = "Log Out"
        Me.btnLogOut.UseVisualStyleBackColor = True
        '
        'btnMyShifts
        '
        Me.btnMyShifts.Location = New System.Drawing.Point(529, 64)
        Me.btnMyShifts.Name = "btnMyShifts"
        Me.btnMyShifts.Size = New System.Drawing.Size(91, 28)
        Me.btnMyShifts.TabIndex = 3
        Me.btnMyShifts.Text = "My Shifts"
        Me.btnMyShifts.UseVisualStyleBackColor = True
        '
        'btnTakeShift
        '
        Me.btnTakeShift.Location = New System.Drawing.Point(529, 98)
        Me.btnTakeShift.Name = "btnTakeShift"
        Me.btnTakeShift.Size = New System.Drawing.Size(91, 28)
        Me.btnTakeShift.TabIndex = 4
        Me.btnTakeShift.Text = "Take Shift"
        Me.btnTakeShift.UseVisualStyleBackColor = True
        '
        'frmOpenShifts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 387)
        Me.Controls.Add(Me.btnTakeShift)
        Me.Controls.Add(Me.btnMyShifts)
        Me.Controls.Add(Me.btnLogOut)
        Me.Controls.Add(Me.lblOpenShifts)
        Me.Controls.Add(Me.lstOpenShifts)
        Me.Name = "frmOpenShifts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmOpenShifts"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstOpenShifts As ListBox
    Friend WithEvents lblOpenShifts As Label
    Friend WithEvents btnLogOut As Button
    Friend WithEvents btnMyShifts As Button
    Friend WithEvents btnTakeShift As Button
End Class
