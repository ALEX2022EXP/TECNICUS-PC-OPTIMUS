<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ALTASCLIENTES
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ALTASCLIENTES))
        Me.txtcos = New System.Windows.Forms.TextBox()
        Me.lblcosto = New System.Windows.Forms.Label()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.lbldescripcion = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtapellidos = New System.Windows.Forms.TextBox()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.lbldireccion = New System.Windows.Forms.Label()
        Me.lblapellidos = New System.Windows.Forms.Label()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.lblclave = New System.Windows.Forms.Label()
        Me.txtcosto = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblseleccione = New System.Windows.Forms.Label()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider3 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider4 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider5 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider6 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtcos
        '
        Me.txtcos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtcos.Font = New System.Drawing.Font("Broadway", 12.0!, System.Drawing.FontStyle.Italic)
        Me.txtcos.Location = New System.Drawing.Point(616, 428)
        Me.txtcos.Name = "txtcos"
        Me.txtcos.Size = New System.Drawing.Size(125, 26)
        Me.txtcos.TabIndex = 81
        Me.txtcos.Visible = False
        '
        'lblcosto
        '
        Me.lblcosto.AutoSize = True
        Me.lblcosto.BackColor = System.Drawing.Color.MediumOrchid
        Me.lblcosto.Font = New System.Drawing.Font("Broadway", 12.0!, System.Drawing.FontStyle.Italic)
        Me.lblcosto.Location = New System.Drawing.Point(313, 431)
        Me.lblcosto.Name = "lblcosto"
        Me.lblcosto.Size = New System.Drawing.Size(236, 19)
        Me.lblcosto.TabIndex = 80
        Me.lblcosto.Text = "COSTO DE LA REPARACION"
        Me.lblcosto.Visible = False
        '
        'txtdescripcion
        '
        Me.txtdescripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtdescripcion.Font = New System.Drawing.Font("Broadway", 12.0!, System.Drawing.FontStyle.Italic)
        Me.txtdescripcion.Location = New System.Drawing.Point(616, 396)
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(490, 26)
        Me.txtdescripcion.TabIndex = 79
        Me.txtdescripcion.Visible = False
        '
        'lbldescripcion
        '
        Me.lbldescripcion.AutoSize = True
        Me.lbldescripcion.BackColor = System.Drawing.Color.MediumOrchid
        Me.lbldescripcion.Font = New System.Drawing.Font("Broadway", 12.0!, System.Drawing.FontStyle.Italic)
        Me.lbldescripcion.Location = New System.Drawing.Point(313, 399)
        Me.lbldescripcion.Name = "lbldescripcion"
        Me.lbldescripcion.Size = New System.Drawing.Size(297, 19)
        Me.lbldescripcion.TabIndex = 78
        Me.lbldescripcion.Text = "DESCRIPCION DE LA REPARACION"
        Me.lbldescripcion.Visible = False
        '
        'txtnombre
        '
        Me.txtnombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtnombre.Font = New System.Drawing.Font("Broadway", 12.0!, System.Drawing.FontStyle.Italic)
        Me.txtnombre.Location = New System.Drawing.Point(478, 287)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(336, 26)
        Me.txtnombre.TabIndex = 77
        Me.txtnombre.Visible = False
        '
        'txtapellidos
        '
        Me.txtapellidos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtapellidos.Font = New System.Drawing.Font("Broadway", 12.0!, System.Drawing.FontStyle.Italic)
        Me.txtapellidos.Location = New System.Drawing.Point(478, 319)
        Me.txtapellidos.Name = "txtapellidos"
        Me.txtapellidos.Size = New System.Drawing.Size(336, 26)
        Me.txtapellidos.TabIndex = 76
        Me.txtapellidos.Visible = False
        '
        'txtdireccion
        '
        Me.txtdireccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtdireccion.Font = New System.Drawing.Font("Broadway", 12.0!, System.Drawing.FontStyle.Italic)
        Me.txtdireccion.Location = New System.Drawing.Point(478, 354)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(336, 26)
        Me.txtdireccion.TabIndex = 75
        Me.txtdireccion.Visible = False
        '
        'txtid
        '
        Me.txtid.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtid.Font = New System.Drawing.Font("Broadway", 12.0!, System.Drawing.FontStyle.Italic)
        Me.txtid.Location = New System.Drawing.Point(478, 251)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(78, 26)
        Me.txtid.TabIndex = 74
        '
        'lbldireccion
        '
        Me.lbldireccion.AutoSize = True
        Me.lbldireccion.BackColor = System.Drawing.Color.MediumOrchid
        Me.lbldireccion.Font = New System.Drawing.Font("Broadway", 12.0!, System.Drawing.FontStyle.Italic)
        Me.lbldireccion.Location = New System.Drawing.Point(314, 361)
        Me.lbldireccion.Name = "lbldireccion"
        Me.lbldireccion.Size = New System.Drawing.Size(104, 19)
        Me.lbldireccion.TabIndex = 73
        Me.lbldireccion.Text = "DIRECCION"
        Me.lbldireccion.Visible = False
        '
        'lblapellidos
        '
        Me.lblapellidos.AutoSize = True
        Me.lblapellidos.BackColor = System.Drawing.Color.MediumOrchid
        Me.lblapellidos.Font = New System.Drawing.Font("Broadway", 12.0!, System.Drawing.FontStyle.Italic)
        Me.lblapellidos.Location = New System.Drawing.Point(314, 326)
        Me.lblapellidos.Name = "lblapellidos"
        Me.lblapellidos.Size = New System.Drawing.Size(107, 19)
        Me.lblapellidos.TabIndex = 72
        Me.lblapellidos.Text = "APELLIDOS"
        Me.lblapellidos.Visible = False
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.BackColor = System.Drawing.Color.MediumOrchid
        Me.lblnombre.Font = New System.Drawing.Font("Broadway", 12.0!, System.Drawing.FontStyle.Italic)
        Me.lblnombre.Location = New System.Drawing.Point(315, 294)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(82, 19)
        Me.lblnombre.TabIndex = 71
        Me.lblnombre.Text = "NOMBRE"
        Me.lblnombre.Visible = False
        '
        'lblclave
        '
        Me.lblclave.AutoSize = True
        Me.lblclave.BackColor = System.Drawing.Color.MediumOrchid
        Me.lblclave.Font = New System.Drawing.Font("Broadway", 12.0!, System.Drawing.FontStyle.Italic)
        Me.lblclave.Location = New System.Drawing.Point(313, 251)
        Me.lblclave.Name = "lblclave"
        Me.lblclave.Size = New System.Drawing.Size(67, 19)
        Me.lblclave.TabIndex = 70
        Me.lblclave.Text = "CLAVE"
        '
        'txtcosto
        '
        Me.txtcosto.BackgroundImage = CType(resources.GetObject("txtcosto.BackgroundImage"), System.Drawing.Image)
        Me.txtcosto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.txtcosto.Location = New System.Drawing.Point(-1, -6)
        Me.txtcosto.Name = "txtcosto"
        Me.txtcosto.Size = New System.Drawing.Size(1371, 158)
        Me.txtcosto.TabIndex = 82
        Me.txtcosto.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.BackgroundImage = CType(resources.GetObject("btnsalir.BackgroundImage"), System.Drawing.Image)
        Me.btnsalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnsalir.Location = New System.Drawing.Point(1000, 484)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(42, 38)
        Me.btnsalir.TabIndex = 85
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'btnguardar
        '
        Me.btnguardar.BackgroundImage = CType(resources.GetObject("btnguardar.BackgroundImage"), System.Drawing.Image)
        Me.btnguardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnguardar.Location = New System.Drawing.Point(542, 469)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(66, 53)
        Me.btnguardar.TabIndex = 84
        Me.btnguardar.UseVisualStyleBackColor = True
        Me.btnguardar.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Thistle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(475, 169)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(81, 76)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 83
        Me.PictureBox1.TabStop = False
        '
        'lblseleccione
        '
        Me.lblseleccione.AutoSize = True
        Me.lblseleccione.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblseleccione.Location = New System.Drawing.Point(314, 202)
        Me.lblseleccione.Name = "lblseleccione"
        Me.lblseleccione.Size = New System.Drawing.Size(108, 13)
        Me.lblseleccione.TabIndex = 86
        Me.lblseleccione.Text = "Seleccionar una foto "
        '
        'btncancelar
        '
        Me.btncancelar.BackgroundImage = CType(resources.GetObject("btncancelar.BackgroundImage"), System.Drawing.Image)
        Me.btncancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btncancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btncancelar.Location = New System.Drawing.Point(647, 469)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(66, 56)
        Me.btncancelar.TabIndex = 87
        Me.btncancelar.UseVisualStyleBackColor = True
        Me.btncancelar.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
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
        'ErrorProvider6
        '
        Me.ErrorProvider6.ContainerControl = Me
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1346, 24)
        Me.MenuStrip1.TabIndex = 88
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ALTASCLIENTES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1346, 567)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.lblseleccione)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtcosto)
        Me.Controls.Add(Me.txtcos)
        Me.Controls.Add(Me.lblcosto)
        Me.Controls.Add(Me.txtdescripcion)
        Me.Controls.Add(Me.lbldescripcion)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.txtapellidos)
        Me.Controls.Add(Me.txtdireccion)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.lbldireccion)
        Me.Controls.Add(Me.lblapellidos)
        Me.Controls.Add(Me.lblnombre)
        Me.Controls.Add(Me.lblclave)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "ALTASCLIENTES"
        Me.Text = "ALTASCLIENTES"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtcos As System.Windows.Forms.TextBox
    Friend WithEvents lblcosto As System.Windows.Forms.Label
    Friend WithEvents txtdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents lbldescripcion As System.Windows.Forms.Label
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents txtapellidos As System.Windows.Forms.TextBox
    Friend WithEvents txtdireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents lbldireccion As System.Windows.Forms.Label
    Friend WithEvents lblapellidos As System.Windows.Forms.Label
    Friend WithEvents lblnombre As System.Windows.Forms.Label
    Friend WithEvents lblclave As System.Windows.Forms.Label
    Friend WithEvents txtcosto As System.Windows.Forms.Button
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents btnguardar As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblseleccione As System.Windows.Forms.Label
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErrorProvider2 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErrorProvider3 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErrorProvider4 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErrorProvider5 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErrorProvider6 As System.Windows.Forms.ErrorProvider
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
End Class
