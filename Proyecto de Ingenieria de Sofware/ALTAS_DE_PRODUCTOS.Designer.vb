<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ALTAS_DE_PRODUCTOS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ALTAS_DE_PRODUCTOS))
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbldescripcion = New System.Windows.Forms.Label()
        Me.txtclave = New System.Windows.Forms.TextBox()
        Me.txtfecha = New System.Windows.Forms.TextBox()
        Me.txtnombreprove = New System.Windows.Forms.TextBox()
        Me.txtimporte = New System.Windows.Forms.TextBox()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.lblnombreprove = New System.Windows.Forms.Label()
        Me.lblfecha = New System.Windows.Forms.Label()
        Me.lblimporte = New System.Windows.Forms.Label()
        Me.lblcantidad = New System.Windows.Forms.Label()
        Me.lblprecio = New System.Windows.Forms.Label()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.lblclave = New System.Windows.Forms.Label()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider3 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider4 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider5 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider6 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider7 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider8 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox2.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnguardar
        '
        Me.btnguardar.BackgroundImage = CType(resources.GetObject("btnguardar.BackgroundImage"), System.Drawing.Image)
        Me.btnguardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnguardar.Location = New System.Drawing.Point(741, 567)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(66, 56)
        Me.btnguardar.TabIndex = 32
        Me.btnguardar.UseVisualStyleBackColor = True
        Me.btnguardar.Visible = False
        '
        'btncancelar
        '
        Me.btncancelar.BackgroundImage = CType(resources.GetObject("btncancelar.BackgroundImage"), System.Drawing.Image)
        Me.btncancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btncancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btncancelar.Location = New System.Drawing.Point(813, 567)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(66, 56)
        Me.btncancelar.TabIndex = 37
        Me.btncancelar.UseVisualStyleBackColor = True
        Me.btncancelar.Visible = False
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Location = New System.Drawing.Point(1, -1)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(1365, 158)
        Me.Button3.TabIndex = 49
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Azure
        Me.GroupBox2.BackgroundImage = CType(resources.GetObject("GroupBox2.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox2.Controls.Add(Me.lbldescripcion)
        Me.GroupBox2.Controls.Add(Me.txtclave)
        Me.GroupBox2.Controls.Add(Me.txtfecha)
        Me.GroupBox2.Controls.Add(Me.txtnombreprove)
        Me.GroupBox2.Controls.Add(Me.txtimporte)
        Me.GroupBox2.Controls.Add(Me.txtcantidad)
        Me.GroupBox2.Controls.Add(Me.txtprecio)
        Me.GroupBox2.Controls.Add(Me.txtdescripcion)
        Me.GroupBox2.Controls.Add(Me.txtnombre)
        Me.GroupBox2.Controls.Add(Me.lblnombreprove)
        Me.GroupBox2.Controls.Add(Me.lblfecha)
        Me.GroupBox2.Controls.Add(Me.lblimporte)
        Me.GroupBox2.Controls.Add(Me.lblcantidad)
        Me.GroupBox2.Controls.Add(Me.lblprecio)
        Me.GroupBox2.Controls.Add(Me.lblnombre)
        Me.GroupBox2.Controls.Add(Me.lblclave)
        Me.GroupBox2.Font = New System.Drawing.Font("Showcard Gothic", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox2.Location = New System.Drawing.Point(328, 220)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(738, 337)
        Me.GroupBox2.TabIndex = 48
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Altas de Producto"
        '
        'lbldescripcion
        '
        Me.lbldescripcion.AutoSize = True
        Me.lbldescripcion.BackColor = System.Drawing.SystemColors.ControlText
        Me.lbldescripcion.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Italic)
        Me.lbldescripcion.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbldescripcion.Location = New System.Drawing.Point(170, 126)
        Me.lbldescripcion.Name = "lbldescripcion"
        Me.lbldescripcion.Size = New System.Drawing.Size(107, 19)
        Me.lbldescripcion.TabIndex = 51
        Me.lbldescripcion.Text = "Descripciòn"
        Me.lbldescripcion.Visible = False
        '
        'txtclave
        '
        Me.txtclave.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtclave.Font = New System.Drawing.Font("Broadway", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtclave.Location = New System.Drawing.Point(358, 48)
        Me.txtclave.Name = "txtclave"
        Me.txtclave.Size = New System.Drawing.Size(121, 26)
        Me.txtclave.TabIndex = 50
        '
        'txtfecha
        '
        Me.txtfecha.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtfecha.Font = New System.Drawing.Font("Broadway", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfecha.Location = New System.Drawing.Point(358, 242)
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.Size = New System.Drawing.Size(225, 26)
        Me.txtfecha.TabIndex = 49
        Me.txtfecha.Visible = False
        '
        'txtnombreprove
        '
        Me.txtnombreprove.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtnombreprove.Font = New System.Drawing.Font("Broadway", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombreprove.Location = New System.Drawing.Point(358, 274)
        Me.txtnombreprove.Name = "txtnombreprove"
        Me.txtnombreprove.Size = New System.Drawing.Size(225, 26)
        Me.txtnombreprove.TabIndex = 47
        Me.txtnombreprove.Visible = False
        '
        'txtimporte
        '
        Me.txtimporte.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtimporte.Font = New System.Drawing.Font("Broadway", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtimporte.Location = New System.Drawing.Point(358, 213)
        Me.txtimporte.Name = "txtimporte"
        Me.txtimporte.Size = New System.Drawing.Size(225, 26)
        Me.txtimporte.TabIndex = 45
        Me.txtimporte.Visible = False
        '
        'txtcantidad
        '
        Me.txtcantidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtcantidad.Font = New System.Drawing.Font("Broadway", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcantidad.Location = New System.Drawing.Point(358, 183)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(225, 26)
        Me.txtcantidad.TabIndex = 44
        Me.txtcantidad.Visible = False
        '
        'txtprecio
        '
        Me.txtprecio.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtprecio.Font = New System.Drawing.Font("Broadway", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprecio.Location = New System.Drawing.Point(358, 151)
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(225, 26)
        Me.txtprecio.TabIndex = 43
        Me.txtprecio.Visible = False
        '
        'txtdescripcion
        '
        Me.txtdescripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtdescripcion.Font = New System.Drawing.Font("Broadway", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdescripcion.Location = New System.Drawing.Point(358, 117)
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(225, 26)
        Me.txtdescripcion.TabIndex = 42
        Me.txtdescripcion.Visible = False
        '
        'txtnombre
        '
        Me.txtnombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtnombre.Font = New System.Drawing.Font("Broadway", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombre.Location = New System.Drawing.Point(358, 84)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(225, 26)
        Me.txtnombre.TabIndex = 41
        Me.txtnombre.Visible = False
        '
        'lblnombreprove
        '
        Me.lblnombreprove.AutoSize = True
        Me.lblnombreprove.BackColor = System.Drawing.SystemColors.ControlText
        Me.lblnombreprove.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Italic)
        Me.lblnombreprove.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblnombreprove.Location = New System.Drawing.Point(169, 277)
        Me.lblnombreprove.Name = "lblnombreprove"
        Me.lblnombreprove.Size = New System.Drawing.Size(167, 19)
        Me.lblnombreprove.TabIndex = 39
        Me.lblnombreprove.Text = "Nombre_proveedor"
        Me.lblnombreprove.Visible = False
        '
        'lblfecha
        '
        Me.lblfecha.AutoSize = True
        Me.lblfecha.BackColor = System.Drawing.SystemColors.ControlText
        Me.lblfecha.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfecha.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblfecha.Location = New System.Drawing.Point(169, 252)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(56, 19)
        Me.lblfecha.TabIndex = 38
        Me.lblfecha.Text = "Fecha"
        Me.lblfecha.Visible = False
        '
        'lblimporte
        '
        Me.lblimporte.AutoSize = True
        Me.lblimporte.BackColor = System.Drawing.SystemColors.ControlText
        Me.lblimporte.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblimporte.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblimporte.Location = New System.Drawing.Point(169, 226)
        Me.lblimporte.Name = "lblimporte"
        Me.lblimporte.Size = New System.Drawing.Size(123, 19)
        Me.lblimporte.TabIndex = 37
        Me.lblimporte.Text = "Importe Total"
        Me.lblimporte.Visible = False
        '
        'lblcantidad
        '
        Me.lblcantidad.AutoSize = True
        Me.lblcantidad.BackColor = System.Drawing.SystemColors.ControlText
        Me.lblcantidad.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcantidad.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblcantidad.Location = New System.Drawing.Point(169, 196)
        Me.lblcantidad.Name = "lblcantidad"
        Me.lblcantidad.Size = New System.Drawing.Size(161, 19)
        Me.lblcantidad.TabIndex = 36
        Me.lblcantidad.Text = "Cantidad_Artìculo"
        Me.lblcantidad.Visible = False
        '
        'lblprecio
        '
        Me.lblprecio.AutoSize = True
        Me.lblprecio.BackColor = System.Drawing.SystemColors.ControlText
        Me.lblprecio.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprecio.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblprecio.Location = New System.Drawing.Point(169, 163)
        Me.lblprecio.Name = "lblprecio"
        Me.lblprecio.Size = New System.Drawing.Size(61, 19)
        Me.lblprecio.TabIndex = 35
        Me.lblprecio.Text = "Precio"
        Me.lblprecio.Visible = False
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.BackColor = System.Drawing.SystemColors.ControlText
        Me.lblnombre.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombre.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblnombre.Location = New System.Drawing.Point(169, 93)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(74, 19)
        Me.lblnombre.TabIndex = 33
        Me.lblnombre.Text = "Nombre"
        Me.lblnombre.Visible = False
        '
        'lblclave
        '
        Me.lblclave.AutoSize = True
        Me.lblclave.BackColor = System.Drawing.SystemColors.ControlText
        Me.lblclave.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblclave.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblclave.Location = New System.Drawing.Point(169, 55)
        Me.lblclave.Name = "lblclave"
        Me.lblclave.Size = New System.Drawing.Size(54, 19)
        Me.lblclave.TabIndex = 32
        Me.lblclave.Text = "Clave"
        '
        'btnsalir
        '
        Me.btnsalir.BackgroundImage = CType(resources.GetObject("btnsalir.BackgroundImage"), System.Drawing.Image)
        Me.btnsalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnsalir.Location = New System.Drawing.Point(1023, 574)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(43, 43)
        Me.btnsalir.TabIndex = 47
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
        'ErrorProvider6
        '
        Me.ErrorProvider6.ContainerControl = Me
        '
        'ErrorProvider7
        '
        Me.ErrorProvider7.ContainerControl = Me
        '
        'ErrorProvider8
        '
        Me.ErrorProvider8.ContainerControl = Me
        '
        'ALTAS_DE_PRODUCTOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1367, 639)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnsalir)
        Me.Name = "ALTAS_DE_PRODUCTOS"
        Me.Text = "ALTAS_DE_PRODUCTOS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnguardar As System.Windows.Forms.Button
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtclave As System.Windows.Forms.TextBox
    Friend WithEvents txtfecha As System.Windows.Forms.TextBox
    Friend WithEvents txtnombreprove As System.Windows.Forms.TextBox
    Friend WithEvents txtimporte As System.Windows.Forms.TextBox
    Friend WithEvents txtcantidad As System.Windows.Forms.TextBox
    Friend WithEvents txtprecio As System.Windows.Forms.TextBox
    Friend WithEvents txtdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents lblnombreprove As System.Windows.Forms.Label
    Friend WithEvents lblfecha As System.Windows.Forms.Label
    Friend WithEvents lblimporte As System.Windows.Forms.Label
    Friend WithEvents lblcantidad As System.Windows.Forms.Label
    Friend WithEvents lblprecio As System.Windows.Forms.Label
    Friend WithEvents lblnombre As System.Windows.Forms.Label
    Friend WithEvents lblclave As System.Windows.Forms.Label
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents lbldescripcion As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErrorProvider2 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErrorProvider3 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErrorProvider4 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErrorProvider5 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErrorProvider6 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErrorProvider7 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErrorProvider8 As System.Windows.Forms.ErrorProvider
End Class
