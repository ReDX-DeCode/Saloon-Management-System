<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Newlogin
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Newlogin))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Strt = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Ext = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(0, 37)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(658, 360)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(234, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "SalooN Liyo"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1300
        '
        'Strt
        '
        Me.Strt.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Strt.BackColor = System.Drawing.Color.Transparent
        Me.Strt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Strt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Strt.Font = New System.Drawing.Font("Old English Text MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Strt.ForeColor = System.Drawing.Color.Lime
        Me.Strt.Image = CType(resources.GetObject("Strt.Image"), System.Drawing.Image)
        Me.Strt.Location = New System.Drawing.Point(12, 8)
        Me.Strt.Name = "Strt"
        Me.Strt.Size = New System.Drawing.Size(61, 23)
        Me.Strt.TabIndex = 5
        Me.Strt.Text = "Start"
        Me.Strt.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Aqua
        Me.Label2.Location = New System.Drawing.Point(205, 400)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(240, 29)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Powered By  RedX"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.ProgressBar1.ForeColor = System.Drawing.Color.Maroon
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 387)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(658, 10)
        Me.ProgressBar1.TabIndex = 4
        '
        'Timer2
        '
        Me.Timer2.Interval = 35
        '
        'Ext
        '
        Me.Ext.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Ext.BackColor = System.Drawing.Color.Transparent
        Me.Ext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Ext.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Ext.Font = New System.Drawing.Font("Old English Text MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ext.ForeColor = System.Drawing.Color.Lime
        Me.Ext.Image = CType(resources.GetObject("Ext.Image"), System.Drawing.Image)
        Me.Ext.Location = New System.Drawing.Point(585, 8)
        Me.Ext.Name = "Ext"
        Me.Ext.Size = New System.Drawing.Size(61, 23)
        Me.Ext.TabIndex = 7
        Me.Ext.Text = "Exit"
        Me.Ext.UseVisualStyleBackColor = False
        '
        'Newlogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(658, 433)
        Me.Controls.Add(Me.Ext)
        Me.Controls.Add(Me.Strt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Newlogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "pic"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Strt As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Ext As System.Windows.Forms.Button
End Class
