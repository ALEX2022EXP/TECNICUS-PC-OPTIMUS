<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class User
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(User))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtlogin = New System.Windows.Forms.TextBox()
        Me.txtcontraseña = New System.Windows.Forms.TextBox()
        Me.lblusuario = New System.Windows.Forms.Label()
        Me.lblcontraseña = New System.Windows.Forms.Label()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Gray
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.Controls.Add(Me.txtlogin)
        Me.GroupBox1.Controls.Add(Me.txtcontraseña)
        Me.GroupBox1.Controls.Add(Me.lblusuario)
        Me.GroupBox1.Controls.Add(Me.lblcontraseña)
        Me.GroupBox1.Location = New System.Drawing.Point(120, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(266, 131)
        Me.GroupBox1.TabIndex = 86
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cuentas"
        '
        'txtlogin
        '
        Me.txtlogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtlogin.Location = New System.Drawing.Point(149, 33)
        Me.txtlogin.Name = "txtlogin"
        Me.txtlogin.Size = New System.Drawing.Size(100, 20)
        Me.txtlogin.TabIndex = 83
        '
        'txtcontraseña
        '
        Me.txtcontraseña.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtcontraseña.Location = New System.Drawing.Point(149, 78)
        Me.txtcontraseña.Name = "txtcontraseña"
        Me.txtcontraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtcontraseña.Size = New System.Drawing.Size(100, 20)
        Me.txtcontraseña.TabIndex = 82
        '
        'lblusuario
        '
        Me.lblusuario.AutoSize = True
        Me.lblusuario.BackColor = System.Drawing.Color.Black
        Me.lblusuario.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.lblusuario.Location = New System.Drawing.Point(28, 40)
        Me.lblusuario.Name = "lblusuario"
        Me.lblusuario.Size = New System.Drawing.Size(33, 13)
        Me.lblusuario.TabIndex = 79
        Me.lblusuario.Text = "Login"
        '
        'lblcontraseña
        '
        Me.lblcontraseña.AutoSize = True
        Me.lblcontraseña.BackColor = System.Drawing.SystemColors.InfoText
        Me.lblcontraseña.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.lblcontraseña.Location = New System.Drawing.Point(28, 85)
        Me.lblcontraseña.Name = "lblcontraseña"
        Me.lblcontraseña.Size = New System.Drawing.Size(53, 13)
        Me.lblcontraseña.TabIndex = 80
        Me.lblcontraseña.Text = "Password"
        '
        'btnsalir
        '
        Me.btnsalir.BackgroundImage = CType(resources.GetObject("btnsalir.BackgroundImage"), System.Drawing.Image)
        Me.btnsalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnsalir.Location = New System.Drawing.Point(446, 245)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(38, 32)
        Me.btnsalir.TabIndex = 84
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'btnlogin
        '
        Me.btnlogin.BackgroundImage = CType(resources.GetObject("btnlogin.BackgroundImage"), System.Drawing.Image)
        Me.btnlogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnlogin.Location = New System.Drawing.Point(138, 172)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(142, 31)
        Me.btnlogin.TabIndex = 83
        Me.btnlogin.UseVisualStyleBackColor = True
        '
        'btncancelar
        '
        Me.btncancelar.BackgroundImage = CType(resources.GetObject("btncancelar.BackgroundImage"), System.Drawing.Image)
        Me.btncancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btncancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btncancelar.Location = New System.Drawing.Point(301, 168)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(56, 48)
        Me.btncancelar.TabIndex = 87
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ErrorProvider2
        '
        Me.ErrorProvider2.ContainerControl = Me
        '
        'User
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(484, 277)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btnlogin)
        Me.Name = "User"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtlogin As System.Windows.Forms.TextBox
    Friend WithEvents txtcontraseña As System.Windows.Forms.TextBox
    Friend WithEvents lblusuario As System.Windows.Forms.Label
    Friend WithEvents lblcontraseña As System.Windows.Forms.Label
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents btnlogin As System.Windows.Forms.Button
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErrorProvider2 As System.Windows.Forms.ErrorProvider
End Class
