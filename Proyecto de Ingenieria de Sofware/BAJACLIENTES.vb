Imports System.Data.OleDb

Public Class BAJACLIENTES
    Dim CN As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\david\Desktop\PROYECTO DE INGENIERIA DE SOFWARE\Proyecto de Ingenieria de Sofware\BD TECNICUS PC OPTIMUS.accdb")

   
    Sub mostrar()
        txtnombre.Visible = True
        txtapellidos.Visible = True
        txtdireccion.Visible = True
        txtdescripcion.Visible = True
        txtcos.Visible = True
        lblnombre.Visible = True
        lblapellidos.Visible = True
        lbldireccion.Visible = True
        lbldescripcion.Visible = True
        lblcosto.Visible = True
        btneliminar.Visible = True
        btncancelar.Visible = True

    End Sub
    Sub ocultar()
        txtnombre.Visible = False
        txtapellidos.Visible = False
        txtdireccion.Visible = False
        txtdescripcion.Visible = False
        txtcos.Visible = False
        lblnombre.Visible = False
        lblapellidos.Visible = False
        lbldireccion.Visible = False
        lbldescripcion.Visible = False
        lblcosto.Visible = False
        btneliminar.Visible = False
        btncancelar.Visible = False

    End Sub


    Sub limpiar()
        txtid.Clear()
        txtnombre.Clear()
        txtapellidos.Clear()
        txtdescripcion.Clear()
        txtdireccion.Clear()
        txtdescripcion.Clear()
        txtcos.Clear()

    End Sub


    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Close()
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btneliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminar.Click
        Dim cmd As New OleDb.OleDbCommand("DELETE FROM CLIENTE WHERE Clave='" & txtid.Text & "'", CN)
        CN.Open()
        cmd.ExecuteNonQuery()
        CN.Close()
        limpiar()
        ocultar()

        MsgBox("REGISTRO ELIMINADO")
        txtid.Enabled = True
        txtid.Focus()
    End Sub

    Private Sub btnconsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconsultar.Click
        If Me.txtid.Text.Length = 0 Then
            ErrorProvider1.SetError(Me.txtid, "DEBE DIGITAR LA CLAVE DEL CLIENTE QUE DESEA DAR DE BAJA")
        End If
        Dim cmd As New OleDb.OleDbCommand("SELECT * FROM CLIENTE WHERE CLAVE= '" & txtid.Text & "'", CN)
        Dim DR As OleDb.OleDbDataReader
        CN.Open()
        DR = cmd.ExecuteReader
        If DR.Read Then  
            txtnombre.Text = DR(1)
            txtapellidos.Text = DR(2)
            txtdireccion.Text = DR(3)
            txtdescripcion.Text = DR(4)
            txtcos.Text = DR(5)
          
            mostrar()
            bloquear()
            txtid.Enabled = False
            MsgBox("REGISTRO ENCONTRADO CON EXITO")
        Else
            MsgBox("REGISTRO NO ENCONTRADO")
            txtid.Clear()
            txtid.Focus()
        End If
        CN.Close()

    End Sub
    Sub bloquear()
        txtnombre.Enabled = False
        txtapellidos.Enabled = False
        txtdireccion.Enabled = False
        txtdescripcion.Enabled = False
        txtcos.Enabled = False
    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        limpiar()
        ocultar()
        txtid.Enabled = True
        txtid.Focus()
    End Sub

    Private Sub BAJACLIENTES_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtid.TextChanged
        ErrorProvider1.Clear()
    End Sub
End Class