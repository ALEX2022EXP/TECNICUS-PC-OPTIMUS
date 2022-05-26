Public Class ALTAS_PROVEEDORES
    Dim CN As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\david\Desktop\PROYECTO DE INGENIERIA DE SOFWARE\Proyecto de Ingenieria de Sofware\BD TECNICUS PC OPTIMUS.accdb")
    Private Sub txtclave_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtclave.KeyPress
        If Me.txtclave.Text.Length = 0 Then
            ErrorProvider1.SetError(Me.txtclave, "DEBE DIGITAR UNA CLAVE")
        Else

            If Asc(e.KeyChar) = 13 Then
                Me.lblnombre.Visible = True
                Me.txtnombre.Visible = True
                Me.btncancelar.Visible = True
                txtnombre.Focus()
            End If
        End If
    End Sub


    

    Private Sub txtnombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnombre.KeyPress
        If Me.txtnombre.Text.Length = 0 Then
            ErrorProvider2.SetError(Me.txtnombre, "DEBE DIGITAR UN NOMBRE DE PROVEEDOR")
        Else
            If Asc(e.KeyChar) = 13 Then
                Me.lblciudad.Visible = True
                Me.txtciudad.Visible = True
                txtciudad.Focus()
            End If
            End If
    End Sub

    Private Sub txtciudad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtciudad.KeyPress
        If Me.txtciudad.Text.Length = 0 Then
            ErrorProvider3.SetError(Me.txtciudad, "DEBE LLENAR EL CAMPO")
        Else

            If Asc(e.KeyChar) = 13 Then
                Me.lbldireccion.Visible = True
                Me.txtdireccion.Visible = True
                txtdireccion.Focus()
            End If
            End If
    End Sub

    Private Sub txtciudad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtciudad.TextChanged
        ErrorProvider3.Clear()
    End Sub

    Private Sub txtdireccion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdireccion.KeyPress
        If Me.txtdireccion.Text.Length = 0 Then
            ErrorProvider4.SetError(Me.txtdireccion, "DEBE DIGITAR UNA DIRECCION")
        Else

            If Asc(e.KeyChar) = 13 Then
                Me.lbltelefono.Visible = True
                Me.txttelefono.Visible = True
                txttelefono.Focus()
            End If

            End If
    End Sub

    Private Sub txtdireccion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdireccion.TextChanged
        ErrorProvider4.Clear()
    End Sub

    Private Sub txttelefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttelefono.KeyPress
        If Me.txttelefono.Text.Length = 0 Then
            ErrorProvider5.SetError(Me.txttelefono, "DEBE DIGITAR UN  TELEFONO ")
        Else

            If Asc(e.KeyChar) = 13 Then
                Me.btnguardar.Visible = True
            End If
        End If
    End Sub

    Private Sub txttelefono_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttelefono.TextChanged
        ErrorProvider5.Clear()
    End Sub

    Sub limpiar()
        txtclave.Clear()
        txtnombre.Clear()
        txtciudad.Clear()
        txtdireccion.Clear()
        txttelefono.Clear()



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
        btnguardar.Visible = False
        btncancelar.Visible = False

    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        limpiar()
        ocultar()
        txtclave.Focus()

    End Sub

    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
        Try
            CN.Close()
            Dim cmd As New OleDb.OleDbCommand("INSERT INTO PROVEEDORES VALUES ('" & txtclave.Text & "','" & txtnombre.Text & "','" & txtciudad.Text & "','" & txtdireccion.Text & "','" & txttelefono.Text & "')", CN)

            CN.Open()
            cmd.ExecuteNonQuery()
            If MessageBox.Show("SE HA GUARDADO CORRECTAMENTE ¿DESEAS DAR OTRO REGISTRO?", "ALTAS DE PROVEEDORES", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                txtclave.Focus()
                limpiar()
                ocultar()
            Else
                Close()
            End If

        Catch ex As Exception
            MessageBox.Show("LA CLAVE DEL PROVEEDOR YA EXISTE, DIGITA OTRA CLAVE", "ALTAS PROVEEDORES", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtclave.Focus()
            txtclave.Clear()

        End Try
        Try
        Catch exc As Exception
            MsgBox("OCURRIO UN ERROR")
        End Try

    End Sub

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Close()
    End Sub

    Private Sub ALTAS_PROVEEDORES_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtclave.Focus()
    End Sub

    Private Sub txtclave_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtclave.TextChanged
        ErrorProvider1.Clear()
    End Sub

    Private Sub txtnombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnombre.TextChanged
        ErrorProvider2.Clear()
    End Sub
End Class