<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class bolsasolidaria
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cbextrema = New System.Windows.Forms.CheckBox()
        Me.cbpobreza = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtintegrantes = New System.Windows.Forms.TextBox()
        Me.txtbolsa = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.txtid = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbdepartamentos = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtmuni = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.ErrorValidacion = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.tmensaje = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorValidacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(90, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Identidad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(90, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre Completo"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cbextrema)
        Me.GroupBox3.Controls.Add(Me.cbpobreza)
        Me.GroupBox3.Location = New System.Drawing.Point(95, 379)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(320, 98)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Estado"
        '
        'cbextrema
        '
        Me.cbextrema.AutoSize = True
        Me.cbextrema.Location = New System.Drawing.Point(141, 40)
        Me.cbextrema.Name = "cbextrema"
        Me.cbextrema.Size = New System.Drawing.Size(157, 24)
        Me.cbextrema.TabIndex = 1
        Me.cbextrema.Text = "Extrema Pobreza"
        Me.cbextrema.UseVisualStyleBackColor = True
        '
        'cbpobreza
        '
        Me.cbpobreza.AutoSize = True
        Me.cbpobreza.Location = New System.Drawing.Point(26, 40)
        Me.cbpobreza.Name = "cbpobreza"
        Me.cbpobreza.Size = New System.Drawing.Size(94, 24)
        Me.cbpobreza.TabIndex = 0
        Me.cbpobreza.Text = "Pobreza"
        Me.cbpobreza.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(91, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Dirección"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Tipo de Bolsa"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(178, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Integrantes de la familia"
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(291, 99)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(136, 26)
        Me.txtnombre.TabIndex = 8
        '
        'txtintegrantes
        '
        Me.txtintegrantes.Location = New System.Drawing.Point(217, 51)
        Me.txtintegrantes.Name = "txtintegrantes"
        Me.txtintegrantes.Size = New System.Drawing.Size(136, 26)
        Me.txtintegrantes.TabIndex = 9
        '
        'txtbolsa
        '
        Me.txtbolsa.Enabled = False
        Me.txtbolsa.Location = New System.Drawing.Point(217, 83)
        Me.txtbolsa.Name = "txtbolsa"
        Me.txtbolsa.Size = New System.Drawing.Size(136, 26)
        Me.txtbolsa.TabIndex = 10
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column7, Me.Column8, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.DataGridView1.Location = New System.Drawing.Point(10, 495)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(1265, 150)
        Me.DataGridView1.TabIndex = 12
        '
        'Column1
        '
        Me.Column1.HeaderText = "Identidad"
        Me.Column1.MinimumWidth = 8
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 150
        '
        'Column7
        '
        Me.Column7.HeaderText = "Departamento"
        Me.Column7.MinimumWidth = 8
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 150
        '
        'Column8
        '
        Me.Column8.HeaderText = "Municipio"
        Me.Column8.MinimumWidth = 8
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 150
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nombre Completo"
        Me.Column2.MinimumWidth = 8
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 150
        '
        'Column3
        '
        Me.Column3.HeaderText = "Integrantes de la Familia"
        Me.Column3.MinimumWidth = 8
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 150
        '
        'Column4
        '
        Me.Column4.HeaderText = "Dirección"
        Me.Column4.MinimumWidth = 8
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 150
        '
        'Column5
        '
        Me.Column5.HeaderText = "Tipo de Bolsa"
        Me.Column5.MinimumWidth = 8
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 150
        '
        'Column6
        '
        Me.Column6.HeaderText = "Estado"
        Me.Column6.MinimumWidth = 8
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 150
        '
        'btnRegistrar
        '
        Me.btnRegistrar.BackColor = System.Drawing.Color.Gray
        Me.btnRegistrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnRegistrar.Location = New System.Drawing.Point(653, 269)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(169, 53)
        Me.btnRegistrar.TabIndex = 13
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = False
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(291, 52)
        Me.txtid.Mask = "0000-0000-00000"
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(136, 26)
        Me.txtid.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 20)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Departamento"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(260, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 20)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Municipio"
        '
        'cmbdepartamentos
        '
        Me.cmbdepartamentos.FormattingEnabled = True
        Me.cmbdepartamentos.Items.AddRange(New Object() {"Atlántida", "Choluteca", "Colón", "Comayagua", "Copán", "Cortés", "El Paraíso", "Francisco Morazán", "Gracias a Dios", "Intibucá", "Islas de la Bahía", "La Paz", "Lempira", "Ocotepeque ", "Olancho", "Santa Bárbara", "Valle", "Yoro"})
        Me.cmbdepartamentos.Location = New System.Drawing.Point(120, 49)
        Me.cmbdepartamentos.Name = "cmbdepartamentos"
        Me.cmbdepartamentos.Size = New System.Drawing.Size(121, 28)
        Me.cmbdepartamentos.TabIndex = 17
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtmuni)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cmbdepartamentos)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(548, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(543, 132)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ubicación"
        '
        'txtmuni
        '
        Me.txtmuni.Location = New System.Drawing.Point(339, 51)
        Me.txtmuni.Name = "txtmuni"
        Me.txtmuni.Size = New System.Drawing.Size(165, 26)
        Me.txtmuni.TabIndex = 18
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gray
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(828, 269)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(169, 53)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Limpiar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Gray
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(1003, 269)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(169, 53)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "Regresar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'txtdireccion
        '
        Me.txtdireccion.Location = New System.Drawing.Point(291, 138)
        Me.txtdireccion.Multiline = True
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(211, 81)
        Me.txtdireccion.TabIndex = 22
        '
        'ErrorValidacion
        '
        Me.ErrorValidacion.ContainerControl = Me
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtintegrantes)
        Me.GroupBox2.Controls.Add(Me.txtbolsa)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(94, 233)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(516, 137)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tipo Bolsa"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Gray
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.Location = New System.Drawing.Point(375, 52)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(119, 53)
        Me.Button3.TabIndex = 24
        Me.Button3.Text = "Obtener"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'bolsasolidaria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(1375, 707)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txtdireccion)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "bolsasolidaria"
        Me.Text = "bolsasolidaria"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorValidacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents txtintegrantes As TextBox
    Friend WithEvents txtbolsa As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents txtid As MaskedTextBox
    Friend WithEvents cbextrema As CheckBox
    Friend WithEvents cbpobreza As CheckBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbdepartamentos As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtmuni As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents txtdireccion As TextBox
    Friend WithEvents ErrorValidacion As ErrorProvider
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button3 As Button
    Friend WithEvents tmensaje As ToolTip
End Class
