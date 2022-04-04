<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtNo2 = New System.Windows.Forms.TextBox()
        Me.txtNo1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AddBtn = New System.Windows.Forms.Button()
        Me.SubBtn = New System.Windows.Forms.Button()
        Me.MulBtn = New System.Windows.Forms.Button()
        Me.DivBtn = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.BackBtn = New System.Windows.Forms.Button()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Stencil", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(84, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MINI CALCULATOR"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtNo2)
        Me.GroupBox1.Controls.Add(Me.txtNo1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 98)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(333, 100)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Enter Number"
        '
        'txtNo2
        '
        Me.txtNo2.Location = New System.Drawing.Point(136, 61)
        Me.txtNo2.Name = "txtNo2"
        Me.txtNo2.Size = New System.Drawing.Size(100, 23)
        Me.txtNo2.TabIndex = 5
        '
        'txtNo1
        '
        Me.txtNo1.Location = New System.Drawing.Point(136, 22)
        Me.txtNo1.Name = "txtNo1"
        Me.txtNo1.Size = New System.Drawing.Size(100, 23)
        Me.txtNo1.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(30, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 19)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Number 2 :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(30, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Number 1 :"
        '
        'AddBtn
        '
        Me.AddBtn.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.AddBtn.Location = New System.Drawing.Point(56, 220)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(45, 45)
        Me.AddBtn.TabIndex = 2
        Me.AddBtn.Text = "+"
        Me.AddBtn.UseVisualStyleBackColor = True
        '
        'SubBtn
        '
        Me.SubBtn.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.SubBtn.Location = New System.Drawing.Point(131, 220)
        Me.SubBtn.Name = "SubBtn"
        Me.SubBtn.Size = New System.Drawing.Size(45, 45)
        Me.SubBtn.TabIndex = 3
        Me.SubBtn.Text = "-"
        Me.SubBtn.UseVisualStyleBackColor = True
        '
        'MulBtn
        '
        Me.MulBtn.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MulBtn.Location = New System.Drawing.Point(217, 220)
        Me.MulBtn.Name = "MulBtn"
        Me.MulBtn.Size = New System.Drawing.Size(45, 45)
        Me.MulBtn.TabIndex = 4
        Me.MulBtn.Text = "x"
        Me.MulBtn.UseVisualStyleBackColor = True
        '
        'DivBtn
        '
        Me.DivBtn.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DivBtn.Location = New System.Drawing.Point(290, 220)
        Me.DivBtn.Name = "DivBtn"
        Me.DivBtn.Size = New System.Drawing.Size(45, 45)
        Me.DivBtn.TabIndex = 5
        Me.DivBtn.Text = "/"
        Me.DivBtn.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(56, 268)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Addition"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(115, 268)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 15)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Subtraction"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(203, 268)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 15)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Multiplication"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(290, 268)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 15)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Division"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Stencil", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(151, 332)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 22)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "ANSWER"
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(131, 357)
        Me.txtResult.Multiline = True
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(131, 36)
        Me.txtResult.TabIndex = 11
        '
        'BackBtn
        '
        Me.BackBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackBtn.Font = New System.Drawing.Font("Stencil", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BackBtn.ForeColor = System.Drawing.Color.Brown
        Me.BackBtn.Location = New System.Drawing.Point(105, 419)
        Me.BackBtn.Name = "BackBtn"
        Me.BackBtn.Size = New System.Drawing.Size(78, 33)
        Me.BackBtn.TabIndex = 12
        Me.BackBtn.Text = "BACK"
        Me.BackBtn.UseVisualStyleBackColor = False
        '
        'ExitBtn
        '
        Me.ExitBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExitBtn.Font = New System.Drawing.Font("Stencil", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ExitBtn.ForeColor = System.Drawing.Color.Brown
        Me.ExitBtn.Location = New System.Drawing.Point(203, 419)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(78, 33)
        Me.ExitBtn.TabIndex = 13
        Me.ExitBtn.Text = "EXIT"
        Me.ExitBtn.UseVisualStyleBackColor = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(392, 484)
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.BackBtn)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DivBtn)
        Me.Controls.Add(Me.MulBtn)
        Me.Controls.Add(Me.SubBtn)
        Me.Controls.Add(Me.AddBtn)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form3"
        Me.Text = "Count Me"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtNo2 As TextBox
    Friend WithEvents txtNo1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents AddBtn As Button
    Friend WithEvents SubBtn As Button
    Friend WithEvents MulBtn As Button
    Friend WithEvents DivBtn As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtResult As TextBox
    Friend WithEvents BackBtn As Button
    Friend WithEvents ExitBtn As Button
End Class
