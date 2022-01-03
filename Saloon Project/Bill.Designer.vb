<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bill
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Bill))
        Me.ext = New System.Windows.Forms.Button()
        Me.clear = New System.Windows.Forms.Button()
        Me.addToBill = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.quntity = New System.Windows.Forms.ComboBox()
        Me.calculate = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Nme = New System.Windows.Forms.TextBox()
        Me.Price = New System.Windows.Forms.TextBox()
        Me.NetT = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Remain = New System.Windows.Forms.TextBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Balance = New System.Windows.Forms.Button()
        Me.s_ID = New System.Windows.Forms.TextBox()
        Me.Dte = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Print = New System.Windows.Forms.Button()
        Me.CosBill = New System.Windows.Forms.Button()
        Me.Cash = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ext
        '
        Me.ext.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ext.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ext.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ext.Location = New System.Drawing.Point(45, 553)
        Me.ext.Name = "ext"
        Me.ext.Size = New System.Drawing.Size(174, 41)
        Me.ext.TabIndex = 65
        Me.ext.Text = "Back"
        Me.ext.UseVisualStyleBackColor = False
        '
        'clear
        '
        Me.clear.BackColor = System.Drawing.Color.Red
        Me.clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear.Location = New System.Drawing.Point(45, 478)
        Me.clear.Name = "clear"
        Me.clear.Size = New System.Drawing.Size(174, 41)
        Me.clear.TabIndex = 64
        Me.clear.Text = "Clear"
        Me.clear.UseVisualStyleBackColor = False
        '
        'addToBill
        '
        Me.addToBill.BackColor = System.Drawing.Color.Lime
        Me.addToBill.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.addToBill.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addToBill.Location = New System.Drawing.Point(45, 303)
        Me.addToBill.Name = "addToBill"
        Me.addToBill.Size = New System.Drawing.Size(174, 41)
        Me.addToBill.TabIndex = 62
        Me.addToBill.Text = "Add to Bill"
        Me.addToBill.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Mistral", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(626, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(326, 76)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Bill Payment"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1326, 151)
        Me.Panel1.TabIndex = 57
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("MS PGothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(1279, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 33)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "X"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Elephant", 71.99999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label1.Location = New System.Drawing.Point(380, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(296, 123)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Liyo "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(314, 276)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 24)
        Me.Label7.TabIndex = 74
        Me.Label7.Text = "Quentity"
        '
        'quntity
        '
        Me.quntity.FormattingEnabled = True
        Me.quntity.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"})
        Me.quntity.Location = New System.Drawing.Point(446, 269)
        Me.quntity.Name = "quntity"
        Me.quntity.Size = New System.Drawing.Size(151, 21)
        Me.quntity.TabIndex = 75
        '
        'calculate
        '
        Me.calculate.BackColor = System.Drawing.Color.Yellow
        Me.calculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.calculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calculate.Location = New System.Drawing.Point(45, 219)
        Me.calculate.Name = "calculate"
        Me.calculate.Size = New System.Drawing.Size(174, 41)
        Me.calculate.TabIndex = 78
        Me.calculate.Text = "Calculate"
        Me.calculate.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(314, 220)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 24)
        Me.Label4.TabIndex = 80
        Me.Label4.Text = "Service ID"
        '
        'Nme
        '
        Me.Nme.Location = New System.Drawing.Point(449, 368)
        Me.Nme.Name = "Nme"
        Me.Nme.Size = New System.Drawing.Size(152, 20)
        Me.Nme.TabIndex = 81
        '
        'Price
        '
        Me.Price.Location = New System.Drawing.Point(445, 320)
        Me.Price.Name = "Price"
        Me.Price.Size = New System.Drawing.Size(152, 20)
        Me.Price.TabIndex = 82
        '
        'NetT
        '
        Me.NetT.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NetT.Location = New System.Drawing.Point(446, 414)
        Me.NetT.Multiline = True
        Me.NetT.Name = "NetT"
        Me.NetT.Size = New System.Drawing.Size(152, 37)
        Me.NetT.TabIndex = 84
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(320, 421)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 24)
        Me.Label8.TabIndex = 87
        Me.Label8.Text = "Net total"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(318, 368)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 24)
        Me.Label10.TabIndex = 89
        Me.Label10.Text = "Name"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(317, 320)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 24)
        Me.Label11.TabIndex = 90
        Me.Label11.Text = "Price"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(320, 566)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(111, 48)
        Me.Label12.TabIndex = 91
        Me.Label12.Text = "Remaning " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  Balance"
        '
        'Remain
        '
        Me.Remain.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Remain.Location = New System.Drawing.Point(445, 566)
        Me.Remain.Multiline = True
        Me.Remain.Name = "Remain"
        Me.Remain.Size = New System.Drawing.Size(152, 48)
        Me.Remain.TabIndex = 92
        Me.Remain.Text = " "
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.ListView1.Location = New System.Drawing.Point(710, 229)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(497, 313)
        Me.ListView1.TabIndex = 93
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Item/Service"
        Me.ColumnHeader1.Width = 106
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Quentity"
        Me.ColumnHeader2.Width = 84
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Price of one item/service"
        Me.ColumnHeader3.Width = 133
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Total Price"
        Me.ColumnHeader4.Width = 79
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Net Total"
        Me.ColumnHeader5.Width = 86
        '
        'Balance
        '
        Me.Balance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Balance.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Balance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Balance.Location = New System.Drawing.Point(45, 390)
        Me.Balance.Name = "Balance"
        Me.Balance.Size = New System.Drawing.Size(174, 41)
        Me.Balance.TabIndex = 95
        Me.Balance.Text = "Balance"
        Me.Balance.UseVisualStyleBackColor = False
        '
        's_ID
        '
        Me.s_ID.BackColor = System.Drawing.Color.White
        Me.s_ID.Location = New System.Drawing.Point(446, 219)
        Me.s_ID.Multiline = True
        Me.s_ID.Name = "s_ID"
        Me.s_ID.Size = New System.Drawing.Size(155, 25)
        Me.s_ID.TabIndex = 96
        '
        'Dte
        '
        Me.Dte.Location = New System.Drawing.Point(774, 194)
        Me.Dte.Name = "Dte"
        Me.Dte.Size = New System.Drawing.Size(124, 20)
        Me.Dte.TabIndex = 99
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(710, 194)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 24)
        Me.Label13.TabIndex = 100
        Me.Label13.Text = "Date "
        '
        'Print
        '
        Me.Print.BackColor = System.Drawing.Color.Maroon
        Me.Print.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Print.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Print.Location = New System.Drawing.Point(1000, 567)
        Me.Print.Name = "Print"
        Me.Print.Size = New System.Drawing.Size(189, 53)
        Me.Print.TabIndex = 102
        Me.Print.Text = "Print"
        Me.Print.UseVisualStyleBackColor = False
        '
        'CosBill
        '
        Me.CosBill.BackColor = System.Drawing.Color.Maroon
        Me.CosBill.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CosBill.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CosBill.Location = New System.Drawing.Point(727, 567)
        Me.CosBill.Name = "CosBill"
        Me.CosBill.Size = New System.Drawing.Size(189, 53)
        Me.CosBill.TabIndex = 103
        Me.CosBill.Text = "cos"
        Me.CosBill.UseVisualStyleBackColor = False
        '
        'Cash
        '
        Me.Cash.Location = New System.Drawing.Point(449, 519)
        Me.Cash.Name = "Cash"
        Me.Cash.Size = New System.Drawing.Size(152, 20)
        Me.Cash.TabIndex = 83
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(318, 519)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 24)
        Me.Label2.TabIndex = 86
        Me.Label2.Text = "Cash"
        '
        'Bill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1316, 681)
        Me.Controls.Add(Me.CosBill)
        Me.Controls.Add(Me.Print)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Dte)
        Me.Controls.Add(Me.s_ID)
        Me.Controls.Add(Me.Balance)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Remain)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NetT)
        Me.Controls.Add(Me.Cash)
        Me.Controls.Add(Me.Price)
        Me.Controls.Add(Me.Nme)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.calculate)
        Me.Controls.Add(Me.quntity)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ext)
        Me.Controls.Add(Me.clear)
        Me.Controls.Add(Me.addToBill)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Bill"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bill"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ext As System.Windows.Forms.Button
    Friend WithEvents clear As System.Windows.Forms.Button
    Friend WithEvents addToBill As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents quntity As System.Windows.Forms.ComboBox
    Friend WithEvents calculate As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Nme As System.Windows.Forms.TextBox
    Friend WithEvents Price As System.Windows.Forms.TextBox
    Friend WithEvents NetT As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Remain As System.Windows.Forms.TextBox
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents Balance As System.Windows.Forms.Button
    Friend WithEvents s_ID As System.Windows.Forms.TextBox
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Dte As System.Windows.Forms.TextBox
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Print As System.Windows.Forms.Button
    Friend WithEvents CosBill As System.Windows.Forms.Button
    Friend WithEvents Cash As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
