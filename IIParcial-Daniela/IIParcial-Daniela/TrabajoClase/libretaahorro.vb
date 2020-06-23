﻿Imports System.ComponentModel

Public Class libretaahorro
    Private monto As Double
    'Procedimientos
    Private Sub activarControles()
        txtNombre.Enabled = False
        txtMonto.Enabled = False
        Button1.Enabled = True
        Button2.Enabled = True
        btnAperturar.Enabled = False
    End Sub
    Private Sub desactivarControles()

        Button1.Enabled = False
        Button2.Enabled = False
        btnAperturar.Enabled = True
    End Sub

    Private Sub limpiar()
        desactivarControles()
        txtNombre.Clear()
        txtMonto.Clear()
        txtSaldo.Clear()
        IstDepositos.Items.Clear()
        IsRetiros.Items.Clear()
        txtedad.Clear()
        txtpais.Clear()
        txtciudad.Clear()
        txtintereses.Clear()
        txtid.Clear()
    End Sub

    Private Sub libretaahorro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        desactivarControles()

    End Sub

    Private Sub mostrarSaldo()
        txtSaldo.Text = monto
    End Sub

    Private Sub btnAperturar_Click(sender As Object, e As EventArgs) Handles btnAperturar.Click

        If txtid.Text = "1212-2001-00016" Then
            txtNombre.Text = "Daniela Isabel Vasquez M."
            txtedad.Text = 20
            txtpais.Text = "Honduras"
            txtciudad.Text = "Comayagua"
            txtMonto.Text = 15000
            txtintereses.Text = Rnd()

        Else

            MessageBox.Show("Numero de identidad incorrecto", "Ingresa correctamente tu ID", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

        Button1.Enabled = True
        Button2.Enabled = True



    End Sub

    Private Function leer(mensaje As String)
        Dim cantidad As Double
        cantidad = InputBox("Ingrese un monto a " & mensaje, "Operacion")
        mostrarSaldo()
        Return cantidad
    End Function

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim deposito As Double
        deposito = leer("Depositar")

        monto = (deposito + txtMonto.Text) * txtintereses.Text

        IstDepositos.Items.Add(deposito)
        mostrarSaldo()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim retiro As Double
        retiro = leer("Retirar")
        If (retiro > txtMonto.Text) Then
            MessageBox.Show("Saldo insuficiente", "Deposite mas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            monto = txtMonto.Text - retiro
            IsRetiros.Items.Add(retiro)
            mostrarSaldo()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub txtNombre_Validating(sender As Object, e As CancelEventArgs) Handles txtNombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtedad_TextChanged(sender As Object, e As EventArgs) Handles txtedad.TextChanged

    End Sub

    Private Sub txtedad_Validating(sender As Object, e As CancelEventArgs) Handles txtedad.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtpais_TextChanged(sender As Object, e As EventArgs) Handles txtpais.TextChanged

    End Sub

    Private Sub txtpais_Validating(sender As Object, e As CancelEventArgs) Handles txtpais.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtciudad_Validating(sender As Object, e As CancelEventArgs) Handles txtciudad.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub


    Private Sub txtMonto_Validating(sender As Object, e As CancelEventArgs) Handles txtMonto.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtintereses_Validating(sender As Object, e As CancelEventArgs) Handles txtintereses.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub




    Private Sub txtSaldo_Validating(sender As Object, e As CancelEventArgs) Handles txtSaldo.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub


    Private Sub IstDepositos_Validating(sender As Object, e As CancelEventArgs) Handles IstDepositos.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub


    Private Sub IsRetiros_Validating(sender As Object, e As CancelEventArgs) Handles IsRetiros.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtid_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtid.MaskInputRejected

    End Sub

    Private Sub txtid_MouseHover(sender As Object, e As EventArgs) Handles txtid.MouseHover
        tmensaje.SetToolTip(txtid, "Ingrese su ID")
        tmensaje.ToolTipTitle = "Descripcion"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnAperturar_MouseHover(sender As Object, e As EventArgs) Handles btnAperturar.MouseHover
        tmensaje.SetToolTip(btnAperturar, "Dar click para aperturar la cuenta")
        tmensaje.ToolTipTitle = "Descripcion"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub IstDepositos_MouseHover(sender As Object, e As EventArgs) Handles IstDepositos.MouseHover
        tmensaje.SetToolTip(IstDepositos, "Mostrara la lista de Depositos realizados")
        tmensaje.ToolTipTitle = "Descripcion"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub IsRetiros_SelectedIndexChanged(sender As Object, e As EventArgs) Handles IsRetiros.SelectedIndexChanged

    End Sub

    Private Sub txtSaldo_TextChanged(sender As Object, e As EventArgs) Handles txtSaldo.TextChanged

    End Sub

    Private Sub IsRetiros_MouseHover(sender As Object, e As EventArgs) Handles IsRetiros.MouseHover
        tmensaje.SetToolTip(IsRetiros, "Mostrara la lista de retiros realizados")
        tmensaje.ToolTipTitle = "Descripcion"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtSaldo_MouseHover(sender As Object, e As EventArgs) Handles txtSaldo.MouseHover
        tmensaje.SetToolTip(txtSaldo, "Mostrara el Saldo total de la cuenta")
        tmensaje.ToolTipTitle = "Descripcion"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnLimpiar_MouseHover(sender As Object, e As EventArgs) Handles btnLimpiar.MouseHover
        tmensaje.SetToolTip(btnLimpiar, "Click para limpiar toda la información")
        tmensaje.ToolTipTitle = "Descripcion"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub Button3_MouseHover(sender As Object, e As EventArgs) Handles Button3.MouseHover
        tmensaje.SetToolTip(Button3, "Click para regresar al menú principal")
        tmensaje.ToolTipTitle = "Descripcion"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        tmensaje.SetToolTip(Button1, "Click para realizar un deposito")
        tmensaje.ToolTipTitle = "Descripcion"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub Button2_MouseHover(sender As Object, e As EventArgs) Handles Button2.MouseHover
        tmensaje.SetToolTip(Button2, "Click para realizar un retiro")
        tmensaje.ToolTipTitle = "Descripcion"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub
End Class