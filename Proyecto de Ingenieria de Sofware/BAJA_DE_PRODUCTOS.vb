Public Class BAJA_DE_PRODUCTOS
    Dim CN As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\david\Desktop\PROYECTO DE INGENIERIA DE SOFWARE\Proyecto de Ingenieria de Sofware\BD TECNICUS PC OPTIMUS.accdb")
 
    Private Sub btnconsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconsultar.Click
        If Me.txtclave.Text.Length = 0 Then
            ErrorProvider1.SetError(Me.txtclave, "DEBE DIGITAR LA CLAVE DEL PRODUCTO QUE DESEA DAR DE BAJA")
        End If
        Dim cmd As New OleDb.OleDbCommand("SELECT * FROM PRODUCTOS WHERE Clave= '" & txtclave.Text & "'", CN)
        Dim DR As OleDb.OleDbDataReader
        CN.Open()
        DR = cmd.ExecuteReader
        If DR.Read Then
            
            txtnombre.Text = DR(1)
            txtdescripcion.Text = DR(2)
            txtprecio.Text = DR(3)
            txtcantidad.Text = DR(4)
            txtimporte.Text = DR(5)
            txtfecha.Text = DR(6)
            txtnombreprove.Text = DR(7)
            mostrar()
            bloquear()
            txtclave.Enabled = False
            MsgBox("REGISTRO ENCONTRADO")


        Else
            MsgBox("REGISTRO NO ENCONTRADO")
            txtclave.Clear()
            txtclave.Focus()
        End If
        CN.Close()

    End Sub
    Sub mostrar()
        txtnombre.Visible = True
        txtdescripcion.Visible = True
        txtprecio.Visible = True
        txtcantidad.Visible = True
        txtimporte.Visible = True
        txtfecha.Visible = True
        txtnombreprove.Visible = True
        lblnombre.Visible = True
        lbldescripcion.Visible = True
        lblprecio.Visible = True
        lblcantidad.Visible = True
        lblimporte.Visible = True
        lblfecha.Visible = True
        lblnombreprove.Visible = True
        btneliminar.Visible = True
        btncancelar.Visible = True
    End Sub
    Sub ocultar()
        txtnombre.Visible = False
        txtdescripcion.Visible = False
        txtprecio.Visible = False
        txtcantidad.Visible = False
        txtimporte.Visible = False
        txtfecha.Visible = False
        txtnombreprove.Visible = False
        lblnombre.Visible = False
        lbldescripcion.Visible = False
        lblprecio.Visible = False
        lblcantidad.Visible = False
        lblimporte.Visible = False
        lblfecha.Visible = False
        lblnombreprove.Visible = False
        btneliminar.Visible = False
        btncancelar.Visible = False
    End Sub
    Sub limpiar()
        txtclave.Clear()
        txtnombre.Clear()
        txtdescripcion.Clear()
        txtprecio.Clear()
        txtcantidad.Clear()
        txtimporte.Clear()
        txtfecha.Clear()
        txtnombreprove.Clear()
    End Sub


    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        limpiar()
        ocultar()
        txtclave.Enabled = True
        txtclave.Focus()
    End Sub

    Private Sub btneliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminar.Click
        Dim cmd As New OleDb.OleDbCommand("DELETE FROM PRODUCTOS WHERE Clave='" & txtclave.Text & "'", CN)
        CN.Open()
        cmd.ExecuteNonQuery()
        CN.Close()
        limpiar()
        ocultar()

        MsgBox("REGISTRO ELIMINADO")
        txtclave.Enabled = True
        txtclave.Focus()
    End Sub
    Sub bloquear()
        txtnombre.Enabled = False
        txtdescripcion.Enabled = False
        txtprecio.Enabled = False
        txtcantidad.Enabled = False
        txtimporte.Enabled = False
        txtfecha.Enabled = False
        txtnombreprove.Enabled = False

    End Sub

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Close()
    End Sub

    Private Sub BAJA_DE_PRODUCTOS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtclave.Focus()
    End Sub

    Private Sub txtclave_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtclave.KeyDown

    End Sub

    Private Sub txtclave_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtclave.KeyPress
        
    End Sub

    Private Sub txtclave_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtclave.TextChanged
        ErrorProvider1.Clear()
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub
End Class