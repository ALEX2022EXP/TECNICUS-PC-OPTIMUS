Public Class MODIFICAR_PROVEEDOR
    Dim CN As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\david\Desktop\PROYECTO DE INGENIERIA DE SOFWARE\Proyecto de Ingenieria de Sofware\BD TECNICUS PC OPTIMUS.accdb")
    Private Sub MODIFICAR_PROVEEDOR_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtclave.Focus()
    End Sub

    Private Sub btnconsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconsultar.Click
        If Me.txtclave.Text.Length = 0 Then
            ErrorProvider1.SetError(Me.txtclave, "DEBE DIGITAR LA CLAVE DEL PROVEEDOR QUE DESEA MODIFICAR")
        End If
        Dim cmd As New OleDb.OleDbCommand("SELECT * FROM PROVEEDORES WHERE Clave_proveedor= '" & txtclave.Text & "'", CN)
        Dim DR As OleDb.OleDbDataReader
        CN.Open()
        DR = cmd.ExecuteReader
        If DR.Read Then
            txtnombre.Text = DR(1)
            txtciudad.Text = DR(2)
            txtdireccion.Text = DR(3)
            txttelefono.Text = DR(4)

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
        txtciudad.Visible = True
        txtdireccion.Visible = True
        txttelefono.Visible = True
        lblnombre.Visible = True
        lblciudad.Visible = True
        lbldireccion.Visible = True
        lbltelefono.Visible = True
        btnmodificar.Visible = True
        btncancelar.Visible = True
    End Sub
    Sub ocultar()
        txtnombre.Visible = False
        txtciudad.Visible = False
        txtdireccion.Visible = False
        txttelefono.Visible = False
        lblnombre.Visible = False
        lblciudad.Visible = False
        lbldireccion.Visible = False
        lbltelefono.Visible = False
        btnmodificar.Visible = False
        btncancelar.Visible = False
    End Sub
    Sub limpiar()
        txtclave.Clear()
        txtnombre.Clear()
        txtciudad.Clear()
        txtdireccion.Clear()
        txttelefono.Clear()
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
        Dim cmd As New OleDb.OleDbCommand("UPDATE PROVEEDORES SET Clave_proveedor='" & txtclave.Text & "',Nombre_proveedor='" & txtnombre.Text & "',Cuidad='" & txtciudad.Text & "',Direccion='" & txtdireccion.Text & "',Telefono='" & txttelefono.Text & "' WHERE Clave_proveedor='" & txtclave.Text & "'", CN)
        CN.Open()
        cmd.ExecuteNonQuery()
        CN.Close()

        MsgBox("REGISTRO ACTUALIZADO")
        limpiar()
        ocultar()

        txtclave.Enabled = True
        txtclave.Focus()
    End Sub

    Private Sub txtclave_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtclave.TextChanged
        ErrorProvider1.Clear()
    End Sub
End Class