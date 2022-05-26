Public Class ALTAS_DE_PRODUCTOS
    Dim CN As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\david\Desktop\PROYECTO DE INGENIERIA DE SOFWARE\Proyecto de Ingenieria de Sofware\BD TECNICUS PC OPTIMUS.accdb")

    Private Sub txtclave_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtclave.KeyPress
        ''primero agregamos un objeto llamado ErrorProvider a un lado de la caja de texto
        '' Esto es para cuando no tecleamos nada y queremos pasar al siguiente textbox, nos mande un error
        ''para que no pase a la siguiente caja de texto necesita tener un if anidado( es decir un if dentro de otro if)
        If Me.txtclave.Text.Length = 0 Then
            ErrorProvider1.SetError(Me.txtclave, "DEBE DIGITAR LA CLAVE")

        Else
            ''estas lineas de codigo son para que cuando presionemos el textboxclave nos pasa al siguiente campo asiendome visible el label y caja de texti visibles
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
            ErrorProvider2.SetError(Me.txtnombre, "DEBE DIGITAR UN NOMBRE DE PRODUCTO")
        Else

            If Asc(e.KeyChar) = 13 Then
                Me.lbldescripcion.Visible = True
                Me.txtdescripcion.Visible = True
                txtdescripcion.Focus()

            End If
        End If
    End Sub

    Private Sub txtdescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdescripcion.KeyPress

        If Me.txtdescripcion.Text.Length = 0 Then
            ErrorProvider3.SetError(Me.txtdescripcion, "DEBE DE PONER UNA DESCRIPCION DE PRODUCTO")
        Else
            If Asc(e.KeyChar) = 13 Then
                Me.lblprecio.Visible = True
                Me.txtprecio.Visible = True
                txtprecio.Focus()
            End If
        End If
    End Sub

    Private Sub txtprecio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtprecio.KeyPress

        If Me.txtprecio.Text.Length = 0 Then
            ErrorProvider4.SetError(Me.txtprecio, "DEBE DE DIGITAR UN PRECIO")
        Else

            If Asc(e.KeyChar) = 13 Then
                Me.lblcantidad.Visible = True
                Me.txtcantidad.Visible = True
                txtcantidad.Focus()
            End If
        End If
    End Sub

    Private Sub txtcantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcantidad.KeyPress

        If Me.txtcantidad.Text.Length = 0 Then
            ErrorProvider5.SetError(Me.txtcantidad, "DEBE DE PONER UNA CANTIDAD")
        Else

            If Asc(e.KeyChar) = 13 Then
                Me.lblimporte.Visible = True
                Me.txtimporte.Visible = True
                txtimporte.Focus()
            End If
        End If
    End Sub
    Private Sub txtimporte_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtimporte.KeyPress
        If Me.txtimporte.Text.Length = 0 Then
            ErrorProvider6.SetError(Me.txtimporte, "DEBE DIGITAR EL IMPORTE TOTAL")
        Else

            If Asc(e.KeyChar) = 13 Then
                Me.lblfecha.Visible = True
                Me.txtfecha.Visible = True
                txtfecha.Focus()
            End If
        End If
    End Sub

    Private Sub txtfecha_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtfecha.KeyPress
        If Me.txtfecha.Text.Length = 0 Then
            ErrorProvider7.SetError(Me.txtfecha, "DEBE PONER UNA FECHA")
        Else

            If Asc(e.KeyChar) = 13 Then
                Me.lblnombreprove.Visible = True
                Me.txtnombreprove.Visible = True

                txtnombreprove.Focus()
            End If

        End If
    End Sub

    Private Sub txtnombreprove_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnombreprove.KeyPress
        If Me.txtnombreprove.Text.Length = 0 Then
            ErrorProvider8.SetError(Me.txtnombreprove, "DEBE DE DIGITAR UNA  NOMBRE DE PROVEEDOR")
        Else

            If Asc(e.KeyChar) = 13 Then
                Me.btnguardar.Visible = True

            End If
        End If
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
        btnguardar.Visible = False
        btncancelar.Visible = False

    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        limpiar()
        ocultar()
        txtclave.Focus()
    End Sub



    Private Sub ALTAS_DE_PRODUCTOS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtclave.Focus()
    End Sub

    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
        Try
            CN.Close()
            Dim cmd As New OleDb.OleDbCommand("INSERT INTO PRODUCTOS VALUES ('" & txtclave.Text & "','" & txtnombre.Text & "','" & txtdescripcion.Text & "','" & txtprecio.Text & "','" & txtcantidad.Text & "','" & txtimporte.Text & "','" & txtfecha.Text & "','" & txtnombreprove.Text & "')", CN)
            CN.Open()
            cmd.ExecuteNonQuery()
            If MessageBox.Show("SE HA GUARDADO CORRECTAMENTE ¿DESEAS DAR OTRO REGISTRO?", "ALTAS PRODUCTOS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                txtclave.Focus()
                limpiar()
                ocultar()
            Else
                Close()
            End If

        Catch ex As Exception
            MessageBox.Show("LA CLAVE DEL PRODUCTO  YA EXISTE, DIGITA OTRA CLAVE", "ALTAS PRODUCTOS", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub txtclave_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtclave.TextChanged
        '' es para que me limpie el error de la caja de texto cuando dijito algun caracter 
        ErrorProvider1.Clear()
    End Sub


    Private Sub txtnombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnombre.TextChanged
        ErrorProvider2.Clear()
    End Sub

    Private Sub txtdescripcion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdescripcion.TextChanged
        ErrorProvider3.Clear()
    End Sub

    Private Sub txtprecio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtprecio.TextChanged
        ErrorProvider4.Clear()
    End Sub

    Private Sub txtcantidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcantidad.TextChanged
        ErrorProvider5.Clear()
    End Sub

    Private Sub txtimporte_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtimporte.TextChanged
        ErrorProvider6.Clear()
    End Sub

    Private Sub txtfecha_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtfecha.TextChanged
        ErrorProvider7.Clear()
    End Sub

    Private Sub txtnombreprove_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnombreprove.TextChanged
        ErrorProvider8.Clear()
    End Sub
End Class