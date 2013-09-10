<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.FontCode = New System.Windows.Forms.TextBox()
        Me.TextLine1 = New System.Windows.Forms.TextBox()
        Me.TextLine2 = New System.Windows.Forms.TextBox()
        Me.TextLine3 = New System.Windows.Forms.TextBox()
        Me.FinishedButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NextButton = New System.Windows.Forms.Button()
        Me.CurrentOutput = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.EnvelopeName = New System.Windows.Forms.TextBox()
        Me.JobTypeSelect = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'FontCode
        '
        Me.FontCode.Location = New System.Drawing.Point(120, 259)
        Me.FontCode.Name = "FontCode"
        Me.FontCode.Size = New System.Drawing.Size(155, 20)
        Me.FontCode.TabIndex = 1
        '
        'TextLine1
        '
        Me.TextLine1.Location = New System.Drawing.Point(120, 285)
        Me.TextLine1.Name = "TextLine1"
        Me.TextLine1.Size = New System.Drawing.Size(155, 20)
        Me.TextLine1.TabIndex = 2
        '
        'TextLine2
        '
        Me.TextLine2.Location = New System.Drawing.Point(120, 311)
        Me.TextLine2.Name = "TextLine2"
        Me.TextLine2.Size = New System.Drawing.Size(155, 20)
        Me.TextLine2.TabIndex = 3
        '
        'TextLine3
        '
        Me.TextLine3.Location = New System.Drawing.Point(120, 337)
        Me.TextLine3.Name = "TextLine3"
        Me.TextLine3.Size = New System.Drawing.Size(155, 20)
        Me.TextLine3.TabIndex = 4
        '
        'FinishedButton
        '
        Me.FinishedButton.Location = New System.Drawing.Point(14, 570)
        Me.FinishedButton.Name = "FinishedButton"
        Me.FinishedButton.Size = New System.Drawing.Size(75, 23)
        Me.FinishedButton.TabIndex = 6
        Me.FinishedButton.Text = "Finished"
        Me.FinishedButton.UseVisualStyleBackColor = True
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(197, 570)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelButton.TabIndex = 7
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 262)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Font Code (optional)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 288)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Text Line 1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 314)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Text Line 2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 340)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Text Line 3"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(239, 104)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = resources.GetString("Label5.Text")
        '
        'NextButton
        '
        Me.NextButton.Location = New System.Drawing.Point(120, 374)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(155, 23)
        Me.NextButton.TabIndex = 5
        Me.NextButton.Text = "Add Another"
        Me.NextButton.UseVisualStyleBackColor = True
        '
        'CurrentOutput
        '
        Me.CurrentOutput.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.CurrentOutput.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.CurrentOutput.Enabled = False
        Me.CurrentOutput.Location = New System.Drawing.Point(282, 13)
        Me.CurrentOutput.Multiline = True
        Me.CurrentOutput.Name = "CurrentOutput"
        Me.CurrentOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.CurrentOutput.Size = New System.Drawing.Size(237, 580)
        Me.CurrentOutput.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 233)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Envelope Name"
        '
        'EnvelopeName
        '
        Me.EnvelopeName.Location = New System.Drawing.Point(120, 230)
        Me.EnvelopeName.Name = "EnvelopeName"
        Me.EnvelopeName.Size = New System.Drawing.Size(155, 20)
        Me.EnvelopeName.TabIndex = 0
        '
        'JobTypeSelect
        '
        Me.JobTypeSelect.FormattingEnabled = True
        Me.JobTypeSelect.Location = New System.Drawing.Point(120, 163)
        Me.JobTypeSelect.Name = "JobTypeSelect"
        Me.JobTypeSelect.Size = New System.Drawing.Size(121, 21)
        Me.JobTypeSelect.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 170)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Job Type"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 605)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.JobTypeSelect)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.EnvelopeName)
        Me.Controls.Add(Me.CurrentOutput)
        Me.Controls.Add(Me.NextButton)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.FinishedButton)
        Me.Controls.Add(Me.TextLine3)
        Me.Controls.Add(Me.TextLine2)
        Me.Controls.Add(Me.TextLine1)
        Me.Controls.Add(Me.FontCode)
        Me.Name = "MainForm"
        Me.Text = "Create StripIns"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FontCode As System.Windows.Forms.TextBox
    Friend WithEvents TextLine1 As System.Windows.Forms.TextBox
    Friend WithEvents TextLine2 As System.Windows.Forms.TextBox
    Friend WithEvents TextLine3 As System.Windows.Forms.TextBox
    Friend WithEvents FinishedButton As System.Windows.Forms.Button
    Friend WithEvents CancelButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents NextButton As System.Windows.Forms.Button
    Friend WithEvents CurrentOutput As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents EnvelopeName As System.Windows.Forms.TextBox
    Friend WithEvents JobTypeSelect As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label

End Class
