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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.n = New System.Windows.Forms.TextBox()
        Me.na = New System.Windows.Forms.TextBox()
        Me.t = New System.Windows.Forms.TextBox()
        Me.k = New System.Windows.Forms.TextBox()
        Me.Insert = New System.Windows.Forms.Button()
        Me.Tampil = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.a = New System.Windows.Forms.TextBox()
        Me.aa = New System.Windows.Forms.TextBox()
        Me.tg = New System.Windows.Forms.DateTimePicker()
        Me.c = New System.Windows.Forms.TextBox()
        Me.cari = New System.Windows.Forms.Button()
        Me.hapus = New System.Windows.Forms.Button()
        Me.refresh = New System.Windows.Forms.Button()
        Me.edit = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NIS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kelas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tempatlahir = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tanggallahir = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Alamat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Alamatasal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.view = New System.Windows.Forms.Button()
        Me.pdf = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Minimal", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(231, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(261, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "BIODATA SISWA XIRPL4"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 14)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NIS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(12, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 14)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(12, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 14)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Kelas"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(12, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 14)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Tempat Lahir"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(12, 155)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 14)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Tanggal Lahir"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(12, 178)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 14)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Alamat"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(12, 233)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 14)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Alamat Asal"
        '
        'n
        '
        Me.n.Location = New System.Drawing.Point(111, 46)
        Me.n.Name = "n"
        Me.n.Size = New System.Drawing.Size(200, 20)
        Me.n.TabIndex = 1
        '
        'na
        '
        Me.na.Location = New System.Drawing.Point(111, 72)
        Me.na.Name = "na"
        Me.na.Size = New System.Drawing.Size(200, 20)
        Me.na.TabIndex = 2
        '
        't
        '
        Me.t.Location = New System.Drawing.Point(111, 124)
        Me.t.Name = "t"
        Me.t.Size = New System.Drawing.Size(200, 20)
        Me.t.TabIndex = 4
        '
        'k
        '
        Me.k.Location = New System.Drawing.Point(111, 98)
        Me.k.Name = "k"
        Me.k.Size = New System.Drawing.Size(200, 20)
        Me.k.TabIndex = 3
        '
        'Insert
        '
        Me.Insert.Location = New System.Drawing.Point(17, 293)
        Me.Insert.Name = "Insert"
        Me.Insert.Size = New System.Drawing.Size(75, 23)
        Me.Insert.TabIndex = 8
        Me.Insert.Text = "Insert"
        Me.Insert.UseVisualStyleBackColor = True
        '
        'Tampil
        '
        Me.Tampil.Location = New System.Drawing.Point(236, 293)
        Me.Tampil.Name = "Tampil"
        Me.Tampil.Size = New System.Drawing.Size(75, 23)
        Me.Tampil.TabIndex = 9
        Me.Tampil.Text = "Tampilkan"
        Me.Tampil.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(334, 46)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(371, 56)
        Me.ListBox1.TabIndex = 10
        '
        'a
        '
        Me.a.Location = New System.Drawing.Point(111, 176)
        Me.a.Multiline = True
        Me.a.Name = "a"
        Me.a.Size = New System.Drawing.Size(200, 49)
        Me.a.TabIndex = 6
        '
        'aa
        '
        Me.aa.Location = New System.Drawing.Point(111, 231)
        Me.aa.Multiline = True
        Me.aa.Name = "aa"
        Me.aa.Size = New System.Drawing.Size(200, 56)
        Me.aa.TabIndex = 7
        '
        'tg
        '
        Me.tg.Location = New System.Drawing.Point(111, 150)
        Me.tg.Name = "tg"
        Me.tg.Size = New System.Drawing.Size(200, 20)
        Me.tg.TabIndex = 5
        '
        'c
        '
        Me.c.Location = New System.Drawing.Point(334, 108)
        Me.c.Name = "c"
        Me.c.Size = New System.Drawing.Size(112, 20)
        Me.c.TabIndex = 11
        '
        'cari
        '
        Me.cari.Location = New System.Drawing.Point(452, 106)
        Me.cari.Name = "cari"
        Me.cari.Size = New System.Drawing.Size(66, 23)
        Me.cari.TabIndex = 12
        Me.cari.Text = "Cari"
        Me.cari.UseVisualStyleBackColor = True
        '
        'hapus
        '
        Me.hapus.Location = New System.Drawing.Point(611, 106)
        Me.hapus.Name = "hapus"
        Me.hapus.Size = New System.Drawing.Size(68, 23)
        Me.hapus.TabIndex = 13
        Me.hapus.Text = "Hapus"
        Me.hapus.UseVisualStyleBackColor = True
        '
        'refresh
        '
        Me.refresh.Location = New System.Drawing.Point(334, 135)
        Me.refresh.Name = "refresh"
        Me.refresh.Size = New System.Drawing.Size(371, 23)
        Me.refresh.TabIndex = 15
        Me.refresh.Text = "Refresh"
        Me.refresh.UseVisualStyleBackColor = True
        '
        'edit
        '
        Me.edit.Location = New System.Drawing.Point(532, 106)
        Me.edit.Name = "edit"
        Me.edit.Size = New System.Drawing.Size(66, 23)
        Me.edit.TabIndex = 16
        Me.edit.Text = "edit"
        Me.edit.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NIS, Me.nama, Me.kelas, Me.Tempatlahir, Me.Tanggallahir, Me.Alamat, Me.Alamatasal})
        Me.DataGridView1.Location = New System.Drawing.Point(334, 164)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(371, 123)
        Me.DataGridView1.TabIndex = 18
        '
        'NIS
        '
        Me.NIS.HeaderText = "NIS"
        Me.NIS.Name = "NIS"
        '
        'nama
        '
        Me.nama.HeaderText = "Nama"
        Me.nama.Name = "nama"
        '
        'kelas
        '
        Me.kelas.HeaderText = "Kelas"
        Me.kelas.Name = "kelas"
        '
        'Tempatlahir
        '
        Me.Tempatlahir.HeaderText = "Tempat Lahir"
        Me.Tempatlahir.Name = "Tempatlahir"
        '
        'Tanggallahir
        '
        Me.Tanggallahir.HeaderText = "Tanggal Lahir"
        Me.Tanggallahir.Name = "Tanggallahir"
        '
        'Alamat
        '
        Me.Alamat.HeaderText = "Alamat"
        Me.Alamat.Name = "Alamat"
        '
        'Alamatasal
        '
        Me.Alamatasal.HeaderText = "Alamat Asal"
        Me.Alamatasal.Name = "Alamatasal"
        '
        'view
        '
        Me.view.Location = New System.Drawing.Point(355, 293)
        Me.view.Name = "view"
        Me.view.Size = New System.Drawing.Size(75, 23)
        Me.view.TabIndex = 19
        Me.view.Text = "View"
        Me.view.UseVisualStyleBackColor = True
        '
        'pdf
        '
        Me.pdf.Location = New System.Drawing.Point(624, 293)
        Me.pdf.Name = "pdf"
        Me.pdf.Size = New System.Drawing.Size(75, 23)
        Me.pdf.TabIndex = 20
        Me.pdf.Text = "Export PDF"
        Me.pdf.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(711, 396)
        Me.Controls.Add(Me.pdf)
        Me.Controls.Add(Me.view)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.edit)
        Me.Controls.Add(Me.refresh)
        Me.Controls.Add(Me.hapus)
        Me.Controls.Add(Me.cari)
        Me.Controls.Add(Me.c)
        Me.Controls.Add(Me.tg)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Tampil)
        Me.Controls.Add(Me.Insert)
        Me.Controls.Add(Me.aa)
        Me.Controls.Add(Me.a)
        Me.Controls.Add(Me.k)
        Me.Controls.Add(Me.t)
        Me.Controls.Add(Me.na)
        Me.Controls.Add(Me.n)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents n As System.Windows.Forms.TextBox
    Friend WithEvents na As System.Windows.Forms.TextBox
    Friend WithEvents t As System.Windows.Forms.TextBox
    Friend WithEvents k As System.Windows.Forms.TextBox
    Friend WithEvents Insert As System.Windows.Forms.Button
    Friend WithEvents Tampil As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents a As System.Windows.Forms.TextBox
    Friend WithEvents aa As System.Windows.Forms.TextBox
    Friend WithEvents tg As System.Windows.Forms.DateTimePicker
    Friend WithEvents c As System.Windows.Forms.TextBox
    Friend WithEvents cari As System.Windows.Forms.Button
    Friend WithEvents hapus As System.Windows.Forms.Button
    Friend WithEvents refresh As System.Windows.Forms.Button
    Friend WithEvents edit As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents NIS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nama As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kelas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tempatlahir As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tanggallahir As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Alamat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Alamatasal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents view As System.Windows.Forms.Button
    Friend WithEvents pdf As System.Windows.Forms.Button

End Class
