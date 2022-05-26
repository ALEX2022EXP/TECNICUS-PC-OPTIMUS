Imports System.Data.OleDb

Public Class ALTASCLIENTES

    Dim CN As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\david\Desktop\PROYECTO DE INGENIERIA DE SOFWARE\Proyecto de Ingenieria de Sofware\BD TECNICUS PC OPTIMUS.accdb")
    Dim IMAGEN As String
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

        Try
            Me.OpenFileDialog1.ShowDialog()
            If Me.OpenFileDialog1.FileName <> "" Then
                IMAGEN = OpenFileDialog1.FileName
                Dim largo As Integer = IMAGEN.Length
                Dim imagen2 As String
                imagen2 = CStr(Microsoft.VisualBasic.Mid(RTrim(IMAGEN), largo - 2, largo))
                If imagen2 <> "gif" And imagen2 <> "bmp" And imagen2 <> "jpg" And imagen2 <> "jpeg" And imagen2 <> "GIF" And imagen2 <> "BMP" And imagen2 <> "JPG" And imagen2 <> "JPEG" Then
                    imagen2 = CStr(Microsoft.VisualBasic.Mid(RTrim(IMAGEN), largo - 3, largo))
                    If imagen2 <> "jpeg" And imagen2 <> "JPEG" And imagen2 <> "log1" Then MsgBox("Formato de imagen no vàlido, seleccione otra imagen") : Exit Sub
                    If imagen2 <> "log1" Then Exit Sub
                End If
                PictureBox1.Load(IMAGEN)
            End If
        Catch ex As Exception
            PictureBox1.Load(Application.StartupPath & "\SIGNO.JPEG")
        End Try
    End Sub

    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
        Try
            CN.Close()
            Dim cmd As New OleDb.OleDbCommand("Insert into CLIENTE (CLAVE, NOMBRE, APELLIDOS, DIRRECCION,DESCRIPCION_DE_LA_REPARACION,COSTO_DE_LA_REPARACION,FOTO)  VALUES ('" & txtid.Text & "','" & txtnombre.Text & "','" & txtapellidos.Text & "','" & txtdireccion.Text & "','" & txtdescripcion.Text & "','" & txtcos.Text & "','" & IMAGEN & "')", CN)
            CN.Open()
            cmd.ExecuteNonQuery()
            If MessageBox.Show("SE HA GUARDADO CORRECTAMENTE ¿DESEAS DAR OTRO REGISTRO?", "ALTAS PRODUCTOS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                txtid.Focus()
                limpiar()
                ocultar()
                PictureBox1.Load(Application.StartupPath & "\SIGNO.JPEG")
            Else
                Close()
            End If

        Catch ex As Exception
            MessageBox.Show("LA CLAVE DEL CLIENTE  YA EXISTE, DIGITA OTRA CLAVE", "ALTAS CLIENTES", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtid.Focus()
            txtid.Clear()

        End Try
        Try
        Catch exc As Exception
            MsgBox("OCURRIO UN ERROR")
        End Try

    End Sub
    Sub limpiar()
        txtid.Text = ""
        txtnombre.Text = ""
        txtapellidos.Text = ""
        txtdireccion.Text = ""
        txtdescripcion.Text = ""
        txtcos.Text = ""
        btnguardar.Enabled = True
        btncancelar.Enabled = True
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
        btnguardar.Visible = False
        btncancelar.Visible = False

    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        PictureBox1.Load(Application.StartupPath & "\SIGNO.JPEG")
        limpiar()
        ocultar()
        txtid.Focus()

    End Sub



    Private Sub txtid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtid.KeyPress
        If Me.txtid.Text.Length = 0 Then
            ErrorProvider1.SetError(Me.txtid, "DEBE DIGITAR LA CLAVE")

        Else
            If Asc(e.KeyChar) = 13 Then
                Me.lblnombre.Visible = True
                Me.txtnombre.Visible = True
                Me.btncancelar.Visible = True
                txtnombre.Focus()
            End If
            End If
    End Sub

    Private Sub txtid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtid.TextChanged
        ErrorProvider1.Clear()
    End Sub

    Private Sub txtnombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnombre.KeyPress
        If Me.txtnombre.Text.Length = 0 Then
            ErrorProvider2.SetError(Me.txtnombre, "DEBE DIGITAR UN NOMBRE")

        Else

            If Asc(e.KeyChar) = 13 Then
                Me.lblapellidos.Visible = True
                Me.txtapellidos.Visible = True
                txtapellidos.Focus()
            End If
            End If
    End Sub

    Private Sub txtnombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnombre.TextChanged
        ErrorProvider2.Clear()
    End Sub

    Private Sub txtapellidos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtapellidos.KeyPress
        If Me.txtapellidos.Text.Length = 0 Then
            ErrorProvider3.SetError(Me.txtapellidos, "DEBE DIGITAR LOS APELLIDOS")

        Else

            If Asc(e.KeyChar) = 13 Then
                Me.lbldireccion.Visible = True
                Me.txtdireccion.Visible = True
                txtdireccion.Focus()
            End If
            End If
    End Sub

    Private Sub txtapellidos_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtapellidos.TextChanged
        ErrorProvider3.Clear()
    End Sub

    Private Sub txtdireccion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdireccion.KeyPress
        If Me.txtdireccion.Text.Length = 0 Then
            ErrorProvider4.SetError(Me.txtdireccion, "DEBE DIGITAR UNA DIRECCION")

        Else

            If Asc(e.KeyChar) = 13 Then
                Me.lbldescripcion.Visible = True
                Me.txtdescripcion.Visible = True
                txtdescripcion.Focus()
            End If
            End If
    End Sub

    Private Sub txtdireccion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdireccion.TextChanged
        ErrorProvider4.Clear()
    End Sub

    Private Sub txtcos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcos.KeyPress
        If Me.txtcos.Text.Length = 0 Then
            ErrorProvider6.SetError(Me.txtcos, "DEBE DIGITAR EL COSTO DE LA REPARACION")

        Else

            If Asc(e.KeyChar) = 13 Then
                Me.btnguardar.Visible = True
            End If
            End If
    End Sub

    Private Sub txtcos_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcos.TextChanged
        ErrorProvider6.Clear()
    End Sub

    Private Sub lblcosto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblcosto.Click

    End Sub

    Private Sub txtdescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdescripcion.KeyPress
        If Me.txtdescripcion.Text.Length = 0 Then
            ErrorProvider5.SetError(Me.txtdescripcion, "DEBE DIGITAR UNA DESCRIPCION ")

        Else
            If Asc(e.KeyChar) = 13 Then
                Me.lblcosto.Visible = True
                Me.txtcos.Visible = True
                txtcos.Focus()
            End If
            End If
    End Sub

    Private Sub txtdescripcion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdescripcion.TextChanged
        ErrorProvider5.Clear()
    End Sub

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Close()
    End Sub

    Private Sub ALTASCLIENTES_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class