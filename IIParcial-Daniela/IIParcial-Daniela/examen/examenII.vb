Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class examenII
    Dim conexion As conexion = New conexion()
    Public adaptador As SqlDataAdapter
    Public dt As DataTable
    Public cn As SqlConnection


    Public Sub mostrardatos()
        conexion.consulta("select v.idVenta, v.cantidad,v.precio, c.nombre, p.nombreProducto from venta v
		  inner join producto p
		  on v.idProducto= p.idProducto
		  inner join cliente c
		  on v.idCliente= c.idCliente", "venta, producto, cliente")

        DataGridView1.DataSource = conexion.ds.Tables("venta, producto, cliente")


    End Sub
    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click

        Dim agregar As String = "insert into venta  values ('" + txtcodigoventa.Text + "','" + mskFecha.Text + "','" + txtprecio.Text + "','" + txtcantidad.Text + "','" + txtcliente.Text + "','" + txtproducto.Text + "')"
            If (conexion.insertar(agregar)) Then
                MessageBox.Show("Datos Agregados Correctamente")
                mostrardatos()
            Else
                MessageBox.Show("error al agregar")

            End If




    End Sub
    Public Sub mostrarnombre(ByVal condicion)
        conexion.consulta("Select nombre from cliente " + "where" + condicion, "cliente")
        txtcliente.Text = conexion.ds.Tables("cliente").Rows(0)(0)
    End Sub
    Public Sub mostrarnombrepro(ByVal condicion)
        conexion.consulta("Select nombre from producto " + "where" + condicion, "producto")
        txtproducto.Text = conexion.ds.Tables("producto").Rows(0)(0)
    End Sub
    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        Try
            Dim conexion As String
            conexion = "data source =DESKTOP-HT00A5J \ SQLEXPRESS;initial catalog=Tienda;integrated security =true"
            Dim cn As New SqlConnection
            cn.ConnectionString = conexion
            Dim adaptador As New SqlDataAdapter("select * from venta where idVenta=" & txtcodigoventa.Text & " ", cn)
            Dim ds As New DataSet
            adaptador.Fill(ds, "datos")
            If ds.Tables("datos").Rows.Count > 0 Then
                txtcodigoventa.Text = ds.Tables("datos").Rows(0).Item(0).ToString
                mskFecha.Text = ds.Tables("datos").Rows(0).Item(1).ToString
                txtprecio.Text = ds.Tables("datos").Rows(0).Item(2).ToString
                txtcantidad.Text = ds.Tables("datos").Rows(0).Item(3).ToString
                txtcliente.Text = ds.Tables("datos").Rows(0).Item(4).ToString
                txtproducto.Text = ds.Tables("datos").Rows(0).Item(5).ToString

                DataGridView1.DataSource = ds.Tables("datos")
            Else

                MessageBox.Show("El dato no existe")
            End If
        Catch ex As Exception

        End Try



    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        If (conexion.eliminar("venta", "idVenta = " + txtcodigoventa.Text)) Then
            MessageBox.Show("Registro eliminado correctamente")
            mostrardatos()
        Else
            MessageBox.Show("error al eliminar")

        End If
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        Dim actualizar As String = "fechaVenta= '" + mskFecha.Text + "' ,precio='" + txtprecio.Text + "', cantidad='" + txtcantidad.Text + "',problema='" + txtcliente.Text + "',estado='" + txtproducto.Text + "')"
        Dim sql As String = String.Format("update venta set  [fechaVenta]='{0}', precio='{1}', cantidad='{2}', idCliente='{3}', idProducto='{4}' where idVenta={4}", mskFecha.Text, txtprecio.Text, txtcantidad.Text, txtcliente.Text, txtproducto.Text)
        If (conexion.actualizar(sql)) Then
            MessageBox.Show("Datos actualizados correctamente")
            mostrardatos()
        Else
            MessageBox.Show("error al actualizar")

        End If

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick



        Dim dgv As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
        txtcodigoventa.Text = dgv.Cells(0).Value.ToString()
        mskFecha.Text = dgv.Cells(1).Value.ToString()
        txtprecio.Text = dgv.Cells(2).Value.ToString()
        txtcantidad.Text = dgv.Cells(3).Value.ToString()
        txtcliente.Text = dgv.Cells(4).Value.ToString()
        txtproducto.Text = dgv.Cells(5).Value.ToString()

    End Sub

    Private Sub txtcodigoventa_Validating(sender As Object, e As CancelEventArgs) Handles txtcodigoventa.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtprecio_Validating(sender As Object, e As CancelEventArgs) Handles txtprecio.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtcantidad_Validating(sender As Object, e As CancelEventArgs) Handles txtcantidad.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtcliente_Validating(sender As Object, e As CancelEventArgs) Handles txtcliente.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtproducto_Validating(sender As Object, e As CancelEventArgs) Handles txtproducto.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtcodigoventa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcodigoventa.KeyPress
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

    Private Sub txtcantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcantidad.KeyPress
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

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        txtproducto.Clear()
        txtcodigoventa.Clear()
        txtprecio.Clear()
        txtcantidad.Clear()
        txtcliente.Clear()

    End Sub

    Private Sub examenII_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.conectar()
        mostrardatos()

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim opcion As DialogResult
        opcion = MessageBox.Show("¿Desea finalizar?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (opcion = DialogResult.Yes) Then
            Form1.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub txtcodigoventa_TextChanged(sender As Object, e As EventArgs) Handles txtcodigoventa.TextChanged

    End Sub

    Private Sub txtcodigoventa_MouseHover(sender As Object, e As EventArgs) Handles txtcodigoventa.MouseHover
        tmensaje.SetToolTip(txtcodigoventa, "Ingrese el codigo de la venta")
        tmensaje.ToolTipTitle = "Código Venta"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtprecio_MouseHover(sender As Object, e As EventArgs) Handles txtprecio.MouseHover
        tmensaje.SetToolTip(txtprecio, "Ingrese el precio")
        tmensaje.ToolTipTitle = "Precio"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtcantidad_TextChanged(sender As Object, e As EventArgs) Handles txtcantidad.TextChanged

    End Sub

    Private Sub txtcantidad_MouseHover(sender As Object, e As EventArgs) Handles txtcantidad.MouseHover
        tmensaje.SetToolTip(txtcantidad, "Ingrese la cantidad del producto")
        tmensaje.ToolTipTitle = "Cantidad"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtcliente_MouseHover(sender As Object, e As EventArgs) Handles txtcliente.MouseHover
        tmensaje.SetToolTip(txtcliente, "Ingrese el cliente")
        tmensaje.ToolTipTitle = "Cliente"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtproducto_TextChanged(sender As Object, e As EventArgs) Handles txtproducto.TextChanged

    End Sub

    Private Sub txtproducto_MouseHover(sender As Object, e As EventArgs) Handles txtproducto.MouseHover
        tmensaje.SetToolTip(txtproducto, "Ingrese el producto")
        tmensaje.ToolTipTitle = "Producto"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnagregar_MouseHover(sender As Object, e As EventArgs) Handles btnagregar.MouseHover
        tmensaje.SetToolTip(btnagregar, "Click para agregar una nueva factura")
        tmensaje.ToolTipTitle = "Agregar"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnbuscar_MouseHover(sender As Object, e As EventArgs) Handles btnbuscar.MouseHover
        tmensaje.SetToolTip(btnbuscar, "Click para buscar la factura")
        tmensaje.ToolTipTitle = "Buscar"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnmodificar_MouseHover(sender As Object, e As EventArgs) Handles btnmodificar.MouseHover
        tmensaje.SetToolTip(btnmodificar, "Click para agregar una nueva factura")
        tmensaje.ToolTipTitle = "Agregar"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub


    Private Sub txtprecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtprecio.KeyPress
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
End Class