<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ALTAS_PROVEEDORES
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ALTAS_PROVEEDORES))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtclave = New System.Windows.Forms.TextBox()
        Me.lbltelefono = New System.Windows.Forms.Label()
        Me.lbldireccion = New System.Windows.Forms.Label()
        Me.lblciudad = New System.Windows.Forms.Label()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.txtciudad = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.lblclave = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider3 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider4 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider5 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.Controls.Add(Me.txtclave)
        Me.GroupBox1.Controls.Add(Me.lbltelefono)
        Me.GroupBox1.Controls.Add(Me.lbldireccion)
        Me.GroupBox1.Controls.Add(Me.lblciudad)
        Me.GroupBox1.Controls.Add(Me.lblnombre)
        Me.GroupBox1.Controls.Add(Me.txttelefono)
        Me.GroupBox1.Controls.Add(Me.txtdireccion)
        Me.GroupBox1.Controls.Add(Me.txtciudad)
        Me.GroupBox1.Controls.Add(Me.txtnombre)
        Me.GroupBox1.Controls.Add(Me.lblclave)
        Me.GroupBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GroupBox1.Font = New System.Drawing.Font("Showcard Gothic", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(381, 215)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(690, 251)
        Me.GroupBox1.TabIndex = 84
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Altas de Proveedor"
        '
        'txtclave
        '
        Me.txtclave.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtclave.Font = New System.Drawing.Font("Broadway", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtclave.Location = New System.Drawing.Point(317, 50)
        Me.txtclave.Name = "txtclave"
        Me.txtclave.Size = New System.Drawing.Size(121, 26)
        Me.txtclave.TabIndex = 83
        '
        'lbltelefono
        '
        Me.lbltelefono.AutoSize = True
        Me.lbltelefono.BackColor = System.Drawing.SystemColors.ControlText
        Me.lbltelefono.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Italic)
        Me.lbltelefono.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbltelefono.Location = New System.Drawing.Point(145, 190)
        Me.lbltelefono.Name = "lbltelefono"
        Me.lbltelefono.Size = New System.Drawing.Size(80, 19)
        Me.lbltelefono.TabIndex = 82
        Me.lbltelefono.Text = "Telefono"
        Me.lbltelefono.Visible = False
        '
        'lbldireccion
        '
        Me.lbldireccion.AutoSize = True
        Me.lbldireccion.BackColor = System.Drawing.SystemColors.ControlText
        Me.lbldireccion.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Italic)
        Me.lbldireccion.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbldireccion.Location = New System.Drawing.Point(145, 157)
        Me.lbldireccion.Name = "lbldireccion"
        Me.lbldireccion.Size = New System.Drawing.Size(88, 19)
        Me.lbldireccion.TabIndex = 81
        Me.lbldireccion.Text = "Direccion"
        Me.lbldireccion.Visible = False
        '
        'lblciudad
        '
        Me.lblciudad.AutoSize = True
        Me.lblciudad.BackColor = System.Drawing.SystemColors.ControlText
        Me.lblciudad.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Italic)
        Me.lblciudad.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblciudad.Location = New System.Drawing.Point(145, 125)
        Me.lblciudad.Name = "lblciudad"
        Me.lblciudad.Size = New System.Drawing.Size(67, 19)
        Me.lblciudad.TabIndex = 80
        Me.lblciudad.Text = "Ciudad"
        Me.lblciudad.Visible = False
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.BackColor = System.Drawing.SystemColors.ControlText
        Me.lblnombre.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Italic)
        Me.lblnombre.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblnombre.Location = New System.Drawing.Point(145, 91)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(167, 19)
        Me.lblnombre.TabIndex = 79
        Me.lblnombre.Text = "Nombre_Proveedor"
        Me.lblnombre.Visible = False
        '
        'txttelefono
        '
        Me.txttelefono.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txttelefono.Font = New System.Drawing.Font("Broadway", 12.0!, System.Drawing.FontStyle.Italic)
        Me.txttelefono.Location = New System.Drawing.Point(317, 184)
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(235, 26)
        Me.txttelefono.TabIndex = 77
        Me.txttelefono.Visible = False
        '
        'txtdireccion
        '
        Me.txtdireccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtdireccion.Font = New System.Drawing.Font("Broadway", 12.0!, System.Drawing.FontStyle.Italic)
        Me.txtdireccion.Location = New System.Drawing.Point(317, 151)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(235, 26)
        Me.txtdireccion.TabIndex = 76
        Me.txtdireccion.Visible = False
        '
        'txtciudad
        '
        Me.txtciudad.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtciudad.Font = New System.Drawing.Font("Broadway", 12.0!, System.Drawing.FontStyle.Italic)
        Me.txtciudad.Location = New System.Drawing.Point(317, 121)
        Me.txtciudad.Name = "txtciudad"
        Me.txtciudad.Size = New System.Drawing.Size(234, 26)
        Me.txtciudad.TabIndex = 75
        Me.txtciudad.Visible = False
        '
        'txtnombre
        '
        Me.txtnombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtnombre.Font = New System.Drawing.Font("Broadway", 12.0!, System.Drawing.FontStyle.Italic)
        Me.txtnombre.Location = New System.Drawing.Point(317, 88)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(235, 26)
        Me.txtnombre.TabIndex = 74
        Me.txtnombre.Visible = False
        '
        'lblclave
        '
        Me.lblclave.AutoSize = True
        Me.lblclave.BackColor = System.Drawing.SystemColors.ControlText
        Me.lblclave.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Italic)
        Me.lblclave.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblclave.Location = New System.Drawing.Point(146, 57)
        Me.lblclave.Name = "lblclave"
        Me.lblclave.Size = New System.Drawing.Size(147, 19)
        Me.lblclave.TabIndex = 72
        Me.lblclave.Text = "Clave_Proveedor"
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(0, -5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(1375, 158)
        Me.Button1.TabIndex = 83
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btncancelar
        '
        Me.btncancelar.BackgroundImage = CType(resources.GetObject("btncancelar.BackgroundImage"), System.Drawing.Image)
        Me.btncancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btncancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btncancelar.Location = New System.Drawing.Point(825, 478)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(66, 56)
        Me.btncancelar.TabIndex = 86
        Me.btncancelar.UseVisualStyleBackColor = True
        Me.btncancelar.Visible = False
        '
        'btnguardar
        '
        Me.btnguardar.BackgroundImage = CType(resources.GetObject("btnguardar.BackgroundImage"), System.Drawing.Image)
        Me.btnguardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnguardar.Location = New System.Drawing.Point(753, 478)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(66, 56)
        Me.btnguardar.TabIndex = 85
        Me.btnguardar.UseVisualStyleBackColor = True
        Me.btnguardar.Visible = False
        '
        'btnsalir
        '
        Me.btnsalir.BackgroundImage = CType(resources.GetObject("btnsalir.BackgroundImage"), System.Drawing.Image)
        Me.btnsalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnsalir.Location = New System.Drawing.Point(1028, 486)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(43, 40)
        Me.btnsalir.TabIndex = 87
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ErrorProvider2
        '
        Me.ErrorProvider2.ContainerControl = Me
        '
        'ErrorProvider3
        '
        Me.ErrorProvider3.ContainerControl = Me
        '
        'ErrorProvider4
        '
        Me.ErrorProvider4.ContainerControl = Me
        '
        'ErrorProvider5
        '
        Me.ErrorProvider5.ContainerControl = Me
        '
        'ALTAS_PROVEEDORES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1370, 567)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "ALTAS_PROVEEDORES"
        Me.Text = "ALTAS_PROVEEDORES"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbltelefono As System.Windows.Forms.Label
    Friend WithEvents lbldireccion As System.Windows.Forms.Label
    Friend WithEvents lblciudad As System.Windows.Forms.Label
    Friend WithEvents lblnombre As System.Windows.Forms.Label
    Friend WithEvents txttelefono As System.Windows.Forms.TextBox
    Friend WithEvents txtdireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtciudad As System.Windows.Forms.TextBox
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents lblclave As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents btnguardar As System.Windows.Forms.Button
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents txtclave As System.Windows.Forms.TextBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErrorProvider2 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErrorProvider3 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErrorProvider4 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErrorProvider5 As System.Windows.Forms.ErrorProvider
End Class
