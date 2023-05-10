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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.username = New System.Windows.Forms.TextBox()
        Me.password = New System.Windows.Forms.TextBox()
        Me.login = New System.Windows.Forms.Button()
        Me.signup = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(465, 200)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(465, 271)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password:"
        '
        'username
        '
        Me.username.Location = New System.Drawing.Point(468, 228)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(194, 22)
        Me.username.TabIndex = 2
        '
        'password
        '
        Me.password.Location = New System.Drawing.Point(468, 299)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(194, 22)
        Me.password.TabIndex = 3
        '
        'login
        '
        Me.login.BackColor = System.Drawing.SystemColors.Highlight
        Me.login.FlatAppearance.BorderSize = 0
        Me.login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.login.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.login.ForeColor = System.Drawing.SystemColors.Window
        Me.login.Location = New System.Drawing.Point(569, 347)
        Me.login.Name = "login"
        Me.login.Size = New System.Drawing.Size(93, 32)
        Me.login.TabIndex = 4
        Me.login.Text = "Login"
        Me.login.UseVisualStyleBackColor = False
        '
        'signup
        '
        Me.signup.BackColor = System.Drawing.SystemColors.MenuBar
        Me.signup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.signup.FlatAppearance.BorderSize = 0
        Me.signup.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.signup.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.signup.ForeColor = System.Drawing.SystemColors.ControlText
        Me.signup.Location = New System.Drawing.Point(468, 347)
        Me.signup.Name = "signup"
        Me.signup.Size = New System.Drawing.Size(95, 32)
        Me.signup.TabIndex = 5
        Me.signup.Text = "Signup"
        Me.signup.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.LABINI_EDP_Acttivity6.My.Resources.Resources.FOODERIA
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(724, 422)
        Me.Controls.Add(Me.signup)
        Me.Controls.Add(Me.login)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.username)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents username As TextBox
    Friend WithEvents password As TextBox
    Friend WithEvents login As Button
    Friend WithEvents signup As Button
End Class
