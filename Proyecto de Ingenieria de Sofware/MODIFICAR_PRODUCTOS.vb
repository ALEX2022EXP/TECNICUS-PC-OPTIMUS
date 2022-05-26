Public Class MODIFICAR_PRODUCTOS
    Dim CN As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\david\Desktop\PROYECTO DE INGENIERIA DE SOFWARE\Proyecto de Ingenieria de Sofware\BD TECNICUS PC OPTIMUS.accdb")

    Private Sub MODIFICAR_PRODUCTOS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtclave.Focus()
    End Sub

   
    Private Sub btnconsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconsultar.Click
        If Me.txtclave.Text.Length = 0 Then
            ErrorProvider1.SetError(Me.txtclave, "DEBE DIGITAR LA CLAVE DEL PRODUCTO QUE DESEA MODIFICAR")
        End If
        Dim cmd As New OleDb.OleDbCommand("SELECT * FROM PRODUCTOS WHERE Clave= '" & txtclave.Text & "'", CN)
        Dim DR As OleDb.OleDbDataReader
        CN.Open()
        DR = cmd.ExecuteReader
        If DR.Read Then
            If Me.txtclave.Text.Length = 0 Then
                ErrorProvider1.SetError(Me.txtclave, "DEBE DE DIGITAR UNA CLAVE DE PRODUCTOS")
            End If
            txtnombre.Text = DR(1)
            txtdescripcion.Text = DR(2)
            txtprecio.Text = DR(3)
            txtcantidad.Text = DR(4)
            txtimporte.Text = DR(5)
            txtfecha.Text = DR(6)
            txtnombreprove.Text = DR(7)
            mostrar()
            txtnombre.Focus()

            MsgBox("REGISTRO ENCONTRADO")
            txtclave.Enabled = False
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
        btnmodificar.Visible = True
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
        btnmodificar.Visible = False
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

    Private Sub btnsalirr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalirr.Click
        Close()
    End Sub

    Private Sub btnmodificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodificar.Click
        Dim cmd As New OleDb.OleDbCommand("UPDATE PRODUCTOS SET Clave='" & txtclave.Text & "',Nombre='" & txtnombre.Text & "',Descripcion='" & txtdescripcion.Text & "',Precio='" & txtprecio.Text & "',Cantidad_articulo='" & txtcantidad.Text & "',Importe_total='" & txtimporte.Text & "',Fecha='" & txtfecha.Text & "',Nombre_proveedor='" & txtnombreprove.Text & "' WHERE Clave='" & txtclave.Text & "'", CN)
        CN.Open()
        cmd.ExecuteNonQuery()
        CN.Close()
        mostrar()
        MsgBox("REGISTRO ACTUALIZADO CON EXITO")
        limpiar()
        ocultar()
        txtclave.Enabled = True
        txtclave.Focus()

    End Sub

    Private Sub txtclave_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtclave.TextChanged
        ErrorProvider1.Clear()
    End Sub
End Class