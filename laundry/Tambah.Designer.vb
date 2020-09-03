<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tambah
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
        Me.inpNama = New System.Windows.Forms.TextBox()
        Me.inpAlamat = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl = New System.Windows.Forms.Label()
        Me.inpKategori = New System.Windows.Forms.ComboBox()
        Me.inpBerat = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.inpTotal = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.id = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama"
        '
        'inpNama
        '
        Me.inpNama.Location = New System.Drawing.Point(74, 45)
        Me.inpNama.Name = "inpNama"
        Me.inpNama.Size = New System.Drawing.Size(271, 20)
        Me.inpNama.TabIndex = 1
        '
        'inpAlamat
        '
        Me.inpAlamat.Location = New System.Drawing.Point(74, 94)
        Me.inpAlamat.Name = "inpAlamat"
        Me.inpAlamat.Size = New System.Drawing.Size(271, 20)
        Me.inpAlamat.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Alamat"
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Location = New System.Drawing.Point(12, 152)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(46, 13)
        Me.lbl.TabIndex = 4
        Me.lbl.Text = "Kategori"
        '
        'inpKategori
        '
        Me.inpKategori.FormattingEnabled = True
        Me.inpKategori.Location = New System.Drawing.Point(74, 144)
        Me.inpKategori.Name = "inpKategori"
        Me.inpKategori.Size = New System.Drawing.Size(271, 21)
        Me.inpKategori.TabIndex = 5
        '
        'inpBerat
        '
        Me.inpBerat.Location = New System.Drawing.Point(74, 197)
        Me.inpBerat.Name = "inpBerat"
        Me.inpBerat.Size = New System.Drawing.Size(271, 20)
        Me.inpBerat.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Berat"
        '
        'inpTotal
        '
        Me.inpTotal.AutoSize = True
        Me.inpTotal.Location = New System.Drawing.Point(33, 244)
        Me.inpTotal.Name = "inpTotal"
        Me.inpTotal.Size = New System.Drawing.Size(27, 13)
        Me.inpTotal.TabIndex = 8
        Me.inpTotal.Text = "total"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(143, 244)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Tambah"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(254, 244)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Update"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(370, 239)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'id
        '
        Me.id.AutoSize = True
        Me.id.Location = New System.Drawing.Point(29, 18)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(15, 13)
        Me.id.TabIndex = 12
        Me.id.Text = "id"
        '
        'Tambah
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(457, 315)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.inpTotal)
        Me.Controls.Add(Me.inpBerat)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.inpKategori)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.inpAlamat)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.inpNama)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Tambah"
        Me.Text = "Tambah"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents inpNama As System.Windows.Forms.TextBox
    Friend WithEvents inpAlamat As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl As System.Windows.Forms.Label
    Friend WithEvents inpKategori As System.Windows.Forms.ComboBox
    Friend WithEvents inpBerat As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents inpTotal As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents id As System.Windows.Forms.Label
End Class
