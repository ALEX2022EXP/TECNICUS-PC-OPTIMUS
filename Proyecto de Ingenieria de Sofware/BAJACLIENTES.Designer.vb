<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BAJACLIENTES
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BAJACLIENTES))
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtapellidos = New System.Windows.Forms.TextBox()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.txtcosto = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.CLIENTEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BD_TECNICUS_PC_OPTIMUSDataSet = New Proyecto_de_Ingenieria_de_Sofware.BD_TECNICUS_PC_OPTIMUSDataSet()
        Me.CLIENTETableAdapter = New Proyecto_de_Ingenieria_de_Sofware.BD_TECNICUS_PC_OPTIMUSDataSetTableAdapters.CLIENTETableAdapter()
        Me.txtcos = New System.Windows.Forms.TextBox()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.lblcosto = New System.Windows.Forms.Label()
        Me.lbldescripcion = New System.Windows.Forms.Label()
        Me.lbldireccion = New System.Windows.Forms.Label()
        Me.lblapellidos = New System.Windows.Forms.Label()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.lblclave = New System.Windows.Forms.Label()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnconsultar = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.CLIENTEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BD_TECNICUS_PC_OPTIMUSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtdescripcion
        '
        Me.txtdescripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtdescripcion.Font = New System.Drawing.Font("Broadway", 12.0!, System.Drawing.FontStyle.Italic)
        Me.txtdescripcion.Location = New System.Drawing.Point(569, 408)
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(490, 26)
        Me.txtdescripcion.TabIndex = 61
        Me.txtdescripcion.Visible = False
        '
        'txtnombre
        '
        Me.txtnombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtnombre.Font = New System.Drawing.Font("Broadway", 12.0!, System.Drawing.FontStyle.Italic)
        Me.txtnombre.Location = New System.Drawing.Point(431, 299)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(336, 26)
        Me.txtnombre.TabIndex = 55
        Me.txtnombre.Visible = False
        '
        'txtapellidos
        '
        Me.txtapellidos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtapellidos.Font = New System.Drawing.Font("Broadway", 12.0!, System.Drawing.FontStyle.Italic)
        Me.txtapellidos.Location = New System.Drawing.Point(431, 331)
        Me.txtapellidos.Name = "txtapellidos"
        Me.txtapellidos.Size = New System.Drawing.Size(336, 26)
        Me.txtapellidos.TabIndex = 54
        Me.txtapellidos.Visible = False
        '
        'txtdireccion
        '
        Me.txtdireccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtdireccion.Font = New System.Drawing.Font("Broadway", 12.0!, System.Drawing.FontStyle.Italic)
        Me.txtdireccion.Location = New System.Drawing.Point(431, 366)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(336, 26)
        Me.txtdireccion.TabIndex = 53
        Me.txtdireccion.Visible = False
        '
        'txtid
        '
        Me.txtid.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtid.Font = New System.Drawing.Font("Broadway", 12.0!, System.Drawing.FontStyle.Italic)
        Me.txtid.Location = New System.Drawing.Point(431, 263)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(78, 26)
        Me.txtid.TabIndex = 52
        '
        'txtcosto
        '
        Me.txtcosto.BackgroundImage = CType(resources.GetObject("txtcosto.BackgroundImage"), System.Drawing.Image)
        Me.txtcosto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.txtcosto.Location = New System.Drawing.Point(2, 3)
        Me.txtcosto.Name = "txtcosto"
        Me.txtcosto.Size = New System.Drawing.Size(1371, 158)
        Me.txtcosto.TabIndex = 65
        Me.txtcosto.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnsalir
        '
        Me.btnsalir.BackgroundImage = CType(resources.GetObject("btnsalir.BackgroundImage"), System.Drawing.Image)
        Me.btnsalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnsalir.Location = New System.Drawing.Point(1022, 496)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(37, 35)
        Me.btnsalir.TabIndex = 66
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'CLIENTEBindingSource
        '
        Me.CLIENTEBindingSource.DataMember = "CLIENTE"
        Me.CLIENTEBindingSource.DataSource = Me.BD_TECNICUS_PC_OPTIMUSDataSet
        '
        'BD_TECNICUS_PC_OPTIMUSDataSet
        '
        Me.BD_TECNICUS_PC_OPTIMUSDataSet.DataSetName = "BD_TECNICUS_PC_OPTIMUSDataSet"
        Me.BD_TECNICUS_PC_OPTIMUSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CLIENTETableAdapter
        '
        Me.CLIENTETableAdapter.ClearBeforeFill = True
        '
        'txtcos
        '
        Me.txtcos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtcos.Font = New System.Drawing.Font("Broadway", 12.0!, System.Drawing.FontStyle.Italic)
        Me.txtcos.Location = New System.Drawing.Point(569, 440)
        Me.txtcos.Name = "txtcos"
        Me.txtcos.Size = New System.Drawing.Size(125, 26)
        Me.txtcos.TabIndex = 69
        Me.txtcos.Visible = False
        '
        'btneliminar
        '
        Me.btneliminar.BackgroundImage = CType(resources.GetObject("btneliminar.BackgroundImage"), System.Drawing.Image)
        Me.btneliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btneliminar.Location = New System.Drawing.Point(458, 488)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(51, 50)
        Me.btneliminar.TabIndex = 70
        Me.btneliminar.UseVisualStyleBackColor = True
        Me.btneliminar.Visible = False
        '
        'lblcosto
        '
        Me.lblcosto.AutoSize = True
        Me.lblcosto.BackColor = System.Drawing.Color.MediumOrchid
        Me.lblcosto.Font = New System.Drawing.Font("Broadway", 12.0!, System.Drawing.FontStyle.Italic)
        Me.lblcosto.Location = New System.Drawing.Point(190, 443)
        Me.lblcosto.Name = "lblcosto"
        Me.lblcosto.Size = New System.Drawing.Size(236, 19)
        Me.lblcosto.TabIndex = 86
        Me.lblcosto.Text = "COSTO DE LA REPARACION"
        Me.lblcosto.Visible = False
        '
        'lbldescripcion
        '
        Me.lbldescripcion.AutoSize = True
        Me.lbldescripcion.BackColor = System.Drawing.Color.MediumOrchid
        Me.lbldescripcion.Font = New System.Drawing.Font("Broadway", 12.0!, System.Drawing.FontStyle.Italic)
        Me.lbldescripcion.Location = New System.Drawing.Point(190, 411)
        Me.lbldescripcion.Name = "lbldescripcion"
        Me.lbldescripcion.Size = New System.Drawing.Size(297, 19)
        Me.lbldescripcion.TabIndex = 85
        Me.lbldescripcion.Text = "DESCRIPCION DE LA REPARACION"
        Me.lbldescripcion.Visible = False
        '
        'lbldireccion
        '
        Me.lbldireccion.AutoSize = True
        Me.lbldireccion.BackColor = System.Drawing.Color.MediumOrchid
        Me.lbldireccion.Font = New System.Drawing.Font("Broadway", 12.0!, System.Drawing.FontStyle.Italic)
        Me.lbldireccion.Location = New System.Drawing.Point(191, 373)
        Me.lbldireccion.Name = "lbldireccion"
        Me.lbldireccion.Size = New System.Drawing.Size(104, 19)
        Me.lbldireccion.TabIndex = 84
        Me.lbldireccion.Text = "DIRECCION"
        Me.lbldireccion.Visible = False
        '
        'lblapellidos
        '
        Me.lblapellidos.AutoSize = True
        Me.lblapellidos.BackColor = System.Drawing.Color.MediumOrchid
        Me.lblapellidos.Font = New System.Drawing.Font("Broadway", 12.0!, System.Drawing.FontStyle.Italic)
        Me.lblapellidos.Location = New System.Drawing.Point(191, 338)
        Me.lblapellidos.Name = "lblapellidos"
        Me.lblapellidos.Size = New System.Drawing.Size(107, 19)
        Me.lblapellidos.TabIndex = 83
        Me.lblapellidos.Text = "APELLIDOS"
        Me.lblapellidos.Visible = False
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.BackColor = System.Drawing.Color.MediumOrchid
        Me.lblnombre.Font = New System.Drawing.Font("Broadway", 12.0!, System.Drawing.FontStyle.Italic)
        Me.lblnombre.Location = New System.Drawing.Point(192, 306)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(82, 19)
        Me.lblnombre.TabIndex = 82
        Me.lblnombre.Text = "NOMBRE"
        Me.lblnombre.Visible = False
        '
        'lblclave
        '
        Me.lblclave.AutoSize = True
        Me.lblclave.BackColor = System.Drawing.Color.MediumOrchid
        Me.lblclave.Font = New System.Drawing.Font("Broadway", 12.0!, System.Drawing.FontStyle.Italic)
        Me.lblclave.Location = New System.Drawing.Point(190, 263)
        Me.lblclave.Name = "lblclave"
        Me.lblclave.Size = New System.Drawing.Size(67, 19)
        Me.lblclave.TabIndex = 81
        Me.lblclave.Text = "CLAVE"
        '
        'btncancelar
        '
        Me.btncancelar.BackgroundImage = CType(resources.GetObject("btncancelar.BackgroundImage"), System.Drawing.Image)
        Me.btncancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btncancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btncancelar.Location = New System.Drawing.Point(549, 488)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(49, 48)
        Me.btncancelar.TabIndex = 88
        Me.btncancelar.UseVisualStyleBackColor = True
        Me.btncancelar.Visible = False
        '
        'btnconsultar
        '
        Me.btnconsultar.BackgroundImage = CType(resources.GetObject("btnconsultar.BackgroundImage"), System.Drawing.Image)
        Me.btnconsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnconsultar.Location = New System.Drawing.Point(640, 253)
        Me.btnconsultar.Name = "btnconsultar"
        Me.btnconsultar.Size = New System.Drawing.Size(40, 40)
        Me.btnconsultar.TabIndex = 89
        Me.btnconsultar.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'BAJACLIENTES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1121, 610)
        Me.Controls.Add(Me.btnconsultar)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.lblcosto)
        Me.Controls.Add(Me.lbldescripcion)
        Me.Controls.Add(Me.lbldireccion)
        Me.Controls.Add(Me.lblapellidos)
        Me.Controls.Add(Me.lblnombre)
        Me.Controls.Add(Me.lblclave)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.txtcos)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.txtcosto)
        Me.Controls.Add(Me.txtdescripcion)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.txtapellidos)
        Me.Controls.Add(Me.txtdireccion)
        Me.Controls.Add(Me.txtid)
        Me.Name = "BAJACLIENTES"
        Me.Text = "CLIENTES"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.CLIENTEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BD_TECNICUS_PC_OPTIMUSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents txtapellidos As System.Windows.Forms.TextBox
    Friend WithEvents txtdireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents txtcosto As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents BD_TECNICUS_PC_OPTIMUSDataSet As Proyecto_de_Ingenieria_de_Sofware.BD_TECNICUS_PC_OPTIMUSDataSet
    Friend WithEvents CLIENTEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CLIENTETableAdapter As Proyecto_de_Ingenieria_de_Sofware.BD_TECNICUS_PC_OPTIMUSDataSetTableAdapters.CLIENTETableAdapter
    Friend WithEvents txtcos As System.Windows.Forms.TextBox
    Friend WithEvents btneliminar As System.Windows.Forms.Button
    Friend WithEvents lblcosto As System.Windows.Forms.Label
    Friend WithEvents lbldescripcion As System.Windows.Forms.Label
    Friend WithEvents lbldireccion As System.Windows.Forms.Label
    Friend WithEvents lblapellidos As System.Windows.Forms.Label
    Friend WithEvents lblnombre As System.Windows.Forms.Label
    Friend WithEvents lblclave As System.Windows.Forms.Label
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents btnconsultar As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
