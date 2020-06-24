Public Class tareasclase
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        arreglos.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        libretaahorro.Show()

    End Sub

    Private Sub Button2_MouseHover(sender As Object, e As EventArgs) Handles Button2.MouseHover
        tmensaje.SetToolTip(Button2, "Mostrara Formulario de Procedimientos")
        tmensaje.ToolTipTitle = "Descripcion"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        tmensaje.SetToolTip(Button1, "Mostrara Formulario de Arreglos")
        tmensaje.ToolTipTitle = "Descripcion"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

End Class