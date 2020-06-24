Imports System.ComponentModel

Public Class bolsasolidaria
    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim existeElDato As Boolean = False
        For Each itm As DataGridViewRow In DataGridView1.Rows
            If itm.Cells(0).Value = txtid.Text Then
                existeElDato = True
            End If
        Next
        If Me.DataGridView1.Rows.Count > 0 AndAlso existeElDato = True Then
            MsgBox("Alerta: ya existe el dato!!!")

        ElseIf cbpobreza.Checked = True Then
            DataGridView1.Rows.Add(txtid.Text, cmbdepartamentos.Text, txtmuni.Text, txtnombre.Text, txtintegrantes.Text, txtdireccion.Text, txtbolsa.Text, cbpobreza.Text)
        ElseIf cbextrema.Checked = True Then
            DataGridView1.Rows.Add(txtid.Text, cmbdepartamentos.Text, txtmuni.Text, txtnombre.Text, txtintegrantes.Text, txtdireccion.Text, txtbolsa.Text, cbextrema.Text)
        Else
            MsgBox("Ingrese los datos necesarios")
        End If
    End Sub


    Private Sub txtnombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnombre.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub


    Private Sub txtintegrantes_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtintegrantes.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub


    Private Sub cbextrema_CheckedChanged(sender As Object, e As EventArgs) Handles cbextrema.CheckedChanged
        If cbextrema.Checked = True Then
            cbpobreza.Checked = False
        End If
    End Sub

    Private Sub cbpobreza_CheckedChanged(sender As Object, e As EventArgs) Handles cbpobreza.CheckedChanged
        If cbpobreza.Checked = True Then
            cbextrema.Checked = False
        End If
    End Sub

    Private Sub cmbdepartamentos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbdepartamentos.SelectedIndexChanged

        Select Case cmbdepartamentos.SelectedIndex
            Case 0
                txtmuni.Text = "La Ceiba"
            Case 1
                txtmuni.Text = "San Isidro"
            Case 2
                txtmuni.Text = "Trujillo"
            Case 3
                txtmuni.Text = "Siguatepeque"
            Case 4
                txtmuni.Text = "Cabañas"
            Case 5
                txtmuni.Text = "San Pedro Sula"
            Case 6
                txtmuni.Text = "Yuscaran"
            Case 7
                txtmuni.Text = "Santa Lucía"
            Case 8
                txtmuni.Text = "Puerto Lempira"
            Case 9
                txtmuni.Text = "La Esperanza"
            Case 10
                txtmuni.Text = "Utila"
            Case 11
                txtmuni.Text = "San José"
            Case 12
                txtmuni.Text = "La Unión"
            Case 13
                txtmuni.Text = "Mercedes"
            Case 14
                txtmuni.Text = "Juticalpa"
            Case 15
                txtmuni.Text = "Santa Rita"
            Case 16
                txtmuni.Text = "San Lorenzo"
            Case 17
                txtmuni.Text = "Morazán"

        End Select
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtmuni.Clear()
        txtnombre.Clear()
        txtintegrantes.Clear()
        txtintegrantes.Clear()
        txtid.Clear()
        txtdireccion.Clear()
        txtbolsa.Clear()
        cmbdepartamentos.Items.Clear()
        cbextrema.Checked = False
        cbpobreza.Checked = False

    End Sub


    Private Sub txtid_Validating(sender As Object, e As CancelEventArgs) Handles txtid.Validating
        If Val(txtid.Text) - Int(Val(txtid.Text)) = 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es necesario llenar el campo")
        End If
    End Sub

    Private Sub txtnombre_Validating(sender As Object, e As CancelEventArgs) Handles txtnombre.Validating
        If Val(txtnombre.Text) - Int(Val(txtnombre.Text)) = 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es necesario llenar el campo")
        End If
    End Sub

    Private Sub txtintegrantes_Validating(sender As Object, e As CancelEventArgs) Handles txtintegrantes.Validating
        If Val(txtintegrantes.Text) - Int(Val(txtintegrantes.Text)) = 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es necesario llenar el campo")
        End If
    End Sub


    Private Sub txtdireccion_Validating(sender As Object, e As CancelEventArgs) Handles txtdireccion.Validating
        If Val(txtdireccion.Text) - Int(Val(txtdireccion.Text)) = 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es necesario llenar el campo")
        End If
    End Sub

    Private Sub txtbolsa_Validating(sender As Object, e As CancelEventArgs) Handles txtbolsa.Validating
        If Val(txtbolsa.Text) - Int(Val(txtbolsa.Text)) = 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es necesario llenar el campo")
        End If
    End Sub

    Private Sub cmbdepartamentos_Validating(sender As Object, e As CancelEventArgs) Handles cmbdepartamentos.Validating
        If Val(cmbdepartamentos.Text) - Int(Val(cmbdepartamentos.Text)) = 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es necesario llenar el campo")
        End If
    End Sub


    Private Sub txtmuni_Validating(sender As Object, e As CancelEventArgs) Handles txtmuni.Validating
        If Val(txtmuni.Text) - Int(Val(txtmuni.Text)) = 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es necesario llenar el campo")
        End If
    End Sub

    Private Sub cbextrema_Validating(sender As Object, e As CancelEventArgs) Handles cbextrema.Validating
        If Val(cbextrema.Text) - Int(Val(cbextrema.Text)) = 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es necesario llenar el campo")
        End If
    End Sub

    Private Sub cbpobreza_Validating(sender As Object, e As CancelEventArgs) Handles cbpobreza.Validating
        If Val(cbpobreza.Text) - Int(Val(cbpobreza.Text)) = 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es necesario llenar el campo")
        End If
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If txtintegrantes.Text > 3 Then
            txtbolsa.Text = "Regular"
        Else
            If txtintegrantes.Text <= 3 Then
                txtbolsa.Text = "Básica"
            End If

        End If
    End Sub

    Private Sub Button3_MouseHover(sender As Object, e As EventArgs) Handles Button3.MouseHover
        tmensaje.SetToolTip(Button2, "Click para obtener el tipo de Bolsa")
        tmensaje.ToolTipTitle = "Descripcion"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnRegistrar_MouseHover(sender As Object, e As EventArgs) Handles btnRegistrar.MouseHover
        tmensaje.SetToolTip(Button2, "Click para Registrar la información")
        tmensaje.ToolTipTitle = "Descripcion"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        tmensaje.SetToolTip(Button2, "Click para limpiar las cajas llenas")
        tmensaje.ToolTipTitle = "Descripcion"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub Button2_MouseHover(sender As Object, e As EventArgs) Handles Button2.MouseHover
        tmensaje.SetToolTip(Button2, "Click para regresar al menú principal")
        tmensaje.ToolTipTitle = "Descripcion"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub


    Private Sub txtid_MouseHover(sender As Object, e As EventArgs) Handles txtid.MouseHover
        tmensaje.SetToolTip(Button2, "Ingrese su ID")
        tmensaje.ToolTipTitle = "Descripcion"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtnombre_MouseHover(sender As Object, e As EventArgs) Handles txtnombre.MouseHover
        tmensaje.SetToolTip(Button2, "Ingrese su nombre completo")
        tmensaje.ToolTipTitle = "Descripcion"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtdireccion_MouseHover(sender As Object, e As EventArgs) Handles txtdireccion.MouseHover
        tmensaje.SetToolTip(Button2, "Ingrese su dirección actual")
        tmensaje.ToolTipTitle = "Descripcion"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtintegrantes_MouseHover(sender As Object, e As EventArgs) Handles txtintegrantes.MouseHover
        tmensaje.SetToolTip(Button2, "Ingrese el numero de integrantes en su familia")
        tmensaje.ToolTipTitle = "Descripcion"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub cmbdepartamentos_MouseHover(sender As Object, e As EventArgs) Handles cmbdepartamentos.MouseHover
        tmensaje.SetToolTip(Button2, "Seleccione el departamento en donde vive")
        tmensaje.ToolTipTitle = "Descripcion"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub


    Private Sub txtmuni_MouseHover(sender As Object, e As EventArgs) Handles txtmuni.MouseHover
        tmensaje.SetToolTip(Button2, "Mostrara el municipio")
        tmensaje.ToolTipTitle = "Descripcion"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub cbextrema_MouseHover(sender As Object, e As EventArgs) Handles cbextrema.MouseHover
        tmensaje.SetToolTip(Button2, "Seleccione si vive en extrema pobreza")
        tmensaje.ToolTipTitle = "Descripcion"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub cbpobreza_MouseHover(sender As Object, e As EventArgs) Handles cbpobreza.MouseHover
        tmensaje.SetToolTip(Button2, "Seleccione si vive con lo necesario")
        tmensaje.ToolTipTitle = "Descripcion"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub
End Class