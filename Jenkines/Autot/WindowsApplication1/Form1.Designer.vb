<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Autot
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
        Me.Auto_lista = New System.Windows.Forms.DataGridView()
        Me.MerkkiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MalliDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VuosimalliDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReknroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VariDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AutotBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Auto_db = New WindowsApplication1.Auto_db()
        Me.AutotTableAdapter = New WindowsApplication1.Auto_dbTableAdapters.AutotTableAdapter()
        Me.Malli_box = New System.Windows.Forms.TextBox()
        Me.Vmalli_box = New System.Windows.Forms.TextBox()
        Me.Reksiterinro_box = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Merkki_box = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Vari_box = New System.Windows.Forms.TextBox()
        Me.Lisaa = New System.Windows.Forms.Button()
        Me.Paivita = New System.Windows.Forms.Button()
        Me.Poista = New System.Windows.Forms.Button()
        CType(Me.Auto_lista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AutotBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Auto_db, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Auto_lista
        '
        Me.Auto_lista.AutoGenerateColumns = False
        Me.Auto_lista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Auto_lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Auto_lista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MerkkiDataGridViewTextBoxColumn, Me.MalliDataGridViewTextBoxColumn, Me.VuosimalliDataGridViewTextBoxColumn, Me.ReknroDataGridViewTextBoxColumn, Me.VariDataGridViewTextBoxColumn})
        Me.Auto_lista.DataSource = Me.AutotBindingSource
        Me.Auto_lista.Location = New System.Drawing.Point(683, 69)
        Me.Auto_lista.Name = "Auto_lista"
        Me.Auto_lista.Size = New System.Drawing.Size(643, 134)
        Me.Auto_lista.TabIndex = 0
        '
        'MerkkiDataGridViewTextBoxColumn
        '
        Me.MerkkiDataGridViewTextBoxColumn.DataPropertyName = "merkki"
        Me.MerkkiDataGridViewTextBoxColumn.HeaderText = "merkki"
        Me.MerkkiDataGridViewTextBoxColumn.Name = "MerkkiDataGridViewTextBoxColumn"
        '
        'MalliDataGridViewTextBoxColumn
        '
        Me.MalliDataGridViewTextBoxColumn.DataPropertyName = "malli"
        Me.MalliDataGridViewTextBoxColumn.HeaderText = "malli"
        Me.MalliDataGridViewTextBoxColumn.Name = "MalliDataGridViewTextBoxColumn"
        '
        'VuosimalliDataGridViewTextBoxColumn
        '
        Me.VuosimalliDataGridViewTextBoxColumn.DataPropertyName = "vuosimalli"
        Me.VuosimalliDataGridViewTextBoxColumn.HeaderText = "vuosimalli"
        Me.VuosimalliDataGridViewTextBoxColumn.Name = "VuosimalliDataGridViewTextBoxColumn"
        '
        'ReknroDataGridViewTextBoxColumn
        '
        Me.ReknroDataGridViewTextBoxColumn.DataPropertyName = "reknro"
        Me.ReknroDataGridViewTextBoxColumn.HeaderText = "reknro"
        Me.ReknroDataGridViewTextBoxColumn.Name = "ReknroDataGridViewTextBoxColumn"
        '
        'VariDataGridViewTextBoxColumn
        '
        Me.VariDataGridViewTextBoxColumn.DataPropertyName = "vari"
        Me.VariDataGridViewTextBoxColumn.HeaderText = "vari"
        Me.VariDataGridViewTextBoxColumn.Name = "VariDataGridViewTextBoxColumn"
        '
        'AutotBindingSource
        '
        Me.AutotBindingSource.DataMember = "Autot"
        Me.AutotBindingSource.DataSource = Me.Auto_db
        '
        'Auto_db
        '
        Me.Auto_db.DataSetName = "Auto_db"
        Me.Auto_db.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AutotTableAdapter
        '
        Me.AutotTableAdapter.ClearBeforeFill = True
        '
        'Malli_box
        '
        Me.Malli_box.Location = New System.Drawing.Point(415, 101)
        Me.Malli_box.Name = "Malli_box"
        Me.Malli_box.Size = New System.Drawing.Size(158, 20)
        Me.Malli_box.TabIndex = 19
        '
        'Vmalli_box
        '
        Me.Vmalli_box.Location = New System.Drawing.Point(415, 127)
        Me.Vmalli_box.Name = "Vmalli_box"
        Me.Vmalli_box.Size = New System.Drawing.Size(158, 20)
        Me.Vmalli_box.TabIndex = 18
        '
        'Reksiterinro_box
        '
        Me.Reksiterinro_box.Location = New System.Drawing.Point(415, 155)
        Me.Reksiterinro_box.Name = "Reksiterinro_box"
        Me.Reksiterinro_box.Size = New System.Drawing.Size(158, 20)
        Me.Reksiterinro_box.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(341, 185)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Väri"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(341, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Rekisterinro"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(341, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Vuosimalli"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(341, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Malli"
        '
        'Merkki_box
        '
        Me.Merkki_box.Location = New System.Drawing.Point(415, 69)
        Me.Merkki_box.Name = "Merkki_box"
        Me.Merkki_box.Size = New System.Drawing.Size(158, 20)
        Me.Merkki_box.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(341, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Merkki"
        '
        'Vari_box
        '
        Me.Vari_box.Location = New System.Drawing.Point(415, 183)
        Me.Vari_box.Name = "Vari_box"
        Me.Vari_box.Size = New System.Drawing.Size(158, 20)
        Me.Vari_box.TabIndex = 20
        '
        'Lisaa
        '
        Me.Lisaa.Location = New System.Drawing.Point(344, 235)
        Me.Lisaa.Name = "Lisaa"
        Me.Lisaa.Size = New System.Drawing.Size(75, 23)
        Me.Lisaa.TabIndex = 21
        Me.Lisaa.Text = "Lisää"
        Me.Lisaa.UseVisualStyleBackColor = True
        '
        'Paivita
        '
        Me.Paivita.Location = New System.Drawing.Point(436, 235)
        Me.Paivita.Name = "Paivita"
        Me.Paivita.Size = New System.Drawing.Size(75, 23)
        Me.Paivita.TabIndex = 22
        Me.Paivita.Text = "Päivitä"
        Me.Paivita.UseVisualStyleBackColor = True
        '
        'Poista
        '
        Me.Poista.Location = New System.Drawing.Point(535, 235)
        Me.Poista.Name = "Poista"
        Me.Poista.Size = New System.Drawing.Size(75, 23)
        Me.Poista.TabIndex = 23
        Me.Poista.Text = "Poista"
        Me.Poista.UseVisualStyleBackColor = True
        '
        'Autot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(1389, 591)
        Me.Controls.Add(Me.Poista)
        Me.Controls.Add(Me.Paivita)
        Me.Controls.Add(Me.Lisaa)
        Me.Controls.Add(Me.Vari_box)
        Me.Controls.Add(Me.Malli_box)
        Me.Controls.Add(Me.Vmalli_box)
        Me.Controls.Add(Me.Reksiterinro_box)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Merkki_box)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Auto_lista)
        Me.Name = "Autot"
        Me.Text = "Autot"
        CType(Me.Auto_lista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AutotBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Auto_db, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Auto_lista As System.Windows.Forms.DataGridView
    Friend WithEvents Auto_db As WindowsApplication1.Auto_db
    Friend WithEvents AutotBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AutotTableAdapter As WindowsApplication1.Auto_dbTableAdapters.AutotTableAdapter
    Friend WithEvents Malli_box As System.Windows.Forms.TextBox
    Friend WithEvents Vmalli_box As System.Windows.Forms.TextBox
    Friend WithEvents Reksiterinro_box As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Merkki_box As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Vari_box As System.Windows.Forms.TextBox
    Friend WithEvents Lisaa As System.Windows.Forms.Button
    Friend WithEvents Paivita As System.Windows.Forms.Button
    Friend WithEvents Poista As System.Windows.Forms.Button
    Friend WithEvents MerkkiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MalliDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VuosimalliDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReknroDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VariDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
