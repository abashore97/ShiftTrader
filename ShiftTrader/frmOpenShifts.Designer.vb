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
        Me.lblOpenShifts = New System.Windows.Forms.Label()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.btnMyShifts = New System.Windows.Forms.Button()
        Me.btnTakeShift = New System.Windows.Forms.Button()
        Me.lstOpenShifts = New System.Windows.Forms.ListView()
        Me.clmName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmStartTime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmEndTime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmLocation = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmPermanent = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'lblOpenShifts
        '
        Me.lblOpenShifts.AutoSize = True
        Me.lblOpenShifts.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOpenShifts.Location = New System.Drawing.Point(70, 20)
        Me.lblOpenShifts.Name = "lblOpenShifts"
        Me.lblOpenShifts.Size = New System.Drawing.Size(121, 25)
        Me.lblOpenShifts.TabIndex = 1
        Me.lblOpenShifts.Text = "Open Shifts:"
        '
        'btnLogOut
        '
        Me.btnLogOut.Location = New System.Drawing.Point(737, 448)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(91, 28)
        Me.btnLogOut.TabIndex = 2
        Me.btnLogOut.Text = "Log Out"
        Me.btnLogOut.UseVisualStyleBackColor = True
        '
        'btnMyShifts
        '
        Me.btnMyShifts.Location = New System.Drawing.Point(737, 64)
        Me.btnMyShifts.Name = "btnMyShifts"
        Me.btnMyShifts.Size = New System.Drawing.Size(91, 28)
        Me.btnMyShifts.TabIndex = 3
        Me.btnMyShifts.Text = "My Shifts"
        Me.btnMyShifts.UseVisualStyleBackColor = True
        '
        'btnTakeShift
        '
        Me.btnTakeShift.Location = New System.Drawing.Point(737, 110)
        Me.btnTakeShift.Name = "btnTakeShift"
        Me.btnTakeShift.Size = New System.Drawing.Size(91, 28)
        Me.btnTakeShift.TabIndex = 4
        Me.btnTakeShift.Text = "Take Shift"
        Me.btnTakeShift.UseVisualStyleBackColor = True
        '
        'lstOpenShifts
        '
        Me.lstOpenShifts.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clmName, Me.clmDate, Me.clmStartTime, Me.clmEndTime, Me.clmLocation, Me.clmPermanent})
        Me.lstOpenShifts.FullRowSelect = True
        Me.lstOpenShifts.GridLines = True
        Me.lstOpenShifts.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstOpenShifts.Location = New System.Drawing.Point(75, 64)
        Me.lstOpenShifts.Name = "lstOpenShifts"
        Me.lstOpenShifts.Size = New System.Drawing.Size(580, 339)
        Me.lstOpenShifts.TabIndex = 5
        Me.lstOpenShifts.UseCompatibleStateImageBehavior = False
        Me.lstOpenShifts.View = System.Windows.Forms.View.Details
        '
        'clmName
        '
        Me.clmName.Text = "Name"
        Me.clmName.Width = 49
        '
        'clmDate
        '
        Me.clmDate.Text = "Date"
        Me.clmDate.Width = 41
        '
        'clmStartTime
        '
        Me.clmStartTime.Text = "Start Time"
        Me.clmStartTime.Width = 73
        '
        'clmEndTime
        '
        Me.clmEndTime.Text = "End Time"
        Me.clmEndTime.Width = 70
        '
        'clmLocation
        '
        Me.clmLocation.Text = "Location"
        Me.clmLocation.Width = 63
        '
        'clmPermanent
        '
        Me.clmPermanent.Text = "Permanent?"
        Me.clmPermanent.Width = 84
        '
        'frmOpenShifts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(840, 488)
        Me.Controls.Add(Me.lstOpenShifts)
        Me.Controls.Add(Me.btnTakeShift)
        Me.Controls.Add(Me.btnMyShifts)
        Me.Controls.Add(Me.btnLogOut)
        Me.Controls.Add(Me.lblOpenShifts)
        Me.Name = "frmOpenShifts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmOpenShifts"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblOpenShifts As Label
    Friend WithEvents btnLogOut As Button
    Friend WithEvents btnMyShifts As Button
    Friend WithEvents btnTakeShift As Button
    Friend WithEvents lstOpenShifts As ListView
    Friend WithEvents clmName As ColumnHeader
    Friend WithEvents clmDate As ColumnHeader
    Friend WithEvents clmStartTime As ColumnHeader
    Friend WithEvents clmEndTime As ColumnHeader
    Friend WithEvents clmLocation As ColumnHeader
    Friend WithEvents clmPermanent As ColumnHeader
End Class
