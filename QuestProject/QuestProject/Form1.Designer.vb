<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtQuest = New System.Windows.Forms.TextBox()
        Me.txtColor = New System.Windows.Forms.TextBox()
        Me.lblQ1Answer = New System.Windows.Forms.Label()
        Me.lblQ2Answer = New System.Windows.Forms.Label()
        Me.lblQ3Answer = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(259, 154)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(100, 23)
        Me.btnSubmit.TabIndex = 0
        Me.btnSubmit.Text = "Submit answers"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(76, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "What is your name?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(258, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "What is your quest?"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(431, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "What is your favorite color?"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(79, 92)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(98, 20)
        Me.txtName.TabIndex = 4
        '
        'txtQuest
        '
        Me.txtQuest.Location = New System.Drawing.Point(259, 92)
        Me.txtQuest.Name = "txtQuest"
        Me.txtQuest.Size = New System.Drawing.Size(100, 20)
        Me.txtQuest.TabIndex = 5
        '
        'txtColor
        '
        Me.txtColor.Location = New System.Drawing.Point(434, 92)
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(100, 20)
        Me.txtColor.TabIndex = 6
        '
        'lblQ1Answer
        '
        Me.lblQ1Answer.AutoSize = True
        Me.lblQ1Answer.Location = New System.Drawing.Point(76, 218)
        Me.lblQ1Answer.Name = "lblQ1Answer"
        Me.lblQ1Answer.Size = New System.Drawing.Size(0, 13)
        Me.lblQ1Answer.TabIndex = 7
        '
        'lblQ2Answer
        '
        Me.lblQ2Answer.AutoSize = True
        Me.lblQ2Answer.Location = New System.Drawing.Point(271, 218)
        Me.lblQ2Answer.Name = "lblQ2Answer"
        Me.lblQ2Answer.Size = New System.Drawing.Size(0, 13)
        Me.lblQ2Answer.TabIndex = 8
        '
        'lblQ3Answer
        '
        Me.lblQ3Answer.AutoSize = True
        Me.lblQ3Answer.Location = New System.Drawing.Point(431, 218)
        Me.lblQ3Answer.Name = "lblQ3Answer"
        Me.lblQ3Answer.Size = New System.Drawing.Size(0, 13)
        Me.lblQ3Answer.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(735, 473)
        Me.Controls.Add(Me.lblQ3Answer)
        Me.Controls.Add(Me.lblQ2Answer)
        Me.Controls.Add(Me.lblQ1Answer)
        Me.Controls.Add(Me.txtColor)
        Me.Controls.Add(Me.txtQuest)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSubmit)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtQuest As System.Windows.Forms.TextBox
    Friend WithEvents txtColor As System.Windows.Forms.TextBox
    Friend WithEvents lblQ1Answer As System.Windows.Forms.Label
    Friend WithEvents lblQ2Answer As System.Windows.Forms.Label
    Friend WithEvents lblQ3Answer As System.Windows.Forms.Label

End Class
