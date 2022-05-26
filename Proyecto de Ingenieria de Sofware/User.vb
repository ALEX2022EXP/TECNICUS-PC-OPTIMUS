Public Class User

    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        If txtlogin.Text = "sistemas" And Me.txtcontraseña.Text = "1" Then Form1.Show()
        If txtlogin.Text = "sistemas" And Me.txtcontraseña.Text = "1" Then
            MsgBox("BIENVENIDO AL SISTEMA")
        Else
            MsgBox("CONTRASEÑA INCORRECTA")
            txtlogin.Clear()
            txtcontraseña.Clear()
            txtlogin.Focus()
        End If
    End Sub
    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Close()
    End Sub

    Private Sub txtlogin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtlogin.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtcontraseña.Focus()
        End If
    End Sub
    Private Sub btncancelar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        txtcontraseña.Clear()
        txtlogin.Clear()
        txtlogin.Focus()
    End Sub

    Private Sub txtcontraseña_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcontraseña.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnlogin.Focus()
        End If
    End Sub

   
    Private Sub User_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtlogin.Focus()
    End Sub
End Class