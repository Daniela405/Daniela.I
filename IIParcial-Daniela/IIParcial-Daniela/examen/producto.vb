Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class Producto
    Dim conexion As conexion = New conexion()
    Public Sub mostrardatos()
        conexion.consulta("select * from producto", "producto")

        DataGridView1.DataSource = conexion.ds.Tables("producto")

    End Sub
    Private Sub producto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.conectar()
        mostrardatos()
    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        Try

            Dim agregar As String = "insert into producto values ('" + txtcodigo.Text + "','" + txtnombre.Text + "','" + txtdescripcion.Text + "')"
            If (conexion.insertar(agregar)) Then
                MessageBox.Show("Datos Agregados Correctamente")
                mostrardatos()
            Else
                MessageBox.Show("error al agregar")

            End If
        Catch ex As Exception
            MessageBox.Show("Registro existente")
        End Try
    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        Dim conexion As String
        conexion = "data source =DESKTOP-HT00A5J \ SQLEXPRESS;initial catalog=Tienda;integrated security =true"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion
        Dim adaptador As New SqlDataAdapter("select * from producto where idProducto=" & txtcodigo.Text & " ", cn)
        Dim ds As New DataSet
        adaptador.Fill(ds, "datos")
        If ds.Tables("datos").Rows.Count > 0 Then
            txtcodigo.Text = ds.Tables("datos").Rows(0).Item(0).ToString
            txtnombre.Text = ds.Tables("datos").Rows(0).Item(1).ToString
            txtdescripcion.Text = ds.Tables("datos").Rows(0).Item(2).ToString



            DataGridView1.DataSource = ds.Tables("datos")
        Else
            MessageBox.Show("No existe el registro")


        End If
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        Dim actualizar As String = "nombre= '" + txtnombre.Text + "' ,descripcion='" + txtdescripcion.Text + "')"
        Dim sql As String = String.Format("update producto set  nombreProducto='{0}', descripcion='{1}' where idProducto={2}", txtnombre.Text, txtdescripcion.Text, txtcodigo.Text)
        If (conexion.actualizar(sql)) Then
            MessageBox.Show("datos actualizados correctamente")
            mostrardatos()
        Else
            MessageBox.Show("error al actualizar")

        End If

    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        txtnombre.Clear()
        txtcodigo.Clear()
        txtdescripcion.Clear()

    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        If (conexion.eliminar("producto", "idProducto = " + txtcodigo.Text)) Then
            MessageBox.Show("Registro eliminado correctamente")
            mostrardatos()
        Else
            MessageBox.Show("error al eliminar")

        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim opcion As DialogResult
        opcion = MessageBox.Show("¿Desea finalizar?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (opcion = DialogResult.Yes) Then
            Form1.Show()
            Me.Hide()
        End If
    End Sub
End Class