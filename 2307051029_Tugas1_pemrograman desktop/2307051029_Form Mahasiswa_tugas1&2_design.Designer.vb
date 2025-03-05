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
        Me.nip = New System.Windows.Forms.Label()
        Me.nama = New System.Windows.Forms.Label()
        Me.gender = New System.Windows.Forms.Label()
        Me.fakultas = New System.Windows.Forms.Label()
        Me.jurusan = New System.Windows.Forms.Label()
        Me.txtnip = New System.Windows.Forms.TextBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.rb1 = New System.Windows.Forms.RadioButton()
        Me.rb2 = New System.Windows.Forms.RadioButton()
        Me.cbofakultas = New System.Windows.Forms.ComboBox()
        Me.cbojurusan = New System.Windows.Forms.ComboBox()
        Me.btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'nip
        '
        Me.nip.AutoSize = True
        Me.nip.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nip.Location = New System.Drawing.Point(36, 22)
        Me.nip.Name = "nip"
        Me.nip.Size = New System.Drawing.Size(30, 16)
        Me.nip.TabIndex = 0
        Me.nip.Text = "NIP"
        '
        'nama
        '
        Me.nama.AutoSize = True
        Me.nama.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nama.Location = New System.Drawing.Point(36, 62)
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(45, 16)
        Me.nama.TabIndex = 1
        Me.nama.Text = "Nama"
        '
        'gender
        '
        Me.gender.AutoSize = True
        Me.gender.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gender.Location = New System.Drawing.Point(36, 114)
        Me.gender.Name = "gender"
        Me.gender.Size = New System.Drawing.Size(91, 16)
        Me.gender.TabIndex = 2
        Me.gender.Text = "Jenis Kelamin"
        '
        'fakultas
        '
        Me.fakultas.AutoSize = True
        Me.fakultas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fakultas.Location = New System.Drawing.Point(36, 160)
        Me.fakultas.Name = "fakultas"
        Me.fakultas.Size = New System.Drawing.Size(59, 16)
        Me.fakultas.TabIndex = 3
        Me.fakultas.Text = "Fakultas"
        '
        'jurusan
        '
        Me.jurusan.AutoSize = True
        Me.jurusan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jurusan.Location = New System.Drawing.Point(36, 200)
        Me.jurusan.Name = "jurusan"
        Me.jurusan.Size = New System.Drawing.Size(55, 16)
        Me.jurusan.TabIndex = 4
        Me.jurusan.Text = "Jurusan"
        '
        'txtnip
        '
        Me.txtnip.Location = New System.Drawing.Point(184, 22)
        Me.txtnip.Name = "txtnip"
        Me.txtnip.Size = New System.Drawing.Size(307, 20)
        Me.txtnip.TabIndex = 5
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(184, 62)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(458, 20)
        Me.txtnama.TabIndex = 6
        '
        'rb1
        '
        Me.rb1.AutoSize = True
        Me.rb1.Location = New System.Drawing.Point(184, 113)
        Me.rb1.Name = "rb1"
        Me.rb1.Size = New System.Drawing.Size(68, 17)
        Me.rb1.TabIndex = 7
        Me.rb1.TabStop = True
        Me.rb1.Text = "Laki-Laki"
        Me.rb1.UseVisualStyleBackColor = True
        '
        'rb2
        '
        Me.rb2.AutoSize = True
        Me.rb2.Location = New System.Drawing.Point(356, 114)
        Me.rb2.Name = "rb2"
        Me.rb2.Size = New System.Drawing.Size(79, 17)
        Me.rb2.TabIndex = 8
        Me.rb2.TabStop = True
        Me.rb2.Text = "Perempuan"
        Me.rb2.UseVisualStyleBackColor = True
        '
        'cbofakultas
        '
        Me.cbofakultas.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.cbofakultas.FormattingEnabled = True
        Me.cbofakultas.Items.AddRange(New Object() {"FMIPA", "FP", "FT", "FEB", "FKIP", "FK", "FISIP"})
        Me.cbofakultas.Location = New System.Drawing.Point(184, 160)
        Me.cbofakultas.Name = "cbofakultas"
        Me.cbofakultas.Size = New System.Drawing.Size(307, 21)
        Me.cbofakultas.TabIndex = 9
        '
        'cbojurusan
        '
        Me.cbojurusan.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.cbojurusan.FormattingEnabled = True
        Me.cbojurusan.Items.AddRange(New Object() {"ILMU KOMPUTER", "BIOLOGI", "BIOLOGI TERAPAN", "KIMIA", "FISIKA", "MANAJEMEN INFORMATIKA"})
        Me.cbojurusan.Location = New System.Drawing.Point(184, 200)
        Me.cbojurusan.Name = "cbojurusan"
        Me.cbojurusan.Size = New System.Drawing.Size(458, 21)
        Me.cbojurusan.TabIndex = 10
        '
        'btn
        '
        Me.btn.Location = New System.Drawing.Point(39, 247)
        Me.btn.Name = "btn"
        Me.btn.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btn.Size = New System.Drawing.Size(88, 31)
        Me.btn.TabIndex = 11
        Me.btn.Text = "Process"
        Me.btn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(677, 299)
        Me.Controls.Add(Me.btn)
        Me.Controls.Add(Me.cbojurusan)
        Me.Controls.Add(Me.cbofakultas)
        Me.Controls.Add(Me.rb2)
        Me.Controls.Add(Me.rb1)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.txtnip)
        Me.Controls.Add(Me.jurusan)
        Me.Controls.Add(Me.fakultas)
        Me.Controls.Add(Me.gender)
        Me.Controls.Add(Me.nama)
        Me.Controls.Add(Me.nip)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents nip As System.Windows.Forms.Label
    Friend WithEvents nama As System.Windows.Forms.Label
    Friend WithEvents gender As System.Windows.Forms.Label
    Friend WithEvents fakultas As System.Windows.Forms.Label
    Friend WithEvents jurusan As System.Windows.Forms.Label
    Friend WithEvents txtnip As System.Windows.Forms.TextBox
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents rb1 As System.Windows.Forms.RadioButton
    Friend WithEvents rb2 As System.Windows.Forms.RadioButton
    Friend WithEvents cbofakultas As System.Windows.Forms.ComboBox
    Friend WithEvents cbojurusan As System.Windows.Forms.ComboBox
    Friend WithEvents btn As System.Windows.Forms.Button

End Class
