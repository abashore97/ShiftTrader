<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMyShifts
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
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.btnAddShift = New System.Windows.Forms.Button()
        Me.btnEditShift = New System.Windows.Forms.Button()
        Me.btnDeleteShift = New System.Windows.Forms.Button()
        Me.btnOpenShifts = New System.Windows.Forms.Button()
        Me.lstMyShifts = New System.Windows.Forms.ListView()
        Me.clmName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmStartTime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmEndTime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmLocation = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmPermanent = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblMyShifts = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnLogOut
        '
        Me.btnLogOut.Location = New System.Drawing.Point(737, 448)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(91, 28)
        Me.btnLogOut.TabIndex = 0
        Me.btnLogOut.Text = "Log Out"
        Me.btnLogOut.UseVisualStyleBackColor = True
        '
        'btnAddShift
        '
        Me.btnAddShift.Location = New System.Drawing.Point(737, 140)
        Me.btnAddShift.Name = "btnAddShift"
        Me.btnAddShift.Size = New System.Drawing.Size(91, 28)
        Me.btnAddShift.TabIndex = 1
        Me.btnAddShift.Text = "Add Shift"
        Me.btnAddShift.UseVisualStyleBackColor = True
        '
        'btnEditShift
        '
        Me.btnEditShift.Location = New System.Drawing.Point(737, 174)
        Me.btnEditShift.Name = "btnEditShift"
        Me.btnEditShift.Size = New System.Drawing.Size(91, 28)
        Me.btnEditShift.TabIndex = 2
        Me.btnEditShift.Text = "Edit Shift"
        Me.btnEditShift.UseVisualStyleBackColor = True
        '
        'btnDeleteShift
        '
        Me.btnDeleteShift.Location = New System.Drawing.Point(737, 208)
        Me.btnDeleteShift.Name = "btnDeleteShift"
        Me.btnDeleteShift.Size = New System.Drawing.Size(91, 28)
        Me.btnDeleteShift.TabIndex = 3
        Me.btnDeleteShift.Text = "Delete Shift"
        Me.btnDeleteShift.UseVisualStyleBackColor = True
        '
        'btnOpenShifts
        '
        Me.btnOpenShifts.Location = New System.Drawing.Point(737, 64)
        Me.btnOpenShifts.Name = "btnOpenShifts"
        Me.btnOpenShifts.Size = New System.Drawing.Size(91, 28)
        Me.btnOpenShifts.TabIndex = 4
        Me.btnOpenShifts.Text = "Open Shifts"
        Me.btnOpenShifts.UseVisualStyleBackColor = True
        '
        'lstMyShifts
        '
        Me.lstMyShifts.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clmName, Me.clmDate, Me.clmStartTime, Me.clmEndTime, Me.clmLocation, Me.clmPermanent})
        Me.lstMyShifts.FullRowSelect = True
        Me.lstMyShifts.GridLines = True
        Me.lstMyShifts.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstMyShifts.Location = New System.Drawing.Point(75, 64)
        Me.lstMyShifts.MultiSelect = False
        Me.lstMyShifts.Name = "lstMyShifts"
        Me.lstMyShifts.Size = New System.Drawing.Size(585, 339)
        Me.lstMyShifts.TabIndex = 6
        Me.lstMyShifts.UseCompatibleStateImageBehavior = False
        Me.lstMyShifts.View = System.Windows.Forms.View.Details
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
        'lblMyShifts
        '
        Me.lblMyShifts.AutoSize = True
        Me.lblMyShifts.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMyShifts.Location = New System.Drawing.Point(70, 20)
        Me.lblMyShifts.Name = "lblMyShifts"
        Me.lblMyShifts.Size = New System.Drawing.Size(99, 25)
        Me.lblMyShifts.TabIndex = 7
        Me.lblMyShifts.Text = "My Shifts:"
        '
        'frmMyShifts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(840, 488)
        Me.Controls.Add(Me.lblMyShifts)
        Me.Controls.Add(Me.lstMyShifts)
        Me.Controls.Add(Me.btnOpenShifts)
        Me.Controls.Add(Me.btnDeleteShift)
        Me.Controls.Add(Me.btnEditShift)
        Me.Controls.Add(Me.btnAddShift)
        Me.Controls.Add(Me.btnLogOut)
        Me.Name = "frmMyShifts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMyShifts"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLogOut As Button
    Friend WithEvents btnAddShift As Button
    Friend WithEvents btnEditShift As Button
    Friend WithEvents btnDeleteShift As Button
    Friend WithEvents btnOpenShifts As Button
    Friend WithEvents lstMyShifts As ListView
    Friend WithEvents clmName As ColumnHeader
    Friend WithEvents clmDate As ColumnHeader
    Friend WithEvents clmStartTime As ColumnHeader
    Friend WithEvents clmEndTime As ColumnHeader
    Friend WithEvents clmLocation As ColumnHeader
    Friend WithEvents clmPermanent As ColumnHeader
    Friend WithEvents lblMyShifts As Label
End Class
