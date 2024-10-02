<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Splash
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
        Me.components = New System.ComponentModel.Container()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Myprogressbar = New CircularProgressBar.CircularProgressBar()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(290, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(278, 46)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "PharmaCenter"
        '
        'Myprogressbar
        '
        Me.Myprogressbar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
        Me.Myprogressbar.AnimationSpeed = 500
        Me.Myprogressbar.BackColor = System.Drawing.Color.Transparent
        Me.Myprogressbar.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold)
        Me.Myprogressbar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Myprogressbar.InnerColor = System.Drawing.Color.Transparent
        Me.Myprogressbar.InnerMargin = 2
        Me.Myprogressbar.InnerWidth = -1
        Me.Myprogressbar.Location = New System.Drawing.Point(325, 67)
        Me.Myprogressbar.MarqueeAnimationSpeed = 2000
        Me.Myprogressbar.Name = "Myprogressbar"
        Me.Myprogressbar.OuterColor = System.Drawing.Color.Magenta
        Me.Myprogressbar.OuterMargin = -25
        Me.Myprogressbar.OuterWidth = 26
        Me.Myprogressbar.ProgressColor = System.Drawing.Color.DarkMagenta
        Me.Myprogressbar.ProgressWidth = 25
        Me.Myprogressbar.SecondaryFont = New System.Drawing.Font("Microsoft Sans Serif", 36.0!)
        Me.Myprogressbar.Size = New System.Drawing.Size(201, 199)
        Me.Myprogressbar.StartAngle = 270
        Me.Myprogressbar.SubscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Myprogressbar.SubscriptMargin = New System.Windows.Forms.Padding(10, -35, 0, 0)
        Me.Myprogressbar.SubscriptText = ""
        Me.Myprogressbar.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Myprogressbar.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
        Me.Myprogressbar.SuperscriptText = ""
        Me.Myprogressbar.TabIndex = 2
        Me.Myprogressbar.TextMargin = New System.Windows.Forms.Padding(8, 8, 0, 0)
        Me.Myprogressbar.Value = 68
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 272)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(838, 55)
        Me.Panel1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(247, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(364, 32)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "PoweredByTheGovernment"
        '
        'Timer1
        '
        '
        'Splash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOrchid
        Me.ClientSize = New System.Drawing.Size(838, 327)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Myprogressbar)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Splash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Myprogressbar As CircularProgressBar.CircularProgressBar
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
End Class
