<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddEditShift
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblLoggedOn = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblStartTime = New System.Windows.Forms.Label()
        Me.lblEndTime = New System.Windows.Forms.Label()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.cboStartTime = New System.Windows.Forms.ComboBox()
        Me.cboEndTime = New System.Windows.Forms.ComboBox()
        Me.cboLocation = New System.Windows.Forms.ComboBox()
        Me.chkPermanent = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(37, 38)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(58, 20)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name:"
        '
        'lblLoggedOn
        '
        Me.lblLoggedOn.AutoSize = True
        Me.lblLoggedOn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoggedOn.Location = New System.Drawing.Point(101, 38)
        Me.lblLoggedOn.Name = "lblLoggedOn"
        Me.lblLoggedOn.Size = New System.Drawing.Size(9, 20)
        Me.lblLoggedOn.TabIndex = 1
        Me.lblLoggedOn.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(37, 88)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(50, 20)
        Me.lblDate.TabIndex = 2
        Me.lblDate.Text = "Date:"
        '
        'lblStartTime
        '
        Me.lblStartTime.AutoSize = True
        Me.lblStartTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStartTime.Location = New System.Drawing.Point(36, 139)
        Me.lblStartTime.Name = "lblStartTime"
        Me.lblStartTime.Size = New System.Drawing.Size(92, 20)
        Me.lblStartTime.TabIndex = 3
        Me.lblStartTime.Text = "Start Time:"
        '
        'lblEndTime
        '
        Me.lblEndTime.AutoSize = True
        Me.lblEndTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEndTime.Location = New System.Drawing.Point(223, 139)
        Me.lblEndTime.Name = "lblEndTime"
        Me.lblEndTime.Size = New System.Drawing.Size(85, 20)
        Me.lblEndTime.TabIndex = 4
        Me.lblEndTime.Text = "End Time:"
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocation.Location = New System.Drawing.Point(37, 196)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(78, 20)
        Me.lblLocation.TabIndex = 5
        Me.lblLocation.Text = "Location:"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(313, 293)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(91, 28)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(410, 293)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(91, 28)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'dtpDate
        '
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(93, 88)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(106, 22)
        Me.dtpDate.TabIndex = 9
        '
        'cboStartTime
        '
        Me.cboStartTime.FormattingEnabled = True
        Me.cboStartTime.Items.AddRange(New Object() {"1am", "4am", "7am", "9am", "11am", "1pm", "3pm", "5pm", "7pm", "9pm", "11pm"})
        Me.cboStartTime.Location = New System.Drawing.Point(134, 139)
        Me.cboStartTime.Name = "cboStartTime"
        Me.cboStartTime.Size = New System.Drawing.Size(65, 24)
        Me.cboStartTime.TabIndex = 10
        '
        'cboEndTime
        '
        Me.cboEndTime.FormattingEnabled = True
        Me.cboEndTime.Items.AddRange(New Object() {"1am", "4am", "7am", "9am", "11am", "1pm", "3pm", "5pm", "7pm", "9pm", "11pm"})
        Me.cboEndTime.Location = New System.Drawing.Point(314, 139)
        Me.cboEndTime.Name = "cboEndTime"
        Me.cboEndTime.Size = New System.Drawing.Size(65, 24)
        Me.cboEndTime.TabIndex = 11
        '
        'cboLocation
        '
        Me.cboLocation.FormattingEnabled = True
        Me.cboLocation.Items.AddRange(New Object() {"Apartments", "Halls", "JMAC", "Nelson", "Nagel", "Towers"})
        Me.cboLocation.Location = New System.Drawing.Point(121, 196)
        Me.cboLocation.MaxDropDownItems = 6
        Me.cboLocation.Name = "cboLocation"
        Me.cboLocation.Size = New System.Drawing.Size(121, 24)
        Me.cboLocation.TabIndex = 12
        '
        'chkPermanent
        '
        Me.chkPermanent.AutoSize = True
        Me.chkPermanent.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPermanent.Location = New System.Drawing.Point(40, 253)
        Me.chkPermanent.Name = "chkPermanent"
        Me.chkPermanent.Size = New System.Drawing.Size(160, 24)
        Me.chkPermanent.TabIndex = 13
        Me.chkPermanent.Text = "Permanent Trade"
        Me.chkPermanent.UseVisualStyleBackColor = True
        '
        'frmAddEditShift
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 333)
        Me.Controls.Add(Me.chkPermanent)
        Me.Controls.Add(Me.cboLocation)
        Me.Controls.Add(Me.cboEndTime)
        Me.Controls.Add(Me.cboStartTime)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblLocation)
        Me.Controls.Add(Me.lblEndTime)
        Me.Controls.Add(Me.lblStartTime)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblLoggedOn)
        Me.Controls.Add(Me.lblName)
        Me.Name = "frmAddEditShift"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add/Edit A Shift"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblLoggedOn As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblStartTime As Label
    Friend WithEvents lblEndTime As Label
    Friend WithEvents lblLocation As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents cboStartTime As ComboBox
    Friend WithEvents cboEndTime As ComboBox
    Friend WithEvents cboLocation As ComboBox
    Friend WithEvents chkPermanent As CheckBox
End Class
