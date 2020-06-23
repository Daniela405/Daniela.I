<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Barratitulo = New System.Windows.Forms.Panel()
        Me.btnMaximizar = New System.Windows.Forms.PictureBox()
        Me.btnRestaurar = New System.Windows.Forms.PictureBox()
        Me.btnMinimizar = New System.Windows.Forms.PictureBox()
        Me.btnCerrar = New System.Windows.Forms.PictureBox()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PanelCon = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PROGRAMACIÓN = New System.Windows.Forms.Label()
        Me.timerMostrarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.timerOcultarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.tmensaje = New System.Windows.Forms.ToolTip(Me.components)
        Me.Barratitulo.SuspendLayout()
        CType(Me.btnMaximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnRestaurar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMenu.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelCon.SuspendLayout()
        Me.SuspendLayout()
        '
        'Barratitulo
        '
        Me.Barratitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Barratitulo.Controls.Add(Me.btnMaximizar)
        Me.Barratitulo.Controls.Add(Me.btnRestaurar)
        Me.Barratitulo.Controls.Add(Me.btnMinimizar)
        Me.Barratitulo.Controls.Add(Me.btnCerrar)
        Me.Barratitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.Barratitulo.Location = New System.Drawing.Point(0, 0)
        Me.Barratitulo.Name = "Barratitulo"
        Me.Barratitulo.Size = New System.Drawing.Size(1116, 35)
        Me.Barratitulo.TabIndex = 4
        '
        'btnMaximizar
        '
        Me.btnMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximizar.Image = Global.IIParcial_Daniela.My.Resources.Resources.Icono_Maximizar
        Me.btnMaximizar.Location = New System.Drawing.Point(1048, 4)
        Me.btnMaximizar.Name = "btnMaximizar"
        Me.btnMaximizar.Size = New System.Drawing.Size(25, 25)
        Me.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMaximizar.TabIndex = 0
        Me.btnMaximizar.TabStop = False
        '
        'btnRestaurar
        '
        Me.btnRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestaurar.Image = Global.IIParcial_Daniela.My.Resources.Resources.Icono_Restaurar
        Me.btnRestaurar.Location = New System.Drawing.Point(1048, 4)
        Me.btnRestaurar.Name = "btnRestaurar"
        Me.btnRestaurar.Size = New System.Drawing.Size(25, 25)
        Me.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnRestaurar.TabIndex = 2
        Me.btnRestaurar.TabStop = False
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.Image = Global.IIParcial_Daniela.My.Resources.Resources.Icono_Minimizar
        Me.btnMinimizar.Location = New System.Drawing.Point(1017, 4)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(25, 25)
        Me.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMinimizar.TabIndex = 3
        Me.btnMinimizar.TabStop = False
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.Image = Global.IIParcial_Daniela.My.Resources.Resources.Icono_cerrar_FN
        Me.btnCerrar.Location = New System.Drawing.Point(1079, 6)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(25, 25)
        Me.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnCerrar.TabIndex = 1
        Me.btnCerrar.TabStop = False
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.PictureBox1)
        Me.PanelMenu.Controls.Add(Me.Button1)
        Me.PanelMenu.Controls.Add(Me.Button2)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 35)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(220, 552)
        Me.PanelMenu.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.IIParcial_Daniela.My.Resources.Resources.cerradura_de_neón_del_vector_en_el_icono_y_sistema_los_números_ejemplo_verde_que_brilla_intensamente_código_binario_escudo_148375547
        Me.PictureBox1.Location = New System.Drawing.Point(0, -13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(232, 237)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(3, 240)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(220, 41)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Trabajos Clase"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(3, 308)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(220, 41)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Trabajos Tarea"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'PanelCon
        '
        Me.PanelCon.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.PanelCon.Controls.Add(Me.Label1)
        Me.PanelCon.Controls.Add(Me.PROGRAMACIÓN)
        Me.PanelCon.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelCon.Location = New System.Drawing.Point(220, 35)
        Me.PanelCon.Name = "PanelCon"
        Me.PanelCon.Size = New System.Drawing.Size(896, 552)
        Me.PanelCon.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(62, 256)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(779, 91)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ENTORNOS VISUALES"
        '
        'PROGRAMACIÓN
        '
        Me.PROGRAMACIÓN.AutoSize = True
        Me.PROGRAMACIÓN.Font = New System.Drawing.Font("Microsoft Tai Le", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PROGRAMACIÓN.Location = New System.Drawing.Point(134, 183)
        Me.PROGRAMACIÓN.Name = "PROGRAMACIÓN"
        Me.PROGRAMACIÓN.Size = New System.Drawing.Size(654, 91)
        Me.PROGRAMACIÓN.TabIndex = 0
        Me.PROGRAMACIÓN.Text = "PROGRAMACION "
        '
        'timerMostrarMenu
        '
        '
        'timerOcultarMenu
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1116, 587)
        Me.Controls.Add(Me.PanelCon)
        Me.Controls.Add(Me.PanelMenu)
        Me.Controls.Add(Me.Barratitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Barratitulo.ResumeLayout(False)
        CType(Me.btnMaximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnRestaurar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMenu.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelCon.ResumeLayout(False)
        Me.PanelCon.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Barratitulo As Panel
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PanelCon As Panel
    Friend WithEvents timerMostrarMenu As Timer
    Friend WithEvents timerOcultarMenu As Timer
    Friend WithEvents btnMaximizar As PictureBox
    Friend WithEvents btnMinimizar As PictureBox
    Friend WithEvents btnRestaurar As PictureBox
    Friend WithEvents btnCerrar As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents tmensaje As ToolTip
    Friend WithEvents Label1 As Label
    Friend WithEvents PROGRAMACIÓN As Label
End Class
