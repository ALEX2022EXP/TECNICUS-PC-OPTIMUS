Public Class Form1

  
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

    End Sub

    Private Sub ALTASToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ALTASToolStripMenuItem3.Click
        ALTAS_DE_PRODUCTOS.Show()
    End Sub

    Private Sub BAJASToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BAJASToolStripMenuItem3.Click
        BAJA_DE_PRODUCTOS.Show()
    End Sub

    Private Sub MODIFICACIONToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MODIFICACIONToolStripMenuItem.Click
        MODIFICAR_PRODUCTOS.Show()

    End Sub

    Private Sub ALTASToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ALTASToolStripMenuItem4.Click
        ALTAS_PROVEEDORES.Show()
    End Sub

    Private Sub BAJASToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BAJASToolStripMenuItem4.Click
        BAJAS_PROVEEDORES.Show()
    End Sub

    Private Sub MODIFICACIONToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MODIFICACIONToolStripMenuItem1.Click
        MODIFICAR_PROVEEDOR.Show()
    End Sub

    Private Sub ALTASToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ALTASToolStripMenuItem5.Click
        ALTASCLIENTES.Show()
    End Sub

    Private Sub BAJASToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BAJASToolStripMenuItem5.Click
        BAJACLIENTES.Show()
    End Sub

    Private Sub SalirToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem1.Click
        Close()
    End Sub
End Class
