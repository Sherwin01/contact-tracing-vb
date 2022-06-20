<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.addbtn = New System.Windows.Forms.Button()
        Me.lb1 = New System.Windows.Forms.ListBox()
        Me.FullName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.savebtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.clearbtn = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tb1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'addbtn
        '
        Me.addbtn.Location = New System.Drawing.Point(601, 75)
        Me.addbtn.Name = "addbtn"
        Me.addbtn.Size = New System.Drawing.Size(81, 24)
        Me.addbtn.TabIndex = 0
        Me.addbtn.Text = "Add"
        Me.addbtn.UseVisualStyleBackColor = True
        '
        'lb1
        '
        Me.lb1.FormattingEnabled = True
        Me.lb1.ItemHeight = 15
        Me.lb1.Location = New System.Drawing.Point(246, 135)
        Me.lb1.Name = "lb1"
        Me.lb1.Size = New System.Drawing.Size(316, 154)
        Me.lb1.TabIndex = 1
        '
        'FullName
        '
        Me.FullName.Location = New System.Drawing.Point(246, 32)
        Me.FullName.Name = "FullName"
        Me.FullName.Size = New System.Drawing.Size(316, 23)
        Me.FullName.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(177, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Full Name"
        '
        'savebtn
        '
        Me.savebtn.Location = New System.Drawing.Point(601, 221)
        Me.savebtn.Name = "savebtn"
        Me.savebtn.Size = New System.Drawing.Size(81, 23)
        Me.savebtn.TabIndex = 4
        Me.savebtn.Text = "Save"
        Me.savebtn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(125, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Fill up the following:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(210, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Age"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(189, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Birthday"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(193, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Gender"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(189, 180)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 15)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Address"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(144, 195)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 15)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Contact Number"
        '
        'clearbtn
        '
        Me.clearbtn.Location = New System.Drawing.Point(601, 250)
        Me.clearbtn.Name = "clearbtn"
        Me.clearbtn.Size = New System.Drawing.Size(81, 23)
        Me.clearbtn.TabIndex = 11
        Me.clearbtn.Text = "Clear"
        Me.clearbtn.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(179, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 15)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Type Here"
        '
        'tb1
        '
        Me.tb1.Location = New System.Drawing.Point(246, 76)
        Me.tb1.Name = "tb1"
        Me.tb1.Size = New System.Drawing.Size(316, 23)
        Me.tb1.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.tb1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.clearbtn)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.savebtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FullName)
        Me.Controls.Add(Me.lb1)
        Me.Controls.Add(Me.addbtn)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents addbtn As Button
    Friend WithEvents lb1 As ListBox
    Friend WithEvents FullName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents savebtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents clearbtn As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents tb1 As TextBox
End Class
