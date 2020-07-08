Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class cliente
    Dim conexion As conexion = New conexion()
    Public Sub mostrardatos()
        conexion.consulta("select * from cliente", "cliente")

        DataGridView1.DataSource = conexion.ds.Tables("cliente")

    End Sub
    Private Sub cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.conectar()
        mostrardatos()
    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click


        Dim agregar As String = "insert into cliente  values ('" + txtcodigo.Text + "' ,'" + txtnombre.Text + "','" + txtapellido.Text + "','" + txtdireccion.Text + "')"
        If (conexion.insertar(agregar)) Then
                MessageBox.Show("Datos Agregados Correctamente")
                mostrardatos()
            Else
                MessageBox.Show("error al agregar")

            End If


    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        txtapellido.Clear()
        txtnombre.Clear()
        txtcodigo.Clear()
        txtdireccion.Clear()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim opcion As DialogResult
        opcion = MessageBox.Show("¿Desea finalizar?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (opcion = DialogResult.Yes) Then
            Form1.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        Dim conexion As String
        conexion = "data source =DESKTOP-HT00A5J \ SQLEXPRESS;initial catalog=Tienda;integrated security =true"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion
        Dim adaptador As New SqlDataAdapter("select * from cliente where idCliente=" & txtcodigo.Text & " ", cn)
        Dim ds As New DataSet
        adaptador.Fill(ds, "datos")
        If ds.Tables("datos").Rows.Count > 0 Then
            txtcodigo.Text = ds.Tables("datos").Rows(0).Item(0).ToString
            txtnombre.Text = ds.Tables("datos").Rows(0).Item(1).ToString
            txtapellido.Text = ds.Tables("datos").Rows(0).Item(2).ToString
            txtdireccion.Text = ds.Tables("datos").Rows(0).Item(3).ToString


            DataGridView1.DataSource = ds.Tables("datos")


        End If
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        Dim actualizar As String = "nombre= '" + txtnombre.Text + "' ,apellido='" + txtapellido.Text + "', direccion='" + txtdireccion.Text + "')"
        Dim sql As String = String.Format("update cliente set  nombre='{0}', apellido='{1}', direccion='{2}' where idCliente={3}", txtnombre.Text, txtapellido.Text, txtdireccion.Text, txtcodigo.Text)
        If (conexion.actualizar(sql)) Then
            MessageBox.Show("datos actualizados correctamente")
            mostrardatos()
        Else
            MessageBox.Show("error al actualizar")

        End If

    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        If (conexion.eliminar("cliente", "idCliente = " + txtcodigo.Text)) Then
            MessageBox.Show("Registro eliminado correctamente")
            mostrardatos()
        Else
            MessageBox.Show("error al eliminar")

        End If
    End Sub
End Class